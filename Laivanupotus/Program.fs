//// Yksinkertainen yhden pelaajan komentorivi-laivanupotuspeli tietokonevastustajaa vastaan.
//
// Säännöt:
// 10x10 pelikenttä
// Yksi laiva (4 yksikköä pitkä)
// Laivan voi vain vaakasuunnassa
// Laiva uppoaa yhdestä osumasta
//
// Tietokonepelaaja asettaa laivansa satunnaisesti pelialueelle.
// Tietokone ampuu pommeja satunnaisiin ruutuihin.


open GameSetup


[<EntryPoint>]
let main _ =

    //logo
    printf
        "*************************************\n****** LAIVANUPOTUS - The Game ******\n******** Horizontal edition ********* \n*************************************\n\n"

    System.Threading.Thread.Sleep(3000)
    runSetup
    0
