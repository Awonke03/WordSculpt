namespace WordSculpt
{
    partial class welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome));
            t1 = new System.Windows.Forms.Timer(components);
            pb1 = new ProgressBar();
            pb2 = new ProgressBar();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // t1
            // 
            t1.Tick += t1_Tick;
            // 
            // pb1
            // 
            pb1.Location = new Point(12, 12);
            pb1.Name = "pb1";
            pb1.Size = new Size(460, 10);
            pb1.TabIndex = 1;
            // 
            // pb2
            // 
            pb2.Location = new Point(12, 407);
            pb2.Name = "pb2";
            pb2.Size = new Size(460, 10);
            pb2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(505, 458);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 429);
            Controls.Add(pb2);
            Controls.Add(pb1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "WordSculpt";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer t1;
        private ProgressBar pb1;
        private ProgressBar pb2;
        private PictureBox pictureBox1;
    }
}