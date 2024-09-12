namespace GatoApp
{
    partial class MK8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MK8));
            Reset = new Button();
            submit = new Button();
            HasController = new CheckBox();
            Enter = new Label();
            textBox1 = new TextBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            Queue = new Label();
            Current = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Reset
            // 
            Reset.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Reset.Location = new Point(190, 617);
            Reset.Name = "Reset";
            Reset.Size = new Size(212, 40);
            Reset.TabIndex = 26;
            Reset.Text = "Next Players";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // submit
            // 
            submit.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            submit.Location = new Point(596, 465);
            submit.Name = "submit";
            submit.Size = new Size(187, 40);
            submit.TabIndex = 25;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // HasController
            // 
            HasController.AutoSize = true;
            HasController.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            HasController.Location = new Point(480, 409);
            HasController.Name = "HasController";
            HasController.Size = new Size(400, 24);
            HasController.TabIndex = 24;
            HasController.Text = "Does the player have their own controller?";
            HasController.UseVisualStyleBackColor = true;
            // 
            // Enter
            // 
            Enter.AutoSize = true;
            Enter.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Enter.Location = new Point(545, 306);
            Enter.Name = "Enter";
            Enter.Size = new Size(238, 26);
            Enter.TabIndex = 23;
            Enter.Text = "Enter Player Name:";
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.Location = new Point(507, 346);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(337, 27);
            textBox1.TabIndex = 22;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 17;
            listBox2.Location = new Point(908, 186);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(323, 361);
            listBox2.TabIndex = 21;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(126, 174);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(323, 361);
            listBox1.TabIndex = 20;
            // 
            // Queue
            // 
            Queue.AutoSize = true;
            Queue.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Queue.Location = new Point(1029, 573);
            Queue.Name = "Queue";
            Queue.Size = new Size(104, 32);
            Queue.TabIndex = 19;
            Queue.Text = "Queue";
            // 
            // Current
            // 
            Current.AutoSize = true;
            Current.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Current.Location = new Point(180, 573);
            Current.Name = "Current";
            Current.Size = new Size(242, 32);
            Current.TabIndex = 18;
            Current.Text = "Current Players";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(430, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 47);
            label2.Name = "label2";
            label2.Size = new Size(393, 42);
            label2.TabIndex = 16;
            label2.Text = "GATO Team Viewer";
            // 
            // MK8
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
            Name = "MK8";
            Text = "MK8";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Reset;
        private Button submit;
        private CheckBox HasController;
        private Label Enter;
        private TextBox textBox1;
        private ListBox listBox2;
        private ListBox listBox1;
        private Label Queue;
        private Label Current;
        private PictureBox pictureBox1;
        private Label label2;
    }
}