using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class Program
    {
        public class quentry
            {
            public int v;
            public int dist;
            }
        static int getMinDiceTrows(int []move,int n)
        {
            int []visited=new int[n];
            Queue<quentry>q=new Queue<quentry>();
            quentry qe =new quentry();
            qe.v=0;
            qe.dist=0;
            visited[0] = 1;
            q.Enqueue(qe);
            while(q.Count != 0)
            {
                qe=q.Dequeue();
                int v =qe.v;
                if (v == n - 1)
                    break;
                for(int j=v+1;j<=(v+6)&&j<n;++j)
                {
                    if (visited[j]==0)
                    {
                        quentry a=new quentry();
                        a.dist = (qe.dist + 1);
                        visited[j] = 1;
                        if (move[j] != -1)
                            a.v = move[j];
                        else
                            a.v = j;
                        q.Enqueue(a);


                    }
                }
            }
            return qe.dist;
        }
       
        static void Main(string[] args)
        {
            int N = 30;
            int []moves=new int[N];
            for(int i=0;i<N;i++)
            {
                moves[i] = -1;
                moves[2] = 21;
                moves[4] = 7;
                moves[10] = 25;
                moves[19] = 28;

                moves[26] = 0;
                moves[20] = 8;
                moves[16] = 3;
                moves[18] = 6;
                Console.WriteLine("Min Dice throws required is"+getMinDiceTrows(moves,N));
            }
            Console.ReadLine();
        }
    }
}
