namespace WarehouseApplication.src.View
{
    partial class FormUserProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserProducts));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.comboBoxFilterSearch = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.inputSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.labelUserId = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewProducts
            // 
            this.listViewProducts.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(12, 68);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(560, 261);
            this.listViewProducts.TabIndex = 16;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            // 
            // comboBoxFilterSearch
            // 
            this.comboBoxFilterSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxFilterSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterSearch.DropDownWidth = 134;
            this.comboBoxFilterSearch.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.comboBoxFilterSearch.Items.AddRange(new object[] {
            "Filter",
            "All",
            "Product Code",
            "Product Name"});
            this.comboBoxFilterSearch.Location = new System.Drawing.Point(12, 12);
            this.comboBoxFilterSearch.Name = "comboBoxFilterSearch";
            this.comboBoxFilterSearch.Palette = this.kryptonPalette1;
            this.comboBoxFilterSearch.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.comboBoxFilterSearch.Size = new System.Drawing.Size(159, 33);
            this.comboBoxFilterSearch.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.comboBoxFilterSearch.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.DarkGray;
            this.comboBoxFilterSearch.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.DarkGray;
            this.comboBoxFilterSearch.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboBoxFilterSearch.StateCommon.ComboBox.Border.Rounding = 20;
            this.comboBoxFilterSearch.StateCommon.ComboBox.Border.Width = 1;
            this.comboBoxFilterSearch.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.comboBoxFilterSearch.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.comboBoxFilterSearch.StateCommon.DropBack.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.comboBoxFilterSearch.StateCommon.Item.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.comboBoxFilterSearch.StateCommon.Item.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.comboBoxFilterSearch.StateCommon.Item.Border.Color1 = System.Drawing.Color.White;
            this.comboBoxFilterSearch.StateCommon.Item.Border.Color2 = System.Drawing.Color.White;
            this.comboBoxFilterSearch.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboBoxFilterSearch.StateCommon.Item.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.comboBoxFilterSearch.StateCommon.Item.Border.Width = 1;
            this.comboBoxFilterSearch.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.comboBoxFilterSearch.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.comboBoxFilterSearch.StateTracking.Item.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.comboBoxFilterSearch.StateTracking.Item.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.comboBoxFilterSearch.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.comboBoxFilterSearch.StateTracking.Item.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.comboBoxFilterSearch.TabIndex = 15;
            this.comboBoxFilterSearch.Text = "Filter";
            this.comboBoxFilterSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterSearch_SelectedIndexChanged);
            // 
            // inputSearch
            // 
            this.inputSearch.Location = new System.Drawing.Point(177, 8);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(349, 37);
            this.inputSearch.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.inputSearch.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.inputSearch.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.inputSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.inputSearch.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.inputSearch.StateCommon.Border.Rounding = 20;
            this.inputSearch.StateCommon.Border.Width = 1;
            this.inputSearch.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.inputSearch.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSearch.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.inputSearch.TabIndex = 14;
            this.inputSearch.Text = "Seach Products...";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(532, 6);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.buttonSearch.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.buttonSearch.OverrideDefault.Back.ColorAngle = 0F;
            this.buttonSearch.OverrideDefault.Border.Color1 = System.Drawing.Color.LightGray;
            this.buttonSearch.OverrideDefault.Border.Color2 = System.Drawing.Color.LightGray;
            this.buttonSearch.OverrideDefault.Border.ColorAngle = 0F;
            this.buttonSearch.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonSearch.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSearch.OverrideDefault.Border.Rounding = 26;
            this.buttonSearch.OverrideDefault.Border.Width = 1;
            this.buttonSearch.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.buttonSearch.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.buttonSearch.OverrideDefault.Content.ShortText.ColorAngle = 0F;
            this.buttonSearch.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.buttonSearch.Size = new System.Drawing.Size(40, 39);
            this.buttonSearch.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.buttonSearch.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.buttonSearch.StateCommon.Back.ColorAngle = 45F;
            this.buttonSearch.StateCommon.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.buttonSearch.StateCommon.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.buttonSearch.StateCommon.Border.ColorAngle = 45F;
            this.buttonSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonSearch.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSearch.StateCommon.Border.Rounding = 20;
            this.buttonSearch.StateCommon.Border.Width = 1;
            this.buttonSearch.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.buttonSearch.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.buttonSearch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.buttonSearch.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.buttonSearch.StateNormal.Border.Color1 = System.Drawing.Color.LightGray;
            this.buttonSearch.StateNormal.Border.Color2 = System.Drawing.Color.LightGray;
            this.buttonSearch.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonSearch.StateNormal.Border.Rounding = 26;
            this.buttonSearch.StateNormal.Border.Width = 1;
            this.buttonSearch.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.buttonSearch.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.buttonSearch.StatePressed.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.buttonSearch.StatePressed.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.buttonSearch.StatePressed.Back.ColorAngle = 0F;
            this.buttonSearch.StatePressed.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.buttonSearch.StatePressed.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.buttonSearch.StatePressed.Border.ColorAngle = 0F;
            this.buttonSearch.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonSearch.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSearch.StatePressed.Border.Rounding = 26;
            this.buttonSearch.StatePressed.Border.Width = 1;
            this.buttonSearch.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.buttonSearch.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.buttonSearch.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.StateTracking.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.buttonSearch.StateTracking.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.buttonSearch.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.buttonSearch.StateTracking.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.buttonSearch.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonSearch.StateTracking.Border.Rounding = 26;
            this.buttonSearch.StateTracking.Border.Width = 1;
            this.buttonSearch.TabIndex = 17;
            this.buttonSearch.Values.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Values.Image")));
            this.buttonSearch.Values.Text = "";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.BackColor = System.Drawing.Color.Transparent;
            this.labelUserId.Font = new System.Drawing.Font("Poppins ExtraLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserId.ForeColor = System.Drawing.Color.Black;
            this.labelUserId.Location = new System.Drawing.Point(68, 353);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(133, 19);
            this.labelUserId.TabIndex = 19;
            this.labelUserId.Text = "abcd-01234-efgh-5678";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.BackColor = System.Drawing.Color.Transparent;
            this.label0.Font = new System.Drawing.Font("Poppins ExtraLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.ForeColor = System.Drawing.Color.Black;
            this.label0.Location = new System.Drawing.Point(12, 353);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(59, 19);
            this.label0.TabIndex = 18;
            this.label0.Text = "User ID    :";
            // 
            // FormUserProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.comboBoxFilterSearch);
            this.Controls.Add(this.inputSearch);
            this.Name = "FormUserProducts";
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
            this.Text = "Form User Products";
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.ListView listViewProducts;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboBoxFilterSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox inputSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonSearch;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label label0;
    }
}