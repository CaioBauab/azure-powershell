---
external help file: Microsoft.Azure.PowerShell.Cmdlets.Compute.dll-Help.xml
Module Name: Az.Compute
online version: https://learn.microsoft.com/powershell/module/az.compute/invoke-azvmruncommand
schema: 2.0.0
---

# Invoke-AzVMRunCommand

## SYNOPSIS
Run a command on the VM.

## SYNTAX

### DefaultParameter (Default)
```
Invoke-AzVMRunCommand [-ResourceGroupName] <String> [-VMName] <String> -CommandId <String>
 [-ScriptPath <String>] [-ScriptString <String>] [-Parameter <Hashtable>] [-AsJob]
 [-DefaultProfile <IAzureContextContainer>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### ResourceIdParameter
```
Invoke-AzVMRunCommand -CommandId <String> [-ScriptPath <String>] [-ScriptString <String>]
 [-Parameter <Hashtable>] [-ResourceId] <String> [-AsJob] [-DefaultProfile <IAzureContextContainer>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### VMParameter
```
Invoke-AzVMRunCommand -CommandId <String> [-ScriptPath <String>] [-ScriptString <String>]
 [-Parameter <Hashtable>] [-VM] <PSVirtualMachine> [-AsJob] [-DefaultProfile <IAzureContextContainer>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke a run command on the VM.

## EXAMPLES

### Example 1: Invoke a command on Windows - Using ScriptPath parameter when the script resides on the remote Windows VM
```powershell
Invoke-AzVMRunCommand -ResourceGroupName 'rgname' -VMName 'vmname' -CommandId 'RunPowerShellScript' -ScriptPath 'sample.ps1' -Parameter @{param1 = "var1"; param2 = "var2"}
```

Invoke a run command 'RunPowerShellScript' with overriding the script 'sample.ps1' on a Windows VM named 'vmname' in resource group 'rgname'. Var1 and var2 are defined as parameters in the sample.ps1. Parameter value can be string type only and script is responsible for converting them to other types if needed. 

### Example 2: Invoke a command on Windows - Using ScriptString parameter to execute cmdlet on the Windows VM
```powershell
Invoke-AzVMRunCommand -ResourceGroupName 'rgname' -VMName 'vmname' -CommandId 'RunPowerShellScript' -ScriptString "Set-TimeZone -Name 'Coordinated Universal Time' -PassThru"
```

This command invokes a run command 'RunShellScript' that will execute the cmdlet Set-TimeZone with it's associated parameters. This example is useful when you want to execute short commands on Windows VM.

### Example 3: Invoke a command on Windows - Using ScriptString parameter to run script blocks on the Windows VM
```powershell
$ScriptBlock = {
    param(
        [string] $NewTimeZone,
        [string] $NewDate
        )
    Set-TimeZone -Id $NewTimeZone
    Set-Date -Date [DateTime]$NewDate
}

$Script = [scriptblock]::create($ScriptBlock)

Invoke-AzVMRunCommand -ResourceGroupName 'rgname' -VMName 'vmname' -CommandId 'RunPowerShellScript' -ScriptString $Script -Parameter @{'NewTimeZone' = "UTC"; 'NewDate' = "Dec-8"}
```

This command invokes a run command 'RunShellScript' that executes a script block on a remote Windows VM named 'vmname'. The script block way allows you to execute multiple cmdlets with parameters in a single invoke and it also saves time on invoking multiple run commands for different cmdlets. Parameter value(s) can be of string type only.

### Example 4: Invoke a command on Linux
<!-- Skip: Output cannot be splitted from code -->


```powershell
export param1=var1 param2=var2
set -- var1 var2 var3

Invoke-AzVMRunCommand -ResourceGroupName 'rgname' -Name 'vmname' -CommandId 'RunShellScript' -ScriptPath 'sample.bash' -Parameter @{"param1" = "var1";"param2" = "var2"}
echo This is a sample bash script
echo Usage 1: Ordered parameters: $0 $1
echo Usage 2: Named exports: $var1 $var2
```

This command invokes a run command 'RunShellScript' with overriding the script 'sample.bash' on a Linux VM named 'vmname'. Var1 and var2 are defined as parameters in the sample.bash.

## PARAMETERS

### -AsJob
Run cmdlet in the background and return a job object to track progress.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CommandId
The run command ID.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: Microsoft.Azure.Commands.Common.Authentication.Abstractions.Core.IAzureContextContainer
Parameter Sets: (All)
Aliases: AzContext, AzureRmContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Parameter
The run command parameters. Specify parameters as key/value pairs to be passed at script execution.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.

```yaml
Type: System.String
Parameter Sets: DefaultParameter
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -ResourceId
The resource ID for the VM.

```yaml
Type: System.String
Parameter Sets: ResourceIdParameter
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -ScriptPath
Path of the script to be executed. When this value is given, the given script will override the default script of the command.
Path should point to a file from a local file system. The command will load it and send it for execution.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScriptString
The script to be executed as a string.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VM
The PS virtual machine object.

```yaml
Type: Microsoft.Azure.Commands.Compute.Models.PSVirtualMachine
Parameter Sets: VMParameter
Aliases: VMProfile

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByPropertyName, ByValue)
Accept wildcard characters: False
```

### -VMName
The name of the virtual machine.

```yaml
Type: System.String
Parameter Sets: DefaultParameter
Aliases: Name

Required: True
Position: 1
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.String

### Microsoft.Azure.Commands.Compute.Models.PSVirtualMachine

## OUTPUTS

### Microsoft.Azure.Commands.Compute.Automation.Models.PSRunCommandResult

## NOTES

## RELATED LINKS
