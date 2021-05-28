docker build --no-cache -f SQL\Dockerfile.PostgreSql -t bd/postgre-sql ../SQL

docker build --no-cache -f Dockerfile -t bd/app ../..
