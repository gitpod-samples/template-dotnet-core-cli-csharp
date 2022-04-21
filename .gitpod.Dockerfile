FROM gitpod/workspace-dotnet:latest

RUN echo "\n create a special symbolic link for shiftfs" >> /home/gitpod/.bashrc.d/110-dotnet \
RUN bash \
    && { echo 'if [ ! -z $GITPOD_REPO_ROOT ]; then'; \
        echo '\tCONTAINER_DIR=$(awk '\''{ print $6 }'\'' /proc/self/maps | grep ^\/run\/containerd | head -n 1 | cut -d '\''/'\'' -f 1-6)'; \
        echo '\t[[ ! -d $CONTAINER_DIR ]] && sudo mkdir -p $CONTAINER_DIR && sudo ln -s / $CONTAINER_DIR/rootfs'; \
        echo 'fi'; } >> /home/gitpod/.bashrc.d/110-dotnet
RUN chmod +x /home/gitpod/.bashrc.d/110-dotnet
