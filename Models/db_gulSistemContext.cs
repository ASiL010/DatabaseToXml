using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DatabaseToXml.Models
{
    public partial class db_gulSistemContext : DbContext
    {
        public db_gulSistemContext()
        {
        }

        public db_gulSistemContext(DbContextOptions<db_gulSistemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FailedJob> FailedJobs { get; set; } = null!;
        public virtual DbSet<HbKayitBazliMuhasebeServisi> HbKayitBazliMuhasebeServisis { get; set; } = null!;
        public virtual DbSet<IptalEdilenSiparisler> IptalEdilenSiparislers { get; set; } = null!;
        public virtual DbSet<Migration> Migrations { get; set; } = null!;
        public virtual DbSet<PasswordReset> PasswordResets { get; set; } = null!;
        public virtual DbSet<PersonalAccessToken> PersonalAccessTokens { get; set; } = null!;
        public virtual DbSet<Picture> Pictures { get; set; } = null!;
        public virtual DbSet<PicturesAltUrun> PicturesAltUruns { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductDescription> ProductDescriptions { get; set; } = null!;
        public virtual DbSet<TblAgirlik> TblAgirliks { get; set; } = null!;
        public virtual DbSet<TblAltKategori> TblAltKategoris { get; set; } = null!;
        public virtual DbSet<TblAltKategority> TblAltKategorities { get; set; } = null!;
        public virtual DbSet<TblAltUrunler> TblAltUrunlers { get; set; } = null!;
        public virtual DbSet<TblBirlestirilmisUrunler> TblBirlestirilmisUrunlers { get; set; } = null!;
        public virtual DbSet<TblBuybox> TblBuyboxes { get; set; } = null!;
        public virtual DbSet<TblBuyboxTy> TblBuyboxTies { get; set; } = null!;
        public virtual DbSet<TblCargo> TblCargos { get; set; } = null!;
        public virtual DbSet<TblCategory> TblCategories { get; set; } = null!;
        public virtual DbSet<TblCiki> TblCikis { get; set; } = null!;
        public virtual DbSet<TblColor> TblColors { get; set; } = null!;
        public virtual DbSet<TblCustomer> TblCustomers { get; set; } = null!;
        public virtual DbSet<TblDigerSatici> TblDigerSaticis { get; set; } = null!;
        public virtual DbSet<TblDigerSaticiFiyat> TblDigerSaticiFiyats { get; set; } = null!;
        public virtual DbSet<TblDigerSaticiResim> TblDigerSaticiResims { get; set; } = null!;
        public virtual DbSet<TblDigerSaticiTagList> TblDigerSaticiTagLists { get; set; } = null!;
        public virtual DbSet<TblDigerSaticiUrun> TblDigerSaticiUruns { get; set; } = null!;
        public virtual DbSet<TblDigerUrunSaticiNm> TblDigerUrunSaticiNms { get; set; } = null!;
        public virtual DbSet<TblDurum> TblDurums { get; set; } = null!;
        public virtual DbSet<TblFatura> TblFaturas { get; set; } = null!;
        public virtual DbSet<TblHacim> TblHacims { get; set; } = null!;
        public virtual DbSet<TblHizliEkleHb> TblHizliEkleHbs { get; set; } = null!;
        public virtual DbSet<TblIptalEdilenTy> TblIptalEdilenTies { get; set; } = null!;
        public virtual DbSet<TblKategori> TblKategoris { get; set; } = null!;
        public virtual DbSet<TblKategoriTy> TblKategoriTies { get; set; } = null!;
        public virtual DbSet<TblKategorilerHb> TblKategorilerHbs { get; set; } = null!;
        public virtual DbSet<TblKullanici> TblKullanicis { get; set; } = null!;
        public virtual DbSet<TblKullohbuybox> TblKullohbuyboxes { get; set; } = null!;
        public virtual DbSet<TblLog> TblLogs { get; set; } = null!;
        public virtual DbSet<TblLogbuybux> TblLogbuybuxes { get; set; } = null!;
        public virtual DbSet<TblMagazaFiyatlari> TblMagazaFiyatlaris { get; set; } = null!;
        public virtual DbSet<TblMarka> TblMarkas { get; set; } = null!;
        public virtual DbSet<TblMarkaTy> TblMarkaTies { get; set; } = null!;
        public virtual DbSet<TblModel> TblModels { get; set; } = null!;
        public virtual DbSet<TblMusteri> TblMusteris { get; set; } = null!;
        public virtual DbSet<TblMusteriler> TblMusterilers { get; set; } = null!;
        public virtual DbSet<TblNumara> TblNumaras { get; set; } = null!;
        public virtual DbSet<TblOrder> TblOrders { get; set; } = null!;
        public virtual DbSet<TblOrtakSipari> TblOrtakSiparis { get; set; } = null!;
        public virtual DbSet<TblOzellikler> TblOzelliklers { get; set; } = null!;
        public virtual DbSet<TblPaketTemp> TblPaketTemps { get; set; } = null!;
        public virtual DbSet<TblPaketTempTy> TblPaketTempTies { get; set; } = null!;
        public virtual DbSet<TblPicture> TblPictures { get; set; } = null!;
        public virtual DbSet<TblPrice> TblPrices { get; set; } = null!;
        public virtual DbSet<TblProduct> TblProducts { get; set; } = null!;
        public virtual DbSet<TblProductHb> TblProductHbs { get; set; } = null!;
        public virtual DbSet<TblProductsAltUrunHb> TblProductsAltUrunHbs { get; set; } = null!;
        public virtual DbSet<TblRenk> TblRenks { get; set; } = null!;
        public virtual DbSet<TblSipari> TblSiparis { get; set; } = null!;
        public virtual DbSet<TblSiparisTy> TblSiparisTies { get; set; } = null!;
        public virtual DbSet<TblTyLink> TblTyLinks { get; set; } = null!;
        public virtual DbSet<TblUrun> TblUruns { get; set; } = null!;
        public virtual DbSet<TblUrunHb> TblUrunHbs { get; set; } = null!;
        public virtual DbSet<TblUrunHbb> TblUrunHbbs { get; set; } = null!;
        public virtual DbSet<TblUrunTy> TblUrunTies { get; set; } = null!;
        public virtual DbSet<TblUrunler> TblUrunlers { get; set; } = null!;
        public virtual DbSet<TblUrunlertolink> TblUrunlertolinks { get; set; } = null!;
        public virtual DbSet<TblUrunsku> TblUrunskus { get; set; } = null!;
        public virtual DbSet<TblUruntosku> TblUruntoskus { get; set; } = null!;
        public virtual DbSet<TblVaryant> TblVaryants { get; set; } = null!;
        public virtual DbSet<TblÇop> TblÇops { get; set; } = null!;
        public virtual DbSet<TblÜrünkargoteslim> TblÜrünkargoteslims { get; set; } = null!;
        public virtual DbSet<TeslimEdilemeyenSiparisler> TeslimEdilemeyenSiparislers { get; set; } = null!;
        public virtual DbSet<TeslimEdilenSiparisler> TeslimEdilenSiparislers { get; set; } = null!;
        public virtual DbSet<TyOrder> TyOrders { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=db_gulSistem;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<FailedJob>(entity =>
            {
                entity.ToTable("failed_jobs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Connection).HasColumnName("connection");

                entity.Property(e => e.Exception).HasColumnName("exception");

                entity.Property(e => e.FailedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("failed_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Payload).HasColumnName("payload");

                entity.Property(e => e.Queue).HasColumnName("queue");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(255)
                    .HasColumnName("uuid");
            });

            modelBuilder.Entity<HbKayitBazliMuhasebeServisi>(entity =>
            {
                entity.HasKey(e => new { e.InvoiceExplanation, e.TransactionType, e.Sku, e.OrderNumber, e.InvoiceNumber, e.OrderItemNumber });

                entity.ToTable("HbKayitBazliMuhasebeServisi");

                entity.Property(e => e.InvoiceExplanation)
                    .HasMaxLength(50)
                    .HasColumnName("invoiceExplanation");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .HasColumnName("transactionType");

                entity.Property(e => e.Sku)
                    .HasMaxLength(50)
                    .HasColumnName("sku");

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .HasColumnName("orderNumber");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(50)
                    .HasColumnName("invoiceNumber");

                entity.Property(e => e.OrderItemNumber)
                    .HasMaxLength(50)
                    .HasColumnName("orderItemNumber");

                entity.Property(e => e.AmountCurrencyCode)
                    .HasMaxLength(10)
                    .HasColumnName("amountCurrencyCode")
                    .IsFixedLength();

                entity.Property(e => e.AmountValue)
                    .HasMaxLength(10)
                    .HasColumnName("amountValue")
                    .IsFixedLength();

                entity.Property(e => e.DueDate)
                    .HasMaxLength(50)
                    .HasColumnName("dueDate");

                entity.Property(e => e.InvoiceDate)
                    .HasMaxLength(50)
                    .HasColumnName("invoiceDate");

                entity.Property(e => e.IsIncome)
                    .HasMaxLength(10)
                    .HasColumnName("isIncome")
                    .IsFixedLength();

                entity.Property(e => e.IsInvoice)
                    .HasMaxLength(10)
                    .HasColumnName("isInvoice")
                    .IsFixedLength();

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(50)
                    .HasColumnName("merchantId");

                entity.Property(e => e.NetAmountCurrencyCode)
                    .HasMaxLength(10)
                    .HasColumnName("netAmountCurrencyCode")
                    .IsFixedLength();

                entity.Property(e => e.NetAmountValue)
                    .HasMaxLength(10)
                    .HasColumnName("netAmountValue")
                    .IsFixedLength();

                entity.Property(e => e.OrderDate)
                    .HasMaxLength(50)
                    .HasColumnName("orderDate");

                entity.Property(e => e.PackageNumber)
                    .HasMaxLength(50)
                    .HasColumnName("packageNumber");

                entity.Property(e => e.PaymentDate)
                    .HasMaxLength(50)
                    .HasColumnName("paymentDate");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .HasColumnName("productName");

                entity.Property(e => e.Quantity)
                    .HasMaxLength(10)
                    .HasColumnName("quantity")
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status");

                entity.Property(e => e.TaxAmountCurrencyCode)
                    .HasMaxLength(10)
                    .HasColumnName("taxAmountCurrencyCode")
                    .IsFixedLength();

                entity.Property(e => e.TaxAmountValue)
                    .HasMaxLength(10)
                    .HasColumnName("taxAmountValue")
                    .IsFixedLength();

                entity.Property(e => e.TransactionTypeCategory)
                    .HasMaxLength(50)
                    .HasColumnName("transactionTypeCategory");
            });

            modelBuilder.Entity<IptalEdilenSiparisler>(entity =>
            {
                entity.ToTable("iptalEdilenSiparisler");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CancelDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cancelDate");

                entity.Property(e => e.CancelReasonCode).HasColumnName("cancelReasonCode");

                entity.Property(e => e.CancelledBy).HasColumnName("cancelledBy");

                entity.Property(e => e.LineItemId).HasColumnName("lineItemId");

                entity.Property(e => e.MerchantId).HasColumnName("merchantId");

                entity.Property(e => e.MerchantSku).HasColumnName("merchantSku");

                entity.Property(e => e.OrderNumber).HasColumnName("orderNumber");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Sku).HasColumnName("sku");
            });

            modelBuilder.Entity<Migration>(entity =>
            {
                entity.ToTable("migrations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.Migration1)
                    .HasMaxLength(255)
                    .HasColumnName("migration");
            });

            modelBuilder.Entity<PasswordReset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("password_resets");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Token)
                    .HasMaxLength(255)
                    .HasColumnName("token");
            });

            modelBuilder.Entity<PersonalAccessToken>(entity =>
            {
                entity.ToTable("personal_access_tokens");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Abilities).HasColumnName("abilities");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.ExpiresAt)
                    .HasColumnType("datetime")
                    .HasColumnName("expires_at");

                entity.Property(e => e.LastUsedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_used_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Token)
                    .HasMaxLength(64)
                    .HasColumnName("token");

                entity.Property(e => e.TokenableId).HasColumnName("tokenable_id");

                entity.Property(e => e.TokenableType)
                    .HasMaxLength(255)
                    .HasColumnName("tokenable_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity.ToTable("pictures");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Path)
                    .IsUnicode(false)
                    .HasColumnName("path");

                entity.Property(e => e.Path2)
                    .IsUnicode(false)
                    .HasColumnName("path2");

                entity.Property(e => e.Path3)
                    .IsUnicode(false)
                    .HasColumnName("path3");

                entity.Property(e => e.Path4)
                    .IsUnicode(false)
                    .HasColumnName("path4");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<PicturesAltUrun>(entity =>
            {
                entity.ToTable("picturesAltUrun");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Path)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("path");

                entity.Property(e => e.Path10)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("path10");

                entity.Property(e => e.Path11)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("path11");

                entity.Property(e => e.Path12)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("path12");

                entity.Property(e => e.Path13)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("path13");

                entity.Property(e => e.Path14)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("path14");

                entity.Property(e => e.Path15)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("path15");

                entity.Property(e => e.Path16)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("path16");

                entity.Property(e => e.Path2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("path2");

                entity.Property(e => e.Path3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("path3");

                entity.Property(e => e.Path4)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("path4");

                entity.Property(e => e.Path5)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("path5");

                entity.Property(e => e.Path6)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("path6");

                entity.Property(e => e.Path7)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("path7");

                entity.Property(e => e.Path8)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("path8");

                entity.Property(e => e.Path9)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("path9");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.HasComment("TRIAL");

                entity.HasIndex(e => e.Category2, "product_category2_index");

                entity.HasIndex(e => e.Group, "product_category_index");

                entity.HasIndex(e => e.ProductCode, "product_productCode_index");

                entity.HasIndex(e => e.SendAliexpress, "product_send_aliexpress_index");

                entity.HasIndex(e => e.SendAliniyor, "product_send_aliniyor_index");

                entity.HasIndex(e => e.SendAmazonEu, "product_send_amazonEu_index");

                entity.HasIndex(e => e.SendAmazon, "product_send_amazon_index");

                entity.HasIndex(e => e.SendBpazar, "product_send_bpazar_index");

                entity.HasIndex(e => e.SendEptt, "product_send_epp_index");

                entity.HasIndex(e => e.SendFarmaborsa, "product_send_farmaborsa_index");

                entity.HasIndex(e => e.SendFarmazon, "product_send_farmazon_index");

                entity.HasIndex(e => e.SendFlo, "product_send_flo_index");

                entity.HasIndex(e => e.SendGg, "product_send_gg_index");

                entity.HasIndex(e => e.SendGordumaldim, "product_send_gordumaldim_index");

                entity.HasIndex(e => e.SendHb, "product_send_hb_index");

                entity.HasIndex(e => e.SendJoom, "product_send_joom_index");

                entity.HasIndex(e => e.SendLidyana, "product_send_lidyana_index");

                entity.HasIndex(e => e.SendMizu, "product_send_mizu_index");

                entity.HasIndex(e => e.SendModanisa, "product_send_modanisa_index");

                entity.HasIndex(e => e.SendN11, "product_send_n11_index");

                entity.HasIndex(e => e.SendN11pro, "product_send_n11pro_index");

                entity.HasIndex(e => e.SendNarwoo, "product_send_narwoo_index");

                entity.HasIndex(e => e.SendNeedion, "product_send_needion_index");

                entity.HasIndex(e => e.SendNovadan, "product_send_novadan_index");

                entity.HasIndex(e => e.SendTrendyol, "product_send_trendyol_index");

                entity.HasIndex(e => e.SendZebramo, "product_send_zebramo_index");

                entity.HasIndex(e => e.SendZoodmall, "product_send_zoodmall_index");

                entity.HasIndex(e => new { e.Supplier, e.SupplierId }, "product_supplier_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("TRIAL");

                entity.Property(e => e.Agirlik)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("agirlik")
                    .HasComment("TRIAL");

                entity.Property(e => e.AkakceDayOfDelivery)
                    .HasColumnName("akakce_dayOfDelivery")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.AkakceExpressDeliveryTime)
                    .HasColumnName("akakce_expressDeliveryTime")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.AkakceShipPrice)
                    .HasColumnName("akakce_shipPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.AliexpressCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aliexpress_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.AliexpressPrice)
                    .HasColumnName("aliexpress_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.AliexpressSalePrice)
                    .HasColumnName("aliexpress_salePrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.AliniyorCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aliniyor_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.AliniyorListPrice)
                    .HasColumnName("aliniyor_listPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.AliniyorSalePrice)
                    .HasColumnName("aliniyor_salePrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonAutopriceEnable)
                    .HasColumnName("amazon_autoprice_enable")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonDiscountDateEnable)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("amazon_discountDateEnable")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonDiscountEnd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("amazon_discountEnd")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonDiscountStart)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("amazon_discountStart")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonEuDiscountDateEnable)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("amazonEu_discountDateEnable")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonEuDiscountEnd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("amazonEu_discountEnd")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonEuDiscountStart)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("amazonEu_discountStart")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonEuFulfillmentLatency)
                    .HasColumnName("amazonEu_fulfillment_latency")
                    .HasDefaultValueSql("((2))")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonEuGtin)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("amazonEu_gtin")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonEuGtinType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("amazonEu_gtin_type")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonEuNodeId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("amazonEu_node_id")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonEuOptionToProduct)
                    .HasColumnName("amazonEu_optionToProduct")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonEuPrice)
                    .HasColumnName("amazonEu_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonEuProductType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("amazonEu_product_type")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonEuSalePrice)
                    .HasColumnName("amazonEu_salePrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonFulfillmentLatency)
                    .HasColumnName("amazon_fulfillment_latency")
                    .HasDefaultValueSql("((2))")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonGtin)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("amazon_gtin")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonGtinType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("amazon_gtin_type")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonNoBarcode)
                    .HasColumnName("amazon_no_barcode")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonNodeId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("amazon_node_id")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonOptionToProduct)
                    .HasColumnName("amazon_optionToProduct")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonPrice)
                    .HasColumnName("amazon_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonPriceBarem)
                    .HasColumnName("amazon_price_barem")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonPriceMax)
                    .HasColumnName("amazon_price_max")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonPriceMin)
                    .HasColumnName("amazon_price_min")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonProductType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("amazon_product_type")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonProductUrl)
                    .HasColumnType("text")
                    .HasColumnName("amazon_product_url")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonSalePrice)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("amazon_salePrice")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonfrPrice)
                    .HasColumnName("amazonfr_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.AmazonfrSalePrice)
                    .HasColumnName("amazonfr_salePrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.BamiloCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bamilo_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.BamiloError)
                    .HasColumnName("bamilo_error")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.BamiloErrorMessage)
                    .HasColumnType("text")
                    .HasColumnName("bamilo_error_message")
                    .HasComment("TRIAL");

                entity.Property(e => e.BamiloPrice)
                    .HasColumnName("bamilo_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.BamiloPrice2)
                    .HasColumnName("bamilo_price2")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.BamiloSync)
                    .HasColumnName("bamilo_sync")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("barcode")
                    .HasComment("TRIAL");

                entity.Property(e => e.Birimi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("birimi")
                    .HasComment("TRIAL");

                entity.Property(e => e.BirvbiryError)
                    .HasColumnName("birvbiry_error")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.BirvbiryErrorMessage)
                    .HasColumnType("text")
                    .HasColumnName("birvbiry_error_message")
                    .HasComment("TRIAL");

                entity.Property(e => e.BirvbiryPrice1)
                    .HasColumnName("birvbiry_price1")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.BirvbiryPrice2)
                    .HasColumnName("birvbiry_price2")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.BirvbirySyncDate)
                    .HasColumnType("datetime")
                    .HasColumnName("_birvbiry_sync_date")
                    .HasComment("TRIAL");

                entity.Property(e => e.BirvbirySyncDate2)
                    .HasColumnType("datetime")
                    .HasColumnName("birvbiry_sync_date2")
                    .HasComment("TRIAL");

                entity.Property(e => e.BisifiratCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bisifirat_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.BisifiratListPrice)
                    .HasColumnName("bisifirat_listPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.BisifiratSalePrice)
                    .HasColumnName("bisifirat_salePrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.BpazarCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bpazar_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.BpazarError)
                    .HasColumnName("bpazar_error")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.BpazarErrorMessage)
                    .HasColumnType("text")
                    .HasColumnName("bpazar_error_message")
                    .HasComment("TRIAL");

                entity.Property(e => e.BpazarPrice1)
                    .HasColumnName("bpazar_price1")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.BpazarPrice2)
                    .HasColumnName("bpazar_price2")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.BpazarShippingCompanyId)
                    .HasColumnName("bpazar_shipping_company_id")
                    .HasDefaultValueSql("((1))")
                    .HasComment("TRIAL");

                entity.Property(e => e.BpazarShippingDays)
                    .HasColumnName("bpazar_shipping_days")
                    .HasComment("TRIAL");

                entity.Property(e => e.BpazarShippingMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bpazar_shipping_method")
                    .HasDefaultValueSql("('in_cart')")
                    .HasComment("TRIAL");

                entity.Property(e => e.BpazarSync)
                    .HasColumnName("bpazar_sync")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.BpazarSyncOrder)
                    .HasColumnName("bpazar_syncOrder")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.BrandId)
                    .HasColumnName("brand_id")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.CargoPacketAmount)
                    .HasColumnName("cargo_packet_amount")
                    .HasDefaultValueSql("((1))")
                    .HasComment("TRIAL");

                entity.Property(e => e.CargoPacketType)
                    .HasColumnName("cargo_packet_type")
                    .HasDefaultValueSql("((1))")
                    .HasComment("TRIAL");

                entity.Property(e => e.Category2)
                    .HasColumnName("category2")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.CdiscountCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cdiscount_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.CdiscountPrice)
                    .HasColumnName("cdiscount_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.CdiscountPrice2)
                    .HasColumnName("cdiscount_price2")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.CdiscountSync)
                    .HasColumnName("cdiscount_sync")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.CountryOfOrigin)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("country_of_origin")
                    .HasComment("TRIAL");

                entity.Property(e => e.CriticalPrice)
                    .HasColumnName("critical_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.CurrencyType)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("currencyType")
                    .HasComment("TRIAL");

                entity.Property(e => e.DateAdd)
                    .HasColumnType("datetime")
                    .HasColumnName("date_add")
                    .HasComment("TRIAL");

                entity.Property(e => e.DateChange)
                    .HasColumnType("datetime")
                    .HasColumnName("date_change")
                    .HasComment("TRIAL");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("date")
                    .HasColumnName("date_end")
                    .HasComment("TRIAL");

                entity.Property(e => e.DateStart)
                    .HasColumnType("date")
                    .HasColumnName("date_start")
                    .HasComment("TRIAL");

                entity.Property(e => e.Depth)
                    .HasColumnName("depth")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description")
                    .HasComment("TRIAL");

                entity.Property(e => e.Desi)
                    .HasColumnName("desi")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.DomesticProductionEnable)
                    .HasColumnName("domestic_production_enable")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.EanshipCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("eanship_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.EanshipDiscountPrice)
                    .HasColumnName("eanship_discountPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.EanshipError)
                    .HasColumnName("eanship_error")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.EanshipErrorMessage)
                    .HasColumnType("text")
                    .HasColumnName("eanship_error_message")
                    .HasComment("TRIAL");

                entity.Property(e => e.EanshipPrice)
                    .HasColumnName("eanship_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.EpttCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eptt_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.EpttCommission)
                    .HasColumnName("eptt_commission")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.EpttIskonto)
                    .HasColumnName("eptt_iskonto")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.EpttOptionToProduct)
                    .HasColumnName("eptt_optionToProduct")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.EpttPrice)
                    .HasColumnName("eptt_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.ErpCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("erp_code")
                    .HasComment("TRIAL");

                entity.Property(e => e.EticaretCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("eticaret_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.EticaretId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("eticaret_id")
                    .HasComment("TRIAL");

                entity.Property(e => e.EticaretIntegrationCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("eticaret_integration_code")
                    .HasComment("TRIAL");

                entity.Property(e => e.EtsyCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("etsy_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.EtsyPrice)
                    .HasColumnName("etsy_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.EvideapazaryeriDiscountDateEnable)
                    .HasColumnName("evideapazaryeri_discountDateEnable")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.EvideapazaryeriDiscountEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("evideapazaryeri_discountEnd")
                    .HasComment("TRIAL");

                entity.Property(e => e.EvideapazaryeriDiscountStart)
                    .HasColumnType("datetime")
                    .HasColumnName("evideapazaryeri_discountStart")
                    .HasComment("TRIAL");

                entity.Property(e => e.EvideapazaryeriDiscountType)
                    .HasColumnName("evideapazaryeri_discount_type")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.EvideapazaryeriDiscountValue)
                    .HasColumnName("evideapazaryeri_discount_value")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.EvideapazaryeriError)
                    .HasColumnName("evideapazaryeri_error")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.EvideapazaryeriErrorMessage)
                    .HasColumnType("text")
                    .HasColumnName("evideapazaryeri_error_message")
                    .HasComment("TRIAL");

                entity.Property(e => e.EvideapazaryeriListPrice)
                    .HasColumnName("evideapazaryeri_list_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.EvideapazaryeriPreparingday)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("evideapazaryeri_preparingday")
                    .HasComment("TRIAL");

                entity.Property(e => e.EvideapazaryeriSalesPrice)
                    .HasColumnName("evideapazaryeri_sales_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.EvideapazaryeriShipmentTypeId)
                    .HasColumnName("evideapazaryeri_shipment_type_id")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.Fark)
                    .HasColumnName("fark")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.FarmaBorsaPrice)
                    .HasColumnName("farmaBorsaPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.FarmaborsaOptionToProduct)
                    .HasColumnName("farmaborsa_optionToProduct")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.FarmaborsaPsPrice)
                    .HasColumnName("farmaborsa_psPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.FarmazonMarketPrice)
                    .HasColumnName("farmazon_market_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.FarmazonOptionToProduct)
                    .HasColumnName("farmazon_optionToProduct")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.FarmazonPrice)
                    .HasColumnName("farmazon_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.Fixprice)
                    .HasColumnName("fixprice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.FloCargoFirmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("flo_cargo_firm_id")
                    .HasComment("TRIAL");

                entity.Property(e => e.FloCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("flo_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.FloCommission)
                    .HasColumnName("flo_commission")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.FloListPrice)
                    .HasColumnName("flo_listPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.FloOptionToProduct)
                    .HasColumnName("flo_optionToProduct")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.FloSalePrice)
                    .HasColumnName("flo_salePrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.FulfillmentError)
                    .HasColumnName("fulfillment_error")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.FulfillmentErrorMessage)
                    .HasColumnType("text")
                    .HasColumnName("fulfillment_error_message")
                    .HasComment("TRIAL");

                entity.Property(e => e.FulfillmentId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("fulfillment_id")
                    .HasComment("TRIAL");

                entity.Property(e => e.FulfillmentOrderStatus)
                    .HasColumnName("fulfillment_order_status")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GetirIntegrationCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("getir_integration_code")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgAffiliateOption)
                    .HasColumnName("gg_affiliateOption")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgAutopriceEnable)
                    .HasColumnName("gg_autoprice_enable")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgAutopriceSync)
                    .HasColumnName("gg_autoprice_sync")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgBoldOption)
                    .HasColumnName("gg_boldOption")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgBuyNowPrice)
                    .HasColumnName("gg_buyNowPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgCargoCargoCompanies)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("gg_cargo_cargoCompanies")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgCargoCargoDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("gg_cargo_cargoDescription")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgCargoCity)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("gg_cargo_city")
                    .HasDefaultValueSql("('34')")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgCargoShippingPayment)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("gg_cargo_shippingPayment")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgCargoShippingPayment2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("gg_cargo_shippingPayment2")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgCargoShippingTimeBeforeTime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gg_cargo_shippingTime_beforeTime")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgCargoShippingTimeDays)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gg_cargo_shippingTime_days")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgCargoShippingWhere)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gg_cargo_shippingWhere")
                    .HasDefaultValueSql("('country')")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgCatalogOption)
                    .HasColumnName("gg_catalogOption")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gg_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgCommission)
                    .HasColumnName("gg_commission")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgFormat)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("gg_format")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgListingDays)
                    .HasColumnName("gg_listingDays")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgMarketPrice)
                    .HasColumnName("gg_marketPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgNewCatalogId)
                    .HasColumnName("gg_newCatalogId")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgOptionToProduct)
                    .HasColumnName("gg_optionToProduct")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgPageTemplate)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("gg_pageTemplate")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgPriceBarem)
                    .HasColumnName("gg_price_barem")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgPriceMax)
                    .HasColumnName("gg_price_max")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgPriceMin)
                    .HasColumnName("gg_price_min")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgProductUrl)
                    .HasColumnType("text")
                    .HasColumnName("gg_product_url")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgShippingCostCf)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("gg_shipping_cost_cf")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgShippingCostTry)
                    .HasColumnName("gg_shipping_cost_try")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgShippingFeePaymentType)
                    .HasColumnName("gg_shippingFeePaymentType")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgStartPrice)
                    .HasColumnName("gg_startPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgStoreCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gg_store_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgSubtitleEnable)
                    .HasColumnName("gg_subtitle_enable")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgSync)
                    .HasColumnName("gg_sync")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgUpdatePriceQuantity)
                    .HasColumnName("gg_update_price_quantity")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GgVitrinOption)
                    .HasColumnName("gg_vitrinOption")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GordumAldimPrice)
                    .HasColumnName("gordumAldimPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GordumAldimcampaignPrice)
                    .HasColumnName("gordumAldimcampaignPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GordumaldimCategoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gordumaldim_category_code")
                    .HasComment("TRIAL");

                entity.Property(e => e.GordumaldimCommericalCampaignPrice)
                    .HasColumnName("gordumaldim_commericalCampaignPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GordumaldimCommericalPrice)
                    .HasColumnName("gordumaldim_commericalPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GordumaldimOptionToProduct)
                    .HasColumnName("gordumaldim_optionToProduct")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.Group)
                    .HasColumnName("group")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("group_name")
                    .HasComment("TRIAL");

                entity.Property(e => e.Gtin)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("gtin")
                    .HasComment("TRIAL");

                entity.Property(e => e.Gtip)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("gtip")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbAutopriceEnable)
                    .HasColumnName("hb_autoprice_enable")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbAutopriceOffset)
                    .HasColumnName("hb_autoprice_offset")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbAutopriceSync)
                    .HasColumnName("hb_autoprice_sync")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbCargoCompany)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("hb_cargo_company")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbCargoCompany2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("hb_cargo_company2")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbCargoCompany3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("hb_cargo_company3")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hb_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbCommission)
                    .HasColumnName("hb_commission")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbDispatchTime)
                    .HasColumnName("hb_dispatch_time")
                    .HasDefaultValueSql("((3))")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbError)
                    .HasColumnName("hb_error")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbErrorMessage)
                    .HasColumnType("text")
                    .HasColumnName("hb_error_message")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbMaxCount)
                    .HasColumnName("hb_max_count")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbOptionToProduct)
                    .HasColumnName("hb_optionToProduct")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbPrice)
                    .HasColumnName("hb_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbPriceBarem)
                    .HasColumnName("hb_price_barem")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbPriceMax)
                    .HasColumnName("hb_price_max")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbPriceMin)
                    .HasColumnName("hb_price_min")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbProductUrl)
                    .HasColumnType("text")
                    .HasColumnName("hb_product_url")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbSaleStatus)
                    .HasColumnName("hb_sale_status")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbShippingProfileName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hb_shipping_profile_name")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbSku)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hb_sku")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbSpeedAutopriceEnable)
                    .HasColumnName("hb_speed_autoprice_enable")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbStSku)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hb_st_sku")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbSync)
                    .HasColumnName("hb_sync")
                    .HasDefaultValueSql("((1))")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbSyncOrder)
                    .HasColumnName("hb_syncOrder")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbTrackingId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hb_tracking_id")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbUpdatePriceTrackingId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hb_update_price_tracking_id")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbUpdatePriceTrackingStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hb_update_price_tracking_status")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbUpdateQuantityTrackingId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hb_update_quantity_tracking_id")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbUpdateQuantityTrackingStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hb_update_quantity_tracking_status")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbUpdateTrackingId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hb_update_tracking_id")
                    .HasComment("TRIAL");

                entity.Property(e => e.HbUpdateTrackingStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hb_update_tracking_status")
                    .HasComment("TRIAL");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.HepsiburadaUpdatePrice)
                    .HasColumnName("hepsiburada_update_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.HepsiburadaUpdateQuantity)
                    .HasColumnName("hepsiburada_update_quantity")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.InvoiceName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("invoice_name")
                    .HasComment("TRIAL");

                entity.Property(e => e.IsAmazonFulfillment)
                    .HasColumnName("is_amazon_fulfillment")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.IsFulfillment)
                    .HasColumnName("isFulfillment")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.IyifiyatCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("iyifiyat_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.IyifiyatListPrice)
                    .HasColumnName("iyifiyat_listPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.IyifiyatSalePrice)
                    .HasColumnName("iyifiyat_salePrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.JoomMsrPrice)
                    .HasColumnName("joom_msrPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.JoomPrice)
                    .HasColumnName("joom_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.KdvId)
                    .HasColumnName("kdv_id")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.LamodaCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("lamoda_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.LamodaError)
                    .HasColumnName("lamoda_error")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.LamodaErrorMessage)
                    .HasColumnType("text")
                    .HasColumnName("lamoda_error_message")
                    .HasComment("TRIAL");

                entity.Property(e => e.LamodaPrice)
                    .HasColumnName("lamoda_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.LamodaPrice2)
                    .HasColumnName("lamoda_price2")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.LamodaSync)
                    .HasColumnName("lamoda_sync")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.LidyanaListPrice)
                    .HasColumnName("lidyana_listPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.LidyanaSalePrice)
                    .HasColumnName("lidyana_salePrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.MainProduct)
                    .HasColumnName("main_product")
                    .HasComment("TRIAL");

                entity.Property(e => e.MainProductCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("main_productCode")
                    .HasComment("TRIAL");

                entity.Property(e => e.MaxPurchaseQuantity)
                    .HasColumnName("max_purchase_quantity")
                    .HasComment("TRIAL");

                entity.Property(e => e.Miad)
                    .HasColumnType("datetime")
                    .HasColumnName("miad")
                    .HasComment("TRIAL");

                entity.Property(e => e.MinPurchaseQuantity)
                    .HasColumnName("min_purchase_quantity")
                    .HasComment("TRIAL");

                entity.Property(e => e.MizuCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mizu_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.MizuPrice1)
                    .HasColumnName("mizu_price1")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.MizuPrice2)
                    .HasColumnName("mizu_price2")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.MizuSync)
                    .HasColumnName("mizu_sync")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.ModanisaCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("modanisa_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.ModanisaListPrice)
                    .HasColumnName("modanisa_listPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.ModanisaSalePrice)
                    .HasColumnName("modanisa_salePrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.MorhipoListPrice)
                    .HasColumnName("morhipo_listPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.MorhipoSalePrice)
                    .HasColumnName("morhipo_salePrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.Mpn)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mpn")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11AutopriceEnable)
                    .HasColumnName("n11_autoprice_enable")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11AutopriceSync)
                    .HasColumnName("n11_autoprice_sync")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11BundleEnable)
                    .HasColumnName("n11_bundle_enable")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11CatalogId)
                    .HasColumnName("n11_catalog_id")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("n11_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11Commission)
                    .HasColumnName("n11_commission")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11DiscountDateEnable)
                    .HasColumnName("n11_discountDateEnable")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11DiscountEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("n11_discountEnd")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11DiscountStart)
                    .HasColumnType("datetime")
                    .HasColumnName("n11_discountStart")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11DiscountType)
                    .HasColumnName("n11_discountType")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11DiscountValue)
                    .HasColumnName("n11_discountValue")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11MaxPurchaseQuantity)
                    .HasColumnName("n11_max_purchase_quantity")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11OemMode)
                    .HasColumnName("n11_oem_mode")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11Preparingday)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("n11_preparingday")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11Price)
                    .HasColumnName("n11_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11PriceBarem)
                    .HasColumnName("n11_price_barem")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11PriceMax)
                    .HasColumnName("n11_price_max")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11PriceMin)
                    .HasColumnName("n11_price_min")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11ProductUrl)
                    .HasColumnType("text")
                    .HasColumnName("n11_product_url")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11Productcondition)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("n11_productcondition")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11Shipmenttemplate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("n11_shipmenttemplate")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11Shipmenttemplate2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("n11_shipmenttemplate2")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11Sync)
                    .HasColumnName("n11_sync")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11proBarcodeDisable)
                    .HasColumnName("n11pro_barcode_disable")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11proDiscountType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("n11pro_discountType")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11proDiscountValue)
                    .HasColumnName("n11pro_discountValue")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.N11proPrice)
                    .HasColumnName("n11pro_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NarwooCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("narwoo_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.NarwooPrice)
                    .HasColumnName("narwoo_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NarwooSalePrice)
                    .HasColumnName("narwoo_salePrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NeedionCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("needion_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.NeedionListPrice)
                    .HasColumnName("needion_listPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NeedionSalePrice)
                    .HasColumnName("needion_salePrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NevadeCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nevade_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.NevadeListPrice)
                    .HasColumnName("nevade_listPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NevadeSalePrice)
                    .HasColumnName("nevade_salePrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NoUpdateBarcode)
                    .HasColumnName("no_update_barcode")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NoUpdateBrand)
                    .HasColumnName("no_update_brand")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NoUpdateCategory)
                    .HasColumnName("no_update_category")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NoUpdateDescription)
                    .HasColumnName("no_update_description")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NoUpdateDesi)
                    .HasColumnName("no_update_desi")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NoUpdateGtin)
                    .HasColumnName("no_update_gtin")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NoUpdateMpn)
                    .HasColumnName("no_update_mpn")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NoUpdateName)
                    .HasColumnName("no_update_name")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NoUpdatePicture)
                    .HasColumnName("no_update_picture")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NoUpdatePrice)
                    .HasColumnName("no_update_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NoUpdateQuantity)
                    .HasColumnName("no_update_quantity")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NoUpdateStatus)
                    .HasColumnName("no_update_status")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NovadanError)
                    .HasColumnName("novadan_error")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NovadanErrorMessage)
                    .HasColumnType("text")
                    .HasColumnName("novadan_error_message")
                    .HasComment("TRIAL");

                entity.Property(e => e.NovadanFront)
                    .HasColumnName("novadan_front")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NovadanIlanId)
                    .HasColumnName("novadan_ilan_id")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NovadanIntegrationCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("novadan_integration_code")
                    .HasComment("TRIAL");

                entity.Property(e => e.NovadanMaxsale)
                    .HasColumnName("novadan_maxsale")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NovadanOptionToProduct)
                    .HasColumnName("novadan_optionToProduct")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NovadanPrice)
                    .HasColumnName("novadan_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NovadanSync)
                    .HasColumnName("novadan_sync")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.NovadanSyncOrder)
                    .HasColumnName("novadan_syncOrder")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.OmnitronError)
                    .HasColumnName("omnitron_error")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.OmnitronErrorMessage)
                    .HasColumnType("text")
                    .HasColumnName("omnitron_error_message")
                    .HasComment("TRIAL");

                entity.Property(e => e.OmnitronPrice1)
                    .HasColumnName("omnitron_price1")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.OmnitronPrice2)
                    .HasColumnName("omnitron_price2")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.OmnitronSync)
                    .HasColumnName("omnitron_sync")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.OmnitronSyncOrder)
                    .HasColumnName("omnitron_syncOrder")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.Op1001Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("op1001_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.Op1001ListPrice)
                    .HasColumnName("op1001_listPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.Op1001SalePrice)
                    .HasColumnName("op1001_salePrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.Option)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("option")
                    .HasComment("TRIAL");

                entity.Property(e => e.OzonCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ozon_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.OzonPrice)
                    .HasColumnName("ozon_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.OzonPrice2)
                    .HasColumnName("ozon_price2")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.OzonSync)
                    .HasColumnName("ozon_sync")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.PazaramaCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pazarama_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.PazaramaListPrice)
                    .HasColumnName("pazarama_listPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.PazaramaSalePrice)
                    .HasColumnName("pazarama_salePrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.Price1)
                    .HasColumnName("price1")
                    .HasComment("TRIAL");

                entity.Property(e => e.Price2)
                    .HasColumnName("price2")
                    .HasComment("TRIAL");

                entity.Property(e => e.Price3)
                    .HasColumnName("price3")
                    .HasComment("TRIAL");

                entity.Property(e => e.Price4)
                    .HasColumnName("price4")
                    .HasComment("TRIAL");

                entity.Property(e => e.Price5)
                    .HasColumnName("price5")
                    .HasComment("TRIAL");

                entity.Property(e => e.Price6)
                    .HasColumnName("price6")
                    .HasComment("TRIAL");

                entity.Property(e => e.Price7)
                    .HasColumnName("price7")
                    .HasComment("TRIAL");

                entity.Property(e => e.Price8)
                    .HasColumnName("price8")
                    .HasComment("TRIAL");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("productCode")
                    .HasComment("TRIAL");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("productName")
                    .HasComment("TRIAL");

                entity.Property(e => e.ProductSubName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("productSubName")
                    .HasComment("TRIAL");

                entity.Property(e => e.ProductType)
                    .HasColumnName("product_type")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasComment("TRIAL");

                entity.Property(e => e.Quantity2)
                    .HasColumnName("quantity2")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.Quantity2Enable)
                    .HasColumnName("quantity2_enable")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.QuantityMax)
                    .HasColumnName("quantity_max")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.QuantityMin)
                    .HasColumnName("quantity_min")
                    .HasDefaultValueSql("((3))")
                    .HasComment("TRIAL");

                entity.Property(e => e.RozetkaCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("rozetka_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.RozetkaPrice)
                    .HasColumnName("rozetka_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.RozetkaPrice2)
                    .HasColumnName("rozetka_price2")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.RozetkaSync)
                    .HasColumnName("rozetka_sync")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendAliexpress)
                    .HasColumnName("send_aliexpress")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendAliniyor)
                    .HasColumnName("send_aliniyor")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendAmazon)
                    .HasColumnName("send_amazon")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendAmazonEu)
                    .HasColumnName("send_amazonEu")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendAmazonfr)
                    .HasColumnName("send_amazonfr")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendApi)
                    .HasColumnName("send_api")
                    .HasDefaultValueSql("((1))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendBamilo)
                    .HasColumnName("send_bamilo")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendBirvbiry)
                    .HasColumnName("send_birvbiry")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendBisifirat)
                    .HasColumnName("send_bisifirat")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendBpazar)
                    .HasColumnName("send_bpazar")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendCdiscount)
                    .HasColumnName("send_cdiscount")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendEanship)
                    .HasColumnName("send_eanship")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendEptt)
                    .HasColumnName("send_eptt")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendEticaret)
                    .HasColumnName("send_eticaret")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendEtsy)
                    .HasColumnName("send_etsy")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendEvideapazaryeri)
                    .HasColumnName("send_evideapazaryeri")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendFarmaborsa)
                    .HasColumnName("send_farmaborsa")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendFarmazon)
                    .HasColumnName("send_farmazon")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendFlo)
                    .HasColumnName("send_flo")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendGetir)
                    .HasColumnName("send_getir")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendGg)
                    .HasColumnName("send_gg")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendGordumaldim)
                    .HasColumnName("send_gordumaldim")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendHb)
                    .HasColumnName("send_hb")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendIyifiyat)
                    .HasColumnName("send_iyifiyat")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendJoom)
                    .HasColumnName("send_joom")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendLamoda)
                    .HasColumnName("send_lamoda")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendLidyana)
                    .HasColumnName("send_lidyana")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendMizu)
                    .HasColumnName("send_mizu")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendModanisa)
                    .HasColumnName("send_modanisa")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendMorhipo)
                    .HasColumnName("send_morhipo")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendN11)
                    .HasColumnName("send_n11")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendN11pro)
                    .HasColumnName("send_n11pro")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendNarwoo)
                    .HasColumnName("send_narwoo")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendNeedion)
                    .HasColumnName("send_needion")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendNevade)
                    .HasColumnName("send_nevade")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendNovadan)
                    .HasColumnName("send_novadan")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendOmnitron)
                    .HasColumnName("send_omnitron")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendOp1001)
                    .HasColumnName("send_op1001")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendOzon)
                    .HasColumnName("send_ozon")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendPazarama)
                    .HasColumnName("send_pazarama")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendRozetka)
                    .HasColumnName("send_rozetka")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendSp)
                    .HasColumnName("send_sp")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendTrendyol)
                    .HasColumnName("send_trendyol")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendTurkcellpasaj)
                    .HasColumnName("send_turkcellpasaj")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendVfmall)
                    .HasColumnName("send_vfmall")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendWish)
                    .HasColumnName("send_wish")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendXml)
                    .HasColumnName("send_xml")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendYapisepeti)
                    .HasColumnName("send_yapisepeti")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendZebramo)
                    .HasColumnName("send_zebramo")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SendZoodmall)
                    .HasColumnName("send_zoodmall")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.ShipmentCost)
                    .HasColumnName("shipment_cost")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("sort_order")
                    .HasComment("TRIAL");

                entity.Property(e => e.SpCargoFirmCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sp_cargo_firm_code")
                    .HasComment("TRIAL");

                entity.Property(e => e.SpCargoShippingDay)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sp_cargo_shipping_day")
                    .HasComment("TRIAL");

                entity.Property(e => e.SpCargoShippingPayType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sp_cargo_shipping_pay_type")
                    .HasComment("TRIAL");

                entity.Property(e => e.SpCargoShippingPayType2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sp_cargo_shipping_pay_type2")
                    .HasComment("TRIAL");

                entity.Property(e => e.SpCity)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sp_city")
                    .HasComment("TRIAL");

                entity.Property(e => e.SpDuration)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sp_duration")
                    .HasComment("TRIAL");

                entity.Property(e => e.SpMaxSaleQuantity)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sp_max_sale_quantity")
                    .HasComment("TRIAL");

                entity.Property(e => e.SpMinSaleQuantity)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sp_min_sale_quantity")
                    .HasComment("TRIAL");

                entity.Property(e => e.SpPrice)
                    .HasColumnName("sp_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SpSanalpazarCategoryCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sp_sanalpazar_category_code")
                    .HasComment("TRIAL");

                entity.Property(e => e.SpSanalpazarStoreCategoryCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sp_sanalpazar_store_category_code")
                    .HasComment("TRIAL");

                entity.Property(e => e.SpUseBoldName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sp_use_bold_name")
                    .HasComment("TRIAL");

                entity.Property(e => e.SpecBody)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("spec_body")
                    .HasComment("TRIAL");

                entity.Property(e => e.SpecColor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("spec_color")
                    .HasComment("TRIAL");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasComment("TRIAL");

                entity.Property(e => e.SubName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sub_name")
                    .HasComment("TRIAL");

                entity.Property(e => e.SubName2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sub_name2")
                    .HasComment("TRIAL");

                entity.Property(e => e.Supplier)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("supplier")
                    .HasComment("TRIAL");

                entity.Property(e => e.SupplierId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("supplier_id")
                    .HasComment("TRIAL");

                entity.Property(e => e.Sync)
                    .HasColumnName("sync")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SyncBirvbiry)
                    .HasColumnName("sync_birvbiry")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SyncDate)
                    .HasColumnType("datetime")
                    .HasColumnName("sync_date")
                    .HasComment("TRIAL");

                entity.Property(e => e.SyncEanship)
                    .HasColumnName("sync_eanship")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SyncEvideapazaryeri)
                    .HasColumnName("sync_evideapazaryeri")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SyncOrder)
                    .HasColumnName("syncOrder")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.SyncOrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("syncOrderDate")
                    .HasComment("TRIAL");

                entity.Property(e => e.TrdOptionToProduct)
                    .HasColumnName("trd_optionToProduct")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.TrendyolAutopriceEnable)
                    .HasColumnName("trendyol_autoprice_enable")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.TrendyolCargoFirmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trendyol_cargo_firm_id")
                    .HasComment("TRIAL");

                entity.Property(e => e.TrendyolCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trendyol_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.TrendyolCommission)
                    .HasColumnName("trendyol_commission")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.TrendyolListPrice)
                    .HasColumnName("trendyol_listPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.TrendyolPriceBarem)
                    .HasColumnName("trendyol_price_barem")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.TrendyolPriceMax)
                    .HasColumnName("trendyol_price_max")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.TrendyolPriceMin)
                    .HasColumnName("trendyol_price_min")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.TrendyolProductUrl)
                    .HasColumnType("text")
                    .HasColumnName("trendyol_product_url")
                    .HasComment("TRIAL");

                entity.Property(e => e.TrendyolSalePrice)
                    .HasColumnName("trendyol_salePrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.TrendyolSpeedAutopriceEnable)
                    .HasColumnName("trendyol_speed_autoprice_enable")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.TrendyolUpdatePriceQuantity)
                    .HasColumnName("trendyol_update_price_quantity")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.TrendyolUpdateQuantity)
                    .HasColumnName("trendyol_update_quantity")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.Trial579)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRIAL579")
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.TurkcellpasajListPrice)
                    .HasColumnName("turkcellpasaj_listPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.TurkcellpasajSalePrice)
                    .HasColumnName("turkcellpasaj_salePrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.VfmallCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vfmall_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.VfmallListPrice)
                    .HasColumnName("vfmall_listPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.VfmallSalePrice)
                    .HasColumnName("vfmall_salePrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.WarehouseRackNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("warehouse_rack_number")
                    .HasComment("TRIAL");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.WishPrice)
                    .HasColumnName("wish_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.WolvoxId)
                    .HasColumnName("wolvox_id")
                    .HasComment("TRIAL");

                entity.Property(e => e.WolvoxPictureSync)
                    .HasColumnName("wolvox_picture_sync")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.XmlCurrencyType)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("xml_currencyType")
                    .HasComment("TRIAL");

                entity.Property(e => e.XmlPrice)
                    .HasColumnName("xml_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.XmlPrice10)
                    .HasColumnName("xml_price10")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.XmlPrice11)
                    .HasColumnName("xml_price11")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.XmlPrice12)
                    .HasColumnName("xml_price12")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.XmlPrice13)
                    .HasColumnName("xml_price13")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.XmlPrice14)
                    .HasColumnName("xml_price14")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.XmlPrice15)
                    .HasColumnName("xml_price15")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.XmlPrice2)
                    .HasColumnName("xml_price2")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.XmlPrice3)
                    .HasColumnName("xml_price3")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.XmlPrice4)
                    .HasColumnName("xml_price4")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.XmlPrice5)
                    .HasColumnName("xml_price5")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.XmlPrice6)
                    .HasColumnName("xml_price6")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.XmlPrice7)
                    .HasColumnName("xml_price7")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.XmlPrice8)
                    .HasColumnName("xml_price8")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.XmlPrice9)
                    .HasColumnName("xml_price9")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.YapisepetiCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("yapisepeti_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.YapisepetiListPrice)
                    .HasColumnName("yapisepeti_listPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.YapisepetiSalePrice)
                    .HasColumnName("yapisepeti_salePrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.ZebramoCargoShippingPayment)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("zebramo_cargo_shippingPayment")
                    .HasComment("TRIAL");

                entity.Property(e => e.ZebramoListPrice)
                    .HasColumnName("zebramo_listPrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.ZebramoSalePrice)
                    .HasColumnName("zebramo_salePrice")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");

                entity.Property(e => e.ZoodmallCategory)
                    .HasColumnName("zoodmall_category")
                    .HasComment("TRIAL");

                entity.Property(e => e.ZoodmallPrice)
                    .HasColumnName("zoodmall_price")
                    .HasDefaultValueSql("((0))")
                    .HasComment("TRIAL");
            });

            modelBuilder.Entity<ProductDescription>(entity =>
            {
                entity.ToTable("product_description");

                entity.HasComment("TRIAL");

                entity.HasIndex(e => e.ProductId, "product_description_product_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("TRIAL");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description")
                    .HasComment("TRIAL");

                entity.Property(e => e.Description1)
                    .HasColumnType("text")
                    .HasColumnName("description1")
                    .HasComment("TRIAL");

                entity.Property(e => e.Description2)
                    .HasColumnType("text")
                    .HasColumnName("description2")
                    .HasComment("TRIAL");

                entity.Property(e => e.Description3)
                    .HasColumnType("text")
                    .HasColumnName("description3")
                    .HasComment("TRIAL");

                entity.Property(e => e.Description4)
                    .HasColumnType("text")
                    .HasColumnName("description4")
                    .HasComment("TRIAL");

                entity.Property(e => e.Description5)
                    .HasColumnType("text")
                    .HasColumnName("description5")
                    .HasComment("TRIAL");

                entity.Property(e => e.EanshareDescription)
                    .HasColumnType("text")
                    .HasColumnName("eanshare_description")
                    .HasComment("TRIAL");

                entity.Property(e => e.EticaretId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("eticaret_id")
                    .HasComment("TRIAL");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasComment("TRIAL");

                entity.Property(e => e.Trial471)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRIAL471")
                    .IsFixedLength()
                    .HasComment("TRIAL");
            });

            modelBuilder.Entity<TblAgirlik>(entity =>
            {
                entity.HasKey(e => e.AgirlikId);

                entity.ToTable("tbl_agirlik");

                entity.Property(e => e.AgirlikId).HasColumnName("agirlik_id");

                entity.Property(e => e.Agirlik).HasColumnName("agirlik");
            });

            modelBuilder.Entity<TblAltKategori>(entity =>
            {
                entity.HasKey(e => e.AltKategoriId);

                entity.ToTable("tbl_altKategori");

                entity.Property(e => e.AltKategoriId).HasColumnName("altKategori_id");

                entity.Property(e => e.AltKategori)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("altKategori");
            });

            modelBuilder.Entity<TblAltKategority>(entity =>
            {
                entity.HasKey(e => e.AltKategoriId);

                entity.ToTable("tbl_altKategority");

                entity.Property(e => e.AltKategoriId).HasColumnName("altKategori_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ParentId).HasColumnName("parentId");
            });

            modelBuilder.Entity<TblAltUrunler>(entity =>
            {
                entity.HasKey(e => e.AltUrunId);

                entity.ToTable("tbl_altUrunler");

                entity.Property(e => e.AltUrunId).HasColumnName("altUrun_id");

                entity.Property(e => e.AltUrunAdi)
                    .HasMaxLength(50)
                    .HasColumnName("altUrunAdi");

                entity.Property(e => e.Fiyat)
                    .HasColumnType("money")
                    .HasColumnName("fiyat");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.HasOne(d => d.Urun)
                    .WithMany(p => p.TblAltUrunlers)
                    .HasForeignKey(d => d.UrunId)
                    .HasConstraintName("FK_tbl_altUrunler_tbl_urun");
            });

            modelBuilder.Entity<TblBirlestirilmisUrunler>(entity =>
            {
                entity.HasKey(e => e.BilresikUrunlerId);

                entity.ToTable("tbl_birlestirilmisUrunler");

                entity.Property(e => e.BilresikUrunlerId).HasColumnName("bilresikUrunler_id");

                entity.Property(e => e.UrunIdler)
                    .IsUnicode(false)
                    .HasColumnName("urunIdler");
            });

            modelBuilder.Entity<TblBuybox>(entity =>
            {
                entity.HasKey(e => e.BuyboxId);

                entity.ToTable("tbl_buybox");

                entity.Property(e => e.BuyboxId).HasColumnName("buybox_id");

                entity.Property(e => e.Baslangıcfiyat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("baslangıcfiyat");

                entity.Property(e => e.BizimFiyat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bizimFiyat");

                entity.Property(e => e.BizimSira).HasColumnName("bizimSira");

                entity.Property(e => e.DispatchTime).IsUnicode(false);

                entity.Property(e => e.Durum).HasColumnName("durum");

                entity.Property(e => e.Elleotomatik).HasColumnName("elleotomatik");

                entity.Property(e => e.Endusukfiyat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("endusukfiyat");

                entity.Property(e => e.Fark)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fark");

                entity.Property(e => e.GuncelFiyat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Islemsayisi).HasColumnName("islemsayisi");

                entity.Property(e => e.Marka).HasColumnName("marka");

                entity.Property(e => e.MaxFiyat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("maxFiyat");

                entity.Property(e => e.MerchantName).IsUnicode(false);

                entity.Property(e => e.MerchantRating).IsUnicode(false);

                entity.Property(e => e.MinFiyat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("minFiyat");

                entity.Property(e => e.Onceki).HasColumnName("onceki");

                entity.Property(e => e.Price).IsUnicode(false);

                entity.Property(e => e.Rank).IsUnicode(false);

                entity.Property(e => e.Sku).IsUnicode(false);

                entity.Property(e => e.Sonfiyat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sonfiyat");

                entity.Property(e => e.Sonraki).HasColumnName("sonraki");

                entity.Property(e => e.Öneri)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("öneri");

                entity.Property(e => e.ÜrünAd).HasColumnName("ürün_ad");
            });

            modelBuilder.Entity<TblBuyboxTy>(entity =>
            {
                entity.HasKey(e => e.BuyboxTyId);

                entity.ToTable("tbl_buyboxTy");

                entity.HasComment("TRIAL");

                entity.Property(e => e.BuyboxTyId)
                    .HasColumnName("buyboxTy_id")
                    .HasComment("TRIAL");

                entity.Property(e => e.Barkod).HasColumnName("barkod");

                entity.Property(e => e.Bizimfiyat)
                    .IsUnicode(false)
                    .HasColumnName("bizimfiyat");

                entity.Property(e => e.Bizimsira).HasColumnName("bizimsira");

                entity.Property(e => e.DiscountedPrice)
                    .IsUnicode(false)
                    .HasColumnName("discountedPrice")
                    .HasComment("TRIAL");

                entity.Property(e => e.Durum)
                    .HasColumnName("durum")
                    .HasComment("TRIAL");

                entity.Property(e => e.Link)
                    .IsUnicode(false)
                    .HasColumnName("link")
                    .HasComment("TRIAL");

                entity.Property(e => e.Max)
                    .IsUnicode(false)
                    .HasColumnName("max");

                entity.Property(e => e.Min)
                    .IsUnicode(false)
                    .HasColumnName("min");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .HasComment("TRIAL");

                entity.Property(e => e.OriginalPrice)
                    .IsUnicode(false)
                    .HasColumnName("originalPrice")
                    .HasComment("TRIAL");

                entity.Property(e => e.SaticiId)
                    .IsUnicode(false)
                    .HasColumnName("satici_id")
                    .HasComment("TRIAL");

                entity.Property(e => e.SellerScore)
                    .IsUnicode(false)
                    .HasColumnName("sellerScore")
                    .HasComment("TRIAL");

                entity.Property(e => e.SellingPrice)
                    .IsUnicode(false)
                    .HasColumnName("sellingPrice")
                    .HasComment("TRIAL");

                entity.Property(e => e.Sonraki)
                    .IsUnicode(false)
                    .HasColumnName("sonraki");

                entity.Property(e => e.Önceki)
                    .IsUnicode(false)
                    .HasColumnName("önceki");
            });

            modelBuilder.Entity<TblCargo>(entity =>
            {
                entity.HasKey(e => e.KargoId);

                entity.ToTable("tbl_cargo");

                entity.Property(e => e.KargoId).HasColumnName("kargo_id");

                entity.Property(e => e.Firma)
                    .IsUnicode(false)
                    .HasColumnName("firma");

                entity.Property(e => e.FirmaKodu)
                    .IsUnicode(false)
                    .HasColumnName("firmaKodu");
            });

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.ToTable("tbl_category");

                entity.Property(e => e.CId).HasColumnName("c_id");

                entity.Property(e => e.CategoryId)
                    .IsUnicode(false)
                    .HasColumnName("category_id");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TblCiki>(entity =>
            {
                entity.ToTable("Tbl_cikis");

                entity.Property(e => e.Barkod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KalemSayisi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Kalem_Sayisi");

                entity.Property(e => e.KargoFirmaAdı)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Kargo_FirmaAdı");

                entity.Property(e => e.KargoyaSonVerme)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Kargoya_sonVerme");

                entity.Property(e => e.MusteriAd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Musteri_Ad");

                entity.Property(e => e.Pazaryeri)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pazaryeri");

                entity.Property(e => e.SiparisDurumu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Siparis_Durumu");

                entity.Property(e => e.SiparisNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Siparis_No");

                entity.Property(e => e.TeslimatAdres)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Teslimat_Adres");

                entity.Property(e => e.ToplamFiyat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Toplam_Fiyat");

                entity.HasOne(d => d.BarkodNavigation)
                    .WithMany(p => p.TblCikis)
                    .HasForeignKey(d => d.Barkod)
                    .HasConstraintName("FK_Tbl_cikis_Tbl_Urunler");
            });

            modelBuilder.Entity<TblColor>(entity =>
            {
                entity.HasKey(e => e.RenkId);

                entity.ToTable("tbl_color");

                entity.Property(e => e.RenkId).HasColumnName("renk_id");

                entity.Property(e => e.Renk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("renk");

                entity.Property(e => e.RenkKodu).HasColumnName("renkKodu");
            });

            modelBuilder.Entity<TblCustomer>(entity =>
            {
                entity.HasKey(e => e.MusteriId)
                    .HasName("PK_tbl_musteri");

                entity.ToTable("tbl_customer");

                entity.Property(e => e.MusteriId).HasColumnName("musteri_id");

                entity.Property(e => e.Adres)
                    .IsUnicode(false)
                    .HasColumnName("adres");

                entity.Property(e => e.MAd)
                    .IsUnicode(false)
                    .HasColumnName("mAd");

                entity.Property(e => e.MSoyad)
                    .IsUnicode(false)
                    .HasColumnName("mSoyad");

                entity.Property(e => e.Tel)
                    .IsUnicode(false)
                    .HasColumnName("tel");
            });

            modelBuilder.Entity<TblDigerSatici>(entity =>
            {
                entity.HasKey(e => e.DigerSaticiId);

                entity.ToTable("tbl_digerSatici");

                entity.Property(e => e.DigerSaticiId)
                    .ValueGeneratedNever()
                    .HasColumnName("digerSatici_id");

                entity.Property(e => e.BuyBoxOrder)
                    .HasMaxLength(10)
                    .HasColumnName("buyBoxOrder")
                    .IsFixedLength();

                entity.Property(e => e.DispatchTime)
                    .HasMaxLength(10)
                    .HasColumnName("dispatchTime")
                    .IsFixedLength();

                entity.Property(e => e.IsFulfilledByHb)
                    .HasMaxLength(10)
                    .HasColumnName("isFulfilledByHB")
                    .IsFixedLength();

                entity.Property(e => e.LifeTimeRating).HasColumnName("lifeTimeRating");

                entity.Property(e => e.MerchantCity)
                    .HasMaxLength(30)
                    .HasColumnName("merchantCity")
                    .IsFixedLength();

                entity.Property(e => e.MerchantCountry)
                    .HasMaxLength(30)
                    .HasColumnName("merchantCountry")
                    .IsFixedLength();

                entity.Property(e => e.MerchantId).HasColumnName("merchantId");

                entity.Property(e => e.MerchantName)
                    .HasMaxLength(50)
                    .HasColumnName("merchantName");

                entity.Property(e => e.MerchantPageUrl)
                    .HasMaxLength(100)
                    .HasColumnName("merchantPageUrl")
                    .IsFixedLength();

                entity.Property(e => e.MerchantVariantUrl)
                    .HasMaxLength(200)
                    .HasColumnName("merchantVariantUrl")
                    .IsFixedLength();

                entity.Property(e => e.Quantity)
                    .HasMaxLength(10)
                    .HasColumnName("quantity")
                    .IsFixedLength();

                entity.Property(e => e.Sehir)
                    .HasMaxLength(30)
                    .HasColumnName("sehir")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDigerSaticiFiyat>(entity =>
            {
                entity.HasKey(e => e.DigerSaticiFiyatId);

                entity.ToTable("tbl_digerSaticiFiyat");

                entity.Property(e => e.DigerSaticiFiyatId)
                    .ValueGeneratedNever()
                    .HasColumnName("digerSaticiFiyat_id");

                entity.Property(e => e.DigerSaticiUrunId).HasColumnName("digerSaticiUrun_id");

                entity.Property(e => e.MinimumPriceText)
                    .HasMaxLength(10)
                    .HasColumnName("minimumPriceText")
                    .IsFixedLength();

                entity.Property(e => e.OriginalPriceText)
                    .HasMaxLength(10)
                    .HasColumnName("originalPriceText")
                    .IsFixedLength();

                entity.Property(e => e.PriceText)
                    .HasMaxLength(10)
                    .HasColumnName("priceText")
                    .IsFixedLength();

                entity.Property(e => e.SortPriceText)
                    .HasMaxLength(10)
                    .HasColumnName("sortPriceText")
                    .IsFixedLength();

                entity.Property(e => e.VatExcludedPriceText)
                    .HasMaxLength(10)
                    .HasColumnName("vatExcludedPriceText")
                    .IsFixedLength();

                entity.HasOne(d => d.DigerSaticiUrun)
                    .WithMany(p => p.TblDigerSaticiFiyats)
                    .HasForeignKey(d => d.DigerSaticiUrunId)
                    .HasConstraintName("FK_tbl_digerSaticiFiyat_tbl_digerSaticiUrun");
            });

            modelBuilder.Entity<TblDigerSaticiResim>(entity =>
            {
                entity.HasKey(e => e.DigerSaticiResimId);

                entity.ToTable("tbl_digerSaticiResim");

                entity.Property(e => e.DigerSaticiResimId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("digerSaticiResim_id");

                entity.Property(e => e.DigerSaticiUrunId).HasColumnName("digerSaticiUrun_id");

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("url");

                entity.HasOne(d => d.DigerSaticiResim)
                    .WithOne(p => p.TblDigerSaticiResim)
                    .HasForeignKey<TblDigerSaticiResim>(d => d.DigerSaticiResimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_digerSaticiResim_tbl_digerSaticiUrun");
            });

            modelBuilder.Entity<TblDigerSaticiTagList>(entity =>
            {
                entity.HasKey(e => e.DigerSaticiTagId);

                entity.ToTable("tbl_digerSaticiTagList");

                entity.Property(e => e.DigerSaticiTagId)
                    .ValueGeneratedNever()
                    .HasColumnName("digerSaticiTag_id");

                entity.Property(e => e.DigerSaticiUrunId).HasColumnName("digerSaticiUrun_id");

                entity.Property(e => e.Tag)
                    .HasMaxLength(200)
                    .HasColumnName("tag")
                    .IsFixedLength();

                entity.HasOne(d => d.DigerSaticiUrun)
                    .WithMany(p => p.TblDigerSaticiTagLists)
                    .HasForeignKey(d => d.DigerSaticiUrunId)
                    .HasConstraintName("FK_tbl_digerSaticiTagList_tbl_digerSaticiUrun");
            });

            modelBuilder.Entity<TblDigerSaticiUrun>(entity =>
            {
                entity.HasKey(e => e.DigerSaticiUrunId);

                entity.ToTable("tbl_digerSaticiUrun");

                entity.Property(e => e.DigerSaticiUrunId).HasColumnName("digerSaticiUrun_id");

                entity.Property(e => e.DefaultSku)
                    .HasMaxLength(50)
                    .HasColumnName("defaultSku")
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name")
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .HasColumnName("productId")
                    .IsFixedLength();

                entity.Property(e => e.Sku)
                    .HasMaxLength(50)
                    .HasColumnName("sku")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDigerUrunSaticiNm>(entity =>
            {
                entity.HasKey(e => e.DigerUrunSaticiNmId);

                entity.ToTable("tbl_digerUrunSaticiNm");

                entity.Property(e => e.DigerUrunSaticiNmId).HasColumnName("digerUrunSaticiNm_id");

                entity.Property(e => e.DigerSaticiId).HasColumnName("digerSatici_id");

                entity.Property(e => e.DigerSaticiUrunId).HasColumnName("digerSaticiUrun_id");

                entity.HasOne(d => d.DigerSatici)
                    .WithMany(p => p.TblDigerUrunSaticiNms)
                    .HasForeignKey(d => d.DigerSaticiId)
                    .HasConstraintName("FK_tbl_digerUrunSaticiNm_tbl_digerSatici");

                entity.HasOne(d => d.DigerSaticiUrun)
                    .WithMany(p => p.TblDigerUrunSaticiNms)
                    .HasForeignKey(d => d.DigerSaticiUrunId)
                    .HasConstraintName("FK_tbl_digerUrunSaticiNm_tbl_digerSaticiUrun");
            });

            modelBuilder.Entity<TblDurum>(entity =>
            {
                entity.HasKey(e => e.DurumId);

                entity.ToTable("tbl_durum");

                entity.Property(e => e.DurumId).HasColumnName("durum_id");

                entity.Property(e => e.Durum)
                    .HasMaxLength(20)
                    .HasColumnName("durum")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblFatura>(entity =>
            {
                entity.HasKey(e => e.FaturaId);

                entity.ToTable("tbl_fatura");

                entity.Property(e => e.FaturaId).HasColumnName("fatura_id");

                entity.Property(e => e.EArsivSeri)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("eArsivSeri");

                entity.Property(e => e.EFaturaSeri)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("eFaturaSeri");

                entity.Property(e => e.EFaturaTipi)
                    .HasMaxLength(15)
                    .HasColumnName("eFaturaTipi")
                    .IsFixedLength();

                entity.Property(e => e.FaturaTipi)
                    .HasMaxLength(15)
                    .HasColumnName("faturaTipi")
                    .IsFixedLength();

                entity.Property(e => e.FirmaId).HasColumnName("firma_id");

                entity.Property(e => e.KargoKodu)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("kargoKodu");

                entity.Property(e => e.KargoVergiNo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("kargoVergiNo");

                entity.Property(e => e.KdvIstisnaDurum)
                    .HasMaxLength(10)
                    .HasColumnName("kdvIstisnaDurum")
                    .IsFixedLength();

                entity.Property(e => e.KullaniciId).HasColumnName("kullanici_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.WebSiteUrl)
                    .HasMaxLength(200)
                    .HasColumnName("webSiteUrl")
                    .IsFixedLength();

                entity.HasOne(d => d.Firma)
                    .WithMany(p => p.TblFaturas)
                    .HasForeignKey(d => d.FirmaId)
                    .HasConstraintName("FK_tbl_fatura_tbl_firma");
            });

            modelBuilder.Entity<TblHacim>(entity =>
            {
                entity.HasKey(e => e.HacimId);

                entity.ToTable("tbl_hacim");

                entity.Property(e => e.HacimId).HasColumnName("hacim_id");

                entity.Property(e => e.Desi).HasColumnName("desi");
            });

            modelBuilder.Entity<TblHizliEkleHb>(entity =>
            {
                entity.HasKey(e => e.HueId);

                entity.ToTable("tbl_hizliEkleHb");

                entity.Property(e => e.HueId).HasColumnName("hue_id");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MerchantSku)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Price)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ProductName)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Stock)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblIptalEdilenTy>(entity =>
            {
                entity.HasKey(e => e.IptalEdilenSiparislerId);

                entity.ToTable("tbl_iptalEdilenTy");

                entity.Property(e => e.IptalEdilenSiparislerId).HasColumnName("iptalEdilenSiparisler_id");

                entity.Property(e => e.CargoProviderName)
                    .IsUnicode(false)
                    .HasColumnName("cargoProviderName");

                entity.Property(e => e.CargoTrackingNumber)
                    .IsUnicode(false)
                    .HasColumnName("cargoTrackingNumber");

                entity.Property(e => e.CustomerFirstName)
                    .IsUnicode(false)
                    .HasColumnName("customerFirstName");

                entity.Property(e => e.Id)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.OrderDate)
                    .IsUnicode(false)
                    .HasColumnName("orderDate");

                entity.Property(e => e.OrderNumber)
                    .IsUnicode(false)
                    .HasColumnName("orderNumber");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TotalPrice)
                    .IsUnicode(false)
                    .HasColumnName("totalPrice");
            });

            modelBuilder.Entity<TblKategori>(entity =>
            {
                entity.HasKey(e => e.KategoriId);

                entity.ToTable("tbl_kategori");

                entity.Property(e => e.KategoriId).HasColumnName("kategori_id");

                entity.Property(e => e.AltKategoriId).HasColumnName("altKategori_id");

                entity.Property(e => e.Kategori)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kategori");

                entity.HasOne(d => d.AltKategori)
                    .WithMany(p => p.TblKategoris)
                    .HasForeignKey(d => d.AltKategoriId)
                    .HasConstraintName("FK_tbl_kategori_tbl_altKategori");
            });

            modelBuilder.Entity<TblKategoriTy>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("tbl_kategoriTy");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<TblKategorilerHb>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("tbl_kategorilerHb");

                entity.Property(e => e.CategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("categoryId");

                entity.Property(e => e.Available)
                    .HasMaxLength(10)
                    .HasColumnName("available")
                    .IsFixedLength();

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("displayName");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("imageURL");

                entity.Property(e => e.Leaf)
                    .HasMaxLength(10)
                    .HasColumnName("leaf")
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.ParentCategoryId)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("parentCategoryId");

                entity.Property(e => e.Paths)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("paths");

                entity.Property(e => e.ProductTypesName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productTypes_name");

                entity.Property(e => e.ProductTypesTypeId)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("productTypes_TypeId");

                entity.Property(e => e.SortId).HasColumnName("sortId");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .HasColumnName("status")
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .HasColumnName("type")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblKullanici>(entity =>
            {
                entity.HasKey(e => e.KullaniciId);

                entity.ToTable("tbl_kullanici");

                entity.Property(e => e.KullaniciId).HasColumnName("kullanici_id");

                entity.Property(e => e.Ad).HasColumnName("ad");

                entity.Property(e => e.KAd)
                    .HasMaxLength(32)
                    .HasColumnName("k_ad");

                entity.Property(e => e.KSif)
                    .HasMaxLength(32)
                    .HasColumnName("k_sif");

                entity.Property(e => e.KayitTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("kayit_tarihi")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Soyad).HasColumnName("soyad");

                entity.Property(e => e.Tur)
                    .HasMaxLength(10)
                    .HasColumnName("tur")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblKullohbuybox>(entity =>
            {
                entity.ToTable("tbl_kullohbuybox");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fark)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fark");

                entity.Property(e => e.Kad).HasColumnName("kad");

                entity.Property(e => e.Marka).HasColumnName("marka");

                entity.Property(e => e.Max)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("max");

                entity.Property(e => e.Min)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("min");

                entity.Property(e => e.Otomanuel).HasColumnName("otomanuel");

                entity.Property(e => e.Sku).HasColumnName("sku");

                entity.Property(e => e.Sonfiyat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("");
            });

            modelBuilder.Entity<TblLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("tbl_log");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.KullaniciId).HasColumnName("kullanici_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.Zaman).HasColumnName("zaman");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.TblLogs)
                    .HasForeignKey(d => d.KullaniciId)
                    .HasConstraintName("FK_tbl_log_tbl_kullanici");

                entity.HasOne(d => d.Urun)
                    .WithMany(p => p.TblLogs)
                    .HasForeignKey(d => d.UrunId)
                    .HasConstraintName("FK_tbl_log_tbl_urun");
            });

            modelBuilder.Entity<TblLogbuybux>(entity =>
            {
                entity.ToTable("tbl_logbuybux");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bilgi).HasColumnName("bilgi");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Fiyat)
                    .HasMaxLength(50)
                    .HasColumnName("fiyat");

                entity.Property(e => e.Sku).HasColumnName("sku");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("tarih")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblMagazaFiyatlari>(entity =>
            {
                entity.HasKey(e => e.MFiyatId);

                entity.ToTable("tbl_magazaFiyatlari");

                entity.Property(e => e.MFiyatId).HasColumnName("mFiyat_id");

                entity.Property(e => e.Amazon)
                    .HasColumnType("money")
                    .HasColumnName("amazon");

                entity.Property(e => e.Hepsiburada)
                    .HasColumnType("money")
                    .HasColumnName("hepsiburada");

                entity.Property(e => e.N11)
                    .HasColumnType("money")
                    .HasColumnName("n11");

                entity.Property(e => e.Trendyol)
                    .HasColumnType("money")
                    .HasColumnName("trendyol");
            });

            modelBuilder.Entity<TblMarka>(entity =>
            {
                entity.HasKey(e => e.MarkaId);

                entity.ToTable("tbl_marka");

                entity.Property(e => e.MarkaId).HasColumnName("marka_id");

                entity.Property(e => e.Marka)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("marka");
            });

            modelBuilder.Entity<TblMarkaTy>(entity =>
            {
                entity.HasKey(e => e.MarkaId);

                entity.ToTable("tbl_markaTy");

                entity.Property(e => e.MarkaId).HasColumnName("marka_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Names).HasColumnName("names");
            });

            modelBuilder.Entity<TblModel>(entity =>
            {
                entity.HasKey(e => e.ModelId);

                entity.ToTable("tbl_model");

                entity.Property(e => e.ModelId).HasColumnName("model_id");

                entity.Property(e => e.MarkaId).HasColumnName("marka_id");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("model");

                entity.HasOne(d => d.Marka)
                    .WithMany(p => p.TblModels)
                    .HasForeignKey(d => d.MarkaId)
                    .HasConstraintName("FK_tbl_model_tbl_marka");
            });

            modelBuilder.Entity<TblMusteri>(entity =>
            {
                entity.HasKey(e => e.FirmaId)
                    .HasName("PK_tbl_firma");

                entity.ToTable("tbl_musteri");

                entity.Property(e => e.FirmaId).HasColumnName("firma_id");

                entity.Property(e => e.Adres)
                    .HasColumnType("text")
                    .HasColumnName("adres");

                entity.Property(e => e.Alias)
                    .HasMaxLength(50)
                    .HasColumnName("alias");

                entity.Property(e => e.FirmaAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("firmaAdi");

                entity.Property(e => e.Il)
                    .HasMaxLength(30)
                    .HasColumnName("il")
                    .IsFixedLength();

                entity.Property(e => e.Ilce)
                    .HasMaxLength(30)
                    .HasColumnName("ilce")
                    .IsFixedLength();

                entity.Property(e => e.Mail)
                    .HasMaxLength(30)
                    .HasColumnName("mail")
                    .IsFixedLength();

                entity.Property(e => e.PazarYeri)
                    .HasMaxLength(50)
                    .HasColumnName("pazarYeri");

                entity.Property(e => e.SabitSiparisNotu)
                    .HasColumnType("text")
                    .HasColumnName("sabitSiparisNotu");

                entity.Property(e => e.Tel)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("tel");

                entity.Property(e => e.VergiDairesi)
                    .HasMaxLength(50)
                    .HasColumnName("vergiDairesi");

                entity.Property(e => e.Vkn)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("vkn");
            });

            modelBuilder.Entity<TblMusteriler>(entity =>
            {
                entity.ToTable("tbl_musteriler");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Logoid).HasColumnName("logoid");

                entity.Property(e => e.Uniqid).HasColumnName("uniqid");
            });

            modelBuilder.Entity<TblNumara>(entity =>
            {
                entity.HasKey(e => e.NumaraId);

                entity.ToTable("tbl_numara");

                entity.Property(e => e.NumaraId).HasColumnName("numara_id");

                entity.Property(e => e.Numara).HasColumnName("numara");
            });

            modelBuilder.Entity<TblOrder>(entity =>
            {
                entity.ToTable("tbl_order");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bank_code");

                entity.Property(e => e.CargoBarcodeRaw)
                    .HasColumnType("text")
                    .HasColumnName("cargo_barcode_raw");

                entity.Property(e => e.CargoCancelSync).HasColumnName("cargo_cancel_sync");

                entity.Property(e => e.CargoCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargo_code");

                entity.Property(e => e.CargoCode2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cargo_code2");

                entity.Property(e => e.CargoCompany)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cargo_company");

                entity.Property(e => e.CargoDeliveryStatusSync).HasColumnName("cargo_delivery_status_sync");

                entity.Property(e => e.CargoErrorMessage)
                    .HasColumnType("text")
                    .HasColumnName("cargo_error_message");

                entity.Property(e => e.CargoFeeType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cargo_fee_type");

                entity.Property(e => e.CargoFinallyStatu)
                    .HasColumnType("text")
                    .HasColumnName("cargo_finally_statu");

                entity.Property(e => e.CargoFollowUrl)
                    .HasColumnType("text")
                    .HasColumnName("cargo_follow_url");

                entity.Property(e => e.CargoPacketQuantity).HasColumnName("cargo_packet_quantity");

                entity.Property(e => e.CargoPacketType).HasColumnName("cargo_packet_type");

                entity.Property(e => e.CargoSendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cargo_send_date");

                entity.Property(e => e.CargoServiceInformation)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cargo_service_information");

                entity.Property(e => e.CargoSync).HasColumnName("cargo_sync");

                entity.Property(e => e.Company)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.CouponPrice).HasColumnName("coupon_price");

                entity.Property(e => e.CreateCommonLabelSync).HasColumnName("create_common_label_sync");

                entity.Property(e => e.CurrencyRate).HasColumnName("currency_rate");

                entity.Property(e => e.CurrencyType)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("currencyType");

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customer_code");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdd)
                    .HasColumnType("datetime")
                    .HasColumnName("date_add");

                entity.Property(e => e.DateChange)
                    .HasColumnType("datetime")
                    .HasColumnName("date_change");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime");

                entity.Property(e => e.DeliveredDate)
                    .HasColumnType("datetime")
                    .HasColumnName("delivered_date");

                entity.Property(e => e.DeliveredPersonName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("delivered_person_name");

                entity.Property(e => e.DeliveryMethod)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("delivery_method");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.EfaturaSync).HasColumnName("efatura_sync");

                entity.Property(e => e.EinvoiceErrorMessage)
                    .HasColumnType("text")
                    .HasColumnName("einvoice_error_message");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Entegration)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("entegration");

                entity.Property(e => e.ErpError).HasColumnName("erp_error");

                entity.Property(e => e.ErpMessage)
                    .HasColumnType("text")
                    .HasColumnName("erp_message");

                entity.Property(e => e.ErpOrderNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("erp_order_number");

                entity.Property(e => e.Ettn)
                    .HasColumnType("text")
                    .HasColumnName("ettn");

                entity.Property(e => e.EurRate).HasColumnName("eur_rate");

                entity.Property(e => e.Fax)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("fax");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("firstname");

                entity.Property(e => e.Fulfillment)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fulfillment");

                entity.Property(e => e.FulfillmentCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("fulfillment_code");

                entity.Property(e => e.FulfillmentErrorMessage)
                    .HasColumnType("text")
                    .HasColumnName("fulfillment_error_message");

                entity.Property(e => e.FulfillmentSync).HasColumnName("fulfillment_sync");

                entity.Property(e => e.GibNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("gib_number");

                entity.Property(e => e.GrandTotal).HasColumnName("grand_total");

                entity.Property(e => e.GrandTotalDesi).HasColumnName("grand_total_desi");

                entity.Property(e => e.Guid)
                    .HasColumnType("text")
                    .HasColumnName("guid");

                entity.Property(e => e.HbDiscountInvoice).HasColumnName("hb_discount_invoice");

                entity.Property(e => e.Installment).HasColumnName("installment");

                entity.Property(e => e.InvoiceAddress)
                    .HasColumnType("text")
                    .HasColumnName("invoice_address");

                entity.Property(e => e.InvoiceCity)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("invoice_city");

                entity.Property(e => e.InvoiceCountry)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("invoice_country");

                entity.Property(e => e.InvoiceCountryCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("invoice_country_code");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("invoice_date");

                entity.Property(e => e.InvoiceDistrict)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("invoice_district");

                entity.Property(e => e.InvoiceFullname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("invoice_fullname");

                entity.Property(e => e.InvoiceGsm)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("invoice_gsm");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("invoice_number");

                entity.Property(e => e.InvoicePostcode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("invoice_postcode");

                entity.Property(e => e.InvoicePrint).HasColumnName("invoice_print");

                entity.Property(e => e.InvoiceTel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("invoice_tel");

                entity.Property(e => e.IsFulfillment).HasColumnName("is_fulfillment");

                entity.Property(e => e.IsPartial).HasColumnName("is_partial");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("lastname");

                entity.Property(e => e.MarketingSync).HasColumnName("marketing_sync");

                entity.Property(e => e.MobilPhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mobil_phone");

                entity.Property(e => e.MorhipoOrderStatu).HasColumnName("morhipo_order_statu");

                entity.Property(e => e.MutHizmet).HasColumnName("mut_hizmet");

                entity.Property(e => e.MutIptal).HasColumnName("mut_iptal");

                entity.Property(e => e.MutKargo).HasColumnName("mut_kargo");

                entity.Property(e => e.MutOdeme).HasColumnName("mut_odeme");

                entity.Property(e => e.No)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("no");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasColumnName("note");

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("order_number");

                entity.Property(e => e.OrderPrefix)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("order_prefix");

                entity.Property(e => e.OrderProcess).HasColumnName("order_process");

                entity.Property(e => e.PaymentStatus).HasColumnName("payment_status");

                entity.Property(e => e.PaymentType).HasColumnName("paymentType");

                entity.Property(e => e.PlatformReferenceNo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("platform_reference_no");

                entity.Property(e => e.PlatformSerialSync).HasColumnName("platform_serial_sync");

                entity.Property(e => e.PreparationStateSync).HasColumnName("preparation_state_sync");

                entity.Property(e => e.PreparationTime)
                    .HasColumnType("datetime")
                    .HasColumnName("preparation_time");

                entity.Property(e => e.SendEfatura).HasColumnName("send_efatura");

                entity.Property(e => e.ShipAddress)
                    .HasColumnType("text")
                    .HasColumnName("ship_address");

                entity.Property(e => e.ShipCity)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ship_city");

                entity.Property(e => e.ShipCountry)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ship_country");

                entity.Property(e => e.ShipCountryCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ship_country_code");

                entity.Property(e => e.ShipDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ship_date");

                entity.Property(e => e.ShipDistrict)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ship_district");

                entity.Property(e => e.ShipFullname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ship_fullname");

                entity.Property(e => e.ShipGsm)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ship_gsm");

                entity.Property(e => e.ShipNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ship_number");

                entity.Property(e => e.ShipPostcode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ship_postcode");

                entity.Property(e => e.ShipPrice).HasColumnName("ship_price");

                entity.Property(e => e.ShipPrint).HasColumnName("ship_print");

                entity.Property(e => e.ShipTel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ship_tel");

                entity.Property(e => e.ShopId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("shop_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.StoreId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("store_id");

                entity.Property(e => e.StoreOrderStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("store_order_status");

                entity.Property(e => e.StoreOrderStatusName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("store_order_status_name");

                entity.Property(e => e.Supplier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplier");

                entity.Property(e => e.SupplierId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplier_id");

                entity.Property(e => e.SupplierOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplier_order_id");

                entity.Property(e => e.SupplierPacketId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("supplier_packet_id");

                entity.Property(e => e.Sync).HasColumnName("sync");

                entity.Property(e => e.Tax).HasColumnName("tax");

                entity.Property(e => e.TaxNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tax_number");

                entity.Property(e => e.TaxOffice)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tax_office");

                entity.Property(e => e.TcId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tc_id");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telephone");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.TotalCommissionIncludeTax).HasColumnName("total_commission_include_tax");

                entity.Property(e => e.TotalPaidPrice).HasColumnName("total_paid_price");

                entity.Property(e => e.TotalProduct).HasColumnName("total_product");

                entity.Property(e => e.TotalProductQuantity).HasColumnName("total_product_quantity");

                entity.Property(e => e.TrackingNumberSync).HasColumnName("tracking_number_sync");

                entity.Property(e => e.UsdRate).HasColumnName("usd_rate");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<TblOrtakSipari>(entity =>
            {
                entity.HasKey(e => e.PaketId);

                entity.ToTable("tbl_ortakSiparis");

                entity.Property(e => e.PaketId).HasColumnName("paket_id");

                entity.Property(e => e.Adet).HasColumnName("adet");

                entity.Property(e => e.FullAdres)
                    .IsUnicode(false)
                    .HasColumnName("fullAdres");

                entity.Property(e => e.KargoSirketi)
                    .IsUnicode(false)
                    .HasColumnName("kargoSirketi");

                entity.Property(e => e.Lineid).HasColumnName("lineid");

                entity.Property(e => e.MAd)
                    .IsUnicode(false)
                    .HasColumnName("mAd");

                entity.Property(e => e.Ozellikler1)
                    .IsUnicode(false)
                    .HasColumnName("ozellikler1");

                entity.Property(e => e.Ozellikler2).HasColumnName("ozellikler2");

                entity.Property(e => e.PazarYeri)
                    .IsUnicode(false)
                    .HasColumnName("pazarYeri");

                entity.Property(e => e.SiparisNo)
                    .IsUnicode(false)
                    .HasColumnName("siparisNo");

                entity.Property(e => e.SiparisTarihi)
                    .IsUnicode(false)
                    .HasColumnName("siparisTarihi");

                entity.Property(e => e.Sku)
                    .IsUnicode(false)
                    .HasColumnName("sku");

                entity.Property(e => e.SonGuncellemeTarihi)
                    .IsUnicode(false)
                    .HasColumnName("sonGuncellemeTarihi");

                entity.Property(e => e.Statu)
                    .IsUnicode(false)
                    .HasColumnName("statu");

                entity.Property(e => e.Tad)
                    .IsUnicode(false)
                    .HasColumnName("TAd");

                entity.Property(e => e.TelefonNo)
                    .IsUnicode(false)
                    .HasColumnName("telefonNo");
            });

            modelBuilder.Entity<TblOzellikler>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_ozellikler");

                entity.Property(e => e.AgirlikId).HasColumnName("agirlik_id");

                entity.Property(e => e.HacimId).HasColumnName("hacim_id");

                entity.Property(e => e.NumaraId).HasColumnName("numara_id");

                entity.Property(e => e.OzellikId).HasColumnName("ozellik_id");

                entity.Property(e => e.RenkId).HasColumnName("renk_id");

                entity.Property(e => e.Stok).HasColumnName("stok");

                entity.HasOne(d => d.Agirlik)
                    .WithMany()
                    .HasForeignKey(d => d.AgirlikId)
                    .HasConstraintName("FK_tbl_ozellikler_tbl_agirlik");

                entity.HasOne(d => d.AgirlikNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.AgirlikId)
                    .HasConstraintName("FK_tbl_ozellikler_tbl_hacim");

                entity.HasOne(d => d.Numara)
                    .WithMany()
                    .HasForeignKey(d => d.NumaraId)
                    .HasConstraintName("FK_tbl_ozellikler_tbl_numara");

                entity.HasOne(d => d.Ozellik)
                    .WithMany()
                    .HasForeignKey(d => d.OzellikId)
                    .HasConstraintName("FK_tbl_ozellikler_tbl_urun");

                entity.HasOne(d => d.Renk)
                    .WithMany()
                    .HasForeignKey(d => d.RenkId)
                    .HasConstraintName("FK_tbl_ozellikler_tbl_renk");
            });

            modelBuilder.Entity<TblPaketTemp>(entity =>
            {
                entity.HasKey(e => e.PaketId);

                entity.ToTable("tbl_paketTemp");

                entity.Property(e => e.PaketId).HasColumnName("paket_id");

                entity.Property(e => e.Adet).HasColumnName("adet");

                entity.Property(e => e.Barkod).HasColumnName("barkod");

                entity.Property(e => e.BasilmaDurumu).HasColumnName("basilmaDurumu");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Hbsku).HasColumnName("HBSKU");

                entity.Property(e => e.Il).HasColumnName("il");

                entity.Property(e => e.Ilçe).HasColumnName("ilçe");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.KargoFirmasi).HasColumnName("kargoFirmasi");

                entity.Property(e => e.KayitTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("kayitTarihi")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MAd).HasColumnName("mAd");

                entity.Property(e => e.Magaza)
                    .HasMaxLength(10)
                    .HasColumnName("magaza");

                entity.Property(e => e.PaketNo).HasColumnName("paketNo");

                entity.Property(e => e.PropertyValue).HasColumnName("property_value");

                entity.Property(e => e.Semt).HasColumnName("semt");

                entity.Property(e => e.SiparisNo).HasColumnName("siparisNo");

                entity.Property(e => e.TAd).HasColumnName("tAd");

                entity.Property(e => e.Tamadres).HasColumnName("tamadres");

                entity.Property(e => e.UrunAd).HasColumnName("urunAd");

                entity.Property(e => e.Uygulamabarkod)
                    .HasColumnName("uygulamabarkod")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VergiNo).HasColumnName("vergiNo");
            });

            modelBuilder.Entity<TblPaketTempTy>(entity =>
            {
                entity.HasKey(e => e.PaketId);

                entity.ToTable("tbl_paketTempTy");

                entity.Property(e => e.PaketId).HasColumnName("paket_id");

                entity.Property(e => e.Adet).HasColumnName("adet");

                entity.Property(e => e.Adres).HasColumnName("adres");

                entity.Property(e => e.Barkod).HasColumnName("barkod");

                entity.Property(e => e.Basilmadurumu).HasColumnName("basilmadurumu");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Il).HasColumnName("il");

                entity.Property(e => e.Ilçe).HasColumnName("ilçe");

                entity.Property(e => e.KargoFirmasi).HasColumnName("kargoFirmasi");

                entity.Property(e => e.Kayittarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("kayittarihi")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LinesSku).HasColumnName("linesSku");

                entity.Property(e => e.MAd).HasColumnName("mAd");

                entity.Property(e => e.Magaza)
                    .HasMaxLength(10)
                    .HasColumnName("magaza");

                entity.Property(e => e.Semt).HasColumnName("semt");

                entity.Property(e => e.SiparisNo).HasColumnName("siparisNo");

                entity.Property(e => e.Tamadres).HasColumnName("tamadres");

                entity.Property(e => e.Tysku).HasColumnName("TYSKU");

                entity.Property(e => e.UrunAd).HasColumnName("urunAd");

                entity.Property(e => e.VergiNo).HasColumnName("vergiNo");
            });

            modelBuilder.Entity<TblPicture>(entity =>
            {
                entity.HasKey(e => e.ResimId)
                    .HasName("PK_tbl_resim");

                entity.ToTable("tbl_picture");

                entity.Property(e => e.ResimId).HasColumnName("resim_id");

                entity.Property(e => e.Url1)
                    .IsUnicode(false)
                    .HasColumnName("url_1");

                entity.Property(e => e.Url10)
                    .IsUnicode(false)
                    .HasColumnName("url_10");

                entity.Property(e => e.Url2)
                    .IsUnicode(false)
                    .HasColumnName("url_2");

                entity.Property(e => e.Url3)
                    .IsUnicode(false)
                    .HasColumnName("url_3");

                entity.Property(e => e.Url4)
                    .IsUnicode(false)
                    .HasColumnName("url_4");

                entity.Property(e => e.Url5)
                    .IsUnicode(false)
                    .HasColumnName("url_5");

                entity.Property(e => e.Url6)
                    .IsUnicode(false)
                    .HasColumnName("url_6");

                entity.Property(e => e.Url7)
                    .IsUnicode(false)
                    .HasColumnName("url_7");

                entity.Property(e => e.Url8)
                    .IsUnicode(false)
                    .HasColumnName("url_8");

                entity.Property(e => e.Url9)
                    .IsUnicode(false)
                    .HasColumnName("url_9");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");
            });

            modelBuilder.Entity<TblPrice>(entity =>
            {
                entity.HasKey(e => e.FiyatId);

                entity.ToTable("tbl_price");

                entity.Property(e => e.FiyatId).HasColumnName("fiyat_id");

                entity.Property(e => e.FiyatHb)
                    .IsUnicode(false)
                    .HasColumnName("fiyatHb");

                entity.Property(e => e.FiyatTy)
                    .IsUnicode(false)
                    .HasColumnName("fiyatTy");

                entity.Property(e => e.UstuCiziliFiyatTy)
                    .IsUnicode(false)
                    .HasColumnName("ustuCiziliFiyatTy");
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.HasKey(e => e.UrunId);

                entity.ToTable("tbl_product");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.Adet)
                    .IsUnicode(false)
                    .HasColumnName("adet");

                entity.Property(e => e.Agirlik)
                    .IsUnicode(false)
                    .HasColumnName("agirlik");

                entity.Property(e => e.Attribute)
                    .IsUnicode(false)
                    .HasColumnName("attribute");

                entity.Property(e => e.AttributeNHb)
                    .IsUnicode(false)
                    .HasColumnName("attribute_nHb");

                entity.Property(e => e.BarcodeTy)
                    .IsUnicode(false)
                    .HasColumnName("barcodeTy");

                entity.Property(e => e.Barkod)
                    .IsUnicode(false)
                    .HasColumnName("barkod");

                entity.Property(e => e.BrandIdTy).HasColumnName("brandIdTy");

                entity.Property(e => e.CargoCompanyIdTy)
                    .IsUnicode(false)
                    .HasColumnName("cargoCompanyIdTy");

                entity.Property(e => e.CategoryId)
                    .IsUnicode(false)
                    .HasColumnName("categoryId");

                entity.Property(e => e.CurrencyTypeTy)
                    .IsUnicode(false)
                    .HasColumnName("currency_typeTy");

                entity.Property(e => e.DescreptionId).HasColumnName("descreption_id");

                entity.Property(e => e.FiyatId).HasColumnName("fiyat_id");

                entity.Property(e => e.GarantiSuresiHb)
                    .IsUnicode(false)
                    .HasColumnName("garantiSuresiHb");

                entity.Property(e => e.KargoId).HasColumnName("kargo_id");

                entity.Property(e => e.MarkaHb)
                    .IsUnicode(false)
                    .HasColumnName("markaHb");

                entity.Property(e => e.MerchantIdHb)
                    .IsUnicode(false)
                    .HasColumnName("merchantIdHb");

                entity.Property(e => e.ResimId).HasColumnName("resim_id");

                entity.Property(e => e.SaticiSku)
                    .IsUnicode(false)
                    .HasColumnName("saticiSku");

                entity.Property(e => e.UrunAdi)
                    .IsUnicode(false)
                    .HasColumnName("urunAdi");

                entity.Property(e => e.VaryantGrupIdHb)
                    .IsUnicode(false)
                    .HasColumnName("varyantGrupIdHb");

                entity.Property(e => e.VatRateTy)
                    .IsUnicode(false)
                    .HasColumnName("vatRateTy");

                entity.HasOne(d => d.Fiyat)
                    .WithMany(p => p.TblProducts)
                    .HasForeignKey(d => d.FiyatId)
                    .HasConstraintName("FK_tbl_product_tbl_price");

                entity.HasOne(d => d.Kargo)
                    .WithMany(p => p.TblProducts)
                    .HasForeignKey(d => d.KargoId)
                    .HasConstraintName("FK_tbl_product_tbl_cargo");

                entity.HasOne(d => d.Resim)
                    .WithMany(p => p.TblProducts)
                    .HasForeignKey(d => d.ResimId)
                    .HasConstraintName("FK_tbl_product_tbl_picture");
            });

            modelBuilder.Entity<TblProductHb>(entity =>
            {
                entity.HasKey(e => e.ProductHbId);

                entity.ToTable("tbl_productHb");

                entity.Property(e => e.ProductHbId).HasColumnName("productHb_id");

                entity.Property(e => e.Barcode).IsUnicode(false);

                entity.Property(e => e.CategoryId)
                    .IsUnicode(false)
                    .HasColumnName("categoryId");

                entity.Property(e => e.EbatlarVariantProperty)
                    .IsUnicode(false)
                    .HasColumnName("ebatlar_variant_property");

                entity.Property(e => e.EksikDurum).HasColumnName("eksikDurum");

                entity.Property(e => e.GarantiSuresi).IsUnicode(false);

                entity.Property(e => e.Image1).IsUnicode(false);

                entity.Property(e => e.Image2).IsUnicode(false);

                entity.Property(e => e.Image3).IsUnicode(false);

                entity.Property(e => e.Image4).IsUnicode(false);

                entity.Property(e => e.Image5).IsUnicode(false);

                entity.Property(e => e.KategoriTy)
                    .IsUnicode(false)
                    .HasColumnName("kategoriTy");

                entity.Property(e => e.Kg)
                    .IsUnicode(false)
                    .HasColumnName("kg");

                entity.Property(e => e.ListeFiyatiTy)
                    .IsUnicode(false)
                    .HasColumnName("listeFiyatiTy");

                entity.Property(e => e.Marka).IsUnicode(false);

                entity.Property(e => e.MarkaTy)
                    .IsUnicode(false)
                    .HasColumnName("markaTy");

                entity.Property(e => e.MaxFiyat)
                    .IsUnicode(false)
                    .HasColumnName("maxFiyat");

                entity.Property(e => e.Merchant)
                    .IsUnicode(false)
                    .HasColumnName("merchant");

                entity.Property(e => e.MerchantSku)
                    .IsUnicode(false)
                    .HasColumnName("merchantSku");

                entity.Property(e => e.MinFiyat)
                    .IsUnicode(false)
                    .HasColumnName("minFiyat");

                entity.Property(e => e.Price)
                    .IsUnicode(false)
                    .HasColumnName("price");

                entity.Property(e => e.RenkVariantProperty)
                    .IsUnicode(false)
                    .HasColumnName("renk_variant_property");

                entity.Property(e => e.SatisFiyatiTy)
                    .IsUnicode(false)
                    .HasColumnName("satisFiyatiTy");

                entity.Property(e => e.Stock)
                    .IsUnicode(false)
                    .HasColumnName("stock");

                entity.Property(e => e.TaxVatRate)
                    .IsUnicode(false)
                    .HasColumnName("tax_vat_rate");

                entity.Property(e => e.UrunAciklamasi).IsUnicode(false);

                entity.Property(e => e.UrunAdi).IsUnicode(false);

                entity.Property(e => e.VaryantGroupId)
                    .IsUnicode(false)
                    .HasColumnName("VaryantGroupID");
            });

            modelBuilder.Entity<TblProductsAltUrunHb>(entity =>
            {
                entity.HasKey(e => e.ProductHbsId);

                entity.ToTable("tbl_productsAltUrunHb");

                entity.Property(e => e.ProductHbsId).HasColumnName("productHbs_id");

                entity.Property(e => e.Barcode).IsUnicode(false);

                entity.Property(e => e.Durum).HasColumnName("durum");

                entity.Property(e => e.Durum2).HasColumnName("durum2");

                entity.Property(e => e.Fiyat)
                    .IsUnicode(false)
                    .HasColumnName("fiyat");

                entity.Property(e => e.MaxFiyat)
                    .IsUnicode(false)
                    .HasColumnName("maxFiyat");

                entity.Property(e => e.MerchantSku)
                    .IsUnicode(false)
                    .HasColumnName("merchantSku");

                entity.Property(e => e.MinFiyat)
                    .IsUnicode(false)
                    .HasColumnName("minFiyat");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductId2).HasColumnName("product_id2");

                entity.Property(e => e.Stok)
                    .IsUnicode(false)
                    .HasColumnName("stok");

                entity.Property(e => e.UrunAciklamasi)
                    .IsUnicode(false)
                    .HasColumnName("urunAciklamasi");

                entity.Property(e => e.UrunAdi)
                    .IsUnicode(false)
                    .HasColumnName("urunAdi");

                entity.Property(e => e.VaryantGroupId)
                    .IsUnicode(false)
                    .HasColumnName("VaryantGroupID");
            });

            modelBuilder.Entity<TblRenk>(entity =>
            {
                entity.HasKey(e => e.RenkId);

                entity.ToTable("tbl_renk");

                entity.Property(e => e.RenkId).HasColumnName("renk_id");

                entity.Property(e => e.Renk)
                    .HasMaxLength(25)
                    .HasColumnName("renk")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblSipari>(entity =>
            {
                entity.HasKey(e => e.SiparisId);

                entity.ToTable("tbl_siparis");

                entity.Property(e => e.SiparisId).HasColumnName("siparis_id");

                entity.Property(e => e.BasılmaDurum).HasColumnName("basılma_durum");

                entity.Property(e => e.ItemsCanCreatePackage).HasColumnName("items_canCreatePackage");

                entity.Property(e => e.ItemsCargoCompany).HasColumnName("items_cargoCompany");

                entity.Property(e => e.ItemsCargoCompanyModelId).HasColumnName("items_cargoCompanyModel_id");

                entity.Property(e => e.ItemsCargoCompanyModelLogoUrl).HasColumnName("items_cargoCompanyModel_logoUrl");

                entity.Property(e => e.ItemsCargoCompanyModelName).HasColumnName("items_cargoCompanyModel_name");

                entity.Property(e => e.ItemsCargoCompanyModelShortName).HasColumnName("items_cargoCompanyModel_shortName");

                entity.Property(e => e.ItemsCargoCompanyModelTrackingUrl).HasColumnName("items_cargoCompanyModel_trackingUrl");

                entity.Property(e => e.ItemsCommission).HasColumnName("items_commission");

                entity.Property(e => e.ItemsCommissionAmount).HasColumnName("items_commission_amount");

                entity.Property(e => e.ItemsCommissionCurrency).HasColumnName("items_commission_currency");

                entity.Property(e => e.ItemsCommissionType).HasColumnName("items_commissionType");

                entity.Property(e => e.ItemsCreditCardHolderName).HasColumnName("items_creditCardHolderName");

                entity.Property(e => e.ItemsCustomerName).HasColumnName("items_customerName");

                entity.Property(e => e.ItemsCustomizedText01).HasColumnName("items_customizedText01");

                entity.Property(e => e.ItemsCustomizedText02).HasColumnName("items_customizedText02");

                entity.Property(e => e.ItemsCustomizedText03).HasColumnName("items_customizedText03");

                entity.Property(e => e.ItemsCustomizedText04).HasColumnName("items_customizedText04");

                entity.Property(e => e.ItemsCustomizedTextX).HasColumnName("items_customizedTextX");

                entity.Property(e => e.ItemsDeliveryOptionId).HasColumnName("items_deliveryOptionId");

                entity.Property(e => e.ItemsDeliveryType).HasColumnName("items_deliveryType");

                entity.Property(e => e.ItemsDispatchTime).HasColumnName("items_dispatchTime");

                entity.Property(e => e.ItemsDueDate).HasColumnName("items_dueDate");

                entity.Property(e => e.ItemsId).HasColumnName("items_id");

                entity.Property(e => e.ItemsInvoice).HasColumnName("items_invoice");

                entity.Property(e => e.ItemsInvoiceAddress).HasColumnName("items_invoice_address");

                entity.Property(e => e.ItemsInvoiceAddressAddress).HasColumnName("items_invoice_address_address");

                entity.Property(e => e.ItemsInvoiceAddressAddressId).HasColumnName("items_invoice_address_addressId");

                entity.Property(e => e.ItemsInvoiceAddressAlternatePhoneNumber).HasColumnName("items_invoice_address_alternatePhoneNumber");

                entity.Property(e => e.ItemsInvoiceAddressCity).HasColumnName("items_invoice_address_city");

                entity.Property(e => e.ItemsInvoiceAddressCountryCode).HasColumnName("items_invoice_address_countryCode");

                entity.Property(e => e.ItemsInvoiceAddressDistrict).HasColumnName("items_invoice_address_district");

                entity.Property(e => e.ItemsInvoiceAddressEmail).HasColumnName("items_invoice_address_email");

                entity.Property(e => e.ItemsInvoiceAddressName).HasColumnName("items_invoice_address_name");

                entity.Property(e => e.ItemsInvoiceAddressPhoneNumber).HasColumnName("items_invoice_address_phoneNumber");

                entity.Property(e => e.ItemsInvoiceAddressTown).HasColumnName("items_invoice_address_town");

                entity.Property(e => e.ItemsInvoiceTaxNumber).HasColumnName("items_invoice_taxNumber");

                entity.Property(e => e.ItemsInvoiceTaxOffice).HasColumnName("items_invoice_taxOffice");

                entity.Property(e => e.ItemsInvoiceTurkishIdentityNumber).HasColumnName("items_invoice_turkishIdentityNumber");

                entity.Property(e => e.ItemsIsCancellable).HasColumnName("items_isCancellable");

                entity.Property(e => e.ItemsIsCancellableByHbAdmin).HasColumnName("items_isCancellableByHbAdmin");

                entity.Property(e => e.ItemsIsCustomized).HasColumnName("items_isCustomized");

                entity.Property(e => e.ItemsLastStatusUpdateDate).HasColumnName("items_lastStatusUpdateDate");

                entity.Property(e => e.ItemsMerchantId).HasColumnName("items_merchantId");

                entity.Property(e => e.ItemsOrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("items_orderDate");

                entity.Property(e => e.ItemsOrderId).HasColumnName("items_orderId");

                entity.Property(e => e.ItemsOrderNumber).HasColumnName("items_orderNumber");

                entity.Property(e => e.ItemsPaymentTermInDays).HasColumnName("items_paymentTermInDays");

                entity.Property(e => e.ItemsPickUpTime).HasColumnName("items_pickUpTime");

                entity.Property(e => e.ItemsPurchasePrice).HasColumnName("items_purchasePrice");

                entity.Property(e => e.ItemsQuantity).HasColumnName("items_quantity");

                entity.Property(e => e.ItemsSapNumber).HasColumnName("items_sapNumber");

                entity.Property(e => e.ItemsShippingAddress).HasColumnName("items_shippingAddress");

                entity.Property(e => e.ItemsSku).HasColumnName("items_sku");

                entity.Property(e => e.ItemsSlot).HasColumnName("items_slot");

                entity.Property(e => e.ItemsStatus).HasColumnName("items_status");

                entity.Property(e => e.ItemsTotalPriceAmount).HasColumnName("items_totalPrice_amount");

                entity.Property(e => e.ItemsTotalPriceCurrency).HasColumnName("items_totalPrice_currency");

                entity.Property(e => e.ItemsUnitPriceAmount).HasColumnName("items_unitPrice_amount");

                entity.Property(e => e.ItemsUnitPriceCurrency).HasColumnName("items_unitPrice_currency");

                entity.Property(e => e.ItemsVat).HasColumnName("items_vat");

                entity.Property(e => e.ItemsVatRate).HasColumnName("items_vatRate");

                entity.Property(e => e.KargolamaTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("kargolama_tarihi");

                entity.Property(e => e.Limit).HasColumnName("limit");

                entity.Property(e => e.Magaza)
                    .HasMaxLength(10)
                    .HasColumnName("magaza");

                entity.Property(e => e.Offset).HasColumnName("offset");

                entity.Property(e => e.PageCount).HasColumnName("pageCount");

                entity.Property(e => e.PaketlemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("paketleme_tarihi");

                entity.Property(e => e.PropertiesValue).HasColumnName("properties_value");

                entity.Property(e => e.TeslimedilmeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("teslimedilme_tarihi");

                entity.Property(e => e.TotalCount).HasColumnName("totalCount");

                entity.Property(e => e.Xml)
                    .HasColumnName("xml")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblSiparisTy>(entity =>
            {
                entity.HasKey(e => e.SiparisTyId);

                entity.ToTable("tbl_siparisTy");

                entity.Property(e => e.SiparisTyId).HasColumnName("siparisTy_id");

                entity.Property(e => e.AgreedDeliveryDate).IsUnicode(false);

                entity.Property(e => e.CargoProviderName).IsUnicode(false);

                entity.Property(e => e.CargoSenderNumber).IsUnicode(false);

                entity.Property(e => e.CargoTrackingLink).IsUnicode(false);

                entity.Property(e => e.CargoTrackingNumber).IsUnicode(false);

                entity.Property(e => e.Commercial).IsUnicode(false);

                entity.Property(e => e.CurrencyCode).IsUnicode(false);

                entity.Property(e => e.CustomerEmail).IsUnicode(false);

                entity.Property(e => e.CustomerFirstName).IsUnicode(false);

                entity.Property(e => e.CustomerId).IsUnicode(false);

                entity.Property(e => e.CustomerLastName).IsUnicode(false);

                entity.Property(e => e.DeliveredByService).IsUnicode(false);

                entity.Property(e => e.DeliveryAddressType).IsUnicode(false);

                entity.Property(e => e.DeliveryType).IsUnicode(false);

                entity.Property(e => e.Durum)
                    .IsUnicode(false)
                    .HasColumnName("durum");

                entity.Property(e => e.EstimatedDeliveryEndDate).IsUnicode(false);

                entity.Property(e => e.EstimatedDeliveryStartDate).IsUnicode(false);

                entity.Property(e => e.FastDelivery).IsUnicode(false);

                entity.Property(e => e.FastDeliveryType).IsUnicode(false);

                entity.Property(e => e.GrossAmount).IsUnicode(false);

                entity.Property(e => e.Id).IsUnicode(false);

                entity.Property(e => e.InvoiceAddressAddress1)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceAddress_Address1");

                entity.Property(e => e.InvoiceAddressAddress2)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceAddress_Address2");

                entity.Property(e => e.InvoiceAddressCity)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceAddress_City");

                entity.Property(e => e.InvoiceAddressCityCode)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceAddress_CityCode");

                entity.Property(e => e.InvoiceAddressCompany)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceAddress_Company");

                entity.Property(e => e.InvoiceAddressCountryCode)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceAddress_CountryCode");

                entity.Property(e => e.InvoiceAddressDistrict)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceAddress_District");

                entity.Property(e => e.InvoiceAddressDistrictId)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceAddress_DistrictId");

                entity.Property(e => e.InvoiceAddressFirstName)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceAddress_FirstName");

                entity.Property(e => e.InvoiceAddressFullAddress)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceAddress_FullAddress");

                entity.Property(e => e.InvoiceAddressFullName)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceAddress_FullName");

                entity.Property(e => e.InvoiceAddressId)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceAddress_Id");

                entity.Property(e => e.InvoiceAddressIsEinvoiceAvailable)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceAddress_IsEInvoiceAvailable");

                entity.Property(e => e.InvoiceAddressLastName)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceAddress_LastName");

                entity.Property(e => e.InvoiceAddressNeighborhood)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceAddress_Neighborhood");

                entity.Property(e => e.InvoiceAddressNeighborhoodId)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceAddress_NeighborhoodId");

                entity.Property(e => e.InvoiceAddressPhone)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceAddress_Phone");

                entity.Property(e => e.InvoiceAddressPostalCode)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceAddress_PostalCode");

                entity.Property(e => e.InvoiceAddressTaxNumber)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceAddress_TaxNumber");

                entity.Property(e => e.InvoiceAddressTaxOffice)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceAddress_TaxOffice");

                entity.Property(e => e.KayitTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("kayit_tarihi")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedDate).IsUnicode(false);

                entity.Property(e => e.LinesAmount)
                    .IsUnicode(false)
                    .HasColumnName("Lines_Amount");

                entity.Property(e => e.LinesBarcode)
                    .IsUnicode(false)
                    .HasColumnName("Lines_Barcode");

                entity.Property(e => e.LinesCurrencyCode)
                    .IsUnicode(false)
                    .HasColumnName("Lines_CurrencyCode");

                entity.Property(e => e.LinesDiscount)
                    .IsUnicode(false)
                    .HasColumnName("Lines_Discount");

                entity.Property(e => e.LinesId)
                    .IsUnicode(false)
                    .HasColumnName("Lines_Id");

                entity.Property(e => e.LinesMerchantId)
                    .IsUnicode(false)
                    .HasColumnName("Lines_MerchantId");

                entity.Property(e => e.LinesMerchantSku)
                    .IsUnicode(false)
                    .HasColumnName("Lines_MerchantSku");

                entity.Property(e => e.LinesOrderLineItemStatusName)
                    .IsUnicode(false)
                    .HasColumnName("Lines_OrderLineItemStatusName");

                entity.Property(e => e.LinesPrice)
                    .IsUnicode(false)
                    .HasColumnName("Lines_Price");

                entity.Property(e => e.LinesProductCode)
                    .IsUnicode(false)
                    .HasColumnName("Lines_ProductCode");

                entity.Property(e => e.LinesProductColor)
                    .IsUnicode(false)
                    .HasColumnName("Lines_ProductColor");

                entity.Property(e => e.LinesProductName)
                    .IsUnicode(false)
                    .HasColumnName("Lines_ProductName");

                entity.Property(e => e.LinesProductSize)
                    .IsUnicode(false)
                    .HasColumnName("Lines_ProductSize");

                entity.Property(e => e.LinesQuantity)
                    .IsUnicode(false)
                    .HasColumnName("Lines_Quantity");

                entity.Property(e => e.LinesSalesCampaignId)
                    .IsUnicode(false)
                    .HasColumnName("Lines_SalesCampaignId");

                entity.Property(e => e.LinesSku)
                    .IsUnicode(false)
                    .HasColumnName("Lines_Sku");

                entity.Property(e => e.LinesTyDiscount)
                    .IsUnicode(false)
                    .HasColumnName("Lines_TyDiscount");

                entity.Property(e => e.LinesVatBaseAmount)
                    .IsUnicode(false)
                    .HasColumnName("Lines_VatBaseAmount");

                entity.Property(e => e.MagazaAd)
                    .IsUnicode(false)
                    .HasColumnName("magazaAd");

                entity.Property(e => e.OrderDate).IsUnicode(false);

                entity.Property(e => e.OrderNumber).IsUnicode(false);

                entity.Property(e => e.OriginShipmentDate).IsUnicode(false);

                entity.Property(e => e.PackageHistoriesCreatedDate)
                    .IsUnicode(false)
                    .HasColumnName("PackageHistories_CreatedDate");

                entity.Property(e => e.PackageHistoriesStatus)
                    .IsUnicode(false)
                    .HasColumnName("PackageHistories_Status");

                entity.Property(e => e.ScheduledDeliveryStoreId).IsUnicode(false);

                entity.Property(e => e.ShipmentAddressAddress1)
                    .IsUnicode(false)
                    .HasColumnName("ShipmentAddress_Address1");

                entity.Property(e => e.ShipmentAddressAddress2)
                    .IsUnicode(false)
                    .HasColumnName("ShipmentAddress_Address2");

                entity.Property(e => e.ShipmentAddressCity)
                    .IsUnicode(false)
                    .HasColumnName("ShipmentAddress_City");

                entity.Property(e => e.ShipmentAddressCityCode)
                    .IsUnicode(false)
                    .HasColumnName("ShipmentAddress_CityCode");

                entity.Property(e => e.ShipmentAddressCompany)
                    .IsUnicode(false)
                    .HasColumnName("ShipmentAddress_Company");

                entity.Property(e => e.ShipmentAddressCountryCode)
                    .IsUnicode(false)
                    .HasColumnName("ShipmentAddress_CountryCode");

                entity.Property(e => e.ShipmentAddressDistrict)
                    .IsUnicode(false)
                    .HasColumnName("ShipmentAddress_District");

                entity.Property(e => e.ShipmentAddressDistrictId)
                    .IsUnicode(false)
                    .HasColumnName("ShipmentAddress_DistrictId");

                entity.Property(e => e.ShipmentAddressFirstName)
                    .IsUnicode(false)
                    .HasColumnName("ShipmentAddress_FirstName");

                entity.Property(e => e.ShipmentAddressFullAddress)
                    .IsUnicode(false)
                    .HasColumnName("ShipmentAddress_FullAddress");

                entity.Property(e => e.ShipmentAddressFullName)
                    .IsUnicode(false)
                    .HasColumnName("ShipmentAddress_FullName");

                entity.Property(e => e.ShipmentAddressId)
                    .IsUnicode(false)
                    .HasColumnName("ShipmentAddress_Id");

                entity.Property(e => e.ShipmentAddressLastName)
                    .IsUnicode(false)
                    .HasColumnName("ShipmentAddress_LastName");

                entity.Property(e => e.ShipmentAddressNeighborhood)
                    .IsUnicode(false)
                    .HasColumnName("ShipmentAddress_Neighborhood");

                entity.Property(e => e.ShipmentAddressNeighborhoodId)
                    .IsUnicode(false)
                    .HasColumnName("ShipmentAddress_NeighborhoodId");

                entity.Property(e => e.ShipmentAddressPhone)
                    .IsUnicode(false)
                    .HasColumnName("ShipmentAddress_Phone");

                entity.Property(e => e.ShipmentAddressPostalCode)
                    .IsUnicode(false)
                    .HasColumnName("ShipmentAddress_PostalCode");

                entity.Property(e => e.ShipmentPackageStatus).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.TaxNumber).IsUnicode(false);

                entity.Property(e => e.TcIdentityNumber).IsUnicode(false);

                entity.Property(e => e.TimeSlotId).IsUnicode(false);

                entity.Property(e => e.TotalDiscount).IsUnicode(false);

                entity.Property(e => e.TotalPrice).IsUnicode(false);

                entity.Property(e => e.TotalTyDiscount).IsUnicode(false);
            });

            modelBuilder.Entity<TblTyLink>(entity =>
            {
                entity.ToTable("tbl_tyLink");

                entity.HasComment("TRIAL");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("TRIAL");

                entity.Property(e => e.Barkod)
                    .IsUnicode(false)
                    .HasColumnName("barkod")
                    .HasComment("TRIAL");

                entity.Property(e => e.Durum)
                    .HasColumnName("durum")
                    .HasComment("TRIAL");

                entity.Property(e => e.Link)
                    .IsUnicode(false)
                    .HasColumnName("link")
                    .HasComment("TRIAL");
            });

            modelBuilder.Entity<TblUrun>(entity =>
            {
                entity.HasKey(e => e.UrunId);

                entity.ToTable("tbl_urun");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.Aciklama)
                    .HasColumnType("text")
                    .HasColumnName("aciklama");

                entity.Property(e => e.AltAd)
                    .HasMaxLength(50)
                    .HasColumnName("altAd");

                entity.Property(e => e.Barkod)
                    .HasMaxLength(20)
                    .HasColumnName("barkod");

                entity.Property(e => e.DurumId).HasColumnName("durum_id");

                entity.Property(e => e.EklemeTipi)
                    .HasMaxLength(50)
                    .HasColumnName("eklemeTipi");

                entity.Property(e => e.FaturaId).HasColumnName("fatura_id");

                entity.Property(e => e.KategoriId).HasColumnName("kategori_id");

                entity.Property(e => e.MFiyatId).HasColumnName("mFiyat_id");

                entity.Property(e => e.MarkaId).HasColumnName("marka_id");

                entity.Property(e => e.OzellikId).HasColumnName("ozellik_id");

                entity.Property(e => e.Stok).HasColumnName("stok");

                entity.Property(e => e.StokDurum).HasColumnName("stokDurum");

                entity.Property(e => e.UrunAd)
                    .HasMaxLength(50)
                    .HasColumnName("urunAd");

                entity.Property(e => e.UrunDurum).HasColumnName("urunDurum");

                entity.Property(e => e.UrunKdv).HasColumnName("urunKdv");

                entity.Property(e => e.UrunKodu)
                    .HasMaxLength(20)
                    .HasColumnName("urunKodu");

                entity.Property(e => e.VaryantBarkod)
                    .HasMaxLength(20)
                    .HasColumnName("varyantBarkod");

                entity.Property(e => e.Yil).HasColumnName("yil");

                entity.HasOne(d => d.Durum)
                    .WithMany(p => p.TblUruns)
                    .HasForeignKey(d => d.DurumId)
                    .HasConstraintName("FK_tbl_urun_tbl_durum");

                entity.HasOne(d => d.Fatura)
                    .WithMany(p => p.TblUruns)
                    .HasForeignKey(d => d.FaturaId)
                    .HasConstraintName("FK_tbl_urun_tbl_fatura");

                entity.HasOne(d => d.Kategori)
                    .WithMany(p => p.TblUruns)
                    .HasForeignKey(d => d.KategoriId)
                    .HasConstraintName("FK_tbl_urun_tbl_kategori");

                entity.HasOne(d => d.MFiyat)
                    .WithMany(p => p.TblUruns)
                    .HasForeignKey(d => d.MFiyatId)
                    .HasConstraintName("FK_tbl_urun_tbl_magazaFiyatlari");

                entity.HasOne(d => d.Marka)
                    .WithMany(p => p.TblUruns)
                    .HasForeignKey(d => d.MarkaId)
                    .HasConstraintName("FK_tbl_urun_tbl_marka");
            });

            modelBuilder.Entity<TblUrunHb>(entity =>
            {
                entity.HasKey(e => e.UrunId);

                entity.ToTable("tbl_urunHb");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.AvailableStock)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CargoCompany1)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CargoCompany2)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CargoCompany3)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ClaimAddressLabel)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CommissionRate)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CustomizableProperties)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DispatchTime)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.HepsiburadaSku)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsFrozen)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsLocked)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsSalable)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsSuspended)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.LockReasons)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MaximumPurchasableQuantity)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MerchantSku)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Price)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PriceDecreaseDisabled)
                    .HasMaxLength(10)
                    .HasColumnName("priceDecreaseDisabled")
                    .IsFixedLength();

                entity.Property(e => e.PriceIncreaseDisabled)
                    .HasMaxLength(10)
                    .HasColumnName("priceIncreaseDisabled")
                    .IsFixedLength();

                entity.Property(e => e.PricingAmount)
                    .HasMaxLength(10)
                    .HasColumnName("Pricing_Amount")
                    .IsFixedLength();

                entity.Property(e => e.PricingDebtor)
                    .HasMaxLength(10)
                    .HasColumnName("Pricing_Debtor")
                    .IsFixedLength();

                entity.Property(e => e.PricingEndDate)
                    .HasMaxLength(10)
                    .HasColumnName("Pricing_EndDate")
                    .IsFixedLength();

                entity.Property(e => e.PricingFinalPrice)
                    .HasMaxLength(10)
                    .HasColumnName("Pricing_FinalPrice")
                    .IsFixedLength();

                entity.Property(e => e.PricingStartDate)
                    .HasMaxLength(10)
                    .HasColumnName("Pricing_StartDate")
                    .IsFixedLength();

                entity.Property(e => e.ShippingAddressLabel)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ShippingProfileName)
                    .HasMaxLength(10)
                    .HasColumnName("shippingProfileName")
                    .IsFixedLength();

                entity.Property(e => e.StockDecreaseDisabled)
                    .HasMaxLength(10)
                    .HasColumnName("stockDecreaseDisabled")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblUrunHbb>(entity =>
            {
                entity.HasKey(e => e.UrunId);

                entity.ToTable("tbl_urunHbb");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.PriceDecreaseDisabled).HasColumnName("priceDecreaseDisabled");

                entity.Property(e => e.PriceIncreaseDisabled).HasColumnName("priceIncreaseDisabled");

                entity.Property(e => e.PricingAmount).HasColumnName("Pricing_Amount");

                entity.Property(e => e.PricingDebtor).HasColumnName("Pricing_Debtor");

                entity.Property(e => e.PricingEndDate).HasColumnName("Pricing_EndDate");

                entity.Property(e => e.PricingFinalPrice).HasColumnName("Pricing_FinalPrice");

                entity.Property(e => e.PricingStartDate).HasColumnName("Pricing_StartDate");

                entity.Property(e => e.ShippingProfileName).HasColumnName("shippingProfileName");

                entity.Property(e => e.StockDecreaseDisabled).HasColumnName("stockDecreaseDisabled");
            });

            modelBuilder.Entity<TblUrunTy>(entity =>
            {
                entity.HasKey(e => e.UruntyId);

                entity.ToTable("tbl_urunTy");

                entity.Property(e => e.UruntyId).HasColumnName("urunty_id");

                entity.Property(e => e.InvoiceAddressAddress1).HasColumnName("InvoiceAddress_Address1");

                entity.Property(e => e.InvoiceAddressAddress2).HasColumnName("InvoiceAddress_Address2");

                entity.Property(e => e.InvoiceAddressCity).HasColumnName("InvoiceAddress_City");

                entity.Property(e => e.InvoiceAddressCityCode).HasColumnName("InvoiceAddress_CityCode");

                entity.Property(e => e.InvoiceAddressCompany).HasColumnName("InvoiceAddress_Company");

                entity.Property(e => e.InvoiceAddressCountryCode).HasColumnName("InvoiceAddress_CountryCode");

                entity.Property(e => e.InvoiceAddressDistrict).HasColumnName("InvoiceAddress_District");

                entity.Property(e => e.InvoiceAddressDistrictId).HasColumnName("InvoiceAddress_DistrictId");

                entity.Property(e => e.InvoiceAddressFirstName).HasColumnName("InvoiceAddress_FirstName");

                entity.Property(e => e.InvoiceAddressFullAddress).HasColumnName("InvoiceAddress_FullAddress");

                entity.Property(e => e.InvoiceAddressFullName).HasColumnName("InvoiceAddress_FullName");

                entity.Property(e => e.InvoiceAddressId).HasColumnName("InvoiceAddress_Id");

                entity.Property(e => e.InvoiceAddressIsEinvoiceAvailable).HasColumnName("InvoiceAddress_IsEInvoiceAvailable");

                entity.Property(e => e.InvoiceAddressLastName).HasColumnName("InvoiceAddress_LastName");

                entity.Property(e => e.InvoiceAddressNeighborhood).HasColumnName("InvoiceAddress_Neighborhood");

                entity.Property(e => e.InvoiceAddressNeighborhoodId).HasColumnName("InvoiceAddress_NeighborhoodId");

                entity.Property(e => e.InvoiceAddressPhone).HasColumnName("InvoiceAddress_Phone");

                entity.Property(e => e.InvoiceAddressPostalCode).HasColumnName("InvoiceAddress_PostalCode");

                entity.Property(e => e.InvoiceAddressTaxNumber).HasColumnName("InvoiceAddress_TaxNumber");

                entity.Property(e => e.InvoiceAddressTaxOffice).HasColumnName("InvoiceAddress_TaxOffice");
            });

            modelBuilder.Entity<TblUrunler>(entity =>
            {
                entity.HasKey(e => e.UrunBarkod);

                entity.ToTable("Tbl_Urunler");

                entity.Property(e => e.UrunBarkod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Urun_Barkod");

                entity.Property(e => e.Kod)
                    .HasMaxLength(50)
                    .HasColumnName("kod");

                entity.Property(e => e.UrunAd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Urun_Ad");

                entity.Property(e => e.UrunFiyat).HasColumnName("Urun_Fiyat");

                entity.Property(e => e.UrunFoto)
                    .HasColumnType("text")
                    .HasColumnName("Urun_Foto");
            });

            modelBuilder.Entity<TblUrunlertolink>(entity =>
            {
                entity.ToTable("tbl_urunlertolink");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnaKategori).IsUnicode(false);

                entity.Property(e => e.Durum).HasColumnName("durum");

                entity.Property(e => e.EnAltKategori).IsUnicode(false);

                entity.Property(e => e.EnTemelKategori).IsUnicode(false);

                entity.Property(e => e.Fiyat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Kayitdurum).HasColumnName("kayitdurum");

                entity.Property(e => e.Marka).IsUnicode(false);

                entity.Property(e => e.Resimyol)
                    .IsUnicode(false)
                    .HasColumnName("resimyol");

                entity.Property(e => e.SaticiStokKodu).IsUnicode(false);

                entity.Property(e => e.Sku)
                    .IsUnicode(false)
                    .HasColumnName("SKU");

                entity.Property(e => e.UrunAdi)
                    .IsUnicode(false)
                    .HasColumnName("urunAdi");
            });

            modelBuilder.Entity<TblUrunsku>(entity =>
            {
                entity.HasKey(e => e.ÜrünId);

                entity.ToTable("tbl_urunsku");

                entity.Property(e => e.ÜrünId).HasColumnName("ürün_id");

                entity.Property(e => e.Durum).HasColumnName("durum");

                entity.Property(e => e.Hbsku).HasColumnName("hbsku");
            });

            modelBuilder.Entity<TblUruntosku>(entity =>
            {
                entity.ToTable("tbl_uruntosku");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Durum).HasColumnName("durum");

                entity.Property(e => e.Resimyol).HasColumnName("resimyol");

                entity.Property(e => e.Sku).HasColumnName("sku");

                entity.Property(e => e.Ürünad).HasColumnName("ürünad");
            });

            modelBuilder.Entity<TblVaryant>(entity =>
            {
                entity.HasKey(e => e.VaryantId);

                entity.ToTable("tbl_varyant");

                entity.Property(e => e.VaryantId).HasColumnName("varyant_id");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.OrderNumber).HasColumnName("order_number");

                entity.Property(e => e.PropertiesValue).HasColumnName("properties_value");
            });

            modelBuilder.Entity<TblÇop>(entity =>
            {
                entity.HasKey(e => e.PaketId);

                entity.ToTable("tbl_çop");

                entity.Property(e => e.PaketId).HasColumnName("paket_id");

                entity.Property(e => e.Adet).HasColumnName("adet");

                entity.Property(e => e.Barkod).HasColumnName("barkod");

                entity.Property(e => e.BasilmaDurumu).HasColumnName("basilmaDurumu");

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.Hbsku).HasColumnName("HBSKU");

                entity.Property(e => e.Il).HasColumnName("il");

                entity.Property(e => e.Ilçe).HasColumnName("ilçe");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.KargoFirmasi).HasColumnName("kargoFirmasi");

                entity.Property(e => e.KayitTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("kayitTarihi")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MAd).HasColumnName("mAd");

                entity.Property(e => e.Magaza)
                    .HasMaxLength(10)
                    .HasColumnName("magaza");

                entity.Property(e => e.PaketNo).HasColumnName("paketNo");

                entity.Property(e => e.PropertyValue).HasColumnName("property_value");

                entity.Property(e => e.Semt).HasColumnName("semt");

                entity.Property(e => e.SiparisNo).HasColumnName("siparisNo");

                entity.Property(e => e.TAd).HasColumnName("tAd");

                entity.Property(e => e.Tamadres).HasColumnName("tamadres");

                entity.Property(e => e.UrunAd).HasColumnName("urunAd");

                entity.Property(e => e.VergiNo).HasColumnName("vergiNo");
            });

            modelBuilder.Entity<TblÜrünkargoteslim>(entity =>
            {
                entity.ToTable("tbl_ürünkargoteslim");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Barkod).HasColumnName("barkod");

                entity.Property(e => e.Kargogönderimtarihi).HasColumnName("kargogönderimtarihi");

                entity.Property(e => e.Kullanici).HasColumnName("kullanici");

                entity.Property(e => e.Pazaryeri).HasColumnName("pazaryeri");

                entity.Property(e => e.Resimyol).HasColumnName("resimyol");

                entity.Property(e => e.Siparişnumarası).HasColumnName("siparişnumarası");
            });

            modelBuilder.Entity<TeslimEdilemeyenSiparisler>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK_TeslimEdilemeyenSiparisler_1");

                entity.ToTable("TeslimEdilemeyenSiparisler");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Lineitemid).HasColumnName("lineitemid");

                entity.Property(e => e.UndeliveredDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TeslimEdilenSiparisler>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK_TeslimEdilenSiparisler_1");

                entity.ToTable("TeslimEdilenSiparisler");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.DeliveredDate).HasColumnType("datetime");

                entity.Property(e => e.LineItemId).HasColumnName("lineItemId");
            });

            modelBuilder.Entity<TyOrder>(entity =>
            {
                entity.ToTable("tyOrders");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AgreedDeliveryDate).HasColumnName("agreedDeliveryDate");

                entity.Property(e => e.AgreedDeliveryDateExtendible).HasColumnName("agreedDeliveryDateExtendible");

                entity.Property(e => e.AgreedDeliveryExtensionEndDate).HasColumnName("agreedDeliveryExtensionEndDate");

                entity.Property(e => e.AgreedDeliveryExtensionStartDate).HasColumnName("agreedDeliveryExtensionStartDate");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Barcode).HasColumnName("barcode");

                entity.Property(e => e.CargoProviderName).HasColumnName("cargoProviderName");

                entity.Property(e => e.CargoSenderNumber).HasColumnName("cargoSenderNumber");

                entity.Property(e => e.CargoTrackingLink).HasColumnName("cargoTrackingLink");

                entity.Property(e => e.CargoTrackingNumber).HasColumnName("cargoTrackingNumber");

                entity.Property(e => e.Commercial).HasColumnName("commercial");

                entity.Property(e => e.CurrencyCode).HasColumnName("currencyCode");

                entity.Property(e => e.CustomerEmail).HasColumnName("customerEmail");

                entity.Property(e => e.CustomerFirstName).HasColumnName("customerFirstNAme");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.DeliveredByService).HasColumnName("deliveredByService");

                entity.Property(e => e.DeliveryAddressType).HasColumnName("deliveryAddressType");

                entity.Property(e => e.DeliveryType).HasColumnName("deliveryType");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.EstimatedDeliveryEndDate).HasColumnName("estimatedDeliveryEndDate");

                entity.Property(e => e.EstimatedDeliveryStartDate).HasColumnName("estimatedDeliveryStartDate");

                entity.Property(e => e.ExtendedAgreedDeliveryDate).HasColumnName("extendedAgreedDeliveryDate");

                entity.Property(e => e.FastDelivery).HasColumnName("fastDelivery");

                entity.Property(e => e.FastDeliveryType).HasColumnName("fastDeliveryType");

                entity.Property(e => e.GrossAmount).HasColumnName("grossAmount");

                entity.Property(e => e.InvoiceAdressFullAdress).HasColumnName("invoiceAdressFullAdress");

                entity.Property(e => e.InvoiceAdressFullName).HasColumnName("invoiceAdressFullNAme");

                entity.Property(e => e.LastModifiedDate).HasColumnName("lastModifiedDate");

                entity.Property(e => e.MerchantId).HasColumnName("merchantID");

                entity.Property(e => e.MerchantSku).HasColumnName("merchantSku");

                entity.Property(e => e.OrderLineItemStatusName).HasColumnName("orderLineItemStatusName");

                entity.Property(e => e.OrderNumber).HasColumnName("orderNumber");

                entity.Property(e => e.OriginShipmentDate).HasColumnName("originShipmentDate");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProductCode).HasColumnName("productCode");

                entity.Property(e => e.ProductColor).HasColumnName("productColor");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.ProductSize).HasColumnName("productSize");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.SalesCampaignId).HasColumnName("salesCampaignId");

                entity.Property(e => e.ScheduleDeliveryStoreId).HasColumnName("scheduleDeliveryStoreId");

                entity.Property(e => e.ShipmentAdressFullAdress).HasColumnName("shipmentAdressFullAdress");

                entity.Property(e => e.ShipmentAdressFullName).HasColumnName("shipmentAdressFullName");

                entity.Property(e => e.ShipmentPackageStatus).HasColumnName("shipmentPackageStatus");

                entity.Property(e => e.Sku).HasColumnName("sku");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TcIdentityNumber).HasColumnName("tcIdentityNumber");

                entity.Property(e => e.TimeSlotId).HasColumnName("timeSlotId");

                entity.Property(e => e.TotalDiscount).HasColumnName("totalDiscount");

                entity.Property(e => e.TotalPrice).HasColumnName("totalPrice");

                entity.Property(e => e.TotalTyDiscount).HasColumnName("totalTyDiscount");

                entity.Property(e => e.TyDiscount).HasColumnName("tyDiscount");

                entity.Property(e => e.VatBaseAmount).HasColumnName("vatBaseAmount");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.EmailVerifiedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("email_verified_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.RememberToken)
                    .HasMaxLength(100)
                    .HasColumnName("remember_token");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.HasSequence<int>("DBSequence").HasMax(35100);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
