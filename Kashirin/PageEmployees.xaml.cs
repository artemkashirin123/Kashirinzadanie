namespace Kashirin;
using SQLite;

public partial class PageEmployees : ContentPage
{
	public PageEmployees()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        EmployeesList.ItemsSource = App.Database.GetItemsEmployee();
        base.OnAppearing();
    }

    private void CreateEmployee(object sender, EventArgs e)
    {
        Employees employees = new Employees();
        PageAddEmployees pageAddEmployees = new PageAddEmployees();
        pageAddEmployees.BindingContext = employees;
        Navigation.PushAsync(pageAddEmployees);
    }

    private void OnItemSelectedEmployee(object sender, SelectedItemChangedEventArgs e)
    {
        Employees selectedEmployees = (Employees)e.SelectedItem;
        PageAddEmployees AddEmployees = new PageAddEmployees();
        AddEmployees.BindingContext = selectedEmployees;
        Navigation.PushAsync(AddEmployees);
    }
}