using Microsoft.AspNetCore.Http;
using sattec.Identity.Application.Common.Models;

namespace sattec.Identity.Application.Common.Interfaces;

public interface IIdentityService 
{
    Task<string> GetUserNameAsync(string userId);
    Task<bool> IsInRoleAsync(string userId, string role);
    Task<bool> AuthorizeAsync(string userId, string policyName);
    Task<string> CreateUserAsync(string userName, string PhoneNumber, string password);
    Task<Result> GetByMobileVerificationCode(string verifiCode);
    Task<string> GetByPhoneNumber(string phoneNumber);
    Task<Result> FindByPhoneNumber(string phoneNumber);
    Task<Result> DeleteUserAsync(string userId);
    Task<(string token, string userId)> LoginByUserPassAsync(string phoneNumber, string password);
    Task<Result> ResetPassword(string code, string newPassword);
    Task<Result> CreateUserIdentityInfo(Guid id, string firstName, string lastName, string fatherName, string nationalId, string identitySerialNumber, DateTime birthday, string birthPlace);
    Task<Result> CreateContactInformation(Guid id, string essentialPhone, string phoneNumber, string postalCode, string address, string country, string state, string city, string description);
    Task<Result> createInsuranceInfo(string userId, string name, string InsuranceNumber);
    Result CreateBankInfo(string userId, bool isDefaultAccount, Guid bankId, string title, string accountNo, string cardNo, string iban, string accountName, string description);
    Result UpdateBankInfo(string userId, bool isDefaultAccount, Guid bankId, string title, string accountNo, string cardNo, string iban, string accountName, string description);
    Task<Result> createDocument(string userId, string description, IFormFile file);
    Task<Result> CheckVerificationAsync(string phoneNumber, string code);
    Task<string> StartVerificationAsync(string phoneNumber);
}
