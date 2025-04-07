build:
	dotnet build

test:
	dotnet test ./UnitTests/UnitTests.csproj

build-deb:
	echo "Building deb package from $(PWD)"
	./build-deb.sh

lint-deb: build-deb
	-lintian ./sieve-v1.0.0.deb
