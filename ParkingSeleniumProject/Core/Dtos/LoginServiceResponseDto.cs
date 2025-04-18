namespace ParkingSeleniumProject.Core.Dtos
{
    public class LoginServiceResponseDto
    {
        public string NewToken { get; set; }
        //This would be returned to frontend
        public UserInfoResult UserInfo { get; set; }
    }
}
