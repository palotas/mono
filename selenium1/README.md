docker build -t e34/mono .
docker run --dns=192.168.34.3 -it e34/mono sh

mono mono/selenium1/bin/Debug/selenium1.exe

