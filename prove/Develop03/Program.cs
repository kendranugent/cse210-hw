using System;

class Program
{
    static void Main(string[] args)
    {
       Scripture scripture1 = new Scripture("D&C", 6, 36, "Look unto me in every thought; doubt not, fear not.");
       scripture1.Practice();
       
       Scripture scripture2 = new Scripture("D&C", 6, 36, 37, "Behold the wounds which pierced my side, and also the prints of the nails in my hands and feet; be faithful, keep my commandments, and ye shall inherit the kingdom of heaven. Amen.");
       scripture1.Practice();
    }
}