using AutoMapper;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ParkingSeleniumProject.Core.AutoMapper
{
    public class AutoMapperConfigProfile : Profile
    {
        public AutoMapperConfigProfile()
        {

            CreateMap<ReservationDTO, Reservation>();
            CreateMap<Reservation, ReservationDTO>();

            CreateMap<ParkingReservationManagerDTO, ParkingReservationManager>();
            CreateMap<ParkingReservationManager, ParkingReservationManagerDTO>();

            CreateMap<ParkingSpotDTO, ParkingSpot>();
            CreateMap<ParkingSpot, ParkingSpotDTO>();

            CreateMap<PaymentDto, Payment>();
            CreateMap<Payment, PaymentDto>();

            CreateMap<PaymentMethodDto, PaymentMethod>();
            CreateMap<PaymentMethod, PaymentMethodDto>();

            CreateMap<InvoiceDto, Invoice>();
            CreateMap<Invoice, InvoiceDto>();

            CreateMap<ParkingSpaceDto, ParkingSpace>();
            CreateMap<ParkingSpace, ParkingSpaceDto>();

            CreateMap<ParkingSpaceManagerDto, ParkingSpaceManager>();
            CreateMap<ParkingSpaceManager, ParkingSpaceManagerDto>();

            CreateMap<AvailabilityMonitorDto, AvailabilityMonitor>();
            CreateMap<AvailabilityMonitor, AvailabilityMonitorDto>();


        }
    }
