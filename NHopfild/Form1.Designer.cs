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
            this.EraseButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.NoiseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox.Location = new System.Drawing.Point(15, 15);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 100);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // identifyButton
            // 
            this.identifyButton.Enabled = false;
            this.identifyButton.Location = new System.Drawing.Point(121, 131);
            this.identifyButton.Name = "identifyButton";
            this.identifyButton.Size = new System.Drawing.Size(75, 52);
            this.identifyButton.TabIndex = 1;
            this.identifyButton.Text = "Распознать";
            this.identifyButton.UseVisualStyleBackColor = true;
            this.identifyButton.Click += new System.EventHandler(this.identifyButton_Click);
            // 
            // learnButton
            // 
            this.learnButton.Enabled = false;
            this.learnButton.Location = new System.Drawing.Point(121, 15);
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
            this.mislearnButton.Location = new System.Drawing.Point(121, 73);
            this.mislearnButton.Name = "mislearnButton";
            this.mislearnButton.Size = new System.Drawing.Size(75, 23);
            this.mislearnButton.TabIndex = 3;
            this.mislearnButton.Text = "Разобучить";
            this.mislearnButton.UseVisualStyleBackColor = true;
            this.mislearnButton.Click += new System.EventHandler(this.mislearnButton_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(16, 160);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(75, 23);
            this.downloadButton.TabIndex = 4;
            this.downloadButton.Text = "Загрузить";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(16, 131);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // EraseButton
            // 
            this.EraseButton.Location = new System.Drawing.Point(121, 44);
            this.EraseButton.Name = "EraseButton";
            this.EraseButton.Size = new System.Drawing.Size(75, 23);
            this.EraseButton.TabIndex = 6;
            this.EraseButton.Text = "Очистить";
            this.EraseButton.UseVisualStyleBackColor = true;
            this.EraseButton.Click += new System.EventHandler(this.eraiseButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.Location = new System.Drawing.Point(12, 199);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(128, 20);
            this.StatusLabel.TabIndex = 7;
            this.StatusLabel.Text = "Готов к работе.";
            // 
            // NoiseButton
            // 
            this.NoiseButton.Location = new System.Drawing.Point(121, 102);
            this.NoiseButton.Name = "NoiseButton";
            this.NoiseButton.Size = new System.Drawing.Size(75, 23);
            this.NoiseButton.TabIndex = 8;
            this.NoiseButton.Text = "Зашумить";
            this.NoiseButton.UseVisualStyleBackColor = true;
            this.NoiseButton.Click += new System.EventHandler(this.NoiseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(220, 228);
            this.Controls.Add(this.NoiseButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.EraseButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.mislearnButton);
            this.Controls.Add(this.learnButton);
            this.Controls.Add(this.identifyButton);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Сеть Хопфилда";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button identifyButton;
        private System.Windows.Forms.Button learnButton;
        private System.Windows.Forms.Button mislearnButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button EraseButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button NoiseButton;
    }
}

