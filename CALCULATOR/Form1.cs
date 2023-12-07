using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR
{
    public partial class CALCULATOR : Form
    {
        //Fields
        Double result = 0;
        string operation = string.Empty;
        string fstNum, secNum;///utilite secnum ?
        bool enterValue = false;

        public CALCULATOR()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Cette methode permet de recevoir le type d'operation qu'on veut faire 
        /// et affiche donc la chaine de l'operation qu'on veut faire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMathOperation_Click(object sender, EventArgs e)
        {
            //Verifie s'il existe deja un resultat , si OUI il realise l'operation suivante avec cette derniere valeur de result
            //PerformClick() appelle directement la methode associé au boutton btnEquals qui est btnEquals_Click()
            if (result != 0) btnEquals.PerformClick();
            else result = Double.Parse(txtDisplay1.Text);//Result va etre la premiere valeur 
            Button button= (Button)sender;
            operation=button.Text;//Recois le text de l'operation(operatione en tant que tel)
            enterValue = true;//enterValue a true si on entre une premiere valeur
            //Verifie si le display main ne contient plus 0 (forcement ne contiendra si l'util saisi une premiere valeur
            if (txtDisplay1.Text != "0")
            {
                txtDisplay2.Text = fstNum=$"{result} {operation}";//fstNum et display operation recevront la valeur de result (premiere valeur) et l'OP.
                txtDisplay1.Text=string.Empty;//On met le display main a vide en attendant la valeur suivante
            }
        }
        /// <summary>
        /// Cette methode permet d'effectuer le calcul avec l'operateur choisi 
        /// et d'afficher le resultat apres appui du bouton '='
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEquals_Click(object sender, EventArgs e)
        {
            //secNum=txtDisplay1.Text;//utilite ?
            txtDisplay2.Text = $"{txtDisplay2.Text} {txtDisplay1.Text} =";//display op affiche l'operation complete 
            if (txtDisplay1.Text!=string.Empty)
            {
                if (txtDisplay1.Text == "0") txtDisplay2.Text = string.Empty;
                //Effectue l'operation et l'affiche selon le cas choisi
                switch (operation)
                {
                    case "+":
                        txtDisplay1.Text=(result+ Double.Parse(txtDisplay1.Text)).ToString();
                        break;
                    case "-":
                        txtDisplay1.Text=(result- Double.Parse(txtDisplay1.Text)).ToString();
                        break;
                    case "X":
                        txtDisplay1.Text = (result * Double.Parse(txtDisplay1.Text)).ToString();
                        break;
                    case "/"://Controler division by zero
                        if(!(Double.Parse(txtDisplay1.Text).ToString()=="0"))
                            txtDisplay1.Text = (result / Double.Parse(txtDisplay1.Text)).ToString();
                        else
                            txtDisplay1.Text = "0";
                             MessageBox.Show(
                                 string.Format("Impossible de diviser par zero revoyez vos leçons de Maths !"));
                        break;
                    default:txtDisplay2.Text = $"{txtDisplay1.Text} =";
                        break;
                }

                result=Double.Parse(txtDisplay1.Text);
                operation=string.Empty;
            }
        }
        /// <summary>
        /// Methode permettant d'effacer one by one les valeurs dans le display main (correction)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text.Length > 0)//Verification s'il existe des valeurs a effacer dans le display main 
                //Retrait d'une valeur en partant de la fin de la chaine(nombre) saisie
                txtDisplay1.Text=txtDisplay1.Text.Remove(txtDisplay1.Text.Length-1, 1);
            //Remettre display main a vide si display main est a 0
            if (txtDisplay2.Text == string.Empty && txtDisplay1.Text.Length < 0) txtDisplay1.Text = "0";
        }
        /// <summary>
        /// Cette methode permet de reinitialiser les valeurs i.e le result if exist 
        /// ainsi que l'operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay1.Text = "0";//Initialise le main Display a 0
            txtDisplay2.Text = string.Empty;//Vide le display operation 
            result = 0;//Initialise le resultat a 0
        }
        /// <summary>
        /// Cette methode remet le display main a 0 si on appui sur CE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay1.Text = "0";
        }
        /// <summary>
        /// Cette methode permet de convertir une valeur en nombre negatif apres l'appui du button
        /// "+/-" mais aussi de convertir une valeur en pourcentage apres l'appui du button "%"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSp_Click(object sender, EventArgs e)
        {
            Button button=(Button)sender;//Referencie le button "+/-"
            operation = button.Text;//Recuperation du text dans le bouton i.e "+/-"

            if (operation == "+/-")//Verifaction de l'entree
                //Conversion de la valeur en multipliant a cette derniere -1 
                txtDisplay1.Text = Convert.ToString(-1 * Convert.ToDouble(txtDisplay1.Text));
            else if (operation == "%")
                //Conversion de la valeur en pourcentage en la divisant par 100
                txtDisplay1.Text = Convert.ToString(Convert.ToDouble(txtDisplay1.Text) / 100);

        }
        /// <summary>
        /// Cette methode permet de quitter l'application apres avoir clique sur "X"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Cette methode permet de renvoyer la valeur saisie avec les buttons (0:9 && ".")
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNum_Click(object sender, EventArgs e)
        {
           //Entervalue sera vrai si on appui sur une operation (voir BtnMathOperation_Click())
          if(txtDisplay1.Text == "0" || enterValue) txtDisplay1.Text = string.Empty;
            enterValue = false;
            Button button=(Button)sender;//Instancie le boutton referencié
            if (button.Text==",")//Verification si on saisi "," pour un nombre decimal
            {
                //Verfie si la valeur n'est pas deja decimale
                if (!txtDisplay1.Text.Contains(","))
                    txtDisplay1.Text = txtDisplay1.Text + button.Text;//Alors on transforme cette valeur en decimal pour de bon
                
            }
              else txtDisplay1.Text = txtDisplay1.Text + button.Text;//Cas normal sans nombre decimal
        }
    }
}
