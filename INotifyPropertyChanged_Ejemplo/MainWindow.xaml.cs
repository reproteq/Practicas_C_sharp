﻿using System;
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

namespace INotifyPropertyChanged_Ejemplo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //miJuntaNom = new JuntaNom { Nom = "Alia", Ape = "Gregori Peinado" };
            miJuntaNom = new JuntaNom {};

            this.DataContext = miJuntaNom;
        }


       public JuntaNom miJuntaNom;
    }




}
