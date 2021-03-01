# MyDaprPlayground

## Useful commands

Deploy app to Dapr sidecar


```bash
dapr run --app-id dotnetapp --app-port 5000 --dapr-http-port 5010 dotnet run
```


Invoke API

```bash
dapr invoke --app-id dotnetapp --method hello --verb GET
```

Run Dapr Dashboard
```
dapr dashboard
```