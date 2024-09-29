using IPService.Entities;
using IPService.Helpers;
using NHibernate.Linq;

namespace IPService.Forms;

public partial class SettingForm : Form
{
    public SettingForm()
    {
        InitializeComponent();
    }

    private void buttonBlockIp_Click(object sender, EventArgs e)
    {
        var ip = textIpAddress.Text;

        using var session = DatabaseHelper.SessionFactory.OpenSession();
        var blockedIp = session
            .Query<BlockedIp>()
            .SingleOrDefault(x => x.IpAddress == ip);

        if (blockedIp == null)
        {
            using var transaction = session.BeginTransaction();
            blockedIp = new BlockedIp
            {
                IpAddress = ip
            };
            session.Save(blockedIp);
            transaction.Commit();
        }
            
        MessageBox.Show($@"Blocked IP Address: {ip}");
    }

    private void buttonUnblockIp_Click(object sender, EventArgs e)
    {
        var ip = textIpAddress.Text;
            
        using var session = DatabaseHelper.SessionFactory.OpenSession();
        var blockedIp = session
            .Query<BlockedIp>()
            .SingleOrDefault(x => x.IpAddress == ip);

        if (blockedIp != null)
        {
            var transaction = session.BeginTransaction();
                
            session.Delete(blockedIp);
            transaction.Commit();
        }
            
        MessageBox.Show($@"Unblocked IP Address: {ip}");
    }

    private void buttonBLockRegion_Click(object sender, EventArgs e)
    {
        var region = textRegion.Text.Trim().ToLower();
            
        using var session = DatabaseHelper.SessionFactory.OpenSession();
        var blockedRegion = session
            .Query<BlockedRegion>()
            .SingleOrDefault(x => x.Region.Like(region));

        if (blockedRegion == null)
        {
            using var transaction = session.BeginTransaction();

            blockedRegion = new BlockedRegion
            {
                Region = region
            };
                
            session.Save(blockedRegion);
            transaction.Commit();
        }

        MessageBox.Show($@"Blocked region: {region}");
    }

    private void buttonUnblockRegion_Click(object sender, EventArgs e)
    {
        var region = textRegion.Text.Trim().ToLower();
            
        using var session = DatabaseHelper.SessionFactory.OpenSession();
        var blockedRegion = session
            .Query<BlockedRegion>()
            .SingleOrDefault(x => x.Region.Like(region));

        if (blockedRegion != null)
        {
            using var transaction = session.BeginTransaction();
                
            session.Delete(blockedRegion);
            transaction.Commit();
        }

        MessageBox.Show($@"Unblocked region: {region}");
    }
}
