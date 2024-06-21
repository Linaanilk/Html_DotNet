class booking
{
    ticketPrice:number;
    numberOfTickets:number;
    bookingDate:Date;
    constructor(price:number,ticketsBooked:number)
    {
        this.ticketPrice=price;
        this.numberOfTickets=ticketsBooked;
    }
    public calculateAmount()
    {
        return this.ticketPrice*this.numberOfTickets
    }
    public display()
    {
        console.log(`Ticket price: ${this.ticketPrice}, Numberoftickets: ${this.numberOfTickets}, Booking Date: ${new Date()}`)

    }
}
let ticketOne=new booking(450,3);
ticketOne.display();
console.log(ticketOne.calculateAmount())