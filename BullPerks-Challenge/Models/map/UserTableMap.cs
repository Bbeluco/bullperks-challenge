using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BullPerks_Challenge;

public class UserTableMap : IEntityTypeConfiguration<UsersModel>
{
    public void Configure(EntityTypeBuilder<UsersModel> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Username).IsRequired();
        builder.Property(x => x.Password).IsRequired();
    }
}
