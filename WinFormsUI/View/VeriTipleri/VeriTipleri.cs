namespace WinFormsUI.View.VeriTipleri
{
    public class Money
    {
        private int lira;
        private int kurus;

        public Money(int l = 0, int k = 0)
        {
            lira = l;
            kurus = k;
        }

        public Money(decimal money)
        {
            lira = (int)money;
            decimal d = money - lira;
            while (d % 10 != 0)
                d = d * 10;
            kurus = (int)d;
        }

        public static Money operator +(Money money, Money[] args)
        {
            Money sonuc = new Money();
            for (int i = 0; i < args.Length; i++)
            {
                sonuc.lira += args[i].lira;
                sonuc.kurus += args[i].kurus;
            }
            return sonuc;
        }

        public override string ToString()
        {
            return this.ToString(false);
        }

        public string ToString(bool birimliMi = false)
        {
            if (!birimliMi)
                return lira.ToString() + "," + kurus.ToString();
            else
                return lira.ToString() + "," + kurus.ToString() + " TL";
        }
    }
}