using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyMetin2
{
    public class PacketCrypt
    {
        #region IDA PRO 7.0 - Chinese Metin2 BETA Client
        private static int TEACrypt(uint[] dest, uint[] src, uint[] key, int size)
        {
            int v4; // eax
            //uint[] v5; // edx
            int v6; // esi
            uint[] v7; // ebx
            uint v8; // ecx
            uint v9; // eax
            uint v10; // edx
            uint v11; // ecx
            uint v12; // eax
            uint v13; // edi
            uint v14; // ecx
            uint v15; // eax
            uint v16; // ecx
            uint v17; // eax
            uint v18; // ecx
            uint v19; // eax
            uint v20; // ecx
            uint v21; // eax
            uint v22; // ecx
            uint v23; // eax
            uint v24; // ecx
            uint v25; // eax
            uint v26; // ecx
            uint v27; // eax
            uint v28; // ecx
            uint v29; // eax
            uint v30; // ecx
            uint v31; // eax
            uint v32; // ecx
            uint v33; // eax
            uint v34; // ecx
            uint v35; // eax
            uint v36; // ecx
            uint v37; // eax
            uint v38; // ecx
            uint v39; // eax
            uint v40; // ecx
            uint v41; // eax
            uint v42; // ecx
            uint v43; // eax
            uint v44; // ecx
            uint v45; // eax
            uint v46; // ecx
            uint v47; // eax
            uint v48; // ecx
            uint v49; // eax
            uint v50; // ecx
            uint v51; // eax
            uint v52; // ecx
            uint v53; // eax
            uint v54; // ecx
            uint v55; // eax
            uint v56; // ecx
            uint v57; // eax
            uint v58; // ecx
            uint v59; // eax
            uint v60; // ecx
            uint v61; // eax
            uint v62; // ecx
            uint v63; // eax
            uint v64; // ecx
            uint v65; // eax
            uint v66; // ecx
            uint v67; // eax
            uint v68; // ecx
            uint v69; // eax
            uint v70; // ecx
            uint v71; // eax
            uint v72; // edx
            uint v73; // ecx
            uint v74; // eax
            int v76; // [esp+Ch] [ebp-8h]
            int v77; // [esp+10h] [ebp-4h]
            uint sizea; // [esp+24h] [ebp+10h]

            v4 = size % 8;
            v6 = size;
            if ((size % 8) > 0)
            {
                v6 = size - v4 + 8;
                v77 = size - v4 + 8;

                //memset((char*)src + size, 0, 8 - v4);

                var conv = new byte[size + (8 - v4)];
                Array.Copy(ToByteArray(src), conv, size);
                for (int ii = 0; ii < (8 - v4); ii++)
                {
                    conv[size + ii] = 0;
                }
                src = ToUintArray(conv);
            }
            else
            {
                v77 = size;
            }
            if (v6 >> 3 <= 0)
                return v6;
            v7 = key;
            v76 = v6 >> 3;

            uint i = 0;
            do
            {
                v8 = src[i + 1];
                v9 = src[i] + (v7[0] ^ (v8 + (16 * src[i + 1] ^ (v8 >> 5))));
                v10 = v7[1];
                v11 = ((v7[3] - 1640531527) ^ (v9 + (16 * v9 ^ (v9 >> 5)))) + v8;
                v12 = ((v10 - 1640531527) ^ (v11 + (16 * v11 ^ (v11 >> 5)))) + v9;
                v13 = v7[2];
                v14 = ((v13 + 1013904242) ^ (v12 + (16 * v12 ^ (v12 >> 5)))) + v11;
                v15 = ((v13 + 1013904242) ^ (v14 + (16 * v14 ^ (v14 >> 5)))) + v12;
                v16 = ((v10 - 626627285) ^ (v15 + (16 * v15 ^ (v15 >> 5)))) + v14;
                v17 = ((key[3] - 626627285) ^ (v16 + (16 * v16 ^ (v16 >> 5)))) + v15;
                v18 = ((v7[0] + 2027808484) ^ (v17 + (16 * v17 ^ (v17 >> 5)))) + v16;
                v19 = ((v7[0] + 2027808484) ^ (v18 + (16 * v18 ^ (v18 >> 5)))) + v17;
                v20 = ((v7[0] + 387276957) ^ (v19 + (16 * v19 ^ (v19 >> 5)))) + v18;
                v21 = ((v10 + 387276957) ^ (v20 + (16 * v20 ^ (v20 >> 5)))) + v19;
                v22 = ((key[3] - 1253254570) ^ (v21 + (16 * v21 ^ (v21 >> 5)))) + v20;
                v23 = ((v13 - 1253254570) ^ (v22 + (16 * v22 ^ (v22 >> 5)))) + v21;
                v24 = ((v13 + 1401181199) ^ (v23 + (16 * v23 ^ (v23 >> 5)))) + v22;
                v25 = ((key[3] + 1401181199) ^ (v24 + (16 * v24 ^ (v24 >> 5)))) + v23;
                v26 = ((v10 - 239350328) ^ (v25 + (16 * v25 ^ (v25 >> 5)))) + v24;
                v27 = ((v7[0] - 239350328) ^ (v26 + (16 * v26 ^ (v26 >> 5)))) + v25;
                v28 = ((v7[0] - 1879881855) ^ (v27 + (16 * v27 ^ (v27 >> 5)))) + v26;
                v29 = ((v10 - 1879881855) ^ (v28 + (16 * v28 ^ (v28 >> 5)))) + v27;
                v30 = ((v7[0] + 774553914) ^ (v29 + (16 * v29 ^ (v29 >> 5)))) + v28;
                v31 = ((v13 + 774553914) ^ (v30 + (16 * v30 ^ (v30 >> 5)))) + v29;
                sizea = key[3] - 865977613;
                v32 = (sizea ^ (v31 + (16 * v31 ^ (v31 >> 5)))) + v30;
                v33 = (sizea ^ (v32 + (16 * v32 ^ (v32 >> 5)))) + v31;
                v34 = ((v13 + 1788458156) ^ (v33 + (16 * v33 ^ (v33 >> 5)))) + v32;
                v35 = ((v7[0] + 1788458156) ^ (v34 + (16 * v34 ^ (v34 >> 5)))) + v33;
                v36 = ((v10 + 147926629) ^ (v35 + (16 * v35 ^ (v35 >> 5)))) + v34;
                v37 = ((v10 + 147926629) ^ (v36 + (16 * v36 ^ (v36 >> 5)))) + v35;
                v38 = ((v10 - 1492604898) ^ (v37 + (16 * v37 ^ (v37 >> 5)))) + v36;
                v39 = ((v13 - 1492604898) ^ (v38 + (16 * v38 ^ (v38 >> 5)))) + v37;
                v40 = ((v7[0] + 1161830871) ^ (v39 + (16 * v39 ^ (v39 >> 5)))) + v38;
                v41 = ((key[3] + 1161830871) ^ (v40 + (16 * v40 ^ (v40 >> 5)))) + v39;
                v42 = ((key[3] - 478700656) ^ (v41 + (16 * v41 ^ (v41 >> 5)))) + v40;
                v43 = ((v7[0] - 478700656) ^ (v42 + (16 * v42 ^ (v42 >> 5)))) + v41;
                v44 = ((v13 - 2119232183) ^ (v43 + (16 * v43 ^ (v43 >> 5)))) + v42;
                v45 = ((v10 - 2119232183) ^ (v44 + (16 * v44 ^ (v44 >> 5)))) + v43;
                v46 = ((v10 + 535203586) ^ (v45 + (16 * v45 ^ (v45 >> 5)))) + v44;
                v47 = ((v13 + 535203586) ^ (v46 + (16 * v46 ^ (v46 >> 5)))) + v45;
                v48 = ((v10 - 1105327941) ^ (v47 + (16 * v47 ^ (v47 >> 5)))) + v46;
                v49 = ((key[3] - 1105327941) ^ (v48 + (16 * v48 ^ (v48 >> 5)))) + v47;
                v50 = ((v7[0] + 1549107828) ^ (v49 + (16 * v49 ^ (v49 >> 5)))) + v48;
                v51 = ((v7[0] + 1549107828) ^ (v50 + (16 * v50 ^ (v50 >> 5)))) + v49;
                v52 = ((key[3] - 91423699) ^ (v51 + (16 * v51 ^ (v51 >> 5)))) + v50;
                v53 = ((v10 - 91423699) ^ (v52 + (16 * v52 ^ (v52 >> 5)))) + v51;
                v54 = ((v13 - 1731955226) ^ (v53 + (16 * v53 ^ (v53 >> 5)))) + v52;
                v55 = ((v13 - 1731955226) ^ (v54 + (16 * v54 ^ (v54 >> 5)))) + v53;
                v56 = ((v10 + 922480543) ^ (v55 + (16 * v55 ^ (v55 >> 5)))) + v54;
                v57 = ((key[3] + 922480543) ^ (v56 + (16 * v56 ^ (v56 >> 5)))) + v55;
                v58 = ((v10 - 718050984) ^ (v57 + (16 * v57 ^ (v57 >> 5)))) + v56;
                v59 = ((v7[0] - 718050984) ^ (v58 + (16 * v58 ^ (v58 >> 5)))) + v57;
                v60 = ((v7[0] + 1936384785) ^ (v59 + (16 * v59 ^ (v59 >> 5)))) + v58;
                v61 = ((v10 + 1936384785) ^ (v60 + (16 * v60 ^ (v60 >> 5)))) + v59;
                v10 -= 330774027;
                v62 = ((key[3] + 295853258) ^ (v61 + (16 * v61 ^ (v61 >> 5)))) + v60;
                v63 = ((v13 + 295853258) ^ (v62 + (16 * v62 ^ (v62 >> 5)))) + v61;
                v64 = ((v13 - 1344678269) ^ (v63 + (16 * v63 ^ (v63 >> 5)))) + v62;
                v65 = ((key[3] - 1344678269) ^ (v64 + (16 * v64 ^ (v64 >> 5)))) + v63;
                v66 = ((v13 + 1309757500) ^ (v65 + (16 * v65 ^ (v65 >> 5)))) + v64;
                v67 = ((v7[0] + 1309757500) ^ (v66 + (16 * v66 ^ (v66 >> 5)))) + v65;
                v68 = (v10 ^ (v67 + (16 * v67 ^ (v67 >> 5)))) + v66;
                v69 = (v10 ^ (v68 + (16 * v68 ^ (v68 >> 5)))) + v67;
                v70 = ((v7[0] - 1971305554) ^ (v69 + (16 * v69 ^ (v69 >> 5)))) + v68;
                v7 = key;
                v71 = ((v13 - 1971305554) ^ (v70 + (16 * v70 ^ (v70 >> 5)))) + v69;
                v72 = key[3] + 683130215;
                v73 = (v72 ^ (v71 + (16 * v71 ^ (v71 >> 5)))) + v70;
                v74 = (v72 ^ (v73 + (16 * v73 ^ (v73 >> 5)))) + v71;
                dest[i] = v74;
                dest[i + 1] = ((v13 - 957401312) ^ (v74 + (16 * v74 ^ (v74 >> 5)))) + v73;

                i += 2;
                --v76;
            }
            while (v76 > 0);

            return v77;
        }

        private static int TEADecrypt(uint[] dest, uint[] src, uint[] key, int size)
        {
            int newSize; // eax
            int newSize_p3; // ecx
            uint currentCharacter; // ecx
            uint key_p3; // edi
            uint n1; // edx
            uint n2; // esi
            uint n3; // ecx
            uint n4; // edx
            uint key_p1; // ebx
            uint n5; // ecx
            uint n6; // edx
            uint key_p2; // esi
            uint n7; // ecx
            uint n8; // edx
            uint n9; // ecx
            uint n10; // edx
            uint n11; // ecx
            uint v23; // edx
            uint v24; // ecx
            uint v25; // edx
            uint v26; // ecx
            uint v27; // edx
            uint v28; // ecx
            uint v29; // edx
            uint v30; // ecx
            uint v31; // edx
            uint v32; // ecx
            uint v33; // edx
            uint v34; // ecx
            uint v35; // edx
            uint v36; // ecx
            uint v37; // edx
            uint v38; // ecx
            uint v39; // edx
            uint v40; // ecx
            uint v41; // edx
            uint v42; // ecx
            uint v43; // edx
            uint v44; // ecx
            uint v45; // edx
            uint v46; // ecx
            uint v47; // edx
            uint v48; // ecx
            uint v49; // edx
            uint v50; // ecx
            uint v51; // edx
            uint v52; // ecx
            uint v53; // edx
            uint v54; // ecx
            uint v55; // edx
            uint v56; // ecx
            uint v57; // edx
            uint v58; // ecx
            uint v59; // edx
            uint v60; // ecx
            uint v61; // edx
            uint v62; // ecx
            uint v63; // edx
            uint v64; // ebp
            uint v65; // ecx
            uint v66; // edx
            uint v67; // ecx
            uint v68; // edx
            uint v69; // ecx
            uint v70; // edx
            uint v71; // ecx
            uint v72; // edx
            uint v73; // ecx
            uint v74; // edx
            uint v75; // ecx
            uint v76; // edx
            int newSize_p3_1; // [esp+0h] [ebp-8h]
            int newSize_1; // [esp+4h] [ebp-4h]
            uint sizea; // [esp+18h] [ebp+10h]

            newSize = size;
            if ((size % 8) > 0)
                newSize = size - size % 8 + 8;
            newSize_1 = newSize;
            newSize_p3 = newSize >> 3;

            uint i = 0;

            if (newSize >> 3 > 0)
            {
                newSize_p3_1 = newSize_p3;
                do
                {
                    currentCharacter = src[i];
                    key_p3 = key[2];
                    n1 = src[i + 1] - ((key_p3 - 957401312) ^ (currentCharacter + (16 * src[i] ^ (currentCharacter >> 5))));
                    n2 = key[3] + 683130215;
                    n3 = currentCharacter - (n2 ^ (n1 + (16 * n1 ^ (n1 >> 5))));
                    n4 = n1 - (n2 ^ (n3 + (16 * n3 ^ (n3 >> 5))));
                    key_p1 = key[0];
                    n5 = n3 - ((key_p3 - 1971305554) ^ (n4 + (16 * n4 ^ (n4 >> 5))));
                    n6 = n4 - ((key[0] - 1971305554) ^ (n5 + (16 * n5 ^ (n5 >> 5))));
                    key_p2 = key[1];
                    n7 = n5 - ((key_p2 - 330774027) ^ (n6 + (16 * n6 ^ (n6 >> 5))));
                    n8 = n6 - ((key_p2 - 330774027) ^ (n7 + (16 * n7 ^ (n7 >> 5))));
                    n9 = n7 - ((key[0] + 1309757500) ^ (n8 + (16 * n8 ^ (n8 >> 5))));
                    n10 = n8 - ((key_p3 + 1309757500) ^ (n9 + (16 * n9 ^ (n9 >> 5))));
                    n11 = n9 - ((key[3] - 1344678269) ^ (n10 + (16 * n10 ^ (n10 >> 5))));
                    v23 = n10 - ((key_p3 - 1344678269) ^ (n11 + (16 * n11 ^ (n11 >> 5))));
                    v24 = n11 - ((key_p3 + 295853258) ^ (v23 + (16 * v23 ^ (v23 >> 5))));
                    v25 = v23 - ((key[3] + 295853258) ^ (v24 + (16 * v24 ^ (v24 >> 5))));
                    v26 = v24 - ((key_p2 + 1936384785) ^ (v25 + (16 * v25 ^ (v25 >> 5))));
                    v27 = v25 - ((key[0] + 1936384785) ^ (v26 + (16 * v26 ^ (v26 >> 5))));
                    v28 = v26 - ((key[0] - 718050984) ^ (v27 + (16 * v27 ^ (v27 >> 5))));
                    v29 = v27 - ((key_p2 - 718050984) ^ (v28 + (16 * v28 ^ (v28 >> 5))));
                    v30 = v28 - ((key[3] + 922480543) ^ (v29 + (16 * v29 ^ (v29 >> 5))));
                    v31 = v29 - ((key_p2 + 922480543) ^ (v30 + (16 * v30 ^ (v30 >> 5))));
                    v32 = v30 - ((key_p3 - 1731955226) ^ (v31 + (16 * v31 ^ (v31 >> 5))));
                    v33 = v31 - ((key_p3 - 1731955226) ^ (v32 + (16 * v32 ^ (v32 >> 5))));
                    v34 = v32 - ((key_p2 - 91423699) ^ (v33 + (16 * v33 ^ (v33 >> 5))));
                    v35 = v33 - ((key[3] - 91423699) ^ (v34 + (16 * v34 ^ (v34 >> 5))));
                    v36 = v34 - ((key[0] + 1549107828) ^ (v35 + (16 * v35 ^ (v35 >> 5))));
                    v37 = v35 - ((key[0] + 1549107828) ^ (v36 + (16 * v36 ^ (v36 >> 5))));
                    v38 = v36 - ((key[3] - 1105327941) ^ (v37 + (16 * v37 ^ (v37 >> 5))));
                    v39 = v37 - ((key_p2 - 1105327941) ^ (v38 + (16 * v38 ^ (v38 >> 5))));
                    v40 = v38 - ((key_p3 + 535203586) ^ (v39 + (16 * v39 ^ (v39 >> 5))));
                    v41 = v39 - ((key_p2 + 535203586) ^ (v40 + (16 * v40 ^ (v40 >> 5))));
                    v42 = v40 - ((key_p2 - 2119232183) ^ (v41 + (16 * v41 ^ (v41 >> 5))));
                    v43 = v41 - ((key_p3 - 2119232183) ^ (v42 + (16 * v42 ^ (v42 >> 5))));
                    v44 = v42 - ((key[0] - 478700656) ^ (v43 + (16 * v43 ^ (v43 >> 5))));
                    v45 = v43 - ((key[3] - 478700656) ^ (v44 + (16 * v44 ^ (v44 >> 5))));
                    v46 = v44 - ((key[3] + 1161830871) ^ (v45 + (16 * v45 ^ (v45 >> 5))));
                    v47 = v45 - ((key[0] + 1161830871) ^ (v46 + (16 * v46 ^ (v46 >> 5))));
                    v48 = v46 - ((key_p3 - 1492604898) ^ (v47 + (16 * v47 ^ (v47 >> 5))));
                    v49 = v47 - ((key_p2 - 1492604898) ^ (v48 + (16 * v48 ^ (v48 >> 5))));
                    v50 = v48 - ((key_p2 + 147926629) ^ (v49 + (16 * v49 ^ (v49 >> 5))));
                    v51 = v49 - ((key_p2 + 147926629) ^ (v50 + (16 * v50 ^ (v50 >> 5))));
                    v52 = v50 - ((key[0] + 1788458156) ^ (v51 + (16 * v51 ^ (v51 >> 5))));
                    v53 = v51 - ((key_p3 + 1788458156) ^ (v52 + (16 * v52 ^ (v52 >> 5))));
                    sizea = key[3] - 865977613;
                    v54 = v52 - (sizea ^ (v53 + (16 * v53 ^ (v53 >> 5))));
                    v55 = v53 - (sizea ^ (v54 + (16 * v54 ^ (v54 >> 5))));
                    v56 = v54 - ((key_p3 + 774553914) ^ (v55 + (16 * v55 ^ (v55 >> 5))));
                    v57 = v55 - ((key[0] + 774553914) ^ (v56 + (16 * v56 ^ (v56 >> 5))));
                    v58 = v56 - ((key_p2 - 1879881855) ^ (v57 + (16 * v57 ^ (v57 >> 5))));
                    v59 = v57 - ((key[0] - 1879881855) ^ (v58 + (16 * v58 ^ (v58 >> 5))));
                    v60 = v58 - ((key[0] - 239350328) ^ (v59 + (16 * v59 ^ (v59 >> 5))));
                    v61 = v59 - ((key_p2 - 239350328) ^ (v60 + (16 * v60 ^ (v60 >> 5))));
                    v62 = v60 - ((key[3] + 1401181199) ^ (v61 + (16 * v61 ^ (v61 >> 5))));
                    v63 = v61 - ((key_p3 + 1401181199) ^ (v62 + (16 * v62 ^ (v62 >> 5))));
                    v64 = key_p3 - 1253254570;
                    key_p3 += 1013904242;
                    v65 = v62 - (v64 ^ (v63 + (16 * v63 ^ (v63 >> 5))));
                    v66 = v63 - ((key[3] - 1253254570) ^ (v65 + (16 * v65 ^ (v65 >> 5))));
                    v67 = v65 - ((key_p2 + 387276957) ^ (v66 + (16 * v66 ^ (v66 >> 5))));
                    v68 = v66 - ((key[0] + 387276957) ^ (v67 + (16 * v67 ^ (v67 >> 5))));
                    v69 = v67 - ((key[0] + 2027808484) ^ (v68 + (16 * v68 ^ (v68 >> 5))));
                    v70 = v68 - ((key[0] + 2027808484) ^ (v69 + (16 * v69 ^ (v69 >> 5))));
                    v71 = v69 - ((key[3] - 626627285) ^ (v70 + (16 * v70 ^ (v70 >> 5))));
                    v72 = v70 - ((key_p2 - 626627285) ^ (v71 + (16 * v71 ^ (v71 >> 5))));
                    v73 = v71 - (key_p3 ^ (v72 + (16 * v72 ^ (v72 >> 5))));
                    v74 = v72 - (key_p3 ^ (v73 + (16 * v73 ^ (v73 >> 5))));
                    v75 = v73 - ((key_p2 - 1640531527) ^ (v74 + (16 * v74 ^ (v74 >> 5))));
                    v76 = v74 - ((key[3] - 1640531527) ^ (v75 + (16 * v75 ^ (v75 >> 5))));
                    dest[i] = v75 - (key_p1 ^ (v76 + (16 * v76 ^ (v76 >> 5))));
                    dest[i + 1] = v76;

                    i += 2;
                    --newSize_p3_1;
                }
                while (newSize_p3_1 > 0);
                newSize = newSize_1;
            }
            return newSize;
        }
        #endregion

        public static uint[] ToUintArray(byte[] input)
        {
            List<uint> array = new List<uint>();

            int cb = 0;
            byte[] n = new byte[4];

            for (int i = 0; i < input.Length; i++)
            {
                n[cb] = input[i];

                if (cb == 3)
                {
                    array.Add(BitConverter.ToUInt32(n, 0));

                    cb = 0;

                    n[0] = 0;
                    n[1] = 0;
                    n[2] = 0;
                    n[3] = 0;
                }
                else
                    cb++;
            }

            if (cb != 0)
            {
                array.Add(BitConverter.ToUInt32(n, 0));
            }

            return array.ToArray();
        }

        public static byte[] ToByteArray(uint[] input)
        {
            List<byte> array = new List<byte>();

            for (int i = 0; i < input.Length; i++)
            {
                array.AddRange(BitConverter.GetBytes(input[i]));
            }

            return array.ToArray();
        }

        public static byte[] Encrypt(byte[] data, uint[] key)
        {
            uint[] dest = new uint[data.Length];
            var newData = ToUintArray(data);
            TEACrypt(dest, newData, key, data.Length);
            return ToByteArray(dest);
        }

        public static byte[] Decrypt(byte[] data, uint[] key)
        {
            uint[] dest = new uint[data.Length];
            var newData = ToUintArray(data);
            TEADecrypt(dest, newData, key, data.Length);
            return ToByteArray(dest);
        }

    }
}
