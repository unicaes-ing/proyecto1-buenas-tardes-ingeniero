using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace maquina_expendedora
{
    class Program
    {
        public static int mode, op1, adbebi, addine, slbebidas, ingresodas, ingrejugos, ingreotros, vbebidas, vsodas, vjugos, votros, cantBeb;
        public static int coca = 0, fanta = 0, sprite = 0, Drpepper = 0, jugovalle = 0, petit = 0, aloe = 0, agua = 0;
        public static int[] bebidas = { 50, 50, 50, 50, 50, 50, 50, 50 };
        public static bool rep = false;
        public static int op = 0;
        //[0] $1 [1] $5
        public static double[] billetes = new double[2];
        //[0] $0.05 [1] $0.1 [2] $0.25 [3] $1
        public static double[] monedas = new double[4];
        //[0] $1 [1] $5
        public static double[] cantBilletes = new double[2];
        //[0] $0.05 [1] $0.1 [2] $0.25 [3] $1
        public static double[] cantMonedas = { 50, 50, 50, 50 };
        //[0] $1 [1] $5 [2] $0.05 [3] $0.1 [4] $0.25 [5] $1
        public static double[] cant = new double[6];
        //[0] Sodas [1] Jugos [2] Otros
        public static double[] tipoBeb = new double[3];
        //Total dinero Ingresado
        public static double dinIng;
        //Total dinero en Máquina
        public static double dinTotal;
        public static double vuelto = 0;
        public static string[] sodas = { "Coca Cola", "Fanta", "Sprite", "Dr.Pepper", };
        public static string[] jugos = { "Jugo del valle", "petit", "Aloe" };
        public static string[] otros = { "Agua" };
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                rep = false;
                Console.WriteLine("-----MAQUINA EXPENDEDORA-----");
                Console.WriteLine("Presione 1 Modo venta ");
                Console.WriteLine("Presione 2 Modo Administrador ");
                Console.WriteLine("Presione 3 Salir ");
                if (int.TryParse(Console.ReadLine(), out mode) && mode > 0 && mode <= 3)
                {
                    Console.Clear();
                    switch (mode)
                    {
                        case 1:
                            modoVenta();
                            rep = true;
                            break;
                        case 2:
                            modoAdministrador();
                            rep = true;
                            break;
                        case 3:
                            rep = false;
                            Console.WriteLine("Saliendo del programa...");
                            Thread.Sleep(1500);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Tenía que ser un número entero entre 1 y 2");
                    rep = true;
                }
            } while (rep == true && mode != 3);
        }

        static void modoAdministrador()
        {
            Console.Clear();
            Console.WriteLine("MODO ADMINISTRADOR:");
            Console.WriteLine("-----Bienvenido------");
            string correct = "123";
            string password;
            do
            //account
            {
                Console.Write("Ingrese la contraseña: ");
                password = Console.ReadLine();
                if (password != correct)
                {
                    Console.WriteLine("Contraseña incorrecta!");
                    Console.WriteLine();
                }
            } while (password != correct);
            Console.WriteLine("Contraseña Correcta");
            Console.Clear();
            //Opciones de bebida o dinero...
            do
            {
                Console.Clear();
                Console.WriteLine("Seleccione la opcion que desea: ");
                Console.WriteLine("1-Administrar el banco de bebidas");
                Console.WriteLine("2-Administrar el banco de dinero");
                op1 = int.Parse(Console.ReadLine());
                Console.Clear();
                rep = false;
                switch (op1)
                {
                    //Modo administrador bebidas
                    case 1:
                        do
                        {
                            Console.WriteLine("**Administracion de el banco de bebidas**");
                            Console.WriteLine("1-Ver la cantidad de las bebidas");
                            Console.WriteLine("2-Ingresar bebidas");
                            adbebi = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (adbebi)
                            {
                                //Ver bebidas
                                case 1:
                                    Console.WriteLine("Tipo de bebidas de desea ver: ");
                                    Console.WriteLine("1-Sodas");
                                    Console.WriteLine("2-Jugos");
                                    Console.WriteLine("3-Otros");
                                    vbebidas = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    switch (vbebidas)
                                    {
                                        case 1:
                                            Console.WriteLine("Seleccione la bedida para ver la cantidad: ");
                                            Console.WriteLine("1-Coca Cola");
                                            Console.WriteLine("2-Fanta");
                                            Console.WriteLine("3-Sprite");
                                            Console.WriteLine("4-Dr.Pepper");
                                            vsodas = int.Parse(Console.ReadLine());
                                            Console.Clear();
                                            switch (vsodas)
                                            {
                                                case 1:
                                                    Console.WriteLine("Cantidad de Coca Cola en la maquina: " + bebidas[0]);
                                                    break;
                                                case 2:
                                                    Console.WriteLine("Cantidad de Fanta en la maquina: " + bebidas[1]);
                                                    break;
                                                case 3:
                                                    Console.WriteLine("Cantidad de Sprite en la maquina: " + bebidas[2]);
                                                    break;
                                                case 4:
                                                    Console.WriteLine("Cantidad de Dr Pepper en la maquina: " + bebidas[6]);
                                                    break;
                                            }
                                            break;
                                        case 2:
                                            Console.WriteLine("Seleccione la bebida para ver la cantidad: ");
                                            Console.WriteLine("1-Jugo de Valle");
                                            Console.WriteLine("2-Petit");
                                            Console.WriteLine("3-Aloe");
                                            vjugos = int.Parse(Console.ReadLine());
                                            Console.Clear();
                                            switch (vjugos)
                                            {
                                                case 1:
                                                    Console.WriteLine("Cantidad de Jugo del Valle en la maquina: " + bebidas[3]);
                                                    break;
                                                case 2:
                                                    Console.WriteLine("Cantidad de Petit en la maquina: " + bebidas[4]);
                                                    break;
                                                case 3:
                                                    Console.WriteLine("Cantidad de Aloe en la maquina: " + bebidas[5]);
                                                    break;
                                            }
                                            break;
                                        case 3:
                                            Console.WriteLine("Seleccione la bebida para ver la cantidad: ");
                                            Console.WriteLine("1-Agua");
                                            votros = int.Parse(Console.ReadLine());
                                            Console.Clear();
                                            switch (votros)
                                            {
                                                case 1:
                                                    Console.WriteLine("Cantidad de Agua en la maquina: " + bebidas[7]);
                                                    break;
                                            }
                                            break;
                                    }
                                    break;
                                //Ingresar bebidas
                                case 2:
                                    Console.WriteLine("Seleccione el tipo de bebida a ingresar: ");
                                    Console.WriteLine("1-Sodas");
                                    Console.WriteLine("2-Jugos");
                                    Console.WriteLine("3-Otros");
                                    slbebidas = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    switch (slbebidas)
                                    {
                                        case 1:
                                            Console.WriteLine("Que tipo de soda desea ingreser a la maquina: ");
                                            Console.WriteLine("1-Coca Cola");
                                            Console.WriteLine("2-Fanta");
                                            Console.WriteLine("3-Sprite");
                                            Console.WriteLine("4-Dr.Pepper");
                                            ingresodas = int.Parse(Console.ReadLine());
                                            Console.Clear();
                                            Console.WriteLine("Cuantas bebidas desea ingresar");
                                            cantBeb = Convert.ToInt32(Console.ReadLine());
                                            switch (ingresodas)
                                            {
                                                case 1:
                                                    if (bebidas[0] <= 100 && cantBeb <= 50)
                                                    {                                                     
                                                        Console.WriteLine("Cantidad de Coca Cola en máquina: " + (cantBeb + bebidas[0]));                                              
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Capacidad Máxima Alcanzada");
                                                        rep = true;
                                                    }
                                                    break;
                                                case 2:
                                                    if (bebidas[1] <= 100 && cantBeb <= 50)
                                                    {
                                                        Console.WriteLine("Cantidad de Fanta en máquina: " + (cantBeb + bebidas[1]));
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Capacidad Máxima Alcanzada");
                                                        rep = true;
                                                    }
                                                    break;
                                                case 3:
                                                    if (bebidas[2] <= 100 && cantBeb <= 50)
                                                    {
                                                        Console.WriteLine("Cantidad de Fanta en máquina: " + (cantBeb + bebidas[2]));
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Capacidad Máxima Alcanzada");
                                                        rep = true;
                                                    }
                                                    break;
                                                case 4:
                                                    if (bebidas[6] <= 100 && cantBeb <= 50)
                                                    {
                                                        Console.WriteLine("Cuantas bebidas desea ingresar");
                                                        cantBeb = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Cantidad de Dr.Pepper en máquina: " + (cantBeb + bebidas[6]));
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Capacidad Máxima Alcanzada");
                                                        rep = true;
                                                    }
                                                    break;
                                            }
                                            break;
                                        case 2:
                                            Console.WriteLine("Que tipo de jugo desea ingresar a la maquina: ");
                                            Console.WriteLine("1-Jugo de Valle");
                                            Console.WriteLine("2-Petit");
                                            Console.WriteLine("3-Aloe");
                                            ingrejugos = int.Parse(Console.ReadLine());
                                            Console.Clear();
                                            Console.WriteLine("Cuantas bebidas desea ingresar");
                                            cantBeb = Convert.ToInt32(Console.ReadLine());
                                            switch (ingrejugos)
                                            {
                                                case 1:
                                                    if (bebidas[3] <= 100 && cantBeb <= 50)
                                                    {                                                       
                                                        Console.WriteLine("Cantidad de Jugo de Valle en máquina: " + (cantBeb + bebidas[3]));
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Capacidad Máxima Alcanzada");
                                                        rep = true;
                                                    }
                                                    break;
                                                case 2:
                                                    if (bebidas[4] <= 100 && cantBeb <= 50)
                                                    {
                                                        Console.WriteLine("Cantidad de Petít en máquina: " + (cantBeb + bebidas[4]));
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Capacidad Máxima Alcanzada");
                                                        rep = true;
                                                    }
                                                    break;
                                                case 3:
                                                    if (bebidas[5] <= 100 && cantBeb <= 50)
                                                    {
                                                        Console.WriteLine("Cantidad de Alóe en máquina: " + (cantBeb + bebidas[5]));
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Capacidad Máxima Alcanzada");
                                                        rep = true;
                                                    }
                                                    break;
                                            }
                                            break;
                                        case 3:
                                            Console.WriteLine("Que tipo de bebida desea ingresar a la maquina: ");
                                            Console.WriteLine("1-Agua");
                                            ingreotros = int.Parse(Console.ReadLine());
                                            Console.Clear();
                                            Console.WriteLine("Cuantas bebidas desea ingresar");
                                            cantBeb = Convert.ToInt32(Console.ReadLine());
                                            switch (ingreotros)
                                            {
                                                case 1:
                                                    if (bebidas[7] <= 100)
                                                    {                                                      
                                                        Console.WriteLine("Cantidad de Agua en máquina: " + (cantBeb + bebidas[7]));
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Capacidad Máxima Alcanzada");
                                                        rep = true;
                                                    }
                                                    break;
                                            }
                                            break;
                                    }
                                    Console.ReadKey();
                                    break;

                            }
                            break;
                } while (rep == true);
                        break;
                    //Opciones modo administrador dinero
                    case 2:
                        do
                        {
                            Console.WriteLine("**Administracion del banco de dinero");
                            Console.WriteLine("1-Ver cantidad de monedas");
                            Console.WriteLine("2-Ver cantidad de billetes");
                            Console.WriteLine("3-Vaciar banco de monedas");
                            Console.WriteLine("4-Vaciar banco de dolares");
                            Console.WriteLine("5-Llenar banco de monedas");
                            Console.WriteLine("6-Llenar banco de dolares");
                            Console.WriteLine("7-Salir...");
                            addine = int.Parse(Console.ReadLine());
                            Console.Clear();
                            //Banco de monedas
                            switch (addine)
                            {
                                case 1:
                                    Console.WriteLine("CANTIDAD DE MONEDAS");
                                    Console.WriteLine("");
                                    Console.WriteLine("* Monedas de $0.05: " + cantMonedas[0]);
                                    Console.WriteLine("* Monedas de $0.1: " + cantMonedas[1]);
                                    Console.WriteLine("* Monedas de $0.25: " + cantMonedas[2]);
                                    Console.WriteLine("* Monedas de $1.00: " + cantMonedas[3]);
                                    break;
                                case 2:
                                    Console.WriteLine("CANTIDAD DE BILLETES");
                                    Console.WriteLine("");
                                    Console.WriteLine("* Billetes de $5.00: " + cantBilletes[0]);
                                    Console.WriteLine("* Billetes de $1.00: " + cantBilletes[1]);
                                    break;
                                case 3:
                                    for (int n = 0; n <= 3; n++)
                                    {
                                        cantMonedas[n] = 0;
                                    }
                                    Console.WriteLine("VACIANDO EL BANCO DE MONEDAS...");
                                    Thread.Sleep(1500);
                                    break;
                                case 4:
                                    for (int n = 0; n <= 1; n++)
                                    {
                                        cantBilletes[n] = 0;
                                    }
                                    Console.WriteLine("VACIANDO EL BANCO DE BILLETES...");
                                    Thread.Sleep(1500);
                                    break;
                                case 5:
                                    rep = false;
                                    do
                                    {
                                        Console.WriteLine("¿Qué tipo de monedas desea agregar?");
                                        Console.WriteLine("1- Monedas de $0.05 ");
                                        Console.WriteLine("2- Monedas de $0.1");
                                        Console.WriteLine("3- Monedas de $0.25");
                                        Console.WriteLine("4- Monedas de $1.00");
                                        if (int.TryParse(Console.ReadLine(), out int tipo) && tipo <= 4 && tipo > 0)
                                        {
                                            do
                                            {
                                                Console.Write("Cantidad de Monedas a ingresar: ");
                                                if (int.TryParse(Console.ReadLine(), out int llenarMon) && llenarMon >= 0)
                                                {
                                                    cantMonedas[tipo - 1] = cantMonedas[tipo - 1] + llenarMon;
                                                    Console.WriteLine("Llenando.....");
                                                    Thread.Sleep(1000);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Tiene que ser un número positivo");
                                                    rep = true;
                                                }
                                            } while (rep == true);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Tiene que ser un número positivo entre 1 y 4");
                                            rep = true;
                                        }
                                    } while (rep == true);
                                    break;
                                case 6:
                                    rep = false;
                                    do
                                    {
                                        Console.WriteLine("¿Qué tipo de billetes desea agregar?");
                                        Console.WriteLine("1- Billetes de $5.00 ");
                                        Console.WriteLine("2- Billetes de $1.00");
                                        if (int.TryParse(Console.ReadLine(), out int tipo) && tipo <= 2 && tipo > 0)
                                        {
                                            do
                                            {
                                                Console.Write("Cantidad de Billetes a ingresar: ");
                                                if (int.TryParse(Console.ReadLine(), out int llenarBill) && llenarBill >= 0)
                                                {
                                                    cantBilletes[tipo - 1] = cantBilletes[tipo - 1] + llenarBill;
                                                    Console.WriteLine("Llenando.....");
                                                    Thread.Sleep(1000);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Tiene que ser un número positivo");
                                                    rep = true;
                                                }
                                            } while (rep == true);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Tiene que ser un número positivo entre 1 y 4");
                                            rep = true;
                                        }
                                    } while (rep == true);
                                    break;
                                case 7:
                                    Console.WriteLine("***Vuelva pronto***");
                                    Console.WriteLine("Press Enter Para salir... ");
                                    Console.ReadKey();
                                    rep = false;
                                    break;
                            }
                        } while (rep == true);
                        break;
                }
                Console.ReadKey();
            } while (rep == true && op1 != 3);
        }

        static void modoVenta()
        {

            do
            {
                dinIng = cant[0] + cant[1] + cant[2] + cant[3] + cant[4] + cant[5];
                dinTotal = billetes[0] + billetes[1] + monedas[0] + monedas[1] + monedas[2] + monedas[3];
                op = 0;
                Console.Clear();
                MaqMain();
                Console.SetCursorPosition(41, 9); Console.WriteLine("!Bienvenido!");
                Console.SetCursorPosition(41, 10); Console.WriteLine("¿Qué desea?");
                Console.SetCursorPosition(41, 12); Console.WriteLine("1- Ingresar dinero");
                Console.SetCursorPosition(41, 13); Console.WriteLine("2- Seleccionar bebida");
                Console.SetCursorPosition(41, 14); Console.WriteLine("3- Salir");
                Console.SetCursorPosition(41, 16); Console.Write("[OPCIÓN]: ");
                if (int.TryParse(Console.ReadLine(), out op) && op > 0 && op <= 3)
                {
                    Console.Clear();
                    switch (op)
                    {
                        case 1:
                            ingDin();
                            rep = true;
                            break;
                        case 2:
                            selBeb();
                            rep = true;
                            break;
                        case 3:
                            salir();
                            rep = false;
                            break;
                    }
                }
                else
                {
                    Console.SetCursorPosition(10, 40); Console.WriteLine("¡Tenía que ser un número entero positivo entre 1 y 3!");
                    Thread.Sleep(2000);
                    rep = true;
                }
            } while (rep == true);
        }
        //[MODO VENTA] - FUNCIONES DE OPCIÓN DE INGRESAR DINERO
        static void ingDin()
        {
            do
            {
                rep = false;
                Console.Clear();
                MaqMain();
                Console.SetCursorPosition(41, 9); Console.WriteLine("¿Qué desea ingresar?");
                Console.SetCursorPosition(41, 11); Console.WriteLine("1- Billetes");
                Console.SetCursorPosition(41, 12); Console.WriteLine("2- Monedas");
                Console.SetCursorPosition(41, 14); Console.Write("[OPCIÓN]: ");
                if (int.TryParse(Console.ReadLine(), out op) && op > 0 && op <= 2)
                {
                    switch (op)
                    {
                        case 1:
                            bilIns();
                            break;
                        case 2:
                            monIns();
                            break;
                    }
                    rep = false;
                }
                else
                {
                    Console.SetCursorPosition(10, 40); Console.WriteLine("¡El valor tiene que ser un entero positivo entre 1 y 2!");
                    rep = true;
                }
            } while (rep == true);
        }

        static void bilIns()
        {

            do
            {
                rep = false;
                Console.Clear();
                MaqMain();
                Console.SetCursorPosition(41, 9); Console.WriteLine("¿Qué tipo de billete desea usar?");
                Console.SetCursorPosition(41, 11); Console.WriteLine("1- Billete de $5");
                Console.SetCursorPosition(41, 12); Console.WriteLine("2- Billete de $1");
                Console.SetCursorPosition(41, 14); Console.Write("[OPCIÓN]: ");
                if (int.TryParse(Console.ReadLine(), out op) && op > 0 && op <= 2)
                {
                    Console.Clear();
                    MaqMain();
                    do
                    {
                        Console.SetCursorPosition(41, 9); Console.WriteLine("Cantidad de Billetes: ");
                        Console.SetCursorPosition(41, 11); Console.Write("[#]: ");
                        if (int.TryParse(Console.ReadLine(), out int bill) && bill >= 0)
                        {
                            switch (op)
                            {
                                case 1:
                                    cant[0] = 5 * bill + cant[0];
                                    billetes[0] = billetes[0] + cant[0];
                                    cantBilletes[0] = cant[0] / 5;
                                    break;
                                case 2:
                                    cant[1] = 1 * bill + cant[1];
                                    billetes[1] = billetes[1] + cant[1];
                                    cantBilletes[1] = cant[1] / 1;
                                    break;
                            }
                        }
                        else
                        {
                            Console.SetCursorPosition(10, 40); Console.WriteLine("¡Tiene que ser un entero positivo!");
                            rep = true;
                        }
                    } while (rep == true);
                    maqDin(1);
                }
                else
                {
                    Console.SetCursorPosition(10, 40); Console.WriteLine("Tiene que ingresar un número entero positivo entre 1 y 2");
                    rep = true;
                }
            } while (rep == true);
        }

        static void monIns()
        {
            int resp = 1;
            do
            {
                rep = false;
                Console.Clear();
                MaqMain();
                Console.SetCursorPosition(41, 9); Console.WriteLine("¿Qué tipo de moneda desea usar?");
                Console.SetCursorPosition(41, 11); Console.WriteLine("1- Moneda de $0.05");
                Console.SetCursorPosition(41, 12); Console.WriteLine("2- Moneda de $0.1");
                Console.SetCursorPosition(41, 13); Console.WriteLine("3- Moneda de $0.25");
                Console.SetCursorPosition(41, 14); Console.WriteLine("4- Moneda de $1");
                Console.SetCursorPosition(41, 16); Console.Write("[OPCIÓN]: ");
                if (int.TryParse(Console.ReadLine(), out op) && op > 0 && op <= 4)
                {
                    Console.Clear();
                    do
                    {
                        MaqMain();
                        Console.SetCursorPosition(41, 9); Console.WriteLine("Cantidad de Monedas: ");
                        Console.SetCursorPosition(41, 11); Console.Write("[#]: ");
                        if (int.TryParse(Console.ReadLine(), out int mon) && mon >= 0)
                        {
                            switch (op)
                            {
                                case 1:
                                    cant[2] = 0.05 * mon + cant[2];
                                    monedas[0] = monedas[0] + cant[2];
                                    cantMonedas[0] = cant[2] / 0.05 + cantMonedas[0];
                                    break;
                                case 2:
                                    cant[3] = 0.1 * mon + cant[3];
                                    monedas[1] = monedas[1] + cant[3];
                                    cantMonedas[1] = cant[3] / 0.1 + cantMonedas[1];
                                    break;
                                case 3:
                                    cant[4] = 0.25 * mon + cant[4];
                                    monedas[2] = monedas[2] + cant[4];
                                    cantMonedas[2] = cant[4] / 0.25 + cantMonedas[2];
                                    break;
                                case 4:
                                    cant[5] = 1 * mon + cant[5];
                                    monedas[3] = monedas[3] + cant[5];
                                    cantMonedas[3] = cant[5] / 1 + cantMonedas[3];
                                    break;
                            }
                            maqDin(2);
                            do
                            {
                                Console.SetCursorPosition(41, 41); Console.WriteLine("¿Desea insertar otro tipo de moneda? [1] SI, [2] NO");
                                Console.SetCursorPosition(41, 42); Console.Write("[OPCIÓN]: ");
                                if (int.TryParse(Console.ReadLine(), out resp) && resp > 0 && resp <= 2)
                                {
                                    rep = false;
                                }
                                else
                                {
                                    Console.SetCursorPosition(10, 40); Console.WriteLine("Tiene que ser un número entero positivo entre 1 y 2");
                                    rep = true;
                                }
                            } while (rep == true);
                        }
                        else
                        {
                            Console.SetCursorPosition(10, 40); Console.WriteLine("Tiene que ser un entero positivo");
                            rep = true;
                        }
                    } while (rep == true);
                    if (resp == 1)
                    {
                        rep = true;
                    }
                }
                else
                {
                    Console.SetCursorPosition(10, 40); Console.WriteLine("Tiene que ingresar un número entero positivo entre 1 y 2");
                    rep = true;
                }
            } while (rep == true && resp == 1);
        }
        //[MODO VENTA] - FUNCIONES DE SELECCIÓN DE BEBIDA
        static void selBeb()
        {
            //Comparar precio con dinero ingresado y si no es suficiente preguntar si quiere meter más o si quiere retirarlo
            //Mostrar el cambio en monedas
            MaqMain();
            rep = false;
            Console.SetCursorPosition(41, 9); Console.WriteLine("Seleccione la Bebida deseada:");
            Console.SetCursorPosition(41, 10); Console.WriteLine("*Números de la vitrina*");
            Console.SetCursorPosition(41, 12); Console.Write("[OPCIÓN]: ");
            do
            {
                proBeb();
            } while (rep == true);
        }
        static void proBeb()
        {
            if (int.TryParse(Console.ReadLine(), out op) && op > 0 && op <= 8)
            {
                cobBeb();
            }
            else
            {
                Console.SetCursorPosition(10, 40); Console.WriteLine("Tiene que ingresar un número entero positivo entre 1 y 8");
                rep = true;
            }
        }
        static void cobBeb()
        {
            Console.Clear();
            MaqMain();
            rep = false;
            tipoBeb[0] = 2; tipoBeb[1] = 1.5; tipoBeb[2] = 1;
            switch (op)
            {
                case 1:
                case 2:
                case 3:
                case 7:
                    bebCas(0, op);
                    break;

                case 4:
                case 5:
                case 6:
                    bebCas(1, op);
                    break;

                case 8:
                    bebCas(2, op);
                    break;
            }
        }

        static void bebCas(int n, int op)
        {
            if (dinIng >= tipoBeb[n])
            {
                dinTotal = dinTotal - dinIng;
                vuelto = dinIng - tipoBeb[n];
                bebidas[op] = bebidas[op] - 1;
                Console.SetCursorPosition(41, 12); Console.WriteLine("Procesando su pedido...");
                Thread.Sleep(1500);
                for (int c = 0; c < 6; c++)
                {
                    cant[c] = 0;
                }
                maqBeb(1);
            }
            else
            {
                dinInsu();
            }
        }
        static void dinInsu()
        {
            rep = false;
            do
            {
                Console.Clear();
                MaqMain();
                dinIng = cant[0] + cant[1] + cant[2] + cant[3] + cant[4] + cant[5];
                dinTotal = billetes[0] + billetes[1] + monedas[0] + monedas[1] + monedas[2] + monedas[3];
                Console.SetCursorPosition(41, 9); Console.WriteLine("¡DINERO INSUFICIENTE!");
                Console.SetCursorPosition(41, 10); Console.WriteLine("¿Qué desea hacer?");
                Console.SetCursorPosition(41, 11); Console.WriteLine("1- Agregar más dinero");
                Console.SetCursorPosition(41, 12); Console.WriteLine("2- Retirar el dinero ingresado");
                Console.SetCursorPosition(41, 14); Console.Write("[OPCIÓN]: ");
                if (int.TryParse(Console.ReadLine(), out op) && op > 0 && op <= 2)
                {
                    Console.Clear();
                    if (op == 1)
                    {
                        ingDin();
                    }
                    else
                    {
                        if (dinIng == 0)
                        {
                            MaqMain();
                            Console.SetCursorPosition(41, 12); Console.WriteLine("¡Ups! Parece que no ha ");
                            Console.SetCursorPosition(41, 13); Console.WriteLine("ingresado dinero :(");
                            Thread.Sleep(1500);
                        }
                        else
                        {
                            dinTotal = dinTotal - dinIng;
                            vuelto = dinIng;
                            for (int c = 0; c < 6; c++)
                            {
                                cant[c] = 0;
                            }
                            maqBeb(2);
                        }
                    }
                    rep = false;
                }
                else
                {
                    Console.SetCursorPosition(10, 40); Console.WriteLine("Tiene que ingresar un número entero positivo entre 1 y 2");
                    rep = true;
                }
            } while (rep == true);
        }
        //[MODO VENTA] - FUNCIÓN DE SALIR
        static void salir()
        {
            MaqMain();
            Console.SetCursorPosition(41, 12); Console.WriteLine("¡Vuelva Pronto!");
            Thread.Sleep(2000);
        }
        //[MODO VENTA] - FUNCIONES MÁQUINA EXPENDEDORA
        static void MaqMain()
        {
            Console.WriteLine("┌────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│ ┌────────────────────────────────────────────────────────────────────────────┐ │");
            Console.WriteLine("│ │ ╔═╗ ╔══ ╔═╗  ╔╗ ╔═╗  ╔══╗ ╔══                                              │ │");
            Console.WriteLine("│ │ ╠═╩╗╠══ ╠═╩╗ ║║ ║  ║ ╠══╣ ╚═╗                                              │ │");
            Console.WriteLine("│ │ ╚══╝╚══ ╚══╝ ╚╝ ╚═╝  ╚  ╝ ══╝                                              │ │");
            Console.WriteLine("│ └────────────────────────────────────────────────────────────────────────────┘ │");
            Console.WriteLine("└┬──────────────────────────────────────────────────────────────────────────────┬┘");
            Console.WriteLine(" │ ┌──────────────────────────────────┐                                         │");
            Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("██        "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("██        "); Console.ResetColor(); Console.WriteLine("██       │ ┌─────────────────────────────────────┐ │");
            Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("██        "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("██        "); Console.ResetColor(); Console.WriteLine("██       │ │                                     │ │");
            Console.WriteLine(" │ │                                  │ │                                     │ │");
            Console.WriteLine(" │ │ 1. Coca   2. Fanta  3. Sprite    │ │                                     │ │");
            Console.WriteLine(" │ │    Cola                          │ │                                     │ │");
            Console.WriteLine(" │ │                                  │ │                                     │ │");
            Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██        "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("██        "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("██"); Console.ResetColor(); Console.WriteLine("       │ │                                     │ │");
            Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██        "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("██        "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("██"); Console.ResetColor(); Console.WriteLine("       │ │                                     │ │");
            Console.WriteLine(" │ │                                  │ │                                     │ │");
            Console.WriteLine(" │ │  4. Jugo   5. Petít  6. Alóe     │ └─────────────────────────────────────┘ │");
            Console.WriteLine(" │ │  del Valle                       │ ┌───┐     ┌─┐                           │");
            Console.WriteLine(" │ │                                  │ │═══│     │|│                           │");
            Console.WriteLine(" │ │                                  │ └───┘     └─┘                           │");
            Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("██                  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("██"); Console.ResetColor(); Console.WriteLine("       │                                         │");
            Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("██                  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("██"); Console.ResetColor(); Console.WriteLine("       │                                         │");
            Console.WriteLine(" │ │                                  │                      │ Sodas: $2.00 │   │");
            Console.WriteLine(" │ │ 7. Dr. Pepper        8. Agua     │                      │ Jugos: $1.50 │   │");
            Console.WriteLine(" │ │                                  │                      │ Otros: $1.00 │   │");
            Console.WriteLine(" │ │                                  │                                         │");
            Console.WriteLine(" │ └──────────────────────────────────┘                                         │");
            Console.WriteLine("┌┴───────────────────────────────────────┐                                      │");
            Console.WriteLine("│ ┌────────────────────────────────────┐ │    ┌────────┐                        │");
            Console.WriteLine("│ │     ┌──────────────┐     BEBIDA    │ │    │        │                        │");
            Console.WriteLine("│ │ ───>│______________│<───  SALE     │ │    └────────┘                        │");
            Console.WriteLine("│ │     └──────────────┘      AQUÍ     │ │         ^                            │");
            Console.WriteLine("│ └────────────────────────────────────┘ │         │                            │");
            Console.WriteLine("└┬───────────────────────────────────────┘       VUELTO                        ┌┘");
            Console.WriteLine(" ├─────────────────────────────────────────────────────────────────────────────┤");
            Console.WriteLine(" └─────────────────────────────────────────────────────────────────────────────┘");
            if (op != 3)
            {
                Console.SetCursorPosition(5, 38); Console.WriteLine("Su dinero: " + dinIng.ToString("C2"));

            }
        }

        static void maqDin(int n)
        {
            for (int p = 1; p <= 2; p++)
            {
                Console.Clear();
                Console.WriteLine("┌────────────────────────────────────────────────────────────────────────────────┐");
                Console.WriteLine("│ ┌────────────────────────────────────────────────────────────────────────────┐ │");
                Console.WriteLine("│ │ ╔═╗ ╔══ ╔═╗  ╔╗ ╔═╗  ╔══╗ ╔══                                              │ │");
                Console.WriteLine("│ │ ╠═╩╗╠══ ╠═╩╗ ║║ ║  ║ ╠══╣ ╚═╗                                              │ │");
                Console.WriteLine("│ │ ╚══╝╚══ ╚══╝ ╚╝ ╚═╝  ╚  ╝ ══╝                                              │ │");
                Console.WriteLine("│ └────────────────────────────────────────────────────────────────────────────┘ │");
                Console.WriteLine("└┬──────────────────────────────────────────────────────────────────────────────┬┘");
                Console.WriteLine(" │ ┌──────────────────────────────────┐                                         │");
                Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("██        "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("██        "); Console.ResetColor(); Console.WriteLine("██       │ ┌─────────────────────────────────────┐ │");
                Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("██        "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("██        "); Console.ResetColor(); Console.WriteLine("██       │ │                                     │ │");
                Console.WriteLine(" │ │                                  │ │                                     │ │");
                Console.WriteLine(" │ │ 1. Coca   2. Fanta  3. Sprite    │ │                                     │ │");
                Console.WriteLine(" │ │    Cola                          │ │                                     │ │");
                Console.WriteLine(" │ │                                  │ │                                     │ │");
                Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██        "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("██        "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("██"); Console.ResetColor(); Console.WriteLine("       │ │                                     │ │");
                Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██        "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("██        "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("██"); Console.ResetColor(); Console.WriteLine("       │ │                                     │ │");
                Console.WriteLine(" │ │                                  │ │                                     │ │");
                Console.WriteLine(" │ │  4. Jugo   5. Petít  6. Alóe     │ └─────────────────────────────────────┘ │");
                if (n == 1)
                {
                    maqDinParBil(p);
                }
                else
                {
                    maqDinParMon(p);
                }
                Console.WriteLine(" │ │                                  │                      │ Sodas: $2.00 │   │");
                Console.WriteLine(" │ │ 7. Dr. Pepper        8. Agua     │                      │ Jugos: $1.50 │   │");
                Console.WriteLine(" │ │                                  │                      │ Otros: $1.00 │   │");
                Console.WriteLine(" │ │                                  │                                         │");
                Console.WriteLine(" │ └──────────────────────────────────┘                                         │");
                Console.WriteLine("┌┴───────────────────────────────────────┐                                      │");
                Console.WriteLine("│ ┌────────────────────────────────────┐ │    ┌────────┐                        │");
                Console.WriteLine("│ │     ┌──────────────┐     BEBIDA    │ │    │        │                        │");
                Console.WriteLine("│ │ ───>│______________│<───  SALE     │ │    └────────┘                        │");
                Console.WriteLine("│ │     └──────────────┘      AQUÍ     │ │         ^                            │");
                Console.WriteLine("│ └────────────────────────────────────┘ │         │                            │");
                Console.WriteLine("└┬───────────────────────────────────────┘       VUELTO                        ┌┘");
                Console.WriteLine(" ├─────────────────────────────────────────────────────────────────────────────┤");
                Console.WriteLine(" └─────────────────────────────────────────────────────────────────────────────┘");
                Console.SetCursorPosition(5, 39); Console.WriteLine("Su dinero: " + dinIng.ToString("C2"));
                Thread.Sleep(1000);
            }
            Console.Clear();
            MaqMain();
            Console.SetCursorPosition(5, 40); Console.WriteLine("¡Dinero Ingresado con Éxito!");
            Thread.Sleep(2000);
        }


        static void maqDinParBil(int n)
        {
            dinIng = cant[0] + cant[1] + cant[2] + cant[3] + cant[4] + cant[5];
            dinTotal = billetes[0] + billetes[1] + monedas[0] + monedas[1] + monedas[2] + monedas[3];
            if (n == 1)
            {
                Console.WriteLine(" │ │  del Valle                       │ ┌───┐     ┌─┐                           │");
                Console.WriteLine(" │ │                                  │ │═══│     │|│                           │");
                Console.WriteLine(" │ │                                  │ └┌─┐┘     └─┘                           │");
                Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("██                  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("██"); Console.ResetColor(); Console.WriteLine("       │  │$│                                    │");
                Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("██                  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("██"); Console.ResetColor(); Console.WriteLine("       │  └─┘                                    │");
            }
            if (n == 2)
            {
                Console.WriteLine(" │ │  del Valle                       │ ┌───┐     ┌─┐                           │");
                Console.WriteLine(" │ │                                  │ │═══│     │|│                           │");
                Console.WriteLine(" │ │                                  │ └└─┘┘     └─┘                           │");
                Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("██                  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("██"); Console.ResetColor(); Console.WriteLine("       │                                         │"); ;
                Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("██                  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("██"); Console.ResetColor(); Console.WriteLine("       │                                         │");
            }
        }

        static void maqDinParMon(int n)
        {

            if (n == 1)
            {
                Console.WriteLine(" │ │  del Valle                       │ ┌───┐     ┌─┐                           │");
                Console.WriteLine(" │ │                                  │ │═══│     │|│  ©                        │");
                Console.WriteLine(" │ │                                  │ └───┘     └─┘   ©                       │");
                Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("██                  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("██"); Console.ResetColor(); Console.WriteLine("       │                                         │");
                Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("██                  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("██"); Console.ResetColor(); Console.WriteLine("       │                                         │");
            }
            if (n == 2)
            {
                Console.WriteLine(" │ │  del Valle                       │ ┌───┐     ┌─┐                           │");
                Console.WriteLine(" │ │                                  │ │═══│     │|©                           │");
                Console.WriteLine(" │ │                                  │ └───┘     └─┘                           │");
                Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("██                  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("██"); Console.ResetColor(); Console.WriteLine("       │                                         │"); ;
                Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("██                  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("██"); Console.ResetColor(); Console.WriteLine("       │                                         │");
            }
        }

        static void maqBeb(int n)
        {
            for (int p = 1; p <= 2; p++)
            {
                Console.Clear();
                Console.WriteLine("┌────────────────────────────────────────────────────────────────────────────────┐");
                Console.WriteLine("│ ┌────────────────────────────────────────────────────────────────────────────┐ │");
                Console.WriteLine("│ │ ╔═╗ ╔══ ╔═╗  ╔╗ ╔═╗  ╔══╗ ╔══                                              │ │");
                Console.WriteLine("│ │ ╠═╩╗╠══ ╠═╩╗ ║║ ║  ║ ╠══╣ ╚═╗                                              │ │");
                Console.WriteLine("│ │ ╚══╝╚══ ╚══╝ ╚╝ ╚═╝  ╚  ╝ ══╝                                              │ │");
                Console.WriteLine("│ └────────────────────────────────────────────────────────────────────────────┘ │");
                Console.WriteLine("└┬──────────────────────────────────────────────────────────────────────────────┬┘");
                Console.WriteLine(" │ ┌──────────────────────────────────┐                                         │");
                Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("██        "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("██        "); Console.ResetColor(); Console.WriteLine("██       │ ┌─────────────────────────────────────┐ │");
                Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("██        "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("██        "); Console.ResetColor(); Console.WriteLine("██       │ │                                     │ │");
                Console.WriteLine(" │ │                                  │ │                                     │ │");
                Console.WriteLine(" │ │ 1. Coca   2. Fanta  3. Sprite    │ │                                     │ │");
                Console.WriteLine(" │ │    Cola                          │ │                                     │ │");
                Console.WriteLine(" │ │                                  │ │                                     │ │");
                Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██        "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("██        "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("██"); Console.ResetColor(); Console.WriteLine("       │ │                                     │ │");
                Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██        "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("██        "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("██"); Console.ResetColor(); Console.WriteLine("       │ │                                     │ │");
                Console.WriteLine(" │ │                                  │ │                                     │ │");
                Console.WriteLine(" │ │  4. Jugo   5. Petít  6. Alóe     │ └─────────────────────────────────────┘ │");
                Console.WriteLine(" │ │  del Valle                       │ ┌───┐     ┌─┐                           │");
                Console.WriteLine(" │ │                                  │ │═══│     │|│                           │");
                Console.WriteLine(" │ │                                  │ └───┘     └─┘                           │");
                Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("██                  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("██"); Console.ResetColor(); Console.WriteLine("       │                                         │");
                Console.Write(" │ │     "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("██                  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("██"); Console.ResetColor(); Console.WriteLine("       │                                         │");
                Console.WriteLine(" │ │                                  │                      │ Sodas: $2.00 │   │");
                Console.WriteLine(" │ │ 7. Dr. Pepper        8. Agua     │                      │ Jugos: $1.50 │   │");
                Console.WriteLine(" │ │                                  │                      │ Otros: $1.00 │   │");
                Console.WriteLine(" │ │                                  │                                         │");
                Console.WriteLine(" │ └──────────────────────────────────┘                                         │");
                Console.WriteLine("┌┴───────────────────────────────────────┐                                      │");
                if (n == 1)
                {
                    maqBebPar(p);
                }
                else
                {
                    vueltoDinInsu(p);
                }
                Console.WriteLine("└┬───────────────────────────────────────┘       VUELTO                        ┌┘");
                Console.WriteLine(" ├─────────────────────────────────────────────────────────────────────────────┤");
                Console.WriteLine(" └─────────────────────────────────────────────────────────────────────────────┘");
                Console.SetCursorPosition(5, 38); Console.WriteLine("Su dinero: $0.00");
                Console.SetCursorPosition(5, 39); Console.WriteLine("Su vuelto: " + vuelto.ToString("C2"));
                Thread.Sleep(1000);
                if (p == 2)
                {
                    Console.SetCursorPosition(5, 41);
                    Console.WriteLine("Presione cualquier tecla para recoger su bebida y/o su vuelto");
                    Console.ReadKey();
                }
            }
            Console.Clear();
            MaqMain();
        }

        static void maqBebPar(int n)
        {
            dinIng = cant[0] + cant[1] + cant[2] + cant[3] + cant[4] + cant[5];
            dinTotal = billetes[0] + billetes[1] + monedas[0] + monedas[1] + monedas[2] + monedas[3];
            if (n == 1)
            {
                Console.WriteLine("│ ┌────────────────────────────────────┐ │    ┌────────┐                        │");
                Console.Write("│ │     ┌────▄▄▄▄▄▄────┐     BEBIDA    │ │    │");
                if (dinIng == vuelto)
                {
                    Console.Write("________");
                }
                else
                {
                    Console.Write("__©_©___");
                }
                Console.WriteLine("│                        │");
                Console.WriteLine("│ │ ───>│______________│<───  SALE     │ │    └────────┘                        │");
                Console.WriteLine("│ │     └──────────────┘      AQUÍ     │ │         ^                            │");
                Console.WriteLine("│ └────────────────────────────────────┘ │         │                            │");
            }
            if (n == 2)
            {
                Console.WriteLine("│ ┌────────────────────────────────────┐ │    ┌────────┐                        │");
                Console.Write("│ │     ┌──────────────┐     BEBIDA    │ │    │");
                if (dinIng == vuelto)
                {
                    Console.Write("________");
                }
                else
                {
                    Console.Write("__©©©©__");
                }
                Console.WriteLine("│                        │");
                Console.WriteLine("│ │ ───>│____██████____│<───  SALE     │ │    └────────┘                        │");
                Console.WriteLine("│ │     └──────────────┘      AQUÍ     │ │         ^                            │");
                Console.WriteLine("│ └────────────────────────────────────┘ │         │                            │");
            }
        }

        static void vueltoDinInsu(int n)
        {
            if (n == 1)
            {
                Console.WriteLine("│ ┌────────────────────────────────────┐ │    ┌────────┐                        │");
                Console.WriteLine("│ │     ┌──────────────┐     BEBIDA    │ │    │__©_©___│                        │");
                Console.WriteLine("│ │ ───>│______________│<───  SALE     │ │    └────────┘                        │");
                Console.WriteLine("│ │     └──────────────┘      AQUÍ     │ │         ^                            │");
                Console.WriteLine("│ └────────────────────────────────────┘ │         │                            │");
            }
            if (n == 2)
            {
                Console.WriteLine("│ ┌────────────────────────────────────┐ │    ┌────────┐                        │");
                Console.WriteLine("│ │     ┌──────────────┐     BEBIDA    │ │    │__©©©©__│                        │");
                Console.WriteLine("│ │ ───>│______________│<───  SALE     │ │    └────────┘                        │");
                Console.WriteLine("│ │     └──────────────┘      AQUÍ     │ │         ^                            │");
                Console.WriteLine("│ └────────────────────────────────────┘ │         │                            │");
            }
        }
    }
}
