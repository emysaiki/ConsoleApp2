// See https://aka.ms/new-console-template for more information 
Console.WriteLine("Hello, World!");

/* string nome;
Console.WriteLine("Informe o seu nome:");
nome = Console.ReadLine();
Console.WriteLine("Olá, bom dia " +nome);
Console.ReadKey(); */


  /*  double areaLosango, alturaLosango, baseLosango; //variaveis declaradas
        Console.WriteLine("Informe a altura do losango"); //escreve na tela
        baseLosango = Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine("Informe a base do losango");
        alturaLosango = Convert.ToDouble(Console.ReadLine());
        areaLosango = (baseLosango * alturaLosango)/2;
        Console.WriteLine("A área do losango é " + areaLosango);
        Console.ReadKey();*/

    double mediaNota, nota1, nota2, nota3, nota4;
        Console.WriteLine("Informe a nota 1");
        nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a nota 2");
        nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a nota 3");
        nota3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a nota 4");
        nota4 = Convert.ToDouble(Console.ReadLine());
        mediaNota = (nota1 + nota2 + nota3 + nota4) / 4;
        Console.WriteLine("A média entre as notas é "+ mediaNota);