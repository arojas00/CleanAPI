using Member.Application;
using System.Collections.Generic;

namespace Member.Infrastructure
{
    //En esta capa se implementan los adaptadores de interfaz.
    //Esta capa referencia a la capa de Entities y Aplications, ya que son las capas internas.
    public class MemberRepository : IMemberRepository
    {
        public static List<Domain.Member> lstMembers = new List<Domain.Member>()
        {
           new Domain.Member{  Name= "Kevin De Bruyne", Position ="Midfielder" , Age= 32},
           new Domain.Member{  Name= "Vinícius Júnior", Position ="Forward" , Age= 23},
           new Domain.Member{  Name= "Erling Haaland", Position ="Forward" , Age= 23},
           new Domain.Member{  Name= "Kylian Mbappé", Position ="Forward" , Age= 24},
           new Domain.Member{  Name= "Lionel Messi", Position ="Forward" , Age= 36},
           new Domain.Member{  Name= "Yassine Bounou", Position ="Goalkeeper" , Age= 32}
        };
        public List<Domain.Member> GetAllMembers()
        {
            return lstMembers;
        }
    }
}