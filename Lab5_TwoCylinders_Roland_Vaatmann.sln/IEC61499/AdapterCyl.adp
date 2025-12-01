<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="14f286cc-ab0d-4ed8-8b06-d2b565dddc91" Name="AdapterCyl" Comment="Adapter Interface" Namespace="Main">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="nxtControl GmBH" Version="0.0" Author="valeriy" Date="7/14/2023" />
  <InterfaceList>
    <EventInputs>
      <Event Name="INIT" Comment="Request from Socket">
        <With Var="DI1" />
        <With Var="DI2" />
      </Event>
      <Event Name="REQ" Comment="Response from Socket">
        <With Var="DI1" />
        <With Var="DI2" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event Name="INITO" Comment="Confirmation from Plug">
        <With Var="DO1" />
        <With Var="DO2" />
      </Event>
      <Event Name="CNF" Comment="Indication from Plug">
        <With Var="DO1" />
        <With Var="DO2" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration Name="DI1" Type="BOOL" Comment="Request Data from Socket" />
      <VarDeclaration Name="DI2" Type="BOOL" Comment="Response Data from Socket" />
    </InputVars>
    <OutputVars>
      <VarDeclaration Name="DO1" Type="BOOL" Comment="Confirmation Data from Plug" />
      <VarDeclaration Name="DO2" Type="BOOL" Comment="Indication Data from Plug" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="INIT" Parameters="DI1" />
        <OutputPrimitive Interface="PLUG" Event="INIT" Parameters="DI1" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="INITO" Parameters="DO1" />
        <OutputPrimitive Interface="SOCKET" Event="INITO" Parameters="DO1" />
      </ServiceTransaction>
    </ServiceSequence>
    <ServiceSequence Name="indication_response">
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CNF" Parameters="DO2" />
        <OutputPrimitive Interface="SOCKET" Event="CNF" Parameters="DO2" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="REQ" Parameters="DI2" />
        <OutputPrimitive Interface="PLUG" Event="REQ" Parameters="DI2" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>