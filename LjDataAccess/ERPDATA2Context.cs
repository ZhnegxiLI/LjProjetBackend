using LjData.Models;
using LjData.Models.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace LjDataAccess
{
    public partial class ERPDATA2Context : DbContext
    {
        public ERPDATA2Context(DbContextOptions<ERPDATA2Context> options)
            : base(options)
        {
        }
        public virtual DbSet<MobilePushMessage> MobilePushMessage { get; set; }
        public virtual DbSet<CpnyInfo> CpnyInfo { get; set; }
        public virtual DbSet<XyInfo> XyInfo { get; set; }
        public virtual DbSet<MobilePermission> MobilePermission { get; set; }
        public virtual DbSet<MobileUserPermission> MobileUserPermission { get; set; }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Accmbk> Accmbk { get; set; }
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Acctrn> Acctrn { get; set; }
        public virtual DbSet<Accyear> Accyear { get; set; }
        public virtual DbSet<AudBak> AudBak { get; set; }
        public virtual DbSet<Audit> Audit { get; set; }
        public virtual DbSet<Bom> Bom { get; set; }
        public virtual DbSet<Cashonhand> Cashonhand { get; set; }
        public virtual DbSet<Cashonhanddtl> Cashonhanddtl { get; set; }
        public virtual DbSet<Cntmst> Cntmst { get; set; }
        public virtual DbSet<Cntmtl> Cntmtl { get; set; }
        public virtual DbSet<Colorcfg> Colorcfg { get; set; }
        public virtual DbSet<Colorpalette> Colorpalette { get; set; }
        public virtual DbSet<Cpdtl> Cpdtl { get; set; }
        public virtual DbSet<Cpmst> Cpmst { get; set; }
        public virtual DbSet<Cpnymd> Cpnymd { get; set; }
        public virtual DbSet<Cprice> Cprice { get; set; }
        public virtual DbSet<Cstacc> Cstacc { get; set; }
        public virtual DbSet<Cstaccdtl> Cstaccdtl { get; set; }
        public virtual DbSet<Cstmns> Cstmns { get; set; }
        public virtual DbSet<Cstwsum> Cstwsum { get; set; }
        public virtual DbSet<DeclareO> DeclareO { get; set; }
        public virtual DbSet<Dhdoc> Dhdoc { get; set; }
        public virtual DbSet<Dhdtl> Dhdtl { get; set; }
        public virtual DbSet<Docissue> Docissue { get; set; }
        public virtual DbSet<Doctype> Doctype { get; set; }
        public virtual DbSet<Dollars> Dollars { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Finished> Finished { get; set; }
        public virtual DbSet<Gdlabel> Gdlabel { get; set; }
        public virtual DbSet<Inven> Inven { get; set; }
        public virtual DbSet<Invenbat> Invenbat { get; set; }
        public virtual DbSet<Itemmst> Itemmst { get; set; }
        public virtual DbSet<Itemprice> Itemprice { get; set; }
        public virtual DbSet<Itemtype> Itemtype { get; set; }
        public virtual DbSet<Itemvend> Itemvend { get; set; }
        public virtual DbSet<Ivndbk> Ivndbk { get; set; }
        public virtual DbSet<Ivnloc> Ivnloc { get; set; }
        public virtual DbSet<Ivnmbk> Ivnmbk { get; set; }
        public virtual DbSet<Ivntrn> Ivntrn { get; set; }
        public virtual DbSet<Locator> Locator { get; set; }
        public virtual DbSet<Loctb> Loctb { get; set; }
        public virtual DbSet<Monthsum> Monthsum { get; set; }
        public virtual DbSet<Moveprice> Moveprice { get; set; }
        public virtual DbSet<Mphead> Mphead { get; set; }
        public virtual DbSet<Mtlhd> Mtlhd { get; set; }
        public virtual DbSet<Notepad> Notepad { get; set; }
        public virtual DbSet<Passwrd> Passwrd { get; set; }
        public virtual DbSet<Paydoc> Paydoc { get; set; }
        public virtual DbSet<PaydocIssue> PaydocIssue { get; set; }
        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<Plants> Plants { get; set; }
        public virtual DbSet<Pnmaker> Pnmaker { get; set; }
        public virtual DbSet<PoCntIssue> PoCntIssue { get; set; }
        public virtual DbSet<Pomodoc> Pomodoc { get; set; }
        public virtual DbSet<Pomst> Pomst { get; set; }
        public virtual DbSet<Popart> Popart { get; set; }
        public virtual DbSet<Poschedule> Poschedule { get; set; }
        public virtual DbSet<Pricelisthd> Pricelisthd { get; set; }
        public virtual DbSet<Pzdoc> Pzdoc { get; set; }
        public virtual DbSet<Pzdtl> Pzdtl { get; set; }
        public virtual DbSet<Pzfydtl> Pzfydtl { get; set; }
        public virtual DbSet<Pzhead> Pzhead { get; set; }
        public virtual DbSet<Pzissue> Pzissue { get; set; }
        public virtual DbSet<Pztype> Pztype { get; set; }
        public virtual DbSet<Reasons> Reasons { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<Settlement> Settlement { get; set; }
        public virtual DbSet<Tc> Tc { get; set; }
        public virtual DbSet<Trndtl> Trndtl { get; set; }
        public virtual DbSet<Trndtl2> Trndtl2 { get; set; }
        public virtual DbSet<Trndtlbat> Trndtlbat { get; set; }
        public virtual DbSet<Trndtlpm> Trndtlpm { get; set; }
        public virtual DbSet<Trnhead> Trnhead { get; set; }
        public virtual DbSet<Trnltr> Trnltr { get; set; }
        public virtual DbSet<Trnvend> Trnvend { get; set; }
        public virtual DbSet<Units> Units { get; set; }
        public virtual DbSet<Useright> Useright { get; set; }

        // Unable to generate entity type for table 'dbo.CDN_BOM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CPNYINFO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CUTOFF'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DOLLARS_X'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MPDTL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MTLVEND'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PRICEVIEW'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SHRINKDBS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SYSLOCK'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.XYINFO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.POVIEW'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GDLABELHD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CSTMNSDOC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CSTWSUMDOC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GDLABEL2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GDLABELHD2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MPSCHEDULE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PRICELISTDTL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BOMCHECK'. Please see the warning messages.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<User>(entity =>
            {
                // View cannot update or insert, only can be read
                entity.ToTable("View_User");
                entity.Property(v => v.Id).HasColumnName("Id");
                entity.Property(v => v.Name).HasColumnName("Name");
                entity.Property(v => v.Password).HasColumnName("Password");
                entity.Property(v => v.Email).HasColumnName("Email");
            });

            modelBuilder.Entity<Accmbk>(entity =>
            {
                entity.HasKey(e => new { e.CutdAtn, e.PlntAtn, e.AccnAtn });

                entity.ToTable("ACCMBK");

                entity.Property(e => e.CutdAtn)
                    .HasColumnName("CUTD_ATN")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlntAtn)
                    .HasColumnName("PLNT_ATN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccnAtn)
                    .HasColumnName("ACCN_ATN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BlceAtn)
                    .HasColumnName("BLCE_ATN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DescAtn)
                    .HasColumnName("DESC_ATN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DollAtn)
                    .HasColumnName("DOLL_ATN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IsumAtn)
                    .HasColumnName("ISUM_ATN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LatvAtn)
                    .HasColumnName("LATV_ATN")
                    .HasColumnType("datetime");

                entity.Property(e => e.LdatAtn)
                    .HasColumnName("LDAT_ATN")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtAtn)
                    .HasColumnName("LEDT_ATN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MbegAtn)
                    .HasColumnName("MBEG_ATN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OsumAtn)
                    .HasColumnName("OSUM_ATN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Prt1Atn)
                    .HasColumnName("PRT1_ATN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Prt2Atn)
                    .HasColumnName("PRT2_ATN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SysAtn).HasColumnName("SYS_ATN");

                entity.Property(e => e.TypeAtn)
                    .HasColumnName("TYPE_ATN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.YbegAtn)
                    .HasColumnName("YBEG_ATN")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => new { e.PlntAtn, e.AccnAtn });

                entity.ToTable("ACCOUNT");

                entity.Property(e => e.PlntAtn)
                    .HasColumnName("PLNT_ATN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccnAtn)
                    .HasColumnName("ACCN_ATN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BlceAtn)
                    .HasColumnName("BLCE_ATN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DescAtn)
                    .HasColumnName("DESC_ATN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DollAtn)
                    .HasColumnName("DOLL_ATN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IsumAtn)
                    .HasColumnName("ISUM_ATN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LatvAtn)
                    .HasColumnName("LATV_ATN")
                    .HasColumnType("datetime");

                entity.Property(e => e.LdatAtn)
                    .HasColumnName("LDAT_ATN")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtAtn)
                    .HasColumnName("LEDT_ATN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MbegAtn)
                    .HasColumnName("MBEG_ATN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OsumAtn)
                    .HasColumnName("OSUM_ATN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Prt1Atn)
                    .HasColumnName("PRT1_ATN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Prt2Atn)
                    .HasColumnName("PRT2_ATN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SysAtn).HasColumnName("SYS_ATN");

                entity.Property(e => e.TypeAtn)
                    .HasColumnName("TYPE_ATN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.YbegAtn)
                    .HasColumnName("YBEG_ATN")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Acctrn>(entity =>
            {
                entity.HasKey(e => new { e.PlntAtr, e.YearAtr, e.AccnAtr, e.PznoAtr, e.PtypAtr });

                entity.ToTable("ACCTRN");

                entity.Property(e => e.PlntAtr)
                    .HasColumnName("PLNT_ATR")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.YearAtr)
                    .HasColumnName("YEAR_ATR")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AccnAtr)
                    .HasColumnName("ACCN_ATR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PznoAtr)
                    .HasColumnName("PZNO_ATR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PtypAtr)
                    .HasColumnName("PTYP_ATR")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AbstAtr)
                    .HasColumnName("ABST_ATR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BlceAtr)
                    .HasColumnName("BLCE_ATR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChekAtr).HasColumnName("CHEK_ATR");

                entity.Property(e => e.ChkdAtr)
                    .HasColumnName("CHKD_ATR")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChkrAtr)
                    .HasColumnName("CHKR_ATR")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CssbAtr)
                    .HasColumnName("CSSB_ATR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAtr)
                    .HasColumnName("DATE_ATR")
                    .HasColumnType("datetime");

                entity.Property(e => e.DirtAtr)
                    .HasColumnName("DIRT_ATR")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsumAtr)
                    .HasColumnName("ISUM_ATR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LedtAtr)
                    .HasColumnName("LEDT_ATR")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OperAtr)
                    .HasColumnName("OPER_ATR")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OsumAtr)
                    .HasColumnName("OSUM_ATR")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Accyear>(entity =>
            {
                entity.HasKey(e => e.YearAcy);

                entity.ToTable("ACCYEAR");

                entity.Property(e => e.YearAcy)
                    .HasColumnName("YEAR_ACY")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.LdatAcy)
                    .HasColumnName("LDAT_ACY")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtAcy)
                    .HasColumnName("LEDT_ACY")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AudBak>(entity =>
            {
                entity.HasKey(e => new { e.DocnAdt, e.RownAdt });

                entity.ToTable("AUD_BAK");

                entity.Property(e => e.DocnAdt)
                    .HasColumnName("DOCN_ADT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RownAdt)
                    .HasColumnName("ROWN_ADT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AqtyAdt)
                    .HasColumnName("AQTY_ADT")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LdatAdt)
                    .HasColumnName("LDAT_ADT")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtAdt)
                    .HasColumnName("LEDT_ADT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LocnAdt)
                    .HasColumnName("LOCN_ADT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PartAdt)
                    .HasColumnName("PART_ADT")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PlntAdt)
                    .HasColumnName("PLNT_ADT")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Audit>(entity =>
            {
                entity.HasKey(e => new { e.DocnAdt, e.RownAdt });

                entity.ToTable("AUDIT");

                entity.Property(e => e.DocnAdt)
                    .HasColumnName("DOCN_ADT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RownAdt)
                    .HasColumnName("ROWN_ADT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AqtyAdt)
                    .HasColumnName("AQTY_ADT")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LdatAdt)
                    .HasColumnName("LDAT_ADT")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtAdt)
                    .HasColumnName("LEDT_ADT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LocnAdt)
                    .HasColumnName("LOCN_ADT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PartAdt)
                    .HasColumnName("PART_ADT")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PlntAdt)
                    .HasColumnName("PLNT_ADT")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bom>(entity =>
            {
                entity.HasKey(e => new { e.PrntBm, e.CmpnBm, e.EffdBm });

                entity.ToTable("BOM");

                entity.Property(e => e.PrntBm)
                    .HasColumnName("PRNT_BM")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CmpnBm)
                    .HasColumnName("CMPN_BM")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EffdBm)
                    .HasColumnName("EFFD_BM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClsdBm)
                    .HasColumnName("CLSD_BM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DenoBm)
                    .HasColumnName("DENO_BM")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LdatBm)
                    .HasColumnName("LDAT_BM")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtBm)
                    .HasColumnName("LEDT_BM")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LossBm)
                    .HasColumnName("LOSS_BM")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.NumtBm)
                    .HasColumnName("NUMT_BM")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<Cashonhand>(entity =>
            {
                entity.HasKey(e => new { e.LocnCsh, e.DateCsh });

                entity.ToTable("CASHONHAND");

                entity.Property(e => e.LocnCsh)
                    .HasColumnName("LOCN_CSH")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DateCsh)
                    .HasColumnName("DATE_CSH")
                    .HasColumnType("datetime");

                entity.Property(e => e.LdatCsh)
                    .HasColumnName("LDAT_CSH")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtCsh)
                    .HasColumnName("LEDT_CSH")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SumCsh)
                    .HasColumnName("SUM_CSH")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Cashonhanddtl>(entity =>
            {
                entity.HasKey(e => new { e.CpnyCsd, e.LocnCsd, e.DateCsd });

                entity.ToTable("CASHONHANDDTL");

                entity.Property(e => e.CpnyCsd)
                    .HasColumnName("CPNY_CSD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LocnCsd)
                    .HasColumnName("LOCN_CSD")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DateCsd)
                    .HasColumnName("DATE_CSD")
                    .HasColumnType("datetime");

                entity.Property(e => e.LdatCsd)
                    .HasColumnName("LDAT_CSD")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtCsd)
                    .HasColumnName("LEDT_CSD")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SumCsd)
                    .HasColumnName("SUM_CSD")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Cntmst>(entity =>
            {
                entity.HasKey(e => e.CntrCtm);

                entity.ToTable("CNTMST");

                entity.Property(e => e.CntrCtm)
                    .HasColumnName("CNTR_CTM")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddrCtm)
                    .HasColumnName("ADDR_CTM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CachetCtm)
                    .HasColumnName("CACHET_CTM")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CaseCtm)
                    .HasColumnName("CASE_CTM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CmplCtm).HasColumnName("CMPL_CTM");

                entity.Property(e => e.CrtdCtm)
                    .HasColumnName("CRTD_CTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCtm)
                    .HasColumnName("DATE_CTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsgyCtm)
                    .HasColumnName("DSGY_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpdCtm)
                    .HasColumnName("EXPD_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FaccnCtm)
                    .HasColumnName("FACCN_CTM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FadrCtm)
                    .HasColumnName("FADR_CTM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FbankCtm)
                    .HasColumnName("FBANK_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FfaxnCtm)
                    .HasColumnName("FFAXN_CTM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FlawrCtm)
                    .HasColumnName("FLAWR_CTM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FromCtm)
                    .HasColumnName("FROM_CTM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FsurgCtm)
                    .HasColumnName("FSURG_CTM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FtelCtm)
                    .HasColumnName("FTEL_CTM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GcCtm)
                    .HasColumnName("GC_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HbshCtm)
                    .HasColumnName("HBSH_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JtCtm)
                    .HasColumnName("JT_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KzCtm)
                    .HasColumnName("KZ_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LdatCtm)
                    .HasColumnName("LDAT_CTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtCtm)
                    .HasColumnName("LEDT_CTM")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LfjyCtm)
                    .HasColumnName("LFJY_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LsxCtm)
                    .HasColumnName("LSX_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MrmkCtm)
                    .HasColumnName("MRMK_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhzCtm)
                    .HasColumnName("PHZ_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PjscCtm)
                    .HasColumnName("PJSC_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlntCtm)
                    .HasColumnName("PLNT_CTM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ProjCtm)
                    .HasColumnName("PROJ_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PzyqCtm)
                    .HasColumnName("PZYQ_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QlcsCtm)
                    .HasColumnName("QLCS_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RsldCtm)
                    .HasColumnName("RSLD_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScCtm)
                    .HasColumnName("SC_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SealCtm).HasColumnName("SEAL_CTM");

                entity.Property(e => e.Sign1Ctm)
                    .HasColumnName("SIGN1_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sign2Ctm)
                    .HasColumnName("SIGN2_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SslbzCtm)
                    .HasColumnName("SSLBZ_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SsljCtm)
                    .HasColumnName("SSLJ_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SslwCtm)
                    .HasColumnName("SSLW_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaccnCtm)
                    .HasColumnName("TACCN_CTM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TadrCtm)
                    .HasColumnName("TADR_CTM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TbankCtm)
                    .HasColumnName("TBANK_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Term10Ctm)
                    .HasColumnName("TERM10_CTM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Term1Ctm)
                    .HasColumnName("TERM1_CTM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Term2Ctm)
                    .HasColumnName("TERM2_CTM")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Term2fsCtm).HasColumnName("TERM2FS_CTM");

                entity.Property(e => e.Term3Ctm)
                    .HasColumnName("TERM3_CTM")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Term4Ctm)
                    .HasColumnName("TERM4_CTM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Term5Ctm)
                    .HasColumnName("TERM5_CTM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Term6Ctm)
                    .HasColumnName("TERM6_CTM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Term7Ctm)
                    .HasColumnName("TERM7_CTM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Term8Ctm)
                    .HasColumnName("TERM8_CTM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Term9Ctm)
                    .HasColumnName("TERM9_CTM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TfaxnCtm)
                    .HasColumnName("TFAXN_CTM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TlawrCtm)
                    .HasColumnName("TLAWR_CTM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ToCtm)
                    .HasColumnName("TO_CTM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TsurgCtm)
                    .HasColumnName("TSURG_CTM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TtelCtm)
                    .HasColumnName("TTEL_CTM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TwscCtm)
                    .HasColumnName("TWSC_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCtm)
                    .HasColumnName("TYPE_CTM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.YhCtm)
                    .HasColumnName("YH_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZsCtm)
                    .HasColumnName("ZS_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZzyscCtm)
                    .HasColumnName("ZZYSC_CTM")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cntmtl>(entity =>
            {
                entity.HasKey(e => new { e.CntrMtl, e.RownMtl });

                entity.ToTable("CNTMTL");

                entity.Property(e => e.CntrMtl)
                    .HasColumnName("CNTR_MTL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RownMtl)
                    .HasColumnName("ROWN_MTL")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DescMtl)
                    .HasColumnName("DESC_MTL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpdMtl)
                    .HasColumnName("EXPD_MTL")
                    .HasColumnType("datetime");

                entity.Property(e => e.LdatMtl)
                    .HasColumnName("LDAT_MTL")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtMtl)
                    .HasColumnName("LEDT_MTL")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OkcolrMtl)
                    .HasColumnName("OKCOLR_MTL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlntMtl)
                    .HasColumnName("PLNT_MTL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PricMtl)
                    .HasColumnName("PRIC_MTL")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.RemkMtl)
                    .HasColumnName("REMK_MTL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecMtl)
                    .HasColumnName("SPEC_MTL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMtl)
                    .HasColumnName("SUM_MTL")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TqtyMtl)
                    .HasColumnName("TQTY_MTL")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UnitMtl)
                    .HasColumnName("UNIT_MTL")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Colorcfg>(entity =>
            {
                entity.HasKey(e => e.DocnCfg);

                entity.ToTable("COLORCFG");

                entity.Property(e => e.DocnCfg)
                    .HasColumnName("DOCN_CFG")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CstmCfg)
                    .HasColumnName("CSTM_CFG")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateCfg)
                    .HasColumnName("DATE_CFG")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsgyCfg)
                    .HasColumnName("DSGY_CFG")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LdatCfg)
                    .HasColumnName("LDAT_CFG")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtCfg)
                    .HasColumnName("LEDT_CFG")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LybhCfg)
                    .HasColumnName("LYBH_CFG")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlntCfg)
                    .HasColumnName("PLNT_CFG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PzggCfg)
                    .HasColumnName("PZGG_CFG")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sb1Cfg)
                    .HasColumnName("SB1_CFG")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sb2Cfg)
                    .HasColumnName("SB2_CFG")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SbbhCfg)
                    .HasColumnName("SBBH_CFG")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sh1Cfg)
                    .HasColumnName("SH1_CFG")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sh2Cfg)
                    .HasColumnName("SH2_CFG")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShrCfg)
                    .HasColumnName("SHR_CFG")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.XsffCfg)
                    .HasColumnName("XSFF_CFG")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZbrCfg)
                    .HasColumnName("ZBR_CFG")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Colorpalette>(entity =>
            {
                entity.HasKey(e => e.DocnClp);

                entity.ToTable("COLORPALETTE");

                entity.Property(e => e.DocnClp)
                    .HasColumnName("DOCN_CLP")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CachetClp)
                    .HasColumnName("CACHET_CLP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ChkrClp)
                    .HasColumnName("CHKR_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr1b1cClp)
                    .HasColumnName("CLR1B1C_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr1b1vClp)
                    .HasColumnName("CLR1B1V_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr1b2cClp)
                    .HasColumnName("CLR1B2C_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr1b2vClp)
                    .HasColumnName("CLR1B2V_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr1bClp).HasColumnName("CLR1B_CLP");

                entity.Property(e => e.Clr1gClp).HasColumnName("CLR1G_CLP");

                entity.Property(e => e.Clr1gcClp)
                    .HasColumnName("CLR1GC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr1gccClp)
                    .HasColumnName("CLR1GCC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr1n1Clp)
                    .HasColumnName("CLR1N1_CLP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clr1rClp).HasColumnName("CLR1R_CLP");

                entity.Property(e => e.Clr1rsClp)
                    .HasColumnName("CLR1RS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr1rscClp)
                    .HasColumnName("CLR1RSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr1scClp)
                    .HasColumnName("CLR1SC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr1sccClp)
                    .HasColumnName("CLR1SCC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr1sljClp)
                    .HasColumnName("CLR1SLJ_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr1sljcClp)
                    .HasColumnName("CLR1SLJC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr1slwClp)
                    .HasColumnName("CLR1SLW_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr1slwcClp)
                    .HasColumnName("CLR1SLWC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr1xsClp)
                    .HasColumnName("CLR1XS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr1xscClp)
                    .HasColumnName("CLR1XSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr1ylClp)
                    .HasColumnName("CLR1YL_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr1ylcClp)
                    .HasColumnName("CLR1YLC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr1zsClp)
                    .HasColumnName("CLR1ZS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr1zscClp)
                    .HasColumnName("CLR1ZSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr2b1cClp)
                    .HasColumnName("CLR2B1C_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr2b1vClp)
                    .HasColumnName("CLR2B1V_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr2b2cClp)
                    .HasColumnName("CLR2B2C_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr2b2vClp)
                    .HasColumnName("CLR2B2V_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr2bClp).HasColumnName("CLR2B_CLP");

                entity.Property(e => e.Clr2gClp).HasColumnName("CLR2G_CLP");

                entity.Property(e => e.Clr2gcClp)
                    .HasColumnName("CLR2GC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr2gccClp)
                    .HasColumnName("CLR2GCC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr2n1Clp)
                    .HasColumnName("CLR2N1_CLP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clr2rClp).HasColumnName("CLR2R_CLP");

                entity.Property(e => e.Clr2rsClp)
                    .HasColumnName("CLR2RS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr2rscClp)
                    .HasColumnName("CLR2RSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr2scClp)
                    .HasColumnName("CLR2SC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr2sccClp)
                    .HasColumnName("CLR2SCC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr2sljClp)
                    .HasColumnName("CLR2SLJ_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr2sljcClp)
                    .HasColumnName("CLR2SLJC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr2slwClp)
                    .HasColumnName("CLR2SLW_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr2slwcClp)
                    .HasColumnName("CLR2SLWC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr2xsClp)
                    .HasColumnName("CLR2XS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr2xscClp)
                    .HasColumnName("CLR2XSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr2ylClp)
                    .HasColumnName("CLR2YL_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr2ylcClp)
                    .HasColumnName("CLR2YLC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr2zsClp)
                    .HasColumnName("CLR2ZS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr2zscClp)
                    .HasColumnName("CLR2ZSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr3b1cClp)
                    .HasColumnName("CLR3B1C_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr3b1vClp)
                    .HasColumnName("CLR3B1V_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr3b2cClp)
                    .HasColumnName("CLR3B2C_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr3b2vClp)
                    .HasColumnName("CLR3B2V_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr3bClp).HasColumnName("CLR3B_CLP");

                entity.Property(e => e.Clr3gClp).HasColumnName("CLR3G_CLP");

                entity.Property(e => e.Clr3gcClp)
                    .HasColumnName("CLR3GC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr3gccClp)
                    .HasColumnName("CLR3GCC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr3n1Clp)
                    .HasColumnName("CLR3N1_CLP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clr3rClp).HasColumnName("CLR3R_CLP");

                entity.Property(e => e.Clr3rsClp)
                    .HasColumnName("CLR3RS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr3rscClp)
                    .HasColumnName("CLR3RSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr3scClp)
                    .HasColumnName("CLR3SC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr3sccClp)
                    .HasColumnName("CLR3SCC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr3sljClp)
                    .HasColumnName("CLR3SLJ_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr3sljcClp)
                    .HasColumnName("CLR3SLJC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr3slwClp)
                    .HasColumnName("CLR3SLW_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr3slwcClp)
                    .HasColumnName("CLR3SLWC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr3xsClp)
                    .HasColumnName("CLR3XS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr3xscClp)
                    .HasColumnName("CLR3XSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr3ylClp)
                    .HasColumnName("CLR3YL_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr3ylcClp)
                    .HasColumnName("CLR3YLC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr3zsClp)
                    .HasColumnName("CLR3ZS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr3zscClp)
                    .HasColumnName("CLR3ZSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr4b1cClp)
                    .HasColumnName("CLR4B1C_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr4b1vClp)
                    .HasColumnName("CLR4B1V_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr4b2cClp)
                    .HasColumnName("CLR4B2C_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr4b2vClp)
                    .HasColumnName("CLR4B2V_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr4bClp).HasColumnName("CLR4B_CLP");

                entity.Property(e => e.Clr4gClp).HasColumnName("CLR4G_CLP");

                entity.Property(e => e.Clr4gcClp)
                    .HasColumnName("CLR4GC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr4gccClp)
                    .HasColumnName("CLR4GCC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr4n1Clp)
                    .HasColumnName("CLR4N1_CLP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clr4rClp).HasColumnName("CLR4R_CLP");

                entity.Property(e => e.Clr4rsClp)
                    .HasColumnName("CLR4RS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr4rscClp)
                    .HasColumnName("CLR4RSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr4scClp)
                    .HasColumnName("CLR4SC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr4sccClp)
                    .HasColumnName("CLR4SCC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr4sljClp)
                    .HasColumnName("CLR4SLJ_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr4sljcClp)
                    .HasColumnName("CLR4SLJC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr4slwClp)
                    .HasColumnName("CLR4SLW_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr4slwcClp)
                    .HasColumnName("CLR4SLWC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr4xsClp)
                    .HasColumnName("CLR4XS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr4xscClp)
                    .HasColumnName("CLR4XSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr4ylClp)
                    .HasColumnName("CLR4YL_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr4ylcClp)
                    .HasColumnName("CLR4YLC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr4zsClp)
                    .HasColumnName("CLR4ZS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr4zscClp)
                    .HasColumnName("CLR4ZSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr5b1cClp)
                    .HasColumnName("CLR5B1C_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr5b1vClp)
                    .HasColumnName("CLR5B1V_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr5b2cClp)
                    .HasColumnName("CLR5B2C_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr5b2vClp)
                    .HasColumnName("CLR5B2V_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr5bClp).HasColumnName("CLR5B_CLP");

                entity.Property(e => e.Clr5gClp).HasColumnName("CLR5G_CLP");

                entity.Property(e => e.Clr5gcClp)
                    .HasColumnName("CLR5GC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr5gccClp)
                    .HasColumnName("CLR5GCC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr5n1Clp)
                    .HasColumnName("CLR5N1_CLP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clr5rClp).HasColumnName("CLR5R_CLP");

                entity.Property(e => e.Clr5rsClp)
                    .HasColumnName("CLR5RS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr5rscClp)
                    .HasColumnName("CLR5RSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr5scClp)
                    .HasColumnName("CLR5SC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr5sccClp)
                    .HasColumnName("CLR5SCC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr5sljClp)
                    .HasColumnName("CLR5SLJ_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr5sljcClp)
                    .HasColumnName("CLR5SLJC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr5slwClp)
                    .HasColumnName("CLR5SLW_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr5slwcClp)
                    .HasColumnName("CLR5SLWC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr5xsClp)
                    .HasColumnName("CLR5XS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr5xscClp)
                    .HasColumnName("CLR5XSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr5ylClp)
                    .HasColumnName("CLR5YL_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr5ylcClp)
                    .HasColumnName("CLR5YLC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr5zsClp)
                    .HasColumnName("CLR5ZS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr5zscClp)
                    .HasColumnName("CLR5ZSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr6b1cClp)
                    .HasColumnName("CLR6B1C_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr6b1vClp)
                    .HasColumnName("CLR6B1V_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr6b2cClp)
                    .HasColumnName("CLR6B2C_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr6b2vClp)
                    .HasColumnName("CLR6B2V_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr6bClp).HasColumnName("CLR6B_CLP");

                entity.Property(e => e.Clr6gClp).HasColumnName("CLR6G_CLP");

                entity.Property(e => e.Clr6gcClp)
                    .HasColumnName("CLR6GC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr6gccClp)
                    .HasColumnName("CLR6GCC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr6n1Clp)
                    .HasColumnName("CLR6N1_CLP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clr6rClp).HasColumnName("CLR6R_CLP");

                entity.Property(e => e.Clr6rsClp)
                    .HasColumnName("CLR6RS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr6rscClp)
                    .HasColumnName("CLR6RSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr6scClp)
                    .HasColumnName("CLR6SC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr6sccClp)
                    .HasColumnName("CLR6SCC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr6sljClp)
                    .HasColumnName("CLR6SLJ_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr6sljcClp)
                    .HasColumnName("CLR6SLJC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr6slwClp)
                    .HasColumnName("CLR6SLW_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr6slwcClp)
                    .HasColumnName("CLR6SLWC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr6xsClp)
                    .HasColumnName("CLR6XS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr6xscClp)
                    .HasColumnName("CLR6XSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr6ylClp)
                    .HasColumnName("CLR6YL_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr6ylcClp)
                    .HasColumnName("CLR6YLC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr6zsClp)
                    .HasColumnName("CLR6ZS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr6zscClp)
                    .HasColumnName("CLR6ZSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr7b1cClp)
                    .HasColumnName("CLR7B1C_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr7b1vClp)
                    .HasColumnName("CLR7B1V_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr7b2cClp)
                    .HasColumnName("CLR7B2C_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr7b2vClp)
                    .HasColumnName("CLR7B2V_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr7bClp).HasColumnName("CLR7B_CLP");

                entity.Property(e => e.Clr7gClp).HasColumnName("CLR7G_CLP");

                entity.Property(e => e.Clr7gcClp)
                    .HasColumnName("CLR7GC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr7gccClp)
                    .HasColumnName("CLR7GCC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr7n1Clp)
                    .HasColumnName("CLR7N1_CLP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clr7rClp).HasColumnName("CLR7R_CLP");

                entity.Property(e => e.Clr7rsClp)
                    .HasColumnName("CLR7RS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr7rscClp)
                    .HasColumnName("CLR7RSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr7scClp)
                    .HasColumnName("CLR7SC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr7sccClp)
                    .HasColumnName("CLR7SCC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr7sljClp)
                    .HasColumnName("CLR7SLJ_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr7sljcClp)
                    .HasColumnName("CLR7SLJC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr7slwClp)
                    .HasColumnName("CLR7SLW_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr7slwcClp)
                    .HasColumnName("CLR7SLWC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr7xsClp)
                    .HasColumnName("CLR7XS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr7xscClp)
                    .HasColumnName("CLR7XSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr7ylClp)
                    .HasColumnName("CLR7YL_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr7ylcClp)
                    .HasColumnName("CLR7YLC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr7zsClp)
                    .HasColumnName("CLR7ZS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr7zscClp)
                    .HasColumnName("CLR7ZSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr8b1cClp)
                    .HasColumnName("CLR8B1C_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr8b1vClp)
                    .HasColumnName("CLR8B1V_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr8b2cClp)
                    .HasColumnName("CLR8B2C_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr8b2vClp)
                    .HasColumnName("CLR8B2V_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr8bClp).HasColumnName("CLR8B_CLP");

                entity.Property(e => e.Clr8gClp).HasColumnName("CLR8G_CLP");

                entity.Property(e => e.Clr8gcClp)
                    .HasColumnName("CLR8GC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr8gccClp)
                    .HasColumnName("CLR8GCC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr8n1Clp)
                    .HasColumnName("CLR8N1_CLP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clr8rClp).HasColumnName("CLR8R_CLP");

                entity.Property(e => e.Clr8rsClp)
                    .HasColumnName("CLR8RS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr8rscClp)
                    .HasColumnName("CLR8RSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr8scClp)
                    .HasColumnName("CLR8SC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr8sccClp)
                    .HasColumnName("CLR8SCC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr8sljClp)
                    .HasColumnName("CLR8SLJ_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr8sljcClp)
                    .HasColumnName("CLR8SLJC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr8slwClp)
                    .HasColumnName("CLR8SLW_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr8slwcClp)
                    .HasColumnName("CLR8SLWC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr8xsClp)
                    .HasColumnName("CLR8XS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr8xscClp)
                    .HasColumnName("CLR8XSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr8ylClp)
                    .HasColumnName("CLR8YL_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr8ylcClp)
                    .HasColumnName("CLR8YLC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr8zsClp)
                    .HasColumnName("CLR8ZS_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clr8zscClp)
                    .HasColumnName("CLR8ZSC_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClrnClp)
                    .HasColumnName("CLRN_CLP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CmplClp).HasColumnName("CMPL_CLP");

                entity.Property(e => e.CrtdClp)
                    .HasColumnName("CRTD_CLP")
                    .HasColumnType("datetime");

                entity.Property(e => e.CstmClp)
                    .HasColumnName("CSTM_CLP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateClp)
                    .HasColumnName("DATE_CLP")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsgyClp)
                    .HasColumnName("DSGY_CLP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FwlrClp)
                    .HasColumnName("FWLR_CLP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LdatClp)
                    .HasColumnName("LDAT_CLP")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtClp)
                    .HasColumnName("LEDT_CLP")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MakrClp)
                    .HasColumnName("MAKR_CLP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MrmkClp)
                    .HasColumnName("MRMK_CLP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MtlClp)
                    .HasColumnName("MTL_CLP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcntClp).HasColumnName("PCNT_CLP");

                entity.Property(e => e.PlntClp)
                    .HasColumnName("PLNT_CLP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PnnbClp)
                    .HasColumnName("PNNB_CLP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReqdClp)
                    .HasColumnName("REQD_CLP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rmk1Clp)
                    .HasColumnName("RMK1_CLP")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Rmk2Clp)
                    .HasColumnName("RMK2_CLP")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RswayClp)
                    .HasColumnName("RSWAY_CLP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SealClp).HasColumnName("SEAL_CLP");

                entity.Property(e => e.SendClp)
                    .HasColumnName("SEND_CLP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SizeClp)
                    .HasColumnName("SIZE_CLP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecClp)
                    .HasColumnName("SPEC_CLP")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ToClp)
                    .HasColumnName("TO_CLP")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.XswayClp)
                    .HasColumnName("XSWAY_CLP")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cpdtl>(entity =>
            {
                entity.HasKey(e => new { e.DocnCpd, e.OrdrCpd });

                entity.ToTable("CPDTL");

                entity.Property(e => e.DocnCpd)
                    .HasColumnName("DOCN_CPD")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OrdrCpd)
                    .HasColumnName("ORDR_CPD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DescCpd)
                    .HasColumnName("DESC_CPD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LdatCpd)
                    .HasColumnName("LDAT_CPD")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtCpd)
                    .HasColumnName("LEDT_CPD")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PlntCpd)
                    .HasColumnName("PLNT_CPD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PricCpd)
                    .HasColumnName("PRIC_CPD")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.RemkCpd)
                    .HasColumnName("REMK_CPD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCpd)
                    .HasColumnName("UNIT_CPD")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cpmst>(entity =>
            {
                entity.HasKey(e => e.DocnCpm);

                entity.ToTable("CPMST");

                entity.Property(e => e.DocnCpm)
                    .HasColumnName("DOCN_CPM")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CachetCpm)
                    .HasColumnName("CACHET_CPM")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CmplCpm).HasColumnName("CMPL_CPM");

                entity.Property(e => e.CrtdCpm)
                    .HasColumnName("CRTD_CPM")
                    .HasColumnType("datetime");

                entity.Property(e => e.CstmCpm)
                    .HasColumnName("CSTM_CPM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CtovCpm).HasColumnName("CTOV_CPM");

                entity.Property(e => e.DateCpm)
                    .HasColumnName("DATE_CPM")
                    .HasColumnType("datetime");

                entity.Property(e => e.FfaxCpm)
                    .HasColumnName("FFAX_CPM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FnamCpm)
                    .HasColumnName("FNAM_CPM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FtelCpm)
                    .HasColumnName("FTEL_CPM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LdatCpm)
                    .HasColumnName("LDAT_CPM")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtCpm)
                    .HasColumnName("LEDT_CPM")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MrmkCpm)
                    .HasColumnName("MRMK_CPM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlntCpm)
                    .HasColumnName("PLNT_CPM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rmk1Cpm)
                    .HasColumnName("RMK1_CPM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rmk2Cpm)
                    .HasColumnName("RMK2_CPM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rmk3Cpm)
                    .HasColumnName("RMK3_CPM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SealCpm).HasColumnName("SEAL_CPM");

                entity.Property(e => e.TfaxCpm)
                    .HasColumnName("TFAX_CPM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TnamCpm)
                    .HasColumnName("TNAM_CPM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TtelCpm)
                    .HasColumnName("TTEL_CPM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCpm)
                    .HasColumnName("TYPE_CPM")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cpnymd>(entity =>
            {
                entity.HasKey(e => e.CpnoCmd);

                entity.ToTable("CPNYMD");

                entity.Property(e => e.CpnoCmd)
                    .HasColumnName("CPNO_CMD")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DescCmd)
                    .IsRequired()
                    .HasColumnName("DESC_CMD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LdatCmd)
                    .HasColumnName("LDAT_CMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtCmd)
                    .HasColumnName("LEDT_CMD")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cprice>(entity =>
            {
                entity.HasKey(e => new { e.LocnCp, e.DateCp, e.PartCp });

                entity.ToTable("CPRICE");

                entity.Property(e => e.LocnCp)
                    .HasColumnName("LOCN_CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DateCp)
                    .HasColumnName("DATE_CP")
                    .HasColumnType("datetime");

                entity.Property(e => e.PartCp)
                    .HasColumnName("PART_CP")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.IprcCp)
                    .HasColumnName("IPRC_CP")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LdatCp)
                    .HasColumnName("LDAT_CP")
                    .HasColumnType("datetime");

                entity.Property(e => e.OprcCp)
                    .HasColumnName("OPRC_CP")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Cstacc>(entity =>
            {
                entity.HasKey(e => e.LocnCac);

                entity.ToTable("CSTACC");

                entity.Property(e => e.LocnCac)
                    .HasColumnName("LOCN_CAC")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BegsCac)
                    .HasColumnName("BEGS_CAC")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsumCac)
                    .HasColumnName("ISUM_CAC")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LdatCac)
                    .HasColumnName("LDAT_CAC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtCac)
                    .HasColumnName("LEDT_CAC")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LidtCac)
                    .HasColumnName("LIDT_CAC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LodtCac)
                    .HasColumnName("LODT_CAC")
                    .HasColumnType("datetime");

                entity.Property(e => e.OsumCac)
                    .HasColumnName("OSUM_CAC")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Cstaccdtl>(entity =>
            {
                entity.HasKey(e => new { e.CpnyCad, e.LocnCad });

                entity.ToTable("CSTACCDTL");

                entity.Property(e => e.CpnyCad)
                    .HasColumnName("CPNY_CAD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LocnCad)
                    .HasColumnName("LOCN_CAD")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BegsCad)
                    .HasColumnName("BEGS_CAD")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsumCad)
                    .HasColumnName("ISUM_CAD")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LdatCad)
                    .HasColumnName("LDAT_CAD")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtCad)
                    .HasColumnName("LEDT_CAD")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LidtCad)
                    .HasColumnName("LIDT_CAD")
                    .HasColumnType("datetime");

                entity.Property(e => e.LodtCad)
                    .HasColumnName("LODT_CAD")
                    .HasColumnType("datetime");

                entity.Property(e => e.OsumCad)
                    .HasColumnName("OSUM_CAD")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Cstmns>(entity =>
            {
                entity.HasKey(e => new { e.LocnCms, e.MmidCms });

                entity.ToTable("CSTMNS");

                entity.Property(e => e.LocnCms)
                    .HasColumnName("LOCN_CMS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MmidCms)
                    .HasColumnName("MMID_CMS")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.IsumCms)
                    .HasColumnName("ISUM_CMS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LatvCms)
                    .HasColumnName("LATV_CMS")
                    .HasColumnType("datetime");

                entity.Property(e => e.RsumCms)
                    .HasColumnName("RSUM_CMS")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Cstwsum>(entity =>
            {
                entity.HasKey(e => new { e.LocnCws, e.WdatCws })
                    .HasName("PK_CSTWARNSUM");

                entity.ToTable("CSTWSUM");

                entity.Property(e => e.LocnCws)
                    .HasColumnName("LOCN_CWS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.WdatCws)
                    .HasColumnName("WDAT_CWS")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsumCws)
                    .HasColumnName("ISUM_CWS")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DeclareO>(entity =>
            {
                entity.HasKey(e => e.FmnoDo);

                entity.ToTable("DECLARE_O");

                entity.Property(e => e.FmnoDo)
                    .HasColumnName("FMNO_DO")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Fd01Do)
                    .HasColumnName("FD01_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd02Do)
                    .HasColumnName("FD02_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd03Do)
                    .HasColumnName("FD03_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd03cDo)
                    .HasColumnName("FD03C_DO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fd04Do)
                    .HasColumnName("FD04_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd05Do)
                    .HasColumnName("FD05_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd06Do)
                    .HasColumnName("FD06_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd07Do)
                    .HasColumnName("FD07_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd07cDo)
                    .HasColumnName("FD07C_DO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fd08Do)
                    .HasColumnName("FD08_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd09Do)
                    .HasColumnName("FD09_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd10Do)
                    .HasColumnName("FD10_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd11Do)
                    .HasColumnName("FD11_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd11cDo)
                    .HasColumnName("FD11C_DO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fd12Do)
                    .HasColumnName("FD12_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd12cDo)
                    .HasColumnName("FD12C_DO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fd13Do)
                    .HasColumnName("FD13_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd13cDo)
                    .HasColumnName("FD13C_DO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fd14Do)
                    .HasColumnName("FD14_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd14cDo)
                    .HasColumnName("FD14C_DO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fd15Do)
                    .HasColumnName("FD15_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd16Do)
                    .HasColumnName("FD16_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd16cDo)
                    .HasColumnName("FD16C_DO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fd17Do)
                    .HasColumnName("FD17_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd17cDo)
                    .HasColumnName("FD17C_DO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fd18Do)
                    .HasColumnName("FD18_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd18cDo)
                    .HasColumnName("FD18C_DO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fd19Do)
                    .HasColumnName("FD19_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd20Do)
                    .HasColumnName("FD20_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd21Do)
                    .HasColumnName("FD21_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd22Do)
                    .HasColumnName("FD22_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd23Do)
                    .HasColumnName("FD23_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd24Do)
                    .HasColumnName("FD24_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd25Do)
                    .HasColumnName("FD25_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd26Do)
                    .HasColumnName("FD26_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd27Do)
                    .HasColumnName("FD27_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd28Do)
                    .HasColumnName("FD28_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd29Do)
                    .HasColumnName("FD29_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd30Do)
                    .HasColumnName("FD30_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd31Do)
                    .HasColumnName("FD31_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd32Do)
                    .HasColumnName("FD32_DO")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3311Do)
                    .HasColumnName("FD33_11_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3312Do)
                    .HasColumnName("FD33_12_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3313Do)
                    .HasColumnName("FD33_13_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3314Do)
                    .HasColumnName("FD33_14_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3315Do)
                    .HasColumnName("FD33_15_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3316Do)
                    .HasColumnName("FD33_16_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3317Do)
                    .HasColumnName("FD33_17_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3318Do)
                    .HasColumnName("FD33_18_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3319Do)
                    .HasColumnName("FD33_19_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3321Do)
                    .HasColumnName("FD33_21_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3322Do)
                    .HasColumnName("FD33_22_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3323Do)
                    .HasColumnName("FD33_23_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3324Do)
                    .HasColumnName("FD33_24_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3325Do)
                    .HasColumnName("FD33_25_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3326Do)
                    .HasColumnName("FD33_26_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3327Do)
                    .HasColumnName("FD33_27_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3328Do)
                    .HasColumnName("FD33_28_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3329Do)
                    .HasColumnName("FD33_29_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3331Do)
                    .HasColumnName("FD33_31_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3332Do)
                    .HasColumnName("FD33_32_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3333Do)
                    .HasColumnName("FD33_33_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3334Do)
                    .HasColumnName("FD33_34_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3335Do)
                    .HasColumnName("FD33_35_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3336Do)
                    .HasColumnName("FD33_36_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3337Do)
                    .HasColumnName("FD33_37_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3338Do)
                    .HasColumnName("FD33_38_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3339Do)
                    .HasColumnName("FD33_39_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3341Do)
                    .HasColumnName("FD33_41_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3342Do)
                    .HasColumnName("FD33_42_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3343Do)
                    .HasColumnName("FD33_43_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3344Do)
                    .HasColumnName("FD33_44_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3345Do)
                    .HasColumnName("FD33_45_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3346Do)
                    .HasColumnName("FD33_46_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3347Do)
                    .HasColumnName("FD33_47_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3348Do)
                    .HasColumnName("FD33_48_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3349Do)
                    .HasColumnName("FD33_49_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3351Do)
                    .HasColumnName("FD33_51_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3352Do)
                    .HasColumnName("FD33_52_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3353Do)
                    .HasColumnName("FD33_53_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3354Do)
                    .HasColumnName("FD33_54_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3355Do)
                    .HasColumnName("FD33_55_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3356Do)
                    .HasColumnName("FD33_56_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3357Do)
                    .HasColumnName("FD33_57_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3358Do)
                    .HasColumnName("FD33_58_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3359Do)
                    .HasColumnName("FD33_59_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3361Do)
                    .HasColumnName("FD33_61_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3362Do)
                    .HasColumnName("FD33_62_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3363Do)
                    .HasColumnName("FD33_63_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3364Do)
                    .HasColumnName("FD33_64_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3365Do)
                    .HasColumnName("FD33_65_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3366Do)
                    .HasColumnName("FD33_66_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3367Do)
                    .HasColumnName("FD33_67_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3368Do)
                    .HasColumnName("FD33_68_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3369Do)
                    .HasColumnName("FD33_69_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3371Do)
                    .HasColumnName("FD33_71_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3372Do)
                    .HasColumnName("FD33_72_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3373Do)
                    .HasColumnName("FD33_73_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3374Do)
                    .HasColumnName("FD33_74_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3375Do)
                    .HasColumnName("FD33_75_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3376Do)
                    .HasColumnName("FD33_76_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3377Do)
                    .HasColumnName("FD33_77_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3378Do)
                    .HasColumnName("FD33_78_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3379Do)
                    .HasColumnName("FD33_79_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3381Do)
                    .HasColumnName("FD33_81_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3382Do)
                    .HasColumnName("FD33_82_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3383Do)
                    .HasColumnName("FD33_83_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3384Do)
                    .HasColumnName("FD33_84_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3385Do)
                    .HasColumnName("FD33_85_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3386Do)
                    .HasColumnName("FD33_86_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3387Do)
                    .HasColumnName("FD33_87_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3388Do)
                    .HasColumnName("FD33_88_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3389Do)
                    .HasColumnName("FD33_89_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3391Do)
                    .HasColumnName("FD33_91_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3392Do)
                    .HasColumnName("FD33_92_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3393Do)
                    .HasColumnName("FD33_93_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3394Do)
                    .HasColumnName("FD33_94_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3395Do)
                    .HasColumnName("FD33_95_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3396Do)
                    .HasColumnName("FD33_96_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3397Do)
                    .HasColumnName("FD33_97_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3398Do)
                    .HasColumnName("FD33_98_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd3399Do)
                    .HasColumnName("FD33_99_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33A1Do)
                    .HasColumnName("FD33_A1_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33A2Do)
                    .HasColumnName("FD33_A2_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33A3Do)
                    .HasColumnName("FD33_A3_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33A4Do)
                    .HasColumnName("FD33_A4_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33A5Do)
                    .HasColumnName("FD33_A5_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33A6Do)
                    .HasColumnName("FD33_A6_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33A7Do)
                    .HasColumnName("FD33_A7_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33A8Do)
                    .HasColumnName("FD33_A8_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33A9Do)
                    .HasColumnName("FD33_A9_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33B1Do)
                    .HasColumnName("FD33_B1_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33B2Do)
                    .HasColumnName("FD33_B2_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33B3Do)
                    .HasColumnName("FD33_B3_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33B4Do)
                    .HasColumnName("FD33_B4_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33B5Do)
                    .HasColumnName("FD33_B5_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33B6Do)
                    .HasColumnName("FD33_B6_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33B7Do)
                    .HasColumnName("FD33_B7_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33B8Do)
                    .HasColumnName("FD33_B8_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33B9Do)
                    .HasColumnName("FD33_B9_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33C1Do)
                    .HasColumnName("FD33_C1_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33C2Do)
                    .HasColumnName("FD33_C2_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33C3Do)
                    .HasColumnName("FD33_C3_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33C4Do)
                    .HasColumnName("FD33_C4_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33C5Do)
                    .HasColumnName("FD33_C5_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33C6Do)
                    .HasColumnName("FD33_C6_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33C7Do)
                    .HasColumnName("FD33_C7_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33C8Do)
                    .HasColumnName("FD33_C8_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33C9Do)
                    .HasColumnName("FD33_C9_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33D1Do)
                    .HasColumnName("FD33_D1_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33D2Do)
                    .HasColumnName("FD33_D2_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33D3Do)
                    .HasColumnName("FD33_D3_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33D4Do)
                    .HasColumnName("FD33_D4_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33D5Do)
                    .HasColumnName("FD33_D5_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33D6Do)
                    .HasColumnName("FD33_D6_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33D7Do)
                    .HasColumnName("FD33_D7_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33D8Do)
                    .HasColumnName("FD33_D8_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33D9Do)
                    .HasColumnName("FD33_D9_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33E1Do)
                    .HasColumnName("FD33_E1_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33E2Do)
                    .HasColumnName("FD33_E2_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33E3Do)
                    .HasColumnName("FD33_E3_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33E4Do)
                    .HasColumnName("FD33_E4_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33E5Do)
                    .HasColumnName("FD33_E5_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33E6Do)
                    .HasColumnName("FD33_E6_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33E7Do)
                    .HasColumnName("FD33_E7_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33E8Do)
                    .HasColumnName("FD33_E8_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33E9Do)
                    .HasColumnName("FD33_E9_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33F1Do)
                    .HasColumnName("FD33_F1_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33F2Do)
                    .HasColumnName("FD33_F2_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33F3Do)
                    .HasColumnName("FD33_F3_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33F4Do)
                    .HasColumnName("FD33_F4_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33F5Do)
                    .HasColumnName("FD33_F5_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33F6Do)
                    .HasColumnName("FD33_F6_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33F7Do)
                    .HasColumnName("FD33_F7_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33F8Do)
                    .HasColumnName("FD33_F8_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd33F9Do)
                    .HasColumnName("FD33_F9_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd34Do)
                    .HasColumnName("FD34_DO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Fd35Do)
                    .HasColumnName("FD35_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd36Do)
                    .HasColumnName("FD36_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd37Do)
                    .HasColumnName("FD37_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd38Do)
                    .HasColumnName("FD38_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd39Do)
                    .HasColumnName("FD39_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd40Do)
                    .HasColumnName("FD40_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd41Do)
                    .HasColumnName("FD41_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd42Do)
                    .HasColumnName("FD42_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd43Do)
                    .HasColumnName("FD43_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd44Do)
                    .HasColumnName("FD44_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd45Do)
                    .HasColumnName("FD45_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd46Do)
                    .HasColumnName("FD46_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fd47Do)
                    .HasColumnName("FD47_DO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LdatDo)
                    .HasColumnName("LDAT_DO")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtDo)
                    .HasColumnName("LEDT_DO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PlntDo)
                    .HasColumnName("PLNT_DO")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dhdoc>(entity =>
            {
                entity.HasKey(e => e.DocnDoc);

                entity.ToTable("DHDOC");

                entity.Property(e => e.DocnDoc)
                    .HasColumnName("DOCN_DOC")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddrDoc)
                    .HasColumnName("ADDR_DOC")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CntrDoc)
                    .HasColumnName("CNTR_DOC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CstmDoc)
                    .HasColumnName("CSTM_DOC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateDoc)
                    .HasColumnName("DATE_DOC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FtelnDoc)
                    .HasColumnName("FTELN_DOC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LdatDoc)
                    .HasColumnName("LDAT_DOC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtDoc)
                    .HasColumnName("LEDT_DOC")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NameDoc)
                    .HasColumnName("NAME_DOC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PcntDoc).HasColumnName("PCNT_DOC");

                entity.Property(e => e.PlntDoc)
                    .HasColumnName("PLNT_DOC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RdateDoc)
                    .HasColumnName("RDATE_DOC")
                    .HasColumnType("datetime");

                entity.Property(e => e.RemkDoc)
                    .HasColumnName("REMK_DOC")
                    .HasColumnType("text");

                entity.Property(e => e.TelnDoc)
                    .HasColumnName("TELN_DOC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendDoc)
                    .HasColumnName("VEND_DOC")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dhdtl>(entity =>
            {
                entity.HasKey(e => new { e.DocnDtl, e.SnoDtl });

                entity.ToTable("DHDTL");

                entity.Property(e => e.DocnDtl)
                    .HasColumnName("DOCN_DTL")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SnoDtl).HasColumnName("SNO_DTL");

                entity.Property(e => e.DescDtl)
                    .HasColumnName("DESC_DTL")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.LdatDtl)
                    .HasColumnName("LDAT_DTL")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtDtl)
                    .HasColumnName("LEDT_DTL")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PlntDtl)
                    .HasColumnName("PLNT_DTL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PricDtl)
                    .HasColumnName("PRIC_DTL")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.QtyDtl)
                    .HasColumnName("QTY_DTL")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemkDtl)
                    .HasColumnName("REMK_DTL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.YardDtl)
                    .HasColumnName("YARD_DTL")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Docissue>(entity =>
            {
                entity.HasKey(e => new { e.TypeDi, e.LocnDi, e.YearDi })
                    .HasName("PK_DOCISSUE2");

                entity.ToTable("DOCISSUE");

                entity.Property(e => e.TypeDi)
                    .HasColumnName("TYPE_DI")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LocnDi)
                    .HasColumnName("LOCN_DI")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.YearDi)
                    .HasColumnName("YEAR_DI")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LisdDi)
                    .HasColumnName("LISD_DI")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MaxnDi)
                    .HasColumnName("MAXN_DI")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Doctype>(entity =>
            {
                entity.HasKey(e => e.TypeDt);

                entity.ToTable("DOCTYPE");

                entity.Property(e => e.TypeDt)
                    .HasColumnName("TYPE_DT")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Desc3Dt)
                    .HasColumnName("DESC3_DT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DescDt)
                    .HasColumnName("DESC_DT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrfxDt)
                    .HasColumnName("PRFX_DT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SnoDt)
                    .HasColumnName("SNO_DT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.YearDt)
                    .HasColumnName("YEAR_DT")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dollars>(entity =>
            {
                entity.HasKey(e => e.SignDol);

                entity.ToTable("DOLLARS");

                entity.Property(e => e.SignDol)
                    .HasColumnName("SIGN_DOL")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DescDol)
                    .IsRequired()
                    .HasColumnName("DESC_DOL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EquivDol)
                    .HasColumnName("EQUIV_DOL")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LdatDol)
                    .HasColumnName("LDAT_DOL")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtDol)
                    .HasColumnName("LEDT_DOL")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SysDol).HasColumnName("SYS_DOL");
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.HasKey(e => e.EvidEvn);

                entity.ToTable("EVENTS");

                entity.Property(e => e.EvidEvn)
                    .HasColumnName("EVID_EVN")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActnEvn)
                    .HasColumnName("ACTN_EVN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BefdEvn).HasColumnName("BEFD_EVN");

                entity.Property(e => e.ClmkEvn)
                    .HasColumnName("CLMK_EVN")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ClsdEvn)
                    .HasColumnName("CLSD_EVN")
                    .HasColumnType("datetime");

                entity.Property(e => e.CmplEvn).HasColumnName("CMPL_EVN");

                entity.Property(e => e.CrtdEvn)
                    .HasColumnName("CRTD_EVN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlwrEvn)
                    .HasColumnName("FLWR_EVN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LdatEvn)
                    .HasColumnName("LDAT_EVN")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtEvn)
                    .HasColumnName("LEDT_EVN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MdatEvn)
                    .HasColumnName("MDAT_EVN")
                    .HasColumnType("datetime");

                entity.Property(e => e.MesgEvn)
                    .HasColumnName("MESG_EVN")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlntEvn)
                    .HasColumnName("PLNT_EVN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemkEvn)
                    .HasColumnName("REMK_EVN")
                    .HasColumnType("text");

                entity.Property(e => e.WdatEvn)
                    .HasColumnName("WDAT_EVN")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Finished>(entity =>
            {
                entity.HasKey(e => new { e.LocnFns, e.PartFns });

                entity.ToTable("FINISHED");

                entity.Property(e => e.LocnFns)
                    .HasColumnName("LOCN_FNS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PartFns)
                    .HasColumnName("PART_FNS")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LdatFns)
                    .HasColumnName("LDAT_FNS")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtFns)
                    .HasColumnName("LEDT_FNS")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RateFns)
                    .HasColumnName("RATE_FNS")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<Gdlabel>(entity =>
            {
                entity.HasKey(e => e.PartGdl);

                entity.ToTable("GDLABEL");

                entity.Property(e => e.PartGdl)
                    .HasColumnName("PART_GDL")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.LdatGdl)
                    .HasColumnName("LDAT_GDL")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtGdl)
                    .HasColumnName("LEDT_GDL")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NetwGdl)
                    .HasColumnName("NETW_GDL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlntGdl)
                    .HasColumnName("PLNT_GDL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Spec2Gdl)
                    .HasColumnName("SPEC2_GDL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Spec4Gdl)
                    .HasColumnName("SPEC4_GDL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecGdl)
                    .HasColumnName("SPEC_GDL")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Inven>(entity =>
            {
                entity.HasKey(e => new { e.LocnIvn, e.PartIvn });

                entity.ToTable("INVEN");

                entity.Property(e => e.LocnIvn)
                    .HasColumnName("LOCN_IVN")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PartIvn)
                    .HasColumnName("PART_IVN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AdjqIvn)
                    .HasColumnName("ADJQ_IVN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.AudtIvn)
                    .HasColumnName("AUDT_IVN")
                    .HasColumnType("datetime");

                entity.Property(e => e.BfadIvn)
                    .HasColumnName("BFAD_IVN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BivnIvn)
                    .HasColumnName("BIVN_IVN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BlceIvn)
                    .HasColumnName("BLCE_IVN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InqIvn)
                    .HasColumnName("INQ_IVN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.IprcIvn)
                    .HasColumnName("IPRC_IVN")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LdatIvn)
                    .HasColumnName("LDAT_IVN")
                    .HasColumnType("datetime");

                entity.Property(e => e.OcpyIvn)
                    .HasColumnName("OCPY_IVN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.OutqIvn)
                    .HasColumnName("OUTQ_IVN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PckqIvn)
                    .HasColumnName("PCKQ_IVN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SblcIvn)
                    .HasColumnName("SBLC_IVN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ScpqIvn)
                    .HasColumnName("SCPQ_IVN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SldtIvn)
                    .HasColumnName("SLDT_IVN")
                    .HasColumnType("datetime");

                entity.Property(e => e.SledIvn)
                    .HasColumnName("SLED_IVN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UseqIvn)
                    .HasColumnName("USEQ_IVN")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<Invenbat>(entity =>
            {
                entity.HasKey(e => new { e.LocnIvb, e.PartIvb, e.DoctIvb, e.DocnIvb, e.SnoIvb });

                entity.ToTable("INVENBAT");

                entity.Property(e => e.LocnIvb)
                    .HasColumnName("LOCN_IVB")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PartIvb)
                    .HasColumnName("PART_IVB")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DoctIvb)
                    .HasColumnName("DOCT_IVB")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocnIvb)
                    .HasColumnName("DOCN_IVB")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SnoIvb).HasColumnName("SNO_IVB");

                entity.Property(e => e.AddqIvb)
                    .HasColumnName("ADDQ_IVB")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ChckIvb).HasColumnName("CHCK_IVB");

                entity.Property(e => e.FpkcIvb)
                    .HasColumnName("FPKC_IVB")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.IprcIvb)
                    .HasColumnName("IPRC_IVB")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LdatIvb)
                    .HasColumnName("LDAT_IVB")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtIvb)
                    .HasColumnName("LEDT_IVB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.QtyIvb)
                    .HasColumnName("QTY_IVB")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.VendIvb)
                    .HasColumnName("VEND_IVB")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ZgkcIvb)
                    .HasColumnName("ZGKC_IVB")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<Itemmst>(entity =>
            {
                entity.HasKey(e => e.PartIt);

                entity.ToTable("ITEMMST");

                entity.Property(e => e.PartIt)
                    .HasColumnName("PART_IT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BarcIt)
                    .HasColumnName("BARC_IT")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.BctrlIt).HasColumnName("BCTRL_IT");

                entity.Property(e => e.Desc2It)
                    .HasColumnName("DESC2_IT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescIt)
                    .HasColumnName("DESC_IT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EquivIt)
                    .HasColumnName("EQUIV_IT")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.IprcIt)
                    .HasColumnName("IPRC_IT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IvnjsIt).HasColumnName("IVNJS_IT");

                entity.Property(e => e.LdatIt)
                    .HasColumnName("LDAT_IT")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtIt)
                    .HasColumnName("LEDT_IT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LprcIt)
                    .HasColumnName("LPRC_IT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LrecIt)
                    .HasColumnName("LREC_IT")
                    .HasColumnType("datetime");

                entity.Property(e => e.LrprcIt)
                    .HasColumnName("LRPRC_IT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LshpIt)
                    .HasColumnName("LSHP_IT")
                    .HasColumnType("datetime");

                entity.Property(e => e.LsprcIt)
                    .HasColumnName("LSPRC_IT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MadeIt)
                    .HasColumnName("MADE_IT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MakdIt)
                    .HasColumnName("MAKD_IT")
                    .HasColumnType("datetime");

                entity.Property(e => e.MakrIt)
                    .HasColumnName("MAKR_IT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MaxqIt)
                    .HasColumnName("MAXQ_IT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinqIt)
                    .HasColumnName("MINQ_IT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Oprc1It)
                    .HasColumnName("OPRC1_IT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Oprc2It)
                    .HasColumnName("OPRC2_IT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Oprc3It)
                    .HasColumnName("OPRC3_IT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Oprc4It)
                    .HasColumnName("OPRC4_IT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OprcIt)
                    .HasColumnName("OPRC_IT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PdatIt)
                    .HasColumnName("PDAT_IT")
                    .HasColumnType("datetime");

                entity.Property(e => e.PedtIt)
                    .HasColumnName("PEDT_IT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Pn2It)
                    .HasColumnName("PN2_IT")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PqtyIt)
                    .HasColumnName("PQTY_IT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PunitIt)
                    .HasColumnName("PUNIT_IT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PybmIt)
                    .HasColumnName("PYBM_IT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemkIt)
                    .HasColumnName("REMK_IT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SpecIt)
                    .HasColumnName("SPEC_IT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Typ2It)
                    .HasColumnName("TYP2_IT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeIt)
                    .HasColumnName("TYPE_IT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UnitIt)
                    .HasColumnName("UNIT_IT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.VendIt)
                    .HasColumnName("VEND_IT")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Itemprice>(entity =>
            {
                entity.HasKey(e => new { e.PlntItp, e.PartItp });

                entity.ToTable("ITEMPRICE");

                entity.Property(e => e.PlntItp)
                    .HasColumnName("PLNT_ITP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PartItp)
                    .HasColumnName("PART_ITP")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.IprcItp)
                    .HasColumnName("IPRC_ITP")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LdatItp)
                    .HasColumnName("LDAT_ITP")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtItp)
                    .HasColumnName("LEDT_ITP")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LprcItp)
                    .HasColumnName("LPRC_ITP")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LrecItp)
                    .HasColumnName("LREC_ITP")
                    .HasColumnType("datetime");

                entity.Property(e => e.LrprcItp)
                    .HasColumnName("LRPRC_ITP")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LshpItp)
                    .HasColumnName("LSHP_ITP")
                    .HasColumnType("datetime");

                entity.Property(e => e.LsprcItp)
                    .HasColumnName("LSPRC_ITP")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Oprc1Itp)
                    .HasColumnName("OPRC1_ITP")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Oprc2Itp)
                    .HasColumnName("OPRC2_ITP")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Oprc3Itp)
                    .HasColumnName("OPRC3_ITP")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Oprc4Itp)
                    .HasColumnName("OPRC4_ITP")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OprcItp)
                    .HasColumnName("OPRC_ITP")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PdatItp)
                    .HasColumnName("PDAT_ITP")
                    .HasColumnType("datetime");

                entity.Property(e => e.PedtItp)
                    .HasColumnName("PEDT_ITP")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Itemtype>(entity =>
            {
                entity.HasKey(e => e.CmpnPty);

                entity.ToTable("ITEMTYPE");

                entity.Property(e => e.CmpnPty)
                    .HasColumnName("CMPN_PTY")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DescPty)
                    .HasColumnName("DESC_PTY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LdatPty)
                    .HasColumnName("LDAT_PTY")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtPty)
                    .HasColumnName("LEDT_PTY")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Itemvend>(entity =>
            {
                entity.HasKey(e => new { e.PartIv, e.VendIv });

                entity.ToTable("ITEMVEND");

                entity.Property(e => e.PartIv)
                    .HasColumnName("PART_IV")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VendIv)
                    .HasColumnName("VEND_IV")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LdatIv)
                    .HasColumnName("LDAT_IV")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtIv)
                    .HasColumnName("LEDT_IV")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ivndbk>(entity =>
            {
                entity.HasKey(e => new { e.CutdIvn, e.LocnIvn, e.PartIvn });

                entity.ToTable("IVNDBK");

                entity.Property(e => e.CutdIvn)
                    .HasColumnName("CUTD_IVN")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocnIvn)
                    .HasColumnName("LOCN_IVN")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PartIvn)
                    .HasColumnName("PART_IVN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BlceIvn)
                    .HasColumnName("BLCE_IVN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LdatIvn)
                    .HasColumnName("LDAT_IVN")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Ivnloc>(entity =>
            {
                entity.HasKey(e => new { e.LocnIvl, e.PartIvl, e.PrdnIvl });

                entity.ToTable("IVNLOC");

                entity.Property(e => e.LocnIvl)
                    .HasColumnName("LOCN_IVL")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PartIvl)
                    .HasColumnName("PART_IVL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PrdnIvl)
                    .HasColumnName("PRDN_IVL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BlceIvl)
                    .HasColumnName("BLCE_IVL")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InpdIvl)
                    .HasColumnName("INPD_IVL")
                    .HasColumnType("datetime");

                entity.Property(e => e.InptIvl)
                    .HasColumnName("INPT_IVL")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LdatIvl)
                    .HasColumnName("LDAT_IVL")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtIvl)
                    .HasColumnName("LEDT_IVL")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ivnmbk>(entity =>
            {
                entity.HasKey(e => new { e.CutdIvn, e.LocnIvn, e.PartIvn });

                entity.ToTable("IVNMBK");

                entity.Property(e => e.CutdIvn)
                    .HasColumnName("CUTD_IVN")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocnIvn)
                    .HasColumnName("LOCN_IVN")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PartIvn)
                    .HasColumnName("PART_IVN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AdjqIvn)
                    .HasColumnName("ADJQ_IVN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.AudtIvn)
                    .HasColumnName("AUDT_IVN")
                    .HasColumnType("datetime");

                entity.Property(e => e.BfadIvn)
                    .HasColumnName("BFAD_IVN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BiprcIvn)
                    .HasColumnName("BIPRC_IVN")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BivnIvn)
                    .HasColumnName("BIVN_IVN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BlceIvn)
                    .HasColumnName("BLCE_IVN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InqIvn)
                    .HasColumnName("INQ_IVN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.IprcIvn)
                    .HasColumnName("IPRC_IVN")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LdatIvn)
                    .HasColumnName("LDAT_IVN")
                    .HasColumnType("datetime");

                entity.Property(e => e.OcpyIvn)
                    .HasColumnName("OCPY_IVN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.OutqIvn)
                    .HasColumnName("OUTQ_IVN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PckqIvn)
                    .HasColumnName("PCKQ_IVN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SblcIvn)
                    .HasColumnName("SBLC_IVN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ScpqIvn)
                    .HasColumnName("SCPQ_IVN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SldtIvn)
                    .HasColumnName("SLDT_IVN")
                    .HasColumnType("datetime");

                entity.Property(e => e.SledIvn)
                    .HasColumnName("SLED_IVN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UseqIvn)
                    .HasColumnName("USEQ_IVN")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<Ivntrn>(entity =>
            {
                entity.HasKey(e => new { e.DoctItr, e.DocnItr, e.LocnItr, e.PartItr });

                entity.ToTable("IVNTRN");

                entity.Property(e => e.DoctItr)
                    .HasColumnName("DOCT_ITR")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocnItr)
                    .HasColumnName("DOCN_ITR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LocnItr)
                    .HasColumnName("LOCN_ITR")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PartItr)
                    .HasColumnName("PART_ITR")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BlceItr)
                    .HasColumnName("BLCE_ITR")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DateItr)
                    .HasColumnName("DATE_ITR")
                    .HasColumnType("datetime");

                entity.Property(e => e.IqtyItr)
                    .HasColumnName("IQTY_ITR")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LedtItr)
                    .HasColumnName("LEDT_ITR")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OqtyItr)
                    .HasColumnName("OQTY_ITR")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PlntItr)
                    .HasColumnName("PLNT_ITR")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Locator>(entity =>
            {
                entity.HasKey(e => e.LtrnLtr);

                entity.ToTable("LOCATOR");

                entity.Property(e => e.LtrnLtr)
                    .HasColumnName("LTRN_LTR")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DescLtr)
                    .HasColumnName("DESC_LTR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LdatLtr)
                    .HasColumnName("LDAT_LTR")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtLtr)
                    .HasColumnName("LEDT_LTR")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LocnLtr)
                    .HasColumnName("LOCN_LTR")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loctb>(entity =>
            {
                entity.HasKey(e => e.LocnLtb);

                entity.ToTable("LOCTB");

                entity.Property(e => e.LocnLtb)
                    .HasColumnName("LOCN_LTB")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccnLtb)
                    .HasColumnName("ACCN_LTB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AcntLtb)
                    .HasColumnName("ACNT_LTB")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddrLtb)
                    .HasColumnName("ADDR_LTB")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AtelLtb)
                    .HasColumnName("ATEL_LTB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankLtb)
                    .HasColumnName("BANK_LTB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BivnLtb).HasColumnName("BIVN_LTB");

                entity.Property(e => e.CntrLtb)
                    .HasColumnName("CNTR_LTB")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CrtdLtb)
                    .HasColumnName("CRTD_LTB")
                    .HasColumnType("datetime");

                entity.Property(e => e.DcckLtb).HasColumnName("DCCK_LTB");

                entity.Property(e => e.DescLtb)
                    .HasColumnName("DESC_LTB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DzdlbLtb)
                    .HasColumnName("DZDLB_LTB")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmailLtb)
                    .HasColumnName("EMAIL_LTB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FaxLtb)
                    .HasColumnName("FAX_LTB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LatvLtb)
                    .HasColumnName("LATV_LTB")
                    .HasColumnType("datetime");

                entity.Property(e => e.LdatLtb)
                    .HasColumnName("LDAT_LTB")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtLtb)
                    .HasColumnName("LEDT_LTB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PlntLtb)
                    .HasColumnName("PLNT_LTB")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PostLtb)
                    .HasColumnName("POST_LTB")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PybmLtb)
                    .HasColumnName("PYBM_LTB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemkLtb)
                    .HasColumnName("REMK_LTB")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SdesLtb)
                    .HasColumnName("SDES_LTB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxnLtb)
                    .HasColumnName("TAXN_LTB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelnLtb)
                    .HasColumnName("TELN_LTB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeLtb)
                    .HasColumnName("TYPE_LTB")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WebLtb)
                    .HasColumnName("WEB_LTB")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Monthsum>(entity =>
            {
                entity.HasKey(e => new { e.CutdMsm, e.PlntMsm, e.OrdrMsm });

                entity.ToTable("MONTHSUM");

                entity.Property(e => e.CutdMsm)
                    .HasColumnName("CUTD_MSM")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlntMsm)
                    .HasColumnName("PLNT_MSM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrdrMsm)
                    .HasColumnName("ORDR_MSM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AdsmMsm)
                    .HasColumnName("ADSM_MSM")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BlceMsm)
                    .HasColumnName("BLCE_MSM")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DescMsm)
                    .HasColumnName("DESC_MSM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LdatMsm)
                    .HasColumnName("LDAT_MSM")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtMsm)
                    .HasColumnName("LEDT_MSM")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MnthMsm)
                    .HasColumnName("MNTH_MSM")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.YearMsm)
                    .HasColumnName("YEAR_MSM")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Moveprice>(entity =>
            {
                entity.HasKey(e => new { e.DeptMop, e.TypeMop, e.DocnMop, e.PartMop, e.SnoMop });

                entity.ToTable("MOVEPRICE");

                entity.Property(e => e.DeptMop)
                    .HasColumnName("DEPT_MOP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TypeMop)
                    .HasColumnName("TYPE_MOP")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocnMop)
                    .HasColumnName("DOCN_MOP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PartMop)
                    .HasColumnName("PART_MOP")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SnoMop).HasColumnName("SNO_MOP");

                entity.Property(e => e.ChekMop).HasColumnName("CHEK_MOP");

                entity.Property(e => e.ChkdMop)
                    .HasColumnName("CHKD_MOP")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChkrMop)
                    .HasColumnName("CHKR_MOP")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DateMop)
                    .HasColumnName("DATE_MOP")
                    .HasColumnType("datetime");

                entity.Property(e => e.DisqMop).HasColumnName("DISQ_MOP");

                entity.Property(e => e.LdatMop)
                    .HasColumnName("LDAT_MOP")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtMop)
                    .HasColumnName("LEDT_MOP")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PckqMop).HasColumnName("PCKQ_MOP");

                entity.Property(e => e.RemkMop)
                    .HasColumnName("REMK_MOP")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SumMop)
                    .HasColumnName("SUM_MOP")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Mphead>(entity =>
            {
                entity.HasKey(e => e.ProcMph);

                entity.ToTable("MPHEAD");

                entity.Property(e => e.ProcMph)
                    .HasColumnName("PROC_MPH")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BlceMph)
                    .HasColumnName("BLCE_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Col1Mph)
                    .HasColumnName("COL1_MPH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Col2Mph)
                    .HasColumnName("COL2_MPH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Col3Mph)
                    .HasColumnName("COL3_MPH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Col4Mph)
                    .HasColumnName("COL4_MPH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Col5Mph)
                    .HasColumnName("COL5_MPH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Col6Mph)
                    .HasColumnName("COL6_MPH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Col7Mph)
                    .HasColumnName("COL7_MPH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Col8Mph)
                    .HasColumnName("COL8_MPH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CrtdMph)
                    .HasColumnName("CRTD_MPH")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateMph)
                    .HasColumnName("DATE_MPH")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ddat1Mph)
                    .HasColumnName("DDAT1_MPH")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ddat2Mph)
                    .HasColumnName("DDAT2_MPH")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ddat3Mph)
                    .HasColumnName("DDAT3_MPH")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dqty11Mph)
                    .HasColumnName("DQTY11_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty12Mph)
                    .HasColumnName("DQTY12_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty13Mph)
                    .HasColumnName("DQTY13_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty14Mph)
                    .HasColumnName("DQTY14_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty15Mph)
                    .HasColumnName("DQTY15_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty16Mph)
                    .HasColumnName("DQTY16_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty17Mph)
                    .HasColumnName("DQTY17_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty18Mph)
                    .HasColumnName("DQTY18_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty21Mph)
                    .HasColumnName("DQTY21_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty22Mph)
                    .HasColumnName("DQTY22_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty23Mph)
                    .HasColumnName("DQTY23_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty24Mph)
                    .HasColumnName("DQTY24_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty25Mph)
                    .HasColumnName("DQTY25_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty26Mph)
                    .HasColumnName("DQTY26_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty27Mph)
                    .HasColumnName("DQTY27_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty28Mph)
                    .HasColumnName("DQTY28_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty31Mph)
                    .HasColumnName("DQTY31_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty32Mph)
                    .HasColumnName("DQTY32_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty33Mph)
                    .HasColumnName("DQTY33_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty34Mph)
                    .HasColumnName("DQTY34_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty35Mph)
                    .HasColumnName("DQTY35_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty36Mph)
                    .HasColumnName("DQTY36_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty37Mph)
                    .HasColumnName("DQTY37_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dqty38Mph)
                    .HasColumnName("DQTY38_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.IprcMph)
                    .HasColumnName("IPRC_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LdatMph)
                    .HasColumnName("LDAT_MPH")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtMph)
                    .HasColumnName("LEDT_MPH")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LocnMph)
                    .HasColumnName("LOCN_MPH")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PartMph)
                    .HasColumnName("PART_MPH")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PdotMph)
                    .HasColumnName("PDOT_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PlntMph)
                    .HasColumnName("PLNT_MPH")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Pn2Mph)
                    .HasColumnName("PN2_MPH")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PricMph)
                    .HasColumnName("PRIC_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.RemkMph)
                    .HasColumnName("REMK_MPH")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Rmk2Mph)
                    .HasColumnName("RMK2_MPH")
                    .HasColumnType("ntext");

                entity.Property(e => e.ScprMph)
                    .HasColumnName("SCPR_MPH")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.StatMph)
                    .HasColumnName("STAT_MPH")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mtlhd>(entity =>
            {
                entity.HasKey(e => e.DescMtv);

                entity.ToTable("MTLHD");

                entity.Property(e => e.DescMtv)
                    .HasColumnName("DESC_MTV")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.PlntMtv)
                    .HasColumnName("PLNT_MTV")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PybmMtv)
                    .HasColumnName("PYBM_MTV")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Notepad>(entity =>
            {
                entity.HasKey(e => e.PagePad);

                entity.ToTable("NOTEPAD");

                entity.Property(e => e.PagePad)
                    .HasColumnName("PAGE_PAD")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CachetPad)
                    .HasColumnName("CACHET_PAD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CasePad)
                    .HasColumnName("CASE_PAD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CmplPad).HasColumnName("CMPL_PAD");

                entity.Property(e => e.CrtdPad)
                    .HasColumnName("CRTD_PAD")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatePad)
                    .HasColumnName("DATE_PAD")
                    .HasColumnType("datetime");

                entity.Property(e => e.FfaxPad)
                    .HasColumnName("FFAX_PAD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FnamPad)
                    .HasColumnName("FNAM_PAD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FtelPad)
                    .HasColumnName("FTEL_PAD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LdatPad)
                    .HasColumnName("LDAT_PAD")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtPad)
                    .HasColumnName("LEDT_PAD")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PcntPad).HasColumnName("PCNT_PAD");

                entity.Property(e => e.PlntPad)
                    .HasColumnName("PLNT_PAD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrmkPad).HasColumnName("PRMK_PAD");

                entity.Property(e => e.Remk2Pad)
                    .HasColumnName("REMK2_PAD")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Remk3Pad)
                    .HasColumnName("REMK3_PAD")
                    .HasColumnType("ntext");

                entity.Property(e => e.RemkPad)
                    .HasColumnName("REMK_PAD")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SealPad).HasColumnName("SEAL_PAD");

                entity.Property(e => e.TcpyPad)
                    .HasColumnName("TCPY_PAD")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TfaxPad)
                    .HasColumnName("TFAX_PAD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TnamPad)
                    .HasColumnName("TNAM_PAD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TtelPad)
                    .HasColumnName("TTEL_PAD")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Passwrd>(entity =>
            {
                entity.HasKey(e => e.EmpnPsw);

                entity.ToTable("PASSWRD");

                entity.Property(e => e.EmpnPsw)
                    .HasColumnName("EMPN_PSW")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreaPsw)
                    .HasColumnName("CREA_PSW")
                    .HasColumnType("datetime");

                entity.Property(e => e.EdatPsw)
                    .HasColumnName("EDAT_PSW")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpdPsw)
                    .HasColumnName("EXPD_PSW")
                    .HasColumnType("datetime");

                entity.Property(e => e.LlgnPsw)
                    .HasColumnName("LLGN_PSW")
                    .HasColumnType("datetime");

                entity.Property(e => e.LockPsw).HasColumnName("LOCK_PSW");

                entity.Property(e => e.PswdPsw)
                    .HasColumnName("PSWD_PSW")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Paydoc>(entity =>
            {
                entity.HasKey(e => e.DocnPdc);

                entity.ToTable("PAYDOC");

                entity.Property(e => e.DocnPdc)
                    .HasColumnName("DOCN_PDC")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccnPdc)
                    .HasColumnName("ACCN_PDC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankPdc)
                    .HasColumnName("BANK_PDC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CpnyPdc)
                    .IsRequired()
                    .HasColumnName("CPNY_PDC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaPdc)
                    .HasColumnName("CREA_PDC")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CrtdPdc)
                    .HasColumnName("CRTD_PDC")
                    .HasColumnType("datetime");

                entity.Property(e => e.CstmPdc)
                    .HasColumnName("CSTM_PDC")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CwPdc)
                    .HasColumnName("CW_PDC")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CwyjPdc)
                    .HasColumnName("CWYJ_PDC")
                    .HasColumnType("text");

                entity.Property(e => e.DatePdc)
                    .HasColumnName("DATE_PDC")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeptPdc)
                    .HasColumnName("DEPT_PDC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DollPdc)
                    .HasColumnName("DOLL_PDC")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FqrPdc)
                    .HasColumnName("FQR_PDC")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FqryjPdc)
                    .HasColumnName("FQRYJ_PDC")
                    .HasColumnType("text");

                entity.Property(e => e.JlPdc)
                    .HasColumnName("JL_PDC")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.JlyjPdc)
                    .HasColumnName("JLYJ_PDC")
                    .HasColumnType("text");

                entity.Property(e => e.LdatPdc)
                    .HasColumnName("LDAT_PDC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtPdc)
                    .HasColumnName("LEDT_PDC")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PsumPdc)
                    .HasColumnName("PSUM_PDC")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SmsgPdc).HasColumnName("SMSG_PDC");

                entity.Property(e => e.SpyjPdc)
                    .HasColumnName("SPYJ_PDC")
                    .HasColumnType("text");

                entity.Property(e => e.StatPdc)
                    .HasColumnName("STAT_PDC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SumPdc)
                    .HasColumnName("SUM_PDC")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TypePdc)
                    .HasColumnName("TYPE_PDC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UsetoPdc)
                    .HasColumnName("USETO_PDC")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<PaydocIssue>(entity =>
            {
                entity.HasKey(e => new { e.YearDi, e.MaxnDi });

                entity.ToTable("PAYDOC_ISSUE");

                entity.Property(e => e.YearDi)
                    .HasColumnName("YEAR_DI")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MaxnDi)
                    .HasColumnName("MAXN_DI")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LisdDi)
                    .HasColumnName("LISD_DI")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Personel>(entity =>
            {
                entity.HasKey(e => e.EmpnPsl);

                entity.ToTable("PERSONEL");

                entity.Property(e => e.EmpnPsl)
                    .HasColumnName("EMPN_PSL")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccnPsl)
                    .HasColumnName("ACCN_PSL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BookPsl)
                    .HasColumnName("BOOK_PSL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BrthPsl)
                    .HasColumnName("BRTH_PSL")
                    .HasColumnType("datetime");

                entity.Property(e => e.DdidPsl)
                    .HasColumnName("DDID_PSL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmailPsl)
                .HasColumnName("Email_PSL")
                .HasMaxLength(500)
                .IsUnicode(false);

                entity.Property(e => e.DeptPsl)
                    .HasColumnName("DEPT_PSL")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EdctPsl)
                    .HasColumnName("EDCT_PSL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Exp1Psl)
                    .HasColumnName("EXP1_PSL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Exp2Psl)
                    .HasColumnName("EXP2_PSL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Exp3Psl)
                    .HasColumnName("EXP3_PSL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Exp4Psl)
                    .HasColumnName("EXP4_PSL")
                    .HasColumnType("datetime");

                entity.Property(e => e.GenlPsl)
                    .HasColumnName("GENL_PSL")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.HcntPsl)
                    .HasColumnName("HCNT_PSL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HomePsl)
                    .HasColumnName("HOME_PSL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HtelPsl)
                    .HasColumnName("HTEL_PSL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IddpPsl)
                    .HasColumnName("IDDP_PSL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdnbPsl)
                    .HasColumnName("IDNB_PSL")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.IdxpPsl)
                    .HasColumnName("IDXP_PSL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ins1Psl)
                    .HasColumnName("INS1_PSL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ins2Psl)
                    .HasColumnName("INS2_PSL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ins3Psl)
                    .HasColumnName("INS3_PSL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ins4Psl)
                    .HasColumnName("INS4_PSL")
                    .HasColumnType("datetime");

                entity.Property(e => e.JndtPsl)
                    .HasColumnName("JNDT_PSL")
                    .HasColumnType("datetime");

                entity.Property(e => e.JoinPsl)
                    .HasColumnName("JOIN_PSL")
                    .HasColumnType("datetime");

                entity.Property(e => e.LcpyPsl)
                    .HasColumnName("LCPY_PSL")
                    .HasColumnType("image");

                entity.Property(e => e.LdatPsl)
                    .HasColumnName("LDAT_PSL")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtPsl)
                    .HasColumnName("LEDT_PSL")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MatrPsl)
                    .HasColumnName("MATR_PSL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NadrPsl)
                    .HasColumnName("NADR_PSL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NamePsl)
                    .HasColumnName("NAME_PSL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NatnPsl)
                    .HasColumnName("NATN_PSL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NcntPsl)
                    .HasColumnName("NCNT_PSL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NtelPsl)
                    .HasColumnName("NTEL_PSL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PictPsl)
                    .HasColumnName("PICT_PSL")
                    .HasColumnType("image");

                entity.Property(e => e.PlntPsl)
                    .HasColumnName("PLNT_PSL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PosiPsl)
                    .HasColumnName("POSI_PSL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PqtyPsl)
                    .HasColumnName("PQTY_PSL")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PrvnPsl)
                    .HasColumnName("PRVN_PSL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PtypPsl)
                    .HasColumnName("PTYP_PSL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.QinPsl)
                    .HasColumnName("QIN_PSL")
                    .HasColumnType("datetime");

                entity.Property(e => e.QoutPsl)
                    .HasColumnName("QOUT_PSL")
                    .HasColumnType("datetime");

                entity.Property(e => e.QrmkPsl)
                    .HasColumnName("QRMK_PSL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuarPsl)
                    .HasColumnName("QUAR_PSL")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RemkPsl)
                    .HasColumnName("REMK_PSL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RsdtPsl)
                    .HasColumnName("RSDT_PSL")
                    .HasColumnType("datetime");

                entity.Property(e => e.SexPsl)
                    .HasColumnName("SEX_PSL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Typ3Psl)
                    .HasColumnName("TYP3_PSL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Typ4Psl)
                    .HasColumnName("TYP4_PSL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WklcPsl)
                    .HasColumnName("WKLC_PSL")
                    .HasMaxLength(18)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Plants>(entity =>
            {
                entity.HasKey(e => e.PlntPlt);

                entity.ToTable("PLANTS");

                entity.Property(e => e.PlntPlt)
                    .HasColumnName("PLNT_PLT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CadrPlt)
                    .HasColumnName("CADR_PLT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescPlt)
                    .HasColumnName("DESC_PLT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FaxPlt)
                    .HasColumnName("FAX_PLT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LdatPlt)
                    .HasColumnName("LDAT_PLT")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtPlt)
                    .HasColumnName("LEDT_PLT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PhonPlt)
                    .HasColumnName("PHON_PLT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostPlt)
                    .HasColumnName("POST_PLT")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pnmaker>(entity =>
            {
                entity.HasKey(e => new { e.PrntPmk, e.CmpnPmk });

                entity.ToTable("PNMAKER");

                entity.Property(e => e.PrntPmk)
                    .HasColumnName("PRNT_PMK")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CmpnPmk)
                    .HasColumnName("CMPN_PMK")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DescPmk)
                    .HasColumnName("DESC_PMK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LdatPmk)
                    .HasColumnName("LDAT_PMK")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtPmk)
                    .HasColumnName("LEDT_PMK")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PoCntIssue>(entity =>
            {
                entity.HasKey(e => e.TypePci)
                    .HasName("PK_PO_CNT_ISSUE_1");

                entity.ToTable("PO_CNT_ISSUE");

                entity.Property(e => e.TypePci)
                    .HasColumnName("TYPE_PCI")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.MaxnPci).HasColumnName("MAXN_PCI");

                entity.Property(e => e.PrfxPci)
                    .IsRequired()
                    .HasColumnName("PRFX_PCI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.YearPci)
                    .HasColumnName("YEAR_PCI")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pomodoc>(entity =>
            {
                entity.HasKey(e => e.DocnPmo);

                entity.ToTable("POMODOC");

                entity.Property(e => e.DocnPmo)
                    .HasColumnName("DOCN_PMO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CachetPmo)
                    .HasColumnName("CACHET_PMO")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ClraqPmo)
                    .HasColumnName("CLRAQ_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClrasPmo)
                    .HasColumnName("CLRAS_PMO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClravPmo)
                    .HasColumnName("CLRAV_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClrbqPmo)
                    .HasColumnName("CLRBQ_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClrbsPmo)
                    .HasColumnName("CLRBS_PMO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClrbvPmo)
                    .HasColumnName("CLRBV_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClrcqPmo)
                    .HasColumnName("CLRCQ_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClrcsPmo)
                    .HasColumnName("CLRCS_PMO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClrcvPmo)
                    .HasColumnName("CLRCV_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClrdqPmo)
                    .HasColumnName("CLRDQ_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClrdsPmo)
                    .HasColumnName("CLRDS_PMO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClrdvPmo)
                    .HasColumnName("CLRDV_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClreqPmo)
                    .HasColumnName("CLREQ_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClresPmo)
                    .HasColumnName("CLRES_PMO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClrevPmo)
                    .HasColumnName("CLREV_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClrfqPmo)
                    .HasColumnName("CLRFQ_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClrfsPmo)
                    .HasColumnName("CLRFS_PMO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClrfvPmo)
                    .HasColumnName("CLRFV_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClrgqPmo)
                    .HasColumnName("CLRGQ_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClrgsPmo)
                    .HasColumnName("CLRGS_PMO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClrgvPmo)
                    .HasColumnName("CLRGV_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClrhqPmo)
                    .HasColumnName("CLRHQ_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClrhsPmo)
                    .HasColumnName("CLRHS_PMO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClrhvPmo)
                    .HasColumnName("CLRHV_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CmplPmo).HasColumnName("CMPL_PMO");

                entity.Property(e => e.CpfdPmo)
                    .HasColumnName("CPFD_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CrtdPmo)
                    .HasColumnName("CRTD_PMO")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatePmo)
                    .HasColumnName("DATE_PMO")
                    .HasColumnType("datetime");

                entity.Property(e => e.DescPmo)
                    .HasColumnName("DESC_PMO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LdatPmo)
                    .HasColumnName("LDAT_PMO")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtPmo)
                    .HasColumnName("LEDT_PMO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MrmkPmo)
                    .HasColumnName("MRMK_PMO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nr10cPmo)
                    .HasColumnName("NR10C_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr10vPmo)
                    .HasColumnName("NR10V_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr11cPmo)
                    .HasColumnName("NR11C_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr11vPmo)
                    .HasColumnName("NR11V_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr12cPmo)
                    .HasColumnName("NR12C_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr12vPmo)
                    .HasColumnName("NR12V_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr13cPmo)
                    .HasColumnName("NR13C_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr13vPmo)
                    .HasColumnName("NR13V_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr14cPmo)
                    .HasColumnName("NR14C_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr14vPmo)
                    .HasColumnName("NR14V_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr15cPmo)
                    .HasColumnName("NR15C_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr15vPmo)
                    .HasColumnName("NR15V_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr16cPmo)
                    .HasColumnName("NR16C_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr16vPmo)
                    .HasColumnName("NR16V_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr1cPmo)
                    .HasColumnName("NR1C_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr1vPmo)
                    .HasColumnName("NR1V_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr2cPmo)
                    .HasColumnName("NR2C_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr2vPmo)
                    .HasColumnName("NR2V_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr3cPmo)
                    .HasColumnName("NR3C_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr3vPmo)
                    .HasColumnName("NR3V_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr4cPmo)
                    .HasColumnName("NR4C_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr4vPmo)
                    .HasColumnName("NR4V_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr5cPmo)
                    .HasColumnName("NR5C_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr5vPmo)
                    .HasColumnName("NR5V_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr6cPmo)
                    .HasColumnName("NR6C_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr6vPmo)
                    .HasColumnName("NR6V_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr7cPmo)
                    .HasColumnName("NR7C_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr7vPmo)
                    .HasColumnName("NR7V_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr8cPmo)
                    .HasColumnName("NR8C_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr8vPmo)
                    .HasColumnName("NR8V_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr9cPmo)
                    .HasColumnName("NR9C_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nr9vPmo)
                    .HasColumnName("NR9V_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PackPmo)
                    .HasColumnName("PACK_PMO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PbmfPmo)
                    .HasColumnName("PBMF_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PcntPmo).HasColumnName("PCNT_PMO");

                entity.Property(e => e.PlntPmo)
                    .HasColumnName("PLNT_PMO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReqdPmo)
                    .HasColumnName("REQD_PMO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rmk1Pmo)
                    .HasColumnName("RMK1_PMO")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Rmk2Pmo)
                    .HasColumnName("RMK2_PMO")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Rmk3Pmo)
                    .HasColumnName("RMK3_PMO")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SealPmo).HasColumnName("SEAL_PMO");

                entity.Property(e => e.ShpdPmo)
                    .HasColumnName("SHPD_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TlfgqPmo)
                    .HasColumnName("TLFGQ_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ToPmo)
                    .HasColumnName("TO_PMO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TqtyPmo)
                    .HasColumnName("TQTY_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Zd1cPmo)
                    .HasColumnName("ZD1C_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Zd1vPmo)
                    .HasColumnName("ZD1V_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Zd2cPmo)
                    .HasColumnName("ZD2C_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Zd2vPmo)
                    .HasColumnName("ZD2V_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Zd3cPmo)
                    .HasColumnName("ZD3C_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Zd3vPmo)
                    .HasColumnName("ZD3V_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Zd4cPmo)
                    .HasColumnName("ZD4C_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Zd4vPmo)
                    .HasColumnName("ZD4V_PMO")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pomst>(entity =>
            {
                entity.HasKey(e => e.PonbPo);

                entity.ToTable("POMST");

                entity.Property(e => e.PonbPo)
                    .HasColumnName("PONB_PO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CachetPo)
                    .HasColumnName("CACHET_PO")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ClsdPo)
                    .HasColumnName("CLSD_PO")
                    .HasColumnType("datetime");

                entity.Property(e => e.CmplPo).HasColumnName("CMPL_PO");

                entity.Property(e => e.CreaPo)
                    .HasColumnName("CREA_PO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CrtdPo)
                    .HasColumnName("CRTD_PO")
                    .HasColumnType("datetime");

                entity.Property(e => e.CstmPo)
                    .HasColumnName("CSTM_PO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CtovPo).HasColumnName("CTOV_PO");

                entity.Property(e => e.CwPo)
                    .HasColumnName("CW_PO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CwyjPo)
                    .HasColumnName("CWYJ_PO")
                    .HasColumnType("text");

                entity.Property(e => e.DatePo)
                    .HasColumnName("DATE_PO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FfaxPo)
                    .HasColumnName("FFAX_PO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FnamPo)
                    .HasColumnName("FNAM_PO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FqrPo)
                    .HasColumnName("FQR_PO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FqryjPo)
                    .HasColumnName("FQRYJ_PO")
                    .HasColumnType("text");

                entity.Property(e => e.FtelPo)
                    .HasColumnName("FTEL_PO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JlPo)
                    .HasColumnName("JL_PO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.JlyjPo)
                    .HasColumnName("JLYJ_PO")
                    .HasColumnType("text");

                entity.Property(e => e.LdatPo)
                    .HasColumnName("LDAT_PO")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtPo)
                    .HasColumnName("LEDT_PO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MrmkPo)
                    .HasColumnName("MRMK_PO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlntPo)
                    .HasColumnName("PLNT_PO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rmk1Po)
                    .HasColumnName("RMK1_PO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rmk2Po)
                    .HasColumnName("RMK2_PO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rmk3Po)
                    .HasColumnName("RMK3_PO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rmk4Po)
                    .HasColumnName("RMK4_PO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rmk5Po)
                    .HasColumnName("RMK5_PO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rmk6Po)
                    .HasColumnName("RMK6_PO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rmk7Po)
                    .HasColumnName("RMK7_PO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RvmkPo)
                    .HasColumnName("RVMK_PO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SealPo).HasColumnName("SEAL_PO");

                entity.Property(e => e.SmsgPo).HasColumnName("SMSG_PO");

                entity.Property(e => e.SpyjPo)
                    .HasColumnName("SPYJ_PO")
                    .HasColumnType("text");

                entity.Property(e => e.StatPo)
                    .HasColumnName("STAT_PO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TcpyPo)
                    .HasColumnName("TCPY_PO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TfaxPo)
                    .HasColumnName("TFAX_PO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TnamPo)
                    .HasColumnName("TNAM_PO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TtelPo)
                    .HasColumnName("TTEL_PO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypePo)
                    .HasColumnName("TYPE_PO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FcpyPo)
                    .HasColumnName("FCPY_PO")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Popart>(entity =>
            {
                entity.HasKey(e => new { e.PonbPp, e.OrdrPp });

                entity.ToTable("POPART");

                entity.Property(e => e.PonbPp)
                    .HasColumnName("PONB_PP")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OrdrPp)
                    .HasColumnName("ORDR_PP")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Desc3Pp)
                    .HasColumnName("DESC3_PP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescPp)
                    .HasColumnName("DESC_PP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EquivPp)
                    .HasColumnName("EQUIV_PP")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LdatPp)
                    .HasColumnName("LDAT_PP")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtPp)
                    .HasColumnName("LEDT_PP")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PartPp)
                    .HasColumnName("PART_PP")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PlntPp)
                    .HasColumnName("PLNT_PP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PricPp)
                    .HasColumnName("PRIC_PP")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PtypPp)
                    .HasColumnName("PTYP_PP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecqPp)
                    .HasColumnName("RECQ_PP")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.RemkPp)
                    .HasColumnName("REMK_PP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SchdPp)
                    .HasColumnName("SCHD_PP")
                    .HasColumnType("datetime");

                entity.Property(e => e.SpecPp)
                    .HasColumnName("SPEC_PP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumPp)
                    .HasColumnName("SUM_PP")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TqtyPp)
                    .HasColumnName("TQTY_PP")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UnitPp)
                    .HasColumnName("UNIT_PP")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Poschedule>(entity =>
            {
                entity.HasKey(e => new { e.PlntPsc, e.CstmPsc, e.RowsPsc });

                entity.ToTable("POSCHEDULE");

                entity.Property(e => e.PlntPsc)
                    .HasColumnName("PLNT_PSC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CstmPsc)
                    .HasColumnName("CSTM_PSC")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RowsPsc).HasColumnName("ROWS_PSC");

                entity.Property(e => e.BzPsc)
                    .HasColumnName("BZ_PSC")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CgPsc)
                    .HasColumnName("CG_PSC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CmplPsc).HasColumnName("CMPL_PSC");

                entity.Property(e => e.CntrPsc)
                    .HasColumnName("CNTR_PSC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DatePsc)
                    .HasColumnName("DATE_PSC")
                    .HasColumnType("datetime");

                entity.Property(e => e.DzPsc)
                    .HasColumnName("DZ_PSC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JcpslPsc)
                    .HasColumnName("JCPSL_PSC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JdPsc)
                    .HasColumnName("JD_PSC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JdqkPsc)
                    .HasColumnName("JDQK_PSC")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KdslPsc)
                    .HasColumnName("KDSL_PSC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KrjqPsc)
                    .HasColumnName("KRJQ_PSC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LdatPsc)
                    .HasColumnName("LDAT_PSC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtPsc)
                    .HasColumnName("LEDT_PSC")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PdrcsjPsc)
                    .HasColumnName("PDRCSJ_PSC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RcmcPsc)
                    .HasColumnName("RCMC_PSC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlPsc)
                    .HasColumnName("SL_PSC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YsPsc)
                    .HasColumnName("YS_PSC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZzgkPsc)
                    .HasColumnName("ZZGK_PSC")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pricelisthd>(entity =>
            {
                entity.HasKey(e => e.RownPlh);

                entity.ToTable("PRICELISTHD");

                entity.Property(e => e.RownPlh)
                    .HasColumnName("ROWN_PLH")
                    .ValueGeneratedNever();

                entity.Property(e => e.DescPlh)
                    .HasColumnName("DESC_PLH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LdatPlh)
                    .HasColumnName("LDAT_PLH")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtPlh)
                    .HasColumnName("LEDT_PLH")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PlntPlh)
                    .HasColumnName("PLNT_PLH")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SpecPlh)
                    .HasColumnName("SPEC_PLH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPlh)
                    .HasColumnName("UNIT_PLH")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pzdoc>(entity =>
            {
                entity.HasKey(e => new { e.TypePdo, e.YearPdo, e.PznoPdo, e.LocnPdo, e.DoctPdo, e.DocnPdo });

                entity.ToTable("PZDOC");

                entity.Property(e => e.TypePdo)
                    .HasColumnName("TYPE_PDO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.YearPdo)
                    .HasColumnName("YEAR_PDO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PznoPdo)
                    .HasColumnName("PZNO_PDO")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LocnPdo)
                    .HasColumnName("LOCN_PDO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DoctPdo)
                    .HasColumnName("DOCT_PDO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocnPdo)
                    .HasColumnName("DOCN_PDO")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CrtdPdo)
                    .HasColumnName("CRTD_PDO")
                    .HasColumnType("datetime");

                entity.Property(e => e.LdatPdo)
                    .HasColumnName("LDAT_PDO")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtPdo)
                    .HasColumnName("LEDT_PDO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SumPdo)
                    .HasColumnName("SUM_PDO")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TsumPdo)
                    .HasColumnName("TSUM_PDO")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<Pzdtl>(entity =>
            {
                entity.HasKey(e => new { e.TypePdt, e.YearPdt, e.PznoPdt, e.LocnPdt });

                entity.ToTable("PZDTL");

                entity.Property(e => e.TypePdt)
                    .HasColumnName("TYPE_PDT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.YearPdt)
                    .HasColumnName("YEAR_PDT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PznoPdt)
                    .HasColumnName("PZNO_PDT")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LocnPdt)
                    .HasColumnName("LOCN_PDT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BinvcPdt).HasColumnName("BINVC_PDT");

                entity.Property(e => e.ChekPdt).HasColumnName("CHEK_PDT");

                entity.Property(e => e.ChkdPdt)
                    .HasColumnName("CHKD_PDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChkrPdt)
                    .HasColumnName("CHKR_PDT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DirtPdt)
                    .HasColumnName("DIRT_PDT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DollPdt)
                    .HasColumnName("DOLL_PDT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EquivPdt)
                    .HasColumnName("EQUIV_PDT")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.InvcPdt)
                    .HasColumnName("INVC_PDT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LdatPdt)
                    .HasColumnName("LDAT_PDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtPdt)
                    .HasColumnName("LEDT_PDT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PdocPdt)
                    .HasColumnName("PDOC_PDT")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PlntPdt)
                    .HasColumnName("PLNT_PDT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemkPdt)
                    .HasColumnName("REMK_PDT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatPdt)
                    .HasColumnName("STAT_PDT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SumPdt)
                    .HasColumnName("SUM_PDT")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Pzfydtl>(entity =>
            {
                entity.HasKey(e => new { e.TypePdt, e.YearPdt, e.PznoPdt, e.AccnPdt });

                entity.ToTable("PZFYDTL");

                entity.Property(e => e.TypePdt)
                    .HasColumnName("TYPE_PDT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.YearPdt)
                    .HasColumnName("YEAR_PDT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PznoPdt)
                    .HasColumnName("PZNO_PDT")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccnPdt)
                    .HasColumnName("ACCN_PDT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DollPdt)
                    .HasColumnName("DOLL_PDT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EquivPdt)
                    .HasColumnName("EQUIV_PDT")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LdatPdt)
                    .HasColumnName("LDAT_PDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtPdt)
                    .HasColumnName("LEDT_PDT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OperPdt)
                    .HasColumnName("OPER_PDT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PlntPdt)
                    .HasColumnName("PLNT_PDT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemkPdt)
                    .HasColumnName("REMK_PDT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatPdt)
                    .HasColumnName("STAT_PDT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SumPdt)
                    .HasColumnName("SUM_PDT")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Pzhead>(entity =>
            {
                entity.HasKey(e => new { e.TypePhd, e.YearPhd, e.PznoPhd });

                entity.ToTable("PZHEAD");

                entity.Property(e => e.TypePhd)
                    .HasColumnName("TYPE_PHD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.YearPhd)
                    .HasColumnName("YEAR_PHD")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PznoPhd)
                    .HasColumnName("PZNO_PHD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AbstPhd)
                    .HasColumnName("ABST_PHD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Acc2Phd)
                    .HasColumnName("ACC2_PHD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AccnPhd)
                    .HasColumnName("ACCN_PHD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BillPhd)
                    .HasColumnName("BILL_PHD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CdatPhd)
                    .HasColumnName("CDAT_PHD")
                    .HasColumnType("datetime");

                entity.Property(e => e.CedtPhd)
                    .HasColumnName("CEDT_PHD")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CreaPhd)
                    .HasColumnName("CREA_PHD")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CrtdPhd)
                    .HasColumnName("CRTD_PHD")
                    .HasColumnType("datetime");

                entity.Property(e => e.CssbPhd)
                    .HasColumnName("CSSB_PHD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CstmPhd)
                    .HasColumnName("CSTM_PHD")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CwPhd)
                    .HasColumnName("CW_PHD")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CwyjPhd)
                    .HasColumnName("CWYJ_PHD")
                    .HasColumnType("text");

                entity.Property(e => e.DdatPhd)
                    .HasColumnName("DDAT_PHD")
                    .HasColumnType("datetime");

                entity.Property(e => e.DedtPhd)
                    .HasColumnName("DEDT_PHD")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DirtPhd)
                    .HasColumnName("DIRT_PHD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DocdPhd)
                    .HasColumnName("DOCD_PHD")
                    .HasColumnType("datetime");

                entity.Property(e => e.DollPhd)
                    .HasColumnName("DOLL_PHD")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EquivPhd)
                    .HasColumnName("EQUIV_PHD")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.FcpnyPhd)
                    .HasColumnName("FCPNY_PHD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FqrPhd)
                    .HasColumnName("FQR_PHD")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FqryjPhd)
                    .HasColumnName("FQRYJ_PHD")
                    .HasColumnType("text");

                entity.Property(e => e.JlPhd)
                    .HasColumnName("JL_PHD")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.JlyjPhd)
                    .HasColumnName("JLYJ_PHD")
                    .HasColumnType("text");

                entity.Property(e => e.LdatPhd)
                    .HasColumnName("LDAT_PHD")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtPhd)
                    .HasColumnName("LEDT_PHD")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LocnPhd)
                    .HasColumnName("LOCN_PHD")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OperPhd)
                    .HasColumnName("OPER_PHD")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PlntPhd)
                    .HasColumnName("PLNT_PHD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SetnPhd)
                    .HasColumnName("SETN_PHD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SmsgPhd).HasColumnName("SMSG_PHD");

                entity.Property(e => e.SpyjPhd)
                    .HasColumnName("SPYJ_PHD")
                    .HasColumnType("text");

                entity.Property(e => e.StatPhd)
                    .HasColumnName("STAT_PHD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SumPhd)
                    .HasColumnName("SUM_PHD")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TcpnyPhd)
                    .HasColumnName("TCPNY_PHD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.XdatPhd)
                    .HasColumnName("XDAT_PHD")
                    .HasColumnType("datetime");

                entity.Property(e => e.XedtPhd)
                    .HasColumnName("XEDT_PHD")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pzissue>(entity =>
            {
                entity.HasKey(e => new { e.PrfxPi, e.YearPi });

                entity.ToTable("PZISSUE");

                entity.Property(e => e.PrfxPi)
                    .HasColumnName("PRFX_PI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.YearPi)
                    .HasColumnName("YEAR_PI")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LisdPi)
                    .HasColumnName("LISD_PI")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MaxnPi).HasColumnName("MAXN_PI");
            });

            modelBuilder.Entity<Pztype>(entity =>
            {
                entity.HasKey(e => e.TypePz);

                entity.ToTable("PZTYPE");

                entity.Property(e => e.TypePz)
                    .HasColumnName("TYPE_PZ")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DescPz)
                    .HasColumnName("DESC_PZ")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Reasons>(entity =>
            {
                entity.HasKey(e => new { e.TrntRsn, e.RsncRsn });

                entity.ToTable("REASONS");

                entity.Property(e => e.TrntRsn)
                    .HasColumnName("TRNT_RSN")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RsncRsn)
                    .HasColumnName("RSNC_RSN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DescRsn)
                    .HasColumnName("DESC_RSN")
                    .HasMaxLength(20);

                entity.Property(e => e.LdatRsn)
                    .HasColumnName("LDAT_RSN")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtRsn)
                    .HasColumnName("LEDT_RSN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RemkRsn)
                    .HasColumnName("REMK_RSN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SysRsn).HasColumnName("SYS_RSN");
            });

            modelBuilder.Entity<Reports>(entity =>
            {
                entity.HasKey(e => e.NameRpt);

                entity.ToTable("REPORTS");

                entity.Property(e => e.NameRpt)
                    .HasColumnName("NAME_RPT")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DescRpt)
                    .HasColumnName("DESC_RPT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReptRpt)
                    .HasColumnName("REPT_RPT")
                    .HasColumnType("image");

                entity.Property(e => e.TypeRpt)
                    .HasColumnName("TYPE_RPT")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Settlement>(entity =>
            {
                entity.HasKey(e => e.CodeStm);

                entity.ToTable("SETTLEMENT");

                entity.Property(e => e.CodeStm)
                    .HasColumnName("CODE_STM")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DescStm)
                    .HasColumnName("DESC_STM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LdatStm)
                    .HasColumnName("LDAT_STM")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtStm)
                    .HasColumnName("LEDT_STM")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PlntStm)
                    .HasColumnName("PLNT_STM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SysStm).HasColumnName("SYS_STM");
            });

            modelBuilder.Entity<Tc>(entity =>
            {
                entity.HasKey(e => e.TccdTc);

                entity.ToTable("TC");

                entity.Property(e => e.TccdTc)
                    .HasColumnName("TCCD_TC")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DescTc)
                    .HasColumnName("DESC_TC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FromTc)
                    .HasColumnName("FROM_TC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LdatTc)
                    .HasColumnName("LDAT_TC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtTc)
                    .HasColumnName("LEDT_TC")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RemkTc)
                    .HasColumnName("REMK_TC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SysTc).HasColumnName("SYS_TC");

                entity.Property(e => e.ToTc)
                    .HasColumnName("TO_TC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeTc)
                    .HasColumnName("TYPE_TC")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Trndtl>(entity =>
            {
                entity.HasKey(e => new { e.TypeTdl, e.DocnTdl, e.RownTdl });

                entity.ToTable("TRNDTL");

                entity.Property(e => e.TypeTdl)
                    .HasColumnName("TYPE_TDL")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocnTdl)
                    .HasColumnName("DOCN_TDL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RownTdl).HasColumnName("ROWN_TDL");

                entity.Property(e => e.Bat10Tdl).HasColumnName("BAT10_TDL");

                entity.Property(e => e.Bat1Tdl).HasColumnName("BAT1_TDL");

                entity.Property(e => e.Bat2Tdl).HasColumnName("BAT2_TDL");

                entity.Property(e => e.Bat3Tdl).HasColumnName("BAT3_TDL");

                entity.Property(e => e.Bat4Tdl).HasColumnName("BAT4_TDL");

                entity.Property(e => e.Bat5Tdl).HasColumnName("BAT5_TDL");

                entity.Property(e => e.Bat6Tdl).HasColumnName("BAT6_TDL");

                entity.Property(e => e.Bat7Tdl).HasColumnName("BAT7_TDL");

                entity.Property(e => e.Bat8Tdl).HasColumnName("BAT8_TDL");

                entity.Property(e => e.Bat9Tdl).HasColumnName("BAT9_TDL");

                entity.Property(e => e.Col10Tdl)
                    .HasColumnName("COL10_TDL")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Col1Tdl)
                    .HasColumnName("COL1_TDL")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Col2Tdl)
                    .HasColumnName("COL2_TDL")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Col3Tdl)
                    .HasColumnName("COL3_TDL")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Col4Tdl)
                    .HasColumnName("COL4_TDL")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Col5Tdl)
                    .HasColumnName("COL5_TDL")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Col6Tdl)
                    .HasColumnName("COL6_TDL")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Col7Tdl)
                    .HasColumnName("COL7_TDL")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Col8Tdl)
                    .HasColumnName("COL8_TDL")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Col9Tdl)
                    .HasColumnName("COL9_TDL")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LdatTdl)
                    .HasColumnName("LDAT_TDL")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtTdl)
                    .HasColumnName("LEDT_TDL")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PlntTdl)
                    .HasColumnName("PLNT_TDL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StatTdl)
                    .HasColumnName("STAT_TDL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TccdTdl)
                    .HasColumnName("TCCD_TDL")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Trndtl2>(entity =>
            {
                entity.HasKey(e => new { e.TypeTdl, e.DocnTdl, e.PrntTdl, e.PartTdl });

                entity.ToTable("TRNDTL2");

                entity.Property(e => e.TypeTdl)
                    .HasColumnName("TYPE_TDL")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocnTdl)
                    .HasColumnName("DOCN_TDL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PrntTdl)
                    .HasColumnName("PRNT_TDL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PartTdl)
                    .HasColumnName("PART_TDL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AddqTdl)
                    .HasColumnName("ADDQ_TDL")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BgfyTdl)
                    .HasColumnName("BGFY_TDL")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChekTdl).HasColumnName("CHEK_TDL");

                entity.Property(e => e.ChkdTdl)
                    .HasColumnName("CHKD_TDL")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChkrTdl)
                    .HasColumnName("CHKR_TDL")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Desc3Tdl)
                    .HasColumnName("DESC3_TDL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisqTdl).HasColumnName("DISQ_TDL");

                entity.Property(e => e.DollTdl)
                    .HasColumnName("DOLL_TDL")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EquivTdl)
                    .HasColumnName("EQUIV_TDL")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.IprcTdl)
                    .HasColumnName("IPRC_TDL")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LdatTdl)
                    .HasColumnName("LDAT_TDL")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtTdl)
                    .HasColumnName("LEDT_TDL")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MadeTdl)
                    .HasColumnName("MADE_TDL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mdrmk1Tdl)
                    .HasColumnName("MDRMK1_TDL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mdrmk2Tdl)
                    .HasColumnName("MDRMK2_TDL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MprcTdl)
                    .HasColumnName("MPRC_TDL")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PckqTdl).HasColumnName("PCKQ_TDL");

                entity.Property(e => e.PlntTdl)
                    .HasColumnName("PLNT_TDL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PonbTdl)
                    .HasColumnName("PONB_TDL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PqtyTdl)
                    .HasColumnName("PQTY_TDL")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PricTdl)
                    .HasColumnName("PRIC_TDL")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PtypTdl)
                    .HasColumnName("PTYP_TDL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RateTdl)
                    .HasColumnName("RATE_TDL")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.RcpricTdl)
                    .HasColumnName("RCPRIC_TDL")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RcptypTdl)
                    .HasColumnName("RCPTYP_TDL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemkTdl)
                    .HasColumnName("REMK_TDL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResnTdl)
                    .HasColumnName("RESN_TDL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatTdl)
                    .HasColumnName("STAT_TDL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Tax2sumTdl)
                    .HasColumnName("TAX2SUM_TDL")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxrTdl)
                    .HasColumnName("TAXR_TDL")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxsumTdl)
                    .HasColumnName("TAXSUM_TDL")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TccdTdl)
                    .HasColumnName("TCCD_TDL")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TcldatTdl)
                    .HasColumnName("TCLDAT_TDL")
                    .HasColumnType("datetime");

                entity.Property(e => e.TcledtTdl)
                    .HasColumnName("TCLEDT_TDL")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TcoutlayTdl)
                    .HasColumnName("TCOUTLAY_TDL")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TcremkTdl)
                    .HasColumnName("TCREMK_TDL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TcsumTdl)
                    .HasColumnName("TCSUM_TDL")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TqtyTdl)
                    .HasColumnName("TQTY_TDL")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<Trndtlbat>(entity =>
            {
                entity.HasKey(e => new { e.TypeTdb, e.DocnTdb, e.FlocTdb, e.PartTdb, e.FtypTdb, e.FdocTdb, e.FsnoTdb });

                entity.ToTable("TRNDTLBAT");

                entity.Property(e => e.TypeTdb)
                    .HasColumnName("TYPE_TDB")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocnTdb)
                    .HasColumnName("DOCN_TDB")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FlocTdb)
                    .HasColumnName("FLOC_TDB")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PartTdb)
                    .HasColumnName("PART_TDB")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FtypTdb)
                    .HasColumnName("FTYP_TDB")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FdocTdb)
                    .HasColumnName("FDOC_TDB")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FsnoTdb).HasColumnName("FSNO_TDB");

                entity.Property(e => e.AddqTdb)
                    .HasColumnName("ADDQ_TDB")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ChckTdb).HasColumnName("CHCK_TDB");

                entity.Property(e => e.IprcTdb)
                    .HasColumnName("IPRC_TDB")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OprcTdb)
                    .HasColumnName("OPRC_TDB")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OrgdTdb)
                    .HasColumnName("ORGD_TDB")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OrgtTdb)
                    .HasColumnName("ORGT_TDB")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.QtyTdb)
                    .HasColumnName("QTY_TDB")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.RejqTdb)
                    .HasColumnName("REJQ_TDB")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<Trndtlpm>(entity =>
            {
                entity.HasKey(e => new { e.TypeTdl, e.DocnTdl, e.PartTdl });

                entity.ToTable("TRNDTLPM");

                entity.Property(e => e.TypeTdl)
                    .HasColumnName("TYPE_TDL")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocnTdl)
                    .HasColumnName("DOCN_TDL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PartTdl)
                    .HasColumnName("PART_TDL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LdatTdl)
                    .HasColumnName("LDAT_TDL")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtTdl)
                    .HasColumnName("LEDT_TDL")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LosqTdl)
                    .HasColumnName("LOSQ_TDL")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PlntTdl)
                    .HasColumnName("PLNT_TDL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StatTdl)
                    .HasColumnName("STAT_TDL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TccdTdl)
                    .HasColumnName("TCCD_TDL")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TqtyTdl)
                    .HasColumnName("TQTY_TDL")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<Trnhead>(entity =>
            {
                entity.HasKey(e => new { e.TypeTrn, e.DocnTrn });

                entity.ToTable("TRNHEAD");

                entity.Property(e => e.TypeTrn)
                    .HasColumnName("TYPE_TRN")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocnTrn)
                    .HasColumnName("DOCN_TRN")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BgfyTrn)
                    .HasColumnName("BGFY_TRN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CaseTrn)
                    .HasColumnName("CASE_TRN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CdatTrn)
                    .HasColumnName("CDAT_TRN")
                    .HasColumnType("datetime");

                entity.Property(e => e.CedtTrn)
                    .HasColumnName("CEDT_TRN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ChekTrn).HasColumnName("CHEK_TRN");

                entity.Property(e => e.ChkdTrn)
                    .HasColumnName("CHKD_TRN")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChkrTrn)
                    .HasColumnName("CHKR_TRN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CpmdTrn)
                    .HasColumnName("CPMD_TRN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CpnoTrn)
                    .HasColumnName("CPNO_TRN")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CreaTrn)
                    .HasColumnName("CREA_TRN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CrtdTrn)
                    .HasColumnName("CRTD_TRN")
                    .HasColumnType("datetime");

                entity.Property(e => e.CwTrn)
                    .HasColumnName("CW_TRN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CwyjTrn)
                    .HasColumnName("CWYJ_TRN")
                    .HasColumnType("text");

                entity.Property(e => e.DdatTrn)
                    .HasColumnName("DDAT_TRN")
                    .HasColumnType("datetime");

                entity.Property(e => e.DedtTrn)
                    .HasColumnName("DEDT_TRN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Desc3Trn)
                    .HasColumnName("DESC3_TRN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisqTrn).HasColumnName("DISQ_TRN");

                entity.Property(e => e.DnnoTrn)
                    .HasColumnName("DNNO_TRN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocdTrn)
                    .HasColumnName("DOCD_TRN")
                    .HasColumnType("datetime");

                entity.Property(e => e.DollTrn)
                    .HasColumnName("DOLL_TRN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EquivTrn)
                    .HasColumnName("EQUIV_TRN")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.FivnTrn).HasColumnName("FIVN_TRN");

                entity.Property(e => e.FqrTrn)
                    .HasColumnName("FQR_TRN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FqryjTrn)
                    .HasColumnName("FQRYJ_TRN")
                    .HasColumnType("text");

                entity.Property(e => e.FromTrn)
                    .IsRequired()
                    .HasColumnName("FROM_TRN")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FtypTrn)
                    .IsRequired()
                    .HasColumnName("FTYP_TRN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IntdTrn)
                    .HasColumnName("INTD_TRN")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvcTrn)
                    .HasColumnName("INVC_TRN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IprcTrn)
                    .HasColumnName("IPRC_TRN")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.JlTrn)
                    .HasColumnName("JL_TRN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.JlyjTrn)
                    .HasColumnName("JLYJ_TRN")
                    .HasColumnType("text");

                entity.Property(e => e.LdatTrn)
                    .HasColumnName("LDAT_TRN")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtTrn)
                    .HasColumnName("LEDT_TRN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MadeTrn)
                    .HasColumnName("MADE_TRN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MprcTrn)
                    .HasColumnName("MPRC_TRN")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OperTrn)
                    .HasColumnName("OPER_TRN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PartTrn)
                    .HasColumnName("PART_TRN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PckqTrn).HasColumnName("PCKQ_TRN");

                entity.Property(e => e.PlntTrn)
                    .HasColumnName("PLNT_TRN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PonbTrn)
                    .HasColumnName("PONB_TRN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Ppn2Trn).HasColumnName("PPN2_TRN");

                entity.Property(e => e.PricTrn)
                    .HasColumnName("PRIC_TRN")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PtypTrn)
                    .HasColumnName("PTYP_TRN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RateTrn)
                    .HasColumnName("RATE_TRN")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.RcpricTrn)
                    .HasColumnName("RCPRIC_TRN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RcptypTrn)
                    .HasColumnName("RCPTYP_TRN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RejdTrn).HasColumnName("REJD_TRN");

                entity.Property(e => e.RemkTrn)
                    .HasColumnName("REMK_TRN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResnTrn)
                    .HasColumnName("RESN_TRN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rmk2Trn)
                    .HasColumnName("RMK2_TRN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rmk3Trn)
                    .HasColumnName("RMK3_TRN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoprTrn)
                    .HasColumnName("ROPR_TRN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RsumTrn)
                    .HasColumnName("RSUM_TRN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesTrn)
                    .HasColumnName("SALES_TRN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SmsgTrn).HasColumnName("SMSG_TRN");

                entity.Property(e => e.SnoTrn)
                    .HasColumnName("SNO_TRN")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SpyjTrn)
                    .HasColumnName("SPYJ_TRN")
                    .HasColumnType("text");

                entity.Property(e => e.StatTrn)
                    .HasColumnName("STAT_TRN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SumTrn)
                    .HasColumnName("SUM_TRN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tax2sumTrn)
                    .HasColumnName("TAX2SUM_TRN")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxrTrn)
                    .HasColumnName("TAXR_TRN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxsumTrn)
                    .HasColumnName("TAXSUM_TRN")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TcldatTrn)
                    .HasColumnName("TCLDAT_TRN")
                    .HasColumnType("datetime");

                entity.Property(e => e.TcledtTrn)
                    .HasColumnName("TCLEDT_TRN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TcoutlayTrn)
                    .HasColumnName("TCOUTLAY_TRN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TcremkTrn)
                    .HasColumnName("TCREMK_TRN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TcsumTrn)
                    .HasColumnName("TCSUM_TRN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TivnTrn).HasColumnName("TIVN_TRN");

                entity.Property(e => e.ToTrn)
                    .HasColumnName("TO_TRN")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TqtyTrn)
                    .HasColumnName("TQTY_TRN")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TtypTrn)
                    .HasColumnName("TTYP_TRN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VendTrn)
                    .HasColumnName("VEND_TRN")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.WdatTrn)
                    .HasColumnName("WDAT_TRN")
                    .HasColumnType("datetime");

                entity.Property(e => e.XdatTrn)
                    .HasColumnName("XDAT_TRN")
                    .HasColumnType("datetime");

                entity.Property(e => e.XedtTrn)
                    .HasColumnName("XEDT_TRN")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Trnltr>(entity =>
            {
                entity.HasKey(e => new { e.TypeTlt, e.DocnTlt, e.LtrnTlt, e.PartTlt, e.PrdnTlt });

                entity.ToTable("TRNLTR");

                entity.Property(e => e.TypeTlt)
                    .HasColumnName("TYPE_TLT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocnTlt)
                    .HasColumnName("DOCN_TLT")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LtrnTlt)
                    .HasColumnName("LTRN_TLT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PartTlt)
                    .HasColumnName("PART_TLT")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PrdnTlt)
                    .HasColumnName("PRDN_TLT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QtyTlt)
                    .HasColumnName("QTY_TLT")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<Trnvend>(entity =>
            {
                entity.HasKey(e => new { e.TypeTrv, e.DocnTrv, e.VendTrv, e.PartTrv });

                entity.ToTable("TRNVEND");

                entity.Property(e => e.TypeTrv)
                    .HasColumnName("TYPE_TRV")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocnTrv)
                    .HasColumnName("DOCN_TRV")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.VendTrv)
                    .HasColumnName("VEND_TRV")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PartTrv)
                    .HasColumnName("PART_TRV")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LdatTrv)
                    .HasColumnName("LDAT_TRV")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtTrv)
                    .HasColumnName("LEDT_TRV")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TqtyTrv)
                    .HasColumnName("TQTY_TRV")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<Units>(entity =>
            {
                entity.HasKey(e => e.DescUn);

                entity.ToTable("UNITS");

                entity.Property(e => e.DescUn)
                    .HasColumnName("DESC_UN")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.EquivUn)
                    .HasColumnName("EQUIV_UN")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LdatUn)
                    .HasColumnName("LDAT_UN")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtUn)
                    .HasColumnName("LEDT_UN")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Useright>(entity =>
            {
                entity.HasKey(e => new { e.PlntUr, e.EmpnUr, e.PrgnUr });

                entity.ToTable("USERIGHT");

                entity.Property(e => e.PlntUr)
                    .HasColumnName("PLNT_UR")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmpnUr)
                    .HasColumnName("EMPN_UR")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PrgnUr)
                    .HasColumnName("PRGN_UR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreaUr)
                    .HasColumnName("CREA_UR")
                    .HasColumnType("datetime");

                entity.Property(e => e.LdatUr)
                    .HasColumnName("LDAT_UR")
                    .HasColumnType("datetime");

                entity.Property(e => e.LedtUr)
                    .HasColumnName("LEDT_UR")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OnofUr).HasColumnName("ONOF_UR");
            });
        }
    }
}
