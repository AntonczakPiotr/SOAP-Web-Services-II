﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OsobyKlient.OsobyWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Osoba", Namespace="http://OsobyApp/WebService/Osoby/")]
    [System.SerializableAttribute()]
    public partial class Osoba : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int OsobaIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImieField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazwiskoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int OsobaId {
            get {
                return this.OsobaIdField;
            }
            set {
                if ((this.OsobaIdField.Equals(value) != true)) {
                    this.OsobaIdField = value;
                    this.RaisePropertyChanged("OsobaId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Imie {
            get {
                return this.ImieField;
            }
            set {
                if ((object.ReferenceEquals(this.ImieField, value) != true)) {
                    this.ImieField = value;
                    this.RaisePropertyChanged("Imie");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Nazwisko {
            get {
                return this.NazwiskoField;
            }
            set {
                if ((object.ReferenceEquals(this.NazwiskoField, value) != true)) {
                    this.NazwiskoField = value;
                    this.RaisePropertyChanged("Nazwisko");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://OsobyApp/WebService/Osoby/", ConfigurationName="OsobyWS.OsobySoap")]
    public interface OsobySoap {
        
        // CODEGEN: Generating message contract since element name ListaOsobPelnaResult from namespace http://OsobyApp/WebService/Osoby/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://OsobyApp/WebService/Osoby/ListaOsobPelna", ReplyAction="*")]
        OsobyKlient.OsobyWS.ListaOsobPelnaResponse ListaOsobPelna(OsobyKlient.OsobyWS.ListaOsobPelnaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OsobyApp/WebService/Osoby/ListaOsobPelna", ReplyAction="*")]
        System.Threading.Tasks.Task<OsobyKlient.OsobyWS.ListaOsobPelnaResponse> ListaOsobPelnaAsync(OsobyKlient.OsobyWS.ListaOsobPelnaRequest request);
        
        // CODEGEN: Generating message contract since element name ListaOsobResult from namespace http://OsobyApp/WebService/Osoby/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://OsobyApp/WebService/Osoby/ListaOsob", ReplyAction="*")]
        OsobyKlient.OsobyWS.ListaOsobResponse ListaOsob(OsobyKlient.OsobyWS.ListaOsobRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OsobyApp/WebService/Osoby/ListaOsob", ReplyAction="*")]
        System.Threading.Tasks.Task<OsobyKlient.OsobyWS.ListaOsobResponse> ListaOsobAsync(OsobyKlient.OsobyWS.ListaOsobRequest request);
        
        // CODEGEN: Generating message contract since element name ListaOsobFiltrResult from namespace http://OsobyApp/WebService/Osoby/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://OsobyApp/WebService/Osoby/ListaOsobFiltr", ReplyAction="*")]
        OsobyKlient.OsobyWS.ListaOsobFiltrResponse ListaOsobFiltr(OsobyKlient.OsobyWS.ListaOsobFiltrRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OsobyApp/WebService/Osoby/ListaOsobFiltr", ReplyAction="*")]
        System.Threading.Tasks.Task<OsobyKlient.OsobyWS.ListaOsobFiltrResponse> ListaOsobFiltrAsync(OsobyKlient.OsobyWS.ListaOsobFiltrRequest request);
        
        // CODEGEN: Generating message contract since element name WyszukajOsobeResult from namespace http://OsobyApp/WebService/Osoby/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://OsobyApp/WebService/Osoby/WyszukajOsobe", ReplyAction="*")]
        OsobyKlient.OsobyWS.WyszukajOsobeResponse WyszukajOsobe(OsobyKlient.OsobyWS.WyszukajOsobeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OsobyApp/WebService/Osoby/WyszukajOsobe", ReplyAction="*")]
        System.Threading.Tasks.Task<OsobyKlient.OsobyWS.WyszukajOsobeResponse> WyszukajOsobeAsync(OsobyKlient.OsobyWS.WyszukajOsobeRequest request);
        
        // CODEGEN: Generating message contract since element name imie from namespace http://OsobyApp/WebService/Osoby/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://OsobyApp/WebService/Osoby/DodajOsobe", ReplyAction="*")]
        OsobyKlient.OsobyWS.DodajOsobeResponse DodajOsobe(OsobyKlient.OsobyWS.DodajOsobeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OsobyApp/WebService/Osoby/DodajOsobe", ReplyAction="*")]
        System.Threading.Tasks.Task<OsobyKlient.OsobyWS.DodajOsobeResponse> DodajOsobeAsync(OsobyKlient.OsobyWS.DodajOsobeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OsobyApp/WebService/Osoby/UsunOsobe", ReplyAction="*")]
        void UsunOsobe(int osobaId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OsobyApp/WebService/Osoby/UsunOsobe", ReplyAction="*")]
        System.Threading.Tasks.Task UsunOsobeAsync(int osobaId);
        
        // CODEGEN: Generating message contract since element name noweImie from namespace http://OsobyApp/WebService/Osoby/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://OsobyApp/WebService/Osoby/EdytujOsobe", ReplyAction="*")]
        OsobyKlient.OsobyWS.EdytujOsobeResponse EdytujOsobe(OsobyKlient.OsobyWS.EdytujOsobeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://OsobyApp/WebService/Osoby/EdytujOsobe", ReplyAction="*")]
        System.Threading.Tasks.Task<OsobyKlient.OsobyWS.EdytujOsobeResponse> EdytujOsobeAsync(OsobyKlient.OsobyWS.EdytujOsobeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListaOsobPelnaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListaOsobPelna", Namespace="http://OsobyApp/WebService/Osoby/", Order=0)]
        public OsobyKlient.OsobyWS.ListaOsobPelnaRequestBody Body;
        
        public ListaOsobPelnaRequest() {
        }
        
        public ListaOsobPelnaRequest(OsobyKlient.OsobyWS.ListaOsobPelnaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListaOsobPelnaRequestBody {
        
        public ListaOsobPelnaRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListaOsobPelnaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListaOsobPelnaResponse", Namespace="http://OsobyApp/WebService/Osoby/", Order=0)]
        public OsobyKlient.OsobyWS.ListaOsobPelnaResponseBody Body;
        
        public ListaOsobPelnaResponse() {
        }
        
        public ListaOsobPelnaResponse(OsobyKlient.OsobyWS.ListaOsobPelnaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://OsobyApp/WebService/Osoby/")]
    public partial class ListaOsobPelnaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public OsobyKlient.OsobyWS.Osoba[] ListaOsobPelnaResult;
        
        public ListaOsobPelnaResponseBody() {
        }
        
        public ListaOsobPelnaResponseBody(OsobyKlient.OsobyWS.Osoba[] ListaOsobPelnaResult) {
            this.ListaOsobPelnaResult = ListaOsobPelnaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListaOsobRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListaOsob", Namespace="http://OsobyApp/WebService/Osoby/", Order=0)]
        public OsobyKlient.OsobyWS.ListaOsobRequestBody Body;
        
        public ListaOsobRequest() {
        }
        
        public ListaOsobRequest(OsobyKlient.OsobyWS.ListaOsobRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://OsobyApp/WebService/Osoby/")]
    public partial class ListaOsobRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int ilosc;
        
        public ListaOsobRequestBody() {
        }
        
        public ListaOsobRequestBody(int ilosc) {
            this.ilosc = ilosc;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListaOsobResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListaOsobResponse", Namespace="http://OsobyApp/WebService/Osoby/", Order=0)]
        public OsobyKlient.OsobyWS.ListaOsobResponseBody Body;
        
        public ListaOsobResponse() {
        }
        
        public ListaOsobResponse(OsobyKlient.OsobyWS.ListaOsobResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://OsobyApp/WebService/Osoby/")]
    public partial class ListaOsobResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public OsobyKlient.OsobyWS.Osoba[] ListaOsobResult;
        
        public ListaOsobResponseBody() {
        }
        
        public ListaOsobResponseBody(OsobyKlient.OsobyWS.Osoba[] ListaOsobResult) {
            this.ListaOsobResult = ListaOsobResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListaOsobFiltrRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListaOsobFiltr", Namespace="http://OsobyApp/WebService/Osoby/", Order=0)]
        public OsobyKlient.OsobyWS.ListaOsobFiltrRequestBody Body;
        
        public ListaOsobFiltrRequest() {
        }
        
        public ListaOsobFiltrRequest(OsobyKlient.OsobyWS.ListaOsobFiltrRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://OsobyApp/WebService/Osoby/")]
    public partial class ListaOsobFiltrRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int start;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int ilosc;
        
        public ListaOsobFiltrRequestBody() {
        }
        
        public ListaOsobFiltrRequestBody(int start, int ilosc) {
            this.start = start;
            this.ilosc = ilosc;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListaOsobFiltrResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListaOsobFiltrResponse", Namespace="http://OsobyApp/WebService/Osoby/", Order=0)]
        public OsobyKlient.OsobyWS.ListaOsobFiltrResponseBody Body;
        
        public ListaOsobFiltrResponse() {
        }
        
        public ListaOsobFiltrResponse(OsobyKlient.OsobyWS.ListaOsobFiltrResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://OsobyApp/WebService/Osoby/")]
    public partial class ListaOsobFiltrResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public OsobyKlient.OsobyWS.Osoba[] ListaOsobFiltrResult;
        
        public ListaOsobFiltrResponseBody() {
        }
        
        public ListaOsobFiltrResponseBody(OsobyKlient.OsobyWS.Osoba[] ListaOsobFiltrResult) {
            this.ListaOsobFiltrResult = ListaOsobFiltrResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WyszukajOsobeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WyszukajOsobe", Namespace="http://OsobyApp/WebService/Osoby/", Order=0)]
        public OsobyKlient.OsobyWS.WyszukajOsobeRequestBody Body;
        
        public WyszukajOsobeRequest() {
        }
        
        public WyszukajOsobeRequest(OsobyKlient.OsobyWS.WyszukajOsobeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://OsobyApp/WebService/Osoby/")]
    public partial class WyszukajOsobeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int osobaId;
        
        public WyszukajOsobeRequestBody() {
        }
        
        public WyszukajOsobeRequestBody(int osobaId) {
            this.osobaId = osobaId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WyszukajOsobeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WyszukajOsobeResponse", Namespace="http://OsobyApp/WebService/Osoby/", Order=0)]
        public OsobyKlient.OsobyWS.WyszukajOsobeResponseBody Body;
        
        public WyszukajOsobeResponse() {
        }
        
        public WyszukajOsobeResponse(OsobyKlient.OsobyWS.WyszukajOsobeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://OsobyApp/WebService/Osoby/")]
    public partial class WyszukajOsobeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public OsobyKlient.OsobyWS.Osoba WyszukajOsobeResult;
        
        public WyszukajOsobeResponseBody() {
        }
        
        public WyszukajOsobeResponseBody(OsobyKlient.OsobyWS.Osoba WyszukajOsobeResult) {
            this.WyszukajOsobeResult = WyszukajOsobeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DodajOsobeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DodajOsobe", Namespace="http://OsobyApp/WebService/Osoby/", Order=0)]
        public OsobyKlient.OsobyWS.DodajOsobeRequestBody Body;
        
        public DodajOsobeRequest() {
        }
        
        public DodajOsobeRequest(OsobyKlient.OsobyWS.DodajOsobeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://OsobyApp/WebService/Osoby/")]
    public partial class DodajOsobeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string imie;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string nazwisko;
        
        public DodajOsobeRequestBody() {
        }
        
        public DodajOsobeRequestBody(string imie, string nazwisko) {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DodajOsobeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DodajOsobeResponse", Namespace="http://OsobyApp/WebService/Osoby/", Order=0)]
        public OsobyKlient.OsobyWS.DodajOsobeResponseBody Body;
        
        public DodajOsobeResponse() {
        }
        
        public DodajOsobeResponse(OsobyKlient.OsobyWS.DodajOsobeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://OsobyApp/WebService/Osoby/")]
    public partial class DodajOsobeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int DodajOsobeResult;
        
        public DodajOsobeResponseBody() {
        }
        
        public DodajOsobeResponseBody(int DodajOsobeResult) {
            this.DodajOsobeResult = DodajOsobeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EdytujOsobeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EdytujOsobe", Namespace="http://OsobyApp/WebService/Osoby/", Order=0)]
        public OsobyKlient.OsobyWS.EdytujOsobeRequestBody Body;
        
        public EdytujOsobeRequest() {
        }
        
        public EdytujOsobeRequest(OsobyKlient.OsobyWS.EdytujOsobeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://OsobyApp/WebService/Osoby/")]
    public partial class EdytujOsobeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int osobaId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string noweImie;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string noweNazwisko;
        
        public EdytujOsobeRequestBody() {
        }
        
        public EdytujOsobeRequestBody(int osobaId, string noweImie, string noweNazwisko) {
            this.osobaId = osobaId;
            this.noweImie = noweImie;
            this.noweNazwisko = noweNazwisko;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EdytujOsobeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EdytujOsobeResponse", Namespace="http://OsobyApp/WebService/Osoby/", Order=0)]
        public OsobyKlient.OsobyWS.EdytujOsobeResponseBody Body;
        
        public EdytujOsobeResponse() {
        }
        
        public EdytujOsobeResponse(OsobyKlient.OsobyWS.EdytujOsobeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://OsobyApp/WebService/Osoby/")]
    public partial class EdytujOsobeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public OsobyKlient.OsobyWS.Osoba EdytujOsobeResult;
        
        public EdytujOsobeResponseBody() {
        }
        
        public EdytujOsobeResponseBody(OsobyKlient.OsobyWS.Osoba EdytujOsobeResult) {
            this.EdytujOsobeResult = EdytujOsobeResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface OsobySoapChannel : OsobyKlient.OsobyWS.OsobySoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OsobySoapClient : System.ServiceModel.ClientBase<OsobyKlient.OsobyWS.OsobySoap>, OsobyKlient.OsobyWS.OsobySoap {
        
        public OsobySoapClient() {
        }
        
        public OsobySoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OsobySoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OsobySoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OsobySoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OsobyKlient.OsobyWS.ListaOsobPelnaResponse OsobyKlient.OsobyWS.OsobySoap.ListaOsobPelna(OsobyKlient.OsobyWS.ListaOsobPelnaRequest request) {
            return base.Channel.ListaOsobPelna(request);
        }
        
        public OsobyKlient.OsobyWS.Osoba[] ListaOsobPelna() {
            OsobyKlient.OsobyWS.ListaOsobPelnaRequest inValue = new OsobyKlient.OsobyWS.ListaOsobPelnaRequest();
            inValue.Body = new OsobyKlient.OsobyWS.ListaOsobPelnaRequestBody();
            OsobyKlient.OsobyWS.ListaOsobPelnaResponse retVal = ((OsobyKlient.OsobyWS.OsobySoap)(this)).ListaOsobPelna(inValue);
            return retVal.Body.ListaOsobPelnaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<OsobyKlient.OsobyWS.ListaOsobPelnaResponse> OsobyKlient.OsobyWS.OsobySoap.ListaOsobPelnaAsync(OsobyKlient.OsobyWS.ListaOsobPelnaRequest request) {
            return base.Channel.ListaOsobPelnaAsync(request);
        }
        
        public System.Threading.Tasks.Task<OsobyKlient.OsobyWS.ListaOsobPelnaResponse> ListaOsobPelnaAsync() {
            OsobyKlient.OsobyWS.ListaOsobPelnaRequest inValue = new OsobyKlient.OsobyWS.ListaOsobPelnaRequest();
            inValue.Body = new OsobyKlient.OsobyWS.ListaOsobPelnaRequestBody();
            return ((OsobyKlient.OsobyWS.OsobySoap)(this)).ListaOsobPelnaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OsobyKlient.OsobyWS.ListaOsobResponse OsobyKlient.OsobyWS.OsobySoap.ListaOsob(OsobyKlient.OsobyWS.ListaOsobRequest request) {
            return base.Channel.ListaOsob(request);
        }
        
        public OsobyKlient.OsobyWS.Osoba[] ListaOsob(int ilosc) {
            OsobyKlient.OsobyWS.ListaOsobRequest inValue = new OsobyKlient.OsobyWS.ListaOsobRequest();
            inValue.Body = new OsobyKlient.OsobyWS.ListaOsobRequestBody();
            inValue.Body.ilosc = ilosc;
            OsobyKlient.OsobyWS.ListaOsobResponse retVal = ((OsobyKlient.OsobyWS.OsobySoap)(this)).ListaOsob(inValue);
            return retVal.Body.ListaOsobResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<OsobyKlient.OsobyWS.ListaOsobResponse> OsobyKlient.OsobyWS.OsobySoap.ListaOsobAsync(OsobyKlient.OsobyWS.ListaOsobRequest request) {
            return base.Channel.ListaOsobAsync(request);
        }
        
        public System.Threading.Tasks.Task<OsobyKlient.OsobyWS.ListaOsobResponse> ListaOsobAsync(int ilosc) {
            OsobyKlient.OsobyWS.ListaOsobRequest inValue = new OsobyKlient.OsobyWS.ListaOsobRequest();
            inValue.Body = new OsobyKlient.OsobyWS.ListaOsobRequestBody();
            inValue.Body.ilosc = ilosc;
            return ((OsobyKlient.OsobyWS.OsobySoap)(this)).ListaOsobAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OsobyKlient.OsobyWS.ListaOsobFiltrResponse OsobyKlient.OsobyWS.OsobySoap.ListaOsobFiltr(OsobyKlient.OsobyWS.ListaOsobFiltrRequest request) {
            return base.Channel.ListaOsobFiltr(request);
        }
        
        public OsobyKlient.OsobyWS.Osoba[] ListaOsobFiltr(int start, int ilosc) {
            OsobyKlient.OsobyWS.ListaOsobFiltrRequest inValue = new OsobyKlient.OsobyWS.ListaOsobFiltrRequest();
            inValue.Body = new OsobyKlient.OsobyWS.ListaOsobFiltrRequestBody();
            inValue.Body.start = start;
            inValue.Body.ilosc = ilosc;
            OsobyKlient.OsobyWS.ListaOsobFiltrResponse retVal = ((OsobyKlient.OsobyWS.OsobySoap)(this)).ListaOsobFiltr(inValue);
            return retVal.Body.ListaOsobFiltrResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<OsobyKlient.OsobyWS.ListaOsobFiltrResponse> OsobyKlient.OsobyWS.OsobySoap.ListaOsobFiltrAsync(OsobyKlient.OsobyWS.ListaOsobFiltrRequest request) {
            return base.Channel.ListaOsobFiltrAsync(request);
        }
        
        public System.Threading.Tasks.Task<OsobyKlient.OsobyWS.ListaOsobFiltrResponse> ListaOsobFiltrAsync(int start, int ilosc) {
            OsobyKlient.OsobyWS.ListaOsobFiltrRequest inValue = new OsobyKlient.OsobyWS.ListaOsobFiltrRequest();
            inValue.Body = new OsobyKlient.OsobyWS.ListaOsobFiltrRequestBody();
            inValue.Body.start = start;
            inValue.Body.ilosc = ilosc;
            return ((OsobyKlient.OsobyWS.OsobySoap)(this)).ListaOsobFiltrAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OsobyKlient.OsobyWS.WyszukajOsobeResponse OsobyKlient.OsobyWS.OsobySoap.WyszukajOsobe(OsobyKlient.OsobyWS.WyszukajOsobeRequest request) {
            return base.Channel.WyszukajOsobe(request);
        }
        
        public OsobyKlient.OsobyWS.Osoba WyszukajOsobe(int osobaId) {
            OsobyKlient.OsobyWS.WyszukajOsobeRequest inValue = new OsobyKlient.OsobyWS.WyszukajOsobeRequest();
            inValue.Body = new OsobyKlient.OsobyWS.WyszukajOsobeRequestBody();
            inValue.Body.osobaId = osobaId;
            OsobyKlient.OsobyWS.WyszukajOsobeResponse retVal = ((OsobyKlient.OsobyWS.OsobySoap)(this)).WyszukajOsobe(inValue);
            return retVal.Body.WyszukajOsobeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<OsobyKlient.OsobyWS.WyszukajOsobeResponse> OsobyKlient.OsobyWS.OsobySoap.WyszukajOsobeAsync(OsobyKlient.OsobyWS.WyszukajOsobeRequest request) {
            return base.Channel.WyszukajOsobeAsync(request);
        }
        
        public System.Threading.Tasks.Task<OsobyKlient.OsobyWS.WyszukajOsobeResponse> WyszukajOsobeAsync(int osobaId) {
            OsobyKlient.OsobyWS.WyszukajOsobeRequest inValue = new OsobyKlient.OsobyWS.WyszukajOsobeRequest();
            inValue.Body = new OsobyKlient.OsobyWS.WyszukajOsobeRequestBody();
            inValue.Body.osobaId = osobaId;
            return ((OsobyKlient.OsobyWS.OsobySoap)(this)).WyszukajOsobeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OsobyKlient.OsobyWS.DodajOsobeResponse OsobyKlient.OsobyWS.OsobySoap.DodajOsobe(OsobyKlient.OsobyWS.DodajOsobeRequest request) {
            return base.Channel.DodajOsobe(request);
        }
        
        public int DodajOsobe(string imie, string nazwisko) {
            OsobyKlient.OsobyWS.DodajOsobeRequest inValue = new OsobyKlient.OsobyWS.DodajOsobeRequest();
            inValue.Body = new OsobyKlient.OsobyWS.DodajOsobeRequestBody();
            inValue.Body.imie = imie;
            inValue.Body.nazwisko = nazwisko;
            OsobyKlient.OsobyWS.DodajOsobeResponse retVal = ((OsobyKlient.OsobyWS.OsobySoap)(this)).DodajOsobe(inValue);
            return retVal.Body.DodajOsobeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<OsobyKlient.OsobyWS.DodajOsobeResponse> OsobyKlient.OsobyWS.OsobySoap.DodajOsobeAsync(OsobyKlient.OsobyWS.DodajOsobeRequest request) {
            return base.Channel.DodajOsobeAsync(request);
        }
        
        public System.Threading.Tasks.Task<OsobyKlient.OsobyWS.DodajOsobeResponse> DodajOsobeAsync(string imie, string nazwisko) {
            OsobyKlient.OsobyWS.DodajOsobeRequest inValue = new OsobyKlient.OsobyWS.DodajOsobeRequest();
            inValue.Body = new OsobyKlient.OsobyWS.DodajOsobeRequestBody();
            inValue.Body.imie = imie;
            inValue.Body.nazwisko = nazwisko;
            return ((OsobyKlient.OsobyWS.OsobySoap)(this)).DodajOsobeAsync(inValue);
        }
        
        public void UsunOsobe(int osobaId) {
            base.Channel.UsunOsobe(osobaId);
        }
        
        public System.Threading.Tasks.Task UsunOsobeAsync(int osobaId) {
            return base.Channel.UsunOsobeAsync(osobaId);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OsobyKlient.OsobyWS.EdytujOsobeResponse OsobyKlient.OsobyWS.OsobySoap.EdytujOsobe(OsobyKlient.OsobyWS.EdytujOsobeRequest request) {
            return base.Channel.EdytujOsobe(request);
        }
        
        public OsobyKlient.OsobyWS.Osoba EdytujOsobe(int osobaId, string noweImie, string noweNazwisko) {
            OsobyKlient.OsobyWS.EdytujOsobeRequest inValue = new OsobyKlient.OsobyWS.EdytujOsobeRequest();
            inValue.Body = new OsobyKlient.OsobyWS.EdytujOsobeRequestBody();
            inValue.Body.osobaId = osobaId;
            inValue.Body.noweImie = noweImie;
            inValue.Body.noweNazwisko = noweNazwisko;
            OsobyKlient.OsobyWS.EdytujOsobeResponse retVal = ((OsobyKlient.OsobyWS.OsobySoap)(this)).EdytujOsobe(inValue);
            return retVal.Body.EdytujOsobeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<OsobyKlient.OsobyWS.EdytujOsobeResponse> OsobyKlient.OsobyWS.OsobySoap.EdytujOsobeAsync(OsobyKlient.OsobyWS.EdytujOsobeRequest request) {
            return base.Channel.EdytujOsobeAsync(request);
        }
        
        public System.Threading.Tasks.Task<OsobyKlient.OsobyWS.EdytujOsobeResponse> EdytujOsobeAsync(int osobaId, string noweImie, string noweNazwisko) {
            OsobyKlient.OsobyWS.EdytujOsobeRequest inValue = new OsobyKlient.OsobyWS.EdytujOsobeRequest();
            inValue.Body = new OsobyKlient.OsobyWS.EdytujOsobeRequestBody();
            inValue.Body.osobaId = osobaId;
            inValue.Body.noweImie = noweImie;
            inValue.Body.noweNazwisko = noweNazwisko;
            return ((OsobyKlient.OsobyWS.OsobySoap)(this)).EdytujOsobeAsync(inValue);
        }
    }
}
