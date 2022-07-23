using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1_cs
{
    class Calculadora
    {
        //atributo o caracteristica del objeto
        private Double numero1;
        private Double numero2;
        private Double numero3;
        private Double resultado;
        // metodos o comportamientos del objeto
        //objetos siempre publicos
        public void setNumero1(Double numero1) {
            this.numero1 = numero1;
        }

        public Double getNumero() {
            return this.numero1;
        }

        public void setNumero2(Double numero2)
        {
            this.numero2 = numero2;
        }
        public Double getNumero2() 
        {
            return this.numero2;
        }

        public void Operaciones(String operador)
        {
            if (operador.Equals("Suma"))
            {
                this.resultado = this.numero1 + this.numero2;
            }
            else if (operador.Equals("Resta"))
            {
                this.resultado = this.numero1 - this.numero2;
            }
            else if (operador.Equals("Multiplicacion"))
            {
                this.resultado = this.numero1 * this.numero2;
            }
            else if (operador.Equals("Division"))
            {
                this.resultado = this.numero1 / this.numero2;
            }
        }

            public Double getResultado()
            {
                return this.resultado;
            }
        }

    }
