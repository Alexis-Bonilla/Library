namespace FirstProgram
{
    partial class InitialWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialWindow));
            this.labWelcome = new System.Windows.Forms.Label();
            this.labWhatDoYouWant = new System.Windows.Forms.Label();
            this.butAddBook = new System.Windows.Forms.Button();
            this.butLendBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labWelcome
            // 
            this.labWelcome.AutoSize = true;
            this.labWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWelcome.ForeColor = System.Drawing.Color.White;
            this.labWelcome.Location = new System.Drawing.Point(12, 9);
            this.labWelcome.Name = "labWelcome";
            this.labWelcome.Size = new System.Drawing.Size(426, 17);
            this.labWelcome.TabIndex = 0;
            this.labWelcome.Text = "Bienvenido al Software de gestión de libros de la Universidad Icesi";
            // 
            // labWhatDoYouWant
            // 
            this.labWhatDoYouWant.AutoSize = true;
            this.labWhatDoYouWant.BackColor = System.Drawing.Color.Transparent;
            this.labWhatDoYouWant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWhatDoYouWant.ForeColor = System.Drawing.Color.White;
            this.labWhatDoYouWant.Location = new System.Drawing.Point(12, 65);
            this.labWhatDoYouWant.Name = "labWhatDoYouWant";
            this.labWhatDoYouWant.Size = new System.Drawing.Size(126, 17);
            this.labWhatDoYouWant.TabIndex = 1;
            this.labWhatDoYouWant.Text = "Que desea hacer?";
            // 
            // butAddBook
            // 
            this.butAddBook.BackColor = System.Drawing.Color.Black;
            this.butAddBook.ForeColor = System.Drawing.Color.White;
            this.butAddBook.Location = new System.Drawing.Point(15, 112);
            this.butAddBook.Name = "butAddBook";
            this.butAddBook.Size = new System.Drawing.Size(158, 44);
            this.butAddBook.TabIndex = 2;
            this.butAddBook.Text = "Añadir Libro";
            this.butAddBook.UseVisualStyleBackColor = false;
            this.butAddBook.Click += new System.EventHandler(this.butAddBook_Click);
            // 
            // butLendBook
            // 
            this.butLendBook.BackColor = System.Drawing.Color.Black;
            this.butLendBook.ForeColor = System.Drawing.Color.White;
            this.butLendBook.Location = new System.Drawing.Point(15, 184);
            this.butLendBook.Name = "butLendBook";
            this.butLendBook.Size = new System.Drawing.Size(158, 44);
            this.butLendBook.TabIndex = 3;
            this.butLendBook.Text = "Prestar Libro";
            this.butLendBook.UseVisualStyleBackColor = false;
            this.butLendBook.Click += new System.EventHandler(this.butLendBook_Click);
            // 
            // InitialWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 261);
            this.Controls.Add(this.butLendBook);
            this.Controls.Add(this.butAddBook);
            this.Controls.Add(this.labWhatDoYouWant);
            this.Controls.Add(this.labWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InitialWindow";
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.InitialWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labWelcome;
        private System.Windows.Forms.Label labWhatDoYouWant;
        private System.Windows.Forms.Button butAddBook;
        private System.Windows.Forms.Button butLendBook;
    }
}