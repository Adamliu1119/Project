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

        List<string> ii = new List<string>();
        string[] img = {
                "Resources/0.png","Resources/1.png", "Resources/2.png", "Resources/3.png",
                "Resources/4.png","Resources/5.png","Resources/6.png","Resources/7.png"
            };

        static int c = 0;

        
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
            ImageButton[] imagebutton = {
                ImageButton1, ImageButton2, ImageButton3, ImageButton4,
                ImageButton5, ImageButton6, ImageButton7, ImageButton8,
                ImageButton9, ImageButton10, ImageButton11, ImageButton12,
                ImageButton13, ImageButton14, ImageButton15, ImageButton16,
            };
            imagebutton[index].ImageUrl = ((string[])ViewState["Image"])[index];

            for (int i = 0; i < 16; i++)
            {
                if (imagebutton[i].ImageUrl!="Resources/onback.png")
                {
                    
                    if (key.Count==2)
                    {
                        if (value[0]==value[1])
                        {
                            imagebutton[key[0]].Enabled = false;
                            imagebutton[key[1]].Enabled = false;
                            
                        }
                        else
                        {
                            imagebutton[key[0]].ImageUrl = "Resources/onback.png";
                            imagebutton[key[1]].ImageUrl = "Resources/onback.png";
                        }
                        key.Clear();
                        value.Clear();
                    }
                    else
                    {
                        key.Add(i);
                        value.Add(imagebutton[i].ImageUrl);
                    }
                }
            }
            
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

        protected void btn_Ran_Click(object sender, EventArgs e)
        {
            c = 0;
            Timer1.Enabled = true;
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


            ViewState["Image"] =imUrl;
            ImageButton[] imagebutton = {
                ImageButton1, ImageButton2, ImageButton3, ImageButton4,
                ImageButton5, ImageButton6, ImageButton7, ImageButton8,
                ImageButton9, ImageButton10, ImageButton11, ImageButton12,
                ImageButton13, ImageButton14, ImageButton15, ImageButton16,
            };
            
            for (int i = 0; i < 16; i++)
            {
                imagebutton[i].Enabled = true;
                imagebutton[i].ImageUrl = ((string[])ViewState["Image"])[i];
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

            c++;

           

            if (c < 3)
            {
                Label1.Text = c.ToString();
                for (int i = 0; i < 16; i++)
                    imagebutton[i].ImageUrl = ((string[])ViewState["Image"])[i];
            }
            else
            {
                for (int i = 0; i < 16; i++)
                    imagebutton[i].ImageUrl = "Resources/onback.png";
                Timer1.Enabled = false;
            }


        }
    }
}