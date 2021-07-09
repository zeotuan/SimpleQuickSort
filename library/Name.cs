using System;
using System.Linq;

namespace library
{
    ///<summary>
    /// Main name Class 
    /// Wrapper class for Name input
    ///</summary>
    public class Name: IComparable<Name>
    {
        private string lastName;
        private string givenName;

        ///<summary>
        /// Constructor for Name Class 
        /// Take a String input 
        /// split raw string input then initialize lastName and givenName
        ///</summary>
        /// <exception cref="System.ArgumentException">Thrown when string input is null 
        /// or when string input contain onlt whitespace
        ///</exception>
        public Name(string Name)
        {
            if(!string.IsNullOrWhiteSpace(Name)){
                string[] words = Name.Trim().Split();
                this.lastName = words[words.Length-1];
                this.givenName = string.Join(" ", words.Take(words.Length-1));  
            }else{
                throw new ArgumentException("Name cannot be null or empty string", "value");
            }
                       
        }

        ///<summary>
        /// Compare function of Name Class
        /// Compare calling Name object with other Name object
        /// Compare By firstName then by Given Name
        ///</summary>
        /// <returns>
        /// return an integer 
        /// result < 0 if calling Name object is lesser than other Name object 
        /// result == 0 if calling Name object is equal to other Name object
        /// result > 0 of cakkubg Bane ivhect us greater than other Name object
        /// </returns>
        /// <example>
        /// <code>
        /// Name name1 = New Name("John Mayer");
        /// Name name2 = New Name("Matt Bellamy");
        /// result = name1.compareTo(name2)
        /// Console.WriteLine(result);
        /// </code>
        /// </example>
        public int CompareTo(Name other)
        {
            if(String.IsNullOrEmpty(other.LastName)){
                return 1;
            }
            int lastNameResult = String.Compare(this.LastName.ToLower(), other.LastName.ToLower(), StringComparison.Ordinal);
            if(lastNameResult == 0){
                return String.Compare(this.GivenName.ToLower(), other.GivenName.ToLower(), StringComparison.Ordinal);
            }
            return lastNameResult;
        }

        /// <value>Gets the value of firstName.</value>
        ///<exampple>
        /// <code>
        /// Name name1 = New Name("John Mayer");
        /// Console.WriteLine(name.LastName); 
        ///</code>
        ///</exampple>
        public string LastName
        {
            get { return lastName; }
        }

        /// <value>Gets the value of givenName.</value>
        ///<exampple>
        /// <code>
        /// Name name1 = New Name("John Mayer");
        /// Console.WriteLine(name1.GivenName); 
        ///</code>
        ///</exampple>
        public string GivenName
        {   
            get { return givenName; }
        }

        ///<summary>
        /// Override default ToString Method
        ///</summary>
        /// <returns>
        /// return fullname of Name object
        /// </returns>
        ///<exampple>
        /// <code>
        /// Name name1 = New Name("John Mayer");
        /// Console.WriteLine(name1.ToString()); 
        ///</code>
        ///</exampple>
        public override string ToString()
        {
            return this.givenName + " " + this.lastName;
        }

        // public static bool operator > (Name operand1, Name operand2){
        //     return operand1.CompareTo(operand2) > 0;
        // }

        // public static bool operator < (Name operand1, Name operand2){
        //     return operand1.CompareTo(operand2) < 0;
        // }

        //  public static bool operator <= (Name operand1, Name operand2){
        //     return operand1.CompareTo(operand2) <= 0;
        // }

        //  public static bool operator >= (Name operand1, Name operand2){
        //     return operand1.CompareTo(operand2) >= 0;
        // }
    }
}