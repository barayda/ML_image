namespace ML_image_match
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnLoad1 = new Button();
            btnLoad2 = new Button();
            btnCompare = new Button();
            lblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(445, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(105, 99);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(179, 112);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnLoad1
            // 
            btnLoad1.Location = new Point(445, 38);
            btnLoad1.Name = "btnLoad1";
            btnLoad1.Size = new Size(118, 23);
            btnLoad1.TabIndex = 2;
            btnLoad1.Text = "Resim 1 Yükle";
            btnLoad1.UseVisualStyleBackColor = true;
            btnLoad1.Click += btnLoad1_Click;
            // 
            // btnLoad2
            // 
            btnLoad2.Location = new Point(105, 38);
            btnLoad2.Name = "btnLoad2";
            btnLoad2.Size = new Size(118, 23);
            btnLoad2.TabIndex = 3;
            btnLoad2.Text = "Resim 2 Yükle";
            btnLoad2.UseVisualStyleBackColor = true;
            btnLoad2.Click += btnLoad2_Click;
            // 
            // btnCompare
            // 
            btnCompare.Location = new Point(105, 296);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(75, 23);
            btnCompare.TabIndex = 4;
            btnCompare.Text = "Karşılaştır";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(221, 300);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(63, 15);
            lblResult.TabIndex = 5;
            lblResult.Text = "Benzerlik : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCompare);
            Controls.Add(btnLoad2);
            Controls.Add(btnLoad1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnLoad1;
        private Button btnLoad2;
        private Button btnCompare;
        private Label lblResult;
    }
}
