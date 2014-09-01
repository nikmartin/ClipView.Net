'''#################################################
''' ClipViewer.Net
''' Allows you to view the HTML formatted text on the clipboard

''' clipviewer@nik-martin.com

''' Copyright (c) 2005, Nik Martin
''' All rights reserved.

''' Redistribution and use in source and binary forms, with or without
''' modification, are permitted provided that the following conditions are met:
'''    * Redistributions of source code must retain the above copyright
'''      notice, this list of conditions and the following disclaimer.
'''     * Redistributions in binary form must reproduce the above copyright
'''       notice, this list of conditions and the following disclaimer in the
'''      documentation and/or other materials provided with the distribution.
'''     * Neither the name of the <organization> nor the
'''       names of its contributors may be used to endorse or promote products
'''       derived from this software without specific prior written permission.

''' THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
''' ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
''' WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
''' DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> BE LIABLE FOR ANY
''' DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
''' (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
''' LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
''' ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
''' (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
''' SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
'''
'''#################################################



Imports System
Imports System.Windows.Forms

Class frmClipView
   Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

   Public Sub New()
      MyBase.New()

      'This call is required by the Windows Form Designer.
      InitializeComponent()

      'Add any initialization after the InitializeComponent() call

   End Sub

   'Form overrides dispose to clean up the component list.
   Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing Then
         If Not (components Is Nothing) Then
            components.Dispose()
         End If
      End If
      MyBase.Dispose(disposing)
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.
   'Do not modify it using the code editor.
   Friend WithEvents RT1 As System.Windows.Forms.RichTextBox
   Friend WithEvents Button1 As System.Windows.Forms.Button
   Friend WithEvents help As System.Windows.Forms.HelpProvider
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.RT1 = New System.Windows.Forms.RichTextBox()
      Me.Button1 = New System.Windows.Forms.Button()
      Me.help = New System.Windows.Forms.HelpProvider()
      Me.SuspendLayout()
      '
      'RT1
      '
      Me.RT1.Dock = System.Windows.Forms.DockStyle.Left
      'Me.RT1.Font = New System.Drawing.Font("Terminal", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.RT1.Location = New System.Drawing.Point(0, 0)
      Me.RT1.Name = "RT1"
      Me.help.SetShowHelp(Me.RT1, True)
      Me.RT1.Size = New System.Drawing.Size(712, 362)
      Me.RT1.TabIndex = 0
      Me.RT1.Text = ""
      '
      'Button1
      '
      Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
      Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Button1.Location = New System.Drawing.Point(712, 0)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(104, 32)
      Me.Button1.TabIndex = 1
      Me.Button1.Text = "Show It, Superchimp!"
      '
      'frmClipView
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(816, 362)
      Me.Controls.Add(Me.Button1)
      Me.Controls.Add(Me.RT1)
      Me.HelpButton = True
      Me.help.SetHelpString(Me, "No Help for this, dude.")
      Me.Name = "frmClipView"
      Me.help.SetShowHelp(Me, True)
      Me.Text = "FP Clip Viewer"
      Me.ResumeLayout(False)

   End Sub

#End Region



   Private Sub Form1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click


   End Sub

   Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
      ' Create a new instance of the DataObject interface.
      Dim data As IDataObject = Clipboard.GetDataObject()
      ' If the data is text, then set the text of the
      ' TextBox to the text in the Clipboard.
      If (data.GetDataPresent(DataFormats.Html)) Then
         RT1.Text = data.GetData(DataFormats.Html).ToString()
      End If
   End Sub


End Class
