using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class SlapShooter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slap Shooter");
            Tooltip.SetDefault("Slaps your enemies all the way to the moon!");
		}

		public override void SetDefaults()
		{
			item.damage = 59;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 14;
			item.rare = 4;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 32;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.knockBack = 36;
			item.shootSpeed = 32;
			item.useAnimation = 32;
			item.shoot = mod.ProjectileType("Slapper");
			item.value = Item.sellPrice(gold: 4);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SlapHand, 1);
			recipe.AddIngredient(ItemID.SpellTome, 1);
            recipe.AddIngredient(ItemID.Amethyst, 15);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}