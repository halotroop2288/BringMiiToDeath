// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using System.Collections.Generic;

namespace Kaitai
{
    public partial class SwitchGameMiiBinary : KaitaiStruct
    {
        public static SwitchGameMiiBinary FromFile(string fileName)
        {
            return new SwitchGameMiiBinary(new KaitaiStream(fileName));
        }

        public SwitchGameMiiBinary(KaitaiStream p__io, KaitaiStruct p__parent = null, SwitchGameMiiBinary p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _unknownData = new List<byte>((int) (16));
            for (var i = 0; i < 16; i++)
            {
                _unknownData.Add(m_io.ReadU1());
            }
            _miiName = System.Text.Encoding.GetEncoding("utf-16le").GetString(m_io.ReadBytes(20));
            _unknownBuffer = new List<byte>((int) (3));
            for (var i = 0; i < 3; i++)
            {
                _unknownBuffer.Add(m_io.ReadU1());
            }
            _favoriteColor = m_io.ReadU1();
            _gender = m_io.ReadU1();
            _bodyHeight = m_io.ReadU1();
            _bodyWeight = m_io.ReadU1();
            _unknownBuffer2 = new List<byte>((int) (2));
            for (var i = 0; i < 2; i++)
            {
                _unknownBuffer2.Add(m_io.ReadU1());
            }
            _faceType = m_io.ReadU1();
            _faceColor = m_io.ReadU1();
            _faceWrinkles = m_io.ReadU1();
            _faceMakeup = m_io.ReadU1();
            _hairType = m_io.ReadU1();
            _hairColor = m_io.ReadU1();
            _hairFlip = m_io.ReadU1();
            _eyeType = m_io.ReadU1();
            _eyeColor = m_io.ReadU1();
            _eyeSize = m_io.ReadU1();
            _eyeStretch = m_io.ReadU1();
            _eyeRotation = m_io.ReadU1();
            _eyeHorizontal = m_io.ReadU1();
            _eyeVertical = m_io.ReadU1();
            _eyebrowType = m_io.ReadU1();
            _eyebrowColor = m_io.ReadU1();
            _eyebrowSize = m_io.ReadU1();
            _eyebrowStretch = m_io.ReadU1();
            _eyebrowRotation = m_io.ReadU1();
            _eyebrowHorizontal = m_io.ReadU1();
            _eyebrowVertical = m_io.ReadU1();
            _noseType = m_io.ReadU1();
            _noseSize = m_io.ReadU1();
            _noseVertical = m_io.ReadU1();
            _mouthType = m_io.ReadU1();
            _mouthColor = m_io.ReadU1();
            _mouthSize = m_io.ReadU1();
            _mouthStretch = m_io.ReadU1();
            _mouthVertical = m_io.ReadU1();
            _facialHairColor = m_io.ReadU1();
            _facialHairBeard = m_io.ReadU1();
            _facialHairMustache = m_io.ReadU1();
            _facialHairSize = m_io.ReadU1();
            _facialHairVertical = m_io.ReadU1();
            _glassesType = m_io.ReadU1();
            _glassesColor = m_io.ReadU1();
            _glassesSize = m_io.ReadU1();
            _glassesVertical = m_io.ReadU1();
            _moleEnable = m_io.ReadU1();
            _moleSize = m_io.ReadU1();
            _moleHorizontal = m_io.ReadU1();
            _moleVertical = m_io.ReadU1();
            _unknownBuffer3 = new List<byte>((int) (1));
            for (var i = 0; i < 1; i++)
            {
                _unknownBuffer3.Add(m_io.ReadU1());
            }
        }
        private List<byte> _unknownData;
        private string _miiName;
        private List<byte> _unknownBuffer;
        private byte _favoriteColor;
        private byte _gender;
        private byte _bodyHeight;
        private byte _bodyWeight;
        private List<byte> _unknownBuffer2;
        private byte _faceType;
        private byte _faceColor;
        private byte _faceWrinkles;
        private byte _faceMakeup;
        private byte _hairType;
        private byte _hairColor;
        private byte _hairFlip;
        private byte _eyeType;
        private byte _eyeColor;
        private byte _eyeSize;
        private byte _eyeStretch;
        private byte _eyeRotation;
        private byte _eyeHorizontal;
        private byte _eyeVertical;
        private byte _eyebrowType;
        private byte _eyebrowColor;
        private byte _eyebrowSize;
        private byte _eyebrowStretch;
        private byte _eyebrowRotation;
        private byte _eyebrowHorizontal;
        private byte _eyebrowVertical;
        private byte _noseType;
        private byte _noseSize;
        private byte _noseVertical;
        private byte _mouthType;
        private byte _mouthColor;
        private byte _mouthSize;
        private byte _mouthStretch;
        private byte _mouthVertical;
        private byte _facialHairColor;
        private byte _facialHairBeard;
        private byte _facialHairMustache;
        private byte _facialHairSize;
        private byte _facialHairVertical;
        private byte _glassesType;
        private byte _glassesColor;
        private byte _glassesSize;
        private byte _glassesVertical;
        private byte _moleEnable;
        private byte _moleSize;
        private byte _moleHorizontal;
        private byte _moleVertical;
        private List<byte> _unknownBuffer3;
        private SwitchGameMiiBinary m_root;
        private KaitaiStruct m_parent;

        /// <summary>
        /// Currently unknown data.
        /// </summary>
        public List<byte> UnknownData { get { return _unknownData; } }

        /// <summary>
        /// Mii name. Can be up to 10 characters long. Different from the Mii name that appears in Smash - in game, this is never seen.
        /// </summary>
        public string MiiName { get { return _miiName; } }

        /// <summary>
        /// Currently unknown data - likely a 00 buffer between the name and misc. info and the rest of the Mii data.
        /// </summary>
        public List<byte> UnknownBuffer { get { return _unknownBuffer; } }

        /// <summary>
        /// Favorite color. Ranges from 0 to 11.
        /// </summary>
        public byte FavoriteColor { get { return _favoriteColor; } }

        /// <summary>
        /// Mii gender. 0 = male, 1 = female.
        /// </summary>
        public byte Gender { get { return _gender; } }

        /// <summary>
        /// Body height. Ranges from 0 to 127, short to tall.
        /// </summary>
        public byte BodyHeight { get { return _bodyHeight; } }

        /// <summary>
        /// Body weight. Ranges from 0 to 127, small to large.
        /// </summary>
        public byte BodyWeight { get { return _bodyWeight; } }

        /// <summary>
        /// Currently unknown data - likely a 00 buffer between the Mii body data and the Mii face data.
        /// </summary>
        public List<byte> UnknownBuffer2 { get { return _unknownBuffer2; } }

        /// <summary>
        /// Face shape. Ranges from 0 to 11. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{face}.
        /// </summary>
        public byte FaceType { get { return _faceType; } }

        /// <summary>
        /// Skin color. Ranges from 0 to 9. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{skin}.
        /// </summary>
        public byte FaceColor { get { return _faceColor; } }

        /// <summary>
        /// Face wrinkles. Ranges from 0 to 11.
        /// </summary>
        public byte FaceWrinkles { get { return _faceWrinkles; } }

        /// <summary>
        /// Face makeup. Ranges from 0 to 11.
        /// </summary>
        public byte FaceMakeup { get { return _faceMakeup; } }

        /// <summary>
        /// Hair type. Ranges from 0 to 131. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{hair}.
        /// </summary>
        public byte HairType { get { return _hairType; } }

        /// <summary>
        /// Hair color. Ranges from 0 to 99. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{hair-color} for default colors and /maps.txt/{colors} for custom colors.
        /// </summary>
        public byte HairColor { get { return _hairColor; } }

        /// <summary>
        /// Flip hair. 0 = no, 1 = yes.
        /// </summary>
        public byte HairFlip { get { return _hairFlip; } }

        /// <summary>
        /// Eye type. Ranges from 0 to 59. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{eyes}.
        /// </summary>
        public byte EyeType { get { return _eyeType; } }

        /// <summary>
        /// Eye color. Ranges from 0 to 99. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{eye-color} for default colors and /maps.txt/{colors} for custom colors.
        /// </summary>
        public byte EyeColor { get { return _eyeColor; } }

        /// <summary>
        /// Eye size. Ranges from 0 to 7, small to large.
        /// </summary>
        public byte EyeSize { get { return _eyeSize; } }

        /// <summary>
        /// Eye stretch. Ranges from 0 to 6, small to large.
        /// </summary>
        public byte EyeStretch { get { return _eyeStretch; } }

        /// <summary>
        /// Eye rotation. Ranges from 0 to 7, down to up. Note that some eye types have a default rotation. You can find more specifics at /rotation.txt/{eyes}.
        /// </summary>
        public byte EyeRotation { get { return _eyeRotation; } }

        /// <summary>
        /// Eye X (horizontal) distance. Ranges from 0 to 12, close to far.
        /// </summary>
        public byte EyeHorizontal { get { return _eyeHorizontal; } }

        /// <summary>
        /// Eye Y (vertical) position. Ranges from 18 to 0, low to high.
        /// </summary>
        public byte EyeVertical { get { return _eyeVertical; } }

        /// <summary>
        /// Eyebrow type. Ranges from 0 to 23. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{eyebrows}.
        /// </summary>
        public byte EyebrowType { get { return _eyebrowType; } }

        /// <summary>
        /// Eyebrow color. Ranges from 0 to 99. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{hair-color} for default colors and /maps.txt/{colors} for custom colors.
        /// </summary>
        public byte EyebrowColor { get { return _eyebrowColor; } }

        /// <summary>
        /// Eyebrow size. Ranges from 0 to 8, small to large.
        /// </summary>
        public byte EyebrowSize { get { return _eyebrowSize; } }

        /// <summary>
        /// Eyebrow stretch. Ranges from 0 to 6, small to large.
        /// </summary>
        public byte EyebrowStretch { get { return _eyebrowStretch; } }

        /// <summary>
        /// Eyebrow rotation. Ranges from 0 to 11, down to up. Note that some eyebrow types have a default rotation. You can find more specifics at /rotation.txt/{eyebrows}.
        /// </summary>
        public byte EyebrowRotation { get { return _eyebrowRotation; } }

        /// <summary>
        /// Eyebrow X (horizontal) distance. Ranges from 0 to 12, close to far.
        /// </summary>
        public byte EyebrowHorizontal { get { return _eyebrowHorizontal; } }

        /// <summary>
        /// Eyebrow Y (vertical) distance. Ranges from 18 to 3, low to high.
        /// </summary>
        public byte EyebrowVertical { get { return _eyebrowVertical; } }

        /// <summary>
        /// Nose type. Ranges from 0 to 17. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{nose}.
        /// </summary>
        public byte NoseType { get { return _noseType; } }

        /// <summary>
        /// Nose size. Ranges from 0 to 8, small to large.
        /// </summary>
        public byte NoseSize { get { return _noseSize; } }

        /// <summary>
        /// Nose Y (vertical) position. Ranges from 18 to 0, low to high.
        /// </summary>
        public byte NoseVertical { get { return _noseVertical; } }

        /// <summary>
        /// Mouth type. Ranges from 0 to 35. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{mouth}.
        /// </summary>
        public byte MouthType { get { return _mouthType; } }

        /// <summary>
        /// Mouth color. The default colors are ordered the same as visible in editor, ranging from 19 to 23. The custom colors are not and range from 0 to 99. A map of the internal values in correlation to the Mii editor is at /maps.txt/{colors} for custom colors.
        /// </summary>
        public byte MouthColor { get { return _mouthColor; } }

        /// <summary>
        /// Mouth size. Ranges from 0 to 8, small to large.
        /// </summary>
        public byte MouthSize { get { return _mouthSize; } }

        /// <summary>
        /// Mouth stretch. Ranges from 0 to 6, small to large.
        /// </summary>
        public byte MouthStretch { get { return _mouthStretch; } }

        /// <summary>
        /// Mouth Y (vertical) position. Ranges from 18 to 0, low to high.
        /// </summary>
        public byte MouthVertical { get { return _mouthVertical; } }

        /// <summary>
        /// Facial hair color. Ranges from 0 to 99. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{hair-color} for default colors and /maps.txt/{colors} for custom colors.
        /// </summary>
        public byte FacialHairColor { get { return _facialHairColor; } }

        /// <summary>
        /// Beard type. Ranges from 0 to 5.
        /// </summary>
        public byte FacialHairBeard { get { return _facialHairBeard; } }

        /// <summary>
        /// Mustache type. Ranges from 0 to 5.
        /// </summary>
        public byte FacialHairMustache { get { return _facialHairMustache; } }

        /// <summary>
        /// Mustache size. Ranges from 0 to 8, small to large.
        /// </summary>
        public byte FacialHairSize { get { return _facialHairSize; } }

        /// <summary>
        /// Mustache Y (vertical) position. Ranges from 16 to 0, low to high.
        /// </summary>
        public byte FacialHairVertical { get { return _facialHairVertical; } }

        /// <summary>
        /// Glasses type. Ranges from 0 to 19. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{glasses}.
        /// </summary>
        public byte GlassesType { get { return _glassesType; } }

        /// <summary>
        /// Glasses color. Ranges from 0 to 99. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{glasses-color} for default colors and /maps.txt/{colors} for custom colors.
        /// </summary>
        public byte GlassesColor { get { return _glassesColor; } }

        /// <summary>
        /// Glasses size. Ranges from 0 to 7, small to large.
        /// </summary>
        public byte GlassesSize { get { return _glassesSize; } }

        /// <summary>
        /// Glasses Y (vertical) position. Ranges from 20 to 0, low to high.
        /// </summary>
        public byte GlassesVertical { get { return _glassesVertical; } }

        /// <summary>
        /// Enable mole. 0 = no, 1 = yes.
        /// </summary>
        public byte MoleEnable { get { return _moleEnable; } }

        /// <summary>
        /// Mole size. Ranges from 0 to 8, small to large.
        /// </summary>
        public byte MoleSize { get { return _moleSize; } }

        /// <summary>
        /// Mole X (horizontal) position. Ranges from 0 to 16, left to right.
        /// </summary>
        public byte MoleHorizontal { get { return _moleHorizontal; } }

        /// <summary>
        /// Mole Y (vertical) position. Ranges from 30 to 0, low to high.
        /// </summary>
        public byte MoleVertical { get { return _moleVertical; } }

        /// <summary>
        /// Currently unknown data - likely a 00 buffer between the Mii data and the Smash Ultimate data.
        /// </summary>
        public List<byte> UnknownBuffer3 { get { return _unknownBuffer3; } }
        public SwitchGameMiiBinary M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
