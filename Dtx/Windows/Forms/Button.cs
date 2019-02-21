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
		//protected System.Drawing.Color CurrentBackColor;

		//protected override void OnMouseEnter(EventArgs e)
		//{
		//	base.OnMouseEnter(e);

		//	CurrentBackColor = BackColor;

		//	BackColor = System.Drawing.Color.Khaki;
		//}

		//protected override void OnMouseLeave(EventArgs e)
		//{
		//	base.OnMouseLeave(e);

		//	BackColor = CurrentBackColor;
		//}
		// /Solution (2)



		// Solution (3)
		//public System.Drawing.Color HoverBackColor;

		//protected System.Drawing.Color CurrentBackColor;

		//protected override void OnMouseEnter(EventArgs e)
		//{
		//	base.OnMouseEnter(e);

		//	CurrentBackColor = BackColor;

		//	BackColor = HoverBackColor;
		//}

		//protected override void OnMouseLeave(EventArgs e)
		//{
		//	base.OnMouseLeave(e);

		//	BackColor = CurrentBackColor;
		//}
		// /Solution (3)



		// Solution (4)
		//public System.Drawing.Color HoverBackColor { get; set; }

		//protected System.Drawing.Color CurrentBackColor;

		//protected override void OnMouseEnter(EventArgs e)
		//{
		//	base.OnMouseEnter(e);

		//	CurrentBackColor = BackColor;

		//	BackColor = HoverBackColor;
		//}

		//protected override void OnMouseLeave(EventArgs e)
		//{
		//	base.OnMouseLeave(e);

		//	BackColor = CurrentBackColor;
		//}
		// /Solution (4)



		// Solution (5)
		[System.ComponentModel.DefaultValue(typeof(System.Drawing.Color), "Khaki")]
		public System.Drawing.Color HoverBackColor { get; set; }

		protected System.Drawing.Color CurrentBackColor;

		protected override void OnMouseEnter(EventArgs e)
		{
			CurrentBackColor = BackColor;

			BackColor = HoverBackColor;
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			BackColor = CurrentBackColor;
		}
		// /Solution (5)
	}
}
