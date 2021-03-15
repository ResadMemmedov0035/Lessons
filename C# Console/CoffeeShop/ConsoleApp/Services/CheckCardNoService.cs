using System.Text.RegularExpressions;

namespace MainApp.Services
{
    class CheckCardNoService : ICheckCardNoService
    {
        private Regex regex = new Regex(@"^(AA\d{7}|AZE\d{8})$");

        public bool CheckAzeCardNo(string cardNo)
        {
            return regex.IsMatch(cardNo);
        }
    }
}
