using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSYS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\Users\\T00233163\\Documents\\Y2_project\\credentials.txt");
                //Read the first line of text
                line = sr.ReadLine();

                String[] creds = line.Split(',');
                String username = creds[0];
                String password = creds[1];

                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            InitializeComponent();
        }
    }
}
