using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OfficeSupport
{
    class Global
    {
        public static Boolean PROCESS_SUCCESS = true;
        public static Boolean PROCESS_FAIL = false;

        public static string STR_SAVE_SUCCESS = "บันทึกข้อมูลสำเร็จ";
        public static string STR_SAVE_FAIL = "บันทึกข้อมูลไม่สำเร็จ";
        public static string STR_UPDATE_SUCCESS = "ปรับปรุงข้อมูลสำเร็จ";
        public static string STR_UPDATE_FAIL = "ปรับปรุงข้อมูลไม่สำเร็จ";
        public static string STR_DELETE_SUCCESS = "ลบข้อมูลไม่สำเร็จ";
        public static string STR_DELETE_FAIL = "ลบข้อมูลไม่สำเร็จ";
        public static string STR_WANT_SAVE = "ต้องการบันทึกข้อมูลใช่หรือไม่?";
        public static string STR_WANT_UPDATE = "ต้องการปรับปรุงข้อมูลใช่หรือไม่?";
        public static string STR_WANT_EXIT = "ต้องการออกใช่หรือไม่?";
        public static string STR_WANT_EXIT_APPLICATION = "ต้องการออกจากโปรแกรมใช่หรือไม่?";
        public static string STR_ACC_NOT_GRANT = "ผู้ใช้งานนี้ไม่สามารถดำเนินการได้";

        public static string STR_ERR_CONTACT_SYSTEM_SUPPORT = "การทำงานผิดพลาด กรุณาติดต่อผู้ดูแลระบบ";

        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserLevel { get; set; }

          static private Global g ;

          static public Global newInstance() {
              if (g == null) {
                  g = new Global();
              }

             return g;    
         }

          static public void free() {
              if (g != null) {
                  g = null;
              }
          }
    }
}
