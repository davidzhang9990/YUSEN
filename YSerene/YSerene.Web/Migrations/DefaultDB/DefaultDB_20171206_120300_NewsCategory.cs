using FluentMigrator;

namespace YSerene.Migrations.DefaultDB
{
    [Migration(20171206120300)]
    public class DefaultDB_20171206_120300_NewsCategory : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("NewsCategory", "CategoryID", s => s
                .WithColumn("CategoryName").AsString(50).NotNullable()
                .WithColumn("Description").AsString(500).Nullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

            this.CreateTableWithId32("News", "NewsID", s => s
                .WithColumn("Title").AsString(100).NotNullable()
                .WithColumn("Image").AsString(100).NotNullable()
                .WithColumn("CategoryID").AsInt32().NotNullable()
                .ForeignKey("FK_News_CategoryID", "NewsCategory", "CategoryID")
                .WithColumn("SourceSite").AsString(100).NotNullable()
                .WithColumn("CreateDate").AsDateTime().NotNullable()
                .WithColumn("Description").AsString(int.MaxValue).Nullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));
        }
    }
}