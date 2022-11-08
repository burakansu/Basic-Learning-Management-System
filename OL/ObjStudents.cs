namespace OL
{
    public class ObjStudents : DBObjects.ObjDBStudents
    {
        public string FullName
        {
            get
            {
                return this.Ogrenci_Ad + " " + this.Ogrenci_Soyad;
            }
        }
    }
}
