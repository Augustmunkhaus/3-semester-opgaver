using Model;
using System.Data.Common;

using (var db = new TaskContext())
{
    Console.WriteLine($"Database path: {db.DbPath}.");

    var newUser = new User("August");

    // Create
    Console.WriteLine("Indsæt et nyt task");
    var newTask = new TodoTask("En opgave der skal løses", false, "svær opgave");
     newTask.User = newUser;
    db.Add(newTask);
    db.SaveChanges();

    // Read
    Console.WriteLine("Find det sidste task");
    var lastTask = db.Tasks
        .OrderBy(b => b.TodoTaskId)
        .Last();
    Console.WriteLine($"Text: {lastTask.Text}");

    //opgave 2 - lav mere Crud
    //update
   /* var firstTask = db.Tasks.First();
    firstTask.Text = "";
    db.SaveChanges();
   */
    Console.WriteLine("Update the last task");
    var taskToUpdate = db.Tasks.Single(x => x.TodoTaskId== lastTask.TodoTaskId);
    
    taskToUpdate.Text = "Update";
    taskToUpdate.Done = true;
        db.SaveChanges();
   

 //fatter det ikke helt
 //delete
 //var deleteTask = db.Tasks.OrderBy(b => b.TodoTaskId).Last();
   //db.Tasks.Remove(deleteTask);
   // db.SaveChanges();

    //hvordan tester jeg det så?

    /*var taskToDelete = db.Tasks.Single(x => x.TodoTaskId== lastTask.TodoTaskId);
    db.Tasks.Remove(taskToDelete);
    db.SaveChanges();
   */
} //har lavet 2 versioner nu, aner ik hvad der er rigtigt. tak for de gode eksempler peter, det hjælper virkelig meget.
// er nået til opgave 4. den giver en fejl med noget foreign key halløj når jeg forsøger at update databasen efter en migration.
//der skal muligvis kigges på migration filen eller sådan noget bøvl.