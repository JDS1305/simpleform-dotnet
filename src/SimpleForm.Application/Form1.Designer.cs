namespace SimpleForm
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
            this.components = new System.ComponentModel.Container();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.itemId = new System.Windows.Forms.TextBox();
            this.countryInput = new System.Windows.Forms.TextBox();
            this.harborOrigin = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.harborLabel = new System.Windows.Forms.Label();
            this.itemIdLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.generateResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.negaraLabel = new System.Windows.Forms.Label();
            this.pelabuhanLabel = new System.Windows.Forms.Label();
            this.barangKodeLabel = new System.Windows.Forms.Label();
            this.barangJenisLabel = new System.Windows.Forms.Label();
            this.hargaLabel = new System.Windows.Forms.Label();
            this.tarifBeaMasuk1Label = new System.Windows.Forms.Label();
            this.tarifBeaMasuk2Label = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.barangKode = new System.Windows.Forms.TextBox();
            this.barangJenis = new System.Windows.Forms.TextBox();
            this.countryName = new System.Windows.Forms.Label();
            this.harborName = new System.Windows.Forms.Label();
            this.harga = new System.Windows.Forms.Label();
            this.tarifBeaMasukPercent = new System.Windows.Forms.Label();
            this.tarifBeaMasukRupiah = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(200, 280);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(200, 27);
            this.priceInput.TabIndex = 4;
            this.toolTip1.SetToolTip(this.priceInput, "Enter the price of the item");
            // 
            // itemId
            // 
            this.itemId.Location = new System.Drawing.Point(200, 160);
            this.itemId.Name = "itemId";
            this.itemId.Size = new System.Drawing.Size(200, 27);
            this.itemId.TabIndex = 1;
            this.toolTip1.SetToolTip(this.itemId, "Enter the ID of the item");
            // 
            // countryInput
            // 
            this.countryInput.Location = new System.Drawing.Point(200, 80);
            this.countryInput.Name = "countryInput";
            this.countryInput.Size = new System.Drawing.Size(200, 27);
            this.countryInput.TabIndex = 0;
            this.toolTip1.SetToolTip(this.countryInput, "Enter the country code");
            // 
            // harborOrigin
            // 
            this.harborOrigin.Location = new System.Drawing.Point(200, 120);
            this.harborOrigin.Name = "harborOrigin";
            this.harborOrigin.Size = new System.Drawing.Size(200, 27);
            this.harborOrigin.TabIndex = 2;
            this.toolTip1.SetToolTip(this.harborOrigin, "Enter the harbor code");
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(50, 60);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(60, 20);
            this.countryLabel.TabIndex = 7;
            this.countryLabel.Text = "Country";
            // 
            // harborLabel
            // 
            this.harborLabel.AutoSize = true;
            this.harborLabel.Location = new System.Drawing.Point(50, 100);
            this.harborLabel.Name = "harborLabel";
            this.harborLabel.Size = new System.Drawing.Size(70, 20);
            this.harborLabel.TabIndex = 8;
            this.harborLabel.Text = "Harbor";
            // 
            // itemIdLabel
            // 
            this.itemIdLabel.AutoSize = true;
            this.itemIdLabel.Location = new System.Drawing.Point(50, 140);
            this.itemIdLabel.Name = "itemIdLabel";
            this.itemIdLabel.Size = new System.Drawing.Size(58, 20);
            this.itemIdLabel.TabIndex = 9;
            this.itemIdLabel.Text = "Item ID";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(50, 260);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(50, 20);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "Price";
            // 
            // generateResult
            // 
            this.generateResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.generateResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateResult.ForeColor = System.Drawing.Color.White;
            this.generateResult.Location = new System.Drawing.Point(200, 360);
            this.generateResult.Name = "generateResult";
            this.generateResult.Size = new System.Drawing.Size(200, 40);
            this.generateResult.TabIndex = 14;
            this.generateResult.Text = "Submit";
            this.generateResult.UseVisualStyleBackColor = false;
            this.generateResult.Click += new System.EventHandler(this.generateResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Input Data";
            // 
            // negaraLabel
            // 
            this.negaraLabel.AutoSize = true;
            this.negaraLabel.Location = new System.Drawing.Point(50, 200);
            this.negaraLabel.Name = "negaraLabel";
            this.negaraLabel.Size = new System.Drawing.Size(60, 20);
            this.negaraLabel.TabIndex = 16;
            this.negaraLabel.Text = "Negara";
            // 
            // pelabuhanLabel
            // 
            this.pelabuhanLabel.AutoSize = true;
            this.pelabuhanLabel.Location = new System.Drawing.Point(50, 240);
            this.pelabuhanLabel.Name = "pelabuhanLabel";
            this.pelabuhanLabel.Size = new System.Drawing.Size(79, 20);
            this.pelabuhanLabel.TabIndex = 17;
            this.pelabuhanLabel.Text = "Pelabuhan";
 // 
            // barangKodeLabel
            // 
            this.barangKodeLabel.AutoSize = true;
            this.barangKodeLabel.Location = new System.Drawing.Point(50, 160);
            this.barangKodeLabel.Name = "barangKodeLabel";
            this.barangKodeLabel.Size = new System.Drawing.Size(94, 20);
            this.barangKodeLabel.TabIndex = 12;
            this.barangKodeLabel.Text = "Barang Kode";
            // 
            // barangJenisLabel
            // 
            this.barangJenisLabel.AutoSize = true;
            this.barangJenisLabel.Location = new System.Drawing.Point(50, 200);
            this.barangJenisLabel.Name = "barangJenisLabel";
            this.barangJenisLabel.Size = new System.Drawing.Size(96, 20);
            this.barangJenisLabel.TabIndex = 18;
            this.barangJenisLabel.Text = "Barang Jenis";
            // 
            // hargaLabel
            // 
            this.hargaLabel.AutoSize = true;
            this.hargaLabel.Location = new System.Drawing.Point(50, 280);
            this.hargaLabel.Name = "hargaLabel";
            this.hargaLabel.Size = new System.Drawing.Size(53, 20);
            this.hargaLabel.TabIndex = 18;
            this.hargaLabel.Text = "Harga";
            // 
            // tarifBeaMasuk1Label
            // 
            this.tarifBeaMasuk1Label.AutoSize = true;
            this.tarifBeaMasuk1Label.Location = new System.Drawing.Point(50, 320);
            this.tarifBeaMasuk1Label.Name = "tarifBeaMasuk1Label";
            this.tarifBeaMasuk1Label.Size = new System.Drawing.Size(118, 20);
            this.tarifBeaMasuk1Label.TabIndex = 19;
            this.tarifBeaMasuk1Label.Text = "Tarif Bea Masuk";
            // 
            // tarifBeaMasuk2Label
            // 
            this.tarifBeaMasuk2Label.AutoSize = true;
            this.tarifBeaMasuk2Label.Location = new System.Drawing.Point(406, 320);
            this.tarifBeaMasuk2Label.Name = "tarifBeaMasuk2Label";
            this.tarifBeaMasuk2Label.Size = new System.Drawing.Size(0, 20);
            this.tarifBeaMasuk2Label.TabIndex = 20;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(450, 10);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(185, 37);
            this.resultLabel.TabIndex = 21;
            this.resultLabel.Text = "Result Details";
            this.resultLabel.Visible = false;
            // 
            // barangKode
            // 
            this.barangKode.Location = new System.Drawing.Point(200, 160);
            this.barangKode.Name = "barangKode";
            this.barangKode.Size = new System.Drawing.Size(200, 27);
            this.barangKode.TabIndex = 1;
            this.toolTip1.SetToolTip(this.barangKode, "Enter the code of the item");
            // 
            // barangJenis
            // 
            this.barangJenis.Location = new System.Drawing.Point(400, 160);
            this.barangJenis.Name = "barangJenis";
            this.barangJenis.Size = new System.Drawing.Size(200, 27);
            this.barangJenis.TabIndex = 3;
            this.toolTip1.SetToolTip(this.barangJenis, "Enter the type of the item");
            // 
            // countryName
            // 
            this.countryName.AutoSize = true;
            this.countryName.Location = new System.Drawing.Point(200, 200);
            this.countryName.Name = "countryName";
            this.countryName.Size = new System.Drawing.Size(0, 20);
            this.countryName.TabIndex = 22;
            // 
            // harborName
            // 
            this.harborName.AutoSize = true;
            this.harborName.Location = new System.Drawing.Point(200, 240);
            this.harborName.Name = "harborName";
            this.harborName.Size = new System.Drawing.Size(0, 20);
            this.harborName.TabIndex = 23;
            // 
            // harga
            // 
            this.harga.AutoSize = true;
            this.harga.Location = new System.Drawing.Point(200, 280);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(0, 20);
            this.harga.TabIndex = 24;
            // 
            // tarifBeaMasukPercent
            // 
            this.tarifBeaMasukPercent.AutoSize = true;
            this.tarifBeaMasukPercent.Location = new System.Drawing.Point(200, 320);
            this.tarifBeaMasukPercent.Name = "tarifBeaMasukPercent";
            this.tarifBeaMasukPercent.Size = new System.Drawing.Size(0, 20);
            this.tarifBeaMasukPercent.TabIndex = 25;
            // 
            // tarifBeaMasukRupiah
            // 
            this.tarifBeaMasukRupiah.AutoSize = true;
            this.tarifBeaMasukRupiah.Location = new System.Drawing.Point(450, 320);
            this.tarifBeaMasukRupiah.Name = "tarifBeaMasukRupiah";
            this.tarifBeaMasukRupiah.Size = new System.Drawing.Size(0, 20);
            this.tarifBeaMasukRupiah.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tarifBeaMasukRupiah);
            this.Controls.Add(this.tarifBeaMasukPercent);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.harborName);
            this.Controls.Add(this.countryName);
            this.Controls.Add(this.barangJenis);
            this.Controls.Add(this.barangKode);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.tarifBeaMasuk2Label);
            this.Controls.Add(this.tarifBeaMasuk1Label);
            this.Controls.Add(this.hargaLabel);
            this.Controls.Add(this.barangJenisLabel);
            this.Controls.Add(this.barangKodeLabel);
            this.Controls.Add(this.pelabuhanLabel);
            this.Controls.Add(this.negaraLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateResult);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.itemIdLabel);
            this.Controls.Add(this.harborLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.harborOrigin);
            this.Controls.Add(this.countryInput);
            this.Controls.Add(this.itemId);
            this.Controls.Add(this.priceInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.TextBox itemId;
        private System.Windows.Forms.TextBox countryInput;
        private System.Windows.Forms.TextBox harborOrigin;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label harborLabel;
        private System.Windows.Forms.Label itemIdLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button generateResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label negaraLabel;
        private System.Windows.Forms.Label pelabuhanLabel;
        private System.Windows.Forms.Label barangKodeLabel;
        private System.Windows.Forms.Label barangJenisLabel;
        private System.Windows.Forms.Label hargaLabel;
        private System.Windows.Forms.Label tarifBeaMasuk1Label;
        private System.Windows.Forms.Label tarifBeaMasuk2Label;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox barangKode;
        private System.Windows.Forms.TextBox barangJenis;
        private System.Windows.Forms.Label countryName;
        private System.Windows.Forms.Label harborName;
        private System.Windows.Forms.Label harga;
        private System.Windows.Forms.Label tarifBeaMasukPercent;
        private System.Windows.Forms.Label tarifBeaMasukRupiah;
    }
}
