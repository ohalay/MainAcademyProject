export interface IJourney {
    id?: number;
    DepartureStationID: number;
    ArrivalStationID: number;
    DriverID: number;
    BusID: number;
    Distance: number;
    DepartureTime: DateTimeFormat;
    ArrivalTime: DateTimeFormat;
}
export interface ICity {
    id?: number;
    Name: string;
    People: number;
}
export interface ITicket {
    id?: number;
    SeatNumber: number;
    JourneyID: number;
    CityFromID: number;
    CityToID: number;
}
export interface IBusStop {
    id?: number;
    CityID: number;
    JourneyID: number;
    Distance: number;
    Time: number;
    Price: number;
}
export interface IBus {
    id?: number;
    SeatsNumber: number;
    BusTypeID: number;
    BusNumber: number;
}
