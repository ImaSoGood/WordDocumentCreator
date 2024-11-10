namespace Konstructor
{
    partial class ListForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.ChangeToList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(434, 251);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonAccept.Location = new System.Drawing.Point(332, 269);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(114, 43);
            this.ButtonAccept.TabIndex = 1;
            this.ButtonAccept.Text = "Принять";
            this.ButtonAccept.UseVisualStyleBackColor = false;
            this.ButtonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // ChangeToList
            // 
            this.ChangeToList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ChangeToList.Location = new System.Drawing.Point(13, 289);
            this.ChangeToList.Name = "ChangeToList";
            this.ChangeToList.Size = new System.Drawing.Size(124, 23);
            this.ChangeToList.TabIndex = 2;
            this.ChangeToList.Text = "Формат списка";
            this.ChangeToList.UseVisualStyleBackColor = false;
            this.ChangeToList.Click += new System.EventHandler(this.ChangeToList_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 324);
            this.Controls.Add(this.ChangeToList);
            this.Controls.Add(this.ButtonAccept);
            this.Controls.Add(this.richTextBox1);
            this.Name = "ListForm";
            this.Text = "Заполните список";
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.Button ChangeToList;
    }
}