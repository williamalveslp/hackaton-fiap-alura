namespace HackatonFIAPAlura.Web.Models;

public class Equipment
{
    public int Id { get; private set; }

    private static int _nextId = 1;
    public string EquipmentName { get; private set; }
    public bool IsInGoodCondition { get; private set; }
    public bool IsAPiece { get; private set; }
    public string DonorName { get; private set; }

    public Equipment(string equipmentName, bool isInGoodCondition, bool isAPiece, string donorName)
    {
        this.Id = _nextId++;
        this.EquipmentName = equipmentName;
        this.IsInGoodCondition = isInGoodCondition;
        this.IsAPiece = isAPiece;
        this.DonorName = donorName;
    }
}