using IPService.Entities;
using IPService.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NHibernate.Linq;

namespace IPService.Forms;

public partial class AppForm : Form
{
    public AppForm()
    {
        InitializeComponent();
        GetIpAddress();
        GetRegion();
        GetBlockedStatus();
    }

    private const string ApiKey = "976988F1F345A5747B9DB3D8194B922B";
    
    private void GetIpAddress()
    {
        using var httpClient = new HttpClient();
            
        var ipAddress = httpClient
            .GetStringAsync("https://api.ipify.org/");
            
        textIpAddress.Text = ipAddress.Result;
    }

    private void GetRegion()
    {
        string ipAddress = textIpAddress.Text;
        
        using var httpClient = new HttpClient();
        
        var response = httpClient
            .GetStringAsync($"https://api.ip2location.io/?key={ApiKey}&ip={ipAddress}")
            .Result;
        
        var deserializedResponse = JsonConvert.DeserializeObject<JToken>(response);
        var region = deserializedResponse?["region_name"];
        textRegion.Text = region?.ToString();
    }

    private void GetBlockedStatus()
    {
        var ipAddress = textIpAddress.Text;
        var region = textRegion.Text.Trim().ToLower();
        
        using var session = DatabaseHelper.SessionFactory.OpenSession();
        var blockedIp = session
            .Query<BlockedIp>()
            .SingleOrDefault(x => x.IpAddress == ipAddress);
        
        var blockedRegion = session
            .Query<BlockedRegion>()
            .SingleOrDefault(x => x.Region.Like(region));
        
        var blockedStatus = blockedIp != null 
            || blockedRegion != null
            ? "Blocked" 
            : "Not Blocked";
        
        textStatus.Text = blockedStatus;
    }
}
