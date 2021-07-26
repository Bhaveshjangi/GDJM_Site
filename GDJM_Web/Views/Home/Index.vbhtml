@Code
    ViewData("Title") = "Home Page"
End Code

<div class=" text-center" style="margin-top:10%;">
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
        </ol>

        <!-- Wrapper for slides -->
        <div class="carousel-inner">
            <div class="item active">
                <img src="~/Images/index.jpg" />
            </div>

            <div class="item">
                <img src="~/Images/index1.jpg" />
            </div>

            <div class="item">
                <img src="~/Images/index2.jpg" />
            </div>
            <div class="item">
                <img src="~/Images/index3.jpg" />
            </div>
            <div class="item">
                <img src="~/Images/index4.jpg" />
            </div>
        </div>

        <!-- Left and right controls -->
        <a class="left carousel-control" href="#myCarousel" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#myCarousel" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>
</div>

<!-- Container (About Section) -->
<div id="about" class="container-fluid">
    <div class="row">
        <div class="col-sm-8">
            <h2>WELCOME TO GDJM</h2><br>
            <p>Our school is situated far from the hustle and bustle of city life, surrounded by the peaceful mountains terrian a really healthy and congenial atmosphere, plans to introduce a new concept and effective technique of education in English medium.</p><br />
            <p>At our school, we promote a cumulative learning environment that helps in the development of the student's ...</p>
            <a href="/About" class="btn btn-default btn-lg">Read More..</a>
        </div>
        <div class="col-sm-4">
            <span class="glyphicon glyphicon-signal logo"></span>
        </div>
    </div>
</div>


<div>
    <div class="row">
        <div class="col-sm-4">
            <div class="card">
                <div class="card-body">
                    <h4>Principal's Desk</h4>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam accumsan dolor id enim lacinia, sed feugiat ex suscipit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam accumsan dolor id enim lacinia, sed feugiat ex suscipit.</p>
                    <br />
                    <a href="#" class="btn btn-primary">Read More..</a>
                </div>
            </div>
        </div>
        <div class="col-sm-4">
            <div class="card">
                <div class="card-body">
                    <h4>Break & Vacations</h4>
                    <p>
                        In addition to normal gazetted holidays, the school observes the following vacations breaks :-
                    </p>
                    <p>
                        (a) Summer vacation - May-June 50 days<br>
                        (b) Winter Break - Dec –Jan 15 days
                    </p>
                    <a href="#" class="btn btn-primary">Read More..</a>
                </div>
            </div>
        </div>
        <div class="col-sm-4">
            <div class="card">
                <div class="card-body">
                    <h4>Rules & Regulations</h4>
                    <p>Regular Parent-Teacher meeting is organized after every Unit Test. Official Hours are as follows</p>
                    <p>
                        (i) Summer : 09:00 AM to 01:00 PM.<br>
                        (ii) Winter : 09:30 AM to 01:30 PM
                    </p>
                    <a href="#" class="btn btn-primary">Read More..</a>
                </div>
            </div>
        </div>
    </div>
    
</div>



