﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace MovieNetWCF
{
	// REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
	[ServiceContract]
	public interface IUserService
	{
		[OperationContract]
		User GetUser(int id);

		[OperationContract]
		User CreateUser(string login, string password);

		[OperationContract]
		User UpdateUser(int id,string login, string password);

		[OperationContract]
		Boolean DeleteUser(int id);

		[OperationContract]
		User LoginUser(string login, string password);
		// TODO: ajoutez vos opérations de service ici
	}

	// Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
	// Vous pouvez ajouter des fichiers XSD au projet. Une fois le projet généré, vous pouvez utiliser directement les types de données qui y sont définis, avec l'espace de noms "MovieNetWCF.ContractType".
	[DataContract]
	public class User
	{
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string Login { get; set; }
		[DataMember]
		public string Password { get; set; }
	}
}
