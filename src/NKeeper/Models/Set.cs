namespace NKeeper.Models
{
    public enum Set
    {
        Invalid = 0,
        Core = 2,
        Expert1 = 3,
        Reward = 4,
        Missions = 5,
        Promo = 11,
        Naxx = 12,
        GVG = 13,
        BRM = 14,
        TGT = 15,
        Hero_Skins = 17,
        LOE = 20,
        OG = 21,

        // Aliased from the original enums
        FP1 = 12,
        PE1 = 13,

        // Renamed
        FP2 = BRM,
        PE2 = TGT,
    }
}