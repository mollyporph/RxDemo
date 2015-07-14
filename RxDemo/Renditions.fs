namespace RxDemo.HttpApi

open System

[<CLIMutable>]
type MakeReservationRendition = {
    Date : string
    Name : string
    Email : string
    Quantity : int}