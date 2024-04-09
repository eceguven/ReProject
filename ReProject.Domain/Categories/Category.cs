using ReProject.Core.Entities;
using ReProject.Domain.Users;
using System.ComponentModel.DataAnnotations;

namespace ReProject.Domain.Categories;

public class Category: EntityBase 
{

    
    public string Name { get; set; }

}
