using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson2 {
	class Program {

		//creating the Add method with 2 integers
		static int Add(int nbr, int inc) {
			return nbr + inc;
		}

		//creating the Add method that takes an int number, adds 1 to it, and then returns the new number
		//okay to be called "Add" because this "Add" has different parameters than the "Add" method above
		static int Add(int nbr) {
			return nbr + 1;
		}

		//creating the Add1 method that takes an int number, adds 1 to it, and then returns the new number
		static int Add1(int nbr) {
			return nbr + 1;
			//return ++nbr; //can also use this to return the same number
			//return Add(nbr,1); //uses the Add method above to add 1 so this also works
		}

		static void Main(string[] args) {

			//BEGIN CALLING OF Add1 METHOD
			int nbr = 12;
			int result = Add1(nbr);
			Console.WriteLine("{0} Add1 is {1}", nbr, result);
			//END Add1 METHOD


			//BEGIN CALLING OF Add METHOD
			int addnbr1 = 12;
			int addnbr2 = 3;
			int resultaddnbr = Add(addnbr1, addnbr2);
			Console.WriteLine("{0} plus {1} is {2}", addnbr1, addnbr2, resultaddnbr);
			//END Add METHOD
		}

		static void Test() {
			//nbr = 13; //this statement won't work b/c scope for the "int nbr" above in the Main method doesn't extend to this method
		}
	}
}
