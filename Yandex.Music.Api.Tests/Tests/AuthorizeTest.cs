﻿using System;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;
using Yandex.Music.Api.Tests.Traits;

namespace Yandex.Music.Api.Tests.Tests
{
    [Collection("Yandex Test Harness")]
    public class AuthorizeTest : YandexTest
    {
        public AuthorizeTest(YandexTestHarness fixture, ITestOutputHelper output) : base(fixture, output)
        {
        }

        [Fact]
        [YandexTrait(TraitGroup.Authorize)]
        public void Authorize_ValidData_GenerateTrue()
        {
            var isAuthorized = Api.Authorize(AppSettings.Login, AppSettings.Password);

            isAuthorized.IsAuthorized.Should().BeTrue();
        }

        [Fact]
        [YandexTrait(TraitGroup.Authorize)]
        public void Authorize_InvalidData_GenerateFalse()
        {
            var isAuthorized = Api.Authorize(AppSettings.Login, AppSettings.Password);

            isAuthorized.IsAuthorized.Should().BeFalse();
        }

        [Fact]
        [YandexTrait(TraitGroup.Authorize)]
        public void Authorize_ValidData_GenerateTru()
        {
            Console.WriteLine("123");
//      Api.GetAccounts();
        }
    }
}