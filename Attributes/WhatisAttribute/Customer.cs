using System.ComponentModel.DataAnnotations;

namespace WhatisAttribute
{
    [Serializable]
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

    }
}
