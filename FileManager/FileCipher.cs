// *
// * ******** TQ File Manager - Open Source ********
// * Copyright (C) 2015 Jean-Philippe Boivin
// *
// * Please read the WARNING, DISCLAIMER and PATENTS
// * sections in the LICENSE file.
// *

using System;

namespace FileManager.Security.Cryptography
{
    /// <summary>
    /// TQ Digital's Asymmetric File Cipher
    /// </summary>
    public class FileCipher
    {
        /// <summary>
        /// The key size in bytes.
        /// </summary>
        private const int KEY_SIZE = 128;

        /// <summary>
        /// The pseudo-random key used to XOR the data.
        /// </summary>
        private Byte[] mKey = new Byte[KEY_SIZE];

        /// <summary>
        /// Create a new file cipher instance. The key will be generated
        /// using the seed for a pseudo-random number generator.
        /// </summary>
        public FileCipher(UInt32 aSeed)
        {
            // Basically, calling srand() with the seed, which will set the
            // global seed value (which is 1 otherwise). Than, successivly
            // calling rand() to generate a new value for the key.
            for (int i = 0; i < KEY_SIZE; ++i)
            {
                // This is the Microsoft's implementation of rand() since NT 2.0 and probably before.
                Int32 value = (Int32)(((aSeed = aSeed * 0x343FD + 0x269EC3) >> 16) & 0x7FFF);

                mKey[i] = (Byte)(value % 0x100);
            }
        }

        /// <summary>
        /// Encrypts data with the algorithm.
        /// </summary>
        public void Encrypt(ref Byte[] aBuf, int aLength)
        {
            for (int i = 0; i < aLength; ++i)
            {
                Int32 tmp = (Byte)((aBuf[i] >> (8 - (i % 8))) + (aBuf[i] << (i % 8)));
                aBuf[i] = (Byte)(tmp ^ mKey[i % KEY_SIZE]);
            }
        }

        /// <summary>
        /// Decrypts data with the algorithm.
        /// </summary>
        public void Decrypt(ref Byte[] aBuf, int aLength)
        {
            for (int i = 0; i < aLength; ++i)
            {
                Int32 tmp = aBuf[i] ^ mKey[i % KEY_SIZE];
                aBuf[i] = (Byte)((tmp << (8 - (i % 8))) + (tmp >> (i % 8)));
            }
        }
    }
}