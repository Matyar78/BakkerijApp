
namespace BakkerijApp.BestellingenForms
{
    partial class ZoekKlantForm
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
            this.txtSearchKlant = new System.Windows.Forms.TextBox();
            this.dataGridViewZoekKlant = new System.Windows.Forms.DataGridView();
            this.cmdSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZoekKlant)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchKlant
            // 
            this.txtSearchKlant.Location = new System.Drawing.Point(30, 23);
            this.txtSearchKlant.Name = "txtSearchKlant";
            this.txtSearchKlant.Size = new System.Drawing.Size(238, 27);
            this.txtSearchKlant.TabIndex = 0;
            this.txtSearchKlant.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchKlant_KeyUp);
            // 
            // dataGridViewZoekKlant
            // 
            this.dataGridViewZoekKlant.AllowUserToAddRows = false;
            this.dataGridViewZoekKlant.AllowUserToDeleteRows = false;
            this.dataGridViewZoekKlant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZoekKlant.Location = new System.Drawing.Point(30, 73);
            this.dataGridViewZoekKlant.Name = "dataGridViewZoekKlant";
            this.dataGridViewZoekKlant.ReadOnly = true;
            this.dataGridViewZoekKlant.RowHeadersWidth = 51;
            this.dataGridViewZoekKlant.RowTemplate.Height = 29;
            this.dataGridViewZoekKlant.Size = new System.Drawing.Size(1148, 277);
            this.dataGridViewZoekKlant.TabIndex = 1;
            // 
            // cmdSelect
            // 
            this.cmdSelect.Location = new System.Drawing.Point(1083, 368);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(94, 29);
            this.cmdSelect.TabIndex = 2;
            this.cmdSelect.Text = "Selecteren";
            this.cmdSelect.UseVisualStyleBackColor = true;
            this.cmdSelect.Click += new System.EventHandler(this.cmdSelect_Click);
            // 
            // ZoekKlantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 418);
            this.Controls.Add(this.cmdSelect);
            this.Controls.Add(this.dataGridViewZoekKlant);
            this.Controls.Add(this.txtSearchKlant);
            this.Name = "ZoekKlantForm";
            this.Text = "ZoekKlantForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZoekKlant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchKlant;
        private System.Windows.Forms.DataGridView dataGridViewZoekKlant;
        private System.Windows.Forms.Button cmdSelect;
    }
}