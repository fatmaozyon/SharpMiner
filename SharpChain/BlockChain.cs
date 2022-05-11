using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpChain
{
    public class BlockChain
    {
        public List<Block> Items { get; set; }
        //Blockchain içindeki bloklarımız

        private int Difficulty;
        public BlockChain(Block genesisBlock)
        {
            Difficulty = 2;
            Items = new List<Block>();
            Items.Add(genesisBlock);
        }

        public string GenerateHash(Block blockToGenerate)
        {
            SHA256Manager sHA256 = new SHA256Manager();
            return sHA256.GetHash(blockToGenerate.ToString());
        }

        public void Mine(Block blockToAdd)
        {
            blockToAdd.PrevHash = Items[Items.Count - 1].Hash;
            while (true)
            {
                blockToAdd.Nonce++;
                blockToAdd.Hash = GenerateHash(blockToAdd);
                if (IsValid(blockToAdd))
                {
                    break;
                }
            }
            Items.Add(blockToAdd);

        }
        private bool IsValid(Block blockToAdd)
        {
            string Zeros = "000000000000000000000000000000000000000000";
            return blockToAdd.Hash.StartsWith(Zeros.Substring(0, Difficulty));
        }
        private bool IsValidPreviousBlock(Block currentBlock, Block prevBlock)
        {
            var prevIsValid = IsValid(prevBlock);
            var hashIsCorrect = currentBlock.PrevHash == prevBlock.Hash;
            var currentIsValid = IsValid(currentBlock);
            return prevIsValid && hashIsCorrect && currentIsValid;

        }
        private bool IsValidChain(List<Block> blockChain)
        {
            if (blockChain.Count < 2)
                return true;
            for (int i = 1; i < blockChain.Count; i += 2)
            {
                if (!IsValidPreviousBlock(blockChain[i + 1], blockChain[i]))
                    return false;
            }
            if (!IsValidPreviousBlock(blockChain[blockChain.Count - 1], blockChain[blockChain.Count - 2]))
                return false;
            return true;
        }

        private bool ResolveConflicts()
        {
            return true;
        }


    }
}
