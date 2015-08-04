using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obstaclofy
{
    public partial class Form1 : Form
    {
        int c = 0;
        int score = 0;
        private int _x;
        private int _y;
        private int l1;
        private int w1;
        private int l2;
        private int w2;
        private int l3;
        private int w3;
        private int l4;
        private int w4;
        private int l5;
        private int w5;
        //   private int l6;
        // private int w6;
        private int l7;
        private int w7;
        private int l8;
        private int w8;
        private int l9;
        private int w9;
        private int l6;
        private int w6;
        enum Position
        {
            Left, Right, Up, Down
        }
        private Position _objPosition;
        public Form1()
        {
            InitializeComponent();
            _x = 0;
            _y = 180;
            l1 = 0;
            w1 = 250;
            l2 = 0;
            w2 = 500;
            l3 = 342;
            w3 = 460;
            w4 = 460;
            w5 = 460;
            w6 = 210;
            l4 = 684;
            l5 = 1022;
            w7 = 210;
            w8 = 210;
            w9 = 210;
            l6 = 342;
            l7 = 684;
            l8 = 1022;

            // if(_y<=180)
            _objPosition = Position.Right;
            //     if(_y<=430&&_y>=300)
            //       _objPosition = Position.Left;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, _x, _y, 10, 70);
            e.Graphics.FillRectangle(Brushes.CadetBlue, l1, w1, 1365, 10);
            e.Graphics.FillRectangle(Brushes.CadetBlue, l2, w2, 1365, 10);
            e.Graphics.FillRectangle(Brushes.CadetBlue, l3, w3, 40, 40);
            e.Graphics.FillRectangle(Brushes.CadetBlue, l4, w4, 40, 40);
            e.Graphics.FillRectangle(Brushes.CadetBlue, l5, w5, 40, 40);
            e.Graphics.FillRectangle(Brushes.CadetBlue, l6, w6, 40, 40);
            e.Graphics.FillRectangle(Brushes.CadetBlue, l7, w7, 40, 40);
            e.Graphics.FillRectangle(Brushes.CadetBlue, l8, w8, 40, 40);
           

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                _objPosition = Position.Left;
            if (e.KeyCode == Keys.Right)
                _objPosition = Position.Right;
            if (e.KeyCode == Keys.Up)
                _objPosition = Position.Up;
            else if (e.KeyCode == Keys.Down)
                _objPosition = Position.Down;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int c1 = 0;
            if (_x >= 1360)
            {

                if (c == 0)
                {
                    _objPosition = Position.Right;
                    _y = 430;
                    _x = 0;

                    c++;
                }
            }

            // _objPosition = Position.Right;
            if (_objPosition == Position.Right)
            {
                _x += 10;
            }

            if (_objPosition == Position.Left)
            {
                _x -= 10;

            }

            if (_objPosition == Position.Up)
            {
                if (c1 == 0)
                {
                    _x += 10;
                    _y -= 10;
                    if (_y <= 110)
                    {
                        _objPosition = Position.Right;
                        _objPosition = Position.Down;

                    }
                    if (c > 0)
                    {
                        if (_y <= 360)
                        {
                            _objPosition = Position.Right;
                            _objPosition = Position.Down;

                        }

                    }
                    c1++;
                }
            }
            if (_objPosition == Position.Down)
            {
                _x += 10;
                _y += 10;
            }
            if (_y == 180 || _y == 430)
            {
                _objPosition = Position.Right;
            }


            if (_x >= 342 && _x <= 382 || _x >= 684 && _x <= 724 || _x >= 1022 && _x <= 1062)
            {
                if (c == 0)
                {
                    if (_y <= 210 && _y >= 140)
                    {
                       timer1.Stop();
                        // MessageBox.Show(_x.ToString());
                        //MessageBox.Show(_y.ToString());
                        //   timer1.Stop();
                       MessageBox.Show("Game Over");
                       MessageBox.Show("Your Score is " + score.ToString());

                    }
                }
                else
                {
                    if (_y <= 460 && _y >= 390)
                    {

                      timer1.Stop();
                        // MessageBox.Show(_x.ToString());
                        //MessageBox.Show(_y.ToString());
                        //   timer1.Stop();
                       MessageBox.Show("Game Over");
                       MessageBox.Show("Your Score is " + score.ToString());


                    }



                }
            }


            Invalidate();
            score++;
            if (_x == 1360 && _y>180 && _y<=430)
            {
                this.Hide();
                Form2 f3 = new Form2();
                f3.ShowDialog();
            }
        }

        }
    }
