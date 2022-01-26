public static string yAxis = "hw.dll+006E92AC,90";


[DllImport("User32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern short GetAsyncKeyState(int vKey);


int yAxisUP;

        int yAxisDOWN;

        private void FlyHack_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(Keys.E) < 0)
            {
                float oldValue = m.ReadFloat(yAxis);
                m.WriteMemory(yAxis, "float", yUp.Text);
                yAxisUP += 2;
                yUp.Text = yAxisUP.ToString();
            }
            else if (GetAsyncKeyState(Keys.Q) < 0)
            {
                yAxisUP = 36;
            }
        }