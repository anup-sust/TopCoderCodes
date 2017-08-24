using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class CrossWord
    {
        public int countWords(String[] board, int size)
        {
            int totalMatch = 0;
            for (int i = 0; i < board.Length; i++)
            {
                totalMatch += GetSlotSepcified(board[i], size);
            }

            return totalMatch;
        }

        private int GetSlotSepcified(string line, int size)
        {
            int currentMatch = 0;
            int match = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '.')
                {
                    currentMatch++;
                }
                if (line[i] == 'X' || i + 1 == line.Length)
                {
                    if (currentMatch == size)
                    {
                        match++;
                    }
                    currentMatch = 0;
                }
            }

            return match;
        }
    }
}
