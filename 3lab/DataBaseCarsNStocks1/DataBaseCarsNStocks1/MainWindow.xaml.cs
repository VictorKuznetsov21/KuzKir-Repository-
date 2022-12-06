using System.Linq;
using System.Windows;


namespace DataBaseCarsNStocks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ApplicationContext _db = new ApplicationContext();
        public MainWindow()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {

            var carnames = _db.Cars.Select(car => car.Name).Distinct().ToList();
            var carcosts = _db.Cars.Select(car => car.Cost).ToList();
            var carReleaseDate = _db.Cars.Select(car => car.DataRelease).Distinct().ToList();
            var carRemark = _db.Cars.Select(car => car.Remark).Distinct().ToList();

            carsGrid.ItemsSource = _db.Cars.ToList();
            box1.ItemsSource = carnames;
            box2.ItemsSource = carcosts;
            box3.ItemsSource = carReleaseDate;
            box4.ItemsSource = carRemark;
        }

        private void ClickToSort(object sender, RoutedEventArgs e) 
        {
            var tempcar = box1.SelectedItem as string;
            carsGrid.ItemsSource = _db.Cars.Where(car => car.Name == tempcar).Distinct().ToList();
            
        }
        private void ClickToReleaseData(object sender,RoutedEventArgs e) 
        {
            var tempdata = box3.SelectedItem as int?;
            carsGrid.ItemsSource = _db.Cars.Where(car => car.DataRelease == tempdata).Distinct().ToList();
        }
        private void ClickToReset(object sender, RoutedEventArgs e) 
        {
            carsGrid.ItemsSource = _db.Cars.ToList();
        }
        private void ClickToCost(object sender, RoutedEventArgs e) 
        {
            var tempcost = box2.SelectedItem as int?;
            carsGrid.ItemsSource = _db.Cars.Where(u =>u.Cost <= tempcost).ToList();
        }
        private void ClickToRemark(object sender, RoutedEventArgs e) 
        {
            var tempremark = box4.SelectedItem as string;
            carsGrid.ItemsSource = _db.Cars.Where(car => car.Remark == tempremark).Distinct().ToList();
        }
    }
}
