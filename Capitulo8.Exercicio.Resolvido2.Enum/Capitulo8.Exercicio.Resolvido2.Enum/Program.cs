using Capitulo8.Exercicio.Resolvido2.Enum.Entities;

var comment1 = new Comment("Have a nice trip!");
var comment2 = new Comment("Wow that's awesome!");
var post1 = new Post(
    DateTime.Parse("21/06/2018 13:04:55"),
    "Traveling to new Zealand",
    "I'm going to visit this wonderful country!", 
    12
    );

post1.AddComment(comment1);
post1.AddComment(comment2);

Console.WriteLine(post1);
