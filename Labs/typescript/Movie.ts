interface MovieDetails
{
    moviename:string;
    moviedesc:string;
    movieimg:URL;
    movietrailer:URL;
    movieduration:number

}
let movie:MovieDetails=
{
    moviename: "Tenet",
    moviedesc: "Sci-fi",
    movieimg:new URL('https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.esquire.com%2Fuk%2Fculture%2Ffilm%2Fa36408331%2Freasons-to-watch-tenet%2F&psig=AOvVaw295v3AnIr2wimvEFJM8NfI&ust=1699683809659000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCNj9qOHluIIDFQAAAAAdAAAAABAD'),
    movietrailer: new URL('https://youtube.com/tenet'),
    movieduration: 90
}
console.log(movie);