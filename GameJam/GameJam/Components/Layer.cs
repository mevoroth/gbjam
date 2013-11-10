using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameJam.Components
{
	public abstract class Layer
	{
		public class LayerComparer : IComparer<Layer>
		{
			public int Compare(Layer l1, Layer l2)
			{
				//if (l1.Priority > l2.Priority)
				//    return -1;
				if (l1.Priority < l2.Priority)
					return 1;
				return -1;
			}
		}
		private int priority;
		private Vector2 position;

		public int Priority
		{
			get { return priority; }
		}

		public virtual Vector2 Position
		{
			get { return position; }
			set { position = value; }
		}

		public Layer(int priority)
		{
			// TODO: Complete member initialization
			this.priority = priority;
		}

		public abstract void next();
		public abstract void Draw(SpriteBatch sb);
	}
}
