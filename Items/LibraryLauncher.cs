using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class LibraryLauncher : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Library Launcher");
            Tooltip.SetDefault("Breaking news: Pixelated man destroys local library!");
		}

		public override void SetDefaults()
		{
			item.damage = 52;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 8;
			item.rare = 4;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 20;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 20f;
			item.useAnimation = 20;
			item.shoot = mod.ProjectileType("SmallBook");
			item.value = Item.sellPrice(gold: 1);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Book, 10);
			recipe.AddIngredient(ItemID.SpellTome, 1);
			recipe.AddIngredient(ItemID.SoulofLight, 12);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}