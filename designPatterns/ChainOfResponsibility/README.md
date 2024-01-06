# Chain Of Responsibility Tasarım Deseni

## 🎯Nedir?

Chain of Responsibility tasarım deseni, bir dizi işleyici (handler) nesnesinin oluşturulup bu nesnelerin zincir şeklinde bağlanarak, bir isteğin başlatılması ve bu isteğin zincirdeki işleyiciler tarafından sırayla ele alınması prensibine dayanır. Bu desen, bir isteğin hangi işleyici tarafından ele alınacağını belirlemek ve bu işleyiciye iletmek için bir zincir oluşturur. Her bir işleyici, isteği ele alabilir veya ele alamazsa bir sonraki işleyiciye devreder. Bu şekilde, isteğin hangi işleyici tarafından işleneceği çalışma zamanında belirlenebilir ve işleyici zinciri kolayca genişletilebilir. Chain of Responsibility tasarım deseni, isteğin göndereni ve işleyenleri arasındaki sıkı bağımlılıkları azaltarak esnek bir yapı sağlar.

## 🤔Neden kullanılır ?

Chain of Responsibility tasarım deseni, bir isteğin birden fazla nesne tarafından sırayla ele alınması ve her bir nesnenin isteği işleyip işleyemeyeceğine karar vermesi gerektiği durumlarda kullanılır. Bu desen, bir isteğin belirli bir nesne tarafından doğrudan ele alınmasını istemiyorsak veya işleme sırasını dinamik olarak belirlemek istiyorsak özellikle uygun olabilir. Örneğin, bir dizi filtreleme işlemi uygulanacak ve her bir filtre belirli bir koşulu kontrol edecekse veya bir isteğin bir zincir içinde sırayla farklı seviyelerde ele alınması gerekiyorsa Chain of Responsibility deseni kullanışlı olabilir. Bu tasarım deseni, işleyicilerin dinamik olarak eklenebildiği ve çıkarılabildiği durumlarda da esneklik sağlar.
