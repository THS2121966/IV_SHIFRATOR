
namespace IV_SHIFRATOR_MAIN
{
    partial class SH_Loading_Window
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
            this.sh_name_label01 = new System.Windows.Forms.Label();
            this.sh_loading_w_p_bar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // sh_name_label01
            // 
            this.sh_name_label01.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sh_name_label01.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sh_name_label01.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sh_name_label01.Location = new System.Drawing.Point(150, 80);
            this.sh_name_label01.Name = "sh_name_label01";
            this.sh_name_label01.Size = new System.Drawing.Size(450, 50);
            this.sh_name_label01.TabIndex = 0;
            this.sh_name_label01.Text = "SHIFRATOR";
            this.sh_name_label01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sh_loading_w_p_bar
            // 
            this.sh_loading_w_p_bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sh_loading_w_p_bar.ForeColor = System.Drawing.Color.LawnGreen;
            this.sh_loading_w_p_bar.Location = new System.Drawing.Point(0, 150);
            this.sh_loading_w_p_bar.Name = "sh_loading_w_p_bar";
            this.sh_loading_w_p_bar.Size = new System.Drawing.Size(800, 25);
            this.sh_loading_w_p_bar.TabIndex = 1;
            // 
            // SH_Loading_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sh_loading_w_p_bar);
            this.Controls.Add(this.sh_name_label01);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SH_Loading_Window";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SH Loading Window";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label sh_name_label01;
        private System.Windows.Forms.ProgressBar sh_loading_w_p_bar;
    }
}

