using System;
using Xunit;

namespace FizFuzProj.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Execute_Expect1_when1()
        {
            var fizfuzz = new FizFuz();
            string result = fizfuzz.Execute(1);
            Assert.Equal("1", result);
        }
        [Fact]
        public void Execute_Expect12_when2()
        {
            var fizfuzz = new FizFuz();
            string result = fizfuzz.Execute(2);
            Assert.Equal("1,2", result);
        }
        [Fact]
        public void Execute_Expect12Fiz_when3()
        {
            var fizfuzz = new FizFuz();
            string result = fizfuzz.Execute(3);
            Assert.Equal("1,2,Fiz", result);
        }
        [Fact]
        public void Execute_Expect12Fiz4_when4()
        {
            var fizfuzz = new FizFuz();
            string result = fizfuzz.Execute(4);
            Assert.Equal("1,2,Fiz,4", result);
        }
        [Fact]
        public void Execute_Expect12Fiz4Fuz_when5()
        {
            var fizfuzz = new FizFuz();
            string result = fizfuzz.Execute(5);
            Assert.Equal("1,2,Fiz,4,Fuz", result);
        }
        [Fact]
        public void Execute_Expect12Fiz4FuzFiz_when6()
        {
            var fizfuzz = new FizFuz();
            string result = fizfuzz.Execute(6);
            Assert.Equal("1,2,Fiz,4,Fuz,Fiz", result);
        }
        [Fact]
        public void Execute_Expect12Fiz4FuzFiz_when10()
        {
            var fizfuzz = new FizFuz();
            string result = fizfuzz.Execute(10);
            Assert.Equal("1,2,Fiz,4,Fuz,Fiz,7,8,Fiz,Fuz", result);
        }
        [Fact]
        public void Execute_Expect12Fiz4FuzFiz_when15()
        {
            var fizfuzz = new FizFuz();
            string result = fizfuzz.Execute(15);
            Assert.Equal("1,2,Fiz,4,Fuz,Fiz,7,8,Fiz,Fuz,11,Fiz,13,14,FizFuz", result);
        }
        [Fact]
        public void Execute_Expect12Fiz4FuzFiz_when30()
        {
            var fizfuzz = new FizFuz();
            string result = fizfuzz.Execute(30);
            Assert.Equal("1,2,Fiz,4,Fuz,Fiz,7,8,Fiz,Fuz,11,Fiz,13,14,FizFuz,16,17,Fiz,19,Fuz,Fiz,22,23,Fiz,Fuz,26,Fiz,28,29,FizFuz", result);
        }
    }
}
