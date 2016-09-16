namespace WindowsFormsApplication2
{
    partial class PlayGame
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
            this.button1 = new System.Windows.Forms.Button();
            this.countdown = new System.Windows.Forms.Label();
            this.begin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(85, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // countdown
            // 
            this.countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown.ForeColor = System.Drawing.Color.White;
            this.countdown.Location = new System.Drawing.Point(61, 182);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(164, 23);
            this.countdown.TabIndex = 1;
            this.countdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countdown.Click += new System.EventHandler(this.countdown_Click);
            // 
            // begin
            // 
            this.begin.Location = new System.Drawing.Point(12, 133);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(75, 23);
            this.begin.TabIndex = 2;
            this.begin.Text = "Begin!";
            this.begin.UseVisualStyleBackColor = true;
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "PlayGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PlayGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.Button begin;
    }
}

