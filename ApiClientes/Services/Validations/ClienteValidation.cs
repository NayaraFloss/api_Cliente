using System;
using System.Linq;
using ApiClientes.Controllers;
using ApiClientes.Services.DTOs;
using ApiClientes.Services.Exceptions;

namespace ApiClientes.Services.Validations
{
    public class ClienteValidation
    {
        private static readonly int[] sourceArray = new[] { 0, 1, 2, 3, 99 };

        public static void ValidarCriarCliente(
           CriarClienteDTO criarClienteDTO)
        {
            if (string.IsNullOrEmpty(criarClienteDTO.Nome))
                throw new BadRequestException(
                "Nome é obrigatório");

            if (string.IsNullOrEmpty(criarClienteDTO.Documento))
                throw new BadRequestException(
                "Documento é obrigatório");

            if (!sourceArray.Contains (
                criarClienteDTO.Tipodoc))
                throw new BadRequestException (
                    "Tipo de documento não suportado");
           
          //  return true;
        }

        internal static void ValidarAtualizarCliente(AtualizarClienteDTO body)
        {
            throw new NotImplementedException();
        }
    }
}
