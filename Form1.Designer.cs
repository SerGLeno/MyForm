namespace MyForm1
{
    partial class MyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            this.bOK = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(342, 12);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 65);
            this.bOK.TabIndex = 0;
            this.bOK.Text = "Сумма";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(107, 12);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(229, 20);
            this.tb1.TabIndex = 1;
            this.tb1.Text = "0";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(24, 19);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(77, 13);
            this.l1.TabIndex = 2;
            this.l1.Text = "Переменная1";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(24, 64);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(77, 13);
            this.l2.TabIndex = 3;
            this.l2.Text = "Переменная2";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(107, 57);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(229, 20);
            this.tb2.TabIndex = 4;
            this.tb2.Text = "0";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 107);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.bOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сумма 2 чисел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.TextBox tb2;
    }
}

