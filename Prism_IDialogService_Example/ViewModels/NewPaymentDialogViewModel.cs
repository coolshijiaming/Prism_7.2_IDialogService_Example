using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using Prism_IDialogService_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Prism_IDialogService_Example.ViewModels
{
    public class NewPaymentDialogViewModel : DialogViewModelBase
    {
        Payment payment;
        public Payment Payment
        {
            get { return payment; }
            set { SetProperty(ref payment, value); }
        }

        public ICommand CancelDialog { get; set; }
        public ICommand ConfirmDialog { get; set; }

        public NewPaymentDialogViewModel()
        {
            Title = "Nieuwe rekening";
            Payment = new Payment();
            CancelDialog = new DelegateCommand(ExecuteCancelDialog);
            ConfirmDialog = new DelegateCommand(ExecuteConfirmDialog);
        }

        void ExecuteCancelDialog()
        {
            RaiseRequestClose(new DialogResult(ButtonResult.Cancel));
        }

        void ExecuteConfirmDialog()
        {
            IDialogParameters dialogParameters = new DialogParameters
            {
                { "Payment", Payment }
            };
            RaiseRequestClose(new DialogResult(ButtonResult.OK, dialogParameters));
        }
    }
}
