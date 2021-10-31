
using System.Windows;
using library.ViewModel;

namespace library.View
{
    /// <summary>
    /// Логика взаимодействия для WindowAuthor.xaml
    /// </summary>
    public partial class WindowAuthor : Window
    {
        public WindowAuthor()
        {
            InitializeComponent();
            AuthorViewModel vmAuthor = new AuthorViewModel();
            lvAuthor.ItemsSource = vmAuthor.ListAuthor;
        }
    }
}
