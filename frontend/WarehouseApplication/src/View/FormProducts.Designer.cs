namespace WarehouseApplication.src.View
{
    partial class FormProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.productUnits = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.buttonAddProduct = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.productPrice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.productStock = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.productName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.productCode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.productUnits2 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ProductName2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.productQuantity2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.productCode2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonGroupBox3 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.buttonDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.comboBoxFilterSearch = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.buttonUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.buttonSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.inputSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label0 = new System.Windows.Forms.Label();
            this.labelUserId = new System.Windows.Forms.Label();
            this.buttonLogout = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productUnits2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).BeginInit();
            this.kryptonGroupBox3.Panel.SuspendLayout();
            this.kryptonGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(13, 3);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            this.kryptonGroupBox1.Palette = this.kryptonPalette1;
            this.kryptonGroupBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.productUnits);
            this.kryptonGroupBox1.Panel.Controls.Add(this.buttonAddProduct);
            this.kryptonGroupBox1.Panel.Controls.Add(this.productPrice);
            this.kryptonGroupBox1.Panel.Controls.Add(this.productStock);
            this.kryptonGroupBox1.Panel.Controls.Add(this.productName);
            this.kryptonGroupBox1.Panel.Controls.Add(this.productCode);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(407, 200);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.kryptonGroupBox1.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonGroupBox1.StateCommon.Border.Rounding = 10;
            this.kryptonGroupBox1.StateCommon.Border.Width = 1;
            this.kryptonGroupBox1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(20, -1, -1, -1);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Tag = "";
            this.kryptonGroupBox1.Values.Heading = "Inbound Product";
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
            this.productUnits.Location = new System.Drawing.Point(303, 25);
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
            this.productUnits.TabIndex = 15;
            this.productUnits.Text = "Units";
            this.productUnits.SelectedIndexChanged += new System.EventHandler(this.productUnits_SelectedIndexChanged);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(187, 109);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.buttonAddProduct.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.buttonAddProduct.OverrideDefault.Back.ColorAngle = 0F;
            this.buttonAddProduct.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray;
            this.buttonAddProduct.OverrideDefault.Border.Color2 = System.Drawing.Color.Gray;
            this.buttonAddProduct.OverrideDefault.Border.ColorAngle = 0F;
            this.buttonAddProduct.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonAddProduct.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonAddProduct.OverrideDefault.Border.Rounding = 20;
            this.buttonAddProduct.OverrideDefault.Border.Width = 1;
            this.buttonAddProduct.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.buttonAddProduct.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.buttonAddProduct.OverrideDefault.Content.ShortText.ColorAngle = 0F;
            this.buttonAddProduct.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProduct.Palette = this.kryptonPalette1;
            this.buttonAddProduct.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.buttonAddProduct.Size = new System.Drawing.Size(204, 39);
            this.buttonAddProduct.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.buttonAddProduct.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.buttonAddProduct.StateCommon.Back.ColorAngle = 45F;
            this.buttonAddProduct.StateCommon.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.buttonAddProduct.StateCommon.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.buttonAddProduct.StateCommon.Border.ColorAngle = 45F;
            this.buttonAddProduct.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonAddProduct.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonAddProduct.StateCommon.Border.Rounding = 20;
            this.buttonAddProduct.StateCommon.Border.Width = 1;
            this.buttonAddProduct.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.buttonAddProduct.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.buttonAddProduct.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProduct.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.buttonAddProduct.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.buttonAddProduct.StateNormal.Border.Color1 = System.Drawing.Color.Gray;
            this.buttonAddProduct.StateNormal.Border.Color2 = System.Drawing.Color.Gray;
            this.buttonAddProduct.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonAddProduct.StateNormal.Border.Rounding = 20;
            this.buttonAddProduct.StateNormal.Border.Width = 1;
            this.buttonAddProduct.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.buttonAddProduct.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.buttonAddProduct.StatePressed.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.buttonAddProduct.StatePressed.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.buttonAddProduct.StatePressed.Back.ColorAngle = 0F;
            this.buttonAddProduct.StatePressed.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.buttonAddProduct.StatePressed.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.buttonAddProduct.StatePressed.Border.ColorAngle = 0F;
            this.buttonAddProduct.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonAddProduct.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonAddProduct.StatePressed.Border.Rounding = 20;
            this.buttonAddProduct.StatePressed.Border.Width = 1;
            this.buttonAddProduct.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.buttonAddProduct.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.buttonAddProduct.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProduct.TabIndex = 9;
            this.buttonAddProduct.Values.Text = "Submit";
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(22, 109);
            this.productPrice.Name = "productPrice";
            this.productPrice.Palette = this.kryptonPalette1;
            this.productPrice.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.productPrice.Size = new System.Drawing.Size(159, 37);
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
            this.productPrice.TabIndex = 5;
            this.productPrice.Text = "Price";
            // 
            // productStock
            // 
            this.productStock.Location = new System.Drawing.Point(187, 23);
            this.productStock.Name = "productStock";
            this.productStock.Palette = this.kryptonPalette1;
            this.productStock.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.productStock.Size = new System.Drawing.Size(110, 37);
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
            this.productStock.TabIndex = 4;
            this.productStock.Text = "Quantity";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(22, 66);
            this.productName.Name = "productName";
            this.productName.Palette = this.kryptonPalette1;
            this.productName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.productName.Size = new System.Drawing.Size(369, 37);
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
            this.productName.TabIndex = 3;
            this.productName.Text = "Product Name";
            // 
            // productCode
            // 
            this.productCode.Location = new System.Drawing.Point(22, 23);
            this.productCode.Name = "productCode";
            this.productCode.Palette = this.kryptonPalette1;
            this.productCode.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.productCode.Size = new System.Drawing.Size(159, 37);
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
            this.productCode.TabIndex = 2;
            this.productCode.Text = "Product Code";
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(12, 233);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            this.kryptonGroupBox2.Palette = this.kryptonPalette1;
            this.kryptonGroupBox2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.productUnits2);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonButton3);
            this.kryptonGroupBox2.Panel.Controls.Add(this.ProductName2);
            this.kryptonGroupBox2.Panel.Controls.Add(this.productQuantity2);
            this.kryptonGroupBox2.Panel.Controls.Add(this.productCode2);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(408, 200);
            this.kryptonGroupBox2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox2.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonGroupBox2.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.kryptonGroupBox2.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.kryptonGroupBox2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox2.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonGroupBox2.StateCommon.Border.Rounding = 10;
            this.kryptonGroupBox2.StateCommon.Border.Width = 1;
            this.kryptonGroupBox2.StateCommon.Content.Padding = new System.Windows.Forms.Padding(20, -1, -1, -1);
            this.kryptonGroupBox2.TabIndex = 1;
            this.kryptonGroupBox2.Tag = "";
            this.kryptonGroupBox2.Values.Heading = "Outbound Product";
            // 
            // productUnits2
            // 
            this.productUnits2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productUnits2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productUnits2.DropDownWidth = 134;
            this.productUnits2.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.productUnits2.Items.AddRange(new object[] {
            "Units",
            "Kg",
            "Pcs",
            "Liters"});
            this.productUnits2.Location = new System.Drawing.Point(304, 23);
            this.productUnits2.Name = "productUnits2";
            this.productUnits2.Palette = this.kryptonPalette1;
            this.productUnits2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.productUnits2.Size = new System.Drawing.Size(88, 33);
            this.productUnits2.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.productUnits2.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.LightGray;
            this.productUnits2.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.LightGray;
            this.productUnits2.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.productUnits2.StateCommon.ComboBox.Border.Rounding = 20;
            this.productUnits2.StateCommon.ComboBox.Border.Width = 1;
            this.productUnits2.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.productUnits2.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.productUnits2.StateCommon.DropBack.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.productUnits2.StateCommon.Item.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.productUnits2.StateCommon.Item.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.productUnits2.StateCommon.Item.Border.Color1 = System.Drawing.Color.White;
            this.productUnits2.StateCommon.Item.Border.Color2 = System.Drawing.Color.White;
            this.productUnits2.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.productUnits2.StateCommon.Item.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.productUnits2.StateCommon.Item.Border.Width = 1;
            this.productUnits2.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.productUnits2.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.productUnits2.StateTracking.Item.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.productUnits2.StateTracking.Item.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.productUnits2.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.productUnits2.StateTracking.Item.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.productUnits2.TabIndex = 16;
            this.productUnits2.Text = "Units";
            this.productUnits2.SelectedIndexChanged += new System.EventHandler(this.productUnits2_SelectedIndexChanged);
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(22, 108);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton3.OverrideDefault.Back.ColorAngle = 0F;
            this.kryptonButton3.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray;
            this.kryptonButton3.OverrideDefault.Border.Color2 = System.Drawing.Color.Gray;
            this.kryptonButton3.OverrideDefault.Border.ColorAngle = 0F;
            this.kryptonButton3.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton3.OverrideDefault.Border.Rounding = 20;
            this.kryptonButton3.OverrideDefault.Border.Width = 1;
            this.kryptonButton3.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonButton3.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonButton3.OverrideDefault.Content.ShortText.ColorAngle = 0F;
            this.kryptonButton3.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.Palette = this.kryptonPalette1;
            this.kryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButton3.Size = new System.Drawing.Size(370, 39);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.kryptonButton3.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.kryptonButton3.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton3.StateCommon.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.kryptonButton3.StateCommon.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.kryptonButton3.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton3.StateCommon.Border.Rounding = 20;
            this.kryptonButton3.StateCommon.Border.Width = 1;
            this.kryptonButton3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton3.StateNormal.Border.Color1 = System.Drawing.Color.Gray;
            this.kryptonButton3.StateNormal.Border.Color2 = System.Drawing.Color.Gray;
            this.kryptonButton3.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateNormal.Border.Rounding = 20;
            this.kryptonButton3.StateNormal.Border.Width = 1;
            this.kryptonButton3.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonButton3.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonButton3.StatePressed.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.kryptonButton3.StatePressed.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.kryptonButton3.StatePressed.Back.ColorAngle = 0F;
            this.kryptonButton3.StatePressed.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.kryptonButton3.StatePressed.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.kryptonButton3.StatePressed.Border.ColorAngle = 0F;
            this.kryptonButton3.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton3.StatePressed.Border.Rounding = 20;
            this.kryptonButton3.StatePressed.Border.Width = 1;
            this.kryptonButton3.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton3.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.TabIndex = 10;
            this.kryptonButton3.Values.Text = "Submit";
            // 
            // ProductName2
            // 
            this.ProductName2.Location = new System.Drawing.Point(22, 65);
            this.ProductName2.Name = "ProductName2";
            this.ProductName2.Palette = this.kryptonPalette1;
            this.ProductName2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ProductName2.Size = new System.Drawing.Size(370, 37);
            this.ProductName2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ProductName2.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.ProductName2.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.ProductName2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ProductName2.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ProductName2.StateCommon.Border.Rounding = 20;
            this.ProductName2.StateCommon.Border.Width = 1;
            this.ProductName2.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.ProductName2.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName2.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ProductName2.TabIndex = 7;
            this.ProductName2.Text = "ProductName";
            // 
            // productQuantity2
            // 
            this.productQuantity2.Location = new System.Drawing.Point(188, 23);
            this.productQuantity2.Name = "productQuantity2";
            this.productQuantity2.Palette = this.kryptonPalette1;
            this.productQuantity2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.productQuantity2.Size = new System.Drawing.Size(110, 37);
            this.productQuantity2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.productQuantity2.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.productQuantity2.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.productQuantity2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.productQuantity2.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.productQuantity2.StateCommon.Border.Rounding = 20;
            this.productQuantity2.StateCommon.Border.Width = 1;
            this.productQuantity2.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.productQuantity2.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuantity2.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.productQuantity2.TabIndex = 4;
            this.productQuantity2.Text = "Quantity";
            // 
            // productCode2
            // 
            this.productCode2.Location = new System.Drawing.Point(22, 23);
            this.productCode2.Name = "productCode2";
            this.productCode2.Palette = this.kryptonPalette1;
            this.productCode2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.productCode2.Size = new System.Drawing.Size(160, 37);
            this.productCode2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.productCode2.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.productCode2.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.productCode2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.productCode2.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.productCode2.StateCommon.Border.Rounding = 20;
            this.productCode2.StateCommon.Border.Width = 1;
            this.productCode2.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.productCode2.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCode2.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.productCode2.TabIndex = 2;
            this.productCode2.Text = "Product Code";
            // 
            // kryptonGroupBox3
            // 
            this.kryptonGroupBox3.Location = new System.Drawing.Point(449, 3);
            this.kryptonGroupBox3.Name = "kryptonGroupBox3";
            this.kryptonGroupBox3.Palette = this.kryptonPalette1;
            this.kryptonGroupBox3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            // 
            // kryptonGroupBox3.Panel
            // 
            this.kryptonGroupBox3.Panel.Controls.Add(this.buttonDelete);
            this.kryptonGroupBox3.Panel.Controls.Add(this.listViewProducts);
            this.kryptonGroupBox3.Panel.Controls.Add(this.comboBoxFilterSearch);
            this.kryptonGroupBox3.Panel.Controls.Add(this.buttonUpdate);
            this.kryptonGroupBox3.Panel.Controls.Add(this.buttonSearch);
            this.kryptonGroupBox3.Panel.Controls.Add(this.inputSearch);
            this.kryptonGroupBox3.Size = new System.Drawing.Size(584, 430);
            this.kryptonGroupBox3.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox3.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonGroupBox3.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.kryptonGroupBox3.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.kryptonGroupBox3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox3.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonGroupBox3.StateCommon.Border.Rounding = 10;
            this.kryptonGroupBox3.StateCommon.Border.Width = 1;
            this.kryptonGroupBox3.StateCommon.Content.Padding = new System.Windows.Forms.Padding(20, -1, -1, -1);
            this.kryptonGroupBox3.TabIndex = 2;
            this.kryptonGroupBox3.Tag = "";
            this.kryptonGroupBox3.Values.Heading = "List Products";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(453, 84);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.buttonDelete.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.buttonDelete.OverrideDefault.Back.ColorAngle = 0F;
            this.buttonDelete.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray;
            this.buttonDelete.OverrideDefault.Border.Color2 = System.Drawing.Color.Gray;
            this.buttonDelete.OverrideDefault.Border.ColorAngle = 0F;
            this.buttonDelete.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonDelete.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonDelete.OverrideDefault.Border.Rounding = 20;
            this.buttonDelete.OverrideDefault.Border.Width = 1;
            this.buttonDelete.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.buttonDelete.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.buttonDelete.OverrideDefault.Content.ShortText.ColorAngle = 0F;
            this.buttonDelete.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Palette = this.kryptonPalette1;
            this.buttonDelete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.buttonDelete.Size = new System.Drawing.Size(107, 39);
            this.buttonDelete.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.buttonDelete.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.buttonDelete.StateCommon.Back.ColorAngle = 0F;
            this.buttonDelete.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.buttonDelete.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.buttonDelete.StateCommon.Border.ColorAngle = 45F;
            this.buttonDelete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonDelete.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonDelete.StateCommon.Border.Rounding = 20;
            this.buttonDelete.StateCommon.Border.Width = 1;
            this.buttonDelete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.buttonDelete.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.buttonDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.buttonDelete.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.buttonDelete.StateNormal.Border.Color1 = System.Drawing.Color.Gray;
            this.buttonDelete.StateNormal.Border.Color2 = System.Drawing.Color.Gray;
            this.buttonDelete.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonDelete.StateNormal.Border.Rounding = 20;
            this.buttonDelete.StateNormal.Border.Width = 1;
            this.buttonDelete.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.buttonDelete.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.buttonDelete.StatePressed.Back.Color1 = System.Drawing.Color.Red;
            this.buttonDelete.StatePressed.Back.Color2 = System.Drawing.Color.Red;
            this.buttonDelete.StatePressed.Back.ColorAngle = 0F;
            this.buttonDelete.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.buttonDelete.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.buttonDelete.StatePressed.Border.ColorAngle = 0F;
            this.buttonDelete.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonDelete.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonDelete.StatePressed.Border.Rounding = 20;
            this.buttonDelete.StatePressed.Border.Width = 1;
            this.buttonDelete.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.buttonDelete.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.buttonDelete.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.StateTracking.Back.Color1 = System.Drawing.Color.Red;
            this.buttonDelete.StateTracking.Back.Color2 = System.Drawing.Color.Red;
            this.buttonDelete.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonDelete.StateTracking.Border.Rounding = 20;
            this.buttonDelete.StateTracking.Border.Width = 1;
            this.buttonDelete.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.buttonDelete.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Values.Text = "Delete";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listViewProducts
            // 
            this.listViewProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(12, 129);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(548, 261);
            this.listViewProducts.TabIndex = 13;
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
            this.comboBoxFilterSearch.Location = new System.Drawing.Point(12, 23);
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
            this.comboBoxFilterSearch.TabIndex = 12;
            this.comboBoxFilterSearch.Text = "Filter";
            this.comboBoxFilterSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterSearch_SelectedIndexChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(340, 84);
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
            this.buttonUpdate.Palette = this.kryptonPalette1;
            this.buttonUpdate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.buttonUpdate.Size = new System.Drawing.Size(107, 39);
            this.buttonUpdate.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.buttonUpdate.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.buttonUpdate.StateCommon.Back.ColorAngle = 0F;
            this.buttonUpdate.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.buttonUpdate.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.buttonUpdate.StateCommon.Border.ColorAngle = 45F;
            this.buttonUpdate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonUpdate.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonUpdate.StateCommon.Border.Rounding = 20;
            this.buttonUpdate.StateCommon.Border.Width = 1;
            this.buttonUpdate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.buttonUpdate.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
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
            this.buttonUpdate.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.buttonUpdate.StatePressed.Border.Color2 = System.Drawing.Color.White;
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
            this.buttonUpdate.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonUpdate.StateTracking.Border.Rounding = 20;
            this.buttonUpdate.StateTracking.Border.Width = 1;
            this.buttonUpdate.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.buttonUpdate.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Values.Text = "Update";
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(520, 19);
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
            this.buttonSearch.Palette = this.kryptonPalette1;
            this.buttonSearch.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
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
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Values.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Values.Image")));
            this.buttonSearch.Values.Text = "";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // inputSearch
            // 
            this.inputSearch.Location = new System.Drawing.Point(177, 19);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Palette = this.kryptonPalette1;
            this.inputSearch.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.inputSearch.Size = new System.Drawing.Size(337, 37);
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
            this.inputSearch.TabIndex = 7;
            this.inputSearch.Text = "Seach...";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.BackColor = System.Drawing.Color.Transparent;
            this.label0.Font = new System.Drawing.Font("Poppins ExtraLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.ForeColor = System.Drawing.Color.Black;
            this.label0.Location = new System.Drawing.Point(9, 457);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(59, 19);
            this.label0.TabIndex = 3;
            this.label0.Text = "User ID    :";
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.BackColor = System.Drawing.Color.Transparent;
            this.labelUserId.Font = new System.Drawing.Font("Poppins ExtraLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserId.ForeColor = System.Drawing.Color.Black;
            this.labelUserId.Location = new System.Drawing.Point(65, 457);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(133, 19);
            this.labelUserId.TabIndex = 4;
            this.labelUserId.Text = "abcd-01234-efgh-5678";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(943, 444);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.buttonLogout.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.buttonLogout.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray;
            this.buttonLogout.OverrideDefault.Border.Color2 = System.Drawing.Color.Silver;
            this.buttonLogout.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonLogout.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonLogout.OverrideDefault.Border.Width = 1;
            this.buttonLogout.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.buttonLogout.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.buttonLogout.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Palette = this.kryptonPalette1;
            this.buttonLogout.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.buttonLogout.Size = new System.Drawing.Size(90, 25);
            this.buttonLogout.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.buttonLogout.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.buttonLogout.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.buttonLogout.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.buttonLogout.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonLogout.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonLogout.StateCommon.Border.Width = 1;
            this.buttonLogout.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.buttonLogout.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.buttonLogout.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.StatePressed.Back.Color1 = System.Drawing.Color.Blue;
            this.buttonLogout.StatePressed.Back.Color2 = System.Drawing.Color.Blue;
            this.buttonLogout.StatePressed.Border.Color1 = System.Drawing.Color.Blue;
            this.buttonLogout.StatePressed.Border.Color2 = System.Drawing.Color.Blue;
            this.buttonLogout.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonLogout.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonLogout.StatePressed.Border.Width = 1;
            this.buttonLogout.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.buttonLogout.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.buttonLogout.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.StateTracking.Back.Color1 = System.Drawing.Color.Blue;
            this.buttonLogout.StateTracking.Back.Color2 = System.Drawing.Color.Blue;
            this.buttonLogout.StateTracking.Border.Color1 = System.Drawing.Color.Blue;
            this.buttonLogout.StateTracking.Border.Color2 = System.Drawing.Color.Blue;
            this.buttonLogout.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonLogout.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonLogout.StateTracking.Border.Width = 1;
            this.buttonLogout.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.buttonLogout.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.buttonLogout.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Values.Text = "Logout";
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 481);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.kryptonGroupBox3);
            this.Controls.Add(this.kryptonGroupBox2);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Name = "FormProducts";
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
            this.Text = "Form Products";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productUnits2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).EndInit();
            this.kryptonGroupBox3.Panel.ResumeLayout(false);
            this.kryptonGroupBox3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).EndInit();
            this.kryptonGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox productName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox productCode;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox productPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox productStock;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox productQuantity2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox productCode2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ProductName2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox3;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label labelUserId;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox inputSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonAddProduct;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboBoxFilterSearch;
        private System.Windows.Forms.ListView listViewProducts;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox productUnits;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox productUnits2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonLogout;
    }
}