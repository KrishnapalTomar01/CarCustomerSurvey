namespace dotnet_core_ts.Models;
using System.ComponentModel.DataAnnotations;
public class CarType
{
    public string CarMake { get; set; }
    public string ModelName { get; set; }
}
public enum Gender
{
    M,
    F,
    Other
}
public enum DriveTrain
{
    FWD,
    RWD,
    DontKnow
}
public class UserResponse
{
    [Required(ErrorMessage = "Please enter age")]
    [Range(1,100)]
    public int Age { get; set; }
    [Required]
    public Gender Gender { get; set; }
    public bool HasDrivingLicense { get; set; }
    public bool IsFirstCar { get; set; }
    public DriveTrain DriveTrain { get; set; }
    public bool IsWorriedForEmissions { get; set; }
    public int NumberOfCars { get; set; }
    public List<CarType> CarTypes { get; set; }
}