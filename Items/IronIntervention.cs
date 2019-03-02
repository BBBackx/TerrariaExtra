using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class IronIntervention : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hallowed Havoc");
            Tooltip.SetDefault("Shoots sharp pieces of hallowed bars"
            + "\nSome say getting hit by this is more painful than stepping on a lego brick");
		}

		public override void SetDefaults()
		{
			item.damage = 57;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 15;
			item.rare = 5;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 30;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 30;
			item.useAnimation = 30;
			item.shoot = mod.ProjectileType("HallowedGlass");
			item.value = Item.sellPrice(gold: 9);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 14);
			recipe.AddIngredient(ItemID.Ichor, 12);
            recipe.AddIngredient(ItemID.Glass, 60);
            recipe.AddIngredient(ItemID.SpellTome, 1);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}