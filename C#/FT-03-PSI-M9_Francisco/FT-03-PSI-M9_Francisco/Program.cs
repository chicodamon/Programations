//Criar viatura
using FT_03_PSI_M9_Francisco;

Viatura viatura1 = new Viatura("BMW", "M4 CS", 5, 2022);

Console.WriteLine("Marca: " + viatura1.obterMarca());

Console.WriteLine("Modelo: " + viatura1.obterModelo());

Console.WriteLine("Numero de Portas: " + viatura1.obterNumPortas());

Console.WriteLine("Ano: " + viatura1.obterAno());

viatura1.alterNumPortas(3);

Console.WriteLine("Alterado! Numero de Portas: " + viatura1.obterNumPortas());

viatura1.alterAno(2023);
Console.WriteLine("Alterado! Ano: " + viatura1.obterAno());
