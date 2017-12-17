﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicIS {
    public class Academician {
        public int Id;
        public string Name;
        public string Faculty;
        public string Department;
        public string Mail;
        public string Phone;
        public string Website;
        public string Office_hours;
        public string Education;
        public string Detail_info;

        public Academician(int id, string name, string faculty, string department, string mail, string phone, string website, string office_hours, string education, string detail_info) {
            Id = id;
            Name = name;
            Faculty = faculty;
            Department = department;
            Mail = mail;
            Phone = phone;
            Website = website;
            Office_hours = office_hours;
            Education = education;
            Detail_info = detail_info;
        }

        public Academician(int id, string name, string faculty, string department) {
            Id = id;
            Name = name;
            Faculty = faculty;
            Department = department;
        }
    }
}