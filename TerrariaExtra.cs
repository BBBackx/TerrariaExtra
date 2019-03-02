using System.Linq;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.Reflection;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.ModLoader;

namespace TerrariaExtra
{
	class TerrariaExtra : Mod
	{
		public TerrariaExtra()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true,
			};
		}

		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Silver Bar", new int[]
			{
					ItemID.SilverBar,
					ItemID.TungstenBar
			});
			RecipeGroup.RegisterGroup("TT:SilverBar", group);

			group = new RecipeGroup(() => Lang.misc[37] + " Evil Biome Block", new int[]
			{
					ItemID.CrimstoneBlock,
					ItemID.EbonstoneBlock
			});
			RecipeGroup.RegisterGroup("TT:EvilBiomeBlock", group);  
		}

		public override void AddRecipes() {
			// Here is an example of a recipe.
			ModRecipe recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "Paper", 12);
			recipe.AddIngredient(ItemID.Wood, 12);
			recipe.SetResult(ItemID.Book, 6);
			recipe.AddRecipe();
		}	
	}
}