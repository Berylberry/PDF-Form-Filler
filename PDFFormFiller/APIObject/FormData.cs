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
        public bool alt_ref_partner_pref_lang_talk { get; set; } = true;
        [Description("EMP5624_E[0].Page1[0].rb_language_written2[0]")]
        public bool alt_ref_partner_pref_lang_write_ { get; set; } = true;
        //there appears to be a RP in the middle of the 
        //numbers so the separation will have to be done in API
        [Description("EMP5624_E[0].Page2[0].num_Company_Code[0]")]
        public string emp_CRAP_deduct_acc_no_1st_part { get; set; } = "40128539033";
        [Description("EMP5624_E[0].Page2[0].num_Company_Code[1]")]
        public string emp_CRAP_deduct_acc_no_2nd_part { get; set; } = "4015";
        [Description("EMP5624_E[0].Page2[0].txtF_Emp_Legal[0]")]
        public string business_legal_name { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_Mail_Adress1[0]")]
        public string business_address_line_1 { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_Mail_Adress2[0]")]
        public string business_address_line_2 { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_City[0]")]
        public string business_city { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_Country[0]")]
        public string business_country { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_Province[0]")]
        public string business_province__territory { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_Postal_Code[0]")]
        public string business_zip_code_postal { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_Mail_Adress2-1[0]")]
        public string alt_business_address_line_1 { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_Mail_Adress2-2[0]")]
        public string alt_business_address_line_2 { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_City2[0]")]
        public string alt_business_city { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_Country2[0]")]
        public string alt_business_country { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_Province2[0]")]
        public string alt_business_province__territory { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_Postal_Code2[0]")]
        public string alt_business_zip_code_postal { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_Employer_Web_Address[0]")]
        public string business_website { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_Employer_Date_Business[0]")]
        public string date_business_started { get; set; } = "2002-05-13";
        [Description("EMP5624_E[0].Page2[0].cb_individual[0]")]
        public bool business_type_sole_prop { get; set; } = false;
        [Description("EMP5624_E[0].Page2[0].cb_partnership[0]")]
        public bool business_type_partnership { get; set; } = true;
        [Description("EMP5624_E[0].Page2[0].cb_society[0]")]
        public bool business_type_corporation { get; set; } = false;
        [Description("EMP5624_E[0].Page2[0].cb_sole_propietor[0]")]
        public bool business_type_co_operative { get; set; } = false;
        [Description("EMP5624_E[0].Page2[0].cb_not_profit[0]")]
        public bool business_type_non_profit { get; set; } = false;
        [Description("EMP5624_E[0].Page2[0].cb_registred[0]")]
        public bool business_type_registered_charity { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_amout_employees[0]")]
        public string business_no_of_employees { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_business_revenu[0]")]
        public string business_annual_gross_revenue { get; set; }
        [Description("EMP5624_E[0].Page2[0].rb_receive_prog[0]")]
        public bool does_business_receive_support_through_ESDCWSP { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_If_Yes2[0]")]
        public string business_receive_support_through_ESDCWSP_details { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_position_title[0]")]
        public string principal_emp_job_title { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_first_name2[0]")]
        public string principal_emp_first_name { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_mid_name2[0]")]
        public string principal_emp_middle_name { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_last_name2[0]")]
        public string principal_emp_last_name { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_phone_number2[0]")]
        public string principal_emp_tel_no_with_ext { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_alternate_phone2[0]")]
        public string principal_emp_alt_tel_no_with_ext { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_fax_number2[0]")]
        public string principal_emp_fax_no { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_Email2[0]")]
        public string principal_emp_email { get; set; }
        [Description("EMP5624_E[0].Page2[0].rb_language_oral2[0]")]
        public bool principal_emp_pref_lang_oral { get; set; }
        [Description("EMP5624_E[0].Page2[0].rb_language_written2[0]")]
        public bool principal_emp_pref_lang_written { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_other_position_title[0]")]
        public string alt_emp_job_title { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_other_first_name2[0]")]
        public string alt_emp_first_name { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_other_mid_name2[0]")]
        public string alt_emp_middle_name { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_other_last_name2[0]")]
        public string alt_emp_last_name { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_other_phone_number2[0]")]
        public string alt_emp_tel_no_with_ext { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_other_alternate_phone2[0]")]
        public string alt_emp_alt_tel_no_with_ext { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_other_fax_number2[0]")]
        public string alt_emp_fax_no { get; set; }
        [Description("EMP5624_E[0].Page2[0].txtF_other_Email2[0]")]
        public string alt_emp_email { get; set; }
        [Description("EMP5624_E[0].Page2[0].rb_other_language_oral2[0]")]
        public bool alt_emp_pref_lang_oral { get; set; }
        [Description("EMP5624_E[0].Page2[0].rb_other_anguage_written2[0]")]
        public bool alt_emp_pref_lang_written { get; set; }
        [Description("EMP5624_E[0].Page2[0].rb_tiers[0]")]
        public bool are_you_appointing_3rd_party_complete_form { get; set; }
        [Description("EMP5624_E[0].Page3[0].num_Company_Code[0]")]
        public string third_party_business_CRAP_deduct_number_1st_part { get; set; }
        [Description("EMP5624_E[0].Page3[0].num_Company_Code[1]")]
        public string third_party_business_CRAP_deduct_number_2nd_part { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_name_Legal[0]")]
        public string third_party_business_legal_name { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_name_commercial[0]")]
        public string third_party_business_operating_name { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_other_position_title[0]")]
        public string third_party_bus_contact_job_title { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_other_first_name2[0]")]
        public string third_party_bus_contact_first_name { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_other_mid_name2[0]")]
        public string third_party_bus_contact_middle_name { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_other_last_name2[0]")]
        public string third_party_bus_contact_last_name { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_other_phone_number2[0]")]
        public string third_party_bus_contact_tel_no_with_ext { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_other_alternate_phone2[0]")]
        public string third_party_bus_contact_alt_tel_no_with_ext { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_other_fax_number2[0]")]
        public string third_party_bus_contact_fax_no { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_other_Email2[0]")]
        public string third_party_bus_contact_email { get; set; }
        [Description("EMP5624_E[0].Page3[0].rb_other_language_oral2[0]")]
        public bool? third_party_bus_contact_pref_lang_oral { get; set; }
        [Description("EMP5624_E[0].Page3[0].rb_other_anguage_written2[0]")]
        public bool? third_party_bus_contact_pref_lang_written { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_Mail_Adress1[0]")]
        public string third_party_bus_address_line_1 { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_Mail_Adress2[0]")]
        public string third_party_bus_address_line_2 { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_City[0]")]
        public string third_party_bus_city { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_Country[0]")]
        public string third_party_bus_country { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_Province[0]")]
        public string third_party_bus_province_territory_state { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_Postal_Code[0]")]
        public string third_party_bus_postal_zip_code { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_Mail_Adress2-1[0]")]
        public string third_party_bus_alt_mail_address_line_1 { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_Mail_Adress2-2[0]")]
        public string third_party_bus_alt_mail_address_line_2 { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_City2[0]")]
        public string third_party_bus_alt_mail_city { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_Country2[0]")]
        public string third_party_bus_alt_mail_country { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_Province2[0]")]
        public string third_party_bus_alt_mail_province_territory_state { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_Postal_Code2[0]")]
        public string third_party_bus_alt_mail_postal_zip_code { get; set; }
        [Description("EMP5624_E[0].Page3[0].rb_tiers[0]")]
        public bool? is_3rd_party_paid_by_employer_to_represent { get; set; }
        [Description("EMP5624_E[0].Page3[0].cb_CCRC[0]")]
        public bool? is_3rd_party_a_CRCC_member { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_CCRC_number[0]")]
        public string third_party_CRCC_member_ID { get; set; }
        [Description("EMP5624_E[0].Page3[0].cb_Law_member[0]")]
        public bool? is_third_party_member_law_society { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_Law_member_prov[0]")]
        public string third_party_law_society_province { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_Law_member_numb[0]")]
        public string third_parrty_law_society_member_ID { get; set; }
        [Description("EMP5624_E[0].Page3[0].cb_Lawyer[0]")]
        public bool? is_third_party_member_CDNDQ { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_Law_numb[0]")]
        public string third_party_CDNDQ_member_ID { get; set; }
        [Description("EMP5624_E[0].Page3[0].cb_Other_member[0]")]
        public bool? is_third_party_member_other_paid { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_Other_specify[0]")]
        public string third_party_other_member_paid_specify { get; set; }
        [Description("EMP5624_E[0].Page3[0].cb_family[0]")]
        public bool? is_third_party_family_or_friend { get; set; }
        [Description("EMP5624_E[0].Page3[0].cb_org_member[0]")]
        public bool? is_third_party_member_of_NGO_or_religious_org { get; set; }
        [Description("EMP5624_E[0].Page3[0].cb_rules_member[0]")]
        public bool? is_third_party_ICCRC_good_reputation { get; set; }
        [Description("EMP5624_E[0].Page3[0].cb_other_member[0]")]
        public bool? is_third_party_member_other_free { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_Other_specify2[0]")]
        public bool third_party_other_member_free_specify { get; set; }
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
