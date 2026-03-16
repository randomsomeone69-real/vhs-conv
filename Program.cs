using Microsoft.VisualBasic;

(int, int) conv_trt(int Min)
{
    int H, M;
    H = Min / 60;
    M = Min % 60;
    return (H,M);
}

(int H, int M) = conv_trt(90);
Console.WriteLine($"The tape lasts {H}:{M:D2} of contiguous time.");