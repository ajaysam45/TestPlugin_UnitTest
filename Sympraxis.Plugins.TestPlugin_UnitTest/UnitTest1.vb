Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Sympraxis.Plugins.TestPlugin
<TestClass()> Public Class UnitTest1


    Dim MyPlugin As New TestPlugin.TestPlugin

    <TestMethod()> _
    Public Sub CountIndicator_Senario1_Above200()
        Dim sMessage As String
        MyPlugin.CountIndicator(200, sMessage)
        Assert.AreEqual("Slightly Higher", sMessage)
    End Sub
    <TestMethod()> _
    Public Sub CountIndicator_Senario2_Above200()
        Dim sMessage As String
        MyPlugin.CountIndicator(200, sMessage)
        Assert.AreNotEqual("Above", sMessage)
    End Sub
    <TestMethod()> _
    Public Sub CountIndicator_Senario1_100()
        Dim sMessage As String
        MyPlugin.CountIndicator(100, sMessage)
        Assert.AreEqual("Percent", sMessage)
    End Sub

End Class