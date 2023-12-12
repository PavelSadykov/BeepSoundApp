namespace BeepSoundApp
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
            this.btnMessageBeep = new System.Windows.Forms.Button();
            this.btnBeep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMessageBeep
            // 
            this.btnMessageBeep.Location = new System.Drawing.Point(492, 214);
            this.btnMessageBeep.Name = "btnMessageBeep";
            this.btnMessageBeep.Size = new System.Drawing.Size(75, 23);
            this.btnMessageBeep.TabIndex = 3;
            this.btnMessageBeep.Text = "Сигнал2";
            this.btnMessageBeep.UseVisualStyleBackColor = true;
            this.btnMessageBeep.Click += new System.EventHandler(this.btnMessageBeep_Click);
            // 
            // btnBeep
            // 
            this.btnBeep.Location = new System.Drawing.Point(234, 214);
            this.btnBeep.Name = "btnBeep";
            this.btnBeep.Size = new System.Drawing.Size(75, 23);
            this.btnBeep.TabIndex = 2;
            this.btnBeep.Text = "Сигнал1";
            this.btnBeep.UseVisualStyleBackColor = true;
            this.btnBeep.Click += new System.EventHandler(this.btnBeep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMessageBeep);
            this.Controls.Add(this.btnBeep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMessageBeep;
        private System.Windows.Forms.Button btnBeep;
    }
}

