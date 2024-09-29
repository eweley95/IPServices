using IPService.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace IPService.EntityMappings;

public class UserMapping : ClassMapping<User>
{
    public UserMapping()
    {
        Id(x => x.Id, m => m.Generator(Generators.Increment));
        Property(x => x.UserName, m => m.Unique(true));
        Property(x => x.Password, m => m.NotNullable(true));
        Table("Users");
    }
}