using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace ScoreboardEditorForStream
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButtonChecked(object sender, RoutedEventArgs e)
        {
            var button = sender as RadioButton;

            var path = ConfigurationManager.AppSettings["PeriodFile"].ToString();

            System.IO.File.WriteAllText(path, button.Content.ToString());

            Console.WriteLine($"text: {button.Content.ToString()}");
        }

        private void DisplayTeamOneScore(object sender, RoutedEventArgs e)
        {
            var path = ConfigurationManager.AppSettings["TeamOneScore"].ToString();

            TeamOneScoreDisplay.Text = System.IO.File.ReadAllText(path);
        }

        private void DisplayTeamTwoScore(object sender, RoutedEventArgs e)
        {
            var path = ConfigurationManager.AppSettings["TeamTwoScore"].ToString();

            TeamTwoScoreDisplay.Text = System.IO.File.ReadAllText(path);
        }

        private void DisplayTeamOneShots(object sender, RoutedEventArgs e)
        {
            var path = ConfigurationManager.AppSettings["TeamOneShots"].ToString();

            TeamOneShotsDisplay.Text = System.IO.File.ReadAllText(path);
        }

        private void DisplayTeamTwoShots(object sender, RoutedEventArgs e)
        {
            var path = ConfigurationManager.AppSettings["TeamTwoShots"].ToString();

            TeamTwoShotsDisplay.Text = System.IO.File.ReadAllText(path);
        }

        private void AddTeamOneScoreEvent(object sender, RoutedEventArgs e)
        {
            var path = ConfigurationManager.AppSettings["TeamOneScore"].ToString();
            var score = int.Parse(System.IO.File.ReadAllText(path));
            var uppedScore = ++score;

            System.IO.File.WriteAllText(path, uppedScore.ToString());

            DisplayTeamOneScore(sender, e);
        }

        private void AddTeamTwoScoreEvent(object sender, RoutedEventArgs e)
        {
            var path = ConfigurationManager.AppSettings["TeamTwoScore"].ToString();
            var score = int.Parse(System.IO.File.ReadAllText(path));
            var uppedScore = ++score;

            System.IO.File.WriteAllText(path, uppedScore.ToString());

            DisplayTeamTwoScore(sender, e);
        }

        private void AddTeamOneShotEvent(object sender, RoutedEventArgs e)
        {
            var path = ConfigurationManager.AppSettings["TeamOneShots"].ToString();
            var score = int.Parse(System.IO.File.ReadAllText(path));
            var uppedScore = ++score;

            System.IO.File.WriteAllText(path, uppedScore.ToString());

            DisplayTeamOneShots(sender, e);
        }

        private void AddTeamTwoShotEvent(object sender, RoutedEventArgs e)
        {
            var path = ConfigurationManager.AppSettings["TeamTwoShots"].ToString();
            var score = int.Parse(System.IO.File.ReadAllText(path));
            var uppedScore = ++score;

            System.IO.File.WriteAllText(path, uppedScore.ToString());

            DisplayTeamTwoShots(sender, e);
        }

        private void SubtractTeamOneScoreEvent(object sender, RoutedEventArgs e)
        {
            var path = ConfigurationManager.AppSettings["TeamOneScore"].ToString();
            var score = int.Parse(System.IO.File.ReadAllText(path));
            var uppedScore = --score;

            System.IO.File.WriteAllText(path, uppedScore.ToString());

            DisplayTeamOneScore(sender, e);
        }            
                     
        private void SubtractTeamTwoScoreEvent(object sender, RoutedEventArgs e)
        {
            var path = ConfigurationManager.AppSettings["TeamTwoScore"].ToString();
            var score = int.Parse(System.IO.File.ReadAllText(path));
            var uppedScore = --score;

            System.IO.File.WriteAllText(path, uppedScore.ToString());

            DisplayTeamTwoScore(sender, e);
        }            
                     
        private void SubtractTeamOneShotEvent(object sender, RoutedEventArgs e)
        {
            var path = ConfigurationManager.AppSettings["TeamOneShots"].ToString();
            var score = int.Parse(System.IO.File.ReadAllText(path));
            var uppedScore = --score;

            System.IO.File.WriteAllText(path, uppedScore.ToString());

            DisplayTeamOneShots(sender, e);
        }            
                     
        private void SubtractTeamTwoShotEvent(object sender, RoutedEventArgs e)
        {
            var path = ConfigurationManager.AppSettings["TeamTwoShots"].ToString();
            var score = int.Parse(System.IO.File.ReadAllText(path));
            var uppedScore = --score;

            System.IO.File.WriteAllText(path, uppedScore.ToString());

            DisplayTeamTwoShots(sender, e);
        }

    }
}
