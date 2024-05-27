using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AuthSystem.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
// https://www.tutorialsteacher.com/mvc/mvc-model#:~:text=Adding%20a%20Model%20Class&text=In%20the%20MVC%20application%20in,name%20Student%20and%20click%20Add.&text=This%20will%20add%20a%20new%20Student%20class%20in%20model%20folder.
public class ApplicationUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string FirstName { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string LastName { get; set; }
}

