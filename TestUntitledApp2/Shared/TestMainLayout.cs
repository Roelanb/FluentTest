using Bunit;
using Microsoft.Extensions.DependencyInjection;
using UntitledApp2.Shared;

namespace TestUntitledApp2
{
	[Collection("UntitledApp2")]
	public class TestMainLayout
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbNavbarModule),
				typeof(IgbIconButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbNavDrawerModule),
				typeof(IgbButtonModule));
			var componentUnderTest = ctx.RenderComponent<MainLayout>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
