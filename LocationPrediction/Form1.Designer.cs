namespace LocationPrediction
{
    partial class Form1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.AirgridInterfaceButton = new System.Windows.Forms.Button();
            this.toolBar1 = new PC_BOT.ToolBar();
            this.m31 = new PC_BOT.M3();
            this.messages1 = new PC_BOT.Messages();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WindowingRadioButton = new System.Windows.Forms.RadioButton();
            this.SimpleRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVelocity = new System.Windows.Forms.TextBox();
            this.textBoxRotate = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ViewMap = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.Button();
            this.Localize = new System.Windows.Forms.Button();
            this.PredictionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(6, 17);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(488, 469);
            this.webBrowser1.TabIndex = 5;
            // 
            // AirgridInterfaceButton
            // 
            this.AirgridInterfaceButton.Location = new System.Drawing.Point(313, 492);
            this.AirgridInterfaceButton.Name = "AirgridInterfaceButton";
            this.AirgridInterfaceButton.Size = new System.Drawing.Size(181, 32);
            this.AirgridInterfaceButton.TabIndex = 15;
            this.AirgridInterfaceButton.Text = "Airgrid Interface";
            this.AirgridInterfaceButton.UseVisualStyleBackColor = true;
            this.AirgridInterfaceButton.Click += new System.EventHandler(this.AirgridInterfaceButton_Click);
            // 
            // toolBar1
            // 
            this.toolBar1.Location = new System.Drawing.Point(6, 19);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.PCBOTm3 = this.m31;
            this.toolBar1.Size = new System.Drawing.Size(488, 38);
            this.toolBar1.TabIndex = 25;
            // 
            // m31
            // 
            this.m31.DigitalOut = new PC_BOT.M3.DigitalValue[] {
        PC_BOT.M3.DigitalValue.Off,
        PC_BOT.M3.DigitalValue.Off,
        PC_BOT.M3.DigitalValue.Off,
        PC_BOT.M3.DigitalValue.Off,
        PC_BOT.M3.DigitalValue.Off,
        PC_BOT.M3.DigitalValue.Off,
        PC_BOT.M3.DigitalValue.Off,
        PC_BOT.M3.DigitalValue.Off,
        PC_BOT.M3.DigitalValue.Off,
        PC_BOT.M3.DigitalValue.Off,
        PC_BOT.M3.DigitalValue.Off,
        PC_BOT.M3.DigitalValue.Off,
        PC_BOT.M3.DigitalValue.Off,
        PC_BOT.M3.DigitalValue.Off,
        PC_BOT.M3.DigitalValue.Off,
        PC_BOT.M3.DigitalValue.Off};
            this.m31.DropOffValue = 10;
            this.m31.Power = ((long)(0));
            this.m31.Safety = PC_BOT.M3.SafetyValue.On;
            this.m31.SensorTypes = new PC_BOT.M3.sensorType[] {
        PC_BOT.M3.sensorType.Sharp_80cm_IR,
        PC_BOT.M3.sensorType.Sharp_80cm_IR,
        PC_BOT.M3.sensorType.Sharp_80cm_IR,
        PC_BOT.M3.sensorType.Sharp_80cm_IR,
        PC_BOT.M3.sensorType.Sharp_80cm_IR,
        PC_BOT.M3.sensorType.Sharp_150cm_IR,
        PC_BOT.M3.sensorType.Sharp_80cm_IR,
        PC_BOT.M3.sensorType.Sharp_150cm_IR};
            this.m31.StopOnSafety = true;
            this.m31.VelocityLeft = 0;
            this.m31.VelocityRight = 0;
            // 
            // messages1
            // 
            this.messages1.Location = new System.Drawing.Point(7, 63);
            this.messages1.Name = "messages1";
            this.messages1.PCBOTm3 = this.m31;
            this.messages1.Size = new System.Drawing.Size(487, 333);
            this.messages1.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.WindowingRadioButton);
            this.groupBox1.Controls.Add(this.SimpleRadioButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxVelocity);
            this.groupBox1.Controls.Add(this.textBoxRotate);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 530);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1: Set Configuration Parameters";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(11, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 50);
            this.label8.TabIndex = 30;
            this.label8.Text = "4. Press Localize button and let it estimate the location";
            this.label8.UseCompatibleTextRendering = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(11, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 50);
            this.label7.TabIndex = 29;
            this.label7.Text = "3. Press Open and the Connect in PC-BOT 914 toolbar to make sure that robot works" +
    "\r\n";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(11, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 50);
            this.label6.TabIndex = 28;
            this.label6.Text = "2. Use the Airgrid Interface button to login in Antenna\'s Interface (user and pas" +
    "s: ubnt)";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(11, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 47);
            this.label5.TabIndex = 27;
            this.label5.Text = "1. Make sure to fill the Rotate textbox properly or leave default value\r\n";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(8, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Follow the below Instructions";
            // 
            // WindowingRadioButton
            // 
            this.WindowingRadioButton.AutoSize = true;
            this.WindowingRadioButton.Location = new System.Drawing.Point(115, 155);
            this.WindowingRadioButton.Name = "WindowingRadioButton";
            this.WindowingRadioButton.Size = new System.Drawing.Size(84, 17);
            this.WindowingRadioButton.TabIndex = 25;
            this.WindowingRadioButton.Text = "windowing";
            this.WindowingRadioButton.UseVisualStyleBackColor = true;
            this.WindowingRadioButton.Visible = false;
            // 
            // SimpleRadioButton
            // 
            this.SimpleRadioButton.AutoSize = true;
            this.SimpleRadioButton.Checked = true;
            this.SimpleRadioButton.Location = new System.Drawing.Point(115, 120);
            this.SimpleRadioButton.Name = "SimpleRadioButton";
            this.SimpleRadioButton.Size = new System.Drawing.Size(58, 17);
            this.SimpleRadioButton.TabIndex = 24;
            this.SimpleRadioButton.TabStop = true;
            this.SimpleRadioButton.Text = "simple";
            this.SimpleRadioButton.UseVisualStyleBackColor = true;
            this.SimpleRadioButton.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Select Dataset";
            this.label1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Rotate (deg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Velocity (mm/s)";
            // 
            // textBoxVelocity
            // 
            this.textBoxVelocity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVelocity.Location = new System.Drawing.Point(115, 36);
            this.textBoxVelocity.Name = "textBoxVelocity";
            this.textBoxVelocity.Size = new System.Drawing.Size(66, 22);
            this.textBoxVelocity.TabIndex = 19;
            this.textBoxVelocity.Text = "30";
            this.textBoxVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxRotate
            // 
            this.textBoxRotate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRotate.Location = new System.Drawing.Point(115, 81);
            this.textBoxRotate.Name = "textBoxRotate";
            this.textBoxRotate.Size = new System.Drawing.Size(66, 22);
            this.textBoxRotate.TabIndex = 18;
            this.textBoxRotate.Text = "10";
            this.textBoxRotate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxRotate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRotate_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AirgridInterfaceButton);
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox2.Location = new System.Drawing.Point(220, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 530);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2: Connect to Antenna Interface";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ViewMap);
            this.groupBox3.Controls.Add(this.Test);
            this.groupBox3.Controls.Add(this.toolBar1);
            this.groupBox3.Controls.Add(this.messages1);
            this.groupBox3.Controls.Add(this.Localize);
            this.groupBox3.Controls.Add(this.PredictionLabel);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.groupBox3.Location = new System.Drawing.Point(730, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 530);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 3: Open and Connect PC-BOT 914";
            // 
            // ViewMap
            // 
            this.ViewMap.Location = new System.Drawing.Point(211, 501);
            this.ViewMap.Name = "ViewMap";
            this.ViewMap.Size = new System.Drawing.Size(75, 23);
            this.ViewMap.TabIndex = 35;
            this.ViewMap.Text = "View Map";
            this.ViewMap.UseVisualStyleBackColor = true;
            this.ViewMap.Visible = false;
            this.ViewMap.Click += new System.EventHandler(this.ViewMap_Click);
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(7, 402);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(181, 32);
            this.Test.TabIndex = 34;
            this.Test.Text = "Localize";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // Localize
            // 
            this.Localize.Location = new System.Drawing.Point(318, 400);
            this.Localize.Name = "Localize";
            this.Localize.Size = new System.Drawing.Size(176, 34);
            this.Localize.TabIndex = 31;
            this.Localize.Text = "Localize ";
            this.Localize.UseVisualStyleBackColor = true;
            this.Localize.Visible = false;
            this.Localize.Click += new System.EventHandler(this.Localize_Click);
            // 
            // PredictionLabel
            // 
            this.PredictionLabel.AutoSize = true;
            this.PredictionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PredictionLabel.Location = new System.Drawing.Point(83, 469);
            this.PredictionLabel.Name = "PredictionLabel";
            this.PredictionLabel.Size = new System.Drawing.Size(0, 17);
            this.PredictionLabel.TabIndex = 32;
            this.PredictionLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1260, 600);
            this.MinimumSize = new System.Drawing.Size(1260, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button AirgridInterfaceButton;
        private PC_BOT.ToolBar toolBar1;
        private PC_BOT.Messages messages1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxVelocity;
        public System.Windows.Forms.TextBox textBoxRotate;
        public PC_BOT.M3 m31;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton WindowingRadioButton;
        private System.Windows.Forms.RadioButton SimpleRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Localize;
        private System.Windows.Forms.Label PredictionLabel;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ViewMap;

    }
}

