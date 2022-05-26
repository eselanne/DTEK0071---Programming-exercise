module GameSetup

open ShipModule
open Game


let runSetup =
    let player1 = ShipModule.player1Ship
    //printfn "Pelaajan laivan %s koordinaatit: X: %i, Y: %i" player1.Name player1.StartXCoord player1.StartYCoord
    let AIPlayer = ShipModule.AIShip
    //printfn "Pelaajan AI laivan %s koordinaatit: X: %i, Y: %i" AIPlayer.Name AIPlayer.StartXCoord AIPlayer.StartYCoord

    //TODO if lauseke määrittelemään vaaka- tai pystysuunnassa oleva laiva (if Orientation == horizontal do, else do vertical)

    let player1ShipLocations =
        array2D [ [ player1.StartXCoord
                    player1.StartYCoord ]
                  [ player1.StartXCoord + 1
                    player1.StartYCoord ]
                  [ player1.StartXCoord + 2
                    player1.StartYCoord ]
                  [ player1.StartXCoord + 3
                    player1.StartYCoord ] ]

    let AIplayerShipLocations =
        array2D [ [ AIPlayer.StartXCoord
                    AIPlayer.StartYCoord ]
                  [ AIPlayer.StartXCoord + 1
                    AIPlayer.StartYCoord ]
                  [ AIPlayer.StartXCoord + 2
                    AIPlayer.StartYCoord ]
                  [ AIPlayer.StartXCoord + 3
                    AIPlayer.StartYCoord ] ]


    startGame (player1ShipLocations, AIplayerShipLocations)
