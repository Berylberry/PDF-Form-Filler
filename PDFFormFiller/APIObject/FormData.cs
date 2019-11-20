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
        public string third_party_other_member_free_specify { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_position_title[0]")]
        public string job_offer_title { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_code[0]")]
        public string job_offer_NOC { get; set; }
        [Description("EMP5624_E[0].Page3[0].txtF_position_title[1]")]
        public string how_many_TFWsis_employer_requesting { get; set; }
        [Description("EMP5624_E[0].Page4[0].txtF_MainDuties[0]")]
        public string job_offer_main_duties { get; set; }
        [Description("EMP5624_E[0].Page4[0].txtF_Date_E[0]")]
        public string expected_employment_start_date { get; set; }
        [Description("EMP5624_E[0].Page4[0].txtF_number_days[0]")]
        public string expected_employment_duration_number { get; set; }
        [Description("EMP5624_E[0].Page4[0].chkB_english1[0]")]
        public bool expected_employment_duration_days { get; set; }
        [Description("EMP5624_E[0].Page4[0].chkB_english1[1]")]
        public bool expected_employment_duration_weeks { get; set; }
        [Description("EMP5624_E[0].Page4[0].chkB_english1[2]")]
        public bool expected_employment_duration_months { get; set; }
        [Description("EMP5624_E[0].Page4[0].chkB_english1[3]")]
        public bool expected_employment_duration_years { get; set; }
        [Description("EMP5624_E[0].Page4[0].txtF_justification[0]")]
        public string employment_duration_ratiionale { get; set; }
        [Description("EMP5624_E[0].Page4[0].rb_job_syndic[0]")]
        public bool is_job_positiion_part_of_a_uniion { get; set; }
        [Description("EMP5624_E[0].Page4[0].chkB_OrallyIn[0]")]
        public bool? is_oral_communication_required { get; set; }
        [Description("EMP5624_E[0].Page4[0].chkB_english1[4]")]
        public bool? oral_eng_ability { get; set; }
        [Description("EMP5624_E[0].Page4[0].chkB_French1[0]")]
        public bool? oral_fr_ability { get; set; }
        [Description("EMP5624_E[0].Page4[0].chkB_English_French1[0]")]
        public bool? oral_eng_and_fr_ability { get; set; }
        [Description("EMP5624_E[0].Page4[0].chkB_TheOffer[0]")]
        public bool? is_written_communication_required { get; set; }
        [Description("EMP5624_E[0].Page4[0].chkB_english2[0]")]
        public bool? eng_writing_ability { get; set; }
        [Description("EMP5624_E[0].Page4[0].chkB_french2[0]")]
        public bool? fr_writing_ability { get; set; }
        [Description("EMP5624_E[0].Page4[0].chkB_English_French2[0]")]
        public bool? eng_and_fr_writing_ability { get; set; }
        [Description("EMP5624_E[0].Page4[0].chkB_TheOffer2[0]")]
        public bool? is_specific_lang_communication_not_req { get; set; }
        [Description("EMP5624_E[0].Page4[0].txtF_ProvideDetails2[0]")]
        public string explain_specific_lang_not_required { get; set; }
        [Description("EMP5624_E[0].Page4[0].chkB_TheOffer2[1]")]
        public bool? is_lang_required_other_than_eng_and_fr { get; set; }
        [Description("EMP5624_E[0].Page4[0].txtF_ProvideDetails3[0]")]
        public string explain_other_lang_required { get; set; }
        [Description("EMP5624_E[0].Page4[0].RadioButtonList[0]")]
        public string min_qualify_req_for_job { get; set; }
        [Description("EMP5624_E[0].Page4[0].txtF_AdditionalInformation[0]")]
        public string min_qualify_req_for_job_additional_info { get; set; }
        [Description("EMP5624_E[0].Page4[0].txtF_MainDuties[1]")]
        public string min_experience_or_skills_for_job { get; set; }
        [Description("EMP5624_E[0].Page4[0].Yes_E[0]")]
        public bool have_you_tried_to_recruit_canada_residents_yes { get; set; }
        [Description("EMP5624_E[0].Page4[0].txtF_AdditionalInformation[1]")]
        public string have_you_tried_recruit_yes_explain_efforts { get; set; }
        [Description("EMP5624_E[0].Page4[0].No_E[0]")]
        public bool have_you_tried_to_recruit_canada_residents_no { get; set; }
        [Description("EMP5624_E[0].Page4[0].txtF_No_AdditionalInformation[0]")]
        public string have_you_tried_no_explain { get; set; }
        [Description("EMP5624_E[0].Page5[0].rb_canadian_empl[0]")]
        public bool have_employees_been_laid_off_in_position { get; set; }
        [Description("EMP5624_E[0].Page5[0].txtF_canadian_how_many[0]")]
        public string how_many_canadian_residents_laid_off { get; set; }
        [Description("EMP5624_E[0].Page5[0].txtF_TET_how_many[0]")]
        public string how_many_TFWs_laid_off { get; set; }
        [Description("EMP5624_E[0].Page5[0].txtF_info[0]")]
        public string layoffs_reasons { get; set; }
        [Description("EMP5624_E[0].Page5[0].rb_TET_empl[0]")]
        public bool will_hiring_TFW_affect_canadian_residents_negatively { get; set; }
        [Description("EMP5624_E[0].Page5[0].txtF_No_add_info[0]")]
        public string explain_impact_of_hiring_TFW { get; set; }
        [Description("EMP5624_E[0].Page5[0].txtF_low_wage[0]")]
        public string low_wage_for_position { get; set; }
        [Description("EMP5624_E[0].Page5[0].txtF_high_wage[0]")]
        public string high_wage_for_position { get; set; }
        [Description("EMP5624_E[0].Page5[0].chkB_no_employees[0]")]
        public bool there_are_currently_no_employees_working_at_this_position { get; set; }
        [Description("EMP5624_E[0].Page5[0].rb_hours[0]")]
        public bool is_job_offer_for_full_time_employment { get; set; }
        [Description("EMP5624_E[0].Page5[0].txtF_IfNo[0]")]
        public string not_full_time_explanation { get; set; }
        [Description("EMP5624_E[0].Page5[0].txtFhours[0]")]
        public string how_many_hours_will_TFW_work_each_day { get; set; }
        [Description("EMP5624_E[0].Page5[0].txtF_week[0]")]
        public string how_many_hours_will_TFW_work_each_week { get; set; }
        [Description("EMP5624_E[0].Page5[0].txtF_month[0]")]
        public string how_many_hours_will_TFW_work_each_month { get; set; }
        [Description("EMP5624_E[0].Page5[0].txtF_salary_hours[0]")]
        public string regular_wage_per_hour_for_TFW { get; set; }
        [Description("EMP5624_E[0].Page5[0].txtF_salary_overtime[0]")]
        public string overtime_wage_per_hour_for_TFW { get; set; }
        [Description("EMP5624_E[0].Page5[0].txtF_salary_after[0]")]
        public string overtime_wage_start_after_how_many_hours_per_day { get; set; }
        [Description("EMP5624_E[0].Page5[0].txtF_hour_week[0]")]
        public string overtime_wage_start_after_how_many_hours_per_week { get; set; }
        [Description("EMP5624_E[0].Page5[0].rb_salary_conversion[0]")]
        public bool is_wage_converted { get; set; }
        [Description("EMP5624_E[0].Page5[0].txtF_yes_add_info[0]")]
        public string wage_conversion_calculations { get; set; }
        [Description("EMP5624_E[0].Page5[0].chkB_DisabilityInsurance[0]")]
        public bool job_benefit_disability_insurance { get; set; }
        [Description("EMP5624_E[0].Page5[0].chkB_DentalInsurance[0]")]
        public bool job_benefit_dental_insurance { get; set; }
        [Description("EMP5624_E[0].Page5[0].chkB_Pension[0]")]
        public bool job_benefit_pension { get; set; }
        [Description("EMP5624_E[0].Page5[0].chkB_ExtendedMed[0]")]
        public bool job_benefit_extended_medical_insurance { get; set; }
        [Description("EMP5624_E[0].Page5[0].txtF_OtherBenefits[0]")]
        public string other_job_benefits { get; set; }
        [Description("EMP5624_E[0].Page5[0].txtF_Days[0]")]
        public string job_vacation_days_per_year { get; set; }
        [Description("EMP5624_E[0].Page5[0].txtF_Remuneration[0]")]
        public string job_vacation_renumeration { get; set; }
        [Description("EMP5624_E[0].Page6[0].txtF_principal_activity[0]")]
        public string principal_business_activity_at_work_location { get; set; }
        [Description("EMP5624_E[0].Page6[0].txtF_commercial_name[0]")]
        public string business_operating_name_at_work_location { get; set; }
        [Description("EMP5624_E[0].Page6[0].txtF_where[0]")]
        public string exact_TFW_work_location { get; set; }
        [Description("EMP5624_E[0].Page6[0].txtF_City2[0]")]
        public string TFW_work_loc_city { get; set; }
        [Description("EMP5624_E[0].Page6[0].txtF_Province2[0]")]
        public string TFW_work_loc_province { get; set; }
        [Description("EMP5624_E[0].Page6[0].txtF_Postal_Code2[0]")]
        public string TFW_work_loc_postal_code { get; set; }
        [Description("EMP5624_E[0].Page6[0].txtF_where[1]")]
        public string other_job_offer_work_location { get; set; }
        [Description("EMP5624_E[0].Page6[0].txtF_City2[1]")]
        public string other_job_offer_work_location_city { get; set; }
        [Description("EMP5624_E[0].Page6[0].txtF_Province2[1]")]
        public string other_job_offer_work_location_province { get; set; }
        [Description("EMP5624_E[0].Page6[0].txtF_Postal_Code2[1]")]
        public string other_job_offer_work_location_postal_code { get; set; }
        [Description("EMP5624_E[0].Page6[0].rb_conflict[0]")]
        public bool is_there_labour_dispute_at_any_location { get; set; }
        [Description("EMP5624_E[0].Page6[0].txtF_yes_add_info[0]")]
        public string dispute_explanation { get; set; }
        [Description("EMP5624_E[0].Page6[0].rb_conflict[1]")]
        public bool does_org_have_active_LMBP { get; set; }
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
