
    using System.Windows;
    using library.ViewModel;

    namespace library.View
    {
        /// <summary>
        /// Логика взаимодействия для WindowPublish.xaml
        /// </summary>
        public partial class WindowPublish : Window
        {
            public WindowPublish()
            {
                InitializeComponent();
                PublishViewModel vmPublish = new PublishViewModel();
                lvPublish.ItemsSource = vmPublish.ListPublish;
            }
        }
    }
