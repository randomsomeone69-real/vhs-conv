/* Rôle : convertit un nombre de minutes finies en heures : minutes.
H : heure, M : minutes
conv_TRT : convert Total Running Time, yes. */

using Microsoft.VisualBasic;

(int, int) conv_trt(int Min)
{
    int H, M;
    H = Min / 60;
    M = Min % 60;
    return (H,M);
}

int valueVHS;
Console.WriteLine("Please indicate the value of minutes indicated on your VHS tape.");
valueVHS = Convert.ToInt16(Console.ReadLine()); //32 bits est inutile puisque les valeurs des cassettes ne sont jamais longues.
(int H, int M) = conv_trt(valueVHS);
Console.WriteLine($"The tape lasts {H}:{M:D2} of contiguous time.");