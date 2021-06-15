using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace WebApplication1
{
    public partial class terminal : System.Web.UI.Page
    {
        Random r = new Random();
        string[] imUrl = {"", "", "", "",
                            "","","","",
                            "","","","",
                            "","","",""
         };

        string[] img = {
                "Resources/0.png","Resources/1.png", "Resources/2.png", "Resources/3.png",
                "Resources/4.png","Resources/5.png","Resources/6.png","Resources/7.png"
            };

        static int c = 3, n = 5;
        int x = 0, indexs1 = 0, indexs2 = 0, count = 0;
        int[] indexs = new int[2] { 16, 16 };
        List<int> key = new List<int>();
        List<string> value = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            ImageButton[] imagebutton = {
                ImageButton1, ImageButton2, ImageButton3, ImageButton4,
                ImageButton5, ImageButton6, ImageButton7, ImageButton8,
                ImageButton9, ImageButton10, ImageButton11, ImageButton12,
                ImageButton13, ImageButton14, ImageButton15, ImageButton16 };

            if (!IsPostBack)
            {
                ViewState["b"] = indexs;
                for (int i = 0; i < 16; i++)
                {
                    imagebutton[i].Enabled = false;
                }
                //Timer1.Enabled = true;
                //int rnd;
                //rnd = r.Next(0, 16);

                //for (int i = 0; i < 2; i++)
                //{
                //    for (int j = 0; j < 8; j++)
                //    {

                //        if (imUrl[rnd] == "")
                //        {
                //            imUrl[rnd] = img[j];
                //        }
                //        else
                //        {
                //            j -= 1;
                //            rnd = r.Next(0, 16);
                //        }
                //    }
                //}
            }
            else
            {
                //c += 1;
                //if (c == 3)
                //{
                //    for (int i = 0; i < 16; i++)
                //        imagebutton[i].ImageUrl = "Resources/onback.png";
                //    Timer1.Enabled = false;
                //}


            }
        }
        public void match(int index)
        {
            x = Convert.ToInt32(ViewState["a"]);
            indexs = (int[])ViewState["b"];
            count = Convert.ToInt32(ViewState["c"]);
            ImageButton[] imagebutton = {
                ImageButton1, ImageButton2, ImageButton3, ImageButton4,
                ImageButton5, ImageButton6, ImageButton7, ImageButton8,
                ImageButton9, ImageButton10, ImageButton11, ImageButton12,
                ImageButton13, ImageButton14, ImageButton15, ImageButton16,
            };
            imagebutton[index].ImageUrl = ((string[])ViewState["Image"])[index];
            Label3.Visible = true; //#
            Label3.Text = "加1前" + x.ToString() + " |";
            x += 1;
            Label3.Text += "| 加1後" + x.ToString() + " |";
            if (indexs[0] == 16)
            {
                indexs[0] = index; //indexs{0,16}
                imagebutton[indexs[0]].Enabled = false;

            }
            else if (indexs[1] == 16) //indexs{0,1}
            {
                indexs[1] = index;
                x = 0;
                if (imagebutton[indexs[0]].ImageUrl == imagebutton[indexs[1]].ImageUrl)
                {
                    n = 6;
                    imagebutton[indexs[0]].Enabled = false;
                    imagebutton[indexs[1]].Enabled = false;
                    count += 1;
                    if (count == 8)
                    {
                        //Response.Write("<script>alert('通關');</script>");
                        Label5.Text = "通關"; //#
                        play.Visible = false; //#
                        win.Visible = true; //#
                        div_lb1.Visible = false; //#
                        count = 0;
                    }
                }
                else
                {

                    Timer1.Enabled = true;
                    for (int i = 0; i < 16; i++)
                    {
                        imagebutton[i].Enabled = true;
                    }
                    count = 0;
                    show(indexs[0], indexs[1]);
                }
                indexs[0] = 16;
                indexs[1] = 16;
            }

            Label4.Text = "配對組數：" + count.ToString();
            ViewState["b"] = indexs;
            ViewState["a"] = x;
            ViewState["c"] = count;


        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            match(0);
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            match(1);
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            match(2);
        }


        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            match(3);
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            match(4);
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            match(5);
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            match(6);
        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            match(7);
        }

        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {
            match(8);
        }

        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {
            match(9);
        }

        protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
        {
            match(10);
        }

        protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
        {
            match(11);
        }

        protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
        {
            match(12);
        }

        protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
        {
            match(13);
        }

        protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
        {
            match(14);
        }
        protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
        {
            match(15);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ImageButton[] imagebutton = {
                ImageButton1, ImageButton2, ImageButton3, ImageButton4,
                ImageButton5, ImageButton6, ImageButton7, ImageButton8,
                ImageButton9, ImageButton10, ImageButton11, ImageButton12,
                ImageButton13, ImageButton14, ImageButton15, ImageButton16,
            };

            btn_Ran.Enabled = true; //#
            Label1.Visible = true; //#
            Label1.Text = "剩餘觀看時間："; //#
            Label2.Text = "選擇時間剩於："; //#
            Label4.Text = "配對組數："; //#

            div_lb1.Visible = false; //#
            Label3.Visible = false; //#
            c = 3; //#
            n = 5; //#
            Timer1.Enabled = false; //#
            Timer2.Enabled = false; //#
            play.Visible = true;
            win.Visible = false;
            for (int i = 0; i < 16; i++)
            {
                imagebutton[i].ImageUrl = "Resources/onback.png";
                imagebutton[i].Enabled = false; //#
            }
                
        }



        protected void btn_Ran_Click(object sender, EventArgs e)
        {
            c = 3;
            n = 6; //
            btn_Ran.Enabled = false; //#
            Timer1.Enabled = true;
            div_lb1.Visible = true;
            int rnd;
            rnd = r.Next(0, 16);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 8; j++)
                {

                    if (imUrl[rnd] == "")
                    {
                        imUrl[rnd] = img[j];
                    }
                    else
                    {
                        j -= 1;
                        rnd = r.Next(0, 16);
                    }
                }
            }


            ViewState["Image"] = imUrl;
            ImageButton[] imagebutton = {
                ImageButton1, ImageButton2, ImageButton3, ImageButton4,
                ImageButton5, ImageButton6, ImageButton7, ImageButton8,
                ImageButton9, ImageButton10, ImageButton11, ImageButton12,
                ImageButton13, ImageButton14, ImageButton15, ImageButton16,
            };

            for (int i = 0; i < 16; i++)
            {
                imagebutton[i].Enabled = false;
                imagebutton[i].ImageUrl = ((string[])ViewState["Image"])[i];
            }

            count = 0;


        }
        public void show(int index1, int index2)
        {
            indexs1 = index1;
            indexs2 = index2;
        }

        protected void Timer2_Tick(object sender, EventArgs e)
        {
            ImageButton[] imagebutton = {
                ImageButton1, ImageButton2, ImageButton3, ImageButton4,
                ImageButton5, ImageButton6, ImageButton7, ImageButton8,
                ImageButton9, ImageButton10, ImageButton11, ImageButton12,
                ImageButton13, ImageButton14, ImageButton15, ImageButton16,
            };
            n -= 1; //#
            Label2.Text = "選擇時間剩於：" + n.ToString();  //#
            if (n == 0) //#
            {
                count = 0;
                imagebutton[indexs1].ImageUrl = "Resources/onback.png";
                imagebutton[indexs2].ImageUrl = "Resources/onback.png";
                imagebutton[indexs1].Enabled = true;
                imagebutton[indexs2].Enabled = true;
                Label5.Text = "未通關"; //#
                play.Visible = false; //#
                win.Visible = true; //#
                div_lb1.Visible = false; //#
                //Timer1.Enabled = false;  //#
               // Timer2.Enabled = false; //#

            }
           
        }
        protected void Timer1_Tick(object sender, EventArgs e)
        {

            ImageButton[] imagebutton = {
                ImageButton1, ImageButton2, ImageButton3, ImageButton4,
                ImageButton5, ImageButton6, ImageButton7, ImageButton8,
                ImageButton9, ImageButton10, ImageButton11, ImageButton12,
                ImageButton13, ImageButton14, ImageButton15, ImageButton16,
            };
            
            Label1.Text = "剩餘觀看時間：" + c.ToString(); //#




            if (c > 0) //#
            {
                c--; //#
                for (int i = 0; i < 16; i++)
                    imagebutton[i].ImageUrl = ((string[])ViewState["Image"])[i];
            }
            else
            {
                for (int i = 0; i < 16; i++)
                {
                    imagebutton[i].ImageUrl = "Resources/onback.png";
                    imagebutton[i].Enabled = true;
                }
                Label1.Visible = false;
                Timer1.Enabled = false;
                Timer2.Enabled = true; //#
                
            }


        }
    }
}