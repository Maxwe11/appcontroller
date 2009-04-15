using System.Windows.Forms;
using ApplicationControllerExample.App;
using ApplicationControllerExample.AppController;
using ApplicationControllerExample.View;
using StructureMap;

namespace ApplicationControllerExample
{

	public class ExampleContext : ApplicationContext
	{
		
		private IApplicationController AppController { get; set; }
		private IContainer Container { get; set; }

		public ExampleContext(IApplicationController appController, IContainer container)
		{
			AppController = appController;
			Container = container;
			MainForm = GetMainForm();
		}

		private Form GetMainForm()
		{
			Form1 mainForm = new Form1();
			new MainPresenter(mainForm, AppController);
			return mainForm;
		}

	}

}