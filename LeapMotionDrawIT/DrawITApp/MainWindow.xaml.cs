using Leap;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1;
using Frame = Leap.Frame;

namespace DrawITApp
{


    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String ChaineInfo = "Cliquez sur Start pour dessiner \nUtilisez votre paume de main droite pour dessiner,\nsi vous mettez les deux mains la largeur du trait sera augmenté !\nLa couleur du trait se change avec la souris. ";
        private TextBlock info = new TextBlock();
        Leap.Controller controller = new Leap.Controller();
        private bool lancer = false;
        private double tailleX;
        private double tailleY;
        Palette p = new Palette();
        private Color laCouleur;

        /// <summary>
        /// A la creation de la fenetre, on set la phrase d'info
        /// on set l'evenement getXYZValues
        /// </summary>

        public MainWindow()
        {

            info.Text = ChaineInfo;
            info.FontSize = 25;
            InitializeComponent();
            controller.EventContext = WindowsFormsSynchronizationContext.Current;
            controller.FrameReady += getXYZValues;

            zone.Children.Add(info);

        }

        /// <summary>
        /// methode qui intercepte l'evenement lancé chaque frame par leapMotion
        /// Elle recupere les positions des paumes de main et appelle une methode pour dessiner sur le canva "zone"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>

        private void getXYZValues(object sender, FrameEventArgs eventArgs)
        {

            if (lancer)
            {
                Frame frame = eventArgs.frame;

                for (int h = 0; h < frame.Hands.Count; h++)
                {

                    Hand leapHand = frame.Hands[0];

                    Leap.Vector currentPositionPalm = leapHand.PalmPosition;




                    if (frame.Hands.Count == 2)
                    {
                        Hand leapHandPannel = frame.Hands[1];

                        Leap.Vector currentPositionPalm2 = leapHandPannel.PalmPosition;


                        if (frame.Hands.Count == 2)
                        {
                            textBox1.Text = "Trait épais";
                            textBox1.FontSize = 20;
                            textBox1.FontWeight = FontWeights.Bold;
                            afficherForme((int)currentPositionPalm2.x, -(int)currentPositionPalm2.y, "moyen");
                        }

                    }
                    else
                    {
                        textBox1.Text = "Trait fin";
                        textBox1.FontSize = 20;
                        textBox1.FontWeight = FontWeights.Regular;
                        afficherForme((int)currentPositionPalm.x, -(int)currentPositionPalm.y, "simple");
                    }
                }
            }


        }

        /// <summary>
        /// methode qui intercepte l'evenement de click sur le bouton Start
        /// permet d'activer le leap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_Leap(object sender, RoutedEventArgs e)
        {
            zone.Children.Remove(info);
            controller.StartConnection();
            lancer = true;
            button_start.IsEnabled = false;
            button_stop.IsEnabled = true;
        }

        /// <summary>
        /// methode qui intercepte l'evenement de click sur le bouton Stop
        /// permet de désactiver le leap et d'afficher de nouveau la page d'aide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void stop_Leap(object sender, RoutedEventArgs e)
        {

            controller.StopConnection();
            lancer = false;
            button_start.IsEnabled = true;
            button_stop.IsEnabled = false;
            info.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            if (!zone.Children.Contains(info))
            {
                zone.Children.Add(info);
            }
            
        }

        /// <summary>
        /// methode qui intercepte l'evenement de click sur le bouton Effacer
        /// nettoie tout le canvas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void clear_Leap(object sender, RoutedEventArgs e)
        {
            zone.Children.Clear();
        }

        /// <summary>
        /// methode qui affiche la palette de couleur au click sur Couleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void color_Leap(object sender, RoutedEventArgs e)
        {
            p.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// methode appelée par GetXYZValues
        /// permet en fonction des coordonnées et du mode, d'afficher des lignes qui simulent des points pour dessiner
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="mode"></param>

        private void afficherForme(int x, int y, String mode)
        {
            tailleX = ActualWidth;
            tailleY = ActualHeight;
            laCouleur = p.setcolor;
            textBox2.Background = new SolidColorBrush(laCouleur); //on recupere la couleur choisit sur la palette


            if (mode == "simple") //mode qui écrit fin
            {
                var line1 = new Line(); //on crée une ligne
                line1.Stroke = new SolidColorBrush(laCouleur); //on lui applique la bonne couleur
                line1.X1 = x + tailleX * 0.5; // --- ici on va "transormer" la ligne en point et lui appliquer un ratio pour calibrer le dessin au milieu du canvas
                line1.X2 = x + tailleX * 0.5 + 2;
                line1.Y1 = y + tailleY*0.9 ;
                line1.Y2 = y + tailleY*0.9 + 2; // ---
                zone.ClipToBounds = true; //permet de ne pas "deborder" en dehors du canvas
                line1.StrokeThickness = 3;

                zone.Children.Add(line1);
            }

            if (mode == "moyen") //mode qui ecrit gras
            {
                
                var line2 = new Line(); //idem meme principe
                line2.Stroke = new SolidColorBrush(laCouleur);
                line2.X1 = x + tailleX * 0.5;
                line2.X2 = x + tailleX * 0.5 + 2;
                line2.Y1 = y + tailleY*0.9;
                line2.Y2 = y + tailleY*0.9 + 2;
                line2.StrokeThickness = 9; //on crée juste une ligne plus epaisse
                zone.ClipToBounds = true;
                zone.Children.Add(line2);

            }


        }


        /// <summary>
        /// methode appelée au click sur Sauvegarder image
        /// permet d'enregistrer le canvas en 3 formats différents
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_Leap(object sender, RoutedEventArgs e)
        {
            zone.Children.Remove(info); //permet de ne pas enregistrer la phrase d'information lors de la sauvegarde
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Png Image| *.png"; //permet de sauvegarder dans  3 formats
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog(); //ouvre la boite de dialogue



            if (saveFileDialog1.FileName != "")
            {


                RenderTargetBitmap rtb = new RenderTargetBitmap((int)zone.RenderSize.Width, //converti les objets en bitmap
                (int)zone.RenderSize.Height, 92d, 92d, System.Windows.Media.PixelFormats.Default);
                rtb.Render(zone);

                var crop = new CroppedBitmap(rtb, new Int32Rect(0, 0, (int)zone.RenderSize.Width, (int)zone.RenderSize.Height));

                BitmapEncoder pngEncoder = new PngBitmapEncoder();
                pngEncoder.Frames.Add(BitmapFrame.Create(crop));

                using (var fs = (System.IO.FileStream)saveFileDialog1.OpenFile())
                {
                    pngEncoder.Save(fs);
                    System.Windows.MessageBox.Show("Image sauvegardée ", "DrawITApp", MessageBoxButton.OK, MessageBoxImage.Information);
                }


            }

            zone.Children.Add(info);

        }


        /// <summary>
        /// methode appelée au click sur Importer image
        /// permet d'importer n'importe quelle image sur le canvas de dessin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void import_Leap(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.ShowDialog(); //ouvre la boite de dialogue pour choisir un fichier
            fileOpen.Title = "Open Image file";
            fileOpen.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Png Image| *.png"; //autorise 3 types de fichiers

            System.Windows.Controls.Image myImage = new System.Windows.Controls.Image();
            myImage.Source =  new BitmapImage(new Uri(fileOpen.FileName,UriKind.RelativeOrAbsolute)); //importe l'image sous forme de bitmap
           

            zone.Children.Add(myImage);//ajoute l'image au canvas
        }
    }
}
    

