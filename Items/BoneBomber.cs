using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class BoneBomber : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bone Bomber");
            Tooltip.SetDefault("+100% Attack power if you consumed calcium in the last 24 hours");
		}

		public override void SetDefaults()
		{
			item.damage = 33;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 12;
			item.rare = 3;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 32;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 32;
			item.useAnimation = 32;
			item.shoot = mod.ProjectileType("SBone");
			item.value = Item.sellPrice(gold: 2);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bone, 25);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}