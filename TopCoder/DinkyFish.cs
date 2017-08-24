namespace TopCoder
{
    public class DinkyFish
    {
        public int monthsUntilCrowded(int tankVolume, int maleNum, int femaleNum)
        {
            var totalFish = maleNum + femaleNum;
            var extra = 0;
            var month = 0;

            if (maleNum < femaleNum)
            {
                extra = femaleNum - maleNum;
            }
            else
            {
                extra = maleNum - femaleNum;
            }

            while (tankVolume * 2 >= totalFish)
            {
                totalFish = (totalFish - extra) * 2 + extra;
                month++;
            }

            return month;
        }
    }
}