<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="d1a31acb-8724-4e61-98e4-a3e85d1d9871" Comment="Adapter Interface" Name="BoolAdp" Namespace="Main">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="nxtControl GmBH" Version="0.0" Author="vv263" Date="7/15/2023" />
  <InterfaceList>
    <EventInputs>
      <Event Name="INIT">
        <With Var="DI1" />
      </Event>
      <Event Name="REQ" Comment="Request from Socket">
        <With Var="DI1" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event Name="INITO">
        <With Var="DO1" />
      </Event>
      <Event Name="CNF" Comment="Confirmation from Plug">
        <With Var="DO1" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration Name="DI1" Type="BOOL" Comment="Request Data from Socket" />
    </InputVars>
    <OutputVars>
      <VarDeclaration Name="DO1" Type="BOOL" Comment="Confirmation Data from Plug" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="REQ" Parameters="DI1" />
        <OutputPrimitive Interface="PLUG" Event="REQ" Parameters="DI1" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CNF" Parameters="DO1" />
        <OutputPrimitive Interface="SOCKET" Event="CNF" Parameters="DO1" />
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