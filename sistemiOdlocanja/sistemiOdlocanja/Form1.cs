using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Dynamic;
using System.Linq.Dynamic;
using System.Reflection;

namespace sistemiOdlocanja
{
    public partial class Form1 : Form
    {
        int stevecAlternative = 1;
        int leftControl = 1;

        public List<string> alternative = new List<string>();
        public List<TextBox> textBoxesAlterantive = new List<TextBox>();
        public List<int> values = new List<int>();
        public List<Parameter> parameters = new List<Parameter>();
        public List<int> rezultati2 = new List<int>();

        public List<int> urejen2 = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox parametri = new TextBox();
            TextBox utez = new TextBox();
            Label napis = new Label();
            Label napisUtezi = new Label();
            this.Controls.Add(parametri);
            this.Controls.Add(napis);
            this.Controls.Add(utez);
            this.Controls.Add(napisUtezi);

            parametri.Top = leftControl * 40;
            napis.Top = parametri.Top - 15;
            utez.Top = parametri.Top;
            napisUtezi.Top = parametri.Top - 15;

            napis.Left = 50;
            parametri.Left = 50;
            utez.Left = parametri.Left + 110;
            napisUtezi.Left = parametri.Left + 110;

            utez.Width = 40;


            napisUtezi.Text = "Utež " + this.leftControl.ToString() + ": ";
            napis.Text = "Parameter: " + this.leftControl.ToString();
            parametri.Name = "paramater" + this.leftControl.ToString();
            leftControl = leftControl + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox dodajAlternativotxb = new TextBox();
            Label napisAlternative = new Label();
            this.Controls.Add(dodajAlternativotxb);
            this.Controls.Add(napisAlternative);
            dodajAlternativotxb.Width = 80;
            if (stevecAlternative == 1)
            {
                dodajAlternativotxb.Left = 300;
                napisAlternative.Left = 300;
                dodajAlternativotxb.Top = 40;
                napisAlternative.Top = dodajAlternativotxb.Top - 15;
            }
            else
            {

                dodajAlternativotxb.Left = stevecAlternative * 200;
                napisAlternative.Left = stevecAlternative * 200;
                dodajAlternativotxb.Top = 40;
                napisAlternative.Top = dodajAlternativotxb.Top - 15;
            }


            napisAlternative.Text = "Alternativa " + this.stevecAlternative.ToString() + ": ";
            napisAlternative.Name = "Alternativa" + this.stevecAlternative.ToString();
            dodajAlternativotxb.Name = "Alternativa" + this.stevecAlternative.ToString();
            stevecAlternative += 1;







        }





        private void DodajPoljabtn_Click(object sender, EventArgs e)
        {
            //dodat textboxe za vnsanje stevilk //hitrost1//ravnotezje2
            //





            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    TextBox txt = (TextBox)Controls[i];
                    if (txt.Name.Contains("Alternativa"))
                    {
                        alternative.Add(txt.Text);
                        textBoxesAlterantive.Add(txt);
                    }
                    if (txt.Name.Contains("paramater"))
                    {
                        parameters.Add(new Parameter() { paramter = txt.Text, utez = Convert.ToInt32(Controls[i + 2].Text) });
                    }
                }
            }


            var top = 0;
            var left = 0;
            var stevec = 1;


            for (int i = 0; i < textBoxesAlterantive.Count; i++) //get by name and then by get position and reapet for parameter
            {
                top = textBoxesAlterantive[i].Top;
                left = textBoxesAlterantive[i].Left;


                foreach (var item in parameters)//prekrivajo se 
                {
                    TextBox textBox = new TextBox();
                    textBox.Width = 80;
                    this.Controls.Add(textBox);
                    textBox.Top = top + 40;//tukaj
                    top = textBox.Top;
                    textBox.Left = left;//tukaj
                    left = textBox.Left;
                    textBox.Name = "parameter" + stevec;
                    //textBox.Text = item.paramter+stevec +"/ "+textBox.Name;//ze tu lahko urejas id posametne laternative pa to

                    stevec++;

                }

            }
        }


        private void button3_Click(object sender, EventArgs e)
        {

            var stevec = 1;
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    TextBox txt = (TextBox)Controls[i];

                    foreach (var item in parameters)
                    {
                        if (txt.Name == ("parameter" + stevec).ToString())
                        {
                            values.Add(Convert.ToInt32(txt.Text));//tukaj je problem
                            //terba se sklicovat na ime plus stevilka da lahko dodas values le tak bo edinstveno!!!
                            //TODO
                            stevec++;
                        }
                    }


                }
            }


            //KT metoda

            List<int> urejen = values.ToList();//se treba urediti //ok
            var stevc = 0;
            List<int> rezultati = new List<int>();
            int vmesni = 0;
            for (int i = 0; i < alternative.Count(); i++)
            {
                for (int z = 0; z < parameters.Count; z++)
                {

                    //MessageBox.Show(urejen[z+stevc].ToString() + "*" + parameters[z].utez);//urejeni nekak mores z povecat

                    vmesni = vmesni + (urejen[z + stevc] * parameters[z].utez);
                }

                stevc = stevc+parameters.Count;
                rezultati.Add(vmesni);
                vmesni = 0;//negre na naslednji stolpec
            }


            //pokazat najboljso alternativo

            var indeks = rezultati.Max();
            var indeks2 = 0;
            for (int i = 0; i < rezultati.Count; i++)
            {
                if (rezultati[i] == indeks)
                {
                    indeks2 = i;
                }
            }

            var imeAlt = "";
            for (int i = 0; i < alternative.Count; i++)
            {
                if (i == indeks2)
                {
                    imeAlt = alternative[i];
                }
            }



            MessageBox.Show("Najboljsa alternativa je " + imeAlt + " in sicer: " + indeks);
            rezultati2 = rezultati;
            urejen2 = urejen;
            NavadniGrafi grafi = new NavadniGrafi(urejen, alternative, parameters, rezultati);
            grafi.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            //občutljivost
            

            var indeks = 0;//po katerem paramtertu gledamo
            List<int> vmesnevrednosti = new List<int>();
            List<int> vmesnevrednosti2 = new List<int>();
            int vmesni = 0;
            List<int> rezultati = new List<int>();
            var stevc = 0;
            for (int i = 0; i < alternative.Count; i++)
            {
                for (int z = 0; z < parameters.Count; z++)
                {



                    if (z==indeks)
                    {

                        for (int t = 1; t <=10; t++)
                        {
                           // MessageBox.Show(values[z+stevc].ToString() + "*" + t.ToString());


                            vmesni = vmesni + values[z + stevc] * t;


                            //sestevanje 

                            for (int w = 0; w < parameters.Count; w++)
                            {
                                if (w==indeks)
                                {
                                    continue;
                                }
                                else
                                {

                                    //MessageBox.Show(values[w+stevc].ToString() + "*" + parameters[w].utez);

                                    vmesni = vmesni + values[w + stevc] * parameters[w].utez;


                                }
                                
                            }


                            rezultati.Add(vmesni);
                            vmesni = 0;
                        }


                    }

                    //rezultati.Add(vmesni);




                }


                stevc = +parameters.Count;
                vmesni = 0;
            }


          
           //Ok dela zdaj 

            //stevilo alternativ 3*10=30 ce imas 3 alternative





            //TODO grafi

           
            if (obcutljivosttextbox.Text!=string.Empty)
            {
                int vrednostObcutljivosti = Convert.ToInt32(obcutljivosttextbox.Text);
                ObcutljivostForm form = new ObcutljivostForm(urejen2, alternative, parameters, rezultati2, vrednostObcutljivosti);
                form.Show();
            }
            else
            {
                MessageBox.Show("Napaka!");
            }

           










        }

        private void pomocbtn_Click(object sender, EventArgs e)
        {
            pomocform pomocform = new pomocform();
            pomocform.ShowDialog();
        }
    }
}
