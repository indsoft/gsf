::*******************************************************************************************************
::  BuildNightly.bat - Gbtc
::
::  Tennessee Valley Authority, 2009
::  No copyright is claimed pursuant to 17 USC � 105.  All Other Rights Reserved.
::
::  This software is made freely available under the TVA Open Source Agreement (see below).
::
::  Code Modification History:
::  -----------------------------------------------------------------------------------------------------
::  10/20/2009 - Pinal C. Patel
::       Generated original version of source code.
::	09/16/2010 - Mihir Brahmbhatt
::		Modified to framework version from 3.5 to 4.0
::
::*******************************************************************************************************

@ECHO OFF
C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\msbuild.exe Historian.buildproj /l:FileLogger,Microsoft.Build.Engine;logfile=Historian.output