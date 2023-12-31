﻿namespace HackatonFIAPAlura.Web.ViewModels;

public class EquipamentListViewModel
{
    public int Id { get; set; }
    public string EquipmentName { get; set; }
    public bool IsInGoodCondition { get; set; }
    public bool IsAPiece { get; set; }
    public string DonorName { get; set; }
}