
namespace BakkerijApp.KlantenForms
{
    partial class KlantenOverviewForm
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
            this.dataGridViewKlanten = new System.Windows.Forms.DataGridView();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlanten)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(145, 38);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(94, 29);
            this.cmdAdd.TabIndex = 0;
            this.cmdAdd.Text = "Toevoegen";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
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
            // dataGridViewKlanten
            // 
            this.dataGridViewKlanten.AllowUserToAddRows = false;
            this.dataGridViewKlanten.AllowUserToDeleteRows = false;
            this.dataGridViewKlanten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKlanten.Location = new System.Drawing.Point(28, 94);
            this.dataGridViewKlanten.MultiSelect = false;
            this.dataGridViewKlanten.Name = "dataGridViewKlanten";
            this.dataGridViewKlanten.ReadOnly = true;
            this.dataGridViewKlanten.RowHeadersWidth = 51;
            this.dataGridViewKlanten.RowTemplate.Height = 29;
            this.dataGridViewKlanten.Size = new System.Drawing.Size(1431, 715);
            this.dataGridViewKlanten.TabIndex = 2;
            this.dataGridViewKlanten.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Enabled = false;
            this.cmdDelete.Location = new System.Drawing.Point(345, 38);
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
            this.cmdEdit.Location = new System.Drawing.Point(245, 38);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(94, 29);
            this.cmdEdit.TabIndex = 4;
            this.cmdEdit.Text = "Wijzigen";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // KlantenOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.dataGridViewKlanten);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.cmdAdd);
            this.Name = "KlantenOverviewForm";
            this.Text = "KlantenOverviewForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KlantenOverviewForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlanten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.DataGridView dataGridViewKlanten;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdEdit;
    }
}