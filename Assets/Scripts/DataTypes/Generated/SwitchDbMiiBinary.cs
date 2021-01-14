// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using System.Collections.Generic;

namespace Kaitai
{
    public partial class SwitchDbMiiBinary : KaitaiStruct
    {
        public static SwitchDbMiiBinary FromFile(string fileName)
        {
            return new SwitchDbMiiBinary(new KaitaiStream(fileName));
        }

        public SwitchDbMiiBinary(KaitaiStream p__io, KaitaiStruct p__parent = null, SwitchDbMiiBinary p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _hairType = m_io.ReadU1();
            _moleEnable = m_io.ReadBitsIntBe(1) != 0;
            _bodyHeight = m_io.ReadBitsIntBe(7);
            _hairFlip = m_io.ReadBitsIntBe(1) != 0;
            _bodyWeight = m_io.ReadBitsIntBe(7);
            m_io.AlignToByte();
            _hairColor = m_io.ReadU1();
            _gender = m_io.ReadBitsIntBe(1) != 0;
            _eyeColor = m_io.ReadBitsIntBe(7);
            m_io.AlignToByte();
            _eyebrowColor = m_io.ReadU1();
            _mouthColor = m_io.ReadU1();
            _facialHairColor = m_io.ReadU1();
            _glassesColor = m_io.ReadU1();
            _eyeType = m_io.ReadU1();
            _mouthType = m_io.ReadU1();
            _glassesSize = m_io.ReadBitsIntBe(3);
            _eyeVertical = m_io.ReadBitsIntBe(5);
            _facialHairMustache = m_io.ReadBitsIntBe(3);
            _eyebrowType = m_io.ReadBitsIntBe(5);
            _facialHairBeard = m_io.ReadBitsIntBe(3);
            _noseType = m_io.ReadBitsIntBe(5);
            _mouthStretch = m_io.ReadBitsIntBe(3);
            _noseVertical = m_io.ReadBitsIntBe(5);
            _eyebrowStretch = m_io.ReadBitsIntBe(3);
            _mouthVertical = m_io.ReadBitsIntBe(5);
            _eyeRotation = m_io.ReadBitsIntBe(3);
            _facialHairVertical = m_io.ReadBitsIntBe(5);
            _eyeStretch = m_io.ReadBitsIntBe(3);
            _glassesVertical = m_io.ReadBitsIntBe(5);
            _eyeSize = m_io.ReadBitsIntBe(3);
            _moleHorizontal = m_io.ReadBitsIntBe(5);
            m_io.AlignToByte();
            _moleVertical = m_io.ReadU1();
            _glassesType = m_io.ReadU1();
            _faceType = m_io.ReadBitsIntBe(4);
            _favoriteColor = m_io.ReadBitsIntBe(4);
            _faceWrinkles = m_io.ReadBitsIntBe(4);
            _faceColor = m_io.ReadBitsIntBe(4);
            _eyeHorizontal = m_io.ReadBitsIntBe(4);
            _faceMakeup = m_io.ReadBitsIntBe(4);
            _eyebrowRotation = m_io.ReadBitsIntBe(4);
            _eyebrowSize = m_io.ReadBitsIntBe(4);
            _eyebrowVertical = m_io.ReadBitsIntBe(4);
            _eyebrowHorizontal = m_io.ReadBitsIntBe(4);
            _mouthSize = m_io.ReadBitsIntBe(4);
            _noseSize = m_io.ReadBitsIntBe(4);
            _moleSize = m_io.ReadBitsIntBe(4);
            _facialHairSize = m_io.ReadBitsIntBe(4);
            m_io.AlignToByte();
            _miiName = System.Text.Encoding.GetEncoding("utf-16le").GetString(m_io.ReadBytes(20));
            _unknown = new List<byte>((int) (16));
            for (var i = 0; i < 16; i++)
            {
                _unknown.Add(m_io.ReadU1());
            }
            _miiId = new List<byte>((int) (4));
            for (var i = 0; i < 4; i++)
            {
                _miiId.Add(m_io.ReadU1());
            }
        }
        private byte _hairType;
        private bool _moleEnable;
        private ulong _bodyHeight;
        private bool _hairFlip;
        private ulong _bodyWeight;
        private byte _hairColor;
        private bool _gender;
        private ulong _eyeColor;
        private byte _eyebrowColor;
        private byte _mouthColor;
        private byte _facialHairColor;
        private byte _glassesColor;
        private byte _eyeType;
        private byte _mouthType;
        private ulong _glassesSize;
        private ulong _eyeVertical;
        private ulong _facialHairMustache;
        private ulong _eyebrowType;
        private ulong _facialHairBeard;
        private ulong _noseType;
        private ulong _mouthStretch;
        private ulong _noseVertical;
        private ulong _eyebrowStretch;
        private ulong _mouthVertical;
        private ulong _eyeRotation;
        private ulong _facialHairVertical;
        private ulong _eyeStretch;
        private ulong _glassesVertical;
        private ulong _eyeSize;
        private ulong _moleHorizontal;
        private byte _moleVertical;
        private byte _glassesType;
        private ulong _faceType;
        private ulong _favoriteColor;
        private ulong _faceWrinkles;
        private ulong _faceColor;
        private ulong _eyeHorizontal;
        private ulong _faceMakeup;
        private ulong _eyebrowRotation;
        private ulong _eyebrowSize;
        private ulong _eyebrowVertical;
        private ulong _eyebrowHorizontal;
        private ulong _mouthSize;
        private ulong _noseSize;
        private ulong _moleSize;
        private ulong _facialHairSize;
        private string _miiName;
        private List<byte> _unknown;
        private List<byte> _miiId;
        private SwitchDbMiiBinary m_root;
        private KaitaiStruct m_parent;

        /// <summary>
        /// Hair type. Ranges from 0 to 131. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{hair}.
        /// </summary>
        public byte HairType { get { return _hairType; } }

        /// <summary>
        /// Enable mole. 0 = no, 1 = yes.
        /// </summary>
        public bool MoleEnable { get { return _moleEnable; } }

        /// <summary>
        /// Body height. Ranges from 0 to 127, short to tall. In the Mii editor, pressing right will add 1 to this value, and pressing left will subtract 1, allowing for precise editing.
        /// </summary>
        public ulong BodyHeight { get { return _bodyHeight; } }

        /// <summary>
        /// Flip hair. 0 = no, 1 = yes.
        /// </summary>
        public bool HairFlip { get { return _hairFlip; } }

        /// <summary>
        /// Body weight. Ranges from 0 to 127, small to large. In the Mii editor, pressing right will add 1 to this value, and pressing left will subtract 1, allowing for precise editing.
        /// </summary>
        public ulong BodyWeight { get { return _bodyWeight; } }

        /// <summary>
        /// Hair color. Ranges from 0 to 99. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{hair-color} for default colors and /maps.txt/{colors} for custom colors.
        /// </summary>
        public byte HairColor { get { return _hairColor; } }

        /// <summary>
        /// Mii gender. 0 = male, 1 = female.
        /// </summary>
        public bool Gender { get { return _gender; } }

        /// <summary>
        /// Eye color. Ranges from 0 to 99. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{eye-color} for default colors and /maps.txt/{colors} for custom colors.
        /// </summary>
        public ulong EyeColor { get { return _eyeColor; } }

        /// <summary>
        /// Eyebrow color. Ranges from 0 to 99. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{hair-color} for default colors and /maps.txt/{colors} for custom colors.
        /// </summary>
        public byte EyebrowColor { get { return _eyebrowColor; } }

        /// <summary>
        /// Mouth color. The default colors are ordered the same as visible in editor, ranging from 19 to 23. The custom colors are not and range from 0 to 99. A map of the internal values in correlation to the Mii editor is at /maps.txt/{colors} for custom colors.
        /// </summary>
        public byte MouthColor { get { return _mouthColor; } }

        /// <summary>
        /// Facial hair color. Ranges from 0 to 99. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{hair-color} for default colors and /maps.txt/{colors} for custom colors.
        /// </summary>
        public byte FacialHairColor { get { return _facialHairColor; } }

        /// <summary>
        /// Glasses color. Ranges from 0 to 99. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{glasses-color} for default colors and /maps.txt/{colors} for custom colors.
        /// </summary>
        public byte GlassesColor { get { return _glassesColor; } }

        /// <summary>
        /// Eye type. Ranges from 0 to 59. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{eyes}.
        /// </summary>
        public byte EyeType { get { return _eyeType; } }

        /// <summary>
        /// Mouth type. Ranges from 0 to 35. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{mouth}.
        /// </summary>
        public byte MouthType { get { return _mouthType; } }

        /// <summary>
        /// Glasses size. Ranges from 0 to 7, small to big.
        /// </summary>
        public ulong GlassesSize { get { return _glassesSize; } }

        /// <summary>
        /// Eye Y (vertical) position. Ranges from 24 to 0, low to high.
        /// </summary>
        public ulong EyeVertical { get { return _eyeVertical; } }

        /// <summary>
        /// Mustache type. Ranges from 0 to 5.
        /// </summary>
        public ulong FacialHairMustache { get { return _facialHairMustache; } }

        /// <summary>
        /// Eyebrow type. Ranges from 0 to 23. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{eyebrows}.
        /// </summary>
        public ulong EyebrowType { get { return _eyebrowType; } }

        /// <summary>
        /// Beard type. Ranges from 0 to 5.
        /// </summary>
        public ulong FacialHairBeard { get { return _facialHairBeard; } }

        /// <summary>
        /// Nose type. Ranges from 0 to 17. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{nose}.
        /// </summary>
        public ulong NoseType { get { return _noseType; } }

        /// <summary>
        /// Mouth stretch. Ranges from 0 to 6, small to big.
        /// </summary>
        public ulong MouthStretch { get { return _mouthStretch; } }

        /// <summary>
        /// Nose Y (vertical) position. Ranges from 24 to 0, low to high.
        /// </summary>
        public ulong NoseVertical { get { return _noseVertical; } }

        /// <summary>
        /// Eyebrow stretch. Ranges from 0 to 6, small to big.
        /// </summary>
        public ulong EyebrowStretch { get { return _eyebrowStretch; } }

        /// <summary>
        /// Mouth Y (vertical) position. Ranges from 24 to 0, low to high.
        /// </summary>
        public ulong MouthVertical { get { return _mouthVertical; } }

        /// <summary>
        /// Eye rotation. Ranges from 0 to 7, down to up. Note that some eye types have a default rotation. You can find more specifics at /rotation.txt/{eyes}.
        /// </summary>
        public ulong EyeRotation { get { return _eyeRotation; } }

        /// <summary>
        /// Mustache Y (vertical) position. Ranges from 22 to 0, low to high.
        /// </summary>
        public ulong FacialHairVertical { get { return _facialHairVertical; } }

        /// <summary>
        /// Eye stretch. Ranges from 0 to 6, small to big.
        /// </summary>
        public ulong EyeStretch { get { return _eyeStretch; } }

        /// <summary>
        /// Glasses Y (vertical) position. Ranges from 20 to 0, low to high.
        /// </summary>
        public ulong GlassesVertical { get { return _glassesVertical; } }

        /// <summary>
        /// Eye size. Ranges from 0 to 7, small to big.
        /// </summary>
        public ulong EyeSize { get { return _eyeSize; } }

        /// <summary>
        /// Mole X (horizontal) position. Ranges from 0 to 16, left to right.
        /// </summary>
        public ulong MoleHorizontal { get { return _moleHorizontal; } }

        /// <summary>
        /// Mole Y (vertical) position. Ranges from 30 to 0, low to high.
        /// </summary>
        public byte MoleVertical { get { return _moleVertical; } }

        /// <summary>
        /// Glasses type. Ranges from 0 to 19. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{glasses}.
        /// </summary>
        public byte GlassesType { get { return _glassesType; } }

        /// <summary>
        /// Face shape. Ranges from 0 to 11. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{face}.
        /// </summary>
        public ulong FaceType { get { return _faceType; } }

        /// <summary>
        /// Favorite color. Ranges from 0 to 11.
        /// </summary>
        public ulong FavoriteColor { get { return _favoriteColor; } }

        /// <summary>
        /// Face wrinkles. Ranges from 0 to 11.
        /// </summary>
        public ulong FaceWrinkles { get { return _faceWrinkles; } }

        /// <summary>
        /// Skin color. Ranges from 0 to 9. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{skin}.
        /// </summary>
        public ulong FaceColor { get { return _faceColor; } }

        /// <summary>
        /// Eye X (horizontal) distance. Ranges from 0 to 12, close to far.
        /// </summary>
        public ulong EyeHorizontal { get { return _eyeHorizontal; } }

        /// <summary>
        /// Face makeup. Ranges from 0 to 11.
        /// </summary>
        public ulong FaceMakeup { get { return _faceMakeup; } }

        /// <summary>
        /// Eyebrow rotation. Ranges from 0 to 11, down to up. Note that some eye types have a default rotation. You can find more specifics at /rotation.txt/{eyebrows}.
        /// </summary>
        public ulong EyebrowRotation { get { return _eyebrowRotation; } }

        /// <summary>
        /// Eyebrow size. Ranges from 0 to 8, small to big.
        /// </summary>
        public ulong EyebrowSize { get { return _eyebrowSize; } }

        /// <summary>
        /// Eyebrow Y (vertical) position. Ranges from 15 to 0, low to high.
        /// </summary>
        public ulong EyebrowVertical { get { return _eyebrowVertical; } }

        /// <summary>
        /// Eyebrow X (horizontal) distance. Ranges from 0 to 12, close to far.
        /// </summary>
        public ulong EyebrowHorizontal { get { return _eyebrowHorizontal; } }

        /// <summary>
        /// Mouth size. Ranges from 0 to 8, small to big.
        /// </summary>
        public ulong MouthSize { get { return _mouthSize; } }

        /// <summary>
        /// Nose size. Ranges from 0 to 8, small to big.
        /// </summary>
        public ulong NoseSize { get { return _noseSize; } }

        /// <summary>
        /// Mole size. Ranges from 0 to 8, small to big.
        /// </summary>
        public ulong MoleSize { get { return _moleSize; } }

        /// <summary>
        /// Mustache size. Ranges from 0 to 8, small to big.
        /// </summary>
        public ulong FacialHairSize { get { return _facialHairSize; } }

        /// <summary>
        /// Mii name. Can be up to 10 characters long.
        /// </summary>
        public string MiiName { get { return _miiName; } }

        /// <summary>
        /// Currently unknown data.
        /// </summary>
        public List<byte> Unknown { get { return _unknown; } }

        /// <summary>
        /// Mii ID. An identifier used to save Miis in most games.
        /// </summary>
        public List<byte> MiiId { get { return _miiId; } }
        public SwitchDbMiiBinary M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
