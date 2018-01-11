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
	}
}
