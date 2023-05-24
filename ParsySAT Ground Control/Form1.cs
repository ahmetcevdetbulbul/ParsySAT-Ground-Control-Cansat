using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using GMap.NET.MapProviders;
using System.IO.Ports;
using Excel = Microsoft.Office.Interop.Excel;
using ZedGraph;
using GMap.NET;
using System.Diagnostics;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Windows;

namespace ParsySAT_Ground_Control
{
    public partial class Form1 : Form
    {

        //Vector data = new Vector();
        string inData = "null";
        string simData = "0";
        int i = 0;
        string[] data = new string[20];

        double zaman = 0;
        double sim_zaman = 0;
        int telemetri = 0;
        Double x = 0, y = 0, z = 0;
        double enlem = 39.89026749492359;
        double boylam = 32.658250221507025;
        //39.89026749492359, 32.658250221507025
        //Landing_speed
        DataTable table = new DataTable();

        GraphPane Temperature = new GraphPane();
        GraphPane GPS_Altitude = new GraphPane();
        GraphPane Voltage = new GraphPane();
        //GraphPane Air_pressure = new GraphPane();
        //GraphPane Landing_speed = new GraphPane();
        GraphPane Altitude = new GraphPane();


        PointPairList PointTemperature = new PointPairList();
        PointPairList PointGPS_Altitude = new PointPairList();
        PointPairList PointVoltage = new PointPairList();
        //PointPairList PointAir_pressure = new PointPairList();
        //PointPairList PointLanding_speed = new PointPairList();
        PointPairList PointAltitude = new PointPairList();


        LineItem CurveTemperature;
        LineItem CurveGPS_Altitude;
        LineItem CurveVoltage;
        //LineItem CurveAir_pressure;
        //LineItem CurveLanding_speed;
        LineItem CurveAltitude;

        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;

            

            //map.MinZoom = 10;
            //map.MaxZoom = 50;
            map.Zoom = 15;
            map.Position = new GMap.NET.PointLatLng(enlem, boylam);



            timer1.Interval = 1000;
            timer2.Interval= 1000;
            sim_timer.Interval = 1100;
            timer2.Start();
            label17.Text = DateTime.Now.ToString();

            grafikHazirla();

            string[] ports = SerialPort.GetPortNames();
            cboPort.Items.AddRange(ports);
            //cboPort.SelectedIndex = 0;

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;



            table.Columns.Add("TEAM_ID", typeof(string));
            table.Columns.Add("MISSION_TIME", typeof(string));
            table.Columns.Add("PACKET_COUNT", typeof(string));
            table.Columns.Add("MODE", typeof(string));//3
            table.Columns.Add("STATE", typeof(string));
            table.Columns.Add("ALTITUDE", typeof(string));//5
            table.Columns.Add("HS_DEPLOYED", typeof(string));
            table.Columns.Add("PC_DEPLOYED", typeof(string));//7
            table.Columns.Add("MAST_RAISED", typeof(string));//8
            table.Columns.Add("TEMPERATURE", typeof(string));//9
            table.Columns.Add("VOLTAGE", typeof(string));//10
            table.Columns.Add("GPS_TIME", typeof(string));
            table.Columns.Add("GPS_ALTITUDE", typeof(string));//12
            table.Columns.Add("GPS_LATITUDE", typeof(string));//13
            table.Columns.Add("GPS_LONGITUDE", typeof(string));
            table.Columns.Add("GPS_SATS", typeof(string));//15
            table.Columns.Add("TILT_X", typeof(string));
            table.Columns.Add("TILT_Y", typeof(string));
            table.Columns.Add("CMD_ECHO", typeof(string));//18
            table.Columns.Add("TILT_Z", typeof(string));//19
            //table.Columns.Add("LANDING_SPEED", typeof(string));//20


            dataGridView1.DataSource = table;
        }


        private void grafikHazirla()
        {
            Temperature = zedGraphControl3.GraphPane;
            GPS_Altitude = zedGraphControl2.GraphPane;
            Voltage = zedGraphControl4.GraphPane;
            //Landing_speed = zedGraphControl6.GraphPane;
            Altitude = zedGraphControl1.GraphPane;
            //Air_pressure = zedGraphControl5.GraphPane;

            //Landing_speed

            Temperature.Title.Text = "Temperature - Time Graphic";
            //Landing_speed.Title.Text = "Landing speed - Time Graphic";
            GPS_Altitude.Title.Text = "GPS Altitude - Time Graphic";
            Voltage.Title.Text = "Voltage - Time Graphic";
            Altitude.Title.Text = "Altitude - Time Graphic";
            //Air_pressure.Title.Text = "Air pressure - Time Graphic";




            Temperature.XAxis.Title.Text = "t (s)";
            //Air_pressure.XAxis.Title.Text = "t (s)";
            GPS_Altitude.XAxis.Title.Text = "t (s)";
            Voltage.XAxis.Title.Text = "t (s)";
            Altitude.XAxis.Title.Text = "t (s)";
            //Landing_speed.XAxis.Title.Text = "t (s)";

            

            Temperature.YAxis.Title.Text = " ";
            //Landing_speed.YAxis.Title.Text = " ";
            GPS_Altitude.YAxis.Title.Text = " ";
            //Air_pressure.YAxis.Title.Text = " ";
            Voltage.YAxis.Title.Text = " ";
            Altitude.YAxis.Title.Text = " ";



            Temperature.YAxis.Scale.Min = 0;
            GPS_Altitude.YAxis.Scale.Min = 0;
            //Air_pressure.YAxis.Scale.Min = 0;
            Voltage.YAxis.Scale.Min = 0;
            //Landing_speed.YAxis.Scale.Min = 0;
            Altitude.YAxis.Scale.Min = 0;


            Temperature.YAxis.Scale.Max = 50;
            GPS_Altitude.YAxis.Scale.Max = 1000;
            //Air_pressure.YAxis.Scale.Max = 1000;
            Voltage.YAxis.Scale.Max = 50;
            //Landing_speed.YAxis.Scale.Max = 500;
            Altitude.YAxis.Scale.Max = 1000;


            CurveTemperature = Temperature.AddCurve(null, PointTemperature, Color.DarkBlue, SymbolType.None);
            CurveGPS_Altitude = GPS_Altitude.AddCurve(null, PointGPS_Altitude, Color.DarkBlue, SymbolType.None);
            CurveVoltage = Voltage.AddCurve(null, PointVoltage, Color.DarkBlue, SymbolType.None);
            //CurveLanding_speed = Landing_speed.AddCurve(null, PointLanding_speed, Color.DarkBlue, SymbolType.None);
            CurveAltitude = Altitude.AddCurve(null, PointAltitude, Color.DarkBlue, SymbolType.None);
            //CurveAir_pressure = Air_pressure.AddCurve(null, PointAir_pressure, Color.DarkBlue, SymbolType.None);


        }


        ///////// Uydu 3D similasyon kodları /////////
        private void silindir(float step, float topla, float radius, float dikey1, float dikey2)
        {
            float eski_step = 0.1f;
            GL.Begin(BeginMode.Quads);//Y EKSEN CIZIM DAİRENİN
            while (step <= 360)
            {
                if (step < 45)
                    GL.Color3(Color.FromArgb(255, 0, 0));
                else if (step < 90)
                    GL.Color3(Color.FromArgb(255, 255, 255));
                else if (step < 135)
                    GL.Color3(Color.FromArgb(255, 0, 0));
                else if (step < 180)
                    GL.Color3(Color.FromArgb(255, 255, 255));
                else if (step < 225)
                    GL.Color3(Color.FromArgb(255, 0, 0));
                else if (step < 270)
                    GL.Color3(Color.FromArgb(255, 255, 255));
                else if (step < 315)
                    GL.Color3(Color.FromArgb(255, 0, 0));
                else if (step < 360)
                    GL.Color3(Color.FromArgb(255, 255, 255));


                float ciz1_x = (float)(radius * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey1, ciz1_y);

                float ciz2_x = (float)(radius * Math.Cos((step + 2) * Math.PI / 180F));
                float ciz2_y = (float)(radius * Math.Sin((step + 2) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey1, ciz2_y);

                GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            GL.End();
            GL.Begin(BeginMode.Lines);
            step = eski_step;
            topla = step;
            while (step <= 180)// UST KAPAK
            {
                if (step < 45)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 90)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 135)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 180)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 225)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 270)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 315)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 360)
                    GL.Color3(Color.FromArgb(250, 250, 200));


                float ciz1_x = (float)(radius * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey1, ciz1_y);

                float ciz2_x = (float)(radius * Math.Cos((step + 180) * Math.PI / 180F));
                float ciz2_y = (float)(radius * Math.Sin((step + 180) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey1, ciz2_y);

                GL.Vertex3(ciz1_x, dikey1, ciz1_y);
                GL.Vertex3(ciz2_x, dikey1, ciz2_y);
                step += topla;
            }
            step = eski_step;
            topla = step;
            while (step <= 180)//ALT KAPAK
            {
                if (step < 45)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 90)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 135)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 180)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 225)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 270)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 315)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 360)
                    GL.Color3(Color.FromArgb(250, 250, 200));

                float ciz1_x = (float)(radius * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey2, ciz1_y);

                float ciz2_x = (float)(radius * Math.Cos((step + 180) * Math.PI / 180F));
                float ciz2_y = (float)(radius * Math.Sin((step + 180) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);

                GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            GL.End();
        }
        private void koni(float step, float topla, float radius1, float radius2, float dikey1, float dikey2)
        {
            float eski_step = 0.1f;
            GL.Begin(BeginMode.Lines);//Y EKSEN CIZIM DAİRENİN
            while (step <= 360)
            {
                if (step < 45)
                    GL.Color3(1.0, 1.0, 1.0);
                else if (step < 90)
                    GL.Color3(1.0, 0.0, 0.0);
                else if (step < 135)
                    GL.Color3(1.0, 1.0, 1.0);
                else if (step < 180)
                    GL.Color3(1.0, 0.0, 0.0);
                else if (step < 225)
                    GL.Color3(1.0, 1.0, 1.0);
                else if (step < 270)
                    GL.Color3(1.0, 0.0, 0.0);
                else if (step < 315)
                    GL.Color3(1.0, 1.0, 1.0);
                else if (step < 360)
                    GL.Color3(1.0, 0.0, 0.0);


                float ciz1_x = (float)(radius1 * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius1 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey1, ciz1_y);

                float ciz2_x = (float)(radius2 * Math.Cos(step * Math.PI / 180F));
                float ciz2_y = (float)(radius2 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            GL.End();

            GL.Begin(BeginMode.Lines);
            step = eski_step;
            topla = step;
            while (step <= 180)// UST KAPAK
            {
                if (step < 45)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 90)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 135)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 180)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 225)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 270)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 315)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 360)
                    GL.Color3(Color.FromArgb(250, 250, 200));


                float ciz1_x = (float)(radius2 * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius2 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey2, ciz1_y);

                float ciz2_x = (float)(radius2 * Math.Cos((step + 180) * Math.PI / 180F));
                float ciz2_y = (float)(radius2 * Math.Sin((step + 180) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);

                GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            step = eski_step;
            topla = step;
            GL.End();
        }
        private void Pervane(float yukseklik, float uzunluk, float kalinlik, float egiklik)
        {
            float radius = 10, angle = 45.0f;
            GL.Begin(BeginMode.Quads);

            GL.Color3(Color.Red);
            GL.Vertex3(uzunluk, yukseklik, kalinlik);
            GL.Vertex3(uzunluk, yukseklik + egiklik, -kalinlik);
            GL.Vertex3(0.0, yukseklik + egiklik, -kalinlik);
            GL.Vertex3(0.0, yukseklik, kalinlik);

            GL.Color3(Color.Red);
            GL.Vertex3(-uzunluk, yukseklik + egiklik, kalinlik);
            GL.Vertex3(-uzunluk, yukseklik, -kalinlik);
            GL.Vertex3(0.0, yukseklik, -kalinlik);
            GL.Vertex3(0.0, yukseklik + egiklik, kalinlik);

            GL.Color3(Color.White);
            GL.Vertex3(kalinlik, yukseklik, -uzunluk);
            GL.Vertex3(-kalinlik, yukseklik + egiklik, -uzunluk);
            GL.Vertex3(-kalinlik, yukseklik + egiklik, 0.0);//+
            GL.Vertex3(kalinlik, yukseklik, 0.0);//-

            GL.Color3(Color.White);
            GL.Vertex3(kalinlik, yukseklik + egiklik, +uzunluk);
            GL.Vertex3(-kalinlik, yukseklik, +uzunluk);
            GL.Vertex3(-kalinlik, yukseklik, 0.0);
            GL.Vertex3(kalinlik, yukseklik + egiklik, 0.0);
            GL.End();

        }
        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            float step = 1.0f;
            float topla = step;
            float radius = 5.0f;
            float dikey1 = radius, dikey2 = -radius;
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Clear(ClearBufferMask.DepthBufferBit);

            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(1.04f, 4 / 3, 1, 10000);
            Matrix4 lookat = Matrix4.LookAt(25, 0, 0, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.LoadMatrix(ref perspective);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.LoadMatrix(ref lookat);
            GL.Viewport(0, 0, glControl1.Width, glControl1.Height);
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Less);

            GL.Rotate(x, 1.0, 0.0, 0.0);//ÖNEMLİ
            GL.Rotate(z, 0.0, 1.0, 0.0);
            GL.Rotate(y, 0.0, 0.0, 1.0);

            silindir(step, topla, radius, 3, -5);
            //silindir(0.01f, topla, 0.5f, 9, 9.7f);
            //silindir(0.01f, topla, 0.1f, 5, dikey1 + 5);
            koni(0.01f, 0.01f, radius, 3.0f, 3, 5);

            koni(0.01f, 0.01f, radius, 2.0f, -5.0f, -10.0f);
            //Pervane(6.0f, 9.0f, 0.2f, 0.5f);


            GL.Begin(BeginMode.Lines);

            GL.Color3(Color.FromArgb(250, 0, 0));
            GL.Vertex3(-30.0, 0.0, 0.0);
            GL.Vertex3(30.0, 0.0, 0.0);


            GL.Color3(Color.FromArgb(0, 0, 0));
            GL.Vertex3(0.0, 30.0, 0.0);
            GL.Vertex3(0.0, -30.0, 0.0);

            GL.Color3(Color.FromArgb(0, 0, 250));
            GL.Vertex3(0.0, 0.0, 30.0);
            GL.Vertex3(0.0, 0.0, -30.0);

            GL.End();
            //GraphicsContext.CurrentContext.VSync = true;
            glControl1.SwapBuffers();
        }

        private void clear_dgv()
        {
            table.Clear();
        }


        private void ToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

                int StartCol = 1;
                int StartRow = 1;

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView1.Columns[j].HeaderText;
                }

                StartRow++;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    }
                }
            }
            catch (Exception hata)
            {
                //MessageBox.Show(hata.StackTrace);
            }
        }

        private void sEnable_Click(object sender, EventArgs e)
        {

            string file_name = @"C:\Users\USER\Desktop\cansat_2023_simp.txt";
            string textLine = "";
            string textLine1 = "";

            if (System.IO.File.Exists(file_name) == true)
            {
                System.IO.StreamReader objReader;
                objReader = new System.IO.StreamReader(file_name);

                do
                {
                    textLine = objReader.ReadLine();
                    if (textLine.IndexOf("C") == 0)
                    {
                        textLine1 = textLine + "\r\n" + textLine1;
                    }
                } while (objReader.Peek() != -1);

                objReader.Close();
            }
            else
            {
                MessageBox.Show("No such file " + file_name);
            }

            richTextBox1.Text = textLine1;


            serialPort1.PortName = cboPort.Text;
            serialPort1.BaudRate = Convert.ToInt32(baudRate.Text);
            serialPort1.Open();
            checkBox1.Checked = true;
            
            //serialPort1.Write("CMD,1077,SIM,ENABLE");
        }

        private void sActivate_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            
            serialPort1.Write("A");
            if (checkBox2.Checked && checkBox1.Checked) { checkBox3.Checked = true; }
            sim_timer.Start();

        }

        private void On_telemetry_Click(object sender, EventArgs e)
        {
            timer1.Start();
            try
            {
                if (cboPort.Text == "" || baudRate.Text == "")
                {
                    MessageBox.Show("Please select port settings");
                }
                else
                {
                    serialPort1.PortName = cboPort.Text;
                    serialPort1.BaudRate = Convert.ToInt32(baudRate.Text);
                    serialPort1.Open();
                    button1.Enabled = false;
                }
            }

            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Unauthorised Access");
            }

        }



        private void simDisable_Click(object sender, EventArgs e)
        {
            serialPort1.Write("CMD,1077,SIM,DISABLE");
            checkBox3.Checked = false;
            checkBox2.Checked = false;
            checkBox1.Checked = false;
            sim_timer.Stop();
            serialPort1.Close();
        }

        private void sim_timer_Tick(object sender, EventArgs e)
        {
            if (richTextBox1.Lines[i] == "")
            {
                sim_timer.Stop();
            }
            sim_TextBox.Text = richTextBox1.Lines[i];
            if (i == richTextBox1.TextLength - 1)
            {
                timer1.Stop();
            }
            i++;
            serialPort1.Write(sim_TextBox.Text);


            simData = serialPort1.ReadExisting();

            sim_TextBox.Text = simData.ToString();
            if (sim_TextBox.Text.Length == 0) { simData = "0"; }

            
            sim_zaman += 1;
            try
            {
                if( (Convert.ToDouble(simData.ToString()) / 10000) < 100 || (Convert.ToDouble(simData.ToString()) / 10000) > 1000) { simData = "9000000"; } 
                PointAltitude.Add(new PointPair(sim_zaman, Convert.ToDouble(simData.ToString()) / 10000));
            }
            catch (Exception hata)
            {
                //MessageBox.Show(hata.StackTrace);
            }
            Altitude.XAxis.Scale.Max = sim_zaman;
            Altitude.AxisChange();
            zedGraphControl1.Refresh();

                
            
        }

        private void set_time_Click(object sender, EventArgs e)
        {
            serialPort1.Write("CMD,1077,ST,"+DateTime.Now);
            
        }

        private void off_telemetry_Click(object sender, EventArgs e)
        {
            serialPort1.Close();    
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            label17.Text = DateTime.Now.ToString();
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
            GL.Enable(EnableCap.DepthTest);
        }
        ///////////////////////////////////

        private void timer1_Tick(object sender, EventArgs e)
        {
            string inData = serialPort1.ReadExisting();
            data = inData.Split(',').Select(sValue => sValue.Trim()).ToArray();


           

            enlem = Convert.ToDouble(data[13].ToString()) / 100000;
            boylam = Convert.ToDouble(data[14].ToString()) / 100000;



            map.Position = new GMap.NET.PointLatLng(enlem, boylam);
            PointLatLng point = new PointLatLng(enlem, boylam);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_small);

            GMapOverlay markers = new GMapOverlay("ParsySAT");

            markers.Markers.Add(marker);

            map.Overlays.Add(markers);
            enlem = enlem + 0.005;
            boylam = boylam + 0.005;



            /////////////////////////////
            try
            {
                glControl1.Invalidate();
                telemetri++;

                textBox8.Text = data[19];
                z = Convert.ToDouble(data[19].ToString()) / 10;
                textBox9.Text = data[17];
                y = Convert.ToDouble(data[17].ToString()) / 10;
                textBox10.Text = data[16];
                x = Convert.ToDouble(data[16].ToString()) / 10;


                string[] values = data;


                for (int i = 0; i < data.Length; i++)
                {

                    string[] row = new string[data.Length];

                    for (int j = 0; j < values.Length; j++)
                    {
                        row[j] = values[j].Trim();
                        data[j] = row[j];
                    }
                    table.Rows.Add(row);
                }

                if (telemetri == 800)
                {
                    try
                    {
                        Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                        excel.Visible = true;
                        Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                        Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

                        int StartCol = 1;
                        int StartRow = 1;

                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                            myRange.Value2 = dataGridView1.Columns[j].HeaderText;
                        }

                        StartRow++;

                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                                myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                            }
                        }
                    }
                    catch (Exception hata)
                    {
                        //MessageBox.Show(hata.StackTrace);
                    }

                    clear_dgv();

                }

                


                if (data.Length != 2)
                {
                    zaman += 1;

                   

                    PointTemperature.Add(new PointPair(zaman, Convert.ToDouble(data[9].ToString()) / 100));
                    PointGPS_Altitude.Add(new PointPair(zaman, Convert.ToDouble(data[12].ToString()) / 100));//5
                    //PointLanding_speed.Add(new PointPair(zaman, Convert.ToDouble(data[20].ToString()) / 100));
                    //PointAir_pressure.Add(new PointPair(zaman, Convert.ToDouble(data[7].ToString()) / 100));
                    PointVoltage.Add(new PointPair(zaman, Convert.ToDouble(data[10].ToString()) / 100));
                    PointAltitude.Add(new PointPair(zaman, Convert.ToDouble(data[5].ToString()) / 100));
                    



                    Temperature.XAxis.Scale.Max = zaman;
                    GPS_Altitude.XAxis.Scale.Max = zaman;
                    Voltage.XAxis.Scale.Max = zaman;
                    Altitude.XAxis.Scale.Max = zaman;
                    //Air_pressure.XAxis.Scale.Max = zaman;
                    //Landing_speed.XAxis.Scale.Max = zaman;


                    Temperature.AxisChange();
                    GPS_Altitude.AxisChange();
                    Voltage.AxisChange();

                    Altitude.AxisChange();
                    //Landing_speed.AxisChange();




                    zedGraphControl1.Refresh();
                    zedGraphControl2.Refresh();
                    zedGraphControl3.Refresh();
                    zedGraphControl4.Refresh();
                    //zedGraphControl5.Refresh();
                    //zedGraphControl6.Refresh();





                }
            }

            catch (Exception ex)
            {

            }
        }






        
        


    }
}
