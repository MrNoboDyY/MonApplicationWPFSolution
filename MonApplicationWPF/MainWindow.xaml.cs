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

        /*constructeur pour la fenêtre */
        public MainWindow()
        {
            /*methode heritée de la class "Window" nous permettant d'initialiser 
             tous les composants graphique de la class "MainWindow" */
            InitializeComponent();
            MonPremierLabel.Content = "contenu modifier";
            MonSecondLabel.Content = "Contenu Modifié une second fois";
        }
    }
}
