using System;

class GravitaionOnMoon
{
    //Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

    static void Main()
    {
        OnMoon(86);
        OnMoon((float)74.6);
        OnMoon((float)53.7);
    }

    static void OnMoon(float weight)
    {
        float onMoon = (17f / 100f) * weight;

        Console.WriteLine("On Earth = {0}; On Moon = {1:0.###}", weight, onMoon);
    }
}
