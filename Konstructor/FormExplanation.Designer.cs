namespace Konstructor
{
    partial class FormExplanation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExplanation));
            this.TextField = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TextField
            // 
            this.TextField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextField.Location = new System.Drawing.Point(0, 0);
            this.TextField.Margin = new System.Windows.Forms.Padding(4);
            this.TextField.Name = "TextField";
            this.TextField.Size = new System.Drawing.Size(800, 450);
            this.TextField.TabIndex = 2;
            this.TextField.Text = "";
            // 
            // FormExplanation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormExplanation";
            this.Load += new System.EventHandler(this.ExplanationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextField;
    }
}