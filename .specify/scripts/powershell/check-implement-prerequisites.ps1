<#
.SYNOPSIS
    Check that tasks.md exists and list optional design documents.
    Usage: ./check-implement-prerequisites.ps1 [-Json]

.DESCRIPTION
    This script verifies prerequisites for implementation in a spec-kit feature directory.
    It sources common functions and variables from common.ps1, checks for required/optional files,
    and can output results in JSON format.

.PARAMETER Json
    Output results in JSON format.

.EXAMPLE
    ./check-implement-prerequisites.ps1
    ./check-implement-prerequisites.ps1 -Json
#>

param (
    [switch]$Json,
    [switch]$Help
)

if ($Help) {
    Write-Host "Usage: .\check-implement-prerequisites.ps1 [-Json]"
    exit 0
}

# Source common functions
$ScriptDir = Split-Path -Parent $MyInvocation.MyCommand.Definition
. "$ScriptDir\common.ps1"

# Get all paths (assume get_feature_paths sets variables via Set-Variable or returns a hashtable)
$featurePaths = Get-FeaturePaths
$CurrentBranch = $featurePaths["CURRENT_BRANCH"]
$FeatureDir    = $featurePaths["FEATURE_DIR"]
$ImplPlan      = $featurePaths["IMPL_PLAN"]
$Research      = $featurePaths["RESEARCH"]
$DataModel     = $featurePaths["DATA_MODEL"]
$Tasks         = $featurePaths["TASKS"]
$ContractsDir  = $featurePaths["CONTRACTS_DIR"]
$Quickstart    = $featurePaths["QUICKSTART"]

# Check if on feature branch
if (-not (Check-FeatureBranch $CurrentBranch)) {
    exit 1
}

# Check if feature directory exists
if (-not (Test-Path $FeatureDir -PathType Container)) {
    Write-Host "ERROR: Feature directory not found: $FeatureDir"
    Write-Host "Run /specify first to create the feature structure."
    exit 1
}

# Check for tasks (required)
if (-not (Test-Path $Tasks -PathType Leaf)) {
    Write-Host "ERROR: tasks.md not found in $FeatureDir"
    Write-Host "Run /tasks first to create the tasks."
    exit 1
}

if ($Json) {
    # Build JSON array of available docs that actually exist
    $docs = @()
    if (Test-Path $ImplPlan -PathType Leaf)    { $docs += "plan.md" }
    if (Test-Path $Research -PathType Leaf)    { $docs += "research.md" }
    if (Test-Path $DataModel -PathType Leaf)   { $docs += "data-model.md" }
    if (Test-Path $Tasks -PathType Leaf)       { $docs += "tasks.md" }
    if ((Test-Path $ContractsDir -PathType Container) -and (Get-ChildItem -Path $ContractsDir | Where-Object { -not $_.PSIsContainer })) {
        $docs += "contracts/"
    }
    if (Test-Path $Quickstart -PathType Leaf)  { $docs += "quickstart.md" }
    $jsonDocs = $docs | ForEach-Object { '"' + $_ + '"' } | Join-String -Separator ","
    $jsonDocs = "[" + $jsonDocs + "]"
    $jsonOut = @{
        FEATURE_DIR    = $FeatureDir
        AVAILABLE_DOCS = $docs
    }
    $jsonOut | ConvertTo-Json
} else {
    # List available design documents (optional)
    Write-Host "FEATURE_DIR:$FeatureDir"
    Write-Host "AVAILABLE_DOCS:"

    # Use common check functions
    Check-File $Tasks        "tasks.md"
    Check-File $ImplPlan     "plan.md"
    Check-File $Research     "research.md"
    Check-File $DataModel    "data-model.md"
    Check-Dir  $ContractsDir "contracts/"
    Check-File $Quickstart   "quickstart.md"
}