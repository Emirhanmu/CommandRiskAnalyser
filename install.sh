#!/bin/bash

dotnet publish -c Release -r linux-x64 --self-contained true

cd bin/Release/net8.0/linux-x64/publish

mv CommandRiskAnalyser safe

sudo mv safe /usr/local/bin/

echo "Installation complete!"
echo "You can now run: safe"
