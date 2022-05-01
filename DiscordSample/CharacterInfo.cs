using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordSample
{

    public class CharacterInfo
    {
        public object Achievements { get; set; }
        public object AchievementsPublic { get; set; }
        public Character Character { get; set; }
        public object FreeCompany { get; set; }
        public object FreeCompanyMembers { get; set; }
        public object Friends { get; set; }
        public object FriendsPublic { get; set; }
        public Minion[] Minions { get; set; }
        public Mount[] Mounts { get; set; }
        public object PvPTeam { get; set; }
    }

    public class Character
    {
        public string Name { get; set; }
    }

    public class Activeclassjob
    {
        public int ClassID { get; set; }
        public int ExpLevel { get; set; }
        public int ExpLevelMax { get; set; }
        public int ExpLevelTogo { get; set; }
        public bool IsSpecialised { get; set; }
        public int JobID { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public Unlockedstate UnlockedState { get; set; }
    }

    public class Unlockedstate
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Classjobsbozjan
    {
        public int Level { get; set; }
        public int Mettle { get; set; }
        public string Name { get; set; }
    }

    public class Classjobselemental
    {
        public int ExpLevel { get; set; }
        public int ExpLevelMax { get; set; }
        public int ExpLevelTogo { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
    }

    public class Gearset
    {
        public Attributes Attributes { get; set; }
        public int ClassID { get; set; }
        public Gear Gear { get; set; }
        public string GearKey { get; set; }
        public int JobID { get; set; }
        public int Level { get; set; }
    }

    public class Attributes
    {
        public int _1 { get; set; }
        public int _2 { get; set; }
        public int _3 { get; set; }
        public int _4 { get; set; }
        public int _5 { get; set; }
        public int _6 { get; set; }
        public int _7 { get; set; }
        public int _8 { get; set; }
        public int _19 { get; set; }
        public int _20 { get; set; }
        public int _21 { get; set; }
        public int _22 { get; set; }
        public int _24 { get; set; }
        public int _27 { get; set; }
        public int _33 { get; set; }
        public int _34 { get; set; }
        public int _44 { get; set; }
        public int _45 { get; set; }
        public int _46 { get; set; }
    }

    public class Gear
    {
        public Body Body { get; set; }
        public Bracelets Bracelets { get; set; }
        public Earrings Earrings { get; set; }
        public Feet Feet { get; set; }
        public Hands Hands { get; set; }
        public Head Head { get; set; }
        public Legs Legs { get; set; }
        public Mainhand MainHand { get; set; }
        public Necklace Necklace { get; set; }
        public Ring1 Ring1 { get; set; }
        public Ring2 Ring2 { get; set; }
        public Soulcrystal SoulCrystal { get; set; }
    }

    public class Body
    {
        public object Creator { get; set; }
        public int Dye { get; set; }
        public int ID { get; set; }
        public object[] Materia { get; set; }
        public int Mirage { get; set; }
    }

    public class Bracelets
    {
        public object Creator { get; set; }
        public object Dye { get; set; }
        public int ID { get; set; }
        public object[] Materia { get; set; }
        public int Mirage { get; set; }
    }

    public class Earrings
    {
        public object Creator { get; set; }
        public object Dye { get; set; }
        public int ID { get; set; }
        public object[] Materia { get; set; }
        public int Mirage { get; set; }
    }

    public class Feet
    {
        public object Creator { get; set; }
        public object Dye { get; set; }
        public int ID { get; set; }
        public object[] Materia { get; set; }
        public int Mirage { get; set; }
    }

    public class Hands
    {
        public object Creator { get; set; }
        public object Dye { get; set; }
        public int ID { get; set; }
        public object[] Materia { get; set; }
        public int Mirage { get; set; }
    }

    public class Head
    {
        public object Creator { get; set; }
        public object Dye { get; set; }
        public int ID { get; set; }
        public object[] Materia { get; set; }
        public int Mirage { get; set; }
    }

    public class Legs
    {
        public object Creator { get; set; }
        public int Dye { get; set; }
        public int ID { get; set; }
        public object[] Materia { get; set; }
        public int Mirage { get; set; }
    }

    public class Mainhand
    {
        public object Creator { get; set; }
        public object Dye { get; set; }
        public int ID { get; set; }
        public object[] Materia { get; set; }
        public int Mirage { get; set; }
    }

    public class Necklace
    {
        public object Creator { get; set; }
        public object Dye { get; set; }
        public int ID { get; set; }
        public object[] Materia { get; set; }
        public int Mirage { get; set; }
    }

    public class Ring1
    {
        public object Creator { get; set; }
        public object Dye { get; set; }
        public int ID { get; set; }
        public object[] Materia { get; set; }
        public int Mirage { get; set; }
    }

    public class Ring2
    {
        public object Creator { get; set; }
        public object Dye { get; set; }
        public int ID { get; set; }
        public object[] Materia { get; set; }
        public int Mirage { get; set; }
    }

    public class Soulcrystal
    {
        public object Creator { get; set; }
        public object Dye { get; set; }
        public int ID { get; set; }
        public object[] Materia { get; set; }
        public object Mirage { get; set; }
    }

    public class Grandcompany
    {
        public int NameID { get; set; }
        public int RankID { get; set; }
    }

    public class Classjob
    {
        public int ClassID { get; set; }
        public int ExpLevel { get; set; }
        public int ExpLevelMax { get; set; }
        public int ExpLevelTogo { get; set; }
        public bool IsSpecialised { get; set; }
        public int JobID { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public Unlockedstate1 UnlockedState { get; set; }
    }

    public class Unlockedstate1
    {
        public int? ID { get; set; }
        public string Name { get; set; }
    }

    public class Minion
    {
        public string Icon { get; set; }
        public string Name { get; set; }
    }

    public class Mount
    {
        public string Icon { get; set; }
        public string Name { get; set; }
    }

}
