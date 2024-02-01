using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo.Tests;

public class PersonTests
{
    [Fact]
    public void Constructor_ValidName_SuccessfulInitialization()
    {
        Person person = new("Inigo");
    }
        //object initializer

        [Fact]
        public void FirstName_SetInigo_Success()
    {
        Person person =new("");
        person.FirstName = "Inigo";
        Assert.Equal("Inigo", person.FirstName);
    }
    [Fact]
    public void Constructor_SetInigo_ThrowNull()
    {
        Person? person;
        Assert.Throws<ArgumentNullException>(
        () =>
        {
            person = new(null!);
        });
    }

    [Fact]
    public void FirstName_SetNull_Success()
    {
        Person person = new(null);
        //at this point the value of FirstName is default, which before changing is null


        //expecting to throw a null exception when person assigned to null
        Assert.Throws<ArgumentNullException>(
            //saying that you are intentionally assigning null to a non null field
            //specifically so you get the null exception
            //! null forgiveness
            //person.FirstName is automatically using a setter 
            () => person.FirstName = null!);
    }

    //add validation to properties by giving setter function

    [Fact]
    public void MiddleName_SetInigo_Success()
    {
        Person person = new("Inigo")
        //any public property that is assignable you can assign inside the initializer
        {
            MiddleName = "Middle"
        };
        Assert.Equal("Middle", person.MiddleName);
    }
}
