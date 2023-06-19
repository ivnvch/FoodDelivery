using FoodDelivery;
using FoodDelivery.DAL;
using Microsoft.EntityFrameworkCore;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(connection));

builder.Services.AddControllers();

builder.Services.AddAuthorization();
//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//    .AddJwtBearer(options =>
//    {
//        options.TokenValidationParameters = new TokenValidationParameters
//        {
//            // ���������, ����� �� �������������� �������� ��� ��������� ������
//            ValidateIssuer = true,
//            // ������, �������������� ��������
//            ValidIssuer = AuthOptions.ISSUER,
//            // ����� �� �������������� ����������� ������
//            ValidateAudience = true,
//            // ��������� ����������� ������
//            ValidAudience = AuthOptions.AUDIENCE,
//            // ����� �� �������������� ����� �������������
//            ValidateLifetime = true,
//            // ��������� ����� ������������
//            IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
//            // ��������� ����� ������������
//            ValidateIssuerSigningKey = true,
//        };
//    });

builder.Services.RegisterRepositories();
builder.Services.RegisterServices();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();


//public class AuthOptions
//{
//    public const string ISSUER = "MyAuthServer"; // �������� ������
//    public const string AUDIENCE = "MyAuthClient"; // ����������� ������
//    const string KEY = "mysupersecret_secretkey!123";   // ���� ��� ��������
//    public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
//        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
//}