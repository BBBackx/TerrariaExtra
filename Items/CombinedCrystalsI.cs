using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class CombinedCrystalsI : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ichor Invasion");
            Tooltip.SetDefault("The power of the Crystal Storm and the Golden Shower combined into one!");
		}

		public override void SetDefaults()
		{
			item.damage = 37;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 5;
			item.rare = 4;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 7;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.knockBack = 5;
			item.shootSpeed = 7;
			item.useAnimation = 7;
			item.shoot = mod.ProjectileType("IC");
			item.value = Item.sellPrice(gold: 6);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenShower, 1);
			recipe.AddIngredient(ItemID.CrystalStorm, 1);
            recipe.AddIngredient(ItemID.SpellTome, 1);
			recipe.AddIngredient(ItemID.SoulofSight, 8);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}