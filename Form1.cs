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
using System.Runtime.Serialization.Formatters.Binary;

namespace ShapeInheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Circle> listCircle = new List<Circle>();
        List<Rectangle> listRectangle = new List<Rectangle>();

        Rectangle newReactangle;
        Circle newCircle;
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonCircle_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxRectangle.Enabled = false;
            groupBoxCircle.Enabled = true;
        }

        private void radioButtonRectangle_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCircle.Enabled = false;
            groupBoxRectangle.Enabled = true;
        }
        #region saveload
        string circleDefaultName = "circle.dat";
        string rectangleDefaultName = "rectangle.dat";

        public void SaveCircle(string fileName)
        {
            FileStream myFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(myFile, listCircle);
            myFile.Close();
        }
        public void SaveRectangle(string fileName)
        {
            FileStream myFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(myFile, listRectangle);
            myFile.Close();
        }
        public void OpenCircle(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream myFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                listCircle = (List<Circle>)formatter.Deserialize(myFile);
                myFile.Close();
            }
        }
        public void OpenRectangle(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream myFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                listRectangle = (List<Rectangle>)formatter.Deserialize(myFile);
                myFile.Close();
            }
        }
        #endregion

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
        }
        public void reset()
        {
            numericUpDownLeft.Value = numericUpDownLeft.Minimum;
            numericUpDownTop.Value = numericUpDownTop.Minimum;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int left = (int)numericUpDownLeft.Value;
                int top = (int)numericUpDownTop.Value;
                if (radioButtonCircle.Checked)
                {
                    int diameter = (int)numericUpDownDiameter.Value;
                    newCircle = new Circle(left, top, diameter);

                    listCircle.Add(newCircle);
                    listBoxInfo.Items.AddRange(newCircle.Display().Split('\n'));

                    SaveCircle(circleDefaultName);
                }
                else if (radioButtonRectangle.Checked)
                {
                    int width = (int)numericUpDownWidth.Value;
                    int height = (int)numericUpDownHeight.Value;

                    newReactangle = new Rectangle(left, top, width, height);
                    listRectangle.Add(newReactangle);
                    listBoxInfo.Items.AddRange(newReactangle.Display().Split('\n'));

                    SaveRectangle(rectangleDefaultName);
                }
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDisplayAll_Click(object sender, EventArgs e)
        {
            foreach (Circle i in listCircle)
            {
                listBoxInfo.Items.AddRange(i.Display().Split('\n'));
            }
            foreach (Rectangle i in listRectangle)
            {
                listBoxInfo.Items.AddRange(i.Display().Split('\n'));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenCircle(circleDefaultName);
            OpenRectangle(rectangleDefaultName);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int left = (int)numericUpDownLeft.Value;
                int top = (int)numericUpDownTop.Value;
                bool found = false;
                if (radioButtonCircle.Checked)
                {
                    int diamter = (int)numericUpDownDiameter.Value;
                    for (int i = 0; i < listCircle.Count && (!found); i++)
                    {
                        if(listCircle[i].Left == left && listCircle[i].Top == top && listCircle[i].Diameter == diamter)
                        {
                            listCircle.RemoveAt(i);
                            SaveCircle(circleDefaultName);
                            found = true;
                        }

                    }
                    if (found == false)
                    {
                        MessageBox.Show("Circle not found");
                    }
                    else
                    {
                        
                    }
                }
                else
                {
                    int width = (int)numericUpDownWidth.Value;
                    int height = (int)numericUpDownHeight.Value;
                    for (int i = 0; i < listRectangle.Count && (!found); i++)
                    {
                        if (listRectangle[i].Left == left && listRectangle[i].Top == top 
                            && listRectangle[i].Height == height && listRectangle[i].Width == width)
                        {
                            listRectangle.RemoveAt(i);
                            SaveRectangle(rectangleDefaultName);
                            found = true;
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
