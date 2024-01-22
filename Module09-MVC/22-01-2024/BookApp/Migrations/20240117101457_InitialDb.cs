using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookCategories",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategories", x => new { x.BookId, x.CategoryId });
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Abstract = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Stock = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    PageCount = table.Column<int>(type: "INTEGER", nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "getdate()"),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "getdate()"),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "getdate()"),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "getdate()"),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "BookId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 5 },
                    { 1, 10 },
                    { 2, 4 },
                    { 2, 13 },
                    { 3, 1 },
                    { 3, 5 },
                    { 3, 10 },
                    { 4, 1 },
                    { 4, 5 },
                    { 4, 10 },
                    { 5, 3 },
                    { 5, 5 },
                    { 5, 10 },
                    { 6, 3 },
                    { 6, 5 },
                    { 6, 10 },
                    { 7, 1 },
                    { 7, 5 },
                    { 8, 3 },
                    { 8, 5 },
                    { 8, 10 },
                    { 9, 7 },
                    { 9, 8 },
                    { 9, 12 },
                    { 10, 1 },
                    { 10, 5 },
                    { 10, 10 },
                    { 11, 1 },
                    { 11, 5 },
                    { 11, 10 },
                    { 12, 2 },
                    { 12, 6 },
                    { 12, 9 },
                    { 13, 5 },
                    { 13, 10 },
                    { 13, 11 },
                    { 14, 1 },
                    { 14, 5 },
                    { 14, 10 },
                    { 15, 13 },
                    { 15, 14 },
                    { 16, 4 },
                    { 16, 13 },
                    { 17, 5 },
                    { 17, 10 },
                    { 18, 5 },
                    { 18, 10 },
                    { 19, 1 },
                    { 19, 5 },
                    { 19, 10 },
                    { 20, 1 },
                    { 20, 3 },
                    { 20, 5 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Abstract", "CreatedDate", "ImageUrl", "IsActive", "IsDeleted", "IsHome", "ModifiedDate", "Name", "PageCount", "Price", "Stock", "Url" },
                values: new object[,]
                {
                    { 1, "'… İyi geceler. Ben prensi olmayan bir Külkedisi’yim. Tokyo’nun neresinde olduğumu biliyor musunuz? Beni bir daha görmeyeceksiniz.'\r\n\r\nYirminci yüzyıl Japon edebiyatının önde gelen yazarlarından, sıradışı hayatıyla da meşhur Osamu Dazai, savaş sonrası Japonya’sının edebiyat çevrelerince tanınmasını sağlayan, kaleme aldığı ilk eserlerden Öğrenci Kız’da Tokyo’nun banliyösünde yaşayan bir genç kızın on iki saatini ironik ve hünerli bir üslupla kaleme alıyor.\r\n\r\nİsimsiz genç kızın, nefret ettiği sabahlardan birine gözlerini açmasıyla başlayıp gece yatağa yattığı anda biten kısa romanda Dazai, artık yitmiş bir dönemin yaygın toplumsal normlarına karşı bireyin duyduğu huzursuzluğu, gençliğin ilk buhranları ve asiliğiyle birleştiriyor. \r\n\r\nÖğrenci Kız, Dazai’nin sonraki çoğu eserinde yer bulacak aykırı kişiliklerin ilk örneklerinden birini görmeyi ve yazarın zihninin derinliklerine yakından bakmayı sağlayacak bir klasik.", new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7240), "ogrenci-kiz.jpg", true, false, false, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7242), "Öğrenci Kız", 439, 90m, 4, "ogrenci-kiz-1" },
                    { 2, "Hayvanlardan Tanrılara: Sapiens kitabıyla insan türünün dünyaya nasıl egemen olduğunu anlatan Harari, Homo Deus’ta çarpıcı öngörüleriyle yarınımızı ele alıyor. İnsanlığın ölümsüzlük, mutluluk ve tanrısallık peşindeki yolculuğunu bilim, tarih ve felsefe ışığında incelediği bu çalışmasında, insanın bambaşka bir türe, Homo deus’a evrildiği bir gelecek kurguluyor.\r\n\r\nYola *önemsiz bir hayvan* olarak çıkan Homo sapiens, tanrılar katına ulaşmak uğruna kendi sonunu mu hazırlıyor?\r\n\r\nHomo sapiens nasıl oldu da evrenin insan türünün etrafında döndüğünü iddia eden hümanist öğretiye inandı?\r\n\r\nBu öğreti gündelik yaşantımızı, sanatımızı ve en gizli tutkularımızı nasıl şekillendiriyor?\r\n\r\nİnsanı inekler, tavuklar, şempanzeler ve bilgisayar programlarının tümünden ayıran yüksek zekası ve kudreti dışında herhangi bir alametifarikası var mı?\r\n\r\nTarih boyunca benzeri görülmemiş kazanımlar elde etmemize rağmen mutluluk seviyemizde neden kayda değer bir artış olmadı?\r\n\r\n*Tüm bunları anlamak için tek yapmamız gereken geriye dönüp bakmak ve Homo sapiens’in aslında ne olduğunu, hümanizmin nasıl dünyaya hakim bir din hâline geldiğini ve hümanizm rüyasını gerçekleştirmeye çalışmanın aslında neden insanlığın kendi sonunu getireceğini incelemektir. İşte bu kitabın temel meselesi budur.*\r\n\r\n*Okurken hem eğlenecek hem de çok şaşıracaksınız. Her şeyin ötesinde, kendinizi daha önce hiç düşünmediğiniz şeyleri düşünürken bulacaksınız.*\r\n\r\n- Daniel Kahneman, Hızlı ve Yavaş Düşünme’nin yazarı\r\n\r\n*Homo Deus’u okuduğunuzda uzun ve zorlu bir yolculuğun ardından vardığınız bir uçurumun kenarında durduğunuzu hissedeceksiniz. Yolculuğun artık bir önemi kalmayacak, çünkü bir sonraki adımınızı engin bir boşluğa atacaksınız.*", new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7251), "homo-deus-yarinin-kisa-bir-tarihi.jpg", true, false, false, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7252), "Homo Deus: Yarının Kısa Bir Tarihi", 308, 60m, 28, "homo-deus-yarinin-kisa-bir-tarihi-2" },
                    { 3, "Edebiyat tarihinin ilk distopyası olan Efendi Uyanıyor bir 19. yy. centilmeni olan Graham’ın öyküsünü anlatıyor. Nadir görülen bir uykusuzluk hastalığından mustarip olan Graham en sonunda uyumayı başarır. Ne var ki bu kez 200 yıllık trans halinde bir uykuya dalacaktır. Uyandığında ise, banka hesabına işleyen faizler sayesinde dünyanın en zengin ve en güçlü adamı olduğunu öğrenir. O artık bambaşka ve hiç tanımadığı bir dünyada yaşamaktadır. Dünyanın tek efendisi ve sahibi odur! Graham uyuduğu sırada servetini idare eden Konsey, tüm gezegene hüküm süren son derece karanlık ve acımasız bir sistem kurmuştur. Oysa insanların bir kurtarıcı olarak gördüğü Graham’dan beklenen, toplumu bu korkunç despotlardan kurtarmasıdır. Bir distopya klasiği ve politik bilimkurgu türünün en iyi örneklerinden biri olan Wells’in bu başyapıtı, okuru fantastik bir maceraya sürüklüyor. Günümüzden 114 yıl önce yazılmış olmasına rağmen global şirketlerin yükselişi, uçakların seyahat amaçlı kullanımı ve birçok teknolojik gelişmeyi zamanının çok ötesinde başarılı bir şekilde tahmin etmiş olması şaşkınlık yaratıyor. Geleceğe dair yerinde tahminlerinin yanı sıra toplumsal adaletsizlikle boğuşan bir dünyayı tasvir eden Efendi Uyanıyor, distopya, bilim kurgu ve politik roman hayranları için mükemmel bir seçim. \"Wells’in en çarpıcı yönü, edebiyatın klişeleşmiş yanlarına yeni bir soluk getirip canlılık katması...\" -The Spectator- \"Politik bilim-kurgu ve distopya severler için kaçırılmaması gereken bir eser...\" -Times Literary Supplement-", new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7254), "efendi-uyaniyor.jpg", true, false, true, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7254), "Efendi Uyanıyor", 417, 85m, 39, "efendi-uyaniyor-3" },
                    { 4, "Milliways Öğlen Menüsü, editörünün iznini alarak, Otostopçunun Galaksi Rehberi’nden bir pasaj aktarmaktaydı. Pasaj şöyleydi: Belli başlı her galaktik uygarlığın tarihi üç ayrı ve fark edilebilir aşamadan geçme eğilimindedir. Bu aşamalar Hayatta Kalma, Sorgulama ve İncelikli Düşünmedir; bir başka deyişle Nasıl, Neden ve Nerede aşamaları olarak da bilinirler. Örneğin, ilk aşama Nasıl Yiyebiliriz? sorusuyla, ikinci aşama Neden Yiyoruz? sorusuyla, üçüncü aşamaysa Öğle Yemeğini Nerede Yiyelim? sorusuyla tanımlanmaktadır.\r\n\r\nMenü daha sonra Milliways’in, Evrenin Sonundaki Restoran’ın bu üçüncü soruya çok uygun ve seçkin bir cevap olduğunu söylüyordu.\r\n\r\nAltın Kalp’in yolcuları sabahtan itibaren altı tamamen imkânsız işi başarmışken, günü gerçekten layık olduğu bir şekilde taçlandırmaya karar vermişlerdi: Gidilebilecek en iyi restoranda, seyredilebilecek en iyi manzaraya karşı mükellef bir yemek.\r\n\r\nBu arada gidiyoruz, ama aranızda rezervasyon yaptıran oldu mu?", new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7256), "evrenin-sonundaki-restoran.jpg", true, false, false, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7256), "Evrenin Sonundaki Restoran", 444, 90m, 13, "evrenin-sonundaki-restoran-4" },
                    { 5, "Ray Bradbury sadece bilimkurgunun değil fantastik edebiyatın ve korkunun da yirminci yüzyıldaki ustalarından biri. Bilimkurgunun *iyi edebiyat* da olabileceğini kanıtlayan belki de ilk yazar. Yayımlandığı anda klasikleşen, distopya edebiyatının dört temel kitabından biri olan Fahrenheit 451 ise bir yirminci yüzyıl başyapıtı.\r\n\r\nGuy Montag bir itfaiyeciydi. Televizyonun hüküm sürdüğü bu dünyada kitaplar ise yok olmak üzereydi zira itfaiyeciler yangın söndürmek yerine ortalığı ateşe veriyordu. Montag’ın işi ise yasadışı olanların en tehlikelisini yakmaktı: Kitapları.\r\n\r\nMontag yaptığı işi tek bir gün dahi sorgulamamıştı ve tüm gününü televizyonla kaplı odalarda geçiren eşi Mildred’la beraber yaşıyordu. Ancak yeni komşusu Clarisse’le tanışmasıyla tüm hayatı değişti. Kitapların değerini kavramaya başlayan Montag artık tüm bildiklerini sorgulayacaktı.\r\n\r\nİnsanların uğruna canlarını feda etmeyi göze aldığı bu kitapların içinde ne vardı?\r\nGerçeklerin farkına vardıktan sonra bu karanlık toplumda artık yaşanabilir miydi?\r\n\r\nFahrenheit 451, yeryüzünde tek bir kitap kalacak olsa, o kitap olmaya aday.", new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7258), "fahrenheit-451.jpg", true, false, true, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7258), "Fahrenheit 451", 307, 60m, 28, "fahrenheit-451-5" },
                    { 6, "1984 kitabı, İngiliz filozof ve yazar George Orwell tarafından kaleme alınmış, 1984 kitap konusu olarak 20. yüzyılın en önemli distopya örneklerinden biri olmuştur. George Orwell, 1948 yılında tamamladığı ve geleceğe dair karamsar bir kurgu geliştirerek gelecek hakkında insanlığı uyarmayı amaçlamıştır. Egemen sınıfa dayalı, totaliter, baskıcı bir yönetim anlayışının benimsendiği üç ayrı devletin egemenliğindeki siyasal düzenden bahsetmektedir. 1984 kitabı, günümüz ile geçmiş arasında gerçekçi bir benzerliklere dayandıran, dönemin okurlarını düşündürtüp hayal güçlerinin sınırlarını zorlamayı sağlayan distopik, alegorik, politik bir romandır.", new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7260), "bindokuzyuzseksendort-1984.jpg", true, false, true, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7260), "1984", 485, 95m, 16, "bindokuzyuzseksendort-1984-6" },
                    { 7, "H. G. Wells, bilimkurgunun atası, türe adını altın harflerle yazdırmış en büyük yazarlardan. Yazdığı bilim fantazileri nesiller boyu yazarları etkilemiş, onlara yol göstermiş; ilk basıldıkları dönemden itibaren etkilerini yitirmeden okurların gönlünde taht kurmaya devam etmiştir. Görünmez Adam da Wells’in eserleri içinde en akılda kalıcı olanlardan biri.\r\n\r\nTuhaf görünüşlü yabancı, bir tipi sırasında Iping Köyü’ne gelir. Garip hareketleri, giyinişi, suratının tamamının bandajlar içinde olması ve gözlüklerini bir an olsun gözünden çıkarmaması köy sakinleri tarafından kimi zaman şüpheyle, kimi zaman düşmanca karşılanır. Kısa süre içerisinde hakkındaki dedikodular giderek yoldan çıkan bir dizi olaya neden olacaktır.", new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7262), "gorunmez-adam.jpg", true, false, false, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7262), "Görünmez Adam", 139, 55m, 19, "gorunmez-adam-7" },
                    { 8, "Hayvan Çiftliği ya da orijinal ismiyle \"Animal Farm\", Eric Arthur Blair yani kitaplarını yazarken kullandığı ismiyle George Orwell’in mecazi bir dille kaleme aldığı ve ilk kez 1945 yılında Birleşik Krallık’ta yayımlan, 1996 tarihinde de Retro Hugo Ödülü’nü kazanan, fabl tarzındaki siyasi hiciv romanıdır. Stalinizmin eleştirildiği \"Hayvan Çiftliği\" romanı, SSCB’nin kuruluşundan itibaren meydana gelen önemli olayları kara mizah yoluyla anlatmaktadır. Yayımlandığında büyük bir ilgi uyandıran bu eser 1954 ve 1999 yıllarında filme uyarlanmış, Pink Floyd’un Animals albümüne ilham olmuştur. George Orwell’in tarihsel bir gerçeği eleştirdiği “Hayvan Çiftliği” eseri, Türkçeye ilk kez 1954 yılında çevrilmiştir.\r\n\r\nGeorge Orwell (25 Haziran 1903 - 21 Ocak 1950), asıl ismi Eric Arthur Blair olan ve oluşturduğu Big Brother (Büyük Birader) kavramı ile tanınan, gazetecilik ve eleştirmenlik de yapmış 20. yüzyıl İngiliz edebiyatının önde gelen yazarıdır. Kaleme aldığı eserleri birçok dile çevrilen, çağdaş klasikler arasında gösterilen George Orwell, “Hayvan Çiftliği” eserinde bir devrimin trajedisini dile getirmiştir.", new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7264), "hayvan-ciftligi.jpg", true, false, true, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7264), "Hayvan Çiftliği", 99, 45m, 26, "hayvan-ciftligi-8" },
                    { 9, "Bir hedef bulacaksınız, o uğurda çalışacaksınız, hedefinizi gerçekleştirmek için bir yol arayacaksınız, yol yoksa da o yolu yapacaksınız. Bir defa geçtiğiniz yoldan da bir daha geri dönmeyeceksiniz. Çünkü lüzumsuz geri dönüş başarısızlıktır, tekrara düşmektir, ufku kapatmaktır. Hedef bulmak, yol açmak ve aynı yoldan geri dönmemek… Hayattaki gayemiz budur.", new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7266), "insan-gelecegini-nasil-kurar.jpg", true, false, true, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7266), "İnsan Geleceğini Nasıl Kurar", 420, 119m, 13, "insan-gelecegini-nasil-kurar-9" },
                    { 10, "*Bu satırları okuyanlarınızın büyük çoğunluğunun, insanların bir mitten ibaret olduğuna inandığını biliyorum ama ben size onların gerçekten var olduklarını bildirmek üzere buradayım. Bilmeyenler için söyleyeyim, insan dediğimiz şey orta zekâlı ve iki ayaklı bir yaşam formu; evrenin çok ıssız bir köşesinde yer alan küçük ve sulu bir gezegende, büyük ölçüde yanılsamalarla dolu bir varoluş sürdürüyor.*\r\n\r\nYağmurlu bir akşamda Profesör Andrew Martin, önce dünyanın en büyük matematik bilmecesini çözmeyi başarıyor, ardından sırra kadem basıyor. Nihayet bir yol kenarında çırılçıplak halde bulunduğunda, kıyafetsizlikten daha ciddi bir meselesi olduğu ortaya çıkıyor: Andrew Martin artık insanlardan tiksiniyor; görünüşlerinden de yiyip içtiklerinden de bitmeyen şiddet ve savaş arzularından da... Yabancı bir tür arasında kaybolmuş hissediyor kendini. Sevgi ve aile kavramları onda şaşırtıcı bir ilgi uyandırsa da tüm sakinlerinden nefret ediyor bu gezegenin. Newton hariç... Ama o da bir köpek işte...", new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7268), "insanlar.jpg", true, false, true, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7268), "İnsanlar", 216, 75m, 40, "insanlar-10" },
                    { 11, "Charlotte Perkins Gilman yaşadığı dönemin önde gelen hümanistlerinden ve kadın hakları savunucularından biri olmasının yanında feminist edebiyatın en önemli erken dönem temsilcilerinden. Yazıldıktan yaklaşık 65 sene sonra kitap formatında yayımlanabilen Kadınlar Ülkesi ise feminist ütopyanın ilk örneklerinden.\r\n\r\nBirinci Dünya Savaşı’nın arifesinde üç Amerikalı erkek pek fazla insanın bulunmadığı, ücra bir yerde, tamamen kadınlardan oluşan bir topluluğa denk gelir. Gözlerine inanamayan kâşifler bu topraklarda erkeklerin de olması gerektiğine dair inançlarıyla araştırmalarına başlar.\r\n\r\nÇok geçmeden bu gizemli ülke ile ilgili gerçekler bir bir açığa çıksa da misafirlerin merakı giderilmenin aksine daha da artar ve Kadınlar Ülkesi’nin yönetim biçiminden inançlarına, kültüründen ekonomisine ve hatta anneliğe kadar pek çok konuda bilgi sahibi olmaya ve toplumsal cinsiyet rollerini sorgulamaya başlarlar.\r\n\r\nToplumsal roller cinsiyete göre belirlenebilir mi? Kadınlık ve erkeklik değişmez kavramlar mıdır?\r\n\r\nKadınlar Ülkesi, ataerkilliğe verilmiş nüktedan bir yanıt.", new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7270), "kadinlar-ulkesi.jpg", true, false, true, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7270), "Kadınlar Ülkesi", 315, 65m, 25, "kadinlar-ulkesi-11" },
                    { 12, "2016 yılının BBC Reith derslerinde Stephen Hawking, bütün bir ömür süren araştırmalarını on beş dakika içinde aktarma gibi gerçekten zorlu bir meydan okumayı kabul etti. Bu çok kısa süren derslerde Hawking, evrenin gizemlerini ortaya sererken, kara delikleri anladığımız takdirde uzayzamanın sırlarına erişebileceğimizi vurguluyor.", new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7272), "kara-delikler.jpg", true, false, false, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7272), "Kara Delikler", 439, 90m, 4, "kara-delikler-12" },
                    { 13, "\"Kumarbaz\" tüm varlığını, gücünü, yeteneğini rulet masasına yatıran; bilinmeyene, tehlikeye özlem duyan; hem başkaldıran, hem korkan; içinde binbir türlü çelişki barındıran kumara tutkun bir adamın romanı. Kendisi de bir süre kumarın tutsağı olan Dostoyevski, belki hiçbir romanına kendi yaşamından bu kadar çok şey katmamıştır. Hiçbir şey yazmasaydı bile \"Kumarbaz\" onu Dostoyevski yapmaya yeterdi.", new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7274), "kumarbaz.jpg", true, false, false, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7274), "Kumarbaz", 417, 85m, 10, "kumarbaz-13" },
                    { 14, " “Son” denilen nükleer felaketten sonra anne ve oğul arasında kurulan geçmişi ve o günü kapsayan ancak sınırları olan bir ilişkinin kapısından içeri girerken; ilacın, elektriğin, kalabalığın, cep telefonlarının ve günümüze ait hiçbir gerecin olmadığı bir dünyaya adım atacaksınız. Hayatta kalma güdüsü, yalnızlık\r\nve ölüm temalarıyla öne çıkan, Galceye özgü akıcı ve güçlü tasvirlerle ilerleyen Nebo’nun Mavi Kitabı; günümüz insanının doğadan ne kadar kopuk yaşadığını da  gözler önüne seriyor.\r\n \r\nManon Steffan Ros “ekolojik distopya” temeline dayanan,\r\nödüllü ve çoksatan romanında, insanın hayatta kalma içgüdüsüyle birlikte, çağdaş dünya düzenini de sorguluyor.", new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7276), "nebonun-mavi-kitabi.jpg", true, false, true, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7276), "Nebo'nun Mavi Kitabı", 582, 115m, 29, "nebonun-mavi-kitabi-14" },
                    { 15, "Ey Türk gençliği! Birinci görevin, Türk bağımsızlığını, Türk Cumhuriyeti’ni sonsuza kadar korumak ve savunmaktır. Varlığının ve geleceğinin tek temeli budur. Bu temel, senin en değerli hazinendir. Gelecekte de, seni bu hazineden yoksun bırakmak isteyecek iç ve dış düşmanların olacaktır. Bir gün, bağımsızlık ve cumhuriyeti savunma zorunluluğuna düşersen, göreve atılmak için, içinde bulunacağın durumun olanak ve koşullarını düşünmeyeceksin!", new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7278), "nutuk.jpg", true, false, true, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7278), "Nutuk", 332, 65m, 34, "nutuk-15" },
                    { 16, "Çoğu çalışma insanlığın serüvenini ya tarihi ya da biyolojik bir yaklaşımla ele alır, ancak Harari 70 bin yıl önce gerçekleşen Bilişsel Devrim’le başlattığı bu kitabında gelenekleri yerle bir ediyor. İnsanların küresel ekosistemde oynadıkları rolden imparatorlukların yükselişine ve modern dünyaya kadar pek çok konuyu irdeleyen Sapiens, tarihle bilimi bir araya getirerek kabul görmüş anlatıları yeniden ele alıyor. Harari ayrıca geleceğe bakmaya da zorluyor okuru. Yakın zamanda insanlar, dört milyar yıldır yaşama hükmeden doğal seçilim yasalarını esnetmeye başladılar. Artık sadece dünyayı değil, kendimizi ve diğer canlıları tasarlama becerisi de kazandık. Peki bu bizi nereye götürüyor, bizi neye dönüştürebilir?", new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7280), "hayvanlardan-tanrilara-sapiens.jpg", true, false, true, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7281), "Hayvanlardan Tanrılara Sapiens", 639, 160m, 32, "hayvanlardan-tanrilara-sapiens-16" },
                    { 17, "Savaş ve Barış, gençlere dünya klasiklerini tanıtarak, onları bu eserleri okumaya yönlendirmek amacıyla hazırladığımız Arkadaş Dünya Klasikleri Gençlik Özet Dizisi’nin üçüncü kitabıdır. Genç okurların kolayca anlayarak beğeniyle okuyabileceği yalın bir Türkçeyle orijinal metinden uyarlanmıştır.\r\n\r\nTolstoy’un başyapıtı olan Savaş ve Barış, dünya edebiyatının en önemli eserlerindendir ve Milli Eğitim Bakanlığınca 100 Temel eser kapsamında öğrencilere tavsiye edilmiştir.", new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7282), "savas-ve-baris.jpg", true, false, true, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7283), "Savaş ve Barış", 239, 85m, 14, "savas-ve-baris-14" },
                    { 18, "Kaç Ömür Gerek, Yaşamayı Öğrenmek İçin?\r\n\r\nTom Hazard’ın tehlikeli bir sırrı var. 41 yaşında sıradan bir tarih öğretmeni gibi göru¨nse de nadir rastlanan bir hastalık yu¨zu¨nden aslında yu¨zyıllardır hayatta. Shakespeare’le aynı sahnede yer almış, Kaptan Cook’la açık denizleri fethetmiş, Fitzgerald’larla içki içmiş. Ama şimdi, tek istediği normal bir hayat su¨rmek. Kimliğini değiştirmeye devam ettiği su¨rece geçmişini geride bırakabilir ve hayatta kalabilir.\r\n\r\nYapmaması gereken tek bir şey var, aşık olmak.", new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7284), "zamani-durdurmanin-yollari.jpg", true, false, true, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7284), "Zamanı Durdurmanın Yolları", 329, 80m, 5, "zamani-durdurmanin-yollari-15" },
                    { 19, "*Yaşamla ölüm arasında bir kütüphane var,* dedi. *Bu kütüphanedeki raflar sonsuza kadar gider.  Her kitap yaşamış olabileceğin başka bir hayatı yaşama şansını sunar sana. Farklı seçimler yapmış olsan, şu an nasıl bir hayatın olacağını görürsün…\r\nPişmanlıklarını telafi etme şansın olsaydı, bazı konularda farklı davranır mıydın?*\r\n\r\nNora Seed berbat halde. Kedisi öldü. İşinden kovuldu. Abisi onunla konuşmuyor. Kimsenin ona ihtiyacı yok. Art arda alınmış kötü kararların sonucunda bir kütüphanede buluyor kendini. Zamanın hiç akmadığı bir gece yarısı kütüphanesinde, sonsuz sayıda kitabın ortasında... Kitapların her birinde Nora’nın farklı bir hayatı yazılı. Başka kararlar verseydi yaşamış olabileceği hayatlar.\r\n\r\nFarklı kariyerler, farklı eşler, farklı arkadaşlar, farklı şehirler arasında gidip gelen Nora’nın aklı sorularla doluyor. Mutluluk sadece önemli sandığımız seçimlerde mi gizli? Yanlış giden her detayın sorumlusu gerçekten biz miyiz? Hayatı yaşanılır kılan ne? Yanlış bir karar insanın tüm hayatına mal olabilir mi?", new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7286), "gece-yarisi-kutuphanesi.jpg", true, false, true, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7286), "Gece Yarısı Kütüphanesi", 512, 100m, 32, "gece-yarisi-kutuphanesi-16" },
                    { 20, "Dünyayı pençesine almış bir delilik salgını...\r\n\r\nKonuşma yoluyla, zihinden zihne bulaşarak yayılan bir hastalık...\r\n\r\nYıkılmanın eşiğine gelmiş uygarlık...\r\n\r\nVaktiyle bu amansız hastalık üzerine çalışmış eski dilbilimci Murat Siyavuş, umutsuzluk içinde annesinin evine sığınmıştır. Acımasız bir devlet kurumunun peşine düştüğünü öğrenince, evden çıkıp hayata karışmak ve salgının dönüştürdüğü dünyayla yüzleşmek zorunda kalır.", new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7288), "sicak-kafa.jpg", true, false, true, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(7288), "Sıcak Kafa", 285, 90m, 40, "sicak-kafa-20" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5960), "Genel kategorisine giren ve kategorisiz kalan kitaplar", true, false, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5976), "Genel", "Genel" },
                    { 2, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5981), "Bilim Kurgu Kitapları", true, false, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5982), "Bilim Kurgu", "bilim-kurgu" },
                    { 3, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5983), "Bilim ve Mühendislik Kitapları", true, false, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5984), "Bilim ve Mühendislik", "bilim-ve-muhendislik" },
                    { 4, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5985), "Distopya Kitapları", true, false, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5985), "Distopya", "distopya" },
                    { 5, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5986), "Dünya Tarihi Kitapları", true, false, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5987), "Dünya Tarihi", "dunya-tarihi" },
                    { 6, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5988), "Edebiyat Kitapları", true, false, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5988), "Edebiyat", "edebiyat" },
                    { 7, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5989), "Fizik Kitapları", true, false, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5990), "Fizik", "fizik" },
                    { 8, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5991), "İnsan ve Toplum Kitapları", true, false, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5991), "İnsan ve Toplum", "insan-ve-toplum" },
                    { 9, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5992), "Kişisel Kitapları", true, false, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5993), "Kişisel Gelişim", "kisisel-gelisim" },
                    { 10, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5993), "Popüler Bilim Kitapları", true, false, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5994), "Popüler Bilim", "populer-bilim" },
                    { 11, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5995), "Romanlar", true, false, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5995), "Roman", "roman" },
                    { 12, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5996), "Rus Edebiyatı Kitapları", true, false, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5996), "Rus Edebiyatı", "rus-edebiyati" },
                    { 13, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5997), "Söyleşi Kitapları", true, false, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5998), "Söyleşi", "soylesi" },
                    { 14, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5999), "Tarih Kitapları", true, false, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(5999), "Tarih", "tarih" },
                    { 15, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(6025), "Türkiye Tarihi Kitapları", true, false, new DateTime(2024, 1, 17, 13, 14, 57, 544, DateTimeKind.Local).AddTicks(6025), "Türkiye Tarihi", "turkiye-tarihi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCategories");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
