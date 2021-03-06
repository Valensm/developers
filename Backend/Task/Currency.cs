﻿namespace ExchangeRateUpdater
{
    public class Currency
    {
        public Currency(string code)
        {
            this.Code = code;
        }

        /// <summary>
        /// Three-letter ISO 4217 code of the currency.
        /// </summary>
        public string Code { get; }

        public override string ToString()
        {
            return Code;
        }

        public override int GetHashCode()
        {
            return this.Code.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is Currency other && this.Code.Equals(other.Code);
        }
    }
}