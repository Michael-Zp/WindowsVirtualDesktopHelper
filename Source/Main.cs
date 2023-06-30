using System;
using System.Windows.Forms;
using WindowsVirtualDesktopHelper.Util;

namespace WindowsVirtualDesktopHelper {
	class Program {

		public static KeyboardHook hook;

		[STAThread]
		public static void Main(string[] args) {
			try {

				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				var app = new App();

				Application.Run(app.SettingsForm);
			} catch (Exception e) {
				// Global error handler
				Console.Error.WriteLine(e);
				var form = new ErrorForm();
				form.UpdateUIForError(e);
				//form.Show();
				Application.Run(form);
			}
		}
	}
}
