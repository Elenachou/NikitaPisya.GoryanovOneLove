using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MieCalc
{
    public class Calculator
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        ///

        public Complex RoundComplex(Complex number)
        {
            double real, img;

            //CReal:= StrToFloat(FloatToStrF(Real(CMPLX), ffFixed, 5, 5));
            //CImg:= StrToFloat(FloatToStrF(Real(VarCmplx.VarComplexTimesNegI(CMPLX)), ffExponent, 5, 5));
            real = Double.Parse(number.Real.ToString("00000.00000"));
            img = Double.Parse((number.Imaginary * 1).ToString("00000.00000"));
            return new Complex(real, img);
        }
        public Complex Interpolate(double Lam, List<double> MLambda, List<double> MN1, List<double> MN2)
        {
            int k, x;
            Complex Result = new Complex(0, 0);

            x = MLambda.Count;
            for (k = 0; k <= x - 1; k++)
            {
                if (Lam == MLambda[k])
                {
                    Result = new Complex(MN1[k], MN2[k]);
                    break;
                }
                else
                    if ((Lam > MLambda[k]) && (Lam < MLambda[k + 1]))
                {
                    Result = new Complex((Lam - MLambda[k]) / (MLambda[k + 1] - MLambda[k]) *
                                 (MN1[k + 1] - MN1[k]) + MN1[k],
                                 (Lam - MLambda[k]) / (MLambda[k + 1] - MLambda[k]) *
                                 (MN2[k + 1] - MN2[k]) + MN2[k]);
                    break;
                }
            }
            return Result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Complex AerIndex(InitialData id, double Lam, int j)
        {
            double S, Growth;
            Complex Result = new Complex(0, 0);

            S = id.RelativeHumidity / 100;
            switch (j)
            {
                case 0: // Пыль
                    Result = Interpolate(Lam, id.Dust.MLambda, id.Dust.MN1, id.Dust.MN2);
                    break;
                case 1:
                    Growth = (1 - S) / (1 - (S / InitialData.A2));
                    Result = Interpolate(Lam, id.Water.MLambda, id.Water.MN1, id.Water.MN2) +
                            (Interpolate(Lam, id.B1.MLambda, id.B1.MN1, id.B1.MN2) -
                            Interpolate(Lam, id.Water.MLambda, id.Water.MN1, id.Water.MN2)) * Growth;
                    break;
                case 2:
                    Growth = (1 - S) / (1 - (S / InitialData.A3));
                    Result = Interpolate(Lam, id.Water.MLambda, id.Water.MN1, id.Water.MN2) +
                    (Interpolate(Lam, id.SeaSalt.MLambda, id.SeaSalt.MN1, id.SeaSalt.MN2) -
                    Interpolate(Lam, id.Water.MLambda, id.Water.MN1, id.Water.MN2)) * Growth;
                    break;
                case 3:
                    Growth = (1 - S) / (1 - (S / InitialData.A4));
                    Result = Interpolate(Lam, id.Water.MLambda, id.Water.MN1, id.Water.MN2) +
                    (Interpolate(Lam, id.SeaSalt.MLambda, id.SeaSalt.MN1, id.SeaSalt.MN2) -
                    Interpolate(Lam, id.Water.MLambda, id.Water.MN1, id.Water.MN2)) * Growth;
                    break;
            }
            return Result;
        }
        
        public void Mie(InitialData id, ResultData rd, double X, Complex REFREL, int DiscretsCount)
        {
            double DX, P, T, DANG, YMOD, NSTOP, XSTOP,
                    PSI0, PSI1, CHI0, CHI1, APSI0, APSI1,
                    MQSCA = 0, MQEXT = 0, FN, PSI, APSI, CHI;
            double[] TAU = new double[100];
            double[] THETA = new double[100];
            double[] AMU = new double[100];
            double[] PI = new double[100];
            double[] PI0 = new double[100];
            double[] PI1 = new double[100];
            Complex[] D = new Complex[3000];
            Complex XI, XI0, XI1, Y, AN, BN;
            int NMX, NN, J, JJ, DN, RN, N;

            DX = X;
            Y = X * REFREL;
            XSTOP = X + 4 * Math.Pow(X, 1/3) + 2; //xxx
            //XSTOP = 20.187274058;
            NSTOP = XSTOP;
            YMOD = Math.Abs(Y.Real); // xxx
            NMX = (int) Math.Round(Math.Max(XSTOP, YMOD) + 15);
            DANG = 1.570796327 / (id.DiscretsCount - 1);
            for (J = 1; J <= id.DiscretsCount; J++)
            {
                THETA[J] = (J - 1) * DANG;
                AMU[J] = Math.Cos(THETA[J]);
            }
            D[NMX] = new Complex(0, 0);
            NN = NMX-1;
            for (N = 1; N <= NN; N++)
            {
                RN = NMX - N + 1;
                D[NMX - N] = (RN / Y) - (1 / (D[NMX - N + 1] + RN / Y)); // XXX
            }
            for (J = 1; J <= id.DiscretsCount; J++)
            {
                PI0[J] = 0;
                PI1[J] = 1;
            }
            NN = 2 * id.DiscretsCount - 1;
            for (J = 1; J <= NN; J++)
            {
                rd.S1[J] = new Complex(0, 0);
                rd.S2[J] = new Complex(0, 0);
            }
            PSI0 = Math.Cos(DX);
            PSI1 = Math.Sin(DX);
            CHI0 = -Math.Sin(X);
            CHI1 = Math.Cos(X);
            APSI0 = PSI0;
            APSI1 = PSI1;
            XI0 = new Complex(APSI0, -CHI0);
            XI1 = new Complex(APSI1, -CHI1);
            rd.QSCA = 0;
            N = 1;
            do
            {
                DN = N;
                RN = N;
                FN = (2 * RN + 1) / (RN * (RN + 1));
                PSI = (2 * DN - 1) * PSI1 / DX - PSI0;
                APSI = PSI;
                CHI = (2 * RN - 1) * CHI1 / X - CHI0;
                XI = new Complex(APSI, -CHI);
                AN = (D[N] / REFREL + RN / X) * APSI - APSI1;
                AN = AN / ((D[N] / REFREL + RN / X) * XI - XI1);
                BN = (REFREL * D[N] + RN / X) * APSI - APSI1;
                BN = BN / ((REFREL * D[N] + RN / X) * XI - XI1);
                MQSCA = MQSCA + (2 * RN + 1) * (Math.Abs(AN.Real) * Math.Abs(AN.Real) +
                                            Math.Abs(BN.Real) * Math.Abs(BN.Real));
                MQEXT = MQEXT + (2 * RN + 1) * (AN.Real + BN.Real);
                for (J = 1; J <= id.DiscretsCount; J++)
                {
                    JJ = 2 * id.DiscretsCount - J;
                    PI[J] = PI1[J];
                    TAU[J] = RN * AMU[J] * PI[J] - (RN + 1) * PI0[J];
                    P = Math.Pow(-1, N - 1);
                    rd.S1[J] = rd.S1[J] + FN * (AN * PI[J] + BN * TAU[J]);
                    T = Math.Pow(-1, N);
                    rd.S2[J] = rd.S2[J] + FN * (AN * TAU[J] + BN * PI[J]);
                    if (J == JJ)
                        break;
                    rd.S1[JJ] = rd.S1[JJ] + FN * (AN * PI[J] * P + BN * TAU[J] * T);
                    rd.S2[JJ] = rd.S2[JJ] + FN * (AN * TAU[J] * T + BN * PI[J] * P);
                }
                PSI0 = PSI1;
                PSI1 = PSI;
                APSI1 = PSI1;
                CHI0 = CHI1;
                CHI1 = CHI;
                XI1 = new Complex(APSI1, -CHI1);
                N = N + 1;
                RN = N;
                for (J = 1; J <= id.DiscretsCount; J++)
                {
                    PI1[J] = ((2 * RN - 1) / (RN - 1)) * AMU[J] * PI[J];
                    PI1[J] = PI1[J] - RN * PI0[J] / (RN - 1);
                    PI0[J] = PI[J];
                }
            } while ((N - 1 - NSTOP) > 0);
            rd.QSCA = (2 / (X * X)) * MQSCA;
            rd.QEXT = (4 / (X * X)) * rd.S1[1].Real;
            rd.QABS = rd.QEXT - rd.QSCA;
            rd.CSCA = (Math.Sqrt(id.WaveLength) / (2 * 3.14)) * MQSCA;
            rd.CEXT = (Math.Sqrt(id.WaveLength) / (2 * 3.14)) * MQEXT;
            rd.CABS = rd.CEXT - rd.CSCA;
        }

        public void SaveResInArrays(InitialData id, ResultData rd, int I, double WL)
        {
            rd.OptI[I] = AerIndex(id, WL, I).ToString();
            rd.SCA[I] = rd.QSCA.ToString();
            //ffFixed, 4, 4);
            rd.EXT[I] = rd.QEXT.ToString();
            rd.ABS[I] = rd.QABS.ToString();
        }
        public void FillStringGrid(InitialData id, ResultData rd, int numGrid, int typeRas)
        {
            double DANG, S11NOR, S11, S12, S11r, POL, S33, S34, ANG;
            int NAN, AJ, J;
            
            // XXX NANG -> DiscretsCount
            Mie(id, rd, id.X, AerIndex(id, id.WaveLength, typeRas), id.DiscretsCount);
            DANG = 1.570796327 / (id.DiscretsCount - 1);
            S11NOR = 0.5 * (Math.Sqrt(Math.Abs(rd.S2[1].Real)) + Math.Sqrt(Math.Abs(rd.S1[1].Real)));
            NAN = 2 * id.DiscretsCount - 1;
            for (J = 1; J <= NAN; J++) {
                AJ = J;
                S11 = 0.5 * Math.Sqrt(Math.Abs(rd.S2[J].Real));
                S11 = S11 + 0.5 * Math.Sqrt(Math.Abs(rd.S1[J].Real));
                S12 = 0.5 * Math.Sqrt(Math.Abs(rd.S2[J].Real));
                S12 = S12 - 0.5 * Math.Sqrt(Math.Abs(rd.S1[J].Real));
                POL = -S12 / S11;
                S33 = (rd.S2[J] * (Complex.Conjugate(rd.S1[J]))).Real;
                S33 = S33 / S11;
                //S34 = (Complex.Negate(rd.S2[J]) * Complex.Conjugate(rd.S1[J])).Real;
                S34 = (new Complex(rd.S2[J].Imaginary * -1, rd.S2[J].Real * -1) * Complex.Conjugate(rd.S1[J])).Real;
                S34 = S34 / S11;
                S11 = S11 / S11NOR;
                ANG = DANG * (AJ - 1) * 57.2958;
//                if (Program.mf.GetInitialDataControl().)
                    S11r = S11 + S12;
                  //else
//                    S11r = S11 - S12;
                Program.mf.FillStringGrid(numGrid, J-1, ANG, S11r, S11, S33, S34);
                /*
                with Form1 do begin
                  Grid.Cells[0, J] := FloatToStrF(ANG, ffFixed, 3, 0);
                    if RadioParPol.Checked then
                    Grid.Cells[1, J] := FloatToStrF(S11 + S12, ffFixed, 6, 6)
                    else
                    Grid.Cells[1, J] := FloatToStrF(S11 - S12, ffFixed, 6, 6);
                Grid.Cells[2, J] := FloatToStrF(S11, ffFixed, 6, 6);
                Grid.Cells[3, J] := FloatToStrF(S33, ffFixed, 6, 6);
                Grid.Cells[4, J] := FloatToStrF(S34, ffFixed, 6, 6);
                Grid.RowCount := J + 1;
                i1:= (sqr(s1r ^[j]) + sqr(s1i ^[j]));
                i2:= (sqr(s2r ^[j]) + sqr(s2i ^[j]));
                i0:= i1 + i2;
                inten:= 0.5 * i0;
                */
            }
        }
        // Rnum -> Steps
        // Rstep -> Step
        public ResultData Calculate(InitialData id)
        {
            int i;
            double R, X;
            ResultData rd = new ResultData();


            FillStringGrid(id, rd, 1, 0);
            SaveResInArrays(id, rd, 0, id.WaveLength);
            FillStringGrid(id, rd, 2, 1);
            SaveResInArrays(id, rd, 1, id.WaveLength);
            FillStringGrid(id, rd, 3, 2);
            SaveResInArrays(id, rd, 2, id.WaveLength);
            FillStringGrid(id, rd, 4, 3);
            SaveResInArrays(id, rd, 3, id.WaveLength);
            // Set grid5.rowcount = Steps + 1
            //QCalcs
            //StringGrid5.RowCount := Steps + 1;
            R = id.RangeMin;
            for (i = 0; i <= id.Steps; i++)
            {

                X = 2 * Math.PI * R * InitialData.RefMed / id.WaveLength;
                Mie(id, rd, X, AerIndex(id, id.WaveLength, 0), 2);

                R = R + id.Step;
            }
            // StringGrid6.RowCount := Steps + 1;
            R = id.RangeMin;
            for (i = 0; i <= id.Steps; i++)
            {

                X = 2 * Math.PI * R * InitialData.RefMed / id.WaveLength;
                Mie(id, rd, X, AerIndex(id, id.WaveLength, 1), 2);

                R = R + id.Step;
            }
            //StringGrid7.RowCount := Steps + 1;
            R = id.RangeMin;
            for (i = 0; i <= id.Steps; i++)
            {

                X = 2 * Math.PI * R * InitialData.RefMed / id.WaveLength;
                Mie(id, rd, X, AerIndex(id, id.WaveLength, 2), 2);

                R = R + id.Step;
            }
            //StringGrid8.RowCount := Steps + 1;
            R = id.RangeMin;
            for (i = 0; i <= id.Steps; i++)
            {
                X = 2 * Math.PI * R * InitialData.RefMed / id.WaveLength;
                Mie(id, rd, X, AerIndex(id, id.WaveLength, 3), 2);

                R = R + id.Step;
            }
            //CCalcs
            //StringGrid9.RowCount := Steps + 1;
            
            R = id.RangeMin;
            for (i = 0; i <= id.Steps; i++)
            {
                X = 2 * Math.PI * R * InitialData.RefMed / id.WaveLength;
                Mie(id, rd, X, AerIndex(id, id.WaveLength, 0), 2);

                R = R + id.Step;
            }
            //StringGrid10.RowCount := Steps + 1;
            R = id.RangeMin;
            for (i = 0; i <= id.Steps; i++)
            {
                X = 2 * Math.PI * R * InitialData.RefMed / id.WaveLength;
                Mie(id, rd, X, AerIndex(id, id.WaveLength, 1), 2);

                R = R + id.Step;
            }
            //StringGrid11.RowCount := Steps + 1;
            R = id.RangeMin;
            for (i = 0; i <= id.Steps; i++) {
                X = 2 * Math.PI * R * InitialData.RefMed / id.WaveLength;
                Mie(id, rd, X, AerIndex(id, id.WaveLength, 2), 2);

                R = R + id.Step;
            }
            //StringGrid12.RowCount := Steps + 1;
            R = id.RangeMin;
            for (i = 0; i <= id.Steps; i++) {
                X = 2 * Math.PI * R * InitialData.RefMed / id.WaveLength;
                Mie(id, rd, X, AerIndex(id, id.WaveLength, 3), 2);

                R = R + id.Step;
            }
            
            //return rd;

            return new ResultData()
            {
                DiffractionParameter = 2 * Math.PI * id.RangeMin / id.WaveLength
            };
        }
    }
}
