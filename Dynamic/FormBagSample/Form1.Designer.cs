namespace FormBagSample
{
    partial class Form1
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
            buttonSend = new Button();
            textBoxValue = new TextBox();
            SuspendLayout();
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(180, 92);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(75, 23);
            buttonSend.TabIndex = 0;
            buttonSend.Text = "Gönder";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(155, 63);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(100, 23);
            textBoxValue.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 246);
            Controls.Add(textBoxValue);
            Controls.Add(buttonSend);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSend;
        private TextBox textBoxValue;
    }
}