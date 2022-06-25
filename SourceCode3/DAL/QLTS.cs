using System;
using System.Data.Entity;
using System.Linq;

namespace SourceCode.DAL
{
    public class QLTS : DbContext
    {
        // Your context has been configured to use a 'QLTS' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SourceCode.Database.QLTS' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QLTS' 
        // connection string in the application configuration file.
        public QLTS()
            : base("name=QLTS")
        {
            System.Data.Entity.Database.SetInitializer(new CreateDB());
        }
        public virtual DbSet<tMonAn> _MonAn { get; set; }
        public virtual DbSet<tThanhVien> _ThanhVien { get; set; }
        public virtual DbSet<tBanAn> _BanAn { get; set; }
        public virtual DbSet<tDatMonAn> _DatMonAn { get; set; }
        public virtual DbSet<tHoaDon> _HoaDon { get; set; }
        public virtual DbSet<tKho> _Kho { get; set; }
        public virtual DbSet<tLoaiMonAn> _LoaiMonAn { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}