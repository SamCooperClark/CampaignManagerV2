using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CampaignManangerV2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Closed += new EventHandler(MainWindow_Closed);
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
        void MainWindow_Closed(object sender, EventArgs e)
        {
            if (notesTabView.Text != "")
            {
                var fileName = DateTime.Now.ToString("yyyy/MM/dd/HH/mm/ss");
                var noteData = notesTabView.Text;
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                using (StreamWriter outputFile = new StreamWriter(System.IO.Path.Combine(docPath, fileName + ".txt")))
                {
                    outputFile.WriteLine(noteData);
                }
            }
        }
    }
}
