#!/bin/bash

# Arguments with defaults
PROJECT_NAME=${1:-"DantesDescent.Core"}
CONFIG=${2:-"Debug"}
FRAMEWORK=${3:-"net8.0"}

# Root directory (where this script lives)
ROOT_DIR="$(dirname "$(realpath "$0")")"

# Paths
SOURCE_DLL="$ROOT_DIR/$PROJECT_NAME/bin/$CONFIG/$FRAMEWORK/$PROJECT_NAME.dll"
UNITY_PLUGINS="$ROOT_DIR/DantesDescent.Renderer.Unity/Assets/Plugins"

# Check if source DLL exists
if [ ! -f "$SOURCE_DLL" ]; then
    echo "Error: $SOURCE_DLL not found. Build may have failed or paths are incorrect."
    exit 1
fi

# Create Unity Plugins directory if it doesn’t exist
mkdir -p "$UNITY_PLUGINS"

# Copy the DLL to Unity
cp "$SOURCE_DLL" "$UNITY_PLUGINS/"
if [ $? -eq 0 ]; then
    echo "Successfully copied $SOURCE_DLL to $UNITY_PLUGINS"
else
    echo "Error: Failed to copy $SOURCE_DLL to $UNITY_PLUGINS"
    exit 1
fi