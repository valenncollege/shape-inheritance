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
        //List<Circle> listCircle = new List<Circle>();
        //List<Rectangle> listRectangle = new List<Rectangle>();
        List<Shape> listShape = new List<Shape>();

        //Rectangle newReactangle;
        //Circle newCircle;
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
        string defaultName = "shape.dat";

        public void SaveShape(string fileName)
        {
            FileStream myFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(myFile, listShape);
            myFile.Close();
        }  
       
        public void OpenShape(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream myFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                listShape = (List<Shape>)formatter.Deserialize(myFile);
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
                    Shape newCircle = new Circle(left, top, diameter);
                    listShape.Add(newCircle);                    
                    listBoxInfo.Items.AddRange(newCircle.Display().Split('\n'));
                    SaveShape(defaultName);
                }
                else if (radioButtonRectangle.Checked)
                {
                    int width = (int)numericUpDownWidth.Value;
                    int height = (int)numericUpDownHeight.Value;

                    Shape newReactangle = new Rectangle(left, top, width, height);
                    listShape.Add(newReactangle);
                    //listRectangle.Add(newReactangle);
                    listBoxInfo.Items.AddRange(newReactangle.Display().Split('\n'));
                    SaveShape(defaultName);
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
           
            foreach (Shape i in listShape)
            {
               listBoxInfo.Items.AddRange(i.Display().Split('\n'));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenShape(defaultName);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                int left = (int)numericUpDownLeft.Value;
                int top = (int)numericUpDownTop.Value;
                bool found = false;
                if (radioButtonCircle.Checked)
                {
                    int diamter = (int)numericUpDownDiameter.Value;
                    for (int i = 0; i < listShape.Count && (!found); i++)
                    {
                        if (i is Circle)
                        {
                            if (listShape[i].Left == left && listShape[i].Top == top && listShape[i].Diameter == diamter)
                            {
                                listCircle.RemoveAt(i);
                                SaveCircle(circleDefaultName);
                                found = true;
                            }
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
            */
        }

        private void buttonLuas_Click(object sender, EventArgs e)
        {
            /*
            if (radioButtonCircle.Checked)
            {
                int diameter = (int)numericUpDownDiameter.Value;
                Shape newCircle = new Circle(left, top, diameter);
                listBoxInfo.Items.Add("Luas : " + newCircle.CalculateArea());
                listBoxInfo.Items.Add("Keliling : " + newCircle.CalculatePerimeter());
            }
            else if (radioButtonRectangle.Checked)
            {
                int width = (int)numericUpDownWidth.Value;
                int height = (int)numericUpDownHeight.Value;

                Shape newReactangle = new Rectangle(left, top, width, height);
                listBoxInfo.Items.Add("Luas : " + newReactangle.CalculateArea());
                listBoxInfo.Items.Add("Keliling : " + newReactangle.CalculatePerimeter());
                listBoxInfo.Items.Add("Diagonal : " + newReactangle.CalculateDiagonal());
            }
            */
            listBoxInfo.Items.Clear();
            if (radioButtonCircle.Checked)
            {
                foreach (Shape i in listShape)
                {
                    if (i is Circle)
                    {
                        listBoxInfo.Items.AddRange(i.Display().Split('\n'));
                        listBoxInfo.Items.Add("Luas : " + i.CalculateArea());
                        listBoxInfo.Items.Add("");
                    }
                }
            }
            else
            {
                foreach(Shape i in listShape)
                {
                    if (i is Rectangle)
                    {
                        listBoxInfo.Items.AddRange(i.Display().Split('\n'));
                        listBoxInfo.Items.Add("Luas : " + i.CalculateArea());
                        listBoxInfo.Items.Add("");
                    }
                }
            }

        }

        private void buttonKeliling_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            if (radioButtonCircle.Checked)
            {
                foreach (Shape i in listShape)
                {
                    if (i is Circle)
                    {
                        listBoxInfo.Items.AddRange(i.Display().Split('\n'));
                        listBoxInfo.Items.Add("Luas : " + i.CalculatePerimeter());
                        listBoxInfo.Items.Add("");
                    }
                }
            }
            else
            {
                foreach (Shape i in listShape)
                {
                    if (i is Rectangle)
                    {
                        listBoxInfo.Items.AddRange(i.Display().Split('\n'));
                        listBoxInfo.Items.Add("Luas : " + i.CalculatePerimeter());
                        listBoxInfo.Items.Add("");
                    }
                }
            }
        }

        private void buttonDiagonal_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            foreach (Shape i in listShape)
            {
                if (i is Rectangle)
                {
                    listBoxInfo.Items.AddRange(i.Display().Split('\n'));
                    listBoxInfo.Items.Add("Luas : " + i.CalculateDiagonal());
                    listBoxInfo.Items.Add("");
                }
            }
        }
    }
}
