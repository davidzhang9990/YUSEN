using FluentMigrator;

namespace YSerene.Migrations.DefaultDB
{
    [Migration(20171218180000)]
    public class DefaultDB_20171218_180000_Pictures : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("Pictures", "PictureID", s => s
                .WithColumn("Title").AsString(100).NotNullable()
                .WithColumn("KeyImage").AsString(100).NotNullable()
                .WithColumn("ImageList").AsString(int.MaxValue).NotNullable()
                .WithColumn("Description").AsString(500).Nullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));
        }
    }
}