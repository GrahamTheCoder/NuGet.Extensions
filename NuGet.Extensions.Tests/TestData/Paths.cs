﻿using System;
using System.Collections.Generic;
using System.IO;

namespace NuGet.Extensions.Tests.TestData
{
    public static class Paths
    {
        public static string RootFolder {get { return Path.Combine(".", "TestData"); }}
        public static string PackageReferenceSetResolverXml { get { return Path.Combine(RootFolder, "PackageReferenceSetResolverTestData.xml"); } }

        private static string TestSolutionForAdapterFolder { get { return Path.Combine(RootFolder, "TestSolutionForAdapter"); } }
        public static string AdapterTestsSolutionFile { get { return Path.Combine(TestSolutionForAdapterFolder, "TestSolutionForAdapter.sln"); } }
        public static string ProjectWithDependencies { get { return Path.Combine(TestSolutionForAdapterFolder, "ProjectWithDependencies", "ProjectWithDependencies.csproj"); } }
    }
}
