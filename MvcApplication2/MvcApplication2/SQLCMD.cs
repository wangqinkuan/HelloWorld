using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2
{
    public static class SQLCMD
    {
        //查虫害信息
        public static class pestcmd
        {
            public static string AllpestInfo = "select * from pests order by id";
            //根据病虫id查询
            public static string pestInfo(string id) 
            {
                return "select * from pests where id=\'" + id+"\'";
            }
            //综合查询病虫
            public static string searchPest(string searchtxt) 
            {
                return "select * from pests where id like \'%" + searchtxt + "%\' or ScientificName like \'%" + searchtxt + "%\' or ScientificName_chs like \'%" + searchtxt + "%\'or Alias like \'%" + searchtxt + "%\'or Order_ like \'%" + searchtxt + "%\'or Family like \'%" + searchtxt + "%\'";

            }
            //选出ne克制的病虫
            public static string pestinfo_byneid(string id) 
            {
                return " select pests.id,pests.ScientificName_chs,pests.ScientificName,pests.Alias,pests.Order_,pests.Family,pests.Imago,pests.Egg,pests.Larva,pests.Occurence,pests.Distribution,pests.DamageSymptoms from NaturalEnemyofPests,pests where NaturalEnemyofPests.PestId=pests.id and NaturalEnemyofPests.NaturalEnemyId=\'" + id + "\'";
            }
            //通过杀虫剂id差害虫
            public static string pestinfo_bypcid(string id)
            {
                return "select * from pests,PesticideToPests where PesticideToPests.PestId=pests.id and PesticideToPests.PesticideId=\'" + id + "\'";
            }
        }
        //控制 方法
        public static class controllingmethodcmd 
        {
            //根据病虫id查方法
            public static string controlling_method_info(string pestid) { 
                return "select * from ControllingMethods where ControllingMethods.PestID=\'"+pestid+"\'"; 
            }
        }
        //天敌
        public static class naturalenemycmd 
        {
            //根据pestid选择
            public static string naturalenemy_info(string pestid) 
            {
                return "select NaturalEnemies.id,NaturalEnemies.ScientificName,NaturalEnemies.ScientificName_chs,NaturalEnemies.Alias,NaturalEnemies.Description from NaturalEnemies,NaturalEnemyofPests where NaturalEnemies.id=NaturalEnemyofPests.NaturalEnemyId and NaturalEnemyofPests.PestId =\'" + pestid + "\'";
            }
            //根据neid选择
            public static string naturalenemy_by_ne_id(string neid) 
            {
                return "select * from NaturalEnemies where id=\'" + neid + "\'";
            }
        }
        //point
        public static class point 
        {
            //select all
            public static string allpoints = "select * from ObservePoints";
            //综合查询
            public static string search(string address,string name) 
            {
                return "select * from ObservePoints where Address like \'%" + address + "%\' and Name like \'%" + name + "%\'";
            }
        }
        //杀虫剂
        public static class pesticide
        {
            //根据病虫害id查杀虫剂
            public static string pesticideinfo_bypestid(string id)
            {
                return "select * from Pesticides,PesticideToPests where Pesticides.id=PesticideToPests.PesticideId and PesticideToPests.PestId=\'" + id + "\'";
            }
            //根据厂商id查杀虫剂
            public static string pesticideinfo_bymid(string id)
            {
                return "select * from Pesticides,PesticideToMs where  PesticideToMs.PesticideId=Pesticides.id and PesticideToMs.ManufacturerId=\'" + id + "\'";
            }
        }
        //厂商
        public static class m 
        {
            //通过杀虫剂id查厂商
            public static string m_bypcid(string id)
            {
                return "select * from PesticideManufacturers,PesticideToMs where  PesticideManufacturers.ID=PesticideToMs.ManufacturerId and PesticideToMs.PesticideId=\'" + id + "\'";
            }
        }
    }
}