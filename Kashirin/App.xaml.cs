namespace Kashirin;

public partial class App : Application
{
    public const string DATABASE_NAME = "kashirin.db";
    public static EmployeesRepository database;
    public static EmployeesRepository Database
    {
        get
        {
            if (database == null)
            {
                database = new EmployeesRepository(
                    Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
            }
            return database;
        }
    }
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
    protected override void OnStart()
    {
    }
    protected override void OnSleep()
    {
    }
    protected override void OnResume()
    {
    }
}
