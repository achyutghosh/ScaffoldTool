using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ScaffoldTool.Events.VendorMaster
{
    public partial class VendorMasterEventContext : DbContext
    {
        public VendorMasterEventContext()
        {
        }

        public VendorMasterEventContext(DbContextOptions<VendorMasterEventContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ADMCITY> ADMCITY { get; set; }
        public virtual DbSet<ADMCLS> ADMCLS { get; set; }
        public virtual DbSet<ADMCMPTAX> ADMCMPTAX { get; set; }
        public virtual DbSet<ADMCURRENCY> ADMCURRENCY { get; set; }
        public virtual DbSet<ADMGSTSTATE> ADMGSTSTATE { get; set; }
        public virtual DbSet<FINFORM> FINFORM { get; set; }
        public virtual DbSet<FINGL> FINGL { get; set; }
        public virtual DbSet<FINSL> FINSL { get; set; }
        public virtual DbSet<FINTRADEGRP> FINTRADEGRP { get; set; }
        public virtual DbSet<PURTERMMAIN> PURTERMMAIN { get; set; }
        public virtual DbSet<SALPRICELISTMAIN> SALPRICELISTMAIN { get; set; }
        public virtual DbSet<SALTERMMAIN> SALTERMMAIN { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseOracle("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=VM-20.GSL.KOLKATA)(PORT=1525))(CONNECT_DATA=(SERVICE_NAME=RELEASE_DEV)));USER ID=MAIN;PASSWORD=gmpl;Direct=true;License Key=NvUQA4CvimpbxB3L42Xba4++TpT7R0iJp8H0AGC4nsmWWXJrY5EUJbwzhb7EM5D26RWY8/GGIU45+AuFzngI+Nq0j2u533jmmW9+/Uvgd0InFOy2LKyo6z3saGaLfIRJT76egNAgYB/D01/TWgRLMjary9Z1LMZ99Yq6y7FlqFd22DmWnZk3KpY7+T+p3h25B5wuD1b8YyqWKGzatui4QjMsf4XBGYkx84mQjUpCCVaRzri4q/J7PQtb4nFCJJTXx8PI0fp9n7gLSbTFrCgqv2QfXW5T9dlRffGfW+83/53GjmJBZYFz+qBWn0eAmDwN");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<ADMCITY>(entity =>
            {
                entity.HasKey(e => e.CODE);

                entity.ToTable("ADMCITY", "MAIN");

                entity.HasIndex(e => e.CMPCODE)
                    .HasName("ADMCITY_LK01");

                entity.HasIndex(e => e.CODE)
                    .HasName("P_ADMCITY_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.CTNAME)
                    .HasName("P_ADMCITY_CTNAME")
                    .IsUnique();

                entity.Property(e => e.CLASS)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.CNNAME)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.CTNAME)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.DIST)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.EXT)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.ISD)
                    .HasColumnType("varchar2")
                    .HasMaxLength(12);

                entity.Property(e => e.STD)
                    .HasColumnType("varchar2")
                    .HasMaxLength(12);

                entity.Property(e => e.STNAME)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.ZONE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ADMCLS>(entity =>
            {
                entity.HasKey(e => e.CLSCODE);

                entity.ToTable("ADMCLS", "MAIN");

                entity.HasIndex(e => e.CLSCODE)
                    .HasName("P_ADMCLS_CLSCODE")
                    .IsUnique();

                entity.HasIndex(e => e.CLSNAME)
                    .HasName("U_ADMCLS_CLSNAME")
                    .IsUnique();

                entity.HasIndex(e => e.CMPCODE)
                    .HasName("ADMCLS_LK01");

                entity.Property(e => e.CLSNAME)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.CLSTYPE)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.EXT)
                    .HasColumnType("char")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<ADMCMPTAX>(entity =>
            {
                entity.HasKey(e => e.CODE);

                entity.ToTable("ADMCMPTAX", "MAIN");

                entity.HasIndex(e => e.CODE)
                    .HasName("PK_ADMCMPTAX")
                    .IsUnique();

                entity.HasIndex(e => e.ECODE)
                    .HasName("ADMCMPTAX_LK01");

                entity.HasIndex(e => e.LAST_ACCESS_ECODE)
                    .HasName("ADMCMPTAX_LK02");

                entity.HasIndex(e => e.NAME)
                    .HasName("ADMCMPTAX_U01")
                    .IsUnique();

                entity.Property(e => e.EXT)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.LAST_ACCESS_TIME).HasColumnType("date");

                entity.Property(e => e.NAME)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.TIME).HasColumnType("date");
            });

            modelBuilder.Entity<ADMCURRENCY>(entity =>
            {
                entity.HasKey(e => e.CODE);

                entity.ToTable("ADMCURRENCY", "MAIN");

                entity.HasIndex(e => e.CODE)
                    .HasName("ADMCURRENCY_PK")
                    .IsUnique();

                entity.HasIndex(e => e.CREATEDBY)
                    .HasName("ADMCURRENCY_LK01");

                entity.HasIndex(e => e.LASTMODIFIEDBY)
                    .HasName("ADMCURRENCY_LK02");

                entity.HasIndex(e => e.NAME)
                    .HasName("ADMCURRENCY_U01")
                    .IsUnique();

                entity.HasIndex(e => e.SHORTCODE)
                    .HasName("ADMCURRENCY_U02")
                    .IsUnique();

                entity.HasIndex(e => e.SYMBOL)
                    .HasName("ADMCURRENCY_U03")
                    .IsUnique();

                entity.Property(e => e.CREATEDON).HasColumnType("date");

                entity.Property(e => e.DECIMAL_SYMBOL)
                    .HasColumnType("varchar2")
                    .HasMaxLength(10);

                entity.Property(e => e.LASTMODIFIEDON).HasColumnType("date");

                entity.Property(e => e.NAME)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.SHORTCODE)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(10);

                entity.Property(e => e.SYMBOL)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<ADMGSTSTATE>(entity =>
            {
                entity.HasKey(e => e.CODE);

                entity.ToTable("ADMGSTSTATE", "MAIN");

                entity.HasIndex(e => e.CODE)
                    .HasName("ADMGSTSTATE_PK")
                    .IsUnique();

                entity.Property(e => e.CODE)
                    .HasColumnType("char")
                    .HasMaxLength(2);

                entity.Property(e => e.ABB)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(2);

                entity.Property(e => e.NAME)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FINFORM>(entity =>
            {
                entity.HasKey(e => e.FORMCODE);

                entity.ToTable("FINFORM", "MAIN");

                entity.HasIndex(e => e.CMPCODE)
                    .HasName("FINFORM_LK01");

                entity.HasIndex(e => e.FORMCODE)
                    .HasName("P_FINFORM_FORMCODE")
                    .IsUnique();

                entity.HasIndex(e => e.FORMNAME)
                    .HasName("U_FINFORM_FORMNAME")
                    .IsUnique();

                entity.Property(e => e.EXT)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.FORMDEPT)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.FORMNAME)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<FINGL>(entity =>
            {
                entity.HasKey(e => e.GLCODE);

                entity.ToTable("FINGL", "MAIN");

                entity.HasIndex(e => e.ADMSITE_CODE_OWNER)
                    .HasName("FINGL_LK05");

                entity.HasIndex(e => e.CMPCODE)
                    .HasName("FINGL_LK04");

                entity.HasIndex(e => e.CTNAME)
                    .HasName("FINGL_LK01");

                entity.HasIndex(e => e.GLCODE)
                    .HasName("P_FINGL_GLCODE")
                    .IsUnique();

                entity.HasIndex(e => e.GLNAME)
                    .HasName("U_FINGL_GLNAME")
                    .IsUnique();

                entity.HasIndex(e => e.GRPCODE)
                    .HasName("FINGL_LK02");

                entity.HasIndex(e => e.TDSSRCCODE)
                    .HasName("FINGL_LK03");

                entity.Property(e => e.ABBRE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.ADDR)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.BRSAMT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.CHQLABEL)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.COSTAPP)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.CP)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.CSTNO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.CTNAME)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.EMAIL)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.EXT)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.FX1)
                    .HasColumnType("varchar2")
                    .HasMaxLength(12);

                entity.Property(e => e.FX2)
                    .HasColumnType("varchar2")
                    .HasMaxLength(12);

                entity.Property(e => e.GLNAME)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.INTRATE)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.LSTNO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.PAN)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.PH1)
                    .HasColumnType("varchar2")
                    .HasMaxLength(12);

                entity.Property(e => e.PH2)
                    .HasColumnType("varchar2")
                    .HasMaxLength(12);

                entity.Property(e => e.PH3)
                    .HasColumnType("varchar2")
                    .HasMaxLength(12);

                entity.Property(e => e.PH4)
                    .HasColumnType("varchar2")
                    .HasMaxLength(12);

                entity.Property(e => e.PIN)
                    .HasColumnType("varchar2")
                    .HasMaxLength(12);

                entity.Property(e => e.SLAPP)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(1);

                entity.Property(e => e.SRCTYPE)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.TYPE)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.WEBSITE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.HasOne(d => d.CTNAMENavigation)
                    .WithMany(p => p.FINGL)
                    .HasPrincipalKey(p => p.CTNAME)
                    .HasForeignKey(d => d.CTNAME)
                    .HasConstraintName("R_FINGL_CTNAME");
            });

            modelBuilder.Entity<FINSL>(entity =>
            {
                entity.HasKey(e => e.SLCODE);

                entity.ToTable("FINSL", "MAIN");

                entity.HasIndex(e => e.ADMCMPTAX_CODE)
                    .HasName("FINSL_LK37");

                entity.HasIndex(e => e.ADMCURRENCY_CODE)
                    .HasName("FINSL_LK27");

                entity.HasIndex(e => e.AGCODE)
                    .HasName("FINSL_LK01");

                entity.HasIndex(e => e.BCTNAME)
                    .HasName("FINSL_LK02");

                entity.HasIndex(e => e.CLSCODE)
                    .HasName("FINSL_LK03");

                entity.HasIndex(e => e.CMPCODE)
                    .HasName("FINSL_LK13");

                entity.HasIndex(e => e.CONSIGNMENT_GLCODE)
                    .HasName("FINSL_LK18");

                entity.HasIndex(e => e.CONSIGNMENT_SALES_GLCODE)
                    .HasName("FINSL_LK19");

                entity.HasIndex(e => e.CONSIGNMENT_SALES_SLCODE)
                    .HasName("FINSL_LK20");

                entity.HasIndex(e => e.CONSIGNMENT_SLCODE)
                    .HasName("FINSL_LK32");

                entity.HasIndex(e => e.CONSIGNMENT_TRNSFR_GLCODE)
                    .HasName("FINSL_LK21");

                entity.HasIndex(e => e.CONSIGNMENT_TRNSFR_SLCODE)
                    .HasName("FINSL_LK22");

                entity.HasIndex(e => e.CP_CATEGORY_CODE)
                    .HasName("FINSL_LK42");

                entity.HasIndex(e => e.CP_GSTIN_STATE_CODE)
                    .HasName("FINSL_LK43");

                entity.HasIndex(e => e.CRCODE)
                    .HasName("FINSL_LK12");

                entity.HasIndex(e => e.FINTRADEGRP_CODE)
                    .HasName("FINSL_LK28");

                entity.HasIndex(e => e.GLCODE)
                    .HasName("FINSL_LK04");

                entity.HasIndex(e => e.INLOCCODE)
                    .HasName("FINSL_LK05");

                entity.HasIndex(e => e.OUTLOCCODE)
                    .HasName("FINSL_LK06");

                entity.HasIndex(e => e.PRICELISTCODE)
                    .HasName("FINSL_LK07");

                entity.HasIndex(e => e.PURCHASE_GLCODE)
                    .HasName("FINSL_LK14");

                entity.HasIndex(e => e.PURCHASE_RETURN_GLCODE)
                    .HasName("FINSL_LK15");

                entity.HasIndex(e => e.PURCHASE_RETURN_SLCODE)
                    .HasName("FINSL_LK16");

                entity.HasIndex(e => e.PURCHASE_SLCODE)
                    .HasName("FINSL_LK17");

                entity.HasIndex(e => e.PURFORMCODE)
                    .HasName("FINSL_LK38");

                entity.HasIndex(e => e.PURTERMMAIN_CODE)
                    .HasName("FINSL_LK29");

                entity.HasIndex(e => e.SALES_GLCODE)
                    .HasName("FINSL_LK23");

                entity.HasIndex(e => e.SALES_RETURN_GLCODE)
                    .HasName("FINSL_LK24");

                entity.HasIndex(e => e.SALES_RETURN_SLCODE)
                    .HasName("FINSL_LK25");

                entity.HasIndex(e => e.SALES_SLCODE)
                    .HasName("FINSL_LK26");

                entity.HasIndex(e => e.SALFORMCODE)
                    .HasName("FINSL_LK39");

                entity.HasIndex(e => e.SALTERMCODE)
                    .HasName("FINSL_LK08");

                entity.HasIndex(e => e.SALTRADEGRP_CODE)
                    .HasName("FINSL_LK40");

                entity.HasIndex(e => e.SCTNAME)
                    .HasName("FINSL_LK41");

                entity.HasIndex(e => e.SLCODE)
                    .HasName("P_FINSL_SLCODE")
                    .IsUnique();

                entity.HasIndex(e => e.SLID)
                    .HasName("U_FINSL_SLID")
                    .IsUnique();

                entity.HasIndex(e => e.TAXCODE)
                    .HasName("FINSL_LK09");

                entity.HasIndex(e => e.TDSSRCCODE)
                    .HasName("FINSL_LK10");

                entity.HasIndex(e => e.TRANSITDIFF_GLCODE)
                    .HasName("FINSL_LK33");

                entity.HasIndex(e => e.TRANSITDIFF_SLCODE)
                    .HasName("FINSL_LK34");

                entity.HasIndex(e => e.TRANSIT_GLCODE)
                    .HasName("FINSL_LK35");

                entity.HasIndex(e => e.TRANSIT_SLCODE)
                    .HasName("FINSL_LK36");

                entity.HasIndex(e => e.TRPCODE)
                    .HasName("FINSL_LK11");

                entity.HasIndex(e => e.VATEXP_GLCODE)
                    .HasName("FINSL_LK30");

                entity.HasIndex(e => e.VATEXP_SLCODE)
                    .HasName("FINSL_LK31");

                entity.Property(e => e.ABBRE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.AGRATE)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.ALLOW_JOBBER_STOCKPOINT)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.BADDR)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.BALE_WISE_LRQTY)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.BANKACCOUNTNO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.BANKIFCCODE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.BANKMICRCODE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.BANKNAME)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.BANKRTGSCODE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.BCP)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.BCTNAME)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.BDIST)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.BEMAIL)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.BEMAIL2)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.BFX1)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.BFX2)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.BPH1)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.BPH2)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.BPH3)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.BPH4)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.BPIN)
                    .HasColumnType("varchar2")
                    .HasMaxLength(12);

                entity.Property(e => e.BRAND)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.BWEBSITE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.CASH_DISCOUNT_APPLICABLE)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.CASH_DISCOUNT_PERCENTAGE).HasColumnType("double");

                entity.Property(e => e.CHQLABEL)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.CINNO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.COMPANYTYPE)
                    .HasColumnType("char")
                    .HasMaxLength(3);

                entity.Property(e => e.CP_GSTIN_DATE).HasColumnType("date");

                entity.Property(e => e.CP_GSTIN_NO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(15);

                entity.Property(e => e.CP_GSTIN_STATE_CODE)
                    .HasColumnType("char")
                    .HasMaxLength(2);

                entity.Property(e => e.CRAMT).HasColumnType("double");

                entity.Property(e => e.CROVERDUEAMT).HasColumnType("double");

                entity.Property(e => e.CRTOLERANCE).HasColumnType("double");

                entity.Property(e => e.CSTDATE).HasColumnType("date");

                entity.Property(e => e.CSTNO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.CVRULE)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.DEFAULT_MARKUP)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.DEFAULT_MARKUP_WSP)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.DISCHGPER)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.DUE_DATE_BASIS)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.ECOMCHNLCODE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.EXCISENO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.EXCISE_DATE).HasColumnType("date");

                entity.Property(e => e.EXT)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.GATEIN_APPL)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.INDUSTRYTYPE)
                    .HasColumnType("char")
                    .HasMaxLength(3);

                entity.Property(e => e.INTRATE)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.LGT_APPL)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.LIMIT)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.LIMIT_WSP)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.LSTDATE).HasColumnType("date");

                entity.Property(e => e.LSTNO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.MARKUP_SELLING_LIMIT)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.MARKUP_SELLING_PRICE)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 22)
                    .HasAnnotation("Scale", 5);

                entity.Property(e => e.MARKUP_SELLING_ROUND_OFF)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.MICRONO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.OUT_LGT_APPL)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.OUT_PERMIT_APPL)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.PAN)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.PERMIT_APPL)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.PO_ORDER_LIMIT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 29)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.PRD_OVERDUE_ACTION)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.PRICETYPE)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.PRODUCT)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.PUR_PRICE_CHART_APPL)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.REM)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.ROUND_OFF_MARKUP)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.ROUND_OFF_MARKUP_WSP)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.SADDR)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.SALETYPE)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.SALE_POST_METHOD)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.SCP)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.SCTNAME)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.SDIST)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.SEMAIL)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.SEMAIL2)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.SERVICETAXCATEGOR)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.SERVICETAXDATE).HasColumnType("date");

                entity.Property(e => e.SERVICETAXNO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.SFX1)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.SFX2)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.SHIPMENT_TRACKING_APPL)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.SLID)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.SLNAME)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.SLOWNER)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.SPH1)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.SPH2)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.SPH3)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.SPH4)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.SPIN)
                    .HasColumnType("varchar2")
                    .HasMaxLength(12);

                entity.Property(e => e.SSINO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.SWEBSITE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.TAXAPP)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.TAXCHGPER)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.TDSCATEGORY)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.TDS_APP)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.TRACK_SECONDARY_INVENTORY)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.WHETHER_CONSIGNMENT)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.HasOne(d => d.ADMCMPTAX_CODENavigation)
                    .WithMany(p => p.FINSL)
                    .HasForeignKey(d => d.ADMCMPTAX_CODE)
                    .HasConstraintName("R_FINSL_ADMCMPTAX_CODE");

                entity.HasOne(d => d.ADMCURRENCY_CODENavigation)
                    .WithMany(p => p.FINSL)
                    .HasForeignKey(d => d.ADMCURRENCY_CODE)
                    .HasConstraintName("R_FINSL_ADMCURRENCY_CODE");

                entity.HasOne(d => d.AGCODENavigation)
                    .WithMany(p => p.InverseAGCODENavigation)
                    .HasForeignKey(d => d.AGCODE)
                    .HasConstraintName("R_FINSL_AGCODE");

                entity.HasOne(d => d.BCTNAMENavigation)
                    .WithMany(p => p.FINSLBCTNAMENavigation)
                    .HasPrincipalKey(p => p.CTNAME)
                    .HasForeignKey(d => d.BCTNAME)
                    .HasConstraintName("R_FINSL_BCTNAME");

                entity.HasOne(d => d.CLSCODENavigation)
                    .WithMany(p => p.FINSL)
                    .HasForeignKey(d => d.CLSCODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_FINSL_CLSCODE");

                entity.HasOne(d => d.CONSIGNMENT_GLCODENavigation)
                    .WithMany(p => p.FINSLCONSIGNMENT_GLCODENavigation)
                    .HasForeignKey(d => d.CONSIGNMENT_GLCODE)
                    .HasConstraintName("R_FINSL_CONSIGNMNT_GLCODE");

                entity.HasOne(d => d.CONSIGNMENT_SALES_GLCODENavigation)
                    .WithMany(p => p.FINSLCONSIGNMENT_SALES_GLCODENavigation)
                    .HasForeignKey(d => d.CONSIGNMENT_SALES_GLCODE)
                    .HasConstraintName("R_FINSL_CONSIGNSALEGLCODE");

                entity.HasOne(d => d.CONSIGNMENT_SALES_SLCODENavigation)
                    .WithMany(p => p.InverseCONSIGNMENT_SALES_SLCODENavigation)
                    .HasForeignKey(d => d.CONSIGNMENT_SALES_SLCODE)
                    .HasConstraintName("R_FINSL_CONSIGNSALESLCODE");

                entity.HasOne(d => d.CONSIGNMENT_SLCODENavigation)
                    .WithMany(p => p.InverseCONSIGNMENT_SLCODENavigation)
                    .HasForeignKey(d => d.CONSIGNMENT_SLCODE)
                    .HasConstraintName("R_FINSL_CONSIGNMENT_SLCODE");

                entity.HasOne(d => d.CONSIGNMENT_TRNSFR_GLCODENavigation)
                    .WithMany(p => p.FINSLCONSIGNMENT_TRNSFR_GLCODENavigation)
                    .HasForeignKey(d => d.CONSIGNMENT_TRNSFR_GLCODE)
                    .HasConstraintName("R_FINSL_CON_TFS_GLCODE");

                entity.HasOne(d => d.CONSIGNMENT_TRNSFR_SLCODENavigation)
                    .WithMany(p => p.InverseCONSIGNMENT_TRNSFR_SLCODENavigation)
                    .HasForeignKey(d => d.CONSIGNMENT_TRNSFR_SLCODE)
                    .HasConstraintName("R_FINSL_CON_TFS_SLCODE");

                entity.HasOne(d => d.CP_GSTIN_STATE_CODENavigation)
                    .WithMany(p => p.FINSL)
                    .HasForeignKey(d => d.CP_GSTIN_STATE_CODE)
                    .HasConstraintName("R_FINSL_CP_GSTIN_STATE_CODE");

                entity.HasOne(d => d.FINTRADEGRP_CODENavigation)
                    .WithMany(p => p.FINSLFINTRADEGRP_CODENavigation)
                    .HasForeignKey(d => d.FINTRADEGRP_CODE)
                    .HasConstraintName("R_FINSL_FINTRADEGRP_CODE");

                entity.HasOne(d => d.GLCODENavigation)
                    .WithMany(p => p.FINSLGLCODENavigation)
                    .HasForeignKey(d => d.GLCODE)
                    .HasConstraintName("R_FINSL_GLCODE");

                entity.HasOne(d => d.PRICELISTCODENavigation)
                    .WithMany(p => p.FINSL)
                    .HasForeignKey(d => d.PRICELISTCODE)
                    .HasConstraintName("R_FINSL_PRICELISTCODE");

                entity.HasOne(d => d.PURCHASE_GLCODENavigation)
                    .WithMany(p => p.FINSLPURCHASE_GLCODENavigation)
                    .HasForeignKey(d => d.PURCHASE_GLCODE)
                    .HasConstraintName("R_FINSL_PURCHASE_GLCODE");

                entity.HasOne(d => d.PURCHASE_RETURN_GLCODENavigation)
                    .WithMany(p => p.FINSLPURCHASE_RETURN_GLCODENavigation)
                    .HasForeignKey(d => d.PURCHASE_RETURN_GLCODE)
                    .HasConstraintName("R_FINSL_PUR_RETURN_GLCODE");

                entity.HasOne(d => d.PURCHASE_RETURN_SLCODENavigation)
                    .WithMany(p => p.InversePURCHASE_RETURN_SLCODENavigation)
                    .HasForeignKey(d => d.PURCHASE_RETURN_SLCODE)
                    .HasConstraintName("R_FINSL_PUR_RETURN_SLCODE");

                entity.HasOne(d => d.PURCHASE_SLCODENavigation)
                    .WithMany(p => p.InversePURCHASE_SLCODENavigation)
                    .HasForeignKey(d => d.PURCHASE_SLCODE)
                    .HasConstraintName("R_FINSL_PURCHASE_SLCODE");

                entity.HasOne(d => d.PURFORMCODENavigation)
                    .WithMany(p => p.FINSLPURFORMCODENavigation)
                    .HasForeignKey(d => d.PURFORMCODE)
                    .HasConstraintName("R_FINSL_PURFORMCODE");

                entity.HasOne(d => d.PURTERMMAIN_CODENavigation)
                    .WithMany(p => p.FINSL)
                    .HasForeignKey(d => d.PURTERMMAIN_CODE)
                    .HasConstraintName("R_FINSL_PURTERMMAIN_CODE");

                entity.HasOne(d => d.SALES_GLCODENavigation)
                    .WithMany(p => p.FINSLSALES_GLCODENavigation)
                    .HasForeignKey(d => d.SALES_GLCODE)
                    .HasConstraintName("R_FINSL_SALES_GLCODE");

                entity.HasOne(d => d.SALES_RETURN_GLCODENavigation)
                    .WithMany(p => p.FINSLSALES_RETURN_GLCODENavigation)
                    .HasForeignKey(d => d.SALES_RETURN_GLCODE)
                    .HasConstraintName("R_FINSL_SALESRETGLCODE");

                entity.HasOne(d => d.SALES_RETURN_SLCODENavigation)
                    .WithMany(p => p.InverseSALES_RETURN_SLCODENavigation)
                    .HasForeignKey(d => d.SALES_RETURN_SLCODE)
                    .HasConstraintName("R_FINSL_SALESRETSLCODE");

                entity.HasOne(d => d.SALES_SLCODENavigation)
                    .WithMany(p => p.InverseSALES_SLCODENavigation)
                    .HasForeignKey(d => d.SALES_SLCODE)
                    .HasConstraintName("R_FINSL_SALES_SLCODE");

                entity.HasOne(d => d.SALFORMCODENavigation)
                    .WithMany(p => p.FINSLSALFORMCODENavigation)
                    .HasForeignKey(d => d.SALFORMCODE)
                    .HasConstraintName("R_FINSL_SALFORMCODE");

                entity.HasOne(d => d.SALTERMCODENavigation)
                    .WithMany(p => p.FINSL)
                    .HasForeignKey(d => d.SALTERMCODE)
                    .HasConstraintName("R_FINSL_SALTERMCODE");

                entity.HasOne(d => d.SALTRADEGRP_CODENavigation)
                    .WithMany(p => p.FINSLSALTRADEGRP_CODENavigation)
                    .HasForeignKey(d => d.SALTRADEGRP_CODE)
                    .HasConstraintName("R_FINSL_SALTRADEGRP_CODE");

                entity.HasOne(d => d.SCTNAMENavigation)
                    .WithMany(p => p.FINSLSCTNAMENavigation)
                    .HasPrincipalKey(p => p.CTNAME)
                    .HasForeignKey(d => d.SCTNAME)
                    .HasConstraintName("R_FINSL_SCTNAME");

                entity.HasOne(d => d.TRANSITDIFF_GLCODENavigation)
                    .WithMany(p => p.FINSLTRANSITDIFF_GLCODENavigation)
                    .HasForeignKey(d => d.TRANSITDIFF_GLCODE)
                    .HasConstraintName("R_FINSL_TRANSITDIFF_GLCODE");

                entity.HasOne(d => d.TRANSITDIFF_SLCODENavigation)
                    .WithMany(p => p.InverseTRANSITDIFF_SLCODENavigation)
                    .HasForeignKey(d => d.TRANSITDIFF_SLCODE)
                    .HasConstraintName("R_FINSL_TRANSITDIFF_SLCODE");

                entity.HasOne(d => d.TRANSIT_GLCODENavigation)
                    .WithMany(p => p.FINSLTRANSIT_GLCODENavigation)
                    .HasForeignKey(d => d.TRANSIT_GLCODE)
                    .HasConstraintName("R_FINSL_TRANSIT_GLCODE");

                entity.HasOne(d => d.TRANSIT_SLCODENavigation)
                    .WithMany(p => p.InverseTRANSIT_SLCODENavigation)
                    .HasForeignKey(d => d.TRANSIT_SLCODE)
                    .HasConstraintName("R_FINSL_TRANSIT_SLCODE");

                entity.HasOne(d => d.TRPCODENavigation)
                    .WithMany(p => p.InverseTRPCODENavigation)
                    .HasForeignKey(d => d.TRPCODE)
                    .HasConstraintName("R_FINSL_TRPCODE");

                entity.HasOne(d => d.VATEXP_GLCODENavigation)
                    .WithMany(p => p.FINSLVATEXP_GLCODENavigation)
                    .HasForeignKey(d => d.VATEXP_GLCODE)
                    .HasConstraintName("R_FINSL_VATEXP_GLCODE");

                entity.HasOne(d => d.VATEXP_SLCODENavigation)
                    .WithMany(p => p.InverseVATEXP_SLCODENavigation)
                    .HasForeignKey(d => d.VATEXP_SLCODE)
                    .HasConstraintName("R_FINSL_VATEXP_SLCODE");
            });

            modelBuilder.Entity<FINTRADEGRP>(entity =>
            {
                entity.HasKey(e => e.CODE);

                entity.ToTable("FINTRADEGRP", "MAIN");

                entity.HasIndex(e => e.CMPCODE)
                    .HasName("FINTRADEGRP_LK01");

                entity.HasIndex(e => e.CODE)
                    .HasName("P_FINTRADEGRP_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.NAME)
                    .HasName("U_FINTRADEGRP_NAME")
                    .IsUnique();

                entity.Property(e => e.DESCRIPTION)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.EXT)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.NAME)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PURTERMMAIN>(entity =>
            {
                entity.HasKey(e => e.CODE);

                entity.ToTable("PURTERMMAIN", "MAIN");

                entity.HasIndex(e => e.CODE)
                    .HasName("P_PURTERMMAIN_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.FINTRADEGRP_CODE)
                    .HasName("PURTERMMAIN_LK01");

                entity.HasIndex(e => e.PURCHASE_GLCODE)
                    .HasName("PURTERMMAIN_LK02");

                entity.HasIndex(e => e.PURCHASE_RETURN_GLCODE)
                    .HasName("PURTERMMAIN_LK03");

                entity.HasIndex(e => e.PURCHASE_RETURN_SLCODE)
                    .HasName("PURTERMMAIN_LK04");

                entity.HasIndex(e => e.PURCHASE_SLCODE)
                    .HasName("PURTERMMAIN_LK05");

                entity.Property(e => e.EXT)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.HEADER_LEVEL_ISCHANGEABLE)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.LINE_LEVEL_ISCHANGEABLE)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.NAME)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.HasOne(d => d.FINTRADEGRP_CODENavigation)
                    .WithMany(p => p.PURTERMMAIN)
                    .HasForeignKey(d => d.FINTRADEGRP_CODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_PURTERMMAIN_TRDGRP_CODE");

                entity.HasOne(d => d.PURCHASE_GLCODENavigation)
                    .WithMany(p => p.PURTERMMAINPURCHASE_GLCODENavigation)
                    .HasForeignKey(d => d.PURCHASE_GLCODE)
                    .HasConstraintName("R_TERMMAIN_PURGLCODE");

                entity.HasOne(d => d.PURCHASE_RETURN_GLCODENavigation)
                    .WithMany(p => p.PURTERMMAINPURCHASE_RETURN_GLCODENavigation)
                    .HasForeignKey(d => d.PURCHASE_RETURN_GLCODE)
                    .HasConstraintName("R_TERMMAIN_PURRETGLCODE");

                entity.HasOne(d => d.PURCHASE_RETURN_SLCODENavigation)
                    .WithMany(p => p.PURTERMMAINPURCHASE_RETURN_SLCODENavigation)
                    .HasForeignKey(d => d.PURCHASE_RETURN_SLCODE)
                    .HasConstraintName("R_TERMMAIN_PURRETSLCODE");

                entity.HasOne(d => d.PURCHASE_SLCODENavigation)
                    .WithMany(p => p.PURTERMMAINPURCHASE_SLCODENavigation)
                    .HasForeignKey(d => d.PURCHASE_SLCODE)
                    .HasConstraintName("R_TERMMAIN_PURSLCODE");
            });

            modelBuilder.Entity<SALPRICELISTMAIN>(entity =>
            {
                entity.HasKey(e => e.PRICELISTCODE);

                entity.ToTable("SALPRICELISTMAIN", "MAIN");

                entity.HasIndex(e => e.CMPCODE)
                    .HasName("SALPRICELISTMAIN_LK02");

                entity.HasIndex(e => e.ECODE)
                    .HasName("SALPRICELISTMAIN_LK01");

                entity.HasIndex(e => e.LAST_ACCESS_ECODE)
                    .HasName("SALPRICELISTMAIN_LK03");

                entity.HasIndex(e => e.PRICELISTCODE)
                    .HasName("P_SALPRICELISTMAIN_LISTCODE")
                    .IsUnique();

                entity.HasIndex(e => e.PRICELISTNAME)
                    .HasName("U_SALPRICELISTMAIN_LISTNAME")
                    .IsUnique();

                entity.Property(e => e.CMPTAX_CODE_BASIS)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.DISCOUNT_BASIS)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.DISCOUNT_FACTOR).HasColumnType("double");

                entity.Property(e => e.DISCOUNT_MODE)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.INCLUDE_VAT_IN_DISCOUNT)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.LAST_ACCESS_TIME).HasColumnType("date");

                entity.Property(e => e.NET_PRICE_MULTIPLES_OF)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.NET_PRICE_ROUND_LIMIT)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.PRICELISTNAME)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.PRICE_TYPE)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.REM)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.TIME).HasColumnType("date");
            });

            modelBuilder.Entity<SALTERMMAIN>(entity =>
            {
                entity.HasKey(e => e.SALTERMCODE);

                entity.ToTable("SALTERMMAIN", "MAIN");

                entity.HasIndex(e => e.FINTRADEGRP_CODE)
                    .HasName("SALTERMMAIN_LK02");

                entity.HasIndex(e => e.SALES_GLCODE)
                    .HasName("SALTERMMAIN_LK03");

                entity.HasIndex(e => e.SALES_RETURN_GLCODE)
                    .HasName("SALTERMMAIN_LK04");

                entity.HasIndex(e => e.SALES_RETURN_SLCODE)
                    .HasName("SALTERMMAIN_LK05");

                entity.HasIndex(e => e.SALES_SLCODE)
                    .HasName("SALTERMMAIN_LK06");

                entity.HasIndex(e => e.SALTERMCODE)
                    .HasName("P_SALTERMMAIN_SALTERMCODE")
                    .IsUnique();

                entity.HasIndex(e => e.SALTERMNAME)
                    .HasName("U_SALTERMMAIN_SALTERMNAME")
                    .IsUnique();

                entity.HasIndex(e => e.TERMGRPCODE)
                    .HasName("SALTERMMAIN_LK01");

                entity.Property(e => e.EXT)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.HEADER_LEVEL_ISCHANGEABLE)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.LINE_LEVEL_ISCHANGEABLE)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.SALTERMNAME)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.HasOne(d => d.FINTRADEGRP_CODENavigation)
                    .WithMany(p => p.SALTERMMAIN)
                    .HasForeignKey(d => d.FINTRADEGRP_CODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_SALTERMMAIN_FINTRADEGRP_CODE");

                entity.HasOne(d => d.SALES_GLCODENavigation)
                    .WithMany(p => p.SALTERMMAINSALES_GLCODENavigation)
                    .HasForeignKey(d => d.SALES_GLCODE)
                    .HasConstraintName("R_TERMMAIN_SALGLCODE");

                entity.HasOne(d => d.SALES_RETURN_GLCODENavigation)
                    .WithMany(p => p.SALTERMMAINSALES_RETURN_GLCODENavigation)
                    .HasForeignKey(d => d.SALES_RETURN_GLCODE)
                    .HasConstraintName("R_TERMMAIN_SALRETGLCODE");

                entity.HasOne(d => d.SALES_RETURN_SLCODENavigation)
                    .WithMany(p => p.SALTERMMAINSALES_RETURN_SLCODENavigation)
                    .HasForeignKey(d => d.SALES_RETURN_SLCODE)
                    .HasConstraintName("R_TERMMAIN_SALRETSLCODE");

                entity.HasOne(d => d.SALES_SLCODENavigation)
                    .WithMany(p => p.SALTERMMAINSALES_SLCODENavigation)
                    .HasForeignKey(d => d.SALES_SLCODE)
                    .HasConstraintName("R_TERMMAIN_SALSLCODE");
            });
        }
    }
}
