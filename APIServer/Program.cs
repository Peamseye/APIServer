WebApplication app = WebApplication.Create();

app.Urls.Add("http://localhost:3000");
app.Urls.Add("http://*:3000");

joe swanson = new joe();
swanson.Name = "Joe";
swanson.Appearance = "Crippled";
swanson.Strength = 9999;

app.MapGet("/", Answer);

app.MapGet("/joe/", () => 
{
    return swanson;
});

app.Run();

static string Answer() 
{
    return "SUPER BOWL!";
}

//http://10.151.170.24:3000