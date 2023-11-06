# Temiz Mimari Şablonu

Bu proje şablonu, temiz mimari prensiplerine uygun olarak tasarlanmış bir yapıya sahiptir. Aşağıda proje yapısı ve katmanlar hakkında detaylı bilgi bulabilirsiniz.


## Proje Yapısı

- ***Common (Yardımcı Katman):***
> Farklı katmanlar arasında paylaşılan ortak işlevleri ve bileşenleri içeren bir katmandır. Bu katman, genellikle ortak yardımcı fonksiyonlar, veri yapıları, hata işleme mekanizmaları ve genel işlevler gibi bileşenleri içerir. Diğer katmanlara bağımlı olmayan ve bağımsız bir yapıda olmalıdır. Bu sayede, kod tekrarı azaltılabilir, bakımı kolaylaştırabilir ve genel uygulama performansı artırabilir.

- **Domain:** 
>  İş mantığını ve iş kurallarını içeren temel katmandır. Genellikle uygulamanın temel veri yapılarını ve iş mantığı modellerini barındırır. Bu katman, diğer katmanlara bağımlı olmayan ve bağımsız bir şekilde çalışan işlevlere sahiptir. Temel olarak, uygulamanın temel işlevselliğini sağlar ve iş kurallarını uygular. Bu katman, uygulamanın çekirdeğini oluşturur ve genellikle değişime en az bağlı olan katmanlardan biridir.

- ***Persistence (Yardımcı Katman):*** 
> Veritabanı işlemlerini ve veri kalıcılığını yönetmek için kullanılan bir yardımcı katmandır. Bu katman, genellikle Infrastructure katmanı altında bulunur ve veri tabanı erişimine ilişkin detayları içerir. Veri tabanı bağlantıları, sorgular ve veri eşleme işlemlerini yönetir. Diğer katmanlardan bağımsız çalışır ve uygulamanın veri tabanı işlemlerini diğer işlevlerden izole eder. Bu sayede, uygulamanın veritabanıyla iletişimi düzenlenir, bakımı kolaylaşır ve esneklik sağlanır.

- **Application:** 
> İş mantığını uygulayan ve temel işlemleri gerçekleştiren kodları içeren katmandır. Genellikle "Use Case" / "Kullanım Durumu" olarak da adlandırılır. Bu katman, "Domain" katmanından gelen iş mantığını kullanır ve genellikle kullanıcı taleplerini karşılamak için gerekli olan kullanım durumlarını içerir. Uygulamanın iş süreçlerini yönetir ve iş mantığını uygulamakla sorumludur. Bu katmanı, "Domain" katmanına bağlıdır ve dış katmanlardan bağımsız çalışır. Bu sayede, uygulamanın iş mantığı diğer katmanlardan izole edilir ve uygulamanın temel işlevselliği bu katmanda gerçekleştirilir.

- **Infrastructure:** 
> Dış kaynaklara erişim sağlamak ve dış bileşenlerle iletişim kurmak için kullanılan bir katmandır. Bu katman, genellikle veritabanı erişimi, ağ iletişimi, dış API'ler veya diğer harici kaynaklara erişim gibi detayları içerir. Dış sistemlere bağımlı olabilir, ancak iç katmanlara bağımlı olmamalıdır. "Infrastructure" katmanı, genellikle dış sistemlerle iletişimi yönetir ve dış kaynaklardan gelen veriyi işlemekle sorumludur. Bu katman, dış kaynaklara özgü ayrıntıları gizleyerek uygulamanın genel yapısını temiz tutar ve dış sistemlerle olan etkileşimi kolaylaştırır.

- **Presentation:** 
> Kullanıcı arayüzü bileşenlerini içeren katman. Temel görevi, bilgiyi kullanıcıya göstermek ve kullanıcı etkileşimlerini yönetmektir. Diğer katmanlarla iletişim halindedir ancak iş mantığı içermez. Bu katman, sistemle etkileşimi sağlar ve genellikle bir Web API, bir GUI veya bir CLI aracılığıyla gerçekleşir. "Application" katmanına ve "Infrastructure" katmanına bağımlıdır.

- ***Specification (Tests: Unit, Integretion, UI / Subcutaneous):*** 
> Temiz Mimari için testlerin organize edildiği bir katmandır. Bu katman, temiz bir test kurulumu, mantıklı test düzenlemesi ve okunabilir testler için tasarlanmıştır. Ayrıca, bu katman birim testleri, entegrasyon testlerini ve arayüz testleri yerine arayüz altı testlerini (Subcutaneous ) içerecek şekilde yapılandırılabilir. Temel olarak, bu katman testlerin düzenli, bakımı kolay ve anlaşılabilir olmasını sağlar. Her kullanım durumu için uygun test senaryolarının oluşturulmasını kolaylaştırarak, her kullanım durumu için beklenen girdi ve çıktıları belirleyerek, işlevlerin beklenen şekilde çalışıp çalışmadığını test etmeyi amaçlar.


## Katmanlar Arası İlişkiler

- ***Common (Yardımcı Katman):*** Tüm katmanlar tarafından kullanılabilir yardımcı araçlar sağlar.
- **Domain:** Diğer tüm katmanlarla bağımsızdır.
- **Application:** Domain katmanıyla etkileşim içindedir.
- ***Persistence (Yardımcı Katman):*** Domain katmanıyla doğrudan etkileşim içindedir. Application katmanıyla etkileşim içinde olabilir.
- **Infrastructure:** Diğer tüm katmanlarla iletişim halindedir.
- **Presentation:** Application ve Infrastrcture ile etkileşim içindedir. Persistence katmanıyla etkileşim içinde olabilir.
- ***Specification (Testler: Birim, Entegrasyon, Arayüz / Arayüz Altı Testi):*** Presentation dışındaki tüm katmanlar ile etkileşim içindedir.

Bu proje şablonu, katmanlı mimarinin en iyi uygulamalarını takip eder ve her bir katmanın belirli bir sorumluluğu olduğu bir yapı sağlar.