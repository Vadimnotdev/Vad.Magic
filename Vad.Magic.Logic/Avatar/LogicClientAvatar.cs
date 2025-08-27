using System.Runtime.CompilerServices;
using Vad.Magic.Logic.Home;
using Vad.Magic.Titan.Logic.DataStream;
using Vad.Magic.Titan.Logic.Math;

namespace Vad.Magic.Logic.Avatar
{
    public class LogicClientAvatar : LogicBase
    {
        public LogicLong Id;
        public LogicLong CurrentHomeId;
        public bool isInAlliance;
        public int AllianceCastleLevel;
        public int AllianceCastleTotalCapacity;
        public int AllianceCastleUsedCapacity;
        public int TownHallLevel;
        public string Name;
        public string FacebookId;
        public int ExpLevel;
        public int ExpPoints;
        public int Diamonds;
        public int FreeDiamonds;
        public int AttackRating;
        public int AttackFactor;
        public int Score;
        public bool NameSetByUser;
        public int AllianceBadge;
        public int Resources;
        public int[] _resourcesId = { 3000001, 3000002 };
        public int[] _resources = { 99999, 88888 }; //Gold and Elixir
        public int Units;
        public int UnitUpgradeLevel;
        public int AllianceUnits;
        public int MissionCompleted;
        public int NpcStars;
        public int LootedNpcGold;
        public int LootedNpcElixir;
        

    public LogicClientAvatar()
        {
            Id = new LogicLong(0, 1);
            CurrentHomeId = new LogicLong(0, 1);
            isInAlliance = false;
            AllianceCastleLevel = 0;
            AllianceCastleTotalCapacity = 0;
            AllianceCastleUsedCapacity = 0;
            TownHallLevel = 0;
            Name = "Vadim_not_dev";
            FacebookId = "facebookID";
            ExpLevel = 99;
            ExpPoints = 30;
            Diamonds = 99999;
            FreeDiamonds = 0;
            AttackRating = 0;
            AttackFactor = 0;
            Score = 999;
            NameSetByUser = true;
            AllianceBadge = 0;
            Resources = 2;
            Units = 0;
            UnitUpgradeLevel = 0;
            AllianceUnits = 0;
            MissionCompleted = 0;
            NpcStars = 0;
            LootedNpcGold = 0;
            LootedNpcElixir = 0;
        }

        public void Encode(ChecksumEncoder encoder)
        {
            base.Encode(encoder);
            encoder.WriteLong(Id);
            encoder.WriteLong(CurrentHomeId);
            encoder.WriteBoolean(isInAlliance);
            encoder.WriteInt(AllianceCastleLevel);
            encoder.WriteInt(AllianceCastleTotalCapacity);
            encoder.WriteInt(AllianceCastleUsedCapacity);
            encoder.WriteInt(TownHallLevel);
            encoder.WriteString(Name);
            encoder.WriteString(FacebookId);
            encoder.WriteInt(ExpLevel);
            encoder.WriteInt(ExpPoints);
            encoder.WriteInt(Diamonds);
            encoder.WriteInt(FreeDiamonds);
            encoder.WriteInt(AttackRating);
            encoder.WriteInt(AttackFactor);
            encoder.WriteInt(Score);
            encoder.WriteBoolean(NameSetByUser);
            encoder.WriteInt(AllianceBadge);
            encoder.WriteInt(Resources);
            
            for (int i = 0; i < Resources; i++)
            {
                encoder.WriteInt(_resourcesId[i]);
                encoder.WriteInt(_resources[i]);
            }
            encoder.WriteInt(Units);
            encoder.WriteInt(UnitUpgradeLevel);
            encoder.WriteInt(AllianceUnits);
            encoder.WriteInt(MissionCompleted);
            encoder.WriteInt(NpcStars);
            encoder.WriteInt(LootedNpcGold);
            encoder.WriteInt(LootedNpcElixir);
        }

    }
}
