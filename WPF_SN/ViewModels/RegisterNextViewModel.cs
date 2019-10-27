using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_SN.Models;

namespace WPF_SN.ViewModels
{
    class RegisterNextViewModel : Base.BaseViewModel
    {
        public List<String> listCountries { get; set; }
        public List<String> listCodes { get; set; }


        public RegisterNextViewModel()
        {
            listCountries = RegisterNextModel.getInstance().getCountriesCodes().ToList();
        }


    }
}
