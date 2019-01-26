namespace FirstProgram
{
    partial class LendBookWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LendBookWindow));
            this.labCodeToSearch = new System.Windows.Forms.Label();
            this.labRequiredQuantity = new System.Windows.Forms.Label();
            this.jTxtFieldCodeToSearch = new System.Windows.Forms.TextBox();
            this.jTextFieldRequiredQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.labTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labCodeToSearch
            // 
            this.labCodeToSearch.AutoSize = true;
            this.labCodeToSearch.BackColor = System.Drawing.Color.Transparent;
            this.labCodeToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCodeToSearch.ForeColor = System.Drawing.Color.White;
            this.labCodeToSearch.Location = new System.Drawing.Point(34, 28);
            this.labCodeToSearch.Name = "labCodeToSearch";
            this.labCodeToSearch.Size = new System.Drawing.Size(111, 17);
            this.labCodeToSearch.TabIndex = 0;
            this.labCodeToSearch.Text = "Código del Libro";
            // 
            // labRequiredQuantity
            // 
            this.labRequiredQuantity.AutoSize = true;
            this.labRequiredQuantity.BackColor = System.Drawing.Color.Transparent;
            this.labRequiredQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRequiredQuantity.ForeColor = System.Drawing.Color.White;
            this.labRequiredQuantity.Location = new System.Drawing.Point(34, 80);
            this.labRequiredQuantity.Name = "labRequiredQuantity";
            this.labRequiredQuantity.Size = new System.Drawing.Size(134, 17);
            this.labRequiredQuantity.TabIndex = 1;
            this.labRequiredQuantity.Text = "Cantidad Requerida";
            // 
            // jTxtFieldCodeToSearch
            // 
            this.jTxtFieldCodeToSearch.Location = new System.Drawing.Point(226, 26);
            this.jTxtFieldCodeToSearch.Name = "jTxtFieldCodeToSearch";
            this.jTxtFieldCodeToSearch.Size = new System.Drawing.Size(100, 20);
            this.jTxtFieldCodeToSearch.TabIndex = 2;
            // 
            // jTextFieldRequiredQuantity
            // 
            this.jTextFieldRequiredQuantity.Location = new System.Drawing.Point(226, 78);
            this.jTextFieldRequiredQuantity.Name = "jTextFieldRequiredQuantity";
            this.jTextFieldRequiredQuantity.Size = new System.Drawing.Size(100, 20);
            this.jTextFieldRequiredQuantity.TabIndex = 3;
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "1 Día",
            "1 Mes",
            "1 Año"});
            this.comboBoxTime.Location = new System.Drawing.Point(226, 130);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTime.TabIndex = 4;
            this.comboBoxTime.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.BackColor = System.Drawing.Color.Transparent;
            this.labTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.ForeColor = System.Drawing.Color.White;
            this.labTime.Location = new System.Drawing.Point(34, 132);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(55, 17);
            this.labTime.TabIndex = 5;
            this.labTime.Text = "Tiempo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(116, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Solicitar Prestamo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LendBookWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(354, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.jTextFieldRequiredQuantity);
            this.Controls.Add(this.jTxtFieldCodeToSearch);
            this.Controls.Add(this.labRequiredQuantity);
            this.Controls.Add(this.labCodeToSearch);
            this.Name = "LendBookWindow";
            this.Text = "Prestar Libro";
            this.Load += new System.EventHandler(this.LendBookWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCodeToSearch;
        private System.Windows.Forms.Label labRequiredQuantity;
        private System.Windows.Forms.TextBox jTxtFieldCodeToSearch;
        private System.Windows.Forms.TextBox jTextFieldRequiredQuantity;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Button button1;
    }
}