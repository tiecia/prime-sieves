#!/bin/sh

export INSTALL_DIR=usr/local/bin
export CONTROL_FILE_NAME=control
export TMP_DIR=tmp
export PUBLISH_DIR=Program/bin/Release/net9.0/linux-x64/publish

rm -rf $TMP_DIR
mkdir -p $TMP_DIR
mkdir -p $TMP_DIR/DEBIAN
mkdir -p $TMP_DIR/$INSTALL_DIR

cp control $TMP_DIR/DEBIAN/$CONTROL_FILE_NAME
cp $PUBLISH_DIR/Program $TMP_DIR/$INSTALL_DIR/sieve

dpkg-deb --build tmp

mv tmp.deb sieve-v1.0.0.deb
