using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using RoboSharp;
using Windows.Foundation;
using System.Threading;
using System.Reflection;
using Xabe.FFmpeg;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using System.Data;
using Dasync.Collections;
using System.Text.RegularExpressions;


namespace DiskConverter
{


    public partial class windowcase : Form
    {
        int numberOfFiles = 0;
        int fileCounter = 0;
        string ffmpeg = "C:\\ProgramData\\chocolatey\\lib\\ffmpeg\\tools\\ffmpeg\\bin\\";
        string localffmpeg = Environment.GetEnvironmentVariable("ffmpegpath",EnvironmentVariableTarget.User) ?? "-";
        string source;
        string target;
        public static bool kill = false;
        public static bool onlymovs = false;
        public static bool lowmovement = false;
        long total = 1;
        long nonmovtotal = 0;
        long donebytes = 0;
        public CancellationTokenSource cancelsource;
        



        List<string> movlist = new();
        public windowcase()
        {
            InitializeComponent();
            
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Text = "EWISE Disk converter";
            cancelsource = new CancellationTokenSource();
            if (localffmpeg != "-" && localffmpeg != null && localffmpeg != "") {
                FFmpeg.SetExecutablesPath(localffmpeg);
                if (!File.Exists(Path.Join(localffmpeg, "ffmpeg.exe")))
                {
                    MessageBox.Show("No ffmpeg found, re-install or set\ncorrect path with ffmpeg button before continuing.");
                };
            } else { 


            //FFmpegDownloader.GetLatestVersion(FFmpegVersion ffmpegVersion)
            FFmpeg.SetExecutablesPath("C:\\ProgramData\\chocolatey\\lib\\ffmpeg\\tools\\ffmpeg\\bin");
            };
            new Task(async() => { Thread.Sleep(2300);
                try { pictureBox3.BeginInvoke((MethodInvoker)delegate () { pictureBox3.Visible = false; }); } catch { };

            }).Start();
        }

        
        static bool changeLabel(Label requestedLabel, string text)
        {
            if (requestedLabel.InvokeRequired)
            {
                try { requestedLabel.BeginInvoke((MethodInvoker)delegate () { requestedLabel.Text = text; requestedLabel.Visible = true; }); } catch { };
            }
            else
            {
                requestedLabel.Text = text;
            }
            return true;
        }

        static void changeProgress(ProgressBar requestedBar, int value, bool visswitch, bool showhide)
        {
            
            if (requestedBar.InvokeRequired)
            {
                requestedBar.BeginInvoke((MethodInvoker)delegate () { if (visswitch) { requestedBar.Visible = showhide; } else {
                        if (value > 100) { requestedBar.Value = 100; } else if (value < 0) { requestedBar.Value = 0; } else requestedBar.Value = (int)value; }; });
            }
            else
            {
                requestedBar.Value = value;
            }
        }


        
        private void imputbutton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog()) {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))

                {
                    source = Path.TrimEndingDirectorySeparator(Path.GetFullPath(fbd.SelectedPath));
                    source = source +Path.DirectorySeparatorChar;
                    source.Replace("\\\\", "\\");
                    inputlabel.Text = source;
                    if (target != null) { convertbutton.Visible = true; };
                    string regexstr = "/20[1-9][1-9][aA-zZ]*/";
                    if (new Regex(regexstr).Match(fbd.SelectedPath).Success) { string schijf = new Regex(regexstr).Match(fbd.SelectedPath).Value;
                        schijfgiant.Text = schijf;
                    };
                }
            }
        }

        private void targetbutton_Click(object sender, EventArgs e)
        {
            
            fileCounter = 0;
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))

                {
                    target = Path.GetFullPath(fbd.SelectedPath).TrimEnd(Path.DirectorySeparatorChar) + Path.DirectorySeparatorChar; 
                    
                    
                    targetlabel.Text = target;
                    if (source != null) { convertbutton.Visible = true; };
                    string regexstr = "20[1-9][1-9][aA-zZ]";
                    if (new Regex(regexstr).Match(fbd.SelectedPath).Success)
                    {
                        string schijf = new Regex(regexstr).Match(fbd.SelectedPath).Value;
                        schijfgiant.Text = schijf;
                    };
                }
            }
        }


        private void copyprogresHandler(object sender, CopyProgressEventArgs args) { 
            changeLabel(currentproglabel, Math.Round(args.CurrentFileProgress,0).ToString()+"%");  
        }

        void currentCopyHanler(object sender, FileProcessedEventArgs args)
        {
            changeLabel(currentFil,"("+fileCounter.ToString()+"/"+numberOfFiles.ToString()+") "+args.ProcessedFile.Name); 
            donebytes += args.ProcessedFile.Size;
            fileCounter++;
            double totalprocent = ((double)donebytes / (double)total) * 100;
            changeLabel(totalproglabel, totalprocent.ToString("0.00", new System.Globalization.CultureInfo("en-US", false)) + "%");
            changeProgress(totalBar, (int)totalprocent,false,false);


        }

        private void copyFileFinishHandler(object sender, RoboCommandCompletedEventArgs args)
        {
            
            changeLabel(currentFil, "Converting MOV files...");
        }


        private async void convertbutton_Click(object sender, EventArgs e)
        {
            
            Cursor.Current = Cursors.WaitCursor;
            currentFil.Text = "Calculating...";
            etawordlabel.Visible = true;
            speedlabel.Visible = true;
            speedwordlabel.Visible = true;
            inputbutton.Visible = false;
            convertbutton.Visible = false;
            targetlabel.Visible = true;
            totaalwordlabel.Visible = true;
            targetbutton.Visible = false;
            currentFil.Visible = true;
#pragma warning disable IDE0090 // Use 'new(...)'
            Semaphore semaphoreObject = new Semaphore(initialCount: 0, maximumCount: 5);
#pragma warning restore IDE0090 // Use 'new(...)'
            changeLabel(currentFil, "Copying folders and small files...");
            long mp4bytes = 0;
            long[] clipbytes = new long[5] {0,0,0,0,0};
            double[] speedsarray = new double[5] { 0.0, 0.0, 0.0, 0.0, 0.0 };

            totalBar.Visible = true;
            totalproglabel.Visible = true;
        
            
            List<string> bigfiles = new List<string>(Directory.GetFiles(source, "*.*",SearchOption.AllDirectories).SkipWhile(name=> 
                Path.GetExtension(name)==".pek" ||
                Path.GetExtension(name) == ".BIN" ||
                Path.GetExtension(name) == ".pek" 
                ).ToArray());
            Thread.Sleep(300);
            await foreach (string file in bigfiles) { total += new FileInfo(file).Length; numberOfFiles++;
                if (Path.GetExtension(file) == ".mp4") { mp4bytes+= new FileInfo(file).Length; }; 
                if (Path.GetExtension(file) != ".mov") { nonmovtotal += new FileInfo(file).Length; }; 
            };
       

            Cursor.Current = Cursors.Default;
            changeLabel(currentFil,"Copying non-video files...");
           

            CopyOptions copt = new();
            copt.Source = source;
            copt.Destination = target;
            
            RoboCommand roboCMD  = new();
            roboCMD.CopyOptions = copt;
            roboCMD.CopyOptions.CopySubdirectoriesIncludingEmpty = true;
            roboCMD.SelectionOptions.ExcludeFiles = "*.mov *.pek *RECYCLE.BIN";
            roboCMD.SelectionOptions.ExcludeAttributes = "S H T";
            roboCMD.OnFileProcessed += currentCopyHanler;
            roboCMD.OnCopyProgressChanged += copyprogresHandler;
            roboCMD.OnCommandCompleted += copyFileFinishHandler;
            Application.UseWaitCursor = false;
            Cursor.Current = Cursors.Default;

            if (!onlymovs)
            {
                await roboCMD.Start();
            }

            DateTime startTime = DateTime.Now;


            ProgressBar[] progressbars = {
                progressBar1,
                progressBar2,
                progressBar3,
                progressBar4,
                progressBar5
            };

            Semaphore semafoor = new Semaphore(0, 1);

            
            etalabel.Visible = true;
            DateTime _starttime = DateTime.Now;
            donebytes = nonmovtotal;

            changeLabel(currentFil,"Converting...");
            changeLabel(currentproglabel," ");

            List<string> movque = new List<string>(Directory.GetFiles(source, "*.mov", SearchOption.AllDirectories).Where(name => !name.Contains("_Pling", StringComparison.OrdinalIgnoreCase) && !name.Contains("Pool", StringComparison.OrdinalIgnoreCase) && !name.Contains(" kort", StringComparison.OrdinalIgnoreCase)).ToArray());
            
            
            
            var bag = new System.Collections.Concurrent.ConcurrentBag<string>(movque);

            await bag.ParallelForEachAsync(async item =>
           {



           int mytrem = -1;
           foreach (ProgressBar pb in progressbars) { Thread.Sleep(10); mytrem++; if (pb.Visible == false) { changeProgress(pb, 0, true, true); break; }; };


           Label filelabel = file1label;
           Label proglabel = proglabel1;

           ProgressBar progressbarnow = progressBar1;
           switch (mytrem) {

               case 0: filelabel = file1label; progressbarnow = progressBar1; proglabel = proglabel1; break;
               case 1: filelabel = file2label; progressbarnow = progressBar2; proglabel = proglabel2; break;
               case 2: filelabel = file3label; progressbarnow = progressBar3; proglabel = proglabel3; break;
               case 3: filelabel = file4label; progressbarnow = progressBar4; proglabel = proglabel4; break;
               case 4: filelabel = file5label; progressbarnow = progressBar5; proglabel = proglabel5; break;
           };

           changeLabel(filelabel, item.Length > 65 ? item.Substring(item.Length - 65) : item);
           changeProgress(progressbarnow, 0, true, true);

           IMediaInfo mediaInfo = await FFmpeg.GetMediaInfo(item);

           if (File.Exists(item.Replace(Path.GetFullPath(source), Path.GetFullPath(target))))
           {
               var check = await FFmpeg.GetMediaInfo(item);
               if (check != null)
               {

                       changeProgress(progressbarnow,progressbarnow.Value, true, true);
                   donebytes = donebytes + mediaInfo.Size;
                   return;
               }

           };

           IStream videoStream = (IStream)mediaInfo.VideoStreams.FirstOrDefault()?.SetCodec(VideoCodec.hevc);

           IStream audioStream = (IStream)mediaInfo.AudioStreams.FirstOrDefault()?.SetCodec(AudioCodec.aac).SetChannels(2);

           IConversion conversion = convertMov(item, audioStream, videoStream);

           string output = item.Replace(Path.GetFullPath(source), Path.GetFullPath(target));
               //-hwaccel_device auto -hwaccel cuda
               //string arguments = $"-i \"{item}\" -c:v h264 -pix_fmt yuv422p -strict experimental -preset ultrafast -crf 23 -aac_coder fast -coder 0 -tune fastdecode -g 10 -refs 1 -threads 6 -ac 2 -c:a aac -map 0 \"{output}\"";
               string arguments = $"-i \"{item}\" -c:v h264 -pix_fmt yuv422p -strict experimental -b:v 8M -slices 3 -preset ultrafast -crf 23 -aac_coder fast -tune fastdecode  -threads 6 -ac 2 -c:a aac -map 0 -y \"{output}\"";
               string[] argumentslist = {

                   "-hwaccel_device auto",
                   "-hwaccel cuda",$"-i \"{item}\"",
                   "-c:v h264","-pix_fmt yuv422p",
                   "-strict experimental",
                   "-preset ultrafast",
                   "-crf 23",
                   "-aac_coder fast",
                   "-tune fastdecode",
                   "-b:v 8M",
                   "-bufsize 500M",
                   "-threads 3",
                   "-g 50",
                   "-slices 3",
                   "-ac 1",
                   "-c:a aac -map 0",
                   "-maxrate 20M",
                   "-y",
                   $"{output}\""};

               //DateTime procstarttime = DateTime.Now;

               //var p = new Process();
               //p.StartInfo.UseShellExecute = false;
               //p.StartInfo.RedirectStandardOutput = true;
               //string eOut = null;
               //p.StartInfo.RedirectStandardError = true;
               //p.ErrorDataReceived += new DataReceivedEventHandler((sender, e) =>
               //{ eOut += e.Data; });
               //p.StartInfo.FileName = "ffmpeg.exe";
               //foreach (string argument in argumentslist) { p.StartInfo.ArgumentList.Add(argument); };
               //p.OutputDataReceived += (object sender, DataReceivedEventArgs e) => { Debug.WriteLine(e.Data); Debug.WriteLine("dedebug optie"); };
               //p.Start();

               //// To avoid deadlocks, use an asynchronous read operation on at least one of the streams.  
               //p.BeginErrorReadLine();
               //string readOutput = p.StandardOutput.ReadToEnd();
               //p.WaitForExit();

               //MessageBox.Show(readOutput);
               conversion.OnProgress += (sender, args) =>
               {
                   double passedseconds = Math.Abs((DateTime.Now-startTime).TotalSeconds);
                   speedsarray[mytrem] = (double)(passedseconds / args.TotalLength.TotalSeconds)/ (double)(args.Duration.TotalSeconds / args.TotalLength.TotalSeconds);
                   if (mytrem == 1 || mytrem == 3) { changeLabel(speedlabel, Math.Round(speedsarray.Aggregate((a, b) => (a + b)), 2).ToString() + "×"); };
                   var percent = (double)Math.Round(args.Duration.TotalSeconds / args.TotalLength.TotalSeconds, 2) * 100;
                   clipbytes[mytrem] = (long)(percent * mediaInfo.Size);
                   changeLabel(proglabel, args.Percent.ToString() + "%");
                   changeProgress(progressbarnow, (int)Math.Round(percent, 0), false, false);
                   double tempprog = (double)((donebytes + (long)clipbytes.Aggregate((a, b) => a + b)) / (double)total);
                   if (tempprog > totalBar.Value)
                   {
                       changeLabel(totalproglabel, tempprog.ToString("0.00", new System.Globalization.CultureInfo("en-US", false)) + "%");
                       changeProgress(totalBar, (int)tempprog, false, false);
                   };



               };

               IConversionResult conversionResult = await conversion.Start(arguments, cancelsource.Token);

               bag.Add(item);
               


                donebytes = donebytes + mediaInfo.Size;
                double totalprocent = ((double)donebytes / (double)total) * 100;
                double mp4totalprocent = ((double)donebytes-mp4bytes / (double)total- mp4bytes) * 100;
                //TimeSpan estimated = TimeSpan.FromSeconds((double)(100.00 / mp4totalprocent) * (double)conversionResult.EndTime.Subtract(conversionResult.StartTime).TotalSeconds);
                long bytespersecond = (long)mediaInfo.Size /(long)DateTime.Now.Subtract(startTime).TotalSeconds;
                TimeSpan estimated = TimeSpan.FromSeconds(((long)(total - donebytes - mp4bytes) / bytespersecond)/3);
                if (estimated.TotalSeconds > 0)
                {
                    changeLabel(etalabel, (estimated.TotalHours>0) ? Math.Floor(estimated.TotalHours) + " uur, " + estimated.Minutes + " minuten resterend." : " Ongeveer "+ estimated.Minutes + " minuten resterend.");
                };
                changeLabel(totalproglabel, totalprocent.ToString("0.00", new System.Globalization.CultureInfo("en-US", false)) + "%");
                changeProgress(totalBar, (int)totalprocent, false, false);

                speedsarray[mytrem] = 0;
                changeProgress(progressbarnow, 0, true, false);
                changeProgress(progressbars[mytrem], 0, true, false);


            }, maxDegreeOfParallelism: 5);
            var count = bag.Count;

            donebutton.Visible = true;
            
            changeProgress(totalBar, 100,false,false);
            changeLabel(currentFil, "Klaar.");
            MessageBox.Show("Schijf converteren is klaar");

        }




        IConversion convertMov(string vid, IStream audioStream, IStream videoStream) {

            // return FFmpeg.Conversions(vid, vid.Replace(Path.GetFullPath(source), Path.GetFullPath(target)));



            return FFmpeg.Conversions.New()
                
                
                .AddStream(audioStream, videoStream)
                .SetPriority(ProcessPriorityClass.BelowNormal)
                .SetPixelFormat(PixelFormat.yuv422p)
                .AddParameter("-tune fastdecode")
                .SetPreset(ConversionPreset.VeryFast)
                .AddParameter("-g 10 -c:v h264 -ac 2 ")
                .AddParameter("-crf 24 -threads 5")
                .AddParameter(" -hwaccel_device auto -hwaccel cuda", ParameterPosition.PreInput)
                .SetOutputFormat(Format.mov)
                .SetOutput(vid.Replace(Path.GetFullPath(source), Path.GetFullPath(target)));



        }

       

        
        private void donebutton_Click(object sender, EventArgs e)
        {

            cancelsource.Cancel();
            if (kill) {
                
                Process.Start("cmd.exe", "/C TASKKILL /IM ffmpeg.exe /F");
                
            };
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))

                {
                    string newffmpegpath = Path.GetFullPath(fbd.SelectedPath).TrimEnd(Path.DirectorySeparatorChar);
                    FFmpeg.SetExecutablesPath(newffmpegpath);
                    try { Environment.SetEnvironmentVariable("ffmpegpath", newffmpegpath, EnvironmentVariableTarget.User); } catch { };
                    if (!File.Exists(Path.Join(newffmpegpath, "ffmpeg.exe")))
                    {
                        MessageBox.Show("No ffmpeg found, re-install or set\ncorrect path with ffmpeg button before continuing.");
                    }
                    else { MessageBox.Show("ffMpeg OK!"); };
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            kill = !kill;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            onlymovs = !onlymovs;
        }

       

        private void targetlabel_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @targetlabel.Text);
        }

        private void convertbutton_MouseDown(object sender, MouseEventArgs e)
        {
            Application.UseWaitCursor = true;
            Cursor.Current = Cursors.Default;
        }
    }
}

