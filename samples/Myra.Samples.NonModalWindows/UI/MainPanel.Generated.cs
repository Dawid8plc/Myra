/* Generated by MyraPad at 06.01.2020 23:04:00 */
using Myra.Assets;
using Myra.Graphics2D;
using Myra.Graphics2D.TextureAtlases;
using Myra.Graphics2D.UI;
using Myra.Graphics2D.Brushes;

#if !XENKO
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#else
using Xenko.Core.Mathematics;
#endif

namespace Myra.Samples.NonModalWindows.UI
{
	partial class MainPanel: Panel
	{
		private void BuildUI()
		{
			_button1 = new TextButton();
			_button1.Text = "Window 1";
			_button1.Toggleable = true;
			_button1.Id = "_button1";

			_button2 = new TextButton();
			_button2.Text = "Window 2";
			_button2.Toggleable = true;
			_button2.Id = "_button2";

			_button3 = new TextButton();
			_button3.Text = "Window 3";
			_button3.Toggleable = true;
			_button3.Id = "_button3";

			var horizontalStackPanel1 = new HorizontalStackPanel();
			horizontalStackPanel1.Spacing = 8;
			horizontalStackPanel1.Widgets.Add(_button1);
			horizontalStackPanel1.Widgets.Add(_button2);
			horizontalStackPanel1.Widgets.Add(_button3);


            _labelOverGui = new Label();
			_labelOverGui.Text = "Is mouse over GUI: true";
			_labelOverGui.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Bottom;
			_labelOverGui.Id = "_labelOverGui";


            Widgets.Add(horizontalStackPanel1);
			Widgets.Add(_labelOverGui);
		}

		
		public TextButton _button1;
		public TextButton _button2;
		public TextButton _button3;
		public Label _labelOverGui;
	}
}