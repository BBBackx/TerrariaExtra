using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class AutumnAgression : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Autumn Agression");
            Tooltip.SetDefault("Jumping into the leaves is not so fun in the Terraria universe...");
		}

		public override void SetDefaults()
		{
			item.damage = 14;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 2;
			item.rare = 2;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 20;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 20;
			item.useAnimation = 20;
			item.shoot = mod.ProjectileType("ALeaf");
			item.value = Item.sellPrice(gold: 2);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddIngredient(ItemID.Acorn, 15);
            recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}