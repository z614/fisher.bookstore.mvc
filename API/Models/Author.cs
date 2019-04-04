using System;
using System.Collections.Generic;

namespace Fisher.Bookstore.Bookstore.Models
{
    public class Author
    {
    public int Id {get; set;}
    public string Name{get;set;}
    public string Bio {get;set;}
    public static implicit operator Author(string v)
    {
        throw new NotImplementedException();
    }
    public void ChangeNameAuthorID(int newId)
    {
        this.Id = newId;
    }
    public void ChangeBio(string newBio)
    {
        this.Bio=newBio;
    }
    }
}