using System;
using System.Collections.Generic;
using System.Text;

namespace PatronMediator
{
    //Crear un chat, las variables serán amigos, pero la comunicacion serán de profesores a alumnos
     public interface IMediator
    {
        //Todo lo que implementen esta interfaz debe tener un metodo llamado send
        void Send(string mensaje, Iamigo amigo);
    }
}
