
namespace StudentsDairy
{
    partial class Main
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
            this.editButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dgvDiary = new System.Windows.Forms.DataGridView();
            this.cbSortByGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiary)).BeginInit();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.editButton.Location = new System.Drawing.Point(142, 12);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(101, 48);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edycja";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.refreshButton.Location = new System.Drawing.Point(408, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(137, 48);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Odśwież";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.Color.Red;
            this.delButton.Location = new System.Drawing.Point(275, 12);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(93, 48);
            this.delButton.TabIndex = 3;
            this.delButton.Text = "Usuń";
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addButton.Location = new System.Drawing.Point(12, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(101, 48);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dgvDiary
            // 
            this.dgvDiary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiary.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiary.Location = new System.Drawing.Point(12, 92);
            this.dgvDiary.Name = "dgvDiary";
            this.dgvDiary.RowHeadersVisible = false;
            this.dgvDiary.RowHeadersWidth = 82;
            this.dgvDiary.RowTemplate.Height = 33;
            this.dgvDiary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiary.Size = new System.Drawing.Size(1426, 677);
            this.dgvDiary.TabIndex = 5;
            this.dgvDiary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiary_CellContentClick);
            // 
            // cbSortByGroup
            // 
            this.cbSortByGroup.FormattingEnabled = true;
            this.cbSortByGroup.Location = new System.Drawing.Point(668, 26);
            this.cbSortByGroup.Name = "cbSortByGroup";
            this.cbSortByGroup.Size = new System.Drawing.Size(193, 33);
            this.cbSortByGroup.TabIndex = 6;
            this.cbSortByGroup.SelectedIndexChanged += new System.EventHandler(this.cbSortByGroup_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Grupa:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(2074, 994);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSortByGroup);
            this.Controls.Add(this.dgvDiary);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.editButton);
            this.Name = "Main";
            this.Text = "Dziennik uczniów";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dgvDiary;
        private System.Windows.Forms.ComboBox cbSortByGroup;
        private System.Windows.Forms.Label label1;
    }
}

