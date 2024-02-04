namespace WarehouseApplication.src.View
{
    partial class FormUpdateProduct
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
            this.productCode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.productStock = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.productUnits = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productPrice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.buttonClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.productUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // productCode
            // 
            this.productCode.Location = new System.Drawing.Point(12, 34);
            this.productCode.Name = "productCode";
            this.productCode.Size = new System.Drawing.Size(280, 37);
            this.productCode.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.productCode.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.productCode.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.productCode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.productCode.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.productCode.StateCommon.Border.Rounding = 20;
            this.productCode.StateCommon.Border.Width = 1;
            this.productCode.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.productCode.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCode.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.productCode.TabIndex = 3;
            this.productCode.Text = "Product Code";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCode.Location = new System.Drawing.Point(8, 8);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(99, 23);
            this.labelCode.TabIndex = 4;
            this.labelCode.Text = "Product Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product Name";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(12, 102);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(280, 37);
            this.productName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.productName.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.productName.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.productName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.productName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.productName.StateCommon.Border.Rounding = 20;
            this.productName.StateCommon.Border.Width = 1;
            this.productName.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.productName.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.productName.TabIndex = 5;
            this.productName.Text = "Product Name";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(8, 144);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(65, 23);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Quantity";
            // 
            // productStock
            // 
            this.productStock.Location = new System.Drawing.Point(12, 170);
            this.productStock.Name = "productStock";
            this.productStock.Size = new System.Drawing.Size(186, 37);
            this.productStock.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.productStock.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.productStock.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.productStock.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.productStock.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.productStock.StateCommon.Border.Rounding = 20;
            this.productStock.StateCommon.Border.Width = 1;
            this.productStock.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.productStock.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productStock.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.productStock.TabIndex = 7;
            this.productStock.Text = "Quantity";
            // 
            // productUnits
            // 
            this.productUnits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productUnits.DropDownWidth = 134;
            this.productUnits.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.productUnits.Items.AddRange(new object[] {
            "Units",
            "Kg",
            "Pcs",
            "Liters"});
            this.productUnits.Location = new System.Drawing.Point(204, 170);
            this.productUnits.Name = "productUnits";
            this.productUnits.Palette = this.kryptonPalette1;
            this.productUnits.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.productUnits.Size = new System.Drawing.Size(88, 33);
            this.productUnits.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.productUnits.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.LightGray;
            this.productUnits.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.LightGray;
            this.productUnits.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.productUnits.StateCommon.ComboBox.Border.Rounding = 20;
            this.productUnits.StateCommon.ComboBox.Border.Width = 1;
            this.productUnits.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.productUnits.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.productUnits.StateCommon.DropBack.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.productUnits.StateCommon.Item.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.productUnits.StateCommon.Item.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.productUnits.StateCommon.Item.Border.Color1 = System.Drawing.Color.White;
            this.productUnits.StateCommon.Item.Border.Color2 = System.Drawing.Color.White;
            this.productUnits.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.productUnits.StateCommon.Item.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.productUnits.StateCommon.Item.Border.Width = 1;
            this.productUnits.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.productUnits.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.productUnits.StateTracking.Item.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.productUnits.StateTracking.Item.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.productUnits.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.productUnits.StateTracking.Item.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.productUnits.TabIndex = 16;
            this.productUnits.Text = "Units";
            this.productUnits.SelectedIndexChanged += new System.EventHandler(this.productUnits_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Product Price";
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(12, 237);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(280, 37);
            this.productPrice.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.productPrice.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.productPrice.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.productPrice.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.productPrice.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.productPrice.StateCommon.Border.Rounding = 20;
            this.productPrice.StateCommon.Border.Width = 1;
            this.productPrice.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.productPrice.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPrice.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.productPrice.TabIndex = 17;
            this.productPrice.Text = "Product Price";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(12, 293);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.buttonUpdate.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.buttonUpdate.OverrideDefault.Back.ColorAngle = 0F;
            this.buttonUpdate.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray;
            this.buttonUpdate.OverrideDefault.Border.Color2 = System.Drawing.Color.Gray;
            this.buttonUpdate.OverrideDefault.Border.ColorAngle = 0F;
            this.buttonUpdate.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonUpdate.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonUpdate.OverrideDefault.Border.Rounding = 20;
            this.buttonUpdate.OverrideDefault.Border.Width = 1;
            this.buttonUpdate.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.buttonUpdate.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.buttonUpdate.OverrideDefault.Content.ShortText.ColorAngle = 0F;
            this.buttonUpdate.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.buttonUpdate.Size = new System.Drawing.Size(280, 39);
            this.buttonUpdate.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.buttonUpdate.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.buttonUpdate.StateCommon.Back.ColorAngle = 45F;
            this.buttonUpdate.StateCommon.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.buttonUpdate.StateCommon.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.buttonUpdate.StateCommon.Border.ColorAngle = 45F;
            this.buttonUpdate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonUpdate.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonUpdate.StateCommon.Border.Rounding = 20;
            this.buttonUpdate.StateCommon.Border.Width = 1;
            this.buttonUpdate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.buttonUpdate.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.buttonUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.buttonUpdate.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.buttonUpdate.StateNormal.Border.Color1 = System.Drawing.Color.Gray;
            this.buttonUpdate.StateNormal.Border.Color2 = System.Drawing.Color.Gray;
            this.buttonUpdate.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonUpdate.StateNormal.Border.Rounding = 20;
            this.buttonUpdate.StateNormal.Border.Width = 1;
            this.buttonUpdate.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.buttonUpdate.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.buttonUpdate.StatePressed.Back.Color1 = System.Drawing.Color.Gold;
            this.buttonUpdate.StatePressed.Back.Color2 = System.Drawing.Color.Gold;
            this.buttonUpdate.StatePressed.Back.ColorAngle = 0F;
            this.buttonUpdate.StatePressed.Border.Color1 = System.Drawing.Color.Gold;
            this.buttonUpdate.StatePressed.Border.Color2 = System.Drawing.Color.Gold;
            this.buttonUpdate.StatePressed.Border.ColorAngle = 0F;
            this.buttonUpdate.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonUpdate.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonUpdate.StatePressed.Border.Rounding = 20;
            this.buttonUpdate.StatePressed.Border.Width = 1;
            this.buttonUpdate.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.buttonUpdate.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.buttonUpdate.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.StateTracking.Back.Color1 = System.Drawing.Color.Gold;
            this.buttonUpdate.StateTracking.Back.Color2 = System.Drawing.Color.Gold;
            this.buttonUpdate.StateTracking.Border.Color1 = System.Drawing.Color.Gold;
            this.buttonUpdate.StateTracking.Border.Color2 = System.Drawing.Color.Gold;
            this.buttonUpdate.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonUpdate.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonUpdate.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.buttonUpdate.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.buttonUpdate.TabIndex = 19;
            this.buttonUpdate.Values.Text = "Update";
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(12, 350);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.buttonClose.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.buttonClose.OverrideDefault.Back.ColorAngle = 0F;
            this.buttonClose.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray;
            this.buttonClose.OverrideDefault.Border.Color2 = System.Drawing.Color.Gray;
            this.buttonClose.OverrideDefault.Border.ColorAngle = 0F;
            this.buttonClose.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonClose.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonClose.OverrideDefault.Border.Rounding = 20;
            this.buttonClose.OverrideDefault.Border.Width = 1;
            this.buttonClose.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.buttonClose.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.buttonClose.OverrideDefault.Content.ShortText.ColorAngle = 0F;
            this.buttonClose.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.buttonClose.Size = new System.Drawing.Size(280, 39);
            this.buttonClose.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.buttonClose.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.buttonClose.StateCommon.Back.ColorAngle = 45F;
            this.buttonClose.StateCommon.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.buttonClose.StateCommon.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.buttonClose.StateCommon.Border.ColorAngle = 45F;
            this.buttonClose.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonClose.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonClose.StateCommon.Border.Rounding = 20;
            this.buttonClose.StateCommon.Border.Width = 1;
            this.buttonClose.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.buttonClose.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.buttonClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.buttonClose.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.buttonClose.StateNormal.Border.Color1 = System.Drawing.Color.Gray;
            this.buttonClose.StateNormal.Border.Color2 = System.Drawing.Color.Gray;
            this.buttonClose.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonClose.StateNormal.Border.Rounding = 20;
            this.buttonClose.StateNormal.Border.Width = 1;
            this.buttonClose.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.buttonClose.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.buttonClose.StatePressed.Back.Color1 = System.Drawing.Color.Red;
            this.buttonClose.StatePressed.Back.Color2 = System.Drawing.Color.Red;
            this.buttonClose.StatePressed.Back.ColorAngle = 0F;
            this.buttonClose.StatePressed.Border.Color1 = System.Drawing.Color.Red;
            this.buttonClose.StatePressed.Border.Color2 = System.Drawing.Color.Red;
            this.buttonClose.StatePressed.Border.ColorAngle = 0F;
            this.buttonClose.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonClose.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonClose.StatePressed.Border.Rounding = 20;
            this.buttonClose.StatePressed.Border.Width = 1;
            this.buttonClose.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.buttonClose.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.buttonClose.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.StateTracking.Back.Color1 = System.Drawing.Color.Red;
            this.buttonClose.StateTracking.Back.Color2 = System.Drawing.Color.Red;
            this.buttonClose.StateTracking.Border.Color1 = System.Drawing.Color.Red;
            this.buttonClose.StateTracking.Border.Color2 = System.Drawing.Color.Red;
            this.buttonClose.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.buttonClose.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonClose.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonClose.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.buttonClose.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.buttonClose.TabIndex = 20;
            this.buttonClose.Values.Text = "Close";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 411);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productUnits);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.productStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.productCode);
            this.Name = "FormUpdateProduct";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
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
            this.Text = "Form Update Product";
            ((System.ComponentModel.ISupportInitialize)(this.productUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox productCode;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox productName;
        private System.Windows.Forms.Label labelPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox productStock;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox productUnits;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox productPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonClose;
    }
}