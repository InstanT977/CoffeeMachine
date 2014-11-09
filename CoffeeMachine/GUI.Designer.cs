using System.Drawing;
using System.Windows.Forms;

namespace CoffeeMachine
{
    partial class GuiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuiForm));
            this.uiDisplayDepositCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiWaterHeatingControl = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiDisplayInput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.uiDisplayUserInformation = new System.Windows.Forms.Button();
            this.uiMoneyPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiMoney5000Button = new System.Windows.Forms.Button();
            this.uiMoney1000Button = new System.Windows.Forms.Button();
            this.uiMoney500Button = new System.Windows.Forms.Button();
            this.uiMoney100Button = new System.Windows.Forms.Button();
            this.uiMoney50Button = new System.Windows.Forms.Button();
            this.uiMoney10Button = new System.Windows.Forms.Button();
            this.uiCashButton = new System.Windows.Forms.Button();
            this.uiPickMoney = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureCup = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uiMainPanelPicture = new System.Windows.Forms.PictureBox();
            this.uiInfoPanel = new System.Windows.Forms.Panel();
            this.uiInformationTextBox = new System.Windows.Forms.RichTextBox();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiWaterHeatingControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uiMoneyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPickMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiMainPanelPicture)).BeginInit();
            this.uiInfoPanel.SuspendLayout();
            this.uiInputPanel.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.uiWaterHeatingControl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.uiDisplayInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.uiDisplayDepositCount);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.uiDisplayUserInformation);
            this.panel1.Controls.Add(this.uiExitButton);
            this.panel1.Location = new System.Drawing.Point(335, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 178);
            this.panel1.TabIndex = 25;
            // 
            // uiWaterHeatingControl
            // 
            this.uiWaterHeatingControl.BackgroundImage = global::CoffeeMachine.Properties.Resources.green;
            this.uiWaterHeatingControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiWaterHeatingControl.Location = new System.Drawing.Point(165, 149);
            this.uiWaterHeatingControl.Name = "uiWaterHeatingControl";
            this.uiWaterHeatingControl.Size = new System.Drawing.Size(13, 13);
            this.uiWaterHeatingControl.TabIndex = 17;
            this.uiWaterHeatingControl.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CoffeeMachine.Properties.Resources.water;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(134, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 33);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // uiDisplayInput
            // 
            this.uiDisplayInput.AutoSize = true;
            this.uiDisplayInput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uiDisplayInput.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiDisplayInput.ForeColor = System.Drawing.Color.Red;
            this.uiDisplayInput.Location = new System.Drawing.Point(26, 102);
            this.uiDisplayInput.MaximumSize = new System.Drawing.Size(144, 19);
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
            // uiDisplayUserInformation
            // 
            this.uiDisplayUserInformation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uiDisplayUserInformation.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.uiDisplayUserInformation.FlatAppearance.BorderSize = 3;
            this.uiDisplayUserInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiDisplayUserInformation.ForeColor = System.Drawing.Color.DarkRed;
            this.uiDisplayUserInformation.Location = new System.Drawing.Point(16, 61);
            this.uiDisplayUserInformation.Name = "uiDisplayUserInformation";
            this.uiDisplayUserInformation.Size = new System.Drawing.Size(161, 37);
            this.uiDisplayUserInformation.TabIndex = 16;
            this.uiDisplayUserInformation.UseVisualStyleBackColor = false;
            // 
            // uiMoneyPanel
            // 
            this.uiMoneyPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.uiMoneyPanel.Controls.Add(this.label7);
            this.uiMoneyPanel.Controls.Add(this.label6);
            this.uiMoneyPanel.Controls.Add(this.label5);
            this.uiMoneyPanel.Controls.Add(this.label4);
            this.uiMoneyPanel.Controls.Add(this.label3);
            this.uiMoneyPanel.Controls.Add(this.label2);
            this.uiMoneyPanel.Controls.Add(this.uiMoney5000Button);
            this.uiMoneyPanel.Controls.Add(this.uiMoney1000Button);
            this.uiMoneyPanel.Controls.Add(this.uiMoney500Button);
            this.uiMoneyPanel.Controls.Add(this.uiMoney100Button);
            this.uiMoneyPanel.Controls.Add(this.uiMoney50Button);
            this.uiMoneyPanel.Controls.Add(this.uiMoney10Button);
            this.uiMoneyPanel.Location = new System.Drawing.Point(335, 471);
            this.uiMoneyPanel.Name = "uiMoneyPanel";
            this.uiMoneyPanel.Size = new System.Drawing.Size(206, 114);
            this.uiMoneyPanel.TabIndex = 26;
            this.uiMoneyPanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "500";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "5000";
            // 
            // uiMoney5000Button
            // 
            this.uiMoney5000Button.BackgroundImage = global::CoffeeMachine.Properties.Resources._5000_r;
            this.uiMoney5000Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiMoney5000Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiMoney5000Button.Location = new System.Drawing.Point(139, 65);
            this.uiMoney5000Button.Name = "uiMoney5000Button";
            this.uiMoney5000Button.Size = new System.Drawing.Size(50, 23);
            this.uiMoney5000Button.TabIndex = 0;
            this.uiMoney5000Button.Tag = "5000";
            this.uiMoney5000Button.UseVisualStyleBackColor = true;
            this.uiMoney5000Button.Click += new System.EventHandler(this.UiMoneyInsertClick);
            // 
            // uiMoney1000Button
            // 
            this.uiMoney1000Button.BackgroundImage = global::CoffeeMachine.Properties.Resources._1000_r;
            this.uiMoney1000Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiMoney1000Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiMoney1000Button.Location = new System.Drawing.Point(77, 65);
            this.uiMoney1000Button.Name = "uiMoney1000Button";
            this.uiMoney1000Button.Size = new System.Drawing.Size(50, 23);
            this.uiMoney1000Button.TabIndex = 0;
            this.uiMoney1000Button.Tag = "1000";
            this.uiMoney1000Button.UseVisualStyleBackColor = true;
            this.uiMoney1000Button.Click += new System.EventHandler(this.UiMoneyInsertClick);
            // 
            // uiMoney500Button
            // 
            this.uiMoney500Button.BackgroundImage = global::CoffeeMachine.Properties.Resources._500_r;
            this.uiMoney500Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiMoney500Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiMoney500Button.Location = new System.Drawing.Point(12, 65);
            this.uiMoney500Button.Name = "uiMoney500Button";
            this.uiMoney500Button.Size = new System.Drawing.Size(50, 23);
            this.uiMoney500Button.TabIndex = 0;
            this.uiMoney500Button.Tag = "500";
            this.uiMoney500Button.UseVisualStyleBackColor = true;
            this.uiMoney500Button.Click += new System.EventHandler(this.UiMoneyInsertClick);
            // 
            // uiMoney100Button
            // 
            this.uiMoney100Button.BackgroundImage = global::CoffeeMachine.Properties.Resources._100_r;
            this.uiMoney100Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiMoney100Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiMoney100Button.Location = new System.Drawing.Point(139, 14);
            this.uiMoney100Button.Name = "uiMoney100Button";
            this.uiMoney100Button.Size = new System.Drawing.Size(50, 23);
            this.uiMoney100Button.TabIndex = 0;
            this.uiMoney100Button.Tag = "100";
            this.uiMoney100Button.UseVisualStyleBackColor = true;
            this.uiMoney100Button.Click += new System.EventHandler(this.UiMoneyInsertClick);
            // 
            // uiMoney50Button
            // 
            this.uiMoney50Button.BackgroundImage = global::CoffeeMachine.Properties.Resources._50_r;
            this.uiMoney50Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiMoney50Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiMoney50Button.Location = new System.Drawing.Point(77, 14);
            this.uiMoney50Button.Name = "uiMoney50Button";
            this.uiMoney50Button.Size = new System.Drawing.Size(50, 23);
            this.uiMoney50Button.TabIndex = 0;
            this.uiMoney50Button.Tag = "50";
            this.uiMoney50Button.UseVisualStyleBackColor = true;
            this.uiMoney50Button.Click += new System.EventHandler(this.UiMoneyInsertClick);
            // 
            // uiMoney10Button
            // 
            this.uiMoney10Button.BackgroundImage = global::CoffeeMachine.Properties.Resources._10_r;
            this.uiMoney10Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiMoney10Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiMoney10Button.Location = new System.Drawing.Point(12, 14);
            this.uiMoney10Button.Name = "uiMoney10Button";
            this.uiMoney10Button.Size = new System.Drawing.Size(50, 23);
            this.uiMoney10Button.TabIndex = 0;
            this.uiMoney10Button.Tag = "10";
            this.uiMoney10Button.UseVisualStyleBackColor = true;
            this.uiMoney10Button.Click += new System.EventHandler(this.UiMoneyInsertClick);
            // 
            // uiCashButton
            // 
            this.uiCashButton.BackgroundImage = global::CoffeeMachine.Properties.Resources.cash;
            this.uiCashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiCashButton.Location = new System.Drawing.Point(382, 478);
            this.uiCashButton.Name = "uiCashButton";
            this.uiCashButton.Size = new System.Drawing.Size(132, 52);
            this.uiCashButton.TabIndex = 28;
            this.uiCashButton.Tag = "$";
            this.uiCashButton.UseVisualStyleBackColor = true;
            // 
            // uiPickMoney
            // 
            this.uiPickMoney.Image = global::CoffeeMachine.Properties.Resources.Animation;
            this.uiPickMoney.Location = new System.Drawing.Point(421, 458);
            this.uiPickMoney.Name = "uiPickMoney";
            this.uiPickMoney.Size = new System.Drawing.Size(51, 9);
            this.uiPickMoney.TabIndex = 27;
            this.uiPickMoney.TabStop = false;
            this.uiPickMoney.Click += new System.EventHandler(this.uiPickMoney_Click);
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
            // uiInfoPanel
            // 
            this.uiInfoPanel.BackgroundImage = global::CoffeeMachine.Properties.Resources.inputPanel;
            this.uiInfoPanel.Controls.Add(this.uiInformationTextBox);
            this.uiInfoPanel.Location = new System.Drawing.Point(335, 172);
            this.uiInfoPanel.Name = "uiInfoPanel";
            this.uiInfoPanel.Size = new System.Drawing.Size(206, 192);
            this.uiInfoPanel.TabIndex = 24;
            this.uiInfoPanel.Visible = false;
            // 
            // uiInformationTextBox
            // 
            this.uiInformationTextBox.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiInformationTextBox.Location = new System.Drawing.Point(16, 12);
            this.uiInformationTextBox.Name = "uiInformationTextBox";
            this.uiInformationTextBox.ReadOnly = true;
            this.uiInformationTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.uiInformationTextBox.Size = new System.Drawing.Size(167, 164);
            this.uiInformationTextBox.TabIndex = 0;
            this.uiInformationTextBox.Text = "";
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
            this.uiInputPanel.Controls.Add(this.uiInformationButton);
            this.uiInputPanel.Controls.Add(this.uiInputButton1);
            this.uiInputPanel.Location = new System.Drawing.Point(335, 172);
            this.uiInputPanel.Name = "uiInputPanel";
            this.uiInputPanel.Size = new System.Drawing.Size(206, 274);
            this.uiInputPanel.TabIndex = 24;
            // 
            // uiInputButton_T2
            // 
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
            this.uiExitButton.FlatAppearance.BorderSize = 0;
            this.uiExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiExitButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uiExitButton.Location = new System.Drawing.Point(164, 0);
            this.uiExitButton.Name = "uiExitButton";
            this.uiExitButton.Size = new System.Drawing.Size(24, 22);
            this.uiExitButton.TabIndex = 0;
            this.uiExitButton.Tag = "13";
            this.uiExitButton.UseVisualStyleBackColor = false;
            this.uiExitButton.Click += new System.EventHandler(this.uiExitButton_Click);
            // 
            // uiInformationButton
            // 
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
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 585);
            this.ControlBox = false;
            this.Controls.Add(this.uiMoneyPanel);
            this.Controls.Add(this.uiCashButton);
            this.Controls.Add(this.uiPickMoney);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureCup);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.uiMainPanelPicture);
            this.Controls.Add(this.uiInfoPanel);
            this.Controls.Add(this.uiInputPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Machine";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiWaterHeatingControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uiMoneyPanel.ResumeLayout(false);
            this.uiMoneyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPickMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiMainPanelPicture)).EndInit();
            this.uiInfoPanel.ResumeLayout(false);
            this.uiInputPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel uiMoneyPanel;
        private System.Windows.Forms.Button uiMoney10Button;
        private System.Windows.Forms.Button uiMoney5000Button;
        private System.Windows.Forms.Button uiMoney1000Button;
        private System.Windows.Forms.Button uiMoney500Button;
        private System.Windows.Forms.Button uiMoney100Button;
        private System.Windows.Forms.Button uiMoney50Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox uiPickMoney;
        private System.Windows.Forms.Panel uiInfoPanel;
        public RichTextBox uiInformationTextBox;
        private Button uiCashButton;
        private PictureBox pictureBox1;
        public PictureBox uiWaterHeatingControl;
    }
}

