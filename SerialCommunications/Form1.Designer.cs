
namespace SerialCommunications
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbPortName = new System.Windows.Forms.TextBox();
            this.btnOpenComm = new System.Windows.Forms.Button();
            this.btnCloseComm = new System.Windows.Forms.Button();
            this.tbReceiveMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRecMessClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSendMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDiagnostic = new System.Windows.Forms.TextBox();
            this.btDiagnosticClear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comm Port Name:";
            // 
            // tbPortName
            // 
            this.tbPortName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPortName.Location = new System.Drawing.Point(157, 19);
            this.tbPortName.Name = "tbPortName";
            this.tbPortName.Size = new System.Drawing.Size(86, 29);
            this.tbPortName.TabIndex = 1;
            this.tbPortName.Text = "COM1";
            this.tbPortName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOpenComm
            // 
            this.btnOpenComm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenComm.Location = new System.Drawing.Point(258, 19);
            this.btnOpenComm.Name = "btnOpenComm";
            this.btnOpenComm.Size = new System.Drawing.Size(106, 29);
            this.btnOpenComm.TabIndex = 2;
            this.btnOpenComm.Text = "OPEN Port";
            this.btnOpenComm.UseVisualStyleBackColor = true;
            this.btnOpenComm.Click += new System.EventHandler(this.btnOpenComm_Click);
            // 
            // btnCloseComm
            // 
            this.btnCloseComm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCloseComm.Location = new System.Drawing.Point(370, 18);
            this.btnCloseComm.Name = "btnCloseComm";
            this.btnCloseComm.Size = new System.Drawing.Size(106, 29);
            this.btnCloseComm.TabIndex = 3;
            this.btnCloseComm.Text = "CLOSE Port";
            this.btnCloseComm.UseVisualStyleBackColor = true;
            this.btnCloseComm.Click += new System.EventHandler(this.btnCloseComm_Click);
            // 
            // tbReceiveMessage
            // 
            this.tbReceiveMessage.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReceiveMessage.ForeColor = System.Drawing.Color.Blue;
            this.tbReceiveMessage.Location = new System.Drawing.Point(13, 108);
            this.tbReceiveMessage.Multiline = true;
            this.tbReceiveMessage.Name = "tbReceiveMessage";
            this.tbReceiveMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbReceiveMessage.Size = new System.Drawing.Size(463, 139);
            this.tbReceiveMessage.TabIndex = 4;
            this.tbReceiveMessage.Text = "Message from comm port";
            this.tbReceiveMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "__________________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, -11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(472, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "__________________________________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(176, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Receive Messages";
            // 
            // btnRecMessClear
            // 
            this.btnRecMessClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRecMessClear.Location = new System.Drawing.Point(421, 253);
            this.btnRecMessClear.Name = "btnRecMessClear";
            this.btnRecMessClear.Size = new System.Drawing.Size(55, 29);
            this.btnRecMessClear.TabIndex = 8;
            this.btnRecMessClear.Text = "Clear";
            this.btnRecMessClear.UseVisualStyleBackColor = true;
            this.btnRecMessClear.Click += new System.EventHandler(this.btnRecMessClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(472, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "__________________________________________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(179, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Send Messages";
            // 
            // tbSendMessage
            // 
            this.tbSendMessage.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSendMessage.ForeColor = System.Drawing.Color.DarkOrchid;
            this.tbSendMessage.Location = new System.Drawing.Point(12, 341);
            this.tbSendMessage.Multiline = true;
            this.tbSendMessage.Name = "tbSendMessage";
            this.tbSendMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSendMessage.Size = new System.Drawing.Size(463, 85);
            this.tbSendMessage.TabIndex = 11;
            this.tbSendMessage.Text = "Message from comm port";
            this.tbSendMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSendMessage.Location = new System.Drawing.Point(351, 432);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(124, 29);
            this.btnSendMessage.TabIndex = 12;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(13, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(472, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "__________________________________________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(195, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Diagnostics";
            // 
            // tbDiagnostic
            // 
            this.tbDiagnostic.BackColor = System.Drawing.SystemColors.Control;
            this.tbDiagnostic.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDiagnostic.ForeColor = System.Drawing.Color.Red;
            this.tbDiagnostic.Location = new System.Drawing.Point(13, 518);
            this.tbDiagnostic.Multiline = true;
            this.tbDiagnostic.Name = "tbDiagnostic";
            this.tbDiagnostic.ReadOnly = true;
            this.tbDiagnostic.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDiagnostic.Size = new System.Drawing.Size(463, 85);
            this.tbDiagnostic.TabIndex = 15;
            this.tbDiagnostic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btDiagnosticClear
            // 
            this.btDiagnosticClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDiagnosticClear.Location = new System.Drawing.Point(420, 609);
            this.btDiagnosticClear.Name = "btDiagnosticClear";
            this.btDiagnosticClear.Size = new System.Drawing.Size(55, 29);
            this.btDiagnosticClear.TabIndex = 16;
            this.btDiagnosticClear.Text = "Clear";
            this.btDiagnosticClear.UseVisualStyleBackColor = true;
            this.btDiagnosticClear.Click += new System.EventHandler(this.btDiagnosticClear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(13, 628);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(472, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "__________________________________________________________________";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 653);
            this.Controls.Add(this.btDiagnosticClear);
            this.Controls.Add(this.tbDiagnostic);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.tbSendMessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRecMessClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseComm);
            this.Controls.Add(this.btnOpenComm);
            this.Controls.Add(this.tbPortName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbReceiveMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Communication Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPortName;
        private System.Windows.Forms.Button btnOpenComm;
        private System.Windows.Forms.Button btnCloseComm;
        private System.Windows.Forms.TextBox tbReceiveMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRecMessClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSendMessage;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDiagnostic;
        private System.Windows.Forms.Button btDiagnosticClear;
        private System.Windows.Forms.Label label9;
    }
}

