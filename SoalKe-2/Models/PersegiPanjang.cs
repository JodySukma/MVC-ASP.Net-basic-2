using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoalKe_2.Models
{
    public class PersegiPanjang
    {
        //private double _panjang;
        //private double _lebar;
        //private double _hitungLuas;
        //private double _hitungKeliling;

        //public double Panjang { get => _panjang; set => _panjang = value = 0; }
        //public double Lebar { get => _lebar; set => _lebar = value = 0; }
        //public double HitungLuas {
        //    get => _hitungLuas;
        //    set => _hitungLuas = _panjang * _lebar;
        //}
        //public double HitungKeliling {
        //    get => _hitungKeliling;
        //    set => _hitungKeliling = 2 * (_panjang + _lebar);
        //}
        public double Panjang { get; set; } = 0;
        public double Lebar { get; set; } = 0;
        public double Luas => Panjang * Lebar;
        public double Keliling => 2 * (Panjang + Lebar);
    }
}
