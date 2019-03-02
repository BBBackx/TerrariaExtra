using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class ImpInvasionPlus : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Imp Invasion+");
            Tooltip.SetDefault("Eat like an Imp. Fight like an Imp. Start an Imp revolution. Be the Imp!");
		}

		public override void SetDefaults()
		{
			item.damage = 46;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 7;
			item.rare = 4;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 3;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 3f;
			item.useAnimation = 12;
			item.shoot = ProjectileID.ImpFireball;
			item.value = Item.sellPrice(gold: 2);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddIngredient(ItemID.ObsidianRose, 1);
			recipe.AddIngredient(null, "ImpInvasion", 1);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }    

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(360));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			return true;
		}
	}
}