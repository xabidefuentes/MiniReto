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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnGuardar = New Button()
        btnAnadir = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        lvVideojuegos = New ListView()
        btnEliminar = New Button()
        SuspendLayout()
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Font = New Font("Reem Kufi", 16.2F, FontStyle.Bold)
        btnGuardar.Location = New Point(246, 498)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(178, 67)
        btnGuardar.TabIndex = 1
        btnGuardar.Text = "GUARDAR"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnAnadir
        ' 
        btnAnadir.Font = New Font("Reem Kufi", 16.2F, FontStyle.Bold)
        btnAnadir.Location = New Point(545, 498)
        btnAnadir.Name = "btnAnadir"
        btnAnadir.Size = New Size(178, 67)
        btnAnadir.TabIndex = 2
        btnAnadir.Text = "AÑADIR"
        btnAnadir.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Reem Kufi", 13.8F, FontStyle.Bold)
        Label1.Location = New Point(64, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 41)
        Label1.TabIndex = 3
        Label1.Text = "TITULO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Reem Kufi", 13.8F, FontStyle.Bold)
        Label2.Location = New Point(233, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(179, 41)
        Label2.TabIndex = 4
        Label2.Text = "PLATAFORMA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Reem Kufi", 13.8F, FontStyle.Bold)
        Label3.Location = New Point(470, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 41)
        Label3.TabIndex = 5
        Label3.Text = "ESTUDIO"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Reem Kufi", 13.8F, FontStyle.Bold)
        Label4.Location = New Point(649, 40)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 41)
        Label4.TabIndex = 6
        Label4.Text = "AÑO"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Reem Kufi", 13.8F, FontStyle.Bold)
        Label5.Location = New Point(756, 40)
        Label5.Name = "Label5"
        Label5.Size = New Size(215, 41)
        Label5.TabIndex = 7
        Label5.Text = "TIEMPO RECORD"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Reem Kufi", 13.8F, FontStyle.Bold)
        Label6.Location = New Point(977, 40)
        Label6.Name = "Label6"
        Label6.Size = New Size(237, 41)
        Label6.TabIndex = 8
        Label6.Text = "PERSONA RECORD"
        ' 
        ' lvVideojuegos
        ' 
        lvVideojuegos.Font = New Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lvVideojuegos.Location = New Point(64, 98)
        lvVideojuegos.Name = "lvVideojuegos"
        lvVideojuegos.Size = New Size(1150, 356)
        lvVideojuegos.TabIndex = 9
        lvVideojuegos.UseCompatibleStateImageBehavior = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Font = New Font("Reem Kufi", 16.2F, FontStyle.Bold)
        btnEliminar.Location = New Point(826, 498)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(178, 67)
        btnEliminar.TabIndex = 10
        btnEliminar.Text = "ELIMINAR"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1282, 593)
        Controls.Add(btnEliminar)
        Controls.Add(lvVideojuegos)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnAnadir)
        Controls.Add(btnGuardar)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "TABLA VIDEOJUEGOS"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnAnadir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lvVideojuegos As ListView
    Friend WithEvents btnEliminar As Button
End Class
