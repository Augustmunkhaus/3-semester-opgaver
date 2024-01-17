using Model;
using System.Security.Cryptography.X509Certificates;

using (var db = new TaskContext())
{
    Console.WriteLine($"Database path: {db.DbPath}.");
    var user = new User("August");
    // Create
    Console.WriteLine("Indsæt et nyt task");
   var addtask = new TodoTask("En opgave der skal løses", false, "svær opgave");
    addtask.user= user;
    db.Add(addtask);

    db.SaveChanges();
    
    // Read
    Console.WriteLine("Find det sidste task");
    var lastTask = db.Tasks
        .OrderBy(b => b.TodoTaskId)
        .Last();
    Console.WriteLine($"Text: {lastTask.Text}");

    //update
     string UpdateTask(int id)
    {
        Console.WriteLine("opdater en task");
        var UpdatedTask = db.Tasks.FirstOrDefault(x => x.TodoTaskId== id);

        UpdatedTask.Text = "opdateret tekst";
        UpdatedTask.Done = true;
        db.SaveChanges();
        return "opdateret task";
    }
   // UpdateTask(1);

    //delete
    string DeleteTask(int id)
    {
        Console.WriteLine("slet en task");
            var DeletedTask = db.Tasks.First(x => x.TodoTaskId== id);

        db.Tasks.Remove(DeletedTask);
        db.SaveChanges();

        return "slettet task";
    }
    //DeleteTask(3);
    
}
    
