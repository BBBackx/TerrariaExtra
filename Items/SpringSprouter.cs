using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class SpringSprouter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spring Sprouter");
            Tooltip.SetDefault("This is why you should know which flowers are poisonous...");
		}

		public override void SetDefaults()
		{
			item.damage = 19;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 8;
			item.rare = 3;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 32;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 32;
			item.useAnimation = 32;
			item.shoot = mod.ProjectileType("SFlower");
			item.value = Item.sellPrice(gold: 1);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.JungleSpores, 12);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddIngredient(ItemID.JungleGrassSeeds, 3);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}