using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ScaffoldTool.Events.ITEMSET
{
    public partial class ITEMSETEventContext : DbContext
    {
        public ITEMSETEventContext()
        {
        }

        public ITEMSETEventContext(DbContextOptions<ITEMSETEventContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HRDEMP> HRDEMP { get; set; }
        public virtual DbSet<INVITEM> INVITEM { get; set; }
        public virtual DbSet<INVSETDET> INVSETDET { get; set; }
        public virtual DbSet<INVSETMAIN> INVSETMAIN { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseOracle("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=vm-20.centralindia.cloudapp.azure.com)(PORT=55211))(CONNECT_DATA=(SERVICE_NAME=RELEASE_DEV)));USER ID=MAIN;PASSWORD=gmpl;Direct=true;License Key=NvUQA4CvimpbxB3L42Xba4++TpT7R0iJp8H0AGC4nsmWWXJrY5EUJbwzhb7EM5D26RWY8/GGIU45+AuFzngI+Nq0j2u533jmmW9+/Uvgd0InFOy2LKyo6z3saGaLfIRJT76egNAgYB/D01/TWgRLMjary9Z1LMZ99Yq6y7FlqFd22DmWnZk3KpY7+T+p3h25B5wuD1b8YyqWKGzatui4QjMsf4XBGYkx84mQjUpCCVaRzri4q/J7PQtb4nFCJJTXx8PI0fp9n7gLSbTFrCgqv2QfXW5T9dlRffGfW+83/53GjmJBZYFz+qBWn0eAmDwN");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<HRDEMP>(entity =>
            {
                entity.HasKey(e => e.ECODE);

                entity.ToTable("HRDEMP", "MAIN");

                entity.HasIndex(e => e.ABBRE)
                    .HasName("U_HRDEMP_ABBRE")
                    .IsUnique();

                entity.HasIndex(e => e.DEPTCODE)
                    .HasName("HRDEMP_LK01");

                entity.HasIndex(e => e.ECODE)
                    .HasName("P_HRDEMP_ECODE")
                    .IsUnique();

                entity.HasIndex(e => e.ENO)
                    .HasName("U_HRDEMP_ENO")
                    .IsUnique();

                entity.HasIndex(e => e.PROFCODE)
                    .HasName("HRDEMP_LK02");

                entity.HasIndex(e => e.RLCODE)
                    .HasName("HRDEMP_LK03");

                entity.Property(e => e.ABBRE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(12);

                entity.Property(e => e.ALLOW_LAST_FY_DAY_MODE)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.APIKEY)
                    .HasColumnType("varchar2")
                    .HasMaxLength(200);

                entity.Property(e => e.ENO)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.EXT)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.FLEX_FIELD_KEY)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 27)
                    .HasAnnotation("Scale", 0);

                entity.Property(e => e.FNAME)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.PASS)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(12);

                entity.Property(e => e.REM)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.REPORTROLE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.SALESMAN)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.USERTYPE)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<INVITEM>(entity =>
            {
                entity.HasKey(e => e.ICODE);

                entity.ToTable("INVITEM", "MAIN");

                entity.HasIndex(e => e.BARCODE)
                    .HasName("INVITEM_BARCODE");

                entity.HasIndex(e => e.BARRQ)
                    .HasName("I_INVITEM_BARRQ");

                entity.HasIndex(e => e.CCODE1)
                    .HasName("INVITEM_LK01");

                entity.HasIndex(e => e.CCODE2)
                    .HasName("INVITEM_LK02");

                entity.HasIndex(e => e.CCODE3)
                    .HasName("INVITEM_LK03");

                entity.HasIndex(e => e.CCODE4)
                    .HasName("INVITEM_LK04");

                entity.HasIndex(e => e.CCODE5)
                    .HasName("INVITEM_LK05");

                entity.HasIndex(e => e.CCODE6)
                    .HasName("INVITEM_LK06");

                entity.HasIndex(e => e.CERTIFICATE_NO)
                    .HasName("INVITEM_CERTIFICATE_NO_U01")
                    .IsUnique();

                entity.HasIndex(e => e.CMPCODE)
                    .HasName("INVITEM_LK07");

                entity.HasIndex(e => e.CONSIDERASFREE)
                    .HasName("I_INVITEM_CONSIDERASFREE");

                entity.HasIndex(e => e.CONSIDERINORDER)
                    .HasName("I_INVITEM_CONSIDERINORDER");

                entity.HasIndex(e => e.COSTSHEET_CODE)
                    .HasName("INVITEM_LK13");

                entity.HasIndex(e => e.DESC1)
                    .HasName("INVITEM_DESC1");

                entity.HasIndex(e => e.DESC2)
                    .HasName("INVITEM_DESC2");

                entity.HasIndex(e => e.DESC3)
                    .HasName("INVITEM_DESC3");

                entity.HasIndex(e => e.DESC4)
                    .HasName("INVITEM_DESC4");

                entity.HasIndex(e => e.DESC5)
                    .HasName("INVITEM_DESC5");

                entity.HasIndex(e => e.DESC6)
                    .HasName("INVITEM_DESC6");

                entity.HasIndex(e => e.EXT)
                    .HasName("I_INVITEM_EXT");

                entity.HasIndex(e => e.GLCODE)
                    .HasName("INVITEM_LK16");

                entity.HasIndex(e => e.GRPCODE)
                    .HasName("INVITEM_LK08");

                entity.HasIndex(e => e.INVARTICLE_CODE)
                    .HasName("INVITEM_LK11");

                entity.HasIndex(e => e.INVHSNSACMAIN_CODE)
                    .HasName("INVITEM_LK15");

                entity.HasIndex(e => e.INVMETAL_CODE)
                    .HasName("INVITEM_LK12");

                entity.HasIndex(e => e.ISSERVICE)
                    .HasName("I_INVITEM_ISSERVICE");

                entity.HasIndex(e => e.NONINVENTORY)
                    .HasName("I_INVITEM_NONINVENTORY");

                entity.HasIndex(e => e.PARTYCODE)
                    .HasName("I_INVITEM_PARTYCODE");

                entity.HasIndex(e => e.PARTYNAME)
                    .HasName("I_INVITEM_PARTYNAME");

                entity.HasIndex(e => e.POS_MULTIPRICE_ACTION)
                    .HasName("I_INVITEM_POS_MULPRICE_ACTION");

                entity.HasIndex(e => e.ROUTECODE)
                    .HasName("INVITEM_LK14");

                entity.HasIndex(e => e.SLCODE)
                    .HasName("INVITEM_LK17");

                entity.HasIndex(e => e.STKPLANCODE)
                    .HasName("I_INVITEM_STKPLANCODE");

                entity.HasIndex(e => e.TAXCODE)
                    .HasName("INVITEM_LK10");

                entity.HasIndex(e => e.UNITNAME)
                    .HasName("INVITEM_UNITNAME");

                entity.HasIndex(e => new { e.ICODE, e.GRPCODE })
                    .HasName("I_INVITEM_ICODE_GRPCODE");

                entity.HasIndex(e => new { e.ICODE, e.INVARTICLE_CODE })
                    .HasName("I_INVITEM_ICODE_ARTICLE");

                entity.Property(e => e.ICODE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(9);

                entity.Property(e => e.ALLOW_PRICE_MODIFICATION)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.ALT_LISTED_MRP)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.ALT_MRP)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.AUTOQTYPOPUP)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.BARCODE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.BARRQ)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.BARUNIT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.BLOCK_SALE_AFTER).HasColumnType("date");

                entity.Property(e => e.BLOCK_SALE_BEFORE).HasColumnType("date");

                entity.Property(e => e.BLOCK_SALE_REASON)
                    .HasColumnType("varchar2")
                    .HasMaxLength(200);

                entity.Property(e => e.CERTIFICATE_NO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.CHARGE)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.CNAME1)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.CNAME2)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.CNAME3)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.CNAME4)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.CNAME5)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.CNAME6)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.CONSIDERASFREE)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.CONSIDERINORDER)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.COSTRATE)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.C_DESC)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.C_VALUE)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.C_WEIGHT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 5);

                entity.Property(e => e.DESC1)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.DESC2)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.DESC3)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.DESC4)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.DESC5)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.DESC6)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.D_DESC)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.D_SIZE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.D_VALUE)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.D_WEIGHT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 5);

                entity.Property(e => e.EXPIRY_DATE).HasColumnType("date");

                entity.Property(e => e.EXT)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.GENERATED).HasColumnType("date");

                entity.Property(e => e.GRS_WEIGHT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 5);

                entity.Property(e => e.GST_ITC_APPL)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(2);

                entity.Property(e => e.ISMETAL)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.ISSERVICE)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.ITEM_NAME)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.JOB_COST_AMT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.JOB_COST_BASIS)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.LAST_CHANGED).HasColumnType("date");

                entity.Property(e => e.LISTED_MRP)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.MATERIAL_TYPE)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.MRP)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.NEGATIVE_STOCK_ALERT)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.NET_WEIGHT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 5);

                entity.Property(e => e.NONINVENTORY)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.NUM1)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.NUM2)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.NUM3)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.OTHER_CHG)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.O_DESC)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.O_VALUE)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.O_WEIGHT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 5);

                entity.Property(e => e.PARTYALIAS)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.PARTYNAME)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.PART_QTY).HasColumnType("double");

                entity.Property(e => e.POS_MULTIPRICE_ACTION)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.POS_RETURN_BEHAVIOR)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.PRICE_BASIS)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.PRICE_CHANGE_LIMIT).HasColumnType("double");

                entity.Property(e => e.PRICE_TERMS)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.RATE)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.REM)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.SEARCH_STRING)
                    .HasColumnType("varchar2")
                    .HasMaxLength(4000);

                entity.Property(e => e.SHRTNAME)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.STOCKINDATE).HasColumnType("date");

                entity.Property(e => e.UDFDATE01).HasColumnType("date");

                entity.Property(e => e.UDFDATE02).HasColumnType("date");

                entity.Property(e => e.UDFDATE03).HasColumnType("date");

                entity.Property(e => e.UDFDATE04).HasColumnType("date");

                entity.Property(e => e.UDFDATE05).HasColumnType("date");

                entity.Property(e => e.UDFNUM01)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.UDFNUM02)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.UDFNUM03)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.UDFNUM04)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.UDFNUM05)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.UDFSTRING01)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.UDFSTRING02)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.UDFSTRING03)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.UDFSTRING04)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.UDFSTRING05)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.UDFSTRING06)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.UDFSTRING07)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.UDFSTRING08)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.UDFSTRING09)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.UDFSTRING10)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.UNITNAME)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.WSP)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);
            });

            modelBuilder.Entity<INVSETDET>(entity =>
            {
                entity.HasKey(e => e.CODE);

                entity.ToTable("INVSETDET", "MAIN");

                entity.HasIndex(e => e.CODE)
                    .HasName("INVSETDET_PK")
                    .IsUnique();

                entity.HasIndex(e => e.ICODE)
                    .HasName("INVSETDET_LK01");

                entity.HasIndex(e => e.SETCODE)
                    .HasName("INVSETDET_LK02");

                entity.Property(e => e.ICODE)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(9);

                entity.Property(e => e.INTGCODE)
                    .HasColumnType("char")
                    .HasMaxLength(3);

                entity.Property(e => e.INTG_STG_ID)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.QTY)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.HasOne(d => d.ICODENavigation)
                    .WithMany(p => p.INVSETDET)
                    .HasForeignKey(d => d.ICODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("INVSETDET_R02");

                entity.HasOne(d => d.SETCODENavigation)
                    .WithMany(p => p.INVSETDET)
                    .HasForeignKey(d => d.SETCODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("INVSETDET_R01");
            });

            modelBuilder.Entity<INVSETMAIN>(entity =>
            {
                entity.HasKey(e => e.SETCODE);

                entity.ToTable("INVSETMAIN", "MAIN");

                entity.HasIndex(e => e.CREATOR_CMPCODE)
                    .HasName("INVSETMAIN_LK01");

                entity.HasIndex(e => e.ECODE)
                    .HasName("INVSETMAIN_LK02");

                entity.HasIndex(e => e.INTGCODE)
                    .HasName("INVSETMAIN_LK04");

                entity.HasIndex(e => e.LOCCODE)
                    .HasName("INVSETMAIN_LK03");

                entity.HasIndex(e => e.SETCODE)
                    .HasName("INVSETMAIN_PK")
                    .IsUnique();

                entity.Property(e => e.CANCEL_FLAG)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.INTGCODE)
                    .HasColumnType("char")
                    .HasMaxLength(3);

                entity.Property(e => e.INTG_STG_ID)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.REM)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.SETDT).HasColumnType("date");

                entity.Property(e => e.UDFDATE01).HasColumnType("date");

                entity.Property(e => e.UDFDATE02).HasColumnType("date");

                entity.Property(e => e.UDFDATE03).HasColumnType("date");

                entity.Property(e => e.UDFDATE04).HasColumnType("date");

                entity.Property(e => e.UDFDATE05).HasColumnType("date");

                entity.Property(e => e.UDFNUM01)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 29)
                    .HasAnnotation("Scale", 0);

                entity.Property(e => e.UDFNUM02)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 29)
                    .HasAnnotation("Scale", 0);

                entity.Property(e => e.UDFNUM03)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 29)
                    .HasAnnotation("Scale", 0);

                entity.Property(e => e.UDFNUM04)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 29)
                    .HasAnnotation("Scale", 0);

                entity.Property(e => e.UDFNUM05)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 29)
                    .HasAnnotation("Scale", 0);

                entity.Property(e => e.UDFSTRIN01)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRIN010)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRIN02)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRIN03)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRIN04)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRIN05)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRIN06)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRIN07)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRIN08)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRIN09)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.HasOne(d => d.ECODENavigation)
                    .WithMany(p => p.INVSETMAIN)
                    .HasForeignKey(d => d.ECODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("INVSETMAIN_R02");
            });
        }
    }
}
