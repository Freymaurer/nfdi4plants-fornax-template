#r "../Fornax.Nfdi4Plants/bin/Debug/net5.0/Fornax.Core.dll"

open System.IO

let generate (ctx : SiteContents) (projectRoot: string) (page: string) =
    let inputPath = Path.Combine(projectRoot, page)
    File.ReadAllBytes inputPath  