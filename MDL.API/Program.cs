WebApplicationBuilder builder = WebApplication.CreateBuilder(args);



/*
 builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
 
 */


WebApplication app = builder.Build();


/*
 if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
 
 */


app.Map("/{alo}/{telo}", async (HttpContext ctx) =>
{
    var routeValues = ctx.Request.RouteValues;
    await ctx.Response.WriteAsync($"<h1> {routeValues}</h1>");
});


app.Use(async (ctx, nxt) =>
{
    //https://localhost:7259/alooooo/teloooooo?xx=xxxxxx&yy=yyyyyy
  

    var host = ctx.Request.Host.Value;
    var schema = ctx.Request.Scheme;
    PathString pathBase = ctx.Request.PathBase;
    PathString pathString = ctx.Request.Path;

    var routeValues = ctx.Request.RouteValues;

    /*
     
    QueryString queryString = ctx.Request.QueryString;

    if (queryString.HasValue)
    {
        string qryStr = queryString.Value;
        Console.WriteLine(qryStr);

    }



    IQueryCollection queryCollection = ctx.Request.Query;
    foreach (var item in queryCollection)
    {
        string key = item.Key;
        string value = item.Value;
        Console.WriteLine($"{key} : {value}");
    }

    if (queryCollection.ContainsKey("alo"))
    {
        string aloValue = queryCollection["alo"];
        if (aloValue == "alooooo")
        {
            await ctx.Response.WriteAsync("<h1>Hello world..!</h1>");
            return;
        }
    }

     
     */



    await nxt(ctx);

});



app.Run();
























/*
 
 
 
 app.Map("/{alo}/{telo}", async (HttpContext ctx) =>
{
    var routeValues = ctx.Request.RouteValues;
    await ctx.Response.WriteAsync($"<h1> {routeValues}</h1>");
});


app.Use(async (ctx, nxt) =>
{
    //https://localhost:7259/alooooo/teloooooo?xx=xxxxxx&yy=yyyyyy
  

    var host = ctx.Request.Host.Value;
    var schema = ctx.Request.Scheme;
    PathString pathBase = ctx.Request.PathBase;
    PathString pathString = ctx.Request.Path;

    var routeValues = ctx.Request.RouteValues;
 
    QueryString queryString = ctx.Request.QueryString;

    if (queryString.HasValue)
    {
        string qryStr = queryString.Value;
        Console.WriteLine(qryStr);

    }



    IQueryCollection queryCollection = ctx.Request.Query;
    foreach (var item in queryCollection)
    {
        string key = item.Key;
        string value = item.Value;
        Console.WriteLine($"{key} : {value}");
    }

    if (queryCollection.ContainsKey("alo"))
    {
        string aloValue = queryCollection["alo"];
        if (aloValue == "alooooo")
        {
            await ctx.Response.WriteAsync("<h1>Hello world..!</h1>");
            return;
        }
    }

     
 



await nxt(ctx);

});







*/















/*
 app.Use(async (ctx, nxt) =>
{
    //https://localhost:7259?alo=alooooo&telo=teloooooo

    var host = ctx.Request.Host.Value;
    var schema = ctx.Request.Scheme;
    PathString pathBase = ctx.Request.PathBase;
    PathString path = ctx.Request.Path;
    QueryString queryString = ctx.Request.QueryString;

    if(queryString.HasValue)
    {
        string qryStr = queryString.Value;
        Console.WriteLine(qryStr);
        
    }



    IQueryCollection queryCollection = ctx.Request.Query;
    foreach (var item in queryCollection)
    {
        string key = item.Key;
        string value = item.Value;
        Console.WriteLine($"{key} : {value}");
    }

    if(queryCollection.ContainsKey("alo"))
    {
        string aloValue = queryCollection["alo"];
        if (aloValue == "alooooo")
        {
            await ctx.Response.WriteAsync("<h1>Hello world..!</h1>");
            return;
        }
    }



    await nxt(ctx);

});
 
 
 */




























//app.Use(async (HttpContext ctx, RequestDelegate nxt) =>
//{
//    Console.WriteLine("m2 start");
//    await nxt(ctx);
//    Console.WriteLine("m2 End");
//});



//app.Use(async (HttpContext ctx, RequestDelegate nxt) =>
//{
//    Console.WriteLine("m3 start");
//    await ctx.Response.WriteAsync("Hello World!");
//    Console.WriteLine("m3 End");
//});








































/*
 
 
 
 
 
app.Use(async (ctx, nxt) =>
{

    //https://localhost:7259  ?alo=alooooo&telo=teloooooo

    string? host = ctx.Request.Host.Value;
    var schema = ctx.Request.Scheme;
    PathString pathBase = ctx.Request.PathBase;
    PathString path = ctx.Request.Path;

    QueryString queryString = ctx.Request.QueryString;

    queryString.Add("newKey", "newValue");

    if (queryString.HasValue)
    {
        string alo = queryString.Value;
    }



    IQueryCollection queryCollection = ctx.Request.Query;

    foreach (var item in queryCollection)
    {
        string key = item.Key;
        string value = item.Value;
        Console.WriteLine($"{key} : {value}");
    }

    if (queryCollection.ContainsKey("alo"))
    {
        string aloValue = queryCollection["alo"];
        if (aloValue == "alooooo")
        {
            await ctx.Response.WriteAsync("Aloooooo");
            return;
        }
    }



    await nxt(ctx);

});

 
 
 
 
 */




/*
 
 
 
 
 
 
 app.Use(async (ctx, nxt) =>
{

    //https://localhost:7259/?alo=alooooo&telo=teloooooo

    var schema = ctx.Request.Scheme;
    PathString pathBase = ctx.Request.PathBase;
    PathString path = ctx.Request.Path;
    QueryString queryString = ctx.Request.QueryString;
    queryString.Add("newKey", "newValue");
 

    IQueryCollection query = ctx.Request.Query;
    
    foreach (var item in query)
    {
        string key = item.Key;
        string value = item.Value;

        Console.WriteLine($"{key} : {value}");
    }

    if(query.ContainsKey("alo"))
    {
        string aloValue = query["alo"];
        if(aloValue == "alooooo")
        {
            await ctx.Response.WriteAsync("Aloooooo");
        }

    }

    await nxt(ctx);

});
 
 
 
 
 
 
 
 
 
 
 
 
 */





/*
 // Use  UseWhen   Run
//--------------------------
 app.Use(async (HttpContext ctx, RequestDelegate nxt) =>
{

    //https://localhost:7259 ? alo=alooooo&telo=teloooooo

    string? host = ctx.Request.Host.Value;
    var schema = ctx.Request.Scheme;
    PathString pathBase = ctx.Request.PathBase;
    PathString path = ctx.Request.Path;
    QueryString query = ctx.Request.QueryString;
    IQueryCollection queryCollection = ctx.Request.Query;

    if (query.HasValue)
    {
        string alo = query.Value;
    }

    if(query.Value.Contains("alo"))
    {
        string alo = query.Value;
    }


    string? method = ctx.Request.Method;
    IHeaderDictionary headers = ctx.Request.Headers;



    await nxt(ctx);
   
});

 
 */

