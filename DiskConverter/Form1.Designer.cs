﻿namespace DiskConverter
{
    partial class windowcase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windowcase));
            this.inputbutton = new System.Windows.Forms.Button();
            this.targetbutton = new System.Windows.Forms.Button();
            this.inputlabel = new System.Windows.Forms.Label();
            this.targetlabel = new System.Windows.Forms.Label();
            this.convertbutton = new System.Windows.Forms.Button();
            this.donebutton = new System.Windows.Forms.Button();
            this.file1label = new System.Windows.Forms.Label();
            this.file2label = new System.Windows.Forms.Label();
            this.file3label = new System.Windows.Forms.Label();
            this.file4label = new System.Windows.Forms.Label();
            this.file5label = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.proglabel1 = new System.Windows.Forms.Label();
            this.proglabel2 = new System.Windows.Forms.Label();
            this.proglabel3 = new System.Windows.Forms.Label();
            this.proglabel4 = new System.Windows.Forms.Label();
            this.proglabel5 = new System.Windows.Forms.Label();
            this.totalBar = new System.Windows.Forms.ProgressBar();
            this.totalproglabel = new System.Windows.Forms.Label();
            this.currentFil = new System.Windows.Forms.Label();
            this.currentproglabel = new System.Windows.Forms.Label();
            this.totaalwordlabel = new System.Windows.Forms.Label();
            this.etawordlabel = new System.Windows.Forms.Label();
            this.etalabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.schijfgiant = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Fromlabel = new System.Windows.Forms.Label();
            this.Tolabel = new System.Windows.Forms.Label();
            this.speedlabel = new System.Windows.Forms.Label();
            this.speedwordlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // inputbutton
            // 
            this.inputbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputbutton.Location = new System.Drawing.Point(100, 167);
            this.inputbutton.Name = "inputbutton";
            this.inputbutton.Size = new System.Drawing.Size(143, 38);
            this.inputbutton.TabIndex = 0;
            this.inputbutton.Text = "input folder";
            this.inputbutton.UseVisualStyleBackColor = true;
            this.inputbutton.Click += new System.EventHandler(this.imputbutton_Click);
            // 
            // targetbutton
            // 
            this.targetbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.targetbutton.Location = new System.Drawing.Point(396, 167);
            this.targetbutton.Name = "targetbutton";
            this.targetbutton.Size = new System.Drawing.Size(147, 38);
            this.targetbutton.TabIndex = 1;
            this.targetbutton.Text = "target folder";
            this.targetbutton.UseVisualStyleBackColor = true;
            this.targetbutton.Click += new System.EventHandler(this.targetbutton_Click);
            // 
            // inputlabel
            // 
            this.inputlabel.AutoSize = true;
            this.inputlabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputlabel.Location = new System.Drawing.Point(121, 19);
            this.inputlabel.Name = "inputlabel";
            this.inputlabel.Size = new System.Drawing.Size(12, 17);
            this.inputlabel.TabIndex = 2;
            this.inputlabel.Text = " ";
            this.inputlabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // targetlabel
            // 
            this.targetlabel.AutoSize = true;
            this.targetlabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.targetlabel.Location = new System.Drawing.Point(116, 44);
            this.targetlabel.Name = "targetlabel";
            this.targetlabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.targetlabel.Size = new System.Drawing.Size(12, 17);
            this.targetlabel.TabIndex = 3;
            this.targetlabel.Text = " ";
            this.targetlabel.Click += new System.EventHandler(this.targetlabel_Click);
            // 
            // convertbutton
            // 
            this.convertbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.convertbutton.Location = new System.Drawing.Point(212, 231);
            this.convertbutton.Name = "convertbutton";
            this.convertbutton.Size = new System.Drawing.Size(228, 29);
            this.convertbutton.TabIndex = 4;
            this.convertbutton.Text = "Convert!";
            this.convertbutton.UseVisualStyleBackColor = true;
            this.convertbutton.Visible = false;
            this.convertbutton.Click += new System.EventHandler(this.convertbutton_Click);
            this.convertbutton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.convertbutton_MouseDown);
            // 
            // donebutton
            // 
            this.donebutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.donebutton.Location = new System.Drawing.Point(660, 19);
            this.donebutton.Name = "donebutton";
            this.donebutton.Size = new System.Drawing.Size(146, 30);
            this.donebutton.TabIndex = 6;
            this.donebutton.Text = "Stop";
            this.donebutton.UseVisualStyleBackColor = true;
            this.donebutton.Click += new System.EventHandler(this.donebutton_Click);
            // 
            // file1label
            // 
            this.file1label.AutoSize = true;
            this.file1label.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.file1label.Location = new System.Drawing.Point(39, 268);
            this.file1label.Name = "file1label";
            this.file1label.Size = new System.Drawing.Size(0, 17);
            this.file1label.TabIndex = 8;
            // 
            // file2label
            // 
            this.file2label.AutoSize = true;
            this.file2label.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.file2label.Location = new System.Drawing.Point(39, 288);
            this.file2label.Name = "file2label";
            this.file2label.Size = new System.Drawing.Size(0, 17);
            this.file2label.TabIndex = 9;
            // 
            // file3label
            // 
            this.file3label.AutoSize = true;
            this.file3label.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.file3label.Location = new System.Drawing.Point(39, 308);
            this.file3label.Name = "file3label";
            this.file3label.Size = new System.Drawing.Size(0, 17);
            this.file3label.TabIndex = 10;
            // 
            // file4label
            // 
            this.file4label.AutoSize = true;
            this.file4label.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.file4label.Location = new System.Drawing.Point(39, 328);
            this.file4label.Name = "file4label";
            this.file4label.Size = new System.Drawing.Size(0, 17);
            this.file4label.TabIndex = 11;
            // 
            // file5label
            // 
            this.file5label.AutoSize = true;
            this.file5label.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.file5label.Location = new System.Drawing.Point(39, 348);
            this.file5label.Name = "file5label";
            this.file5label.Size = new System.Drawing.Size(0, 17);
            this.file5label.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(516, 268);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(125, 10);
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Visible = false;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(516, 288);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(125, 10);
            this.progressBar2.TabIndex = 14;
            this.progressBar2.Visible = false;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(516, 308);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(125, 10);
            this.progressBar3.TabIndex = 15;
            this.progressBar3.Visible = false;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(516, 328);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(125, 10);
            this.progressBar4.TabIndex = 16;
            this.progressBar4.Visible = false;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(516, 348);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(125, 10);
            this.progressBar5.TabIndex = 17;
            this.progressBar5.Visible = false;
            // 
            // proglabel1
            // 
            this.proglabel1.AutoSize = true;
            this.proglabel1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.proglabel1.Location = new System.Drawing.Point(647, 261);
            this.proglabel1.Name = "proglabel1";
            this.proglabel1.Size = new System.Drawing.Size(0, 17);
            this.proglabel1.TabIndex = 18;
            // 
            // proglabel2
            // 
            this.proglabel2.AutoSize = true;
            this.proglabel2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.proglabel2.Location = new System.Drawing.Point(647, 281);
            this.proglabel2.Name = "proglabel2";
            this.proglabel2.Size = new System.Drawing.Size(0, 17);
            this.proglabel2.TabIndex = 19;
            this.proglabel2.Click += new System.EventHandler(this.label1_Click);
            // 
            // proglabel3
            // 
            this.proglabel3.AutoSize = true;
            this.proglabel3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.proglabel3.Location = new System.Drawing.Point(647, 301);
            this.proglabel3.Name = "proglabel3";
            this.proglabel3.Size = new System.Drawing.Size(0, 17);
            this.proglabel3.TabIndex = 20;
            // 
            // proglabel4
            // 
            this.proglabel4.AutoSize = true;
            this.proglabel4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.proglabel4.Location = new System.Drawing.Point(647, 321);
            this.proglabel4.Name = "proglabel4";
            this.proglabel4.Size = new System.Drawing.Size(0, 17);
            this.proglabel4.TabIndex = 21;
            // 
            // proglabel5
            // 
            this.proglabel5.AutoSize = true;
            this.proglabel5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.proglabel5.Location = new System.Drawing.Point(647, 341);
            this.proglabel5.Name = "proglabel5";
            this.proglabel5.Size = new System.Drawing.Size(0, 17);
            this.proglabel5.TabIndex = 22;
            // 
            // totalBar
            // 
            this.totalBar.Location = new System.Drawing.Point(55, 172);
            this.totalBar.Name = "totalBar";
            this.totalBar.Size = new System.Drawing.Size(622, 29);
            this.totalBar.TabIndex = 23;
            this.totalBar.Visible = false;
            // 
            // totalproglabel
            // 
            this.totalproglabel.AutoSize = true;
            this.totalproglabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalproglabel.Location = new System.Drawing.Point(325, 208);
            this.totalproglabel.Name = "totalproglabel";
            this.totalproglabel.Size = new System.Drawing.Size(0, 20);
            this.totalproglabel.TabIndex = 24;
            // 
            // currentFil
            // 
            this.currentFil.AutoSize = true;
            this.currentFil.Location = new System.Drawing.Point(73, 92);
            this.currentFil.Name = "currentFil";
            this.currentFil.Size = new System.Drawing.Size(0, 20);
            this.currentFil.TabIndex = 25;
            // 
            // currentproglabel
            // 
            this.currentproglabel.AutoSize = true;
            this.currentproglabel.Location = new System.Drawing.Point(73, 119);
            this.currentproglabel.Name = "currentproglabel";
            this.currentproglabel.Size = new System.Drawing.Size(0, 20);
            this.currentproglabel.TabIndex = 26;
            // 
            // totaalwordlabel
            // 
            this.totaalwordlabel.AutoSize = true;
            this.totaalwordlabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totaalwordlabel.Location = new System.Drawing.Point(325, 152);
            this.totaalwordlabel.Name = "totaalwordlabel";
            this.totaalwordlabel.Size = new System.Drawing.Size(46, 17);
            this.totaalwordlabel.TabIndex = 28;
            this.totaalwordlabel.Text = "Totaal";
            this.totaalwordlabel.Visible = false;
            // 
            // etawordlabel
            // 
            this.etawordlabel.AutoSize = true;
            this.etawordlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.etawordlabel.Location = new System.Drawing.Point(58, 394);
            this.etawordlabel.Name = "etawordlabel";
            this.etawordlabel.Size = new System.Drawing.Size(71, 17);
            this.etawordlabel.TabIndex = 29;
            this.etawordlabel.Text = "Estimated:";
            this.etawordlabel.Visible = false;
            // 
            // etalabel
            // 
            this.etalabel.AutoSize = true;
            this.etalabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.etalabel.Location = new System.Drawing.Point(135, 393);
            this.etalabel.Name = "etalabel";
            this.etalabel.Size = new System.Drawing.Size(74, 17);
            this.etalabel.TabIndex = 30;
            this.etalabel.Text = "estimating...";
            this.etalabel.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(723, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 28);
            this.button1.TabIndex = 31;
            this.button1.Text = "ffmpeg";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(681, 118);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 21);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "kill processes";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.Location = new System.Drawing.Point(681, 93);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 21);
            this.checkBox2.TabIndex = 33;
            this.checkBox2.Text = "MOVs only";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DiskConverter.Properties.Resources.prores_logo;
            this.pictureBox1.Location = new System.Drawing.Point(756, 380);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(760, 345);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(758, 436);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(68, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 38;
            this.pictureBox5.TabStop = false;
            // 
            // schijfgiant
            // 
            this.schijfgiant.AutoSize = true;
            this.schijfgiant.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.schijfgiant.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.schijfgiant.Location = new System.Drawing.Point(543, 404);
            this.schijfgiant.Name = "schijfgiant";
            this.schijfgiant.Size = new System.Drawing.Size(0, 62);
            this.schijfgiant.TabIndex = 39;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(848, 479);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // Fromlabel
            // 
            this.Fromlabel.AutoSize = true;
            this.Fromlabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Fromlabel.Location = new System.Drawing.Point(73, 19);
            this.Fromlabel.Name = "Fromlabel";
            this.Fromlabel.Size = new System.Drawing.Size(44, 17);
            this.Fromlabel.TabIndex = 41;
            this.Fromlabel.Text = "From:";
            // 
            // Tolabel
            // 
            this.Tolabel.AutoSize = true;
            this.Tolabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tolabel.Location = new System.Drawing.Point(73, 44);
            this.Tolabel.Name = "Tolabel";
            this.Tolabel.Size = new System.Drawing.Size(27, 17);
            this.Tolabel.TabIndex = 42;
            this.Tolabel.Text = "To:";
            // 
            // speedlabel
            // 
            this.speedlabel.AutoSize = true;
            this.speedlabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.speedlabel.Location = new System.Drawing.Point(416, 394);
            this.speedlabel.Name = "speedlabel";
            this.speedlabel.Size = new System.Drawing.Size(77, 17);
            this.speedlabel.TabIndex = 44;
            this.speedlabel.Text = "calculating...";
            this.speedlabel.Visible = false;
            // 
            // speedwordlabel
            // 
            this.speedwordlabel.AutoSize = true;
            this.speedwordlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.speedwordlabel.Location = new System.Drawing.Point(309, 394);
            this.speedwordlabel.Name = "speedwordlabel";
            this.speedwordlabel.Size = new System.Drawing.Size(101, 17);
            this.speedwordlabel.TabIndex = 43;
            this.speedwordlabel.Text = "Average speed:";
            this.speedwordlabel.Visible = false;
            // 
            // windowcase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(840, 476);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.speedlabel);
            this.Controls.Add(this.speedwordlabel);
            this.Controls.Add(this.Tolabel);
            this.Controls.Add(this.Fromlabel);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.currentFil);
            this.Controls.Add(this.schijfgiant);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.etalabel);
            this.Controls.Add(this.etawordlabel);
            this.Controls.Add(this.totaalwordlabel);
            this.Controls.Add(this.currentproglabel);
            this.Controls.Add(this.totalproglabel);
            this.Controls.Add(this.totalBar);
            this.Controls.Add(this.proglabel5);
            this.Controls.Add(this.proglabel4);
            this.Controls.Add(this.proglabel3);
            this.Controls.Add(this.proglabel2);
            this.Controls.Add(this.proglabel1);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.file5label);
            this.Controls.Add(this.file4label);
            this.Controls.Add(this.file3label);
            this.Controls.Add(this.file2label);
            this.Controls.Add(this.file1label);
            this.Controls.Add(this.donebutton);
            this.Controls.Add(this.convertbutton);
            this.Controls.Add(this.targetlabel);
            this.Controls.Add(this.inputlabel);
            this.Controls.Add(this.targetbutton);
            this.Controls.Add(this.inputbutton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "windowcase";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button inputbutton;
        private Button targetbutton;
        private Label inputlabel;
        private Label targetlabel;
        private Button convertbutton;
        private Button donebutton;
        private Label file1label;
        private Label file2label;
        private Label file3label;
        private Label file4label;
        private Label file5label;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private ProgressBar progressBar4;
        private ProgressBar progressBar5;
        private Label proglabel1;
        private Label proglabel2;
        private Label proglabel3;
        private Label proglabel4;
        private Label proglabel5;
        private ProgressBar totalBar;
        private Label totalproglabel;
        private Label currentFil;
        private Label currentproglabel;
        private Label totaalwordlabel;
        private Label etawordlabel;
        private Label etalabel;
        private Button button1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private Label schijfgiant;
        private PictureBox pictureBox3;
        private Label Fromlabel;
        private Label Tolabel;
        private Label speedlabel;
        private Label speedwordlabel;
    }
}