using DrawITApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class Palette : Window
    {
        public RGB mycolor { get; set; }
        public Color setcolor { get; set; } = (Color)ColorConverter.ConvertFromString("#FF000000");

        /// <summary>
        /// Code behind de la palette de couleur, utilise la classe RGB qui nous permet de faire plus simplement les couleurs
        /// </summary>
        public Palette()
        {
            InitializeComponent();
            mycolor = new RGB(0, 0, 0);
            button_valider.Background = new SolidColorBrush(Color.FromRgb(mycolor.red, mycolor.green, mycolor.blue)); //marker showing the current color           
        }

        /// <summary>
        /// Methode qui permet de set une couleur RGB grace a des sliders
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sld_Color_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            string sliderName = slider.Name;
            double sliderValue = slider.Value;
            switch (sliderName)
            {
                case "sld_RedColor":
                    mycolor.red = Convert.ToByte(sliderValue); //Pour chacun des trois sliders on recupere la value en byte dans le R, le G et le B
                    break;
                case "sld_GreenColor":
                    mycolor.green = Convert.ToByte(sliderValue);
                    break;
                case "sld_BlueColor":
                    mycolor.blue = Convert.ToByte(sliderValue);
                    break;
            }

            button_valider.Background = new SolidColorBrush(Color.FromRgb(mycolor.red, mycolor.green, mycolor.blue));

        }

        /// <summary>
        /// Au click sur le bouton, methode qui va sauvegarder le choix de couleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        void validerCouleur(object sender, RoutedEventArgs e)
        {
            setcolor = Color.FromRgb(mycolor.red, mycolor.green, mycolor.blue);
        }


        /// <summary>
        /// Methode qui modifie la fermeture de la fenetre : elle disparait sans être stoppée
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            e.Cancel = true;
        }

    }
}
