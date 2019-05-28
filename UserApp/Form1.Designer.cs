namespace UserApp
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
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lstCommands = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.flowLayout_waterLevel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstStatus = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDrainLevel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRaiseDrainLevel = new System.Windows.Forms.Button();
            this.btnDownDrainLevel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.Location = new System.Drawing.Point(12, 26);
            this.btnDeactivate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(129, 37);
            this.btnDeactivate.TabIndex = 0;
            this.btnDeactivate.Text = "Deactivate";
            this.btnDeactivate.UseVisualStyleBackColor = true;
            this.btnDeactivate.Visible = false;
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_ClickAsync);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pump number:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(253, 36);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(72, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // lstCommands
            // 
            this.lstCommands.FormattingEnabled = true;
            this.lstCommands.ItemHeight = 16;
            this.lstCommands.Location = new System.Drawing.Point(12, 175);
            this.lstCommands.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstCommands.Name = "lstCommands";
            this.lstCommands.Size = new System.Drawing.Size(289, 132);
            this.lstCommands.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Commands sent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Water level";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 80);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(143, 37);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Deactivate pumps";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // flowLayout_waterLevel
            // 
            this.flowLayout_waterLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayout_waterLevel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayout_waterLevel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.flowLayout_waterLevel.Location = new System.Drawing.Point(513, 59);
            this.flowLayout_waterLevel.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayout_waterLevel.Name = "flowLayout_waterLevel";
            this.flowLayout_waterLevel.Size = new System.Drawing.Size(265, 438);
            this.flowLayout_waterLevel.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(338, 104);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 56);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start ";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_ClickAsync);
            // 
            // lstStatus
            // 
            this.lstStatus.FormattingEnabled = true;
            this.lstStatus.ItemHeight = 16;
            this.lstStatus.Location = new System.Drawing.Point(13, 349);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.Size = new System.Drawing.Size(288, 148);
            this.lstStatus.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pumps status";
            // 
            // lblDrainLevel
            // 
            this.lblDrainLevel.AutoSize = true;
            this.lblDrainLevel.Location = new System.Drawing.Point(447, 224);
            this.lblDrainLevel.Name = "lblDrainLevel";
            this.lblDrainLevel.Size = new System.Drawing.Size(16, 17);
            this.lblDrainLevel.TabIndex = 15;
            this.lblDrainLevel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Drain Level";
            // 
            // btnRaiseDrainLevel
            // 
            this.btnRaiseDrainLevel.Location = new System.Drawing.Point(307, 190);
            this.btnRaiseDrainLevel.Name = "btnRaiseDrainLevel";
            this.btnRaiseDrainLevel.Size = new System.Drawing.Size(106, 28);
            this.btnRaiseDrainLevel.TabIndex = 17;
            this.btnRaiseDrainLevel.Text = "Drain Up";
            this.btnRaiseDrainLevel.UseVisualStyleBackColor = true;
            this.btnRaiseDrainLevel.Click += new System.EventHandler(this.BtnRaiseDrainLevel_ClickAsync);
            // 
            // btnDownDrainLevel
            // 
            this.btnDownDrainLevel.Location = new System.Drawing.Point(307, 235);
            this.btnDownDrainLevel.Name = "btnDownDrainLevel";
            this.btnDownDrainLevel.Size = new System.Drawing.Size(106, 29);
            this.btnDownDrainLevel.TabIndex = 18;
            this.btnDownDrainLevel.Text = "Drain down";
            this.btnDownDrainLevel.UseVisualStyleBackColor = true;
            this.btnDownDrainLevel.Click += new System.EventHandler(this.BtnDownDrainLevel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 513);
            this.Controls.Add(this.btnDownDrainLevel);
            this.Controls.Add(this.btnRaiseDrainLevel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDrainLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstStatus);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.flowLayout_waterLevel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCommands);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeactivate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox lstCommands;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_waterLevel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDrainLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRaiseDrainLevel;
        private System.Windows.Forms.Button btnDownDrainLevel;
    }
}

