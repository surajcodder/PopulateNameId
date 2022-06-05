using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class Class1
    {
    }
    public class Demo
    {
        public string Id { get; set; }
       public string Name { get; set;}
        public List<string> GetName()
        {
            DAL.Demo demo = new DAL.Demo();
             return demo.GetName();
        }
        public string GetIdByName()
        {
            DAL.Demo demo = new DAL.Demo();
            demo.Name = this.Name;
            return demo.GetIdByName();
        }
        public int UpdateIdByName()
        {
            DAL.Demo demo = new DAL.Demo();
            demo.Id = this.Id;
            demo.Name = this.Name;
            return demo.UpdateNameById();
        }

    }
}
