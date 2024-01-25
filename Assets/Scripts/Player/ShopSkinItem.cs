[System.Serializable]
public class ShopSkinItem
{
    public SkinType type;
    public int price;
    public bool isUnlocked;

    public bool UnlockSkin()
    {
        return isUnlocked;
    }
}