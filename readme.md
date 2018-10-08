Build the docker file:
> docker build -t rest-test .

Run the docker container in docker. Remember to stop your container before you expose it via Kubernetes
> docker run -p 80:80 rest-test

Create the kubernetes deployment and run it
> kubectl run rest-test --image rest-test:latest --port=80 --image-pull-policy=Never

Expose it outside the kubernetes cluster
> kubectl expose deployment rest-test --type=LoadBalancer

Scale the deployment appropriately
> kubectl scale deployments/rest-test --replicas=4

You can change the deployed image
> kubectl set image deployments/rest-test rest-test=rest-test-1
> kubectl set image deployments/rest-test rest-test=rest-test-2
