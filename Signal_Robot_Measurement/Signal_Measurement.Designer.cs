namespace Signal_Robot_Measurment
{
    partial class Signal_Measurement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBoxSignalPower = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVelocity = new System.Windows.Forms.TextBox();
            this.textBoxRotate = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonGetSignal = new System.Windows.Forms.Button();
            this.m31 = new PC_BOT.M3();
            this.messages1 = new PC_BOT.Messages();
            this.toolBar1 = new PC_BOT.ToolBar();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(13, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(404, 383);
            this.webBrowser1.TabIndex = 4;
            // 
            // AirgridInterfaceButton
            // 
            this.AirgridInterfaceButton.Location = new System.Drawing.Point(12, 401);
            this.AirgridInterfaceButton.Name = "AirgridInterfaceButton";
            this.AirgridInterfaceButton.Size = new System.Drawing.Size(175, 32);
            this.AirgridInterfaceButton.TabIndex = 14;
            this.AirgridInterfaceButton.Text = "Airgrid Interface";
            this.AirgridInterfaceButton.UseVisualStyleBackColor = true;
            this.AirgridInterfaceButton.Click += new System.EventHandler(this.AirgridInterfaceButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBoxSignalPower);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxVelocity);
            this.groupBox1.Controls.Add(this.textBoxRotate);
            this.groupBox1.Location = new System.Drawing.Point(423, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 141);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rotate";
            // 
            // TextBoxSignalPower
            // 
            this.TextBoxSignalPower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSignalPower.Enabled = false;
            this.TextBoxSignalPower.Location = new System.Drawing.Point(88, 27);
            this.TextBoxSignalPower.Name = "TextBoxSignalPower";
            this.TextBoxSignalPower.Size = new System.Drawing.Size(66, 20);
            this.TextBoxSignalPower.TabIndex = 23;
            this.TextBoxSignalPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Rotate (deg)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Signal Strength";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Velocity (mm/s)";
            // 
            // textBoxVelocity
            // 
            this.textBoxVelocity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVelocity.Location = new System.Drawing.Point(88, 65);
            this.textBoxVelocity.Name = "textBoxVelocity";
            this.textBoxVelocity.Size = new System.Drawing.Size(66, 20);
            this.textBoxVelocity.TabIndex = 19;
            this.textBoxVelocity.Text = "30";
            this.textBoxVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxRotate
            // 
            this.textBoxRotate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRotate.Location = new System.Drawing.Point(88, 107);
            this.textBoxRotate.Name = "textBoxRotate";
            this.textBoxRotate.Size = new System.Drawing.Size(66, 20);
            this.textBoxRotate.TabIndex = 18;
            this.textBoxRotate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxY
            // 
            this.textBoxY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxY.Location = new System.Drawing.Point(88, 65);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(66, 20);
            this.textBoxY.TabIndex = 19;
            this.textBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Y - Axis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "X - Axis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 22;
            // 
            // textBoxX
            // 
            this.textBoxX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxX.Location = new System.Drawing.Point(88, 27);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(66, 20);
            this.textBoxX.TabIndex = 23;
            this.textBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxX);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxY);
            this.groupBox2.Location = new System.Drawing.Point(625, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 101);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Point Coordinates(cm)";
            // 
            // buttonGetSignal
            // 
            this.buttonGetSignal.Location = new System.Drawing.Point(625, 168);
            this.buttonGetSignal.Name = "buttonGetSignal";
            this.buttonGetSignal.Size = new System.Drawing.Size(181, 32);
            this.buttonGetSignal.TabIndex = 21;
            this.buttonGetSignal.Text = "Get Signal!";
            this.buttonGetSignal.UseVisualStyleBackColor = true;
            this.buttonGetSignal.Click += new System.EventHandler(this.buttonGetSignal_Click);
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
            this.m31.PositionEvent += new PC_BOT.M3.PositionEventHandler(this.m31_PositionEvent);
            // 
            // messages1
            // 
            this.messages1.Location = new System.Drawing.Point(423, 254);
            this.messages1.Name = "messages1";
            this.messages1.PCBOTm3 = this.m31;
            this.messages1.Size = new System.Drawing.Size(383, 179);
            this.messages1.TabIndex = 22;
            // 
            // toolBar1
            // 
            this.toolBar1.Location = new System.Drawing.Point(423, 12);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.PCBOTm3 = this.m31;
            this.toolBar1.Size = new System.Drawing.Size(599, 32);
            this.toolBar1.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 32);
            this.button1.TabIndex = 25;
            this.button1.Text = "Test Rotate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 437);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.messages1);
            this.Controls.Add(this.buttonGetSignal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AirgridInterfaceButton);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button AirgridInterfaceButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBoxSignalPower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVelocity;
        private System.Windows.Forms.TextBox textBoxRotate;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonGetSignal;
        private PC_BOT.M3 m31;
        private PC_BOT.Messages messages1;
        private PC_BOT.ToolBar toolBar1;
        private System.Windows.Forms.Button button1;
    }
}

