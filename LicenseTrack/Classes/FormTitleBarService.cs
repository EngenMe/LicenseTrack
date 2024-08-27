using LicenseTrack.Interfaces;
using System.Drawing;
using System.Windows.Forms;

namespace LicenseTrack.Classes
{
    public class FormTitleBarService : IFormTitleBarService
    {
        private FormWindowState _previousWindowState;
        private Rectangle _previousBounds;

        private bool _IsWindowMaximized(Form form)
        {
            return form.WindowState == FormWindowState.Maximized;
        }
        private bool _IsBorderStyleNone(Form form)
        {
            return form.FormBorderStyle == FormBorderStyle.None;
        }
        private void _ReturnFormToOriginalState(Form form)
        {
            form.WindowState = _previousWindowState;
            form.Bounds = _previousBounds;
        }
        private void _RegisterOriginalWindowState(Form form)
        {
            _previousWindowState = form.WindowState;
            _previousBounds = form.Bounds;
        }
        private void _MaximizeWindowToFullScreen(Form form)
        {
            form.WindowState = FormWindowState.Maximized;
        }
        public void ToggleForm(Form form)
        {
            if (_IsWindowMaximized(form) && _IsBorderStyleNone(form))
            {
                _ReturnFormToOriginalState(form);
            }
            else
            {
                _RegisterOriginalWindowState(form);
                _MaximizeWindowToFullScreen(form);
            }
        }

        public void MinimizeForm(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        public void ExitForm()
        {
            Application.Exit();
        }
    }
}
