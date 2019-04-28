using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TowerOfHanoi
{
    public partial class TowerOfHanoi : Form
    {
        TimeSpan time;
        PictureBox[] dia;
        int movecount, H, M, S, t, numofdisk;
        int Hours, Minutes, Seconds;
        Stack<PictureBox> stackA, stackB, stackC;
        const int firstY = 320, diskheight = 29;        //firstY : toạ độ Y của đĩa đầu tiên đặt vào cột
        bool move;                                      // biến xét di chuyển
        int pointx, pointy;                             //biến toạ độ khi di chuyển
        Point picLocation;                                              //toạ độ dĩa
        Stack<PictureBox> stacktemp;                                //biến xét dĩa đang nằm trên cột nào
        int[] Vitri;                                                            //lưu vị trí... 1: dĩa ở cột A, 2: dĩa ở cột B, 3: dĩa ở cột C
        const int MidA = 192, MidB = 577, MidC = 962, HalfDisk = 189;           //toạ độ giữa từng cột và độ dài nữa cột

        public TowerOfHanoi()
        {
            InitializeComponent();

            dia = new PictureBox[] { dia1, dia2, dia3, dia4, dia5, dia6, dia7 };
            stackA = new Stack<PictureBox>();
            stackB = new Stack<PictureBox>();
            stackC = new Stack<PictureBox>();
            stacktemp = new Stack<PictureBox>();
            Vitri = new int[8];
            //khởi tạo sự kiện cho từng dĩa
            for (int i = 0; i < 7; i++)
            {
                dia[i].MouseUp += new MouseEventHandler(dia_MouseUp);
                dia[i].MouseDown += new MouseEventHandler(dia_MouseDown);
                dia[i].MouseMove += new MouseEventHandler(dia_MouseMove);
            }
            //
            ShowHighScore();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time.Add(new TimeSpan(0, 0, 1));
            timelabel.Text = string.Format("Thời gian  {0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds);
            Hours = time.Hours;
            Minutes = time.Minutes;
            Seconds = time.Seconds;
        }

        private void losebt_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            demobt.Enabled = true;
            level.Enabled = true;
            losebt.Enabled = false;
            playbt.Text = "Chơi";
            timelabel.Text = "Thời gian  00:00:00";
            movelabel.Text = "Số lần di chuyển:  0";
            stackA.Clear(); stackB.Clear(); stackC.Clear();
            foreach (PictureBox a in dia)
                a.Visible = false;
        }

        private void playbt_Click(object sender, EventArgs e)
        {
            //restart
            //thiết lập showhighscore
            int temp = (int)level.Value;
            if (File.Exists("..//..//HighScore.txt") && (temp == numofdisk))
            {
                play();
            }
            else
            {
                clrHSc.PerformClick();
                play();
            }
        }

        private void play()
        {
            //restart
            timer1.Stop();
            foreach (PictureBox a in dia)
                a.Visible = false;
            time = new TimeSpan(0);
            movecount = 0;              //số lần di chuyển
            timelabel.Text = "Thời gian  00:00:00";
            movelabel.Text = "Số lần di chuyển:  0";
            stackA.Clear(); stackB.Clear(); stackC.Clear();

            //install game
            demobt.Enabled = false;
            level.Enabled = false;
            losebt.Enabled = true;
            playbt.Text = "Chơi lại";
            int x = CotA.Location.X + HalfDisk, y = firstY;        //tính toạ độ dĩa đầu tiên
            for (int i = (int)level.Value - 1; i >= 0; i--)
            {
                dia[i].Location = new Point(x - dia[i].Width / 2, y);
                dia[i].Visible = true;
                stackA.Push(dia[i]);          //add vào stack
                y -= diskheight;

                //các dĩa ban đầu ở cột A tương ứng với giá trị Tag=1
                Vitri[i] = 1;
            }
            timer1.Start();
        }

        private void aboutbt_Click(object sender, EventArgs e)
        {
            if (!checkexitform("About"))
            {
                About frm = new About();
                frm.ShowDialog();
            }
            else
            {
                activechirldform("About");
            }
        }

        private void rulebt_Click(object sender, EventArgs e)
        {
            if (!checkexitform("Rule"))
            {
                Rule frm = new Rule();
                frm.ShowDialog();
            }
            else
            {
                activechirldform("Rule");
            }
        }

        private void demobt_Click(object sender, EventArgs e)
        {
            playbt.PerformClick();
            playbt.Enabled = false;
            losebt.Enabled = false;
            clrHSc.Enabled = false;
            timer1.Stop();
            timelabel.Text = "Thời gian  00:00:00";
            demobt.Enabled = false;
            movecount = 0;
            int SoDia = int.Parse(level.Value.ToString());
            AutoMove(SoDia, CotA, CotB, CotC);
            demobt.Enabled = true;
            playbt.Enabled = true;
            level.Enabled = true;
            clrHSc.Enabled = true;
        }

        private void clrHSc_Click(object sender, EventArgs e)
        {
            File.Delete("..//..//HighScore.txt");
            highscore.Text = "      ";
        }

        private void dia_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (pic.Enabled == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    move = true;

                    //nhận toạ độ khi click chuột
                    pointx = e.Location.X;
                    pointy = e.Location.Y;

                    //lưu lại vị trí ban đầu của đĩa
                    picLocation = pic.Location;

                    //xét vị trí dĩa dc chọn nằm trên cột nào
                    if ((pic.Location.X >= CotA.Location.X) && (pic.Location.X <= CotA.Location.X + CotA.Width))
                        stacktemp = stackA;
                    if ((pic.Location.X >= CotB.Location.X) && (pic.Location.X <= CotB.Location.X + CotB.Width))
                        stacktemp = stackB;
                    if ((pic.Location.X >= CotC.Location.X) && (pic.Location.X <= CotC.Location.X + CotC.Width))
                        stacktemp = stackC;

                    stacktemp.Pop();        //stacktemp lưu vị trí dĩa, để trả dĩa về vị trí cũ nếu không thoả điều kiện di chuyển
                    
                    //nổi đĩa lên trên để ko bị che mất
                    pic.BringToFront();
                }
            }
        }

        private void dia_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            //Di chuyển dĩa theo chuột khi kéo
            if (pic.Enabled == true)
            {
                if (move == true)
                {
                    pic.Location = new Point(pic.Left + e.X - pointx, pic.Top + e.Y - pointy);
                }
            }
        }

        private void dia_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            //tính vị trí mới của dĩa khi kéo
            int col = pic.Location.X;
            int row = pic.Location.Y;

            //xét vị trí tương đối của dĩa đối với mỗi cột
            if ((col >= CotA.Location.X + HalfDisk - pic.Width / 2 - 25) && (col <= CotA.Location.X + HalfDisk - pic.Width / 2 + 25))
            {
                Moverment(stackA, pic, CotA);
            }
            else
            {
                if ((col >= CotB.Location.X + HalfDisk - pic.Width / 2 - 25) && (col <= CotB.Location.X + HalfDisk - pic.Width / 2 + 25))
                {
                    Moverment(stackB, pic, CotB);
                }
                else
                {
                    if ((col >= CotC.Location.X + HalfDisk - pic.Width / 2 - 25) && (col <= CotC.Location.X + HalfDisk - pic.Width / 2 + 25))
                    {
                        Moverment(stackC, pic, CotC);
                    }
                    else
                    {
                        //trả đĩa về vị trí cũ nếu ko thoả
                        pic.Location = picLocation;
                        stacktemp.Push(pic);
                    }
                }
            }
            move = false;
        }

        private void Moverment(Stack<PictureBox> stackX, PictureBox picX, PictureBox cot)
        {
            //di chuyển dĩa
            if (stackX.Count() != 0)
            {
                //xét dĩa đang di chuyển có nhỏ hơn dĩa trên cùng của cột hay ko
                PictureBox TopCot = stackX.Peek();
                if (int.Parse(picX.Tag.ToString()) < int.Parse(TopCot.Tag.ToString()))
                {
                    letmove(stacktemp, stackX, picX, cot);
                }
                else
                {
                    //trả đĩa về vị trí cũ nếu ko thoả
                    picX.Location = picLocation;
                    stacktemp.Push(picX);
                }
            }
            else
            {
                letmove(stacktemp, stackX, picX, cot);
            }
            TopEnable(stackA); TopEnable(stackB); TopEnable(stackC);
        }

        private void letmove(Stack<PictureBox> temp1, Stack<PictureBox> letmovedisk, PictureBox picm, PictureBox cot)
        {
            picm.Location = new Point(cot.Location.X + HalfDisk - picm.Width / 2, firstY - diskheight * letmovedisk.Count());
            letmovedisk.Push(picm);
            movecount++;
            movelabel.Text = string.Format("Số lần di chuyển: {0}", movecount);
            TopEnable(stackA); TopEnable(stackB); TopEnable(stackC);

            temp1 = null;   //đưa stack lưu dĩa tạm về rỗng

            //xét xem đã hoàn thành chò chơi hay chưa
            if (stackC.Count == level.Value)
            {
                writedownHighScore(movecount, Hours, Minutes, Seconds);
                timer1.Stop();
                MessageBox.Show("Congratulation !");
                demobt.Enabled = true;
                level.Enabled = true;
                losebt.Enabled = false;
                playbt.Text = "Chơi";
                stackA.Clear(); stackB.Clear(); stackC.Clear();
                foreach (PictureBox a in dia)
                    a.Visible = false;
            }
        }

        private void TopEnable(Stack<PictureBox> temp2)
        {
            if (temp2.Count() != 0)
            {
                foreach (PictureBox a in temp2)
                    a.Enabled = false;

                PictureBox b = temp2.Peek();
                b.Enabled = true;
            }
        }

        private bool checkexitform(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void activechirldform(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void MoveEffect(PictureBox CotNguon, PictureBox CotDich)
        {
            PictureBox pic = dia[1];
            int speed = 1;                  //tốc độ di chuyển

            //gán vị trí cột mới cho dĩa dc di chuyển
            for (int i = 0; i < level.Value; i++)
            {
                if (Vitri[i] == int.Parse(CotNguon.Tag.ToString()))
                {
                    pic = dia[i];
                    Vitri[i] = int.Parse(CotDich.Tag.ToString());
                    break;
                }
            }
            //tính số dĩa đã có ở cột đích để đặt dĩa xuống
            int temp = -1;
            for(int i = 0; i < level.Value; i++)
            {
                if (Vitri[i] == int.Parse(CotDich.Tag.ToString()))
                    temp++;
            }
            //nâng dĩa lên trên
            while (pic.Top > 100)
            {
                pic.Top -= speed;
                Application.DoEvents();
            }
            //dịch dĩa sang trái, phải
            int vtmoi;
            if (int.Parse(CotDich.Tag.ToString()) == 1)
                vtmoi = MidA;
            else
            {
                if (int.Parse(CotDich.Tag.ToString()) == 2)
                    vtmoi = MidB;
                else
                    vtmoi = MidC;
            }
            if (pic.Left + pic.Width / 2 > vtmoi)
            {
                while (pic.Left + pic.Width / 2 > vtmoi)
                {
                    pic.Left -= speed;
                    Application.DoEvents();
                }
            }
            else
            {
                if (pic.Left + pic.Width / 2 < vtmoi)
                {
                    while (pic.Left + pic.Width / 2 < vtmoi)
                    {
                        pic.Left += speed;
                        Application.DoEvents();
                    }
                }
            }
            //đặt dĩa xuống
            while(pic.Top < firstY - temp*diskheight)
            {
                pic.Top += speed;
                Application.DoEvents();
            }
            movelabel.Text = string.Format("Số lần di chuyển: {0}", movecount);
        }

        private void AutoMove(int SoDia, PictureBox CotNguon, PictureBox CotTG, PictureBox CotDich)
        {
            if(SoDia >0)
            {
                //MoveEffect(CotNguon, CotDich);
                AutoMove(SoDia -1, CotNguon, CotDich, CotTG);
                movecount++;
                MoveEffect(CotNguon, CotDich);
                AutoMove(SoDia - 1, CotTG, CotNguon, CotDich);
                //MoveEffect(CotNguon, CotDich);
            }
        }

        private void writedownHighScore(int count, int Hours, int Minutes, int Seconds)
        {
            if (File.Exists("..//..//HighScore.txt"))
            {
                readHighScore(movecount, Hours, Minutes, Seconds);
            }
            else
            {
                overwrite(movecount, Hours, Minutes, Seconds);
            }
        }

        private void overwrite(int count, int Hours, int Minutes, int Seconds)
        {
            string h = Convert.ToString(Hours);
            string m = Convert.ToString(Minutes);
            string s = Convert.ToString(Seconds);
            string t = Convert.ToString(count);
            string n = Convert.ToString((int)level.Value);
            List<string> lines = new List<string>();
            lines.Add(h);
            lines.Add(m);
            lines.Add(s);
            lines.Add(t);
            lines.Add(n);
            File.WriteAllLines("..//..//HighScore.txt", lines);
            ShowHighScore();
        }

        private void ShowHighScore()
        {
            Console.OutputEncoding = Encoding.Unicode;
            string[] lines;
            if (File.Exists("..//..//HighScore.txt"))
            {
                lines = File.ReadAllLines("..//..//HighScore.txt");
                H = Convert.ToInt32(lines[0]);
                M = Convert.ToInt32(lines[1]);
                S = Convert.ToInt32(lines[2]);
                t = Convert.ToInt32(lines[3]);
                numofdisk = Convert.ToInt32(lines[4]);
                highscore.Text = string.Format("{0:00}:{1:00}:{2:00}    {3:00} turn", H, M, S, t);
            }
        }

        private void readHighScore(int count, int Hours, int Minutes, int Seconds)
        {
            Console.OutputEncoding = Encoding.Unicode;
            string[] lines;
            if (File.Exists("..//..//HighScore.txt"))
            {
                lines = System.IO.File.ReadAllLines("..//..//HighScore.txt");
                H = Convert.ToInt32(lines[0]);
                M = Convert.ToInt32(lines[1]);
                S = Convert.ToInt32(lines[2]);
                t = Convert.ToInt32(lines[3]);

                if (count < t)
                {
                    overwrite(movecount, Hours, Minutes, Seconds);
                }
                else
                {
                    if (count == t)
                    {
                        if (Hours == H)
                        {
                            if (Minutes == M)
                            {
                                if (Seconds < S)
                                {
                                    overwrite(movecount, Hours, Minutes, Seconds);
                                }
                                else
                                    ShowHighScore();
                            }
                            else
                            {
                                if (Minutes < M)
                                {
                                    overwrite(movecount, Hours, Minutes, Seconds);
                                }
                                else ShowHighScore();
                            }
                        }
                        else
                        {
                            if (Hours < H)
                            {
                                overwrite(movecount, Hours, Minutes, Seconds);
                            }
                            else ShowHighScore();
                        }
                    }
                    else ShowHighScore();
                }
            }
        }
    }
}
