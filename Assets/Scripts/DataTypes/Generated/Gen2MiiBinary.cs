// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using System.Collections.Generic;

namespace Kaitai
{
    public partial class Gen2MiiBinary : KaitaiStruct
    {
        public static Gen2MiiBinary FromFile(string fileName)
        {
            return new Gen2MiiBinary(new KaitaiStream(fileName));
        }

        public Gen2MiiBinary(KaitaiStream p__io, KaitaiStruct p__parent = null, Gen2MiiBinary p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_glassesColor = false;
            f_eyebrowHorizontal = false;
            f_eyeVertical = false;
            f_facialHairBeard = false;
            f_mouthSize = false;
            f_eyebrowStretch = false;
            f_noseVertical = false;
            f_eyeColor = false;
            f_birthMonth = false;
            f_mouthColor = false;
            f_moleHorizontal = false;
            f_facialHairMustache = false;
            f_eyebrowRotation = false;
            f_moleVertical = false;
            f_glassesType = false;
            f_eyebrowSize = false;
            f_moleSize = false;
            f_noseSize = false;
            f_facialHairVertical = false;
            f_eyeStretch = false;
            f_eyeSize = false;
            f_eyeType = false;
            f_eyeHorizontal = false;
            f_eyebrowType = false;
            f_mouthVertical = false;
            f_eyebrowColor = false;
            f_noseType = false;
            f_facialHairColor = false;
            f_eyebrowVertical = false;
            f_glassesSize = false;
            f_eyeRotation = false;
            f_gender = false;
            f_birthDay = false;
            f_mouthStretch = false;
            f_moleEnable = false;
            f_favorite = false;
            f_glassesVertical = false;
            f_favoriteColor = false;
            f_mouthType = false;
            f_facialHairSize = false;
            _read();
        }
        private void _read()
        {
            _unknown1 = m_io.ReadU1();
            _characterSet = m_io.ReadBitsIntBe(2);
            _regionLock = m_io.ReadBitsIntBe(2);
            _profanityFlag = m_io.ReadBitsIntBe(1) != 0;
            _copying = m_io.ReadBitsIntBe(1) != 0;
            _unknown2 = m_io.ReadBitsIntBe(2);
            _miiPositionSlotIndex = m_io.ReadBitsIntBe(4);
            _miiPositionPageIndex = m_io.ReadBitsIntBe(4);
            _version = m_io.ReadBitsIntBe(4);
            _unknown3 = m_io.ReadBitsIntBe(4);
            m_io.AlignToByte();
            _systemId = new List<byte>((int) (8));
            for (var i = 0; i < 8; i++)
            {
                _systemId.Add(m_io.ReadU1());
            }
            _avatarId = new List<byte>((int) (4));
            for (var i = 0; i < 4; i++)
            {
                _avatarId.Add(m_io.ReadU1());
            }
            _clientId = new List<byte>((int) (6));
            for (var i = 0; i < 6; i++)
            {
                _clientId.Add(m_io.ReadU1());
            }
            _padding = m_io.ReadU2le();
            _data1 = m_io.ReadU2le();
            _miiName = System.Text.Encoding.GetEncoding("utf-16le").GetString(m_io.ReadBytes(20));
            _bodyHeight = m_io.ReadU1();
            _bodyWeight = m_io.ReadU1();
            _faceColor = m_io.ReadBitsIntBe(3);
            _faceType = m_io.ReadBitsIntBe(4);
            _mingle = m_io.ReadBitsIntBe(1) != 0;
            _faceMakeup = m_io.ReadBitsIntBe(4);
            _faceWrinkles = m_io.ReadBitsIntBe(4);
            m_io.AlignToByte();
            _hairType = m_io.ReadU1();
            _unknown5 = m_io.ReadBitsIntBe(4);
            _hairFlip = m_io.ReadBitsIntBe(1) != 0;
            _hairColor = m_io.ReadBitsIntBe(3);
            m_io.AlignToByte();
            _eye = m_io.ReadU4le();
            _eyebrow = m_io.ReadU4le();
            _nose = m_io.ReadU2le();
            _mouth = m_io.ReadU2le();
            _mouth2 = m_io.ReadU2le();
            _beard = m_io.ReadU2le();
            _glasses = m_io.ReadU2le();
            _mole = m_io.ReadU2le();
            _creatorName = System.Text.Encoding.GetEncoding("utf-16le").GetString(m_io.ReadBytes(20));
            _padding2 = m_io.ReadU2le();
            _checksum = m_io.ReadU2le();
        }
        private bool f_glassesColor;
        private int _glassesColor;
        public int GlassesColor
        {
            get
            {
                if (f_glassesColor)
                    return _glassesColor;
                _glassesColor = (int) (((Glasses >> 4) & 7));
                f_glassesColor = true;
                return _glassesColor;
            }
        }
        private bool f_eyebrowHorizontal;
        private int _eyebrowHorizontal;
        public int EyebrowHorizontal
        {
            get
            {
                if (f_eyebrowHorizontal)
                    return _eyebrowHorizontal;
                _eyebrowHorizontal = (int) (((Eyebrow >> 21) & 15));
                f_eyebrowHorizontal = true;
                return _eyebrowHorizontal;
            }
        }
        private bool f_eyeVertical;
        private int _eyeVertical;
        public int EyeVertical
        {
            get
            {
                if (f_eyeVertical)
                    return _eyeVertical;
                _eyeVertical = (int) (((Eye >> 25) & 31));
                f_eyeVertical = true;
                return _eyeVertical;
            }
        }
        private bool f_facialHairBeard;
        private int _facialHairBeard;
        public int FacialHairBeard
        {
            get
            {
                if (f_facialHairBeard)
                    return _facialHairBeard;
                _facialHairBeard = (int) ((Beard & 7));
                f_facialHairBeard = true;
                return _facialHairBeard;
            }
        }
        private bool f_mouthSize;
        private int _mouthSize;
        public int MouthSize
        {
            get
            {
                if (f_mouthSize)
                    return _mouthSize;
                _mouthSize = (int) (((Mouth >> 9) & 15));
                f_mouthSize = true;
                return _mouthSize;
            }
        }
        private bool f_eyebrowStretch;
        private int _eyebrowStretch;
        public int EyebrowStretch
        {
            get
            {
                if (f_eyebrowStretch)
                    return _eyebrowStretch;
                _eyebrowStretch = (int) (((Eyebrow >> 12) & 7));
                f_eyebrowStretch = true;
                return _eyebrowStretch;
            }
        }
        private bool f_noseVertical;
        private int _noseVertical;
        public int NoseVertical
        {
            get
            {
                if (f_noseVertical)
                    return _noseVertical;
                _noseVertical = (int) (((Nose >> 9) & 31));
                f_noseVertical = true;
                return _noseVertical;
            }
        }
        private bool f_eyeColor;
        private int _eyeColor;
        public int EyeColor
        {
            get
            {
                if (f_eyeColor)
                    return _eyeColor;
                _eyeColor = (int) (((Eye >> 6) & 7));
                f_eyeColor = true;
                return _eyeColor;
            }
        }
        private bool f_birthMonth;
        private int _birthMonth;
        public int BirthMonth
        {
            get
            {
                if (f_birthMonth)
                    return _birthMonth;
                _birthMonth = (int) (((Data1 >> 1) & 15));
                f_birthMonth = true;
                return _birthMonth;
            }
        }
        private bool f_mouthColor;
        private int _mouthColor;
        public int MouthColor
        {
            get
            {
                if (f_mouthColor)
                    return _mouthColor;
                _mouthColor = (int) (((Mouth >> 6) & 7));
                f_mouthColor = true;
                return _mouthColor;
            }
        }
        private bool f_moleHorizontal;
        private int _moleHorizontal;
        public int MoleHorizontal
        {
            get
            {
                if (f_moleHorizontal)
                    return _moleHorizontal;
                _moleHorizontal = (int) (((Mole >> 5) & 31));
                f_moleHorizontal = true;
                return _moleHorizontal;
            }
        }
        private bool f_facialHairMustache;
        private int _facialHairMustache;
        public int FacialHairMustache
        {
            get
            {
                if (f_facialHairMustache)
                    return _facialHairMustache;
                _facialHairMustache = (int) (((Mouth2 >> 5) & 7));
                f_facialHairMustache = true;
                return _facialHairMustache;
            }
        }
        private bool f_eyebrowRotation;
        private int _eyebrowRotation;
        public int EyebrowRotation
        {
            get
            {
                if (f_eyebrowRotation)
                    return _eyebrowRotation;
                _eyebrowRotation = (int) (((Eyebrow >> 16) & 15));
                f_eyebrowRotation = true;
                return _eyebrowRotation;
            }
        }
        private bool f_moleVertical;
        private int _moleVertical;
        public int MoleVertical
        {
            get
            {
                if (f_moleVertical)
                    return _moleVertical;
                _moleVertical = (int) (((Mole >> 10) & 31));
                f_moleVertical = true;
                return _moleVertical;
            }
        }
        private bool f_glassesType;
        private int _glassesType;
        public int GlassesType
        {
            get
            {
                if (f_glassesType)
                    return _glassesType;
                _glassesType = (int) ((Glasses & 15));
                f_glassesType = true;
                return _glassesType;
            }
        }
        private bool f_eyebrowSize;
        private int _eyebrowSize;
        public int EyebrowSize
        {
            get
            {
                if (f_eyebrowSize)
                    return _eyebrowSize;
                _eyebrowSize = (int) (((Eyebrow >> 8) & 15));
                f_eyebrowSize = true;
                return _eyebrowSize;
            }
        }
        private bool f_moleSize;
        private int _moleSize;
        public int MoleSize
        {
            get
            {
                if (f_moleSize)
                    return _moleSize;
                _moleSize = (int) (((Mole >> 1) & 15));
                f_moleSize = true;
                return _moleSize;
            }
        }
        private bool f_noseSize;
        private int _noseSize;
        public int NoseSize
        {
            get
            {
                if (f_noseSize)
                    return _noseSize;
                _noseSize = (int) (((Nose >> 5) & 15));
                f_noseSize = true;
                return _noseSize;
            }
        }
        private bool f_facialHairVertical;
        private int _facialHairVertical;
        public int FacialHairVertical
        {
            get
            {
                if (f_facialHairVertical)
                    return _facialHairVertical;
                _facialHairVertical = (int) (((Beard >> 10) & 31));
                f_facialHairVertical = true;
                return _facialHairVertical;
            }
        }
        private bool f_eyeStretch;
        private int _eyeStretch;
        public int EyeStretch
        {
            get
            {
                if (f_eyeStretch)
                    return _eyeStretch;
                _eyeStretch = (int) (((Eye >> 13) & 7));
                f_eyeStretch = true;
                return _eyeStretch;
            }
        }
        private bool f_eyeSize;
        private int _eyeSize;
        public int EyeSize
        {
            get
            {
                if (f_eyeSize)
                    return _eyeSize;
                _eyeSize = (int) (((Eye >> 9) & 7));
                f_eyeSize = true;
                return _eyeSize;
            }
        }
        private bool f_eyeType;
        private int _eyeType;
        public int EyeType
        {
            get
            {
                if (f_eyeType)
                    return _eyeType;
                _eyeType = (int) ((Eye & 63));
                f_eyeType = true;
                return _eyeType;
            }
        }
        private bool f_eyeHorizontal;
        private int _eyeHorizontal;
        public int EyeHorizontal
        {
            get
            {
                if (f_eyeHorizontal)
                    return _eyeHorizontal;
                _eyeHorizontal = (int) (((Eye >> 21) & 15));
                f_eyeHorizontal = true;
                return _eyeHorizontal;
            }
        }
        private bool f_eyebrowType;
        private int _eyebrowType;
        public int EyebrowType
        {
            get
            {
                if (f_eyebrowType)
                    return _eyebrowType;
                _eyebrowType = (int) ((Eyebrow & 31));
                f_eyebrowType = true;
                return _eyebrowType;
            }
        }
        private bool f_mouthVertical;
        private int _mouthVertical;
        public int MouthVertical
        {
            get
            {
                if (f_mouthVertical)
                    return _mouthVertical;
                _mouthVertical = (int) ((Mouth2 & 31));
                f_mouthVertical = true;
                return _mouthVertical;
            }
        }
        private bool f_eyebrowColor;
        private int _eyebrowColor;
        public int EyebrowColor
        {
            get
            {
                if (f_eyebrowColor)
                    return _eyebrowColor;
                _eyebrowColor = (int) (((Eyebrow >> 5) & 7));
                f_eyebrowColor = true;
                return _eyebrowColor;
            }
        }
        private bool f_noseType;
        private int _noseType;
        public int NoseType
        {
            get
            {
                if (f_noseType)
                    return _noseType;
                _noseType = (int) ((Nose & 31));
                f_noseType = true;
                return _noseType;
            }
        }
        private bool f_facialHairColor;
        private int _facialHairColor;
        public int FacialHairColor
        {
            get
            {
                if (f_facialHairColor)
                    return _facialHairColor;
                _facialHairColor = (int) (((Beard >> 3) & 7));
                f_facialHairColor = true;
                return _facialHairColor;
            }
        }
        private bool f_eyebrowVertical;
        private int _eyebrowVertical;
        public int EyebrowVertical
        {
            get
            {
                if (f_eyebrowVertical)
                    return _eyebrowVertical;
                _eyebrowVertical = (int) (((Eyebrow >> 25) & 31));
                f_eyebrowVertical = true;
                return _eyebrowVertical;
            }
        }
        private bool f_glassesSize;
        private int _glassesSize;
        public int GlassesSize
        {
            get
            {
                if (f_glassesSize)
                    return _glassesSize;
                _glassesSize = (int) (((Glasses >> 7) & 15));
                f_glassesSize = true;
                return _glassesSize;
            }
        }
        private bool f_eyeRotation;
        private int _eyeRotation;
        public int EyeRotation
        {
            get
            {
                if (f_eyeRotation)
                    return _eyeRotation;
                _eyeRotation = (int) (((Eye >> 16) & 31));
                f_eyeRotation = true;
                return _eyeRotation;
            }
        }
        private bool f_gender;
        private int _gender;
        public int Gender
        {
            get
            {
                if (f_gender)
                    return _gender;
                _gender = (int) ((Data1 & 1));
                f_gender = true;
                return _gender;
            }
        }
        private bool f_birthDay;
        private int _birthDay;
        public int BirthDay
        {
            get
            {
                if (f_birthDay)
                    return _birthDay;
                _birthDay = (int) (((Data1 >> 5) & 31));
                f_birthDay = true;
                return _birthDay;
            }
        }
        private bool f_mouthStretch;
        private int _mouthStretch;
        public int MouthStretch
        {
            get
            {
                if (f_mouthStretch)
                    return _mouthStretch;
                _mouthStretch = (int) (((Mouth >> 13) & 7));
                f_mouthStretch = true;
                return _mouthStretch;
            }
        }
        private bool f_moleEnable;
        private int _moleEnable;
        public int MoleEnable
        {
            get
            {
                if (f_moleEnable)
                    return _moleEnable;
                _moleEnable = (int) ((Mole >> 15));
                f_moleEnable = true;
                return _moleEnable;
            }
        }
        private bool f_favorite;
        private int _favorite;
        public int Favorite
        {
            get
            {
                if (f_favorite)
                    return _favorite;
                _favorite = (int) (((Data1 >> 14) & 1));
                f_favorite = true;
                return _favorite;
            }
        }
        private bool f_glassesVertical;
        private int _glassesVertical;
        public int GlassesVertical
        {
            get
            {
                if (f_glassesVertical)
                    return _glassesVertical;
                _glassesVertical = (int) (((Glasses >> 11) & 15));
                f_glassesVertical = true;
                return _glassesVertical;
            }
        }
        private bool f_favoriteColor;
        private int _favoriteColor;
        public int FavoriteColor
        {
            get
            {
                if (f_favoriteColor)
                    return _favoriteColor;
                _favoriteColor = (int) (((Data1 >> 10) & 15));
                f_favoriteColor = true;
                return _favoriteColor;
            }
        }
        private bool f_mouthType;
        private int _mouthType;
        public int MouthType
        {
            get
            {
                if (f_mouthType)
                    return _mouthType;
                _mouthType = (int) ((Mouth & 63));
                f_mouthType = true;
                return _mouthType;
            }
        }
        private bool f_facialHairSize;
        private int _facialHairSize;
        public int FacialHairSize
        {
            get
            {
                if (f_facialHairSize)
                    return _facialHairSize;
                _facialHairSize = (int) (((Beard >> 6) & 15));
                f_facialHairSize = true;
                return _facialHairSize;
            }
        }
        private byte _unknown1;
        private ulong _characterSet;
        private ulong _regionLock;
        private bool _profanityFlag;
        private bool _copying;
        private ulong _unknown2;
        private ulong _miiPositionSlotIndex;
        private ulong _miiPositionPageIndex;
        private ulong _version;
        private ulong _unknown3;
        private List<byte> _systemId;
        private List<byte> _avatarId;
        private List<byte> _clientId;
        private ushort _padding;
        private ushort _data1;
        private string _miiName;
        private byte _bodyHeight;
        private byte _bodyWeight;
        private ulong _faceColor;
        private ulong _faceType;
        private bool _mingle;
        private ulong _faceMakeup;
        private ulong _faceWrinkles;
        private byte _hairType;
        private ulong _unknown5;
        private bool _hairFlip;
        private ulong _hairColor;
        private uint _eye;
        private uint _eyebrow;
        private ushort _nose;
        private ushort _mouth;
        private ushort _mouth2;
        private ushort _beard;
        private ushort _glasses;
        private ushort _mole;
        private string _creatorName;
        private ushort _padding2;
        private ushort _checksum;
        private Gen2MiiBinary m_root;
        private KaitaiStruct m_parent;

        /// <summary>
        /// Always 3?
        /// </summary>
        public byte Unknown1 { get { return _unknown1; } }

        /// <summary>
        /// 0=JPN+USA+EUR, 1=CHN, 2=KOR, 3=TWN
        /// </summary>
        public ulong CharacterSet { get { return _characterSet; } }

        /// <summary>
        /// 0=no lock, 1=JPN, 2=USA, 3=EUR
        /// </summary>
        public ulong RegionLock { get { return _regionLock; } }
        public bool ProfanityFlag { get { return _profanityFlag; } }
        public bool Copying { get { return _copying; } }
        public ulong Unknown2 { get { return _unknown2; } }
        public ulong MiiPositionSlotIndex { get { return _miiPositionSlotIndex; } }
        public ulong MiiPositionPageIndex { get { return _miiPositionPageIndex; } }
        public ulong Version { get { return _version; } }
        public ulong Unknown3 { get { return _unknown3; } }
        public List<byte> SystemId { get { return _systemId; } }
        public List<byte> AvatarId { get { return _avatarId; } }
        public List<byte> ClientId { get { return _clientId; } }
        public ushort Padding { get { return _padding; } }
        public ushort Data1 { get { return _data1; } }
        public string MiiName { get { return _miiName; } }
        public byte BodyHeight { get { return _bodyHeight; } }
        public byte BodyWeight { get { return _bodyWeight; } }
        public ulong FaceColor { get { return _faceColor; } }
        public ulong FaceType { get { return _faceType; } }
        public bool Mingle { get { return _mingle; } }
        public ulong FaceMakeup { get { return _faceMakeup; } }
        public ulong FaceWrinkles { get { return _faceWrinkles; } }
        public byte HairType { get { return _hairType; } }
        public ulong Unknown5 { get { return _unknown5; } }
        public bool HairFlip { get { return _hairFlip; } }
        public ulong HairColor { get { return _hairColor; } }
        public uint Eye { get { return _eye; } }
        public uint Eyebrow { get { return _eyebrow; } }
        public ushort Nose { get { return _nose; } }
        public ushort Mouth { get { return _mouth; } }
        public ushort Mouth2 { get { return _mouth2; } }
        public ushort Beard { get { return _beard; } }
        public ushort Glasses { get { return _glasses; } }
        public ushort Mole { get { return _mole; } }
        public string CreatorName { get { return _creatorName; } }
        public ushort Padding2 { get { return _padding2; } }
        public ushort Checksum { get { return _checksum; } }
        public Gen2MiiBinary M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
