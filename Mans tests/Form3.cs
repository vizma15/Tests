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
    public partial class Form3 : Form
    {

        int pirma2;
        int otra2;
        int tresa2;
        int ceturta2;

        public Form3()
        {
            InitializeComponent();
            pirma2 = Form2.pirma;
            otra2 = Form2.otra;
            tresa2 = Form2.tresa;
            ceturta2 = Form2.ceturta;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int maxCounterValue = Math.Max(Math.Max(pirma2, otra2), Math.Max(tresa2, ceturta2));

            if (pirma2 == maxCounterValue)
            {
                label2.Text = "Tu esi vislīdzīgais/ā HARIJAM POTERAM!\nTev diezgan labi padodas skola, bet tu labprātāk pavadi laiku spēlējot galda spēles un lidojot uz slotas 🪄\nHarijs Poters, grāmatu sērijas (Dž.K Roulinga)";
            }
            if (otra2 == maxCounterValue)
            {
                label2.Text = "Tu esi vislīdzīgais/ā KATNISAI EVERDĪNAI\nTu esi brīvs un aktīvs cilvēks, taču tu arī augsti vērtē mieru. Brīvajā laikā tu ej pastaigās pa mežu un izbaudi klusumu 🏹\nBada spēles, triloģija (Sūzena Kolinsa)";
            }
            if (tresa2 == maxCounterValue)
            {
                label2.Text = "Tu esi vislīdzīgais/ā ANNAI NO ZAĻAJIEM JUMTIEM!\nTu esi ļoti patīkams cilvēks ar plašu iztēli. Esi čakls un tas ir labi pamanāms skolā un dzīvē 🌼\nAnna no Zaļajiem Jumtiem, grāmatu sērijas(L. M. Montgomerija)";
            }
            if (ceturta2 == maxCounterValue)
            {
                label2.Text = "Tu esi vislīdzīgais/ā MUMINTROLLIM!\nTu esi piedzīvojumu meklētājs, tev patīk jautri pavadīt laiku ar draugiem. Ļoti iespējams tev arī ļoti patīk gulēt (Mumintroļļi guļ ziemas miegu ;)) 🌊\nMumini, grāmatu sērijas(Tūve Jansone)";
            }
        }
    }
}
