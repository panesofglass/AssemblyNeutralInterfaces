open AssemblyNeutralInterfaces

type Settings = {
    Name : string
    Version: string
}

type SettingsClass(name: string, version: string) =
    member this.Name with get() = name
    member this.Version with get() = version

[<EntryPoint>]
let main argv = 
    Startup.configure { Name = "Test"; Version = "1.0.0" }
    Startup.configure (SettingsClass("Test Class", "1.0.0"))
    printfn "Press enter to quit."
    System.Console.ReadLine() |> ignore
    0 // return an integer exit code
