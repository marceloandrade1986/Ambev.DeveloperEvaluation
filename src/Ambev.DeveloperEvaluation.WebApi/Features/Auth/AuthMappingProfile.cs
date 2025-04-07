using System;
using Ambev.DeveloperEvaluation.Application.Auth.AuthenticateUser;
using Ambev.DeveloperEvaluation.WebApi.Features.Auth.AuthenticateUserFeature;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Auth
{
	public class AuthMappingProfile: Profile
	{
		public AuthMappingProfile()
		{
            // Mapeamento do request da API para o command da aplicação
            CreateMap<AuthenticateUserRequest, AuthenticateUserCommand>();

            // Mapeamento do resultado da aplicação para a resposta da API
            CreateMap<AuthenticateUserResult, AuthenticateUserResponse>();
        }
	}
}

