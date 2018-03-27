set -ex

cd $(dirname $0)


unameOut="$(uname -s)"
case "${unameOut}" in
    Linux*)     machine=Linux;;
    Darwin*)    machine=Mac;;
    CYGWIN*)    machine=Cygwin;;
    MINGW*)     machine=MinGw;;
    windows*)   machine=Windows;;
    *)          machine="UNKNOWN:${unameOut}"
esac


PROTOC=protoc

if [ $machine = "Windows" ] ; then
  PLUGIN=protoc-gen-dotbpe=dotbpe-amp-link.cmd
elif [ $machine = "Cygwin" ] ; then
  PLUGIN=protoc-gen-dotbpe=dotbpe-amp-link.cmd
elif [ $machine = "MinGw" ] ; then
  PLUGIN=protoc-gen-dotbpe=dotbpe-amp-link.cmd
else
  PLUGIN=protoc-gen-dotbpe=dotbpe-amp-link
fi


OUT_DIR=./Survey.Core/_g

PROTO_DIR=./protos

if [ -d $OUT_DIR ]; then
  rm -rf $OUT_DIR
fi

mkdir -p $OUT_DIR

<<<<<<< HEAD

$PROTOC -I=$PROTO_DIR  --csharp_out=$OUT_DIR --dotbpe_out=$OUT_DIR \
	$PROTO_DIR/message/*.proto $PROTO_DIR/service/gate/*.proto $PROTO_DIR/service/inner/*.proto --plugin=$PLUGIN
=======
$PROTOC -I=$PROTO_DIR  --csharp_out=$OUT_DIR --dotbpe_out=$OUT_DIR \
  $PROTO_DIR/{message/common,message/apaper,message/qpaper,message/user}.proto  $PROTO_DIR/service/{gate/*,inner/*}.proto  --plugin=$PLUGIN
>>>>>>> f5c1d08761a3e9e7c5eb30f2c9e1ba2be6b1c63a
