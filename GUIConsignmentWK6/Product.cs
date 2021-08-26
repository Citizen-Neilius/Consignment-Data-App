using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
{     //************************************************************************************************************************************************************
    //                    The product class is the base class to be inherited by Videogames, music, and comics.
    class Product
    {

        protected string input1name;  // Each instance of a class has different inputs to be stored, such as "album title"
        protected string input2name;
        protected string input3name;
        protected string input4name;
        protected string listforDisplay;   //listfordisplay is used to transfer the entire list over to the form for display.
        protected string type;              // type just holds the type of list (music, comics etc)
        string item;
        protected List<string> listlist = new List<string>();  // the list

   
        public void AddItem(string input1, string input2, string input3, string input4)  // uses the users input to add to the list.
        {
            item = "                        " + input1name + input1 + "                        " + input2name + input2 +
                "                        " + input3name + input3 + "                        " + input4name + input4 + "                        ";
            listlist.Add(item);

        }
        public string GetList()  //Gets the list and transfers to the form for display
        {
            int p = 0;

            // Displaying the elements of List 

            foreach (string k in listlist)
            {
                if (p > 0)
                {
                    listforDisplay = listforDisplay + Environment.NewLine + "Item # " + (p) + "\t" + k;

                    p++;
                }
                else
                {
                    listforDisplay = type + " List";
                    p++;
                }

            }
            return listforDisplay;
        }
        public void DeleteItem(int itemnumber)  //uses input from user to delete a list entry.
        {
            listlist.RemoveAt(itemnumber);
        }

    }

        class VideoGames : Product  //Class for video game list
        {
            public VideoGames()
            {
                listlist.Add("Video games:");
                input1name = "Title: ";
                input2name = "Version:  ";
                input3name = "Manufacturer:  ";
                input4name = "Price:  ";
                type = "Video Games";
            }
            public void Save()  //Saves to a text file.
            {
                TextWriter tw = new StreamWriter("SavedVideo.txt");  //System IO Textwriter/Streamwriter creates text file
                int p = 0;

                // Displaying the elements of List 

                foreach (string k in listlist)  //writes ONE line per item in list to saved text file.
                {
                    tw.WriteLine(k);
                    p++;
                }
                // close the stream     
                tw.Close();
            }
            public void load()   //loading the saved data from text file.
            {

                // create reader & open file
                string temp;
                TextReader lr = new StreamReader("SavedVideo.txt");  
                listlist.Clear();
                temp = lr.ReadLine();
                while (temp != null)  // code reads lines from text until the input is null.
                {
                    listlist.Add(temp);
                    temp = lr.ReadLine();
                }


                // close the stream
                lr.Close();
            }
        }



    class Music : Product  //Class for music list
    {
        public Music()
        {
            listlist.Add("Music :");
            input1name = "Album Title: ";
            input2name = "Band:  ";
            input3name = "Record Label:  ";
            input4name = "Price:  ";
            type = "Music";
        }
        public void Save()  //Saves file for Music 
        {
            TextWriter tw = new StreamWriter("SavedMusic.txt");  //System IO Textwriter/Streamwriter creates text file
            int p = 0;

            // Displaying the elements of List 

            foreach (string k in listlist)
            {
                tw.WriteLine(k);
                p++;
            }
            // close the stream     
            tw.Close();
        }
        public void load()   //loading music
        {

            // create reader & open file
            string temp;
            TextReader lr = new StreamReader("SavedMusic.txt");
            listlist.Clear();
            temp = lr.ReadLine();
            while (temp != null)
            {
                listlist.Add(temp);
                temp = lr.ReadLine();
            }


            // close the stream
            lr.Close();


        }
    }
    class Comics : Product //class for Comics list.
    {
        public Comics()
        {
            listlist.Add("Music :");
            input1name = "Super Hero: ";
            input2name = "Issue Title:";
            input3name = "Publisher:  ";
            input4name = "Price:  ";
            type = "Comics";
        }
        public void Save()
        {
            TextWriter tw = new StreamWriter("SavedComics.txt");  //System IO Textwriter/Streamwriter creates text file
            int p = 0;

            // Displaying the elements of List 

            foreach (string k in listlist)
            {
                tw.WriteLine(k);
                p++;
            }
            // close the stream     
            tw.Close();
        }
        public void load()   //loads the comic data
        {

            // create reader & open file
            string temp;
            TextReader lr = new StreamReader("SavedComics.txt");
            listlist.Clear();
            temp = lr.ReadLine();
            while (temp != null)
            {
                listlist.Add(temp);
                temp = lr.ReadLine();
            }


            // close the stream
            lr.Close();

        }
    }
    }




