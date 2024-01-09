namespace POS.Utils
{
    partial class UserConfirmMessageBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMessage = new MaterialSkin.Controls.MaterialLabel();
            btnYes = new MaterialSkin.Controls.MaterialButton();
            btnNo = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Depth = 0;
            lblMessage.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMessage.HighEmphasis = true;
            lblMessage.Location = new Point(141, 48);
            lblMessage.MouseState = MaterialSkin.MouseState.HOVER;
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(96, 19);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Are you sure?";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            btnYes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnYes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnYes.Depth = 0;
            btnYes.HighEmphasis = true;
            btnYes.Icon = null;
            btnYes.Location = new Point(213, 97);
            btnYes.Margin = new Padding(4, 6, 4, 6);
            btnYes.MouseState = MaterialSkin.MouseState.HOVER;
            btnYes.Name = "btnYes";
            btnYes.NoAccentTextColor = Color.Empty;
            btnYes.Size = new Size(158, 36);
            btnYes.TabIndex = 1;
            btnYes.Text = "materialButton1";
            btnYes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnYes.UseAccentColor = false;
            btnYes.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            btnNo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNo.Depth = 0;
            btnNo.DialogResult = DialogResult.Cancel;
            btnNo.HighEmphasis = true;
            btnNo.Icon = null;
            btnNo.Location = new Point(30, 97);
            btnNo.Margin = new Padding(4, 6, 4, 6);
            btnNo.MouseState = MaterialSkin.MouseState.HOVER;
            btnNo.Name = "btnNo";
            btnNo.NoAccentTextColor = Color.Empty;
            btnNo.Size = new Size(158, 36);
            btnNo.TabIndex = 2;
            btnNo.Text = "materialButton2";
            btnNo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNo.UseAccentColor = true;
            btnNo.UseVisualStyleBackColor = true;
            // 
            // UserConfirmMessageBox
            // 
            AcceptButton = btnYes;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnNo;
            ClientSize = new Size(400, 150);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(lblMessage);
            DrawerHighlightWithAccent = false;
            FormStyle = FormStyles.ActionBar_None;
            Name = "UserConfirmMessageBox";
            Padding = new Padding(3, 24, 3, 3);
            ShowInTaskbar = false;
            Sizable = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblMessage;
        private MaterialSkin.Controls.MaterialButton btnYes;
        private MaterialSkin.Controls.MaterialButton btnNo;
    }
}
