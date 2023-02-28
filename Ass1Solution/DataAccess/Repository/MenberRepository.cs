using System;
using System.Collections.Generic;
using BusinessObject;

namespace DataAccess.Repository
{
    internal interface MenberRepository
    {
        public Member GetMemberByID(int memberId) => MemberDAO.Instance.GetMemberByID(memberId);
        public Member GetMemberByName(string memberName) => MemberDAO.Instance.GetMemberByName(memberName);

        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMemberList;
        public void InsertMember(Member member) => MemberDAO.Instance.NewMember(member);
        public void DeleteMember(int memberId) => MemberDAO.Instance.RemoveMember(memberId);
        public void UpdateMember(Member member) => MemberDAO.Instance.UpdateMember(member);


    }
}
