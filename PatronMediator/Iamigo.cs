using System;
using System.Collections.Generic;
using System.Text;

namespace PatronMediator
{
    //Esta interfaz debe tener un mediator y por conveniencia lo cambio a una clase abstracta
    public abstract class  Iamigo
    {
        private IMediator mediator;
        //Creo una propiedad para proteger los datos
        public IMediator Mediator
        {
            get;
        }
        //Se crea el meadiator de la clase abstracta 
        public Iamigo(IMediator mediator)
            //Que el mediator sea recibido en el constructor
        {
            this.mediator = mediator;
        }
        //Este metodo se va a comunicar por medio del mediator
        //Va a enviar el mensaje que se recibe por mediator
        public void Comunicacion(string mensaje)
        {
            this.mediator.Send(mensaje, this);
        }
        //Como es una clase abstracta este es el metodo que va  a ser diferente dependiendo del objeto
        public abstract void Recibir(String mensaje);
        
    }
}
