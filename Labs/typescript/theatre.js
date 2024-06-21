var TheatreName = "Inox";
var numberOfSeats = 350;
var numberofscreen = [10, 11, 12];
var Restaurants = ["MacD", 1];
var moviestatus;
(function (moviestatus) {
    moviestatus[moviestatus["Upcoming"] = 0] = "Upcoming";
    moviestatus[moviestatus["ongoing"] = 1] = "ongoing";
    moviestatus[moviestatus["deleted"] = 2] = "deleted";
})(moviestatus || (moviestatus = {}));
;
var tenet = moviestatus.Upcoming;
var tloc;
tloc = "Worli Naka";
tloc = 400018;
