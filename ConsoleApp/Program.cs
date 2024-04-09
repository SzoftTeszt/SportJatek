using ClassLibrary.Data;
using ClassLibrary.Models;

GolfContext db = new GolfContext();

if (!db.Player.Any()) {
    var sorok = File.ReadAllLines(@"c:\adat\golfjatekosok.txt").Skip(1);
    foreach (var line in sorok)
        db.Player.Add(new Player(line));
    db.SaveChanges();
}
if (!db.Result.Any()) {
    var sorok = File.ReadAllLines(@"c:\adat\golferedmenyek.csv").Skip(1);
    foreach (var line in sorok)
        db.Result.Add(new Result(line));
    db.SaveChanges();
}