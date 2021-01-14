using UnityEngine;

namespace Mii.MiiData.UMii {
	// TODO: These types are all guesses. Please double check!
	[System.Serializable]
	public struct UMiiData {
		public FFSD ffsd;
		public Body body;
		public Personal personal;
		public Common common;
		public Shape shape;
		public Hair hair;
		public Eye eye;
		public EyeControl eye_ctrl;
		public Eyebrow eyebrow;
		public Nose nose;
		public Mouth mouth;
		public Beard beard;
		public Glass glass;
		#region Race-Specific
		public Korok korog;
		public Gerudo gerudo;
		public Rito rito;
		public  Zora zora;
		#endregion
		public Object[] lists; // unknown usage
	}

	public sealed class FFSD {
		public  bool no_use_ffsd = false; // Do not use Mii data (treat as NPC profile)[
		public int type = 0; // Reference first
	}

	public sealed class Body {
		public int type = 0;
		public int number = 0;
		public Race race = 0;
		public int weight = 1;
		public int height = 0;
	}

	/// <summary>
	/// All body types available to UMii NPCs in Breath of the Wild
	/// https://zeldamods.org/wiki/Bumii#body
	/// </summary>
	public enum Type : int {
		C, N, T, S, SK,
		Unknown
	}

	/// <summary>
	/// Races available to UMii NPCs in Breath of the Wild
	/// https://zeldamods.org/wiki/Bumii#body
	/// </summary>
	public enum Race : int {
		// TODO: Not necessarily in this order!
		Hylian = 0,
		Korok = 1,
		Goron = 2,
		Shiekah = 3,
		Gerudo = 4,
		Zora = 5,
		Rito = 6,
		Unknown
	}

	public sealed class Personal {
		public int fav_color = 0;
		public int sub_color_1 = -1;
		public int sub_color_2 = -1;
		public string voice_type = "Hylia_Man_Kid_Normal00";
		public int shoulder_fav_color = -1;
		public SexAge sex_age = 0;
		public string personality;
		public int head_fav_color = -1;
		public int shoulder_sub_color_1 = -1;
	}

	/// <summary>
	/// This enum decides both the sex and age of an NPC in Breat of the Wild.
	/// https://zeldamods.org/wiki/Bumii#personal
	/// </summary>
	public enum SexAge : int {
		C = 0, // Child
		M = 1, // Man
		X = 2, // Old man
		Unlabeled = 3, // Not documented
		W = 4, // Woman
		Unknown
	}

	public sealed class Common {
		public int backpack = -1;
		public int hat = -1;
		public bool no_hat_always = false;
		public int body_correct = 0;
		public bool is_mid_age = false;
		public float rot_cravicle = 0;
		public float rot_arm = 0;
		public float rot_leg = 0;
		public float rot_crotch = 0;
	}

	public sealed class Shape {
		public int jaw = 0;
		public int wrinkle = 0;
		public Makeup make = 0;
		public int skin_color = 0;
		public float trans_v = 0;
		public float scale = 1;
	}

	/// <summary>
	/// All "make" options available to Breath of the Wild NPCs
	/// </summary>
	public enum Makeup : int {
		None = 0,
		Eyes1 = 1, Eyes2 = 2, Eyes3 = 3, Eyes4 = 4, Eyes5 = 5, Eyes6 = 6, Eyes7 = 7, Eyes8 = 8,
		Unlabeled = 9,
		Beard1 = 10, Beard2 = 11
	}

	public sealed class Hair {
		public int type = 0;
		[Range(0, 10)] public int color = 0;
		public bool flip = false;
	}

	public sealed class Eye {
		public int type = 2;
		public int color = 0;
		public float trans_v = 3;
		public float trans_u = 2;
		public float rotate = 0;
		public float scale = 4;
		public float aspect = 3;
		public float eyeball_trans_u = 0;
		public float eyeball_trans_v = 0;
		public float eyeball_scale = 0;
		public  int highlight_bright = 0;
	}

	public sealed class EyeControl {
		public float[] base_offset = new float[3] { 0, 0.029999999329447746f, 0 }; // vec3
		public float translim_out = 0.2f;
		public float translim_in = 0.12f;
		public float translim_d = 0.3f;
		public float translim_u = 0.1f;
		public float neck_offset_ud = 0;
	}

	public sealed class Eyebrow {
		public int type = 6;
		public int color = 0;
		public float trans_v = 7;
		public float trans_u = 2;
		public float rotate = 0;
		public float scale = 4;
		public float aspect = 3;
	}

	public sealed class Nose {
		public int type = 1;
		public float trans_v = 9;
		public float scale = 4;
	}

	public sealed class Mouth {
		public int type = 3;
		public int color = 0;
		public float trans_v = 13;
		public float scale = 4;
		public float aspect = 3;
	}

	public class Beard {
		public int mustache = 0;
		public float scale = 4;
		public int type = 0;
		public int color = 0;
	}

	public sealed class Glass {
		public int type = 0;
		[Range(0, 5)] public int color = 0;
	}

	#region Race-Specific
	public sealed class Korok { // Korok
		public int mask = 0;
		public int skin_color = 0;
		public int left_plant = 0;
		public int right_plant = 0;
	}

	public sealed class Goron {
		public int skin_color = 0;
	}

	public sealed class Gerudo {
		public int hair = 0;
		public int hair_color = 0;
		public int glass = 0;
		public int glass_color = 0;
		public int skin_color = 0;
		public int lip_color = 0;
	}

	public sealed class Rito {
		public RitoBodyColor body_color = 0;
		public int hair_color = -1;
	}

	public enum RitoBodyColor : int {
		Unlabeled1 = 0, Unlabeled2 = 1, Unlabeled3 = 2, Unlabeled4 = 3, Unlabeled5 = 4, Unlabeled6 = 5, Unlabeled7 = 6, Unlabeled8 = 7,
		Blue = 8,
		Green = 9,
		Unknown
	}

	public sealed class Zora {
		public int body_color = 0;
	}
	#endregion
}

