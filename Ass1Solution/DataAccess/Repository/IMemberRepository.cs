using System;
using System.Collections.Generic;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> getMembers();

        Member GetMemberByID(int id);
        Member GetMemberByName(string name);
        void InsertMember(Member member);
        void DeleteMember(int id);
        void UpdateMember(Member member);

        List<Member> GetMemberByCityCountry(string city,string country);
    }
}
