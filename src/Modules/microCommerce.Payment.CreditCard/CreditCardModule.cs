﻿using microCommerce.Module.Core;
using System;

namespace microCommerce.Payment.CreditCard
{
    public class CreditCardModule : IPaymentModule
    {
        public void Install()
        {
            throw new NotImplementedException();
        }

        public void Uninstall()
        {
            throw new NotImplementedException();
        }

        public ModuleInfo ModuleInfo { get; set; }
    }
}