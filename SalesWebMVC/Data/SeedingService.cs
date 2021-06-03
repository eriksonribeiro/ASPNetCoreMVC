using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Department department1 = new Department() { Name = "Music" };
            Department department2 = new Department() { Name = "FanFics" };
            Department department3 = new Department() { Name = "Fashion" };
            Department department4 = new Department() { Name = "Books" };
                                                       
            Seller seller1 = new Seller() {Name = "Madonna"  , Email = "mdna@studio69.com"       , BirthDate = new DateTime(1958, 8, 16) , BaseSalary = 5000.00, Department = department1};
            Seller seller2 = new Seller() {Name = "Rihanna"  , Email = "badgirlriri@studio69.com", BirthDate = new DateTime(1988, 2, 22) , BaseSalary = 5000.00, Department = department3};
            Seller seller3 = new Seller() {Name = "Beyoncé"  , Email = "bey@studio69.com"        , BirthDate = new DateTime(1981, 9, 04) , BaseSalary = 5000.00, Department = department3};
            Seller seller4 = new Seller() {Name = "Christina", Email = "xtina@studio69.com"      , BirthDate = new DateTime(1980, 12, 18), BaseSalary = 5000.00, Department = department2};
            Seller seller5 = new Seller() {Name = "Lady Gaga", Email = "monster@studio69.com"    , BirthDate = new DateTime(1986, 3, 28) , BaseSalary = 5000.00, Department = department2};
            Seller seller6 = new Seller() {Name = "Robin"    , Email = "honey@studio69.com"      , BirthDate = new DateTime(1979, 6, 12) , BaseSalary = 5000.00, Department = department4};

            SalesRecord salesRecord1 = new SalesRecord() { Date = new DateTime(2020, 1, 1), Amount = 10000.00, Status = SaleStatus.Billed  , Seller = seller1};
            SalesRecord salesRecord2 = new SalesRecord()  {Date = new DateTime(2020, 2, 1), Amount =  5000.00, Status = SaleStatus.Billed  , Seller = seller1};
            SalesRecord salesRecord3 = new SalesRecord()  {Date = new DateTime(2020, 3, 1), Amount = 10000.00, Status = SaleStatus.Pending , Seller = seller1};
            SalesRecord salesRecord4 = new SalesRecord()  {Date = new DateTime(2018, 4, 1), Amount =    60.00, Status = SaleStatus.Billed  , Seller = seller1};
            SalesRecord salesRecord5 = new SalesRecord()  {Date = new DateTime(2020, 5, 1), Amount = 10000.00, Status = SaleStatus.Canceled, Seller = seller1};
            SalesRecord salesRecord6 = new SalesRecord()  {Date = new DateTime(2020, 1, 1), Amount =     5.00, Status = SaleStatus.Billed  , Seller = seller2};
            SalesRecord salesRecord7 = new SalesRecord()  {Date = new DateTime(2020, 1, 1), Amount = 10000.00, Status = SaleStatus.Billed  , Seller = seller2};
            SalesRecord salesRecord8 = new SalesRecord()  {Date = new DateTime(2018, 1, 1), Amount =   550.00, Status = SaleStatus.Billed  , Seller = seller2};
            SalesRecord salesRecord9 = new SalesRecord()  {Date = new DateTime(2020, 1, 1), Amount = 10000.00, Status = SaleStatus.Pending , Seller = seller2};
            SalesRecord salesRecord10 = new SalesRecord() {Date = new DateTime(2020, 1, 1), Amount = 10000.00, Status = SaleStatus.Billed  , Seller = seller2};
            SalesRecord salesRecord11 = new SalesRecord() {Date = new DateTime(2020, 1, 1), Amount =   500.00, Status = SaleStatus.Billed  , Seller = seller3};
            SalesRecord salesRecord12 = new SalesRecord() {Date = new DateTime(2020, 1, 1), Amount = 10000.00, Status = SaleStatus.Billed  , Seller = seller3};
            SalesRecord salesRecord13 = new SalesRecord() {Date = new DateTime(2021, 1, 1), Amount =   666.00, Status = SaleStatus.Canceled, Seller = seller3};
            SalesRecord salesRecord14 = new SalesRecord() {Date = new DateTime(2021, 2, 1), Amount = 10000.00, Status = SaleStatus.Billed  , Seller = seller3};
            SalesRecord salesRecord15 = new SalesRecord() {Date = new DateTime(2021, 3, 1), Amount =   300.00, Status = SaleStatus.Billed  , Seller = seller3};
            SalesRecord salesRecord16 = new SalesRecord() {Date = new DateTime(2017, 1, 1), Amount = 10000.00, Status = SaleStatus.Billed  , Seller = seller4};
            SalesRecord salesRecord17 = new SalesRecord() {Date = new DateTime(2020, 1, 1), Amount = 10000.00, Status = SaleStatus.Billed  , Seller = seller4};
            SalesRecord salesRecord18 = new SalesRecord() {Date = new DateTime(2020, 1, 1), Amount = 10000.00, Status = SaleStatus.Billed  , Seller = seller4};
            SalesRecord salesRecord19 = new SalesRecord() {Date = new DateTime(2019, 1, 1), Amount = 10000.00, Status = SaleStatus.Pending , Seller = seller4};
            SalesRecord salesRecord20 = new SalesRecord() {Date = new DateTime(2019, 2, 1), Amount = 10000.00, Status = SaleStatus.Billed  , Seller = seller4};
            SalesRecord salesRecord21 = new SalesRecord() {Date = new DateTime(2019, 3, 1), Amount = 10000.00, Status = SaleStatus.Billed  , Seller = seller5};
            SalesRecord salesRecord22 = new SalesRecord() {Date = new DateTime(2019, 4, 1), Amount =   789.00, Status = SaleStatus.Billed  , Seller = seller5};
            SalesRecord salesRecord23 = new SalesRecord() {Date = new DateTime(2019, 5, 1), Amount = 10000.00, Status = SaleStatus.Billed  , Seller = seller5};
            SalesRecord salesRecord24 = new SalesRecord() {Date = new DateTime(2020, 1, 1), Amount = 10000.00, Status = SaleStatus.Billed  , Seller = seller6};
            SalesRecord salesRecord25 = new SalesRecord() {Date = new DateTime(2020, 1, 1), Amount =    40.00, Status = SaleStatus.Canceled, Seller = seller6};
            SalesRecord salesRecord26 = new SalesRecord() {Date = new DateTime(2020, 1, 1), Amount = 10000.00, Status = SaleStatus.Billed  , Seller = seller6};
            SalesRecord salesRecord27 = new SalesRecord() {Date = new DateTime(2020, 1, 1), Amount =    11.00, Status = SaleStatus.Pending , Seller = seller6};
            SalesRecord salesRecord28 = new SalesRecord() {Date = new DateTime(2021, 1, 1), Amount = 15000.00, Status = SaleStatus.Billed  , Seller = seller6};
            SalesRecord salesRecord29 = new SalesRecord() {Date = new DateTime(2021, 2, 1), Amount =   500.00, Status = SaleStatus.Billed  , Seller = seller6};
            SalesRecord salesRecord30 = new SalesRecord() {Date = new DateTime(2021, 3, 1), Amount =   300.00, Status = SaleStatus.Canceled, Seller = seller6};

            _context.Department.AddRange(department1, department2, department3, department4);
            _context.Seller.AddRange(seller1, seller2, seller3, seller4, seller5, seller6);
            _context.SalesRecord.AddRange(salesRecord1,  salesRecord2,  salesRecord3,  salesRecord4,  salesRecord5,  salesRecord6,
                                          salesRecord7,  salesRecord8,  salesRecord9,  salesRecord10, salesRecord11, salesRecord12,
                                          salesRecord13, salesRecord14, salesRecord15, salesRecord16, salesRecord17, salesRecord18,
                                          salesRecord19, salesRecord20, salesRecord21, salesRecord22, salesRecord23, salesRecord24,
                                          salesRecord25, salesRecord26, salesRecord27, salesRecord28, salesRecord29, salesRecord30
                                        );

            _context.SaveChanges();
        }
    }
}
