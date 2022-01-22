
namespace IV_SHIFRATOR_MAIN
{
    partial class SH_Main_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SH_Main_Menu));
            this.sh_sended_msg_box_01 = new System.Windows.Forms.TextBox();
            this.sh_button_shifrate = new System.Windows.Forms.Button();
            this.sh_button_deshifrate = new System.Windows.Forms.Button();
            this.sh_cb_logic_show_signs_op = new System.Windows.Forms.CheckBox();
            this.SH_Save_Text_To_File_DLG = new System.Windows.Forms.SaveFileDialog();
            this.sh_b_save_text01 = new System.Windows.Forms.Button();
            this.sh_b_write_created_file = new System.Windows.Forms.Button();
            this.sh_cb_num_text_for_file = new System.Windows.Forms.CheckBox();
            this.sh_b_load_signs_from_f = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sh_b_back_color_change = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sh_m_m_color_dlg = new System.Windows.Forms.ColorDialog();
            this.sh_cb_color_gradient = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.sh_p_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sh_p_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // sh_sended_msg_box_01
            // 
            this.sh_sended_msg_box_01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sh_sended_msg_box_01.Location = new System.Drawing.Point(538, 403);
            this.sh_sended_msg_box_01.Multiline = true;
            this.sh_sended_msg_box_01.Name = "sh_sended_msg_box_01";
            this.sh_sended_msg_box_01.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sh_sended_msg_box_01.Size = new System.Drawing.Size(250, 35);
            this.sh_sended_msg_box_01.TabIndex = 0;
            this.sh_sended_msg_box_01.Text = "Type TEXT to Here!!!";
            this.sh_sended_msg_box_01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sh_sended_msg_box_01.Click += new System.EventHandler(this.SH_DS_Text_Clicked_Hook);
            this.sh_sended_msg_box_01.TextChanged += new System.EventHandler(this.SH_DES_Bar_Text_Changed_Hook);
            this.sh_sended_msg_box_01.Leave += new System.EventHandler(this.SH_DS_Out_Of_Focus_Hook);
            // 
            // sh_button_shifrate
            // 
            this.sh_button_shifrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sh_button_shifrate.BackColor = System.Drawing.Color.Lime;
            this.sh_button_shifrate.Location = new System.Drawing.Point(538, 374);
            this.sh_button_shifrate.Name = "sh_button_shifrate";
            this.sh_button_shifrate.Size = new System.Drawing.Size(75, 23);
            this.sh_button_shifrate.TabIndex = 1;
            this.sh_button_shifrate.Text = "SHIFRATE";
            this.sh_button_shifrate.UseVisualStyleBackColor = false;
            this.sh_button_shifrate.Click += new System.EventHandler(this.SH_B_Shifrate_Hook);
            // 
            // sh_button_deshifrate
            // 
            this.sh_button_deshifrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sh_button_deshifrate.BackColor = System.Drawing.Color.Red;
            this.sh_button_deshifrate.Location = new System.Drawing.Point(705, 374);
            this.sh_button_deshifrate.Name = "sh_button_deshifrate";
            this.sh_button_deshifrate.Size = new System.Drawing.Size(83, 23);
            this.sh_button_deshifrate.TabIndex = 2;
            this.sh_button_deshifrate.Text = "DESHIFRATE";
            this.sh_button_deshifrate.UseVisualStyleBackColor = false;
            this.sh_button_deshifrate.Click += new System.EventHandler(this.SH_B_DEShifrate_Hook);
            // 
            // sh_cb_logic_show_signs_op
            // 
            this.sh_cb_logic_show_signs_op.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sh_cb_logic_show_signs_op.AutoSize = true;
            this.sh_cb_logic_show_signs_op.BackColor = System.Drawing.SystemColors.Info;
            this.sh_cb_logic_show_signs_op.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sh_cb_logic_show_signs_op.Location = new System.Drawing.Point(645, 351);
            this.sh_cb_logic_show_signs_op.Name = "sh_cb_logic_show_signs_op";
            this.sh_cb_logic_show_signs_op.Size = new System.Drawing.Size(143, 17);
            this.sh_cb_logic_show_signs_op.TabIndex = 3;
            this.sh_cb_logic_show_signs_op.Text = "Show Sign for Replacing";
            this.sh_cb_logic_show_signs_op.UseVisualStyleBackColor = false;
            this.sh_cb_logic_show_signs_op.CheckedChanged += new System.EventHandler(this.SH_Check_Sign_S_R_Hook);
            // 
            // SH_Save_Text_To_File_DLG
            // 
            this.SH_Save_Text_To_File_DLG.Title = "Shifrator Save Dialog";
            this.SH_Save_Text_To_File_DLG.FileOk += new System.ComponentModel.CancelEventHandler(this.SH_DLG_Text_Saved_Hook);
            // 
            // sh_b_save_text01
            // 
            this.sh_b_save_text01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sh_b_save_text01.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sh_b_save_text01.Location = new System.Drawing.Point(482, 415);
            this.sh_b_save_text01.Name = "sh_b_save_text01";
            this.sh_b_save_text01.Size = new System.Drawing.Size(50, 23);
            this.sh_b_save_text01.TabIndex = 4;
            this.sh_b_save_text01.Text = "Save";
            this.sh_b_save_text01.UseVisualStyleBackColor = false;
            this.sh_b_save_text01.Click += new System.EventHandler(this.SH_B_Save_To_File_Hook);
            // 
            // sh_b_write_created_file
            // 
            this.sh_b_write_created_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sh_b_write_created_file.BackColor = System.Drawing.Color.OrangeRed;
            this.sh_b_write_created_file.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sh_b_write_created_file.Location = new System.Drawing.Point(482, 386);
            this.sh_b_write_created_file.Name = "sh_b_write_created_file";
            this.sh_b_write_created_file.Size = new System.Drawing.Size(50, 23);
            this.sh_b_write_created_file.TabIndex = 5;
            this.sh_b_write_created_file.Text = "Write";
            this.sh_b_write_created_file.UseVisualStyleBackColor = false;
            this.sh_b_write_created_file.Click += new System.EventHandler(this.SH_B_Write_FIle_Hook);
            // 
            // sh_cb_num_text_for_file
            // 
            this.sh_cb_num_text_for_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sh_cb_num_text_for_file.AutoSize = true;
            this.sh_cb_num_text_for_file.BackColor = System.Drawing.SystemColors.Info;
            this.sh_cb_num_text_for_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sh_cb_num_text_for_file.Location = new System.Drawing.Point(404, 403);
            this.sh_cb_num_text_for_file.Name = "sh_cb_num_text_for_file";
            this.sh_cb_num_text_for_file.Size = new System.Drawing.Size(72, 17);
            this.sh_cb_num_text_for_file.TabIndex = 6;
            this.sh_cb_num_text_for_file.Text = "Num Text";
            this.sh_cb_num_text_for_file.UseVisualStyleBackColor = false;
            this.sh_cb_num_text_for_file.Visible = false;
            this.sh_cb_num_text_for_file.CheckedChanged += new System.EventHandler(this.SH_CB_Num_Text_F_Hook);
            // 
            // sh_b_load_signs_from_f
            // 
            this.sh_b_load_signs_from_f.Animated = true;
            this.sh_b_load_signs_from_f.AutoRoundedCorners = true;
            this.sh_b_load_signs_from_f.BackColor = System.Drawing.Color.Transparent;
            this.sh_b_load_signs_from_f.BorderColor = System.Drawing.Color.White;
            this.sh_b_load_signs_from_f.BorderRadius = 19;
            this.sh_b_load_signs_from_f.CheckedState.Parent = this.sh_b_load_signs_from_f;
            this.sh_b_load_signs_from_f.CustomImages.Parent = this.sh_b_load_signs_from_f;
            this.sh_b_load_signs_from_f.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sh_b_load_signs_from_f.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sh_b_load_signs_from_f.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sh_b_load_signs_from_f.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sh_b_load_signs_from_f.DisabledState.Parent = this.sh_b_load_signs_from_f;
            this.sh_b_load_signs_from_f.FillColor = System.Drawing.Color.Linen;
            this.sh_b_load_signs_from_f.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sh_b_load_signs_from_f.ForeColor = System.Drawing.Color.Black;
            this.sh_b_load_signs_from_f.HoverState.Parent = this.sh_b_load_signs_from_f;
            this.sh_b_load_signs_from_f.Location = new System.Drawing.Point(12, 12);
            this.sh_b_load_signs_from_f.Name = "sh_b_load_signs_from_f";
            this.sh_b_load_signs_from_f.ShadowDecoration.Parent = this.sh_b_load_signs_from_f;
            this.sh_b_load_signs_from_f.Size = new System.Drawing.Size(140, 40);
            this.sh_b_load_signs_from_f.TabIndex = 7;
            this.sh_b_load_signs_from_f.Text = "Load Signs from File";
            this.sh_b_load_signs_from_f.UseTransparentBackground = true;
            this.sh_b_load_signs_from_f.Visible = false;
            this.sh_b_load_signs_from_f.Click += new System.EventHandler(this.SH_B_Load_Signs_From_F_Hook);
            // 
            // sh_b_back_color_change
            // 
            this.sh_b_back_color_change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sh_b_back_color_change.Animated = true;
            this.sh_b_back_color_change.AutoRoundedCorners = true;
            this.sh_b_back_color_change.BackColor = System.Drawing.Color.Transparent;
            this.sh_b_back_color_change.BorderRadius = 12;
            this.sh_b_back_color_change.CheckedState.Parent = this.sh_b_back_color_change;
            this.sh_b_back_color_change.CustomImages.Parent = this.sh_b_back_color_change;
            this.sh_b_back_color_change.DefaultAutoSize = true;
            this.sh_b_back_color_change.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sh_b_back_color_change.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sh_b_back_color_change.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sh_b_back_color_change.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sh_b_back_color_change.DisabledState.Parent = this.sh_b_back_color_change;
            this.sh_b_back_color_change.FillColor = System.Drawing.Color.Azure;
            this.sh_b_back_color_change.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sh_b_back_color_change.ForeColor = System.Drawing.Color.Black;
            this.sh_b_back_color_change.HoverState.Parent = this.sh_b_back_color_change;
            this.sh_b_back_color_change.Location = new System.Drawing.Point(705, 0);
            this.sh_b_back_color_change.Name = "sh_b_back_color_change";
            this.sh_b_back_color_change.ShadowDecoration.Parent = this.sh_b_back_color_change;
            this.sh_b_back_color_change.Size = new System.Drawing.Size(94, 27);
            this.sh_b_back_color_change.TabIndex = 8;
            this.sh_b_back_color_change.Text = "Menu Color";
            this.sh_b_back_color_change.UseTransparentBackground = true;
            this.sh_b_back_color_change.Visible = false;
            this.sh_b_back_color_change.Click += new System.EventHandler(this.SH_M_M_Color_B_Click_Hook);
            // 
            // sh_m_m_color_dlg
            // 
            this.sh_m_m_color_dlg.AnyColor = true;
            this.sh_m_m_color_dlg.FullOpen = true;
            // 
            // sh_cb_color_gradient
            // 
            this.sh_cb_color_gradient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sh_cb_color_gradient.Animated = true;
            this.sh_cb_color_gradient.AutoSize = true;
            this.sh_cb_color_gradient.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.sh_cb_color_gradient.CheckedState.BorderColor = System.Drawing.Color.LightGreen;
            this.sh_cb_color_gradient.CheckedState.BorderRadius = 0;
            this.sh_cb_color_gradient.CheckedState.BorderThickness = 0;
            this.sh_cb_color_gradient.CheckedState.FillColor = System.Drawing.Color.LightGreen;
            this.sh_cb_color_gradient.CheckMarkColor = System.Drawing.Color.Black;
            this.sh_cb_color_gradient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sh_cb_color_gradient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.sh_cb_color_gradient.Location = new System.Drawing.Point(592, 0);
            this.sh_cb_color_gradient.Name = "sh_cb_color_gradient";
            this.sh_cb_color_gradient.Size = new System.Drawing.Size(106, 17);
            this.sh_cb_color_gradient.TabIndex = 9;
            this.sh_cb_color_gradient.Text = "Gradient Colorise";
            this.sh_cb_color_gradient.UncheckedState.BorderColor = System.Drawing.Color.DarkRed;
            this.sh_cb_color_gradient.UncheckedState.BorderRadius = 0;
            this.sh_cb_color_gradient.UncheckedState.BorderThickness = 0;
            this.sh_cb_color_gradient.UncheckedState.FillColor = System.Drawing.Color.DarkRed;
            this.sh_cb_color_gradient.UseVisualStyleBackColor = false;
            this.sh_cb_color_gradient.Visible = false;
            this.sh_cb_color_gradient.CheckedChanged += new System.EventHandler(this.SH_CB_Gradient_State_Hook);
            // 
            // sh_p_logo
            // 
            this.sh_p_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sh_p_logo.Image = global::IV_SHIFRATOR_MAIN.Properties.Resources.ths_icon;
            this.sh_p_logo.Location = new System.Drawing.Point(5, 385);
            this.sh_p_logo.Name = "sh_p_logo";
            this.sh_p_logo.Size = new System.Drawing.Size(64, 64);
            this.sh_p_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sh_p_logo.TabIndex = 10;
            this.sh_p_logo.TabStop = false;
            this.sh_p_logo.Click += new System.EventHandler(this.SH_Logo_Click_Hook);
            // 
            // SH_Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sh_p_logo);
            this.Controls.Add(this.sh_cb_color_gradient);
            this.Controls.Add(this.sh_b_back_color_change);
            this.Controls.Add(this.sh_b_load_signs_from_f);
            this.Controls.Add(this.sh_cb_num_text_for_file);
            this.Controls.Add(this.sh_b_write_created_file);
            this.Controls.Add(this.sh_b_save_text01);
            this.Controls.Add(this.sh_cb_logic_show_signs_op);
            this.Controls.Add(this.sh_button_deshifrate);
            this.Controls.Add(this.sh_button_shifrate);
            this.Controls.Add(this.sh_sended_msg_box_01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SH_Main_Menu";
            this.Text = "SHIFRATOR Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SH_M_M_Closed);
            this.Shown += new System.EventHandler(this.SH_M_M_Showed_Hook);
            ((System.ComponentModel.ISupportInitialize)(this.sh_p_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sh_sended_msg_box_01;
        private System.Windows.Forms.Button sh_button_shifrate;
        private System.Windows.Forms.Button sh_button_deshifrate;
        private System.Windows.Forms.CheckBox sh_cb_logic_show_signs_op;
        private System.Windows.Forms.SaveFileDialog SH_Save_Text_To_File_DLG;
        private System.Windows.Forms.Button sh_b_save_text01;
        private System.Windows.Forms.Button sh_b_write_created_file;
        private System.Windows.Forms.CheckBox sh_cb_num_text_for_file;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sh_b_load_signs_from_f;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sh_b_back_color_change;
        private System.Windows.Forms.ColorDialog sh_m_m_color_dlg;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox sh_cb_color_gradient;
        private System.Windows.Forms.PictureBox sh_p_logo;
    }
}