using nosso_site_de_viagens.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using nosso_site_de_viagens.Models;

namespace nosso_site_de_viagens.Validators
{
    public class UniqueUserValidator: ValidationAttribute
    {
       
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
             DataContext _context;

            _context = validationContext.GetService<DataContext>();

            bool result = _context.Companhia.Where(u => u.Nome == value.ToString()).Any();

            return result ? new ValidationResult(FormatErrorMessage(validationContext.DisplayName)) : ValidationResult.Success;
        }
    }
}
