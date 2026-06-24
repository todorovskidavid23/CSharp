using Microsoft.AspNetCore.Routing.Constraints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// CONVENTIONAL ROUTING
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");//this is the default route, it will be used if no other route matches, it is optional

app.MapControllerRoute(
    "allCourses",//using this name we can refer to this route in the code, for example in the RedirectToAction method, so we can use it to redirect to this route, for example : RedirectToAction("GetAllCourses", "Courses", new { area = "" }, "allCourses");
    pattern: "courses/allcourses",//this is the pattern of the route, it will be used to match the incoming request, it is optional
    defaults: new { controller = "Courses", action = "GetAllCourses" }//we must specify the controller and action, otherwise the route will not work, it is optional
    //this is custom route, courses/allcourses will be the url for this route, and not courses/getallcourses, so we can use it to redirect to this route, for example : RedirectToAction("GetAllCourses", "Courses", new { area = "" }, "allCourses"
    );

app.MapControllerRoute(
    "course_by_name_with_constraint",
    pattern: "courses/{name}",//if we want parameter we use {} and the name of the parameter, so we can use it to redirect to this route, for example : RedirectToAction("GetCourseByName", "Courses", new { area = "" }, "course_by_name_with_constraint"
    defaults: new { controller = "Courses", action = "GetCourseByName" },
    constraints: new { name = new MinLengthRouteConstraint(5) }//this is a custom route with a constraint, the constraint is that the name must be at least 5 characters long, otherwise the route will not match
    );

app.MapControllerRoute(
    "course_multiple_params",
    pattern: "courses/{id}/{name}",//the sequence of the parameters is important, if we change the sequence, the route will not match, so we can use it to redirect to this route, for example : RedirectToAction("GetCourseByIdAndName", "Courses", new { area = "" }, "course_multiple_params"
    defaults: new { controller = "Courses", action = "GetCourseByIdAndName" },
    constraints: new { id = new IntRouteConstraint() }//this is a custom route with multiple parameters, the constraint is that the id must be an integer, otherwise the route will not match
    //must be integer
    );

app.MapControllerRoute(
    "course_by_id",//this is the name of the route, it can be anything and is used to identify the route, it is optional 
    pattern: "courses/getCourseById/{id:int}", //same as IntRouteConstraints();  //this is the pattern of the route, it is used to match the incoming request, it can be anything and is used to identify the route, it is optional
    defaults: new { controller = "Courses", action = "GetCourseById" } //and this is the default values for the route, it is used to provide default values for the route parameters, it is optional
    );
app.Run();
//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
