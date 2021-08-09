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

namespace ProtocolEditor
{
    public partial class ProtocolEditor : Form
    {
        public ProtocolEditor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 2);

            // Create rectangle for ellipse.
            Rectangle rect = new Rectangle(50, 0, 350, 350);

            // Draw ellipse to screen.
            e.Graphics.DrawEllipse(blackPen, rect);

            e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(231,178), new Point(350, 51));
            
        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.DrawLine(new Pen(Color.Black, 3),
                                 1,
                                 1,
                                 10,
                                 10);

            e.Graphics.DrawLine(new Pen(Color.Black, 3),
                                 1,
                                 10,
                                 10,
                                 1);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Point[] ptos = new Point[] { new Point(0, 0), new Point(0, 18), new Point(9, 9) };
            e.Graphics.FillPolygon(brush: new SolidBrush(Color.Red),ptos); 
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Point[] ptos = new Point[] { new Point(0, 0), new Point(0, 18), new Point(9, 9) };
            e.Graphics.FillPolygon(brush: new SolidBrush(Color.Red), ptos);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click_1(object sender, EventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string fileName = "input.txt";

            try
            {   
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                using (FileStream fs = File.Create(fileName))
                {
                    byte[] name = new UTF8Encoding(true).GetBytes("Name:" + textBox8.Text + "\n");
                    fs.Write(name, 0, name.Length);

                    byte[] radio = new UTF8Encoding(true).GetBytes("Ratio:" + textBox1.Value + "\n");
                    fs.Write(radio, 0, radio.Length);

                    byte[] nbanderas = new UTF8Encoding(true).GetBytes("Flags Quantity:" + textBox5.Value + "\n");
                    fs.Write(nbanderas, 0, nbanderas.Length);

                    byte[] separacion = new UTF8Encoding(true).GetBytes("Separation:" + textBox4.Value + "\n");
                    fs.Write(separacion, 0, separacion.Length);

                    string color = "rojo";

                    if (comboBox4.SelectedIndex == 1)
                    {
                        color = "azul";
                    }
                    if (comboBox4.SelectedIndex == 2)
                    {
                        color = "amarillo";
                    }
                    if (comboBox4.SelectedIndex == 3)
                    {
                        color = "verde";
                    }


                    byte[] colores = new UTF8Encoding(true).GetBytes("Flag Color:" + color + "\n");
                    fs.Write(colores, 0, colores.Length);

                    string escena = (string)comboBox5.SelectedItem;
                    byte[] escenas = new UTF8Encoding(true).GetBytes("Virtual scena id:" + escena + "\n");
                    fs.Write(escenas, 0, escenas.Length);


                    Dispose();
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
