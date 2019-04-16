#!/bin/bash

set -e
run_cmd="dotnet run"

# --server.urls http://0.0.0.0:5000

until dotnet ef database update; do
>&2 echo "Posgres Server is starting up"
sleep 1
done

>&2 echo "Postgres Server is up - executing command"
exec $run_cmd

