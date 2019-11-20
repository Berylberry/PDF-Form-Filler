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
        public bool does_position_appear_on_GTO_yes = true;

        [Description("EMP5624_E[0].Page1[0].No_business[0]")]
        public bool does_position_appear_on_GTO_no = false;
        [Description("EMP5624_E[0].Page1[0].Yes_inn[0]")]
        public bool? are_referred_toGTO_yes { get; set; }= true;
        [Description("EMP5624_E[0].Page1[0].No_inn[0]")]
        public bool? are_referred_toGTO_no = false;
        [Description("EMP5624_E[0].Page1[0].txtF_des_part[0]")]
        public string ref_partner_org_name = "Chipotle";
        [Description("EMP5624_E[0].Page1[0].txtF_first_name[0]")]
        public string ref_partner_f_name = "Terrance";
        [Description("EMP5624_E[0].Page1[0].txtF_mid_name[0]")]
        public string ref_partner_m_name = "Kwame";
        [Description("EMP5624_E[0].Page1[0].txtF_last_name[0]")]
        public string ref_partner_l_name = "Traylor";
        [Description("EMP5624_E[0].Page1[0].txtF_phone_number[0]")]
        public string ref_partner_tel_no_with_ext = "+1 650-267-8309";
        [Description("EMP5624_E[0].Page1[0].txtF_alternate_phone[0]")]
        public string ref_partner_alt_tel_no_with_ext = "401-406-7588";
        [Description("EMP5624_E[0].Page1[0].txtF_fax_number[0]")]
        public string ref_partner_fax = "401-285-3902";
        [Description("EMP5624_E[0].Page1[0].txtF_Email[0]")]
        public string ref_partner_email = "lola1985@gmail.com";
        [Description("EMP5624_E[0].Page1[0].rb_language_oral[0]")]
        public bool? ref_partner_pref_lang_talk = true;
        [Description("EMP5624_E[0].Page1[0].rb_language_written[0]")]
        public bool? ref_partner_pref_lang_write = true;
        [Description("EMP5624_E[0].Page1[0].txtF_first_name2[0]")]
        public string alt_ref_partner_f_name = "Joseph ";
        [Description("EMP5624_E[0].Page1[0].txtF_mid_name2[0]")]
        public string alt_ref_partner_m_name = "Eben";
        [Description("EMP5624_E[0].Page1[0].txtF_last_name2[0]")]
        public string alt_ref_partner_l_name = "Elam";
        [Description("EMP5624_E[0].Page1[0].txtF_phone_number2[0]")]
        public string alt_ref_partner_tel_no_with_ext = "+1 401-285-3902";
        [Description("EMP5624_E[0].Page1[0].txtF_alternate_phone2[0]")]
        public string alt_ref_partner_alt_tel_no = "+1 401-285-3902";
        [Description("EMP5624_E[0].Page1[0].txtF_fax_number2[0]")]
        public string alt_ref_partner_fax = "401-285-3902";
        [Description("EMP5624_E[0].Page1[0].txtF_Email2[0]")]
        public string alt_ref_partner_email = "TerranceKTraylor@teleworm.us";
        [Description("EMP5624_E[0].Page1[0].rb_language_oral2[0]")]
        public bool alt_ref_partner_pref_lang_talk = true;
        [Description("EMP5624_E[0].Page1[0].rb_language_written2[0]")]
        public bool alt_ref_partner_pref_lang_write_ = true;
        //there appears to be a RP in the middle of the 
        //numbers so the separation will have to be done in API
        [Description("EMP5624_E[0].Page2[0].num_Company_Code[0]")]
        public string emp_CRAP_deduct_acc_no_1st_part = "40128539033";
        [Description("EMP5624_E[0].Page2[0].num_Company_Code[1]")]
        public string emp_CRAP_deduct_acc_no_2nd_part = "4015";
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
        public string date_business_started = "2002-05-13";
        [Description("EMP5624_E[0].Page2[0].cb_individual[0]")]
        public bool business_type_sole_prop = false;
        [Description("EMP5624_E[0].Page2[0].cb_partnership[0]")]
        public bool business_type_partnership = true;
        [Description("EMP5624_E[0].Page2[0].cb_society[0]")]
        public bool business_type_corporation = false;
        [Description("EMP5624_E[0].Page2[0].cb_sole_propietor[0]")]
        public bool business_type_co_operative = false;
        [Description("EMP5624_E[0].Page2[0].cb_not_profit[0]")]
        public bool business_type_non_profit = false;
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
        [Description("EMP5624_E[0].Page6[0].txtF_advantage[0]")]
        public string what_mandatory_achievement_by_hiring_TFW { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row1[0].TextField1[0]")]
        public string mandatory_milestone_1 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row1[0].TextField2[0]")]
        public string mandatory_target_1 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row1[0].DateField1[0]")]
        public string mandatory_start_date_1 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row1[0].DateField2[0]")]
        public string mandatory_end_date_1 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row2[0].TextField3[0]")]
        public string mandatory_milestone_2 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row2[0].TextField4[0]")]
        public string mandatory_target_2 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row2[0].DateField3[0]")]
        public string mandatory_start_date_2 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row2[0].DateField4[0]")]
        public string mandatory_end_date_2 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row3[0].TextField5[0]")]
        public string mandatory_milestone_3 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row3[0].TextField6[0]")]
        public string mandatory_target_3 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row3[0].DateField5[0]")]
        public string mandatory_start_date_3 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row3[0].DateField6[0]")]
        public string mandatory_end_date_3 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row4[0].TextField7[0]")]
        public string mandatory_milestone_4 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row4[0].TextField8[0]")]
        public string mandatory_target_4 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row4[0].DateField7[0]")]
        public string mandatory_start_date_4 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row4[0].DateField8[0]")]
        public string mandatory_end_date_4 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row5[0].TextField9[0]")]
        public string mandatory_milestone_5 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row5[0].TextField10[0]")]
        public string mandatory_target_5 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row5[0].DateField9[0]")]
        public string mandatory_start_date_5 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row5[0].DateField10[0]")]
        public string mandatory_end_date_5 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row6[0].TextField11[0]")]
        public string mandatory_milestone_6 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row6[0].TextField12[0]")]
        public string mandatory_target_6 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row6[0].DateField11[0]")]
        public string mandatory_start_date_6 { get; set; }
        [Description("EMP5624_E[0].Page6[0].Table1[0].Row6[0].DateField12[0]")]
        public string mandatory_end_date_6 { get; set; }
        [Description("EMP5624_E[0].Page7[0].txtF_advantage1[0]")]
        public string what_complementary_1_achievement_by_hiring_TFW { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row1[0].TextField1[0]")]
        public string complementary_1_milestone_1 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row1[0].TextField2[0]")]
        public string complementary_1_target_1 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row1[0].DateField1[0]")]
        public string complementary_1_start_date_1 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row1[0].DateField2[0]")]
        public string complementary_1_end_date_1 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row2[0].TextField3[0]")]
        public string complementary_1_milestone_2 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row2[0].TextField4[0]")]
        public string complementary_1_target_2 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row2[0].DateField3[0]")]
        public string complementary_1_start_date_2 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row2[0].DateField4[0]")]
        public string complementary_1_end_date_2 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row3[0].TextField5[0]")]
        public string complementary_1_milestone_3 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row3[0].TextField6[0]")]
        public string complementary_1_target_3 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row3[0].DateField5[0]")]
        public string complementary_1_start_date_3 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row3[0].DateField6[0]")]
        public string complementary_1_end_date_3 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row4[0].TextField7[0]")]
        public string complementary_1_milestone_4 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row4[0].TextField8[0]")]
        public string complementary_1_target_4 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row4[0].DateField7[0]")]
        public string complementary_1_start_date_4 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row4[0].DateField8[0]")]
        public string complementary_1_end_date_4 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row5[0].TextField9[0]")]
        public string complementary_1_milestone_5 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row5[0].TextField10[0]")]
        public string complementary_1_target_5 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row5[0].DateField9[0]")]
        public string complementary_1_start_date_5 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row5[0].DateField10[0]")]
        public string complementary_1_end_date_5 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row6[0].TextField11[0]")]
        public string complementary_1_milestone_6 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row6[0].TextField12[0]")]
        public string complementary_1_target_6 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row6[0].DateField11[0]")]
        public string complementary_1_start_date_6 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table1[0].Row6[0].DateField12[0]")]
        public string complementary_1_end_date_6 { get; set; }
        [Description("EMP5624_E[0].Page7[0].txtF_advantage1[1]")]
        public string what_complementary_2_achievement_by_hiring_TFW { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row1[0].TextField1[0]")]
        public string complementary_2_milestone_1 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row1[0].TextField2[0]")]
        public string complementary_2_target_1 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row1[0].DateField1[0]")]
        public string complementary_2_start_date_1 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row1[0].DateField2[0]")]
        public string complementary_2_end_date_1 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row2[0].TextField3[0]")]
        public string complementary_2_milestone_2 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row2[0].TextField4[0]")]
        public string complementary_2_target_2 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row2[0].DateField3[0]")]
        public string complementary_2_start_date_2 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row2[0].DateField4[0]")]
        public string complementary_2_end_date_2 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row3[0].TextField5[0]")]
        public string complementary_2_milestone_3 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row3[0].TextField6[0]")]
        public string complementary_2_target_3 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row3[0].DateField5[0]")]
        public string complementary_2_start_date_3 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row3[0].DateField6[0]")]
        public string complementary_2_end_date_3 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row4[0].TextField7[0]")]
        public string complementary_2_milestone_4 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row4[0].TextField8[0]")]
        public string complementary_2_target_4 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row4[0].DateField7[0]")]
        public string complementary_2_start_date_4 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row4[0].DateField8[0]")]
        public string complementary_2_end_date_4 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row5[0].TextField9[0]")]
        public string complementary_2_milestone_5 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row5[0].TextField10[0]")]
        public string complementary_2_target_5 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row5[0].DateField9[0]")]
        public string complementary_2_start_date_5 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row5[0].DateField10[0]")]
        public string complementary_2_end_date_5 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row6[0].TextField11[0]")]
        public string complementary_2_milestone_6 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row6[0].TextField12[0]")]
        public string complementary_2_target_6 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row6[0].DateField11[0]")]
        public string complementary_2_start_date_6 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table2[0].Row6[0].DateField12[0]")]
        public string complementary_2_end_date_6 { get; set; }
        [Description("EMP5624_E[0].Page7[0].txtF_advantage1[2]")]
        public string what_complementary_3_achievement_by_hiring_TFW { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row1[0].TextField1[0]")]
        public string complementary_3_milestone_1 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row1[0].TextField2[0]")]
        public string complementary_3_target_1 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row1[0].DateField1[0]")]
        public string complementary_3_start_date_1 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row1[0].DateField2[0]")]
        public string complementary_3_end_date_1 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row2[0].TextField3[0]")]
        public string complementary_3_milestone_2 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row2[0].TextField4[0]")]
        public string complementary_3_target_2 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row2[0].DateField3[0]")]
        public string complementary_3_start_date_2 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row2[0].DateField4[0]")]
        public string complementary_3_end_date_2 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row3[0].TextField5[0]")]
        public string complementary_3_milestone_3 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row3[0].TextField6[0]")]
        public string complementary_3_target_3 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row3[0].DateField5[0]")]
        public string complementary_3_start_date_3 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row3[0].DateField6[0]")]
        public string complementary_3_end_date_3 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row4[0].TextField7[0]")]
        public string complementary_3_milestone_4 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row4[0].TextField8[0]")]
        public string complementary_3_target_4 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row4[0].DateField7[0]")]
        public string complementary_3_start_date_4 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row4[0].DateField8[0]")]
        public string complementary_3_end_date_4 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row5[0].TextField9[0]")]
        public string complementary_3_milestone_5 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row5[0].TextField10[0]")]
        public string complementary_3_target_5 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row5[0].DateField9[0]")]
        public string complementary_3_start_date_5 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row5[0].DateField10[0]")]
        public string complementary_3_end_date_5 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row6[0].TextField11[0]")]
        public string complementary_3_milestone_6 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row6[0].TextField12[0]")]
        public string complementary_3_target_6 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row6[0].DateField11[0]")]
        public string complementary_3_start_date_6 { get; set; }
        [Description("EMP5624_E[0].Page7[0].Table3[0].Row6[0].DateField12[0]")]
        public string complementary_3_end_date_6 { get; set; }
        [Description("EMP5624_E[0].Page8[0].txtF_advantage1[0]")]
        public string what_complementary_4_achievement_by_hiring_TFW { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row1[0].TextField1[0]")]
        public string complementary_4_milestone_1 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row1[0].TextField2[0]")]
        public string complementary_4_target_1 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row1[0].DateField1[0]")]
        public string complementary_4_start_date_1 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row1[0].DateField2[0]")]
        public string complementary_4_end_date_1 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row2[0].TextField3[0]")]
        public string complementary_4_milestone_2 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row2[0].TextField4[0]")]
        public string complementary_4_target_2 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row2[0].DateField3[0]")]
        public string complementary_4_start_date_2 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row2[0].DateField4[0]")]
        public string complementary_4_end_date_2 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row3[0].TextField5[0]")]
        public string complementary_4_milestone_3 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row3[0].TextField6[0]")]
        public string complementary_4_target_3 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row3[0].DateField5[0]")]
        public string complementary_4_start_date_3 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row3[0].DateField6[0]")]
        public string complementary_4_end_date_3 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row4[0].TextField7[0]")]
        public string complementary_4_milestone_4 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row4[0].TextField8[0]")]
        public string complementary_4_target_4 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row4[0].DateField7[0]")]
        public string complementary_4_start_date_4 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row4[0].DateField8[0]")]
        public string complementary_4_end_date_4 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row5[0].TextField9[0]")]
        public string complementary_4_milestone_5 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row5[0].TextField10[0]")]
        public string complementary_4_target_5 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row5[0].DateField9[0]")]
        public string complementary_4_start_date_5 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row5[0].DateField10[0]")]
        public string complementary_4_end_date_5 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row6[0].TextField11[0]")]
        public string complementary_4_milestone_6 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row6[0].TextField12[0]")]
        public string complementary_4_target_6 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row6[0].DateField11[0]")]
        public string complementary_4_start_date_6 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table1[0].Row6[0].DateField11[0]")]
        public string complementary_4_end_date_6 { get; set; }
        [Description("EMP5624_E[0].Page8[0].txtF_advantage1[1]")]
        public string what_complementary_5_achievement_by_hiring_TFW { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row1[0].TextField1[0]")]
        public string complementary_5_milestone_1 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row1[0].TextField2[0]")]
        public string complementary_5_target_1 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row1[0].DateField1[0]")]
        public string complementary_5_start_date_1 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row1[0].DateField2[0]")]
        public string complementary_5_end_date_1 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row2[0].TextField3[0]")]
        public string complementary_5_milestone_2 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row2[0].TextField4[0]")]
        public string complementary_5_target_2 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row2[0].DateField3[0]")]
        public string complementary_5_start_date_2 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row2[0].DateField4[0]")]
        public string complementary_5_end_date_2 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row3[0].TextField5[0]")]
        public string complementary_5_milestone_3 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row3[0].TextField6[0]")]
        public string complementary_5_target_3 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row3[0].DateField5[0]")]
        public string complementary_5_start_date_3 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row3[0].DateField6[0]")]
        public string complementary_5_end_date_3 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row4[0].TextField7[0]")]
        public string complementary_5_milestone_4 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row4[0].TextField8[0]")]
        public string complementary_5_target_4 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row4[0].DateField7[0]")]
        public string complementary_5_start_date_4 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row4[0].DateField8[0]")]
        public string complementary_5_end_date_4 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row5[0].TextField9[0]")]
        public string complementary_5_milestone_5 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row5[0].TextField10[0]")]
        public string complementary_5_target_5 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row5[0].DateField9[0]")]
        public string complementary_5_start_date_5 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row5[0].DateField10[0]")]
        public string complementary_5_end_date_5 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row6[0].TextField11[0]")]
        public string complementary_5_milestone_6 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row6[0].TextField12[0]")]
        public string complementary_5_target_6 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row6[0].DateField11[0]")]
        public string complementary_5_start_date_6 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table2[0].Row6[0].DateField12[0]")]
        public string complementary_5_end_date_6 { get; set; }
        [Description("EMP5624_E[0].Page8[0].txtF_advantage1[2]")]
        public string what_complementary_6_achievement_by_hiring_TFW { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row1[0].TextField1[0]")]
        public string complementary_6_milestone_1 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row1[0].TextField2[0]")]
        public string complementary_6_target_1 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row1[0].DateField1[0]")]
        public string complementary_6_start_date_1 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row1[0].DateField2[0]")]
        public string complementary_6_end_date_1 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row2[0].TextField3[0]")]
        public string complementary_6_milestone_2 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row2[0].TextField4[0]")]
        public string complementary_6_target_2 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row2[0].DateField3[0]")]
        public string complementary_6_start_date_2 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row2[0].DateField4[0]")]
        public string complementary_6_end_date_2 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row3[0].TextField5[0]")]
        public string complementary_6_milestone_3 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row3[0].TextField6[0]")]
        public string complementary_6_target_3 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row3[0].DateField5[0]")]
        public string complementary_6_start_date_3 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row3[0].DateField6[0]")]
        public string complementary_6_end_date_3 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row4[0].TextField7[0]")]
        public string complementary_6_milestone_4 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row4[0].TextField8[0]")]
        public string complementary_6_target_4 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row4[0].DateField7[0]")]
        public string complementary_6_start_date_4 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row4[0].DateField8[0]")]
        public string complementary_6_end_date_4 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row5[0].TextField9[0]")]
        public string complementary_6_milestone_5 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row5[0].TextField10[0]")]
        public string complementary_6_target_5 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row5[0].DateField9[0]")]
        public string complementary_6_start_date_5 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row5[0].DateField10[0]")]
        public string complementary_6_end_date_5 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row6[0].TextField11[0]")]
        public string complementary_6_milestone_6 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row6[0].TextField12[0]")]
        public string complementary_6_target_6 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row6[0].DateField11[0]")]
        public string complementary_6_start_date_6 { get; set; }
        [Description("EMP5624_E[0].Page8[0].Table3[0].Row6[0].DateField12[0]")]
        public string complementary_6_end_date_6 { get; set; }
        [Description("EMP5624_E[0].Page9[0].txtF_Employer_Signature[0]")]
        public string sign_of_employer { get; set; }
        [Description("EMP5624_E[0].Page9[0].txtF_Employer_Print_Name[0]")]
        public string sign_printed_name_of_employer { get; set; }
        [Description("EMP5624_E[0].Page9[0].txtF_Employer_Title[0]")]
        public string title_of_employer { get; set; }
        [Description("EMP5624_E[0].Page9[0].txtF_Today_Date_1[0]")]
        public string signing_date { get; set; }
        [Description("EMP5624_E[0].Page9[0].txtF_Employer_Signature[1]")]
        public string sign_of_third_party_rep { get; set; }
        [Description("EMP5624_E[0].Page9[0].txtF_Employer_Print_Name[1]")]
        public string printed_name_of_third_party_rep { get; set; }
        [Description("EMP5624_E[0].Page9[0].txtF_Today_Date_1[1]")]
        public string third_party_sign_date { get; set; }
        [Description("EMP5624_E[0].Page9[0].txtF_Employer_Signature[2]")]
        public string appt_sign_of_employer { get; set; }
        [Description("EMP5624_E[0].Page9[0].txtF_Employer_Print_Name[2]")]
        public string appt_sign_printed_name_of_employer { get; set; }
        [Description("EMP5624_E[0].Page9[0].txtF_Today_Date_1[2]")]
        public string appt_sign_date { get; set; }
        [Description("EMP5624_E[0].Page9[0].txtF_Employer_Signature[3]")]
        public string appt_sign_of_witness { get; set; }
        [Description("EMP5624_E[0].Page9[0].txtF_Employer_Print_Name[3]")]
        public string printed_name_of_witness { get; set; }
        [Description("EMP5624_E[0].Page9[0].txtF_Today_Date_1[3]")]
        public string witness_sign_date { get; set; }

        //labour assessment processings
        [Description("EMP5624_E[0].Page11[0].txtF_EMployer_Name[0]")]
        public string LMI_fee_employer_name { get; set; }
        [Description("EMP5624_E[0].Page11[0].txtF_CRA_Business_Number[0]")]
        public string LMI_fee_employer_CRA_number { get; set; }
        [Description("EMP5624_E[0].Page11[0].txtF_Number_Positions[0]")]
        public string number_of_positions_requested { get; set; }
        [Description("EMP5624_E[0].Page11[0].txtF_Processing_Fee[0]")]
        public string total_processing_fee { get; set; }
        [Description("EMP5624_E[0].Page11[0].rb_Payment[0]")]
        public bool? payment_method { get; set; }
        [Description("EMP5624_E[0].Page11[0].txtF_Given_Names[0]")]
        public string cardholder_name { get; set; }
        [Description("EMP5624_E[0].Page11[0].txtF_Applicant_Name[0]")]
        public string employer_primary_contact_name { get; set; }
        [Description("EMP5624_E[0].Page11[0].rb_Card_Type[0]")]
        public string card_type { get; set; }
        [Description("EMP5624_E[0].Page11[0].txtF_Applicant_Name[1]")]
        public string last_4_digits_of_card { get; set; }
        [Description("EMP5624_E[0].Page11[0].txtF_Charge[0]")]
        public string authorized_amount { get; set; }
        [Description("EMP5624_E[0].Page11[0].txtF_Signature_E[0]")]
        public string cardholder_signature { get; set; }
        [Description("EMP5624_E[0].Page11[0].txtF_Day[0]")]
        public string signature_year { get; set; }
        [Description("EMP5624_E[0].Page11[0].txtF_Month[0]")]
        public string signature_month { get; set; }
        [Description("EMP5624_E[0].Page11[0].txtF_Year[0]")]
        public string signature_day { get; set; }
        [Description("EMP5624_E[0].Page11[0].txtF_Card_Number[0]")]
        public string credit_card_number { get; set; }
        [Description("EMP5624_E[0].Page11[0].txtF_Month[1]")]
        public string credit_card_expiry_date_month { get; set; }
        [Description("EMP5624_E[0].Page11[0].txtF_Year[1]")]
        public string credit_card_expiry_date_year { get; set; }
        [Description("EMP5624_E[0].Page12[0].txtF_Family_Name1[0]")]
        public string worker_1_last_name { get; set; }
        [Description("EMP5624_E[0].Page12[0].txtF_First_Name1[0]")]
        public string worker_1_first_name { get; set; }
        [Description("EMP5624_E[0].Page12[0].rb_Gender1[0]")]
        public string worker_1_gender = "Male";
        [Description("EMP5624_E[0].Page12[0].txtF_Date_of_Birth1[0]")]
        public string worker_1_date_of_birth = "1988-06-23";
        [Description("EMP5624_E[0].Page12[0].txtF_Citizenship1[0]")]
        public string worker_1_citizenship { get; set; }
        [Description("EMP5624_E[0].Page12[0].txtF_City1[0]")]
        public string worker_1_city_outside_canada { get; set; }
        [Description("EMP5624_E[0].Page12[0].txtF_Country1[0]")]
        public string worker_1_country_outside_canada { get; set; }
        [Description("EMP5624_E[0].Page12[0].txtF_City1b[0]")]
        public string worker_1_city_inside_canada { get; set; }
        [Description("EMP5624_E[0].Page12[0].txtF_Country1b[0]")]
        public string worker_1_country_in_canada { get; set; }
        [Description("EMP5624_E[0].Page12[0].Temporary_foreign_worker1[0]")]
        public bool? worker_1_immigration_status_if_in_canada_TFW { get; set; }
        [Description("EMP5624_E[0].Page12[0].student[0]")]
        public bool? worker_1_immigration_status_if_in_canada_student { get; set; }
        [Description("EMP5624_E[0].Page12[0].visitor[0]")]
        public bool? worker_1_immigration_status_if_in_canada_visitor { get; set; }
        [Description("EMP5624_E[0].Page12[0].refugie_demandeur[0]")]
        public bool? worker_1_immigration_status_if_in_canada_refugee { get; set; }
        [Description("EMP5624_E[0].Page12[0].txtF_Family_Name2[0]")]
        public string worker_2_last_name { get; set; }
        [Description("EMP5624_E[0].Page12[0].txtF_First_Name2[0]")]
        public string worker_2_first_name { get; set; }
        [Description("EMP5624_E[0].Page12[0].rb_Gender2[0]")]
        public string worker_2_gender = "Male";
        [Description("EMP5624_E[0].Page12[0].txtF_Date_of_Birth2[0]")]
        public string worker_2_date_of_birth = "1988-06-23";
        [Description("EMP5624_E[0].Page12[0].txtF_Citizenship1[1]")]
        public string worker_2_citizenship { get; set; }
        [Description("EMP5624_E[0].Page12[0].txtF_City2[0]")]
        public string worker_2_city_outside_canada { get; set; }
        [Description("EMP5624_E[0].Page12[0].txtF_Country2[0]")]
        public string worker_2_country_outside_canada { get; set; }
        [Description("EMP5624_E[0].Page12[0].txtF_City2b[0]")]
        public string worker_2_city_inside_canada { get; set; }
        [Description("EMP5624_E[0].Page12[0].txtF_Country2b[0]")]
        public string worker_2_country_in_canada { get; set; }
        [Description("EMP5624_E[0].Page12[0].Temporary_foreign_worker2[0]")]
        public bool? worker_2_immigration_status_if_in_canada_TFW { get; set; }
        [Description("EMP5624_E[0].Page12[0].student2[0]")]
        public bool? worker_2_immigration_status_if_in_canada_student { get; set; }
        [Description("EMP5624_E[0].Page12[0].visitor2[0]")]
        public bool? worker_2_immigration_status_if_in_canada_visitor { get; set; }
        [Description("EMP5624_E[0].Page12[0].refugie_demandeur2[0]")]
        public bool? worker_2_immigration_status_if_in_canada_refugee { get; set; }
        [Description("EMP5624_E[0].Page12[0].txtF_Family_Name3[0]")]
        public string worker_3_last_name { get; set; }
        [Description("EMP5624_E[0].Page12[0].txtF_First_Name2[1]")]
        public string worker_3_first_name { get; set; }
        [Description("EMP5624_E[0].Page12[0].rb_Gender3[0]")]
        public string worker_3_gender = "Male";
        [Description("EMP5624_E[0].Page12[0].txtF_Date_of_Birth3[0]")]
        public string worker_3_date_of_birth = "1988-06-23";
        [Description("EMP5624_E[0].Page12[0].txtF_Citizenship3[0]")]
        public string worker_3_citizenship { get; set; }
        [Description("EMP5624_E[0].Page12[0].txtF_City3[0]")]
        public string worker_3_city_outside_canada { get; set; }
        [Description("EMP5624_E[0].Page12[0].txtF_Country3[0]")]
        public string worker_3_country_outside_canada { get; set; }
        [Description("EMP5624_E[0].Page12[0].txtF_City3b[0]")]
        public string worker_3_city_inside_canada { get; set; }
        [Description("EMP5624_E[0].Page12[0].txtF_Country1b[1]")]
        public string worker_3_country_in_canada { get; set; }
        [Description("EMP5624_E[0].Page12[0].Temporary_foreign_worker3[0]")]
        public bool? worker_3_immigration_status_if_in_canada_TFW { get; set; }
        [Description("EMP5624_E[0].Page12[0].student3[0]")]
        public bool? worker_3_immigration_status_if_in_canada_student { get; set; }
        [Description("EMP5624_E[0].Page12[0].visitor3[0]")]
        public bool? worker_3_immigration_status_if_in_canada_visitor { get; set; }
        [Description("EMP5624_E[0].Page12[0].refugie_demandeur3[0]")]
        public bool? worker_3_immigration_status_if_in_canada_refugee { get; set; }
        [Description("EMP5624_E[0].Page13[0].txtF_Family_Name4[0]")]
        public string worker_4_last_name { get; set; }
        [Description("EMP5624_E[0].Page13[0].txtF_First_Name4[0]")]
        public string worker_4_first_name { get; set; }
        [Description("EMP5624_E[0].Page13[0].rb_Gender4[0]")]
        public string worker_4_gender = "Male";
        [Description("EMP5624_E[0].Page13[0].txtF_Date_of_Birth4[0]")]
        public string worker_4_date_of_birth = "1988-06-23";
        [Description("EMP5624_E[0].Page13[0].txtF_Citizenship4[0]")]
        public string worker_4_citizenship { get; set; }
        [Description("EMP5624_E[0].Page13[0].txtF_City4[0]")]
        public string worker_4_city_outside_canada { get; set; }
        [Description("EMP5624_E[0].Page13[0].txtF_Country4[0]")]
        public string worker_4_country_outside_canada { get; set; }
        [Description("EMP5624_E[0].Page13[0].txtF_City4b[0]")]
        public string worker_4_city_inside_canada { get; set; }
        [Description("EMP5624_E[0].Page13[0].txtF_Country4b[0]")]
        public string worker_4_country_in_canada { get; set; }
        [Description("EMP5624_E[0].Page13[0].Temporary_foreign_worker4[0]")]
        public bool? worker_4_immigration_status_if_in_canada_TFW { get; set; }
        [Description("EMP5624_E[0].Page13[0].student4[0]")]
        public bool? worker_4_immigration_status_if_in_canada_student { get; set; }
        [Description("EMP5624_E[0].Page13[0].visitor4[0]")]
        public bool? worker_4_immigration_status_if_in_canada_visitor { get; set; }
        [Description("EMP5624_E[0].Page13[0].refugie_demandeur4[0]")]
        public bool? worker_4_immigration_status_if_in_canada_refugee { get; set; }
        [Description("EMP5624_E[0].Page13[0].txtF_Family_Name5[0]")]
        public string worker_5_last_name { get; set; }
        [Description("EMP5624_E[0].Page13[0].txtF_First_Name5[0]")]
        public string worker_5_first_name { get; set; }
        [Description("EMP5624_E[0].Page13[0].rb_Gender5[0]")]
        public string worker_5_gender = "Male";
        [Description("EMP5624_E[0].Page13[0].txtF_Date_of_Birth5[0]")]
        public string worker_5_date_of_birth = "1988-06-23";
        [Description("EMP5624_E[0].Page13[0].txtF_Citizenship5[0]")]
        public string worker_5_citizenship { get; set; }
        [Description("EMP5624_E[0].Page13[0].txtF_City5[0]")]
        public string worker_5_city_outside_canada { get; set; }
        [Description("EMP5624_E[0].Page13[0].txtF_Country5[0]")]
        public string worker_5_country_outside_canada { get; set; }
        [Description("EMP5624_E[0].Page13[0].txtF_City5b[0]")]
        public string worker_5_city_inside_canada { get; set; }
        [Description("EMP5624_E[0].Page13[0].txtF_Country5b[0]")]
        public string worker_5_country_in_canada { get; set; }
        [Description("EMP5624_E[0].Page13[0].Temporary_foreign_worker5[0]")]
        public bool? worker_5_immigration_status_if_in_canada_TFW { get; set; }
        [Description("EMP5624_E[0].Page13[0].student5[0]")]
        public bool? worker_5_immigration_status_if_in_canada_student { get; set; }
        [Description("EMP5624_E[0].Page13[0].visitor5[0]")]
        public bool? worker_5_immigration_status_if_in_canada_visitor { get; set; }
        [Description("EMP5624_E[0].Page13[0].refugie_demandeur5[0]")]
        public bool? worker_5_immigration_status_if_in_canada_refugee { get; set; }
    }
}
