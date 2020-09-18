using System;
using System.Collections.Generic;
using System.Text;

namespace PatronMediator
{
    public class IngPanchana : Iamigo
    {
        //Se crea este metodo para recibir al mediator
        //Con "base" se invoca el constructor o interfaz que se está heredando 
        public IngPanchana(IMediator mediator) : base(mediator)
        {

        }

        public override void Recibir(string mensaje)
        {
            Console.WriteLine("Un profesor recibe: " + mensaje);
            Console.WriteLine("Se notificó por correo");
        }
    }
}

