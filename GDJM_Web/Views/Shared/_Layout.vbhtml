<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - GDJM</title>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="~/Content/Site.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <link href="https://fonts.googleapis.com/css?family=Montserrat" rel="stylesheet" type="text/css">
    <link href="https://fonts.googleapis.com/css?family=Lato" rel="stylesheet" type="text/css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <script src="https://kit.fontawesome.com/acbbc8e7b6.js" crossorigin="anonymous"></script>
    <script>
        $(document).ready(function () {
            // Add smooth scrolling to all links in navbar + footer link
            $(".navbar a, footer a[href='#myPage']").on('click', function (event) {
                debugger;
                // Make sure this.hash has a value before overriding default behavior
                if (this.hash !== "") {
                    // Prevent default anchor click behavior
                    event.preventDefault();

                    // Store hash
                    var hash = this.hash;

                    // Using jQuery's animate() method to add smooth page scroll
                    // The optional number (900) specifies the number of milliseconds it takes to scroll to the specified area
                    $('html, body').animate({
                        scrollTop: $(hash).offset().top
                    }, 900, function () {

                        // Add hash (#) to URL when done scrolling (default click behavior)
                        window.location.hash = hash;
                    });
                } // End if
            });

            $(window).scroll(function () {
                $(".slideanim").each(function () {
                    var pos = $(this).offset().top;

                    var winTop = $(window).scrollTop();
                    if (pos < winTop + 600) {
                        $(this).addClass("slide");
                    }
                });
            });
        })
    </script>
</head>
<body>
    <nav class="navbar navbar-default navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>

            </div>
            <div class="collapse navbar-collapse" id="myNavbar">
                <a class="navbar-brand" href="#myPage">
                    <img src="~/Images/gdjmLogo.png" style="width:100px;" />
                </a>
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="#about">HOME</a></li>
                    <li><a href="#about">ABOUT</a></li>
                    <li><a href="#services">ADMISSION</a></li>
                    <li><a href="#portfolio">DOWNLOADS</a></li>
                    <li><a href="#pricing">GALLERY</a></li>
                    <li><a href="#contact">CONTACT</a></li>
                </ul>
            </div>
        </div>
    </nav>
    <div class="body-content" style="margin:10px;">
        @RenderBody()
        <hr />
        <div class="row">
            <div class="col-lg-6">
                <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3485.6233631304535!2d79.69502571543661!3d29.11679876874791!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x39a08c80e5555555%3A0x2520659913b47513!2sG%20D%20J%20Memorial%20Senior%20secondary%20school!5e0!3m2!1sen!2sin!4v1627325313736!5m2!1sen!2sin" width="900" height="450" style="border:0;" allowfullscreen="" loading="lazy"></iframe>
            </div>
            <div class="col-lg-6">
                <div class="footer_logo"><a href="#"><img src="~/Images/gdjmLogo.png" alt="" style="max-width: 100px;"></a></div><br /><br />
                <div class="footer_contact_list footerTxt" >
                    <p> <span class="glyphicon glyphicon-home"></span> G.D.J. Memorial Public School, Naya Gaon Katan, Chorgaliya (Nainital)</p>
                    <p>A CBSE New Delhi affiliated Co-Educational English Medium School, CBSE Affiliation Number 3530484</p>
                    <p><span class="glyphicon glyphicon-phone"></span> 9410713666, 9917417797</p>
                    <p>
                        <span class="glyphicon glyphicon-envelope"></span>
                        gdjmpublicschoolchorgaliya@gmail.com
                    </p>
                </div>
            </div>
        </div>

        <footer class="container-fluid text-center">
            @*<a href="#myPage" title="To Top">
                <span class="glyphicon glyphicon-chevron-up"></span>
            </a>*@
            <p>@DateTime.Now.Year - Made By Bhavesh Kumar Jangi</p>
        </footer>
    </div>

</body>


</html>
