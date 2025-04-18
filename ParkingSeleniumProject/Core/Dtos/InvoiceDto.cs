namespace ParkingSeleniumProject.Core.Dtos
{
    public class InvoiceDto
    {
        public int Id { get; set; }
        public DateTime DateGenerated { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
