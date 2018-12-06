Imports System
Imports System.Math
Imports System.IO
Imports System.Text
Imports System.Data.OleDb
Imports System.Collections.Generic
Imports System.Reflection
Imports AirXDLL


Public Class Form1

    Dim input As New AirXDLL.Inputs
    Dim output As New AirXDLL.Outputs
    Dim myObject As Object
    ' Dim cityCollection As CitiesCollection
    Dim fileName As String
    Dim calcOutputs As New CalculatedOutputs

    Dim binEnData As New BinEnergyData

    Private Sub Form1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' txtFileLoc.Text = ""
        'Dim utiltityFuncs As New UtilityFunctions

        'ddlRegion.Items.Clear()
        'Dim SortedArray As New ArrayList(10)

        ''Dim di As New IO.DirectoryInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\AirXChange ERC 6.0")
        ''txtFileLoc.Text = di.FullName & "\"
        'Dim di As New IO.DirectoryInfo(txtFileLoc.Text)
        'Dim diar1 As IO.FileInfo() = di.GetFiles("*AirXWeatherData*.mdb")
        'Dim dra As IO.FileInfo

        ''list the names of all files in the specified directory
        'For Each dra In diar1
        '    Dim fileName As String = dra.Name
        '    Dim subFileName As String = fileName.Substring(0, fileName.IndexOf(".mdb"))
        '    'filenames are in the form AirXWeatherData-Region.mdb
        '    'pull off the AirXWeather
        '    Dim parts() As String = subFileName.Split(CChar("-"))
        '    Dim r As String = parts(1).Replace("_", " ")
        '    If Not SortedArray.Contains(r) Then

        '        SortedArray.Add(r)
        '    End If

        'Next
        'SortedArray.Sort()
        'For Each Region As String In SortedArray
        '    ddlRegion.Items.Add(Region)
        'Next

        'ddlRegion.SelectedIndex = 0
        'PopulateModelsDDL()


    End Sub

    Private Sub PopulateModelsDDL()
        Dim utiltityFuncs As New UtilityFunctions
        Dim modelsList As ArrayList = utiltityFuncs.GetModelsList(txtFileLoc.Text)

        For Each model As String In modelsList
            ddlModel.Items.Add(model)
        Next
        If ddlModel.Items.Count > 0 Then
            ddlModel.SelectedIndex = 0
        End If
    End Sub


    Private Sub WriteOutputToFile(ByVal o As Outputs, ByVal FileName As String)

        Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim sb As New StringBuilder()

        With o
            'sb.AppendLine("eatr" & "," & .EATR.ToString())
            'sb.AppendLine("oacf" & "," & .OACF.ToString())
            'sb.AppendLine("latenteff" & "," & .LatentEff.ToString())
            'sb.AppendLine("senseff" & "," & .SensEff.ToString())
            'sb.AppendLine("winterlatenteff" & "," & .WinterLatentEff.ToString())
            'sb.AppendLine("wintersenseff" & "," & .WinterSensEff.ToString())
            sb.AppendLine("supdbsum" & "," & .SupDBSum.ToString())
            sb.AppendLine("supwbsum" & "," & .SupWBSum.ToString())
            'sb.AppendLine("suphrsum" & "," & .SupHRSum.ToString())
            'sb.AppendLine("supenthsum" & "," & .SupEnthSum.ToString())
            sb.AppendLine("supdbwin" & "," & .SupDBWin.ToString())
            sb.AppendLine("supwbwin" & "," & .SupWBWin.ToString())
            'sb.AppendLine("suphrwin" & "," & .SupHRWin.ToString())
            'sb.AppendLine("supenthwin" & "," & .SupEnthWin.ToString())
            sb.AppendLine("supplyflow" & "," & .SupplyFlow.ToString())
            sb.AppendLine("returnflow" & "," & .ReturnFlow.ToString())
            sb.AppendLine("outdoorflow" & "," & .OutdoorFlow.ToString())
            sb.AppendLine("exhaustflow" & "," & .ExhaustFlow.ToString())
            sb.AppendLine("suppressdrop" & "," & .SupPressDrop.ToString())
            sb.AppendLine("exhpressdrop" & "," & .ExhPressDrop.ToString())
            'sb.AppendLine("fanpower" & "," & .FanPower.ToString())
            'sb.AppendLine("measeffsummer" & "," & .MeasEffSummer.ToString())
            'sb.AppendLine("neteffsummer" & "," & .NetEffSummer.ToString())
            'sb.AppendLine("measeffwin" & "," & .MeasEffWinter.ToString())
            'sb.AppendLine("neteffwinter" & "," & .NetEffWinter.ToString())
            'sb.AppendLine("outdoorpressure" & "," & .OutdoorPressure.ToString())
            'sb.AppendLine("supplypressure" & "," & .SupplyPressure.ToString())
            'sb.AppendLine("exhaustpressure" & "," & .ExhaustPressure.ToString())
            'sb.AppendLine("returnpressure" & "," & .ReturnPressure.ToString())
            'sb.AppendLine("returnpressure" & "," & .ReturnPressure.ToString())
            'sb.AppendLine("oasensiblesum" & "," & .OASensSum.ToString())
            'sb.AppendLine("oalatentsum" & "," & .OALatentSum.ToString())
            'sb.AppendLine("oatotalsum" & "," & .OATotalSum.ToString())
            'sb.AppendLine("oarecoveredsum" & "," & .OARecoveredSum.ToString())
            'sb.AppendLine("oarecoveredsensiblesum" & "," & .OARecoveredSensibleSum.ToString())
            'sb.AppendLine("oarecoveredlatentsum" & "," & .OARecoveredLatentSum.ToString())
            'sb.AppendLine("oanetsum" & "," & .OANetSum.ToString())
            'sb.AppendLine("oasensiblewin" & "," & .OASensibleWin.ToString())
            'sb.AppendLine("oalatentwin" & "," & .OALatentWin.ToString())
            'sb.AppendLine("oatotalwin" & "," & .OATotalWin.ToString())
            'sb.AppendLine("oarecoveredwin" & "," & .OARecoveredWin.ToString())
            'sb.AppendLine("oarecoveredsensiblewin" & "," & .OARecoveredSensibleWin.ToString())
            'sb.AppendLine("oarecoveredlatentwin" & "," & .OARecoveredLatentWin.ToString())
            'sb.AppendLine("oanetwin" & "," & .OANetWin.ToString())
            'sb.AppendLine("preheattemp" & "," & .PreHeatTemp.ToString())
            'sb.AppendLine("preheatcapacity" & "," & .PreHeatCapacity.ToString())
            'sb.AppendLine("preheater" & "," & .PreHeater.ToString())
            'sb.AppendLine("recsenssum" & "," & .RecSensSum.ToString())
            'sb.AppendLine("reclatsum" & "," & .RecLatSum.ToString())
            'sb.AppendLine("recsenswin" & "," & .RecSensWin.ToString())
            'sb.AppendLine("reclatwin" & "," & .RecLatWin.ToString())
            'sb.AppendLine("allowedDP" & "," & .AllowedDP.ToString())
            'sb.AppendLine("tFrost" & "," & .TFrost.ToString())
            'sb.AppendLine("capacity" & "," & .Capacity.ToString())
            'sb.AppendLine("dbsupSnet" & "," & .DBSupSNet.ToString())
            'sb.AppendLine("hrsupSnet" & "," & .HRSupSNet.ToString())
            'sb.AppendLine("enthsupSnet" & "," & .EnthSupSNet.ToString())
            'sb.AppendLine("rhsupSnet" & "," & .RHSupSNet.ToString())
            'sb.AppendLine("wbsupSnet" & "," & .WBSupSNet.ToString())
            'sb.AppendLine("DbsupwNet" & "," & .DbsupwNet.ToString())
            'sb.AppendLine("HrsupwNet" & "," & .HRsupwNet.ToString())
            'sb.AppendLine("EnthsupwNet" & "," & .EnthsupwNet.ToString())
            'sb.AppendLine("WBsupwNet" & "," & .WBsupwNet.ToString())
            'sb.AppendLine("RHsupwNet" & "," & .RHsupwNet.ToString())
            'sb.AppendLine("TwbEstw" & "," & .TwbEstw.ToString())
            'sb.AppendLine("TwbEsts" & "," & .TwbEsts.ToString())
            'sb.AppendLine("TempWIn" & "," & .TempWIn.ToString())
            'sb.AppendLine("EnthWIn" & "," & .EnthWIn.ToString())
            'sb.AppendLine("CLGSav" & "," & .CLGSav.ToString())
            'sb.AppendLine("HTGSav" & "," & .HTGSav.ToString())
            'sb.AppendLine("ESSM" & "," & .ESSM.ToString())
            'sb.AppendLine("ELSM" & "," & .ELSM.ToString())
            'sb.AppendLine("ETSM" & "," & .ETSM.ToString())
            'sb.AppendLine("ESSN" & "," & .ESSN.ToString())
            'sb.AppendLine("ELSN" & "," & .ELSN.ToString())
            'sb.AppendLine("ETSN" & "," & .ETSN.ToString())
            'sb.AppendLine("ESWM" & "," & .ESWM.ToString())
            'sb.AppendLine("ELWM" & "," & .ELWM.ToString())
            'sb.AppendLine("ETWM" & "," & .ETWM.ToString())
            'sb.AppendLine("ESWN" & "," & .ESWN.ToString())
            'sb.AppendLine("ELWN" & "," & .ELWN.ToString())
            'sb.AppendLine("ETWN" & "," & .ETwN.ToString())
            'sb.AppendLine("DbexhsNet" & "," & .DbexhsNet.ToString())
            'sb.AppendLine("HrexhsNet" & "," & .HrexhsNet.ToString())
            'sb.AppendLine("EnthexhsNet" & "," & .EnthexhsNet.ToString())
            'sb.AppendLine("WbexhsNet" & "," & .WbexhsNet.ToString())
            'sb.AppendLine("RhexhsNet" & "," & .RhexhsNet.ToString())
            'sb.AppendLine("DbexhwNet" & "," & .DbexhwNet.ToString())
            'sb.AppendLine("HrexhwNet" & "," & .HrexhwNet.ToString())
            'sb.AppendLine("EnthexhwNet" & "," & .EnthexhwNet.ToString())
            'sb.AppendLine("WbexhwNet" & "," & .WbexhwNet.ToString())
            'sb.AppendLine("RhexhwNet" & "," & .RhexhwNet.ToString())
            'sb.AppendLine("AverageSupplyFlow" & "," & .AverageSupplyFlow.ToString())
            'sb.AppendLine("AverageExhaustFlow" & "," & .AverageExhaustFlow.ToString())
            'sb.AppendLine("mfRHError" & "," & .mfRHError.ToString())
            'sb.AppendLine("purgeAngle" & "," & .PurgeAngle.ToString())
            'sb.AppendLine("freshSCFM" & "," & .FreshSCFM.ToString())
            'sb.AppendLine("exhaustSCFM" & "," & .ExhaustSCFM.ToString())
            'sb.AppendLine("erveer" & "," & .ErvEER.ToString())
            'sb.AppendLine("PercentOALoad" & "," & .PercentOALoad.ToString())
            'sb.AppendLine("CombinedEER" & "," & .CombinedEER.ToString())

        End With

        Using outfile As New StreamWriter(mydocpath & "\" & FileName & ".csv")
            outfile.Write(sb.ToString())
        End Using
    End Sub
    Private Sub WriteAirXErrsToFile(ByVal e As List(Of ErrFlags), ByVal fileName As String)
        'Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim mydocpath As String = txtRptLoc.Text
        Dim sb As New StringBuilder()


        For Each errs As ErrFlags In e
            sb.AppendLine("ErrText=" & "," & errs.ErrText)
        Next

        If e.Count = 0 Then
            sb.AppendLine("No errors found")
        End If
        Try
            Using outfile As New StreamWriter(mydocpath & "\" & fileName & ".csv")
                outfile.Write(sb.ToString())
            End Using
        Catch ex As Exception
            MsgBox("Error writing report.  Please check that file is closed", MsgBoxStyle.OkOnly, "Output Error")
        End Try

    End Sub
    Private Sub WriteAirXOutputToFile(ByVal o As AirXOutputs, ByVal FileName As String)

        'Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim mydocpath As String = txtRptLoc.Text
        Dim sb As New StringBuilder()

        With o
            'sb.AppendLine("eatr" & "," & .EATR.ToString() & "," & "," & "exhaust air transfer ratio")
            'sb.AppendLine("oacf" & "," & .OACF.ToString() & "," & "," & "outdoor air correction factor")
            'sb.AppendLine("latenteff" & "," & .LatentEff.ToString() & "," & "," & "latent efficiency summer")
            'sb.AppendLine("senseff" & "," & .SensEff.ToString() & "," & "," & "sensible efficiency summer")
            'sb.AppendLine("winterlatenteff" & "," & .WinterLatentEff.ToString() & "," & "," & "latent efficiency winter")
            'sb.AppendLine("wintersenseff" & "," & .WinterSensEff.ToString() & "," & "," & "sensible efficiency winter")
            sb.AppendLine("supdbsum" & "," & .SupDBSum.ToString() & "," & "," & "temperature of supply air summer F")
            sb.AppendLine("supwbsum" & "," & .SupWBSum.ToString() & "," & "," & "wet bulb of supply air summer F")
            'sb.AppendLine("suphrsum" & "," & .SupHRSum.ToString() & "," & "," & "humidity ratio of supply air summer gr/lb")
            'sb.AppendLine("supRHsum" & "," & .SupRHSum.ToString() & "," & "," & "relative humidity of supply air summer %")
            'sb.AppendLine("supenthsum" & "," & .SupEnthSum.ToString() & "," & "," & "enthalpy of supply air summer Btu/lb")
            sb.AppendLine("supdbwin" & "," & .SupDBWin.ToString() & "," & "," & "temperature of supply air winter F")
            sb.AppendLine("supwbwin" & "," & .SupWBWin.ToString() & "," & "," & "wet bulb of supply air winter F")
            'sb.AppendLine("suphrwin" & "," & .SupHRWin.ToString() & "," & "," & "humidity ratio of supply air winter gr/lb")
            'sb.AppendLine("supRHwin" & "," & .SupRHWin.ToString() & "," & "," & "relative humidity of supply air winter %")
            'sb.AppendLine("supenthwin" & "," & .SupEnthWin.ToString() & "," & "," & "enthalpy of supply air winter Btu/lb")
            'sb.AppendLine("exhdbsum" & "," & .ExhDBSum.ToString() & "," & "," & "temperature of exhaust air summer F")
            'sb.AppendLine("exhwbsum" & "," & .ExhWBSum.ToString() & "," & "," & "wet bulb of exhaust air summer F")
            'sb.AppendLine("exhdbwin" & "," & .ExhDBWin.ToString() & "," & "," & "temperature of exhaust air winter F")
            'sb.AppendLine("exhwbwin" & "," & .ExhWBWin.ToString() & "," & "," & "wet bulb of exhaust air winter F")
            sb.AppendLine("supplyflow" & "," & .SupplyFlow.ToString() & "," & "," & "total flow to the building cfm")
            sb.AppendLine("returnflow" & "," & .ReturnFlow.ToString() & "," & "," & "total flow taken from the building cfm")
            sb.AppendLine("outdoorflow" & "," & .OutdoorFlow.ToString() & "," & "," & "total incoming fresh air flow cfm")
            sb.AppendLine("exhaustflow" & "," & .ExhaustFlow.ToString() & "," & "," & "total flow exhausted to outdoor cfm")
            sb.AppendLine("suppressdrop" & "," & .SupPressDrop.ToString() & "," & "," & "supply pressure drop in. wc")
            sb.AppendLine("exhpressdrop" & "," & .ExhPressDrop.ToString() & "," & "," & "supply pressure drop in. wc")
            'sb.AppendLine("fanpower" & "," & .FanPower.ToString() & "," & "," & "total fan electrical power kW")
            'sb.AppendLine("neteffsummer" & "," & .NetEffSummer.ToString() & "," & "," & "net effectiveness in summer")
            'sb.AppendLine("neteffwinter" & "," & .NetEffWinter.ToString() & "," & "," & "net effectiveness in winter")
            'sb.Append ("totaleffsummer" & "," & .toteffsum.to
            'sb.AppendLine("outdoorpressure" & "," & .OutdoorPressure.ToString() & "," & "," & "pressure in outdoor air plenum ''WC")
            'sb.AppendLine("supplypressure" & "," & .SupplyPressure.ToString() & "," & "," & "pressure in supply air plenum ''WC")
            'sb.AppendLine("exhaustpressure" & "," & .ExhaustPressure.ToString() & "," & "," & "pressure in exhaust air plenum ''WC")
            'sb.AppendLine("returnpressure" & "," & .ReturnPressure.ToString() & "," & "," & "pressure in return air plenum ''WC")
            'sb.AppendLine("oasensiblesum" & "," & .OASensSum.ToString() & "," & "," & "total sensible load summer")
            'sb.AppendLine("oalatentsum" & "," & .OALatentSum.ToString() & "," & "," & "total latent load summer")
            'sb.AppendLine("oatotalsum" & "," & .OATotalSum.ToString() & "," & "," & "total load summer")
            'sb.AppendLine("oarecoveredsum" & "," & .OARecoveredSum.ToString() & "," & "," & "recovered load summer")
            'sb.AppendLine("oarecoveredsensiblesum" & "," & .OARecoveredSensibleSum.ToString() & "," & "," & "recovered sensible energy summer Btuh")
            'sb.AppendLine("oarecoveredlatentsum" & "," & .OARecoveredLatentSum.ToString() & "," & "," & "recovered latent energy summer Btuh")
            'sb.AppendLine("oanetsum" & "," & .OANetSum.ToString() & "," & "," & "net load on space summer")
            'sb.AppendLine("oasensiblewin" & "," & .OASensibleWin.ToString() & "," & "," & "total sensible load winter")
            'sb.AppendLine("oalatentwin" & "," & .OALatentWin.ToString() & "," & "," & "total latent load winter")
            'sb.AppendLine("oatotalwin" & "," & .OATotalWin.ToString() & "," & "," & "total load winter")
            'sb.AppendLine("oarecoveredwin" & "," & .OARecoveredWin.ToString() & "," & "," & "recovered load winter")
            'sb.AppendLine("oarecoveredsensiblewin" & "," & .OARecoveredSensibleWin.ToString() & "," & "," & "recovered sensible energy winter Btuh")
            'sb.AppendLine("oarecoveredlatentwin" & "," & .OARecoveredLatentWin.ToString() & "," & "," & "recovered latent energy winter Btuh")
            'sb.AppendLine("oanetwin" & "," & .OANetWin.ToString() & "," & "," & "net load on space winter")
            'sb.AppendLine("preheattemp" & "," & .PreHeatTemp.ToString() & "," & "," & "control temperature for preheater F")
            'sb.AppendLine("preheatcapacity" & "," & .PreHeatCapacity.ToString() & "," & "," & "maximum delta-T of heater F")
            'sb.AppendLine("preheater" & "," & .PreHeater.ToString() & "," & "," & "installed capacity of prehater Btu/hr")

            'sb.AppendLine("allowedDP" & "," & .AllowedDP.ToString() & "," & "," & "allowable pressure loss through the wheel ''WC")
            'sb.AppendLine("tFrost" & "," & .TFrost.ToString() & "," & "," & "Frost threshold / Control Setpoint °F")

            'sb.AppendLine("purgeAngle" & "," & .PurgeAngle.ToString() & "," & "," & "purge angle in calculations degrees")
            'sb.AppendLine("erveer" & "," & .ErvEER.ToString() & "," & "," & "calculated EER of ERV")
            'sb.AppendLine("PercentOALoad" & "," & .PercentOALoad.ToString() & "," & "," & "percent of total laod due to OA")
            'sb.AppendLine("CombinedEER" & "," & .CombinedEER.ToString() & "," & "," & "combined EER of ERV and AC")

        End With
        Try
            Using outfile As New StreamWriter(mydocpath & "\" & FileName & ".csv")
                outfile.Write(sb.ToString())
            End Using
        Catch ex As Exception
            MsgBox("Error writing report.  Please check that file is closed", MsgBoxStyle.OkOnly, "Output Error")
        End Try
    End Sub
    Private Sub WriteCalcEER(o As CalculatedEER, fileName As String)
        Dim mydocpath As String = txtRptLoc.Text
        Dim sb As New StringBuilder

        With o
            sb.AppendLine("erveer" & "," & .ErvEER.ToString() & "," & "," & "calculated EER of ERV")
            sb.AppendLine("PercentOALoad" & "," & .PercentOALoad.ToString() & "," & "," & "percent of total laod due to OA")
            sb.AppendLine("CombinedEER" & "," & .CombinedEER.ToString() & "," & "," & "combined EER of ERV and AC")
            sb.AppendLine("oarecoveredsum" & "," & .OARecoveredSum.ToString())
        End With

        Try
            Using outfile As New StreamWriter(mydocpath & "\" & fileName & ".csv")
                outfile.Write(sb.ToString())
            End Using
        Catch ex As Exception
            MsgBox("Error writing report.  Please check that file is closed", MsgBoxStyle.OkOnly, "Output Error")
        End Try
    End Sub
    Private Sub WriteCalcOutputToFile(ByVal o As CalculatedOutputs, ByVal FileName As String)

        Dim mydocpath As String = txtRptLoc.Text
        Dim sb As New StringBuilder()

        With o
            sb.AppendLine("eatr" & "," & .EATR.ToString())
            sb.AppendLine("oacf" & "," & .OACF.ToString())
            sb.AppendLine("outdoorflow" & "," & .OutdoorFlow.ToString())
            sb.AppendLine("supplyflow" & "," & .SupplyFlow.ToString())
            sb.AppendLine("returnflow" & "," & .ReturnFlow.ToString())
            sb.AppendLine("exhaustflow" & "," & .ExhaustFlow.ToString())
            sb.AppendLine("fanpower" & "," & .FanPower.ToString())
            sb.AppendLine("allowedDP" & "," & .AllowedDP.ToString())
            sb.AppendLine("suppressdrop" & "," & .SupPressDrop.ToString())
            sb.AppendLine("exhpressdrop" & "," & .ExhPressDrop.ToString())
            sb.AppendLine("outdoorpressure" & "," & .OutdoorPressure.ToString())
            sb.AppendLine("supplypressure" & "," & .SupplyPressure.ToString())
            sb.AppendLine("exhaustpressure" & "," & .ExhaustPressure.ToString())
            sb.AppendLine("returnpressure" & "," & .ReturnPressure.ToString())
            'sb.AppendLine("AverageSupplyFlow" & "," & .AverageSupplyFlow.ToString())
            'sb.AppendLine("AverageExhaustFlow" & "," & .AverageExhaustFlow.ToString())
            sb.AppendLine("purgeAngle" & "," & .PurgeAngle.ToString())
            'sb.AppendLine("tFrost" & "," & .TFrost.ToString())
            sb.AppendLine("capacity" & "," & .Capacity.ToString())
            sb.AppendLine("preheattemp" & "," & .PreHeatTemp.ToString())
            sb.AppendLine("preheater" & "," & .PreHeater.ToString())
            sb.AppendLine("EnthSumO" & "," & .EnthSumO.ToString())
            sb.AppendLine("EnthSumI" & "," & .EnthSumI.ToString())
            sb.AppendLine("EnthWinO" & "," & .EnthWinO.ToString())
            sb.AppendLine("EnthWinI" & "," & .EnthWinI.ToString())
            sb.AppendLine("latenteff" & "," & .LatentEffectiveness.ToString())
            sb.AppendLine("senseff" & "," & .SensibleEffectiveness.ToString())
            sb.AppendLine("SupLatentEff" & "," & .SupLatentEffectiveness.ToString())
            sb.AppendLine("SupSensbileEff" & "," & .SupSensibleEffectiveness.ToString())
            sb.AppendLine("winterlatenteff" & "," & .WinterLatentEffectiveness.ToString())
            sb.AppendLine("wintersenseff" & "," & .WinterSensibleEffectiveness.ToString())
            sb.AppendLine("WinterSupLatentEff" & "," & .WinterSupLatentEffectiveness.ToString())
            sb.AppendLine("winterSupSensbileEff" & "," & .WinterSupSensibleEffectiveness.ToString())
            'sb.AppendLine("freshSCFM" & "," & .FreshSCFM.ToString())
            'sb.AppendLine("exhaustSCFM" & "," & .ExhaustSCFM.ToString())
            sb.AppendLine("dbsupSnet" & "," & .DBSupSNet.ToString())
            sb.AppendLine("hrsupSnet" & "," & .HRSupSNet.ToString())
            sb.AppendLine("enthsupSnet" & "," & .EnthSupSNet.ToString())
            sb.AppendLine("rhsupSnet" & "," & .RHSupSNet.ToString())
            sb.AppendLine("wbsupSnet" & "," & .WBSupSNet.ToString())
            sb.AppendLine("DbsupwNet" & "," & .DbsupwNet.ToString())
            sb.AppendLine("HrsupwNet" & "," & .HRsupwNet.ToString())
            sb.AppendLine("EnthsupwNet" & "," & .EnthsupwNet.ToString())
            sb.AppendLine("WBsupwNet" & "," & .WBsupwNet.ToString())
            sb.AppendLine("RHsupwNet" & "," & .RHsupwNet.ToString())
            sb.AppendLine("oarecoveredsensiblesum" & "," & .OARecoveredSensibleSum.ToString())
            sb.AppendLine("oarecoveredlatentsum" & "," & .OARecoveredLatentSum.ToString())
            sb.AppendLine("oasensiblesum" & "," & .OASensSum.ToString())
            sb.AppendLine("oalatentsum" & "," & .OALatentSum.ToString())
            sb.AppendLine("oatotalsum" & "," & .OATotalSum.ToString())
            sb.AppendLine("oanetsum" & "," & .OANetSum.ToString())
            sb.AppendLine("oarecoveredsum" & "," & .OARecoveredSum.ToString())
            sb.AppendLine("oarecoveredsensiblewin" & "," & .OARecoveredSensibleWin.ToString())
            sb.AppendLine("oarecoveredlatentwin" & "," & .OARecoveredLatentWin.ToString())
            sb.AppendLine("oasensiblewin" & "," & .OASensibleWin.ToString())
            sb.AppendLine("oalatentwin" & "," & .OALatentWin.ToString())
            sb.AppendLine("oatotalwin" & "," & .OATotalWin.ToString())
            sb.AppendLine("oarecoveredwin" & "," & .OARecoveredWin.ToString())
            sb.AppendLine("oanetwin" & "," & .OANetWin.ToString())
            'sb.AppendLine("neteffsummer" & "," & .NetEffSummer.ToString())
            'sb.AppendLine("neteffwinter" & "," & .NetEffWinter.ToString())
            sb.AppendLine("totaleffsummer" & "," & .TotalEffSummer.ToString())
            sb.AppendLine("totaleffwinter" & "," & .TotalEffWinter.ToString())
            sb.AppendLine("CLGSav" & "," & .CLGSav.ToString())
            sb.AppendLine("HTGSav" & "," & .HTGSav.ToString())
            sb.AppendLine("DbexhsNet" & "," & .DbexhsNet.ToString())
            sb.AppendLine("WbexhsNet" & "," & .WbexhsNet.ToString())
            sb.AppendLine("DbexhwNet" & "," & .DbexhwNet.ToString())
            sb.AppendLine("WbexhwNet" & "," & .WbexhwNet.ToString())
            sb.AppendLine("HrexhsNet" & "," & .HrexhsNet.ToString())
            sb.AppendLine("EnthexhsNet" & "," & .EnthexhsNet.ToString())
            sb.AppendLine("RhexhsNet" & "," & .RhexhsNet.ToString())
            sb.AppendLine("HrexhwNet" & "," & .HrexhwNet.ToString())
            sb.AppendLine("EnthexhwNet" & "," & .EnthexhwNet.ToString())
            sb.AppendLine("RhexhwNet" & "," & .RhexhwNet.ToString())
        End With

        Try
            Using outfile As New StreamWriter(mydocpath & "\" & FileName & ".csv")
                outfile.Write(sb.ToString())
            End Using
        Catch ex As Exception
            MsgBox("Error writing report.  Please check that file is closed", MsgBoxStyle.OkOnly, "Output Error")
        End Try
    End Sub
    Private Sub WriteBinDataToFile(ByVal b As BinEnergyData, ByVal FileName As String)

        'Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim mydocpath As String = txtRptLoc.Text

        Dim sb As New StringBuilder()
        Dim I As Integer

        sb.AppendLine()
        sb.AppendLine("DryBulb" & "," & "MCWB" & "," & "Annual Hours" & "," & "BinEnthalpy" & "," & "BinVentLoad" & "," &
                      "BinRecLoad" & "," & "BinNetLoad" & "," & "TotPreEnergy" & "," & "BinPreHeat")

        With b
            For I = 0 To .DryBulb.GetUpperBound(0) - 1
                sb.AppendLine(.DryBulb(I) & "," & .MCWB(I) & "," & .AnnualHours(I) & "," & .BinEnthalpy(I) & "," &
                              .BinVentLoad(I) & "," & .BinRecLoad(I) & "," & .BinNetLoad(I) & "," & .TotPreEnergy(I) & "," &
                              .BinPreheat(I))

            Next
            sb.AppendLine()
            sb.AppendLine("totalcoolinghours" & "," & .TotalCoolingHours.ToString())
            sb.AppendLine("totalheatinghours" & "," & .TotalHeatingHours.ToString())
            sb.AppendLine("totalcoolingload" & "," & .TotalCoolingLoad.ToString())
            sb.AppendLine("totalcoolingrecovered" & "," & .TotalCoolingRecovered.ToString())
            sb.AppendLine("totalnetcoolingload" & "," & .TotalNetCoolingLoad.ToString())
            sb.AppendLine("totalheatingload" & "," & .TotalHeatingLoad.ToString())
            sb.AppendLine("totalheatingrecovered" & "," & .TotalHeatingRecovered.ToString())
            sb.AppendLine("TotalNetHeatingLoad" & "," & .TotalNetHeatingLoad.ToString())
            sb.AppendLine("TotalPreheat" & "," & .TotalPreheat.ToString())
            sb.AppendLine("TotalFanKWH" & "," & .TotalFanKWH.ToString())

            sb.AppendLine("CoolingEnergySaved" & "," & .RecCostC.ToString())
            sb.AppendLine("CoolingDollarsSaved" & "," & .CoolingDollarsSaved)
            sb.AppendLine("HeatingEnergySaved" & "," & .RecCostH.ToString())
            sb.AppendLine("HeatingDollarsSaved" & "," & .HeatingDollarsSaved)
            sb.AppendLine("FanDollarsSpent" & "," & .FanDollarsSpent.ToString())
            sb.AppendLine("NetAnnualDollarSavings" & "," & .NetAnnualSavings.ToString())
            sb.AppendLine("Factor" & "," & .Factor.ToString())
        End With

        Try
            Using outfile As New StreamWriter(mydocpath & "\" & FileName & ".csv")
                outfile.Write(sb.ToString())
            End Using
        Catch ex As Exception
            MsgBox("Error writing report.  Please check that file is closed", MsgBoxStyle.OkOnly, "Output Error")
        End Try



    End Sub



    Private Sub btnMainCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainCalc.Click
        Dim airXInput As New AirXInputs

        If chkPrintRpts.Checked And txtRptLoc.Text = "" Then
            MessageBox.Show("In order to print reports a location must be specified.  Please enter a folder to save reports to")
            Exit Sub
        End If
        If ddlModel.Text = "" Then
            MessageBox.Show("Please select a model before calculating")
            Return

        End If
        With airXInput

            .Sensible = chkSensibleOnly.Checked

            'Full path to the AirXDLL configuration files
            .ConfigFileLocation = txtFileLoc.Text
            .dbLocation = txtFileLoc.Text
            'AirXchange model for the cassette.
            .Model = ddlModel.Text

            'Flow and psychrometric values
            .Elevation = CInt(txtElev.Text)
            .FreshFlow = CInt(txtFreshFlow.Text)
            .OutFlow = CInt(txtOutFlow.Text)

            .OutDBSum = CInt(txtOutDBSum.Text)
            .OutWBSum = CInt(txtOutWBSum.Text)
            .InDBSum = CInt(txtInDBSum.Text)
            .InWBSum = CInt(txtInWBSum.Text)

            .OutDBWin = CInt(txtOutDBWin.Text)
            .OutWBWin = CInt(txtOutWBWin.Text)
            .InDBWin = CInt(txtInDBWin.Text)
            .InWBWin = CInt(txtInWBWin.Text)

            'plenum static pressures
            .SSPress = CDbl(txtSSPress.Text)
            .ESPress = CDbl(txtESPressure.Text)


            .PurgeAngle = CInt(txtPurgeAngle.Text)

            'should AirXDLL calculate the purge angle?
            If rbCalcPurge.Checked Then
                .CalcPurge = True
            Else : .CalcPurge = False
            End If


            'if AirXDLL will calculate purge angle a minimum EATR must be provided
            .TargetEATR = CDbl(txtPurgeAngle.Text)

            'static pressure plenum identifiers
            .SSPresT = txtSSPressT.Text
            .ESPresT = txtESPressT.Text

            'number of wheels
            .Wheels = CInt(txtWheels.Text)

            'fan efficiency used in the energy calculations
            .FanEff = CDbl(txtFanEff.Text)

            'location for bin energy calculations
            .City = ddlCity.Text
            .State = ddlState.Text
            .Region = ddlRegion.Text
            .FileName = fileName
            'indicate which week days schedule should be used.
            '.DaysIndex = CInt(txtDaysIndex.Text)

            'indicate which months should be included in bin energy calculations
            .January = chkJan.Checked
            .February = chkFeb.Checked
            .March = chkMarch.Checked
            .April = chkApr.Checked
            .May = chkMay.Checked
            .June = chkJune.Checked
            .July = chkJuly.Checked
            .August = chkAug.Checked
            .September = chkSept.Checked
            .October = chkOct.Checked
            .November = chkNov.Checked
            .December = chkDec.Checked
            .Months = ""
            If chkJan.Checked Then
                .Months += "1"
            Else : .Months += "0"
            End If
            If chkFeb.Checked Then
                .Months += "1"
            Else : .Months += "0"
            End If
            If chkMarch.Checked Then
                .Months += "1"
            Else : .Months += "0"
            End If
            If chkApr.Checked Then
                .Months += "1"
            Else : .Months += "0"
            End If
            If chkMay.Checked Then
                .Months += "1"
            Else : .Months += "0"
            End If
            If chkJune.Checked Then
                .Months += "1"
            Else : .Months += "0"
            End If
            If chkJuly.Checked Then
                .Months += "1"
            Else : .Months += "0"
            End If
            If chkAug.Checked Then
                .Months += "1"
            Else : .Months += "0"
            End If
            If chkSept.Checked Then
                .Months += "1"
            Else : .Months += "0"
            End If
            If chkOct.Checked Then
                .Months += "1"
            Else : .Months += "0"
            End If
            If chkNov.Checked Then
                .Months += "1"
            Else : .Months += "0"
            End If
            If chkDec.Checked Then
                .Months += "1"
            Else : .Months += "0"
            End If

            If chkAllHours.Checked Then
                .Sunday = "111111111111111111111111"
                .Monday = "111111111111111111111111"
                .Tuesday = "111111111111111111111111"
                .Wednessday = "111111111111111111111111"
                .Thursday = "111111111111111111111111"
                .Friday = "111111111111111111111111"
                .Saturday = "111111111111111111111111"
            Else
                .Sunday = txtSun.Text
                .Monday = txtMon.Text
                .Tuesday = txtTues.Text
                .Wednessday = txtWed.Text
                .Thursday = txtThurs.Text
                .Friday = txtFri.Text
                .Saturday = txtSat.Text
            End If
            'daily periods to be included in bin energy calculations
            '.Period1 = chkPeriod1.Checked
            '.Period2 = chkPeriod2.Checked
            '.Period3 = chkPeriod3.Checked
            '.Period4 = chkPeriod4.Checked
            '.Period5 = chkPeriod5.Checked
            '.Period6 = chkPeriod6.Checked

            .HeatingIndex = CInt(txtHeatIndex.Text)
            .HeatingEfficiency = CDbl(txtHeatEff.Text)
            .CoolingEER = CDbl(txtSumEER.Text)
            .HeatingCOP = CDbl(txtHeatCOP.Text)
            .FuelCost = CDbl(txtFuelCost.Text)
            .WinterElecCost = CDbl(txtWinElecCost.Text)
            .SummerElecCost = CDbl(txtSumElecCost.Text)
            .SummerDemandCost = CDbl(txtSumDemandCost.Text)

            'time of day electrical rate inputs
            '.TOD = chkTOD.Checked
            '.TOD0 = CDbl(txtTOD0.Text)
            '.TOD1 = CDbl(txtTOD1.Text)
            '.TOD2 = CDbl(txtTOD2.Text)
            '.TOD3 = CDbl(txtTOD3.Text)
            '.TOD4 = CDbl(txtTOD4.Text)
            '.TOD5 = CDbl(txtTOD5.Text)

            'inputs for combined EER calculation
            .RTUcapacity = CInt(txtRTUCapacity.Text)
            .RTUeer = CDbl(txtEER.Text)

            .FrostControl = CInt(txtFrostControl.Text)

        End With



        'create output objects 
        Dim binData As New BinEnergyData
        Dim errs As New List(Of ErrFlags)
        Dim outobj As New AirXOutputs
        Dim result As Boolean

        Dim calcFuncs As New Calculate


        Me.Cursor = Cursors.WaitCursor

        'call the maincalc function
        result = calcFuncs.MainCalc(airXInput, outobj, binData, errs)

        '--------------------------------------------
        'these functions are used to write results to text files and are not needed for use of the DLL
        MessageBox.Show("Calculations Complete")
        If chkPrintRpts.Checked Then
            MessageBox.Show("Printing report")
            WriteBinDataToFile(binData, "BinData")
            WriteAirXOutputToFile(outobj, "AirXOutputs")
            WriteAirXErrsToFile(errs, "AirXErrs")
            '--------------------------------------------
        End If

        Me.Cursor = Cursors.Default

    End Sub



    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim utilityFuncs As New UtilityFunctions
        'Me.Cursor = Cursors.WaitCursor
        'Dim input As New AirXInputs
        'With input
        '    .ConfigFileLocation = txtFileLoc.Text
        'End With
        'Try
        '    Dim ret As Boolean = utilityFuncs.DoUpdate(input)
        '    Me.Cursor = Cursors.Default
        '    If ret Then
        '        MessageBox.Show("Update Complete")
        '    Else : MessageBox.Show("Error occured during update")
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Error occured durring update. Ex=" + ex.Message)
        'End Try


    End Sub

    Private Sub rbSetPurge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSetPurge.CheckedChanged
        If rbSetPurge.Checked = True Then
            lblPurge.Text = "Purge Angle"
        Else : lblPurge.Text = "Allowable EATR"
        End If
    End Sub

    Private Sub ddlState_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlState.SelectedIndexChanged

        ddlCity.Items.Clear()
        ddlCity.SelectedIndex = -1
        Dim SortedArray As New ArrayList(50)


        'get cities from db
        Dim dbFuncs As New AirXDLL.AirXWeatherDBFunctions
        Dim cityList As New List(Of String)
        cityList = dbFuncs.GetCities(ddlRegion.Text, ddlCountry.Text, ddlState.Text, txtFileLoc.Text)
        If cityList.Count = 0 Then
            MessageBox.Show("Error getting city names")
        End If
        For Each c As String In cityList
            ddlCity.Items.Add(c)
        Next

        ddlCity.SelectedIndex = 0

    End Sub

    Private Sub ddlCity_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlCity.SelectedIndexChanged
        Dim weatherData As AirXDLL.WeatherDesignData
        Dim weatherFuncs As New AirXDLL.AirXWeatherDBFunctions
        weatherData = weatherFuncs.GetWeatherDesignData(ddlRegion.Text, ddlCountry.Text,
                                                        ddlState.Text, ddlCity.Text, txtFileLoc.Text)


        Dim summerDBIndoor As Double
        Dim summerWBIndoor As Double

        If weatherData.DB04 >= 75 Then
            summerDBIndoor = 75
        Else
            summerDBIndoor = 72

        End If


        txtElev.Text = weatherData.Elev.ToString

        Psychrometrics.SetAirProperties(txtElev.Text)

        Dim AirPressure As Double = Psychrometrics.AirPressure

        Dim HR As Double = Psychrometrics.WetBulbHR(weatherData.DB04, weatherData.MCWB04, CDbl(txtElev.Text))
        If HR >= Psychrometrics.WetBulbHR(75, 63, CDbl(txtElev.Text)) Then
            summerWBIndoor = 63
        Else
            Dim h As Double = Psychrometrics.Enthalpy(weatherData.DB04, HR)
            summerWBIndoor = Psychrometrics.WetBulbTemp(summerDBIndoor, h, 63, AirPressure)
        End If


        Dim WinterDBIndoor As Double = Math.Min(72, summerDBIndoor)



        txtOutDBSum.Text = weatherData.DB04.ToString("#.0")
        txtOutWBSum.Text = weatherData.MCWB04.ToString("#.0")
        txtInDBSum.Text = summerDBIndoor.ToString("#.0")
        txtInWBSum.Text = summerWBIndoor.ToString("#.0")
        txtOutDBWin.Text = weatherData.DB996.ToString("#.0")
        txtOutWBWin.Text = weatherData.MCWB996.ToString("#.0")
        txtInDBWin.Text = WinterDBIndoor.ToString("#.0")
        txtInWBWin.Text = "54.0"

        fileName = weatherData.FileName


    End Sub

    Private Sub txtFileLoc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFileLoc.TextChanged
        'ddlCity.Items.Clear()
        'ddlState.Items.Clear()
        'ddlModel.Items.Clear()

        'ddlCity.Text = ""
        'ddlState.Text = ""
        'ddlModel.Text = ""


        'Dim utiltityFuncs As New UtilityFunctions
        'If Directory.Exists(txtFileLoc.Text) Then
        '    cityCollection = utiltityFuncs.GetCities(txtFileLoc.Text)
        '    PopulateStateDDL(cityCollection)
        '    PopulateModelsDDL()
        'End If

    End Sub

    Private Sub btnRptLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRptLocation.Click
        folderDialog.RootFolder = Environment.SpecialFolder.MyDocuments
        folderDialog.Description = "Select a Folder"
        Dim dlgResult As DialogResult = folderDialog.ShowDialog()
        If dlgResult = Windows.Forms.DialogResult.OK Then
            txtRptLoc.Text = folderDialog.SelectedPath
        End If
    End Sub

    Private Sub btnCalcOutputs_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcOutputs.Click
        Dim funcInputs As New FunctionDLLInputs
        Dim calcFuncs As New Calculate
        Dim errs As New List(Of AirXDLL.ErrFlags)

        If ddlModel.Text = "" Then
            MessageBox.Show("Please select a model before calculating")
            Return
        End If
        If chkPrintRpts.Checked And txtRptLoc.Text = "" Then
            MessageBox.Show("In order to print reports a location must be specified.  Please enter a folder to save reports to")
            Exit Sub
        End If
        funcInputs.ConfigFileLocation = txtFileLoc.Text
        funcInputs.FanEff = CDbl(txtFanEff.Text)
        'plenum static pressures
        funcInputs.UnitPressures = New UnitPressures


        funcInputs.UnitPressures.SSPress = CDbl(txtSSPress.Text)
        funcInputs.UnitPressures.ESPress = CDbl(txtESPressure.Text)
        funcInputs.UnitPressures.SSPresT = txtSSPressT.Text
        funcInputs.UnitPressures.ESPresT = txtESPressT.Text

        funcInputs.AirFlows = New AirFlows

        funcInputs.AirFlows.FreshFlow = CDbl(txtFreshFlow.Text)
        funcInputs.AirFlows.OutFlow = CDbl(txtOutFlow.Text)
        funcInputs.Location = New Location
        funcInputs.Location.Elevation = CInt(txtElev.Text)
        funcInputs.ModelParam = New ModelParams
        funcInputs.ModelParam.Model = ddlModel.Text
        funcInputs.ModelParam.Wheels = CDbl(txtWheels.Text)

        'If CDbl(txtPurgeAngle.Text) > 0 Or rbCalcPurge.Checked = True Then
        '    funcInputs.ModelParam.HasPurge = True
        '    funcInputs.ModelParam.PurgeAngle = CDbl(txtPurgeAngle.Text)
        '    funcInputs.ModelParam.TargetEATR = CDbl(txtPurgeAngle.Text)
        'Else : funcInputs.ModelParam.HasPurge = False
        'End If
        If rbCalcPurge.Checked = True Then
            funcInputs.ModelParam.HasPurge = False
        Else
            funcInputs.ModelParam.HasPurge = True
        End If

        funcInputs.ModelParam.PurgeAngle = CDbl(txtPurgeAngle.Text)
        funcInputs.ModelParam.TargetEATR = CDbl(txtPurgeAngle.Text)
        funcInputs.ModelParam.Sensible = chkSensibleOnly.Checked

        funcInputs.AirInlet = New AirInlets
        funcInputs.AirInlet.OutDBSum = CInt(txtOutDBSum.Text)
        funcInputs.AirInlet.OutWBSum = CInt(txtOutWBSum.Text)
        funcInputs.AirInlet.InDBSum = CInt(txtInDBSum.Text)
        funcInputs.AirInlet.InWBSum = CInt(txtInWBSum.Text)

        funcInputs.AirInlet.OutDBWin = CInt(txtOutDBWin.Text)
        funcInputs.AirInlet.OutWBWin = CInt(txtOutWBWin.Text)
        funcInputs.AirInlet.InDBWin = CInt(txtInDBWin.Text)
        funcInputs.AirInlet.InWBWin = CInt(txtInWBWin.Text)


        Me.Cursor = Cursors.WaitCursor
        calcFuncs.CalculateOutputs(funcInputs, calcOutputs, errs)
        MessageBox.Show("Calculations Complete")
        If chkPrintRpts.Checked Then
            MessageBox.Show("Printing Report")
            WriteCalcOutputToFile(calcOutputs, "AirxCalculatedOutputs")
            WriteAirXErrsToFile(errs, "AirXErrs")
        End If

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub BtnCalcEnergy_Click(sender As System.Object, e As System.EventArgs) Handles BtnCalcEnergy.Click
        Dim funcInputs As New FunctionDLLInputs
        Dim calcFuncs As New Calculate
        Dim errs As New List(Of AirXDLL.ErrFlags)

        If ddlModel.Text = "" Then
            MessageBox.Show("Please select a model before calculating")
            Return
        End If
        If chkPrintRpts.Checked And txtRptLoc.Text = "" Then
            MessageBox.Show("In order to print reports a location must be specified.  Please enter a folder to save reports to")
            Exit Sub
        End If

        funcInputs.ConfigFileLocation = txtFileLoc.Text
        'indicate which week days schedule should be used.
        'funcInputs.DaysIndex = CInt(txtDaysIndex.Text)



        funcInputs.Location = New Location
        funcInputs.Location.City = ddlCity.Text
        funcInputs.Location.State = ddlState.Text
        funcInputs.Location.Elevation = CInt(txtElev.Text)

        funcInputs.ModelParam = New ModelParams
        funcInputs.ModelParam.Model = ddlModel.Text

        funcInputs.AirInlet = New AirInlets
        funcInputs.AirInlet.OutDBSum = CInt(txtOutDBSum.Text)
        funcInputs.AirInlet.OutWBSum = CInt(txtOutWBSum.Text)
        funcInputs.AirInlet.InDBSum = CInt(txtInDBSum.Text)
        funcInputs.AirInlet.InWBSum = CInt(txtInWBSum.Text)

        funcInputs.AirInlet.OutDBWin = CInt(txtOutDBWin.Text)
        funcInputs.AirInlet.OutWBWin = CInt(txtOutWBWin.Text)
        funcInputs.AirInlet.InDBWin = CInt(txtInDBWin.Text)
        funcInputs.AirInlet.InWBWin = CInt(txtInWBWin.Text)

        'indicate which months should be included in bin energy calculations
        funcInputs.OpMonth = New OperationMonth
        funcInputs.OpMonth.January = chkJan.Checked
        funcInputs.OpMonth.February = chkFeb.Checked
        funcInputs.OpMonth.March = chkMarch.Checked
        funcInputs.OpMonth.April = chkApr.Checked
        funcInputs.OpMonth.May = chkMay.Checked
        funcInputs.OpMonth.June = chkJune.Checked
        funcInputs.OpMonth.July = chkJuly.Checked
        funcInputs.OpMonth.August = chkAug.Checked
        funcInputs.OpMonth.September = chkSept.Checked
        funcInputs.OpMonth.October = chkOct.Checked
        funcInputs.OpMonth.November = chkNov.Checked
        funcInputs.OpMonth.December = chkDec.Checked

        'daily periods to be included in bin energy calculations
        funcInputs.OpPeriod = New OperationPeriod
        'funcInputs.OpPeriod.Period1 = chkPeriod1.Checked
        'funcInputs.OpPeriod.Period2 = chkPeriod2.Checked
        'funcInputs.OpPeriod.Period3 = chkPeriod3.Checked
        'funcInputs.OpPeriod.Period4 = chkPeriod4.Checked
        'funcInputs.OpPeriod.Period5 = chkPeriod5.Checked
        'funcInputs.OpPeriod.Period6 = chkPeriod6.Checked

        'time of day electrical rate inputs
        funcInputs.TODPrice = New TimeOfDayPrice
        funcInputs.TODPrice.TOD = chkTOD.Checked
        funcInputs.TODPrice.TOD0 = CDbl(txtTOD0.Text)
        funcInputs.TODPrice.TOD1 = CDbl(txtTOD1.Text)
        funcInputs.TODPrice.TOD2 = CDbl(txtTOD2.Text)
        funcInputs.TODPrice.TOD3 = CDbl(txtTOD3.Text)
        funcInputs.TODPrice.TOD4 = CDbl(txtTOD4.Text)
        funcInputs.TODPrice.TOD5 = CDbl(txtTOD5.Text)

        funcInputs.EnergyCost = New EnergyCosts
        funcInputs.EnergyCost.HeatingIndex = CInt(txtHeatIndex.Text)
        funcInputs.EnergyCost.HeatingEfficiency = CDbl(txtHeatEff.Text)
        funcInputs.EnergyCost.CoolingEER = CDbl(txtSumEER.Text)
        'funcInputs.EnergyCost.HeatingCOP = CDbl(txtHeatCOP.Text)
        funcInputs.EnergyCost.FuelCost = CDbl(txtFuelCost.Text)
        funcInputs.EnergyCost.WinterElecCost = CDbl(txtWinElecCost.Text)
        funcInputs.EnergyCost.SummerElecCost = CDbl(txtSumElecCost.Text)
        funcInputs.EnergyCost.SummerDemandCost = CDbl(txtSumDemandCost.Text)


        Me.Cursor = Cursors.WaitCursor


        funcInputs.FanEff = CDbl(txtFanEff.Text)
        'plenum static pressures
        funcInputs.UnitPressures = New UnitPressures
        funcInputs.UnitPressures.SSPress = CDbl(txtSSPress.Text)
        funcInputs.UnitPressures.ESPress = CDbl(txtESPressure.Text)
        funcInputs.UnitPressures.SSPresT = txtSSPressT.Text
        funcInputs.UnitPressures.ESPresT = txtESPressT.Text

        funcInputs.AirFlows = New AirFlows

        funcInputs.AirFlows.FreshFlow = CDbl(txtFreshFlow.Text)
        funcInputs.AirFlows.OutFlow = CDbl(txtOutFlow.Text)


        If rbCalcPurge.Checked = True Then
            funcInputs.ModelParam.HasPurge = False
        Else
            funcInputs.ModelParam.HasPurge = True
        End If

        funcInputs.ModelParam.PurgeAngle = CDbl(txtPurgeAngle.Text)
        funcInputs.ModelParam.TargetEATR = CDbl(txtPurgeAngle.Text)
        funcInputs.ModelParam.Sensible = chkSensibleOnly.Checked
        funcInputs.ModelParam.Wheels = 1

        calcFuncs.CalculateOutputs(funcInputs, calcOutputs, errs) 'need to call this first to get values needed for binning

        funcInputs.CalcOutputs = calcOutputs
        funcInputs.DBFileLocation = txtFileLoc.Text

        Dim binerr As String = ""
        funcInputs.BinData = GetBins(funcInputs.CalcOutputs, funcInputs.DBFileLocation, funcInputs.TotalHours, binerr)

        If binerr <> "" Then
            'error occured
            MessageBox.Show(binerr)
            Me.Cursor = Cursors.Default
            Return
        End If
        Dim binData As New BinEnergyData
        calcFuncs.CalculateEnergyNewBins(funcInputs, binEnData, errs)
        MessageBox.Show("Calculations Complete")
        If chkPrintRpts.Checked Then
            MessageBox.Show("Printing Report")
            WriteBinDataToFile(binEnData, "BinCalcEnergy")
        End If

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub btnCalcEco_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcEco.Click
        Dim funcInputs As New FunctionDLLInputs
        Dim calcFuncs As New Calculate
        Dim errs As New List(Of AirXDLL.ErrFlags)

        If ddlModel.Text = "" Then
            MessageBox.Show("Please select a model before calculating")
            Return

        End If
        If chkPrintRpts.Checked And txtRptLoc.Text = "" Then
            MessageBox.Show("In order to print reports a location must be specified.  Please enter a folder to save reports to")
            Exit Sub
        End If

        funcInputs.ConfigFileLocation = txtFileLoc.Text
        'indicate which week days schedule should be used.
        'funcInputs.DaysIndex = CInt(txtDaysIndex.Text)



        funcInputs.Location = New Location
        funcInputs.Location.City = ddlCity.Text
        funcInputs.Location.State = ddlState.Text
        funcInputs.Location.Elevation = CInt(txtElev.Text)

        funcInputs.ModelParam = New ModelParams
        funcInputs.ModelParam.Model = ddlModel.Text
        funcInputs.ModelParam.Wheels = 1

        funcInputs.AirInlet = New AirInlets
        funcInputs.AirInlet.OutDBSum = CInt(txtOutDBSum.Text)
        funcInputs.AirInlet.OutWBSum = CInt(txtOutWBSum.Text)
        funcInputs.AirInlet.InDBSum = CInt(txtInDBSum.Text)
        funcInputs.AirInlet.InWBSum = CInt(txtInWBSum.Text)

        funcInputs.AirInlet.OutDBWin = CInt(txtOutDBWin.Text)
        funcInputs.AirInlet.OutWBWin = CInt(txtOutWBWin.Text)
        funcInputs.AirInlet.InDBWin = CInt(txtInDBWin.Text)
        funcInputs.AirInlet.InWBWin = CInt(txtInWBWin.Text)

        funcInputs.CalcEnergy = New CalculatedEnergy
        funcInputs.CalcEnergy.BinPreHeat = binEnData.BinPreheat

        'indicate which months should be included in bin energy calculations
        funcInputs.OpMonth = New OperationMonth
        funcInputs.OpMonth.January = chkJan.Checked
        funcInputs.OpMonth.February = chkFeb.Checked
        funcInputs.OpMonth.March = chkMarch.Checked
        funcInputs.OpMonth.April = chkApr.Checked
        funcInputs.OpMonth.May = chkMay.Checked
        funcInputs.OpMonth.June = chkJune.Checked
        funcInputs.OpMonth.July = chkJuly.Checked
        funcInputs.OpMonth.August = chkAug.Checked
        funcInputs.OpMonth.September = chkSept.Checked
        funcInputs.OpMonth.October = chkOct.Checked
        funcInputs.OpMonth.November = chkNov.Checked
        funcInputs.OpMonth.December = chkDec.Checked

        'daily periods to be included in bin energy calculations
        'funcInputs.OpPeriod = New OperationPeriod
        'funcInputs.OpPeriod.Period1 = chkPeriod1.Checked
        'funcInputs.OpPeriod.Period2 = chkPeriod2.Checked
        'funcInputs.OpPeriod.Period3 = chkPeriod3.Checked
        'funcInputs.OpPeriod.Period4 = chkPeriod4.Checked
        'funcInputs.OpPeriod.Period5 = chkPeriod5.Checked
        'funcInputs.OpPeriod.Period6 = chkPeriod6.Checked

        'time of day electrical rate inputs
        funcInputs.TODPrice = New TimeOfDayPrice
        funcInputs.TODPrice.TOD = chkTOD.Checked
        funcInputs.TODPrice.TOD0 = CDbl(txtTOD0.Text)
        funcInputs.TODPrice.TOD1 = CDbl(txtTOD1.Text)
        funcInputs.TODPrice.TOD2 = CDbl(txtTOD2.Text)
        funcInputs.TODPrice.TOD3 = CDbl(txtTOD3.Text)
        funcInputs.TODPrice.TOD4 = CDbl(txtTOD4.Text)
        funcInputs.TODPrice.TOD5 = CDbl(txtTOD5.Text)

        funcInputs.EnergyCost = New EnergyCosts
        funcInputs.EnergyCost.HeatingIndex = CInt(txtHeatIndex.Text)
        funcInputs.EnergyCost.HeatingEfficiency = CDbl(txtHeatEff.Text)
        funcInputs.EnergyCost.CoolingEER = CDbl(txtSumEER.Text)
        'funcInputs.EnergyCost.HeatingCOP = CDbl(txtHeatCOP.Text)
        funcInputs.EnergyCost.FuelCost = CDbl(txtFuelCost.Text)
        funcInputs.EnergyCost.WinterElecCost = CDbl(txtWinElecCost.Text)
        funcInputs.EnergyCost.SummerElecCost = CDbl(txtSumElecCost.Text)
        funcInputs.EnergyCost.SummerDemandCost = CDbl(txtSumDemandCost.Text)


        Me.Cursor = Cursors.WaitCursor

        funcInputs.FanEff = CDbl(txtFanEff.Text)
        'plenum static pressures
        funcInputs.UnitPressures = New UnitPressures
        funcInputs.UnitPressures.SSPress = CDbl(txtSSPress.Text)
        funcInputs.UnitPressures.ESPress = CDbl(txtESPressure.Text)
        funcInputs.UnitPressures.SSPresT = txtSSPressT.Text
        funcInputs.UnitPressures.ESPresT = txtESPressT.Text

        funcInputs.AirFlows = New AirFlows

        funcInputs.AirFlows.FreshFlow = CDbl(txtFreshFlow.Text)
        funcInputs.AirFlows.OutFlow = CDbl(txtOutFlow.Text)


        If rbCalcPurge.Checked = True Then
            funcInputs.ModelParam.HasPurge = False
        Else
            funcInputs.ModelParam.HasPurge = True
        End If

        funcInputs.ModelParam.PurgeAngle = CDbl(txtPurgeAngle.Text)
        funcInputs.ModelParam.TargetEATR = CDbl(txtPurgeAngle.Text)
        funcInputs.ModelParam.Sensible = chkSensibleOnly.Checked

        calcFuncs.CalculateOutputs(funcInputs, calcOutputs, errs) 'need to call this first to get values needed for binning

        funcInputs.CalcOutputs = calcOutputs
        funcInputs.DBFileLocation = txtFileLoc.Text
        Dim binerr As String = ""
        funcInputs.BinData = GetBins(funcInputs.CalcOutputs, funcInputs.DBFileLocation, funcInputs.TotalHours, binerr)

        If binerr <> "" Then
            'error occured
            MessageBox.Show(binerr)
            Me.Cursor = Cursors.Default
            Return
        End If
        funcInputs.CalcOutputs = calcOutputs


        Dim binData As New BinEnergyData
        calcFuncs.CalculateEconomicsNewBins(funcInputs, binData, errs)
        Me.Cursor = Cursors.Default
        MessageBox.Show("Calculations Complete")
        If chkPrintRpts.Checked Then
            MessageBox.Show("Printing Report")
            WriteBinDataToFile(binData, "BinCalcEco")
        End If


    End Sub

    Private Sub btnCalcEER_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcEER.Click
        Dim funcInputs As New FunctionDLLInputs
        Dim calcFuncs As New Calculate
        Dim errs As New List(Of AirXDLL.ErrFlags)

        If ddlModel.Text = "" Then
            MessageBox.Show("Please select a model before calculating")
            Return
        End If
        If chkPrintRpts.Checked And txtRptLoc.Text = "" Then
            MessageBox.Show("In order to print reports a location must be specified.  Please enter a folder to save reports to")
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        funcInputs.Location = New Location
        funcInputs.Location.City = ddlCity.Text
        funcInputs.Location.State = ddlState.Text
        funcInputs.Location.Elevation = CInt(txtElev.Text)

        funcInputs.ModelParam = New ModelParams
        funcInputs.ModelParam.Wheels = txtWheels.Text

        funcInputs.AirInlet = New AirInlets
        funcInputs.AirInlet.OutDBSum = CInt(txtOutDBSum.Text)
        funcInputs.AirInlet.OutWBSum = CInt(txtOutWBSum.Text)
        funcInputs.AirInlet.InDBSum = CInt(txtInDBSum.Text)
        funcInputs.AirInlet.InWBSum = CInt(txtInWBSum.Text)

        funcInputs.AirInlet.OutDBWin = CInt(txtOutDBWin.Text)
        funcInputs.AirInlet.OutWBWin = CInt(txtOutWBWin.Text)
        funcInputs.AirInlet.InDBWin = CInt(txtInDBWin.Text)
        funcInputs.AirInlet.InWBWin = CInt(txtInWBWin.Text)

        funcInputs.CalcOutputs = calcOutputs

        funcInputs.RTU = New RTU
        funcInputs.RTU.RTUcapacity = txtRTUCapacity.Text
        funcInputs.RTU.RTUeer = txtEER.Text


        Dim calcEER As New CalculatedEER
        calcFuncs.CalculateEER(funcInputs, calcEER, errs)
        MessageBox.Show("Calculations Complete")
        If chkPrintRpts.Checked Then
            MessageBox.Show("Printing Report")
            WriteCalcEER(calcEER, "AirXCalcEER")
        End If

        Me.Cursor = Cursors.Default

    End Sub


    Private Sub cboRegion_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlRegion.SelectedIndexChanged
        ddlCountry.Items.Clear()
        ddlCountry.SelectedIndex = -1
        Dim SortedArray As New ArrayList(50)
        'get countries from db
        Dim dbFuncs As New AirXDLL.AirXWeatherDBFunctions
        Dim countryList As New List(Of String)
        countryList = dbFuncs.GetCountries(ddlRegion.Text, txtFileLoc.Text)
        If countryList.Count = 0 Then
            MessageBox.Show("Error getting country names")
            Return
        End If
        For Each c As String In countryList
            ddlCountry.Items.Add(c)
        Next

        ddlCountry.SelectedIndex = 0
    End Sub


    Private Sub ddlCountry_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlCountry.SelectedIndexChanged
        ddlState.Items.Clear()
        ddlState.SelectedIndex = -1
        Dim dbFuncs As New AirXDLL.AirXWeatherDBFunctions
        Dim stateList As New List(Of String)
        stateList = dbFuncs.GetStates(ddlRegion.Text, ddlCountry.Text, txtFileLoc.Text)
        If stateList.Count = 0 Then
            MessageBox.Show("Error getting state names")
        End If
        For Each c As String In stateList
            ddlState.Items.Add(c)
        Next

        ddlState.SelectedIndex = 0
    End Sub
    Private Function GetBins(outputs As AirXDLL.CalculatedOutputs, dbLocation As String, ByRef totalHours As Integer, ByRef err As String) As List(Of AirXDLL.BinData)

        Application.DoEvents()
        'get all data 
        'Dim hourList As New List(Of AIRXData.HourData)

        Dim dbFuncs As New AirXDLL.AirXWeatherDBFunctions
        Dim HourMonthBinDataList As New List(Of AirXDLL.HourData)
        Dim binDataList As New List(Of AirXDLL.BinData)

        Dim strMonths As String = ""
        If chkJan.Checked Then
            strMonths += "1"
        Else : strMonths += "0"
        End If
        If chkFeb.Checked Then
            strMonths += "1"
        Else : strMonths += "0"
        End If
        If chkMarch.Checked Then
            strMonths += "1"
        Else : strMonths += "0"
        End If
        If chkApr.Checked Then
            strMonths += "1"
        Else : strMonths += "0"
        End If
        If chkMay.Checked Then
            strMonths += "1"
        Else : strMonths += "0"
        End If
        If chkJune.Checked Then
            strMonths += "1"
        Else : strMonths += "0"
        End If
        If chkJuly.Checked Then
            strMonths += "1"
        Else : strMonths += "0"
        End If
        If chkAug.Checked Then
            strMonths += "1"
        Else : strMonths += "0"
        End If
        If chkSept.Checked Then
            strMonths += "1"
        Else : strMonths += "0"
        End If
        If chkOct.Checked Then
            strMonths += "1"
        Else : strMonths += "0"
        End If
        If chkNov.Checked Then
            strMonths += "1"
        Else : strMonths += "0"
        End If
        If chkDec.Checked Then
            strMonths += "1"
        Else : strMonths += "0"
        End If

        Dim Sunday As String
        Dim Monday As String
        Dim Tuesday As String
        Dim Wednessday As String
        Dim Thursday As String
        Dim Friday As String
        Dim Saturday As String
        If chkAllHours.Checked Then
            Sunday = "111111111111111111111111"
            Monday = "111111111111111111111111"
            Tuesday = "111111111111111111111111"
            Wednessday = "111111111111111111111111"
            Thursday = "111111111111111111111111"
            Friday = "111111111111111111111111"
            Saturday = "111111111111111111111111"
        Else
            Sunday = txtSun.Text
            Monday = txtMon.Text
            Tuesday = txtTues.Text
            Wednessday = txtWed.Text
            Thursday = txtThurs.Text
            Friday = txtFri.Text
            Saturday = txtSat.Text
        End If
        err = dbFuncs.ValidateBinInputs(strMonths, Sunday, Monday, Tuesday, Wednessday, Thursday, Friday, Saturday)
        If err <> "" Then
            'not valid
            Return binDataList
        End If
        HourMonthBinDataList = dbFuncs.GetHourDataByMonth(ddlRegion.Text, fileName, strMonths,
                           Sunday, Monday, Tuesday, Wednessday,
                           Thursday, Friday, Saturday, dbLocation)

        If HourMonthBinDataList.Count = 0 Then
            'no records returned
            err = " No hourly data found"
            Return binDataList
        End If

        'now get bin data
        Dim inputObj As New AirXDLL.Inputs
        totalHours = HourMonthBinDataList.Count
        inputObj.InDBSum = CDbl(txtInDBSum.Text)
        inputObj.InDBWin = CDbl(txtInDBWin.Text)
        inputObj.NeededValues = New AirXDLL.Values
        inputObj.NeededValues.EnthSumI = outputs.EnthSumI
        inputObj.NeededValues.EnthWinI = outputs.EnthWinI
        inputObj.HourData = New List(Of AirXDLL.HourData)
        For Each hr As AirXDLL.HourData In HourMonthBinDataList
            Dim dllHR As AirXDLL.HourData = New AirXDLL.HourData
            dllHR.DB = hr.DB
            dllHR.HumRatio = hr.HumRatio
            dllHR.Month = hr.Month
            inputObj.HourData.Add(dllHR)
        Next
        Dim calcFuncs As New AirXDLL.Calculate
        Dim outputObj As New AirXDLL.Outputs

        'calcFuncs.CalculateBinData(inputObj, outputObj, binDataList)
        calcFuncs.CalculateBinDataByMonth(inputObj, outputObj, binDataList)
        Dim bdList As New List(Of AirXDLL.BinData)
        For Each bdDLL As AirXDLL.BinData In binDataList
            Dim bd As New AirXDLL.BinData
            bd.DB = bdDLL.DB
            bd.W = bdDLL.W
            bd.Hours = bdDLL.Hours
            bd.MidPoint = bdDLL.MidPoint
            bd.Month = bdDLL.Month
            bdList.Add(bd)
        Next

        Return bdList
    End Function

    Private Sub btnLoadLocations_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadLocations.Click

        ddlCity.Items.Clear()
        ddlState.Items.Clear()
        ddlCountry.Items.Clear()
        'ddlModel.Items.Clear()

        ddlCity.Text = ""
        ddlState.Text = ""
        ddlCountry.Text = ""
        'ddlModel.Text = ""

        ddlRegion.Items.Clear()
        ddlRegion.Text = ""
        Dim SortedArray As New ArrayList(10)

        'Dim di As New IO.DirectoryInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\AirXChange ERC 6.0")
        If Not Directory.Exists(txtFileLoc.Text) Then
            MessageBox.Show("Valid config file path required. Please click Browse button to select path.")
            Return
        End If

        If chkUseDesignDB.Checked Then

            Dim di As New IO.DirectoryInfo(txtFileLoc.Text)
            Dim diar1 As IO.FileInfo() = di.GetFiles("*AirXWeatherData*.mdb")
            Dim dra As IO.FileInfo

            'list the names of all files in the specified directory
            For Each dra In diar1
                Dim fileName As String = dra.Name
                Dim subFileName As String = fileName.Substring(0, fileName.IndexOf(".mdb"))
                'filenames are in the form AirXWeatherData-Region.mdb
                'pull off the AirXWeather
                Dim parts() As String = subFileName.Split(CChar("-"))
                Dim r As String = parts(1).Replace("_", " ")
                If Not SortedArray.Contains(r) Then

                    SortedArray.Add(r)
                End If

            Next
            SortedArray.Sort()
            For Each Region As String In SortedArray
                ddlRegion.Items.Add(Region)
            Next

            ddlRegion.SelectedIndex = 0
        End If
        PopulateModelsDDL()
    End Sub

    Private Sub btnBrowseFileLoc_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowseFileLoc.Click
        folderDialog.RootFolder = Environment.SpecialFolder.MyComputer
        folderDialog.Description = "Select a Folder"
        Dim dlgResult As DialogResult = folderDialog.ShowDialog()
        If dlgResult = Windows.Forms.DialogResult.OK Then
            txtFileLoc.Text = folderDialog.SelectedPath + "\"
        End If
    End Sub

    Private Sub chkUseDesignDB_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUseDesignDB.CheckedChanged
        If chkUseDesignDB.Checked Then
            'enable calc buttons that use weather data
            btnCalcEco.Enabled = True
            btnCalcEER.Enabled = True
            BtnCalcEnergy.Enabled = True
            btnMainCalc.Enabled = True
            txtElev.Enabled = False
        Else
            'disable calc buttons that use weather data
            btnCalcEco.Enabled = False
            btnCalcEER.Enabled = False
            BtnCalcEnergy.Enabled = False
            btnMainCalc.Enabled = False
            txtElev.Enabled = True
        End If
    End Sub

    Private Sub ddlModel_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlModel.SelectedIndexChanged
        If ddlModel.Text.EndsWith("-A1") Then
            chkSensibleOnly.Checked = False
            chkSensibleOnly.Enabled = False
        Else
            chkSensibleOnly.Enabled = True
        End If
    End Sub

End Class