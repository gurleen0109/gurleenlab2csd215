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

type Teams = {
    Name: string
    Coach: Coach
    Stats: Stats
}


// Create a list of 5 teams
let Teams = [
    {Name = "Los Angeles Lakers"; Coach = { Name = "Darvin Ham"; FormerPlayer = true } ; Stats = { Wins = 3503 ; Losses = 2419 }}
    {Name = "Atlanta Hawks"; Coach = { Name = "Quin Snyder"; FormerPlayer = false } ; Stats = { Wins = 2891 ;Losses = 2964 }}
    {Name = "Boston Celtics"; Coach = { Name = "Joe Mazzulla"; FormerPlayer = false } ; Stats = { Wins = 3570 ;Losses = 2462 }}
    {Name = "Chicago Bulls"; Coach = { Name = "Billy Donovan"; FormerPlayer = true } ; Stats = { Wins = 2344 ;Losses = 2254 }}
    {Name = "Toronto Raptors"; Coach = { Name = "Darko Rajakovic"; FormerPlayer = false } ; Stats = { Wins = 1071 ;Losses = 1157 }}
]

let finestTeams = Teams |> List.filter (fun team -> team.Stats.Wins > team.Stats.Losses)

//printfn "%A" finestTeam

finestTeams |> List.iter (fun team -> printfn "Team Name: %s" team.Name)
finestTeams |> List.iter (fun team -> printfn "Team wins: %d" team.Stats.Wins)

let calculateScsPercentile team = float team.Stats.Wins / float (team.Stats.Wins + team.Stats.Losses) * 100.0

let ScsPercentiles =  finestTeams |> List.map calculateScsPercentile

let ag = List.average ScsPercentiles

printfn "The Percentile Of Team %f" ag

type Cuisn =
    | Koreannn
    | Turkishhh

type Movietype =
    | Regular
    | IMAX
    | DBOX
    | RegularWithSnacks
    | IMAXWithSnacks
    | DBOXWithSnacks

type Actvty = 
    | BoardGames
    | Chill
    | Movie of Movietype
    | Restaurant of Cuisn
    | LongDrive of int * float

let calculatebudget Actvty = 
    match Actvty  with 
    | BoardGame -> 10.0
    | Chill -> 0.0
    | Movie Regular -> 12.0
    | Movie IMAX -> 17.0
    | Movie DBOX -> 20.0
    | Movie _ -> 12.0 + 5.0
    | Restaurant Koreannn -> 70.0
    | Restaurant Turkishhh -> 65.0
    | LongDrive (kilometres, fuelcharge) -> float kilometres * fuelcharge

let eveningActvty = Restaurant Turkishhh
let budget = calculatebudget eveningActvty
printfn "Est budget: %.2f CAD" budget
