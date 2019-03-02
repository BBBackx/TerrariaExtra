using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class StingerStorm : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stinger Storm");
            Tooltip.SetDefault("Was attaching grenades to stingers really a good idea?");
		}

		public override void SetDefaults()
		{
			item.damage = 7;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 4;
			item.rare = 3;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 6;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 6;
			item.useAnimation = 6;
			item.shoot = mod.ProjectileType("ExplodingStinger");
			item.value = Item.sellPrice(gold: 1);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Grenade, 15);
			recipe.AddIngredient(ItemID.Stinger, 8);
			recipe.AddIngredient(ItemID.FallenStar, 5);
            recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}