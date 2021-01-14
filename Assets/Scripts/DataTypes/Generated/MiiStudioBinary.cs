// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild



namespace Kaitai
{
    public partial class MiiStudioBinary : KaitaiStruct
    {
        public static MiiStudioBinary FromFile(string fileName)
        {
            return new MiiStudioBinary(new KaitaiStream(fileName));
        }

        public MiiStudioBinary(KaitaiStream p__io, KaitaiStruct p__parent = null, MiiStudioBinary p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _facialHairColor = m_io.ReadU1();
            _beardGoatee = m_io.ReadU1();
            _bodyWeight = m_io.ReadU1();
            _eyeStretch = m_io.ReadU1();
            _eyeColor = m_io.ReadU1();
            _eyeRotation = m_io.ReadU1();
            _eyeSize = m_io.ReadU1();
            _eyeType = m_io.ReadU1();
            _eyeHorizontal = m_io.ReadU1();
            _eyeVertical = m_io.ReadU1();
            _eyebrowStretch = m_io.ReadU1();
            _eyebrowColor = m_io.ReadU1();
            _eyebrowRotation = m_io.ReadU1();
            _eyebrowSize = m_io.ReadU1();
            _eyebrowType = m_io.ReadU1();
            _eyebrowHorizontal = m_io.ReadU1();
            _eyebrowVertical = m_io.ReadU1();
            _faceColor = m_io.ReadU1();
            _faceMakeup = m_io.ReadU1();
            _faceType = m_io.ReadU1();
            _faceWrinkles = m_io.ReadU1();
            _favoriteColor = m_io.ReadU1();
            _gender = m_io.ReadU1();
            _glassesColor = m_io.ReadU1();
            _glassesSize = m_io.ReadU1();
            _glassesType = m_io.ReadU1();
            _glassesVertical = m_io.ReadU1();
            _hairColor = m_io.ReadU1();
            _hairFlip = m_io.ReadU1();
            _hairType = m_io.ReadU1();
            _bodyHeight = m_io.ReadU1();
            _moleSize = m_io.ReadU1();
            _moleEnable = m_io.ReadU1();
            _moleHorizontal = m_io.ReadU1();
            _moleVertical = m_io.ReadU1();
            _mouthStretch = m_io.ReadU1();
            _mouthColor = m_io.ReadU1();
            _mouthSize = m_io.ReadU1();
            _mouthType = m_io.ReadU1();
            _mouthVertical = m_io.ReadU1();
            _beardSize = m_io.ReadU1();
            _beardMustache = m_io.ReadU1();
            _beardVertical = m_io.ReadU1();
            _noseSize = m_io.ReadU1();
            _noseType = m_io.ReadU1();
            _noseVertical = m_io.ReadU1();
        }
        private byte _facialHairColor;
        private byte _beardGoatee;
        private byte _bodyWeight;
        private byte _eyeStretch;
        private byte _eyeColor;
        private byte _eyeRotation;
        private byte _eyeSize;
        private byte _eyeType;
        private byte _eyeHorizontal;
        private byte _eyeVertical;
        private byte _eyebrowStretch;
        private byte _eyebrowColor;
        private byte _eyebrowRotation;
        private byte _eyebrowSize;
        private byte _eyebrowType;
        private byte _eyebrowHorizontal;
        private byte _eyebrowVertical;
        private byte _faceColor;
        private byte _faceMakeup;
        private byte _faceType;
        private byte _faceWrinkles;
        private byte _favoriteColor;
        private byte _gender;
        private byte _glassesColor;
        private byte _glassesSize;
        private byte _glassesType;
        private byte _glassesVertical;
        private byte _hairColor;
        private byte _hairFlip;
        private byte _hairType;
        private byte _bodyHeight;
        private byte _moleSize;
        private byte _moleEnable;
        private byte _moleHorizontal;
        private byte _moleVertical;
        private byte _mouthStretch;
        private byte _mouthColor;
        private byte _mouthSize;
        private byte _mouthType;
        private byte _mouthVertical;
        private byte _beardSize;
        private byte _beardMustache;
        private byte _beardVertical;
        private byte _noseSize;
        private byte _noseType;
        private byte _noseVertical;
        private MiiStudioBinary m_root;
        private KaitaiStruct m_parent;

        /// <summary>
        /// Facial hair color. Ranges from 0 to 99. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{hair-color} for default colors and /maps.txt/{colors} for custom colors.
        /// </summary>
        public byte FacialHairColor { get { return _facialHairColor; } }

        /// <summary>
        /// Beard (goatee) type. Ranges from 0 to 5.
        /// </summary>
        public byte BeardGoatee { get { return _beardGoatee; } }

        /// <summary>
        /// Body weight. Ranges from 0 to 127, small to large.
        /// </summary>
        public byte BodyWeight { get { return _bodyWeight; } }

        /// <summary>
        /// Eye stretch. Ranges from 0 to 6, small to large.
        /// </summary>
        public byte EyeStretch { get { return _eyeStretch; } }

        /// <summary>
        /// Eye color. Ranges from 0 to 99. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{eye-color} for default colors and /maps.txt/{colors} for custom colors.
        /// </summary>
        public byte EyeColor { get { return _eyeColor; } }

        /// <summary>
        /// Eye rotation. Ranges from 0 to 7, down to up. Note that some eye types have a default rotation. You can find more specifics at /rotation.txt/{eyes}.
        /// </summary>
        public byte EyeRotation { get { return _eyeRotation; } }

        /// <summary>
        /// Eye size. Ranges from 0 to 7, small to large.
        /// </summary>
        public byte EyeSize { get { return _eyeSize; } }

        /// <summary>
        /// Eye type. Ranges from 0 to 59. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{eyes}.
        /// </summary>
        public byte EyeType { get { return _eyeType; } }

        /// <summary>
        /// Eye X (horizontal) distance. Ranges from 0 to 12, close to far.
        /// </summary>
        public byte EyeHorizontal { get { return _eyeHorizontal; } }

        /// <summary>
        /// Eye Y (vertical) position. Ranges from 18 to 0, low to high.
        /// </summary>
        public byte EyeVertical { get { return _eyeVertical; } }

        /// <summary>
        /// Eyebrow stretch. Ranges from 0 to 6, small to large.
        /// </summary>
        public byte EyebrowStretch { get { return _eyebrowStretch; } }

        /// <summary>
        /// Eyebrow color. Ranges from 0 to 99. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{hair-color} for default colors and /maps.txt/{colors} for custom colors.
        /// </summary>
        public byte EyebrowColor { get { return _eyebrowColor; } }

        /// <summary>
        /// Eyebrow rotation. Ranges from 0 to 11, down to up. Note that some eyebrow types have a default rotation. You can find more specifics at /rotation.txt/{eyebrows}.
        /// </summary>
        public byte EyebrowRotation { get { return _eyebrowRotation; } }

        /// <summary>
        /// Eyebrow size. Ranges from 0 to 8, small to large.
        /// </summary>
        public byte EyebrowSize { get { return _eyebrowSize; } }

        /// <summary>
        /// Eyebrow type. Ranges from 0 to 23. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{eyebrows}.
        /// </summary>
        public byte EyebrowType { get { return _eyebrowType; } }

        /// <summary>
        /// Eyebrow X (horizontal) distance. Ranges from 0 to 12, close to far.
        /// </summary>
        public byte EyebrowHorizontal { get { return _eyebrowHorizontal; } }

        /// <summary>
        /// Eyebrow Y (vertical) distance. Ranges from 12 to 3, low to high.
        /// </summary>
        public byte EyebrowVertical { get { return _eyebrowVertical; } }

        /// <summary>
        /// Skin color. Ranges from 0 to 9. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{skin}.
        /// </summary>
        public byte FaceColor { get { return _faceColor; } }

        /// <summary>
        /// Face makeup. Ranges from 0 to 11.
        /// </summary>
        public byte FaceMakeup { get { return _faceMakeup; } }

        /// <summary>
        /// Face shape. Ranges from 0 to 11. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{face}.
        /// </summary>
        public byte FaceType { get { return _faceType; } }

        /// <summary>
        /// Face wrinkles. Ranges from 0 to 11.
        /// </summary>
        public byte FaceWrinkles { get { return _faceWrinkles; } }

        /// <summary>
        /// Favorite color. Ranges from 0 to 11.
        /// </summary>
        public byte FavoriteColor { get { return _favoriteColor; } }

        /// <summary>
        /// Mii gender. 0 = male, 1 = female.
        /// </summary>
        public byte Gender { get { return _gender; } }

        /// <summary>
        /// Glasses color. Ranges from 0 to 99. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{glasses-color} for default colors and /maps.txt/{colors} for custom colors.
        /// </summary>
        public byte GlassesColor { get { return _glassesColor; } }

        /// <summary>
        /// Glasses size. Ranges from 0 to 7, small to large.
        /// </summary>
        public byte GlassesSize { get { return _glassesSize; } }

        /// <summary>
        /// Glasses type. Ranges from 0 to 19. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{glasses}.
        /// </summary>
        public byte GlassesType { get { return _glassesType; } }

        /// <summary>
        /// Glasses Y (vertical) position. Ranges from 20 to 0, low to high.
        /// </summary>
        public byte GlassesVertical { get { return _glassesVertical; } }

        /// <summary>
        /// Hair color. Ranges from 0 to 99. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{hair-color} for default colors and /maps.txt/{colors} for custom colors.
        /// </summary>
        public byte HairColor { get { return _hairColor; } }

        /// <summary>
        /// Flip hair. 0 = no, 1 = yes.
        /// </summary>
        public byte HairFlip { get { return _hairFlip; } }

        /// <summary>
        /// Hair type. Ranges from 0 to 131. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{hair}.
        /// </summary>
        public byte HairType { get { return _hairType; } }

        /// <summary>
        /// Body height. Ranges from 0 to 127, short to tall.
        /// </summary>
        public byte BodyHeight { get { return _bodyHeight; } }

        /// <summary>
        /// Beauty mark size. Ranges from 0 to 8, small to large.
        /// </summary>
        public byte MoleSize { get { return _moleSize; } }

        /// <summary>
        /// Enable beauty mark. 0 = no, 1 = yes.
        /// </summary>
        public byte MoleEnable { get { return _moleEnable; } }

        /// <summary>
        /// Beauty mark X (horizontal) position. Ranges from 0 to 16, left to right.
        /// </summary>
        public byte MoleHorizontal { get { return _moleHorizontal; } }

        /// <summary>
        /// Beauty mark Y (vertical) position. Ranges from 30 to 0, low to high.
        /// </summary>
        public byte MoleVertical { get { return _moleVertical; } }

        /// <summary>
        /// Mouth stretch. Ranges from 0 to 6, small to large.
        /// </summary>
        public byte MouthStretch { get { return _mouthStretch; } }

        /// <summary>
        /// Mouth color. The default colors are ordered the same as visible in editor, ranging from 19 to 23. The custom colors are not and range from 0 to 99. A map of the internal values in correlation to the Mii editor is at /maps.txt/{colors} for custom colors.
        /// </summary>
        public byte MouthColor { get { return _mouthColor; } }

        /// <summary>
        /// Mouth size. Ranges from 0 to 8, small to large.
        /// </summary>
        public byte MouthSize { get { return _mouthSize; } }

        /// <summary>
        /// Mouth type. Ranges from 0 to 35. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{mouth}.
        /// </summary>
        public byte MouthType { get { return _mouthType; } }

        /// <summary>
        /// Mouth Y (vertical) position. Ranges from 18 to 0, low to high.
        /// </summary>
        public byte MouthVertical { get { return _mouthVertical; } }

        /// <summary>
        /// Mustache size. Ranges from 0 to 8, small to large.
        /// </summary>
        public byte BeardSize { get { return _beardSize; } }

        /// <summary>
        /// Mustache type. Ranges from 0 to 5.
        /// </summary>
        public byte BeardMustache { get { return _beardMustache; } }

        /// <summary>
        /// Mustache Y (vertical) position. Ranges from 16 to 0, low to high.
        /// </summary>
        public byte BeardVertical { get { return _beardVertical; } }

        /// <summary>
        /// Nose size. Ranges from 0 to 8, small to large.
        /// </summary>
        public byte NoseSize { get { return _noseSize; } }

        /// <summary>
        /// Nose type. Ranges from 0 to 17. Not ordered the same as visible in editor. A map of the internal values in correlation to the Mii editor is at /maps.txt/{nose}.
        /// </summary>
        public byte NoseType { get { return _noseType; } }

        /// <summary>
        /// Nose Y (vertical) position. Ranges from 18 to 0, low to high.
        /// </summary>
        public byte NoseVertical { get { return _noseVertical; } }
        public MiiStudioBinary M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
