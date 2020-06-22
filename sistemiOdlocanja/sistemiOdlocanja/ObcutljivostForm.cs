using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace sistemiOdlocanja
{
    public partial class ObcutljivostForm : Form
    {
        public ObcutljivostForm(List<int> values, List<string> alternative, List<Parameter> parameters, List<int> rezultati, int indeks2)
        {
            InitializeComponent();


           

            //sestevat se mores sproti ne samo prvo vrsto drugac dobis same ravne crte
            //TODO
            var indeks = indeks2;//po katerem paramtertu gledamo
            List<int> vmesnevrednosti = new List<int>();
            List<int> vmesnevrednosti2 = new List<int>();
            int vmesni = 0;
            //List<int> rezultati = new List<int>();
            var stevc = 0;
            Random rnd = new Random();
            for (int i = 0; i < alternative.Count; i++)
            {

                if (chartObcutljivosti.Series.IsUniqueName(alternative[i]))
                {
                    Color randomColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                    chartObcutljivosti.Series.Add(alternative[i]);// narise samo dve seriji
                    chartObcutljivosti.Series[alternative[i]].LegendText = alternative[i];
                    chartObcutljivosti.Series[alternative[i]].ChartType = SeriesChartType.Line;
                    chartObcutljivosti.Series[alternative[i]].Color = randomColor;

                }
               
                

                for (int z = 0; z < parameters.Count; z++)
                {



                    if (z == indeks)
                    {

                        for (int t = 1; t <= 10; t++)
                        {
                            // MessageBox.Show(values[z+stevc].ToString() + "*" + t.ToString());


                            vmesni = vmesni + values[z + stevc] * t;

                            //narisi tocko


                            //sestevanje 

                            for (int w = 0; w < parameters.Count; w++)
                            {
                                if (w == indeks)
                                {
                                    continue;
                                }
                                else
                                {

                                    //MessageBox.Show(values[w+stevc].ToString() + "*" + parameters[w].utez);

                                    vmesni = vmesni + values[w + stevc] * parameters[w].utez;
                                    //narisi tocko

                                }

                            }

                            chartObcutljivosti.Series[alternative[i]].Points.AddXY(t, vmesni);
                           


                           
                           
                            


                            rezultati.Add(vmesni);
                            vmesni = 0;
                        }


                    }

                    //rezultati.Add(vmesni);




                }


                
                



                stevc =stevc+parameters.Count;
                vmesni = 0;
            }



        }

       
    }
}
