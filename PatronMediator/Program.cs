using System;

namespace PatronMediator
{
    class Program
    {
        /* Se utiliza este patron de diseño cuando exista comunicación entre objetos los cuales puedan ser
         * de diferente tipo
          */
        static void Main(string[] args)
        {
            //Aqui hay 2 tipos y existe un medio por el cual se comunican
            //Se crea el patron de diseño 
            Mediator mediator = new Mediator();

            //Ahora se crea el estudiante
            //Y se recibe el mediator
            Iamigo JoseGongora = new Estudiante (mediator);

            //Se crean los profesores
            Iamigo IngePanchana = new IngPanchana(mediator);
            Iamigo IngVilka = new IngPanchana(mediator);

            //Ahora voy a hacer que se envien mensajes entre ellos
            //Para eso se agrega a mediator
            mediator.Add(JoseGongora);
            mediator.Add(IngePanchana);
            mediator.Add(IngVilka);

            //Ahora se manda un mensaje del estudiante al profesor
            JoseGongora.Comunicacion("Ing. tengo un problema con una tarea");


            //El mediator actua como una via para comunicación entre los mensajes, entre los objetos que implementan una misma interfaz 
        }
    }
}
