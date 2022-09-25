﻿using Mafi.Base;
using Mafi.Core.Entities.Static;
using Mafi.Core.Factory.Machines;
using Mafi.Core.Factory.Recipes;
using Mafi.Core.Products;
using Mafi.Core.Prototypes;
using Mafi.Core.Research;

namespace CoI.Mod.Better.MyIDs
{

    public sealed class Products
    {
        public readonly static ProductProto.ID Nothing = new ProductProto.ID("NothingProduct");
    }

    public sealed class Research
    {
        public readonly static ResearchNodeProto.ID GenerellEdictsResearchT1 = Ids.Research.CreateId("MyGenerellEdictsResearchT1");
        public readonly static ResearchNodeProto.ID GenerellEdictsResearchT2 = Ids.Research.CreateId("MyGenerellEdictsResearchT2");
        public readonly static ResearchNodeProto.ID GenerellEdictsResearchT3 = Ids.Research.CreateId("MyGenerellEdictsResearchT3");
        public readonly static ResearchNodeProto.ID GenerellEdictsResearchT4 = Ids.Research.CreateId("MyGenerellEdictsResearchT4");
        public readonly static ResearchNodeProto.ID GenerellEdictsResearchT5 = Ids.Research.CreateId("MyGenerellEdictsResearchT5");

        public readonly static ResearchNodeProto.ID GenerellEdictsResearchCheat_T1 = Ids.Research.CreateId("MyGenerellEdictsResearchCheat");
        public readonly static ResearchNodeProto.ID GenerellEdictsResearchCheat_T2 = Ids.Research.CreateId("MyGenerellEdictsResearchCheatT2");
        public readonly static ResearchNodeProto.ID GenerellEdictsResearchCheat_T3 = Ids.Research.CreateId("MyGenerellEdictsResearchCheatT3");
        public readonly static ResearchNodeProto.ID GenerellEdictsResearchCheat_T4 = Ids.Research.CreateId("MyGenerellEdictsResearchCheatT4");
        public readonly static ResearchNodeProto.ID GenerellEdictsResearchCheat_T5 = Ids.Research.CreateId("MyGenerellEdictsResearchCheatT5");

        public readonly static ResearchNodeProto.ID VehicleEdictsResearchT1 = Ids.Research.CreateId("MyEdictsResearchT1");
        public readonly static ResearchNodeProto.ID VehicleEdictsResearchT2 = Ids.Research.CreateId("MyEdictsResearchT2");
        public readonly static ResearchNodeProto.ID VehicleEdictsResearchT3 = Ids.Research.CreateId("MyEdictsResearchT3");
        public readonly static ResearchNodeProto.ID VehicleEdictsResearchT4 = Ids.Research.CreateId("MyEdictsResearchT4");
        public readonly static ResearchNodeProto.ID VehicleEdictsResearchT5 = Ids.Research.CreateId("MyEdictsResearchT5");

        public readonly static ResearchNodeProto.ID VehicleEdictsResearchCheat_T1 = Ids.Research.CreateId("MyEdictsResearchCheat");
        public readonly static ResearchNodeProto.ID VehicleEdictsResearchCheat_T2 = Ids.Research.CreateId("MyEdictsResearchCheatT2");
        public readonly static ResearchNodeProto.ID VehicleEdictsResearchCheat_T3 = Ids.Research.CreateId("MyEdictsResearchCheatT3");
        public readonly static ResearchNodeProto.ID VehicleEdictsResearchCheat_T4 = Ids.Research.CreateId("MyEdictsResearchCheatT4");
        public readonly static ResearchNodeProto.ID VehicleEdictsResearchCheat_T5 = Ids.Research.CreateId("MyEdictsResearchCheatT5");

        public readonly static ResearchNodeProto.ID VehicleCapIncreaseID_ZERO = Ids.Research.CreateId("MyVehicle_Cap_Increase_ZERO");
        public readonly static ResearchNodeProto.ID VehicleCapIncreaseID_CHEAT = Ids.Research.CreateId("CHEAT_Vehicle_Cap_Increase_CHEAT");
        public readonly static ResearchNodeProto.ID VehicleCapIncreaseID_I = Ids.Research.CreateId("MyVehicle_Cap_Increase_I");
        public readonly static ResearchNodeProto.ID VehicleCapIncreaseID_II = Ids.Research.CreateId("MyVehicle_Cap_Increase_II");
        public readonly static ResearchNodeProto.ID VehicleCapIncreaseID_III = Ids.Research.CreateId("MyVehicle_Cap_Increase_III");
        public readonly static ResearchNodeProto.ID VehicleCapIncreaseID_IV = Ids.Research.CreateId("MyVehicle_Cap_Increase_IV");
        public readonly static ResearchNodeProto.ID VehicleCapIncreaseID_V = Ids.Research.CreateId("MyVehicle_Cap_Increase_V");
        public readonly static ResearchNodeProto.ID VehicleCapIncreaseID_VI = Ids.Research.CreateId("MyVehicle_Cap_Increase_VI");
        public readonly static ResearchNodeProto.ID VehicleCapIncreaseID_VII = Ids.Research.CreateId("MyVehicle_Cap_Increase_VII");
        public readonly static ResearchNodeProto.ID VehicleCapIncreaseID_VIII = Ids.Research.CreateId("MyVehicle_Cap_Increase_VIII");
        public readonly static ResearchNodeProto.ID VehicleCapIncreaseID_IX = Ids.Research.CreateId("MyVehicle_Cap_Increase_IX");
        public readonly static ResearchNodeProto.ID VehicleCapIncreaseID_X = Ids.Research.CreateId("MyVehicle_Cap_Increase_X");
        public readonly static ResearchNodeProto.ID VehicleCapIncreaseID_XI = Ids.Research.CreateId("MyVehicle_Cap_Increase_XI");
        public readonly static ResearchNodeProto.ID VehicleCapIncreaseID_XII = Ids.Research.CreateId("MyVehicle_Cap_Increase_XII");
        public readonly static ResearchNodeProto.ID VehicleCapIncreaseID_XIII = Ids.Research.CreateId("MyVehicle_Cap_Increase_XIII");
        public readonly static ResearchNodeProto.ID VehicleCapIncreaseID_XIV = Ids.Research.CreateId("MyVehicle_Cap_Increase_XIV");
        public readonly static ResearchNodeProto.ID VehicleCapIncreaseID_XV = Ids.Research.CreateId("MyVehicle_Cap_Increase_XV");

        public readonly static ResearchNodeProto.ID VoidCrusher = Ids.Research.CreateId("ResearchVoidCrusher");
        public readonly static ResearchNodeProto.ID VoidCrusherCheat = Ids.Research.CreateId("ResearchVoidCrusherCheat");
        public readonly static ResearchNodeProto.ID VoidCrusherRecyclablesCheat = Ids.Research.CreateId("ResearchVoidCrusherRecyclablesCheat");
        public readonly static ResearchNodeProto.ID VoidCrusherFluidCheat = Ids.Research.CreateId("ResearchVoidCrusherFluidCheat");
        public readonly static ResearchNodeProto.ID VoidCrusherLooseCheat = Ids.Research.CreateId("ResearchVoidCrusherLooseCheat");
        public readonly static ResearchNodeProto.ID VoidProducerCheat = Ids.Research.CreateId("ResearchVoidProducerCheat");
        public readonly static ResearchNodeProto.ID VoidDieselEnergyCheat = Ids.Research.CreateId("VoidEnergyCheat");
        public readonly static ResearchNodeProto.ID VoidPowerEnergyCheat = Ids.Research.CreateId("VoidPowerEnergyCheat");

        public readonly static ResearchNodeProto.ID StorageResearchT1 = Ids.Research.CreateId("MyStorageResearchT1");
        public readonly static ResearchNodeProto.ID StorageResearchT2 = Ids.Research.CreateId("MyStorageResearchT2");
        public readonly static ResearchNodeProto.ID StorageResearchT3 = Ids.Research.CreateId("MyStorageResearchT3");
        public readonly static ResearchNodeProto.ID StorageResearchT4 = Ids.Research.CreateId("MyStorageResearchT4");
        public readonly static ResearchNodeProto.ID StorageResearchT5 = Ids.Research.CreateId("MyStorageResearchT5");

        public readonly static ResearchNodeProto.ID SteamStorageResearchT1 = Ids.Research.CreateId("MySteamStorageResearchT1");
        public readonly static ResearchNodeProto.ID SteamStorageResearchT2 = Ids.Research.CreateId("MySteamStorageResearchT2");
        public readonly static ResearchNodeProto.ID SteamStorageResearchT3 = Ids.Research.CreateId("MySteamStorageResearchT3");
        public readonly static ResearchNodeProto.ID SteamStorageResearchT4 = Ids.Research.CreateId("MySteamStorageResearchT4");

    }

    public static class ToolbarCategories
    {
        public static readonly Proto.ID Storages = Ids.ToolbarCategories.Storages;
        public static readonly Proto.ID MachinesElectricity = Ids.ToolbarCategories.MachinesElectricity;
        public static readonly Proto.ID MachinesMetallurgy = Ids.ToolbarCategories.MachinesMetallurgy;
    }

    public sealed class Buildings
    {
        public static readonly StaticEntityProto.ID MineTowerNormal = new StaticEntityProto.ID("MyMineTowerNormal");
        public static readonly StaticEntityProto.ID MineTowerT2 = new StaticEntityProto.ID("MyMineTowerT2");
        public static readonly StaticEntityProto.ID MineTowerT3 = new StaticEntityProto.ID("MyMineTowerT3");

        public static readonly StaticEntityProto.ID StorageUnitT4 = new StaticEntityProto.ID("MyStorageUnitT4");
        public static readonly StaticEntityProto.ID StorageUnitT3 = new StaticEntityProto.ID("MyStorageUnitT3");
        public static readonly StaticEntityProto.ID StorageUnitT2 = new StaticEntityProto.ID("MyStorageUnitT2");
        public static readonly StaticEntityProto.ID StorageUnitT1 = new StaticEntityProto.ID("MyStorageUnitT1");

        public static readonly StaticEntityProto.ID StorageLooseT4 = new StaticEntityProto.ID("MyStorageLooseT4");
        public static readonly StaticEntityProto.ID StorageLooseT3 = new StaticEntityProto.ID("MyStorageLooseT3");
        public static readonly StaticEntityProto.ID StorageLooseT2 = new StaticEntityProto.ID("MyStorageLooseT2");
        public static readonly StaticEntityProto.ID StorageLooseT1 = new StaticEntityProto.ID("MyStorageLooseT1");

        public static readonly StaticEntityProto.ID StorageFluidT4 = new StaticEntityProto.ID("MyStorageFluidT4");
        public static readonly StaticEntityProto.ID StorageFluidT3 = new StaticEntityProto.ID("MyStorageFluidT3");
        public static readonly StaticEntityProto.ID StorageFluidT2 = new StaticEntityProto.ID("MyStorageFluidT2");
        public static readonly StaticEntityProto.ID StorageFluidT1 = new StaticEntityProto.ID("MyStorageFluidT1");

        public static readonly StaticEntityProto.ID StorageSteamT4 = new StaticEntityProto.ID("MyStorageSteamT4");
        public static readonly StaticEntityProto.ID StorageSteamT3 = new StaticEntityProto.ID("MyStorageSteamT3");
        public static readonly StaticEntityProto.ID StorageSteamT2 = new StaticEntityProto.ID("MyStorageSteamT2");
        public static readonly StaticEntityProto.ID StorageSteamT1 = new StaticEntityProto.ID("MyStorageSteamT1");

        public static readonly StaticEntityProto.ID NuclearWasteStorage = new StaticEntityProto.ID("MyNuclearWasteStorage");
    }

    public sealed class Machines
    {
        public readonly static MachineProto.ID VoidCrusher = Ids.Machines.CreateId("VoidCrusher");
        public readonly static MachineProto.ID VoidCrusherCheat = Ids.Machines.CreateId("VoidCrusherCheat");
        public readonly static MachineProto.ID VoidCrusherLooseCheat = Ids.Machines.CreateId("VoidCrusherLooseCheat");
        public readonly static MachineProto.ID VoidCrusherFluidCheat = Ids.Machines.CreateId("VoidCrusherFluidCheat");
        public readonly static MachineProto.ID VoidCrusherRecyclablesCheat = Ids.Machines.CreateId("VoidCrusherRecyclablesCheat");
        public readonly static MachineProto.ID VoidProducerFluidCheat = Ids.Machines.CreateId("VoidProducerLiquidCheat");
        public readonly static MachineProto.ID VoidProducerLooseCheat = Ids.Machines.CreateId("VoidProducerLooseCheat");
        public readonly static MachineProto.ID VoidProducerProductCheat = Ids.Machines.CreateId("VoidProducerProductCheat");


        public readonly static StaticEntityProto.ID VoidDieselEnergy10Cheat = new StaticEntityProto.ID("VoidProducerEnergy10Cheat");
        public readonly static StaticEntityProto.ID VoidDieselEnergy50Cheat = new StaticEntityProto.ID("VoidProducerEnergy50Cheat");
        public readonly static StaticEntityProto.ID VoidDieselEnergy100Cheat = new StaticEntityProto.ID("VoidProducerEnergy100Cheat");
        public readonly static StaticEntityProto.ID VoidDieselEnergy200Cheat = new StaticEntityProto.ID("VoidProducerEnergy200Cheat");
        public readonly static StaticEntityProto.ID VoidDieselEnergy1000Cheat = new StaticEntityProto.ID("VoidProducerEnergy1000Cheat");


        public readonly static StaticEntityProto.ID VoidPowerEnergyT1Cheat = new StaticEntityProto.ID("VoidPowerEnergyT1Cheat");
        public readonly static StaticEntityProto.ID VoidPowerEnergyT2Cheat = new StaticEntityProto.ID("VoidPowerEnergyT2Cheat");
        public readonly static StaticEntityProto.ID VoidPowerEnergyT3Cheat = new StaticEntityProto.ID("VoidPowerEnergyT3Cheat");
        public readonly static StaticEntityProto.ID VoidPowerEnergyT4Cheat = new StaticEntityProto.ID("VoidPowerEnergyT4Cheat");
        public readonly static StaticEntityProto.ID VoidPowerEnergyT5Cheat = new StaticEntityProto.ID("VoidPowerEnergyT5Cheat");
    }

    public sealed class Eticts
    {
        public static readonly Proto.ID BetterMod = new ProductProto.ID("BetterModCatergory");
        public static readonly Proto.ID BetterModCheats = new ProductProto.ID("BetterModCheatCatergory");

        public sealed class Trucks
        {
            public readonly static ResearchNodeProto.ID CapacityIncT1 = Ids.Research.CreateId(Utilities.CapacityIncStr + "2");
            public readonly static ResearchNodeProto.ID CapacityIncT2 = Ids.Research.CreateId(Utilities.CapacityIncStr + "3");
            public readonly static ResearchNodeProto.ID CapacityIncT3 = Ids.Research.CreateId(Utilities.CapacityIncStr + "4");
            public readonly static ResearchNodeProto.ID CapacityIncT4 = Ids.Research.CreateId(Utilities.CapacityIncStr + "5");

            public readonly static ResearchNodeProto.ID CapacityIncT1_CHEAT = Ids.Research.CreateId(Utilities.CapacityIncStr + Utilities.Cheat_1);
            public readonly static ResearchNodeProto.ID CapacityIncT2_CHEAT = Ids.Research.CreateId(Utilities.CapacityIncStr + Utilities.Cheat_2);
            public readonly static ResearchNodeProto.ID CapacityIncT3_CHEAT = Ids.Research.CreateId(Utilities.CapacityIncStr + Utilities.Cheat_3);
            public readonly static ResearchNodeProto.ID CapacityIncT4_CHEAT = Ids.Research.CreateId(Utilities.CapacityIncStr + Utilities.Cheat_4);
            public readonly static ResearchNodeProto.ID CapacityIncT5_CHEAT = Ids.Research.CreateId(Utilities.CapacityIncStr + Utilities.Cheat_5);



            public readonly static ResearchNodeProto.ID FuelReductionT1 = Ids.Research.CreateId(Utilities.FuelReductionStr + "2");
            public readonly static ResearchNodeProto.ID FuelReductionT2 = Ids.Research.CreateId(Utilities.FuelReductionStr + "3");
            public readonly static ResearchNodeProto.ID FuelReductionT3 = Ids.Research.CreateId(Utilities.FuelReductionStr + "4");
            public readonly static ResearchNodeProto.ID FuelReductionT4 = Ids.Research.CreateId(Utilities.FuelReductionStr + "5");

            public readonly static ResearchNodeProto.ID FuelReductionT1_CHEAT = Ids.Research.CreateId(Utilities.FuelReductionStr + Utilities.Cheat_1);
            public readonly static ResearchNodeProto.ID FuelReductionT2_CHEAT = Ids.Research.CreateId(Utilities.FuelReductionStr + Utilities.Cheat_2);
            public readonly static ResearchNodeProto.ID FuelReductionT3_CHEAT = Ids.Research.CreateId(Utilities.FuelReductionStr + Utilities.Cheat_3);
            public readonly static ResearchNodeProto.ID FuelReductionT4_CHEAT = Ids.Research.CreateId(Utilities.FuelReductionStr + Utilities.Cheat_4);



            public readonly static ResearchNodeProto.ID MaintenanceReductionT1 = Ids.Research.CreateId(Utilities.MaintenanceReductionStr + "2");
            public readonly static ResearchNodeProto.ID MaintenanceReductionT2 = Ids.Research.CreateId(Utilities.MaintenanceReductionStr + "3");
            public readonly static ResearchNodeProto.ID MaintenanceReductionT3 = Ids.Research.CreateId(Utilities.MaintenanceReductionStr + "4");
            public readonly static ResearchNodeProto.ID MaintenanceReductionT4 = Ids.Research.CreateId(Utilities.MaintenanceReductionStr + "5");

            public readonly static ResearchNodeProto.ID MaintenanceReductionT1_CHEAT = Ids.Research.CreateId(Utilities.MaintenanceReductionStr + Utilities.Cheat_1);
            public readonly static ResearchNodeProto.ID MaintenanceReductionT2_CHEAT = Ids.Research.CreateId(Utilities.MaintenanceReductionStr + Utilities.Cheat_2);
            public readonly static ResearchNodeProto.ID MaintenanceReductionT3_CHEAT = Ids.Research.CreateId(Utilities.MaintenanceReductionStr + Utilities.Cheat_3);
            public readonly static ResearchNodeProto.ID MaintenanceReductionT4_CHEAT = Ids.Research.CreateId(Utilities.MaintenanceReductionStr + Utilities.Cheat_4);
        }

        public sealed class Generell
        {
            public readonly static Proto.ID UnityPointsT1 = new Proto.ID(Utilities.UnityPlusStr + "1");
            public readonly static Proto.ID UnityPointsT2 = new Proto.ID(Utilities.UnityPlusStr + "2");
            public readonly static Proto.ID UnityPointsT3 = new Proto.ID(Utilities.UnityPlusStr + "3");
            public readonly static Proto.ID UnityPointsT4 = new Proto.ID(Utilities.UnityPlusStr + "4");
            public readonly static Proto.ID UnityPointsT5 = new Proto.ID(Utilities.UnityPlusStr + "5");

            public readonly static Proto.ID UnityPointsT1_CHEAT = new Proto.ID(Utilities.UnityPlusStr + Utilities.Cheat_1);
            public readonly static Proto.ID UnityPointsT2_CHEAT = new Proto.ID(Utilities.UnityPlusStr + Utilities.Cheat_2);
            public readonly static Proto.ID UnityPointsT3_CHEAT = new Proto.ID(Utilities.UnityPlusStr + Utilities.Cheat_3);
            public readonly static Proto.ID UnityPointsT4_CHEAT = new Proto.ID(Utilities.UnityPlusStr + Utilities.Cheat_4);
            public readonly static Proto.ID UnityPointsT5_CHEAT = new Proto.ID(Utilities.UnityPlusStr + Utilities.Cheat_5);

            public readonly static Proto.ID ReduceServiceT1_CHEAT = new Proto.ID(Utilities.ReduceServiceStr + Utilities.Cheat_1);
            public readonly static Proto.ID ReduceServiceT2_CHEAT = new Proto.ID(Utilities.ReduceServiceStr + Utilities.Cheat_2);
            public readonly static Proto.ID ReduceServiceT3_CHEAT = new Proto.ID(Utilities.ReduceServiceStr + Utilities.Cheat_3);
            public readonly static Proto.ID ReduceServiceT4_CHEAT = new Proto.ID(Utilities.ReduceServiceStr + Utilities.Cheat_4);
            public readonly static Proto.ID ReduceServiceT5_CHEAT = new Proto.ID(Utilities.ReduceServiceStr + Utilities.Cheat_5);

            public readonly static Proto.ID FarmMultiplierT1_CHEAT = new Proto.ID(Utilities.FarmMultiplierStr + Utilities.Cheat_1);
            public readonly static Proto.ID FarmMultiplierT2_CHEAT = new Proto.ID(Utilities.FarmMultiplierStr + Utilities.Cheat_2);
            public readonly static Proto.ID FarmMultiplierT3_CHEAT = new Proto.ID(Utilities.FarmMultiplierStr + Utilities.Cheat_3);
            public readonly static Proto.ID FarmMultiplierT4_CHEAT = new Proto.ID(Utilities.FarmMultiplierStr + Utilities.Cheat_4);
            public readonly static Proto.ID FarmMultiplierT5_CHEAT = new Proto.ID(Utilities.FarmMultiplierStr + Utilities.Cheat_5);

            public readonly static Proto.ID FarmWaterConsumMultiplierT1_CHEAT = new Proto.ID(Utilities.FarmWaterConsumMultiplierStr + Utilities.Cheat_1);
            public readonly static Proto.ID FarmWaterConsumMultiplierT2_CHEAT = new Proto.ID(Utilities.FarmWaterConsumMultiplierStr + Utilities.Cheat_2);
            public readonly static Proto.ID FarmWaterConsumMultiplierT3_CHEAT = new Proto.ID(Utilities.FarmWaterConsumMultiplierStr + Utilities.Cheat_3);
            public readonly static Proto.ID FarmWaterConsumMultiplierT4_CHEAT = new Proto.ID(Utilities.FarmWaterConsumMultiplierStr + Utilities.Cheat_4);
            public readonly static Proto.ID FarmWaterConsumMultiplierT5_CHEAT = new Proto.ID(Utilities.FarmWaterConsumMultiplierStr + Utilities.Cheat_5);

            public readonly static Proto.ID RecyclingRatioDiffT1_CHEAT = new Proto.ID(Utilities.RecyclingRatioDiffStr + Utilities.Cheat_1);
            public readonly static Proto.ID RecyclingRatioDiffT2_CHEAT = new Proto.ID(Utilities.RecyclingRatioDiffStr + Utilities.Cheat_2);
            public readonly static Proto.ID RecyclingRatioDiffT3_CHEAT = new Proto.ID(Utilities.RecyclingRatioDiffStr + Utilities.Cheat_3);
            public readonly static Proto.ID RecyclingRatioDiffT4_CHEAT = new Proto.ID(Utilities.RecyclingRatioDiffStr + Utilities.Cheat_4);
            public readonly static Proto.ID RecyclingRatioDiffT5_CHEAT = new Proto.ID(Utilities.RecyclingRatioDiffStr + Utilities.Cheat_5);

            public readonly static Proto.ID SolarPowerT1_CHEAT = new Proto.ID(Utilities.SolarPowerStr + Utilities.Cheat_1);
            public readonly static Proto.ID SolarPowerT2_CHEAT = new Proto.ID(Utilities.SolarPowerStr + Utilities.Cheat_2);
            public readonly static Proto.ID SolarPowerT3_CHEAT = new Proto.ID(Utilities.SolarPowerStr + Utilities.Cheat_3);
            public readonly static Proto.ID SolarPowerT4_CHEAT = new Proto.ID(Utilities.SolarPowerStr + Utilities.Cheat_4);
            public readonly static Proto.ID SolarPowerT5_CHEAT = new Proto.ID(Utilities.SolarPowerStr + Utilities.Cheat_5);
        }
    }

    public sealed class Utilities
    {
        public readonly static Proto.ID BeaconSchedule = new Proto.ID("BeaconSchedule");

        public readonly static string CapacityIncStr = "MyTruckCapacityIncreaseT";
        public readonly static string FuelReductionStr = "MyFuelReductionT";
        public readonly static string MaintenanceReductionStr = "MyMaintenanceReductionT";
        public readonly static string UnityPlusStr = "MyUnityPlusT";
        public readonly static string ReduceServiceStr = "MyReduceServiceT";
        public readonly static string FarmMultiplierStr = "MyFarmMultiplierT";
        public readonly static string FarmWaterConsumMultiplierStr = "MyFarmWaterConsumMultiplierT";
        public readonly static string RecyclingRatioDiffStr = "MyRecyclingRatioDiffT";
        public readonly static string SolarPowerStr = "MySolarT";

        public readonly static string Cheat_1 = "CHEAT1";
        public readonly static string Cheat_2 = "CHEAT2";
        public readonly static string Cheat_3 = "CHEAT3";
        public readonly static string Cheat_4 = "CHEAT4";
        public readonly static string Cheat_5 = "CHEAT5";
    }
}
