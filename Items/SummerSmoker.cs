using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class SummerSmoker : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Summer Smoker");
            Tooltip.SetDefault("Shooting normal cactus just wasn't enough...");
		}

		public override void SetDefaults()
		{
			item.damage = 11;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 7;
			item.rare = 3;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 27;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 27f;
			item.useAnimation = 27;
			item.shoot = mod.ProjectileType("SCactus");
			item.value = Item.sellPrice(gold: 1);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Cactus, 25);
			recipe.AddIngredient(ItemID.SandBlock, 50);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}