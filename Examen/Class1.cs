using System;


//namespace EDexamenT6a8


namespace Deposito.PabloRodera
{
    /// <summary>
    /// Se ha cambiado el nombre del namespace.
    /// Esta clase es la que usaremos para realizar el examen, se va a usar esta clase para representar la gestión de los depósitos de una granja.
    /// La granja tiene 2 depósitos: pienso y agua.
    /// La propiedad devuelve el nivel de agua y pienso.
    /// Los métodos permiten reponer o consumir tanto pienso como agua.
    /// Se han realizado cierta tabulaciones para dejar el código legible.
    /// </summary>
   
    class Deposito
    {
        /// <summary>
        /// Se han renombrado los nombres de las vairables y su declaracion para que sea mas correcto su uso, se han renombrado las variables con estilo caMel, 
        /// dado que es un buen uso práctico. Se han añadido las propiedades set para poner darle valor a las variables privadas.
        /// </summary>
        /// <param name="nivelAgua"> Valor de tipo float el cual almacenará el nivel de agua</param>
        /// <param name="nivelPienso"> Valor de tipo float el cual almacenará el nivel de pienso</param>
        /// <param name="cantidadMaxAgua"> Valor de tipo float el cual almacenará el nivel máximo de agua</param>
        /// <param name="cantidadMaxPienso"> Valor de tipo float el cual almacenará el nivel máximo de pienso</param>
        /// <remarks>La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE AGUA, se comprueba antes de actualizar los niveles.</remarks>
        /// <remarks>La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE PIENSO, se comprueba antes de actualizar los niveles.</remarks>

        private float nivelAgua;
        private float nivelPienso;
        private float cantidadMaxAgua;       
        private float cantidadMaxPienso;      
        
        public float NivelAgua
        {
            get { return nivelAgua; }
            set { nivelAgua = value; }
        }
        public float NivelPienso
        {
            get { return nivelPienso; }
            set { nivelPienso = value; }
        }
        /// <summary>
        /// Se ha renombrado el método y además se le ha aplicado el estilo PasCal para un buen uso y mas claro del método.
        /// Se ha renombrado la variable y además se le ha aplicado el estilo caMel para un buen uso y mas claro de la variable,
        /// En el nombre del método se intuye a la perfección para que se va a usar esta variable, por lo tanto elimina cualquier ambiguedad.
        /// Se han realizados introduccion de llaves y corregido cierto código.
        /// </summary>
        /// <remarks>El tamaño del depósito de pienso es de 1000 l.</remarks>
        /// <exception cref="System.ArgumentOutOfRangeException">cantidadMaxAgua es superior a 10000.</exception>
        /// <param name="reponerAgua">La variable que se le pasará a este método indicará el agua que queremos reponer.</param>
        public void ReponerAgua(float cantidadAgua)
        {
            cantidadMaxAgua = cantidadAgua + nivelAgua;
            if (cantidadAgua > 0 && cantidadMaxAgua < 10000)
            {
                nivelAgua = nivelAgua + cantidadAgua;
            }
        }
        /// <summary>
        /// Se ha renombrado el método y además se le ha aplicado el estilo PasCal para un buen uso y mas claro del método.
        /// Se ha renombrado la variable y además se le ha aplicado el estilo caMel para un buen uso y mas claro de la variable,
        /// En el nombre del método se intuye a la perfección para que se va a usar esta variable, por lo tanto elimina cualquier ambiguedad.
        /// Se han realizados introduccion de llaves y corregido cierto código.
        /// </summary>
        /// <remarks>El tamaño del depósito de pienso es de 5000 kg.</remarks>
        /// <exception cref="System.ArgumentOutOfRangeException">cantidadMaxPienso es superior a 5000.</exception>
        /// <param name="cantPienso">Introducimos la cantidad de pienso que queremos reponer.</param>
        public void ReponerPienso(float cantPienso)
        {
            cantidadMaxPienso = cantPienso + nivelPienso;
            if (cantPienso > 0 && cantidadMaxPienso < 5000)
            {
                nivelPienso = nivelPienso + cantPienso;
            }
        }

        /// <summary>
        /// Se ha renombrado el método y además se le ha aplicado el estilo PasCal para un buen uso y mas claro del método.
        /// Se ha renombrado la variable a introducir y además se le ha aplicado el estilo caMel para un buen uso y mas claro de la variable,
        /// En el nombre del método se intuye a la perfección para que se va a usar esta variable, por lo tanto elimina cualquier ambiguedad.
        /// Se ha renombrado la variable retirado2 porque puede dar luegar a ambigüedad.
        /// Se han realizados introduccion de llaves y corregido cierto código.
        /// </summary>
        /// <remarks>La variable aguaRetirada nos indica el agua que se retira.</remarks>
        /// <param name="cantAgua">Introducimos la cantidad de agua que queremos retirar del depósito.</param>
        /// <returns>Nos devolverá la cantidad de agua retirada del depósito, si no es posible, porque no hay agua suficiente,
        /// nos devolverá -1, ya que es buena práctica que nos devuelva -1 en vez de 0 como devolvía inicialmente.</returns>
        public float ConsumoAgua(float cantAgua)
        {
            float aguaRetirada = -1; 

            if (cantAgua > 0 && cantAgua <= nivelAgua)
            {
                aguaRetirada = cantAgua;
                nivelAgua = nivelAgua - cantAgua;
            }

            return aguaRetirada;
        }
        /// <summary>
        /// Se ha renombrado el método y además se le ha aplicado el estilo PasCal para un buen uso y mas claro del método.
        /// Se ha renombrado la variable a introducir y además se le ha aplicado el estilo caMel para un buen uso y mas claro de la variable,
        /// En el nombre del método se intuye a la perfección para que se va a usar esta variable, por lo tanto elimina cualquier ambiguedad.
        /// Se ha renombrado la variable retirado2 porque puede dar luegar a ambigüedad.
        /// Se han realizados introduccion de llaves y corregido cierto código.
        /// </summary>
        /// <remarks>La variable piensoRetirado nos indica el pienso que se retira.</remarks>
        /// <param name="cantAgua">Introducimos la cantidad de pienso que queremos reti</param>
        /// <returns>Nos devolverá la cantidad de pienso retirada del depósito, si no es posible, porque no hay pienso suficiente,
        /// nos devolverá -1, ya que es buena práctica que nos devuelva -1 en vez de 0 como devolvía inicialmente.</returns>
        public float ConsumoPienso(float cantPienso)
        {
            float piensoRetirado = -1; 
            if (cantPienso > 0 && cantPienso <= nivelPienso)
            {
                piensoRetirado = cantPienso;
                nivelPienso = nivelPienso - cantPienso;
            }
            return piensoRetirado;
        }
    }
}
