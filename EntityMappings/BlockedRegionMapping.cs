using IPService.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace IPService.EntityMappings;

public class BlockedRegionMapping : ClassMapping<BlockedRegion>
{
    public BlockedRegionMapping()
    {
        Id(x => x.Id, m => m.Generator(Generators.Increment));
        Property(x => x.Region, m => m.Unique(true));
        Table("BlockedRegions");
    }
}