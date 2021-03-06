﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL;

namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
            IBL bl = FactoryBL.GetBL();
            #region ido data

            #region Mothers
            #region Mom1
            Mother m1 = new Mother();
            m1.MomID = 2111;
            m1.MomFirstName = "Noa";
            m1.MomFamilyName = "Cohen";
            m1.MomPhoneNum = 0542161798;
            m1.MomAdress = "bazel, jerusalem, israel";
            m1.MomSearchAdress = "Basel, jerusalem, israel";

            m1.MomDaysNannyNeeds[0] = false;
            m1.MomDaysNannyNeeds[1] = false;
            m1.MomDaysNannyNeeds[2] = false;
            m1.MomDaysNannyNeeds[3] = false;
            m1.MomDaysNannyNeeds[4] = true;
            m1.MomDaysNannyNeeds[5] = false;

            for (int i = 0; i < 6; i++)
            {
                m1.MomHoursNannyNeeds.Add(null);
                m1.MomHoursNannyNeeds[i] = new WeeklyWorkSchedule();
            }
            m1.MomHoursNannyNeeds[0].StartTime = new TimeSpan(8, 30, 00);
            m1.MomHoursNannyNeeds[0].EndTime = new TimeSpan(16, 30, 00);
            m1.MomHoursNannyNeeds[1].StartTime = new TimeSpan(8, 30, 00);
            m1.MomHoursNannyNeeds[1].EndTime = new TimeSpan(16, 30, 00);
            m1.MomHoursNannyNeeds[2].StartTime = new TimeSpan(8, 30, 00);
            m1.MomHoursNannyNeeds[2].EndTime = new TimeSpan(16, 30, 00);
            m1.MomHoursNannyNeeds[3].StartTime = new TimeSpan(8, 30, 00);
            m1.MomHoursNannyNeeds[3].EndTime = new TimeSpan(16, 30, 00);
            m1.MomHoursNannyNeeds[4].StartTime = new TimeSpan(8, 30, 00);
            m1.MomHoursNannyNeeds[4].EndTime = new TimeSpan(15, 30, 00);
            m1.MomHoursNannyNeeds[5].StartTime = new TimeSpan(8, 30, 00);
            m1.MomHoursNannyNeeds[5].EndTime = new TimeSpan(16, 30, 00);

            bl.AddMom(m1);
            #endregion

            #region Mom2
            Mother m2 = new Mother();
            m2.MomID = 2112;
            m2.MomFirstName = "Tirtza";
            m2.MomFamilyName = "Herst";
            m2.MomPhoneNum = 0548522454;
            m2.MomAdress = "shoshana, jerusalem, israel";
            m2.MomSearchAdress = "yaffo, jerusalem, israel";

            m2.MomDaysNannyNeeds[0] = false;
            m2.MomDaysNannyNeeds[1] = false;
            m2.MomDaysNannyNeeds[2] = false;
            m2.MomDaysNannyNeeds[3] = true;
            m2.MomDaysNannyNeeds[4] = false;
            m2.MomDaysNannyNeeds[5] = true;
            for (int i = 0; i < 6; i++)
            {
                m2.MomHoursNannyNeeds.Add(null);
                m2.MomHoursNannyNeeds[i] = new WeeklyWorkSchedule();
            }
            m2.MomHoursNannyNeeds[0].StartTime = new TimeSpan(8, 30, 00);
            m2.MomHoursNannyNeeds[0].EndTime = new TimeSpan(16, 30, 00);
            m2.MomHoursNannyNeeds[1].StartTime = new TimeSpan(8, 30, 00);
            m2.MomHoursNannyNeeds[1].EndTime = new TimeSpan(16, 30, 00);
            m2.MomHoursNannyNeeds[2].StartTime = new TimeSpan(8, 30, 00);
            m2.MomHoursNannyNeeds[2].EndTime = new TimeSpan(16, 30, 00);
            m2.MomHoursNannyNeeds[3].StartTime = new TimeSpan(8, 30, 00);
            m2.MomHoursNannyNeeds[3].EndTime = new TimeSpan(16, 30, 00);
            m2.MomHoursNannyNeeds[4].StartTime = new TimeSpan(8, 30, 00);
            m2.MomHoursNannyNeeds[4].EndTime = new TimeSpan(16, 30, 00);
            m2.MomHoursNannyNeeds[5].StartTime = new TimeSpan(8, 30, 00);
            m2.MomHoursNannyNeeds[5].EndTime = new TimeSpan(16, 30, 00);

            bl.AddMom(m2);
            #endregion

            #region Mom3
            Mother m3 = new Mother();
            m3.MomID = 2113;
            m3.MomFirstName = "Stav";
            m3.MomFamilyName = "Havakook";
            m3.MomPhoneNum = 0548774141;
            m3.MomAdress = "avizohar, jerusalem, israel";
            m3.MomSearchAdress = "avizohar, jerusalem, israel";

            m3.MomDaysNannyNeeds[0] = false;
            m3.MomDaysNannyNeeds[1] = false;
            m3.MomDaysNannyNeeds[2] = false;
            m3.MomDaysNannyNeeds[3] = true;
            m3.MomDaysNannyNeeds[4] = false;
            m3.MomDaysNannyNeeds[5] = true;
            for (int i = 0; i < 6; i++)
            {
                m3.MomHoursNannyNeeds.Add(null);
                m3.MomHoursNannyNeeds[i] = new WeeklyWorkSchedule();
            }
            m3.MomHoursNannyNeeds[0].StartTime = new TimeSpan(8, 30, 00);
            m3.MomHoursNannyNeeds[0].EndTime = new TimeSpan(16, 30, 00);
            m3.MomHoursNannyNeeds[1].StartTime = new TimeSpan(8, 30, 00);
            m3.MomHoursNannyNeeds[1].EndTime = new TimeSpan(16, 30, 00);
            m3.MomHoursNannyNeeds[2].StartTime = new TimeSpan(8, 30, 00);
            m3.MomHoursNannyNeeds[2].EndTime = new TimeSpan(16, 30, 00);
            m3.MomHoursNannyNeeds[3].StartTime = new TimeSpan(8, 30, 00);
            m3.MomHoursNannyNeeds[3].EndTime = new TimeSpan(16, 30, 00);
            m3.MomHoursNannyNeeds[4].StartTime = new TimeSpan(8, 30, 00);
            m3.MomHoursNannyNeeds[4].EndTime = new TimeSpan(16, 30, 00);
            m3.MomHoursNannyNeeds[5].StartTime = new TimeSpan(8, 30, 00);
            m3.MomHoursNannyNeeds[5].EndTime = new TimeSpan(16, 30, 00);

            bl.AddMom(m3);
            #endregion

            #region Mom4
            Mother m4 = new Mother();
            m4.MomID = 2114;
            m4.MomFirstName = "Galit";
            m4.MomFamilyName = "Melikovski";
            m4.MomPhoneNum = 0548774141;
            m4.MomAdress = "avizohar, jerusalem, israel";
            m4.MomSearchAdress = "avizohar, jerusalem, israel";

            m4.MomDaysNannyNeeds[0] = false;
            m4.MomDaysNannyNeeds[1] = false;
            m4.MomDaysNannyNeeds[2] = false;
            m4.MomDaysNannyNeeds[3] = true;
            m4.MomDaysNannyNeeds[4] = false;
            m4.MomDaysNannyNeeds[5] = true;
            for (int i = 0; i < 6; i++)
            {
                m4.MomHoursNannyNeeds.Add(null);
                m4.MomHoursNannyNeeds[i] = new WeeklyWorkSchedule();
            }
            m4.MomHoursNannyNeeds[0].StartTime = new TimeSpan(8, 30, 00);
            m4.MomHoursNannyNeeds[0].EndTime = new TimeSpan(16, 30, 00);
            m4.MomHoursNannyNeeds[1].StartTime = new TimeSpan(8, 30, 00);
            m4.MomHoursNannyNeeds[1].EndTime = new TimeSpan(16, 30, 00);
            m4.MomHoursNannyNeeds[2].StartTime = new TimeSpan(8, 30, 00);
            m4.MomHoursNannyNeeds[2].EndTime = new TimeSpan(16, 30, 00);
            m4.MomHoursNannyNeeds[3].StartTime = new TimeSpan(8, 30, 00);
            m4.MomHoursNannyNeeds[3].EndTime = new TimeSpan(16, 30, 00);
            m4.MomHoursNannyNeeds[4].StartTime = new TimeSpan(8, 30, 00);
            m4.MomHoursNannyNeeds[4].EndTime = new TimeSpan(16, 30, 00);
            m4.MomHoursNannyNeeds[5].StartTime = new TimeSpan(8, 30, 00);
            m4.MomHoursNannyNeeds[5].EndTime = new TimeSpan(16, 30, 00);

            bl.AddMom(m4);
            #endregion

            #region Mom5
            Mother m5 = new Mother();
            m5.MomID = 2115;
            m5.MomFirstName = "Danit";
            m5.MomFamilyName = "Yeshayahu";
            m5.MomPhoneNum = 0548774141;
            m5.MomAdress = "avizohar, jerusalem, israel";
            m5.MomSearchAdress = "avizohar, jerusalem, israel";

            m5.MomDaysNannyNeeds[0] = false;
            m5.MomDaysNannyNeeds[1] = false;
            m5.MomDaysNannyNeeds[2] = false;
            m5.MomDaysNannyNeeds[3] = true;
            m5.MomDaysNannyNeeds[4] = false;
            m5.MomDaysNannyNeeds[5] = true;
            for (int i = 0; i < 6; i++)
            {
                m5.MomHoursNannyNeeds.Add(null);
                m5.MomHoursNannyNeeds[i] = new WeeklyWorkSchedule();
            }
            m5.MomHoursNannyNeeds[0].StartTime = new TimeSpan(8, 30, 00);
            m5.MomHoursNannyNeeds[0].EndTime = new TimeSpan(16, 30, 00);
            m5.MomHoursNannyNeeds[1].StartTime = new TimeSpan(8, 30, 00);
            m5.MomHoursNannyNeeds[1].EndTime = new TimeSpan(16, 30, 00);
            m5.MomHoursNannyNeeds[2].StartTime = new TimeSpan(8, 30, 00);
            m5.MomHoursNannyNeeds[2].EndTime = new TimeSpan(16, 30, 00);
            m5.MomHoursNannyNeeds[3].StartTime = new TimeSpan(8, 30, 00);
            m5.MomHoursNannyNeeds[3].EndTime = new TimeSpan(16, 30, 00);
            m5.MomHoursNannyNeeds[4].StartTime = new TimeSpan(8, 30, 00);
            m5.MomHoursNannyNeeds[4].EndTime = new TimeSpan(16, 30, 00);
            m5.MomHoursNannyNeeds[5].StartTime = new TimeSpan(8, 30, 00);
            m5.MomHoursNannyNeeds[5].EndTime = new TimeSpan(16, 30, 00);

            bl.AddMom(m5);
            #endregion


            #endregion

            #region childs

            #region Child1
            Child c1 = new Child();
            c1.ChildID = 1111;
            c1.ChildMomID = 2111;
            c1.ChildAge = new DateTime(2017, 8, 26);
            c1.ChildName = "David";
            c1.ChildIsSpecialNeeds = false;
            //c1.ChildTypesOfSpecialNeeds = " ";
            c1.IsHaveNanny = false;
            bl.AddChild(c1);
            #endregion

            #region child2
            Child c2 = new Child();
            c2.ChildID = 1112;
            c2.ChildMomID = 2112;
            c2.ChildAge = new DateTime(2017, 3, 2);
            c2.ChildName = "Reuven";
            c2.ChildIsSpecialNeeds = true;
            c2.ChildTypesOfSpecialNeeds = "need to eat something every 2 hours";
            c2.IsHaveNanny = false;
            bl.AddChild(c2);
            #endregion

            #region child3
            Child c3 = new Child();
            c3.ChildID = 1113;
            c3.ChildMomID = 2113;
            c3.ChildAge = new DateTime(2017, 1, 29);
            c3.ChildName = "Moshe";
            c3.ChildIsSpecialNeeds = false;
            //c3.ChildTypesOfSpecialNeeds = " ";
            c3.IsHaveNanny = false;
            bl.AddChild(c3);
            #endregion

            #region child4
            Child c4 = new Child();
            c4.ChildID = 1114;
            c4.ChildMomID = 2114;
            c4.ChildAge = new DateTime(2017, 11, 15);
            c4.ChildName = "Yosef";
            c4.ChildIsSpecialNeeds = false;
            //c4.ChildTypesOfSpecialNeeds = " ";
            c4.IsHaveNanny = false;
            bl.AddChild(c4);
            #endregion

            #region child5
            Child c5 = new Child();
            c5.ChildID = 1115;
            c5.ChildMomID = 2114;
            c5.ChildAge = new DateTime(2016, 11, 15);
            c5.ChildName = "Shimon";
            c5.ChildIsSpecialNeeds = false;
            //c5.ChildTypesOfSpecialNeeds = " ";
            c5.IsHaveNanny = false;
            bl.AddChild(c5);
            #endregion

            #region child6
            Child c6 = new Child();
            c6.ChildID = 1116;
            c6.ChildMomID = 2114;
            c6.ChildAge = new DateTime(2017, 10, 15);
            c6.ChildName = "Levi";
            c6.ChildIsSpecialNeeds = true;
            c6.ChildTypesOfSpecialNeeds = "please dont put him much time under sun";
            c6.IsHaveNanny = false;
            bl.AddChild(c6);
            #endregion

            #region child7
            Child c7 = new Child();
            c7.ChildID = 1117;
            c7.ChildMomID = 2114;
            c7.ChildAge = new DateTime(2016, 4, 24);
            c7.ChildName = "Yehuda";
            c7.ChildIsSpecialNeeds = false;
            //c7.ChildTypesOfSpecialNeeds = " ";
            c7.IsHaveNanny = false;
            bl.AddChild(c7);
            #endregion

            #region child8
            Child c8 = new Child();
            c8.ChildID = 1118;
            c8.ChildMomID = 2114;
            c8.ChildAge = new DateTime(2016, 8, 14);
            c8.ChildName = "Isaschar";
            c8.ChildIsSpecialNeeds = false;
            //c8.ChildTypesOfSpecialNeeds = " ";
            c8.IsHaveNanny = false;
            bl.AddChild(c8);
            #endregion

            #region child9
            Child c9 = new Child();
            c9.ChildID = 1119;
            c9.ChildMomID = 2114;
            c9.ChildAge = new DateTime(2015, 12, 8);
            c9.ChildName = "Zevulun";
            c9.ChildIsSpecialNeeds = false;
            //c9.ChildTypesOfSpecialNeeds = " ";
            c9.IsHaveNanny = false;
            bl.AddChild(c9);
            #endregion

            #region child10
            Child c10 = new Child();
            c10.ChildID = 1120;
            c10.ChildMomID = 2114;
            c10.ChildAge = new DateTime(2015, 8, 19);
            c10.ChildName = "Dan";
            c10.ChildIsSpecialNeeds = false;
            //c10.ChildTypesOfSpecialNeeds = " ";
            c10.IsHaveNanny = false;
            bl.AddChild(c10);
            #endregion


            #endregion

            #region Nannies
            #region nanny1
            Nanny nanny1 = new Nanny();
            nanny1.NannyId = 3111;
            nanny1.NannyPrivateName = "Sara";
            nanny1.NannyFamilyName = "Berkovich";
            nanny1.NannyMaxInfantAge = 36;
            nanny1.NannyMinInfantAge = 3;
            nanny1.NannyMaxInfants = 10;
            nanny1.NannyDateOfBirth = new DateTime(1989, 12, 12);
            nanny1.NannyPhoneNum = 0502535656;
            nanny1.NannyIsElevator = true;
            nanny1.NannyFloor = 2;
            nanny1.NannyYearsOfExperience = 0;
            nanny1.NannyIsHourlySalary = true;
            nanny1.NannyHourlySalary = 29.5;
            nanny1.NannyMonthlySalary = 2360;
            nanny1.NannyIsMOE = true;
            nanny1.IsNannyHaveRecommendations = true;
            nanny1.NannyRecommendations = "very dedicated to the child";
            nanny1.NannyAdress = "Shoshana Polyakov, Jerusalem, Israel";
            nanny1.NannyWorkingDays = new bool[6] { false, true, true, true, true, true };
            nanny1.NannyWorkingHours = new List<WeeklyWorkSchedule>(6);
            for (int i = 0; i < 6; i++)
            {
                nanny1.NannyWorkingHours.Add(null);
                nanny1.NannyWorkingHours[i] = new WeeklyWorkSchedule();
            }
            nanny1.NannyWorkingHours[0].StartTime = new TimeSpan(7, 30, 00);
            nanny1.NannyWorkingHours[0].EndTime = new TimeSpan(16, 30, 00);
            nanny1.NannyWorkingHours[1].StartTime = new TimeSpan(7, 30, 00);
            nanny1.NannyWorkingHours[1].EndTime = new TimeSpan(16, 30, 00);
            nanny1.NannyWorkingHours[3].StartTime = new TimeSpan(7, 30, 00);
            nanny1.NannyWorkingHours[3].EndTime = new TimeSpan(16, 30, 00);
            nanny1.NannyWorkingHours[4].StartTime = new TimeSpan(7, 30, 00);
            nanny1.NannyWorkingHours[4].EndTime = new TimeSpan(16, 30, 00);
            nanny1.NannyWorkingHours[5].StartTime = new TimeSpan(7, 30, 00);
            nanny1.NannyWorkingHours[5].EndTime = new TimeSpan(16, 30, 00);
            bl.AddNanny(nanny1);
            #endregion

            #region nanny2
            Nanny nanny2 = new Nanny();
            nanny2.NannyId = 3112;
            nanny2.NannyPrivateName = "Rivka";
            nanny2.NannyFamilyName = "Birs";
            nanny2.NannyMaxInfantAge = 23;
            nanny2.NannyMinInfantAge = 3;
            nanny2.NannyMaxInfants = 10;
            nanny2.NannyDateOfBirth = new DateTime(1985, 12, 12);
            nanny2.NannyPhoneNum = 0572213656;
            nanny2.NannyIsElevator = false;
            nanny2.NannyFloor = 5;
            nanny2.NannyYearsOfExperience = 2;
            nanny2.NannyIsHourlySalary = false;
            nanny2.NannyHourlySalary = 29.5;
            nanny2.NannyMonthlySalary = 2900;
            nanny2.NannyIsMOE = false;
            nanny2.IsNannyHaveRecommendations = true;
            nanny2.NannyRecommendations = "good nanny";
            nanny2.NannyAdress = "David Remez, Jerusalem, Israel";
            nanny2.NannyWorkingDays = new bool[6] { false, true, true, true, true, true };
            nanny2.NannyWorkingHours = new List<WeeklyWorkSchedule>(6);
            for (int i = 0; i < 6; i++)
            {
                nanny2.NannyWorkingHours.Add(null);
                nanny2.NannyWorkingHours[i] = new WeeklyWorkSchedule();
            }
            nanny2.NannyWorkingHours[0].StartTime = new TimeSpan(6, 30, 00);
            nanny2.NannyWorkingHours[0].EndTime = new TimeSpan(17, 30, 00);
            nanny2.NannyWorkingHours[1].StartTime = new TimeSpan(6, 30, 00);
            nanny2.NannyWorkingHours[1].EndTime = new TimeSpan(17, 30, 00);
            nanny2.NannyWorkingHours[2].StartTime = new TimeSpan(6, 30, 00);
            nanny2.NannyWorkingHours[2].EndTime = new TimeSpan(17, 30, 00);
            nanny2.NannyWorkingHours[3].StartTime = new TimeSpan(6, 30, 00);
            nanny2.NannyWorkingHours[3].EndTime = new TimeSpan(17, 30, 00);
            nanny2.NannyWorkingHours[4].StartTime = new TimeSpan(6, 30, 00);
            nanny2.NannyWorkingHours[4].EndTime = new TimeSpan(17, 30, 00);
            nanny2.NannyWorkingHours[5].StartTime = new TimeSpan(6, 30, 00);
            nanny2.NannyWorkingHours[5].EndTime = new TimeSpan(17, 30, 00);
            bl.AddNanny(nanny2);
            #endregion

            #region nanny3
            Nanny nanny3 = new Nanny();
            nanny3.NannyId = 3113;
            nanny3.NannyPrivateName = "Rachel";
            nanny3.NannyFamilyName = "Buzaglo";
            nanny3.NannyMaxInfantAge = 13;
            nanny3.NannyMinInfantAge = 4;
            nanny3.NannyMaxInfants = 10;
            nanny3.NannyDateOfBirth = new DateTime(1978, 2, 20);
            nanny3.NannyPhoneNum = 0545232625;
            nanny3.NannyIsElevator = false;
            nanny3.NannyFloor = 2;
            nanny3.NannyYearsOfExperience = 5;
            nanny3.NannyIsHourlySalary = false;
            nanny3.NannyHourlySalary = 29.5;
            nanny3.NannyMonthlySalary = 3500;
            nanny3.NannyIsMOE = true;
            nanny3.IsNannyHaveRecommendations = false;
            nanny3.NannyRecommendations = "good nanny";
            nanny3.NannyAdress = "Karmon , Jerusalem, Israel";
            nanny3.NannyWorkingDays = new bool[6] { false, true, false, false, false, false };
            nanny3.NannyWorkingHours = new List<WeeklyWorkSchedule>(6);
            for (int i = 0; i < 6; i++)
            {
                nanny3.NannyWorkingHours.Add(null);
                nanny3.NannyWorkingHours[i] = new WeeklyWorkSchedule();
            }
            nanny3.NannyWorkingHours[0].StartTime = new TimeSpan(7, 30, 00);
            nanny3.NannyWorkingHours[0].EndTime = new TimeSpan(16, 30, 00);
            nanny3.NannyWorkingHours[1].StartTime = new TimeSpan(7, 30, 00);
            nanny3.NannyWorkingHours[1].EndTime = new TimeSpan(16, 30, 00);
            nanny3.NannyWorkingHours[3].StartTime = new TimeSpan(7, 30, 00);
            nanny3.NannyWorkingHours[3].EndTime = new TimeSpan(16, 30, 00);
            nanny3.NannyWorkingHours[4].StartTime = new TimeSpan(7, 30, 00);
            nanny3.NannyWorkingHours[4].EndTime = new TimeSpan(16, 30, 00);
            nanny3.NannyWorkingHours[5].StartTime = new TimeSpan(07, 30, 00);
            nanny3.NannyWorkingHours[5].EndTime = new TimeSpan(16, 30, 00);
            bl.AddNanny(nanny3);
            #endregion

            #region nanny4
            Nanny nanny4 = new Nanny();
            nanny4.NannyId = 3114;
            nanny4.NannyPrivateName = "Tal";
            nanny4.NannyFamilyName = "Leybovich";
            nanny4.NannyMaxInfantAge = 23;
            nanny4.NannyMinInfantAge = 4;
            nanny4.NannyMaxInfants = 10;
            nanny4.NannyDateOfBirth = new DateTime(1991, 7, 5);
            nanny4.NannyPhoneNum = 0535488987;
            nanny4.NannyIsElevator = true;
            nanny4.NannyFloor = 8;
            nanny4.NannyYearsOfExperience = 0;
            nanny4.NannyIsHourlySalary = true;
            nanny4.NannyHourlySalary = 35;
            nanny4.NannyMonthlySalary = 2900;
            nanny4.NannyIsMOE = false;
            nanny4.IsNannyHaveRecommendations = false;
            nanny4.NannyRecommendations = "good nanny";
            nanny4.NannyAdress = "Ya'akov Eliav , Jerusalem, Israel";
            nanny4.NannyWorkingDays = new bool[6] { false, true, false, true, true, true };
            nanny4.NannyWorkingHours = new List<WeeklyWorkSchedule>(6);
            for (int i = 0; i < 6; i++)
            {
                nanny4.NannyWorkingHours.Add(null);
                nanny4.NannyWorkingHours[i] = new WeeklyWorkSchedule();
            }
            nanny4.NannyWorkingHours[0].StartTime = new TimeSpan(7, 30, 00);
            nanny4.NannyWorkingHours[0].EndTime = new TimeSpan(16, 30, 00);
            nanny4.NannyWorkingHours[1].StartTime = new TimeSpan(7, 30, 00);
            nanny4.NannyWorkingHours[1].EndTime = new TimeSpan(16, 30, 00);
            nanny4.NannyWorkingHours[3].StartTime = new TimeSpan(7, 30, 00);
            nanny4.NannyWorkingHours[3].EndTime = new TimeSpan(16, 30, 00);
            nanny4.NannyWorkingHours[4].StartTime = new TimeSpan(7, 30, 00);
            nanny4.NannyWorkingHours[4].EndTime = new TimeSpan(16, 30, 00);
            nanny4.NannyWorkingHours[5].StartTime = new TimeSpan(09, 30, 00);
            nanny4.NannyWorkingHours[5].EndTime = new TimeSpan(16, 30, 00);
            bl.AddNanny(nanny4);
            #endregion

            #region nanny5
            Nanny nanny5 = new Nanny();
            nanny5.NannyId = 3115;
            nanny5.NannyPrivateName = "Gila";
            nanny5.NannyFamilyName = "Gadasi";
            nanny5.NannyMaxInfantAge = 13;
            nanny5.NannyMinInfantAge = 4;
            nanny5.NannyMaxInfants = 10;
            nanny5.NannyDateOfBirth = new DateTime(1971, 3, 15);
            nanny5.NannyPhoneNum = 0572213656;
            nanny5.NannyIsElevator = true;
            nanny5.NannyFloor = 1;
            nanny5.NannyYearsOfExperience = 6;
            nanny5.NannyIsHourlySalary = false;
            nanny5.NannyHourlySalary = 29.5;
            nanny5.NannyMonthlySalary = 2500;
            nanny5.NannyIsMOE = true;
            nanny5.IsNannyHaveRecommendations = true;
            nanny5.NannyRecommendations = "great nanny, i'm very happy because of her";
            nanny5.NannyAdress = "Mazkeret Moshe St, Jerusalem, Israel";
            nanny5.NannyWorkingDays = new bool[6] { false, true, false, false, false, false };
            nanny5.NannyWorkingHours = new List<WeeklyWorkSchedule>(6);
            for (int i = 0; i < 6; i++)
            {
                nanny5.NannyWorkingHours.Add(null);
                nanny5.NannyWorkingHours[i] = new WeeklyWorkSchedule();
            }
            nanny5.NannyWorkingHours[0].StartTime = new TimeSpan(7, 30, 00);
            nanny5.NannyWorkingHours[0].EndTime = new TimeSpan(16, 30, 00);
            nanny5.NannyWorkingHours[1].StartTime = new TimeSpan(7, 30, 00);
            nanny5.NannyWorkingHours[1].EndTime = new TimeSpan(16, 30, 00);
            nanny5.NannyWorkingHours[3].StartTime = new TimeSpan(7, 30, 00);
            nanny5.NannyWorkingHours[3].EndTime = new TimeSpan(16, 30, 00);
            nanny5.NannyWorkingHours[4].StartTime = new TimeSpan(7, 30, 00);
            nanny5.NannyWorkingHours[4].EndTime = new TimeSpan(16, 30, 00);
            nanny5.NannyWorkingHours[5].StartTime = new TimeSpan(07, 30, 00);
            nanny5.NannyWorkingHours[5].EndTime = new TimeSpan(16, 30, 00);
            bl.AddNanny(nanny5);
            #endregion

            #region nanny6
            Nanny nanny6 = new Nanny();
            nanny6.NannyId = 3116;
            nanny6.NannyPrivateName = "Fatma";
            nanny6.NannyFamilyName = "Salah";
            nanny6.NannyMaxInfantAge = 23;
            nanny6.NannyMinInfantAge = 6;
            nanny6.NannyMaxInfants = 10;
            nanny6.NannyDateOfBirth = new DateTime(1967, 6, 25);
            nanny6.NannyPhoneNum = 0535244545;
            nanny6.NannyIsElevator = false;
            nanny6.NannyFloor = 5;
            nanny6.NannyYearsOfExperience = 10;
            nanny6.NannyIsHourlySalary = false;
            nanny6.NannyHourlySalary = 29.5;
            nanny6.NannyMonthlySalary = 4500;
            nanny6.NannyIsMOE = false;
            nanny6.IsNannyHaveRecommendations = false;
            nanny6.NannyRecommendations = "good nanny";
            nanny6.NannyWorkingDays = new bool[6] { false, true, false, false, false, false };
            nanny6.NannyAdress = "Ha-Kimronim St , Jerusalem, Israel";
            nanny6.NannyWorkingHours = new List<WeeklyWorkSchedule>(6);
            for (int i = 0; i < 6; i++)
            {
                nanny6.NannyWorkingHours.Add(null);
                nanny6.NannyWorkingHours[i] = new WeeklyWorkSchedule();
            }
            nanny6.NannyWorkingHours[0].StartTime = new TimeSpan(7, 30, 00);
            nanny6.NannyWorkingHours[0].EndTime = new TimeSpan(16, 30, 00);
            nanny6.NannyWorkingHours[1].StartTime = new TimeSpan(7, 30, 00);
            nanny6.NannyWorkingHours[1].EndTime = new TimeSpan(16, 30, 00);
            nanny6.NannyWorkingHours[3].StartTime = new TimeSpan(7, 30, 00);
            nanny6.NannyWorkingHours[3].EndTime = new TimeSpan(16, 30, 00);
            nanny6.NannyWorkingHours[4].StartTime = new TimeSpan(7, 30, 00);
            nanny6.NannyWorkingHours[4].EndTime = new TimeSpan(16, 30, 00);
            nanny6.NannyWorkingHours[5].StartTime = new TimeSpan(07, 30, 00);
            nanny6.NannyWorkingHours[5].EndTime = new TimeSpan(16, 30, 00);
            bl.AddNanny(nanny6);
            #endregion

            #region nanny7
            Nanny nanny7 = new Nanny();
            nanny7.NannyId = 3117;
            nanny7.NannyPrivateName = "Tova";
            nanny7.NannyFamilyName = "Glazer";
            nanny7.NannyMaxInfantAge = 23;
            nanny7.NannyMinInfantAge = 4;
            nanny7.NannyMaxInfants = 10;
            nanny7.NannyDateOfBirth = new DateTime(1988, 7, 16);
            nanny7.NannyPhoneNum = 0526633232;
            nanny7.NannyIsElevator = false;
            nanny7.NannyFloor = 3;
            nanny7.NannyYearsOfExperience = 0;
            nanny7.NannyIsHourlySalary = true;
            nanny7.NannyHourlySalary = 33;
            nanny7.NannyMonthlySalary = 2900;
            nanny7.NannyIsMOE = false;
            nanny7.IsNannyHaveRecommendations = false;
            nanny7.NannyRecommendations = "good nanny";
            nanny7.NannyWorkingDays = new bool[6] { false, true, false, true, true, true };
            nanny7.NannyAdress = "Tel Khai St, Jerusalem, Israel";
            nanny7.NannyWorkingHours = new List<WeeklyWorkSchedule>(6);
            for (int i = 0; i < 6; i++)
            {
                nanny7.NannyWorkingHours.Add(null);
                nanny7.NannyWorkingHours[i] = new WeeklyWorkSchedule();
            }
            nanny7.NannyWorkingHours[0].StartTime = new TimeSpan(7, 30, 00);
            nanny7.NannyWorkingHours[0].EndTime = new TimeSpan(16, 30, 00);
            nanny7.NannyWorkingHours[1].StartTime = new TimeSpan(7, 30, 00);
            nanny7.NannyWorkingHours[1].EndTime = new TimeSpan(16, 30, 00);
            nanny7.NannyWorkingHours[3].StartTime = new TimeSpan(7, 30, 00);
            nanny7.NannyWorkingHours[3].EndTime = new TimeSpan(16, 30, 00);
            nanny7.NannyWorkingHours[4].StartTime = new TimeSpan(7, 30, 00);
            nanny7.NannyWorkingHours[4].EndTime = new TimeSpan(16, 30, 00);
            nanny7.NannyWorkingHours[5].StartTime = new TimeSpan(07, 30, 00);
            nanny7.NannyWorkingHours[5].EndTime = new TimeSpan(16, 30, 00);
            bl.AddNanny(nanny7);
            #endregion

            #region nanny8
            Nanny nanny8 = new Nanny();
            nanny8.NannyId = 3118;
            nanny8.NannyPrivateName = "Neta";
            nanny8.NannyFamilyName = "Shimoni";
            nanny8.NannyMaxInfantAge = 52;
            nanny8.NannyMinInfantAge = 10;
            nanny8.NannyMaxInfants = 10;
            nanny8.NannyDateOfBirth = new DateTime(1990, 5, 16);
            nanny8.NannyPhoneNum = 0526651232;
            nanny8.NannyIsElevator = false;
            nanny8.NannyFloor = 1;
            nanny8.NannyYearsOfExperience = 3;
            nanny8.NannyIsHourlySalary = true;
            nanny8.NannyHourlySalary = 31;
            nanny8.NannyMonthlySalary = 2650;
            nanny8.NannyIsMOE = false;
            nanny8.IsNannyHaveRecommendations = false;
            nanny8.NannyRecommendations = "good nanny";
            nanny8.NannyWorkingDays = new bool[6] { false, true, false, true, true, true };
            nanny8.NannyAdress = "Tel Khai St, Jerusalem, Israel";
            nanny8.NannyWorkingHours = new List<WeeklyWorkSchedule>(6);
            for (int i = 0; i < 6; i++)
            {
                nanny8.NannyWorkingHours.Add(null);
                nanny8.NannyWorkingHours[i] = new WeeklyWorkSchedule();
            }
            nanny8.NannyWorkingHours[0].StartTime = new TimeSpan(7, 30, 00);
            nanny8.NannyWorkingHours[0].EndTime = new TimeSpan(16, 30, 00);
            nanny8.NannyWorkingHours[1].StartTime = new TimeSpan(7, 30, 00);
            nanny8.NannyWorkingHours[1].EndTime = new TimeSpan(16, 30, 00);
            nanny8.NannyWorkingHours[3].StartTime = new TimeSpan(7, 30, 00);
            nanny8.NannyWorkingHours[3].EndTime = new TimeSpan(16, 30, 00);
            nanny8.NannyWorkingHours[4].StartTime = new TimeSpan(7, 30, 00);
            nanny8.NannyWorkingHours[4].EndTime = new TimeSpan(16, 30, 00);
            nanny8.NannyWorkingHours[5].StartTime = new TimeSpan(07, 30, 00);
            nanny7.NannyWorkingHours[5].EndTime = new TimeSpan(16, 30, 00);
            bl.AddNanny(nanny8);
            #endregion

            #endregion

            #region Contracts

            #region Contract1

            Contract co1 = new Contract();
            co1.ChildID = 1111;
            co1.NannyID = 3111;
            co1.IsIntroductoryMeeting = true;
            co1.IsContractSigned = false;
            co1.PaymentMethod = Payment_method.hourly;
            co1.HourlySalary = 30.5;
            co1.MonthlySalary = 3500;
            co1.StartDate = new DateTime(2017, 5, 9);
            co1.EndDate = new DateTime(2018, 5, 9);

            bl.AddContract(co1);
            #endregion

            #region Contract2

            Contract co2 = new Contract();
            co2.ChildID = 1112;
            co2.NannyID = 3112;
            co2.IsIntroductoryMeeting = true;
            co2.IsContractSigned = false;
            co2.PaymentMethod = Payment_method.monthly;
            co2.HourlySalary = 34.5;
            co2.MonthlySalary = 3900;
            co2.StartDate = new DateTime(2016, 5, 9);
            co2.EndDate = new DateTime(2017, 5, 9);

            bl.AddContract(co2);
            #endregion

            #region Contract3

            Contract co3 = new Contract();
            co3.ChildID = 1113;
            co3.NannyID = 3113;
            co3.IsIntroductoryMeeting = false;
            co3.IsContractSigned = false;
            co3.PaymentMethod = Payment_method.monthly;
            co3.HourlySalary = 29;
            co3.MonthlySalary = 2900;
            co3.StartDate = new DateTime(2017, 9, 7);
            co3.EndDate = new DateTime(2018, 9, 7);

            bl.AddContract(co3);
            #endregion

            #region Contract4

            Contract co4 = new Contract();
            co4.ChildID = 1114;
            co4.NannyID = 3114;
            co4.IsIntroductoryMeeting = false;
            co4.IsContractSigned = true;
            co4.PaymentMethod = Payment_method.monthly;
            co4.HourlySalary = 39.5;
            co4.MonthlySalary = 3900;
            co4.StartDate = new DateTime(2016, 5, 9);
            co4.EndDate = new DateTime(2017, 5, 9);

            bl.AddContract(co4);
            #endregion

            #region Contract5

            Contract co5 = new Contract();
            co5.ChildID = 1115;
            co5.NannyID = 3115;
            co5.IsIntroductoryMeeting = true;
            co5.IsContractSigned = true;
            co5.PaymentMethod = Payment_method.hourly;
            co5.HourlySalary = 31;
            co5.MonthlySalary = 3700;
            co5.StartDate = new DateTime(2016, 3, 24);
            co5.EndDate = new DateTime(2017, 9, 7);

            bl.AddContract(co5);
            #endregion
            #endregion

            #endregion

            #region main
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Hello! Welcome to the Baby-nannies-Mediation system, please enter your choice:");
            Console.WriteLine("******************************************************************************");


            
            

            int choice;
            bool logOff = false;
            do
            {
                Console.WriteLine("1. The mother's options");
                Console.WriteLine("2. The nannie's options");
                Console.WriteLine("3. The child's options");
                Console.WriteLine("4. The contract's options");
                Console.WriteLine("5. Exit");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                try
                {
                    switch (choice)
                    {
                        case 1:
                            MotherOptions.MomMain();
                            break;
                        case 2:
                            NannyOptions.NannyMain();
                            break;
                        case 3:
                            ChildOptions.ChildMain();
                            break;
                        case 4:
                            ContractOptions.ContractMain();
                            break;
                        case 5:
                            Console.WriteLine("GoodBye!");
                            logOff = true;
                            break;
                        default:
                            throw new Exception("Error, Your choice does not exist, please enter a number between 1 and 5");

                    }
                }
                catch (Exception c)
                {
                    Console.WriteLine(c.Message);
                }

                Console.WriteLine();

            } while (!logOff);
            #endregion

        }
    }
}
