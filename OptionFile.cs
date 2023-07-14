﻿using System;
using System.IO;
namespace PES5_WE9_LE_GDB_Manager
{
    public class OptionFile
    {
        private static readonly uint OFByteLength = 1250304;
        private static readonly uint[] OFBlock = {
            12, 
            5144, 
            9508, 
            14044, 
            36872, 
            657712, 
            803608, 
            822940, 
            969192, 
            1228568,
        };
        private static readonly uint[] OFBlockSize = {
            4948,
            1232,
            4520,
            22816,
            620000,
            145880,
            19320,
            146240,
            259364,
            21016,
        };
        private static readonly uint[] OFKey = {
            1815549542,
            1815549585,
            1815549585,
            1815549509,
            1815549566,
            1815549588,
            1815549594,
            1815549591,
            1815549509,
            1815549560,
            1815549588,
            1815549576,
            1815549576,
            1815549578,
            1815549591,
            1815549509,
            1815549548,
            1815549574,
            1815549586,
            1815549578,
            1815549509,
            1815549542,
            1815549591,
            1815549578,
            1815549509,
            1815549543,
            1815549578,
            1815549585,
            1815549588,
            1815549587,
            1815549580,
            1815549509,
            1815549561,
            1815549588,
            1815549509,
            1815549564,
            1815549546,
            1815549523,
            1815549350,
            1815549541,
            1815549362,
            1815549418,
            1815549364,
            1815549358,
            1815549351,
            1815549425,
            1815549370,
            1815549403,
            1815549351,
            1815549426,
            1815549351,
            1815549389,
            1815549371,
            1815549462,
            1815549366,
            1815549390,
            1815549351,
            1815549421,
            1815549380,
            1815549394,
            1815549372,
            1815549363,
            1815549351,
            1815549418,
            1815549350,
            1815549543,
            1815549351,
            1815549420,
            1815549351,
            1815549385,
            1815549351,
            1815549447,
            1815549351,
            1815549452,
            1815549352,
            1815549546,
            1815549352,
            1815549544,
            1815549352,
            1815549544,
            1815549352,
            1815549361,
            1815549351,
            1815549425,
            1815549352,
            1815549579,
            1815549350,
            1815549568,
            1815549352,
            1815549571,
            1815549351,
            1815549461,
            1815549358,
            1815549473,
            1815549366,
            1815549383,
            1815549351,
            1815549402,
            1815549351,
            1815549417,
            1815549352,
            1815549550,
            1815549350,
            1815549568,
            1815549352,
            1815549555,
            1815549352,
            1815549563,
            1815549352,
            1815549356,
            1815549352,
            1815549368,
            1815549351,
            1815549418,
            1815549364,
            1815549385,
            1815549369,
            1815549353,
            1815549351,
            1815549402,
            1815549351,
            1815549417,
            1815549351,
            1815549383,
            1815549351,
            1815549454,
            1815549369,
            1815549598,
            1815549351,
            1815549391,
            1815549360,
            1815549364,
            1815549351,
            1815549454,
            1815549351,
            1815549452,
            1815549351,
            1815549402,
            1815549351,
            1815549383,
            1815549350,
            1815549542,
            1815549360,
            1815549445,
            1815549366,
            1815549552,
            1815549351,
            1815549391,
            1815549372,
            1815549362,
            1815549351,
            1815549441,
            1815549351,
            1815549421,
            1815549351,
            1815549383,
            1815549361,
            1815549415,
            1815549365,
            1815549585,
            1815549351,
            1815549447,
            1815549350,
            1815549542,
            1815549352,
            1815549355,
            1815549350,
            1815549568,
            1815549352,
            1815549562,
            1815549350,
            1815549568,
            1815549359,
            1815549433,
            1815549351,
            1815549425,
            1815549352,
            1815549600,
            1815549352,
            1815549358,
            1815549352,
            1815549368,
            1815549352,
            1815549578,
            1815549352,
            1815549543,
            1815549352,
            1815549542,
            1815549351,
            1815549418,
            1815549352,
            1815549579,
            1815549350,
            1815549568,
            1815549352,
            1815549571,
            1815549351,
            1815549425,
            1815549351,
            1815549447,
            1815549351,
            1815549453,
            1815549363,
            1815549451,
            1815549351,
            1815549453,
            1815549351,
            1815549461,
            1815549351,
            1815549404,
            1815549351,
            1815549454,
            1815549351,
            1815549425,
            1815549351,
            1815549426,
            1815549352,
            1815549558,
            1815549350,
            1815549568,
            1815549352,
            1815549349,
            1815549351,
            1815549422,
            1815549366,
            1815549427,
            1815549351,
            1815549404,
            1815549351,
            1815549454,
            1815549364,
            1815549459,
            1815549369,
            1815549554,
            1815549351,
            1815549461,
            1815549359,
            1815549401,
            1815549351,
            1815549403,
            1815549351,
            1815549454,
            1815549351,
            1815549402,
            1815549350,
            1815549542,
            1815549351,
            1815549398,
            1815549351,
            1815549412,
            1815549351,
            1815549452,
            1815549351,
            1815549419,
            1815549351,
            1815549402,
            1815549351,
            1815549417,
            1815549351,
            1815549445,
            1815549359,
            1815549461,
            1815549351,
            1815549402,
            1815549351,
            1815549383,
            1815549361,
            1815549413,
            1815549351,
            1815549453,
            1815549351,
            1815549411,
            1815549351,
            1815549396,
            1815549351,
            1815549420,
            1815549350,
            1815549542,
            1815549364,
            1815549385,
            1815549369,
            1815549353,
            1815549363,
            1815549587,
            1815549351,
            1815549444,
            1815549351,
            1815549452,
            1815549351,
            1815549455,
            1815549351,
            1815549454,
            1815549351,
            1815549419,
            1815549351,
            1815549398,
            1815549351,
            1815549412,
            1815549351,
            1815549452,
            1815549351,
            1815549419,
            1815549351,
            1815549402,
            1815549351,
            1815549417,
            1815549351,
            1815549445,
            1815549366,
            1815549599,
            1815549367,
            1815549453,
            1815549351,
            1815549402,
            1815549351,
            1815549417,
            1815549351,
            1815549421,
            1815549351,
            1815549383,
            1815549363,
            1815549371,
            1815549351,
            1815549422,
            1815549351,
            1815549421,
            1815549351,
            1815549454,
            1815549351,
            1815549425,
            1815549351,
            1815549418,
            1815549352,
            1815549580,
            1815549352,
            1815549358,
            1815549352,
            1815549594,
            1815549352,
            1815549360,
            1815549371,
            1815549581,
            1815549363,
            1815549603,
            1815549351,
            1815549425,
            1815549351,
            1815549410,
            1815549351,
            1815549444,
            1815549351,
            1815549422,
            1815549357,
            1815549416,
            1815549362,
            1815549355,
            1815549358,
            1815549408,
            1815549351,
            1815549402,
            1815549351,
            1815549441,
            1815549351,
            1815549404,
            1815549350,
            1815549543,
            1815549477,
        };
        private static readonly byte[] OFKeyPC = {
            115,
            96,
            225,
            198,
            31,
            60,
            173,
            66,
            11,
            88,
            185,
            254,
            55,
            180,
            5,
            250,
            163,
            80,
            145,
            54,
            79,
            44,
            93,
            178,
            59,
            72,
            105,
            110,
            103,
            164,
            181,
            106,
            211,
            64,
            65,
            166,
            127,
            28,
            13,
            34,
            107,
            56,
            25,
            222,
            151,
            148,
            101,
            218,
            3,
            48,
            241,
            22,
            175,
            12,
            189,
            146,
            155,
            40,
            201,
            78,
            199,
            132,
            21,
            74,
            51,
            32,
            161,
            134,
            223,
            252,
            109,
            2,
            203,
            24,
            121,
            190,
            247,
            116,
            197,
            186,
            99,
            16,
            81,
            246,
            15,
            236,
            29,
            114,
            251,
            8,
            41,
            46,
            39,
            100,
            117,
            42,
            147,
            0,
            1,
            102,
            63,
            220,
            205,
            226,
            43,
            248,
            217,
            158,
            87,
            84,
            37,
            154,
            195,
            240,
            177,
            214,
            111,
            204,
            125,
            82,
            91,
            232,
            137,
            14,
            135,
            68,
            213,
            10,
            243,
            224,
            97,
            70,
            159,
            188,
            45,
            194,
            139,
            216,
            57,
            126,
            183,
            52,
            133,
            122,
            35,
            208,
            17,
            182,
            207,
            172,
            221,
            50,
            187,
            200,
            233,
            238,
            231,
            36,
            53,
            234,
            83,
            192,
            193,
            38,
            255,
            156,
            141,
            162,
            235,
            184,
            153,
            94,
            23,
            20,
            229,
            90,
            131,
            176,
            113,
            150,
            47,
            140,
            61,
            18,
            27,
            168,
            73,
            206,
            71,
            4,
            149,
            202,
            179,
            160,
            33,
            6,
            95,
            124,
            237,
            130,
            75,
            152,
            249,
            62,
            119,
            244,
            69,
            58,
            227,
            144,
            209,
            118,
            143,
            108,
            157,
            242,
            123,
            136,
            169,
            174,
            167,
            228,
            245,
            170,
            19,
            128,
            129,
            230,
            191,
            92,
            77,
            98,
            171,
            120,
            89,
            30,
            215,
            212,
            165,
            26,
            67,
            112,
            49,
            86,
            239,
            76,
            253,
            210,
            219,
            104,
            9,
            142,
            7,
            196,
            85,
            138,
        };
        private static readonly uint lastKey = OFKey[OFKey.Length - 1];
        private string fileLocation;
        public byte[] data;
        private string fileName;

        public OptionFile(string fileLocation)
        {
            this.fileLocation = fileLocation;
            ReadOptionFile();
        }

        private void ReadOptionFile()
        {
            byte[] fileContents = File.ReadAllBytes(fileLocation);
            fileName = Path.GetFileName(fileLocation);
            data = new byte[OFByteLength];
            Array.Copy(fileContents, data, fileContents.Length);
            ConvertData();
            Decrypt();
        }

        private void ConvertData()
        {
            uint key = 0;

            for (int i = 0; i < OFByteLength; i++)
            {
                data[i] = (byte)(data[i] ^ OFKeyPC[key]);

                if (key < 255)
                {
                    key++;
                }
                else
                {
                    key = 0;
                }
            }
        }

        private void Decrypt()
        {
            for (int i = 1; i < OFBlock.Length; i++)
            {
                int k = 0;
                for (uint a = OFBlock[i]; a < OFBlock[i] + OFBlockSize[i]; a += 4)
                {
                    uint c = Utils.ReadUInt32FromByteArray(data, a);
                    uint p = c - OFKey[k] + lastKey ^ lastKey;
                    uint val = 0x000000FF;
                    data[a] = (byte)(p & val);
                    data[(a + 1)] = (byte)(Utils.ZeroFillRightShift(p, 8) & val);
                    data[(a + 2)] = (byte)(Utils.ZeroFillRightShift(p, 16) & val);
                    data[(a + 3)] = (byte)(Utils.ZeroFillRightShift(p, 24) & val);
                    k++;
                    if (k == OFKey.Length)
                    {
                        k = 0;
                    }
                }
            }
        }
    }
}
