using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_2
{
    //base
    enum eTypeCharac
    {
        Player = 0,
        Monster 
    }
    //monster
    enum eTypeTribe
    {
        오크 = 0,
        인간,
        용족,
        엘프,
        유령
    }
    //player
    enum eTypeJob
    {
        전사 = 0,
        궁수,
        암살자,
        나무꾼
    }

    class BaseUnit
    {
        //이름,체력,공격력,방어력,eTypeCharac
        //초기화 함수, 피격함수, 정보 확인 함수
        int health;
        int def;
        int atk;
        string name;

        protected int Health
        {
            get
            {

            }
            set
            {

            }
        }
        protected int Def
        {
            get
            {

            }
            set
            {

            }
        }
        protected int Atk
        {
            get
            {

            }
            set
            {

            }
        }
        protected int Name
        {
            get
            {

            }
            set
            {

            }
        }

    }
}
