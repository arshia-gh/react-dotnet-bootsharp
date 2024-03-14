Install `wasm-tools` workload in a terminal with administration access:
```
dotnet install workload wasm-tools
```

Build the C# project
```
cd DotNetBindings && dotnet publish && cd ..
```

Install react dependencies
```
cd react-client && npm install
```

Run the react dev server
```
npm start
```
