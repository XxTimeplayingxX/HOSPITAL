using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOSPITAL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        private void CustomizeDesign()
        {
            panelSubMenuMedios.Visible= false;
            panelSubMenuPlayList.Visible= false;
            panelSubMenuTools.Visible= false;
        }
        private void hideSubMenu()
        {
            if(panelSubMenuMedios.Visible == true)
            {
                panelSubMenuMedios.Visible = false;
            }
            if(panelSubMenuPlayList.Visible == true)
            {
                panelSubMenuPlayList.Visible = false;
            }
            if(panelSubMenuTools.Visible == true)
            {
                panelSubMenuTools.Visible = false;
            }
        }
        private void showSubmenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible= false;
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubMenuMedios);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Mi Código
            openChildForm(new Form3());

            hideSubMenu();


        }

        private void button3_Click(object sender, EventArgs e)
        {


            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {


            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {


            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {


            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {


            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {


            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {


            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {


            hideSubMenu();
        }

        private void btnPlayListManagment_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());


            showSubmenu(panelSubMenuPlayList);
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubMenuTools);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {


            hideSubMenu();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel= false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
