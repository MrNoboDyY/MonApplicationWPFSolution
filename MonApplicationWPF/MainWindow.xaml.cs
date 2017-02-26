using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MonApplicationWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>


        /*Un Class "MainWindow" dérivant d'une class "Window" 
         appartenant au NameSpace "MonApplicationWPF"*/
    public partial class MainWindow : Window
    {
        delegate void MonPremierDelegate(string str);//"MonPremierDelegate" est un Type

        //"event" evenement personalisé + methode de type MonPremierDelegate + nom evenement
        event MonPremierDelegate MonPremierEvenement;

        Button monSecondButton;

        /*constructeur pour la fenêtre */
        public MainWindow()
        {
            /*methode heritée de la class "Window" nous permettant d'initialiser 
             tous les composants graphique de la class "MainWindow" */
            InitializeComponent();
            monSecondButton = new Button();
            monSecondButton.Content = "ceci est mon deuxieme bouton";
            monSecondButton.Click += MonSecondBouton_Click;

            MonPremierStackPanel.Children.Add(monSecondButton);


            //association de la methode "CeciEstUneMethode" à celle "MonPremierEvenement"
            MonPremierEvenement += CeciEstUneMethode;

            ///////////////////////////////////////////////////////////////////////////////////////
            //expression Lambda == methode CeciEstUneMethode
            MonPremierEvenement += (str) =>
            {
                MonPremierLabel.Content = str;
            };
            /////////////////////////////////////////////////////////////////////////////////////////
        }

        private void MonPremierBouton_Click(object sender, RoutedEventArgs e)
        {
            //MonPremierLabel.Content = DateTime.Now;

            //déclanchement de l'evenement par appel,comme pour une méthode !!!
            MonPremierEvenement("premier bouton");
        }

        private void MonSecondBouton_Click(object sender, RoutedEventArgs e)
        {
            //MonPremierLabel.Content = DateTime.Now.Second;

            //déclanchement de l'evenement par appel,comme pour une méthode !!!
            MonPremierEvenement("deuxieme bouton");
        }

        private void CeciEstUneMethode(string str)//une chaine de caractere en parametre et ne renvoyant rien(void) !!
        {
            //modification lors du Clic du contenu de MonPremierLabel avec la valeur du string/str 
            //même signature que "MonPremierDelegate(string str)"
            MonPremierLabel.Content = str;
        }
    }
}
