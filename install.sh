#!/bin/bash

echo "-------------------------------------"
echo " Safe Command Analyzer Installer"
echo "-------------------------------------"

# Check if dotnet is installed

if ! command -v dotnet &> /dev/null
then
echo "Error: .NET SDK is not installed."
echo "Please install .NET from:"
echo "https://dotnet.microsoft.com/download"
exit 1
fi

echo "Checking .NET installation..."
dotnet --version

echo ""
echo "Building project..."

dotnet publish -c Release -r linux-x64 --self-contained true

if [ $? -ne 0 ]; then
echo "Build failed."
exit 1
fi

echo ""
echo "Build successful."

PUBLISH_DIR="bin/Release/net9.0/linux-x64/publish"

if [ ! -d "$PUBLISH_DIR" ]; then
echo "Publish directory not found."
exit 1
fi

cd $PUBLISH_DIR

# Rename executable

if [ -f "CommandRiskAnalyser" ]; then
mv CommandRiskAnalyser safe
fi

# Make executable

chmod +x safe

echo ""
echo "Installing safe command..."

sudo mv safe /usr/local/bin/

if [ $? -ne 0 ]; then
echo "Installation failed."
exit 1
fi

echo ""
echo "-------------------------------------"
echo "Installation complete!"
echo ""
echo "You can now run commands safely:"
echo ""
echo "  safe pwd"
echo "  safe ls"
echo "  safe echo hello"
echo ""
echo "Risky commands will be blocked."
echo "-------------------------------------"
