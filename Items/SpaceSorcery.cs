using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class SpaceSorcery : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Space Sorcery");
            Tooltip.SetDefault("This book shines like the stars...");
		}

		public override void SetDefaults()
		{
			item.damage = 156;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 8;
			item.rare = 10;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 13;
			item.UseSound = SoundID.Item30;
			item.useStyle = 5;
			item.shootSpeed = 13f;
			item.useAnimation = 13;
			item.shoot = mod.ProjectileType("LunarFollow");
			item.value = Item.sellPrice(gold: 10);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "NebulaCharger", 1);
			recipe.AddIngredient(null, "VortexVanquisher", 1);
			recipe.AddIngredient(null, "StardustStriker", 1);
			recipe.AddIngredient(null, "DayBreakDrama", 1);
			recipe.AddIngredient(ItemID.LunarFlareBook, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}