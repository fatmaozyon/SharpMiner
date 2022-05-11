using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpChain
{
    //kim kime ne göndermiş onun bilgisi tutulur
    public class Transaction
    {
        public string Sender { get; set; }
        //coin gönderen
        public string Receiver { get; set; }
        //coin alan
        public float Value { get; set; }
        //coin sayısı

        public override string ToString()
        {
            return Sender + ":" + Receiver + ":" + Value;
           // return base.ToString();
        }
    }
}
