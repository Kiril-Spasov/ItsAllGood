using System;
using System.IO;
using System.Windows.Forms;

namespace ItsAllGood
{
    public partial class FormItsAllGood : Form
    {
        public FormItsAllGood()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int x1, y1, x2, y2;

            string[] points = new string[5];

            string line = "";
            string lineSplit;

            string path = Application.StartupPath + @"\good.txt";
            StreamReader streamReader = new StreamReader(path);

            int linesCount = Convert.ToInt32(streamReader.ReadLine());

            for (int i = 1; i <= linesCount; i++)
            {
                line = streamReader.ReadLine();

                points = line.Split(' ');

                x1 = Convert.ToInt32(points[0]);
                y1 = Convert.ToInt32(points[1]);
                x2 = Convert.ToInt32(points[2]);
                y2 = Convert.ToInt32(points[3]);

                CheckLines(x1, y1, x2, y2);

            }
        }

        private void CheckLines(int x1, int y1, int x2, int y2)
        {
            if (x1 == x2 || y1 == y2)
            {
                TxtResult.Text += "It's all good." + Environment.NewLine;
            }
            else
            {
                TxtResult.Text += "We need to fix this." + Environment.NewLine;
            }
        }
    }
}
