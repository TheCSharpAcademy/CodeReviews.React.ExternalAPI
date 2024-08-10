using ReactApp1.Server.Models;

namespace ReactApp1.Server.Data;

public class Seeder
{
    private ApplicationDbContext _context { get; set; }

    public Seeder(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task SeedDb()
    {
        var newPlace = new Place()
        {
            City = "Muğla",
            Name = "Ölü Deniz",
            ImageUrl = "https://www.gezimakinesi.com/wp-content/uploads/2018/07/%C3%B6l%C3%BCdeniz.jpg",
            Description = "Oludeniz is the archetypal picture-postcard beach backed by dramatic pine-clad hills. Literally translated as 'dead sea', the stunning lagoon is a protected area, ensuring that its natural beauty is preserved. There is a small entrance charge to use the lagoon beach and only non-motorised watersports are allowed. The main resort beach is a long stretch of coarse sand and shingle beach known as Belceğiz."
        };
        await _context.Places.AddAsync(newPlace);
        await _context.SaveChangesAsync();

        newPlace = new Place()
        {
            City = "Nevşehir",
            Name = "Cappadocia",
            ImageUrl = "https://www.kazdagitur.com/images/kapadokya-turu.jpg",
            Description = "As if plucked from a whimsical fairytale and set down upon the stark Anatolian plains, Cappadocia is a geological oddity of honeycombed hills and towering boulders of otherworldly beauty. The fantastical topography is matched by the human history here. People have long utilised the region's soft stone, seeking shelter underground and leaving the countryside scattered with fascinating cavern architecture. The fresco-adorned rock-cut churches of Göreme Open-Air Museum and the subterranean refuges of Derinkuyu and Kaymaklı are the most famous sights, while simply bedding down in one of Cappadocia's cave hotels is an experience in 21st-century cave living."
        };

        await _context.Places.AddAsync(newPlace);
        await _context.SaveChangesAsync();

        newPlace = new Place()
        {
            City = "Erzurum",
            Name = "Palandöken",
            ImageUrl = "https://www.gunaydingezginler.com/wp-content/uploads/2013/02/Palandoken-Map.jpg",
            Description = " The peak of Palandöken Mountains covering the southern part of Erzurum as an arc and locating only 10 kms away from Erzurum is Ejder Hill with 3271 mt altitude. With its high quality snow and long track, Palandöken is the favorite place of skiers and as a result of mass investments it has become a winter sports center. \r\nIn 2011, it hosted 25th World Universities’ Winter Games thanks to star hotels in the altitude of 2400 meters. In addition to the gondola-lift enabling players to coming to the peak, snow blowing system and lighting system helps skiers to ski every time. Palandöken turns into a bride with the beginning of snow in October and November and it’s covered with a rich flora after the melting of snow. With its clean air, sun light, flowers and butterflies Palandöken has unique and beatiful scenery and above its peak Ejder clouds always exist."
        };

        await _context.Places.AddAsync(newPlace);
        await _context.SaveChangesAsync();
        
        newPlace = new Place()
        {
            City = "İstanbul",
            Name = "Hagia Sophia Grand Mosque",
            ImageUrl = " https://cdn-imgix.headout.com/media/images/2235bf02e2ee0df7ea93f34d3cada1a6-Banner.jpg",
            Description = " The Hagia Sophia Grand Mosque / Ayasofya-i Kebir Cami-i Şerifi, with its innovative architecture, rich history, religious significance and extraordinary characteristics has been fighting against time for centuries, was the largest Eastern Roman Church in İstanbul. Constructed three times in the same location, it is the world’s oldest and fastest-completed cathedral. With its breathtaking domes that look like hanging in the air, monolithic marble columns and unparalleled mosaics, is one of the wonders of world’s architecture history. The sheer dazzling beauty of mosque with its magnificent play on space, light, and color provokes worship in the believer! Hagia Sophia pose on the ground of the first hill of İstanbul, precisely at the tip of the historic peninsula, surrounded by the Sea of Marmara, the Bosphorus and the Golden Horn on three sides."
        };

        await _context.Places.AddAsync(newPlace);
        await _context.SaveChangesAsync();

        newPlace = new Place()
        {
            City = "İzmir",
            Name = "Ephesus",
            ImageUrl = " https://www.planetware.com/photos-large/TR/turkey-library-facade-ephesus.jpg",
            Description = @"Not to be missed, the mighty ruin of Ephesus is a city of colossal monuments and marble-columned roads.

One of the most complete, still-standing famed cities of antiquity in the Mediterranean region, this is the place to experience what life must have been like during the golden age of the Roman Empire.

The city's history dates back to the 10th century BCE, but the major monuments you see today all date from its Roman era when it was a thriving commercial center.

In particular, the Library of Celsus, the complex of frescoed terraced houses, and the Great Theater all point to the wealth and importance of Ephesus during the Roman period.

A sightseeing trip here will take at least half a day to cover the major highlights and longer, if you really want to explore, so make sure you plan your visit so you don't feel rushed."
        };

        await _context.Places.AddAsync(newPlace);
        await _context.SaveChangesAsync();

        newPlace = new Place()
        {
            City = "İstanbul",
            Name = "The Blue Mosque",
            ImageUrl = " https://www.planetware.com/wpimages/2022/05/turkey-top-attractions-blue-mosque-interior.jpg",
            Description = @" This famous mosque (officially called the Sultanahmet Mosque), facing the Hagia Sophia Mosque across Sultanahmet Park in Istanbul, is one of Turkey's most visited monuments.

Built by Sultan Ahmed I, the mosque was designed to mimic the Hagia Sophia by the architect Sedefkar Mehmet Ağa, a disciple of the Ottoman era's most renowned architect, Sinan.

With six slender minarets and a sprawling courtyard complex, everything about the Blue Mosque is on a grand scale but it's best known for its prayer hall interior covered in tens of thousands of blue Iznik tiles (for which the mosque gained its moniker), lit by shards of light from 260 windows.

Non-worshipping visitors are welcome to visit outside of prayer times. Everyone must have knees and shoulders covered, and females must wear a headscarf."
        };

        await _context.Places.AddAsync(newPlace);
        await _context.SaveChangesAsync();

        newPlace = new Place()
        {
            City = "Trabzon",
            Name = "Sumela Monastery",
            ImageUrl = " https://media2.thrillophilia.com/images/photos/000/368/065/original/1614679611_shutterstock_1428562280.jpg?w=753&h=450&dpr=1.0",
            Description = @"Constructed back in the 4th century, Sumela Monastery is one of the world’s oldest monasteries. Situated outside Trabzon city, this beautiful monastery sits atop the majestic Zigana Mountain. Exhibiting a brilliant architectural design and dedicated to Virgin Mary, Sumela Monastery attracts spiritual seekers as well as architecture buffs.

The interior walls of this monastery are adorned with vibrant and elegant frescoes. The isolated setting and calm atmosphere of this place also allows visitors to practice peaceful meditation.
 "
        };

        await _context.Places.AddAsync(newPlace);
        await _context.SaveChangesAsync();

        newPlace = new Place()
        {
            City = "Adıyaman",
            Name = "Mount Nemrut",
            ImageUrl = " https://media2.thrillophilia.com/images/photos/000/368/066/original/1614679693_shutterstock_295734866.jpg?w=753&h=450&dpr=1.0",
            Description = @"Lying in Eastern Turkey, the breathtaking Mount Nemrut happens to be the monumental abode of King Antiochus I Theos of the Kingdom of Commagene. Considered to be the world’s 8th wonder, this place is packed with magnificent statues of King Antiochus I Theos and various Persian and Greek gods.

You can see magnificent stone heads of ancient gods perched on the arid mountaintop, amidst the mystic atmosphere. Some of the Greco-Persian deities you can spot in the course of your visit to the 2,150 meters high Mount Nemrut include Zeus Oromasdes, Apollo-Mithras-Helios-Hermes, Commagene-Tyche, and Heracles-Verethragna-Artagnes-Ares. "
        };

        await _context.Places.AddAsync(newPlace);
        await _context.SaveChangesAsync();


    }
}

