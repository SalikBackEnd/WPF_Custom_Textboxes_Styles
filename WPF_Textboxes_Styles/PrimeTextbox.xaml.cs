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

namespace WPF_Textboxes_Styles
{
    /// <summary>
    /// Interaction logic for PrimeTextbox.xaml
    /// </summary>
    public partial class PrimeTextbox : UserControl
    {


        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(PrimeTextbox), new PropertyMetadata("Label"));

        public string Label { get => (string)GetValue(LabelProperty); set => SetValue(LabelProperty, value); }
        
        public static readonly DependencyProperty ForegroundProperty =
            DependencyProperty.Register("LabelColor", typeof(SolidColorBrush), typeof(PrimeTextbox), new PropertyMetadata((SolidColorBrush)new BrushConverter().ConvertFrom("#0000")));

        public SolidColorBrush LabelColor { get => (SolidColorBrush)GetValue(ForegroundProperty); set => SetValue(ForegroundProperty, value); }
        

        public PrimeTextbox()
        {
            InitializeComponent();
            DataContext = this;
           
        }
    }
}
