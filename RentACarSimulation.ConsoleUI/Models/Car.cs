﻿
namespace RentACarSimulation.ConsoleUI.Models;

public sealed class Car : Entity<Guid>
{
    public Car()
    {
        
    }

    public Car(Guid id, int colorId, int fuelId, int transmissionId, string carState,
        int kiloMeter, short modelYear, string plate,string brandName, string modelName ,double dailyPrice)
    {
        Id = id;
        ColorId = colorId;
        FuelId = fuelId;
        TransmissionId = transmissionId;
        CarState = carState;
        KiloMeter = kiloMeter;
        ModelYear = modelYear;
        Plate = plate;
        BrandName = brandName;
        ModelName = modelName;
        DailyPrice = dailyPrice;
    }
    public int ColorId { get; set; }
    public int FuelId { get; set; }
    public int TransmissionId { get; set; }
    public string CarState { get; set; }
    public int? KiloMeter { get; set; }
    public short? ModelYear { get; set; }
    public string? Plate { get; set; }
    public string? BrandName { get; set; }
    public string? ModelName { get; set; }
    public double? DailyPrice { get; set; }


    public override string ToString()
    {
        return $"Id : {Id} Color Id : {ColorId} FuelId : {FuelId} TransmissionId : {TransmissionId} CarState : {CarState} KiloMeter : {KiloMeter}" +
            $"Model Year : {ModelYear} Plate : {Plate} BrandName : {BrandName} ModelName : {ModelName} DailPrice : {DailyPrice}";
    }
}
