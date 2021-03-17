# kong-konga-core
Kong apiGateway + Konga Admin + .NET Core 5


docker network create kong-comic-net

1. docker run -d --name kong-database --network=kong-comic-net -p 5432:5432 -e "POSTGRES_USER=kong" -e "POSTGRES_DB=kong" -e "POSTGRES_PASSWORD=kong" postgres:9.6

2. docker run --rm --network=kong-comic-net -e "KONG_DATABASE=postgres" -e "KONG_PG_HOST=kong-database" -e "KONG_PG_USER=kong" -e "KONG_PG_PASSWORD=kong" kong:latest kong migrations bootstrap

3. docker run -d -p 1337:1337 --network=kong-comic-net --name konga -v /var/data/kongadata:/app/kongadata -e "NODE_ENV=production" pantsel/konga


./Microservices > docker-compose up

1. create upstream and routes
curl -i -X POST http://localhost:8001/services --data name=DC --data url="http://localhost:7001/"
curl -i -X POST http://localhost:8001/services/DC/routes   --data "paths[]=/DC-Web"   --data name=DC-Web
curl -i -X POST http://localhost:8001/services/DC/routes   --data "paths[]=/DC-App"   --data name=DC-App
