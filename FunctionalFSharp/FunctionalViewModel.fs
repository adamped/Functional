// This is Revision #2

namespace FunctionalFSharp

open Functional.Base
open Xamarin.Forms
open Functional.Extensions
open System
open System.Collections.Generic

type View() =    
    inherit BaseViewState()
    
    member val LabelValue = "" with get, set   

type Controller() as this =
    inherit BaseController()

    let combine first last = first + " " + last
    
    let f (e: Data[]) = 
        let request = new Request()
        let first = e.[0].Value
        let second = e.[1].Value
        
        request.Add("LabelValue", combine first second)
        this.Push(request) |> ignore
    
    let command = new Command<_>(System.Action<_>(f))

    member val UpdateCommand = command

type FunctionalFSharpViewModel() =
    inherit DefineViewModel<View, Controller>()

