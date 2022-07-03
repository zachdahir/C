//Name: Zachary Dahir
//Date: 11-10-21
//Assignment Info: Assignment 11

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    class assignment11
    {
        static void Main(string[] args)
        {
            //Here is the "encrypted" data stored in array
            //of strings called 'line'.  Each line contains
			//60 characters - that's an important detail!
            String[] line = { "sA~~.S`r_`)-##fuh9pB/X/{8g]WG7Yd%cu]#o<]P gog>fXh+@#=`@r2#e3",
                                "u) G&C(>+*sl{4j.o>4y4sn<vWFDCZI~5)eLn@hC5GL]6R%mt2Ksmkap9tPN",
                                "|czPbsWrM=sNTpckW0%uQ=N0/U1H*t2yo:EQK{}Bt2ZVr{?{'29)o |^4iA)",
                                " .gX+D^9J1?[1aHraw=264@vi)*b=f=`Ys_jI#Kw<%Qtq]veb]|;L.rNmp|!",
                                ":z{es]t<#]t_Lmt1aJ%|1{ ^i!4t!0 X$I4A(m!3[Y*%h<m]8akBk onz=yq",
                                "IU;p_;[#YS(sIp@rpyuL2U2?DZl#YvEjs.i&>9E `j$cXvwp_fKoFL_sB{L$",
                                "pWIbl= ;':8WSIkGQMeLaqB@JDCoNebAk@}(AAU;v]rE rL|`7At5eB[4)7h",
                                "xXl1Vuj3Kb%0vJT%} ?twFe6Sm,l}Ar8)lA>oam*'9Q|11|jI=]7h`oQr ]o",
                                "i 4enl&*(d4<.aN^tg$Ao@B`c[NG{nK9$%@)$G.D*ra3(@,S11]*Q;wHZSD2",
                                "n^-9iz7)rEZLY_6d^/WCoy6j2Agh,wMO#z&KdGH-(}_kU/Oa$ziK{ ^BGA'H",
                                "2N|zv*J]Xj76eylT9J4#puc0.#S!<b$B@ yX!dnKdq89cRdQd))i-$W<jkl ",
                                "VHAceeteOaRTnh=~]ILZ<!;2Y'5;H]m5w s;OARn]i!#VSGCfW^@>1dT,/;^",
                                "]Y=nr=]Ts!N;u]|l 8Z%^pSo}LueI?/t&s0#a./8vaOe)BI`49TsS5~l%LlE",
                                "Fv+Tq.5#Ly p(A.lAmfZ#4Poi:kosC|4:hq~fysy-G4:]cr1'2Kye8B2EzjV",
                                "Bm-){FU>O/%FylMZ 6QcNhh`weN# ^Yk/<Vg9+>6.a`v-$=xjg2.Hd(g]K15",
                                "vSxpT96]5dAtw:v#wenrHU6]LJCJ4n+lx(?YSoArm_c F=6-l%nkislA<:D*",
                                "ujGEYSzox=N(N_%gq07e4 ].~?t[:|=8K7|o8=KqBE1OVf<7t%O,#5u_-9F:",
                                "^uT}~5]6b#NSdtcme.W8#]C5M056A=s}u03#p3Oe*&T4UzG]H'[~a.8!y?On",
                                " EtD-P]S1h|o]6.{(/^QhWl9`t<gw1(Pb_@c0 %%=rK^*k@K <w- |%GXZc8",
                                "3t[ _K,}tIsx)Y4t,-.tTpf[9=odZx+AbkqG7J~^^BUVP}alh/;JLecA- eB",
                                "ZFB{=5S<fk]`.O52:0*:Zi{Jn`(](O:7d[$8~o8;PD?{QY;|WQ'&uJfpIw=]",
                                ",p47QF{RJ|3_vmi6I w#D+$VH=A9s3m&s[/^0sa+]hQZ>F%'`PFI~:m l]n4" };

            //Here is the array of strings where you will store 
            //the five characters you get from each line
            String[] decrypted = new String[22];

            //Declare your additional variables here,
            //and don't forget to seed your Random with 243!
           Random rand = new Random(243);

            //Use your nested for loops and Random .Next to pull 5 
            //characters from each line
            for (int x = 0; x < line.Length; x++)
            {
                //Create a temporary string that from the current
                //line of the data - you don't have to do this,
				//but it makes it easier from a conceptual standpoint
                String currentLine = line[x];
				
				//Use your second for loop here to get the appropriate
				//characters from the currentLine and store them in
				//your decrypted array.  This is where you will need
				//to use your random .Next method - make sure you set 
				//the range of .Next correctly or you won't get the
				//right answer!
                for (int i = 0; i < 5; i++)
				{
					int j = rand.Next(0,60);
                    decrypted[x] += currentLine[j].ToString();
                    
				}
                
            }

            //Call printIt here
            printIt(decrypted);

			
			Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        } //end Main

        static void printIt(string[] arr)
        {
            //Declare you StringBuilder here 
            StringBuilder message = new StringBuilder();

            //Print the contents of the array you pass to this method
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //Build your message using a StringBuilder method and the 
            //array of strings you passed to this method
            for (int i = 0; i < arr.Length; i++)
            {
                message.Append(arr[i]);
            }
			//Print the contents of your StringBuilder - this will be the 
			//human readable message!
            Console.WriteLine("-----Message-----");
            Console.WriteLine(message);

        }
    }
}