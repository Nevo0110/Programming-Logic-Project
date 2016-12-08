using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace counterProgram
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        int count = 0; // count will store the current number of edits for the session

        private void GetAverage()
        {
            FileStream getAverage = new FileStream(@"output.txt", FileMode.Open, FileAccess.Read); // create a filestream to open files and read them
            StreamReader readOutput = new StreamReader(getAverage); // the streamreader that will do the reading and writing
            
            var listForAverage = new List<int>(); // this list is an array however it has no set size

            while (!readOutput.EndOfStream) // while the streamreader hasn't reached the end of the file continue to loop
            {
                int placeholder; // the placehoder is exactly that, a value is stored here that is later added to the list

                if (int.TryParse(readOutput.ReadLine(), out placeholder)) // if it is possible to convert the current line in the file to an integer put that integer in the placeholder variable
                    listForAverage.Add(placeholder); // put the placeholder variable into the list only if the if statement evalutes as true
            }

            if(count > 0) // when the application opens if the current count is less than zero, don't add the count to the list so the user can see the overall average before putting values in
                listForAverage.Add(count); // adds the current count everytime an average is calculated which is everytime the button is clicked giving a realtime average

            if (listForAverage.Count > 0) // this if statement makes sure that there is something inside of the list before averaging
            {
                double uAverage = listForAverage.Average(); // get the initial average in a double
                string average = uAverage.ToString("#.##"); // format the average making it more readable

                displayAverage.Text = average; 
            }

            for (int i = 0; i < listForAverage.Count; i++)
            {
                chart1.Series["Edits"].Points.AddXY(i + 1, listForAverage[i]); // sets the XY cordinates of the graph, the X cordinate is the "i" variable plus one because lists start at zero just like arrays, after that the Y value is simply the current list item
            }

            readOutput.Close(); // close the streamreader so other applications and the user can access the file
        }

        private void button_Click(object sender, EventArgs e)
        {
            ++count; 
            currentCount.Text = count.ToString();
            GetAverage();

        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (count > 0) // everytime the form closes save the current count to the otuput.txt file only if the current count is greater than zero
            {
                FileStream writer = new FileStream(@"output.txt", FileMode.Append, FileAccess.Write); // create a filestream that will append files with write access
                StreamWriter writeOutput = new StreamWriter(writer); // the streamwriter that will be doing all of the writing to file

                writeOutput.WriteLine(count); // writeline the current count value to the output.txt file using the "writeOutput" streamwriter
                writeOutput.Close(); // close the streamwriter so that other applications and the user can access the file
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"output.txt") == false) // when the form loads check to see if output.txt exists, if not create one
            { 
                var createOutput = File.Create(@"output.txt"); // instead of using another filestream and streamwriter here I just used the File.Create() method because there's no appending or readingb

                createOutput.Close(); // like all file manipulation you need to close the stream to allow other applications and the user to edit the file
            }
            currentCount.Text = count.ToString();
            GetAverage();
        }

        private void graphColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = graphColor.SelectedItem.ToString();
            chart1.Series["Edits"].Color = Color.FromName(color);
        }
    }
}