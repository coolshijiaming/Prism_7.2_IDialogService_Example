using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using Prism_IDialogService_Example.Models;
using Prism_IDialogService_Example.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Prism_IDialogService_Example.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        readonly IDialogService _dialogService;

        public ICommand ShowDialog { get; set; }

        Payment payment;
        public Payment Payment
        {
            get { return payment; }
            set { SetProperty(ref payment, value); }
        }

        public MainWindowViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
            ShowDialog = new DelegateCommand(ExecuteShowDialog);
        }

        void ExecuteShowDialog()
        {
            _dialogService.ShowDialog("NewPaymentDialogView", null, result =>
            {
                if (result.Result == ButtonResult.OK)
                {
                    Payment = result.Parameters.GetValue<Payment>("Payment");
                }   
            });
        }
    }
}
