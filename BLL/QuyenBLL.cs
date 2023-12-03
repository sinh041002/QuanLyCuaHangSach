using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QuyenBLL
    {
        public static List<QuyenDTO> listQuyen = null;

        public List<QuyenDTO> getListQuyen()
        {
            QuyenDAL quyenDTO = new QuyenDAL();
            listQuyen = quyenDTO.getListQuyen();
            if (listQuyen != null)
            {
                return listQuyen;
            }
            else return listQuyen;
        }

        public Boolean themQuyen(QuyenDTO quyen)
        {

            QuyenDAL quyenDAL = new QuyenDAL();
            Boolean kt = quyenDAL.themQuyen(quyen);
            return kt;
        }

        public Boolean suaQuyen(QuyenDTO quyen)
        {

            QuyenDAL quyenDAL = new QuyenDAL();
            Boolean kt = quyenDAL.suaQuyen(quyen);
            return kt;
        }

        public Boolean xoaQuyen(int maQuyen)
        {

            QuyenDAL quyenDAL = new QuyenDAL();
            Boolean kt = quyenDAL.xoaQuyen(maQuyen);

            if (kt)
            {
                return kt;
            }
            return false;
        }
        public QuyenDTO GetItemQuyen(int id)
        {
            QuyenDAL quyenDTO = new QuyenDAL();
            listQuyen = quyenDTO.getListQuyen();
            //List<int> result = new List<int>();
            QuyenDTO quyenItem = new QuyenDTO();   
            for(int i = 0; i < listQuyen.Count; i++)
            {
               if (listQuyen[i].MaQuyen == id)
                {
                   quyenItem = listQuyen[i];
                }
            }
            return quyenItem;
        }
    }
}
