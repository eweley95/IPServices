using IPService.Entities;
using IPService.Helpers;

namespace IPService.Forms;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var username = textUsername.Text;
        var password = textPassword.Text;

        using var session = DatabaseHelper.SessionFactory.OpenSession();

        var user = session
            .Query<User>()
            .SingleOrDefault(x => x.UserName == username && x.Password == password);

        if (user != null)
        {
            var settingForm = new SettingForm();
            settingForm.ShowDialog();
            this.Close();
        }
        else
        {
            MessageBox.Show(@"Invalid username or password!");
        }
    }
}
