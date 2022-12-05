using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageDataManager
{
    public class PageData
    {
        public static string pageData_Con =
                "<!DOCTYPE>" +
            "<html>" +
            "  <head>" +
            "    <title>Converter of UOM</title>" +
            "  </head>" +
            "  <body>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/CO/\">Convert/</a>\r\n    <a href=\"{1}Page/LUD/\">List Unit Dimensions/</a>\r\n    <a href=\"{1}Page/UD/\">Unit Dimention Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/LA/\">List Alias/</a>\r\n    <a href=\"{1}Page/LQC/\">List Quality class/</a>\r\n    <a href=\"{1}Page/QC/\">Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/CUOM/\">Create UOM/</a>\r\n    <a href=\"{1}Page/CQC/\">Create Quality class/</a>\r\n    <a href=\"{1}Page/AQC/\">Add Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/EUOM/\">Edit UOM/</a>\r\n    <a href=\"{1}Page/EQC/\">Edit Quality class/</a>\r\n    <a href=\"{1}Page/RQC/\">Remove Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/DUOM/\">Delete UOM/</a>\r\n    <a href=\"{1}Page/DQC/\">Delete Quality class Page/</a>\r\n   </div>\r\n</div>" +
            "<div id=\"1\">" +
            "    <form method=\"post\" action=\"{1}Convert/\">" +
            "       <label for=\"value\">Value:</label><br>" +
            "       <input type=\"text\" id=\"value\" name=\"number\" value=\"0\"><br>" +
             "       <label for=\"inputuom\">InputUOM:</label><br>" +
            "       <input type=\"text\" id=\"inputuom\" name=\"uom1\" value=\"meter\"><br>" +
            "       <label for=\"outputuom\">OutputUOM:</label><br>" +
            "       <input type=\"text\" id=\"outputuom\" name=\"uom2\" value=\"mile\"><br>" +
            "      <input type=\"submit\" value=\"Convert\">" +
             "    </form>" +
            "</div>" +
            "   <div class=\"parent\", style=\"text-align-last: center\" >" +
            "      <div class=\"Output\">Output: \n</div>" +
            "      <div class=\"child two\"><p>{2}</p></div>" +
            "    </div>" +
            "  </body>" +
            "</html>";

        public static string pageData_LUD =
            "<!DOCTYPE>" +
            "<html>" +
            "  <head>" +
            "    <title>Converter of UOM</title>" +
            "  </head>" +
            "  <body>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/CO/\">Convert/</a>\r\n    <a href=\"{1}Page/LUD/\">List Unit Dimensions/</a>\r\n    <a href=\"{1}Page/UD/\">Unit Dimention Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/LA/\">List Alias/</a>\r\n    <a href=\"{1}Page/LQC/\">List Quality class/</a>\r\n    <a href=\"{1}Page/QC/\">Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/CUOM/\">Create UOM/</a>\r\n    <a href=\"{1}Page/CQC/\">Create Quality class/</a>\r\n    <a href=\"{1}Page/AQC/\">Add Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/EUOM/\">Edit UOM/</a>\r\n    <a href=\"{1}Page/EQC/\">Edit Quality class/</a>\r\n    <a href=\"{1}Page/RQC/\">Remove Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/DUOM/\">Delete UOM/</a>\r\n    <a href=\"{1}Page/DQC/\">Delete Quality class Page/</a>\r\n   </div>\r\n</div>" +
            "<div id=\"2\">" +
            "   <form id=\"1\" method=\"get\" action=\"{1}List/Dimensions\">" +
            "       <label>LUD:</label><br>" +
            "      <input type=\"submit\" name=\"LUD\" value=\"List Unit Dimentions\">" +
            "    </ form > " +
            "</div>" +
            "   <div class=\"parent\", style=\"text-align-last: center\" >" +
            "      <div class=\"Output\">Output: \n</div>" +
            "      <div class=\"child two\"><p>{2}</p></div>" +
            "    </div>" +
            "  </body>" +
            "</html>";

        public static string pageData_UD =
            "<!DOCTYPE>" +
            "<html>" +
            "  <head>" +
            "    <title>Converter of UOM</title>" +
            "  </head>" +
            "  <body>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/CO/\">Convert/</a>\r\n    <a href=\"{1}Page/LUD/\">List Unit Dimensions/</a>\r\n    <a href=\"{1}Page/UD/\">Unit Dimention Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/LA/\">List Alias/</a>\r\n    <a href=\"{1}Page/LQC/\">List Quality class/</a>\r\n    <a href=\"{1}Page/QC/\">Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/CUOM/\">Create UOM/</a>\r\n    <a href=\"{1}Page/CQC/\">Create Quality class/</a>\r\n    <a href=\"{1}Page/AQC/\">Add Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/EUOM/\">Edit UOM/</a>\r\n    <a href=\"{1}Page/EQC/\">Edit Quality class/</a>\r\n    <a href=\"{1}Page/RQC/\">Remove Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/DUOM/\">Delete UOM/</a>\r\n    <a href=\"{1}Page/DQC/\">Delete Quality class Page/</a>\r\n   </div>\r\n</div>" +
             "<div id=\"4\">" +
            "   <form id=\"3\" method=\"post\" action=\"{1}Dimension/\">" +
            "       <label>UD:</label><br>" +
            "       <input type=\"text\" id=\"UD\" name=\"UD\" value=\"Unit Dimension Name\"><br>" +
            "      <input type=\"submit\" name=\"UD1\" value=\"Unit Dimention\">" +
            "    </ form > " +
            "</div>" +
            "   <div class=\"parent\", style=\"text-align-last: center\" >" +
            "      <div class=\"Output\">Output: \n</div>" +
            "      <div class=\"child two\"><p>{2}</p></div>" +
            "    </div>" +
            "  </body>" +
            "</html>";


        public static string pageData_LA =
           "<!DOCTYPE>" +
            "<html>" +
            "  <head>" +
            "    <title>Converter of UOM</title>" +
            "  </head>" +
            "  <body>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/CO/\">Convert/</a>\r\n    <a href=\"{1}Page/LUD/\">List Unit Dimensions/</a>\r\n    <a href=\"{1}Page/UD/\">Unit Dimention Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/LA/\">List Alias/</a>\r\n    <a href=\"{1}Page/LQC/\">List Quality class/</a>\r\n    <a href=\"{1}Page/QC/\">Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/CUOM/\">Create UOM/</a>\r\n    <a href=\"{1}Page/CQC/\">Create Quality class/</a>\r\n    <a href=\"{1}Page/AQC/\">Add Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/EUOM/\">Edit UOM/</a>\r\n    <a href=\"{1}Page/EQC/\">Edit Quality class/</a>\r\n    <a href=\"{1}Page/RQC/\">Remove Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/DUOM/\">Delete UOM/</a>\r\n    <a href=\"{1}Page/DQC/\">Delete Quality class Page/</a>\r\n   </div>\r\n</div>" +
                      "<div id=\"4\">" +
            "   <form id=\"3\" method=\"post\" action=\"{1}List/Alias\">" +
            "       <label>LA :</label><br>" +
            "       <input type=\"text\" id=\"U\" name=\"U\" value=\"Unit Name\"><br>" +
            "      <input type=\"submit\" name=\"LA\" value=\"List Alias\">" +
            "    </ form > " +
            "</div>" +
            "   <div class=\"parent\", style=\"text-align-last: center\" >" +
            "      <div class=\"Output\">Output: \n</div>" +
            "      <div class=\"child two\"><p>{2}</p></div>" +
            "    </div>" +
            "  </body>" +
            "</html>";



        public static string pageData_LQC =
         "<!DOCTYPE>" +
         "<html>" +
         "  <head>" +
         "    <title>Converter of UOM</title>" +
         "  </head>" +
         "  <body>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/CO/\">Convert/</a>\r\n    <a href=\"{1}Page/LUD/\">List Unit Dimensions/</a>\r\n    <a href=\"{1}Page/UD/\">Unit Dimention Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/LA/\">List Alias/</a>\r\n    <a href=\"{1}Page/LQC/\">List Quality class/</a>\r\n    <a href=\"{1}Page/QC/\">Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/CUOM/\">Create UOM/</a>\r\n    <a href=\"{1}Page/CQC/\">Create Quality class/</a>\r\n    <a href=\"{1}Page/AQC/\">Add Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/EUOM/\">Edit UOM/</a>\r\n    <a href=\"{1}Page/EQC/\">Edit Quality class/</a>\r\n    <a href=\"{1}Page/RQC/\">Remove Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/DUOM/\">Delete UOM/</a>\r\n    <a href=\"{1}Page/DQC/\">Delete Quality class Page/</a>\r\n   </div>\r\n</div>" +
                   "<div id=\"2\">" +
         "   <form id=\"1\" method=\"get\" action=\"{1}List/Qualityclass\">" +
         "       <label>LQC:</label><br>" +
         "      <input type=\"submit\" name=\"LQC\" value=\"List Quality class\">" +
         "    </ form > " +
         "</div>" +
         "   <div class=\"parent\", style=\"text-align-last: center\" >" +
         "      <div class=\"Output\">Output: \n</div>" +
         "      <div class=\"child two\"><p>{2}</p></div>" +
         "    </div>" +
         "  </body>" +
         "</html>";

        public static string pageData_QC =
           "<!DOCTYPE>" +
           "<html>" +
           "  <head>" +
           "    <title>Converter of UOM</title>" +
           "  </head>" +
           "  <body>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/CO/\">Convert/</a>\r\n    <a href=\"{1}Page/LUD/\">List Unit Dimensions/</a>\r\n    <a href=\"{1}Page/UD/\">Unit Dimention Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/LA/\">List Alias/</a>\r\n    <a href=\"{1}Page/LQC/\">List Quality class/</a>\r\n    <a href=\"{1}Page/QC/\">Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/CUOM/\">Create UOM/</a>\r\n    <a href=\"{1}Page/CQC/\">Create Quality class/</a>\r\n    <a href=\"{1}Page/AQC/\">Add Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/EUOM/\">Edit UOM/</a>\r\n    <a href=\"{1}Page/EQC/\">Edit Quality class/</a>\r\n    <a href=\"{1}Page/RQC/\">Remove Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/DUOM/\">Delete UOM/</a>\r\n    <a href=\"{1}Page/DQC/\">Delete Quality class Page/</a>\r\n   </div>\r\n</div>" +
             "<div id=\"4\">" +
            "   <form id=\"3\" method=\"post\" action=\"{1}Qualityclass\">" +
            "       <label>QC :</label><br>" +
            "       <input type=\"text\" id=\"QC\" name=\"QC\" value=\"Quality class Name\"><br>" +
            "      <input type=\"submit\" name=\"QC\" value=\"Get Quality class\">" +
            "    </ form > " +
            "</div>" +
           "   <div class=\"parent\", style=\"text-align-last: center\" >" +
           "      <div class=\"Output\">Output: \n</div>" +
           "      <div class=\"child two\"><p>{2}</p></div>" +
           "    </div>" +
           "  </body>" +
           "</html>";

        //CUOM, CQC, AQC
        //EUOM, EQC, RQC
        //DUOM, DQC

        public static string pageData_CUOM =
              "<!DOCTYPE>" +
            "<html>" +
            "  <head>" +
            "    <title>Converter of UOM</title>" +
            "  </head>" +
            "  <body>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/CO/\">Convert/</a>\r\n    <a href=\"{1}Page/LUD/\">List Unit Dimensions/</a>\r\n    <a href=\"{1}Page/UD/\">Unit Dimention Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/LA/\">List Alias/</a>\r\n    <a href=\"{1}Page/LQC/\">List Quality class/</a>\r\n    <a href=\"{1}Page/QC/\">Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/CUOM/\">Create UOM/</a>\r\n    <a href=\"{1}Page/CQC/\">Create Quality class/</a>\r\n    <a href=\"{1}Page/AQC/\">Add Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/EUOM/\">Edit UOM/</a>\r\n    <a href=\"{1}Page/EQC/\">Edit Quality class/</a>\r\n    <a href=\"{1}Page/RQC/\">Remove Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/DUOM/\">Delete UOM/</a>\r\n    <a href=\"{1}Page/DQC/\">Delete Quality class Page/</a>\r\n   </div>\r\n</div>" +
            //string id, string annotation, string name, string qualitytype, string dimensionalclass, string baseunit

            "<div id=\"4\">" +
            "   <form id=\"3\" method=\"post\" action=\"{1}CUOM\">" +
            "       <label>CUOM :</label><br>" +
            "       <input type=\"text\" id=\"id\" name=\"id\" value=\"Unit id\"><br>" +
             "       <input type=\"text\" id=\"annotation\" name=\"annotation\" value=\"Unit annotation\"><br>" +
             "       <input type=\"text\" id=\"name\" name=\"name\" value=\"Unit name\"><br>" +
             "       <input type=\"text\" id=\"qualitytype\" name=\"qualitytype\" value=\"Unit qualitytype\"><br>" +
             "       <input type=\"text\" id=\"dimensionalclass\" name=\"dimensionalclass\" value=\"Unit dimensionalclass\"><br>" +
             "       <input type=\"text\" id=\"baseunit\" name=\"baseunit\" value=\"Unit baseunit\"><br>" +
            "      <input type=\"submit\" name=\"CUOM\" value=\"Create UOM\">" +
            "    </ form > " +
            "</div>" +
           "   <div class=\"parent\", style=\"text-align-last: center\" >" +
           "      <div class=\"Output\">Output: \n</div>" +
           "      <div class=\"child two\"><p>{2}</p></div>" +
           "    </div>" +
            "  </body>" +
            "</html>";
        public static string pageData_CQC =
           "<!DOCTYPE>" +
            "<html>" +
            "  <head>" +
            "    <title>Converter of UOM</title>" +
            "  </head>" +
            "  <body>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/CO/\">Convert/</a>\r\n    <a href=\"{1}Page/LUD/\">List Unit Dimensions/</a>\r\n    <a href=\"{1}Page/UD/\">Unit Dimention Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/LA/\">List Alias/</a>\r\n    <a href=\"{1}Page/LQC/\">List Quality class/</a>\r\n    <a href=\"{1}Page/QC/\">Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/CUOM/\">Create UOM/</a>\r\n    <a href=\"{1}Page/CQC/\">Create Quality class/</a>\r\n    <a href=\"{1}Page/AQC/\">Add Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/EUOM/\">Edit UOM/</a>\r\n    <a href=\"{1}Page/EQC/\">Edit Quality class/</a>\r\n    <a href=\"{1}Page/RQC/\">Remove Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/DUOM/\">Delete UOM/</a>\r\n    <a href=\"{1}Page/DQC/\">Delete Quality class Page/</a>\r\n   </div>\r\n</div>" +
            //string name, string baseunit

            "<div id=\"4\">" +
            "   <form id=\"5\" method=\"post\" action=\"{1}CQC\">" +
            "       <label>CQC :</label><br>" +
            "       <input type=\"text\" id=\"name\" name=\"name\" value=\"Quality class Name\"><br>" +
             "       <input type=\"text\" id=\"baseunit\" name=\"baseunit\" value=\"Quality class Base Unit\"><br>" +
            "      <input type=\"submit\" name=\"CQC\" value=\"Create Quality class\">" +
            "    </ form > " +
            "</div>" +
           "   <div class=\"parent\", style=\"text-align-last: center\" >" +
           "      <div class=\"Output\">Output: \n</div>" +
           "      <div class=\"child two\"><p>{2}</p></div>" +
           "    </div>" +
            "  </body>" +
            "</html>";
        public static string pageData_AQC;
        public static string pageData_EUOM;
        public static string pageData_EQC;
        public static string pageData_RQC;
        public static string pageData_DUOM;
        public static string pageData_DQC;

       


        public static string pageDataMeny =
            "<!DOCTYPE>" +
            "<html>" +
            "  <head>" +
            "    <title>Converter of UOM</title>" +
            "  </head>" +
            "  <body>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/CO/\">Convert/</a>\r\n    <a href=\"{1}Page/LUD/\">List Unit Dimensions/</a>\r\n    <a href=\"{1}Page/UD/\">Unit Dimention Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/LA/\">List Alias/</a>\r\n    <a href=\"{1}Page/LQC/\">List Quality class/</a>\r\n    <a href=\"{1}Page/QC/\">Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/CUOM/\">Create UOM/</a>\r\n    <a href=\"{1}Page/CQC/\">Create Quality class/</a>\r\n    <a href=\"{1}Page/AQC/\">Add Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/EUOM/\">Edit UOM/</a>\r\n    <a href=\"{1}Page/EQC/\">Edit Quality class/</a>\r\n    <a href=\"{1}Page/RQC/\">Remove Quality class Page</a>\r\n  </div>\r\n</div>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Meny Options</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}Page/DUOM/\">Delete UOM/</a>\r\n    <a href=\"{1}Page/DQC/\">Delete Quality class Page/</a>\r\n   </div>\r\n</div>" +
            
            "  </body>" +
            "</html>";

        public static string page_example =
                "<!DOCTYPE>" +
            "<html>" +
            "  <head>" +
            "    <title>Converter of UOM</title>" +
            "  </head>" +
            "  <body>" +
            "<div class=\"dropdown\">\r\n  <button class=\"dropbtn\">Dropdown</button>\r\n  <div class=\"dropdown-content\">\r\n    <a href=\"{1}CO/\">Convert</a>\r\n    <a href=\"{1}LUD/\">List Unit Dimensions</a>\r\n    <a href=\"{1}UD/\">Unit Dimention Page</a>\r\n  </div>\r\n</div>" +
            "<div id=\"1\">" +
            "    <form method=\"post\" action=\"{1}Convert/\">" +
            "       <label for=\"value\">Value:</label><br>" +
            "       <input type=\"text\" id=\"value\" name=\"value\" value=\"0\"><br>" +
             "       <label for=\"inputuom\">InputUOM:</label><br>" +
            "       <input type=\"text\" id=\"inputuom\" name=\"inputuom\" value=\"meter\"><br>" +
            "       <label for=\"outputuom\">OutputUOM:</label><br>" +
            "       <input type=\"text\" id=\"outputuom\" name=\"outputuom\" value=\"mile\"><br>" +
            "      <input type=\"submit\" value=\"Convert\">" +
             "    </form>" +
            "</div>" +
             "<div id=\"3\">" +
             "   <form id=\"2\" method=\"get\" action=\"{1}List/Units\">" +
             "       <label>U:</label><br>" +
            "      <input type=\"submit\" name=\"LU\" value=\"List Quality Types\">" +
            "    </ form > " +
            "</div>" +
            "<div id=\"2\">" +
            "   <form id=\"1\" method=\"get\" action=\"{1}List/Dimensions\">" +
            "       <label>LUD:</label><br>" +
            "      <input type=\"submit\" name=\"LUD\" value=\"List Unit Dimentions\">" +
            "    </ form > " +
            "</div>" +
            "<div id=\"4\">" +
            "   <form id=\"3\" method=\"post\" action=\"{1}Dimension/\">" +
            "       <label>UD:</label><br>" +
            "       <input type=\"text\" id=\"UD\" name=\"UD\" value=\"UnitDimention\"><br>" +
            "      <input type=\"submit\" name=\"UD\" value=\"Unit Dimention\">" +
            "    </ form > " +
            "</div>" +
            "   <div class=\"parent\", style=\"text-align-last: center\" >" +
            "      <div class=\"Output\">Output: \n</div>" +
            "      <div class=\"child two\">{2}</div>" +
            "    </div>" +
            "  </body>" +
            "</html>";
    }
}
