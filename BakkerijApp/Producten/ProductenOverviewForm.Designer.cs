
namespace BakkerijApp.ProductenForms
{
    partial class ProductenOverviewForm
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
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            this.dataGridViewProducten = new System.Windows.Forms.DataGridView();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducten)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(145, 38);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(114, 29);
            this.cmdAdd.TabIndex = 0;
            this.cmdAdd.Text = "Toevoegen";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAddKlant_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.Location = new System.Drawing.Point(28, 38);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(94, 29);
            this.cmdBack.TabIndex = 1;
            this.cmdBack.Text = "Terug";
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // dataGridViewProducten
            // 
            this.dataGridViewProducten.AllowUserToAddRows = false;
            this.dataGridViewProducten.AllowUserToDeleteRows = false;
            this.dataGridViewProducten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducten.Location = new System.Drawing.Point(28, 94);
            this.dataGridViewProducten.MultiSelect = false;
            this.dataGridViewProducten.Name = "dataGridViewProducten";
            this.dataGridViewProducten.ReadOnly = true;
            this.dataGridViewProducten.RowHeadersWidth = 51;
            this.dataGridViewProducten.RowTemplate.Height = 29;
            this.dataGridViewProducten.Size = new System.Drawing.Size(1431, 715);
            this.dataGridViewProducten.TabIndex = 2;
            this.dataGridViewProducten.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Enabled = false;
            this.cmdDelete.Location = new System.Drawing.Point(365, 38);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(102, 29);
            this.cmdDelete.TabIndex = 3;
            this.cmdDelete.Text = "Verwijderen";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Enabled = false;
            this.cmdEdit.Location = new System.Drawing.Point(265, 38);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(94, 29);
            this.cmdEdit.TabIndex = 4;
            this.cmdEdit.Text = "Wijzigen";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // ProductenOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.dataGridViewProducten);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.cmdAdd);
            this.Name = "ProductenOverviewForm";
            this.Text = "KlantenOverviewForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KlantenOverviewForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.DataGridView dataGridViewProducten;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdEdit;
    }
}