## ToMarkup

To configure the app:

- Install [.NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Install [wasmtime](https://github.com/bytecodealliance/wasmtime#installation)
- Install the `wasi-experimental` workload via the following instructions.

```bash
dotnet restore workload wasi-experimental
```

This command requiress admin/`root`.

Build and run the app via the following pattern:

```bash
$ dotnet build
$ cd bin/Debug/net8.0/wasi-wasm/AppBundle 
$ cat run-wasmtime.sh
wasmtime run --dir . dotnet.wasm tomarkup $*
$ ./run-wasmtime.sh 
A valid inputfile must be provided.
$  wasmtime run --dir . --mapdir /markdown::/Users/rich/markdown --mapdir /tmp::/Users/rich dotnet.wasm tomarkup $* /markdown/README.md /tmp/README.html
$ ls ~/*.html
/Users/rich/README.html
```
