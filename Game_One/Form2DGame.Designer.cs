namespace Game_One
{
    partial class Form2DGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2DGame));
            this.Maiin_Taimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.saveBatton = new System.Windows.Forms.Button();
            this.loadBatton = new System.Windows.Forms.Button();
            this.generatButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ExitBatton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Maiin_Taimer
            // 
            this.Maiin_Taimer.Enabled = true;
            this.Maiin_Taimer.Interval = 41;
            this.Maiin_Taimer.Tick += new System.EventHandler(this.Maiin_Taimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = global::Game_One.Resource1.Disert1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.Location = new System.Drawing.Point(133, 729);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 48);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackgroundImage = global::Game_One.Resource1.Graund;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.No;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.Location = new System.Drawing.Point(68, 729);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 48);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // saveBatton
            // 
            this.saveBatton.Location = new System.Drawing.Point(1061, 9);
            this.saveBatton.Name = "saveBatton";
            this.saveBatton.Size = new System.Drawing.Size(75, 23);
            this.saveBatton.TabIndex = 7;
            this.saveBatton.Text = "Сохранить";
            this.saveBatton.UseVisualStyleBackColor = true;
            this.saveBatton.Click += new System.EventHandler(this.SaveBattonClick);
            // 
            // loadBatton
            // 
            this.loadBatton.Location = new System.Drawing.Point(1142, 9);
            this.loadBatton.Name = "loadBatton";
            this.loadBatton.Size = new System.Drawing.Size(75, 23);
            this.loadBatton.TabIndex = 8;
            this.loadBatton.Text = "Загрузить";
            this.loadBatton.UseVisualStyleBackColor = true;
            this.loadBatton.Click += new System.EventHandler(this.LoadBattonClick);
            // 
            // generatButton
            // 
            this.generatButton.Location = new System.Drawing.Point(1061, 38);
            this.generatButton.Name = "generatButton";
            this.generatButton.Size = new System.Drawing.Size(75, 23);
            this.generatButton.TabIndex = 9;
            this.generatButton.Text = "Генерация";
            this.generatButton.UseVisualStyleBackColor = true;
            this.generatButton.Click += new System.EventHandler(this.GeneratButtonClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::Game_One.Resource1.Graund_And_Green;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(3, 729);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 49);
            this.button1.TabIndex = 4;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitBatton
            // 
            this.ExitBatton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBatton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBatton.BackgroundImage")));
            this.ExitBatton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBatton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBatton.ForeColor = System.Drawing.Color.Snow;
            this.ExitBatton.Location = new System.Drawing.Point(1237, 9);
            this.ExitBatton.Name = "ExitBatton";
            this.ExitBatton.Size = new System.Drawing.Size(41, 37);
            this.ExitBatton.TabIndex = 1;
            this.ExitBatton.UseVisualStyleBackColor = true;
            this.ExitBatton.Click += new System.EventHandler(this.ExitBatton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1142, 38);
            this.button4.Name = "ShowMap";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Карта";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ShowMap);
            // 
            // Form2DGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.generatButton);
            this.Controls.Add(this.loadBatton);
            this.Controls.Add(this.saveBatton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBatton);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1280, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 800);
            this.Name = "Form2DGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game_One";
            this.Click += new System.EventHandler(this.SetBlock);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBatton;
        private System.Windows.Forms.Timer Maiin_Taimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button saveBatton;
        private System.Windows.Forms.Button loadBatton;
        private System.Windows.Forms.Button generatButton;
        private System.Windows.Forms.Button button4;
    }
}

