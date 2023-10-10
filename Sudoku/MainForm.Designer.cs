namespace Sudoku
{
    partial class Game_Sudoku
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cmb_box = new System.Windows.Forms.ComboBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.lvl = new System.Windows.Forms.Label();
            this.examination = new System.Windows.Forms.Label();
            this.lblSaveImage = new System.Windows.Forms.Label();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cmb_box
            // 
            this.cmb_box.DisplayMember = "Легкий";
            this.cmb_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_box.FormattingEnabled = true;
            this.cmb_box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_box.Items.AddRange(new object[] {
            "Легкий",
            "Нормальний",
            "Важкий",
            "Для теста"});
            this.cmb_box.Location = new System.Drawing.Point(147, 12);
            this.cmb_box.Name = "cmb_box";
            this.cmb_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_box.Size = new System.Drawing.Size(121, 28);
            this.cmb_box.TabIndex = 1;
            this.cmb_box.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.LightGray;
            this.btn_check.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_check.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btn_check.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.btn_check.Location = new System.Drawing.Point(697, 12);
            this.btn_check.Margin = new System.Windows.Forms.Padding(0);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(27, 28);
            this.btn_check.TabIndex = 2;
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // lvl
            // 
            this.lvl.Location = new System.Drawing.Point(26, 17);
            this.lvl.Name = "lvl";
            this.lvl.Size = new System.Drawing.Size(100, 23);
            this.lvl.TabIndex = 3;
            this.lvl.Text = " Рівень:";
            // 
            // examination
            // 
            this.examination.Location = new System.Drawing.Point(516, 12);
            this.examination.Name = "examination";
            this.examination.Size = new System.Drawing.Size(178, 31);
            this.examination.TabIndex = 4;
            this.examination.Text = "Автоперевірка помилок :";
            // 
            // lblSaveImage
            // 
            this.lblSaveImage.Location = new System.Drawing.Point(494, 270);
            this.lblSaveImage.Name = "lblSaveImage";
            this.lblSaveImage.Size = new System.Drawing.Size(334, 31);
            this.lblSaveImage.TabIndex = 5;
            this.lblSaveImage.Text = "(зберігає в тій же папці, де знаходиться виконуваний файл) ";
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.BackColor = System.Drawing.Color.LightGray;
            this.btnSaveImage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSaveImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnSaveImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnSaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.btnSaveImage.Location = new System.Drawing.Point(558, 242);
            this.btnSaveImage.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(191, 28);
            this.btnSaveImage.TabIndex = 6;
            this.btnSaveImage.Text = "Зберегти зображення";
            this.btnSaveImage.UseVisualStyleBackColor = false;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // Game_Sudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(885, 431);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.lblSaveImage);
            this.Controls.Add(this.examination);
            this.Controls.Add(this.lvl);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.cmb_box);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 39);
            this.Name = "Game_Sudoku";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox cmb_box;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label lvl;
        private System.Windows.Forms.Label examination;
        private System.Windows.Forms.Label lblSaveImage;
        private System.Windows.Forms.Button btnSaveImage;
    }
}

