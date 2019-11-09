using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telex.Business.Services.Interfaces;

namespace Telex.WinForm.Forms
{
    public partial class LoginForm : Form
    {
        private readonly ITelegramService _telegramService;

        public LoginForm(ITelegramService telegramService)
        {
            _telegramService = telegramService;
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
