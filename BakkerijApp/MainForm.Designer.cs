
namespace BakkerijApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdKlantenBeheer = new System.Windows.Forms.Button();
            this.cmdMedewerkersBeheer = new System.Windows.Forms.Button();
            this.cmdProductenBeheer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdKlantenBeheer
            // 
            this.cmdKlantenBeheer.Location = new System.Drawing.Point(245, 121);
            this.cmdKlantenBeheer.Name = "cmdKlantenBeheer";
            this.cmdKlantenBeheer.Size = new System.Drawing.Size(884, 75);
            this.cmdKlantenBeheer.TabIndex = 0;
            this.cmdKlantenBeheer.Text = "Klanten beheer";
            this.cmdKlantenBeheer.UseVisualStyleBackColor = true;
            this.cmdKlantenBeheer.Click += new System.EventHandler(this.cmdKlantenBeheer_Click);
            // 
            // cmdMedewerkersBeheer
            // 
            this.cmdMedewerkersBeheer.Location = new System.Drawing.Point(245, 203);
            this.cmdMedewerkersBeheer.Name = "cmdMedewerkersBeheer";
            this.cmdMedewerkersBeheer.Size = new System.Drawing.Size(884, 74);
            this.cmdMedewerkersBeheer.TabIndex = 1;
            this.cmdMedewerkersBeheer.Text = "Medewerkers beheer";
            this.cmdMedewerkersBeheer.UseVisualStyleBackColor = true;
            this.cmdMedewerkersBeheer.Click += new System.EventHandler(this.cmdMedewerkersBeheer_Click);
            // 
            // cmdProductenBeheer
            // 
            this.cmdProductenBeheer.Location = new System.Drawing.Point(245, 283);
            this.cmdProductenBeheer.Name = "cmdProductenBeheer";
            this.cmdProductenBeheer.Size = new System.Drawing.Size(884, 85);
            this.cmdProductenBeheer.TabIndex = 2;
            this.cmdProductenBeheer.Text = "Producten";
            this.cmdProductenBeheer.UseVisualStyleBackColor = true;
            this.cmdProductenBeheer.Click += new System.EventHandler(this.cmdProductenBeheer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.cmdProductenBeheer);
            this.Controls.Add(this.cmdMedewerkersBeheer);
            this.Controls.Add(this.cmdKlantenBeheer);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdKlantenBeheer;
        private System.Windows.Forms.Button cmdMedewerkersBeheer;
        private System.Windows.Forms.Button cmdProductenBeheer;
    }
}

