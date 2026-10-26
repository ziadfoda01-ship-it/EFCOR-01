using EFCOR_01.ConTexte;
using Microsoft.EntityFrameworkCore;

namespace EFCOR_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using AddDbConTexte dbContext = new();
            #region What is an ORM
            //EFCore هي الربت بين الابلكيشن و الداتا بيز 
            //Dbset <T> بيعرف الابلكيشن انه تيبول 
            // Change TraCker بيسجل اي حاجه بتحصل في البليكيشن 
            // Save Changes  
            //DbContext ده هو الربت بين الداتا بيز 
            //Databease First => Legacey لو الابلكيشن قديم لو ارودي الداتا بيز موجوده 
            // Code First لو الداتا بيز جديده هتعملها من اول وجديد 
            // بيحول من السي شرب للداتا بيز
            
            #endregion
        }
    }
}
