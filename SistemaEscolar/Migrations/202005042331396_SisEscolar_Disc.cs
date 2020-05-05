namespace SistemaEscolar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SisEscolar_Disc : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Avaliacoes", "Valor", c => c.String(maxLength: 5, storeType: "nvarchar"));
            AlterColumn("dbo.Disciplinas", "CargaHoraria", c => c.String(maxLength: 4, storeType: "nvarchar"));
            AlterColumn("dbo.Disciplinas", "AulasSemanais", c => c.String(maxLength: 2, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Disciplinas", "AulasSemanais", c => c.Int(nullable: false));
            AlterColumn("dbo.Disciplinas", "CargaHoraria", c => c.Int(nullable: false));
            AlterColumn("dbo.Avaliacoes", "Valor", c => c.Single(nullable: false));
        }
    }
}
