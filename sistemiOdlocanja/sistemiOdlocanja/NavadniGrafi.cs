using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemiOdlocanja
{
    public partial class NavadniGrafi : Form
    {
        public NavadniGrafi(List<int> values, List<string> alternative, List<Parameter> parameters, List<int> rezultati)
        {
            InitializeComponent();
            VrednostiAlternativ.Titles.Add("Vrednosti alternativ:");
            for (int i = 0; i < alternative.Count; i++)
            {
                VrednostiAlternativ.Series["chartAlterniv"].Points.AddXY(alternative[i],rezultati[i]); //se treba neke popravit lol
            }

            VrednostiUtezi.Titles.Add("Vrednosti utezi: ");
            for (int i = 0; i < parameters.Count; i++)
            {
                VrednostiUtezi.Series["vrednostUtezi"].Points.AddXY(parameters[i].paramter, parameters[i].utez);
            }


        }
    }
}
