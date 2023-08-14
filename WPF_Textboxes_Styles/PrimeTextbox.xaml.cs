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

        public new static readonly DependencyProperty FontFamilyProperty =
            DependencyProperty.Register("FontFamily", typeof(string), typeof(PrimeTextbox), new PropertyMetadata("Arial"));

        public new static readonly DependencyProperty FontWeightProperty =
           DependencyProperty.Register("FontWeight", typeof(string), typeof(PrimeTextbox), new PropertyMetadata("Normal"));

        public new static readonly DependencyProperty LabelForegroundProperty =
            DependencyProperty.Register("LabelForeground", typeof(SolidColorBrush), typeof(PrimeTextbox), new PropertyMetadata((SolidColorBrush)new BrushConverter().ConvertFrom("#1C2833")));
        
        public new static readonly DependencyProperty BackgroundProperty =
            DependencyProperty.Register("Background", typeof(SolidColorBrush), typeof(PrimeTextbox), new PropertyMetadata((SolidColorBrush)new BrushConverter().ConvertFrom("#ffffff")));
        
        public new static readonly DependencyProperty BorderBrushProperty =
            DependencyProperty.Register("BorderBrush", typeof(SolidColorBrush), typeof(PrimeTextbox), new PropertyMetadata((SolidColorBrush)new BrushConverter().ConvertFrom("#808B96")));

        public static readonly DependencyProperty TextForegroundProperty =
            DependencyProperty.Register("TextForeground", typeof(SolidColorBrush), typeof(PrimeTextbox), new PropertyMetadata((SolidColorBrush)new BrushConverter().ConvertFrom("#1C2833")));

        public new static readonly DependencyProperty BorderThicknessProperty =
            DependencyProperty.Register("BorderThickness", typeof(Thickness), typeof(PrimeTextbox), new PropertyMetadata(new Thickness(1,1,1,1)));

        public static readonly DependencyProperty IsReadOnlyProperty =
            DependencyProperty.Register("IsReadOnly", typeof(bool), typeof(PrimeTextbox), new PropertyMetadata(false));

        public new static readonly DependencyProperty IsEnabledProperty =
            DependencyProperty.Register("IsEnabled", typeof(bool), typeof(PrimeTextbox), new PropertyMetadata(true));

        public new static readonly DependencyProperty FontSizeProperty =
            DependencyProperty.Register("FontSize", typeof(string), typeof(PrimeTextbox), new PropertyMetadata("12"));
        
        public new static readonly DependencyProperty TextAlignmentProperty =
            DependencyProperty.Register("TextAlignment", typeof(TextAlignment), typeof(PrimeTextbox), new PropertyMetadata(TextAlignment.Left));


        public string Label { 
            get => (string)GetValue(LabelProperty); 
            set => SetValue(LabelProperty, value);
        }
        
        public  SolidColorBrush LabelForeground { 
            get => (SolidColorBrush)GetValue(LabelForegroundProperty);
            set => SetValue(LabelForegroundProperty, value); 
        }

        public new SolidColorBrush Background { 
            get => (SolidColorBrush)GetValue(BackgroundProperty);
            set => SetValue(BackgroundProperty, value); 
        }
        
        public new string FontSize
        {
            get => (string)GetValue(FontSizeProperty);
            set => SetValue(FontSizeProperty, value);
        }

        public new string FontFamily
        {
            get => (string)GetValue(FontFamilyProperty);
            set => SetValue(FontFamilyProperty, value);
        }

        public new string FontWeight
        {
            get => (string)GetValue(FontWeightProperty);
            set => SetValue(FontWeightProperty, value);
        }
        public new SolidColorBrush BorderBrush
        {
            get => (SolidColorBrush)GetValue(BorderBrushProperty);
            set => SetValue(BorderBrushProperty, value);
        }

        public new Thickness BorderThickness
        {
            get => (Thickness)GetValue(BorderThicknessProperty);
            set => SetValue(BorderThicknessProperty, value);
        }

        public bool IsReadOnly
        {
            get => (bool)GetValue(IsReadOnlyProperty);
            set => SetValue(IsReadOnlyProperty, value);
        }

        public new bool IsEnabled
        {
            get => (bool)GetValue(IsEnabledProperty);
            set => SetValue(IsEnabledProperty, value);
        }

        public SolidColorBrush TextForeground
        {
            get => (SolidColorBrush)GetValue(TextForegroundProperty);
            set => SetValue(TextForegroundProperty, value);
        }

        public TextAlignment TextAlignment
        {
            get => (TextAlignment)GetValue(TextAlignmentProperty);
            set => SetValue(TextAlignmentProperty, value);
        }

        public PrimeTextbox()
        {
            InitializeComponent();
            DataContext = this;
           
        }

       
    }
}
