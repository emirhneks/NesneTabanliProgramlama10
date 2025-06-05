using System.Data.SqlClient;

namespace KSGKutuphane
{
    internal class VeriTabaniIslemleri
    {
        string baglantiCumlesi =
            "Data Source=DESKTOP-LDME0PG;Initial Catalog=KSGKutuphaneVeriTabani;Integrated Security=True";

        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            SqlConnection.ClearPool(baglanti);
            return baglanti;
        }
    }
}
