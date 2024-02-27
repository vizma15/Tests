using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mans_tests
{
    public partial class Form2 : Form
    {
        string[] jautajumi = new string[] {
            "KĀDĀ KRĀSĀ IR TAVI MATI?",
            "CIK GARŠ TU ESI?",
            "KĀDS IR TAVS HOBIJS?",
            "TU TIECIES PĒC ...",
            "NO ŠEIT PIEMINĒTAJIEM LAIKA PAVADĪŠANAS VEIDIEM TU LABPRĀTĀK ...",
            "KĀDA IR TAVA SAPŅU PROFESIJA?",
            "KAS IR TAVA MĪĻĀKĀ VIETA?",
            "KURŠ NO ŠIEM ĒDIENIEM IR TAVS MĪĻĀKAIS?",
            "KURŠ NO ŠIEM AUTORIEM TEV PATĪK VISLABĀK?",
            "UN, VISBEIDZOT, KAS IR TAVS MĪĻĀKAIS DZĪVNIEKS?",
        };
        string[] atbildes1 = new string[] {
            "Melnā",
            "Garš",
            "Komandas sporti",
            "Ģimenes",
            "Spēlētu galda spēles",
            "Policists / Detektīvs",
            "Skola",
            "Pīrāgs",
            "Dž. K. Roulinga",
            "Pūce",
        };
        string[] atbildes2 = new string[] {
            "Brūnā",
            "Vidēji garš",
            "Loka šaušana",
            "Miera",
            "Dotos medībās",
            "Mednieks",
            "Mežs",
            "Sautējums",
            "Sūzena Kolinsa",
            "Dziedātājputns",
        };
        string[] atbildes3 = new string[] {
            "Sarkanā",
            "Īss",
            "Lasīšana",
            "Skaistuma",
            "Taisītu kūku",
            "Rakstnieks",
            "Pļava",
            "Torte",
            "Lūsija Moda Montgomerija",
            "Kaķis",
        };
        string[] atbildes4 = new string[] {
            "Baltā",
            "Ļoti garš",
            "Laika pavadīšana ar draugiem",
            "Piedzīvojuma",
            "Peldētos",
            "Pētnieks",
            "Pludmale",
            "Banāni",
            "Tūve Jansone",
            "Pūķītis",
};

        int piemeri = 0;
        public static int pirma = 0;
        public static int otra = 0;
        public static int tresa = 0;
        public static int ceturta = 0;


        public Form2()
        {
            InitializeComponent();
        }




        private void jautajums_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            jautajums.Text = jautajumi[piemeri];
            butAtbilde1.Text = atbildes1[piemeri];
            butAtbilde2.Text = atbildes2[piemeri];
            butAtbilde3.Text = atbildes3[piemeri];
            butAtbilde4.Text = atbildes4[piemeri];
        }

        private void butAtbilde1_Click(object sender, EventArgs e)
        {
            piemeri++;
            pirma++;
            if (piemeri < 10)
            {
                jautajums.Text = jautajumi[piemeri];
                butAtbilde1.Text = atbildes1[piemeri];
                butAtbilde2.Text = atbildes2[piemeri];
                butAtbilde3.Text = atbildes3[piemeri];
                butAtbilde4.Text = atbildes4[piemeri];
                labPiemers.Text = (piemeri + 1) + ". no 10. jautājumiem";
            }
            else
            {
                this.Hide();
                Form3 rezultats = new Form3();
                rezultats.Show();
            }
        }

        private void butAtbilde2_Click(object sender, EventArgs e)
        {
            piemeri++;
            otra++;
            if (piemeri < 10)
            {
                jautajums.Text = jautajumi[piemeri];
                butAtbilde1.Text = atbildes1[piemeri];
                butAtbilde2.Text = atbildes2[piemeri];
                butAtbilde3.Text = atbildes3[piemeri];
                butAtbilde4.Text = atbildes4[piemeri];
                labPiemers.Text = (piemeri + 1) + ". no 10. jautājumiem";
            }
            else
            {
                this.Hide();
                Form3 rezultats = new Form3();
                rezultats.Show();
            }
        }

        private void butAtbilde3_Click(object sender, EventArgs e)
        {
            piemeri++;
            tresa++;
            if (piemeri < 10)
            {
                jautajums.Text = jautajumi[piemeri];
                butAtbilde1.Text = atbildes1[piemeri];
                butAtbilde2.Text = atbildes2[piemeri];
                butAtbilde3.Text = atbildes3[piemeri];
                butAtbilde4.Text = atbildes4[piemeri];
                labPiemers.Text = (piemeri + 1) + ". no 10. jautājumiem";
            }
            else
            {
                this.Hide();
                Form3 rezultats = new Form3();
                rezultats.Show();
            }
        }

        private void butAtbilde4_Click(object sender, EventArgs e)
        {
            piemeri++;
            ceturta++;
            if (piemeri < 10)
            {
                jautajums.Text = jautajumi[piemeri];
                butAtbilde1.Text = atbildes1[piemeri];
                butAtbilde2.Text = atbildes2[piemeri];
                butAtbilde3.Text = atbildes3[piemeri];
                butAtbilde4.Text = atbildes4[piemeri];
                labPiemers.Text = (piemeri + 1) + ". no 10. jautājumiem";
            }
            else
            {
                this.Hide();
                Form3 rezultats = new Form3();
                rezultats.Show();
            }
        }
    }
}
