using System;

namespace CoI.Mod.Better.ModConfigs.Configs
{
    [Serializable]
    public class StorageConfig : ConfigBase
    {
        public bool UnlimitedTransferLimit = false;

        public int CapacityT1 = 540; // vanilla * 3
        public int TransferLimitT1Count = 2; // vanilla
        public int TransferLimitT1Duration = 5; // vanilla

        public int CapacityT2 = 1080; // vanilla * 3
        public int TransferLimitT2Count = 4; // vanilla
        public int TransferLimitT2Duration = 5; // vanilla

        public int CapacityT3 = 6480; // vanilla * 3
        public int TransferLimitT3Count = 8; // vanilla
        public int TransferLimitT3Duration = 5; // vanilla

        public int CapacityT4 = 12960; // vanilla * 3
        public int TransferLimitT4Count = 10; // vanilla
        public int TransferLimitT4Duration = 5; // vanilla

        public int FluidCapacityMultiplier = 2; // vanilla * 2
        public int SteamCapacityMultiplier = 2; // FluidCapacity * 2

        public int CapacityNuclearWaste = 12000; // vanilla * 3
        public int NuclearWasteCapacityMultiplier = 2; // = Vanilla * 2

        public int ResearchCostT1 = 1;
        public int ResearchCostT2 = 4;
        public int ResearchCostT3 = 8;
        public int ResearchCostT4 = 16;
        public int ResearchCostT5 = 32;
        public int SteamResearchCostT1 = 5;
        public int SteamResearchCostT2 = 7;
        public int SteamResearchCostT3 = 14;
        public int SteamResearchCostT4 = 20;
        public int SteamResearchCostT5 = 40;
    }
}
