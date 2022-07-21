
namespace OL
{
    public class ObjDirector : DBObjects.ObjDBDirectors
    {
        public string FullName
        {
            get
            {
                return this.Mudur_Ad + " " + this.Mudur_Soyad;
            }
        }
    }
}
