#!/bin/bash

set -e

echo "-------------------------------------"
echo " Safe Command Analyzer Installer"
echo "-------------------------------------"

APP_NAME="safe"
PROJECT_DIR="$(pwd)/CommandRiskAnalyser"
PROJECT_FILE="$PROJECT_DIR/CommandRiskAnalyser.csproj"
PUBLISH_DIR="$PROJECT_DIR/bin/Release/net8.0/linux-x64/publish"
EXECUTABLE_NAME="CommandRiskAnalyser"
TARGET_LINK="/usr/local/bin/$APP_NAME"

echo "Checking .NET installation..."
dotnet --version

if [ ! -f "$PROJECT_FILE" ]; then
    echo "Project file not found: $PROJECT_FILE"
    exit 1
fi

echo ""
echo "Building project..."
dotnet publish "$PROJECT_FILE" -c Release -r linux-x64 --self-contained false

echo ""
if [ ! -d "$PUBLISH_DIR" ]; then
    echo "Publish directory not found: $PUBLISH_DIR"
    exit 1
fi

if [ ! -f "$PUBLISH_DIR/$EXECUTABLE_NAME" ]; then
    echo "Executable not found: $PUBLISH_DIR/$EXECUTABLE_NAME"
    echo "Publish contents:"
    ls -la "$PUBLISH_DIR"
    exit 1
fi

echo "Creating command shortcut..."
sudo chmod +x "$PUBLISH_DIR/$EXECUTABLE_NAME"
sudo ln -sf "$PUBLISH_DIR/$EXECUTABLE_NAME" "$TARGET_LINK"

echo ""
echo "Installation successful."
echo "You can now run:"
echo "  safe"
echo "or"
echo "  safe \"ls -la\""
