using OperacionesApp.ViewModels;

namespace OperacionesApp.Views;

public partial class OperacionesAppView : TabbedPage
{
	OperacionesAppViewModel ViewModel;
	public OperacionesAppView()
	{
		InitializeComponent();
		ViewModel = new OperacionesAppViewModel();
		
	}
}