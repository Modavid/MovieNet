﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieNetWPF.WCFMovieService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Movie", Namespace="http://schemas.datacontract.org/2004/07/MovieNetWCF")]
    [System.SerializableAttribute()]
    public partial class Movie : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SummaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public string Genre {
            get {
                return this.GenreField;
            }
            set {
                if ((object.ReferenceEquals(this.GenreField, value) != true)) {
                    this.GenreField = value;
                    this.RaisePropertyChanged("Genre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Summary {
            get {
                return this.SummaryField;
            }
            set {
                if ((object.ReferenceEquals(this.SummaryField, value) != true)) {
                    this.SummaryField = value;
                    this.RaisePropertyChanged("Summary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFMovieService.IMovieService")]
    public interface IMovieService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMovie", ReplyAction="http://tempuri.org/IMovieService/GetMovieResponse")]
        MovieNetWPF.WCFMovieService.Movie GetMovie(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMovie", ReplyAction="http://tempuri.org/IMovieService/GetMovieResponse")]
        System.Threading.Tasks.Task<MovieNetWPF.WCFMovieService.Movie> GetMovieAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/CreateMovie", ReplyAction="http://tempuri.org/IMovieService/CreateMovieResponse")]
        MovieNetWPF.WCFMovieService.Movie CreateMovie(string title, string genre, string summary);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/CreateMovie", ReplyAction="http://tempuri.org/IMovieService/CreateMovieResponse")]
        System.Threading.Tasks.Task<MovieNetWPF.WCFMovieService.Movie> CreateMovieAsync(string title, string genre, string summary);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/UpdateMovie", ReplyAction="http://tempuri.org/IMovieService/UpdateMovieResponse")]
        MovieNetWPF.WCFMovieService.Movie UpdateMovie(int id, string title, string genre, string summary);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/UpdateMovie", ReplyAction="http://tempuri.org/IMovieService/UpdateMovieResponse")]
        System.Threading.Tasks.Task<MovieNetWPF.WCFMovieService.Movie> UpdateMovieAsync(int id, string title, string genre, string summary);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/DeleteMovie", ReplyAction="http://tempuri.org/IMovieService/DeleteMovieResponse")]
        bool DeleteMovie(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/DeleteMovie", ReplyAction="http://tempuri.org/IMovieService/DeleteMovieResponse")]
        System.Threading.Tasks.Task<bool> DeleteMovieAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/FindMovieTitle", ReplyAction="http://tempuri.org/IMovieService/FindMovieTitleResponse")]
        MovieNetWPF.WCFMovieService.Movie[] FindMovieTitle(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/FindMovieTitle", ReplyAction="http://tempuri.org/IMovieService/FindMovieTitleResponse")]
        System.Threading.Tasks.Task<MovieNetWPF.WCFMovieService.Movie[]> FindMovieTitleAsync(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/FindMovieGenre", ReplyAction="http://tempuri.org/IMovieService/FindMovieGenreResponse")]
        MovieNetWPF.WCFMovieService.Movie[] FindMovieGenre(string genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/FindMovieGenre", ReplyAction="http://tempuri.org/IMovieService/FindMovieGenreResponse")]
        System.Threading.Tasks.Task<MovieNetWPF.WCFMovieService.Movie[]> FindMovieGenreAsync(string genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetAllMovies", ReplyAction="http://tempuri.org/IMovieService/GetAllMoviesResponse")]
        MovieNetWPF.WCFMovieService.Movie[] GetAllMovies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetAllMovies", ReplyAction="http://tempuri.org/IMovieService/GetAllMoviesResponse")]
        System.Threading.Tasks.Task<MovieNetWPF.WCFMovieService.Movie[]> GetAllMoviesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMovieServiceChannel : MovieNetWPF.WCFMovieService.IMovieService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MovieServiceClient : System.ServiceModel.ClientBase<MovieNetWPF.WCFMovieService.IMovieService>, MovieNetWPF.WCFMovieService.IMovieService {
        
        public MovieServiceClient() {
        }
        
        public MovieServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MovieServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MovieServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MovieServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MovieNetWPF.WCFMovieService.Movie GetMovie(int id) {
            return base.Channel.GetMovie(id);
        }
        
        public System.Threading.Tasks.Task<MovieNetWPF.WCFMovieService.Movie> GetMovieAsync(int id) {
            return base.Channel.GetMovieAsync(id);
        }
        
        public MovieNetWPF.WCFMovieService.Movie CreateMovie(string title, string genre, string summary) {
            return base.Channel.CreateMovie(title, genre, summary);
        }
        
        public System.Threading.Tasks.Task<MovieNetWPF.WCFMovieService.Movie> CreateMovieAsync(string title, string genre, string summary) {
            return base.Channel.CreateMovieAsync(title, genre, summary);
        }
        
        public MovieNetWPF.WCFMovieService.Movie UpdateMovie(int id, string title, string genre, string summary) {
            return base.Channel.UpdateMovie(id, title, genre, summary);
        }
        
        public System.Threading.Tasks.Task<MovieNetWPF.WCFMovieService.Movie> UpdateMovieAsync(int id, string title, string genre, string summary) {
            return base.Channel.UpdateMovieAsync(id, title, genre, summary);
        }
        
        public bool DeleteMovie(int id) {
            return base.Channel.DeleteMovie(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteMovieAsync(int id) {
            return base.Channel.DeleteMovieAsync(id);
        }
        
        public MovieNetWPF.WCFMovieService.Movie[] FindMovieTitle(string title) {
            return base.Channel.FindMovieTitle(title);
        }
        
        public System.Threading.Tasks.Task<MovieNetWPF.WCFMovieService.Movie[]> FindMovieTitleAsync(string title) {
            return base.Channel.FindMovieTitleAsync(title);
        }
        
        public MovieNetWPF.WCFMovieService.Movie[] FindMovieGenre(string genre) {
            return base.Channel.FindMovieGenre(genre);
        }
        
        public System.Threading.Tasks.Task<MovieNetWPF.WCFMovieService.Movie[]> FindMovieGenreAsync(string genre) {
            return base.Channel.FindMovieGenreAsync(genre);
        }
        
        public MovieNetWPF.WCFMovieService.Movie[] GetAllMovies() {
            return base.Channel.GetAllMovies();
        }
        
        public System.Threading.Tasks.Task<MovieNetWPF.WCFMovieService.Movie[]> GetAllMoviesAsync() {
            return base.Channel.GetAllMoviesAsync();
        }
    }
}
