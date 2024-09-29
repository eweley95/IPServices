using IPService.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace IPService.EntityMappings;

public class BlockedIpMapping : ClassMapping<BlockedIp>
{
    public BlockedIpMapping()
    {
        Id(x => x.Id, m => m.Generator(Generators.Increment));
        Property(x => x.IpAddress, m => m.Unique(true));
        Table("BlockedIps");
    }
}