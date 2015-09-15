# -*- mode: ruby -*-
# vi: set ft=ruby :

Vagrant.configure(2) do |config|

  config.vm.box = "ubuntu/trusty64"
  config.vm.hostname = "dockertest"
  config.vm.boot_timeout = 600

  config.vm.network "private_network", ip: "172.28.128.50"

  config.vm.provider :virtualbox do |vb|
    vb.memory = "512"
    vb.cpus = 2
    vb.name = "dockertest"
  end

  config.vm.provision "docker"

end
