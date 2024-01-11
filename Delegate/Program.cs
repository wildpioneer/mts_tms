using Delegate;
using Delegate.HomeWork;

// -================= Single Cast Delegate
// new Example1().Run();
// new Example2().Run();

// -================= Multi Cast Delegate
// new Example3().Run();

// -================= Анонимные методы
// new Example4().Run();

// -================= Delegate как параметр
//new Example5().Run();

// -================= Живой пример
// new Example6().Run();

// -================= Invoke
// new Example7().Run();

// -================= Generic Delegates
// new Example8().Run();

// -================= Лямбда выражения
/*
Lambda lambda = new Lambda();
lambda.Example0();
lambda.Example1();
lambda.Example2();
lambda.Example3();
lambda.Example4();
lambda.Example5();
lambda.Example6();
*/

// -================= Action Delegates
/*
ActionExamples actionExamples = new ActionExamples();
actionExamples.SimpleAction();

actionExamples.PerformOperation(5, 3, (a, b) => Console.WriteLine($"Sum: {a + b}"));
actionExamples.PerformOperation(8, 4, (a, b) => Console.WriteLine($"Product: {a * b}"));

actionExamples.Run();
*/

// -================= Predicate Delegates
/*
PredicateExample predicateExample = new PredicateExample();
predicateExample.Run();
*/

// -================= Func Delegates
FuncExample funcExample = new FuncExample();
funcExample.Run();

// HomeWork
/*
Task4 task4 = new Task4();
task4.Run();
*/