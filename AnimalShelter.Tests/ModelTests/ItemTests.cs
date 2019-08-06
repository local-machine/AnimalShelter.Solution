// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System.Collections.Generic;
// using AnimalShelter.Models;
// using System;
// using MySql.Data.MySqlClient;


// namespace AnimalShelter.Tests
// {

//   [TestClass]
//   public class AnimalTest : IDisposable
//   {
//   public void Dispose()
//     {
//       Animal.ClearAll();
//     }
//     public AnimalTest()
//     {
//       DBConfiguration.ConnectionString = "server=localhost;user id=root;password=epicodus;port=3306;database=to_do_list_test;";
//     }

//     [TestMethod]
// public void GetAll_ReturnsEmptyListFromDatabase_AnimalList()
// {
//    List<Animal> newList = new List<Animal> { };
//    List<Animal> result = Animal.GetAll();
//    CollectionAssert.AreEqual(newList, result);
// }
//    [TestMethod]
// public void Equals_ReturnsTrueIfDescriptionsAreTheSame_Animal()
// {
//   Animal firstAnimal = new Animal("Mow the lawn");
//   Animal secondAnimal = new Animal("Mow the lawn");
//   Assert.AreEqual(firstAnimal, secondAnimal);
// }
// [TestMethod]
//   public void Save_SavesToDatabase_AnimalList()
//   {
//     Animal testAnimal = new Animal("Mow the lawn");
//     testAnimal.Save();
//     List<Animal> result = Animal.GetAll();
//     List<Animal> testList = new List<Animal>{testAnimal};
//     CollectionAssert.AreEqual(testList, result);
//   }
//   [TestMethod]
//   public void GetAll_ReturnsAnimals_AnimalList()
//   {
//     string description01 = "Walk the dog";
//     string description02 = "Wash the dishes";
//     Animal newAnimal1 = new Animal(description01);
//     newAnimal1.Save(); 
//     Animal newAnimal2 = new Animal(description02);
//     newAnimal2.Save(); 
//     List<Animal> newList = new List<Animal> { newAnimal1, newAnimal2 };
//     List<Animal> result = Animal.GetAll();
//     CollectionAssert.AreEqual(newList, result);
//   }
//   [TestMethod]
//     public void Find_ReturnsCorrectAnimalFromDatabase_Animal()
//     {
//       Animal newAnimal = new Animal("Mow the lawn");
//       newAnimal.Save();
//       Animal newAnimal2 = new Animal("Wash dishes");
//       newAnimal2.Save();
//       Animal foundAnimal = Animal.Find(newAnimal.Id);
//       Assert.AreEqual(newAnimal, foundAnimal);
//     }

//     public static Animal Find(int id)
// {
//   MySqlConnection conn = DB.Connection();
//   conn.Open();
//   var cmd = conn.CreateCommand() as MySqlCommand;
//   cmd.CommandText = @"SELECT * FROM `animals` WHERE id = @thisId;";
//   MySqlParameter thisId = new MySqlParameter();
//   thisId.ParameterName = "@thisId";
//   thisId.Value = id;
//   cmd.Parameters.Add(thisId);
//   var rdr = cmd.ExecuteReader() as MySqlDataReader;
//   int animalId = 0;
//   string animalDescription = "";
//   while (rdr.Read())
//   {
//      animalId = rdr.GetInt32(0);
//      animalDescription = rdr.GetString(1);
//   }
//   Animal foundAnimal= new Animal(animalDescription, animalId);
//   conn.Close();
//   if (conn != null)
//   {
//     conn.Dispose();
//   }
//   return foundAnimal;
// }

//   }
// }