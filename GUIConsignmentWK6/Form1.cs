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
// Neil Little 
// SDEV 360  Week 6
// GUI Consignment Shop 
// 22 February 2020
//    You have been tasked to write a program that maintains products for a consignment shop.
//        The shop  limits its inventory to video games, music and comic books.The values to be 
//        stored are not an inventory count, just a list of items that are available.

//Your program shall use a base class called Product from which product classes are derived.

//The program shall have a main form that contains three radio buttons, one for video games, 
//one for music and one for comic books.The main form entry values will change, 
//depending on the radio button selected.

//The main form shall have a view products form that reads the products from the file(s) and prints to 
//    a report form/box. (The interface design for this element is your choice.)

//Optional Challenge
//Create a maintenance screen that allows the user to brows the current records and delete a chosen record(s) from the file(s).

//As always, use proper object oriented design and appropriate validation, error handling and other learned techniques.
namespace GUIConsignmentWK6
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        VideoGames videoGames = new VideoGames();  //Creating instance of our three category classes.
        Music music = new Music();
        Comics comics = new Comics();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioVideoG_Click(object sender, EventArgs e)  // Changes the labels and list diplay to work with the Videogame category.
        {
            label1.Text = "Title: ";
            label2.Text = "Version:";
            label3.Text = "Manufacturer:";
            label4.Text = "Price:";
            textBoxListviewer.Text = videoGames.GetList();
        }

        private void radioMusic_Click(object sender, EventArgs e)  // Changes the labels and list display to work with the Music category.
        {
            label1.Text = "Title: ";
            label2.Text = "Band:";
            label3.Text = "Record Label:";
            label4.Text = "Price:";
            textBoxListviewer.Text = music.GetList();
        }
         
        private void radioComic_Click(object sender, EventArgs e)  // Changes the labels and list display to work with the Comic category.
        {

            label1.Text = "Hero/ Title: ";
            label2.Text = "Issue Title:";
            label3.Text = "Publisher:";
            label4.Text = "Price:";
            textBoxListviewer.Text = comics.GetList();
        }
       
        private void ButtonAdd_Click(object sender, EventArgs e) 
            // Sends users input to the right class to be added to a list.
        {
            try //exception handling
            {


                if (radioVideoG.Checked == true)
                {
                    videoGames.AddItem(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                    textBoxListviewer.Text = videoGames.GetList();
                }
                if (radioMusic.Checked == true)
                {
                    music.AddItem(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                    textBoxListviewer.Text = music.GetList();
                }
                if (radioComic.Checked == true)
                {
                    comics.AddItem(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                    textBoxListviewer.Text = comics.GetList();
                }
            }
            catch (Exception ex)  
            {
                MessageBox.Show(ex.Message);  //flys a message box to display what went wrong.
            }
            textBox1.Text = "";  //clears the text boxes after list entry.
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)  //Saves all categories and lists 
        {
            try
            {
                videoGames.Save();
                music.Save();
                comics.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)  //loads the saved files 
        {
            try
            {
                videoGames.load();
                music.load();
                comics.load();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message);
            }
            if (radioVideoG.Checked == true)
            {
                textBoxListviewer.Text = videoGames.GetList();
            }
            else if (radioMusic.Checked == true)
            {
                textBoxListviewer.Text = music.GetList();
            }
            else
            {
                textBoxListviewer.Text = comics.GetList();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)  // deletes the user's chosen list item. 
        {
            try
            {
                int delete = Convert.ToInt32(textDelete.Text);


                if (radioVideoG.Checked == true)
                {
                    videoGames.DeleteItem(delete);
                    textBoxListviewer.Text = videoGames.GetList();
                }
                else if (radioMusic.Checked == true)
                {
                    music.DeleteItem(delete);
                    textBoxListviewer.Text = music.GetList();
                }
                else
                {
                    comics.DeleteItem(delete);
                    textBoxListviewer.Text = comics.GetList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
