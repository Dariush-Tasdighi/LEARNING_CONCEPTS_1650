using System;

namespace Dtx.Windows.Forms
{
	public class Button : System.Windows.Forms.Button
	{
		public Button() : base()
		{
			HoverBackColor =
				System.Drawing.Color.Khaki;
		}

		// Solution (1)
		//protected override void OnMouseEnter(EventArgs e)
		//{
		//	base.OnMouseEnter(e);

		//	BackColor = System.Drawing.Color.Khaki;
		//}

		//protected override void OnMouseLeave(EventArgs e)
		//{
		//	base.OnMouseLeave(e);

		//	BackColor = System.Drawing.SystemColors.Control;
		//}
		// /Solution (1)



		// Solution (2)
		//protected System.Drawing.Color currentBackColor;

		//protected override void OnMouseEnter(EventArgs e)
		//{
		//	base.OnMouseEnter(e);

		//	currentBackColor = BackColor;

		//	BackColor = System.Drawing.Color.Khaki;
		//}

		//protected override void OnMouseLeave(EventArgs e)
		//{
		//	base.OnMouseLeave(e);

		//	BackColor = currentBackColor;
		//}
		// /Solution (2)



		// Solution (3)
		//public System.Drawing.Color HoverBackColor;

		//protected System.Drawing.Color currentBackColor;

		//protected override void OnMouseEnter(EventArgs e)
		//{
		//	base.OnMouseEnter(e);

		//	currentBackColor = BackColor;

		//	BackColor = HoverBackColor;
		//}

		//protected override void OnMouseLeave(EventArgs e)
		//{
		//	base.OnMouseLeave(e);

		//	BackColor = currentBackColor;
		//}
		// /Solution (3)



		// Solution (4)
		//public System.Drawing.Color HoverBackColor { get; set; }

		//protected System.Drawing.Color currentBackColor;

		//protected override void OnMouseEnter(EventArgs e)
		//{
		//	base.OnMouseEnter(e);

		//	currentBackColor = BackColor;

		//	BackColor = HoverBackColor;
		//}

		//protected override void OnMouseLeave(EventArgs e)
		//{
		//	base.OnMouseLeave(e);

		//	BackColor = currentBackColor;
		//}
		// /Solution (4)



		// Solution (5)
		[System.ComponentModel.DefaultValue(typeof(System.Drawing.Color), "Khaki")]
		public System.Drawing.Color HoverBackColor { get; set; }

		protected System.Drawing.Color currentBackColor;

		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);

			currentBackColor = BackColor;

			BackColor = HoverBackColor;
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);

			BackColor = currentBackColor;
		}
		// /Solution (5)
	}
}
