namespace Bai18
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
            fileToolStripMenuItem = new ToolStripMenuItem();
            windowToolStripMenuItem = new ToolStripMenuItem();
            windowToolStripMenuItem1 = new ToolStripMenuItem();
            tileHorizonalToolStripMenuItem = new ToolStripMenuItem();
            tileVerticallyToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            mùaXuấnToolStripMenuItem = new ToolStripMenuItem();
            mùaHèToolStripMenuItem = new ToolStripMenuItem();
            mùaThuToolStripMenuItem = new ToolStripMenuItem();
            mùaĐôngToolStripMenuItem = new ToolStripMenuItem();
            showToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, windowToolStripMenuItem, windowToolStripMenuItem1, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mùaXuấnToolStripMenuItem, mùaHèToolStripMenuItem, mùaThuToolStripMenuItem, mùaĐôngToolStripMenuItem, showToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // windowToolStripMenuItem
            // 
            windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            windowToolStripMenuItem.Size = new Size(65, 24);
            windowToolStripMenuItem.Text = "Fomat";
            // 
            // windowToolStripMenuItem1
            // 
            windowToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { tileHorizonalToolStripMenuItem, tileVerticallyToolStripMenuItem, cascadeToolStripMenuItem });
            windowToolStripMenuItem1.Name = "windowToolStripMenuItem1";
            windowToolStripMenuItem1.Size = new Size(78, 24);
            windowToolStripMenuItem1.Text = "Window";
            // 
            // tileHorizonalToolStripMenuItem
            // 
            tileHorizonalToolStripMenuItem.Name = "tileHorizonalToolStripMenuItem";
            tileHorizonalToolStripMenuItem.Size = new Size(224, 26);
            tileHorizonalToolStripMenuItem.Text = "Tile Horizontally";
            tileHorizonalToolStripMenuItem.Click += tileHorizonalToolStripMenuItem_Click;
            // 
            // tileVerticallyToolStripMenuItem
            // 
            tileVerticallyToolStripMenuItem.Name = "tileVerticallyToolStripMenuItem";
            tileVerticallyToolStripMenuItem.Size = new Size(224, 26);
            tileVerticallyToolStripMenuItem.Text = "Tile Vertically";
            tileVerticallyToolStripMenuItem.Click += tileVerticallyToolStripMenuItem_Click;
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(224, 26);
            cascadeToolStripMenuItem.Text = "Cascade";
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // mùaXuấnToolStripMenuItem
            // 
            mùaXuấnToolStripMenuItem.Name = "mùaXuấnToolStripMenuItem";
            mùaXuấnToolStripMenuItem.Size = new Size(224, 26);
            mùaXuấnToolStripMenuItem.Text = "Mùa Xuân";
            // 
            // mùaHèToolStripMenuItem
            // 
            mùaHèToolStripMenuItem.Name = "mùaHèToolStripMenuItem";
            mùaHèToolStripMenuItem.Size = new Size(224, 26);
            mùaHèToolStripMenuItem.Text = "Mùa Hè";
            // 
            // mùaThuToolStripMenuItem
            // 
            mùaThuToolStripMenuItem.Name = "mùaThuToolStripMenuItem";
            mùaThuToolStripMenuItem.Size = new Size(224, 26);
            mùaThuToolStripMenuItem.Text = "Mùa Thu";
            // 
            // mùaĐôngToolStripMenuItem
            // 
            mùaĐôngToolStripMenuItem.Name = "mùaĐôngToolStripMenuItem";
            mùaĐôngToolStripMenuItem.Size = new Size(224, 26);
            mùaĐôngToolStripMenuItem.Text = "Mùa Đông";
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(224, 26);
            showToolStripMenuItem.Text = "Show";
            showToolStripMenuItem.Click += showToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
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
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem1;
        private ToolStripMenuItem tileHorizonalToolStripMenuItem;
        private ToolStripMenuItem tileVerticallyToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem mùaXuấnToolStripMenuItem;
        private ToolStripMenuItem mùaHèToolStripMenuItem;
        private ToolStripMenuItem mùaThuToolStripMenuItem;
        private ToolStripMenuItem mùaĐôngToolStripMenuItem;
        private ToolStripMenuItem showToolStripMenuItem;
    }
}
