﻿'------------------------------------------------------------------------------
' <auto-generated>
'     このコードはツールによって生成されました。
'     ランタイム バージョン:4.0.30319.42000
'
'     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
'     コードが再生成されるときに損失したりします。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'このクラスは StronglyTypedResourceBuilder クラスが ResGen
    'または Visual Studio のようなツールを使用して自動生成されました。
    'メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    'ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    '''<summary>
    '''  ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("NicoInWonderland.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        '''  現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
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
        '''  System.IO.MemoryStream に類似した型 System.IO.UnmanagedMemoryStream のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property alarm() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("alarm", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property batsu() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("batsu", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property clock() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("clock", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property hatena() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("hatena", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property heart() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("heart", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  (アイコン) に類似した型 System.Drawing.Icon のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property icon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("icon", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property lace3() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("lace3", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property loupe() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("loupe", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property memo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("memo", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property nicoclick() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("nicoclick", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property nicoloop() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("nicoloop", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property nicoOK() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("nicoOK", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  System.IO.MemoryStream に類似した型 System.IO.UnmanagedMemoryStream のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property piko() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("piko", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  System.IO.MemoryStream に類似した型 System.IO.UnmanagedMemoryStream のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property pipi() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("pipi", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property poweroff() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("poweroff", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
