
测试一：
 string wkt= "POLYGON((13743949.17417164 5123794.654281617, 13743970.672085842 5123897.366538367, 13744001.72462858 5123894.977881233, 13744374.35514144 5123896.1722098, 13744333.747970168 5123763.601738879, 13744233.424370585 5123766.587560293, 13743999.33597143 5123765.393231726, 13744002.321792847 5123706.871131938, 13744004.113285698 5123686.567546296, 13744015.459407086 5123501.446618393, 13743963.506114416 5123490.1004970055, 13743900.803864641 5123481.7401970355, 13743901.401028965 5123792.265624484, 13743949.17417164 5123794.654281617))";
 string gcj02_geojson = CoordsTrans.Trans_3857toGCJ02(wkt);
 string ss = CoordsTrans.CoordsTrans.Trans_3857toGCJ02("MULTILINESTRING((11338794.17999267578125 4372873.4100341796875,11338748.7900390625 4372913.41998291015625)) ");

测试二：
{
        static void Main(string[] args)
        {
            string sql = "select sde.st_astext(shape) as WKT from pipesectionhpa";
            DataTable dt = OraHelper.ExecuteDataSet(sql).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string strName = dt.Rows[i]["WKT"].ToString();
                string bd09=CoordsTrans.Trans_3857toBD09(strName);
                string gcj02 = CoordsTrans.Trans_3857toGCJ02(strName);
             }
        }
    }
