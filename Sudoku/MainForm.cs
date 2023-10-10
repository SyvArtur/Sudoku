using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;


namespace Sudoku
{
    public partial class Game_Sudoku : Form
    {
        public Game_Sudoku()
        {
            InitializeComponent();
        }


        int[,] sudoku;
        SolidBrush black = new SolidBrush(Color.Black);
        Button[,] _buttons = new Button[9, 9];
        Button[] key = new Button[10];
        Random rnd = new Random();
        int difficult;
        bool check=false;
        // double proportion = 0.58;


        private void difficult_start(int difficult)
        {
            int x, y;
            sudoku = GenSudoku.start_gen(rnd);
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    _buttons[i, j].Text = sudoku[i, j].ToString();
                    _buttons[i, j].Cursor = Cursors.Default;
                    _buttons[i, j].ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < difficult; i++)
            {
                x = rnd.Next(0, 9);
                y = rnd.Next(0, 9);
                _buttons[x, y].Text = "";
                _buttons[x, y].Cursor = Cursors.Hand;
            }

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var button = new Button();
                    string btn_name = ""+i + j;
                    //button.BackColor = Color.Gray;
                    //button.Tag = j * 9 + i;
                    button.FlatAppearance.BorderColor = Color.Gainsboro;
                    button.Click += Btn_Click;
                    button.Name = btn_name;
                    _buttons[i, j] = button;
                    this.Controls.Add(button);
                }
                
            }

            for (int i = 0; i < 10; i++)
            {
                var button_key = new Button();
                if (i == 9)
                {
                    button_key.Text = "Очистити";
                } else { button_key.Text = (i + 1).ToString(); }
                button_key.Click += Btn_key_Click;
                button_key.Name = (i + 1).ToString();
                button_key.FlatStyle = FlatStyle.Flat;
                button_key.FlatAppearance.BorderColor = Color.Gainsboro;
               // button.FlatAppearance = 
                button_key.BackColor = Color.Gainsboro;
                button_key.ForeColor = Color.Blue;
                key[i] = button_key;
                this.Controls.Add(button_key);
            }
            difficult_start(50);
            cmb_box.SelectedItem = "Легкий";
            this.Size = new Size(800, (int)(506 + 35));
        }



        private void btn_check_Click(object sender, EventArgs e)
        {
            check = !check;
            property();
            if (check)
            {
                btn_check.Text = "✔";
            } else
                btn_check.Text = "";
        }

        private void property()
        {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (!_buttons[i, j].Text.Equals(sudoku[i, j].ToString()) && _buttons[i, j].Cursor == Cursors.Hand && check)
                        {
                            _buttons[i, j].ForeColor = Color.Red;
                        }
                    else if (_buttons[i, j].Cursor == Cursors.Hand)
                    {
                        _buttons[i, j].ForeColor = Color.Blue;
                    }
                    }
                }
        }














        private void Btn_Click(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            if (button != null && button.Cursor==Cursors.Hand)
            {
                button.Text = press_key;
                property();
                bool win = true;
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        
                        if (!_buttons[i, j].Text.Equals (sudoku[i, j].ToString())  )
                            {
                                win = false;
                            }
                    }
                }
              
                if (win)
                {
                    MessageBox.Show("You win!!!");
                }
            }
               
                
            }

        String press_key;
        private void Btn_key_Click(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            for (int i = 0; i < 10; i++)
            {
              key[i].BackColor = Color.Gainsboro;
            }
            button.BackColor = Color.Silver;
            //MessageBox.Show(button.Text);
            if(button.Text=="Очистити")
            {
                press_key = "";
            } else
                press_key = button.Text;
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            int x = this.Size.Width;
            if (key[0].Width != x / 10)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {

                        _buttons[i, j].Width = x / 16;
                        _buttons[i, j].Height = x / 16;
                        _buttons[i, j].Font = new Font("Microsoft Sans Serif", x / 50);
                        _buttons[i, j].Location = new Point(_buttons[i, j].Width * i + x / 200 * Convert.ToInt32(i / 3) + x / 200, (_buttons[i, j].Height * j + x / 20) + x / 220 * Convert.ToInt32(j / 3) + x / 50);

                    }
                    // key
                    key[i].Width = x / 10;
                    key[i].Height = x / 10;
                    key[i].Font = new Font("Microsoft Sans Serif", (float)x / 35);
                    key[i].Location = new Point(key[i].Width * (i % 3) * 9 / 8 + _buttons[i, 1].Width * 10, key[i].Height * Convert.ToInt32(i / 3) * 8 / 7 + _buttons[i, 1].Width * 2);
                }


                key[9].Width = x / 7;
                key[9].Height = x / 10;
                key[9].Font = new Font("Microsoft Sans Serif", (float)x / 60);
                key[9].Location = new Point(x * 143 / 200, x / 30);
                System.Drawing.Drawing2D.GraphicsPath Button_Path = new System.Drawing.Drawing2D.GraphicsPath();
                Button_Path.AddEllipse(0, this.key[9].Width/9, this.key[9].Width*98/100, this.key[9].Height*2/3);
                Region Button_Region = new Region(Button_Path);
                this.key[9].Region = Button_Region;


                cmb_box.Width = x / 7;
                cmb_box.Location = new Point(x / 8, x / 70);
                cmb_box.Font = new Font("Microsoft Sans Serif", (float)x / 60);

                lvl.Width = x / 9;
                lvl.Height = x / 25;
                lvl.Location = new Point(x / 70, x / 60);
                lvl.Font = new Font("Microsoft Sans Serif", (float)x / 60);

                btn_check.Width = x / 30;
                btn_check.Height = x / 30;
                btn_check.Location = new Point(x * 30 / 48, x / 60);
                btn_check.Font = new Font("Microsoft Sans Serif", (float)x / 80);

                examination.Height = x / 25;
                examination.Width = x * 33 / 120;
                examination.Location = new Point(x / 3, x / 60);
                examination.Font = new Font("Microsoft Sans Serif", (float)x / 60);

                lblSaveImage.Height = x / 25;
                lblSaveImage.Width = x / 2;
                lblSaveImage.Location = new Point(x * 3 / 5, x * 9 / 16);
                lblSaveImage.Font = new Font("Microsoft Sans Serif", (float)x / 110);

                btnSaveImage.Height = x / 25;
                btnSaveImage.Width = x / 4;
                btnSaveImage.Location = new Point(x * 70 / 105, x * 4 / 8);
                btnSaveImage.Font = new Font("Microsoft Sans Serif", (float)x / 80);
            }
                Graphics g = CreateGraphics();
                g.Clear(Color.WhiteSmoke);
                g.FillRectangle(black, 0, x / 16, x / 16 * 9 + x / 200 * 4, x);
            
        }


        
       private void Form1_Resize(object sender, EventArgs e)
        {
            int x = this.Size.Width;

            Control control = (Control)sender;

                if (control.Size.Height != (int)(x / 16 * 9 + x / 50 +35+ x / 15))
                {
                    control.Size = new Size(control.Size.Width, (int)(x / 16 * 9 + 35 + x / 50 +x/15));
                }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string selectedState = cmb_box.SelectedItem.ToString();
            if (selectedState=="Легкий")
            {
                difficult = 50;
            }
            if (selectedState == "Нормальний")
            {
                difficult = 75;
            }
            if (selectedState == "Важкий")
            {
                difficult = 100;
            }
            if (selectedState == "Для теста")
            {
                difficult = 3;
            }
            difficult_start(difficult);
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            int x = this.Size.Width;
            Bitmap bmpScreenshot = new Bitmap(x / 16 * 9 + x / 200 * 4, x / 16 * 9 + x / 200 * 4, PixelFormat.Format32bppArgb);

            Graphics gfxScreenshot = Graphics.FromImage(bmpScreenshot);

            gfxScreenshot.CopyFromScreen(this.Location.X+8, this.Location.Y+(x/16)+31, 0, 0, new Size (x / 16 * 9 + x / 200 * 4, x / 16 * 9 + x / 200 * 4), CopyPixelOperation.SourceCopy);

            bmpScreenshot.Save("screenshot.png", ImageFormat.Png);
            MessageBox.Show("Зображення screenshot.png завантажилось по шляху: " +  Environment.CurrentDirectory);
        }
    }

    public static class GenSudoku 
    {
        static int[,] sudoku = new int[9, 9];

        public static bool check_sector(int x, int y)
        {
            for (int i = 3 * Convert.ToInt32(x / 3); i < (3 * Convert.ToInt32(x / 3) + 3); i++)
            {
                for (int j = 3 * Convert.ToInt32(y / 3); j < (3 * Convert.ToInt32(y / 3) + 3); j++)
                {
                    if ((i != x) & (j != y))
                    {
                        if (sudoku[x, y] == sudoku[i, j])
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public static bool check_column(int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i != y)
                {
                    if (sudoku[x, y] == sudoku[x, i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool check_line(int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i != x)
                {
                    if (sudoku[x, y] == sudoku[i, y])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool gen(Random rnd)
        {
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    sudoku[i, j] = rnd.Next(1, 10);
                    int tim = 0;
                    while (check_column(i, j) | check_line(i, j) | check_sector(i, j))
                    {
                        tim++;
                        sudoku[i, j] = rnd.Next(1, 10);
                        if (tim == 30) { return true; }
                    }

                }
            }
            return false;
        }

        public static int[,] start_gen(Random rnd)
        {
            while (gen(rnd))
            {
                for (int j = 0; j < 9; j++)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        sudoku[i, j] = 0;
                    }
                }
            }
            return sudoku;
        }
    }

}
