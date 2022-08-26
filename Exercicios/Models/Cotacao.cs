using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Exercicios.Models
{
    public class Cotacao
    {
       
       [Display(Name = "Cotação do Dollar")]
       public double CotacaoDollar { get; set; }

       [Display(Name = "Seu Saldo em Dollar")]
       public double SaldoDollar { get; set; }

       [Display(Name = "Seu Saldo em Reais")] 
       public double SaldoReais { get => CalcularReais(); }
       
       private double CalcularReais () {
       return SaldoDollar * CotacaoDollar;

       }
    }
}