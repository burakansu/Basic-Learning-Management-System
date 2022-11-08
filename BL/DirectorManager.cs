using DB;
using OL;

namespace BL
{
    public class DirectorManager
    {
        SQL sQL = new SQL();
        public ObjDirector GetDirector(int Director_ID)
        {
            return sQL.Single<ObjDirector>("select * from TblMudurler where Mudur_ID=" + Director_ID);
        }
    }
}