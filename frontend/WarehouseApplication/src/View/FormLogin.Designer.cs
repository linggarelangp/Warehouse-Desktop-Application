namespace WarehouseApplication.src.View
{
    partial class FormLogin
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.username = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.password = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(130, 140);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(220, 37);
            this.username.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.username.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.username.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.username.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.username.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.username.StateCommon.Border.Rounding = 20;
            this.username.StateCommon.Border.Width = 1;
            this.username.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.username.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(130, 185);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(220, 37);
            this.password.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.password.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.password.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.password.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.password.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.password.StateCommon.Border.Rounding = 20;
            this.password.StateCommon.Border.Width = 1;
            this.password.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.password.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(130, 240);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.buttonLogin.OverrideDefault.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.buttonLogin.OverrideDefault.Back.ColorAngle = 45F;
            this.buttonLogin.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonLogin.OverrideDefault.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.buttonLogin.OverrideDefault.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.buttonLogin.OverrideDefault.Border.ColorAngle = 45F;
            this.buttonLogin.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonLogin.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonLogin.OverrideDefault.Border.Rounding = 20;
            this.buttonLogin.OverrideDefault.Border.Width = 1;
            this.buttonLogin.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.buttonLogin.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.buttonLogin.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            this.buttonLogin.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.buttonLogin.Size = new System.Drawing.Size(220, 39);
            this.buttonLogin.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.buttonLogin.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.buttonLogin.StateCommon.Back.ColorAngle = 45F;
            this.buttonLogin.StateCommon.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.buttonLogin.StateCommon.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.buttonLogin.StateCommon.Border.ColorAngle = 45F;
            this.buttonLogin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonLogin.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonLogin.StateCommon.Border.Rounding = 20;
            this.buttonLogin.StateCommon.Border.Width = 1;
            this.buttonLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.buttonLogin.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.buttonLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.buttonLogin.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.buttonLogin.StatePressed.Back.ColorAngle = 0F;
            this.buttonLogin.StatePressed.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.buttonLogin.StatePressed.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.buttonLogin.StatePressed.Border.ColorAngle = 0F;
            this.buttonLogin.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonLogin.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonLogin.StatePressed.Border.Rounding = 20;
            this.buttonLogin.StatePressed.Border.Width = 1;
            this.buttonLogin.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.buttonLogin.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.buttonLogin.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Values.Text = "Login";
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.StateCommon.Border.Rounding = 12;
            this.StateCommon.Border.Width = 1;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Header.ButtonEdgeInset = 10;
            this.StateCommon.Header.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.Text = "Form Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox username;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox password;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonLogin;
    }
}