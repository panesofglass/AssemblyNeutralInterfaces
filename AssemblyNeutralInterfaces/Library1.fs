namespace AssemblyNeutralInterfaces

module Startup =
    
    [<CompiledName("Configure")>]
    let inline configure settings =
        let name = ( ^T : (member Name : string) settings)
        let version = ( ^T : (member Version: string) settings)
        printfn "%s %s" name version
