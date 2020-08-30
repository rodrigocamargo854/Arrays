             class Arrays
        {
            
            public double Array1 { get; set; }
            public double Array2 { get; set; }

            public double Array3 { get; set; }

            public string Array4 { get; set; }
            public string Array5 { get; set; }


            public Arrays(double arrayA, double arrayB)
            {
                Array1 = arrayA;
                Array2 = arrayB;
            }
            public Arrays(double arrayA)
            {
                Array1 = arrayA;
            }

            public Arrays(string arrayS, string arrayT)
            {
                Array4 = arrayS;
                Array5 = arrayT;
            }
            public Arrays(string arraystring)
            {
                Array4 = arraystring;

            }

        }