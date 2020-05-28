using Casamento.Data.Context;
using Casamento.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Casamento.Data.Service
{
    public class PessoaService
    {
        AppDbContext context;

        public PessoaService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Pessoa>> GetPessoasAsync()
        {
            var result = context.Pessoas;
            return await Task.FromResult(result.OrderBy(a => a.Nome).AsNoTracking().ToList());
        }

        public async Task<Pessoa> GetPessoaAsync(int id)
        {
            return await context.Pessoas.FindAsync(id);
        }

        public async Task<Pessoa> PostPessoaAsync(Pessoa pessoa)
        {
            context.Add(pessoa);
            await context.SaveChangesAsync();

            return pessoa;
        }

        public async Task<Pessoa> PutPessoaAsync(int id, Pessoa pess)
        {
            var pessoa = await context.Pessoas.FindAsync(id);

            if (pessoa == null)
                return null;

            pessoa.Nome = pess.Nome;
            pessoa.Sobrenome = pess.Sobrenome;

            context.Pessoas.Update(pessoa);
            await context.SaveChangesAsync();

            return pessoa;
        }
    }
}
