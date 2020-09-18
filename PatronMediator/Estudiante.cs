using System;
using System.Collections.Generic;
using System.Text;

namespace PatronMediator
{
    //Implementara la clase abstracta
    class Estudiante : Iamigo
    {
        //Se crea este metodo para recibir al mediator
        //Con "base" se invoca el constructor o interfaz que se está heredando 
        public Estudiante(IMediator mediator) : base (mediator)
        {

        }
        public override void Recibir(string mensaje)
        {
            Console.WriteLine("Un profesor recibe: "+ mensaje);
         //De esta manera se mantienen los mensajes entre elementos
         //tambien que exista un medio por el cual se comunican los objetos
        }
    }
}
