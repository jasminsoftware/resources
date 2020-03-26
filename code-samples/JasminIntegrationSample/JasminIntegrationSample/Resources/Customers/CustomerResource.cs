﻿namespace Jasmin.IntegrationSample
{
    internal class CustomerResource
    {
        #region Internal Properties

        public string CustomerGroup { get; set; }

        public string PaymentMethod { get; set; }

        public string PaymentTerm { get; set; }

        public string PartyTaxSchema { get; set; }

        public bool Locked { get; set; }

        public bool OneTimeCustomer { get; set; }

        public bool EndCustomer { get; set; }

        public string BaseEntityKey { get; set; }

        public string PartyKey { get; set; }

        #endregion
    }
}
