using System;
using FluentValidation;
using Raven.Client;
using Raven.Client.Linq;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GestUAB.Validators;
using GestUAB.Models;

namespace GestUAB
{
    public class Memorandum : IModel
    {
<<<<<<< HEAD
=======
        [GlobalizedEnum(typeof(MemorandumType), "Geral", "Diária")]
        public enum MemorandumType {
            General,
            DailyRate
        }

>>>>>>> 4ecf3330985035e0b554cac0c1da3926a12adea3
        public Memorandum ()
        {
            Id = Guid.NewGuid();
            Observation = string.Empty;
            Destiny = string.Empty;
            StartDate = DateTime.Now;
            FinishDate = DateTime.Now;
            RequesterName = string.Empty;
            BankAccount = string.Empty;
            CovenantNumber = string.Empty;
            Type = 0;
        }

        #region IModel implementation
        [Display(Name = "Código",
                 Description= "Código do memorando.")]
        [ScaffoldVisibility(all:ScaffoldVisibilityType.Hidden)] 
        public System.Guid Id { get ; set ; }
        #endregion

        [Display(Name = "Referente",
                 Description= "Texto \"Referente\" a.")]
        [ScaffoldVisibility(all:ScaffoldVisibilityType.Show)] 
        public String Observation { get ; set ; }

        [Display(Name = "Destino",
                 Description= "Local de destino.")]
        [ScaffoldVisibility(all:ScaffoldVisibilityType.Show)] 
        public String Destiny { get ; set ; }

        [Display(Name = "Data Ida",
                 Description= "Data de ida.")]
        [ScaffoldVisibility(all:ScaffoldVisibilityType.Show)] 
        public DateTime StartDate { get ; set ; }

        [Display(Name = "Data Volta",
                 Description= "Data de volta.")]
        [ScaffoldVisibility(all:ScaffoldVisibilityType.Show)] 
        public DateTime FinishDate { get ; set ; }

        [Display(Name = "Solicitante",
                 Description= "Nome do solicitante.")]
        [ScaffoldVisibility(all:ScaffoldVisibilityType.Show)] 
        public String RequesterName { get ; set ; }

        [Display(Name = "Conta Bancaria",
                 Description= "Conta para deposito.")]
        [ScaffoldVisibility(all:ScaffoldVisibilityType.Show)] 
        public String BankAccount { get ; set ; }

        [Display(Name = "Convenio",
                 Description= "Numero do convenio.")]
        [ScaffoldVisibility(all:ScaffoldVisibilityType.Show)] 
        public string CovenantNumber { get ; set ; }

        [Display(Name = "Diaria solicitada",
                 Description= "Tipo de diaria solicitada.")]
        [ScaffoldVisibility(all:ScaffoldVisibilityType.Show)] 
<<<<<<< HEAD
        public int Type { get ; set ; }
=======
        [ScaffoldSelectProperties("", SelectType.Single)]
        public MemorandumType Type { get ; set ; }
>>>>>>> 4ecf3330985035e0b554cac0c1da3926a12adea3
    }

    public class MemorandumValidator : ValidatorBase<Memorandum>
    {
        public MemorandumValidator ()
        {
            using (var session = DocumentSession) {
                RuleFor (memorandum => memorandum.RequesterName)
                    .NotEmpty ().WithMessage ("O nome do requerente é obrigatório.")
                    .Length (5, 50).WithMessage ("O nome do requerente deve conter entre 5 e 50 caracteres.")
                        .Matches (@"^[a-zA-Z][a-zA-Z0-9_]*\.?[a-zA-Z0-9_]*$").WithMessage ("Insira somente letras.");
                RuleFor (memorandum => memorandum.Observation)
                    .NotEmpty ().WithMessage ("A observaçao é obrigatório.");
                RuleFor (memorandum => memorandum.Destiny)
                    .NotEmpty ().WithMessage ("O destino é obrigatório.");
            }
            RuleSet ("Update", () => {
<<<<<<< HEAD
//                RuleFor (user => user.FirstName)
//                    .NotEmpty ().WithMessage ("O campo nome é obrigatório.")
//                    .Matches (@"^[a-zA-Z\u00C0-\u00ff\s]*$").WithMessage ("Insira somente letras.")
//                        .Length (2, 30).WithMessage ("O nome deve conter entre 2 e 30 caracteres.");
//                RuleFor (user => user.LastName)
//                    .NotEmpty ().WithMessage ("O campo sobrenome é obrigatório.")
//                    .Matches (@"^[a-zA-Z\u00C0-\u00ff\s]*$").WithMessage ("Insira somente letras.")
//                    .Length (2, 30).WithMessage ("O nome deve conter entre 2 e 30 caracteres.");
=======
                RuleFor (memorandum => memorandum.RequesterName)
                    .NotEmpty ().WithMessage ("O nome do requerente é obrigatório.")
                    .Length (5, 50).WithMessage ("O nome do requerente deve conter entre 5 e 50 caracteres.")
                        .Matches (@"^[a-zA-Z][a-zA-Z0-9_]*\.?[a-zA-Z0-9_]*$").WithMessage ("Insira somente letras.");
                RuleFor (memorandum => memorandum.Observation)
                    .NotEmpty ().WithMessage ("A observaçao é obrigatório.");
                RuleFor (memorandum => memorandum.Destiny)
                    .NotEmpty ().WithMessage ("O destino é obrigatório.");
>>>>>>> 4ecf3330985035e0b554cac0c1da3926a12adea3
            }
            );
        }
    }
}

