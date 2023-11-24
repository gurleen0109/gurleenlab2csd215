//For more information see https://aka.ms/fsharp-console-apps
// Records: NBA Basketball Statistics

type Coach = {
    Name: string
    FormerPlayer: bool
}

type Stats = {
    Wins: int
    Losses:int
}

type Team = {
    Name: string
    Coach: Coach
    Stats: stats
}


// Create a list of 5 teams
let teams = [
    {Name = "Los Angeles Lakers"; Coach = { Name = "Darvin Ham"; FormerPlayer = true } ; stats = { Wins = 3503 ; Losses = 2419 }}
    {Name = "Atlanta Hawks"; Coach = { Name = "Quin Snyder"; FormerPlayer = false } ; stats = { Wins = 2891 ;Losses = 2964 }}
    {Name = "Boston Celtics"; Coach = { Name = "Joe Mazzulla"; FormerPlayer = false } ; stats = { Wins = 3570 ;Losses = 2462 }}
    {Name = "Chicago Bulls"; Coach = { Name = "Billy Donovan"; FormerPlayer = true } ; stats = { Wins = 2344 ;Losses = 2254 }}
    {Name = "Toronto Raptors"; Coach = { Name = "Darko Rajakovic"; FormerPlayer = false } ; stats = { Wins = 1071 ;Losses = 1157 }}
]

    


