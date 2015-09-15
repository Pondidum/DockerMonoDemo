# Docker Microservice Demo

This is the repository to go with this blog post:

## Usage

* Compile the microservice in visualstudio (I was going to include a rakefile, but there seems little point...)
  * This will output the application to the `/app` directory of this repository.
* Open a console window and type:
  ```
  vagrant up
  ```
* Once the box is created:
  ```
  vagrant ssh
  ```

* In the ssh session:
  ```
  cd /vagrant/app
  docker build -t servicedemo .
  docker run -d -p 12345:12345 --name demo servicedemo
  ```
* On your host machine, open a web browser to `http://172.28.128.50:12345`
  * You should see the Owin welcome page

* Exit the virtualmachine, and destroy it if done:
  ```
  exit
  vagrant destroy -f
  ```
