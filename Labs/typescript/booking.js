var booking = /** @class */ (function () {
    function booking(price, ticketsBooked) {
        this.ticketPrice = price;
        this.numberOfTickets = ticketsBooked;
    }
    booking.prototype.calculateAmount = function () {
        return this.ticketPrice * this.numberOfTickets;
    };
    booking.prototype.display = function () {
        console.log("Ticket price: ".concat(this.ticketPrice, ", Numberoftickets: ").concat(this.numberOfTickets, ", Booking Date: ").concat(new Date()));
    };
    return booking;
}());
var ticketOne = new booking(450, 3);
ticketOne.display();
console.log(ticketOne.calculateAmount());
