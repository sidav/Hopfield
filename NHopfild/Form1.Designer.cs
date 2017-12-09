namespace NHopfild
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.identifyButton = new System.Windows.Forms.Button();
            this.learnButton = new System.Windows.Forms.Button();
            this.mislearnButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.eraiseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox.Location = new System.Drawing.Point(39, 31);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 100);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // identifyButton
            // 
            this.identifyButton.Enabled = false;
            this.identifyButton.Location = new System.Drawing.Point(178, 31);
            this.identifyButton.Name = "identifyButton";
            this.identifyButton.Size = new System.Drawing.Size(75, 23);
            this.identifyButton.TabIndex = 1;
            this.identifyButton.Text = "Распознать";
            this.identifyButton.UseVisualStyleBackColor = true;
            this.identifyButton.Click += new System.EventHandler(this.identifyButton_Click);
            // 
            // learnButton
            // 
            this.learnButton.Enabled = false;
            this.learnButton.Location = new System.Drawing.Point(178, 60);
            this.learnButton.Name = "learnButton";
            this.learnButton.Size = new System.Drawing.Size(75, 23);
            this.learnButton.TabIndex = 2;
            this.learnButton.Text = "Обучить";
            this.learnButton.UseVisualStyleBackColor = true;
            this.learnButton.Click += new System.EventHandler(this.learnButton_Click);
            // 
            // mislearnButton
            // 
            this.mislearnButton.Enabled = false;
            this.mislearnButton.Location = new System.Drawing.Point(178, 89);
            this.mislearnButton.Name = "mislearnButton";
            this.mislearnButton.Size = new System.Drawing.Size(75, 23);
            this.mislearnButton.TabIndex = 3;
            this.mislearnButton.Text = "Разобучить";
            this.mislearnButton.UseVisualStyleBackColor = true;
            this.mislearnButton.Click += new System.EventHandler(this.mislearnButton_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(178, 118);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(75, 23);
            this.downloadButton.TabIndex = 4;
            this.downloadButton.Text = "Загрузить";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(178, 147);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // eraiseButton
            // 
            this.eraiseButton.Location = new System.Drawing.Point(178, 176);
            this.eraiseButton.Name = "eraiseButton";
            this.eraiseButton.Size = new System.Drawing.Size(75, 23);
            this.eraiseButton.TabIndex = 6;
            this.eraiseButton.Text = "Очистить";
            this.eraiseButton.UseVisualStyleBackColor = true;
            this.eraiseButton.Click += new System.EventHandler(this.eraiseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.eraiseButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.mislearnButton);
            this.Controls.Add(this.learnButton);
            this.Controls.Add(this.identifyButton);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Сеть Хопфилда";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button identifyButton;
        private System.Windows.Forms.Button learnButton;
        private System.Windows.Forms.Button mislearnButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button eraiseButton;
    }
}

