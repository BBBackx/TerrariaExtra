using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class CombinedCrystals : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Combined Crystals");
            Tooltip.SetDefault("The power of the Crystal Storm, the Golden Shower and Cursed Flames combined into one!");
		}

		public override void SetDefaults()
		{
			item.damage = 58;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 6;
			item.rare = 6;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 7;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.knockBack = 5;
			item.shootSpeed = 7;
			item.useAnimation = 7;
			item.shoot = mod.ProjectileType("SC");
			item.value = Item.sellPrice(gold: 9);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CombinedCrystalsI", 1);
			recipe.AddIngredient(null, "CombinedCrystalsC", 1);
            recipe.AddIngredient(ItemID.SpellTome, 1);
			recipe.AddIngredient(ItemID.SoulofFright, 5);
            recipe.AddIngredient(ItemID.SoulofSight, 5);
            recipe.AddIngredient(ItemID.SoulofMight, 5);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}