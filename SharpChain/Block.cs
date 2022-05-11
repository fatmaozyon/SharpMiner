using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpChain
{
    public class Block
    {
        public int Nonce { get; set; }
        //Proof of Work için gerekli Nonce 

        public List<Transaction> Data { get; set; }
        //Transaction'ların tutulduğu kısım

        public string PrevHash { get; set; }
        //önceki bloğun hash değeri

        public string Hash { get; set; }
        //bloğun hash değeri

        public DateTime TimeStamp { get; set; }
        //blok oluşturulduğu tarih
        

        //SHA256 hash'ini oluştururken kullanacağımız string değerini döndürdük.
        public override string ToString()
        {
            return Nonce + ":" + PrevHash + ":" + TimeStamp.ToString()+ GetDataString();
            //return base.ToString();
        }


        //Transaction'ları stringe dönüştüren metod
        private string GetDataString()
        {
            string res = "";
            foreach(var d in Data)
            {
                res += d.ToString() + ":";
            }
            return res;
        }
    }
}
