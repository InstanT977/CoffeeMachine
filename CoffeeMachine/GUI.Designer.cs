using System.Drawing;

namespace CoffeeMachine
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.uiDisplayDepositCount = new System.Windows.Forms.Label();
            this.uiInputPanel = new System.Windows.Forms.Panel();
            this.uiInputButton_T2 = new System.Windows.Forms.Button();
            this.uiInputButton0 = new System.Windows.Forms.Button();
            this.uiInputButton_T1 = new System.Windows.Forms.Button();
            this.uiInputButton9 = new System.Windows.Forms.Button();
            this.uiInputButton8 = new System.Windows.Forms.Button();
            this.uiInputButton7 = new System.Windows.Forms.Button();
            this.uiInputButton6 = new System.Windows.Forms.Button();
            this.uiInputButton5 = new System.Windows.Forms.Button();
            this.uiInputButton3 = new System.Windows.Forms.Button();
            this.uiInputButton4 = new System.Windows.Forms.Button();
            this.uiInputButton2 = new System.Windows.Forms.Button();
            this.uiExitButton = new System.Windows.Forms.Button();
            this.uiInformationButton = new System.Windows.Forms.Button();
            this.uiInputButton1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureCup = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uiMainPanelPicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiDisplayUserInformation = new System.Windows.Forms.Button();
            this.uiDisplayInput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.uiInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiMainPanelPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiDisplayDepositCount
            // 
            this.uiDisplayDepositCount.AutoSize = true;
            this.uiDisplayDepositCount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uiDisplayDepositCount.ForeColor = System.Drawing.Color.Red;
            this.uiDisplayDepositCount.Location = new System.Drawing.Point(128, 41);
            this.uiDisplayDepositCount.Name = "uiDisplayDepositCount";
            this.uiDisplayDepositCount.Size = new System.Drawing.Size(13, 13);
            this.uiDisplayDepositCount.TabIndex = 15;
            this.uiDisplayDepositCount.Text = "0";
            // 
            // uiInputPanel
            // 
            this.uiInputPanel.BackgroundImage = global::CoffeeMachine.Properties.Resources.inputPanel;
            this.uiInputPanel.Controls.Add(this.uiInputButton_T2);
            this.uiInputPanel.Controls.Add(this.uiInputButton0);
            this.uiInputPanel.Controls.Add(this.uiInputButton_T1);
            this.uiInputPanel.Controls.Add(this.uiInputButton9);
            this.uiInputPanel.Controls.Add(this.uiInputButton8);
            this.uiInputPanel.Controls.Add(this.uiInputButton7);
            this.uiInputPanel.Controls.Add(this.uiInputButton6);
            this.uiInputPanel.Controls.Add(this.uiInputButton5);
            this.uiInputPanel.Controls.Add(this.uiInputButton3);
            this.uiInputPanel.Controls.Add(this.uiInputButton4);
            this.uiInputPanel.Controls.Add(this.uiInputButton2);
            this.uiInputPanel.Controls.Add(this.uiExitButton);
            this.uiInputPanel.Controls.Add(this.uiInformationButton);
            this.uiInputPanel.Controls.Add(this.uiInputButton1);
            this.uiInputPanel.Location = new System.Drawing.Point(335, 172);
            this.uiInputPanel.Name = "uiInputPanel";
            this.uiInputPanel.Size = new System.Drawing.Size(206, 274);
            this.uiInputPanel.TabIndex = 24;
            // 
            // uiInputButton_T2
            // 
            this.uiInputButton_T2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiInputButton_T2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiInputButton_T2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiInputButton_T2.Location = new System.Drawing.Point(136, 153);
            this.uiInputButton_T2.Name = "uiInputButton_T2";
            this.uiInputButton_T2.Size = new System.Drawing.Size(46, 39);
            this.uiInputButton_T2.TabIndex = 0;
            this.uiInputButton_T2.Tag = "11";
            this.uiInputButton_T2.Text = "#";
            this.uiInputButton_T2.UseVisualStyleBackColor = true;
            this.uiInputButton_T2.Click += new System.EventHandler(this.UiInputButtonClick);
            // 
            // uiInputButton0
            // 
            this.uiInputButton0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiInputButton0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiInputButton0.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiInputButton0.Location = new System.Drawing.Point(84, 153);
            this.uiInputButton0.Name = "uiInputButton0";
            this.uiInputButton0.Size = new System.Drawing.Size(46, 39);
            this.uiInputButton0.TabIndex = 0;
            this.uiInputButton0.Tag = "0";
            this.uiInputButton0.Text = "0";
            this.uiInputButton0.UseVisualStyleBackColor = true;
            this.uiInputButton0.Click += new System.EventHandler(this.UiInputButtonClick);
            // 
            // uiInputButton_T1
            // 
            this.uiInputButton_T1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiInputButton_T1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiInputButton_T1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiInputButton_T1.Location = new System.Drawing.Point(32, 152);
            this.uiInputButton_T1.Name = "uiInputButton_T1";
            this.uiInputButton_T1.Size = new System.Drawing.Size(46, 39);
            this.uiInputButton_T1.TabIndex = 0;
            this.uiInputButton_T1.Tag = "10";
            this.uiInputButton_T1.Text = "*";
            this.uiInputButton_T1.UseVisualStyleBackColor = true;
            this.uiInputButton_T1.Click += new System.EventHandler(this.UiInputButtonClick);
            // 
            // uiInputButton9
            // 
            this.uiInputButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiInputButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiInputButton9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiInputButton9.Location = new System.Drawing.Point(136, 108);
            this.uiInputButton9.Name = "uiInputButton9";
            this.uiInputButton9.Size = new System.Drawing.Size(46, 39);
            this.uiInputButton9.TabIndex = 0;
            this.uiInputButton9.Tag = "9";
            this.uiInputButton9.Text = "9";
            this.uiInputButton9.UseVisualStyleBackColor = true;
            this.uiInputButton9.Click += new System.EventHandler(this.UiInputButtonClick);
            // 
            // uiInputButton8
            // 
            this.uiInputButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiInputButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiInputButton8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiInputButton8.Location = new System.Drawing.Point(84, 108);
            this.uiInputButton8.Name = "uiInputButton8";
            this.uiInputButton8.Size = new System.Drawing.Size(46, 39);
            this.uiInputButton8.TabIndex = 0;
            this.uiInputButton8.Tag = "8";
            this.uiInputButton8.Text = "8";
            this.uiInputButton8.UseVisualStyleBackColor = true;
            this.uiInputButton8.Click += new System.EventHandler(this.UiInputButtonClick);
            // 
            // uiInputButton7
            // 
            this.uiInputButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiInputButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiInputButton7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiInputButton7.Location = new System.Drawing.Point(32, 108);
            this.uiInputButton7.Name = "uiInputButton7";
            this.uiInputButton7.Size = new System.Drawing.Size(46, 39);
            this.uiInputButton7.TabIndex = 0;
            this.uiInputButton7.Tag = "7";
            this.uiInputButton7.Text = "7";
            this.uiInputButton7.UseVisualStyleBackColor = true;
            this.uiInputButton7.Click += new System.EventHandler(this.UiInputButtonClick);
            // 
            // uiInputButton6
            // 
            this.uiInputButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiInputButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiInputButton6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiInputButton6.Location = new System.Drawing.Point(136, 63);
            this.uiInputButton6.Name = "uiInputButton6";
            this.uiInputButton6.Size = new System.Drawing.Size(46, 39);
            this.uiInputButton6.TabIndex = 0;
            this.uiInputButton6.Tag = "6";
            this.uiInputButton6.Text = "6";
            this.uiInputButton6.UseVisualStyleBackColor = true;
            this.uiInputButton6.Click += new System.EventHandler(this.UiInputButtonClick);
            // 
            // uiInputButton5
            // 
            this.uiInputButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiInputButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiInputButton5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiInputButton5.Location = new System.Drawing.Point(84, 63);
            this.uiInputButton5.Name = "uiInputButton5";
            this.uiInputButton5.Size = new System.Drawing.Size(46, 39);
            this.uiInputButton5.TabIndex = 0;
            this.uiInputButton5.Tag = "5";
            this.uiInputButton5.Text = "5";
            this.uiInputButton5.UseVisualStyleBackColor = true;
            this.uiInputButton5.Click += new System.EventHandler(this.UiInputButtonClick);
            // 
            // uiInputButton3
            // 
            this.uiInputButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiInputButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiInputButton3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiInputButton3.Location = new System.Drawing.Point(136, 18);
            this.uiInputButton3.Name = "uiInputButton3";
            this.uiInputButton3.Size = new System.Drawing.Size(46, 39);
            this.uiInputButton3.TabIndex = 0;
            this.uiInputButton3.Tag = "3";
            this.uiInputButton3.Text = "3";
            this.uiInputButton3.UseVisualStyleBackColor = true;
            this.uiInputButton3.Click += new System.EventHandler(this.UiInputButtonClick);
            // 
            // uiInputButton4
            // 
            this.uiInputButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiInputButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiInputButton4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiInputButton4.Location = new System.Drawing.Point(32, 63);
            this.uiInputButton4.Name = "uiInputButton4";
            this.uiInputButton4.Size = new System.Drawing.Size(46, 39);
            this.uiInputButton4.TabIndex = 0;
            this.uiInputButton4.Tag = "4";
            this.uiInputButton4.Text = "4";
            this.uiInputButton4.UseVisualStyleBackColor = true;
            this.uiInputButton4.Click += new System.EventHandler(this.UiInputButtonClick);
            // 
            // uiInputButton2
            // 
            this.uiInputButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiInputButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiInputButton2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiInputButton2.Location = new System.Drawing.Point(84, 18);
            this.uiInputButton2.Name = "uiInputButton2";
            this.uiInputButton2.Size = new System.Drawing.Size(46, 39);
            this.uiInputButton2.TabIndex = 0;
            this.uiInputButton2.Tag = "2";
            this.uiInputButton2.Text = "2";
            this.uiInputButton2.UseVisualStyleBackColor = true;
            this.uiInputButton2.Click += new System.EventHandler(this.UiInputButtonClick);
            // 
            // uiExitButton
            // 
            this.uiExitButton.BackColor = System.Drawing.Color.Transparent;
            this.uiExitButton.BackgroundImage = global::CoffeeMachine.Properties.Resources.exit;
            this.uiExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiExitButton.FlatAppearance.BorderSize = 0;
            this.uiExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiExitButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uiExitButton.Location = new System.Drawing.Point(84, 222);
            this.uiExitButton.Name = "uiExitButton";
            this.uiExitButton.Size = new System.Drawing.Size(46, 37);
            this.uiExitButton.TabIndex = 0;
            this.uiExitButton.Tag = "13";
            this.uiExitButton.UseVisualStyleBackColor = false;
            this.uiExitButton.Click += new System.EventHandler(this.uiExitButton_Click);
            // 
            // uiInformationButton
            // 
            this.uiInformationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiInformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiInformationButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uiInformationButton.Location = new System.Drawing.Point(32, 194);
            this.uiInformationButton.Name = "uiInformationButton";
            this.uiInformationButton.Size = new System.Drawing.Size(150, 25);
            this.uiInformationButton.TabIndex = 0;
            this.uiInformationButton.Tag = "12";
            this.uiInformationButton.Text = "Информация";
            this.uiInformationButton.UseVisualStyleBackColor = true;
            this.uiInformationButton.Click += new System.EventHandler(this.uiInformationButton_Click);
            // 
            // uiInputButton1
            // 
            this.uiInputButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiInputButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiInputButton1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiInputButton1.Location = new System.Drawing.Point(32, 18);
            this.uiInputButton1.Name = "uiInputButton1";
            this.uiInputButton1.Size = new System.Drawing.Size(46, 39);
            this.uiInputButton1.TabIndex = 0;
            this.uiInputButton1.Tag = "1";
            this.uiInputButton1.Text = "1";
            this.uiInputButton1.UseVisualStyleBackColor = true;
            this.uiInputButton1.Click += new System.EventHandler(this.UiInputButtonClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(335, 443);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(206, 142);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureCup
            // 
            this.pictureCup.Image = global::CoffeeMachine.Properties.Resources.cup;
            this.pictureCup.Location = new System.Drawing.Point(157, 306);
            this.pictureCup.Name = "pictureCup";
            this.pictureCup.Size = new System.Drawing.Size(59, 64);
            this.pictureCup.TabIndex = 22;
            this.pictureCup.TabStop = false;
            this.pictureCup.Visible = false;
            this.pictureCup.Click += new System.EventHandler(this.pictureCup_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(335, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(206, 178);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // uiMainPanelPicture
            // 
            this.uiMainPanelPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiMainPanelPicture.Image = ((System.Drawing.Image)(resources.GetObject("uiMainPanelPicture.Image")));
            this.uiMainPanelPicture.Location = new System.Drawing.Point(0, 0);
            this.uiMainPanelPicture.Name = "uiMainPanelPicture";
            this.uiMainPanelPicture.Size = new System.Drawing.Size(335, 585);
            this.uiMainPanelPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uiMainPanelPicture.TabIndex = 1;
            this.uiMainPanelPicture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.uiDisplayInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.uiDisplayDepositCount);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.uiDisplayUserInformation);
            this.panel1.Location = new System.Drawing.Point(335, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 178);
            this.panel1.TabIndex = 25;
            // 
            // uiDisplayUserInformation
            // 
            this.uiDisplayUserInformation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uiDisplayUserInformation.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.uiDisplayUserInformation.FlatAppearance.BorderSize = 3;
            this.uiDisplayUserInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiDisplayUserInformation.Location = new System.Drawing.Point(16, 61);
            this.uiDisplayUserInformation.Name = "uiDisplayUserInformation";
            this.uiDisplayUserInformation.Size = new System.Drawing.Size(161, 37);
            this.uiDisplayUserInformation.TabIndex = 16;
            this.uiDisplayUserInformation.UseVisualStyleBackColor = false;
            // 
            // uiDisplayInput
            // 
            this.uiDisplayInput.AutoSize = true;
            this.uiDisplayInput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uiDisplayInput.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiDisplayInput.ForeColor = System.Drawing.Color.Red;
            this.uiDisplayInput.Location = new System.Drawing.Point(38, 102);
            this.uiDisplayInput.Name = "uiDisplayInput";
            this.uiDisplayInput.Size = new System.Drawing.Size(0, 19);
            this.uiDisplayInput.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Внесено:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(16, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 37);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(16, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 37);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 585);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.uiInputPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureCup);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.uiMainPanelPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Machine";
            this.uiInputPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiMainPanelPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox uiMainPanelPicture;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureCup;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button uiInputButton1;
        private System.Windows.Forms.Panel uiInputPanel;
        private System.Windows.Forms.Button uiInputButton_T2;
        private System.Windows.Forms.Button uiInputButton0;
        private System.Windows.Forms.Button uiInputButton_T1;
        private System.Windows.Forms.Button uiInputButton9;
        private System.Windows.Forms.Button uiInputButton8;
        private System.Windows.Forms.Button uiInputButton7;
        private System.Windows.Forms.Button uiInputButton6;
        private System.Windows.Forms.Button uiInputButton5;
        private System.Windows.Forms.Button uiInputButton3;
        private System.Windows.Forms.Button uiInputButton4;
        private System.Windows.Forms.Button uiInputButton2;
        private System.Windows.Forms.Button uiExitButton;
        private System.Windows.Forms.Button uiInformationButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label uiDisplayDepositCount;
        public System.Windows.Forms.Button uiDisplayUserInformation;
        public System.Windows.Forms.Label uiDisplayInput;
    }
}

