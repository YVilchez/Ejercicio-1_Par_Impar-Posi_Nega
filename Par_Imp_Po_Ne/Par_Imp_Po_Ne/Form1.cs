using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Par_Imp_Po_Ne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_comp_info_Click(object sender, EventArgs e)
        {
            //Declarar variable del numero ha ingresar

            int Numero = int.Parse(TB_IngresoNu.Text);

            //LLAMAR FUNSION PAR O IMPAR
            ParImp(Numero);

            //LLAMAR FUNSION DE POSITIVO O NEGATIVO 
            PosiNega(Numero);
        }

        //FUNSION DE PAR O IMPAR
        private void ParImp(int Numero)
        {
            if (Numero % 2 == 0)
            {
                TB_par_imp.Text = "  PAR";
            }
            else
            {
                TB_par_imp.Text = "  IMPAR";
            }

        }
        //FUNSION DE POSITIVO O NEGATIVO
        private void PosiNega(int Numero)
        {
            if (Numero > 0)
            {
                TBsigno.Text = " POSITIVO";
                
            }
           else if(Numero < 0)
            {
                TBsigno.Text = " NEGATIVO";
            }
        }


        private void TB_par_imp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
