﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBestellingBL {
    public class BestellingException : Exception {
        public BestellingException() {
        }

        public BestellingException(string? message) : base(message) {
        }

        public BestellingException(string? message, Exception? innerException) : base(message, innerException) {
        }
    }
}
