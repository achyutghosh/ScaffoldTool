using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ScaffoldTool.Events.PURORDMain
{
    public partial class PURORDMainEventContext : DbContext
    {
        public PURORDMainEventContext()
        {
        }

        public PURORDMainEventContext(DbContextOptions<PURORDMainEventContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ADMCITY> ADMCITY { get; set; }
        public virtual DbSet<ADMCURRENCY> ADMCURRENCY { get; set; }
        public virtual DbSet<ADMDOCSCHEME> ADMDOCSCHEME { get; set; }
        public virtual DbSet<ADMGSTIN> ADMGSTIN { get; set; }
        public virtual DbSet<ADMGSTSTATE> ADMGSTSTATE { get; set; }
        public virtual DbSet<ADMOU> ADMOU { get; set; }
        public virtual DbSet<ADMSITE> ADMSITE { get; set; }
        public virtual DbSet<FINSL> FINSL { get; set; }
        public virtual DbSet<FINTRADEGRP> FINTRADEGRP { get; set; }
        public virtual DbSet<HRDEMP> HRDEMP { get; set; }
        public virtual DbSet<INVITEM> INVITEM { get; set; }
        public virtual DbSet<PURORDCHG> PURORDCHG { get; set; }
        public virtual DbSet<PURORDCHG_ITEM> PURORDCHG_ITEM { get; set; }
        public virtual DbSet<PURORDDET> PURORDDET { get; set; }
        public virtual DbSet<PURORDMAIN> PURORDMAIN { get; set; }

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

                entity.HasOne(d => d.CREATEDBYNavigation)
                    .WithMany(p => p.ADMCURRENCYCREATEDBYNavigation)
                    .HasForeignKey(d => d.CREATEDBY)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ADMCURRENCY_R01");

                entity.HasOne(d => d.LASTMODIFIEDBYNavigation)
                    .WithMany(p => p.ADMCURRENCYLASTMODIFIEDBYNavigation)
                    .HasForeignKey(d => d.LASTMODIFIEDBY)
                    .HasConstraintName("ADMCURRENCY_R02");
            });

            modelBuilder.Entity<ADMDOCSCHEME>(entity =>
            {
                entity.HasKey(e => e.DOCCODE);

                entity.ToTable("ADMDOCSCHEME", "MAIN");

                entity.HasIndex(e => e.CMPCODE)
                    .HasName("ADMDOCSCHEME_LK01");

                entity.HasIndex(e => e.DOCCODE)
                    .HasName("ADMDOCSCHEME_PK")
                    .IsUnique();

                entity.HasIndex(e => new { e.CMPCODE, e.DOCNAME })
                    .HasName("ADMDOCSCHEME_U01")
                    .IsUnique();

                entity.Property(e => e.BASEDON)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.DEFAULT_SUFFIX)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.DEFAULT_SUFFIX_MUSK)
                    .HasColumnType("varchar2")
                    .HasMaxLength(10);

                entity.Property(e => e.DOC).HasColumnType("date");

                entity.Property(e => e.DOCCODE_WISE)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.DOCNAME)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.DOM).HasColumnType("date");

                entity.Property(e => e.EXT)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.GENERATION_BASIS)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.GENERATION_INTERVAL)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.GSTAPPL)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.ISEXCISE)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.MANUAL)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.PREFILL)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.PREFIX)
                    .HasColumnType("varchar2")
                    .HasMaxLength(24);

                entity.Property(e => e.REMARKS)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.SAMPLE_DOCNO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.SEPERATOR1)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.SEPERATOR2)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.STARTING)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 24)
                    .HasAnnotation("Scale", 0);

                entity.Property(e => e.SUFFIX)
                    .HasColumnType("varchar2")
                    .HasMaxLength(24);

                entity.Property(e => e.SUFFIX_ATTACHMENT)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.SYSTEM_GENERATED)
                    .HasColumnType("char")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<ADMGSTIN>(entity =>
            {
                entity.HasKey(e => e.CODE);

                entity.ToTable("ADMGSTIN", "MAIN");

                entity.HasIndex(e => e.ADMGSTSTATE_CODE)
                    .HasName("ADMGSTIN_LK21");

                entity.HasIndex(e => e.ADMOU_CODE)
                    .HasName("ADMGSTIN_LK20");

                entity.HasIndex(e => e.CESS_INPUT_GLCODE)
                    .HasName("ADMGSTIN_LK02");

                entity.HasIndex(e => e.CESS_INPUT_SLCODE)
                    .HasName("ADMGSTIN_LK03");

                entity.HasIndex(e => e.CESS_OUTPUT_GLCODE)
                    .HasName("ADMGSTIN_LK04");

                entity.HasIndex(e => e.CESS_OUTPUT_SLCODE)
                    .HasName("ADMGSTIN_LK05");

                entity.HasIndex(e => e.CGST_INPUT_GLCODE)
                    .HasName("ADMGSTIN_LK06");

                entity.HasIndex(e => e.CGST_INPUT_SLCODE)
                    .HasName("ADMGSTIN_LK07");

                entity.HasIndex(e => e.CGST_OUTPUT_GLCODE)
                    .HasName("ADMGSTIN_LK08");

                entity.HasIndex(e => e.CGST_OUTPUT_SLCODE)
                    .HasName("ADMGSTIN_LK09");

                entity.HasIndex(e => e.CODE)
                    .HasName("ADMGSTIN_PK")
                    .IsUnique();

                entity.HasIndex(e => e.CREATEDBY)
                    .HasName("ADMGSTIN_LK10");

                entity.HasIndex(e => e.GSTIN_NO)
                    .HasName("ADMGSTIN_UK")
                    .IsUnique();

                entity.HasIndex(e => e.IGST_INPUT_GLCODE)
                    .HasName("ADMGSTIN_LK11");

                entity.HasIndex(e => e.IGST_INPUT_SLCODE)
                    .HasName("ADMGSTIN_LK12");

                entity.HasIndex(e => e.IGST_OUTPUT_GLCODE)
                    .HasName("ADMGSTIN_LK13");

                entity.HasIndex(e => e.IGST_OUTPUT_SLCODE)
                    .HasName("ADMGSTIN_LK14");

                entity.HasIndex(e => e.LASTMODIFIEDBY)
                    .HasName("ADMGSTIN_LK15");

                entity.HasIndex(e => e.PPOB)
                    .HasName("ADMGSTIN_U01")
                    .IsUnique();

                entity.HasIndex(e => e.SGST_INPUT_GLCODE)
                    .HasName("ADMGSTIN_LK16");

                entity.HasIndex(e => e.SGST_INPUT_SLCODE)
                    .HasName("ADMGSTIN_LK17");

                entity.HasIndex(e => e.SGST_OUTPUT_GLCODE)
                    .HasName("ADMGSTIN_LK18");

                entity.HasIndex(e => e.SGST_OUTPUT_SLCODE)
                    .HasName("ADMGSTIN_LK19");

                entity.Property(e => e.ADMGSTSTATE_CODE)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(2);

                entity.Property(e => e.CREATEDON).HasColumnType("date");

                entity.Property(e => e.EXTINCT)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.GSTIN_DATE).HasColumnType("date");

                entity.Property(e => e.GSTIN_NO)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(15);

                entity.Property(e => e.LASTMODIFIEDON).HasColumnType("date");

                entity.Property(e => e.REMARKS)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.HasOne(d => d.ADMGSTSTATE_CODENavigation)
                    .WithMany(p => p.ADMGSTIN)
                    .HasForeignKey(d => d.ADMGSTSTATE_CODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ADMGSTIN_R02");

                entity.HasOne(d => d.ADMOU_CODENavigation)
                    .WithMany(p => p.ADMGSTIN)
                    .HasForeignKey(d => d.ADMOU_CODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ADMGSTIN_R01");

                entity.HasOne(d => d.CESS_INPUT_SLCODENavigation)
                    .WithMany(p => p.ADMGSTINCESS_INPUT_SLCODENavigation)
                    .HasForeignKey(d => d.CESS_INPUT_SLCODE)
                    .HasConstraintName("ADMGSTIN_R16");

                entity.HasOne(d => d.CESS_OUTPUT_SLCODENavigation)
                    .WithMany(p => p.ADMGSTINCESS_OUTPUT_SLCODENavigation)
                    .HasForeignKey(d => d.CESS_OUTPUT_SLCODE)
                    .HasConstraintName("ADMGSTIN_R18");

                entity.HasOne(d => d.CGST_INPUT_SLCODENavigation)
                    .WithMany(p => p.ADMGSTINCGST_INPUT_SLCODENavigation)
                    .HasForeignKey(d => d.CGST_INPUT_SLCODE)
                    .HasConstraintName("ADMGSTIN_R08");

                entity.HasOne(d => d.CGST_OUTPUT_SLCODENavigation)
                    .WithMany(p => p.ADMGSTINCGST_OUTPUT_SLCODENavigation)
                    .HasForeignKey(d => d.CGST_OUTPUT_SLCODE)
                    .HasConstraintName("ADMGSTIN_R10");

                entity.HasOne(d => d.CREATEDBYNavigation)
                    .WithMany(p => p.ADMGSTINCREATEDBYNavigation)
                    .HasForeignKey(d => d.CREATEDBY)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ADMGSTIN_R19");

                entity.HasOne(d => d.IGST_INPUT_SLCODENavigation)
                    .WithMany(p => p.ADMGSTINIGST_INPUT_SLCODENavigation)
                    .HasForeignKey(d => d.IGST_INPUT_SLCODE)
                    .HasConstraintName("ADMGSTIN_R04");

                entity.HasOne(d => d.IGST_OUTPUT_SLCODENavigation)
                    .WithMany(p => p.ADMGSTINIGST_OUTPUT_SLCODENavigation)
                    .HasForeignKey(d => d.IGST_OUTPUT_SLCODE)
                    .HasConstraintName("ADMGSTIN_R06");

                entity.HasOne(d => d.LASTMODIFIEDBYNavigation)
                    .WithMany(p => p.ADMGSTINLASTMODIFIEDBYNavigation)
                    .HasForeignKey(d => d.LASTMODIFIEDBY)
                    .HasConstraintName("ADMGSTIN_R20");

                entity.HasOne(d => d.PPOBNavigation)
                    .WithOne(p => p.ADMGSTIN)
                    .HasForeignKey<ADMGSTIN>(d => d.PPOB)
                    .HasConstraintName("ADMGSTIN_R21");

                entity.HasOne(d => d.SGST_INPUT_SLCODENavigation)
                    .WithMany(p => p.ADMGSTINSGST_INPUT_SLCODENavigation)
                    .HasForeignKey(d => d.SGST_INPUT_SLCODE)
                    .HasConstraintName("ADMGSTIN_R12");

                entity.HasOne(d => d.SGST_OUTPUT_SLCODENavigation)
                    .WithMany(p => p.ADMGSTINSGST_OUTPUT_SLCODENavigation)
                    .HasForeignKey(d => d.SGST_OUTPUT_SLCODE)
                    .HasConstraintName("ADMGSTIN_R14");
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

            modelBuilder.Entity<ADMOU>(entity =>
            {
                entity.HasKey(e => e.CODE);

                entity.ToTable("ADMOU", "MAIN");

                entity.HasIndex(e => e.ADMCMPTAX_CODE)
                    .HasName("ADMOU_LK01");

                entity.HasIndex(e => e.CODE)
                    .HasName("P_ADMOU_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.CONSIGNMENTSALE_GLCODE)
                    .HasName("ADMOU_LK19");

                entity.HasIndex(e => e.CONSIGNMENTSALE_SLCODE)
                    .HasName("ADMOU_LK20");

                entity.HasIndex(e => e.CREDITNOTE_GLCODE)
                    .HasName("ADMOU_LK13");

                entity.HasIndex(e => e.DEBITNOTE_GLCODE)
                    .HasName("ADMOU_LK18");

                entity.HasIndex(e => e.DEFAULT_HO_SITE)
                    .HasName("ADMOU_LK21");

                entity.HasIndex(e => e.GVCONTROL_GLCODE)
                    .HasName("ADMOU_LK14");

                entity.HasIndex(e => e.GVDISCOUNT_GLCODE)
                    .HasName("ADMOU_LK15");

                entity.HasIndex(e => e.INLOCCODE)
                    .HasName("ADMOU_LK02");

                entity.HasIndex(e => e.NAME)
                    .HasName("U_ADMOU_NAME")
                    .IsUnique();

                entity.HasIndex(e => e.OUTLOCCODE)
                    .HasName("ADMOU_LK03");

                entity.HasIndex(e => e.PKGLOCCODE)
                    .HasName("ADMOU_LK04");

                entity.HasIndex(e => e.REDEMPTION_GLCODE)
                    .HasName("ADMOU_LK16");

                entity.HasIndex(e => e.ROUNDOFF_GLCODE)
                    .HasName("ADMOU_LK17");

                entity.HasIndex(e => e.SHRTNAME)
                    .HasName("U_ADMOU_SHRTNAME")
                    .IsUnique();

                entity.HasIndex(e => e.TRANSFERIN_GLCODE)
                    .HasName("ADMOU_LK05");

                entity.HasIndex(e => e.TRANSFERIN_SLCODE)
                    .HasName("ADMOU_LK06");

                entity.HasIndex(e => e.TRANSFEROUT_GLCODE)
                    .HasName("ADMOU_LK07");

                entity.HasIndex(e => e.TRANSFEROUT_SLCODE)
                    .HasName("ADMOU_LK08");

                entity.HasIndex(e => e.TRANSITDIFF_GLCODE)
                    .HasName("ADMOU_LK09");

                entity.HasIndex(e => e.TRANSITDIFF_SLCODE)
                    .HasName("ADMOU_LK10");

                entity.HasIndex(e => e.TRANSIT_GLCODE)
                    .HasName("ADMOU_LK11");

                entity.HasIndex(e => e.TRANSIT_SLCODE)
                    .HasName("ADMOU_LK12");

                entity.Property(e => e.ADDRESS)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.CINNO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.CNNAME)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.CONTACT_PERSON)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.CREATED_ON).HasColumnType("date");

                entity.Property(e => e.CSTNO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.CTNAME)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.EMAIL1)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.EMAIL2)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.EXC)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.EXP)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.EXT)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.EXT_ON).HasColumnType("date");

                entity.Property(e => e.FAX)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.LASTMODIFIED_ON).HasColumnType("date");

                entity.Property(e => e.LOGO_NAME)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.LSTNO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.MOBILE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.NAME)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.OPH1)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.OPH2)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.OPH3)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.PAN)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.PIN)
                    .HasColumnType("varchar2")
                    .HasMaxLength(12);

                entity.Property(e => e.RPH1)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.SERVICETAXDATE).HasColumnType("date");

                entity.Property(e => e.SERVICETAXNO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.SHRTNAME)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.STNAME)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.TANNO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.TANWARD)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.TLNO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.WEBSITE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CONSIGNMENTSALE_SLCODENavigation)
                    .WithMany(p => p.ADMOUCONSIGNMENTSALE_SLCODENavigation)
                    .HasForeignKey(d => d.CONSIGNMENTSALE_SLCODE)
                    .HasConstraintName("R_ADMOU_CONSIGNMENTSALE_SL");

                entity.HasOne(d => d.DEFAULT_HO_SITENavigation)
                    .WithMany(p => p.ADMOU)
                    .HasForeignKey(d => d.DEFAULT_HO_SITE)
                    .HasConstraintName("ADMOU_DEFAULT_HO_SITE");

                entity.HasOne(d => d.TRANSFERIN_SLCODENavigation)
                    .WithMany(p => p.ADMOUTRANSFERIN_SLCODENavigation)
                    .HasForeignKey(d => d.TRANSFERIN_SLCODE)
                    .HasConstraintName("R_ADMOU_TRANSFERIN_SLCODE");

                entity.HasOne(d => d.TRANSFEROUT_SLCODENavigation)
                    .WithMany(p => p.ADMOUTRANSFEROUT_SLCODENavigation)
                    .HasForeignKey(d => d.TRANSFEROUT_SLCODE)
                    .HasConstraintName("R_ADMOU_TRANSFEROUT_SLCODE");

                entity.HasOne(d => d.TRANSITDIFF_SLCODENavigation)
                    .WithMany(p => p.ADMOUTRANSITDIFF_SLCODENavigation)
                    .HasForeignKey(d => d.TRANSITDIFF_SLCODE)
                    .HasConstraintName("R_ADMOU_TRANSITDIFF_SLCODE");

                entity.HasOne(d => d.TRANSIT_SLCODENavigation)
                    .WithMany(p => p.ADMOUTRANSIT_SLCODENavigation)
                    .HasForeignKey(d => d.TRANSIT_SLCODE)
                    .HasConstraintName("R_ADMOU_TRANSIT_SLCODE");
            });

            modelBuilder.Entity<ADMSITE>(entity =>
            {
                entity.HasKey(e => e.CODE);

                entity.ToTable("ADMSITE", "MAIN");

                entity.HasIndex(e => e.ADMGSTIN_CODE)
                    .HasName("ADMSITE_LK21");

                entity.HasIndex(e => e.ADMISD_CODE)
                    .HasName("ADMSITE_LK25");

                entity.HasIndex(e => e.ADMOU_CODE)
                    .HasName("ADMSITE_LK12");

                entity.HasIndex(e => e.CMPCODE)
                    .HasName("ADMSITE_LK01");

                entity.HasIndex(e => e.CODE)
                    .HasName("P_ADMSITE_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.CP_GSTIN_STATE_CODE)
                    .HasName("ADMSITE_LK22");

                entity.HasIndex(e => e.DEFAULT_PICKLIST_RULE)
                    .HasName("ADMSITE_LK20");

                entity.HasIndex(e => e.INLOCCODE)
                    .HasName("ADMSITE_LK14");

                entity.HasIndex(e => e.OUTLOCCODE)
                    .HasName("ADMSITE_LK15");

                entity.HasIndex(e => e.PRICELIST_CODE)
                    .HasName("ADMSITE_LK13");

                entity.HasIndex(e => e.PSITE_ADMCMPTAX_CODE)
                    .HasName("ADMSITE_LK02");

                entity.HasIndex(e => e.PSITE_ALLOCATION_CODE)
                    .HasName("ADMSITE_LK08");

                entity.HasIndex(e => e.PSITE_GROUP_CODE)
                    .HasName("ADMSITE_LK09");

                entity.HasIndex(e => e.PSITE_KEY)
                    .HasName("ADMSITE_PSITE_U01")
                    .IsUnique();

                entity.HasIndex(e => e.PSITE_LOCALPOLICY_CODE)
                    .HasName("ADMSITE_LK10");

                entity.HasIndex(e => e.PSITE_PROMO_ALLOCATION_CODE)
                    .HasName("ADMSITE_LK11");

                entity.HasIndex(e => e.PSITE_SI_ALLOCATION_CODE)
                    .HasName("ADMSITE_LK17");

                entity.HasIndex(e => e.PSITE_STOCKPOINT_CODE)
                    .HasName("ADMSITE_LK16");

                entity.HasIndex(e => e.PSITE_TRANSIT_LOCCODE)
                    .HasName("ADMSITE_LK03");

                entity.HasIndex(e => e.SALFORMCODE)
                    .HasName("ADMSITE_LK18");

                entity.HasIndex(e => e.SALTRADEGRP_CODE)
                    .HasName("ADMSITE_LK19");

                entity.HasIndex(e => e.SHIP_CP_CATEGORY_CODE)
                    .HasName("ADMSITE_LK23");

                entity.HasIndex(e => e.SHIP_CP_GSTIN_STATE_CODE)
                    .HasName("ADMSITE_LK24");

                entity.HasIndex(e => e.SITEDOCIN)
                    .HasName("ADMSITE_PSITE_U02");

                entity.HasIndex(e => e.SITETYPE)
                    .HasName("I_ADMSITE_SITETYPE");

                entity.HasIndex(e => e.SLCODE)
                    .HasName("ADMSITE_LK04");

                entity.HasIndex(e => e.STORE_LOCCODE)
                    .HasName("ADMSITE_LK05");

                entity.HasIndex(e => e.TERMCODE)
                    .HasName("ADMSITE_LK06");

                entity.HasIndex(e => e.TRPCODE)
                    .HasName("ADMSITE_LK07");

                entity.HasIndex(e => new { e.SLCODE, e.NAME })
                    .HasName("U_ADMSITE_SLCODE_NAME")
                    .IsUnique();

                entity.Property(e => e.ADDRESS)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.CONTACT_PERSON)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.CP)
                    .HasColumnType("varchar2")
                    .HasMaxLength(15);

                entity.Property(e => e.CP_GSTIN_DATE).HasColumnType("date");

                entity.Property(e => e.CP_GSTIN_NO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(15);

                entity.Property(e => e.CP_GSTIN_STATE_CODE)
                    .HasColumnType("char")
                    .HasMaxLength(2);

                entity.Property(e => e.CSTDATE).HasColumnType("date");

                entity.Property(e => e.CSTNO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.CTNAME)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.EMAIL1)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.EMAIL2)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.EXT)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.FAX)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.GATEIN_APPL)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.INSTALLATION_TYPE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.ISBILLINGSHIPPINGSAME)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.ISPOS)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.ISPROMOSEND_BLOCKED)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.ISSECONDARY)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.LASTDIFFBACKUPENDTIME).HasColumnType("date");

                entity.Property(e => e.LASTFULLBACKUPENDTIME).HasColumnType("date");

                entity.Property(e => e.LASTSYNCENDTIME).HasColumnType("date");

                entity.Property(e => e.LGT_APPL)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.LSTDATE).HasColumnType("date");

                entity.Property(e => e.LSTNO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.MOBILE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.NAME)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.OPERATIONSTARTDATE).HasColumnType("date");

                entity.Property(e => e.OPH1)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.OPH2)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.OPH3)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.OUT_LGT_APPL)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.OUT_PERMIT_APPL)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.PERMIT_APPL)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.PIN)
                    .HasColumnType("varchar2")
                    .HasMaxLength(12);

                entity.Property(e => e.PRICEFACTOR).HasColumnType("double");

                entity.Property(e => e.PRICETYPE)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.PSITE_INITIAL)
                    .HasColumnType("varchar2")
                    .HasMaxLength(14);

                entity.Property(e => e.PSITE_ISPUBLISHED)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.PSITE_KEY)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.PSITE_STOCKPOINT_CODE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.PSITE_STOPSYNC)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.PSITE_TIMEZONE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(200);

                entity.Property(e => e.REPORTNAME)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.RESERVE_INV)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.RPH1)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.SHIP_ADDRESS)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.SHIP_CINNO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.SHIP_CONTACT_PERSON)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.SHIP_CP_GSTIN_DATE).HasColumnType("date");

                entity.Property(e => e.SHIP_CP_GSTIN_NO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(15);

                entity.Property(e => e.SHIP_CP_GSTIN_STATE_CODE)
                    .HasColumnType("char")
                    .HasMaxLength(2);

                entity.Property(e => e.SHIP_CTNAME)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.SHIP_EMAIL1)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.SHIP_EMAIL2)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.SHIP_FAX)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.SHIP_LEGAL_NAME)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.SHIP_MOBILE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.SHIP_OPH1)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.SHIP_OPH2)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.SHIP_OPH3)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.SHIP_PIN)
                    .HasColumnType("varchar2")
                    .HasMaxLength(12);

                entity.Property(e => e.SHIP_RPH1)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.SHIP_WEBSITE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.SHRTNAME)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.SITEDOCIN)
                    .HasColumnType("char")
                    .HasMaxLength(3);

                entity.Property(e => e.SITETYPE)
                    .IsRequired()
                    .HasColumnType("varchar2")
                    .HasMaxLength(15);

                entity.Property(e => e.STORE_CLOSEDT).HasColumnType("date");

                entity.Property(e => e.STORE_STARTDT).HasColumnType("date");

                entity.Property(e => e.STORE_TARGET_SALES)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.UDFSTRING01)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING02)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING03)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING04)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING05)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING06)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING07)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING08)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING09)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING10)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING11)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING12)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING13)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING14)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING15)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.VERSION)
                    .HasColumnType("varchar2")
                    .HasMaxLength(15);

                entity.Property(e => e.WEBSITE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.HasOne(d => d.ADMGSTIN_CODENavigation)
                    .WithMany(p => p.ADMSITE)
                    .HasForeignKey(d => d.ADMGSTIN_CODE)
                    .HasConstraintName("ADMSITE_PSITE_R07");

                entity.HasOne(d => d.ADMOU_CODENavigation)
                    .WithMany(p => p.ADMSITE)
                    .HasForeignKey(d => d.ADMOU_CODE)
                    .HasConstraintName("R_ADMSITE_ADMOU_CODE");

                entity.HasOne(d => d.CP_GSTIN_STATE_CODENavigation)
                    .WithMany(p => p.ADMSITECP_GSTIN_STATE_CODENavigation)
                    .HasForeignKey(d => d.CP_GSTIN_STATE_CODE)
                    .HasConstraintName("ADMSITE_PSITE_R06");

                entity.HasOne(d => d.CTNAMENavigation)
                    .WithMany(p => p.ADMSITE)
                    .HasPrincipalKey(p => p.CTNAME)
                    .HasForeignKey(d => d.CTNAME)
                    .HasConstraintName("R_ADMSITE_CTNAME");

                entity.HasOne(d => d.SALTRADEGRP_CODENavigation)
                    .WithMany(p => p.ADMSITE)
                    .HasForeignKey(d => d.SALTRADEGRP_CODE)
                    .HasConstraintName("R_ADMSITE_SALTRADEGRP_CODE");

                entity.HasOne(d => d.SHIP_CP_GSTIN_STATE_CODENavigation)
                    .WithMany(p => p.ADMSITESHIP_CP_GSTIN_STATE_CODENavigation)
                    .HasForeignKey(d => d.SHIP_CP_GSTIN_STATE_CODE)
                    .HasConstraintName("R_SHIP_CP_GSTIN_STATE_CODE");

                entity.HasOne(d => d.SLCODENavigation)
                    .WithMany(p => p.ADMSITESLCODENavigation)
                    .HasForeignKey(d => d.SLCODE)
                    .HasConstraintName("R_ADMSITE_SLCODE");

                entity.HasOne(d => d.TRPCODENavigation)
                    .WithMany(p => p.ADMSITETRPCODENavigation)
                    .HasForeignKey(d => d.TRPCODE)
                    .HasConstraintName("R_ADMSITE_TRPCODE");
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

                entity.HasOne(d => d.CONSIGNMENT_SALES_SLCODENavigation)
                    .WithMany(p => p.InverseCONSIGNMENT_SALES_SLCODENavigation)
                    .HasForeignKey(d => d.CONSIGNMENT_SALES_SLCODE)
                    .HasConstraintName("R_FINSL_CONSIGNSALESLCODE");

                entity.HasOne(d => d.CONSIGNMENT_SLCODENavigation)
                    .WithMany(p => p.InverseCONSIGNMENT_SLCODENavigation)
                    .HasForeignKey(d => d.CONSIGNMENT_SLCODE)
                    .HasConstraintName("R_FINSL_CONSIGNMENT_SLCODE");

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

                entity.HasOne(d => d.PURCHASE_RETURN_SLCODENavigation)
                    .WithMany(p => p.InversePURCHASE_RETURN_SLCODENavigation)
                    .HasForeignKey(d => d.PURCHASE_RETURN_SLCODE)
                    .HasConstraintName("R_FINSL_PUR_RETURN_SLCODE");

                entity.HasOne(d => d.PURCHASE_SLCODENavigation)
                    .WithMany(p => p.InversePURCHASE_SLCODENavigation)
                    .HasForeignKey(d => d.PURCHASE_SLCODE)
                    .HasConstraintName("R_FINSL_PURCHASE_SLCODE");

                entity.HasOne(d => d.SALES_RETURN_SLCODENavigation)
                    .WithMany(p => p.InverseSALES_RETURN_SLCODENavigation)
                    .HasForeignKey(d => d.SALES_RETURN_SLCODE)
                    .HasConstraintName("R_FINSL_SALESRETSLCODE");

                entity.HasOne(d => d.SALES_SLCODENavigation)
                    .WithMany(p => p.InverseSALES_SLCODENavigation)
                    .HasForeignKey(d => d.SALES_SLCODE)
                    .HasConstraintName("R_FINSL_SALES_SLCODE");

                entity.HasOne(d => d.SALTRADEGRP_CODENavigation)
                    .WithMany(p => p.FINSLSALTRADEGRP_CODENavigation)
                    .HasForeignKey(d => d.SALTRADEGRP_CODE)
                    .HasConstraintName("R_FINSL_SALTRADEGRP_CODE");

                entity.HasOne(d => d.SCTNAMENavigation)
                    .WithMany(p => p.FINSLSCTNAMENavigation)
                    .HasPrincipalKey(p => p.CTNAME)
                    .HasForeignKey(d => d.SCTNAME)
                    .HasConstraintName("R_FINSL_SCTNAME");

                entity.HasOne(d => d.TRANSITDIFF_SLCODENavigation)
                    .WithMany(p => p.InverseTRANSITDIFF_SLCODENavigation)
                    .HasForeignKey(d => d.TRANSITDIFF_SLCODE)
                    .HasConstraintName("R_FINSL_TRANSITDIFF_SLCODE");

                entity.HasOne(d => d.TRANSIT_SLCODENavigation)
                    .WithMany(p => p.InverseTRANSIT_SLCODENavigation)
                    .HasForeignKey(d => d.TRANSIT_SLCODE)
                    .HasConstraintName("R_FINSL_TRANSIT_SLCODE");

                entity.HasOne(d => d.TRPCODENavigation)
                    .WithMany(p => p.InverseTRPCODENavigation)
                    .HasForeignKey(d => d.TRPCODE)
                    .HasConstraintName("R_FINSL_TRPCODE");

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

                entity.Property(e => e.NEWCOLUMN)
                    .HasColumnType("varchar2")
                    .HasMaxLength(10);

                entity.Property(e => e.NEWCOLUMN1).HasColumnType("double");

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

                entity.HasOne(d => d.PARTYCODENavigation)
                    .WithMany(p => p.INVITEMPARTYCODENavigation)
                    .HasForeignKey(d => d.PARTYCODE)
                    .HasConstraintName("R_INVITEM_SLCODE");

                entity.HasOne(d => d.SLCODENavigation)
                    .WithMany(p => p.INVITEMSLCODENavigation)
                    .HasForeignKey(d => d.SLCODE)
                    .HasConstraintName("R_INVITEM_POST_SLCODE");
            });

            modelBuilder.Entity<PURORDCHG>(entity =>
            {
                entity.HasKey(e => e.CODE);

                entity.ToTable("PURORDCHG", "MAIN");

                entity.HasIndex(e => e.CHGCODE)
                    .HasName("PURORDCHG_LK01");

                entity.HasIndex(e => e.CODE)
                    .HasName("PURORDCHG_PK")
                    .IsUnique();

                entity.HasIndex(e => e.ORDCODE)
                    .HasName("PURORDCHG_LK02");

                entity.HasIndex(e => new { e.ORDCODE, e.CHGCODE, e.RATE })
                    .HasName("U_PURORDCHG_ORD_CHG_RATE")
                    .IsUnique();

                entity.Property(e => e.APPAMT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.BASIS)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.CHGAMT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.FORMULAE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.GST_COMPONENT)
                    .HasColumnType("char")
                    .HasMaxLength(4);

                entity.Property(e => e.ISREVERSE)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.ISTAX)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.OPERATION_LEVEL)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.RATE)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.SIGN)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.SOURCE)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.WITHOUT_TERM_FORMULA)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.HasOne(d => d.ORDCODENavigation)
                    .WithMany(p => p.PURORDCHG)
                    .HasForeignKey(d => d.ORDCODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_PURORDCHG_ORDCODE");
            });

            modelBuilder.Entity<PURORDCHG_ITEM>(entity =>
            {
                entity.HasKey(e => e.CODE);

                entity.ToTable("PURORDCHG_ITEM", "MAIN");

                entity.HasIndex(e => e.CHGCODE)
                    .HasName("PURORDCHG_ITEM_LK01");

                entity.HasIndex(e => e.CODE)
                    .HasName("PURORDCHG_ITEM_PK")
                    .IsUnique();

                entity.HasIndex(e => e.ORDCODE)
                    .HasName("PURORDCHG_ITEM_LK02");

                entity.HasIndex(e => e.PURORDDET_CODE)
                    .HasName("PURORDCHG_ITEM_LK03");

                entity.Property(e => e.APPAMT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.BASIS)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.CHGAMT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.FORMULAE)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.GST_COMPONENT)
                    .HasColumnType("char")
                    .HasMaxLength(4);

                entity.Property(e => e.ISREVERSE)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.ISTAX)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.OPERATION_LEVEL)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.RATE)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.SIGN)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.SOURCE)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.HasOne(d => d.ORDCODENavigation)
                    .WithMany(p => p.PURORDCHG_ITEM)
                    .HasForeignKey(d => d.ORDCODE)
                    .HasConstraintName("R_PURORDCHG_ITEM_ORDCODE");

                entity.HasOne(d => d.PURORDDET_CODENavigation)
                    .WithMany(p => p.PURORDCHG_ITEM)
                    .HasForeignKey(d => d.PURORDDET_CODE)
                    .HasConstraintName("R_PURORDCHG_ITEM_PURORDDETCODE");
            });

            modelBuilder.Entity<PURORDDET>(entity =>
            {
                entity.HasKey(e => e.CODE);

                entity.ToTable("PURORDDET", "MAIN");

                entity.HasIndex(e => e.CODE)
                    .HasName("PURORDDET_PK")
                    .IsUnique();

                entity.HasIndex(e => e.EXCISEMAIN_CODE)
                    .HasName("PURORDDET_LK03");

                entity.HasIndex(e => e.ICODE)
                    .HasName("PURORDDET_LK01");

                entity.HasIndex(e => e.ORDCODE)
                    .HasName("PURORDDET_LK02");

                entity.HasIndex(e => new { e.ORDCODE, e.ICODE, e.RATE, e.INVSETMAIN_CODE })
                    .HasName("U_PURORDDET_ORD_ICODE_SET_RATE")
                    .IsUnique();

                entity.Property(e => e.CNLQTY)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.DISCHGPER)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.DISCOUNT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.EX_ABTFACTOR)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.EX_APPAMT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.EX_APPLICABLE_FROM).HasColumnType("double");

                entity.Property(e => e.EX_BASIS)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.EX_CESSAMT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.EX_CESSFACTOR)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.EX_DUTYAMT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.EX_DUTYFACTOR)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.EX_EFFRATE)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 2);

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

                entity.Property(e => e.NETAMT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.OQTY)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.ORDQTY)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.RATE)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.RCQTY)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.REM)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.RSP)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.TAXAMT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.TAXCHGPER)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.TOLERANCE).HasColumnType("double");

                entity.HasOne(d => d.ICODENavigation)
                    .WithMany(p => p.PURORDDET)
                    .HasForeignKey(d => d.ICODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_PURORDDET_ICODE");

                entity.HasOne(d => d.ORDCODENavigation)
                    .WithMany(p => p.PURORDDET)
                    .HasForeignKey(d => d.ORDCODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_PURORDDET_ORDCODE");
            });

            modelBuilder.Entity<PURORDMAIN>(entity =>
            {
                entity.HasKey(e => e.ORDCODE);

                entity.ToTable("PURORDMAIN", "MAIN");

                entity.HasIndex(e => e.ADMCURRENCY_CODE)
                    .HasName("PURORDMAIN_LK14");

                entity.HasIndex(e => e.ADMOU_CODE)
                    .HasName("PURORDMAIN_LK13");

                entity.HasIndex(e => e.ADMSITE_CODE)
                    .HasName("PURORDMAIN_LK17");

                entity.HasIndex(e => e.AGCODE)
                    .HasName("PURORDMAIN_LK01");

                entity.HasIndex(e => e.AUTHORCODE)
                    .HasName("PURORDMAIN_LK02");

                entity.HasIndex(e => e.CREATORCMPCODE)
                    .HasName("PURORDMAIN_LK10");

                entity.HasIndex(e => e.DATAVERSION)
                    .HasName("U_PURORDMAIN_DATAVERSION")
                    .IsUnique();

                entity.HasIndex(e => e.DESCCMPCODE)
                    .HasName("PURORDMAIN_LK03");

                entity.HasIndex(e => e.DOCCODE)
                    .HasName("PURORDMAIN_LK12");

                entity.HasIndex(e => e.ECODE)
                    .HasName("PURORDMAIN_LK04");

                entity.HasIndex(e => e.FINTRADEGRP_CODE)
                    .HasName("PURORDMAIN_LK15");

                entity.HasIndex(e => e.FORMCODE)
                    .HasName("PURORDMAIN_LK18");

                entity.HasIndex(e => e.INTGCODE)
                    .HasName("PURORDMAIN_LK20");

                entity.HasIndex(e => e.LAST_ACCESS_ECODE)
                    .HasName("PURORDMAIN_LK05");

                entity.HasIndex(e => e.MRCHNDSRCODE)
                    .HasName("PURORDMAIN_LK16");

                entity.HasIndex(e => e.ORDCMPCODE)
                    .HasName("PURORDMAIN_LK06");

                entity.HasIndex(e => e.ORDCODE)
                    .HasName("P_PURORDMAIN_ORDCODE")
                    .IsUnique();

                entity.HasIndex(e => e.PCODE)
                    .HasName("PURORDMAIN_LK07");

                entity.HasIndex(e => e.PURTERMCODE)
                    .HasName("PURORDMAIN_LK19");

                entity.HasIndex(e => e.TRPCODE)
                    .HasName("PURORDMAIN_LK08");

                entity.HasIndex(e => e.TXNCODE)
                    .HasName("PURORDMAIN_LK11");

                entity.HasIndex(e => e.YCODE)
                    .HasName("PURORDMAIN_LK09");

                entity.HasIndex(e => new { e.ORDNO, e.YCODE, e.TEMPLATE_FLG })
                    .HasName("U_PURORDMAIN_ORDNO_YCODE_TMPL")
                    .IsUnique();

                entity.Property(e => e.AGRATE)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.AUTHORIZATIONTIME).HasColumnType("date");

                entity.Property(e => e.CHGAMT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.DISCHGPER)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.DOCNO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.DTFR).HasColumnType("date");

                entity.Property(e => e.DTTO).HasColumnType("date");

                entity.Property(e => e.EXRATE).HasColumnType("double");

                entity.Property(e => e.GRSAMT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.INTGCODE)
                    .HasColumnType("char")
                    .HasMaxLength(3);

                entity.Property(e => e.INTG_STG_ID)
                    .HasColumnType("varchar2")
                    .HasMaxLength(50);

                entity.Property(e => e.LAST_ACCESS_TIME).HasColumnType("date");

                entity.Property(e => e.NETAMT)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.ORDDT).HasColumnType("date");

                entity.Property(e => e.PAYTERM)
                    .HasColumnType("varchar2")
                    .HasMaxLength(1000);

                entity.Property(e => e.PRINT_LABEL)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.REFSCHEME_DOCNO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.REM)
                    .HasColumnType("varchar2")
                    .HasMaxLength(500);

                entity.Property(e => e.SCHEME_DOCNO)
                    .HasColumnType("varchar2")
                    .HasMaxLength(25);

                entity.Property(e => e.SET_APPLICABLE)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.SOURCE_ORD)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.STAT)
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.TAXCHGPER)
                    .HasColumnType("decimal")
                    .HasAnnotation("Precision", 20)
                    .HasAnnotation("Scale", 3);

                entity.Property(e => e.TEMPLATE_FLG)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.Property(e => e.TIME).HasColumnType("date");

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

                entity.Property(e => e.UDFSTRING01)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING02)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING03)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING04)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING05)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING06)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING07)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING08)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING09)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.UDFSTRING10)
                    .HasColumnType("varchar2")
                    .HasMaxLength(100);

                entity.Property(e => e.WHETHER_CONSIGNMENT)
                    .IsRequired()
                    .HasColumnType("char")
                    .HasMaxLength(1);

                entity.HasOne(d => d.ADMCURRENCY_CODENavigation)
                    .WithMany(p => p.PURORDMAIN)
                    .HasForeignKey(d => d.ADMCURRENCY_CODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_PURORDMAIN_ADMCURRENCY_CODE");

                entity.HasOne(d => d.ADMOU_CODENavigation)
                    .WithMany(p => p.PURORDMAIN)
                    .HasForeignKey(d => d.ADMOU_CODE)
                    .HasConstraintName("R_PURORDMAIN_ADMOU_CODE");

                entity.HasOne(d => d.ADMSITE_CODENavigation)
                    .WithMany(p => p.PURORDMAIN)
                    .HasForeignKey(d => d.ADMSITE_CODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_PURORDMAIN_ADMSITE_CODE");

                entity.HasOne(d => d.AGCODENavigation)
                    .WithMany(p => p.PURORDMAINAGCODENavigation)
                    .HasForeignKey(d => d.AGCODE)
                    .HasConstraintName("R_PURORDMAIN_AGCODE");

                entity.HasOne(d => d.AUTHORCODENavigation)
                    .WithMany(p => p.PURORDMAINAUTHORCODENavigation)
                    .HasForeignKey(d => d.AUTHORCODE)
                    .HasConstraintName("R_PURORDMAIN_AUTHORCODE");

                entity.HasOne(d => d.DOCCODENavigation)
                    .WithMany(p => p.PURORDMAIN)
                    .HasForeignKey(d => d.DOCCODE)
                    .HasConstraintName("R_PURORDMAIN_DOCCODE");

                entity.HasOne(d => d.ECODENavigation)
                    .WithMany(p => p.PURORDMAINECODENavigation)
                    .HasForeignKey(d => d.ECODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_PURORDMAIN_ECODE");

                entity.HasOne(d => d.FINTRADEGRP_CODENavigation)
                    .WithMany(p => p.PURORDMAIN)
                    .HasForeignKey(d => d.FINTRADEGRP_CODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_PURORDMAIN_FINTRADEGRP_CODE");

                entity.HasOne(d => d.LAST_ACCESS_ECODENavigation)
                    .WithMany(p => p.PURORDMAINLAST_ACCESS_ECODENavigation)
                    .HasForeignKey(d => d.LAST_ACCESS_ECODE)
                    .HasConstraintName("R_PURORDMAIN_LAECODE");

                entity.HasOne(d => d.MRCHNDSRCODENavigation)
                    .WithMany(p => p.PURORDMAINMRCHNDSRCODENavigation)
                    .HasForeignKey(d => d.MRCHNDSRCODE)
                    .HasConstraintName("R_PURORDMAIN_MRCHNDSRCODE");

                entity.HasOne(d => d.PCODENavigation)
                    .WithMany(p => p.PURORDMAINPCODENavigation)
                    .HasForeignKey(d => d.PCODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_PURORDMAIN_PCODE");

                entity.HasOne(d => d.TRPCODENavigation)
                    .WithMany(p => p.PURORDMAINTRPCODENavigation)
                    .HasForeignKey(d => d.TRPCODE)
                    .HasConstraintName("R_PURORDMAIN_TRPCODE");
            });
        }
    }
}
