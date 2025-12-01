var builder = WebApplication.CreateBuilder(args);

// 🔧 Forzar el puerto desde configuración o desde argumentos
// Si quieres que lea el puerto desde appsettings.json, descomenta esta línea:
// builder.WebHost.UseConfiguration(builder.Configuration);

// Opción más directa y confiable: forzar el puerto aquí.
// Puedes cambiarlo a 8080 u otro que tú desees.
builder.WebHost.UseUrls("http://localhost:8080");

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<CaminaDog.Services.IDiagnosisService, CaminaDog.Services.DiagnosisService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
