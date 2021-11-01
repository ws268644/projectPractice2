
namespace projectPractice2
{
    partial class frmMenu
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetDataTable = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHighestScore = new System.Windows.Forms.Label();
            this.lblAverageScore = new System.Windows.Forms.Label();
            this.lblNameResult = new System.Windows.Forms.Label();
            this.lblHighestResult = new System.Windows.Forms.Label();
            this.lblAverageResult = new System.Windows.Forms.Label();
            this.btnReader = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Go back";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 125);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnGetDataTable
            // 
            this.btnGetDataTable.Location = new System.Drawing.Point(12, 52);
            this.btnGetDataTable.Name = "btnGetDataTable";
            this.btnGetDataTable.Size = new System.Drawing.Size(75, 33);
            this.btnGetDataTable.TabIndex = 3;
            this.btnGetDataTable.Text = "Get data";
            this.btnGetDataTable.UseVisualStyleBackColor = true;
            this.btnGetDataTable.Click += new System.EventHandler(this.btnGetDataTable_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(568, 124);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblHighestScore
            // 
            this.lblHighestScore.AutoSize = true;
            this.lblHighestScore.Location = new System.Drawing.Point(568, 150);
            this.lblHighestScore.Name = "lblHighestScore";
            this.lblHighestScore.Size = new System.Drawing.Size(75, 13);
            this.lblHighestScore.TabIndex = 5;
            this.lblHighestScore.Text = "Highest score:";
            // 
            // lblAverageScore
            // 
            this.lblAverageScore.AutoSize = true;
            this.lblAverageScore.Location = new System.Drawing.Point(568, 179);
            this.lblAverageScore.Name = "lblAverageScore";
            this.lblAverageScore.Size = new System.Drawing.Size(79, 13);
            this.lblAverageScore.TabIndex = 6;
            this.lblAverageScore.Text = "Average score:";
            // 
            // lblNameResult
            // 
            this.lblNameResult.AutoSize = true;
            this.lblNameResult.Location = new System.Drawing.Point(612, 124);
            this.lblNameResult.Name = "lblNameResult";
            this.lblNameResult.Size = new System.Drawing.Size(13, 13);
            this.lblNameResult.TabIndex = 7;
            this.lblNameResult.Text = "0";
            // 
            // lblHighestResult
            // 
            this.lblHighestResult.AutoSize = true;
            this.lblHighestResult.Location = new System.Drawing.Point(649, 150);
            this.lblHighestResult.Name = "lblHighestResult";
            this.lblHighestResult.Size = new System.Drawing.Size(13, 13);
            this.lblHighestResult.TabIndex = 8;
            this.lblHighestResult.Text = "0";
            // 
            // lblAverageResult
            // 
            this.lblAverageResult.AutoSize = true;
            this.lblAverageResult.Location = new System.Drawing.Point(653, 179);
            this.lblAverageResult.Name = "lblAverageResult";
            this.lblAverageResult.Size = new System.Drawing.Size(13, 13);
            this.lblAverageResult.TabIndex = 9;
            this.lblAverageResult.Text = "0";
            // 
            // btnReader
            // 
            this.btnReader.Location = new System.Drawing.Point(121, 52);
            this.btnReader.Name = "btnReader";
            this.btnReader.Size = new System.Drawing.Size(75, 33);
            this.btnReader.TabIndex = 10;
            this.btnReader.Text = "Reader";
            this.btnReader.UseVisualStyleBackColor = true;
            this.btnReader.Click += new System.EventHandler(this.btnReader_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReader);
            this.Controls.Add(this.lblAverageResult);
            this.Controls.Add(this.lblHighestResult);
            this.Controls.Add(this.lblNameResult);
            this.Controls.Add(this.lblAverageScore);
            this.Controls.Add(this.lblHighestScore);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnGetDataTable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReturn);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetDataTable;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHighestScore;
        private System.Windows.Forms.Label lblAverageScore;
        private System.Windows.Forms.Label lblNameResult;
        private System.Windows.Forms.Label lblHighestResult;
        private System.Windows.Forms.Label lblAverageResult;
        private System.Windows.Forms.Button btnReader;
    }
}