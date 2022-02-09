using System;


public class Program
 {
	 public static void Main()
   {
     /*Cajero Automático:
     1.-Realiza un sistema que solicite un NIP de cajero al usuario que sea válido (NIP=3867)si el NIP es inválido el sistema deberá permitir 3 intentos más.
     2.-Inicia el saldo del usuario en $4,000.00 y muestra en pantalla el menú.
     3.-El menú deberá permitir: Consultar Saldo,Retirar de Efectivo,Consultar Movimientos y Salir.*/

     // pedir al usuario su NIP si es 3867 darle un saldo de $4,000.00
     // mostrar el menu en la pantalla
     // el menu debe tener Consultar Saldo
     // Retiro de Efectivo
     // Consultar Movimientos 
     // y salir 
 

     //DECLARAR VARIABLES

     int movimientoSaldo=0;
     int MovimientoRetiro=0;
     int numeroEleccion;
     double montoRetiro;
     int conteo=0;
     double monto=0;
     int NIP;
     int contado = 0;
     double consultarSaldo;
     //pido al usuario su NIP
    for(contado = 0;contado <=3;contado++ )
    {
     Console.WriteLine("DIGITE SU NIP: ");
     NIP = Convert.ToInt32(Console.ReadLine());
     //Verifico si su NIP es correcto

     if(NIP==3867)
     {
       monto=4000.00;
       Console.WriteLine($"----TU MONTO INICIAL ES --->{monto} $");
       contado +=3;
       for(conteo=1;conteo<3;conteo++)
       {
          //MENU
          Console.WriteLine("-----MENU-----");
          Console.WriteLine("----ESCRIBA EL NUMERO QUE DESEA EJECUTAR----");
          //consultar saldo
       
       
          Console.WriteLine($@"1---> SI DESEA CONSULTAR EL SALDO
2---> SI DESEA RETIRAR EFECTIVO
3---> SI DESEA CONSULTAR MOVIMIENTOS
4---> SI DESEAS SALIR");
          numeroEleccion=Convert.ToInt32(Console.ReadLine());
          switch(numeroEleccion)
            {
              case 1: consultarSaldo = monto;
                      Console.WriteLine($"TU SALDO ES ----> {consultarSaldo} $");
                      if(numeroEleccion==1)
                        {
                          movimientoSaldo+=1;
                        }
                      conteo-=1;
                      break;
              case 2: 
                      Console.WriteLine("CUANTO DINERO DESEA RETIRAR: ");
                      montoRetiro=Convert.ToInt32(Console.ReadLine());
                      
                      if(monto>0)
                      {
                        if(montoRetiro>monto)
                        {
                          Console.WriteLine("ESE MONTO ES MAYOR AL SALDO QUE USTED TIENE, INTENTE DE NUEVO");
                          
                        }
                        if(montoRetiro<=monto)
                          {monto-=montoRetiro;}
                      }
                      if (numeroEleccion==2)
                      {
                        movimientoSaldo+=1;
                      }
                      conteo-=1;
                      break;
              case 3: Console.WriteLine($@"----MOVIMIENTOS HECHO EN EL SISTEMA----
                                      
                      --->Ha consultado el saldo {movimientoSaldo} veces
                      --->Ha retirado saldo {MovimientoRetiro} veces");
                      conteo-=1;
                      break;
              case 4: Console.WriteLine("------Saliendo del sistema....");
                      conteo+=4;
                      break;
              }  
       
  
       }
      }
     else
       {
         Console.WriteLine("CODIGO INVALIDO");
         contado+=1;
         }

    }
    
  }

 }
//Usar un FOR en la parte del MENÚ 
// hacer que el monto se actualize

