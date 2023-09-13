FROM debian:latest
LABEL version="1.0" description="Docker image for nginx"
RUN apt-get update && apt-get install -y nginx && apt-get clean
EXPOSE 80
ENTRYPOINT ["/usr/sbin/nginx"]
CMD ["-g", "daemon off;"]