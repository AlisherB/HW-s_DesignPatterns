using System;
using System.Drawing;
using System.Windows.Forms;

namespace HW_DP_27._03._18
{
    public partial class MainForm : Form
    {
        TextBox t;
        public MainForm()
        {
            InitializeComponent();
            t = new MyTextBox();
            Controls.Add(t);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                Controls.Remove(t);
                if (checkBox.Name == "multiline_checkBox")
                {
                    t = new Multiline(t);
                }
                else if (checkBox.Name == "hscroll_checkBox")
                {
                    t = new HScroll_TextBox(t);
                }
                else if (checkBox.Name == "vscroll_checkBox")
                {
                    t = new VScroll_TextBox(t);
                }
                Controls.Add(t);
            }
            else
            {
                Controls.Remove(t);
                t = new MyTextBox(t);
                if (multiline_checkBox.Checked)
                {
                    t = new Multiline(t);
                }
                else if (hscroll_checkBox.Checked)
                {
                    t = new HScroll_TextBox(t);
                }
                else if (vscroll_checkBox.Checked)
                {
                    t = new VScroll_TextBox(t);
                }
                Controls.Add(t);
            }
        }
    }
    public class MyTextBox : TextBox
    {
        public MyTextBox() : base()
        {
            Location = new Point(103, 13);
            Size = new Size(249, 20);
            Multiline = false;
            ScrollBars = ScrollBars.None;
            WordWrap = true;
        }
        public MyTextBox(TextBox t) : this()
        {
            Text = t.Text;
            Location = t.Location;
            Size = t.Size;
        }
    }
    public class Multiline : MyTextBox
    {
        public Multiline(TextBox t) : base()
        {
            Text = t.Text;
            Multiline = true;
            ScrollBars = t.ScrollBars;
            Size = new Size(249, 100);
            Location = t.Location;
        }
    }
    public class VScroll_TextBox : MyTextBox
    {
        public VScroll_TextBox(TextBox t) : base()
        {
            if (t.ScrollBars == ScrollBars.Both)
            {
                ScrollBars = t.ScrollBars;
                Multiline = true;
                Size = new Size(249, 100);
            }


            if (t.ScrollBars == ScrollBars.Horizontal)
            {
                ScrollBars = ScrollBars.Both;
                Multiline = true;
                Size = new Size(249, 100);
            }
            else
            {
                ScrollBars = ScrollBars.Vertical;
                Multiline = true;
                Size = new Size(249, 100);
            }
            
            Text = t.Text;
            Location = t.Location;
        }
    }
    public class HScroll_TextBox : MyTextBox
    {
        public HScroll_TextBox(TextBox t) : base()
        {
            if (t.ScrollBars == ScrollBars.Both)
            {
                ScrollBars = t.ScrollBars;
                Multiline = true;
                Size = new Size(249, 100);
            }
                
            if (t.ScrollBars == ScrollBars.Vertical)
            {
                WordWrap = false;
                ScrollBars = ScrollBars.Both;
                Multiline = true;
                Size = new Size(249, 100);
            }    
            else
            {
                WordWrap = false;
                ScrollBars = ScrollBars.Horizontal;
                Multiline = true;
                Size = new Size(249, 40);
            }

            Text = t.Text;
            Location = t.Location;
        }
    }
}
