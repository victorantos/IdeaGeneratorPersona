namespace IdeaGeneratorPersona.WinUI;

internal class RadImageButtonHandler : ImageButtonHandler
	{
		protected override Button CreatePlatformView()
		{
			return new RadImageButton
			{
				VerticalAlignment = VerticalAlignment.Stretch,
				HorizontalAlignment = HorizontalAlignment.Stretch,
				Content = new Image
				{
					VerticalAlignment = VerticalAlignment.Center,
					HorizontalAlignment = HorizontalAlignment.Center,
					Stretch = Stretch.Uniform,
				}
			};
		}
	}
