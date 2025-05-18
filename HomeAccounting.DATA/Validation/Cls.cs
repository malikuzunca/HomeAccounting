using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccounting.DATA.Validation
{
    public class Cls
    {
        #region Sonuç Dönüş Model
        public class ResultModel
        {
            public int resultType { get; set; }
            public string resultCaption { get; set; }
            public string resultMessage { get; set; }
            public string resultClass { get; set; }
        }
        #endregion

        #region Kullanıcı
        public class UserList
        {
            public string? userID { get; set; }
            public int loginType { get; set; }
            public string? userName { get; set; }
            public string? email { get; set; }
            public string? nameSurname { get; set; }
            public string? phone { get; set; }
            public string? company { get; set; }
            public DateTime registerDate { get; set; }
            public bool? lockoutEnabled { get; set; }
            public DateTimeOffset? lockoutEnd { get; set; }
        }
        public class UserGetModel
        {
            public string userID { get; set; }
            public string userName { get; set; }
            public string userEmailAddress { get; set; }
            public string nameSurname { get; set; }
            public string phoneNumber { get; set; }
            public string? company { get; set; }
        }

        public class AccountUpdateModel
        {
            public string nameSurname { get; set; }
            public string emailAddress { get; set; }
            public string phoneNumber { get; set; }
            public string company { get; set; }
        }

        public class PasswordUpdateModel
        {
            public string emailAddress { get; set; }
            public string newPassword { get; set; }
            public string confirmPassword { get; set; }
        }
        #endregion

        #region Dil Tab Model
        public class LangItem
        {
            public int langID { get; set; }
            public string? caption { get; set; }
            public string? shortText { get; set; }
            public string? content { get; set; }
            public string? title { get; set; }
            public string? description { get; set; }
            public string? prdCode { get; set; }
            public string? url { get; set; }
        }
        #endregion
    }
}
