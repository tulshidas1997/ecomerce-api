using CleanArchitecture.Core.Types;
using Core.Dtos;

namespace CleanArchitecture.Core.Interfaces.Services;

public interface IAuthService
{
    Task<LoginResult> LoginAsync(LoginPayload request);
}