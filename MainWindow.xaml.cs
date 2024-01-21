using System.Windows.Controls;
using System.Windows;

public partial class MainWindow : Window
{
    private PeopleService peopleService = new PeopleService();

    public MainWindow()
    {
        InitializeComponent();
        LoadPeople();
    }

    private void LoadPeople()
    {
        var people = peopleService.GetAllPeople();
        PeopleList.ItemsSource = people;
    }

    private void PeopleList_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        // Display details of the selected person
    }

    private void Add_Click(object sender, RoutedEventArgs e)
    {
        // Add a new person
    }

    private void Edit_Click(object sender, RoutedEventArgs e)
    {
        // Edit the selected person
    }

    private void Delete_Click(object sender, RoutedEventArgs e)
    {
        // Delete the selected person
    }
}
