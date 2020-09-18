using System;
using System.Collections.Generic;
using System.Text;

namespace PatronMediator
{
    //Se implementa la interfaz IMediator
    //Esta clase será como el chismoso se de la clase, va a decir todo
    class Mediator : IMediator
    {
        //Se crea una lista de los amigos
        private List<Iamigo> amigos;
        //Se hace un constructor 
        public Mediator()
        {
            //Inicializa este objeto pero está en 0
            amigos = new List<Iamigo>();
        }
        //Se crea un metodo para agregar a los amigos
        //Que seran comunicados por esta clase

        //Se recibe un amigo de la clase abstracta
        public void Add(Iamigo amigo)
        {
            //Forma de agregar a los amigos
            //Cada que se conecten al chat se utiliza este metodo
            this.amigos.Add(amigo);
            //UN receptor de los mensajes que envie alguien
        }
        //Este seria el amigo chismoso que lo va a mandar por medio de este metodo
        public void Send(string mensaje, Iamigo amigo)
        {
            //Hago un recorrido de todos mis amigos
            foreach (var a in this.amigos)
            {
                if (amigo != a)
                {
                    //Mensaje que envio el amigo
                    a.Recibir(mensaje);
                }
            }
        }
    }
}
