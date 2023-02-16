WebApplication app = WebApplication.Create();

app.Urls.Add("http://localhost:3000");
app.Urls.Add("http://*:3000");

List<Supervillain> villains = new();

Supervillain penguin = new Supervillain();
penguin.Name = "Penguin";
penguin.Appearance = "Short";
penguin.Strength = 50;

app.MapGet("/", Answer);

app.MapGet("/Supervillain/", () => 
{
    return penguin;
});

app.Run();

static string Answer() 
{
    return "SUPER BOWL!";
}

//http://10.151.170.24:3000