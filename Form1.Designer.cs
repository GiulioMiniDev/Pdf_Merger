
namespace PdfMerger2._0
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selected_pdfs = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selected_pdfs
            // 
            this.selected_pdfs.AllowDrop = true;
            this.selected_pdfs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_pdfs.FormattingEnabled = true;
            this.selected_pdfs.ItemHeight = 25;
            this.selected_pdfs.Location = new System.Drawing.Point(230, 12);
            this.selected_pdfs.Name = "selected_pdfs";
            this.selected_pdfs.Size = new System.Drawing.Size(679, 729);
            this.selected_pdfs.TabIndex = 5;
            this.selected_pdfs.SelectedIndexChanged += new System.EventHandler(this.selected_pdfs_SelectedIndexChanged);
            this.selected_pdfs.DragDrop += new System.Windows.Forms.DragEventHandler(this.selected_pdfs_DragDrop);
            this.selected_pdfs.DragEnter += new System.Windows.Forms.DragEventHandler(this.selected_pdfs_DragEnter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 58);
            this.button2.TabIndex = 4;
            this.button2.Text = "Merge \'em";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Pdf";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 733);
            this.Controls.Add(this.selected_pdfs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox selected_pdfs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

