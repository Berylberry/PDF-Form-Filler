using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFFormFiller.APIObject
{
    public partial class FormData
    {
        [Description("EMP5624_E[0].Page1[0].Yes_business[0]")]
        public bool does_position_appear_on_GTO_yes { get; set; } = true;
        [Description("EMP5624_E[0].Page1[0].No_business[0]")]
        public bool does_position_appear_on_GTO_no { get; set; } = false;
        [Description("EMP5624_E[0].Page1[0].Yes_inn[0]")]
        public bool? are_referred_toGTO_yes { get; set; } = true;
        [Description("EMP5624_E[0].Page1[0].No_inn[0]")]
        public bool? are_referred_toGTO_no { get; set; } = false;
        [Description("EMP5624_E[0].Page1[0].txtF_des_part[0]")]
        public string ref_partner_org_name { get; set; } = "Chipotle";
        [Description("EMP5624_E[0].Page1[0].txtF_first_name[0]")]
        public string ref_partner_f_name { get; set; } = "Terrance";
        [Description("EMP5624_E[0].Page1[0].txtF_mid_name[0]")]
        public string ref_partner_m_name { get; set; } = "Kwame";
        [Description("EMP5624_E[0].Page1[0].txtF_last_name[0]")]
        public string ref_partner_l_name { get; set; } = "Traylor";
        [Description("EMP5624_E[0].Page1[0].txtF_phone_number[0]")]
        public string ref_partner_tel_no_with_ext { get; set; } = "+1 650-267-8309";
        [Description("EMP5624_E[0].Page1[0].txtF_alternate_phone[0]")]
        public string ref_partner_alt_tel_no_with_ext { get; set; } = "401-406-7588";
        [Description("EMP5624_E[0].Page1[0].txtF_fax_number[0]")]
        public string ref_partner_fax { get; set; } = "401-285-3902";
        [Description("EMP5624_E[0].Page1[0].txtF_Email[0]")]
        public string ref_partner_email { get; set; } = "lola1985@gmail.com";
        [Description("EMP5624_E[0].Page1[0].rb_language_oral[0]")]
        public bool? ref_partner_pref_lang_talk { get; set; } = true;
        [Description("EMP5624_E[0].Page1[0].rb_language_written[0]")]
        public bool? ref_partner_pref_lang_write { get; set; } = true;
        [Description("EMP5624_E[0].Page1[0].txtF_first_name2[0]")]
        public string alt_ref_partner_f_name { get; set; } = "Joseph ";
        [Description("EMP5624_E[0].Page1[0].txtF_mid_name2[0]")]
        public string alt_ref_partner_m_name { get; set; } = "Eben";
        [Description("EMP5624_E[0].Page1[0].txtF_last_name2[0]")]
        public string alt_ref_partner_l_name { get; set; } = "Elam";
        [Description("EMP5624_E[0].Page1[0].txtF_phone_number2[0]")]
        public string alt_ref_partner_tel_no_with_ext { get; set; } = "+1 401-285-3902";
        [Description("EMP5624_E[0].Page1[0].txtF_alternate_phone2[0]")]
        public string alt_ref_partner_alt_tel_no { get; set; } = "+1 401-285-3902";
        [Description("EMP5624_E[0].Page1[0].txtF_fax_number2[0]")]
        public string alt_ref_partner_fax { get; set; } = "401-285-3902";
        [Description("EMP5624_E[0].Page1[0].txtF_Email2[0]")]
        public string alt_ref_partner_email { get; set; } = "TerranceKTraylor@teleworm.us";
        [Description("EMP5624_E[0].Page1[0].rb_language_oral2[0]")]
        public bool? alt_ref_partner_pref_lang_talk { get; set; } = true;
        [Description("EMP5624_E[0].Page1[0].rb_language_written2[0]")]
        public bool? alt_ref_partner_pref_lang_write_ { get; set; } = true;
        //there appears to be a RP in the middle of the 
        //numbers so the separation will have to be done in API
        [Description("EMP5624_E[0].Page2[0].num_Company_Code[0]")]
        public string emp_CRAP_deduct_acc_no_1st_part { get; set; } = "40128539033";
        [Description("EMP5624_E[0].Page2[0].num_Company_Code[1]")]
        public string emp_CRAP_deduct_acc_no_2nd_part { get; set; } = "4015";
        [Description("EMP5624_E[0].Page2[0].txtF_Emp_Legal[0]")]
        public string business_legal_name { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_Mail_Adress1[0]")]
        public bool business_address_line_1 { get; set; }
        [Description("")]
        public bool business_address_line_2 { get; set; }
        [Description("")]
        public bool business_city { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
        [Description("")]
        public bool does_position_appear_on_GTO_yes { get; set; }
    }
}
