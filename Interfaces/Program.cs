﻿// See https://aka.ms/new-console-template for more information

using Interfaces;
using Interfaces.BaseImpl;
using Interfaces.ExplicitImpl;
using Interfaces.FinalExample;

// IDisplayable displayable = new IDisplayable(); - Ошибка 

Smartphone smartphone = new Smartphone();
Tablet tablet = new Tablet();

// -======================== Обычное применение метода ========================-
smartphone.DisplayInformation("Hello from smartphone!");
tablet.DisplayInformation("Hello from tablet!");

// -======================== Продвинутое применение метода ========================-
// Мы можем использовать их, как будто они одинаковые, потому что они реализуют интерфейс
DisplayInformationOnDevice(smartphone, "Hello from smartphone!");
DisplayInformationOnDevice(tablet, "Hello from tablet!");

// Метод, который принимает любой объект, реализующий интерфейс IDisplayable
static void DisplayInformationOnDevice(IDisplayable device, string information)
{
    // Вызываем метод отображения, и не важно, что за устройство - смартфон, планшет или другое
    device.DisplayInformation(information);
}

// -======================== Реализация интерфейсов по умолчанию ========================-
// smartphone.DrawBorders(); Ошибка - метод DrawBorders() не определен в классе
tablet.DrawBorders();

// -======================== Множественная реализация интерфейсов ========================-
Tablet1 tablet1 = new Tablet1();
tablet1.Charge();

// -======================== Интерфейсы в преобразованиях типов ========================-
// Все объекты Tablet1 являются объектами IChargeable или IDisplayable
IChargeable tablet21 = new Tablet1();
tablet21.Charge();

IDisplayable tablet22 = new Tablet1();
tablet22.DisplayInformation("Hello from tablet22!");

// Не все объекты IChargeable являются объектами Tablet1, необходимо явное приведение
Tablet1 anotherTable1 = tablet1; // Никаких проблем
// Tablet1 anotherTable2 = tablet22; // ! Ошибка

// если tablet22 представляет класс Tablet1, выполняем преобразование
if (tablet22 is Tablet1 anotherTable3) anotherTable3.DrawBorders();

// Ранее рассмотренный пример с применением преобразования
// smartphone.DrawBorders(); Ошибка - метод DrawBorders() не определен в классе
((IDisplayable)smartphone).DrawBorders();
tablet.DrawBorders();
((IDisplayable)tablet).DrawBorders();

// -======================== Явная реализация интерфейсов ========================-
BaseAction baseAction = new BaseAction();
// baseAction.Move(); - Ошибка, нет метода Move

// небезопасное приведение
((IAction)baseAction).Move();   
// безопасное приведение 
if (baseAction is IAction action) action.Move();
// или так
IAction baseAction2 = new BaseAction();
baseAction2.Move();


NewAction newAction = new NewAction();
// newAction.Move();  - Ошибка, нет метода Move
((IAction) newAction).Move();
((IMovable) newAction).Move();


HeroAction heroAction = new HeroAction();
heroAction.Move();
((IAction) heroAction).Move();

// -======================== Реализация интерфейсов в базовых и производных классах ========================-
Tablet3 tablet3 = new Tablet3();
tablet3.DisplayInformation("Hello from tablet3!");

// -======================== Virtual
Tablet4 tablet41 = new Tablet4();
tablet41.DisplayInformation("Hello from tablet41!");

IDisplayable tablet42 = new Tablet4();
tablet42.DisplayInformation("Hello from tablet42!");

// -======================== New
Tablet5 tablet51 = new Tablet5();
tablet51.DisplayInformation("Hello from tablet51!");

IDisplayable tablet52 = new Tablet5();
tablet52.DisplayInformation("Hello from tablet52!");


// -======================== Задача ========================-
ApplicationTester applicationTester = new ApplicationTester();
applicationTester.AddTest(new IntegrationTest());
applicationTester.AddTest(new UnitTest());
applicationTester.AddTest(new UITest());

applicationTester.RunTests();