﻿namespace testingStuffs
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
            this.buttonSayHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSayHello
            // 
            this.buttonSayHello.Location = new System.Drawing.Point(78, 61);
            this.buttonSayHello.Name = "buttonSayHello";
            this.buttonSayHello.Size = new System.Drawing.Size(75, 23);
            this.buttonSayHello.TabIndex = 0;
            this.buttonSayHello.Text = "Say Hello";
            this.buttonSayHello.UseVisualStyleBackColor = true;
            this.buttonSayHello.Click += new System.EventHandler(this.buttonSayHello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 156);
            this.Controls.Add(this.buttonSayHello);
            this.Name = "Form1";
            this.Text = "Saying Hello ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSayHello;
    }
}

