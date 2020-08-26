using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Serializers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Get_Api_Data_Thai.Models
{
    [BsonIgnoreExtraElements]
    public class ModelTest
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [Required]
        [Display(Name ="อำเภอ")]
        public string district { get; set; }

        [Required]
        [Display(Name ="อำเภอเมือง")]
        public string amphoe { get; set; }

        [Required]
        [Display(Name ="จังหวัด")]
        public string province { get; set; }

        [Required]
        [Display(Name = "รหัสไปรษณีย์")]
        public string zipcode { get; set; }

        [Required]
        [Display(Name ="รหัสอำเภอ")]
        public string district_code { get; set; }

        [Required]
        [Display(Name ="รหัสอำเภอ")]
        public string amphoe_code { get; set; }

        [Required]
        [Display(Name ="รหัสจังหวัด")]
        public string province_code { get; set; }
    }
}
