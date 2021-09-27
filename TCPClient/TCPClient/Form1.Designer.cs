
namespace TCPClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.textIP = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.textINFO = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(65, 12);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(495, 22);
            this.textIP.TabIndex = 1;
            this.textIP.Text = "127.0.0.1:9000";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(365, 324);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // textINFO
            // 
            this.textINFO.Location = new System.Drawing.Point(65, 50);
            this.textINFO.Multiline = true;
            this.textINFO.Name = "textINFO";
            this.textINFO.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textINFO.Size = new System.Drawing.Size(495, 192);
            this.textINFO.TabIndex = 3;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(65, 266);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(495, 22);
            this.textMessage.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Guess:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(464, 324);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 359);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textINFO);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP/IP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textINFO;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
    }
}

