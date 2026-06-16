#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: locally maintained from https://www.3daistudio.com/Platform/API/Documentation/overview
install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace ThreeDAIStudio \
  --clientClassName ThreeDAIStudioClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
