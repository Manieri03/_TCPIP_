namespace ClientApp
{
    partial class Client
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
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textport = new System.Windows.Forms.TextBox();
            this.statustxt = new System.Windows.Forms.TextBox();
            this.connectbtn = new System.Windows.Forms.Button();
            this.Sendbtn = new System.Windows.Forms.Button();
            this.statustxt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(126, 48);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 20);
            this.txtHost.TabIndex = 2;
            this.txtHost.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // textport
            // 
            this.textport.Location = new System.Drawing.Point(439, 48);
            this.textport.Name = "textport";
            this.textport.Size = new System.Drawing.Size(100, 20);
            this.textport.TabIndex = 4;
            this.textport.Text = "8910";
            // 
            // statustxt
            // 
            this.statustxt.Location = new System.Drawing.Point(74, 127);
            this.statustxt.Multiline = true;
            this.statustxt.Name = "statustxt";
            this.statustxt.Size = new System.Drawing.Size(673, 94);
            this.statustxt.TabIndex = 5;
            // 
            // connectbtn
            // 
            this.connectbtn.Location = new System.Drawing.Point(667, 46);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(80, 23);
            this.connectbtn.TabIndex = 6;
            this.connectbtn.Text = "Connessione";
            this.connectbtn.UseVisualStyleBackColor = true;
            // 
            // Sendbtn
            // 
            this.Sendbtn.Location = new System.Drawing.Point(672, 240);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(75, 23);
            this.Sendbtn.TabIndex = 7;
            this.Sendbtn.Text = "Send";
            this.Sendbtn.UseVisualStyleBackColor = true;
            // 
            // statustxt2
            // 
            this.statustxt2.Location = new System.Drawing.Point(74, 287);
            this.statustxt2.Multiline = true;
            this.statustxt2.Name = "statustxt2";
            this.statustxt2.Size = new System.Drawing.Size(673, 98);
            this.statustxt2.TabIndex = 8;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statustxt2);
            this.Controls.Add(this.Sendbtn);
            this.Controls.Add(this.connectbtn);
            this.Controls.Add(this.statustxt);
            this.Controls.Add(this.textport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textport;
        private System.Windows.Forms.TextBox statustxt;
        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.Button Sendbtn;
        private System.Windows.Forms.TextBox statustxt2;
    }
}

