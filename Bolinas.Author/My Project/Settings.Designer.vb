﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.4200
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On



<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
 Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0"),  _
 Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
Partial Friend NotInheritable Class MySettings
    Inherits Global.System.Configuration.ApplicationSettingsBase
    
    Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings),MySettings)
    
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
    
    Public Shared ReadOnly Property [Default]() As MySettings
        Get
            
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
            Return defaultInstance
        End Get
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("RCDb Bolinas")>  _
    Public Property APPLICATION_NAME() As String
        Get
            Return CType(Me("APPLICATION_NAME"),String)
        End Get
        Set
            Me("APPLICATION_NAME") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property LAST_PROJECT_NAME() As String
        Get
            Return CType(Me("LAST_PROJECT_NAME"),String)
        End Get
        Set
            Me("LAST_PROJECT_NAME") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("C:\")>  _
    Public Property LAST_VIDEOTS_DIR() As String
        Get
            Return CType(Me("LAST_VIDEOTS_DIR"),String)
        End Get
        Set
            Me("LAST_VIDEOTS_DIR") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("C:\")>  _
    Public Property LAST_EXPORT_DIR() As String
        Get
            Return CType(Me("LAST_EXPORT_DIR"),String)
        End Get
        Set
            Me("LAST_EXPORT_DIR") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property RECENT_PROJECTS() As String
        Get
            Return CType(Me("RECENT_PROJECTS"),String)
        End Get
        Set
            Me("RECENT_PROJECTS") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
    Public Property RECENT_PROJECT_COUNT() As String
        Get
            Return CType(Me("RECENT_PROJECT_COUNT"),String)
        End Get
        Set
            Me("RECENT_PROJECT_COUNT") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
    Public Property PLAYER_REGION() As String
        Get
            Return CType(Me("PLAYER_REGION"),String)
        End Get
        Set
            Me("PLAYER_REGION") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
    Public Property PLAYER_ASPECT_RATIO() As String
        Get
            Return CType(Me("PLAYER_ASPECT_RATIO"),String)
        End Get
        Set
            Me("PLAYER_ASPECT_RATIO") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("English")>  _
    Public Property PLAYER_MENU_LANG() As String
        Get
            Return CType(Me("PLAYER_MENU_LANG"),String)
        End Get
        Set
            Me("PLAYER_MENU_LANG") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property RUN_UPGRADE() As Boolean
        Get
            Return CType(Me("RUN_UPGRADE"),Boolean)
        End Get
        Set
            Me("RUN_UPGRADE") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute(".bol_prj")>  _
    Public Property PROJECT_EXT() As String
        Get
            Return CType(Me("PROJECT_EXT"),String)
        End Get
        Set
            Me("PROJECT_EXT") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("Bolinas")>  _
    Public Property APPLICATION_NAME_SHORT() As String
        Get
            Return CType(Me("APPLICATION_NAME_SHORT"),String)
        End Get
        Set
            Me("APPLICATION_NAME_SHORT") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("C:\")>  _
    Public Property LAST_PROJECT_DIR() As String
        Get
            Return CType(Me("LAST_PROJECT_DIR"),String)
        End Get
        Set
            Me("LAST_PROJECT_DIR") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("C:\")>  _
    Public Property LAST_IMPORT_DIR() As String
        Get
            Return CType(Me("LAST_IMPORT_DIR"),String)
        End Get
        Set
            Me("LAST_IMPORT_DIR") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("100")>  _
    Public Property WINDOW_MAIN_TOP() As Short
        Get
            Return CType(Me("WINDOW_MAIN_TOP"),Short)
        End Get
        Set
            Me("WINDOW_MAIN_TOP") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("100")>  _
    Public Property WINDOW_MAIN_LEFT() As Short
        Get
            Return CType(Me("WINDOW_MAIN_LEFT"),Short)
        End Get
        Set
            Me("WINDOW_MAIN_LEFT") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("500")>  _
    Public Property WINDOW_VIEWER_TOP() As Short
        Get
            Return CType(Me("WINDOW_VIEWER_TOP"),Short)
        End Get
        Set
            Me("WINDOW_VIEWER_TOP") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("100")>  _
    Public Property WINDOW_VIEWER_LEFT() As Short
        Get
            Return CType(Me("WINDOW_VIEWER_LEFT"),Short)
        End Get
        Set
            Me("WINDOW_VIEWER_LEFT") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("92A09553-FDD9-4e6b-917B-B1FE2BF9EB59")>  _
    Public Property KEY_GUID() As String
        Get
            Return CType(Me("KEY_GUID"),String)
        End Get
        Set
            Me("KEY_GUID") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("5")>  _
    Public Property JUMP_SECONDS() As UShort
        Get
            Return CType(Me("JUMP_SECONDS"),UShort)
        End Get
        Set
            Me("JUMP_SECONDS") = value
        End Set
    End Property
End Class

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.RCDb.Bolinas.Author.MySettings
            Get
                Return Global.RCDb.Bolinas.Author.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
