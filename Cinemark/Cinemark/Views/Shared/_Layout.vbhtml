<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - CineMark</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        @Html.ActionLink("CineMark", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarText">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item">
                    @Html.ActionLink("Inicio", "Index", "Home", New With {.class = "nav-link"})
                </li>
                <li class="nav-item">
                    @Html.ActionLink("Acerca de", "About", "Home", New With {.class = "nav-link"})
                </li>
                <li class="nav-item">
                    @Html.ActionLink("Contacto", "Contact", "Home", New With {.class = "nav-link"})
                </li>
            </ul>
        </div>
    </nav>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p class="text-center">&copy; @DateTime.Now.Year - Mi aplicación ASP.NET</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
