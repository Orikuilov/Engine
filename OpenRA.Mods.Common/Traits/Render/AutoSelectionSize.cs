#region Copyright & License Information
/*
 * Copyright 2007-2015 The OpenRA Developers (see AUTHORS)
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation. For more information,
 * see COPYING.
 */
#endregion

using System;
using OpenRA.Traits;

namespace OpenRA.Mods.Common.Traits
{
	[Desc("Automatically calculates the targetable area and screen map boundaries from the sprite size.")]
	public class AutoSelectionSizeInfo : ITraitInfo, Requires<RenderSpritesInfo>
	{
		public object Create(ActorInitializer init) { return new AutoSelectionSize(this); }
	}

	public class AutoSelectionSize : IAutoSelectionSize
	{
		public AutoSelectionSize(AutoSelectionSizeInfo info) { }

		public int2 SelectionSize(Actor self)
		{
			var rs = self.Trait<RenderSprites>();
			return rs.AutoSelectionSize(self);
		}
	}
}