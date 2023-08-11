using System.ComponentModel.DataAnnotations;

public class CongTy
{
    [Key]
    public int Id { get; set;}
    public string Name { get; set; }
    public string DiaChi { get; set; }
    public DateTime NgayThanhLap { get; set; }
}