using System;
using System.Buffers;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO.Pipelines;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json
{
	// Token: 0x0200000C RID: 12
	internal static class ThrowHelper
	{
		// Token: 0x06000105 RID: 261 RVA: 0x0000346A File Offset: 0x0000166A
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ThrowOutOfMemoryException_BufferMaximumSizeExceeded(uint capacity)
		{
			throw new OutOfMemoryException(SR.Format(SR.BufferMaximumSizeExceeded, capacity));
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00003481 File Offset: 0x00001681
		[DoesNotReturn]
		public static void ThrowArgumentNullException(string parameterName)
		{
			throw new ArgumentNullException(parameterName);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00003489 File Offset: 0x00001689
		[DoesNotReturn]
		public static void ThrowArgumentOutOfRangeException_NewLine(string parameterName)
		{
			throw ThrowHelper.GetArgumentOutOfRangeException(parameterName, SR.InvalidNewLine);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00003496 File Offset: 0x00001696
		[DoesNotReturn]
		public static void ThrowArgumentOutOfRangeException_IndentCharacter(string parameterName)
		{
			throw ThrowHelper.GetArgumentOutOfRangeException(parameterName, SR.InvalidIndentCharacter);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000034A3 File Offset: 0x000016A3
		[DoesNotReturn]
		public static void ThrowArgumentOutOfRangeException_IndentSize(string parameterName, int minimumSize, int maximumSize)
		{
			throw ThrowHelper.GetArgumentOutOfRangeException(parameterName, SR.Format(SR.InvalidIndentSize, minimumSize, maximumSize));
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000034C1 File Offset: 0x000016C1
		[DoesNotReturn]
		public static void ThrowArgumentOutOfRangeException_MaxDepthMustBePositive(string parameterName)
		{
			throw ThrowHelper.GetArgumentOutOfRangeException(parameterName, SR.MaxDepthMustBePositive);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000034CE File Offset: 0x000016CE
		[DoesNotReturn]
		public static void ThrowArgumentOutOfRangeException_JsonNumberExponentTooLarge(string parameterName)
		{
			throw ThrowHelper.GetArgumentOutOfRangeException(parameterName, SR.JsonNumberExponentTooLarge);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000034DB File Offset: 0x000016DB
		private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(string parameterName, string message)
		{
			return new ArgumentOutOfRangeException(parameterName, message);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000034E4 File Offset: 0x000016E4
		[DoesNotReturn]
		public static void ThrowArgumentOutOfRangeException_CommentEnumMustBeInRange(string parameterName)
		{
			throw ThrowHelper.GetArgumentOutOfRangeException(parameterName, SR.CommentHandlingMustBeValid);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000034F1 File Offset: 0x000016F1
		[DoesNotReturn]
		public static void ThrowArgumentOutOfRangeException_JsonConverterFactory_TypeNotSupported(Type typeToConvert)
		{
			throw new ArgumentOutOfRangeException("typeToConvert", SR.Format(SR.SerializerConverterFactoryInvalidArgument, typeToConvert.FullName));
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000350D File Offset: 0x0000170D
		private static ArgumentException GetArgumentException(string message)
		{
			return new ArgumentException(message);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00003515 File Offset: 0x00001715
		[DoesNotReturn]
		public static void ThrowArgumentException(string message)
		{
			throw ThrowHelper.GetArgumentException(message);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000351D File Offset: 0x0000171D
		[DoesNotReturn]
		public static void ThrowArgumentException_DestinationTooShort()
		{
			throw ThrowHelper.GetArgumentException(SR.DestinationTooShort);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00003529 File Offset: 0x00001729
		[DoesNotReturn]
		public static void ThrowArgumentException_PropertyNameTooLarge(int tokenLength)
		{
			throw ThrowHelper.GetArgumentException(SR.Format(SR.PropertyNameTooLarge, tokenLength));
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00003540 File Offset: 0x00001740
		[DoesNotReturn]
		public static void ThrowArgumentException_ValueTooLarge(long tokenLength)
		{
			throw ThrowHelper.GetArgumentException(SR.Format(SR.ValueTooLarge, tokenLength));
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00003557 File Offset: 0x00001757
		[DoesNotReturn]
		public static void ThrowArgumentException_ValueNotSupported()
		{
			throw ThrowHelper.GetArgumentException(SR.SpecialNumberValuesNotSupported);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00003563 File Offset: 0x00001763
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_NeedLargerSpan()
		{
			throw ThrowHelper.GetInvalidOperationException(SR.FailedToGetLargerSpan);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00003529 File Offset: 0x00001729
		[DoesNotReturn]
		public static void ThrowPropertyNameTooLargeArgumentException(int length)
		{
			throw ThrowHelper.GetArgumentException(SR.Format(SR.PropertyNameTooLarge, length));
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00003570 File Offset: 0x00001770
		[DoesNotReturn]
		public static void ThrowArgumentException(ReadOnlySpan<byte> propertyName, ReadOnlySpan<byte> value)
		{
			if (propertyName.Length > 166666666)
			{
				ThrowHelper.ThrowArgumentException(SR.Format(SR.PropertyNameTooLarge, propertyName.Length));
				return;
			}
			ThrowHelper.ThrowArgumentException(SR.Format(SR.ValueTooLarge, value.Length));
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000035C4 File Offset: 0x000017C4
		[DoesNotReturn]
		public static void ThrowArgumentException(ReadOnlySpan<byte> propertyName, ReadOnlySpan<char> value)
		{
			if (propertyName.Length > 166666666)
			{
				ThrowHelper.ThrowArgumentException(SR.Format(SR.PropertyNameTooLarge, propertyName.Length));
				return;
			}
			ThrowHelper.ThrowArgumentException(SR.Format(SR.ValueTooLarge, value.Length));
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00003618 File Offset: 0x00001818
		[DoesNotReturn]
		public static void ThrowArgumentException(ReadOnlySpan<char> propertyName, ReadOnlySpan<byte> value)
		{
			if (propertyName.Length > 166666666)
			{
				ThrowHelper.ThrowArgumentException(SR.Format(SR.PropertyNameTooLarge, propertyName.Length));
				return;
			}
			ThrowHelper.ThrowArgumentException(SR.Format(SR.ValueTooLarge, value.Length));
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000366C File Offset: 0x0000186C
		[DoesNotReturn]
		public static void ThrowArgumentException(ReadOnlySpan<char> propertyName, ReadOnlySpan<char> value)
		{
			if (propertyName.Length > 166666666)
			{
				ThrowHelper.ThrowArgumentException(SR.Format(SR.PropertyNameTooLarge, propertyName.Length));
				return;
			}
			ThrowHelper.ThrowArgumentException(SR.Format(SR.ValueTooLarge, value.Length));
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000036C0 File Offset: 0x000018C0
		[DoesNotReturn]
		public static void ThrowInvalidOperationOrArgumentException(ReadOnlySpan<byte> propertyName, int currentDepth, int maxDepth)
		{
			currentDepth &= int.MaxValue;
			if (currentDepth >= maxDepth)
			{
				ThrowHelper.ThrowInvalidOperationException(SR.Format(SR.DepthTooLarge, currentDepth, maxDepth));
				return;
			}
			ThrowHelper.ThrowArgumentException(SR.Format(SR.PropertyNameTooLarge, propertyName.Length));
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00003711 File Offset: 0x00001911
		[DoesNotReturn]
		public static void ThrowInvalidOperationException(int currentDepth, int maxDepth)
		{
			currentDepth &= int.MaxValue;
			ThrowHelper.ThrowInvalidOperationException(SR.Format(SR.DepthTooLarge, currentDepth, maxDepth));
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00003737 File Offset: 0x00001937
		[DoesNotReturn]
		public static void ThrowInvalidOperationException(string message)
		{
			throw ThrowHelper.GetInvalidOperationException(message);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000373F File Offset: 0x0000193F
		private static InvalidOperationException GetInvalidOperationException(string message)
		{
			return new InvalidOperationException(message)
			{
				Source = "System.Text.Json.Rethrowable"
			};
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00003754 File Offset: 0x00001954
		[DoesNotReturn]
		public static void ThrowInvalidOperationOrArgumentException(ReadOnlySpan<char> propertyName, int currentDepth, int maxDepth)
		{
			currentDepth &= int.MaxValue;
			if (currentDepth >= maxDepth)
			{
				ThrowHelper.ThrowInvalidOperationException(SR.Format(SR.DepthTooLarge, currentDepth, maxDepth));
				return;
			}
			ThrowHelper.ThrowArgumentException(SR.Format(SR.PropertyNameTooLarge, propertyName.Length));
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000037A5 File Offset: 0x000019A5
		public static InvalidOperationException GetInvalidOperationException_ExpectedArray(JsonTokenType tokenType)
		{
			return ThrowHelper.GetInvalidOperationException("array", tokenType);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000037B2 File Offset: 0x000019B2
		public static InvalidOperationException GetInvalidOperationException_ExpectedObject(JsonTokenType tokenType)
		{
			return ThrowHelper.GetInvalidOperationException("object", tokenType);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000037BF File Offset: 0x000019BF
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_ExpectedNumber(JsonTokenType tokenType)
		{
			throw ThrowHelper.GetInvalidOperationException("number", tokenType);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000037CC File Offset: 0x000019CC
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_ExpectedBoolean(JsonTokenType tokenType)
		{
			throw ThrowHelper.GetInvalidOperationException("boolean", tokenType);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000037D9 File Offset: 0x000019D9
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_ExpectedString(JsonTokenType tokenType)
		{
			throw ThrowHelper.GetInvalidOperationException("string", tokenType);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000037E6 File Offset: 0x000019E6
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_ExpectedPropertyName(JsonTokenType tokenType)
		{
			throw ThrowHelper.GetInvalidOperationException("propertyName", tokenType);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000037F3 File Offset: 0x000019F3
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_ExpectedStringComparison(JsonTokenType tokenType)
		{
			throw ThrowHelper.GetInvalidOperationException(tokenType);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000037FB File Offset: 0x000019FB
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_ExpectedComment(JsonTokenType tokenType)
		{
			throw ThrowHelper.GetInvalidOperationException("comment", tokenType);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00003808 File Offset: 0x00001A08
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_CannotSkipOnPartial()
		{
			throw ThrowHelper.GetInvalidOperationException(SR.CannotSkip);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00003814 File Offset: 0x00001A14
		private static InvalidOperationException GetInvalidOperationException(string message, JsonTokenType tokenType)
		{
			return ThrowHelper.GetInvalidOperationException(SR.Format(SR.InvalidCast, tokenType, message));
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000382C File Offset: 0x00001A2C
		private static InvalidOperationException GetInvalidOperationException(JsonTokenType tokenType)
		{
			return ThrowHelper.GetInvalidOperationException(SR.Format(SR.InvalidComparison, tokenType));
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00003843 File Offset: 0x00001A43
		[DoesNotReturn]
		internal static void ThrowJsonElementWrongTypeException(JsonTokenType expectedType, JsonTokenType actualType)
		{
			throw ThrowHelper.GetJsonElementWrongTypeException(expectedType.ToValueKind(), actualType.ToValueKind());
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00003856 File Offset: 0x00001A56
		internal static InvalidOperationException GetJsonElementWrongTypeException(JsonValueKind expectedType, JsonValueKind actualType)
		{
			return ThrowHelper.GetInvalidOperationException(SR.Format(SR.JsonElementHasWrongType, expectedType, actualType));
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00003873 File Offset: 0x00001A73
		internal static InvalidOperationException GetJsonElementWrongTypeException(string expectedTypeName, JsonValueKind actualType)
		{
			return ThrowHelper.GetInvalidOperationException(SR.Format(SR.JsonElementHasWrongType, expectedTypeName, actualType));
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000388B File Offset: 0x00001A8B
		[DoesNotReturn]
		public static void ThrowJsonReaderException(ref Utf8JsonReader json, ExceptionResource resource, byte nextByte = 0, ReadOnlySpan<byte> bytes = default(ReadOnlySpan<byte>))
		{
			throw ThrowHelper.GetJsonReaderException(ref json, resource, nextByte, bytes);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00003898 File Offset: 0x00001A98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static JsonException GetJsonReaderException(ref Utf8JsonReader json, ExceptionResource resource, byte nextByte, ReadOnlySpan<byte> bytes)
		{
			string resourceString = ThrowHelper.GetResourceString(ref json, resource, nextByte, JsonHelpers.Utf8GetString(bytes));
			long lineNumber = json.CurrentState._lineNumber;
			long bytePositionInLine = json.CurrentState._bytePositionInLine;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 2);
			defaultInterpolatedStringHandler.AppendLiteral(" LineNumber: ");
			defaultInterpolatedStringHandler.AppendFormatted<long>(lineNumber);
			defaultInterpolatedStringHandler.AppendLiteral(" | BytePositionInLine: ");
			defaultInterpolatedStringHandler.AppendFormatted<long>(bytePositionInLine);
			defaultInterpolatedStringHandler.AppendLiteral(".");
			return new JsonReaderException(resourceString + defaultInterpolatedStringHandler.ToStringAndClear(), lineNumber, bytePositionInLine);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000391C File Offset: 0x00001B1C
		private static bool IsPrintable(byte value)
		{
			return value >= 32 && value < 127;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000392C File Offset: 0x00001B2C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static string GetPrintableString(byte value)
		{
			if (!ThrowHelper.IsPrintable(value))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
				defaultInterpolatedStringHandler.AppendLiteral("0x");
				defaultInterpolatedStringHandler.AppendFormatted<byte>(value, "X2");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			char c = (char)value;
			return c.ToString();
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00003974 File Offset: 0x00001B74
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string GetResourceString(ref Utf8JsonReader json, ExceptionResource resource, byte nextByte, string characters)
		{
			string printableString = ThrowHelper.GetPrintableString(nextByte);
			string result = "";
			switch (resource)
			{
			case ExceptionResource.ArrayDepthTooLarge:
				result = SR.Format(SR.ArrayDepthTooLarge, json.CurrentState.Options.MaxDepth);
				break;
			case ExceptionResource.EndOfCommentNotFound:
				result = SR.EndOfCommentNotFound;
				break;
			case ExceptionResource.EndOfStringNotFound:
				result = SR.EndOfStringNotFound;
				break;
			case ExceptionResource.RequiredDigitNotFoundAfterDecimal:
				result = SR.Format(SR.RequiredDigitNotFoundAfterDecimal, printableString);
				break;
			case ExceptionResource.RequiredDigitNotFoundAfterSign:
				result = SR.Format(SR.RequiredDigitNotFoundAfterSign, printableString);
				break;
			case ExceptionResource.RequiredDigitNotFoundEndOfData:
				result = SR.RequiredDigitNotFoundEndOfData;
				break;
			case ExceptionResource.ExpectedEndAfterSingleJson:
				result = SR.Format(SR.ExpectedEndAfterSingleJson, printableString);
				break;
			case ExceptionResource.ExpectedEndOfDigitNotFound:
				result = SR.Format(SR.ExpectedEndOfDigitNotFound, printableString);
				break;
			case ExceptionResource.ExpectedFalse:
				result = SR.Format(SR.ExpectedFalse, characters);
				break;
			case ExceptionResource.ExpectedNextDigitEValueNotFound:
				result = SR.Format(SR.ExpectedNextDigitEValueNotFound, printableString);
				break;
			case ExceptionResource.ExpectedNull:
				result = SR.Format(SR.ExpectedNull, characters);
				break;
			case ExceptionResource.ExpectedSeparatorAfterPropertyNameNotFound:
				result = SR.Format(SR.ExpectedSeparatorAfterPropertyNameNotFound, printableString);
				break;
			case ExceptionResource.ExpectedStartOfPropertyNotFound:
				result = SR.Format(SR.ExpectedStartOfPropertyNotFound, printableString);
				break;
			case ExceptionResource.ExpectedStartOfPropertyOrValueNotFound:
				result = SR.ExpectedStartOfPropertyOrValueNotFound;
				break;
			case ExceptionResource.ExpectedStartOfPropertyOrValueAfterComment:
				result = SR.Format(SR.ExpectedStartOfPropertyOrValueAfterComment, printableString);
				break;
			case ExceptionResource.ExpectedStartOfValueNotFound:
				result = SR.Format(SR.ExpectedStartOfValueNotFound, printableString);
				break;
			case ExceptionResource.ExpectedTrue:
				result = SR.Format(SR.ExpectedTrue, characters);
				break;
			case ExceptionResource.ExpectedValueAfterPropertyNameNotFound:
				result = SR.ExpectedValueAfterPropertyNameNotFound;
				break;
			case ExceptionResource.FoundInvalidCharacter:
				result = SR.Format(SR.FoundInvalidCharacter, printableString);
				break;
			case ExceptionResource.InvalidCharacterWithinString:
				result = SR.Format(SR.InvalidCharacterWithinString, printableString);
				break;
			case ExceptionResource.InvalidCharacterAfterEscapeWithinString:
				result = SR.Format(SR.InvalidCharacterAfterEscapeWithinString, printableString);
				break;
			case ExceptionResource.InvalidHexCharacterWithinString:
				result = SR.Format(SR.InvalidHexCharacterWithinString, printableString);
				break;
			case ExceptionResource.InvalidEndOfJsonNonPrimitive:
				result = SR.Format(SR.InvalidEndOfJsonNonPrimitive, json.TokenType);
				break;
			case ExceptionResource.MismatchedObjectArray:
				result = SR.Format(SR.MismatchedObjectArray, printableString);
				break;
			case ExceptionResource.ObjectDepthTooLarge:
				result = SR.Format(SR.ObjectDepthTooLarge, json.CurrentState.Options.MaxDepth);
				break;
			case ExceptionResource.ZeroDepthAtEnd:
				result = SR.Format(SR.ZeroDepthAtEnd, Array.Empty<object>());
				break;
			case ExceptionResource.ExpectedJsonTokens:
				result = SR.ExpectedJsonTokens;
				break;
			case ExceptionResource.TrailingCommaNotAllowedBeforeArrayEnd:
				result = SR.TrailingCommaNotAllowedBeforeArrayEnd;
				break;
			case ExceptionResource.TrailingCommaNotAllowedBeforeObjectEnd:
				result = SR.TrailingCommaNotAllowedBeforeObjectEnd;
				break;
			case ExceptionResource.InvalidCharacterAtStartOfComment:
				result = SR.Format(SR.InvalidCharacterAtStartOfComment, printableString);
				break;
			case ExceptionResource.UnexpectedEndOfDataWhileReadingComment:
				result = SR.Format(SR.UnexpectedEndOfDataWhileReadingComment, Array.Empty<object>());
				break;
			case ExceptionResource.UnexpectedEndOfLineSeparator:
				result = SR.Format(SR.UnexpectedEndOfLineSeparator, Array.Empty<object>());
				break;
			case ExceptionResource.ExpectedOneCompleteToken:
				result = SR.ExpectedOneCompleteToken;
				break;
			case ExceptionResource.NotEnoughData:
				result = SR.NotEnoughData;
				break;
			case ExceptionResource.InvalidLeadingZeroInNumber:
				result = SR.Format(SR.InvalidLeadingZeroInNumber, printableString);
				break;
			}
			return result;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00003C7C File Offset: 0x00001E7C
		[DoesNotReturn]
		public static void ThrowInvalidOperationException(ExceptionResource resource, int currentDepth, int maxDepth, byte token, JsonTokenType tokenType)
		{
			throw ThrowHelper.GetInvalidOperationException(resource, currentDepth, maxDepth, token, tokenType);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00003C89 File Offset: 0x00001E89
		[DoesNotReturn]
		public static void ThrowArgumentException_InvalidCommentValue()
		{
			throw new ArgumentException(SR.CannotWriteCommentWithEmbeddedDelimiter);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00003C98 File Offset: 0x00001E98
		[DoesNotReturn]
		public unsafe static void ThrowArgumentException_InvalidUTF8(ReadOnlySpan<byte> value)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num = Math.Min(value.Length, 10);
			for (int i = 0; i < num; i++)
			{
				byte value2 = *value[i];
				if (ThrowHelper.IsPrintable(value2))
				{
					stringBuilder.Append((char)value2);
				}
				else
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder3 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder2);
					appendInterpolatedStringHandler.AppendLiteral("0x");
					appendInterpolatedStringHandler.AppendFormatted<byte>(value2, "X2");
					stringBuilder3.Append(ref appendInterpolatedStringHandler);
				}
			}
			if (num < value.Length)
			{
				stringBuilder.Append("...");
			}
			throw new ArgumentException(SR.Format(SR.CannotEncodeInvalidUTF8, stringBuilder));
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00003D3C File Offset: 0x00001F3C
		[DoesNotReturn]
		public static void ThrowArgumentException_InvalidUTF16(int charAsInt)
		{
			string cannotEncodeInvalidUTF = SR.CannotEncodeInvalidUTF16;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
			defaultInterpolatedStringHandler.AppendLiteral("0x");
			defaultInterpolatedStringHandler.AppendFormatted<int>(charAsInt, "X2");
			throw new ArgumentException(SR.Format(cannotEncodeInvalidUTF, defaultInterpolatedStringHandler.ToStringAndClear()));
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00003D84 File Offset: 0x00001F84
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_ReadInvalidUTF16(int charAsInt)
		{
			string cannotReadInvalidUTF = SR.CannotReadInvalidUTF16;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
			defaultInterpolatedStringHandler.AppendLiteral("0x");
			defaultInterpolatedStringHandler.AppendFormatted<int>(charAsInt, "X2");
			throw ThrowHelper.GetInvalidOperationException(SR.Format(cannotReadInvalidUTF, defaultInterpolatedStringHandler.ToStringAndClear()));
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00003DC9 File Offset: 0x00001FC9
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_ReadIncompleteUTF16()
		{
			throw ThrowHelper.GetInvalidOperationException(SR.CannotReadIncompleteUTF16);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00003DD5 File Offset: 0x00001FD5
		public static InvalidOperationException GetInvalidOperationException_ReadInvalidUTF8(DecoderFallbackException innerException = null)
		{
			return ThrowHelper.GetInvalidOperationException(SR.CannotTranscodeInvalidUtf8, innerException);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00003DE2 File Offset: 0x00001FE2
		public static ArgumentException GetArgumentException_ReadInvalidUTF16(EncoderFallbackException innerException)
		{
			return new ArgumentException(SR.CannotTranscodeInvalidUtf16, innerException);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00003DEF File Offset: 0x00001FEF
		public static InvalidOperationException GetInvalidOperationException(string message, Exception innerException)
		{
			return new InvalidOperationException(message, innerException)
			{
				Source = "System.Text.Json.Rethrowable"
			};
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00003E03 File Offset: 0x00002003
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static InvalidOperationException GetInvalidOperationException(ExceptionResource resource, int currentDepth, int maxDepth, byte token, JsonTokenType tokenType)
		{
			InvalidOperationException invalidOperationException = ThrowHelper.GetInvalidOperationException(ThrowHelper.GetResourceString(resource, currentDepth, maxDepth, token, tokenType));
			invalidOperationException.Source = "System.Text.Json.Rethrowable";
			return invalidOperationException;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000346A File Offset: 0x0000166A
		[DoesNotReturn]
		public static void ThrowOutOfMemoryException(uint capacity)
		{
			throw new OutOfMemoryException(SR.Format(SR.BufferMaximumSizeExceeded, capacity));
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00003E20 File Offset: 0x00002020
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string GetResourceString(ExceptionResource resource, int currentDepth, int maxDepth, byte token, JsonTokenType tokenType)
		{
			string result = "";
			switch (resource)
			{
			case ExceptionResource.MismatchedObjectArray:
				result = ((tokenType == JsonTokenType.PropertyName) ? SR.Format(SR.CannotWriteEndAfterProperty, (char)token) : SR.Format(SR.MismatchedObjectArray, (char)token));
				break;
			case ExceptionResource.DepthTooLarge:
				result = SR.Format(SR.DepthTooLarge, currentDepth & int.MaxValue, maxDepth);
				break;
			case ExceptionResource.CannotStartObjectArrayWithoutProperty:
				result = SR.Format(SR.CannotStartObjectArrayWithoutProperty, tokenType);
				break;
			case ExceptionResource.CannotStartObjectArrayAfterPrimitiveOrClose:
				result = SR.Format(SR.CannotStartObjectArrayAfterPrimitiveOrClose, tokenType);
				break;
			case ExceptionResource.CannotWriteValueWithinObject:
				result = SR.Format(SR.CannotWriteValueWithinObject, tokenType);
				break;
			case ExceptionResource.CannotWriteValueAfterPrimitiveOrClose:
				result = SR.Format(SR.CannotWriteValueAfterPrimitiveOrClose, tokenType);
				break;
			case ExceptionResource.CannotWritePropertyWithinArray:
				result = ((tokenType == JsonTokenType.PropertyName) ? SR.Format(SR.CannotWritePropertyAfterProperty, Array.Empty<object>()) : SR.Format(SR.CannotWritePropertyWithinArray, tokenType));
				break;
			}
			return result;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00003F2A File Offset: 0x0000212A
		[DoesNotReturn]
		public static void ThrowFormatException()
		{
			throw new FormatException
			{
				Source = "System.Text.Json.Rethrowable"
			};
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00003F3C File Offset: 0x0000213C
		public static void ThrowFormatException(NumericType numericType)
		{
			string message = "";
			switch (numericType)
			{
			case NumericType.Byte:
				message = SR.FormatByte;
				break;
			case NumericType.SByte:
				message = SR.FormatSByte;
				break;
			case NumericType.Int16:
				message = SR.FormatInt16;
				break;
			case NumericType.Int32:
				message = SR.FormatInt32;
				break;
			case NumericType.Int64:
				message = SR.FormatInt64;
				break;
			case NumericType.Int128:
				message = SR.FormatInt128;
				break;
			case NumericType.UInt16:
				message = SR.FormatUInt16;
				break;
			case NumericType.UInt32:
				message = SR.FormatUInt32;
				break;
			case NumericType.UInt64:
				message = SR.FormatUInt64;
				break;
			case NumericType.UInt128:
				message = SR.FormatUInt128;
				break;
			case NumericType.Half:
				message = SR.FormatHalf;
				break;
			case NumericType.Single:
				message = SR.FormatSingle;
				break;
			case NumericType.Double:
				message = SR.FormatDouble;
				break;
			case NumericType.Decimal:
				message = SR.FormatDecimal;
				break;
			}
			throw new FormatException(message)
			{
				Source = "System.Text.Json.Rethrowable"
			};
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00004010 File Offset: 0x00002210
		[DoesNotReturn]
		public static void ThrowFormatException(DataType dataType)
		{
			string message = "";
			switch (dataType)
			{
			case DataType.Boolean:
			case DataType.DateOnly:
			case DataType.DateTime:
			case DataType.DateTimeOffset:
			case DataType.TimeOnly:
			case DataType.TimeSpan:
			case DataType.Guid:
			case DataType.Version:
				message = SR.Format(SR.UnsupportedFormat, dataType);
				break;
			case DataType.Base64String:
				message = SR.CannotDecodeInvalidBase64;
				break;
			}
			throw new FormatException(message)
			{
				Source = "System.Text.Json.Rethrowable"
			};
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00004079 File Offset: 0x00002279
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_ExpectedChar(JsonTokenType tokenType)
		{
			throw ThrowHelper.GetInvalidOperationException("char", tokenType);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00004086 File Offset: 0x00002286
		[DoesNotReturn]
		public static void ThrowObjectDisposedException_Utf8JsonWriter()
		{
			throw new ObjectDisposedException("Utf8JsonWriter");
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00004092 File Offset: 0x00002292
		[DoesNotReturn]
		public static void ThrowObjectDisposedException_JsonDocument()
		{
			throw new ObjectDisposedException("JsonDocument");
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000409E File Offset: 0x0000229E
		[DoesNotReturn]
		public static void ThrowInsufficientExecutionStackException_JsonElementDeepEqualsInsufficientExecutionStack()
		{
			throw new InsufficientExecutionStackException(SR.JsonElementDeepEqualsInsufficientExecutionStack);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000040AA File Offset: 0x000022AA
		[DoesNotReturn]
		public static void ThrowArgumentException_NodeValueNotAllowed(string paramName)
		{
			throw new ArgumentException(SR.NodeValueNotAllowed, paramName);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000040B7 File Offset: 0x000022B7
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_NodeAlreadyHasParent()
		{
			throw new InvalidOperationException(SR.NodeAlreadyHasParent);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000040C3 File Offset: 0x000022C3
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_NodeCycleDetected()
		{
			throw new InvalidOperationException(SR.NodeCycleDetected);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000040CF File Offset: 0x000022CF
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_NodeElementCannotBeObjectOrArray()
		{
			throw new InvalidOperationException(SR.NodeElementCannotBeObjectOrArray);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000040DC File Offset: 0x000022DC
		[DoesNotReturn]
		public unsafe static void ThrowInvalidOperationException_NodeWrongType([ParamCollection] [ScopedRef] ReadOnlySpan<string> supportedTypeNames)
		{
			string p = (supportedTypeNames.Length == 1) ? (*supportedTypeNames[0]) : string.Join(", ", supportedTypeNames.ToArray());
			throw new InvalidOperationException(SR.Format(SR.NodeWrongType, p));
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00004120 File Offset: 0x00002320
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_NodeParentWrongType(string typeName)
		{
			throw new InvalidOperationException(SR.Format(SR.NodeParentWrongType, typeName));
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00004132 File Offset: 0x00002332
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_NodeUnableToConvert(Type sourceType, Type destinationType)
		{
			throw new InvalidOperationException(SR.Format(SR.NodeUnableToConvert, sourceType, destinationType));
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00004145 File Offset: 0x00002345
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_NodeUnableToConvertElement(JsonValueKind valueKind, Type destinationType)
		{
			throw new InvalidOperationException(SR.Format(SR.NodeUnableToConvertElement, valueKind, destinationType));
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000415D File Offset: 0x0000235D
		[DoesNotReturn]
		public static void ThrowArgumentException_DeserializeWrongType(Type type, object value)
		{
			throw new ArgumentException(SR.Format(SR.DeserializeWrongType, type, value.GetType()));
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00004175 File Offset: 0x00002375
		[DoesNotReturn]
		public static void ThrowArgumentException_SerializerDoesNotSupportComments(string paramName)
		{
			throw new ArgumentException(SR.JsonSerializerDoesNotSupportComments, paramName);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00004182 File Offset: 0x00002382
		[DoesNotReturn]
		public static void ThrowNotSupportedException_SerializationNotSupported(Type propertyType)
		{
			throw new NotSupportedException(SR.Format(SR.SerializationNotSupportedType, propertyType));
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00004194 File Offset: 0x00002394
		[DoesNotReturn]
		public static void ThrowNotSupportedException_TypeRequiresAsyncSerialization(Type propertyType)
		{
			throw new NotSupportedException(SR.Format(SR.TypeRequiresAsyncSerialization, propertyType));
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000041A6 File Offset: 0x000023A6
		[DoesNotReturn]
		public static void ThrowNotSupportedException_DictionaryKeyTypeNotSupported(Type keyType, JsonConverter converter)
		{
			throw new NotSupportedException(SR.Format(SR.DictionaryKeyTypeNotSupported, keyType, converter.GetType()));
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000041BE File Offset: 0x000023BE
		[DoesNotReturn]
		public static void ThrowJsonException_DeserializeUnableToConvertValue(Type propertyType)
		{
			throw new JsonException(SR.Format(SR.DeserializeUnableToConvertValue, propertyType))
			{
				AppendPathInformation = true
			};
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000041D7 File Offset: 0x000023D7
		[DoesNotReturn]
		public static void ThrowInvalidCastException_DeserializeUnableToAssignValue(Type typeOfValue, Type declaredType)
		{
			throw new InvalidCastException(SR.Format(SR.DeserializeUnableToAssignValue, typeOfValue, declaredType));
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000041EA File Offset: 0x000023EA
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_DeserializeUnableToAssignNull(Type declaredType)
		{
			throw new InvalidOperationException(SR.Format(SR.DeserializeUnableToAssignNull, declaredType));
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000041FC File Offset: 0x000023FC
		[DoesNotReturn]
		public static void ThrowJsonException_PropertyGetterDisallowNull(string propertyName, Type declaringType)
		{
			throw new JsonException(SR.Format(SR.PropertyGetterDisallowNull, propertyName, declaringType))
			{
				AppendPathInformation = true
			};
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00004216 File Offset: 0x00002416
		[DoesNotReturn]
		public static void ThrowJsonException_PropertySetterDisallowNull(string propertyName, Type declaringType)
		{
			throw new JsonException(SR.Format(SR.PropertySetterDisallowNull, propertyName, declaringType))
			{
				AppendPathInformation = true
			};
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00004230 File Offset: 0x00002430
		[DoesNotReturn]
		public static void ThrowJsonException_ConstructorParameterDisallowNull(string parameterName, Type declaringType)
		{
			throw new JsonException(SR.Format(SR.ConstructorParameterDisallowNull, parameterName, declaringType))
			{
				AppendPathInformation = true
			};
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000424A File Offset: 0x0000244A
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_ObjectCreationHandlingPopulateNotSupportedByConverter(JsonPropertyInfo propertyInfo)
		{
			throw new InvalidOperationException(SR.Format(SR.ObjectCreationHandlingPopulateNotSupportedByConverter, propertyInfo.Name, propertyInfo.DeclaringType));
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00004267 File Offset: 0x00002467
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_ObjectCreationHandlingPropertyMustHaveAGetter(JsonPropertyInfo propertyInfo)
		{
			throw new InvalidOperationException(SR.Format(SR.ObjectCreationHandlingPropertyMustHaveAGetter, propertyInfo.Name, propertyInfo.DeclaringType));
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00004284 File Offset: 0x00002484
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_ObjectCreationHandlingPropertyValueTypeMustHaveASetter(JsonPropertyInfo propertyInfo)
		{
			throw new InvalidOperationException(SR.Format(SR.ObjectCreationHandlingPropertyValueTypeMustHaveASetter, propertyInfo.Name, propertyInfo.DeclaringType));
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000042A1 File Offset: 0x000024A1
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_ObjectCreationHandlingPropertyCannotAllowPolymorphicDeserialization(JsonPropertyInfo propertyInfo)
		{
			throw new InvalidOperationException(SR.Format(SR.ObjectCreationHandlingPropertyCannotAllowPolymorphicDeserialization, propertyInfo.Name, propertyInfo.DeclaringType));
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000042BE File Offset: 0x000024BE
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_ObjectCreationHandlingPropertyCannotAllowReadOnlyMember(JsonPropertyInfo propertyInfo)
		{
			throw new InvalidOperationException(SR.Format(SR.ObjectCreationHandlingPropertyCannotAllowReadOnlyMember, propertyInfo.Name, propertyInfo.DeclaringType));
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000042DB File Offset: 0x000024DB
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_ObjectCreationHandlingPropertyCannotAllowReferenceHandling()
		{
			throw new InvalidOperationException(SR.ObjectCreationHandlingPropertyCannotAllowReferenceHandling);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000042E7 File Offset: 0x000024E7
		[DoesNotReturn]
		public static void ThrowNotSupportedException_ObjectCreationHandlingPropertyDoesNotSupportParameterizedConstructors()
		{
			throw new NotSupportedException(SR.ObjectCreationHandlingPropertyDoesNotSupportParameterizedConstructors);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000042F3 File Offset: 0x000024F3
		[DoesNotReturn]
		public static void ThrowJsonException_SerializationConverterRead(JsonConverter converter)
		{
			throw new JsonException(SR.Format(SR.SerializationConverterRead, converter))
			{
				AppendPathInformation = true
			};
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000430C File Offset: 0x0000250C
		[DoesNotReturn]
		public static void ThrowJsonException_SerializationConverterWrite(JsonConverter converter)
		{
			throw new JsonException(SR.Format(SR.SerializationConverterWrite, converter))
			{
				AppendPathInformation = true
			};
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00004325 File Offset: 0x00002525
		[DoesNotReturn]
		public static void ThrowJsonException_SerializerCycleDetected(int maxDepth)
		{
			throw new JsonException(SR.Format(SR.SerializerCycleDetected, maxDepth))
			{
				AppendPathInformation = true
			};
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00004343 File Offset: 0x00002543
		[DoesNotReturn]
		public static void ThrowJsonException(string message = null)
		{
			throw new JsonException(message)
			{
				AppendPathInformation = true
			};
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00004352 File Offset: 0x00002552
		[DoesNotReturn]
		public static void ThrowArgumentException_CannotSerializeInvalidType(string paramName, Type typeToConvert, Type declaringType, string propertyName)
		{
			if (declaringType == null)
			{
				throw new ArgumentException(SR.Format(SR.CannotSerializeInvalidType, typeToConvert), paramName);
			}
			throw new ArgumentException(SR.Format(SR.CannotSerializeInvalidMember, typeToConvert, propertyName, declaringType), paramName);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00004382 File Offset: 0x00002582
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_CannotSerializeInvalidType(Type typeToConvert, Type declaringType, MemberInfo memberInfo)
		{
			if (declaringType == null)
			{
				throw new InvalidOperationException(SR.Format(SR.CannotSerializeInvalidType, typeToConvert));
			}
			throw new InvalidOperationException(SR.Format(SR.CannotSerializeInvalidMember, typeToConvert, memberInfo.Name, declaringType));
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000043B5 File Offset: 0x000025B5
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_SerializationConverterNotCompatible(Type converterType, Type type)
		{
			throw new InvalidOperationException(SR.Format(SR.SerializationConverterNotCompatible, converterType, type));
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000043C8 File Offset: 0x000025C8
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_ResolverTypeNotCompatible(Type requestedType, Type actualType)
		{
			throw new InvalidOperationException(SR.Format(SR.ResolverTypeNotCompatible, actualType, requestedType));
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000043DB File Offset: 0x000025DB
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_ResolverTypeInfoOptionsNotCompatible()
		{
			throw new InvalidOperationException(SR.ResolverTypeInfoOptionsNotCompatible);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000043E7 File Offset: 0x000025E7
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_JsonSerializerOptionsNoTypeInfoResolverSpecified()
		{
			throw new InvalidOperationException(SR.JsonSerializerOptionsNoTypeInfoResolverSpecified);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000043F3 File Offset: 0x000025F3
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_JsonSerializerIsReflectionDisabled()
		{
			throw new InvalidOperationException(SR.JsonSerializerIsReflectionDisabled);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00004400 File Offset: 0x00002600
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_SerializationConverterOnAttributeInvalid(Type classType, MemberInfo memberInfo)
		{
			string text = classType.ToString();
			if (memberInfo != null)
			{
				text = text + "." + memberInfo.Name;
			}
			throw new InvalidOperationException(SR.Format(SR.SerializationConverterOnAttributeInvalid, text));
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00004440 File Offset: 0x00002640
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_SerializationConverterOnAttributeNotCompatible(Type classTypeAttributeIsOn, MemberInfo memberInfo, Type typeToConvert)
		{
			string text = classTypeAttributeIsOn.ToString();
			if (memberInfo != null)
			{
				text = text + "." + memberInfo.Name;
			}
			throw new InvalidOperationException(SR.Format(SR.SerializationConverterOnAttributeNotCompatible, text, typeToConvert));
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00004480 File Offset: 0x00002680
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_SerializerOptionsReadOnly(JsonSerializerContext context)
		{
			throw new InvalidOperationException((context == null) ? SR.SerializerOptionsReadOnly : SR.SerializerContextOptionsReadOnly);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00004496 File Offset: 0x00002696
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_DefaultTypeInfoResolverImmutable()
		{
			throw new InvalidOperationException(SR.DefaultTypeInfoResolverImmutable);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000044A2 File Offset: 0x000026A2
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_TypeInfoResolverChainImmutable()
		{
			throw new InvalidOperationException(SR.TypeInfoResolverChainImmutable);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000044AE File Offset: 0x000026AE
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_TypeInfoImmutable()
		{
			throw new InvalidOperationException(SR.TypeInfoImmutable);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000044BA File Offset: 0x000026BA
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_InvalidChainedResolver()
		{
			throw new InvalidOperationException(SR.SerializerOptions_InvalidChainedResolver);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000044C6 File Offset: 0x000026C6
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_SerializerPropertyNameConflict(Type type, string propertyName)
		{
			throw new InvalidOperationException(SR.Format(SR.SerializerPropertyNameConflict, type, propertyName));
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000044D9 File Offset: 0x000026D9
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_SerializerPropertyNameNull(JsonPropertyInfo jsonPropertyInfo)
		{
			throw new InvalidOperationException(SR.Format(SR.SerializerPropertyNameNull, jsonPropertyInfo.DeclaringType, jsonPropertyInfo.MemberName));
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000044F6 File Offset: 0x000026F6
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_JsonPropertyRequiredAndNotDeserializable(JsonPropertyInfo jsonPropertyInfo)
		{
			throw new InvalidOperationException(SR.Format(SR.JsonPropertyRequiredAndNotDeserializable, jsonPropertyInfo.Name, jsonPropertyInfo.DeclaringType));
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00004513 File Offset: 0x00002713
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_JsonPropertyRequiredAndExtensionData(JsonPropertyInfo jsonPropertyInfo)
		{
			throw new InvalidOperationException(SR.Format(SR.JsonPropertyRequiredAndExtensionData, jsonPropertyInfo.Name, jsonPropertyInfo.DeclaringType));
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00004530 File Offset: 0x00002730
		[DoesNotReturn]
		public unsafe static void ThrowJsonException_JsonRequiredPropertyMissing(JsonTypeInfo parent, BitArray requiredPropertiesSet)
		{
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = true;
			ReadOnlySpan<JsonPropertyInfo> propertyCache = parent.PropertyCache;
			for (int i = 0; i < propertyCache.Length; i++)
			{
				JsonPropertyInfo jsonPropertyInfo = *propertyCache[i];
				if (jsonPropertyInfo.IsRequired && !requiredPropertiesSet[jsonPropertyInfo.RequiredPropertyIndex])
				{
					if (!flag)
					{
						stringBuilder.Append(CultureInfo.CurrentUICulture.TextInfo.ListSeparator);
						stringBuilder.Append(' ');
					}
					stringBuilder.Append('\'');
					stringBuilder.Append(jsonPropertyInfo.Name);
					stringBuilder.Append('\'');
					flag = false;
					if (stringBuilder.Length >= 60)
					{
						break;
					}
				}
			}
			throw new JsonException(SR.Format(SR.JsonRequiredPropertiesMissing, parent.Type, stringBuilder.ToString()));
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000045EA File Offset: 0x000027EA
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_NamingPolicyReturnNull(JsonNamingPolicy namingPolicy)
		{
			throw new InvalidOperationException(SR.Format(SR.NamingPolicyReturnNull, namingPolicy));
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000045FC File Offset: 0x000027FC
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_SerializerConverterFactoryReturnsNull(Type converterType)
		{
			throw new InvalidOperationException(SR.Format(SR.SerializerConverterFactoryReturnsNull, converterType));
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000460E File Offset: 0x0000280E
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_SerializerConverterFactoryReturnsJsonConverterFactorty(Type converterType)
		{
			throw new InvalidOperationException(SR.Format(SR.SerializerConverterFactoryReturnsJsonConverterFactory, converterType));
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00004620 File Offset: 0x00002820
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_MultiplePropertiesBindToConstructorParameters(Type parentType, string parameterName, string firstMatchName, string secondMatchName)
		{
			throw new InvalidOperationException(SR.Format(SR.MultipleMembersBindWithConstructorParameter, new object[]
			{
				firstMatchName,
				secondMatchName,
				parentType,
				parameterName
			}));
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00004647 File Offset: 0x00002847
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_ConstructorParameterIncompleteBinding(Type parentType)
		{
			throw new InvalidOperationException(SR.Format(SR.ConstructorParamIncompleteBinding, parentType));
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00004659 File Offset: 0x00002859
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_ExtensionDataCannotBindToCtorParam(string propertyName, JsonPropertyInfo jsonPropertyInfo)
		{
			throw new InvalidOperationException(SR.Format(SR.ExtensionDataCannotBindToCtorParam, propertyName, jsonPropertyInfo.DeclaringType));
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00004671 File Offset: 0x00002871
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_JsonIncludeOnInaccessibleProperty(string memberName, Type declaringType)
		{
			throw new InvalidOperationException(SR.Format(SR.JsonIncludeOnInaccessibleProperty, memberName, declaringType));
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00004684 File Offset: 0x00002884
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_IgnoreConditionOnValueTypeInvalid(string clrPropertyName, Type propertyDeclaringType)
		{
			throw new InvalidOperationException(SR.Format(SR.IgnoreConditionOnValueTypeInvalid, clrPropertyName, propertyDeclaringType));
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00004697 File Offset: 0x00002897
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_NumberHandlingOnPropertyInvalid(JsonPropertyInfo jsonPropertyInfo)
		{
			throw new InvalidOperationException(SR.Format(SR.NumberHandlingOnPropertyInvalid, jsonPropertyInfo.MemberName, jsonPropertyInfo.DeclaringType));
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000046B4 File Offset: 0x000028B4
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_ConverterCanConvertMultipleTypes(Type runtimePropertyType, JsonConverter jsonConverter)
		{
			throw new InvalidOperationException(SR.Format(SR.ConverterCanConvertMultipleTypes, jsonConverter.GetType(), jsonConverter.Type, runtimePropertyType));
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000046D4 File Offset: 0x000028D4
		[DoesNotReturn]
		public static void ThrowNotSupportedException_ObjectWithParameterizedCtorRefMetadataNotSupported(ReadOnlySpan<byte> propertyName, ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state)
		{
			JsonTypeInfo topJsonTypeInfoWithParameterizedConstructor = state.GetTopJsonTypeInfoWithParameterizedConstructor();
			state.Current.JsonPropertyName = propertyName.ToArray();
			NotSupportedException innerException = new NotSupportedException(SR.Format(SR.ObjectWithParameterizedCtorRefMetadataNotSupported, topJsonTypeInfoWithParameterizedConstructor.Type));
			ThrowHelper.ThrowNotSupportedException(ref state, reader, innerException);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00004718 File Offset: 0x00002918
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_JsonTypeInfoOperationNotPossibleForKind(JsonTypeInfoKind kind)
		{
			throw new InvalidOperationException(SR.Format(SR.InvalidJsonTypeInfoOperationForKind, kind));
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000472F File Offset: 0x0000292F
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_JsonTypeInfoOnDeserializingCallbacksNotSupported(Type type)
		{
			throw new InvalidOperationException(SR.Format(SR.OnDeserializingCallbacksNotSupported, type));
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00004741 File Offset: 0x00002941
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_CreateObjectConverterNotCompatible(Type type)
		{
			throw new InvalidOperationException(SR.Format(SR.CreateObjectConverterNotCompatible, type));
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00004754 File Offset: 0x00002954
		[DoesNotReturn]
		public static void ReThrowWithPath([ScopedRef] ref ReadStack state, JsonReaderException ex)
		{
			string text = state.JsonPath();
			string text2 = ex.Message;
			int num = text2.AsSpan().LastIndexOf(" LineNumber: ");
			if (num >= 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 3);
				defaultInterpolatedStringHandler.AppendFormatted(text2.Substring(0, num));
				defaultInterpolatedStringHandler.AppendLiteral(" Path: ");
				defaultInterpolatedStringHandler.AppendFormatted(text);
				defaultInterpolatedStringHandler.AppendLiteral(" |");
				defaultInterpolatedStringHandler.AppendFormatted(text2.Substring(num));
				text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				text2 = text2 + " Path: " + text + ".";
			}
			throw new JsonException(text2, text, ex.LineNumber, ex.BytePositionInLine, ex);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00004800 File Offset: 0x00002A00
		[DoesNotReturn]
		public static void ReThrowWithPath([ScopedRef] ref ReadStack state, in Utf8JsonReader reader, Exception ex)
		{
			JsonException ex2 = new JsonException(null, ex);
			ThrowHelper.AddJsonExceptionInformation(ref state, reader, ex2);
			throw ex2;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00004820 File Offset: 0x00002A20
		public static void AddJsonExceptionInformation([ScopedRef] ref ReadStack state, in Utf8JsonReader reader, JsonException ex)
		{
			long lineNumber = reader.CurrentState._lineNumber;
			ex.LineNumber = new long?(lineNumber);
			long bytePositionInLine = reader.CurrentState._bytePositionInLine;
			ex.BytePositionInLine = new long?(bytePositionInLine);
			string text = state.JsonPath();
			ex.Path = text;
			string text2 = ex._message;
			if (string.IsNullOrEmpty(text2))
			{
				JsonPropertyInfo jsonPropertyInfo = state.Current.JsonPropertyInfo;
				Type p = ((jsonPropertyInfo != null) ? jsonPropertyInfo.PropertyType : null) ?? state.Current.JsonTypeInfo.Type;
				text2 = SR.Format(SR.DeserializeUnableToConvertValue, p);
				ex.AppendPathInformation = true;
			}
			if (ex.AppendPathInformation)
			{
				string str = text2;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 3);
				defaultInterpolatedStringHandler.AppendLiteral(" Path: ");
				defaultInterpolatedStringHandler.AppendFormatted(text);
				defaultInterpolatedStringHandler.AppendLiteral(" | LineNumber: ");
				defaultInterpolatedStringHandler.AppendFormatted<long>(lineNumber);
				defaultInterpolatedStringHandler.AppendLiteral(" | BytePositionInLine: ");
				defaultInterpolatedStringHandler.AppendFormatted<long>(bytePositionInLine);
				defaultInterpolatedStringHandler.AppendLiteral(".");
				text2 = str + defaultInterpolatedStringHandler.ToStringAndClear();
				ex.SetMessage(text2);
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000492C File Offset: 0x00002B2C
		[DoesNotReturn]
		public static void ReThrowWithPath(ref WriteStack state, Exception ex)
		{
			JsonException ex2 = new JsonException(null, ex);
			ThrowHelper.AddJsonExceptionInformation(ref state, ex2);
			throw ex2;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000494C File Offset: 0x00002B4C
		public static void AddJsonExceptionInformation(ref WriteStack state, JsonException ex)
		{
			string text = state.PropertyPath();
			ex.Path = text;
			string text2 = ex._message;
			if (string.IsNullOrEmpty(text2))
			{
				text2 = SR.Format(SR.SerializeUnableToSerialize, Array.Empty<object>());
				ex.AppendPathInformation = true;
			}
			if (ex.AppendPathInformation)
			{
				text2 = text2 + " Path: " + text + ".";
				ex.SetMessage(text2);
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000049B0 File Offset: 0x00002BB0
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_SerializationDuplicateAttribute(Type attribute, MemberInfo memberInfo)
		{
			Type type = memberInfo as Type;
			string text;
			if (type == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<Type>(memberInfo.DeclaringType);
				defaultInterpolatedStringHandler.AppendLiteral(".");
				defaultInterpolatedStringHandler.AppendFormatted(memberInfo.Name);
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				text = type.ToString();
			}
			string p = text;
			throw new InvalidOperationException(SR.Format(SR.SerializationDuplicateAttribute, attribute, p));
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00004A17 File Offset: 0x00002C17
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_SerializationDuplicateTypeAttribute(Type classType, Type attribute)
		{
			throw new InvalidOperationException(SR.Format(SR.SerializationDuplicateTypeAttribute, classType, attribute));
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00004A2A File Offset: 0x00002C2A
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_SerializationDuplicateTypeAttribute<TAttribute>(Type classType)
		{
			throw new InvalidOperationException(SR.Format(SR.SerializationDuplicateTypeAttribute, classType, typeof(TAttribute)));
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00004A46 File Offset: 0x00002C46
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_ExtensionDataConflictsWithUnmappedMemberHandling(Type classType, JsonPropertyInfo jsonPropertyInfo)
		{
			throw new InvalidOperationException(SR.Format(SR.ExtensionDataConflictsWithUnmappedMemberHandling, classType, jsonPropertyInfo.MemberName));
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00004A5E File Offset: 0x00002C5E
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_SerializationDataExtensionPropertyInvalid(JsonPropertyInfo jsonPropertyInfo)
		{
			throw new InvalidOperationException(SR.Format(SR.SerializationDataExtensionPropertyInvalid, jsonPropertyInfo.PropertyType, jsonPropertyInfo.MemberName));
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00004A7B File Offset: 0x00002C7B
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_PropertyTypeNotNullable(JsonPropertyInfo jsonPropertyInfo)
		{
			throw new InvalidOperationException(SR.Format(SR.PropertyTypeNotNullable, jsonPropertyInfo.PropertyType));
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00004A92 File Offset: 0x00002C92
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_NodeJsonObjectCustomConverterNotAllowedOnExtensionProperty()
		{
			throw new InvalidOperationException(SR.NodeJsonObjectCustomConverterNotAllowedOnExtensionProperty);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00004AA0 File Offset: 0x00002CA0
		[DoesNotReturn]
		public static void ThrowNotSupportedException([ScopedRef] ref ReadStack state, in Utf8JsonReader reader, Exception innerException)
		{
			string text = innerException.Message;
			JsonPropertyInfo jsonPropertyInfo = state.Current.JsonPropertyInfo;
			Type type = ((jsonPropertyInfo != null) ? jsonPropertyInfo.PropertyType : null) ?? state.Current.JsonTypeInfo.Type;
			if (!text.Contains(type.ToString()))
			{
				if (text.Length > 0)
				{
					text += " ";
				}
				text += SR.Format(SR.SerializationNotSupportedParentType, type);
			}
			long lineNumber = reader.CurrentState._lineNumber;
			long bytePositionInLine = reader.CurrentState._bytePositionInLine;
			string str = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 3);
			defaultInterpolatedStringHandler.AppendLiteral(" Path: ");
			defaultInterpolatedStringHandler.AppendFormatted(state.JsonPath());
			defaultInterpolatedStringHandler.AppendLiteral(" | LineNumber: ");
			defaultInterpolatedStringHandler.AppendFormatted<long>(lineNumber);
			defaultInterpolatedStringHandler.AppendLiteral(" | BytePositionInLine: ");
			defaultInterpolatedStringHandler.AppendFormatted<long>(bytePositionInLine);
			defaultInterpolatedStringHandler.AppendLiteral(".");
			text = str + defaultInterpolatedStringHandler.ToStringAndClear();
			throw new NotSupportedException(text, innerException);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00004B9C File Offset: 0x00002D9C
		[DoesNotReturn]
		public static void ThrowNotSupportedException(ref WriteStack state, Exception innerException)
		{
			string text = innerException.Message;
			JsonPropertyInfo jsonPropertyInfo = state.Current.JsonPropertyInfo;
			Type type = ((jsonPropertyInfo != null) ? jsonPropertyInfo.PropertyType : null) ?? state.Current.JsonTypeInfo.Type;
			if (!text.Contains(type.ToString()))
			{
				if (text.Length > 0)
				{
					text += " ";
				}
				text += SR.Format(SR.SerializationNotSupportedParentType, type);
			}
			text = text + " Path: " + state.PropertyPath() + ".";
			throw new NotSupportedException(text, innerException);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00004C30 File Offset: 0x00002E30
		[DoesNotReturn]
		public static void ThrowNotSupportedException_DeserializeNoConstructor(JsonTypeInfo typeInfo, ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state)
		{
			Type type = typeInfo.Type;
			string message;
			if (type.IsInterface || type.IsAbstract)
			{
				PolymorphicTypeResolver polymorphicTypeResolver = typeInfo.PolymorphicTypeResolver;
				bool? flag = (polymorphicTypeResolver != null) ? new bool?(polymorphicTypeResolver.UsesTypeDiscriminators) : null;
				if (flag != null && flag.GetValueOrDefault())
				{
					message = SR.Format(SR.DeserializationMustSpecifyTypeDiscriminator, type);
				}
				else
				{
					JsonTypeInfoKind kind = typeInfo.Kind;
					bool flag2 = kind - JsonTypeInfoKind.Enumerable <= 1;
					if (flag2)
					{
						message = SR.Format(SR.CannotPopulateCollection, type);
					}
					else
					{
						message = SR.Format(SR.DeserializeInterfaceOrAbstractType, type);
					}
				}
			}
			else
			{
				message = SR.Format(SR.DeserializeNoConstructor, "JsonConstructorAttribute", type);
			}
			ThrowHelper.ThrowNotSupportedException(ref state, reader, new NotSupportedException(message));
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00004CE9 File Offset: 0x00002EE9
		[DoesNotReturn]
		public static void ThrowNotSupportedException_CannotPopulateCollection(Type type, ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state)
		{
			ThrowHelper.ThrowNotSupportedException(ref state, reader, new NotSupportedException(SR.Format(SR.CannotPopulateCollection, type)));
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00004D02 File Offset: 0x00002F02
		[DoesNotReturn]
		public static void ThrowJsonException_MetadataValuesInvalidToken(JsonTokenType tokenType)
		{
			ThrowHelper.ThrowJsonException(SR.Format(SR.MetadataInvalidTokenAfterValues, tokenType));
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00004D19 File Offset: 0x00002F19
		[DoesNotReturn]
		public static void ThrowJsonException_MetadataReferenceNotFound(string id)
		{
			ThrowHelper.ThrowJsonException(SR.Format(SR.MetadataReferenceNotFound, id));
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00004D2B File Offset: 0x00002F2B
		[DoesNotReturn]
		public static void ThrowJsonException_MetadataValueWasNotString(JsonTokenType tokenType)
		{
			ThrowHelper.ThrowJsonException(SR.Format(SR.MetadataValueWasNotString, tokenType));
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00004D42 File Offset: 0x00002F42
		[DoesNotReturn]
		public static void ThrowJsonException_MetadataValueWasNotString(JsonValueKind valueKind)
		{
			ThrowHelper.ThrowJsonException(SR.Format(SR.MetadataValueWasNotString, valueKind));
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00004D59 File Offset: 0x00002F59
		[DoesNotReturn]
		public static void ThrowJsonException_MetadataReferenceObjectCannotContainOtherProperties(ReadOnlySpan<byte> propertyName, [ScopedRef] ref ReadStack state)
		{
			state.Current.JsonPropertyName = propertyName.ToArray();
			ThrowHelper.ThrowJsonException_MetadataReferenceObjectCannotContainOtherProperties();
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00004D72 File Offset: 0x00002F72
		[DoesNotReturn]
		public static void ThrowJsonException_MetadataUnexpectedProperty(ReadOnlySpan<byte> propertyName, [ScopedRef] ref ReadStack state)
		{
			state.Current.JsonPropertyName = propertyName.ToArray();
			ThrowHelper.ThrowJsonException(SR.Format(SR.MetadataUnexpectedProperty, Array.Empty<object>()));
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00004D9A File Offset: 0x00002F9A
		[DoesNotReturn]
		public static void ThrowJsonException_UnmappedJsonProperty(Type type, string unmappedPropertyName)
		{
			throw new JsonException(SR.Format(SR.UnmappedJsonProperty, unmappedPropertyName, type));
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00004DAD File Offset: 0x00002FAD
		[DoesNotReturn]
		public static void ThrowJsonException_MetadataReferenceObjectCannotContainOtherProperties()
		{
			ThrowHelper.ThrowJsonException(SR.MetadataReferenceCannotContainOtherProperties);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00004DB9 File Offset: 0x00002FB9
		[DoesNotReturn]
		public static void ThrowJsonException_MetadataIdCannotBeCombinedWithRef(ReadOnlySpan<byte> propertyName, [ScopedRef] ref ReadStack state)
		{
			state.Current.JsonPropertyName = propertyName.ToArray();
			ThrowHelper.ThrowJsonException(SR.MetadataIdCannotBeCombinedWithRef);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00004DD7 File Offset: 0x00002FD7
		[DoesNotReturn]
		public static void ThrowJsonException_MetadataStandaloneValuesProperty([ScopedRef] ref ReadStack state, ReadOnlySpan<byte> propertyName)
		{
			state.Current.JsonPropertyName = propertyName.ToArray();
			ThrowHelper.ThrowJsonException(SR.MetadataStandaloneValuesProperty);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00004DF8 File Offset: 0x00002FF8
		[DoesNotReturn]
		public static void ThrowJsonException_MetadataInvalidPropertyWithLeadingDollarSign(ReadOnlySpan<byte> propertyName, [ScopedRef] ref ReadStack state, in Utf8JsonReader reader)
		{
			if (state.Current.IsProcessingDictionary())
			{
				Utf8JsonReader utf8JsonReader = reader;
				state.Current.JsonPropertyNameAsString = utf8JsonReader.GetString();
			}
			else
			{
				state.Current.JsonPropertyName = propertyName.ToArray();
			}
			ThrowHelper.ThrowJsonException(SR.MetadataInvalidPropertyWithLeadingDollarSign);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00004E49 File Offset: 0x00003049
		[DoesNotReturn]
		public static void ThrowJsonException_MetadataDuplicateIdFound(string id)
		{
			ThrowHelper.ThrowJsonException(SR.Format(SR.MetadataDuplicateIdFound, id));
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00004E5B File Offset: 0x0000305B
		[DoesNotReturn]
		public static void ThrowJsonException_DuplicateMetadataProperty(ReadOnlySpan<byte> utf8PropertyName)
		{
			ThrowHelper.ThrowJsonException(SR.Format(SR.DuplicateMetadataProperty, JsonHelpers.Utf8GetString(utf8PropertyName)));
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00004E72 File Offset: 0x00003072
		[DoesNotReturn]
		public static void ThrowJsonException_MetadataInvalidReferenceToValueType(Type propertyType)
		{
			ThrowHelper.ThrowJsonException(SR.Format(SR.MetadataInvalidReferenceToValueType, propertyType));
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00004E84 File Offset: 0x00003084
		[DoesNotReturn]
		public static void ThrowJsonException_MetadataInvalidPropertyInArrayMetadata([ScopedRef] ref ReadStack state, Type propertyType, in Utf8JsonReader reader)
		{
			byte[] jsonPropertyName;
			if (!reader.HasValueSequence)
			{
				jsonPropertyName = reader.ValueSpan.ToArray();
			}
			else
			{
				ReadOnlySequence<byte> valueSequence = reader.ValueSequence;
				jsonPropertyName = valueSequence.ToArray<byte>();
			}
			state.Current.JsonPropertyName = jsonPropertyName;
			Utf8JsonReader utf8JsonReader = reader;
			string @string = utf8JsonReader.GetString();
			ThrowHelper.ThrowJsonException(SR.Format(SR.MetadataPreservedArrayFailed, SR.Format(SR.MetadataInvalidPropertyInArrayMetadata, @string), SR.Format(SR.DeserializeUnableToConvertValue, propertyType)));
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00004EF6 File Offset: 0x000030F6
		[DoesNotReturn]
		public static void ThrowJsonException_MetadataPreservedArrayValuesNotFound([ScopedRef] ref ReadStack state, Type propertyType)
		{
			state.Current.JsonPropertyName = null;
			ThrowHelper.ThrowJsonException(SR.Format(SR.MetadataPreservedArrayFailed, SR.MetadataStandaloneValuesProperty, SR.Format(SR.DeserializeUnableToConvertValue, propertyType)));
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00004F23 File Offset: 0x00003123
		[DoesNotReturn]
		public static void ThrowJsonException_MetadataCannotParsePreservedObjectIntoImmutable(Type propertyType)
		{
			ThrowHelper.ThrowJsonException(SR.Format(SR.MetadataCannotParsePreservedObjectToImmutable, propertyType));
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00004F35 File Offset: 0x00003135
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_MetadataReferenceOfTypeCannotBeAssignedToType(string referenceId, Type currentType, Type typeToConvert)
		{
			throw new InvalidOperationException(SR.Format(SR.MetadataReferenceOfTypeCannotBeAssignedToType, referenceId, currentType, typeToConvert));
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00004F49 File Offset: 0x00003149
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_JsonPropertyInfoIsBoundToDifferentJsonTypeInfo(JsonPropertyInfo propertyInfo)
		{
			throw new InvalidOperationException(SR.Format(SR.JsonPropertyInfoBoundToDifferentParent, propertyInfo.Name, propertyInfo.DeclaringTypeInfo.Type.FullName));
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00004F70 File Offset: 0x00003170
		[DoesNotReturn]
		internal static void ThrowUnexpectedMetadataException(ReadOnlySpan<byte> propertyName, ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state)
		{
			if (JsonSerializer.GetMetadataPropertyName(propertyName, state.Current.BaseJsonTypeInfo.PolymorphicTypeResolver) != MetadataPropertyName.None)
			{
				ThrowHelper.ThrowJsonException_MetadataUnexpectedProperty(propertyName, ref state);
				return;
			}
			ThrowHelper.ThrowJsonException_MetadataInvalidPropertyWithLeadingDollarSign(propertyName, ref state, reader);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00004F9A File Offset: 0x0000319A
		[DoesNotReturn]
		public static void ThrowNotSupportedException_NoMetadataForType(Type type, IJsonTypeInfoResolver resolver)
		{
			throw new NotSupportedException(SR.Format(SR.NoMetadataForType, type, ((resolver != null) ? resolver.ToString() : null) ?? "<null>"));
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00004FC1 File Offset: 0x000031C1
		public static NotSupportedException GetNotSupportedException_AmbiguousMetadataForType(Type type, Type match1, Type match2)
		{
			return new NotSupportedException(SR.Format(SR.AmbiguousMetadataForType, type, match1, match2));
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00004FD5 File Offset: 0x000031D5
		[DoesNotReturn]
		public static void ThrowNotSupportedException_ConstructorContainsNullParameterNames(Type declaringType)
		{
			throw new NotSupportedException(SR.Format(SR.ConstructorContainsNullParameterNames, declaringType));
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00004FE7 File Offset: 0x000031E7
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_NoMetadataForType(Type type, IJsonTypeInfoResolver resolver)
		{
			throw new InvalidOperationException(SR.Format(SR.NoMetadataForType, type, ((resolver != null) ? resolver.ToString() : null) ?? "<null>"));
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000500E File Offset: 0x0000320E
		public static Exception GetInvalidOperationException_NoMetadataForTypeProperties(IJsonTypeInfoResolver resolver, Type type)
		{
			return new InvalidOperationException(SR.Format(SR.NoMetadataForTypeProperties, ((resolver != null) ? resolver.ToString() : null) ?? "<null>", type));
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00005035 File Offset: 0x00003235
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_NoMetadataForTypeProperties(IJsonTypeInfoResolver resolver, Type type)
		{
			throw ThrowHelper.GetInvalidOperationException_NoMetadataForTypeProperties(resolver, type);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000503E File Offset: 0x0000323E
		[DoesNotReturn]
		public static void ThrowMissingMemberException_MissingFSharpCoreMember(string missingFsharpCoreMember)
		{
			throw new MissingMemberException(SR.Format(SR.MissingFSharpCoreMember, missingFsharpCoreMember));
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00005050 File Offset: 0x00003250
		[DoesNotReturn]
		public static void ThrowNotSupportedException_BaseConverterDoesNotSupportMetadata(Type derivedType)
		{
			throw new NotSupportedException(SR.Format(SR.Polymorphism_DerivedConverterDoesNotSupportMetadata, derivedType));
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00005050 File Offset: 0x00003250
		[DoesNotReturn]
		public static void ThrowNotSupportedException_DerivedConverterDoesNotSupportMetadata(Type derivedType)
		{
			throw new NotSupportedException(SR.Format(SR.Polymorphism_DerivedConverterDoesNotSupportMetadata, derivedType));
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00005062 File Offset: 0x00003262
		[DoesNotReturn]
		public static void ThrowNotSupportedException_RuntimeTypeNotSupported(Type baseType, Type runtimeType)
		{
			throw new NotSupportedException(SR.Format(SR.Polymorphism_RuntimeTypeNotSupported, runtimeType, baseType));
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00005075 File Offset: 0x00003275
		[DoesNotReturn]
		public static void ThrowNotSupportedException_RuntimeTypeDiamondAmbiguity(Type baseType, Type runtimeType, Type derivedType1, Type derivedType2)
		{
			throw new NotSupportedException(SR.Format(SR.Polymorphism_RuntimeTypeDiamondAmbiguity, new object[]
			{
				runtimeType,
				derivedType1,
				derivedType2,
				baseType
			}));
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000509C File Offset: 0x0000329C
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_TypeDoesNotSupportPolymorphism(Type baseType)
		{
			throw new InvalidOperationException(SR.Format(SR.Polymorphism_TypeDoesNotSupportPolymorphism, baseType));
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000050AE File Offset: 0x000032AE
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_DerivedTypeNotSupported(Type baseType, Type derivedType)
		{
			throw new InvalidOperationException(SR.Format(SR.Polymorphism_DerivedTypeIsNotSupported, derivedType, baseType));
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000050C1 File Offset: 0x000032C1
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_DerivedTypeIsAlreadySpecified(Type baseType, Type derivedType)
		{
			throw new InvalidOperationException(SR.Format(SR.Polymorphism_DerivedTypeIsAlreadySpecified, baseType, derivedType));
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000050D4 File Offset: 0x000032D4
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_TypeDicriminatorIdIsAlreadySpecified(Type baseType, object typeDiscriminator)
		{
			throw new InvalidOperationException(SR.Format(SR.Polymorphism_TypeDicriminatorIdIsAlreadySpecified, baseType, typeDiscriminator));
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000050E7 File Offset: 0x000032E7
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_InvalidCustomTypeDiscriminatorPropertyName()
		{
			throw new InvalidOperationException(SR.Polymorphism_InvalidCustomTypeDiscriminatorPropertyName);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000050F3 File Offset: 0x000032F3
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_PolymorphicTypeConfigurationDoesNotSpecifyDerivedTypes(Type baseType)
		{
			throw new InvalidOperationException(SR.Format(SR.Polymorphism_ConfigurationDoesNotSpecifyDerivedTypes, baseType));
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00005105 File Offset: 0x00003305
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_UnsupportedEnumIdentifier(Type enumType, string enumName)
		{
			throw new InvalidOperationException(SR.Format(SR.UnsupportedEnumIdentifier, enumType.Name, enumName));
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000511D File Offset: 0x0000331D
		[DoesNotReturn]
		public static void ThrowJsonException_UnrecognizedTypeDiscriminator(object typeDiscriminator)
		{
			ThrowHelper.ThrowJsonException(SR.Format(SR.Polymorphism_UnrecognizedTypeDiscriminator, typeDiscriminator));
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000512F File Offset: 0x0000332F
		[DoesNotReturn]
		public static void ThrowArgumentException_JsonPolymorphismOptionsAssociatedWithDifferentJsonTypeInfo(string parameterName)
		{
			throw new ArgumentException(SR.JsonPolymorphismOptionsAssociatedWithDifferentJsonTypeInfo, parameterName);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000513C File Offset: 0x0000333C
		[DoesNotReturn]
		public static void ThrowOperationCanceledException_PipeWriteCanceled()
		{
			throw new OperationCanceledException(SR.PipeWriterCanceled);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00005148 File Offset: 0x00003348
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_PipeWriterDoesNotImplementUnflushedBytes(PipeWriter pipeWriter)
		{
			throw new InvalidOperationException(SR.Format(SR.PipeWriter_DoesNotImplementUnflushedBytes, pipeWriter.GetType().Name));
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00005164 File Offset: 0x00003364
		[DoesNotReturn]
		public static void ThrowNotSupportedException_JsonSchemaExporterDoesNotSupportReferenceHandlerPreserve()
		{
			throw new NotSupportedException(SR.JsonSchemaExporter_ReferenceHandlerPreserve_NotSupported);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00005170 File Offset: 0x00003370
		[DoesNotReturn]
		public static void ThrowInvalidOperationException_JsonSchemaExporterDepthTooLarge()
		{
			throw new InvalidOperationException(SR.JsonSchemaExporter_DepthTooLarge);
		}
	}
}
