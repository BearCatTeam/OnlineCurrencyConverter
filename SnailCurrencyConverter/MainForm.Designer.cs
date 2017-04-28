namespace SnailCurrencyConverter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.src_currencyCb = new System.Windows.Forms.ComboBox();
            this.dest_currencyCb = new System.Windows.Forms.ComboBox();
            this.src_amountTb = new System.Windows.Forms.TextBox();
            this.dest_amountTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.convert_bt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // src_currencyCb
            // 
            this.src_currencyCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.src_currencyCb.FormattingEnabled = true;
            this.src_currencyCb.Location = new System.Drawing.Point(19, 39);
            this.src_currencyCb.Margin = new System.Windows.Forms.Padding(6);
            this.src_currencyCb.Name = "src_currencyCb";
            this.src_currencyCb.Size = new System.Drawing.Size(320, 37);
            this.src_currencyCb.TabIndex = 0;
            // 
            // dest_currencyCb
            // 
            this.dest_currencyCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dest_currencyCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dest_currencyCb.FormattingEnabled = true;
            this.dest_currencyCb.Location = new System.Drawing.Point(408, 39);
            this.dest_currencyCb.Margin = new System.Windows.Forms.Padding(6);
            this.dest_currencyCb.Name = "dest_currencyCb";
            this.dest_currencyCb.Size = new System.Drawing.Size(320, 37);
            this.dest_currencyCb.TabIndex = 1;
            // 
            // src_amountTb
            // 
            this.src_amountTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.src_amountTb.Location = new System.Drawing.Point(19, 83);
            this.src_amountTb.Margin = new System.Windows.Forms.Padding(6);
            this.src_amountTb.Name = "src_amountTb";
            this.src_amountTb.Size = new System.Drawing.Size(320, 36);
            this.src_amountTb.TabIndex = 2;
            this.src_amountTb.Enter += new System.EventHandler(this.src_amountTb_Enter);
            this.src_amountTb.Leave += new System.EventHandler(this.src_amountTb_Leave);
            // 
            // dest_amountTb
            // 
            this.dest_amountTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dest_amountTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dest_amountTb.Location = new System.Drawing.Point(408, 83);
            this.dest_amountTb.Margin = new System.Windows.Forms.Padding(6);
            this.dest_amountTb.Name = "dest_amountTb";
            this.dest_amountTb.ReadOnly = true;
            this.dest_amountTb.Size = new System.Drawing.Size(320, 36);
            this.dest_amountTb.TabIndex = 3;
            this.dest_amountTb.Enter += new System.EventHandler(this.dest_amountTb_Enter);
            this.dest_amountTb.Leave += new System.EventHandler(this.dest_amountTb_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source Currency";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination Currency";
            // 
            // convert_bt
            // 
            this.convert_bt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convert_bt.Location = new System.Drawing.Point(19, 124);
            this.convert_bt.Margin = new System.Windows.Forms.Padding(6);
            this.convert_bt.Name = "convert_bt";
            this.convert_bt.Size = new System.Drawing.Size(709, 60);
            this.convert_bt.TabIndex = 4;
            this.convert_bt.Text = "Convert";
            this.convert_bt.UseVisualStyleBackColor = true;
            this.convert_bt.Click += new System.EventHandler(this.convert_bt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(709, 448);
            this.dataGridView1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 653);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.convert_bt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dest_amountTb);
            this.Controls.Add(this.src_amountTb);
            this.Controls.Add(this.dest_currencyCb);
            this.Controls.Add(this.src_currencyCb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Snail Currency Converter";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox src_currencyCb;
        private System.Windows.Forms.ComboBox dest_currencyCb;
        private System.Windows.Forms.TextBox src_amountTb;
        private System.Windows.Forms.TextBox dest_amountTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button convert_bt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

