
namespace Feladat
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
            this.label1 = new System.Windows.Forms.Label();
            this.kolcsonzesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.szuresButton = new System.Windows.Forms.Button();
            this.dvdDataGridView = new System.Windows.Forms.DataGridView();
            this.exportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvdDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dvd-k listája";
            // 
            // kolcsonzesDateTimePicker
            // 
            this.kolcsonzesDateTimePicker.Location = new System.Drawing.Point(343, 240);
            this.kolcsonzesDateTimePicker.Name = "kolcsonzesDateTimePicker";
            this.kolcsonzesDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.kolcsonzesDateTimePicker.TabIndex = 1;
            // 
            // szuresButton
            // 
            this.szuresButton.Location = new System.Drawing.Point(218, 240);
            this.szuresButton.Name = "szuresButton";
            this.szuresButton.Size = new System.Drawing.Size(75, 23);
            this.szuresButton.TabIndex = 2;
            this.szuresButton.Text = "Szűrés";
            this.szuresButton.UseVisualStyleBackColor = true;
            this.szuresButton.Click += new System.EventHandler(this.szuresButton_Click);
            // 
            // dvdDataGridView
            // 
            this.dvdDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvdDataGridView.Location = new System.Drawing.Point(343, 48);
            this.dvdDataGridView.Name = "dvdDataGridView";
            this.dvdDataGridView.Size = new System.Drawing.Size(240, 150);
            this.dvdDataGridView.TabIndex = 3;
            this.dvdDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(218, 293);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 4;
            this.exportButton.Text = "Excel export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.dvdDataGridView);
            this.Controls.Add(this.szuresButton);
            this.Controls.Add(this.kolcsonzesDateTimePicker);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvdDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker kolcsonzesDateTimePicker;
        private System.Windows.Forms.Button szuresButton;
        private System.Windows.Forms.DataGridView dvdDataGridView;
        private System.Windows.Forms.Button exportButton;
    }
}

