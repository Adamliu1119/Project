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
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        public void match(int index)
        {
            ImageButton[] imagebutton = {
                ImageButton1, ImageButton2, ImageButton3, ImageButton4,
                ImageButton5, ImageButton6, ImageButton7, ImageButton8,
                ImageButton9, ImageButton10, ImageButton11, ImageButton12,
                ImageButton13, ImageButton14, ImageButton15, ImageButton16,
            };
            if (ViewState["Image"] != null)
            {
                imagebutton[index].ImageUrl = ((string[])ViewState["Image"])[index];
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

            Timer1.Enabled = true;
            Timer1.Interval = 1000;

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

            ViewState["Back"] = "Resources/onback.png";
            ViewState["Image"] =imUrl;
            ImageButton[] imagebutton = {
                ImageButton1, ImageButton2, ImageButton3, ImageButton4,
                ImageButton5, ImageButton6, ImageButton7, ImageButton8,
                ImageButton9, ImageButton10, ImageButton11, ImageButton12,
                ImageButton13, ImageButton14, ImageButton15, ImageButton16,
            };

            //while (c < 3)
            //{
            //    Timer1.Enabled = true;

            //}
            if (c < 3)
            {
                for (int i = 0; i < 16; i++)
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
            }
            else if (c==1)
            {
                Timer1.Enabled = false;
                for (int i = 0; i < 16; i++)
                    imagebutton[i].ImageUrl = ViewState["Back"].ToString();
            }
            
        }
    }
}