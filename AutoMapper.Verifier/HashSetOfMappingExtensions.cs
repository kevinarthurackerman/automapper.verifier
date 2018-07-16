﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoMapper.Verifier
{
    internal static class HashSetOfMappingExtensions
    {
        internal static void AddOrUpdateMapping(this HashSet<Mapping> mappings, Mapping mapping)
        {
            if (mappings.TryGetValue(mapping, out var existingMapping))
            {
                mapping = new Mapping(
                        existingMapping.From,
                        existingMapping.To,
                        existingMapping.CreateCallSites.Concat(mapping.CreateCallSites),
                        existingMapping.MapCallSites.Concat(mapping.MapCallSites),
                        existingMapping.Errors.Concat(mapping.Errors));

                mappings.Remove(existingMapping);
            }

            mappings.Add(mapping);
        }

        internal static void AddError(this HashSet<Mapping> mappings, Type from, Type to, string error)
        {
            AddOrUpdateMapping(mappings, new Mapping(from, to, null, null, new[] { error }));
        }
    }
}
