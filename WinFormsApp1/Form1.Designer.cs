namespace WinFormsApp1
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
            label1 = new Label();
            Miasto = new TextBox();
            button = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            temperature = new Label();
            labelwind = new Label();
            description = new Label();
            wind = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(67, 63);
            label1.Name = "label1";
            label1.Size = new Size(101, 33);
            label1.TabIndex = 0;
            label1.Text = "Miasto:";
            // 
            // Miasto
            // 
            Miasto.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Miasto.Location = new Point(161, 64);
            Miasto.Name = "Miasto";
            Miasto.Size = new Size(233, 33);
            Miasto.TabIndex = 1;
            // 
            // button
            // 
            button.BackColor = Color.Transparent;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button.ForeColor = Color.White;
            button.Location = new Point(400, 63);
            button.Name = "button";
            button.Size = new Size(91, 34);
            button.TabIndex = 2;
            button.Text = "Szukaj";
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(228, 140);
            label2.Name = "label2";
            label2.Size = new Size(164, 33);
            label2.TabIndex = 3;
            label2.Text = "Temperatura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.White;
            label3.Location = new Point(192, 185);
            label3.Name = "label3";
            label3.Size = new Size(202, 33);
            label3.TabIndex = 4;
            label3.Text = "Prędkość wiatru:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.White;
            label4.Location = new Point(232, 228);
            label4.Name = "label4";
            label4.Size = new Size(162, 33);
            label4.TabIndex = 5;
            label4.Text = "Opis pogody:";
            // 
            // temperature
            // 
            temperature.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            temperature.AutoSize = true;
            temperature.BackColor = Color.Transparent;
            temperature.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            temperature.ForeColor = Color.White;
            temperature.Location = new Point(400, 140);
            temperature.Name = "temperature";
            temperature.Size = new Size(60, 33);
            temperature.TabIndex = 6;
            temperature.Text = "N/A";
            // 
            // labelwind
            // 
            labelwind.AutoSize = true;
            labelwind.BackColor = Color.Transparent;
            labelwind.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelwind.ForeColor = Color.White;
            labelwind.Location = new Point(400, 185);
            labelwind.Name = "labelwind";
            labelwind.Size = new Size(0, 33);
            labelwind.TabIndex = 7;
            // 
            // description
            // 
            description.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            description.AutoSize = true;
            description.BackColor = Color.Transparent;
            description.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            description.ForeColor = Color.White;
            description.Location = new Point(400, 228);
            description.Name = "description";
            description.Size = new Size(60, 33);
            description.TabIndex = 8;
            description.Text = "N/A";
            // 
            // wind
            // 
            wind.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wind.AutoSize = true;
            wind.BackColor = Color.Transparent;
            wind.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            wind.ForeColor = Color.White;
            wind.Location = new Point(400, 185);
            wind.Name = "wind";
            wind.Size = new Size(60, 33);
            wind.TabIndex = 9;
            wind.Text = "N/A";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(332, 264);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(161, 35);
            label5.Name = "label5";
            label5.Size = new Size(0, 26);
            label5.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(wind);
            Controls.Add(description);
            Controls.Add(labelwind);
            Controls.Add(temperature);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button);
            Controls.Add(Miasto);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Miasto;
        private Button button;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelwind;
        private Label description;
        public Label temperature;
        public Label wind;
        private PictureBox pictureBox1;
        private Label label5;
    }
}
