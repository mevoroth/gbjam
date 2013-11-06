using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace GameJam.Settings
{
	class Controls
	{
		private static Controls inst;
		private static Object mutex = new Object();

		private Keys forward = Keys.Up;
		private Keys backward = Keys.Down;
		private Keys moveleft = Keys.Left;
		private Keys moveright = Keys.Right;
		private Keys primary = Keys.X;
		private Keys secondary = Keys.W;

		public Keys Forward
		{
			get { return forward; }
			set { forward = value; }
		}
		public Keys Backward
		{
			get { return backward; }
			set { backward = value; }
		}
		public Keys MoveLeft
		{
			get { return moveleft; }
			set { moveleft = value; }
		}
		public Keys MoveRight
		{
			get { return moveright; }
			set { moveright = value; }
		}
		public Keys Primary
		{
			get { return primary; }
			set { primary = value; }
		}
		public Keys Secondary
		{
			get { return secondary; }
			set { secondary = value; }
		}

		public static Controls Get
		{
			get
			{
				lock (mutex)
				{
					if (inst == null)
					{
						inst = new Controls();
					}
					return inst;
				}
			}
		}
	}
}
