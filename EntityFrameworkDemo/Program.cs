using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new EntityFrameworkDemoContext())
            {
                var idDasPessoasTudo = dbContext.PESSOA_TB.Where(p => p.ID_PESSOA >= 1000).Select(p => p.ID_PESSOA).ToList();

                var idDaspessoasTudoV2 = (from p in dbContext.PESSOA_TB
                                         where p.ID_PESSOA >= 1000
                                         select p.ID_PESSOA).ToList();
            }
        }
    }
}
