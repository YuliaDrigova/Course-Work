namespace courseWork
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bn_add = new System.Windows.Forms.Button();
            this.bn_Edit = new System.Windows.Forms.Button();
            this.bn_Search = new System.Windows.Forms.Button();
            this.bn_Delete = new System.Windows.Forms.Button();
            this.dgv_films = new System.Windows.Forms.DataGridView();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.bn_Show = new System.Windows.Forms.Button();
            this.bn_save = new System.Windows.Forms.Button();
            this.pb_POSTER = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_films)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_POSTER)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cataloguer \"Films\"";
            // 
            // bn_add
            // 
            this.bn_add.Location = new System.Drawing.Point(176, 241);
            this.bn_add.Margin = new System.Windows.Forms.Padding(2);
            this.bn_add.Name = "bn_add";
            this.bn_add.Size = new System.Drawing.Size(148, 42);
            this.bn_add.TabIndex = 3;
            this.bn_add.Text = "New film";
            this.bn_add.UseVisualStyleBackColor = true;
            this.bn_add.Click += new System.EventHandler(this.bn_add_Click);
            // 
            // bn_Edit
            // 
            this.bn_Edit.Location = new System.Drawing.Point(337, 241);
            this.bn_Edit.Name = "bn_Edit";
            this.bn_Edit.Size = new System.Drawing.Size(148, 42);
            this.bn_Edit.TabIndex = 4;
            this.bn_Edit.Text = "Edit";
            this.bn_Edit.UseVisualStyleBackColor = true;
            this.bn_Edit.Click += new System.EventHandler(this.bn_Edit_Click);
            // 
            // bn_Search
            // 
            this.bn_Search.Location = new System.Drawing.Point(12, 337);
            this.bn_Search.Name = "bn_Search";
            this.bn_Search.Size = new System.Drawing.Size(148, 42);
            this.bn_Search.TabIndex = 5;
            this.bn_Search.Text = "Search";
            this.bn_Search.UseVisualStyleBackColor = true;
            this.bn_Search.Click += new System.EventHandler(this.bn_Search_Click);
            // 
            // bn_Delete
            // 
            this.bn_Delete.Location = new System.Drawing.Point(503, 241);
            this.bn_Delete.Name = "bn_Delete";
            this.bn_Delete.Size = new System.Drawing.Size(148, 42);
            this.bn_Delete.TabIndex = 6;
            this.bn_Delete.Text = "Delete";
            this.bn_Delete.UseVisualStyleBackColor = true;
            this.bn_Delete.Click += new System.EventHandler(this.bn_Delete_Click);
            // 
            // dgv_films
            // 
            this.dgv_films.AllowUserToAddRows = false;
            this.dgv_films.AllowUserToDeleteRows = false;
            this.dgv_films.AllowUserToResizeColumns = false;
            this.dgv_films.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgv_films.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_films.Location = new System.Drawing.Point(-2, 63);
            this.dgv_films.Name = "dgv_films";
            this.dgv_films.Size = new System.Drawing.Size(867, 150);
            this.dgv_films.TabIndex = 7;
            this.dgv_films.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_films_ColumnHeaderMouseClick);
            this.dgv_films.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_films_MouseClick);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(176, 337);
            this.tb_search.Multiline = true;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(196, 42);
            this.tb_search.TabIndex = 8;
            // 
            // bn_Show
            // 
            this.bn_Show.Location = new System.Drawing.Point(12, 241);
            this.bn_Show.Name = "bn_Show";
            this.bn_Show.Size = new System.Drawing.Size(148, 42);
            this.bn_Show.TabIndex = 10;
            this.bn_Show.Text = "Show list ";
            this.bn_Show.UseVisualStyleBackColor = true;
            this.bn_Show.Click += new System.EventHandler(this.bn_Show_Click);
            // 
            // bn_save
            // 
            this.bn_save.BackColor = System.Drawing.Color.LightCoral;
            this.bn_save.Location = new System.Drawing.Point(690, 241);
            this.bn_save.Name = "bn_save";
            this.bn_save.Size = new System.Drawing.Size(175, 97);
            this.bn_save.TabIndex = 12;
            this.bn_save.Text = "SAVE";
            this.bn_save.UseVisualStyleBackColor = false;
            this.bn_save.Click += new System.EventHandler(this.bn_save_Click);
            // 
            // pb_POSTER
            // 
            this.pb_POSTER.Location = new System.Drawing.Point(888, 63);
            this.pb_POSTER.Name = "pb_POSTER";
            this.pb_POSTER.Size = new System.Drawing.Size(122, 150);
            this.pb_POSTER.TabIndex = 13;
            this.pb_POSTER.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1022, 427);
            this.Controls.Add(this.pb_POSTER);
            this.Controls.Add(this.bn_save);
            this.Controls.Add(this.bn_Show);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.dgv_films);
            this.Controls.Add(this.bn_Delete);
            this.Controls.Add(this.bn_Search);
            this.Controls.Add(this.bn_Edit);
            this.Controls.Add(this.bn_add);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Catalog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_films)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_POSTER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bn_add;
        private System.Windows.Forms.Button bn_Edit;
        private System.Windows.Forms.Button bn_Search;
        private System.Windows.Forms.Button bn_Delete;
        public System.Windows.Forms.DataGridView dgv_films;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button bn_Show;
        private System.Windows.Forms.Button bn_save;
        private System.Windows.Forms.PictureBox pb_POSTER;

    }
}

