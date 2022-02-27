namespace Translator_using_Google_Translate_API
{
    partial class mainHall
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
            this.richInput = new System.Windows.Forms.RichTextBox();
            this.richOutput = new System.Windows.Forms.RichTextBox();
            this.btTranslate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richInput
            // 
            this.richInput.Location = new System.Drawing.Point(12, 12);
            this.richInput.Name = "richInput";
            this.richInput.Size = new System.Drawing.Size(333, 426);
            this.richInput.TabIndex = 0;
            this.richInput.Text = "I would really like to drive your car around the block a a few times.";
            // 
            // richOutput
            // 
            this.richOutput.Location = new System.Drawing.Point(432, 12);
            this.richOutput.Name = "richOutput";
            this.richOutput.Size = new System.Drawing.Size(356, 426);
            this.richOutput.TabIndex = 1;
            this.richOutput.Text = "";
            // 
            // btTranslate
            // 
            this.btTranslate.Location = new System.Drawing.Point(351, 12);
            this.btTranslate.Name = "btTranslate";
            this.btTranslate.Size = new System.Drawing.Size(75, 23);
            this.btTranslate.TabIndex = 2;
            this.btTranslate.Text = "Translate";
            this.btTranslate.UseVisualStyleBackColor = true;
            this.btTranslate.Click += new System.EventHandler(this.btTranslate_ClickAsync);
            // 
            // mainHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btTranslate);
            this.Controls.Add(this.richOutput);
            this.Controls.Add(this.richInput);
            this.Name = "mainHall";
            this.Text = "Translate using Microsoft Translator API";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richInput;
        private System.Windows.Forms.RichTextBox richOutput;
        private System.Windows.Forms.Button btTranslate;
    }
}

