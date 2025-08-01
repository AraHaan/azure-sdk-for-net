﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.TypeSpec.Generator.Input;
using Microsoft.TypeSpec.Generator.Providers;
using System;

namespace Azure.Generator.Management.Providers
{
    internal class SystemObjectModelProvider : ModelProvider
    {
        internal readonly Type _type;

        public SystemObjectModelProvider(Type type, InputModelType inputModel) : base(inputModel)
        {
            _type = type;
            CrossLanguageDefinitionId = inputModel.CrossLanguageDefinitionId;
        }

        internal string CrossLanguageDefinitionId { get; }

        protected override string BuildName() => _type.Name;

        protected override string BuildRelativeFilePath()
            => throw new InvalidOperationException("This type should not be writing in generation");

        protected override string BuildNamespace() => _type.Namespace!;
    }
}
