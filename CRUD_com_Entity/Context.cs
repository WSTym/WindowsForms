namespace CRUD_com_Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using MySql.Data.EntityFramework;

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Context : DbContext
    {
        public Context()
            : base("name=conn")
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
