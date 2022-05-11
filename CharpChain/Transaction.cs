using System;
using System.Collections.Generic;
using System.Text;

namespace CharpChain
{
    // kim kime ne göndermiş onun bilgisi tutulur
    class Transaction
    {
        public string Sender { get; set; }
        //coin gönderen
        public string Receiver { get; set; }
        //coin alan
        public float Value { get; set; }
        //coin sayısı
    }
}
