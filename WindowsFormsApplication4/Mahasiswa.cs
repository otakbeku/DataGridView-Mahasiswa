using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    public class Mahasiswa
    {
        private int _nim;
        private string _nama;
        private string _alamat;

        public int NIM
        {
            get { return _nim; }
            set { _nim = value; }
        }

        public string NamaMahasiswa
        {
            get { return _nama; }
            set { _nama = value; }
        }

        public string AlamatMahasiswa
        {
            get { return _alamat; }
            set { _alamat = value; }
        }

        public Mahasiswa()
        {
            this._nim = 0;
            this._nama = "Mahasiswa Baru";
        }

        public Mahasiswa(int nim, string nama)
        {
            this._nim = nim;
            this._nama = nama;
        }
    }
}
