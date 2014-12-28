namespace courseWork
{
    partial class Form2
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
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_Company = new System.Windows.Forms.ComboBox();
            this.tb_Duration = new System.Windows.Forms.TextBox();
            this.cb_Format = new System.Windows.Forms.ComboBox();
            this.cb_Quality = new System.Windows.Forms.ComboBox();
            this.tb_Director = new System.Windows.Forms.TextBox();
            this.bn_Add = new System.Windows.Forms.Button();
            this.bn_save = new System.Windows.Forms.Button();
            this.cb_Genre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pb_Poster = new System.Windows.Forms.PictureBox();
            this.bn_Browse = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Poster)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(206, 12);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(121, 20);
            this.tb_Name.TabIndex = 0;
            // 
            // tb_Year
            // 
            this.tb_Year.Location = new System.Drawing.Point(206, 66);
            this.tb_Year.Name = "tb_Year";
            this.tb_Year.Size = new System.Drawing.Size(121, 20);
            this.tb_Year.TabIndex = 2;
            this.tb_Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title of film";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Company of productation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Duration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Format";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Quality";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Director";
            // 
            // cb_Company
            // 
            this.cb_Company.FormattingEnabled = true;
            this.cb_Company.Items.AddRange(new object[] {
            "20th Century Fox",
            "A-Media",
            "Columbia Pictures",
            "Dimension Films",
            "DreamWorks",
            "Gaumont Pictures",
            "Golden Harvest",
            "Lionsgate Entertainment Corporation",
            "Metro-Goldwyn-Mayer",
            "Miramax Films",
            "Miriam-Media",
            "New Line Cinema",
            "Paramount Pictures",
            "Pixar",
            "Sony Pictures Entertainment, Inc",
            "Summit Entertainment",
            "Universal Studios",
            "Walt Disney",
            "Warner Bros.",
            "Кинокомпания \"Аватар Фильм\"",
            "Кинокомпания \"СТВ\"",
            "Кинокомпания \"Централ Партнершип\"",
            "Ленфильм",
            "Мосфильм",
            "Одесская киностудия"});
            this.cb_Company.Location = new System.Drawing.Point(206, 39);
            this.cb_Company.Name = "cb_Company";
            this.cb_Company.Size = new System.Drawing.Size(121, 21);
            this.cb_Company.TabIndex = 12;
            this.cb_Company.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_KeyPress);
            // 
            // tb_Duration
            // 
            this.tb_Duration.Location = new System.Drawing.Point(205, 123);
            this.tb_Duration.Name = "tb_Duration";
            this.tb_Duration.Size = new System.Drawing.Size(122, 20);
            this.tb_Duration.TabIndex = 15;
            this.tb_Duration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // cb_Format
            // 
            this.cb_Format.FormattingEnabled = true;
            this.cb_Format.Items.AddRange(new object[] {
            ".avi",
            ".mkv",
            ".mov",
            ".wma",
            ".mp4",
            ".flv",
            ".vob",
            ".m2v",
            ".ifo"});
            this.cb_Format.Location = new System.Drawing.Point(205, 152);
            this.cb_Format.Name = "cb_Format";
            this.cb_Format.Size = new System.Drawing.Size(122, 21);
            this.cb_Format.TabIndex = 16;
            this.cb_Format.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_KeyPress);
            // 
            // cb_Quality
            // 
            this.cb_Quality.FormattingEnabled = true;
            this.cb_Quality.Items.AddRange(new object[] {
            "144",
            "240",
            "360",
            "480",
            "720 HD",
            "1080 HD"});
            this.cb_Quality.Location = new System.Drawing.Point(206, 180);
            this.cb_Quality.Name = "cb_Quality";
            this.cb_Quality.Size = new System.Drawing.Size(121, 21);
            this.cb_Quality.TabIndex = 17;
            this.cb_Quality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_KeyPress);
            // 
            // tb_Director
            // 
            this.tb_Director.Location = new System.Drawing.Point(206, 212);
            this.tb_Director.Name = "tb_Director";
            this.tb_Director.Size = new System.Drawing.Size(121, 20);
            this.tb_Director.TabIndex = 18;
            // 
            // bn_Add
            // 
            this.bn_Add.Location = new System.Drawing.Point(27, 284);
            this.bn_Add.Name = "bn_Add";
            this.bn_Add.Size = new System.Drawing.Size(107, 34);
            this.bn_Add.TabIndex = 19;
            this.bn_Add.Text = "Add";
            this.bn_Add.UseVisualStyleBackColor = true;
            this.bn_Add.Click += new System.EventHandler(this.bn_Add_Click);
            // 
            // bn_save
            // 
            this.bn_save.Location = new System.Drawing.Point(185, 284);
            this.bn_save.Name = "bn_save";
            this.bn_save.Size = new System.Drawing.Size(95, 34);
            this.bn_save.TabIndex = 24;
            this.bn_save.Text = "Save";
            this.bn_save.UseVisualStyleBackColor = true;
            this.bn_save.Click += new System.EventHandler(this.bn_save_Click);
            // 
            // cb_Genre
            // 
            this.cb_Genre.Items.AddRange(new object[] {
            "adventures",
            "anime",
            "biographical",
            "cartoon",
            "children\'s",
            "comedy",
            "concert",
            "crime",
            "detective",
            "documentary",
            "drama",
            "erotica",
            "family",
            "fantasy",
            "fiction",
            "film noir",
            "historical",
            "horrors",
            "kinokomiks",
            "melodrama",
            "military",
            "music",
            "musical",
            "mysticism",
            "reality show",
            "research",
            "short",
            "sport",
            "talk show",
            "thriller",
            "thriller",
            "western"});
            this.cb_Genre.Location = new System.Drawing.Point(206, 96);
            this.cb_Genre.Name = "cb_Genre";
            this.cb_Genre.Size = new System.Drawing.Size(121, 21);
            this.cb_Genre.Sorted = true;
            this.cb_Genre.TabIndex = 25;
            this.cb_Genre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(422, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 26);
            this.label5.TabIndex = 26;
            this.label5.Text = "Poster";
            // 
            // pb_Poster
            // 
            this.pb_Poster.Location = new System.Drawing.Point(408, 48);
            this.pb_Poster.Name = "pb_Poster";
            this.pb_Poster.Size = new System.Drawing.Size(100, 125);
            this.pb_Poster.TabIndex = 27;
            this.pb_Poster.TabStop = false;
            // 
            // bn_Browse
            // 
            this.bn_Browse.Location = new System.Drawing.Point(433, 193);
            this.bn_Browse.Name = "bn_Browse";
            this.bn_Browse.Size = new System.Drawing.Size(75, 23);
            this.bn_Browse.TabIndex = 28;
            this.bn_Browse.Text = "Browse";
            this.bn_Browse.UseVisualStyleBackColor = true;
            this.bn_Browse.Click += new System.EventHandler(this.bn_Browse_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(536, 342);
            this.Controls.Add(this.bn_Browse);
            this.Controls.Add(this.pb_Poster);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_Genre);
            this.Controls.Add(this.bn_save);
            this.Controls.Add(this.bn_Add);
            this.Controls.Add(this.tb_Director);
            this.Controls.Add(this.cb_Quality);
            this.Controls.Add(this.cb_Format);
            this.Controls.Add(this.tb_Duration);
            this.Controls.Add(this.cb_Company);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Year);
            this.Controls.Add(this.tb_Name);
            this.Name = "Form2";
            this.Text = "New movie";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Poster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tb_Name;
        public System.Windows.Forms.TextBox tb_Year;
        public System.Windows.Forms.ComboBox cb_Company;
        public System.Windows.Forms.TextBox tb_Duration;
        public System.Windows.Forms.ComboBox cb_Format;
        public System.Windows.Forms.ComboBox cb_Quality;
        public System.Windows.Forms.TextBox tb_Director;
        public System.Windows.Forms.Button bn_Add;
        public System.Windows.Forms.Button bn_save;
        public System.Windows.Forms.ComboBox cb_Genre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bn_Browse;
        private System.Windows.Forms.OpenFileDialog openFile;
        public System.Windows.Forms.PictureBox pb_Poster;
    }
}