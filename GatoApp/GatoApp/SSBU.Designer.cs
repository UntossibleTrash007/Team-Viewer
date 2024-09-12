namespace GatoApp
{
    partial class SSBU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SSBU));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            Current = new Label();
            Queue = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            textBox1 = new TextBox();
            Enter = new Label();
            HasController = new CheckBox();
            submit = new Button();
            Reset = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(402, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 32);
            label2.Name = "label2";
            label2.Size = new Size(393, 42);
            label2.TabIndex = 5;
            label2.Text = "GATO Team Viewer";
            // 
            // Current
            // 
            Current.AutoSize = true;
            Current.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Current.Location = new Point(152, 558);
            Current.Name = "Current";
            Current.Size = new Size(242, 32);
            Current.TabIndex = 7;
            Current.Text = "Current Players";
            // 
            // Queue
            // 
            Queue.AutoSize = true;
            Queue.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Queue.Location = new Point(1001, 558);
            Queue.Name = "Queue";
            Queue.Size = new Size(104, 32);
            Queue.TabIndex = 8;
            Queue.Text = "Queue";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(98, 159);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(323, 361);
            listBox1.TabIndex = 9;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 17;
            listBox2.Location = new Point(880, 171);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(323, 361);
            listBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.Location = new Point(479, 331);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(337, 27);
            textBox1.TabIndex = 11;
            // 
            // Enter
            // 
            Enter.AutoSize = true;
            Enter.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Enter.Location = new Point(517, 291);
            Enter.Name = "Enter";
            Enter.Size = new Size(238, 26);
            Enter.TabIndex = 12;
            Enter.Text = "Enter Player Name:";
            // 
            // HasController
            // 
            HasController.AutoSize = true;
            HasController.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            HasController.Location = new Point(452, 394);
            HasController.Name = "HasController";
            HasController.Size = new Size(400, 24);
            HasController.TabIndex = 13;
            HasController.Text = "Does the player have their own controller?";
            HasController.UseVisualStyleBackColor = true;
            HasController.CheckedChanged += HasController_CheckedChanged;
            // 
            // submit
            // 
            submit.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            submit.Location = new Point(568, 450);
            submit.Name = "submit";
            submit.Size = new Size(187, 40);
            submit.TabIndex = 14;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // Reset
            // 
            Reset.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Reset.Location = new Point(162, 602);
            Reset.Name = "Reset";
            Reset.Size = new Size(212, 40);
            Reset.TabIndex = 15;
            Reset.Text = "Next Players";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // SSBU
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(Reset);
            Controls.Add(submit);
            Controls.Add(HasController);
            Controls.Add(Enter);
            Controls.Add(textBox1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(Queue);
            Controls.Add(Current);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Name = "SSBU";
            Text = "SSBU";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label Current;
        private Label Queue;
        private ListBox listBox1;
        private ListBox listBox2;
        private TextBox textBox1;
        private Label Enter;
        private CheckBox HasController;
        private Button submit;
        private Button Reset;
    }
}