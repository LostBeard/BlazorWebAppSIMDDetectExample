using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SpawnDev.BlazorJS.WebWorkers;
using System.Diagnostics;

namespace SpawnDev.BlazorJS
{
    public interface IMathsService
    {
        Task<double> TestMultiSigMethod(double value);
        Task<string> TestMultiSigMethod(string value);
        Task<double> TestMultiSigMethod(int value);
        Task<string> TestMultiSigMethod(string value, double dblValue);
        Task<T2> TestGenerics<T1, T2>(T1 value1, T2 value2);
    }

    /// <summary>
    /// This service runs insinde the worker.
    /// </summary>
    public class MathsService : IMathsService
    {
        public MathsService()
        {

        }
        public Task<double> TestMultiSigMethod(double value)
        {
            return Task.FromResult(value);
        }

        public Task<string> TestMultiSigMethod(string value)
        {
            return Task.FromResult(value);
        }

        public Task<double> TestMultiSigMethod(int value)
        {
            return Task.FromResult((double)value);
        }

        public Task<string> TestMultiSigMethod(string value, double dblValue)
        {
            return Task.FromResult(value + " " + dblValue);
        }

        public Task<T2> TestGenerics<T1, T2>(T1 value1, T2 value2)
        {
            var typeofT1 = typeof(T1);
            var typeofT2 = typeof(T2);
            return Task.FromResult(value2);
        }
    }
}
