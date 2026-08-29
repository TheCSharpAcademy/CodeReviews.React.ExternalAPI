export interface Driver {
    id : number,
    name : string, 
    team : string,
    number : number,
    nationality : string,
    age : number,
    imageUrl : string
}

export interface LeaderboardEntry {
    position : number,
    name : string,
    team : string,
    number : number,
    points : number,
    imageUrl : string
}