using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Math;

namespace Mii {
	using Mii.MiiData.SuperMii;
	using System.IO;
	using SFB;
	using System.Runtime.Serialization.Formatters.Binary;

	public class MiiCharacter : MonoBehaviour {
		private static ExtensionFilter wiiFilter		= new ExtensionFilter("Gen1 binary (Wii)",					"mii", "mae", "miigx", "rcd");
		private static ExtensionFilter studioTxtFilter	= new ExtensionFilter("Gen2 text (Mii Studio)",				"txt");
		private static ExtensionFilter studioBinFilter	= new ExtensionFilter("Gen2 binary (Mii Studio)",			"mnms");
		private static ExtensionFilter genTwoFilter		= new ExtensionFilter("Gen2 binary (Wii U, 3DS, Miitomo)",	"cfsd");
		private static ExtensionFilter switchDBFilter   = new ExtensionFilter("Switch DB binary(Switch NAND dump)", "");
		private static ExtensionFilter switchGameFilter = new ExtensionFilter("Switch game binary",					"");
		private static ExtensionFilter bumiiFilter		= new ExtensionFilter("UMii binary (BotW)",					"bumii", "aamp");
		private static ExtensionFilter umiiYamlFilter	= new ExtensionFilter("UMii text (BotW)",					"yaml", "yml");
		private static ExtensionFilter superBinFilter   = new ExtensionFilter("Bring Mii to Life binary",			"bm2l");
		private static ExtensionFilter superJsonFilter  = new ExtensionFilter("Bring Mii to Life text",				"json");

		[SerializeField] public SuperMiiData data;

		public MiiCharacter() {
			this.data = new SuperMiiData();
		}

		public MiiCharacter(SuperMiiData data) {
			this.data = data;
		}


		public void SaveBinary(BinaryDataFormat format) {
			ExtensionFilter[] extensions;

			switch (format) {
				case BinaryDataFormat.Wii:
					extensions = new ExtensionFilter[] { wiiFilter };
					break;
				case BinaryDataFormat.BringMiiToLife:
					extensions = new ExtensionFilter[] { superBinFilter };
					break;
				default:
					throw new System.NotImplementedException("Binary format " + format + " is not implemented!");
			}

			string path = StandaloneFileBrowser.SaveFilePanel("Save Mii from the nothing I've become...",
				Application.dataPath, this.data.basics.nickname, extensions);

			// Binary
			FileStream stream = new FileStream(path, FileMode.Create);
			BinaryFormatter formatter = new BinaryFormatter();


			switch (format) {
				case BinaryDataFormat.BringMiiToLife:
					formatter.Serialize(stream, this.data);
					break;
				default:
					throw new System.NotImplementedException("Binary format " + format + " is not implemented!");
			}



			stream.Close();
		}

		public void SaveText(TextDataFormat format) {
		}

		public static void LoadBinary() {
			ExtensionFilter[] extensions = new ExtensionFilter[] {
				wiiFilter, genTwoFilter, studioBinFilter,
				switchDBFilter, switchGameFilter, bumiiFilter,
				superBinFilter
			};

			string path = StandaloneFileBrowser.SaveFilePanel("Load mii...",
				Application.dataPath, "mii", extensions);


			FileStream stream = new FileStream(path, FileMode.Create);
			BinaryFormatter formatter = new BinaryFormatter();
		}
	}

	public enum BinaryDataFormat {
		Wii,
		WiiU3DSMiitomo,
		MiiStudio,
		SwitchDB,
		SwitchGame,
		bUMii,
		BringMiiToLife
	}

	public enum TextDataFormat {
		MiiStudioCode, UMiiYAML,
		BringMiiToLifeJSON
	}

	public enum FavoriteColor : uint {
		Red = 0, Orange = 1, Yellow = 2, Lime = 3, DarkGreen = 4, Indigo = 5,
		LightBlue = 6, Pink = 7, Purple = 8, Brown = 9, White = 10, Black = 11,
		// Abnormal colors
		Gray = 1111, Grey = 1111
	}

	public class Favorite {
		public static readonly uint[] colors = {
			0xd21e14, 0xff6e19, 0xffd820, 0x78d220, 0x007830, 0x0a48b4,
			0x3caade, 0xf55a7d, 0x7328ad, 0x483818, 0xe0e0e0, 0x181814,

			0x7C7875B // Grey (Unlisted)
		};
	}
}

namespace Mii.MiiData.SuperMii {
	using Mii.MiiData.UMii;

	/// <summary>
	/// Data that will contain every required piece of information
	/// for every single generation of mii and then some, at runtime
	/// </summary>
	[System.Serializable]
	public struct SuperMiiData {
		[SerializeField] public Basics basics;
		[SerializeField] public Face face;
		[SerializeField] public Hairstyle hair;
		[SerializeField] public Eyebrows eyebrows;
		[SerializeField] public Eyes eyes;
		[SerializeField] public Nose nose;
		[SerializeField] public Mouth mouth;
		[SerializeField] public Glasses glasses;
		[SerializeField] public FacialHair facial_hair;
		[SerializeField] public Mole mole;
		[SerializeField] public Body body;

		// Contstuctors here will convert data
		public SuperMiiData(MiiDataWii data) {
			#region Basics
			this.basics = new Basics();
			this.basics.nickname = data.mii_name;
			this.basics.creator_name = data.creator_name;
			this.basics.is_female = data.female;
			this.basics.favorite_color = (uint) data.favorite_color;
			this.basics.favorite = data.favorite;
			#endregion
			#region Face
			this.face.color = Face.colors[data.skin_color];
			this.face.type = data.face_shape;
			if (data.facial_feature < 4) {
				this.face.makeup = (Makeup) data.facial_feature;
				this.face.wrinkles = 0;
			} else {
				this.face.wrinkles = (Wrinkles) data.facial_feature - 4;
				this.face.makeup = 0;
			}
			#endregion
			#region Hair
			this.hair.type = (byte) data.hair_type;
			this.hair.color = Hairstyle.colors[data.hair_color];
			this.hair.flipped = data.hair_flip;
			#endregion
			#region Eyebrows
			this.eyebrows.type = data.eyebrow_type;
			this.eyebrows.color = Eyebrows.colors[data.eyebrow_color];
			this.eyebrows.verticalPosition = Normalize(data.eyebrow_vertical, 3, 18);
			this.eyebrows.horizontalSpread = Normalize(data.eyebrow_horizontal, 12);
			this.eyebrows.rotation = Normalize(data.eyebrow_rotation, 11);
			this.eyebrows.size = Normalize(data.eyebrow_size, 8);
			this.eyebrows.stretch = 0;
			#endregion
			#region Eyes
			this.eyes.type = data.eye_type;
			this.eyes.size = Normalize(data.eye_size, 3);
			this.eyes.rotation = Normalize(data.eye_rotation, 7);
			this.eyes.verticalPosition = Normalize(data.eye_vertical, 18);
			this.eyes.color = Eyes.colors[data.eye_color];
			this.eyes.spread = Normalize(data.eye_horizontal, 12);
			#endregion
			#region Nose
			this.nose.type = data.nose_type;
			this.nose.size = Normalize(data.nose_size, 8);
			this.nose.verticalPosition = Normalize(data.nose_vertical, 18);
			#endregion
			#region Mouth
			this.mouth.type = data.mouth_type;
			this.mouth.color = SuperMiiData.ApproximateColor(Mouth.colors, data.mouth_color);
			this.mouth.size = Normalize(data.mouth_size, 8);
			this.mouth.stretch = 0;
			this.mouth.verticalPosition = Normalize(data.mouth_vertical, 18);
			#endregion
			#region Glasses
			this.glasses.type = data.glasses_type;
			this.glasses.color = Glasses.colors[data.glasses_color];
			this.glasses.size = Normalize(data.glasses_size, 7);
			this.glasses.verticalPosition = Normalize(data.glasses_vertical, 20);
			#endregion
			#region Facial Hair
			this.facial_hair.beard = data.facial_hair_beard;
			this.facial_hair.moustache = data.facial_hair_mustache;
			this.facial_hair.size = Normalize(data.facial_hair_size, 8);
			this.facial_hair.verticalPosition = Normalize(data.facial_hair_vertical, 30);
			this.facial_hair.color = FacialHair.colors[data.facial_hair_color];
			#endregion
			#region Mole
			this.mole.enabled = data.mole_enable;
			this.mole.size = Normalize(data.mole_size, 8);
			this.mole.horizontalPosition = Normalize(data.mole_horizontal, 16);
			this.mole.verticalPosition = Normalize(data.mole_vertical, 16);
			#endregion
			#region Body
			this.body.height = data.body_height;
			this.body.weight = data.body_weight;
			#endregion
		}

		#region Static Math Stuff
		public static float Normalize(uint value, uint max) {
			return Normalize(value, 0, max);
		}

		public static float Normalize(uint value, uint min, uint max) {
			return ((float) value) / (max - min);
		}

		public static uint Denormalize(float value, uint max) {
			return Denormalize(value, 0, max);
		}

		public static uint Denormalize(float value, uint min, uint max) {
			uint num = max - min;
			float f = value * num;
			uint i = (uint) (value * num);
			if ((float) i != f) {
				Debug.LogWarning("Denormalized value was rounded!\n"
				+ "Expected: " + f + "\n"
				+ "Rounded to: " + i);
			}

			return i;
		}

		public static uint ApproximateColor(uint[] colors, uint color) {
			List<uint> cols = new List<uint>(colors);

			uint closest = 0xFF_FF_FF;
			uint minDifference = 0xFF_FF_FF;
			foreach (uint element in cols) {
				var difference = Abs((long)element - color);
				if (minDifference > difference) {
					minDifference = (uint) difference;
					closest = (uint) cols.IndexOf(element);
				}
			}
			return closest;
		}
		#endregion
	}

	public struct Basics {
		public string nickname;
		public bool favorite;
		public bool is_female; // For the sake of compatability only...
		[Range(0, 0xFF_FF_FF)] public uint favorite_color;
		[Range(1, 12)] public byte birth_month;
		[Range(1, 31)] public byte birth_day;
		public string creator_name;
	}

	[System.Serializable]
	public struct Face {
		// As laid out in Mii Studio
		public static readonly uint[] colors = {
			0xFF_D3_AD, 0xFF_C5_8F, 0xFF_B6_6B, 0xAD_51_29, 0x63_2C_18, 0xFF_BE_A5,
			0xFF_AA_8C, 0xDE_79_42, 0x8C_3C_23, 0x8C_3C_23
		};

		[Range(0, 11)] public byte type;
		public Makeup makeup;
		public Wrinkles wrinkles;

		// Can be any hex color code, will be rounded to the nearest color in the above array if needed
		[Range(0, 0xFF_FF_FF)] public uint color;
	}

	public enum Makeup : byte {
		None = 0,
		LowerCheekBlush, LowerCheekBlushHeavy, Eyeshadow, UpperCheekBlush, UpperCheekBlushHeavy,
		LowerCheekHeavyEye, LowerCheckEyeHeavy, UpperCheekEye, Freckles, Stubble, FiveOclockShadow
	}

	public enum Wrinkles : byte {
		None = 0,
		InnerEye, CheekBones, OuterEye, Nose, DroopyCheeks,
		PeterGriffin, DoubleChin, DarkEyes, Mouth, Everywhere
	}

	[System.Serializable]
	public struct Hairstyle {
		public static readonly uint[] colors = new uint[] {
			0x000000, 0x402010, 0x5c180a, 0x7c3a14, 0x787880, 0x4e3e10, 0x885818, 0xd0a04a
		};

		[Range(0, 131)] public byte type;
		public bool flipped;

		// Can be any hex color code, will be rounded to the nearest color in the above array if needed
		[Range(0, 0xFF_FF_FF)] public uint color;
	}

	[System.Serializable]
	public struct Eyebrows {
		public static readonly uint[] colors = Hairstyle.colors;

		[Range(0, 23)] public uint type;
		// Can be any hex color code, will be rounded to the nearest color in the hairstyle color array if needed
		[Range(0, 0xFF_FF_FF)] public uint color;

		// Transform (Normalized)
		[Range(0, 1)] public float verticalPosition;
		[Range(0, 1)] public float horizontalSpread;
		[Range(0, 1)] public float rotation;
		[Range(0, 1)] public float size;
		[Range(0, 1)] public float stretch;
	}

	[System.Serializable]
	public struct Eyes {
		public static readonly uint[] colors = new uint[] {
			0x000000, 0x6c7070, 0x663c2c, 0x605e30, 0x4654a8, 0x387058
		};

		[Range(0, 23)] public uint type;
		[Range(0, 0xFF_FF_FF)] public uint color;

		// Transform (Normalized)
		[Range(0, 1)] public float size;
		[Range(0, 1)] public float rotation;
		[Range(0, 1)] public float spread; // x
		[Range(0, 1)] public float verticalPosition; // y
	}

	[System.Serializable]
	public struct Nose {
		[Range(0, 17)] public uint type;
		[Range(0, 01)] public float size;
		[Range(0, 01)] public float verticalPosition;
	}

	[System.Serializable]
	public struct Mouth {
		public static readonly uint[] colors = new uint[] {
			0xd85208, 0xf00c08, 0xf54848, 0xf09a74, 0x8c5040
		};
	
		[Range(0, 35)] public uint type;
		[Range(0, 0xFF_FF_FF)] public uint color;

		// Transform (Normalized)
		[Range(0, 1)] public float size;
		[Range(0, 1)] public float stretch;
		[Range(0, 1)] public float verticalPosition;
	}

	#region Extras
	[System.Serializable]
	public struct FacialHair {
		public static readonly uint[] colors = Hairstyle.colors;

		[Range(0, 5)] public uint beard;
		[Range(0, 5)] public uint moustache;
		[Range(0, 0xFF_FF_FF)] public uint color;

		// Transform (Normalized)
		[Range(0, 1)] public float size;
		[Range(0, 1)] public float verticalPosition;
	}

	[System.Serializable]
	public struct Glasses {
		public static readonly uint[] colors = new uint[] {
			0x000000, 0x603810, 0xa81008, 0x203068, 0xa86000, 0x787068
		};

		[Range(0, 19)] public uint type;
		[Range(0, 0xFF_FF_FF)] public uint color;

		// Transform (Normalized)
		[Range(0, 1)] public float size;
		[Range(0, 1)] public float verticalPosition;
	}

	[System.Serializable]
	public struct Mole {
		public bool enabled;

		// Transform (Normalized)
		[Range(0, 1)] public float size;
		[Range(0, 1)] public float horizontalPosition;
		[Range(0, 1)] public float verticalPosition;
	}
	#endregion

	public struct Body {
		// Transform (Normalized)
		[Range(0, 1)] public float height;
		[Range(0, 1)] public float weight;
	}

	/// <summary>
	/// 100 "custom" colors that a Mii from the Switch or Mii Studio can use for
	/// eyes, hair, eyebrows, mouth, glasses, or facial hair, but NOT favorite
	/// </summary>
	public static class Custom {
		// As laid out in Mii Studio
		public static readonly uint[,] colors = new uint[10,10] {
			{ 0x5c180a, 0x842626, 0x663c2c, 0x8c5040, 0xa81008, 0xf00c08, 0xf54848, 0xff7366, 0xffa6a6, 0xffc0ba }, // 0-9
			{ 0x732e3b, 0x991f3d, 0x991f3d, 0xb53e42, 0xc71e56, 0xb05381, 0xc7546e, 0xfa7597, 0xfcacc9, 0xffc9d8 },
			{ 0xffc9d8, 0x37283d, 0x4c184d, 0x6f42b3, 0x855cb8, 0xc083cc, 0xa893c9, 0xc5ace6, 0xeebefa, 0xd2c5ed },
			{ 0x191f40, 0x203068, 0x123f66, 0x4654a8, 0x2a82d4, 0x57b4f2, 0x7ac5de, 0x89a6fa, 0x84bdfa, 0xa1e3ff },
			{ 0x0b2e36, 0x013d3b, 0x0d4f59, 0x236663, 0x387058, 0x307e8c, 0x4faeb0, 0x7ac49e, 0x7fd4c0, 0x87e5b6 },
			{ 0x0a4a35, 0x437a00, 0x027562, 0x369970, 0x4bad1a, 0x92bf0a, 0x63c788, 0x9ee042, 0x96de7e, 0xbbf2aa },
			{ 0x4e3e10, 0x605e30, 0x99932b, 0xa69563, 0xccc039, 0xccb987, 0xd9cc82, 0xd5d96f, 0xd5e683, 0xd8fa9d },
			{ 0x603810, 0x7d4500, 0x885818, 0xa86000, 0xd0a04a, 0xe6bb7a, 0xfee24a, 0xfade82, 0xf7ea9c, 0xfaf89b },
			{ 0x402010, 0x7c3a14, 0xa64d1e, 0xd85208, 0xff960d, 0xd19b69, 0xf09a74, 0xffb266, 0xffc28c, 0xe5cfb1 },
			{ 0x000000, 0x2d2828, 0x414141, 0x6c7070, 0x787068, 0x787880, 0x9b9b9b, 0xbebebe, 0xdcd7cd, 0xffffff } // 90-99
		};
	}
}