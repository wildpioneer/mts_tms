﻿// See https://aka.ms/new-console-template for more information

using Encapsulation;

State state = new State();
 
// обратиться к переменной defaultVar у нас не получится,
// так как она имеет модификатор private и класс StateConsumer ее не видит
//Console.WriteLine(state.defaultVar); //Ошибка, получить доступ нельзя
 
// то же самое относится и к переменной privateVar
//Console.WriteLine(state.privateVar); // Ошибка, получить доступ нельзя
 
// обратиться к переменной protectedPrivateVar не получится,
// так как класс StateConsumer не является классом-наследником класса State
//Console.WriteLine(state.protectedPrivateVar); // Ошибка, получить доступ нельзя
 
// обратиться к переменной protectedVar тоже не получится,
// так как класс StateConsumer не является классом-наследником класса State
//Console.WriteLine(state.protectedVar); // Ошибка, получить доступ нельзя
 
// переменная internalVar с модификатором internal доступна из любого места текущего проекта
// поэтому можно получить или изменить ее значение
Console.WriteLine(state.internalVar);
 
// переменная protectedInternalVar так же доступна из любого места текущего проекта
Console.WriteLine(state.protectedInternalVar);
 
// переменная publicVar общедоступна
Console.WriteLine(state.publicVar);

// Методы
//state.Print(); //Ошибка, получить доступ нельзя
 
//state.PrintPrivate(); // Ошибка, получить доступ нельзя
 
//state.PrintProtectedPrivate(); // Ошибка, получить доступ нельзя
 
//state.PrintProtected(); // Ошибка, получить доступ нельзя
 
state.PrintInternal();    // норм
 
state.PrintProtectedInternal();  // норм
 
state.PrintPublic();      // норм
