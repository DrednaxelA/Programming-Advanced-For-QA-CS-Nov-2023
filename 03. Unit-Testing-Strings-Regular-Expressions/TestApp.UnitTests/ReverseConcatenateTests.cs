﻿using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange
        string[] input = new[] { "Yooo" };

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo("Yooo"));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = new[] { "Yooo", "Hahaha" };

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo("HahahaYooo"));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = null;

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        // Arrange
        string[] input = new[] { "Yooo yo", "Hahaha" };

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo("HahahaYooo yo"));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = new[] { "YoooyoYoooyoYoooyoYoooyo", "HahahaHahahaHahahaHahahaHahahaHahahaHahaha" };

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo("HahahaHahahaHahahaHahahaHahahaHahahaHahahaYoooyoYoooyoYoooyoYoooyo"));
    }
}
