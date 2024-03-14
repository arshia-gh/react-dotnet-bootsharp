import React from "react";
import ReactDOM from "react-dom/client";
import App from "./App";
import reportWebVitals from "./reportWebVitals";
import bootstrap, { Program } from "dotnet-bindings";

Program.getFrontendName = () => "create-react-app";
Program.onMainInvoked.subscribe(console.log);

const root = ReactDOM.createRoot(document.getElementById("root"));

bootstrap.boot().then(() =>
  root.render(
    <React.StrictMode>
      <App />
    </React.StrictMode>
  )
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
