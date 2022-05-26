module Controller

let checkHit (shipCoords, X, Y) =
    printf "Tarkastetaan osumaa.. X:%i ,Y:%i \n" X Y
    System.Threading.Thread.Sleep(1000)
    let mutable length = Array2D.length1 shipCoords
    let mutable length2 = Array2D.length2 shipCoords
    let mutable Xhitted = false
    let mutable Yhitted = false



    for i in 0 .. length - 1 do
        let mutable tempX = Array2D.get shipCoords i 0

        if tempX = X then Xhitted <- true

    for j in 0 .. length2 - 1 do
        let mutable tempY = Array2D.get shipCoords 0 j

        if tempY = Y then Yhitted <- true


    if Xhitted = true && Yhitted = true then
        printf "OSUMA!!! LAIVA UPPOAA!! \n"
        true
    else
        false





//    for i in 0 .. length - 1 do
//        for j in 0 .. length2 - 1 do
//            let mutable tempX = Array2D.get shipCoords i j
//            printf "%i" tempX
//
//        printf "\n"









// if (Array2D.get shipCoords 1 0) = 2 then
//    printf "on sama!!\n"





// Tällai saa parametri 2D arraysta tsekattua kontenttia
//    if (Array2D.get xCoords 1 0) = 2 then
//        printf "ON SAMA!!"
