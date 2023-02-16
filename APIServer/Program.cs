WebApplication app = WebApplication.Create();

app.Urls.Add("http://localhost:3000");
app.Urls.Add("http://*:3000");

List<Supervillain> villains = new();

villains.Add(new() { Name = "Penguin", Appearance = "Short with top hat", Strength = 50});
villains.Add(new() { Name = "Joker", Appearance = "Tall and with clown outfit", Strength = 150});
villains.Add(new() { Name = "Two-Face", Appearance = "Split personality & looks", Strength = 100});

app.MapGet("/", Answer);

app.MapGet("/supervillain/", () => 
{
    return villains;
});

app.MapGet("/superhero/{num}", (int num) =>
{
    return num * 2;
});

app.Run();

static string Answer() 
{
    return "SUPER BOWL!";
}

//http://10.151.170.24:3000