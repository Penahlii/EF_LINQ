using DataAccess.Contexts;
using DataAccess.Repositories.Concretes;
using DomainLayer.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            DebtorsContext debtorsContext = new DebtorsContext();

            ///*2) rhyta.com ve ya dayrep.com domenlerinde emaili olan borclulari cixartmag*/

            //var debtors1 = debtorsContext.Debtors
            //    .Where(debtor => debtor.Email.EndsWith("@rhyta.com") || debtor.Email.EndsWith("@dayrep.com"))
            //    .ToList();

            ////3) Yashi 26 - dan 36 - ya qeder olan borclulari cixartmag


            //var debtors2 = debtorsContext.Debtors
            //   .Where(debtor => DateTime.Now.Year- debtor.BirthDay.Year >= 26 && DateTime.Now.Year - debtor.BirthDay.Year <= 36)
            //   .ToList();



            ////4) Borcu 5000 - den cox olmayan borclularic cixartmag

            //var debtors3 = debtorsContext.Debtors
            //  .Where(debtor => debtor.Debt <= 5000)
            //  .ToList();

            //5) Butov adi 18 simvoldan cox olan ve telefon nomresinde 2 ve ya 2 - den cox 7 reqemi olan borclulari cixartmaq

            //var debtors4 = debtorsContext.Debtors.Where(debtor =>
            //    debtor.FullName.Length > 18).ToList().Where(debtor => debtor.Phone.Count(c => c == '7') >= 2);


            //7) Qishda anadan olan borclulari cixardmaq

            //var debtors5 = debtorsContext.Debtors.Where(debtor =>
            //    debtor.BirthDay.Month == 12 ||
            //    debtor.BirthDay.Month == 1 ||  
            //    debtor.BirthDay.Month == 2)    
            //    .ToList();

            ////8) Borcu, umumi borclarin orta borcunnan cox olan borclulari cixarmaq ve evvel familyaya gore sonra ise meblegin azalmagina gore sortirovka etmek



            //var averageDebt = debtorsContext.Debtors.Average(debtor => debtor.Debt);
            //var debtors6 = debtorsContext.Debtors
            //    .Where(debtor => debtor.Debt > averageDebt)

            //    .OrderBy(debtor => debtor.Debt)
            //    .ToList();




            //9) Telefon nomresinde 8 olmayan borclularin yalniz familyasin, yashin ve umumi borcun meblegin cixarmaq


            //var without8 = debtorsContext.Debtors.Where(debtor =>
            //    !debtor.Phone.Contains('8'));

            //var debtors7 = without8.Select(debtor =>
            //    new
            //    {
            //        Surname = debtor.FullName.Split(' ')[1],
            //        Age = (DateTime.Now - debtor.BirthDay).Days / 365,
            //        TotalDebt = debtor.Debt
            //    }).ToList();



            //11)Adinda ve familyasinda hec olmasa 3 eyni herf olan borclularin siyahisin cixarmaq ve onlari elifba sirasina gore sortirovka elemek


            //var debtors8 = debtorsContext.Debtors.Where(debtor =>
            //{
            //    var firstName = debtor.FullName.Split(' ')[0]; 
            //    var lastName = debtor.FullName.Split(' ')[1]; 
            //    return firstName.GroupBy(c => c).Any(g => g.Count() >= 3) &&
            //           lastName.GroupBy(c => c).Any(g => g.Count() >= 3);
            //});

            //var sortedDebtors = debtorsWithThreeIdenticalLetters.OrderBy(debtor => debtor.FullName).ToList();


            ////13)borclulardan en coxu hansi ilde dogulubsa hemin ili cixartmaq

            //var debtors9 = debtorsContext.Debtors
            //    .GroupBy(debtor => debtor.BirthDay.Year) 
            //    .OrderByDescending(group => group.Count()) 
            //    .Select(group => group.Key) 
            //    .FirstOrDefault(); 

            ////Console.WriteLine(debtors9);


            ////14) Borcu en boyuk olan 5 borclunun siyahisini cixartmaq

            //var debtors10 = debtorsContext.Debtors
            //    .OrderByDescending(debtor => debtor.Debt)
            //    .Take(5)
            //    .ToList();



            ////15)Butun borcu olanlarin borcunu cemleyib umumi borcu cixartmaq

            //var debtors11 = debtorsContext.Debtors
            //    .Sum(debtor => debtor.Debt);

            //Console.WriteLine(debtors11);

            //16)2ci dunya muharibesin gormush borclularin siyahisi cixartmaq

            //var debtors12 = debtorsContext.Debtors
            //    .Where(debtor => debtor.BirthDay.Year <= 1939);

            //foreach (var debtor in debtors12)
            //    Console.WriteLine(debtor.FullName);


            //18)Nomresinde tekrar reqemler olmayan borclularin ve onlarin borcunun meblegin cixartmaq

            //var debtors13 = debtorsContext.Debtors.Where(debtor =>
            //    debtor.Phone.Distinct().Count() == debtor.Phone.Length);

            //var netice = debtors13
            //    .Select(debtor => debtor.Debt)
            //    .ToList();


            //19)Tesevvur edek ki,butun borclari olanlar bugunden etibaren her ay 500 azn pul odeyecekler.Oz ad gunune kimi borcun oduyub qurtara bilenlerin siyahisin cixartmaq


            //var debtors14 = debtorsContext.Debtors
            //    .Where(d => (DateTime.Now.Year - d.BirthDay.Year) * 500 >= d.Debt);

            //foreach (var debtor in debtors14)
            //{ 
            //    Console.WriteLine(debtor.FullName);
            //}

            //20)Adindaki ve familyasindaki herflerden "smile" sozunu yaza bileceyimiz borclularin siyahisini cixartmaq

            //var debtorsWithSmileName = debtorsContext.Debtors.Where(debtor =>
            //{
            //    var fullName = debtor.FullName.ToLower(); 
            //    var smileLetters = "smile";

            //    foreach (char l in smileLetters)
            //    {
            //        if (!fullName.Contains(l))
            //            return false;
            //    }
            //    return true;
            //}).ToList();


        }
    }
}
