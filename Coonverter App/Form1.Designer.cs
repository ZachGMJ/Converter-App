namespace Coonverter_App
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
            label1 = new Label();
            label2 = new Label();
            converted = new Label();
            Convert = new Button();
            ClearRes = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            Save = new Button();
            SaveFile = new Button();
            clearList = new Button();
            tracker = new Label();
            List = new RichTextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(370, 61);
            label1.Name = "label1";
            label1.Size = new Size(225, 41);
            label1.TabIndex = 0;
            label1.Text = "Converter App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(370, 148);
            label2.Name = "label2";
            label2.Size = new Size(212, 62);
            label2.TabIndex = 1;
            label2.Text = "Enter a value and\r\nchoose conversion";
            // 
            // converted
            // 
            converted.AutoSize = true;
            converted.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            converted.Location = new Point(370, 508);
            converted.Name = "converted";
            converted.Size = new Size(99, 31);
            converted.TabIndex = 2;
            converted.Text = "Waiting";
            converted.Visible = false;
            // 
            // Convert
            // 
            Convert.BackColor = Color.FromArgb(128, 128, 255);
            Convert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Convert.ForeColor = Color.Black;
            Convert.Location = new Point(370, 427);
            Convert.Name = "Convert";
            Convert.Size = new Size(196, 46);
            Convert.TabIndex = 3;
            Convert.Text = "Convert";
            Convert.UseVisualStyleBackColor = false;
            Convert.Click += Convert_Click;
            // 
            // ClearRes
            // 
            ClearRes.BackColor = Color.FromArgb(128, 128, 255);
            ClearRes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearRes.ForeColor = Color.Black;
            ClearRes.Location = new Point(370, 622);
            ClearRes.Name = "ClearRes";
            ClearRes.Size = new Size(203, 46);
            ClearRes.TabIndex = 5;
            ClearRes.Text = "Clear Results";
            ClearRes.UseVisualStyleBackColor = false;
            ClearRes.Click += ClearRes_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(13, 35);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(175, 29);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Inches to Meters";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(13, 75);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(175, 29);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Meters to Inches";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Purple;
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(370, 251);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 153);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Convert Measurement";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.building;
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 292);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Purple;
            textBox1.Location = new Point(633, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 27);
            textBox1.TabIndex = 10;
            // 
            // Save
            // 
            Save.BackColor = Color.FromArgb(128, 128, 255);
            Save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Save.ForeColor = Color.Black;
            Save.Location = new Point(370, 560);
            Save.Name = "Save";
            Save.Size = new Size(203, 46);
            Save.TabIndex = 11;
            Save.Text = "Save Results";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // SaveFile
            // 
            SaveFile.BackColor = Color.FromArgb(128, 128, 255);
            SaveFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveFile.ForeColor = Color.Black;
            SaveFile.Location = new Point(186, 674);
            SaveFile.Name = "SaveFile";
            SaveFile.Size = new Size(149, 46);
            SaveFile.TabIndex = 13;
            SaveFile.Text = "Save to file";
            SaveFile.UseVisualStyleBackColor = false;
            SaveFile.Click += SaveFile_Click;
            // 
            // clearList
            // 
            clearList.BackColor = Color.FromArgb(128, 128, 255);
            clearList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearList.ForeColor = Color.Black;
            clearList.Location = new Point(23, 674);
            clearList.Name = "clearList";
            clearList.Size = new Size(146, 46);
            clearList.TabIndex = 14;
            clearList.Text = "Clear List";
            clearList.UseVisualStyleBackColor = false;
            clearList.Click += clearList_Click;
            // 
            // tracker
            // 
            tracker.AutoSize = true;
            tracker.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tracker.Location = new Point(370, 681);
            tracker.Name = "tracker";
            tracker.Size = new Size(388, 31);
            tracker.TabIndex = 15;
            tracker.Text = "Saved 0 entries to file measures.txt";
            tracker.Visible = false;
            // 
            // List
            // 
            List.Enabled = false;
            List.Location = new Point(1, 297);
            List.Name = "List";
            List.Size = new Size(350, 371);
            List.TabIndex = 16;
            List.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(897, 762);
            Controls.Add(List);
            Controls.Add(tracker);
            Controls.Add(clearList);
            Controls.Add(SaveFile);
            Controls.Add(Save);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(ClearRes);
            Controls.Add(Convert);
            Controls.Add(converted);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Converter";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label converted;
        private Button Convert;
        private Button ClearRes;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button Save;
        private Button SaveFile;
        private Button clearList;
        private Label tracker;
        private RichTextBox List;
    }
}
