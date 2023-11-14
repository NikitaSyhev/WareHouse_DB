namespace WareHouse
{
    partial class Form1
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
            this.textBoxConn = new System.Windows.Forms.TextBox();
            this.ConString = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textBoxNameGoods = new System.Windows.Forms.TextBox();
            this.buttonGoods = new System.Windows.Forms.Button();
            this.buttonGoodsType = new System.Windows.Forms.Button();
            this.buttonSuppl = new System.Windows.Forms.Button();
            this.buttonGoodMax = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonMinCost = new System.Windows.Forms.Button();
            this.buttonMaxCost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxConn
            // 
            this.textBoxConn.Location = new System.Drawing.Point(65, 70);
            this.textBoxConn.Name = "textBoxConn";
            this.textBoxConn.Size = new System.Drawing.Size(306, 20);
            this.textBoxConn.TabIndex = 0;
            // 
            // ConString
            // 
            this.ConString.AutoSize = true;
            this.ConString.Location = new System.Drawing.Point(62, 54);
            this.ConString.Name = "ConString";
            this.ConString.Size = new System.Drawing.Size(113, 13);
            this.ConString.TabIndex = 1;
            this.ConString.Text = "Строка подключения";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(513, 67);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(187, 40);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textBoxNameGoods
            // 
            this.textBoxNameGoods.Location = new System.Drawing.Point(65, 191);
            this.textBoxNameGoods.Multiline = true;
            this.textBoxNameGoods.Name = "textBoxNameGoods";
            this.textBoxNameGoods.Size = new System.Drawing.Size(221, 85);
            this.textBoxNameGoods.TabIndex = 3;
            // 
            // buttonGoods
            // 
            this.buttonGoods.Location = new System.Drawing.Point(513, 131);
            this.buttonGoods.Name = "buttonGoods";
            this.buttonGoods.Size = new System.Drawing.Size(187, 40);
            this.buttonGoods.TabIndex = 4;
            this.buttonGoods.Text = "Вывести название товара";
            this.buttonGoods.UseVisualStyleBackColor = true;
            this.buttonGoods.Click += new System.EventHandler(this.buttonGoods_Click);
            // 
            // buttonGoodsType
            // 
            this.buttonGoodsType.Location = new System.Drawing.Point(513, 191);
            this.buttonGoodsType.Name = "buttonGoodsType";
            this.buttonGoodsType.Size = new System.Drawing.Size(187, 40);
            this.buttonGoodsType.TabIndex = 5;
            this.buttonGoodsType.Text = "Вывести типы товара";
            this.buttonGoodsType.UseVisualStyleBackColor = true;
            this.buttonGoodsType.Click += new System.EventHandler(this.buttonGoodsType_Click);
            // 
            // buttonSuppl
            // 
            this.buttonSuppl.Location = new System.Drawing.Point(513, 255);
            this.buttonSuppl.Name = "buttonSuppl";
            this.buttonSuppl.Size = new System.Drawing.Size(187, 40);
            this.buttonSuppl.TabIndex = 6;
            this.buttonSuppl.Text = "Вывести всех поставщиков";
            this.buttonSuppl.UseVisualStyleBackColor = true;
            this.buttonSuppl.Click += new System.EventHandler(this.buttonSuppl_Click);
            // 
            // buttonGoodMax
            // 
            this.buttonGoodMax.Location = new System.Drawing.Point(513, 315);
            this.buttonGoodMax.Name = "buttonGoodMax";
            this.buttonGoodMax.Size = new System.Drawing.Size(187, 40);
            this.buttonGoodMax.TabIndex = 7;
            this.buttonGoodMax.Text = "Максимальное количество товаров";
            this.buttonGoodMax.UseVisualStyleBackColor = true;
            this.buttonGoodMax.Click += new System.EventHandler(this.buttonGoodMax_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Location = new System.Drawing.Point(513, 375);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(187, 40);
            this.buttonMin.TabIndex = 8;
            this.buttonMin.Text = "Минимальное количество товаров";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMinCost
            // 
            this.buttonMinCost.Location = new System.Drawing.Point(303, 131);
            this.buttonMinCost.Name = "buttonMinCost";
            this.buttonMinCost.Size = new System.Drawing.Size(187, 40);
            this.buttonMinCost.TabIndex = 9;
            this.buttonMinCost.Text = "Минимальная себестоимость товара";
            this.buttonMinCost.UseVisualStyleBackColor = true;
            this.buttonMinCost.Click += new System.EventHandler(this.buttonMinCost_Click);
            // 
            // buttonMaxCost
            // 
            this.buttonMaxCost.Location = new System.Drawing.Point(307, 205);
            this.buttonMaxCost.Name = "buttonMaxCost";
            this.buttonMaxCost.Size = new System.Drawing.Size(187, 40);
            this.buttonMaxCost.TabIndex = 10;
            this.buttonMaxCost.Text = "Максимальная себестоимость товара";
            this.buttonMaxCost.UseVisualStyleBackColor = true;
            this.buttonMaxCost.Click += new System.EventHandler(this.buttonMaxCost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMaxCost);
            this.Controls.Add(this.buttonMinCost);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonGoodMax);
            this.Controls.Add(this.buttonSuppl);
            this.Controls.Add(this.buttonGoodsType);
            this.Controls.Add(this.buttonGoods);
            this.Controls.Add(this.textBoxNameGoods);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.ConString);
            this.Controls.Add(this.textBoxConn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConn;
        private System.Windows.Forms.Label ConString;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox textBoxNameGoods;
        private System.Windows.Forms.Button buttonGoods;
        private System.Windows.Forms.Button buttonGoodsType;
        private System.Windows.Forms.Button buttonSuppl;
        private System.Windows.Forms.Button buttonGoodMax;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonMinCost;
        private System.Windows.Forms.Button buttonMaxCost;
    }
}

