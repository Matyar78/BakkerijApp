
namespace BakkerijApp.BestellingenForms
{
    partial class ZoekProductForm
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
            this.txtZoekProduct = new System.Windows.Forms.TextBox();
            this.dataGridViewProducten = new System.Windows.Forms.DataGridView();
            this.cmdSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducten)).BeginInit();
            this.SuspendLayout();
            // 
            // txtZoekProduct
            // 
            this.txtZoekProduct.Location = new System.Drawing.Point(22, 13);
            this.txtZoekProduct.Name = "txtZoekProduct";
            this.txtZoekProduct.Size = new System.Drawing.Size(216, 27);
            this.txtZoekProduct.TabIndex = 0;
            this.txtZoekProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtZoekProducten_KeyUp);
            // 
            // dataGridViewProducten
            // 
            this.dataGridViewProducten.AllowUserToAddRows = false;
            this.dataGridViewProducten.AllowUserToDeleteRows = false;
            this.dataGridViewProducten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducten.Location = new System.Drawing.Point(22, 47);
            this.dataGridViewProducten.Name = "dataGridViewProducten";
            this.dataGridViewProducten.ReadOnly = true;
            this.dataGridViewProducten.RowHeadersWidth = 51;
            this.dataGridViewProducten.RowTemplate.Height = 29;
            this.dataGridViewProducten.Size = new System.Drawing.Size(766, 341);
            this.dataGridViewProducten.TabIndex = 1;
            // 
            // cmdSelect
            // 
            this.cmdSelect.Location = new System.Drawing.Point(694, 409);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(94, 29);
            this.cmdSelect.TabIndex = 2;
            this.cmdSelect.Text = "Selecteren";
            this.cmdSelect.UseVisualStyleBackColor = true;
            this.cmdSelect.Click += new System.EventHandler(this.cmdSelect_Click);
            // 
            // ZoekProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdSelect);
            this.Controls.Add(this.dataGridViewProducten);
            this.Controls.Add(this.txtZoekProduct);
            this.Name = "ZoekProductForm";
            this.Text = "ZoekProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtZoekProduct;
        private System.Windows.Forms.DataGridView dataGridViewProducten;
        private System.Windows.Forms.Button cmdSelect;
    }
}