namespace Kashirin;

public partial class PageAddEmployees : ContentPage
{
	public PageAddEmployees()
	{
		InitializeComponent();
	}

    private void AddEmployee(object sender, EventArgs e)
    {
        var employee = (Employees)BindingContext;
        if (!String.IsNullOrEmpty(employee.Name))
        {
            App.Database.SaveItemEmployee(employee);
        }
        Navigation.PushAsync(new PageEmployees());
    }

    private void Cancel(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PageEmployees());
    }

    private void DeleteEmployee(object sender, EventArgs e)
    {
        var employees = (Employees)BindingContext;
        App.Database.DeleteItemEmployee(employees.IDEmployee);
        Navigation.PushAsync(new PageEmployees());
    }
}