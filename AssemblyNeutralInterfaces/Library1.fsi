namespace AssemblyNeutralInterfaces

module Startup =
    
    [<CompiledName("Configure")>]
    val inline configure< ^T when ^T : (member Name : string)
                              and ^T : (member Version : string)>
        : settings: ^T -> unit
