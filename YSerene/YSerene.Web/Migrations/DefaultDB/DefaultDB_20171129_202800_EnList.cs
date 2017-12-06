using FluentMigrator;

namespace YSerene.Migrations.DefaultDB
{
    [Migration(20171129202800)]
    public class DefaultDB_20171129_202800_EnList : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId64("EnList", "EnId", s => s
                .WithColumn("ParentName").AsString(50).NotNullable()
                .WithColumn("Mobile").AsString(11).NotNullable()
                .WithColumn("ChildName").AsString(50).NotNullable()
                .WithColumn("Sex").AsInt32().NotNullable()
                .WithColumn("Birthday").AsDateTime().NotNullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt32().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));
        }
    }
}