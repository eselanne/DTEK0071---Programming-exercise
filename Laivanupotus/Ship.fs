module ShipModule

open System

let random = new System.Random()

type ship =
    { Name: string
      StartXCoord: int
      StartYCoord: int
      EndXCoord: int
      EndYCoord: int
    //    Orientation: string
     }

//TODO: tarkasta, että laiva on pelialueella

let player1Ship =
    printf
        "Laiva on 4 yksikköä pitkä ja se sijoitetaan 10x10 pelialueelle vaakatasossa. Laivan perän X koordinaatti pitää olla välillä 1-7, jotta laivan keula ei mene yli pelialueesta.\n"

    printf "Anna laivan perän X koordinaatti (1-7):\n"
    let mutable x = Console.ReadLine()
    let mutable xInt = x |> int

    while xInt > 7 || xInt < 1 do
        printf "Laiva ei mahdu pelialueelle!\nAnna uusi X koordinaatti:\n"
        x <- Console.ReadLine()
        xInt <- x |> int

    System.Threading.Thread.Sleep(500)

    printf "Anna laivan Y koordinaatti (1-10):\n"
    let mutable y = Console.ReadLine()
    let mutable yInt = y |> int

    while yInt > 7 || yInt < 1 do
        printf "Laiva ei mahdu pelialueelle!\nAnna uusi Y koordinaatti:\n"
        y <- Console.ReadLine()
        yInt <- y |> int

    System.Threading.Thread.Sleep(500)


    //    printf "Valitse suuntaus: pysty tai vaaka\n"
//    let orien = Console.ReadLine()
//    let orientation = orien |> string
//    System.Threading.Thread.Sleep(500)


    for i in 0..4 do
        printf "*\n"
        System.Threading.Thread.Sleep(400)



    { Name = "Corvette"
      StartXCoord = xInt
      StartYCoord = yInt
      EndXCoord = xInt + 4
      EndYCoord = yInt
    //  Orientation = orientation }
    }



let AIShip =
    let randX = random.Next(0, 10)
    let randY = random.Next(0, 10)

    { Name = "Carrier"
      StartXCoord = randX
      StartYCoord = randY
      EndXCoord = randX + 4
      EndYCoord = randY
    //      Orientation = "horizontal"
    }
