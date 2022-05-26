module Game

open System
open Controller

let random = new System.Random()

let startGame (p1Coords, aiCoords) =
    printf "PELI ALKAA! \n"
    System.Threading.Thread.Sleep(2000)

    printf "Pelaajan 1 laivan lokaatio:\n %A\n\n" p1Coords
    //printf "Pelaajan AI laivan lokaatio:\n %A\n\n" aiCoords
    System.Threading.Thread.Sleep(1000)

    let mutable continueLoop = true
    let mutable player1BombX = int
    let mutable player1BombY = int
    let mutable playerAIBombX = int
    let mutable playerAIBombY = int
    let mutable player1Won = false
    let mutable playerAIWon = false
    let mutable input = string

    while continueLoop do
        //pelaajan 1 vuoro
        System.Threading.Thread.Sleep(2000)
        printf "\n********************************\nAnna pommin X koordinaatti (1-10)\n"
        let mutable P1tempX = Console.ReadLine()
        let mutable P1X = P1tempX |> int

        System.Threading.Thread.Sleep(1000)

        printf "Anna pommin Y koordinaatti (1-10)\n"
        let mutable P1tempY = Console.ReadLine()
        let mutable P1Y = P1tempY |> int

        System.Threading.Thread.Sleep(2000)

        printf "Pommi tiputettu ruutuun X:%s, Y:%s\n" P1tempX P1tempY

        //tarkastetaan osuiko pommi AI:n laivaan
        if checkHit (aiCoords, P1X, P1Y) then
            player1Won <- true
        else
            printf "Pelaajan 1 pommi: EI OSUMAA! \n"

        System.Threading.Thread.Sleep(2000)

        for i in 0..2 do
            printf "*\n"
            System.Threading.Thread.Sleep(500)


        //AI vuoro
        let mutable AIX = random.Next(1, 10)
        let mutable AIY = random.Next(1, 10)
        printf "AI tiputtaa pommi kohteeseen X:%i, Y:%i\n" AIX AIY
        System.Threading.Thread.Sleep(2000)

        //tarkastetaan osuiko pommi P1 laivaan
        if checkHit (p1Coords, AIX, AIY) then
            playerAIWon <- true
        else
            printf "Pelaajan AI pommi: EI OSUMAA! \n"


        //Tarkastetaan voittaja / tasapeli
        if player1Won && playerAIWon then
            printf "\nPelipäättyi tasapeliin.\n"
            continueLoop <- false
            System.Threading.Thread.Sleep(5000)
        else if player1Won then
            printf "\nPelaaja 1 voitti!"
            continueLoop <- false
            System.Threading.Thread.Sleep(5000)
        else if playerAIWon then
            printf "\nPelaaja AI voitti!"
            continueLoop <- false
            System.Threading.Thread.Sleep(5000)

    printf "\nSulje peli painamalla mitä tahansa nappia\n"
    Console.ReadKey()



//        printf "Stop?\n"

//        if Console.ReadLine() = "stop" then
//            continueLoop <- false



// Tällai saa parametri 2D arraysta tsekattua kontenttia
//    if (Array2D.get xCoords 1 0) = 2 then
//        printf "ON SAMA!!"
