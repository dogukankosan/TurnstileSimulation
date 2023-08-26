namespace Turnstile
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
            pctDoor = new PictureBox();
            btnEntry = new Button();
            txtBarcode = new TextBox();
            label1 = new Label();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lblWorkerName = new Label();
            lblErrorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)pctDoor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pctDoor
            // 
            pctDoor.Image = (Image)resources.GetObject("pctDoor.Image");
            pctDoor.Location = new Point(3, 16);
            pctDoor.Name = "pctDoor";
            pctDoor.Size = new Size(531, 338);
            pctDoor.SizeMode = PictureBoxSizeMode.StretchImage;
            pctDoor.TabIndex = 0;
            pctDoor.TabStop = false;
            // 
            // btnEntry
            // 
            btnEntry.BackColor = Color.Black;
            btnEntry.Cursor = Cursors.Hand;
            btnEntry.FlatStyle = FlatStyle.Flat;
            btnEntry.ForeColor = Color.White;
            btnEntry.Location = new Point(406, 151);
            btnEntry.Name = "btnEntry";
            btnEntry.Size = new Size(96, 27);
            btnEntry.TabIndex = 1;
            btnEntry.Text = "GİRİŞ YAP";
            btnEntry.UseVisualStyleBackColor = false;
            btnEntry.Click += btnEntry_Click;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(563, 34);
            txtBarcode.MaxLength = 36;
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(251, 23);
            txtBarcode.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(563, 16);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 4;
            label1.Text = "Kart Numarası:";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(87, 43);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(96, 27);
            btnExit.TabIndex = 2;
            btnExit.Text = "ÇIKIŞ YAP";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(563, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(475, 269);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(77, 77, 77);
            label2.ForeColor = Color.White;
            label2.Location = new Point(594, 110);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Ad Soyad:";
            // 
            // lblWorkerName
            // 
            lblWorkerName.AutoSize = true;
            lblWorkerName.BackColor = Color.FromArgb(77, 77, 77);
            lblWorkerName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblWorkerName.ForeColor = Color.White;
            lblWorkerName.Location = new Point(660, 110);
            lblWorkerName.Name = "lblWorkerName";
            lblWorkerName.Size = new Size(0, 15);
            lblWorkerName.TabIndex = 7;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.BackColor = Color.Black;
            lblErrorMessage.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(600, 213);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(0, 19);
            lblErrorMessage.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1049, 361);
            Controls.Add(lblErrorMessage);
            Controls.Add(lblWorkerName);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(txtBarcode);
            Controls.Add(btnEntry);
            Controls.Add(pctDoor);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pctDoor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctDoor;
        private Button btnEntry;
        private TextBox txtBarcode;
        private Label label1;
        private Button btnExit;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblWorkerName;
        private Label lblErrorMessage;
    }
}