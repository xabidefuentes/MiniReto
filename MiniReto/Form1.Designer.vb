<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lbVideojuegos = New ListBox()
        btnGuardar = New Button()
        btnAnadir = New Button()
        SuspendLayout()
        ' 
        ' lbVideojuegos
        ' 
        lbVideojuegos.FormattingEnabled = True
        lbVideojuegos.Location = New Point(134, 39)
        lbVideojuegos.Name = "lbVideojuegos"
        lbVideojuegos.Size = New Size(476, 204)
        lbVideojuegos.TabIndex = 0
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(134, 316)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(169, 44)
        btnGuardar.TabIndex = 1
        btnGuardar.Text = "GUARDAR"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnAnadir
        ' 
        btnAnadir.Location = New Point(441, 316)
        btnAnadir.Name = "btnAnadir"
        btnAnadir.Size = New Size(169, 44)
        btnAnadir.TabIndex = 2
        btnAnadir.Text = "AÑADIR"
        btnAnadir.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnAnadir)
        Controls.Add(btnGuardar)
        Controls.Add(lbVideojuegos)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lbVideojuegos As ListBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnAnadir As Button
End Class
