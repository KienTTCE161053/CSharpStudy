using System;
using System.Collections.Generic;
using System.Linq;
using BusinessObject;

namespace DataAccess
{
    internal class MemberDAO
    {
        private static List<Member> MemberList = new List<Member>()
        {
            new Member{MemberID=1234,Name="Kien",Email="KienTTCE161053@fpt.edu.vn",City="Kien Giang",Country="Viet Nam",Password="Kien2023"},
            new Member{MemberID=1235,Name="Hieu",Email="Hieu2023@gmail.com",City="Hau Giang",Country="Viet Nam",Password="Hieu2023"},
            new Member{MemberID=1236,Name="Hai",Email="Hai2023@gmail.com",City="Bac Lieu",Country="Viet Nam",Password="Hai2023"},
            new Member{MemberID=1237,Name="Quy",Email="Quy2023@gmail.com",City="Cà Mau",Country="Viet Nam",Password="Quy2023"},

        };

        private static MemberDAO instance = null;

        private static readonly object instanceLock = new object();
        private MemberDAO() { }

        public List<Member> GetMemberByCityCountry(string city, string country)
        {
            List<Member> memberList = new List<Member>();
            //lấy từng member
            foreach (Member member in MemberList)
            {
                if (member.City.Equals(city) && member.Country.Equals(country)) {
                    memberList.Add(member);
                }
            }
            return memberList;
        }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock){
                    if (instance == null){
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Member> GetMemberList => MemberList;
        public Member GetMemberByID(int memberID){

            Member member = MemberList.SingleOrDefault(member => member.MemberID == memberID);
            return member;
        }


        public Member GetMemberByName(string memberName){

            Member member = MemberList.SingleOrDefault(member => member.Name == memberName);
            return member;
        }

        public void NewMember(Member member){
            Member pro = GetMemberByID(member.MemberID);
            if (pro == null)
            {
                MemberList.Add(member);
            }
            else
            {
                throw new Exception("This member is already exists");
            }
        }

        public void UpdateMember(Member member){
            Member c = GetMemberByID(member.MemberID);
            if (c != null)
            {
                var index = MemberList.IndexOf(c);
                MemberList[index] = member;
            }
            else
            {
                throw new Exception("Member does not already exists.");
            }
        }

        public void RemoveMember(int MemberID){
            Member p = GetMemberByID(MemberID);
            if (p != null)
            {
                MemberList.Remove(p);
            }
            else
            {
                throw new Exception("Member does not already exists.");
            }
        }
    }
}
