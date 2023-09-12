namespace Bangladesh_Cricket_Board
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRun = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMatchFormat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colPrize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Player Run";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(203, 212);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 32);
            this.txtName.TabIndex = 0;
            // 
            // txtRun
            // 
            this.txtRun.Location = new System.Drawing.Point(446, 212);
            this.txtRun.Name = "txtRun";
            this.txtRun.Size = new System.Drawing.Size(211, 32);
            this.txtRun.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMatchFormat,
            this.colPrize});
            this.dataGridView1.Location = new System.Drawing.Point(203, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(454, 239);
            this.dataGridView1.TabIndex = 2;
            // 
            // colMatchFormat
            // 
            this.colMatchFormat.HeaderText = "Match Format";
            this.colMatchFormat.MinimumWidth = 6;
            this.colMatchFormat.Name = "colMatchFormat";
            // 
            // colPrize
            // 
            this.colPrize.HeaderText = "Prize Money";
            this.colPrize.MinimumWidth = 6;
            this.colPrize.Name = "colPrize";
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(203, 524);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(92, 36);
            this.btnSaveAll.TabIndex = 3;
            this.btnSaveAll.Text = "Save All";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Player Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(923, 690);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtRun);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Sweet Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.TextBox txtName;
            private System.Windows.Forms.TextBox txtRun;
            private System.Windows.Forms.DataGridView dataGridView1;
            private System.Windows.Forms.Button btnSaveAll;
            private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMatchFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrize;
    }
    }

