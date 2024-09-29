namespace IPService.Entities;

public class BlockedIp
{
    public virtual int Id { get; set; }
    public virtual string IpAddress { get; set; }
}