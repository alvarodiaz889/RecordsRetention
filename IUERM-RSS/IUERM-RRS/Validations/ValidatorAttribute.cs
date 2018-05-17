using IUERM_RRS.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IUERM_RRS.Validations
{
    public class ValidatorAttribute:ValidationAttribute
    {
        private IMainRepository repository;
        public ValidatorAttribute()
        {
            repository = new MainRepositoryImpl();
        }
        protected override ValidationResult IsValid(object value,ValidationContext context)
        {

            string fieldName = context.MemberName;
            var column = repository.GetColumnsConfig().Where(o => o.ColumnName == fieldName).FirstOrDefault();
            bool isRequired = column?.Required ?? false;
            if (isRequired)
            {
                if (column.ColumnName == "SCH_OfficeId")
                {
                    var prop = context.ObjectInstance.GetType().GetProperty("SCH_Type").GetValue(context.ObjectInstance);
                    if(string.IsNullOrWhiteSpace(value?.ToString()) && prop.ToString().ToUpper() == "GENERAL")
                        return new ValidationResult("This field can't be empty");

                }
                else if (string.IsNullOrWhiteSpace(value?.ToString()))
                    return new ValidationResult("This field can't be empty");
            }
            return ValidationResult.Success;

        }
    }
}