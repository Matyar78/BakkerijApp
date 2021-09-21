
namespace BakkerijApp.ProductenForms
{
    partial class NewProductForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textVoorraad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textPrijs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textOmschrijving = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textProductNaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textVoorraad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textPrijs);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textOmschrijving);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textProductNaam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 383);
            this.panel1.TabIndex = 0;
            // 
            // textVoorraad
            // 
            this.textVoorraad.Location = new System.Drawing.Point(135, 321);
            this.textVoorraad.Name = "textVoorraad";
            this.textVoorraad.Size = new System.Drawing.Size(607, 27);
            this.textVoorraad.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Voorraad";
            // 
            // textPrijs
            // 
            this.textPrijs.Location = new System.Drawing.Point(135, 279);
            this.textPrijs.Name = "textPrijs";
            this.textPrijs.Size = new System.Drawing.Size(607, 27);
            this.textPrijs.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prijs";
            // 
            // textOmschrijving
            // 
            this.textOmschrijving.Location = new System.Drawing.Point(135, 61);
            this.textOmschrijving.Multiline = true;
            this.textOmschrijving.Name = "textOmschrijving";
            this.textOmschrijving.Size = new System.Drawing.Size(607, 202);
            this.textOmschrijving.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Omschrijving";
            // 
            // textProductNaam
            // 
            this.textProductNaam.Location = new System.Drawing.Point(135, 17);
            this.textProductNaam.Name = "textProductNaam";
            this.textProductNaam.Size = new System.Drawing.Size(607, 27);
            this.textProductNaam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product naam";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(36, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 23);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Nieuw product gegevens";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(600, 439);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(94, 29);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "Annuleren";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(705, 439);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(94, 29);
            this.cmdSave.TabIndex = 6;
            this.cmdSave.Text = "Opslaan";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 499);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Name = "NewProductForm";
            this.Text = "NewKlantForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox textVoorraad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPrijs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textOmschrijving;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textProductNaam;
        private System.Windows.Forms.Label label1;
    }
}