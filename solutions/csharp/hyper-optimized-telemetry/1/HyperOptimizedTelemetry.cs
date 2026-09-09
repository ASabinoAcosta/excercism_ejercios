public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] buffer = new byte[9];

        if (reading >= 0 && reading <= ushort.MaxValue)
        {
            buffer[0] = 2;
            byte[] bytes = BitConverter.GetBytes((ushort)reading);
            Array.Copy(bytes, 0, buffer, 1, 2);
        }
        else if (reading >= 0 && reading <= int.MaxValue)
        {
            buffer[0] = 252;
            byte[] bytes = BitConverter.GetBytes((int)reading);
            Array.Copy(bytes, 0, buffer, 1, 4);
        }
        else if (reading >= 0 && reading <= uint.MaxValue)
        {
            buffer[0] = 4;
            byte[] bytes = BitConverter.GetBytes((uint)reading);
            Array.Copy(bytes, 0, buffer, 1, 4);
        }
        else if (reading >= short.MinValue && reading < 0)
        {
            buffer[0] = 254;
            byte[] bytes = BitConverter.GetBytes((short)reading);
            Array.Copy(bytes, 0, buffer, 1, 2);
        }
        else if (reading >= int.MinValue && reading < short.MinValue)
        {
            buffer[0] = 252;
            byte[] bytes = BitConverter.GetBytes((int)reading);
            Array.Copy(bytes, 0, buffer, 1, 4);
        }
        else
        {
            buffer[0] = 248;
            byte[] bytes = BitConverter.GetBytes(reading);
            Array.Copy(bytes, 0, buffer, 1, 8);
        }

        return buffer;
    }

    public static long FromBuffer(byte[] buffer)
    {
        if (buffer[0] == 2)
        {
            return BitConverter.ToUInt16(buffer, 1);
        }

        if (buffer[0] == 4)
        {
            return BitConverter.ToUInt32(buffer, 1);
        }

        if (buffer[0] == 252)
        {
            return BitConverter.ToInt32(buffer, 1);
        }

        if (buffer[0] == 254)
        {
            return BitConverter.ToInt16(buffer, 1);
        }

        if (buffer[0] == 248)
        {
            return BitConverter.ToInt64(buffer, 1);
        }

        return 0;
    }
}