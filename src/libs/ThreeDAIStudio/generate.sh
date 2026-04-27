#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained from https://www.3daistudio.com/Platform/API/Documentation/overview

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace ThreeDAIStudio \
  --clientClassName ThreeDAIStudioClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
