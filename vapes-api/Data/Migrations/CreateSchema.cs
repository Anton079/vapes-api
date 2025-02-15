using FluentMigrator;

namespace vapes_api.Data.Migrations
{
    [Migration(14022025)]
    public class CreateSchema : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table("vape")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("type").AsString(120).NotNullable()
                .WithColumn("capacity").AsInt32().NotNullable()
                .WithColumn("price").AsInt32().NotNullable();
        }
    }
}
