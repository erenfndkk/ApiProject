﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Lütfen oda numarasını giriniz.")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Lütfen oda görseli bilgisini giriniz")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen fiyat bilgisini giriniz")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen oda başlığı bilgisini giriniz")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısı bilgisini giriniz")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo sayısı bilgisini giriniz")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }

        [Required(ErrorMessage = "Lütfen açıklama bilgisini giriniz")]
        public string Description { get; set; }
    }
}
