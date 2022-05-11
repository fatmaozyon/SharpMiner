using System;
using System.Collections.Generic;
using System.Text;

namespace CharpChain
{
    class Block
    {
        public int Nonce { get; set; }
        //Proof of Work için gerekli Nonce 

        public List<Transaction> Data { get; set; }
        //Transaction'ların tutulduğu kısım

        public string PrevHash { get; set; }
        //önceki bloğun hash değeri

        public string  Hash { get; set; }
        //bloğun hash değeri

    }

    public DateTime TimeStamp { get; set; }
    //Blok oluşturulduğu tarih


    public override string ToString()
    {

        //return base.ToString();
    }
}
