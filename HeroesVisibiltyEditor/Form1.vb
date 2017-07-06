Imports System.IO

Public Class Form1
    Structure Chunk
        Dim ChunkNumber As UInt32
        Dim MinimumX As Int32
        Dim MinimumY As Int32
        Dim MinimumZ As Int32
        Dim MaximumX As Int32
        Dim MaximumY As Int32
        Dim MaximumZ As Int32
    End Structure

    Dim ChunkStream As New List(Of Chunk)

    Dim ProgramIsChangingStuff = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            LoadBLKFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If OpenFileDialog1.FileName.Count > 0 Then
            SaveBLKFile(OpenFileDialog1.FileName)
        Else
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                SaveBLKFile(SaveFileDialog1.FileName)
            End If
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        If OpenFileDialog1.FileName.Count > 0 Then
            SaveFileDialog1.FileName = OpenFileDialog1.FileName
        End If
        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            SaveBLKFile(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Heroes BLK Visibility Editor Release 3 by igorseabra4")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Sub LoadBLKFile(FileName As String)
        ChunkStream.Clear()
        ListBoxChunks.Items.Clear()

        Dim BLKFileReader As New BinaryReader(New FileStream(FileName, FileMode.Open))

        BLKFileReader.BaseStream.Position = 0

        For i = 0 To (BLKFileReader.BaseStream.Length / &H1C) - 1
            Dim BCArray = BLKFileReader.ReadBytes(&H1C)

            Dim TempChunk As New Chunk
            TempChunk.ChunkNumber = BitConverter.ToUInt32({BCArray(3), BCArray(2), BCArray(1), BCArray(0)}, 0)

            If TempChunk.ChunkNumber = 4294967295 Then
                Continue For
            End If

            TempChunk.MinimumX = BitConverter.ToInt32({BCArray(7), BCArray(6), BCArray(5), BCArray(4)}, 0)
            TempChunk.MinimumY = BitConverter.ToInt32({BCArray(11), BCArray(10), BCArray(9), BCArray(8)}, 0)
            TempChunk.MinimumZ = BitConverter.ToInt32({BCArray(15), BCArray(14), BCArray(13), BCArray(12)}, 0)

            TempChunk.MaximumX = BitConverter.ToInt32({BCArray(19), BCArray(18), BCArray(17), BCArray(16)}, 0)
            TempChunk.MaximumY = BitConverter.ToInt32({BCArray(23), BCArray(22), BCArray(21), BCArray(20)}, 0)
            TempChunk.MaximumZ = BitConverter.ToInt32({BCArray(27), BCArray(26), BCArray(25), BCArray(24)}, 0)

            ChunkStream.Add(TempChunk)
        Next

        PopulateListBox()

        BLKFileReader.Close()
    End Sub

    Sub SaveBLKFile(OutputFileName)
        Dim BLKFileWriter As New BinaryWriter(New FileStream(OutputFileName, FileMode.Create))

        For Each i As Chunk In ChunkStream
            If i.ChunkNumber = -1 Then
                Continue For
            End If

            BLKFileWriter.Write(BitConverter.GetBytes(i.ChunkNumber)(3))
            BLKFileWriter.Write(BitConverter.GetBytes(i.ChunkNumber)(2))
            BLKFileWriter.Write(BitConverter.GetBytes(i.ChunkNumber)(1))
            BLKFileWriter.Write(BitConverter.GetBytes(i.ChunkNumber)(0))

            BLKFileWriter.Write(BitConverter.GetBytes(i.MinimumX)(3))
            BLKFileWriter.Write(BitConverter.GetBytes(i.MinimumX)(2))
            BLKFileWriter.Write(BitConverter.GetBytes(i.MinimumX)(1))
            BLKFileWriter.Write(BitConverter.GetBytes(i.MinimumX)(0))

            BLKFileWriter.Write(BitConverter.GetBytes(i.MinimumY)(3))
            BLKFileWriter.Write(BitConverter.GetBytes(i.MinimumY)(2))
            BLKFileWriter.Write(BitConverter.GetBytes(i.MinimumY)(1))
            BLKFileWriter.Write(BitConverter.GetBytes(i.MinimumY)(0))

            BLKFileWriter.Write(BitConverter.GetBytes(i.MinimumZ)(3))
            BLKFileWriter.Write(BitConverter.GetBytes(i.MinimumZ)(2))
            BLKFileWriter.Write(BitConverter.GetBytes(i.MinimumZ)(1))
            BLKFileWriter.Write(BitConverter.GetBytes(i.MinimumZ)(0))

            BLKFileWriter.Write(BitConverter.GetBytes(i.MaximumX)(3))
            BLKFileWriter.Write(BitConverter.GetBytes(i.MaximumX)(2))
            BLKFileWriter.Write(BitConverter.GetBytes(i.MaximumX)(1))
            BLKFileWriter.Write(BitConverter.GetBytes(i.MaximumX)(0))

            BLKFileWriter.Write(BitConverter.GetBytes(i.MaximumY)(3))
            BLKFileWriter.Write(BitConverter.GetBytes(i.MaximumY)(2))
            BLKFileWriter.Write(BitConverter.GetBytes(i.MaximumY)(1))
            BLKFileWriter.Write(BitConverter.GetBytes(i.MaximumY)(0))

            BLKFileWriter.Write(BitConverter.GetBytes(i.MaximumZ)(3))
            BLKFileWriter.Write(BitConverter.GetBytes(i.MaximumZ)(2))
            BLKFileWriter.Write(BitConverter.GetBytes(i.MaximumZ)(1))
            BLKFileWriter.Write(BitConverter.GetBytes(i.MaximumZ)(0))
        Next

        OpenFileDialog1.FileName = OutputFileName
        BLKFileWriter.Close()
    End Sub

    Sub PopulateListBox()
        ProgramIsChangingStuff = True
        ListBoxChunks.Items.Clear()

        For i = 0 To ChunkStream.Count - 1
            ListBoxChunks.Items.Add("Chunk " + (i + 1).ToString)
        Next

        ProgramIsChangingStuff = False
    End Sub

    Private Sub ListBoxChunks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxChunks.SelectedIndexChanged
        ProgramIsChangingStuff = True

        If ListBoxChunks.Items.Count > 0 And ListBoxChunks.SelectedIndex <> -1 Then
            NumChunkNum.Enabled = True
            NumMinX.Enabled = True
            NumMinY.Enabled = True
            NumMinZ.Enabled = True
            NumMaxX.Enabled = True
            NumMaxY.Enabled = True
            NumMaxZ.Enabled = True
            NumChunkNum.Value = ChunkStream(ListBoxChunks.SelectedIndex).ChunkNumber
            NumMinX.Value = ChunkStream(ListBoxChunks.SelectedIndex).MinimumX
            NumMinY.Value = ChunkStream(ListBoxChunks.SelectedIndex).MinimumY
            NumMinZ.Value = ChunkStream(ListBoxChunks.SelectedIndex).MinimumZ
            NumMaxX.Value = ChunkStream(ListBoxChunks.SelectedIndex).MaximumX
            NumMaxY.Value = ChunkStream(ListBoxChunks.SelectedIndex).MaximumY
            NumMaxZ.Value = ChunkStream(ListBoxChunks.SelectedIndex).MaximumZ
        Else
            NumChunkNum.Value = 0
            NumMinX.Value = 0
            NumMinY.Value = 0
            NumMinZ.Value = 0
            NumMaxX.Value = 0
            NumMaxY.Value = 0
            NumMaxZ.Value = 0
            NumChunkNum.Enabled = False
            NumMinX.Enabled = False
            NumMinY.Enabled = False
            NumMinZ.Enabled = False
            NumMaxX.Enabled = False
            NumMaxY.Enabled = False
            NumMaxZ.Enabled = False
        End If

        ProgramIsChangingStuff = False
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        If ChunkStream.Count = 64 Then
            MessageBox.Show("Maximum amount of chunks reached")
            Exit Sub
        End If

        ChunkStream.Add(New Chunk)
        ListBoxChunks.Items.Add("Chunk " + ChunkStream.Count.ToString)
        ListBoxChunks.SelectedIndex = ChunkStream.Count - 1
    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        If ListBoxChunks.SelectedIndex >= 0 Then

            Dim SaveForLater = ListBoxChunks.SelectedIndex
            ChunkStream.RemoveAt(ListBoxChunks.SelectedIndex)

            ListBoxChunks.Items.RemoveAt(SaveForLater)

            For i = SaveForLater To ListBoxChunks.Items.Count - 1
                ListBoxChunks.Items(i) = ("Chunk " + (i + 1).ToString)
            Next

            If SaveForLater < ListBoxChunks.Items.Count And SaveForLater >= 1 Then
                ListBoxChunks.SelectedIndex = SaveForLater
            ElseIf SaveForLater < ListBoxChunks.Items.Count Then
                ListBoxChunks.SelectedIndex = SaveForLater - 1
            ElseIf ListBoxChunks.Items.Count > 0 Then
                ListBoxChunks.SelectedIndex = 0
            End If

            If ChunkStream.Count = 0 Then
                NumChunkNum.Value = 0
                NumMinX.Value = 0
                NumMinY.Value = 0
                NumMinZ.Value = 0
                NumMaxX.Value = 0
                NumMaxY.Value = 0
                NumMaxZ.Value = 0
                NumChunkNum.Enabled = False
                NumMinX.Enabled = False
                NumMinY.Enabled = False
                NumMinZ.Enabled = False
                NumMaxX.Enabled = False
                NumMaxY.Enabled = False
                NumMaxZ.Enabled = False
            End If
        End If
    End Sub

    Private Sub NumChunkNum_ValueChanged(sender As Object, e As EventArgs) Handles NumChunkNum.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim TempChunk = ChunkStream(ListBoxChunks.SelectedIndex)
            TempChunk.ChunkNumber = NumChunkNum.Value
            ChunkStream(ListBoxChunks.SelectedIndex) = TempChunk
        End If
    End Sub

    Private Sub NumMinX_ValueChanged(sender As Object, e As EventArgs) Handles NumMinX.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim TempChunk = ChunkStream(ListBoxChunks.SelectedIndex)
            TempChunk.MinimumX = NumMinX.Value
            ChunkStream(ListBoxChunks.SelectedIndex) = TempChunk
        End If
    End Sub

    Private Sub NumMinY_ValueChanged(sender As Object, e As EventArgs) Handles NumMinY.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim TempChunk = ChunkStream(ListBoxChunks.SelectedIndex)
            TempChunk.MinimumY = NumMinY.Value
            ChunkStream(ListBoxChunks.SelectedIndex) = TempChunk
        End If
    End Sub

    Private Sub NumMinZ_ValueChanged(sender As Object, e As EventArgs) Handles NumMinZ.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim TempChunk = ChunkStream(ListBoxChunks.SelectedIndex)
            TempChunk.MinimumZ = NumMinZ.Value
            ChunkStream(ListBoxChunks.SelectedIndex) = TempChunk
        End If
    End Sub

    Private Sub NumMaxX_ValueChanged(sender As Object, e As EventArgs) Handles NumMaxX.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim TempChunk = ChunkStream(ListBoxChunks.SelectedIndex)
            TempChunk.MaximumX = NumMaxX.Value
            ChunkStream(ListBoxChunks.SelectedIndex) = TempChunk
        End If
    End Sub

    Private Sub NumMaxY_ValueChanged(sender As Object, e As EventArgs) Handles NumMaxY.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim TempChunk = ChunkStream(ListBoxChunks.SelectedIndex)
            TempChunk.MaximumY = NumMaxY.Value
            ChunkStream(ListBoxChunks.SelectedIndex) = TempChunk
        End If
    End Sub

    Private Sub NumMaxZ_ValueChanged(sender As Object, e As EventArgs) Handles NumMaxZ.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim TempChunk = ChunkStream(ListBoxChunks.SelectedIndex)
            TempChunk.MaximumZ = NumMaxZ.Value
            ChunkStream(ListBoxChunks.SelectedIndex) = TempChunk
        End If
    End Sub

End Class
