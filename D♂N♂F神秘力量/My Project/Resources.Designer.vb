﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.42000
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    '此类是由 StronglyTypedResourceBuilder
    '类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    '若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    '(以 /str 作为命令选项)，或重新生成 VS 项目。
    '''<summary>
    '''  一个强类型的资源类，用于查找本地化的字符串等。
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  返回此类使用的缓存的 ResourceManager 实例。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("D_N_F神秘力量.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  使用此强类型资源类，为所有资源查找
        '''  重写当前线程的 CurrentUICulture 属性。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  查找 System.Byte[] 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property DNF_Path_Info() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("DNF_Path_Info", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  查找类似 懒人指南：
        '''禁用插件：一键禁用&gt;[插件状态]列显示[禁用]即可(TenSafe及TPSvc除外)
        '''还原插件：一键恢复&gt;[插件状态]列显示[正常]即可
        '''-----------------------------------
        '''关于两种模式：
        '''使用[IFEO]：推荐！，更新游戏[无需还原插件]
        '''禁止[文件读写]：更新游戏需要[还原插件]
        '''-----------------------------------
        '''关于弹窗：
        '''禁用插件弹窗：代表[IFEO]权限不足，默认采用[文件读写]模式
        '''如果已安装360，请翻到最后查看临时赋予权限方法
        '''-----------------------------------
        '''关于游戏环境异常：
        '''进入手动模式，逐个恢复已禁用插件
        '''一般为TenSafe.exe以及TPSvc.exe，建议不要禁用这两个插件
        '''-----------------------------------
        '''关于工作原理：
        '''禁止[文件读写]以及使用[IFEO]均可禁用插件。
        '''禁止[文件读写]：向目标文件添加[Everyone:deny]权限，插件文件不可访问
        '''使用[IFEO]：向注册 [字符串的其余部分被截断]&quot;; 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property help() As String
            Get
                Return ResourceManager.GetString("help", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似 Version2.4
        '''TP3Helper.exe|2|\TP3Helper.exe|TP主程序
        '''TPHelper.exe|2|\TCLS\TenProtect\TP\TPHelper\TPHelper.exe|TP安全中心后台程序
        '''TPWeb.exe|2|\TCLS\TenProtect\TP\TPHelper\TPWeb.exe|TP安全中心后台程序网络组件
        '''tgp_gamead.exe|2|\start\Cross\Apps\DNFTips\tgp_gamead\tgp_gamead.exe|WeGame直播程序
        '''AdvertDialog.exe|2|\TCLS\AdvertDialog.exe|视频播放程序
        '''AdvertTips.exe|2|\TCLS\AdvertTips.exe|广告程序
        '''BackgroundDownloader.exe|2|\TCLS\BackgroundDownloader.exe|后台下载程序
        '''TenSafe.exe|0|\start\TenProtect\TenSafe.exe|TP安全中心程序
        '''TenSafe.exe|0|\TCLS\TenProtect\ [字符串的其余部分被截断]&quot;; 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property list() As String
            Get
                Return ResourceManager.GetString("list", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Byte[] 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property takeown() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("takeown", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Byte[] 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property VoCytDefenderEx() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("VoCytDefenderEx", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
    End Module
End Namespace
