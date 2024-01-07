# Multiton Tasarım Deseni

## 🎯Nedir?

Multiton tasarım deseni, Singleton deseni ile benzerlik gösterir, ancak tek bir örneğin ötesine geçerek belirli bir anahtarla ilişkilendirilmiş birden fazla örneğin yönetilmesini sağlar. Her bir örnek, bir anahtarla ilişkilendirilir ve bu anahtar kullanılarak belirli bir örneğe erişim sağlanır.

## 🤔Neden kullanılır ?

Multiton tasarım deseni, belirli bağlamlar, durumlar veya anahtarlar altında farklı örneklerin yönetilmesi gerektiği durumlarda kullanılır. Tek bir türden sadece bir örneğin değil, belirli bir anahtarla ilişkilendirilmiş birden fazla örneğin oluşturulması ve yönetilmesi istendiğinde kullanışlıdır. Örneğin, bir konfigürasyon yöneticisi, farklı dosya türleri için ayrı ayrı konfigürasyon örneklerini yönetmek için Multiton deseni kullanabilir. Her bir dosya türü, belirli bir anahtarla ilişkilendirilmiş bir konfigürasyon örneğine sahip olabilir. Bu desen, tek bir örneğin genişletilmiş ve özelleştirilmiş versiyonlarının yönetilmesi gereken durumlarda veya bağlamın değiştiği durumlarda faydalı olabilir.
