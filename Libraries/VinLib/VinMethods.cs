using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinLib
{
	public class VinMethods
	{
		private Dictionary<string, int> _years;

		private Dictionary<string, string> _countries;

		private string _countryData;

		public VinMethods()
		{
			_years = new Dictionary<string, int>();
			_years.Add("A", 1980);
			_years.Add("B", 1981);
			_years.Add("C", 1982);
			_years.Add("D", 1983);
			_years.Add("E", 1984);
			_years.Add("F", 1985);
			_years.Add("G", 1986);
			_years.Add("H", 1987);
			_years.Add("J", 1988);
			_years.Add("K", 1989);
			_years.Add("L", 1990);
			_years.Add("M", 1991);
			_years.Add("N", 1992);
			_years.Add("P", 1992);
			_years.Add("R", 1994);
			_years.Add("S", 1995);
			_years.Add("T", 1996);
			_years.Add("V", 1997);
			_years.Add("W", 1998);
			_years.Add("X", 1999);
			_years.Add("Y", 2000);
			_years.Add("1", 2001);
			_years.Add("2", 2002);
			_years.Add("3", 2003);
			_years.Add("4", 2004);
			_years.Add("5", 2005);
			_years.Add("6", 2006);
			_years.Add("7", 2007);
			_years.Add("8", 2008);
			_years.Add("9", 2009);
			_countryData = "AA-AH South Africa;AJ-AN Cote d'Ivoire;AP-A0 unassigned;BA-BE Angola;BL-BR Tanzania;BS-B0 unassigned;CA-CE Benin;CF-CK Madagascar;CL-CR Tunisia;CS-C0 unassigned;DA-DE Egypt;DF-DK Morocco;DL-DR Zambia;DS-D0 unassigned;EA-EE Ethiopia;EF-EK Mozambique;EL-E0 unassigned;FA-FE Ghana;FF-FK Nigeria;FL-F0 unassigned;GA-G0 unassigned;HA-H0 unassigned;JA-JT Japan;KA-KE Sri Lanka;KF-KK Israel;KL-KR Korea (South);KS-K0 Kazakhstan;LA-L0 China (Mainland);MA-ME India;MF-MK Indonesia;ML-MR Thailand;MS-M0 Myanmar;NA-NE Iran;NF-NK Pakistan;NL-NR Turkey;NS-N0 unassigned;PA-PE Philippines;PF-PK Singapore;PL-PR Malaysia;PS-P0 unassigned;RA-RE United Arab Emirates;RF-RK Taiwan;RL-RR Vietnam;RS-R0 Saudi Arabia;SA-SM United Kingdom;SN-ST Germany (formerly;East Germany);SU-SZ Poland;S1-S4 Latvia;S5-S0 unassigned;TA-TH Switzerland;TJ-TP Czech Republic;TR-TV Hungary;TW-T1 Portugal;T2-T0 unassigned;UA-UG unassigned;UH-UM Denmark;UN-UT Ireland;UU-UZ Romania;U1-U4 unassigned;U5-U7 Slovakia;U8-U0 unassigned;VA-VE Austria;VF-VR France;VS-VW Spain;VX-V2 Serbia;V3-V5 Croatia;V6-V0 Estonia;WA-W0 Germany (formerly West Germany);XA-XE Bulgaria;XF-XK Greece;XL-XR Netherlands;XS-XW Russia (former USSR);XX-X2 Luxembourg;X3-X0 Russia;YA-YE Belgium;YF-YK Finland;YL-YR Malta;YS-YW Sweden;YX-Y2 Norway;Y3-Y5 Belarus;Y6-Y0 Ukraine;ZA-ZR Italy;ZS-ZW unassigned;ZX-Z2 Slovenia;Z3-Z5 Lithuania;Z6-Z0 unassigned;1A-10 United States;4 United States;5 United States;2 Canada;3A-3W Mexico;3X-37 Costa Rica;38-39 Cayman Islands;30 unassigned;6 Australia;7 New Zealand;8A-8E Argentina;8F-8K Chile;8L-8R Ecuador;8S-8W Peru;8X-82 Venezuela;83-80 unassigned;9A-9E Brazil;9F-9K Colombia;9L-9R Paraguay;9S-9W Uruguay;9X-92 Trinidad & Tobago;93–99 Brazil;90 unassigned;";
		}

		public bool CheckVIN(string vin)
		{
			string text = "1234567890ABCDEFGHJKLMNOPRSTUVWXYZ";
			string text2 = text;
			for (int i = 0; i < text2.Length; i++)
			{
				if (!text.Contains(text2[i].ToString()))
				{
					return false;
				}
			}

			if (vin.Length != 17)
			{
				return false;
			}

			string text3 = vin.Substring(13, 4);
			foreach (char c in text3)
			{
				if (!char.IsDigit(c))
				{
					return false;
				}
			}

			return true;
		}

		public string GetVINCountry(string vin)
		{
			string text = vin.Substring(0, 2);
			string[] array = _countryData.Split(';');
			List<string> list = new List<string>();
			for (int i = 0; i < 106; i++)
			{
				if (text[0] == array[i][0])
				{
					list.Add(array[i]);
				}
			}

			for (int j = 0; j < list.Count; j++)
			{
				char c = list[j][1];
				char c2 = list[j][4];
				string text2 = "123457890";
				if (text[1] == c && text[1] <= c2)
				{
					List<string> list2 = list[j].Split(' ').ToList();
					string text3 = "";
					for (int k = 1; k < list2.Count(); k++)
					{
						text3 = text3 + list2[k] + " ";
					}

					text3 = text3.Trim(' ');
					return text3.Trim(' ');
				}
			}

			return "unassigned";
		}

		public int GetTransportYear(string vin)
		{
			string key = vin[9].ToString();
			return _years[key];
		}
	}
}
