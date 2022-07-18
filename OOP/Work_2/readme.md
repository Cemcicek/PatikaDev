<h3>Ödev - Hayvanat Bahçesi</h3>

Bir hayvanat bahçesindeki hayvanlar hakkındaki bilgileri takip etmek için bir sistem tasarlıyorsunuz.<br>

Hayvanlar:<br>
Atlar (atlar, zebralar, eşekler vb.),<br>
Kedigiller (kaplanlar, aslanlar vb.),<br>
Kemirgenler (sıçanlar, kunduzlar vb.) gibi gruplardaki türlerle karakterize edilir.<br>

Hayvanlar hakkında depolanan bilgilerin çoğu tüm gruplamalar için aynıdır.<br>
tür adı, ağırlığı, yaşı vb.<br>

Sistem ayrıca her hayvan için belirli ilaçların dozajını alabilmeli => getDosage ()<br>

Sistem Yem verme zamanlarını hesaplayabilmelidir => getFeedSchedule ()<br>

Sistemin bu işlevleri yerine getirme mantığı, her gruplama için farklı olacaktır. Örneğin, atlar için yem verme algoritması farklı olup, kaplanlar için farklı olacaktır.<br>

Polimorfizm modelini kullanarak, yukarıda açıklanan durumu ele almak için bir sınıf diyagramı tasarlayın.<br>
