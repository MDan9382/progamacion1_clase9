
using clase_9.Clases;

Carro carrito = new Carro("toyota", 2021, "rojo");

Console.WriteLine(carrito.accel(0));


Console.WriteLine(carrito.accel(1) + "km/h");
Console.WriteLine(carrito.accel(1) + "km/h");
Console.WriteLine(carrito.accel(1) + "km/h");

//carrito.marca = "nissan";
//carrito.modelo = 2021;
//carrito.color = "rojo";
//carrito.dueño = "juan";
//carrito.maxvelocidad = 200;

Carro carrito2 = new Carro("nissan", 2020, "azul");


Console.WriteLine($"mi carro es un {carrito.marca} {carrito.modelo} de color {carrito.color}");
Console.WriteLine($"mi otro carro es un {carrito2.marca} {carrito2.modelo} de color {carrito2.color}");

