using ApiClientes.Database.Models;
using ApiClientes.Services.DTOs;

namespace ApiClientes.Services.Parsers
{
    public class EnderecoParser
    {
        public static TbEndereco ToTbEndereco(CriarEnderecoDTO dto)
        {
            return new TbEndereco
            {
                Cep = dto.Cep,
                Logradouro = dto.Logradouro,
                Numero = dto.Numero,
                Complemento = dto.Complemento,
                Bairro = dto.Bairro,
                Cidade = dto.Cidade,
                Uf = dto.Uf
            };
        }

        public static EnderecoDTO ToEnderecoDTO(TbEndereco endereco)
        {
            return new EnderecoDTO
            {
                Id = endereco.Id,
                Cep = endereco.Cep,
                Logradouro = endereco.Logradouro,
                Numero = endereco.Numero,
                Complemento = endereco.Complemento,
                Bairro = endereco.Bairro,
                Cidade = endereco.Cidade,
                Uf = endereco.Uf,
                Clienteid = endereco.Clienteid
            };
        }
    }
}
    