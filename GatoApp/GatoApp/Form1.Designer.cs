namespace GatoApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(369, 376);
            button1.Name = "button1";
            button1.Size = new Size(215, 53);
            button1.TabIndex = 0;
            button1.Text = "Super Smash Bros";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(667, 376);
            button2.Name = "button2";
            button2.Size = new Size(215, 53);
            button2.TabIndex = 1;
            button2.Text = "Mario Kart";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(326, 258);
            label1.Name = "label1";
            label1.Size = new Size(597, 46);
            label1.TabIndex = 2;
            label1.Text = "What Game Are We Playing?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 28);
            label2.Name = "label2";
            label2.Size = new Size(393, 42);
            label2.TabIndex = 3;
            label2.Text = "GATO Team Viewer";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(411, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "GATO Team Viewer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}