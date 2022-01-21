
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
            this.sh_l_m_button_exit = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sh_nodes_label_01 = new System.Windows.Forms.Label();
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
            this.sh_loading_w_p_bar.Visible = false;
            // 
            // sh_l_m_button_exit
            // 
            this.sh_l_m_button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sh_l_m_button_exit.Animated = true;
            this.sh_l_m_button_exit.AutoRoundedCorners = true;
            this.sh_l_m_button_exit.BackColor = System.Drawing.Color.Transparent;
            this.sh_l_m_button_exit.BorderRadius = 15;
            this.sh_l_m_button_exit.CheckedState.Parent = this.sh_l_m_button_exit;
            this.sh_l_m_button_exit.CustomImages.Parent = this.sh_l_m_button_exit;
            this.sh_l_m_button_exit.DefaultAutoSize = true;
            this.sh_l_m_button_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sh_l_m_button_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sh_l_m_button_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sh_l_m_button_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sh_l_m_button_exit.DisabledState.Parent = this.sh_l_m_button_exit;
            this.sh_l_m_button_exit.FillColor = System.Drawing.Color.Red;
            this.sh_l_m_button_exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sh_l_m_button_exit.ForeColor = System.Drawing.Color.White;
            this.sh_l_m_button_exit.HoverState.Parent = this.sh_l_m_button_exit;
            this.sh_l_m_button_exit.Location = new System.Drawing.Point(759, 0);
            this.sh_l_m_button_exit.Name = "sh_l_m_button_exit";
            this.sh_l_m_button_exit.ShadowDecoration.Parent = this.sh_l_m_button_exit;
            this.sh_l_m_button_exit.Size = new System.Drawing.Size(41, 33);
            this.sh_l_m_button_exit.TabIndex = 2;
            this.sh_l_m_button_exit.Text = "X";
            this.sh_l_m_button_exit.UseTransparentBackground = true;
            this.sh_l_m_button_exit.Visible = false;
            this.sh_l_m_button_exit.Click += new System.EventHandler(this.SH_B_Exit_Clicked_Hook);
            // 
            // sh_nodes_label_01
            // 
            this.sh_nodes_label_01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sh_nodes_label_01.BackColor = System.Drawing.SystemColors.Menu;
            this.sh_nodes_label_01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sh_nodes_label_01.Location = new System.Drawing.Point(9, 411);
            this.sh_nodes_label_01.Name = "sh_nodes_label_01";
            this.sh_nodes_label_01.Size = new System.Drawing.Size(180, 30);
            this.sh_nodes_label_01.TabIndex = 3;
            this.sh_nodes_label_01.Text = "FIXME!!!";
            this.sh_nodes_label_01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SH_Loading_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sh_nodes_label_01);
            this.Controls.Add(this.sh_l_m_button_exit);
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
            this.Load += new System.EventHandler(this.SH_L_M_Loaded);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sh_name_label01;
        private System.Windows.Forms.ProgressBar sh_loading_w_p_bar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sh_l_m_button_exit;
        private System.Windows.Forms.Label sh_nodes_label_01;
    }
}

