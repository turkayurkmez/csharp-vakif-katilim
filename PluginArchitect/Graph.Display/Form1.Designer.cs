namespace Graph.Display
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
            menuStrip1 = new MenuStrip();
            pluginsToolStripMenuItem = new ToolStripMenuItem();
            pluginEkleToolStripMenuItem = new ToolStripMenuItem();
            plugsToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            textBoxX = new TextBox();
            buttonColor = new Button();
            textBoxY = new TextBox();
            textBoxWidth = new TextBox();
            textBoxHeight = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { pluginsToolStripMenuItem, plugsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // pluginsToolStripMenuItem
            // 
            pluginsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pluginEkleToolStripMenuItem });
            pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            pluginsToolStripMenuItem.Size = new Size(58, 20);
            pluginsToolStripMenuItem.Text = "Plugins";
            // 
            // pluginEkleToolStripMenuItem
            // 
            pluginEkleToolStripMenuItem.Name = "pluginEkleToolStripMenuItem";
            pluginEkleToolStripMenuItem.Size = new Size(132, 22);
            pluginEkleToolStripMenuItem.Text = "Plugin Ekle";
            pluginEkleToolStripMenuItem.Click += pluginEkleToolStripMenuItem_Click;
            // 
            // plugsToolStripMenuItem
            // 
            plugsToolStripMenuItem.Name = "plugsToolStripMenuItem";
            plugsToolStripMenuItem.Size = new Size(60, 20);
            plugsToolStripMenuItem.Text = "İşlemler";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(151, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 331);
            panel1.TabIndex = 1;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(17, 47);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(100, 23);
            textBoxX.TabIndex = 2;
            // 
            // buttonColor
            // 
            buttonColor.Location = new Point(441, 45);
            buttonColor.Name = "buttonColor";
            buttonColor.Size = new Size(137, 23);
            buttonColor.TabIndex = 3;
            buttonColor.Text = "Renk Seçiniz";
            buttonColor.UseVisualStyleBackColor = true;
            buttonColor.Click += buttonColor_Click;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(123, 47);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(100, 23);
            textBoxY.TabIndex = 4;
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(229, 47);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(100, 23);
            textBoxWidth.TabIndex = 5;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(335, 46);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(100, 23);
            textBoxHeight.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxHeight);
            Controls.Add(textBoxWidth);
            Controls.Add(textBoxY);
            Controls.Add(buttonColor);
            Controls.Add(textBoxX);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pluginsToolStripMenuItem;
        private ToolStripMenuItem pluginEkleToolStripMenuItem;
        private ToolStripMenuItem plugsToolStripMenuItem;
        private Panel panel1;
        private TextBox textBoxX;
        private Button buttonColor;
        private TextBox textBoxY;
        private TextBox textBoxWidth;
        private TextBox textBoxHeight;
    }
}