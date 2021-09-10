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

namespace Protocol_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
Pen blackPen = new Pen(Color.Black, 2);

            // Create rectangle for ellipse.
            Rectangle rect = new Rectangle(15, 0, 300, 300);

            // Draw ellipse to screen.
            e.Graphics.DrawEllipse(blackPen, rect);

            e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(162, 150), new Point(279, 51));
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

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Point[] ptos = new Point[] { new Point(0, 0), new Point(0, 18), new Point(9, 9) };
            e.Graphics.FillPolygon(brush: new SolidBrush(Color.Red), ptos);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Point[] ptos = new Point[] { new Point(0, 0), new Point(0, 18), new Point(9, 9) };
            e.Graphics.FillPolygon(brush: new SolidBrush(Color.Red), ptos);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Point[] ptos = new Point[] { new Point(0, 0), new Point(0, 18), new Point(9, 9) };
            e.Graphics.FillPolygon(brush: new SolidBrush(Color.Red), ptos);
        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {
            Point[] ptos = new Point[] { new Point(0, 0), new Point(0, 18), new Point(9, 9) };
            e.Graphics.FillPolygon(brush: new SolidBrush(Color.Red), ptos);
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label21_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    byte[] ip = new UTF8Encoding(true).GetBytes("IP:" + textBox2.Text + "\n");
                    fs.Write(ip, 0, ip.Length);
                    byte[] preotr;
                    if (comboBox6.SelectedIndex == 1)
                    {
                        preotr = new UTF8Encoding(true).GetBytes("PreTR/TR:" + "P" + "\n"); 
                    }
                    else
                    {
                        preotr = new UTF8Encoding(true).GetBytes("PreTR/TR:" + "T" + "\n");
                    }
                    fs.Write(preotr, 0, preotr.Length);

                    byte[] name = new UTF8Encoding(true).GetBytes("Name:" + textBox1.Text + "\n");
                    fs.Write(name, 0, name.Length);

                    byte[] radio = new UTF8Encoding(true).GetBytes("Ratio:" + textBox3.Value + "\n");
                    fs.Write(radio, 0, radio.Length);

                    byte[] nbanderas = new UTF8Encoding(true).GetBytes("Flags Quantity:" + textBox10.Value + "\n");
                    fs.Write(nbanderas, 0, nbanderas.Length);

                    byte[] separacion = new UTF8Encoding(true).GetBytes("Separation:" + textBox5.Value + "\n");
                    fs.Write(separacion, 0, separacion.Length);

                    string color = "rojo";

                    if (comboBox8.SelectedIndex == 1)
                    {
                        color = "azul";
                    }
                    if (comboBox8.SelectedIndex == 2)
                    {
                        color = "amarillo";
                    }
                    if (comboBox8.SelectedIndex == 3)
                    {
                        color = "verde";
                    }


                    byte[] colores = new UTF8Encoding(true).GetBytes("Flag Color:" + color + "\n");
                    fs.Write(colores, 0, colores.Length);

                    string escena = (string)comboBox2.SelectedItem;
                    byte[] escenas = new UTF8Encoding(true).GetBytes("Virtual Scena id:" + escena + "\n");
                    fs.Write(escenas, 0, escenas.Length);

                    byte[] angulo = new UTF8Encoding(true).GetBytes("Angle:" + textBox9.Value + "\n");
                    fs.Write(angulo, 0, angulo.Length);

                    byte[] delay = new UTF8Encoding(true).GetBytes("Delay:" + comboBox7.SelectedIndex + "\n");
                    fs.Write(delay, 0, delay.Length);

                    byte[] protocol = new UTF8Encoding(true).GetBytes("Protocol:" + comboBox5.SelectedIndex + "\n");
                    fs.Write(protocol, 0, protocol.Length);

                    Dispose();
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void comboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
