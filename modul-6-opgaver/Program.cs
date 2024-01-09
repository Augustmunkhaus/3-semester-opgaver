// See https://aka.ms/new-console-template for more information
using model;
using Model;

Console.WriteLine("Hello, World!");

using (var db = new TaskContext())
{

    Console.WriteLine($"Database path: {db.DbPath}.");

    var addtodo = new Board("første opgave der skal laves", "skoleopgave");
    db.Add(addtodo);
    db.SaveChanges();












}