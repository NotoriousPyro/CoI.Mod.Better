# CoI.Mod.Better
## Version 0.2.4 (compatible CoI version: 0.4.12 - 0.4.13)

> :warning: **This mod is a fork of the original with some stuff stripped out to make it more maintainable.** Notably, there is no longer any option to override built-in game entities, instead creating new ones & removing of the custom toolbar creation and using the built-in categories.

> :warning: **This mod being a fork of the original, will not have new features and updates will be delivered WHEN and WHERE possible AND WITHOUT WARRANTY.**

> :warning: **THERE IS NO GUARANTEE THIS WILL WORK FOR YOUR PRE-EXISTING SAVES**

> :warning: **You need to remove any DLLs copied to the CoI base folder from previous releases of CoI.Mod.Better, the required DLLs are already included alongside the main DLL and can be copied to the same mod folder of Coi.Mod.Better.**


# Current overview of the functions:
- Void Destroyer - Shreds products(no liquids, no losse), has as output stones. and causes emissions.
- All vanilla storages have 3x more space. 
- Steam Storage(Hi, Lo, Deplated, chiller water)
- The liquid stores have 30x more than the vanilla building.
- The refugee system has been overhauled so that refugees are now arriving forever. However, the rhythm has been changed, the number of refugees varies, the gift amounts are now also randomly generated and it can also happen that you do not receive any gifts. The number of refugees and the gifts increase at the beginning and stop increasing after a certain limit, but these can also fluctuate strongly.
- More edict have been added that offer your load amount of trucks, their consumption and their maintenance more slopes.
- You can now increase your vehicle limit with further research. However, it may happen that the performance suffers. 
- The range of your mining tower has been increased by 50%.
- Edit various settings in the Config. It should be noted that this is created only after the load / new game. The config is valid for all new and old savegames. So be careful what you change.

# Cheats:

- Cheats can be disabled in the config file.

Machine:
- Void Destroyer - Shreds products(no liquids, no losse), has no waste and also no emissions.
- Void Destroyer Liquids - Shreds products liquids, has no waste and also no emissions.
- Void Destroyer Loose - Shreds losse, has no waste and also no emissions.
- Void Producer Liquids - You can produce all liquids
- Void Producer Products - You can produce all Products
- Void Producer Loose - You can produce all Loose
- Diesel Generators - 1 Diesel per minute, produce: 10MW, 50MW, 100MW, 200MW, 1GW | You can customise this setting in the Config file.
- Power Generators - 500 KwMech per minute, produce: 900KW, 1.8MW, 2.7MW, 3.6MW, 4.5GW | You can customise this setting in the Config file.

Research:
- Vehicle Capacity +250

Edicts: 
- Maintenance reduce: 
	-Vanilla: -30%, -40%, -50%, -60%
	- Cheat: -30%, -50%, -75%, -100%
- Fuel consume reduce:
	- Vanilla: -30%, -45%, -60%, -75%
	- Cheat: -25%, -50%, -75%, -100%
- Truck load size increase:
	- Vanilla: 50%, 75%, 100%, 200%
	- Cheat: 100%, 200%, 300%, 400%, 500%
- Unity Points: 5, 10, 20, 50, 100
- Reduce all Services: -30%, -40%, -50%, -75%, -100%
- Farm yield multiplier: 25%, 50%, 100%, 200%, 300%
- Farm Water Consumption Multiplier: 20%, 40%, 50%, 75%, 95%
- Recycling Ratio: 20%, 40%, 60%, 80%, 100%
- Solar power: 25%, 50%, 100%, 200%, 300%

# How to install

Download the latest release: https://github.com/NotoriousPyro/CoI.Mod.Better/releases

1. From the downloaded zip, copy the contents of the `Mods` folder to your Captain of Industry `Mods` folder.

    By default, this is `Documents\Captain of Industry\Mods`. You can find out where exactly by running the following in PowerShell:
    ```powershell
    ((new-object -COM Shell.Application).Namespace(0x05).Self.Path + '\Captain of Industry\Mods')
    ```

2. Verify inside 'Mods' folder, each sub-folder has **a dll file with the same name as the folder**, it is fine if other DLLs are also present.

3. Enable the `Enable mods` options in the ingame settings or select the mod in load game menu.

# FAQ

1. May I rename the folder or file ? 
    Best not to, but you can try loading it without the mod enabled first... Likely to cause things to disappear in the game...

2. Why is the mod not loaded?
    There are several reasons.
    1. in the settings menu the option Mods was not activated.
    2. is the file/mod path correct? It must look like this: "Documents\Captain Of Industry\Mods\CoI.Mod.Better\CoI.Mod.Better.dll".

3. How do I see that the mod is active?
    Here, too, there are several possibilities.
    
    Log Folder: "Documents\Captain Of Industry\Logs"
    
    1. You look in the last log and in the log should be the following to find: 
     
        Loaded 1 extra mods
		CoI.Mod.Better (CoI.Mod.Better.BetterMod) <--- If this is displayed, the mod has been loaded.
        
    2. In the research tree there should be new research options at the top.

# Config

	see you soon!

# 
I wish you a lot of fun!
Luxgor
