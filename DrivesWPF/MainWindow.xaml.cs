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
using System.IO;

namespace DrivesWPF
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            string strDriveInfo = "";

            foreach (DriveInfo driveInfo in allDrives)
            {
                strDriveInfo += "Drive " + driveInfo.Name + "\n";
                strDriveInfo += "  Drive type: " + driveInfo.DriveType +"\n";
                if (driveInfo.IsReady == true)
                {
                    strDriveInfo += "  Volume label: " + driveInfo.VolumeLabel + "\n";
                    strDriveInfo += "  File system: " + driveInfo.DriveFormat + "\n";
                    strDriveInfo += "  Available space to current user: " + driveInfo.AvailableFreeSpace + " Bytes\n";
                    strDriveInfo += "  Total available space:  " + driveInfo.TotalFreeSpace + " Bytes\n";
                    strDriveInfo += "  Total size of drive:   "  + driveInfo.TotalSize + " Bytes\n";
                }
            }

            txtDriveInfo.Text = strDriveInfo;
        }
    }
}
