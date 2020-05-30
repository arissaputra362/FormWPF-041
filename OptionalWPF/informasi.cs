using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalWPF
{
    public class informasi
    {
        private string txtdata1;
        private string txtdata2;
        private string txtdata3;
        private string txtdata4;
        private string txtdata5;

        public string NIMMahasiswa
        {
            get { return txtdata1; }
            set { txtdata1 = value; }
        }

        public string NamaMahasiswa
        {
            get { return txtdata2; }
            set { txtdata2 = value; }
        }

        public string ProgramStudiMahasiswa
        {
            get { return txtdata3; }
            set { txtdata3 = value; }
        }

        public string AsalMahasiswa
        {
            get { return txtdata4; }
            set { txtdata4 = value; }
        }

        public string AlamatTinggalKosMahasiswa
        {
            get { return txtdata5; }
            set { txtdata5 = value; }
        }
    }
}
