﻿namespace AutoMapper.Verifier
{
    public class VerifierConfiguration
    {
        internal VerifierConfiguration() { }

        public ErrorActions OnUndeclaredMapping { get; set; } = ErrorActions.LogError;
        public ErrorActions OnMultiplyDeclaredMapping { get; set; } = ErrorActions.LogError;
        public ErrorActions OnUnusedMapping { get; set; } = ErrorActions.LogError;
        public ErrorActions OnIndeterminantMapping { get; set; } = ErrorActions.LogError;
    }
}
