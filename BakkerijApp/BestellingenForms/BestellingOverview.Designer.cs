
namespace BakkerijApp.BestellingenForms
{
    partial class BestellingOverview
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
            this.cmdBack = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.dataGridViewBestellingen = new System.Windows.Forms.DataGridView();
            this.dataGridViewBestelRegels = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBestellingen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBestelRegels)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdBack
            // 
            this.cmdBack.Location = new System.Drawing.Point(29, 26);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(94, 29);
            this.cmdBack.TabIndex = 0;
            this.cmdBack.Text = "Terug";
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(145, 26);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(94, 29);
            this.cmdAdd.TabIndex = 1;
            this.cmdAdd.Text = "Toevoegen";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // dataGridViewBestellingen
            // 
            this.dataGridViewBestellingen.AllowUserToAddRows = false;
            this.dataGridViewBestellingen.AllowUserToDeleteRows = false;
            this.dataGridViewBestellingen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBestellingen.Location = new System.Drawing.Point(29, 73);
            this.dataGridViewBestellingen.Name = "dataGridViewBestellingen";
            this.dataGridViewBestellingen.ReadOnly = true;
            this.dataGridViewBestellingen.RowHeadersWidth = 51;
            this.dataGridViewBestellingen.RowTemplate.Height = 29;
            this.dataGridViewBestellingen.Size = new System.Drawing.Size(1415, 307);
            this.dataGridViewBestellingen.TabIndex = 3;
            this.dataGridViewBestellingen.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBestellingen_RowEnter);
            // 
            // dataGridViewBestelRegels
            // 
            this.dataGridViewBestelRegels.AllowUserToAddRows = false;
            this.dataGridViewBestelRegels.AllowUserToDeleteRows = false;
            this.dataGridViewBestelRegels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBestelRegels.Location = new System.Drawing.Point(29, 431);
            this.dataGridViewBestelRegels.Name = "dataGridViewBestelRegels";
            this.dataGridViewBestelRegels.ReadOnly = true;
            this.dataGridViewBestelRegels.RowHeadersWidth = 51;
            this.dataGridViewBestelRegels.RowTemplate.Height = 29;
            this.dataGridViewBestelRegels.Size = new System.Drawing.Size(1415, 338);
            this.dataGridViewBestelRegels.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Producten";
            // 
            // BestellingOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewBestelRegels);
            this.Controls.Add(this.dataGridViewBestellingen);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmdBack);
            this.Name = "BestellingOverview";
            this.Text = "BestellingOverview";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBestellingen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBestelRegels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.DataGridView dataGridViewBestellingen;
        private System.Windows.Forms.DataGridView dataGridViewBestelRegels;
        private System.Windows.Forms.Label label1;
    }
}