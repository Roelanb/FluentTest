using Bunit;
using Microsoft.Extensions.DependencyInjection;
using UntitledApp2.Pages;
using UntitledApp2.DocumentsApi;

namespace TestUntitledApp2
{
	[Collection("UntitledApp2")]
	public class TestDocuments
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbGridModule),
				typeof(IgbActionStripModule));
			ctx.Services.AddScoped<IDocumentsApiService>(sp => new MockDocumentsApiService());
			var componentUnderTest = ctx.RenderComponent<Documents>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
