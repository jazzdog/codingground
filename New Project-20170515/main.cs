using System.IO;
using System;
using JimmyOffice;

namespace JimmyHome
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Hello, World!");
            //MyTool.printSomeText();
            uint nInputN=999999990;
            findeFactor(nInputN);
            
            //驗證
            if(true)
            {
                uint nSolutionCount =0;
                for(uint nStart=1;nStart<(nInputN-1);nStart++)
                {
                    uint nSum =0;
                    for(uint i=nStart;i<(nInputN-1);i++)                
                    {
                        nSum+=i;
                        if(nSum==nInputN)
                        {
                            nSolutionCount++;
                            Console.WriteLine("({3})::[{0}]=>{1}+..+{2}({4})",nInputN,nStart,i,nSolutionCount,(i-nStart+1));
                            break;
                        }
                        else if(nSum>nInputN)
                        {
                            break;
                        }
                    }
                }
            }
            
            
        }
        
        
        static void findeFactor(uint _nNumber)
        {
              uint nTheSolution=0;
              uint nNumber = _nNumber;
              uint nFactor=1;
              uint nTheFactorCount= 1;
              uint nFactors=0;
              for(uint x=2;x<=nNumber;x++)
              {
                   
                    while(nNumber%x==0)
                    {
                       
                        if(x!=2)
                        {
                             if(x!=nFactor)                              
                             {
                                  nFactors++;
                                 if(nTheSolution==0)
                                    nTheSolution=1;
                                //Console.WriteLine("\n@:{0}=>{1} count:{2} [nFactors:{3}]",nFactor,x,nTheFactorCount,nFactors);
                                 nTheSolution*=(nTheFactorCount+1);
                                 nFactor =x;
                                 nTheFactorCount=1;
                             }
                             else
                             {
                                 nTheFactorCount++;
                             }
                        }
                        else
                        {
                            nFactor=x;
                        }
                        
                        Console.Write("{0}*",x);
                        nNumber/=x;
                    }
              } 
              
            if(nTheSolution>1)
                nTheSolution-=1;
            if( nFactors==1) //如果只有自己 5*5 9*9 則要加1
                nTheSolution+=1;
            Console.Write("\n{0}==>Solution: {1} nFactors:{2}\n",_nNumber,nTheSolution,nFactors);
        }
    }
}

