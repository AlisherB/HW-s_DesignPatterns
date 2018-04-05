namespace HW_DP_27._03._18
{
    partial class MainForm
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
            this.multiline_checkBox = new System.Windows.Forms.CheckBox();
            this.vscroll_checkBox = new System.Windows.Forms.CheckBox();
            this.hscroll_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // multiline_checkBox
            // 
            this.multiline_checkBox.AutoSize = true;
            this.multiline_checkBox.Location = new System.Drawing.Point(13, 13);
            this.multiline_checkBox.Name = "multiline_checkBox";
            this.multiline_checkBox.Size = new System.Drawing.Size(68, 17);
            this.multiline_checkBox.TabIndex = 0;
            this.multiline_checkBox.Text = "MultiLine";
            this.multiline_checkBox.UseVisualStyleBackColor = true;
            this.multiline_checkBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // vscroll_checkBox
            // 
            this.vscroll_checkBox.AutoSize = true;
            this.vscroll_checkBox.Location = new System.Drawing.Point(13, 54);
            this.vscroll_checkBox.Name = "vscroll_checkBox";
            this.vscroll_checkBox.Size = new System.Drawing.Size(59, 17);
            this.vscroll_checkBox.TabIndex = 1;
            this.vscroll_checkBox.Text = "VScroll";
            this.vscroll_checkBox.UseVisualStyleBackColor = true;
            this.vscroll_checkBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // hscroll_checkBox
            // 
            this.hscroll_checkBox.AutoSize = true;
            this.hscroll_checkBox.Location = new System.Drawing.Point(13, 95);
            this.hscroll_checkBox.Name = "hscroll_checkBox";
            this.hscroll_checkBox.Size = new System.Drawing.Size(60, 17);
            this.hscroll_checkBox.TabIndex = 2;
            this.hscroll_checkBox.Text = "HScroll";
            this.hscroll_checkBox.UseVisualStyleBackColor = true;
            this.hscroll_checkBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 131);
            this.Controls.Add(this.hscroll_checkBox);
            this.Controls.Add(this.vscroll_checkBox);
            this.Controls.Add(this.multiline_checkBox);
            this.MaximumSize = new System.Drawing.Size(380, 170);
            this.MinimumSize = new System.Drawing.Size(380, 170);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox multiline_checkBox;
        private System.Windows.Forms.CheckBox vscroll_checkBox;
        private System.Windows.Forms.CheckBox hscroll_checkBox;
    }
}

