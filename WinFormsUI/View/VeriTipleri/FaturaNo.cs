using System;
using System.Collections.Generic;

namespace WinFormsUI.View.VeriTipleri
{
    /// <summary>
    /// Fatura ve irsaliye Numaraları için kullanılan temel sınıf
    /// </summary>
    //[DebuggerStepThrough]
    public class FaturaNo : IDisposable, IEquatable<FaturaNo>
    {
        #region Privates
        private string seri;
        private uint numara;
        #endregion
        /// <summary>
        /// Varsayılan Yapıcı Method
        /// </summary>
        public FaturaNo()
        {
            seri = "__";
            numara = 0;
        }
        /// <summary>
        /// yapıcı method
        /// </summary>
        /// <param name="_seri">string tipinde Fatura Serisi</param>
        public FaturaNo(string _seri)
        {
            Seri = _seri;
            Numara = 0;
        }
        /// <summary>
        /// yapıcı method
        /// </summary>
        /// <param name="_seri">string tipinde Fatura Serisi</param>
        /// <param name="_numara">uint tipinde Fatura Numarası</param>
        public FaturaNo(string _seri, uint _numara)
        {
            if (_seri.Length == 2 && _numara.ToString().Length <= 10)
            {
                Seri = _seri;
                Numara = _numara;
            }
            else
                throw new ArgumentOutOfRangeException("_seri ya da _numara", (_seri.Length + _numara.ToString().Length),
                    "'Fatura No' veri tipinin toplam uzunluğu 12'i geçemez!!!");
        }
        /// <summary>
        /// Kopyalayıcı yapıcı method
        /// </summary>
        /// <param name="_copyFrom">kopyalanacak nesne</param>
        public FaturaNo(FaturaNo _copyFrom)
        {
            this.Numara = _copyFrom.Numara;
            this.Seri = _copyFrom.Seri;
        }
        /// <summary>
        /// Yıkıcı Method
        /// </summary>
        ~FaturaNo()
        {
            this.Dispose();
        }
        /// <summary>
        /// String tipinden veri çekmek için kullanılan fonksiyon
        /// </summary>
        /// <param name="_faturaNo">string metin</param>
        /// <returns>FaturaNo</returns>
        public bool CopyFromString(string _faturaNo)
        {
            bool result = false;
            string s = "__";
            string n = "";

            if (_faturaNo.Length != 12)
                return false;

            s = _faturaNo.Substring(0, 2);
            if ((s != "FA" && s != "FS" &&
                s != "IA" && s != "IS")
                && !char.IsDigit(_faturaNo.Substring(2, 1).ToCharArray()[0]))
                return false;

            for (int i = 2; i < _faturaNo.Length; i++)
                if (_faturaNo[i] != '0')
                {
                    n = _faturaNo.Substring(i, _faturaNo.Length - i);
                    result = true;
                    break;
                }
            if (n == "") return false; else this.Numara = Convert.ToUInt32(n);
            if (s == "__") return false; else this.Seri = s;
            return result;
        }
        /// <summary>
        /// FaturaNo'nun serisi
        /// </summary>
        public string Seri
        {
            get { return seri; }
            set
            {
                if (value == "FA" || value == "FS" || value == "IA" || value == "IS")
                    seri = value;
                else
                    throw new ArgumentException("Belge serisi tanınmıyor\nBeklenen değerler:FA,FS,IA,IS");
            }
        }
        /// <summary>
        /// FaturaNo'nun numarası
        /// </summary>
        public uint Numara
        {
            get { return numara; }
            set
            {
                if (value < uint.MaxValue)
                    numara = value;
                else
                    throw new ArgumentOutOfRangeException("value", value, "'Fatura No' en fazla " + uint.MaxValue.ToString() + " olmalıdır!..");
            }
        }
        /// <summary>
        /// Serisi bilinen FaturaNo'nun bir sonraki değeri
        /// </summary>
        /// <returns>Sonraki FaturaNo</returns>
        public FaturaNo GetNextFaturaNo()
        {
            if (this.numara + 1 <= uint.MaxValue)
                this.numara += 1;
            else
                throw new ArgumentOutOfRangeException("Numara", this.Numara, "Bu seride son numaraya gelinmiş!!!");
            return this;
        }
        #region OPERATOR == !=
        public static bool operator ==(FaturaNo operand1, string operand2)
        {
            if (operand1 is null)
                throw new ArgumentNullException(nameof(operand1));
            if (operand2 is null)
                throw new ArgumentNullException(nameof(operand2));

            FaturaNo ftr = new FaturaNo();
            ftr.CopyFromString(operand2);
            if (operand1.Numara == ftr.Numara && operand1.Seri == ftr.Seri)
                return true;
            else
                return false;
        }
        public static bool operator !=(FaturaNo operand1, string operand2)
        {
            return !(operand1 == operand2);
        }
        public static bool operator ==(string operand2, FaturaNo operand1)
        {
            return operand1 == operand2;
        }
        public static bool operator !=(string operand2, FaturaNo operand1)
        {
            return !(operand1 == operand2);
        }
        public static bool operator ==(FaturaNo left, FaturaNo right)
        {
            return EqualityComparer<FaturaNo>.Default.Equals(left, right);
        }
        public static bool operator !=(FaturaNo left, FaturaNo right)
        {
            return !(left == right);
        }
        #endregion
        #region OPERATOR ++ --
        public static FaturaNo operator ++(FaturaNo ftr)
        {
            ftr.Numara += 1;
            return ftr;
        }
        public static FaturaNo operator --(FaturaNo ftr)
        {
            ftr.Numara -= 1;
            return ftr;
        }
        #endregion
        #region OPERATOR CAST ()
        public static implicit operator FaturaNo(string val)
        {
            FaturaNo ftr = new FaturaNo();
            ftr.CopyFromString(val);
            return ftr;
        }
        public static implicit operator string(FaturaNo val)
        {
            return val.ToString();
        }
        #endregion
        #region Overrides
        /// <summary>
        /// Üzerinde yazılmış ToString Methodu (CopyFromString'in tersidir) 15 hanedir.
        /// </summary>
        /// <returns>Biçimlendirilmiş String tipi</returns>
        public override string ToString()
        {
            string result = "";

            int sifirlarinuzunlugu = 12 - this.seri.Length - this.numara.ToString().Length;

            result += this.seri;
            for (int i = 0; i < sifirlarinuzunlugu; i++)
            {
                result += 0;
            }
            result += this.numara;

            return result;
        }
        /// <summary>
        /// üzerine yazılmış dispose methodu
        /// </summary>
        public void Dispose()
        {
            this.numara = 0;
            this.seri = null;
        }
        /// <summary>
        /// Obje sınıfının mirası
        /// </summary>
        /// <param name="obj">karşılaştırma yapılacak nesne</param>
        /// <returns>true ya da false</returns>
        public override bool Equals(object obj)
        {
            return Equals(obj as FaturaNo);
        }
        /// <summary>
        /// IEquatable<T> arayüzünün implemetastonu
        /// </summary>
        /// <param name="other">karşılaştırma yapılacak nesne</param>
        /// <returns>true ya da false</returns>
        public bool Equals(FaturaNo other)
        {
            return Seri == other.Seri &&
                   Numara == other.Numara;
        }
        /// <summary>
        /// Obje sınıfının mirası
        /// </summary>
        /// <returns>HashCode int</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}