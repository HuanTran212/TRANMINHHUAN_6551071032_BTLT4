namespace Bai15_Ex3
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            trackBar1 = new TrackBar();
            progressBar1 = new ProgressBar();
            lblComplete = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(143, 208);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(278, 56);
            trackBar1.TabIndex = 0;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(143, 82);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(278, 29);
            progressBar1.TabIndex = 1;
            // 
            // lblComplete
            // 
            lblComplete.AutoSize = true;
            lblComplete.Location = new Point(143, 152);
            lblComplete.Name = "lblComplete";
            lblComplete.Size = new Size(170, 20);
            lblComplete.TabIndex = 2;
            lblComplete.Text = "Percentage Complete: %";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblComplete);
            Controls.Add(progressBar1);
            Controls.Add(trackBar1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private TrackBar trackBar1;
        private ProgressBar progressBar1;
        private Label lblComplete;
    }
}
