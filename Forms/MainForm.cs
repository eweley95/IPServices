namespace IPService.Forms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void buttonLoginForm_Click(object sender, EventArgs e)
    {
        var loginForm = new LoginForm();
        loginForm.Show();
    }

    private void buttonAppForm_Click(object sender, EventArgs e)
    {
        var appForm = new AppForm();
        appForm.Show();
    }
}
