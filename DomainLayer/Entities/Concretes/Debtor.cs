﻿using DomainLayer.Entities.Abstracts;

namespace DomainLayer.Entities.Concretes;

public class Debtor : BaseEntity
{
    public string FullName { get; set; }
    public DateTime BirthDay { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    public int Debt { get; set; }

    public Debtor() { }

    public Debtor(int Id,string fullName, DateTime birthDay, string? phone, string? email, string? address, int debt)
    {
        this.Id = Id;
        FullName = fullName;
        BirthDay = birthDay;
        Phone = phone;
        Email = email;
        Address = address;
        Debt = debt;
    }
}
