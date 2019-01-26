namespace FirstProgram
{
    partial class AddBookWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookWindow));
            this.labEnterData = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.labAuthor = new System.Windows.Forms.Label();
            this.labCode = new System.Windows.Forms.Label();
            this.labEditorial = new System.Windows.Forms.Label();
            this.labPubDate = new System.Windows.Forms.Label();
            this.jTxtFieldName = new System.Windows.Forms.TextBox();
            this.jTxtFieldCode = new System.Windows.Forms.TextBox();
            this.jTxtFieldGender = new System.Windows.Forms.TextBox();
            this.jTxtFieldPubDate = new System.Windows.Forms.TextBox();
            this.jTxtFieldAuthor = new System.Windows.Forms.TextBox();
            this.jTxtFieldEditorial = new System.Windows.Forms.TextBox();
            this.butAddBook = new System.Windows.Forms.Button();
            this.jTxtFieldQuantity = new System.Windows.Forms.TextBox();
            this.labQuantity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labEnterData
            // 
            this.labEnterData.AutoSize = true;
            this.labEnterData.BackColor = System.Drawing.Color.Transparent;
            this.labEnterData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEnterData.ForeColor = System.Drawing.Color.White;
            this.labEnterData.Location = new System.Drawing.Point(29, 9);
            this.labEnterData.Name = "labEnterData";
            this.labEnterData.Size = new System.Drawing.Size(205, 15);
            this.labEnterData.TabIndex = 0;
            this.labEnterData.Text = "Por favor, digite los siguientes datos:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Transparent;
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.ForeColor = System.Drawing.Color.White;
            this.labName.Location = new System.Drawing.Point(29, 50);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(52, 15);
            this.labName.TabIndex = 1;
            this.labName.Text = "Nombre";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.BackColor = System.Drawing.Color.Transparent;
            this.labGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGender.ForeColor = System.Drawing.Color.White;
            this.labGender.Location = new System.Drawing.Point(29, 140);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(48, 15);
            this.labGender.TabIndex = 2;
            this.labGender.Text = "Género";
            // 
            // labAuthor
            // 
            this.labAuthor.AutoSize = true;
            this.labAuthor.BackColor = System.Drawing.Color.Transparent;
            this.labAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAuthor.ForeColor = System.Drawing.Color.White;
            this.labAuthor.Location = new System.Drawing.Point(29, 110);
            this.labAuthor.Name = "labAuthor";
            this.labAuthor.Size = new System.Drawing.Size(35, 15);
            this.labAuthor.TabIndex = 2;
            this.labAuthor.Text = "Autor";
            // 
            // labCode
            // 
            this.labCode.AutoSize = true;
            this.labCode.BackColor = System.Drawing.Color.Transparent;
            this.labCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCode.ForeColor = System.Drawing.Color.White;
            this.labCode.Location = new System.Drawing.Point(29, 80);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(46, 15);
            this.labCode.TabIndex = 3;
            this.labCode.Text = "Código";
            // 
            // labEditorial
            // 
            this.labEditorial.AutoSize = true;
            this.labEditorial.BackColor = System.Drawing.Color.Transparent;
            this.labEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEditorial.ForeColor = System.Drawing.Color.White;
            this.labEditorial.Location = new System.Drawing.Point(29, 170);
            this.labEditorial.Name = "labEditorial";
            this.labEditorial.Size = new System.Drawing.Size(52, 15);
            this.labEditorial.TabIndex = 4;
            this.labEditorial.Text = "Editorial";
            // 
            // labPubDate
            // 
            this.labPubDate.AutoSize = true;
            this.labPubDate.BackColor = System.Drawing.Color.Transparent;
            this.labPubDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPubDate.ForeColor = System.Drawing.Color.White;
            this.labPubDate.Location = new System.Drawing.Point(29, 200);
            this.labPubDate.Name = "labPubDate";
            this.labPubDate.Size = new System.Drawing.Size(125, 15);
            this.labPubDate.TabIndex = 5;
            this.labPubDate.Text = "Fecha de Publicación";
            // 
            // jTxtFieldName
            // 
            this.jTxtFieldName.Location = new System.Drawing.Point(178, 49);
            this.jTxtFieldName.Name = "jTxtFieldName";
            this.jTxtFieldName.Size = new System.Drawing.Size(100, 20);
            this.jTxtFieldName.TabIndex = 6;
            // 
            // jTxtFieldCode
            // 
            this.jTxtFieldCode.Location = new System.Drawing.Point(178, 79);
            this.jTxtFieldCode.Name = "jTxtFieldCode";
            this.jTxtFieldCode.Size = new System.Drawing.Size(100, 20);
            this.jTxtFieldCode.TabIndex = 7;
            // 
            // jTxtFieldGender
            // 
            this.jTxtFieldGender.Location = new System.Drawing.Point(178, 139);
            this.jTxtFieldGender.Name = "jTxtFieldGender";
            this.jTxtFieldGender.Size = new System.Drawing.Size(100, 20);
            this.jTxtFieldGender.TabIndex = 8;
            this.jTxtFieldGender.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // jTxtFieldPubDate
            // 
            this.jTxtFieldPubDate.Location = new System.Drawing.Point(178, 199);
            this.jTxtFieldPubDate.Name = "jTxtFieldPubDate";
            this.jTxtFieldPubDate.Size = new System.Drawing.Size(100, 20);
            this.jTxtFieldPubDate.TabIndex = 9;
            // 
            // jTxtFieldAuthor
            // 
            this.jTxtFieldAuthor.Location = new System.Drawing.Point(178, 109);
            this.jTxtFieldAuthor.Name = "jTxtFieldAuthor";
            this.jTxtFieldAuthor.Size = new System.Drawing.Size(100, 20);
            this.jTxtFieldAuthor.TabIndex = 10;
            // 
            // jTxtFieldEditorial
            // 
            this.jTxtFieldEditorial.Location = new System.Drawing.Point(178, 169);
            this.jTxtFieldEditorial.Name = "jTxtFieldEditorial";
            this.jTxtFieldEditorial.Size = new System.Drawing.Size(100, 20);
            this.jTxtFieldEditorial.TabIndex = 11;
            // 
            // butAddBook
            // 
            this.butAddBook.BackColor = System.Drawing.Color.Black;
            this.butAddBook.ForeColor = System.Drawing.Color.White;
            this.butAddBook.Location = new System.Drawing.Point(94, 278);
            this.butAddBook.Name = "butAddBook";
            this.butAddBook.Size = new System.Drawing.Size(108, 35);
            this.butAddBook.TabIndex = 12;
            this.butAddBook.Text = "Añadir Libro";
            this.butAddBook.UseVisualStyleBackColor = false;
            this.butAddBook.Click += new System.EventHandler(this.butAddBook_Click);
            // 
            // jTxtFieldQuantity
            // 
            this.jTxtFieldQuantity.Location = new System.Drawing.Point(178, 229);
            this.jTxtFieldQuantity.Name = "jTxtFieldQuantity";
            this.jTxtFieldQuantity.Size = new System.Drawing.Size(100, 20);
            this.jTxtFieldQuantity.TabIndex = 13;
            // 
            // labQuantity
            // 
            this.labQuantity.AutoSize = true;
            this.labQuantity.BackColor = System.Drawing.Color.Transparent;
            this.labQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQuantity.ForeColor = System.Drawing.Color.White;
            this.labQuantity.Location = new System.Drawing.Point(29, 230);
            this.labQuantity.Name = "labQuantity";
            this.labQuantity.Size = new System.Drawing.Size(56, 15);
            this.labQuantity.TabIndex = 14;
            this.labQuantity.Text = "Cantidad";
            // 
            // AddBookWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(305, 325);
            this.Controls.Add(this.labQuantity);
            this.Controls.Add(this.jTxtFieldQuantity);
            this.Controls.Add(this.butAddBook);
            this.Controls.Add(this.jTxtFieldEditorial);
            this.Controls.Add(this.jTxtFieldAuthor);
            this.Controls.Add(this.jTxtFieldPubDate);
            this.Controls.Add(this.jTxtFieldGender);
            this.Controls.Add(this.jTxtFieldCode);
            this.Controls.Add(this.jTxtFieldName);
            this.Controls.Add(this.labPubDate);
            this.Controls.Add(this.labEditorial);
            this.Controls.Add(this.labCode);
            this.Controls.Add(this.labAuthor);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labEnterData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddBookWindow";
            this.Text = "Añadir Libro";
            this.Load += new System.EventHandler(this.AddBookWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labEnterData;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labAuthor;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.Label labEditorial;
        private System.Windows.Forms.Label labPubDate;
        private System.Windows.Forms.TextBox jTxtFieldName;
        private System.Windows.Forms.TextBox jTxtFieldCode;
        private System.Windows.Forms.TextBox jTxtFieldPubDate;
        private System.Windows.Forms.TextBox jTxtFieldAuthor;
        private System.Windows.Forms.TextBox jTxtFieldEditorial;
        private System.Windows.Forms.TextBox jTxtFieldGender;
        private System.Windows.Forms.Button butAddBook;
        private System.Windows.Forms.TextBox jTxtFieldQuantity;
        private System.Windows.Forms.Label labQuantity;
    }
}

