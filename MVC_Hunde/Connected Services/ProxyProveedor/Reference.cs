﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Hunde.ProxyProveedor {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProveedorBE", Namespace="http://schemas.datacontract.org/2004/07/WCF_Hunde")]
    [System.SerializableAttribute()]
    public partial class ProveedorBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cod_provField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dir_provField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string email_provField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int estado_provField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fec_reg_provField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fec_ult_modField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_ubigeoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string raz_socField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string rep_ven_provField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ruc_provField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tel_provField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usu_regField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usu_ult_modField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cod_prov {
            get {
                return this.cod_provField;
            }
            set {
                if ((object.ReferenceEquals(this.cod_provField, value) != true)) {
                    this.cod_provField = value;
                    this.RaisePropertyChanged("cod_prov");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string dir_prov {
            get {
                return this.dir_provField;
            }
            set {
                if ((object.ReferenceEquals(this.dir_provField, value) != true)) {
                    this.dir_provField = value;
                    this.RaisePropertyChanged("dir_prov");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email_prov {
            get {
                return this.email_provField;
            }
            set {
                if ((object.ReferenceEquals(this.email_provField, value) != true)) {
                    this.email_provField = value;
                    this.RaisePropertyChanged("email_prov");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int estado_prov {
            get {
                return this.estado_provField;
            }
            set {
                if ((this.estado_provField.Equals(value) != true)) {
                    this.estado_provField = value;
                    this.RaisePropertyChanged("estado_prov");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fec_reg_prov {
            get {
                return this.fec_reg_provField;
            }
            set {
                if ((this.fec_reg_provField.Equals(value) != true)) {
                    this.fec_reg_provField = value;
                    this.RaisePropertyChanged("fec_reg_prov");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fec_ult_mod {
            get {
                return this.fec_ult_modField;
            }
            set {
                if ((this.fec_ult_modField.Equals(value) != true)) {
                    this.fec_ult_modField = value;
                    this.RaisePropertyChanged("fec_ult_mod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id_ubigeo {
            get {
                return this.id_ubigeoField;
            }
            set {
                if ((object.ReferenceEquals(this.id_ubigeoField, value) != true)) {
                    this.id_ubigeoField = value;
                    this.RaisePropertyChanged("id_ubigeo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string raz_soc {
            get {
                return this.raz_socField;
            }
            set {
                if ((object.ReferenceEquals(this.raz_socField, value) != true)) {
                    this.raz_socField = value;
                    this.RaisePropertyChanged("raz_soc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string rep_ven_prov {
            get {
                return this.rep_ven_provField;
            }
            set {
                if ((object.ReferenceEquals(this.rep_ven_provField, value) != true)) {
                    this.rep_ven_provField = value;
                    this.RaisePropertyChanged("rep_ven_prov");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ruc_prov {
            get {
                return this.ruc_provField;
            }
            set {
                if ((object.ReferenceEquals(this.ruc_provField, value) != true)) {
                    this.ruc_provField = value;
                    this.RaisePropertyChanged("ruc_prov");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tel_prov {
            get {
                return this.tel_provField;
            }
            set {
                if ((object.ReferenceEquals(this.tel_provField, value) != true)) {
                    this.tel_provField = value;
                    this.RaisePropertyChanged("tel_prov");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string usu_reg {
            get {
                return this.usu_regField;
            }
            set {
                if ((object.ReferenceEquals(this.usu_regField, value) != true)) {
                    this.usu_regField = value;
                    this.RaisePropertyChanged("usu_reg");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string usu_ult_mod {
            get {
                return this.usu_ult_modField;
            }
            set {
                if ((object.ReferenceEquals(this.usu_ult_modField, value) != true)) {
                    this.usu_ult_modField = value;
                    this.RaisePropertyChanged("usu_ult_mod");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyProveedor.IServicioProveedor")]
    public interface IServicioProveedor {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioProveedor/ConsultarProveedores", ReplyAction="http://tempuri.org/IServicioProveedor/ConsultarProveedoresResponse")]
        MVC_Hunde.ProxyProveedor.ProveedorBE[] ConsultarProveedores();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioProveedor/ConsultarProveedores", ReplyAction="http://tempuri.org/IServicioProveedor/ConsultarProveedoresResponse")]
        System.Threading.Tasks.Task<MVC_Hunde.ProxyProveedor.ProveedorBE[]> ConsultarProveedoresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioProveedor/ConsultarProveedorPorCodigo", ReplyAction="http://tempuri.org/IServicioProveedor/ConsultarProveedorPorCodigoResponse")]
        MVC_Hunde.ProxyProveedor.ProveedorBE ConsultarProveedorPorCodigo(string strCodigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioProveedor/ConsultarProveedorPorCodigo", ReplyAction="http://tempuri.org/IServicioProveedor/ConsultarProveedorPorCodigoResponse")]
        System.Threading.Tasks.Task<MVC_Hunde.ProxyProveedor.ProveedorBE> ConsultarProveedorPorCodigoAsync(string strCodigo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioProveedorChannel : MVC_Hunde.ProxyProveedor.IServicioProveedor, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioProveedorClient : System.ServiceModel.ClientBase<MVC_Hunde.ProxyProveedor.IServicioProveedor>, MVC_Hunde.ProxyProveedor.IServicioProveedor {
        
        public ServicioProveedorClient() {
        }
        
        public ServicioProveedorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioProveedorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioProveedorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioProveedorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MVC_Hunde.ProxyProveedor.ProveedorBE[] ConsultarProveedores() {
            return base.Channel.ConsultarProveedores();
        }
        
        public System.Threading.Tasks.Task<MVC_Hunde.ProxyProveedor.ProveedorBE[]> ConsultarProveedoresAsync() {
            return base.Channel.ConsultarProveedoresAsync();
        }
        
        public MVC_Hunde.ProxyProveedor.ProveedorBE ConsultarProveedorPorCodigo(string strCodigo) {
            return base.Channel.ConsultarProveedorPorCodigo(strCodigo);
        }
        
        public System.Threading.Tasks.Task<MVC_Hunde.ProxyProveedor.ProveedorBE> ConsultarProveedorPorCodigoAsync(string strCodigo) {
            return base.Channel.ConsultarProveedorPorCodigoAsync(strCodigo);
        }
    }
}
