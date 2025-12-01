<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="9f961a5e-2c22-4e74-9561-8a983a75d581" Comment="Adapter Interface" Name="AdpChan" Namespace="Main">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="nxtControl GmBH" Version="0.0" Author="vaatmar1" Date="12/6/2023" />
  <InterfaceList>
    <EventInputs>
      <Event Name="EI0">
        <With Var="DI1" />
        <With Var="DI2" />
        <With Var="DI3" />
      </Event>
      <Event Name="EI1">
        <With Var="DI1" />
        <With Var="DI2" />
        <With Var="DI3" />
      </Event>
      <Event Name="EI2">
        <With Var="DI1" />
        <With Var="DI2" />
        <With Var="DI3" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event Name="EO0">
        <With Var="DO0" />
        <With Var="DO1" />
        <With Var="DO2" />
        <With Var="DO3" />
      </Event>
      <Event Name="EO1">
        <With Var="DO0" />
        <With Var="DO1" />
        <With Var="DO2" />
        <With Var="DO3" />
      </Event>
      <Event Name="EO2">
        <With Var="DO0" />
        <With Var="DO1" />
        <With Var="DO2" />
        <With Var="DO3" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration Name="DI1" Type="STRING" />
      <VarDeclaration Name="DI2" Type="STRING" />
      <VarDeclaration Name="DI3" Type="STRING" />
    </InputVars>
    <OutputVars>
      <VarDeclaration Name="DO0" Type="BOOL" />
      <VarDeclaration Name="DO1" Type="STRING" />
      <VarDeclaration Name="DO2" Type="STRING" />
      <VarDeclaration Name="DO3" Type="STRING" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="REQ" Parameters="REQD" />
        <OutputPrimitive Interface="PLUG" Event="REQ" Parameters="REQD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CNF" Parameters="CNFD" />
        <OutputPrimitive Interface="SOCKET" Event="CNF" Parameters="CNFD" />
      </ServiceTransaction>
    </ServiceSequence>
    <ServiceSequence Name="indication_response">
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="IND" Parameters="INDD" />
        <OutputPrimitive Interface="SOCKET" Event="IND" Parameters="INDD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="RSP" Parameters="RSPD" />
        <OutputPrimitive Interface="PLUG" Event="RSP" Parameters="RSPD" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>