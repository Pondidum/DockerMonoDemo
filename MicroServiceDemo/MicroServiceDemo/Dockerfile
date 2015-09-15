FROM mono:3.10.0

RUN apt-get update && apt-get install mono-4.0-service -y

RUN mkdir -p /usr/src/app
COPY . /usr/src/app

WORKDIR /usr/src/app
CMD [ "mono-service",  "./MicroServiceDemo.exe", "--no-daemon" ]

EXPOSE 12345
