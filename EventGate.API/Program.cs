using EventGate.Business.Mappers;
using EventGate.Business.Models.DTOs;
using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services;
using EventGate.Business.Services.Interface;
using EventGate.Data;
using EventGate.Data.Entity;
using EventGate.Data.Repositories;
using EventGate.Data.Repositories.Interface;
using EventGate.Services.JWT;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace EventGate
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin",
                    b =>
                    {
                        b.SetIsOriginAllowed(host => true)
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .AllowCredentials();
                    });
            });

            builder.Services.AddControllers();
            builder.Services.AddHttpContextAccessor();

            // Register DbContext
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

            // Add Identity services
            builder.Services.AddIdentityCore<User>()
                .AddRoles<IdentityRole>()
                //.AddSignInManager<SignInManager<User>>()
                .AddSignInManager()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            // Add Scoped
            builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

            //-- User -- 
            builder.Services.AddAutoMapper(typeof(UserMapper));
            builder.Services.AddScoped<IUserPropository, UserRepository>();
            builder.Services.AddScoped<IUserService, UserService>();
            //--chat Room--
            builder.Services.AddScoped<IChatRoomRepository, ChatRoomRepository>();
            builder.Services.AddScoped<IChatRoomServices, ChatRoomServices>();
            
            //--Chat--
            builder.Services.AddScoped<IChatRepository, ChatRepository>();
            
            //-- Club -- 
            builder.Services.AddScoped<IClubRepository, ClubRepository>();
            builder.Services.AddScoped<IClubService, ClubService>();

            //-- Ticket -- 
            builder.Services.AddScoped<ITicketRepository, TicketRepository>();
            builder.Services.AddScoped<ITicketService, TicketService>();

            //-- Seat -- 
            builder.Services.AddScoped<ISeatRepository, SeatRepository>();
            builder.Services.AddScoped<ISeatService, SeatService>();

            //-- Voucher -- 
            builder.Services.AddScoped<IVoucherRepository, VoucherRepository>();
            builder.Services.AddScoped<IVoucherService, VoucherService>();

            //-- Order -- 
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();
            builder.Services.AddScoped<IOrderService, OrderService>();

            //-- OrderDetail -- 
            builder.Services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            builder.Services.AddScoped<IOrderDetailService, OrderDetailService>();

            //-- Email --
            builder.Services.AddScoped<IEmailService, EmailService>();

            //-- Event -- 
            builder.Services.AddScoped<IEventRepository, EventRepository>();
            builder.Services.AddScoped<IEventService, EventService>();

            //-- EventType -- 
            builder.Services.AddScoped<IEventTypeRepository, EventTypeRepository>();
            builder.Services.AddScoped<IEventTypeService, EventTypeService>();

            //-- EventClub --
            builder.Services.AddScoped<IEventClubsRepository, EventClubsRepository>();
            builder.Services.AddScoped<IEventClubService, EventClubService>();

            //-- UserEvent --
            builder.Services.AddScoped<IUserEventRepository, UserEventRepository>();
            builder.Services.AddScoped<IUserEventService, UserEventService>();

            //-- UserHistory --
            builder.Services.AddScoped<IUserHistoryRepository, UserHistoryRepository>();
            builder.Services.AddScoped<IUserHistoryService, UserHistoryService>();

            //-- EventRule -- 
            builder.Services.AddScoped<IEventRuleRepository, EventRuleRepository>();
            builder.Services.AddScoped<IEventRuleService, EventRuleService>();

            //-- PaymentsInfo -- 
            builder.Services.AddScoped<IPaymentsInfoRepository, PaymentsInfoRepository>();
            builder.Services.AddScoped<IPaymentsInfoService, PaymentsInfoService>();

            //-- EventFeedback -- 
            builder.Services.AddScoped<IEventFeedBackRepository, EventFeedBackRepository>();
            builder.Services.AddScoped<IEventFeedBackService, EventFeedBackService>();

            // --EventHistory --
            builder.Services.AddScoped<IEventHistoryRepository, EventHistoryRepository>();
            builder.Services.AddScoped<IEventHistoryService, EventHistoryService>();

            //-- UserEventHistory --
            builder.Services.AddScoped<IUserEventHistoryRepository, UserEventHistoryRepository>();
            builder.Services.AddScoped<IUserEventHistoryService, UserEventHistoryService>();

            // --Blog--
            builder.Services.AddScoped<IBlogRepository, BlogRepository>();
            builder.Services.AddScoped<IBlogService, BlogService>();


            builder.Services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequiredLength = 8;
                options.Password.RequiredUniqueChars = 1;
                options.User.RequireUniqueEmail = false;
                options.Tokens.PasswordResetTokenProvider = TokenOptions.DefaultProvider;
                options.Tokens.EmailConfirmationTokenProvider = TokenOptions.DefaultProvider;
            }).Configure<DataProtectionTokenProviderOptions>(options => options.TokenLifespan = TimeSpan.FromMinutes(15));    

            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                var secretKey = builder.Configuration["JwtSettings:SecretKey"];
                if (string.IsNullOrEmpty(secretKey))
                {
                    throw new ArgumentNullException(nameof(secretKey), "Secret key is missing in configuration");
                }

                //options.Audience = "My Audience";
                //options.Authority = "My issuer";
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    //ValidateIssuer = true,
                    //ValidateAudience = true,
                    //ValidateLifetime = true,
                    //ValidateIssuerSigningKey = true,
                    //ValidIssuer = builder.Configuration["Jwt:Issuer"],
                    //ValidAudience = builder.Configuration["Jwt:Audience"],
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
                };
                options.RequireHttpsMetadata = false;
                options.Events = new JwtBearerEvents
                {
                    OnTokenValidated = context =>
                    {
                        var token = context.SecurityToken as JwtSecurityToken;
                        if (token != null && !Business.Services.JwtGenerator.IsTokenValid(token.RawData))
                        {
                            context.Fail("Token is invalid.");
                        }

                        return Task.CompletedTask;
                    }
                };
            })
            .AddCookie()
            .AddGoogle(GoogleDefaults.AuthenticationScheme, options =>
            {
                options.ClientId = builder.Configuration["Google:ClientID"];
                options.ClientSecret = builder.Configuration["Google:ClientSecret"];
                options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            });

            // Add Email Configuration
            var emailConfig = builder.Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>();
            builder.Services.AddSingleton(emailConfig);

            // Register necessary services
            builder.Services.AddDataProtection();

            builder.Services.AddSignalR();

            // Add Swagger services
            builder.Services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "Bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement{
                    {
                        new OpenApiSecurityScheme{
                            Reference = new OpenApiReference{
                                Id = "Bearer",
                                Type = ReferenceType.SecurityScheme
                            }
                        },
                        new List<string>()
                    }
                });

                c.EnableAnnotations();
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EventGate API", Version = "v1" });
            });

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "EventGate API V1");
                c.RoutePrefix = "swagger";
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
           

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseCors("AllowOrigin");
           
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<ChatRepository>("/Chathub");
                endpoints.MapControllers();
            });

            app.Run();
        }
    }
}
