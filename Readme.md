# Taller de Aplicaciones Web con Blazor WebAssembly y .Net

Este taller esta orientado a conocer lo más elemental y básico del desarrollo de aplicaciones web con Blazor WebAssembly y .Net

## Introducción

A continuación conoceremos los conceptos básicos que necesitamos dominar para poder trabajar con Blazor WebAssembly.

## Prerequisitos.

- Conocimiento en C# y .Net
- Visual Code o Visual Studio.
- Conocimientos sobre desarrollo web (HTML, CSS, JavaScript).
- .Net 6 o superior.

### ¿Qué es WebAssembly y Bazor?

#### WebAssembly.
- **Nuevo estándar web** que aparece por primera vez en el año 2015.
- Diseñado inicialmente para **C y C++**.
- Permite a **lenguajes compilados ejecutarse en el navegador** (Rust, C++, Go, C#).
- Extensiones **.wast, .wasm**
- Puede trabajar junto con **JavaScript**

#### Casos de éxito con WebAssembly.
A continuación tenemos algunos casos de éxito con WebAssembly.

[Casos de Éxito con WebAssembly](https://madewithwebassembly.com)

![Figma](https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.o_5hw8d8HmsCPMKoiJfB5AHaHa%26pid%3DApi&f=1&ipt=821de8c19625db4bcb2c1a9183bdbe8c5b62747e47b845219bf5733e9b05d23d&ipo=images)

#### Blazor.

- Nueva tecnología para el desarrollo web.
- Sintaxis C# + HTML.
- Open Source y multiplataforma.
- Muchas librerías y apoyo de la comunidad.
- Puede trabajar junto con JavaScript.

#### Blazor WebAssembly Vs Blazor Server.

- Se ejecuta en el navegador.
- Utiliza Web Assembly para hospedarse en el navegador.
- Se ejecuta en el servidor.
- Utiliza SignalR para sincronizar los cambios.

| Preview | .NET 3.1 | .NET 5 | .NET 6 | .NET 7 |
|----------|----------|----------|----------|----------| 
| 2018   | 2019   | 2020   | 2021 | 2022 | 
| Web Assembly    | .NET core integration   | CSS Isolation   | New Template | Hot Reload Improved |
| SPA application    | Share component   | Virtualization   | Hot reload | .NET Maui |
| Visual Studio Support    | .NET Standard   | Web SDK   | AOT compilation | New Console Output |
| Mono    |    | Wasm size improved   | Error boundaries | Inject services into custom validation attributes in Blazor |
|         |    | Lazy loading    | Components for react.js and angular | | 

### Creando un proyecto de Blazor en Visual Studio.

Seguimos los siguientes pasos que se citan a continuación.

```{bash}
    dotnet new blazorwasm -n MiProyecto002
```

1. Verificamos que tengamos activado la opción **Desarrollo de ASP.Net y Web**, como se muestra en la siguiente imagen.

![Activada la opción Desarrollo de ASP.Net y Web](image.png)

2. El siguiente paso es utilizar la barra de búsqueda de los tipos de proyectos y seleccionar Blazor Webassembly

![Blazor Webassembly](img/image-1.png)

3. Asignar un nombre y una ruta para almacenar el nuevo proyecto.

![Nombre y Ruta](img/image-2.png)

4. Seleccionamos el Framework con el que vamos a trabajar. Se sugiere utilizar a partir de la versión 6 en adelante.

![Selección del Framework](img/image-3.png)

5. Una vez creado el proyecto debemos probar que todo funciona correctamente.

![Proyecto Creado](img/image-4.png)

6. Una vez probado el proyecto, podemos tener la seguridad de que todo está correctamente listo para empezar.

![Probando el Proyecto](img/image-5.png)

7. Finalmente verificamos tener habilitada la opción **Hot Reload** para poder trabajar con total normalidad.

![Hot Reload](img/image-6.png)

### Creando un proyecto de Blazor con CLI.

Para utilizar el CLI de .Net es necesario primero ubicarnos en la ruta a nivel de consola en donde vamos a crear el proyecto, seguido de ello utilizamos el siguiente comando.

```{bash}
dotnet new blazorwasm -n <title of project>
```
![Creación del Proyecto en Blazor WebAssembly desde CLI de .Net](img/image-7.png)

Una vez ejecutado el comando debe salir algo como la siguiente imagen.

![Proyecto Creado en Blazor WebAssembly desde CLI de .Net](img/image.png)

2. Ahora es necesario verificar que el proyecto compile correctamente, para ello vamos a utilizar el comando build. Es necesario estar en la ruta dentro del proyecto creado.

```{bash}
dotnet build
```
![Compilación del Proyecto](img/image-8.png)

3. Si todo ha salido bien hasta ahora, es necesario utilizar el comando run para ejecutar nuestro proyecto en un navegador.

```{bash}
dotnet run
```
![Ejecutando el proyecto](img/image-9.png)

![Ejecutando el proyecto en el navegador](img/image-10.png)

4. Por comodidad es mejor trabajar desde **Visual Studio Code** ya que consume menos recursos en maquinas modestas. En estos casos se sugiere utilizar la terminal del mismo editor y utilizar el comando watch run para activar el modo **Hot Reload** y poder programar con mayor rapidez.

```{bash}
dotnet watch run
```
![Modo Hot Reload en VS Code](img/image-11.png)

Esto es genial, ya que podemos hacer cambios en tiempo real y visualizarlos en el navegador.

| Sin modificación | Con modificación |
|----------|----------|
| ![Sin modificación](img/image-12.png)  | ![Con modificación](img/image-13.png)   |

### Analizando extensiones de Visual para Blazor.

Ahora vamos a empezar analizando algunas extensiones para **Visual Studio Code** que nos facilitarán el trabajo de programación con Blazor.

La primera extensión que analizaremos es la extensión de C# creada por Microsoft que nos permitirá trabajar en VS Code con este lenguaje de programación.

![Alt text](img/image-15.png)

La siguiente extensión que se sugiere utilizar es los Snippets para Blazor, de las cuales tenemos Blazor Snippet Pack y Blazor Snippets.

| Blazor Snippet Pack | Blazor Snippets|
|----------|----------|
| ![Blazor Snippet Pack](img/image-16.png)   | ![Blazor Snippet](img/image-17.png)   | 

#### Demo.

Mediante estas extensiones nos será mas sencillo poder escribir código como se muestra a continuación.

![Eventos que ocurren en este ciclo de vida](img/image-18.png)

En la imagen anterior podemos ver como aparecen todos los eventos que ocurren en este ciclo de vida. Estos son eventos que internamente tienen un componente y normalmente se debe crear una función para poder utilizar en estos eventos una porción de código en específico para agregar lógica al componente.

Esto nos permitirá crear esta estructura de código sin la necesidad de escribir cada uno de los detalles necesarios para utilizar por ejemplo este método.

![Código creado con las extensiones](img/image-19.png)

En la imagen anterior se puede visualizar lo rápido que se puede escribir código en Blazor con las extensiones utilizadas.

### Estructura de Componentes y Arquitectura en Blazor.
Vamos a analizar los componentes básicos de Blazor, es decir todos los archivos que se crearon en el template básico.

### Program.cs

![Archivo Program.cs](img/image-20.png)

Lo que hace este archivo, es tener toda la estructura general para poder ejecutar el proyecto. Es importante resaltar, que aquí es donde se realiza la configuración de los servicios, es decir todas las dependencias que vamos a estar inyectando en la aplicación se van a configurar en este punto.

Por ejemplo como se hace con una Web de ASP, es decir una Web API de ASP.Net

### MiProyecto002.csproj

![Alt text](img/image-21.png)

Se puede observar el Target Framework, el SDK para trabajar con BlazorWebAssembly

Se obtiene la versión del Framework, la configuración del lenguaje

Y 2 paquetes que vienen por defecto.

- Microsoft.AspNetCore.Components.WebAssembly
- Microsoft.AspNetCore.Components.WebAssembly.DevServer

En este caso ambos se utilizan para poder ejecutar el proyecto.

### App.razor

![App.razor](img/image-22.png)

Este archivo va a contener toda aplicación y la arquitectura de componentes que vamos a ir creando.

Este archivo usualmente no se modifica, se extiende ya que se agrega nuevas configuraciones, pero normalmente debe contenerse con esta parte inicial para que pueda realizar la configuración y ejecución.

### Imports.razor

![Imports.razor](img/image-23.png)

En este archivo se hace algunas declaraciones de @using, de los @using que se van a utilizar.

La ventaja que tenemos de utilizar todos los using que coloquemos aquí se los va a implementar en los complementos.

Esto evita que vayamos implementando en cada uno de los componentes, ya que es una cantidad grande de cosas comunes que se puede exponer aquí y no en cada declaración de cada componente.

De esta forma queda visible y expuesto para todos los componentes.

### Directorio wwwRoot

![wwwroot](img/image-24.png)

Esta carpeta es clásica en .NET donde se almacenan los archivos estáticos del proyecto, por ejemplo los archivos css, html, carpetas de imágenes, iconos, etc.

Existe un solo archivo index.html, esto quiere decir que es un SPA, un simple page application. En donde un único archivo html contiene toda la aplicación, la interfaz va cambiando en base a lo que el usuario va haciendo, los botones que va seleccionando, etc. 

### Directorio Shared

![Directorio Shared](img/image-25.png)

Este directorio tiene los componentes compartidos. Este es un concepto que lo veremos más adelante, pero es un concepto que se utiliza en Blazor para poder reutilizar componentes.

Hablamos de componentes genéricos que queremos utilizar en diferentes partes.

### Directorio Properties.

![Directorio Properties](img/image-26.png)

La configuración de como se va a ejecutar la aplicación.

### Directorio Pages.

![Directorio Pages](img/image-27.png)

Aquí se encuentran los componentes que se van a utilizar en la aplicación. Por defecto vienen 3 componentes.

- **Counter.Razor:** Es un componente que viene por defecto, es un componente que tiene un contador, que tiene un botón para incrementar y otro para decremental.
- **FetchData.Razor:** Es un componente que viene por defecto, es un componente que lista una tabla.
- **Index.Razor:** Es un componente que viene por defecto, es un componente que es el home de la aplicación.

### Analizando la estructura de un componente.

![Analizando el Componente Counter](img/image-28.png)1

Lo más importante de un componente es entender su estructura general, por ejemplo empezamos con un **@page**, que es la ruta que va a tener el componente.

También es importante conocer el PageTitle, que es el título que va a tener el componente.

En esta sección vamos a tener toda la estructura del componente en sí, es decir el HTML, el CSS y C#. Cada vez que vayamos a utilizar C# se debe utilizar **@** para poder empezar a escribir y al momento que se compile la aplicación sepa que se va a ejecutar código de C#.

Por otra parte es importante conocer el **@code** y un **@code** es donde se va a escribir el código de C#.

También es importante conocer los eventos como @onclick, @onchange, etc. Estos eventos son los que se van a ejecutar en el componente. Es importante reconocer que por ejemplo en el evento @onclick se debe colocar un método que se va a ejecutar cuando se haga click en el botón.

Si analizamos el componente de index.razor, podemos ver que tiene un **@page** que es la ruta que va a tener el componente, también tiene un **@page** que es el título que va a tener el componente. Pero no contiene un **@code** ya que no tiene código de C#.

### Ciclo de Vida en Componentes y Parámetros.

El ciclo de vida se refiere a los **eventos que ocurren desde que se crea un componente hasta que se renderiza** en la interfaz.

![](https://learn.microsoft.com/en-us/aspnet/core/blazor/components/lifecycle/_static/lifecycle1.png?view=aspnetcore-7.0)

#### Lista de Eventos.

- SetParametersAsync.
- OnInitialized{Async}.
- OnAfterRenderAsync (Manejo de notificaciones, login, guardar en la bitácora, cosas extra que se puede hacer cuando el componente ha sido renderizado).
- OnParametersSet{Async}.
- StateHasChanged (Cuando ha cambiado algo dentro del componente y la interfaz se va a refrescar).

[Revisar la Documentación Oficial.](https://learn.microsoft.com/en-us/aspnet/core/blazor/components/lifecycle?view=aspnetcore-7.0)

#### Demo

![Código de los Componentes modificados](img/image-29.png)

```{razor}

@page "/counter"
@inject ILogger<Counter> logger;

<PageTitle>Counter</PageTitle>

<h1>Counter</h1>

<p role="status">Current count: @currentCount</p>

<button class="btn btn-primary" @onclick="IncrementCount">Click me</button>

@code {
    private int currentCount = 0;

    protected override void OnParametersSet()
    {
        logger.LogInformation("Se envian los parámetros");
    }

    protected override void OnAfterRender(bool firstRender)
    {
        logger.LogInformation("esto ocurre después de iniciar el componente");
    }

    private void IncrementCount()
    {
        currentCount++;
    }
}
```

Ahora revisamos la sección de parámetros en nuestro código.

```{blazor}
@page "/counter/{currentCountParameter?}"
@inject ILogger<Counter> logger;

<PageTitle>Counter</PageTitle>

<h1>Counter</h1>

<p role="status">Current count: @currentCount</p>

<button class="btn btn-primary" @onclick="IncrementCount">Click me</button>

@code {
    private int currentCount = 0;

    [SupplyParameterFromQuery]
    [Parameter]

    //public string? currentCountParameter {get;set;}
    public string? CountryFromQuery {get;set;}

    public override async Task SetParametersAsync(ParameterView parameters)
    {
        if (parameters.TryGetValue<string>(nameof(currentCountParameter), out var value))
        {
            if (value is not null)
                currentCountParameter = value;
        }
    
        await base.SetParametersAsync(parameters);
    }

    protected override void OnParametersSet()
    {
        logger.LogInformation("Se envían los parámetros");
    }

    protected override void OnInitialized()
    {   
        //currentCount = currentCountParameter != null ? int.Parse(currentCountParameter) : 0;
        currentCount = counterFromQuery != null ? int.Parse(counterFromQuery) : 0;
        logger.LogInformation("Se inicializa el componente");
    }

    protected override void OnAfterRender(bool firstRender)
    {
        logger.LogInformation("esto ocurre después de iniciar el componente");
    }

    private void IncrementCount()
    {
        currentCount++;
    }
}
```

![Seccion de Parámetros en el código](/img/image-30.png)

En nuevas versiones de código se aconseja utilizar este nuevo parámetro

```{blazor}
@page "/counter/{currentCountParameter?}"
@inject ILogger<Counter> logger;

<PageTitle>Counter</PageTitle>

<h1>Counter</h1>

<p role="status">Current count: @currentCount</p>

<button class="btn btn-primary" @onclick="IncrementCount">Click me</button>

@code {
    private int currentCount = 0;

    [Parameter]
    public string? currentCountParameter {get;set;}

    [SupplyParameterFromQuery]
    [Parameter]
    public string? CounterFromQuery {get;set;}

    public override async Task SetParametersAsync(ParameterView parameters)
    {
        if (parameters.TryGetValue<string>(nameof(currentCountParameter), out var value))
        {
            if (value is not null)
                currentCountParameter = value;
        }
    
        await base.SetParametersAsync(parameters);
    }

    protected override void OnParametersSet()
    {
        logger.LogInformation("Se envian los parametros");
    }

    protected override void OnInitialized()
    {
        //currentCount = currentCountParameter!= null ? int.Parse(currentCountParameter) : 0; 
        currentCount = CounterFromQuery!= null ? int.Parse(CounterFromQuery) : 0;
        logger.LogInformation("Se inicia el componente");
    }

    protected override void OnAfterRender(bool firstRender)
    {
        logger.LogInformation("esto ocurre despues de iniciar el componente");
    }

    private void IncrementCount()
    {
        currentCount++;
    }
}
```
![Pasando Parametros con CounterFromQuery](img/image-31.png)

Ejemplo de como se pasa el parametro con el QueryString

```{bash}
http://localhost:5123/counter?CounterFromQuery=200
```

### Creando Componentes Compartidos.

Una de las caracteristicas de los componentes compartidos es que no existe una ruta para ellos, por lo que no se puede acceder a ellos directamente.

El componente SurveyPrompt es un componente compartido. Se puede acceder a él desde cualquier página, pero no tiene una ruta de página asociada. En este caso podemos observer que en su secci'on @code crea un string? que se llama Title y se invoca mediante @Title.

![Componente SurveryPromt](img/image-32.png)

Siempre que se crea un componente compartido es porque se va a reutilizar en varias partes de la aplicación.

En el caso del titulo se puede crear un componente compartido para reutilizar código y el mismo puede ser una imagen por ejemplo que serviría para reutilizarlo.

## Demo

Creando un componente compartido para el titulo.

![Ejemplo de la Impelmentación de un componente compartido](img/image-33.png)

```{razor}
<h1>@Title</h1>


@code
{
    [Parameter]
    public string Title {get; set;}
}
```

Ahora lo podemos reutilizar en cualquier componente, la sintaxis que remplazaría al titulo es la siguiente.

```{razor}
<ModuleTitle Title="Hello, world!" />
```
### Creando Archivo de Configuración.

En el directorio wwwroot se crea un archivo llamado appsettings.json

![Agregando Configuraciones en el archivo appsettings.json](img/image-35.png)

```{json}

Esta configuración se puede cambiar
{
    "Title": "Hello, world ESPE!"
}
```
![Servidor con la configuración desde el archivo appsetings.json](img/image-36.png)

Codigo del archivo Index.razor

```{razor}
@page "/"
@inject IConfiguration config

<PageTitle>Index</PageTitle>

<ModuleTitle Title="@HelloMessage" />

Welcome to your new app.

<SurveyPrompt Title="How is Blazor working for you?" />

@code
{
   public string HelloMessage = "";

   protected override void OnInitialized()
   {
      HelloMessage = config["helloMessage"];
   }
}
```
 ## Conectando Blazor a Backend.

 Nota: En este punto puedes crear un proyecto nuevo con la version del SDK 6 de .Net, esto con el fin de evitar incompatibilidades.

Ahora vamos a conectarnos a un API desde el archivo de configuración, existen muchos API en el mundo que podemos utilizar de forma gratuita, otros tienen un costo, sin embargo vamos a buscar un API gratuito para poder trabajar sin inconvenientes.

Agregamos la siguiente línea al archivo.

```{json}
"apiUrl" : "https://api.escuelajs.co/api/"
```

En el archivo **Program.cs** se agrega la siguiente línea de código.

```{csharp}
var apiUrl = builder.Configuration.GetValue<string>("apiUrl");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiUrl) });
```
## Creando Componentes para la conexión a la API.

**Nota:** Con esta web, es posible autogenerar las clases a partir de un objeto json

[https://quicktype.io/csharp](https://quicktype.io/csharp)

Empezamos creando el directorio en la raiz del proyecto denominado **Models**, seguido creamos el archivo **Products.cs**, le agregamos el siguiente codigo.

```{csharp}
namespace MiProyecto002

public class Product
{
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string[] Images { get; set; }
        public string? Image { get; set; }
}
```

Ahora creamos el archivo **Category.cs** y agregamos el siguiente codigo.

```{csharp}
namespace MiProyecto002
public class Category
{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
}
```

Ahora creamos un directorio llamado **Services** en el directorio principal, creamos el archivo **ProductService.cs** y agregamos el siguiente codigo.

```{csharp}
using System.Net.Http.Json;
using System.Text.Json;

namespace MiProyecto002


public class ProductService : IProductService
{
    private readonly HttpClient client;

    private readonly JsonSerializerOptions options; 

    public ProductService( HttpClient httpClient)
    {
        client = httpClient;
        options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

        public async Task<List<Product>?> Get()
        {
            var response = await client.GetAsync("v1/products");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            return JsonSerializer.Deserialize<List<Product>>(content, options);
        }

        public async Task Add(Product product)
        {
            var response = await client.PostAsync("v1/products", JsonContent.Create(product));
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
        }

        public async Task Delete(int productId)
        {
            var response = await client.DeleteAsync($"v1/products/{productId}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
        }
}
```

De la misma forma incorporamos el archivo **Category.cs** y agregamos el siguiente codigo

```{csharp}
using System.Text.Json;

namespace MiProyecto002;

public class CategoryService : ICategoryService
{
      private readonly HttpClient client;
        private readonly JsonSerializerOptions options;
        public CategoryService(HttpClient client)
        {
            this.client = client;
            options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<List<Category>?> Get()
        {
            var response = await client.GetAsync("v1/categories");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            return JsonSerializer.Deserialize<List<Category>>(content, options);
        }
}
```
## Mostrando lista de productos.

Ahora vamos a implementar la interfaz, modificar un poco el codigo y realizar la configuracion al final en el archivo **ProductServices.cs**

```{csharp}

public interface IProductService
{
    Task<List<Category>?> Get();

    Task Add(Product product);

    Task Delete(int productId);
}
```
De la misma forma en el archivo **CategoryService.cs**.

```{csharp}
public interface ICategoryService
{
    Task<List<Category>?> Get();

}
```

En el archivo **Program.cs** realizamos la siguiente inserción de código.

```{csharp}
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MiProyecto002;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
var apiUrl = builder.Configuration.GetValue<string>("apiUrl");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiUrl) });

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

await builder.Build().RunAsync();
```

Ahora vamos a crear los componentes en la sección de Pages.

Creamos el archivo Products.razor y agregamos el siguiente codigo.

```{csharp}
@page "/product"
@inject ILogger<Products> logger;
@inject IProductService productService;

<PageTitle>Products</PageTitle>

<ModuleTitle Title="Products" />

@if(products?.Count > 0)
{
    <div class="products-container">
        @foreach (var product in products)
        {
            <div class="card">
                <img class="card-img-top" src="@product.Images[0]" alt="Product" loading="lazy" width="270" height="210">
                <div class="card-body">
                    <h4><b>@product.Title</b></h4>
                    <p>@product.Price?.ToString("C")</p>
                </div>
            </div>
        }
    </div>

}
else
{
    <p>No hay productos para mostrar</p>
}

@code
{
    private List<Product>? products;
    
    protected override async Task OnInitializedAsync()
    {
        products = await GetProducts();
    }

    private async Task<List<Product>> GetProducts()
        {
            return await productService.Get();
        }

}
```
Si todo ha salido bien ahora vamos a correr el servidor, si es necesario corregir errores de sintaxis y si no podemos ver los productos en la pantalla.

### Creando Menú y CSS para la lista de productos.

En el archivo ProductService.cs creamos la etiqueta css

```{css}
<style>
    .products-container{
    display:grid;
    grid-template-columns: repeat(auto-fill, 280px);
    grid-auto-rows:auto;
    grid-gap: 1rem;
    }
</style>
```
Sin embargo esta no es la mejor práctica, es por ello necesario que migremos este codigo css a un nuevo archivo que se encuentra en la sección Pages, creamos el archivo **Products.razor.css** y movemos lo que se encuentra dentro de la etiqueta **style**, a esta sección.

Ahora vamos a agregar nuestra url product a la sección de menú.

Agregamos el siguiente div en la sección Shared/NavMenu.razor

```{razor}
<div class="nav-item px-3">
    <NavLink class="nav-link" href="product">
        <span class="oi oi-list-rich" aria-hidden="true"></span> Products
    </NavLink>
</div>
```
### Creando un formulario para agregar registros.

Creamos el directorio Products dentro de Pages para evitar que se desordene el proyecto llamado Products.

Dentro del mismo agrupamos los archivos Products.razor y Products.razor.css, agregamos un nuevo archivo llamado AddProduct.razor con el siguiente codigo

```{razor}
@page "/addproduct"
@inject IProductService productService
@inject ICategoryService categoryService
@inject NavigationManager NavigationManager

<PageTitle>Add - Product</PageTitle>

<ModuleTitle Title="Add product"></ModuleTitle>

<button class="btn btn-dark" @onclick="@(()=> NavigationManager.NavigateTo("/product"))">Go back products</button>
<EditForm Model="@product">
    <div class="row">
        <div class="col-8 form-group">
            <label for="title" class="col-form-label">Title</label>
            <InputText id="title" @bind-Value="product.Title" required class="form-control" />
        </div>
    </div>
</EditForm>

@code
{
    private Product product = new();
}
```
Ahora agregamos el botón a nuestro archivo Products.razor

```{razor}
<button class="btn btn-dark" @onclick="@(()=> NavigationManager.NavigateTo("/addproduct"))">Add Product</button>
```

no nos olvidamos de inyectar la dependencia para no tener inconvenientes

```{razor}
@inject NavigationManager NavigationManager
```

corremos una vez mas nuestro servidor para probar

### Integrando formulario con servicios  

Agregamos el siguiente código al archivo AddProduct.razor.

```{razor}
@page "/addproduct"
@inject IProductService productService
@inject ICategoryService categoryService
@inject NavigationManager NavigationManager

<PageTitle>Add - Product</PageTitle>

<ModuleTitle Title="Add product"></ModuleTitle>

<button class="btn btn-dark" @onclick="@(()=> NavigationManager.NavigateTo("/product"))">Go back products</button>
<EditForm Model="@product" OnSubmit="@Save">
       <div class="row">
        <div class="col-8 form-group">
            <label for="title" class="col-form-label">Title</label>
            <InputText id="title" @bind-Value="product.Title" required class="form-control" />
        </div>
        <div class="col form-group">
            <label for="price" class="col-form-label">Price</label>
            <InputNumber id="price" @bind-Value="product.Price" min="0" required class="form-control" />
        </div>
    </div>
    <div class="row">
        <div class="col form-group">
            <label for="category" class="col-form-label">Category</label>
            <InputSelect id="category" @bind-Value="product.CategoryId" required class="form-control">
                <option>Select Category...</option>
                @foreach (var category in categories)
                {
                    <option value="@category.Id">@category.Name</option>
                }
            </InputSelect>
        </div>
        <div class="col form-group">
            <label for="image" class="col-form-label">Image (Url)</label>
            <InputText id="image" @bind-Value="product.Image" required class="form-control" />
        </div>
    </div>
    <div class="form-group">
        <label for="description" class="col-form-label">Description</label>
        <InputTextArea id="description" @bind-Value="product.Description" required class="form-control"></InputTextArea>
    </div>

    <hr />
    <button class="btn btn-primary" type="submit">Save</button>
</EditForm>

@code
{
    private Product product = new();

    private List<Category> categories = new List<Category>();

    protected override async Task OnInitializedAsync()
    {
        categories = await categoryService.Get();
    }

    private async Task Save()
    {
        product.Images = new string[1] { product.Image };
        await productService.Add(product);
        NavigationManager.NavigateTo("/product");
    }
}
```

### Creando funcionalidad de eliminar usando JavaScript

En el archivo Products.razor vamos a crear una nueva inyección de dependencias 

```{razor}
@inject IJSRuntime JSRuntime
```
Debajo de la tarea GetProducts() vamos a crear la Tarea de Eliminar Productos.

```{razor}
    private async Task DeleteProduct(Product product)
    {
        if(!await JSRuntime.InvokeAsync<bool>("confirm", $"Are you sure you want to remove {product.Title}" ))
            return;

        await productService.Delete(product.Id);

        await GetProducts();
```
Excelente, ahora vamos a agregar nustro boton de Eliminar en la sección visual de nuestro producto, para ello nos ubicamos al final de nuestro div, y bajo la sección donde se invoca @product.Product? incrustamos esta línea de código.

```{razor}
<button title="Delete" class="btn btn-danger btn-delete" @onclick="@(() => DeleteProduct(product))"><span class="oi oi-trash"></span></button>
```
Perfecto, si probamos la eliminación se produce pero no se refresca, para evitar que este inconveniente se presente vamos a modificar un poco el código, en la sección de Task donde se invoca GetProducts, vamos a cambiar la línea de código

```{razor}
products = await GetProducts();
```

Por la siguiente línea.

```{razor}
products = await productService.Get();

```
De esta forma corregimos este error y hemos completado la funcionalidad de eliminar, hemos utilizado el feacture de blazor que nos permite implementar javascript

### Usando Librerías de Blazor

Existen muchas librerias que podemos utilizar para poder extender las funcionalidades de nuestro proyecto y poder potencializarlo. Una de estas opciones es [Telerik](https://www.telerik.com/) donde se puede descargar una versión de prueba.

Por otra parte existe [Syncfuncion](https://www.syncfusion.com/) y tambien se puede descargar una función gratuita por un tiempo limitado.

Otra opción interesante de código abierto es [https://mudblazor.com/](mudblazor)

Tenemos tambien [Blazor Radzen](https://blazor.radzen.com/) que nos permite trabajar de forma gratuita muy interesante que podemos ir agregando.

Por otra parte es [Blazored](https://github.com/Blazored) de este únltimo vamos a utilizar [toast](https://github.com/Blazored/Toast), es un control que nos muestra una notificación que se puede cerrar o eliminar despues de algunos segundos.

Volvamos al proyecto

vamos a agregar el siguiente comando

```{bash}
dotnet add package Blazored.Toast
```
Ahora debemos configurar el servicio dentro del archivo Program.cs y agregamos la siguiente linea.

```{c#}
builder.Services.AddBlazoredToast();
```

Muy bien, ahora vamos a agregar en el archivo _Imports.razor dentro del directoreio wwwroot, de esta forma los agregamos de forma global y no debemos ir agregando en cada componente

```{razor}
@using Blazored.Toast
@using Blazored.Toast.Services
```
Ahora vamos a agregar dentro del componente de MainLayout.razor dentro del directoreio Shared

```{razor}
<BlazoredToasts />
```

Ahora agregamos los estilos, para ello nos dirigimos a index.html dentro del directorio wwwroot 

```{html}
    <link href="_content/Blazored.Toast/blazored-toast.min.css" rel="stylesheet" />
```
Si seguimos los pasos correctos ahora estamos listos para utilizar la librería. La implementamos para poder recibir una notificación al momento de eliminar un registro.

Dentro del archivo Products.razor empezamos inyectando el servicio de esta librería.

```{razor}
@inject IToastService toastService
```

Una vez inyectado el servicio podemos utilizarlo, para ello vamos a la secci'on antes del await GetProduct() (en la parte final) e implementamos el servicio.


```{razor}
    toastService.ShowSuccess("Producto eliminado");
```