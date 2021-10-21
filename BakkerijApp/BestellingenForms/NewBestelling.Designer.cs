
namespace BakkerijApp.BestellingenForms
{
    partial class NewBestelling
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtContactKlant = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTussenvoegsel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdSearchKlant = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nieuw bestelling";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtContactKlant);
            this.panel1.Controls.Add(this.txtAchternaam);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTussenvoegsel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtVoornaam);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmdSearchKlant);
            this.panel1.Location = new System.Drawing.Point(26, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 257);
            this.panel1.TabIndex = 1;
            // 
            // txtContactKlant
            // 
            this.txtContactKlant.Location = new System.Drawing.Point(424, 56);
            this.txtContactKlant.Multiline = true;
            this.txtContactKlant.Name = "txtContactKlant";
            this.txtContactKlant.ReadOnly = true;
            this.txtContactKlant.Size = new System.Drawing.Size(402, 176);
            this.txtContactKlant.TabIndex = 7;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(135, 144);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.ReadOnly = true;
            this.txtAchternaam.Size = new System.Drawing.Size(197, 27);
            this.txtAchternaam.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Achternaam";
            // 
            // txtTussenvoegsel
            // 
            this.txtTussenvoegsel.Location = new System.Drawing.Point(135, 102);
            this.txtTussenvoegsel.Name = "txtTussenvoegsel";
            this.txtTussenvoegsel.ReadOnly = true;
            this.txtTussenvoegsel.Size = new System.Drawing.Size(197, 27);
            this.txtTussenvoegsel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tussenvoegsel";
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(135, 56);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.ReadOnly = true;
            this.txtVoornaam.Size = new System.Drawing.Size(197, 27);
            this.txtVoornaam.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voornaam";
            // 
            // cmdSearchKlant
            // 
            this.cmdSearchKlant.Location = new System.Drawing.Point(21, 17);
            this.cmdSearchKlant.Name = "cmdSearchKlant";
            this.cmdSearchKlant.Size = new System.Drawing.Size(94, 29);
            this.cmdSearchKlant.TabIndex = 0;
            this.cmdSearchKlant.Text = "Zoek klant";
            this.cmdSearchKlant.UseVisualStyleBackColor = true;
            this.cmdSearchKlant.Click += new System.EventHandler(this.cmdSearchKlant_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewProducts);
            this.panel2.Controls.Add(this.cmdAdd);
            this.panel2.Location = new System.Drawing.Point(26, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 345);
            this.panel2.TabIndex = 2;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(21, 60);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 29;
            this.dataGridViewProducts.Size = new System.Drawing.Size(805, 282);
            this.dataGridViewProducts.TabIndex = 1;
            this.dataGridViewProducts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellEndEdit);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(21, 15);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(124, 29);
            this.cmdAdd.TabIndex = 0;
            this.cmdAdd.Text = "Voeg product";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Producten";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(642, 721);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(94, 29);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Annuleren";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(758, 721);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(94, 29);
            this.cmdSave.TabIndex = 4;
            this.cmdSave.Text = "Opslaan";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // NewBestelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 778);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "NewBestelling";
            this.Text = "NewBestelling";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.TextBox txtTussenvoegsel;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Button cmdSearchKlant;
        private System.Windows.Forms.TextBox txtContactKlant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
    }
}