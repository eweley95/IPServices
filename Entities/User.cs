namespace IPService.Entities;

public class User
{
    public virtual int Id { get; set; }
    public virtual string UserName { get; set; }
    public virtual string Password { get; set; }
}