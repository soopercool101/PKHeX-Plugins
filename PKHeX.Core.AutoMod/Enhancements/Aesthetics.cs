﻿using System;
using System.Collections.Generic;
using System.Linq;
using static PKHeX.Core.Ball;
using static PKHeX.Core.Species;
using static PKHeX.Core.AutoMod.Aesthetics.PersonalColor;

namespace PKHeX.Core.AutoMod
{
    public static class Aesthetics
    {
        private static readonly Dictionary<Species, PersonalColor> ShinyMap = new()
        {
            { Bulbasaur,       Green },
            { Ivysaur,         Green },
            { Venusaur,        Green },
            { Charmander,      Yellow },
            { Charmeleon,      Yellow },
            { Charizard,       Black },
            { Squirtle,        Blue },
            { Wartortle,       Purple },
            { Blastoise,       Purple },
            { Caterpie,        Yellow },
            { Metapod,         Red },
            { Butterfree,      Purple },
            { Weedle,          Yellow },
            { Kakuna,          Green },
            { Beedrill,        Green },
            { Pidgey,          Brown },
            { Pidgeotto,       Yellow },
            { Pidgeot,         Yellow },
            { Rattata,         Green },
            { Raticate,        Red },
            { Spearow,         Green },
            { Fearow,          Green },
            { Ekans,           Green },
            { Arbok,           Yellow },
            { Pikachu,         Yellow },
            { Raichu,          Yellow },
            { Sandshrew,       Green },
            { Sandslash,       Red },
            { NidoranF,        Purple },
            { Nidorina,        Purple },
            { Nidoqueen,       Green },
            { NidoranM,        Blue },
            { Nidorino,        Blue },
            { Nidoking,        Blue },
            { Clefairy,        Pink },
            { Clefable,        Pink },
            { Vulpix,          Yellow },
            { Ninetales,       White },
            { Jigglypuff,      Pink },
            { Wigglytuff,      Pink },
            { Zubat,           Green },
            { Golbat,          Green },
            { Oddish,          Green },
            { Gloom,           Green },
            { Vileplume,       Green },
            { Paras,           Red },
            { Parasect,        Red },
            { Venonat,         Purple },
            { Venomoth,        Blue },
            { Diglett,         Brown },
            { Dugtrio,         Brown },
            { Meowth,          White },
            { Persian,         White },
            { Psyduck,         Blue },
            { Golduck,         Blue },
            { Mankey,          Green },
            { Primeape,        White },
            { Growlithe,       Yellow },
            { Arcanine,        Yellow },
            { Poliwag,         Blue },
            { Poliwhirl,       Blue },
            { Poliwrath,       Green },
            { Abra,            Yellow },
            { Kadabra,         Yellow },
            { Alakazam,        Yellow },
            { Machop,          Brown },
            { Machoke,         Green },
            { Machamp,         Green },
            { Bellsprout,      Yellow },
            { Weepinbell,      Yellow },
            { Victreebel,      Yellow },
            { Tentacool,       Blue },
            { Tentacruel,      Blue },
            { Geodude,         Yellow },
            { Graveler,        Brown },
            { Golem,           Brown },
            { Ponyta,          Blue },
            { Rapidash,        Black },
            { Slowpoke,        Pink },
            { Slowbro,         Purple },
            { Magnemite,       Gray },
            { Magneton,        Gray },
            { Farfetchd,       Pink },
            { Doduo,           Green },
            { Dodrio,          Green },
            { Seel,            White },
            { Dewgong,         White },
            { Grimer,          Green },
            { Muk,             Green },
            { Shellder,        Red },
            { Cloyster,        Blue },
            { Gastly,          Purple },
            { Haunter,         Purple },
            { Gengar,          Purple },
            { Onix,            Green },
            { Drowzee,         Pink },
            { Hypno,           Pink },
            { Krabby,          Yellow },
            { Kingler,         Green },
            { Voltorb,         Blue },
            { Electrode,       Blue },
            { Exeggcute,       Yellow },
            { Exeggutor,       Red },
            { Cubone,          Green },
            { Marowak,         Green },
            { Hitmonlee,       Green },
            { Hitmonchan,      Green },
            { Lickitung,       Yellow },
            { Koffing,         Green },
            { Weezing,         Green },
            { Rhyhorn,         Red },
            { Rhydon,          Gray },
            { Chansey,         Green },
            { Tangela,         Green },
            { Kangaskhan,      Brown },
            { Horsea,          Blue },
            { Seadra,          Blue },
            { Goldeen,         White },
            { Seaking,         Red },
            { Staryu,          Yellow },
            { Starmie,         Blue },
            { MrMime,          White },
            { Scyther,         Green },
            { Jynx,            Pink },
            { Electabuzz,      Yellow },
            { Magmar,          Red },
            { Pinsir,          Purple },
            { Tauros,          Green },
            { Magikarp,        Yellow },
            { Gyarados,        Red },
            { Lapras,          Purple },
            { Ditto,           Blue },
            { Eevee,           White },
            { Vaporeon,        Purple },
            { Jolteon,         Green },
            { Flareon,         Yellow },
            { Porygon,         Pink },
            { Omanyte,         Purple },
            { Omastar,         Purple },
            { Kabuto,          Green },
            { Kabutops,        Green },
            { Aerodactyl,      Purple },
            { Snorlax,         Blue },
            { Articuno,        Blue },
            { Zapdos,          Yellow },
            { Moltres,         Red },
            { Dratini,         Pink },
            { Dragonair,       Pink },
            { Dragonite,       Green },
            { Mewtwo,          White },
            { Mew,             Blue },
            { Chikorita,       Green },
            { Bayleef,         Red },
            { Meganium,        Green },
            { Cyndaquil,       Brown },
            { Quilava,         Brown },
            { Typhlosion,      Brown },
            { Totodile,        Blue },
            { Croconaw,        Blue },
            { Feraligatr,      Blue },
            { Sentret,         Yellow },
            { Furret,          Pink },
            { Hoothoot,        Yellow },
            { Noctowl,         Brown },
            { Ledyba,          Red },
            { Ledian,          Red },
            { Spinarak,        Blue },
            { Ariados,         Pink },
            { Crobat,          Pink },
            { Chinchou,        Blue },
            { Lanturn,         Purple },
            { Pichu,           Yellow },
            { Cleffa,          Pink },
            { Igglybuff,       Pink },
            { Togepi,          White },
            { Togetic,         White },
            { Natu,            Green },
            { Xatu,            Green },
            { Mareep,          Pink },
            { Flaaffy,         Pink },
            { Ampharos,        Pink },
            { Bellossom,       Purple },
            { Marill,          Green },
            { Azumarill,       Yellow },
            { Sudowoodo,       Brown },
            { Politoed,        Blue },
            { Hoppip,          Green },
            { Skiploom,        Pink },
            { Jumpluff,        Red },
            { Aipom,           Red },
            { Sunkern,         Yellow },
            { Sunflora,        Yellow },
            { Yanma,           Blue },
            { Wooper,          Pink },
            { Quagsire,        Pink },
            { Espeon,          Green },
            { Umbreon,         Black },
            { Murkrow,         Purple },
            { Slowking,        Purple },
            { Misdreavus,      Green },
            { Unown,           Blue },
            { Wobbuffet,       Pink },
            { Girafarig,       Yellow },
            { Pineco,          Yellow },
            { Forretress,      Yellow },
            { Dunsparce,       Yellow },
            { Gligar,          Blue },
            { Steelix,         Yellow },
            { Snubbull,        Purple },
            { Granbull,        Pink },
            { Qwilfish,        Pink },
            { Scizor,          Green },
            { Shuckle,         Blue },
            { Heracross,       Pink },
            { Sneasel,         Pink },
            { Teddiursa,       Green },
            { Ursaring,        Green },
            { Slugma,          Gray },
            { Magcargo,        Pink },
            { Swinub,          Green },
            { Piloswine,       Yellow },
            { Corsola,         Blue },
            { Remoraid,        Purple },
            { Octillery,       Brown },
            { Delibird,        Purple },
            { Mantine,         Blue },
            { Skarmory,        Brown },
            { Houndour,        Blue },
            { Houndoom,        Blue },
            { Kingdra,         Purple },
            { Phanpy,          Blue },
            { Donphan,         Red },
            { Porygon2,        Blue },
            { Stantler,        Green },
            { Smeargle,        Yellow },
            { Tyrogue,         Brown },
            { Hitmontop,       Brown },
            { Smoochum,        Pink },
            { Elekid,          Yellow },
            { Magby,           Red },
            { Miltank,         Blue },
            { Blissey,         Pink },
            { Raikou,          Yellow },
            { Entei,           Brown },
            { Suicune,         Blue },
            { Larvitar,        Green },
            { Pupitar,         Purple },
            { Tyranitar,       Brown },
            { Lugia,           White },
            { HoOh,            Yellow },
            { Celebi,          Pink },
            { Treecko,         Green },
            { Grovyle,         Green },
            { Sceptile,        Green },
            { Torchic,         Yellow },
            { Combusken,       Yellow },
            { Blaziken,        Red },
            { Mudkip,          Purple },
            { Marshtomp,       Purple },
            { Swampert,        Purple },
            { Poochyena,       Yellow },
            { Mightyena,       Yellow },
            { Zigzagoon,       Red },
            { Linoone,         Red },
            { Wurmple,         Purple },
            { Silcoon,         Yellow },
            { Beautifly,       Yellow },
            { Cascoon,         Green },
            { Dustox,          Brown },
            { Lotad,           Red },
            { Lombre,          Green },
            { Ludicolo,        Yellow },
            { Seedot,          Red },
            { Nuzleaf,         Red },
            { Shiftry,         Red },
            { Taillow,         Red },
            { Swellow,         Red },
            { Wingull,         White },
            { Pelipper,        Green },
            { Ralts,           Blue },
            { Kirlia,          White },
            { Gardevoir,       White },
            { Surskit,         Black },
            { Masquerain,      Green },
            { Shroomish,       Red },
            { Breloom,         Red },
            { Slakoth,         Pink },
            { Vigoroth,        White },
            { Slaking,         Brown },
            { Nincada,         Yellow },
            { Ninjask,         Yellow },
            { Shedinja,        Yellow },
            { Whismur,         Purple },
            { Loudred,         Purple },
            { Exploud,         Purple },
            { Makuhita,        Yellow },
            { Hariyama,        Purple },
            { Azurill,         Green },
            { Nosepass,        Yellow },
            { Skitty,          Red },
            { Delcatty,        Red },
            { Sableye,         Yellow },
            { Mawile,          Black },
            { Aron,            White },
            { Lairon,          Gray },
            { Aggron,          Gray },
            { Meditite,        Red },
            { Medicham,        Blue },
            { Electrike,       Blue },
            { Manectric,       Black },
            { Plusle,          Red },
            { Minun,           Green },
            { Volbeat,         Purple },
            { Illumise,        Blue },
            { Roselia,         Green },
            { Gulpin,          Blue },
            { Swalot,          Blue },
            { Carvanha,        Green },
            { Sharpedo,        Purple },
            { Wailmer,         Purple },
            { Wailord,         Purple },
            { Numel,           Yellow },
            { Camerupt,        Black },
            { Torkoal,         Red },
            { Spoink,          Yellow },
            { Grumpig,         Black },
            { Spinda,          Green },
            { Trapinch,        Green },
            { Vibrava,         Red },
            { Flygon,          Green },
            { Cacnea,          Red },
            { Cacturne,        Red },
            { Swablu,          Yellow },
            { Altaria,         Yellow },
            { Zangoose,        White },
            { Seviper,         Black },
            { Lunatone,        Yellow },
            { Solrock,         Red },
            { Barboach,        Blue },
            { Whiscash,        Blue },
            { Corphish,        Red },
            { Crawdaunt,       Red },
            { Baltoy,          Yellow },
            { Claydol,         Black },
            { Lileep,          Green },
            { Cradily,         Red },
            { Anorith,         Brown },
            { Armaldo,         Red },
            { Feebas,          Purple },
            { Milotic,         Blue },
            { Castform,        Purple },
            { Kecleon,         Green },
            { Shuppet,         Blue },
            { Banette,         Black },
            { Duskull,         Red },
            { Dusclops,        Red },
            { Tropius,         Green },
            { Chimecho,        Blue },
            { Absol,           Red },
            { Wynaut,          Purple },
            { Snorunt,         Blue },
            { Glalie,          White },
            { Spheal,          Purple },
            { Sealeo,          Purple },
            { Walrein,         Purple },
            { Clamperl,        Purple },
            { Huntail,         Green },
            { Gorebyss,        Yellow },
            { Relicanth,       Blue },
            { Luvdisc,         Yellow },
            { Bagon,           Green },
            { Shelgon,         Green },
            { Salamence,       Green },
            { Beldum,          Gray },
            { Metang,          Gray },
            { Metagross,       Gray },
            { Regirock,        Red },
            { Regice,          Blue },
            { Registeel,       Black },
            { Latias,          Yellow },
            { Latios,          Green },
            { Kyogre,          Purple },
            { Groudon,         Green },
            { Rayquaza,        Black },
            { Jirachi,         Yellow },
            { Deoxys,          Yellow },
            { Turtwig,         Blue },
            { Grotle,          Blue },
            { Torterra,        Green },
            { Chimchar,        Red },
            { Monferno,        Red },
            { Infernape,       Red },
            { Piplup,          Blue },
            { Prinplup,        Blue },
            { Empoleon,        Blue },
            { Starly,          Brown },
            { Staravia,        Brown },
            { Staraptor,       Brown },
            { Bidoof,          Yellow },
            { Bibarel,         Yellow },
            { Kricketot,       Yellow },
            { Kricketune,      Yellow },
            { Shinx,           Yellow },
            { Luxio,           Yellow },
            { Luxray,          Black },
            { Budew,           Green },
            { Roserade,        Green },
            { Cranidos,        Red },
            { Rampardos,       Red },
            { Shieldon,        Black },
            { Bastiodon,       Black },
            { Burmy,           Green },
            { Wormadam,        Green },
            { Mothim,          Yellow },
            { Combee,          Red },
            { Vespiquen,       Red },
            { Pachirisu,       Pink },
            { Buizel,          Yellow },
            { Floatzel,        Yellow },
            { Cherubi,         Red },
            { Cherrim,         Green },
            { Shellos,         Blue },
            { Gastrodon,       Blue },
            { Ambipom,         Pink },
            { Drifloon,        Yellow },
            { Drifblim,        Yellow },
            { Buneary,         Red },
            { Lopunny,         Red },
            { Mismagius,       Green },
            { Honchkrow,       Purple },
            { Glameow,         Purple },
            { Purugly,         Purple },
            { Chingling,       Yellow },
            { Stunky,          Red },
            { Skuntank,        Red },
            { Bronzor,         Green },
            { Bronzong,        Green },
            { Bonsly,          Brown },
            { MimeJr,          Pink },
            { Happiny,         Pink },
            { Chatot,          Black },
            { Spiritomb,       Blue },
            { Gible,           Blue },
            { Gabite,          Blue },
            { Garchomp,        Black },
            { Munchlax,        Blue },
            { Riolu,           Yellow },
            { Lucario,         Yellow },
            { Hippopotas,      Yellow },
            { Hippowdon,       Yellow },
            { Skorupi,         Red },
            { Drapion,         Red },
            { Croagunk,        Blue },
            { Toxicroak,       Blue },
            { Carnivine,       Green },
            { Finneon,         Black },
            { Lumineon,        Black },
            { Mantyke,         Blue },
            { Snover,          White },
            { Abomasnow,       White },
            { Weavile,         Pink },
            { Magnezone,       Gray },
            { Lickilicky,      Yellow },
            { Rhyperior,       Yellow },
            { Tangrowth,       Green },
            { Electivire,      Yellow },
            { Magmortar,       Red },
            { Togekiss,        White },
            { Yanmega,         Blue },
            { Leafeon,         Yellow },
            { Glaceon,         Blue },
            { Gliscor,         Blue },
            { Mamoswine,       Brown },
            { PorygonZ,        Blue },
            { Gallade,         Blue },
            { Probopass,       Yellow },
            { Dusknoir,        Black },
            { Froslass,        White },
            { Rotom,           Red },
            { Uxie,            Yellow },
            { Mesprit,         Red },
            { Azelf,           Blue },
            { Dialga,          Green },
            { Palkia,          Pink },
            { Heatran,         Red },
            { Regigigas,       Blue },
            { Giratina,        Blue },
            { Cresselia,       Purple },
            { Phione,          Blue },
            { Manaphy,         Blue },
            { Darkrai,         Black },
            { Shaymin,         Green },
            { Arceus,          Yellow },
            { Victini,         White },
            { Snivy,           Green },
            { Servine,         Green },
            { Serperior,       Green },
            { Tepig,           Yellow },
            { Pignite,         Red },
            { Emboar,          Blue },
            { Oshawott,        Blue },
            { Dewott,          Blue },
            { Samurott,        Blue },
            { Patrat,          Brown },
            { Watchog,         Red },
            { Lillipup,        Yellow },
            { Herdier,         Yellow },
            { Stoutland,       Yellow },
            { Purrloin,        Blue },
            { Liepard,         Red },
            { Pansage,         Green },
            { Simisage,        Green },
            { Pansear,         Red },
            { Simisear,        Red },
            { Panpour,         Blue },
            { Simipour,        Blue },
            { Munna,           Yellow },
            { Musharna,        Purple },
            { Pidove,          Gray },
            { Tranquill,       Green },
            { Unfezant,        Brown },
            { Blitzle,         Blue },
            { Zebstrika,       Black },
            { Roggenrola,      Purple },
            { Boldore,         Purple },
            { Gigalith,        Blue },
            { Woobat,          Green },
            { Swoobat,         Yellow },
            { Drilbur,         Red },
            { Excadrill,       Red },
            { Audino,          Purple },
            { Timburr,         Yellow },
            { Gurdurr,         Yellow },
            { Conkeldurr,      Red },
            { Tympole,         Yellow },
            { Palpitoad,       Blue },
            { Seismitoad,      Blue },
            { Throh,           Red },
            { Sawk,            Blue },
            { Sewaddle,        Green },
            { Swadloon,        Green },
            { Leavanny,        Green },
            { Venipede,        Red },
            { Whirlipede,      Purple },
            { Scolipede,       Red },
            { Cottonee,        Yellow },
            { Whimsicott,      White },
            { Petilil,         Yellow },
            { Lilligant,       Yellow },
            { Basculin,        Green },
            { Sandile,         Yellow },
            { Krokorok,        Brown },
            { Krookodile,      Brown },
            { Darumaka,        Red },
            { Darmanitan,      Red },
            { Maractus,        Green },
            { Dwebble,         Red },
            { Crustle,         Green },
            { Scraggy,         Yellow },
            { Scrafty,         Green },
            { Sigilyph,        Black },
            { Yamask,          Blue },
            { Cofagrigus,      Gray },
            { Tirtouga,        Blue },
            { Carracosta,      Blue },
            { Archen,          Red },
            { Archeops,        Yellow },
            { Trubbish,        Blue },
            { Garbodor,        Brown },
            { Zorua,           Black },
            { Zoroark,         Black },
            { Minccino,        Red },
            { Cinccino,        Brown },
            { Gothita,         Red },
            { Gothorita,       Black },
            { Gothitelle,      Black },
            { Solosis,         Green },
            { Duosion,         Green },
            { Reuniclus,       Blue },
            { Ducklett,        Pink },
            { Swanna,          White },
            { Vanillite,       White },
            { Vanillish,       White },
            { Vanilluxe,       White },
            { Deerling,        Pink },
            { Sawsbuck,        Yellow },
            { Emolga,          White },
            { Karrablast,      Green },
            { Escavalier,      Gray },
            { Foongus,         Blue },
            { Amoonguss,       Blue },
            { Frillish,        Blue },
            { Jellicent,       Blue },
            { Alomomola,       Purple },
            { Joltik,          Yellow },
            { Galvantula,      Yellow },
            { Ferroseed,       Gray },
            { Ferrothorn,      Yellow },
            { Klink,           Gray },
            { Klang,           Gray },
            { Klinklang,       Yellow },
            { Tynamo,          White },
            { Eelektrik,       Yellow },
            { Eelektross,      Green },
            { Elgyem,          Blue },
            { Beheeyem,        Red },
            { Litwick,         White },
            { Lampent,         Black },
            { Chandelure,      Red },
            { Axew,            Brown },
            { Fraxure,         Black },
            { Haxorus,         Black },
            { Cubchoo,         White },
            { Beartic,         White },
            { Cryogonal,       Blue },
            { Shelmet,         Yellow },
            { Accelgor,        Yellow },
            { Stunfisk,        Yellow },
            { Mienfoo,         Blue },
            { Mienshao,        Pink },
            { Druddigon,       Green },
            { Golett,          Gray },
            { Golurk,          Gray },
            { Pawniard,        Blue },
            { Bisharp,         Blue },
            { Bouffalant,      Red },
            { Rufflet,         Brown },
            { Braviary,        Blue },
            { Vullaby,         Red },
            { Mandibuzz,       Red },
            { Heatmor,         Red },
            { Durant,          Gray },
            { Deino,           Green },
            { Zweilous,        Green },
            { Hydreigon,       Green },
            { Larvesta,        Yellow },
            { Volcarona,       Yellow },
            { Cobalion,        Blue },
            { Terrakion,       Red },
            { Virizion,        Red },
            { Tornadus,        Green },
            { Thundurus,       Blue },
            { Reshiram,        White },
            { Zekrom,          Black },
            { Landorus,        Yellow },
            { Kyurem,          Black },
            { Keldeo,          Green },
            { Meloetta,        Green },
            { Genesect,        Red },
            { Chespin,         Red },
            { Quilladin,       Red },
            { Chesnaught,      Green },
            { Fennekin,        Gray },
            { Braixen,         Purple },
            { Delphox,         Purple },
            { Froakie,         Blue },
            { Frogadier,       Blue },
            { Greninja,        Black },
            { Bunnelby,        Gray },
            { Diggersby,       Gray },
            { Fletchling,      Red },
            { Fletchinder,     Red },
            { Talonflame,      Red },
            { Scatterbug,      White },
            { Spewpa,          Gray },
            { Vivillon,        Red },
            { Litleo,          Red },
            { Pyroar,          Red },
            { Flabébé,         White },
            { Floette,         White },
            { Florges,         Purple },
            { Skiddo,          Green },
            { Gogoat,          Green },
            { Pancham,         Black },
            { Pangoro,         Black },
            { Furfrou,         Black },
            { Espurr,          Pink },
            { Meowstic,        Yellow },
            { Honedge,         Red },
            { Doublade,        Red },
            { Aegislash,       Red },
            { Spritzee,        Purple },
            { Aromatisse,      Purple },
            { Swirlix,         Yellow },
            { Slurpuff,        Yellow },
            { Inkay,           Brown },
            { Malamar,         Brown },
            { Binacle,         Blue },
            { Barbaracle,      Blue },
            { Skrelp,          Purple },
            { Dragalge,        Purple },
            { Clauncher,       Red },
            { Clawitzer,       Red },
            { Helioptile,      Red },
            { Heliolisk,       Red },
            { Tyrunt,          Blue },
            { Tyrantrum,       Blue },
            { Amaura,          White },
            { Aurorus,         White },
            { Sylveon,         Blue },
            { Hawlucha,        Black },
            { Dedenne,         Brown },
            { Carbink,         Black },
            { Goomy,           Yellow },
            { Sliggoo,         Yellow },
            { Goodra,          Yellow },
            { Klefki,          Yellow },
            { Phantump,        Gray },
            { Trevenant,       Gray },
            { Pumpkaboo,       Purple },
            { Gourgeist,       Purple },
            { Bergmite,        Blue },
            { Avalugg,         Blue },
            { Noibat,          Blue },
            { Noivern,         Blue },
            { Xerneas,         Blue },
            { Yveltal,         Red },
            { Zygarde,         White },
            { Diancie,         Pink },
            { Hoopa,           Yellow },
            { Volcanion,       Yellow },
            { Rowlet,          Green },
            { Dartrix,         Green },
            { Decidueye,       Black },
            { Litten,          White },
            { Torracat,        White },
            { Incineroar,      White },
            { Popplio,         Blue },
            { Brionne,         Blue },
            { Primarina,       Blue },
            { Pikipek,         Black },
            { Trumbeak,        Black },
            { Toucannon,       Black },
            { Yungoos,         Brown },
            { Gumshoos,        Brown },
            { Grubbin,         Red },
            { Charjabug,       Red },
            { Vikavolt,        Gray },
            { Crabrawler,      Purple },
            { Crabominable,    White },
            { Oricorio,        Black },
            { Cutiefly,        Pink },
            { Ribombee,        Pink },
            { Rockruff,        Blue },
            { Lycanroc,        Blue },
            { Wishiwashi,      Blue },
            { Mareanie,        Red },
            { Toxapex,         Red },
            { Mudbray,         Yellow },
            { Mudsdale,        Yellow },
            { Dewpider,        Purple },
            { Araquanid,       Purple },
            { Fomantis,        Green },
            { Lurantis,        Green },
            { Morelull,        Brown },
            { Shiinotic,       Brown },
            { Salandit,        White },
            { Salazzle,        White },
            { Stufful,         Yellow },
            { Bewear,          Yellow },
            { Bounsweet,       Red },
            { Steenee,         Purple },
            { Tsareena,        Purple },
            { Comfey,          Blue },
            { Oranguru,        Pink },
            { Passimian,       Blue },
            { Wimpod,          Red },
            { Golisopod,       White },
            { Sandygast,       Black },
            { Palossand,       Black },
            { Pyukumuku,       Green },
            { TypeNull,        Brown },
            { Silvally,        Yellow },
            { Minior,          Black },
            { Komala,          Blue },
            { Turtonator,      Blue },
            { Togedemaru,      White },
            { Mimikyu,         Gray },
            { Bruxish,         Red },
            { Drampa,          Yellow },
            { Dhelmise,        Red },
            { Jangmoo,         Yellow },
            { Hakamoo,         Green },
            { Kommoo,          Green },
            { TapuKoko,        Black },
            { TapuLele,        Black },
            { TapuBulu,        Black },
            { TapuFini,        Black },
            { Cosmog,          Purple },
            { Cosmoem,         Yellow },
            { Solgaleo,        Red },
            { Lunala,          Red },
            { Nihilego,        Yellow },
            { Buzzwole,        Green },
            { Pheromosa,       Black },
            { Xurkitree,       Blue },
            { Celesteela,      White },
            { Kartana,         White },
            { Guzzlord,        White },
            { Necrozma,        Blue },
            { Magearna,        Gray },
            { Marshadow,       Black },
            { Poipole,         White },
            { Naganadel,       Yellow },
            { Stakataka,       Yellow },
            { Blacephalon,     Blue },
            { Zeraora,         White },
            { Meltan,          Gray },
            { Melmetal,        Gray },
            { Grookey,         Green },
            { Thwackey,        Yellow },
            { Rillaboom,       Brown },
            { Scorbunny,       White },
            { Raboot,          Gray },
            { Cinderace,       Gray },
            { Sobble,          Blue },
            { Drizzile,        Blue },
            { Inteleon,        Blue },
            { Skwovet,         Red },
            { Greedent,        Red },
            { Rookidee,        Yellow },
            { Corvisquire,     Gray },
            { Corviknight,     Gray },
            { Blipbug,         Blue },
            { Dottler,         Blue },
            { Orbeetle,        Blue },
            { Nickit,          Brown },
            { Thievul,         Brown },
            { Gossifleur,      Blue },
            { Eldegoss,        White },
            { Wooloo,          Black },
            { Dubwool,         Black },
            { Chewtle,         Green },
            { Drednaw,         Green },
            { Yamper,          Pink },
            { Boltund,         Yellow },
            { Rolycoly,        Black },
            { Carkol,          Black },
            { Coalossal,       Black },
            { Applin,          Green },
            { Flapple,         Green },
            { Appletun,        Green },
            { Silicobra,       Yellow },
            { Sandaconda,      Black },
            { Cramorant,       Red },
            { Arrokuda,        Blue },
            { Barraskewda,     Blue },
            { Toxel,           Red },
            { Toxtricity,      Purple },
            { Sizzlipede,      Red },
            { Centiskorch,     Red },
            { Clobbopus,       Blue },
            { Grapploct,       Red },
            { Sinistea,        Purple },
            { Polteageist,     Purple },
            { Hatenna,         White },
            { Hattrem,         White },
            { Hatterene,       White },
            { Impidimp,        Blue },
            { Morgrem,         Blue },
            { Grimmsnarl,      White },
            { Obstagoon,       Red },
            { Perrserker,      Yellow },
            { Cursola,         Pink },
            { Sirfetchd,       Yellow },
            { MrRime,          Black },
            { Runerigus,       White },
            { Milcery,         White },
            { Alcremie,        White },
            { Falinks,         Brown },
            { Pincurchin,      Black },
            { Snom,            White },
            { Frosmoth,        White },
            { Stonjourner,     Black },
            { Eiscue,          Purple },
            { Indeedee,        Black },
            { Morpeko,         White },
            { Cufant,          Yellow },
            { Copperajah,      Black },
            { Dracozolt,       Brown },
            { Arctozolt,       White },
            { Dracovish,       Brown },
            { Arctovish,       White },
            { Duraludon,       White },
            { Dreepy,          Green },
            { Drakloak,        Gray },
            { Dragapult,       Green },
            { Zacian,          Blue },
            { Zamazenta,       Red },
            { Eternatus,       Red },
            { Kubfu,           White},
            { Urshifu,         Black },
            { Zarude,          Black },
            { Regieleki,       Yellow },
            { Regidrago,       Red },
            { Glastrier,       White },
            { Spectrier,       Black },
            { Calyrex,         White },
        };

        public static Ball GetBallFromString(string ballstr)
        {
            ballstr = ballstr.Split(' ')[0];
            if (ballstr == "Poké")
                return Poke;
            var valid = Enum.TryParse(ballstr, out Ball ball);
            if (valid)
                return ball;
            return Ball.None;
        }

        public static void ApplyShinyBall(PKM pk)
        {
            var color = ShinyMap[(Species)pk.Species];
            ApplyFirstLegalBall(pk, BallColors[color]);
        }

        private static readonly Ball[] BallList = (Ball[])Enum.GetValues(typeof(Ball));

        static Aesthetics()
        {
            var exclude = new[] { Ball.None, Poke };
            var end = new[] { Poke };
            var allBalls = BallList.Except(exclude).ToArray();
            var colors = (PersonalColor[])Enum.GetValues(typeof(PersonalColor));
            foreach (var c in colors)
            {
                var vals = BallColors[c];
                var extra = allBalls.Except(vals).ToArray();
                Util.Shuffle(extra);
                BallColors[c] = vals.Concat(extra).Concat(end).ToArray();
            }
        }

        public static Shiny GetShinyType(string value)
        {
            if (value.Equals("Square", StringComparison.OrdinalIgnoreCase))
                return Shiny.AlwaysSquare;
            if (value.Equals("Star", StringComparison.OrdinalIgnoreCase))
                return Shiny.AlwaysStar;
            if (value.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                return Shiny.Always;
            if (value.Equals("No", StringComparison.OrdinalIgnoreCase))
                return Shiny.Never;

            return Shiny.Random;
        }

        public static LanguageID? GetLanguageId(string value)
        {
            var valid = Enum.TryParse(value, out LanguageID lang);
            if (!valid)
                return null;
            if (lang is LanguageID.Hacked or LanguageID.UNUSED_6)
                return LanguageID.English;
            return lang;
        }

        /// <summary>
        /// Priority Match ball IDs that match the color ID in descending order
        /// </summary>
        private static readonly Dictionary<PersonalColor, Ball[]> BallColors = new()
        {
            [Red] = new[] { Cherish, Repeat, Fast, Heal, Great, Dream, Lure },
            [Blue] = new[] { Dive, Net, Great, Beast, Lure },
            [Yellow] = new[] { Level, Ultra, Repeat, Quick, Moon },
            [Green] = new[] { Safari, Friend, Nest, Dusk },
            [Black] = new[] { Luxury, Heavy, Ultra, Moon, Net, Beast },

            [Brown] = new[] { Level, Heavy },
            [Purple] = new[] { Master, Love, Dream, Heal },
            [Gray] = new[] { Heavy, Premier, Luxury },
            [White] = new[] { Premier, Timer, Luxury, Ultra },
            [Pink] = new[] { Love, Dream, Heal },
        };

        public static int ApplyFirstLegalBall(PKM pkm, IEnumerable<Ball> balls)
        {
            foreach (var b in balls)
            {
                pkm.Ball = (int)b;
                if (new LegalityAnalysis(pkm).Valid)
                    break;
            }
            return pkm.Ball;
        }

        public enum PersonalColor : byte
        {
            Red,
            Blue,
            Yellow,
            Green,
            Black,

            Brown,
            Purple,
            Gray,
            White,
            Pink,
        }
    }
}
