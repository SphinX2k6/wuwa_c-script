using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000226 RID: 550
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KismetStringLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetStringLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002A13 RID: 10771 RVA: 0x0003928E File Offset: 0x0003748E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetStringLibrary._ClassPtr;
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x0003929C File Offset: 0x0003749C
		public UKismetStringLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetStringLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x000392C4 File Offset: 0x000374C4
		public UKismetStringLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetStringLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x000392F8 File Offset: 0x000374F8
		public unsafe static string TrimTrailing(string SourceString)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__TrimTrailing_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x00039324 File Offset: 0x00037524
		public unsafe static string Trim(string SourceString)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Trim_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x00039350 File Offset: 0x00037550
		public unsafe static string ToUpper(string SourceString)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__ToUpper_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x0003937C File Offset: 0x0003757C
		public unsafe static string ToLower(string SourceString)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__ToLower_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x000393A5 File Offset: 0x000375A5
		public static string TimeSecondsToString(float InSeconds)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__TimeSecondsToString_Internal(InSeconds));
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x000393B4 File Offset: 0x000375B4
		public unsafe static bool StartsWith(string SourceString, string InPrefix, ESearchCase SearchCase = ESearchCase.IgnoreCase)
		{
			FString fstring = FString.AllocTemp(SourceString);
			FString fstring2 = FString.AllocTemp(InPrefix);
			bool result = UKismetStringLibrary.__StartsWith_Internal(fstring, fstring2, SearchCase);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x000393F0 File Offset: 0x000375F0
		public unsafe static bool Split(string SourceString, string InStr, ref string LeftS, ref string RightS, ESearchCase SearchCase = ESearchCase.IgnoreCase, ESearchDir SearchDir = ESearchDir.FromStart)
		{
			FString fstring = FString.AllocTemp(SourceString);
			FString fstring2 = FString.AllocTemp(InStr);
			FString fstring3 = FString.AllocTemp(LeftS);
			FString fstring4 = FString.AllocTemp(RightS);
			bool result = UKismetStringLibrary.__Split_Internal(fstring, fstring2, ref fstring3, ref fstring4, SearchCase, SearchDir);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			LeftS = FString.ToString(fstring3);
			FString.NativeDestruct(&fstring3, 1);
			RightS = FString.ToString(fstring4);
			FString.NativeDestruct(&fstring4, 1);
			return result;
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x0003946C File Offset: 0x0003766C
		public unsafe static string RightPad(string SourceString, int ChCount)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__RightPad_Internal(fstring, ChCount));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x00039498 File Offset: 0x00037698
		public unsafe static string RightChop(string SourceString, int Count)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__RightChop_Internal(fstring, Count));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x000394C4 File Offset: 0x000376C4
		public unsafe static string Right(string SourceString, int Count)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Right_Internal(fstring, Count));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A20 RID: 10784 RVA: 0x000394F0 File Offset: 0x000376F0
		public unsafe static string Reverse(string SourceString)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Reverse_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x0003951C File Offset: 0x0003771C
		public unsafe static int ReplaceInline(ref string SourceString, string SearchText, string ReplacementText, ESearchCase SearchCase = ESearchCase.IgnoreCase)
		{
			FString fstring = FString.AllocTemp(SourceString);
			FString fstring2 = FString.AllocTemp(SearchText);
			FString fstring3 = FString.AllocTemp(ReplacementText);
			int result = UKismetStringLibrary.__ReplaceInline_Internal(ref fstring, fstring2, fstring3, SearchCase);
			SourceString = FString.ToString(fstring);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x00039574 File Offset: 0x00037774
		public unsafe static string Replace(string SourceString, string From, string To, ESearchCase SearchCase = ESearchCase.IgnoreCase)
		{
			FString fstring = FString.AllocTemp(SourceString);
			FString fstring2 = FString.AllocTemp(From);
			FString fstring3 = FString.AllocTemp(To);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Replace_Internal(fstring, fstring2, fstring3, SearchCase));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x000395C8 File Offset: 0x000377C8
		public unsafe static TArray<string> ParseIntoArray(string SourceString, string Delimiter = " ", bool CullEmptyStrings = true)
		{
			FString fstring = FString.AllocTemp(SourceString);
			FString fstring2 = FString.AllocTemp(Delimiter);
			TArray<string> result = new TArray<string>(UKismetStringLibrary.__ParseIntoArray_Internal(fstring, fstring2, CullEmptyStrings), null);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x00039608 File Offset: 0x00037808
		public unsafe static bool NotEqual_StrStr(string A, string B)
		{
			FString fstring = FString.AllocTemp(A);
			FString fstring2 = FString.AllocTemp(B);
			bool result = UKismetStringLibrary.__NotEqual_StrStr_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x00039640 File Offset: 0x00037840
		public unsafe static bool NotEqual_StriStri(string A, string B)
		{
			FString fstring = FString.AllocTemp(A);
			FString fstring2 = FString.AllocTemp(B);
			bool result = UKismetStringLibrary.__NotEqual_StriStri_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x00039678 File Offset: 0x00037878
		public unsafe static string Mid(string SourceString, int Start, int Count)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Mid_Internal(fstring, Start, Count));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x000396A4 File Offset: 0x000378A4
		public unsafe static bool MatchesWildcard(string SourceString, string Wildcard, ESearchCase SearchCase = ESearchCase.IgnoreCase)
		{
			FString fstring = FString.AllocTemp(SourceString);
			FString fstring2 = FString.AllocTemp(Wildcard);
			bool result = UKismetStringLibrary.__MatchesWildcard_Internal(fstring, fstring2, SearchCase);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x000396E0 File Offset: 0x000378E0
		public unsafe static int LenInUTF8(string S)
		{
			FString fstring = FString.AllocTemp(S);
			int result = UKismetStringLibrary.__LenInUTF8_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x00039704 File Offset: 0x00037904
		public unsafe static int Len(string S)
		{
			FString fstring = FString.AllocTemp(S);
			int result = UKismetStringLibrary.__Len_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x00039728 File Offset: 0x00037928
		public unsafe static string LeftPad(string SourceString, int ChCount)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__LeftPad_Internal(fstring, ChCount));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x00039754 File Offset: 0x00037954
		public unsafe static string LeftChop(string SourceString, int Count)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__LeftChop_Internal(fstring, Count));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x00039780 File Offset: 0x00037980
		public unsafe static string Left(string SourceString, int Count)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Left_Internal(fstring, Count));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x000397AC File Offset: 0x000379AC
		public unsafe static string JoinStringArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> SourceArray, string Separator = " ")
		{
			FString fstring = FString.AllocTemp(Separator);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__JoinStringArray_Internal((SourceArray ?? new TArray<string>()).NativePtr, fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x000397E8 File Offset: 0x000379E8
		public unsafe static bool IsNumeric(string SourceString)
		{
			FString fstring = FString.AllocTemp(SourceString);
			bool result = UKismetStringLibrary.__IsNumeric_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x0003980C File Offset: 0x00037A0C
		public unsafe static bool IsEmpty(string InString)
		{
			FString fstring = FString.AllocTemp(InString);
			bool result = UKismetStringLibrary.__IsEmpty_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x00039830 File Offset: 0x00037A30
		public unsafe static string GetSubstring(string SourceString, int StartIndex = 0, int Length = 1)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__GetSubstring_Internal(fstring, StartIndex, Length));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x0003985C File Offset: 0x00037A5C
		public unsafe static int GetCharacterAsNumber(string SourceString, int Index = 0)
		{
			FString fstring = FString.AllocTemp(SourceString);
			int result = UKismetStringLibrary.__GetCharacterAsNumber_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x00039884 File Offset: 0x00037A84
		public unsafe static TArray<string> GetCharacterArrayFromString(string SourceString)
		{
			FString fstring = FString.AllocTemp(SourceString);
			TArray<string> result = new TArray<string>(UKismetStringLibrary.__GetCharacterArrayFromString_Internal(fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x000398B0 File Offset: 0x00037AB0
		public unsafe static int FindSubstring(string SearchIn, string Substring, bool bUseCase = false, bool bSearchFromEnd = false, int StartPosition = -1)
		{
			FString fstring = FString.AllocTemp(SearchIn);
			FString fstring2 = FString.AllocTemp(Substring);
			int result = UKismetStringLibrary.__FindSubstring_Internal(fstring, fstring2, bUseCase, bSearchFromEnd, StartPosition);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x000398EC File Offset: 0x00037AEC
		public unsafe static bool EqualEqual_StrStr(string A, string B)
		{
			FString fstring = FString.AllocTemp(A);
			FString fstring2 = FString.AllocTemp(B);
			bool result = UKismetStringLibrary.__EqualEqual_StrStr_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x00039924 File Offset: 0x00037B24
		public unsafe static bool EqualEqual_StriStri(string A, string B)
		{
			FString fstring = FString.AllocTemp(A);
			FString fstring2 = FString.AllocTemp(B);
			bool result = UKismetStringLibrary.__EqualEqual_StriStri_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x0003995C File Offset: 0x00037B5C
		public unsafe static bool EndsWith(string SourceString, string InSuffix, ESearchCase SearchCase = ESearchCase.IgnoreCase)
		{
			FString fstring = FString.AllocTemp(SourceString);
			FString fstring2 = FString.AllocTemp(InSuffix);
			bool result = UKismetStringLibrary.__EndsWith_Internal(fstring, fstring2, SearchCase);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x00039998 File Offset: 0x00037B98
		public static string D_Conv_VectorToString(FVectorDouble InVec)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__D_Conv_VectorToString_Internal(InVec));
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x000399A8 File Offset: 0x00037BA8
		public unsafe static string D_Conv_TransformToString(in FTransformDouble InTrans)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = InTrans;
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__D_Conv_TransformToString_Internal(uintPtr));
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x000399DA File Offset: 0x00037BDA
		public static string D_Conv_FloatToString(double InDouble)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__D_Conv_FloatToString_Internal(InDouble));
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x000399E8 File Offset: 0x00037BE8
		public unsafe static int CullArray(string SourceString, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> InArray)
		{
			FString fstring = FString.AllocTemp(SourceString);
			int result = UKismetStringLibrary.__CullArray_Internal(fstring, (InArray ?? new TArray<string>()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x00039A1C File Offset: 0x00037C1C
		public static string Conv_VectorToString(FVector InVec)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_VectorToString_Internal(InVec));
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x00039A29 File Offset: 0x00037C29
		public static string Conv_Vector2dToString(FVector2D InVec)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_Vector2dToString_Internal(InVec));
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x00039A36 File Offset: 0x00037C36
		public static string Conv_Vector2dDoubleToString(FVector2DDouble InVec)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_Vector2dDoubleToString_Internal(InVec));
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x00039A44 File Offset: 0x00037C44
		public unsafe static string Conv_TransformToString(in FTransform InTrans)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = InTrans;
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_TransformToString_Internal(uintPtr));
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x00039A78 File Offset: 0x00037C78
		public unsafe static void Conv_StringToVector2D(string InString, ref FVector2D OutConvertedVector2D, ref bool OutIsValid)
		{
			FString fstring = FString.AllocTemp(InString);
			fixed (FVector2D* ptr = &OutConvertedVector2D)
			{
				void* ptr2 = (void*)ptr;
				fixed (bool* ptr3 = &OutIsValid)
				{
					void* ptr4 = (void*)ptr3;
					UKismetStringLibrary.__Conv_StringToVector2D_Internal(fstring, ref OutConvertedVector2D, ref OutIsValid);
					FString.NativeDestruct(&fstring, 1);
					ptr = null;
				}
			}
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x00039AB4 File Offset: 0x00037CB4
		public unsafe static void Conv_StringToVector(string InString, ref FVector OutConvertedVector, ref bool OutIsValid)
		{
			FString fstring = FString.AllocTemp(InString);
			fixed (FVector* ptr = &OutConvertedVector)
			{
				void* ptr2 = (void*)ptr;
				fixed (bool* ptr3 = &OutIsValid)
				{
					void* ptr4 = (void*)ptr3;
					UKismetStringLibrary.__Conv_StringToVector_Internal(fstring, ref OutConvertedVector, ref OutIsValid);
					FString.NativeDestruct(&fstring, 1);
					ptr = null;
				}
			}
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x00039AF0 File Offset: 0x00037CF0
		public unsafe static void Conv_StringToRotator(string InString, ref FRotator OutConvertedRotator, ref bool OutIsValid)
		{
			FString fstring = FString.AllocTemp(InString);
			fixed (FRotator* ptr = &OutConvertedRotator)
			{
				void* ptr2 = (void*)ptr;
				fixed (bool* ptr3 = &OutIsValid)
				{
					void* ptr4 = (void*)ptr3;
					UKismetStringLibrary.__Conv_StringToRotator_Internal(fstring, ref OutConvertedRotator, ref OutIsValid);
					FString.NativeDestruct(&fstring, 1);
					ptr = null;
				}
			}
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x00039B2C File Offset: 0x00037D2C
		public unsafe static FName Conv_StringToName(string InString)
		{
			FString fstring = FString.AllocTemp(InString);
			FName result = UKismetStringLibrary.__Conv_StringToName_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x00039B50 File Offset: 0x00037D50
		public unsafe static long Conv_StringToInt64(string InString)
		{
			FString fstring = FString.AllocTemp(InString);
			long result = UKismetStringLibrary.__Conv_StringToInt64_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x00039B74 File Offset: 0x00037D74
		public unsafe static int Conv_StringToInt(string InString)
		{
			FString fstring = FString.AllocTemp(InString);
			int result = UKismetStringLibrary.__Conv_StringToInt_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x00039B98 File Offset: 0x00037D98
		public unsafe static float Conv_StringToFloat(string InString)
		{
			FString fstring = FString.AllocTemp(InString);
			float result = UKismetStringLibrary.__Conv_StringToFloat_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x00039BBC File Offset: 0x00037DBC
		public unsafe static void Conv_StringToColor(string InString, ref FLinearColor OutConvertedColor, ref bool OutIsValid)
		{
			FString fstring = FString.AllocTemp(InString);
			fixed (FLinearColor* ptr = &OutConvertedColor)
			{
				void* ptr2 = (void*)ptr;
				fixed (bool* ptr3 = &OutIsValid)
				{
					void* ptr4 = (void*)ptr3;
					UKismetStringLibrary.__Conv_StringToColor_Internal(fstring, ref OutConvertedColor, ref OutIsValid);
					FString.NativeDestruct(&fstring, 1);
					ptr = null;
				}
			}
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x00039BF5 File Offset: 0x00037DF5
		public static string Conv_RotatorToString(FRotator InRot)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_RotatorToString_Internal(InRot));
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x00039C02 File Offset: 0x00037E02
		public static string Conv_ObjectToString([Nullable(2)] UObject InObj)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_ObjectToString_Internal((InObj != null) ? InObj.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x00039C1E File Offset: 0x00037E1E
		public static string Conv_NameToString(FName InName)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_NameToString_Internal(InName));
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x00039C2C File Offset: 0x00037E2C
		public unsafe static string Conv_MatrixToString(in FMatrix InMatrix)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = InMatrix;
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_MatrixToString_Internal(uintPtr));
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x00039C5E File Offset: 0x00037E5E
		public static string Conv_IntVectorToString(FIntVector InIntVec)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_IntVectorToString_Internal(InIntVec));
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x00039C6B File Offset: 0x00037E6B
		public static string Conv_IntToString(int InInt)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_IntToString_Internal(InInt));
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x00039C78 File Offset: 0x00037E78
		public static string Conv_IntPointToString(FIntPoint InIntPoint)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_IntPointToString_Internal(InIntPoint));
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x00039C85 File Offset: 0x00037E85
		public static string Conv_Int64ToString(long InInt64)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_Int64ToString_Internal(InInt64));
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x00039C92 File Offset: 0x00037E92
		public static string Conv_FloatToString(float InFloat)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_FloatToString_Internal(InFloat));
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x00039C9F File Offset: 0x00037E9F
		public static string Conv_ColorToString(FLinearColor InColor)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_ColorToString_Internal(InColor));
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x00039CAC File Offset: 0x00037EAC
		public static string Conv_ByteToString(byte InByte)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_ByteToString_Internal(InByte));
		}

		// Token: 0x06002A52 RID: 10834 RVA: 0x00039CB9 File Offset: 0x00037EB9
		public static string Conv_BoolToString(bool InBool)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_BoolToString_Internal(InBool));
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x00039CC8 File Offset: 0x00037EC8
		public unsafe static bool Contains(string SearchIn, string Substring, bool bUseCase = false, bool bSearchFromEnd = false)
		{
			FString fstring = FString.AllocTemp(SearchIn);
			FString fstring2 = FString.AllocTemp(Substring);
			bool result = UKismetStringLibrary.__Contains_Internal(fstring, fstring2, bUseCase, bSearchFromEnd);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x00039D00 File Offset: 0x00037F00
		public unsafe static string Concat_StrStr(string A, string B)
		{
			FString fstring = FString.AllocTemp(A);
			FString fstring2 = FString.AllocTemp(B);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Concat_StrStr_Internal(fstring, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x00039D3C File Offset: 0x00037F3C
		public unsafe static string BuildString_Vector2d(string AppendTo, string Prefix, FVector2D InVector2d, string Suffix)
		{
			FString fstring = FString.AllocTemp(AppendTo);
			FString fstring2 = FString.AllocTemp(Prefix);
			FString fstring3 = FString.AllocTemp(Suffix);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__BuildString_Vector2d_Internal(fstring, fstring2, InVector2d, fstring3));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x00039D8C File Offset: 0x00037F8C
		public unsafe static string BuildString_Vector(string AppendTo, string Prefix, FVector InVector, string Suffix)
		{
			FString fstring = FString.AllocTemp(AppendTo);
			FString fstring2 = FString.AllocTemp(Prefix);
			FString fstring3 = FString.AllocTemp(Suffix);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__BuildString_Vector_Internal(fstring, fstring2, InVector, fstring3));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x00039DDC File Offset: 0x00037FDC
		public unsafe static string BuildString_Rotator(string AppendTo, string Prefix, FRotator InRot, string Suffix)
		{
			FString fstring = FString.AllocTemp(AppendTo);
			FString fstring2 = FString.AllocTemp(Prefix);
			FString fstring3 = FString.AllocTemp(Suffix);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__BuildString_Rotator_Internal(fstring, fstring2, InRot, fstring3));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x06002A58 RID: 10840 RVA: 0x00039E2C File Offset: 0x0003802C
		public unsafe static string BuildString_Object(string AppendTo, string Prefix, [Nullable(2)] UObject InObj, string Suffix)
		{
			FString fstring = FString.AllocTemp(AppendTo);
			FString fstring2 = FString.AllocTemp(Prefix);
			FString fstring3 = FString.AllocTemp(Suffix);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__BuildString_Object_Internal(fstring, fstring2, (InObj != null) ? InObj.NativePtr : IntPtr.Zero, fstring3));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x00039E8C File Offset: 0x0003808C
		public unsafe static string BuildString_Name(string AppendTo, string Prefix, FName InName, string Suffix)
		{
			FString fstring = FString.AllocTemp(AppendTo);
			FString fstring2 = FString.AllocTemp(Prefix);
			FString fstring3 = FString.AllocTemp(Suffix);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__BuildString_Name_Internal(fstring, fstring2, InName, fstring3));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x00039EDC File Offset: 0x000380DC
		public unsafe static string BuildString_IntVector(string AppendTo, string Prefix, FIntVector InIntVector, string Suffix)
		{
			FString fstring = FString.AllocTemp(AppendTo);
			FString fstring2 = FString.AllocTemp(Prefix);
			FString fstring3 = FString.AllocTemp(Suffix);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__BuildString_IntVector_Internal(fstring, fstring2, InIntVector, fstring3));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x00039F2C File Offset: 0x0003812C
		public unsafe static string BuildString_Int(string AppendTo, string Prefix, int InInt, string Suffix)
		{
			FString fstring = FString.AllocTemp(AppendTo);
			FString fstring2 = FString.AllocTemp(Prefix);
			FString fstring3 = FString.AllocTemp(Suffix);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__BuildString_Int_Internal(fstring, fstring2, InInt, fstring3));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x00039F7C File Offset: 0x0003817C
		public unsafe static string BuildString_Float(string AppendTo, string Prefix, float InFloat, string Suffix)
		{
			FString fstring = FString.AllocTemp(AppendTo);
			FString fstring2 = FString.AllocTemp(Prefix);
			FString fstring3 = FString.AllocTemp(Suffix);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__BuildString_Float_Internal(fstring, fstring2, InFloat, fstring3));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x06002A5D RID: 10845 RVA: 0x00039FCC File Offset: 0x000381CC
		public unsafe static string BuildString_Color(string AppendTo, string Prefix, FLinearColor InColor, string Suffix)
		{
			FString fstring = FString.AllocTemp(AppendTo);
			FString fstring2 = FString.AllocTemp(Prefix);
			FString fstring3 = FString.AllocTemp(Suffix);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__BuildString_Color_Internal(fstring, fstring2, InColor, fstring3));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x06002A5E RID: 10846 RVA: 0x0003A01C File Offset: 0x0003821C
		public unsafe static string BuildString_Bool(string AppendTo, string Prefix, bool InBool, string Suffix)
		{
			FString fstring = FString.AllocTemp(AppendTo);
			FString fstring2 = FString.AllocTemp(Prefix);
			FString fstring3 = FString.AllocTemp(Suffix);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__BuildString_Bool_Internal(fstring, fstring2, InBool, fstring3));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x06002A5F RID: 10847
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __TrimTrailing_Internal(in FString SourceString);

		// Token: 0x06002A60 RID: 10848
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Trim_Internal(in FString SourceString);

		// Token: 0x06002A61 RID: 10849
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ToUpper_Internal(in FString SourceString);

		// Token: 0x06002A62 RID: 10850
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ToLower_Internal(in FString SourceString);

		// Token: 0x06002A63 RID: 10851
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __TimeSecondsToString_Internal(float InSeconds);

		// Token: 0x06002A64 RID: 10852
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __StartsWith_Internal(in FString SourceString, in FString InPrefix, TEnumAsByte<ESearchCase> SearchCase);

		// Token: 0x06002A65 RID: 10853
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Split_Internal(in FString SourceString, in FString InStr, ref FString LeftS, ref FString RightS, TEnumAsByte<ESearchCase> SearchCase, TEnumAsByte<ESearchDir> SearchDir);

		// Token: 0x06002A66 RID: 10854
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __RightPad_Internal(in FString SourceString, int ChCount);

		// Token: 0x06002A67 RID: 10855
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __RightChop_Internal(in FString SourceString, int Count);

		// Token: 0x06002A68 RID: 10856
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Right_Internal(in FString SourceString, int Count);

		// Token: 0x06002A69 RID: 10857
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Reverse_Internal(in FString SourceString);

		// Token: 0x06002A6A RID: 10858
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __ReplaceInline_Internal(ref FString SourceString, in FString SearchText, in FString ReplacementText, TEnumAsByte<ESearchCase> SearchCase);

		// Token: 0x06002A6B RID: 10859
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Replace_Internal(in FString SourceString, in FString From, in FString To, TEnumAsByte<ESearchCase> SearchCase);

		// Token: 0x06002A6C RID: 10860
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ParseIntoArray_Internal(in FString SourceString, in FString Delimiter, bool CullEmptyStrings);

		// Token: 0x06002A6D RID: 10861
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_StrStr_Internal(in FString A, in FString B);

		// Token: 0x06002A6E RID: 10862
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_StriStri_Internal(in FString A, in FString B);

		// Token: 0x06002A6F RID: 10863
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Mid_Internal(in FString SourceString, int Start, int Count);

		// Token: 0x06002A70 RID: 10864
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MatchesWildcard_Internal(in FString SourceString, in FString Wildcard, TEnumAsByte<ESearchCase> SearchCase);

		// Token: 0x06002A71 RID: 10865
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __LenInUTF8_Internal(in FString S);

		// Token: 0x06002A72 RID: 10866
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __Len_Internal(in FString S);

		// Token: 0x06002A73 RID: 10867
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __LeftPad_Internal(in FString SourceString, int ChCount);

		// Token: 0x06002A74 RID: 10868
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __LeftChop_Internal(in FString SourceString, int Count);

		// Token: 0x06002A75 RID: 10869
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Left_Internal(in FString SourceString, int Count);

		// Token: 0x06002A76 RID: 10870
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __JoinStringArray_Internal(IntPtr SourceArray, in FString Separator);

		// Token: 0x06002A77 RID: 10871
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsNumeric_Internal(in FString SourceString);

		// Token: 0x06002A78 RID: 10872
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEmpty_Internal(in FString InString);

		// Token: 0x06002A79 RID: 10873
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSubstring_Internal(in FString SourceString, int StartIndex, int Length);

		// Token: 0x06002A7A RID: 10874
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCharacterAsNumber_Internal(in FString SourceString, int Index);

		// Token: 0x06002A7B RID: 10875
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCharacterArrayFromString_Internal(in FString SourceString);

		// Token: 0x06002A7C RID: 10876
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __FindSubstring_Internal(in FString SearchIn, in FString Substring, bool bUseCase, bool bSearchFromEnd, int StartPosition);

		// Token: 0x06002A7D RID: 10877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_StrStr_Internal(in FString A, in FString B);

		// Token: 0x06002A7E RID: 10878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_StriStri_Internal(in FString A, in FString B);

		// Token: 0x06002A7F RID: 10879
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EndsWith_Internal(in FString SourceString, in FString InSuffix, TEnumAsByte<ESearchCase> SearchCase);

		// Token: 0x06002A80 RID: 10880
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __D_Conv_VectorToString_Internal(FVectorDouble InVec);

		// Token: 0x06002A81 RID: 10881
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __D_Conv_TransformToString_Internal(in FTransformDouble InTrans);

		// Token: 0x06002A82 RID: 10882
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __D_Conv_FloatToString_Internal(double InDouble);

		// Token: 0x06002A83 RID: 10883
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __CullArray_Internal(in FString SourceString, IntPtr InArray);

		// Token: 0x06002A84 RID: 10884
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_VectorToString_Internal(FVector InVec);

		// Token: 0x06002A85 RID: 10885
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_Vector2dToString_Internal(FVector2D InVec);

		// Token: 0x06002A86 RID: 10886
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_Vector2dDoubleToString_Internal(FVector2DDouble InVec);

		// Token: 0x06002A87 RID: 10887
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_TransformToString_Internal(in FTransform InTrans);

		// Token: 0x06002A88 RID: 10888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Conv_StringToVector2D_Internal(in FString InString, ref FVector2D OutConvertedVector2D, ref bool OutIsValid);

		// Token: 0x06002A89 RID: 10889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Conv_StringToVector_Internal(in FString InString, ref FVector OutConvertedVector, ref bool OutIsValid);

		// Token: 0x06002A8A RID: 10890
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Conv_StringToRotator_Internal(in FString InString, ref FRotator OutConvertedRotator, ref bool OutIsValid);

		// Token: 0x06002A8B RID: 10891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __Conv_StringToName_Internal(in FString InString);

		// Token: 0x06002A8C RID: 10892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long __Conv_StringToInt64_Internal(in FString InString);

		// Token: 0x06002A8D RID: 10893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __Conv_StringToInt_Internal(in FString InString);

		// Token: 0x06002A8E RID: 10894
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Conv_StringToFloat_Internal(in FString InString);

		// Token: 0x06002A8F RID: 10895
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Conv_StringToColor_Internal(in FString InString, ref FLinearColor OutConvertedColor, ref bool OutIsValid);

		// Token: 0x06002A90 RID: 10896
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_RotatorToString_Internal(FRotator InRot);

		// Token: 0x06002A91 RID: 10897
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_ObjectToString_Internal(IntPtr InObj);

		// Token: 0x06002A92 RID: 10898
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_NameToString_Internal(FName InName);

		// Token: 0x06002A93 RID: 10899
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_MatrixToString_Internal(in FMatrix InMatrix);

		// Token: 0x06002A94 RID: 10900
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_IntVectorToString_Internal(FIntVector InIntVec);

		// Token: 0x06002A95 RID: 10901
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_IntToString_Internal(int InInt);

		// Token: 0x06002A96 RID: 10902
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_IntPointToString_Internal(FIntPoint InIntPoint);

		// Token: 0x06002A97 RID: 10903
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_Int64ToString_Internal(long InInt64);

		// Token: 0x06002A98 RID: 10904
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_FloatToString_Internal(float InFloat);

		// Token: 0x06002A99 RID: 10905
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_ColorToString_Internal(FLinearColor InColor);

		// Token: 0x06002A9A RID: 10906
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_ByteToString_Internal(byte InByte);

		// Token: 0x06002A9B RID: 10907
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_BoolToString_Internal(bool InBool);

		// Token: 0x06002A9C RID: 10908
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Contains_Internal(in FString SearchIn, in FString Substring, bool bUseCase, bool bSearchFromEnd);

		// Token: 0x06002A9D RID: 10909
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Concat_StrStr_Internal(in FString A, in FString B);

		// Token: 0x06002A9E RID: 10910
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BuildString_Vector2d_Internal(in FString AppendTo, in FString Prefix, FVector2D InVector2d, in FString Suffix);

		// Token: 0x06002A9F RID: 10911
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BuildString_Vector_Internal(in FString AppendTo, in FString Prefix, FVector InVector, in FString Suffix);

		// Token: 0x06002AA0 RID: 10912
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BuildString_Rotator_Internal(in FString AppendTo, in FString Prefix, FRotator InRot, in FString Suffix);

		// Token: 0x06002AA1 RID: 10913
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BuildString_Object_Internal(in FString AppendTo, in FString Prefix, IntPtr InObj, in FString Suffix);

		// Token: 0x06002AA2 RID: 10914
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BuildString_Name_Internal(in FString AppendTo, in FString Prefix, FName InName, in FString Suffix);

		// Token: 0x06002AA3 RID: 10915
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BuildString_IntVector_Internal(in FString AppendTo, in FString Prefix, FIntVector InIntVector, in FString Suffix);

		// Token: 0x06002AA4 RID: 10916
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BuildString_Int_Internal(in FString AppendTo, in FString Prefix, int InInt, in FString Suffix);

		// Token: 0x06002AA5 RID: 10917
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BuildString_Float_Internal(in FString AppendTo, in FString Prefix, float InFloat, in FString Suffix);

		// Token: 0x06002AA6 RID: 10918
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BuildString_Color_Internal(in FString AppendTo, in FString Prefix, FLinearColor InColor, in FString Suffix);

		// Token: 0x06002AA7 RID: 10919
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BuildString_Bool_Internal(in FString AppendTo, in FString Prefix, bool InBool, in FString Suffix);

		// Token: 0x06002AA8 RID: 10920 RVA: 0x0003A06A File Offset: 0x0003826A
		static UKismetStringLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KismetStringLibrary");
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x0003A078 File Offset: 0x00038278
		protected UKismetStringLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E1A RID: 3610
		public new const string __ObjectPath = "/Script/Engine.KismetStringLibrary";

		// Token: 0x04000E1B RID: 3611
		private static IntPtr _ClassPtr;

		// Token: 0x04000E1C RID: 3612
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
