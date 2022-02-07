
namespace IV_Console
{
    partial class IV_Console_Window
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IV_Console_Window));
            this.iv_console_b_exit = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.iv_panel_control_buttons = new System.Windows.Forms.Panel();
            this.iv_console_text_resiser_bar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.iv_console_panel = new System.Windows.Forms.TextBox();
            this.iv_console_send_panel = new System.Windows.Forms.TextBox();
            this.iv_b_send_to_console = new System.Windows.Forms.Button();
            this.iv_console_text_helper = new System.Windows.Forms.Label();
            this.iv_console_scroll_tip = new System.Windows.Forms.ToolTip(this.components);
            this.iv_console_font_dlg = new System.Windows.Forms.FontDialog();
            this.iv_console_b_chose_font = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.iv_panel_control_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // iv_console_b_exit
            // 
            this.iv_console_b_exit.Animated = true;
            this.iv_console_b_exit.AutoRoundedCorners = true;
            this.iv_console_b_exit.BackColor = System.Drawing.Color.Transparent;
            this.iv_console_b_exit.BorderRadius = 12;
            this.iv_console_b_exit.CheckedState.Parent = this.iv_console_b_exit;
            this.iv_console_b_exit.CustomImages.Parent = this.iv_console_b_exit;
            this.iv_console_b_exit.DefaultAutoSize = true;
            this.iv_console_b_exit.DisabledState.Parent = this.iv_console_b_exit;
            this.iv_console_b_exit.FillColor = System.Drawing.Color.Red;
            this.iv_console_b_exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iv_console_b_exit.ForeColor = System.Drawing.Color.White;
            this.iv_console_b_exit.HoverState.Parent = this.iv_console_b_exit;
            this.iv_console_b_exit.IndicateFocus = true;
            this.iv_console_b_exit.Location = new System.Drawing.Point(481, 3);
            this.iv_console_b_exit.Name = "iv_console_b_exit";
            this.iv_console_b_exit.ShadowDecoration.Parent = this.iv_console_b_exit;
            this.iv_console_b_exit.Size = new System.Drawing.Size(37, 27);
            this.iv_console_b_exit.TabIndex = 1;
            this.iv_console_b_exit.Text = "X";
            this.iv_console_b_exit.UseTransparentBackground = true;
            this.iv_console_b_exit.Click += new System.EventHandler(this.IV_Console_B_Exit_Hook);
            // 
            // iv_panel_control_buttons
            // 
            this.iv_panel_control_buttons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iv_panel_control_buttons.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.iv_panel_control_buttons.Controls.Add(this.iv_console_b_chose_font);
            this.iv_panel_control_buttons.Controls.Add(this.iv_console_text_resiser_bar);
            this.iv_panel_control_buttons.Location = new System.Drawing.Point(0, 0);
            this.iv_panel_control_buttons.Name = "iv_panel_control_buttons";
            this.iv_panel_control_buttons.Size = new System.Drawing.Size(520, 35);
            this.iv_panel_control_buttons.TabIndex = 0;
            this.iv_panel_control_buttons.Click += new System.EventHandler(this.IV_WND_Stop_Move_Hook);
            this.iv_panel_control_buttons.DoubleClick += new System.EventHandler(this.IV_WND_Move_Hook);
            // 
            // iv_console_text_resiser_bar
            // 
            this.iv_console_text_resiser_bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iv_console_text_resiser_bar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iv_console_text_resiser_bar.HoverState.Parent = this.iv_console_text_resiser_bar;
            this.iv_console_text_resiser_bar.LargeChange = 2;
            this.iv_console_text_resiser_bar.Location = new System.Drawing.Point(105, 7);
            this.iv_console_text_resiser_bar.Maximum = 72;
            this.iv_console_text_resiser_bar.Minimum = 9;
            this.iv_console_text_resiser_bar.Name = "iv_console_text_resiser_bar";
            this.iv_console_text_resiser_bar.Size = new System.Drawing.Size(300, 23);
            this.iv_console_text_resiser_bar.TabIndex = 6;
            this.iv_console_text_resiser_bar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iv_console_text_resiser_bar.Value = 9;
            this.iv_console_text_resiser_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.IV_Console_Text_Scale_Hook);
            // 
            // iv_console_panel
            // 
            this.iv_console_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iv_console_panel.BackColor = System.Drawing.SystemColors.Menu;
            this.iv_console_panel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iv_console_panel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iv_console_panel.Location = new System.Drawing.Point(12, 41);
            this.iv_console_panel.Multiline = true;
            this.iv_console_panel.Name = "iv_console_panel";
            this.iv_console_panel.ReadOnly = true;
            this.iv_console_panel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.iv_console_panel.Size = new System.Drawing.Size(496, 522);
            this.iv_console_panel.TabIndex = 2;
            // 
            // iv_console_send_panel
            // 
            this.iv_console_send_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iv_console_send_panel.Location = new System.Drawing.Point(12, 573);
            this.iv_console_send_panel.Multiline = true;
            this.iv_console_send_panel.Name = "iv_console_send_panel";
            this.iv_console_send_panel.Size = new System.Drawing.Size(395, 20);
            this.iv_console_send_panel.TabIndex = 3;
            this.iv_console_send_panel.TextChanged += new System.EventHandler(this.IV_Console_Send_Text_Hook);
            // 
            // iv_b_send_to_console
            // 
            this.iv_b_send_to_console.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iv_b_send_to_console.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iv_b_send_to_console.Location = new System.Drawing.Point(433, 573);
            this.iv_b_send_to_console.Name = "iv_b_send_to_console";
            this.iv_b_send_to_console.Size = new System.Drawing.Size(75, 23);
            this.iv_b_send_to_console.TabIndex = 4;
            this.iv_b_send_to_console.Text = "Send";
            this.iv_b_send_to_console.UseVisualStyleBackColor = true;
            this.iv_b_send_to_console.Click += new System.EventHandler(this.IV_B_Console_Send_Hook);
            // 
            // iv_console_text_helper
            // 
            this.iv_console_text_helper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iv_console_text_helper.AutoSize = true;
            this.iv_console_text_helper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iv_console_text_helper.Location = new System.Drawing.Point(12, 522);
            this.iv_console_text_helper.Name = "iv_console_text_helper";
            this.iv_console_text_helper.Size = new System.Drawing.Size(48, 13);
            this.iv_console_text_helper.TabIndex = 5;
            this.iv_console_text_helper.Text = "FIXME!!!";
            this.iv_console_text_helper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iv_console_text_helper.Visible = false;
            this.iv_console_text_helper.Click += new System.EventHandler(this.IV_Console_Helper_Click_Hook);
            this.iv_console_text_helper.DoubleClick += new System.EventHandler(this.IV_Console_Helper_DClick_Hook);
            // 
            // iv_console_scroll_tip
            // 
            this.iv_console_scroll_tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.iv_console_scroll_tip.ToolTipTitle = "Font Size:";
            // 
            // iv_console_font_dlg
            // 
            this.iv_console_font_dlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.iv_console_font_dlg.FontMustExist = true;
            this.iv_console_font_dlg.MaxSize = 72;
            this.iv_console_font_dlg.MinSize = 9;
            this.iv_console_font_dlg.ShowApply = true;
            this.iv_console_font_dlg.ShowHelp = true;
            this.iv_console_font_dlg.Apply += new System.EventHandler(this.IV_Console_Font_DLG_Applied_Hook);
            // 
            // iv_console_b_chose_font
            // 
            this.iv_console_b_chose_font.Animated = true;
            this.iv_console_b_chose_font.AutoRoundedCorners = true;
            this.iv_console_b_chose_font.BackColor = System.Drawing.Color.Transparent;
            this.iv_console_b_chose_font.BorderRadius = 10;
            this.iv_console_b_chose_font.CheckedState.Parent = this.iv_console_b_chose_font;
            this.iv_console_b_chose_font.CustomImages.Parent = this.iv_console_b_chose_font;
            this.iv_console_b_chose_font.DefaultAutoSize = true;
            this.iv_console_b_chose_font.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.iv_console_b_chose_font.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.iv_console_b_chose_font.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.iv_console_b_chose_font.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.iv_console_b_chose_font.DisabledState.Parent = this.iv_console_b_chose_font;
            this.iv_console_b_chose_font.FillColor = System.Drawing.Color.Ivory;
            this.iv_console_b_chose_font.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iv_console_b_chose_font.ForeColor = System.Drawing.Color.Black;
            this.iv_console_b_chose_font.HoverState.Parent = this.iv_console_b_chose_font;
            this.iv_console_b_chose_font.Location = new System.Drawing.Point(0, 0);
            this.iv_console_b_chose_font.Name = "iv_console_b_chose_font";
            this.iv_console_b_chose_font.ShadowDecoration.Parent = this.iv_console_b_chose_font;
            this.iv_console_b_chose_font.Size = new System.Drawing.Size(75, 23);
            this.iv_console_b_chose_font.TabIndex = 7;
            this.iv_console_b_chose_font.Text = "Chose Font";
            this.iv_console_b_chose_font.UseTransparentBackground = true;
            this.iv_console_b_chose_font.Click += new System.EventHandler(this.IV_Console_B_Chose_Font_Hook);
            // 
            // IV_Console_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(520, 605);
            this.Controls.Add(this.iv_console_text_helper);
            this.Controls.Add(this.iv_b_send_to_console);
            this.Controls.Add(this.iv_console_send_panel);
            this.Controls.Add(this.iv_console_panel);
            this.Controls.Add(this.iv_console_b_exit);
            this.Controls.Add(this.iv_panel_control_buttons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IV_Console_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IV_Console_Window";
            this.Activated += new System.EventHandler(this.IV_Enter_Focus_Hook);
            this.Deactivate += new System.EventHandler(this.IV_Out_Focus_Hook);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IV_Console_Close_Hook);
            this.iv_panel_control_buttons.ResumeLayout(false);
            this.iv_panel_control_buttons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton iv_console_b_exit;
        private System.Windows.Forms.Panel iv_panel_control_buttons;
        private System.Windows.Forms.TextBox iv_console_panel;
        private System.Windows.Forms.TextBox iv_console_send_panel;
        private System.Windows.Forms.Button iv_b_send_to_console;
        private System.Windows.Forms.Label iv_console_text_helper;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar iv_console_text_resiser_bar;
        private System.Windows.Forms.ToolTip iv_console_scroll_tip;
        private System.Windows.Forms.FontDialog iv_console_font_dlg;
        private Siticone.Desktop.UI.WinForms.SiticoneButton iv_console_b_chose_font;
    }
}