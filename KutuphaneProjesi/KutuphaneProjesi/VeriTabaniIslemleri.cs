using System.Data.SqlClient;

namespace KutuphaneProjesi
{
    internal class VeriTabaniIslemleri
    {
        string baglantiCumlesi =
            "Data Source=DESKTOP-LDME0PG;Initial Catalog=KutuphaneVeriTabani;Integrated Security=True";

        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            SqlConnection.ClearPool(baglanti);
            return baglanti;
        }
    }
}
