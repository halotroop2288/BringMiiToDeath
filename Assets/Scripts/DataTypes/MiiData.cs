using UnityEngine;
using Mii.MiiData.UMii;

namespace Mii.MiiData {
	using SuperMii;
	// ext: .mii .mae .miigx
	// big endian
	[System.Serializable]
	public struct MiiDataWii { // Wii	
		public bool invalid;
		#region Basics
		public bool female;
		public byte birth_month;
		public byte birth_day;
		public FavoriteColor favorite_color;
		public bool favorite;
		public string mii_name; // size: 20 bytes (10 chars)
		#endregion
		#region Height / Weight
		public sbyte body_height;
		public sbyte body_weight;
		#endregion
		#region ID
		public uint mii_id; // length: 4
		public uint client_id; // length: 4
		#endregion
		#region Face
		public byte face_shape;
		public byte skin_color;
		public byte facial_feature; // = makeup?
		#endregion
		#region Metadata
		public byte unknown_1;
		public bool dontMingle;
		public bool unknown_2;
		public bool downloaded;
		#endregion
		#region Hair
		[Range(0, 71)] public sbyte hair_type;
		[Range(0, 07)] public sbyte hair_color;
		public bool hair_flip;
		public byte unknown_3;
		#endregion
		#region Eyebrow
		[Range(0, 23)] public uint eyebrow_type;
		public uint unknown_4;
		[Range(0, 11)] public uint eyebrow_rotation;
		public uint unknown_5;
		[Range(0, 07)] public uint eyebrow_color;
		[Range(0, 08)] public uint eyebrow_size;
		[Range(3, 18)] public uint eyebrow_vertical; // x
		[Range(0, 12)] public uint eyebrow_horizontal; // y
		#endregion
		#region Eye
		public uint eye_type;
		public uint unknown_6;
		public uint eye_rotation;
		public uint eye_vertical; // y
		public uint eye_color;
		public uint unknown_7;
		public uint eye_size;
		public uint eye_horizontal; // x
		public uint unknown_8;
		#endregion
		#region Nose
		public byte nose_type;
		public byte nose_size;
		public byte nose_vertical; // y
		public byte unknown_9;
		#endregion
		#region Mouth
		public byte mouth_type;
		public byte mouth_color;
		public byte mouth_size;
		public byte mouth_vertical; // y
		#endregion
		#region Glasses
		public byte glasses_type;
		public byte glasses_color;
		public byte unknown_10;
		public byte glasses_size;
		public byte glasses_vertical; // y
		#endregion
		#region Facial Hair
		public byte facial_hair_mustache;
		public byte facial_hair_beard;
		public byte facial_hair_color;
		public byte facial_hair_size;
		public byte facial_hair_vertical; // y
		#endregion
		#region Mole
		public bool mole_enable;
		public byte mole_size;
		public byte mole_vertical; // y
		public byte mole_horizontal; // x
		#endregion

		public bool unknown_11;
		public string creator_name;

		public MiiDataWii(MiiCharacter mii) {
			#region Unknown Data
			this.unknown_1 = 0;
			this.unknown_2 = false;
			this.unknown_3 = 0;
			this.unknown_4 = 0;
			this.unknown_5 = 0;
			this.unknown_6 = 0;
			this.unknown_7 = 0;
			this.unknown_8 = 0;
			this.unknown_9 = 0;
			this.unknown_10 = 0;
			this.unknown_11 = false;
			#endregion
			SuperMii.SuperMiiData data = mii.data;
			#region Basics
			SuperMii.Basics basics = data.basics;
			this.invalid = false;
			this.mii_name = basics.nickname;
			this.female = basics.is_female;
			this.birth_month = basics.birth_month;
			this.birth_day = basics.birth_day;
			this.favorite_color = (FavoriteColor) SuperMiiData.ApproximateColor(Favorite.colors, basics.favorite_color);
			this.favorite = basics.favorite;
			this.creator_name = basics.creator_name;
			#endregion
			#region Body
			SuperMii.Body body = data.body;
			this.body_height = (sbyte) SuperMiiData.Denormalize(body.height, 127);
			this.body_weight = (sbyte) SuperMiiData.Denormalize(body.weight, 127);
			#endregion
			#region Identifiers
			// FIXME: This will cause issues on real hardware!
			this.mii_id = 0;
			this.client_id = 0;
			#endregion
			#region Metadata
			this.dontMingle = true;
			this.downloaded = true;
			#endregion
			#region Face
			SuperMii.Face face = data.face;
			this.face_shape = face.type;
			this.skin_color = face.type;
			// Facial feature
			if (face.wrinkles == 0) {
				this.facial_feature = (byte) face.makeup;
			} else if (face.makeup == 0) {
				this.facial_feature = (byte) (face.wrinkles + 4);
			} else {
				// TODO add a way for the user to select either wrinkles or makeup
				this.facial_feature = 0;
			}
			#endregion
			#region Hair
			SuperMii.Hairstyle hair = data.hair;
			this.hair_type = (sbyte) hair.type;
			this.hair_color = (sbyte) SuperMiiData.ApproximateColor(Hairstyle.colors, hair.color);
			this.hair_flip = hair.flipped;
			#endregion
			#region Eyebrows
			SuperMii.Eyebrows eyebrows = data.eyebrows;
			this.eyebrow_type = (uint) eyebrows.type;
			this.eyebrow_rotation = SuperMiiData.Denormalize(eyebrows.rotation, 11);
			this.eyebrow_color = SuperMiiData.ApproximateColor(Eyebrows.colors, eyebrows.color);
			this.eyebrow_size = SuperMiiData.Denormalize(eyebrows.size, 8);
			this.eyebrow_vertical = SuperMiiData.Denormalize(eyebrows.verticalPosition, 3, 18);
			this.eyebrow_horizontal = SuperMiiData.Denormalize(eyebrows.horizontalSpread, 0, 12);
			#endregion
			#region Eyes
			SuperMii.Eyes eyes = data.eyes;
			this.eye_type = (byte) eyes.type;
			this.eye_rotation = SuperMiiData.Denormalize(eyes.rotation, 7);
			this.eye_vertical = SuperMiiData.Denormalize(eyes.verticalPosition, 18);
			this.eye_color = SuperMiiData.ApproximateColor(Eyes.colors, eyes.color);
			this.eye_size = SuperMiiData.Denormalize(eyes.size, 7);
			this.eye_horizontal = SuperMiiData.Denormalize(eyes.spread, 12);
			#endregion
			#region Nose
			SuperMii.Nose nose = data.nose;
			this.nose_type = (byte) nose.type;
			this.nose_size = (byte) SuperMiiData.Denormalize(nose.size, 8);
			this.nose_vertical = (byte) SuperMiiData.Denormalize(nose.verticalPosition, 18);
			#endregion
			#region Mouth
			SuperMii.Mouth mouth = data.mouth;
			this.mouth_type = (byte) mouth.type;
			this.mouth_color = (byte) SuperMiiData.ApproximateColor(Mouth.colors, mouth.color);
			this.mouth_size = (byte) SuperMiiData.Denormalize(mouth.size, 8);
			this.mouth_vertical = (byte) SuperMiiData.Denormalize(mouth.verticalPosition, 18);
			#endregion
			#region Glasses
			SuperMii.Glasses glasses = data.glasses;
			this.glasses_type = (byte) glasses.type;
			this.glasses_color = (byte) SuperMiiData.ApproximateColor(Glasses.colors, glasses.color);
			this.glasses_size = (byte) SuperMiiData.Denormalize(glasses.size, 7);
			this.glasses_vertical = (byte) SuperMiiData.Denormalize(glasses.verticalPosition, 20);
			#endregion
			#region Facial hair
			SuperMii.FacialHair facial_hair = data.facial_hair;
			this.facial_hair_mustache = (byte) facial_hair.moustache;
			this.facial_hair_beard = (byte) facial_hair.beard;
			this.facial_hair_color = (byte) SuperMiiData.ApproximateColor(FacialHair.colors, facial_hair.color);
			this.facial_hair_size = (byte) SuperMiiData.Denormalize(facial_hair.size, 8);
			this.facial_hair_vertical = (byte) SuperMiiData.Denormalize(facial_hair.verticalPosition, 16);
			#endregion
			#region Mole
			SuperMii.Mole mole = data.mole;
			this.mole_enable = mole.enabled;
			this.mole_size = (byte) SuperMiiData.Denormalize(mole.size, 8);
			this.mole_vertical = (byte) SuperMiiData.Denormalize(mole.verticalPosition, 30);
			this.mole_horizontal = (byte) SuperMiiData.Denormalize(mole.horizontalPosition, 16);
			#endregion
		}
	}

	// little endian
	[System.Serializable]
	public struct MiiDataGen2 { // Wii U, 3DS, Miitomo
		uint unknown_1;

		#region Region
		byte character_set; // 0=JPN+USA+EUR, 1=CHN, 2=KOR, 3=TWN
		byte region_lock; // 0=no lock, 1=JPN, 2=USA, 3=EUR
		#endregion

		#region Online flags
		bool profanity_flag;
		bool copying;
		byte unknown_2;
		#endregion

		#region Metadata
		byte mii_position_slot_index;
		byte mii_position_page_index;

		byte version;
		byte unknown_3;
		uint system_id; // length: 8
		uint avatar_id; // length: 4
		uint client_id; // length: 4

		uint padding;

		uint data_1;
		#endregion

		string mii_name; // size: 20 bytes (10 chars)

		uint body_height;
		uint body_weight;

		byte face_color;
		byte face_type;

		bool mingle;

		byte face_makeup;
		byte face_wrinkles;

		#region Hair
		byte hair_type;
		byte unknown_5;
		bool hair_flip;
		byte hair_color;
		#endregion

		#region Face
		// These need to be bit-shifted to get the proper values!
		uint eye;
		uint eyebrow;
		uint nose;
		uint mouth;
		uint mouth2;
		uint beard;
		uint glasses;
		uint mole;
		#endregion

		string creator_name; // size: 20 bytes (10 chars)

		uint padding2;
		uint checksum;
	}

	// ext: .txt
	// little endian
	[System.Serializable]
	public struct MiiDataStudio { // Mii Studio
		#region Beard
		[Range(0, 099)] uint facial_hair_color;
		[Range(0, 006)] uint beard_goatee;
		#endregion

		[Range(0, 127)] uint body_weight;

		#region Eye
		[Range(0, 006)] uint eye_stretch;
		[Range(0, 099)] uint eye_color;
		[Range(0, 007)] uint eye_rotation;
		[Range(0, 059)] uint eye_type;
		[Range(0, 012)] uint eye_horizontal; // x
		[Range(0, 018)] uint eye_vertical;   // y
		#endregion
		#region Eyebrow
		[Range(0, 006)] uint eyebrow_stretch;
		[Range(0, 011)] uint eyebrow_rotation;
		[Range(0, 008)] uint eyebrow_size;
		[Range(0, 023)] uint eyebrow_type;
		[Range(0, 012)] uint eyebrow_horizontal; // x
		[Range(3, 012)] uint eyebrow_vertical;   // y
		#endregion
		#region Face
		[Range(0, 009)] uint face_color;
		[Range(0, 011)] uint face_makeup;
		[Range(0, 011)] uint face_type;
		[Range(0, 011)] uint face_wrinkles;
		#endregion

		[Range(0, 011)] uint favorite_color;
		[Range(0, 001)] uint gender; // 0 = male, 1 = female // still a bad solution

		#region Glasses
		[Range(0, 099)] uint glasses_color;
		[Range(0, 007)] uint glasses_size;
		[Range(0, 019)] uint glasses_type;
		[Range(0, 020)] uint glasses_vertical; // y
		#endregion
		#region Hair
		[Range(0, 009)] uint hair_color;
		[Range(0, 001)] uint hair_flip; // 0 = no, 1 = yes
		[Range(0, 131)] uint hair_type;
		#endregion

		[Range(0, 127)] uint body_height;

		#region Mole
		[Range(0, 008)] uint mole_size;
		[Range(0, 001)] uint mole_enable; // 0 = false, 1 = true
		[Range(0, 016)] uint mole_horizontal; // x
		#endregion
		#region Mouth
		[Range(0, 006)] uint mouth_stretch;
		[Range(0, 099)] uint mouth_color;
		[Range(0, 008)] uint mouth_size;
		[Range(0, 035)] uint mouth_type;
		[Range(0, 018)] uint mouth_vertical;
		#endregion
		#region Moustache
		[Range(0, 008)] uint mustache_size;
		[Range(0, 005)] uint mustache_type;
		[Range(0, 016)] uint mustache_vertical; // y
		#endregion
		#region Nose
		[Range(0, 008)] uint nose_size;
		[Range(0, 017)] uint nose_type;
		[Range(0, 018)] uint nose_vertical; // y
		#endregion
	}

	// little endian
	[System.Serializable]
	public struct MiiDataSwitchDB { // Switch system
		// These are ordered completely randomly. That pisses me off!
		uint hair_type;
		bool mole_enable;
		byte body_height;
		bool hair_flip;
		byte body_weight;
		uint hair_color;
		bool gender; // Ugh.
		byte eye_color;
		uint eyebrow_color;
		uint mouth_color;
		uint facial_hair_color;
		uint glasses_color;
		uint eye_type;
		uint mouth_type;
		byte glasses_size;
		byte eye_vertical; // y
		byte mustache_type;
		byte eyebrow_type;
		byte facial_hair_beard;
		byte nose_type;
		byte mouth_stretch;
		byte nose_vertical; // y
		byte eyebrow_stretch;
		byte mouth_vertical; // y
		byte eye_rotation;
		byte mustache_vertical; // y
		byte eye_stretch;
		byte glasses_vertical; // y
		byte eye_size;
		byte mole_horizontal; // x
		uint mole_vertical;   // y
		uint glasses_type;
		byte face_type;
		byte favorite_color;
		byte face_wrinkles;
		byte face_color;
		byte eye_horizontal; // x
		byte face_makeup;
		byte eyebrow_rotation;
		byte eyebrow_size;
		byte eyebrow_vertical;   // y
		byte eyebrow_horizontal; // x
		byte mouth_size;
		byte nose_size;
		byte mole_size;
		byte facial_hair_size;
		byte mustache_size;
		string mii_name; // length: 20 bytes (10 chars)
		uint unknown;
		uint mii_id;
	}

	// little endian
	[System.Serializable]
	public struct MiiDataSwitch { // Switch games
		#region Basics
		uint unknown_data;
		string mii_name; // length: 20 bytes (10 chars)
		uint unknown_buffer;
		uint favorite_color;
		bool gender; // Ugh.
		#endregion
		#region Height and Weight
		uint body_height;
		uint body_weight;
		uint unknown_buffer2;
		#endregion
		#region Face
		uint face_type;
		uint face_color;
		uint face_wrinkles;
		uint face_makeup;
		#endregion
		#region Hair
		uint hair_type;
		uint hair_color;
		uint hair_flip;
		#endregion
		#region Eye
		uint eye_type;
		uint eye_color;
		uint eye_size;
		uint eye_stretch;
		uint eye_rotation;
		uint eye_horizontal; // x
		uint eye_vertical;   // y
		#endregion
		#region Eyebrow
		uint eyebrow_type;
		uint eyebrow_color;
		uint eyebrow_size;
		uint eyebrow_stretch;
		uint eyebrow_rotation;
		uint eyebrow_horizontal; // x
		uint eyebrow_vertical;   // y
		#endregion
		#region Nose
		uint nose_type;
		uint nose_size;
		uint nose_vertical; // y
		#endregion
		#region Mouth
		uint mouth_type;
		uint mouth_color;
		uint mouth_size;
		uint mouth_stretch;
		uint mouth_vertical; // y
		#endregion
		#region Facial Hair
		uint facial_hair_color;
		uint facial_hair_beard;
		uint facial_hair_mustache;
		uint facial_hair_size;
		uint facial_hair_vertical; // y
		#endregion
		#region Glasses
		uint glasses_type;
		uint glasses_color;
		uint glasses_size;
		uint glasses_vertical; // y
		#endregion
		#region Mole
		uint mole_enable;
		uint mole_horizontal; // x
		uint mole_vertical;   // y
		uint mole_size;
		#endregion
	}
}