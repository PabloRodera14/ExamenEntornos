using System;


//namespace EDexamenT6a8


namespace Deposito
{
    /*Clase que representa la gestión de los depósitos de una granja.
     * Tiene dos depósitos: pienso y agua. 
     * La propiedad devuelve el nivel de agua y pienso. 
     * Los métodos permiten reponer o consumir tanto pienso como agua.
     * Estos comentarios se deben eliminar y usar comentarios de documentación en su lugar.
     */
    class Deposito
    {
        private decimal niveldeagua;
        private decimal niveldepienso;
        private decimal cantidadmaxima;      //La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE AGUA, se comprueba antes de actualizar los niveles. 
        private decimal cantidadmaxima2;     //La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE PIENSO, se comprueba antes de actualizar los niveles. 
        public decimal Niveldeagua
        {
            get { return niveldeagua; }
        }
        public decimal Niveldepienso
        {
            get { return niveldepienso; }
        }
        public void reponer1(decimal cantidadareponerdeagua)
        {
            cantidadmaxima = antidadareponerdeagua + niveldeagua;
            if (cantidadareponerdeagua > 0 && cantidadmaxima < 10000) ;  //Tamaño del depósito de pienso es de 1000 l.
            niveldeagua = niveldeagua + cantidadareponerdeagua;




        }
        public void reponer2(decimal cantidadareponerdepienso)
        {

            cantidadmaxima2 = cantidadareponerdepienso + niveldepienso;
            if (cantidadareponerdepienso > 0 && cantidadmaxima2 < 5000)  //Tamaño del depósito de pienso es de 5000 kg. 
                niveldepienso = niveldepienso + cantidadareponerdepienso;
        }


        public decimal consumo1(decimal cantidadaretirardeagua)
        {
            decimal retirado1 = 0; //Cantidad que se retira
            if (cantidadaretirardeagua > 0 && cantidadaretirardeagua <= niveldeagua)
            {
                retirado1 = cantidadaretirardeagua;
                niveldeagua = niveldeagua - cantidadaretirardeagua;
            }

            return retirado1;
        }
        public decimal consumo2(decimal cantidadaretirardepienso)
        {
            decimal retirado2 = 0; //Cantidad que se retira
            if (cantidadaretirardepienso > 0 && cantidadaretirardepienso <= niveldepienso)
            {
                retirado2 = cantidadaretirardepienso;
                niveldepienso = niveldepienso - cantidadaretirardepienso;
            }
            return retirado2;
        }








    }
}
