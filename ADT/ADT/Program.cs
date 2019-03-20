using System;

namespace ADT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Stack st = new Stack();

            // Introduce un element in stiva
            st.Push(1);
            st.Push(2);
            st.Push(3);

            // Elimina un element din stiva
            int v = st.Pop();

            st.Push(4);

            // Intoarce elementul din varful stivei fara a-l elimina
            Console.WriteLine(st.Peek());

            // Intoarce numarul de elemente din stiva
            Console.WriteLine(st.Count);

            // Intoarce numarul maxim de elemente pe care le putem introduce in stiva
            Console.WriteLine(st.Capacity);

            st.Pop();
            st.Pop();

            int value;
            bool result = st.TryPeek(out value);

            st.Pop();

            Console.WriteLine(st.IsEmpty);
            Console.WriteLine(st.IsFull);
            // instructiunea va lansa exceptie
            try
            {
                st.Pop();
            }
            catch (StackEmptyException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

/*
 * Iubirea bug-ului

Un orologiu sună noaptea jumătate,
În birou la ușa… Oare cine bate?
“Eu sunt, drag Developer, bug-ul tău iubit.
Eu, și din production mă întorc grăbit…
Soarta noastră fuse crudă astă dată…
Mă găsiră aștia după Realease, dintr-o dată!
Dar opriți commit-ul, QA-ii mă-nconjor’
De stau în Eclipse forever… sigur n-am să mor!
Love at first sight eu am simțit!
O iubire sweet… încă de la primul commit!”
***
Dar când o astfel de iubire e neîmpărtășită,
Un Software Engineer are o viață liniștită!
Și… după lungi bug fixuri un build a venit,
Chiar de Valentine’s … bug-ul a murit!
 * */
