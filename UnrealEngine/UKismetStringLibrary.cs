using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CD4 RID: 3284
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KismetStringLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetStringLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AB0B RID: 43787 RVA: 0x000F0688 File Offset: 0x000EE888
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetStringLibrary._ClassPtr;
		}

		// Token: 0x0600AB0C RID: 43788 RVA: 0x000F0694 File Offset: 0x000EE894
		public UKismetStringLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetStringLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AB0D RID: 43789 RVA: 0x000F06BC File Offset: 0x000EE8BC
		public UKismetStringLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetStringLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600AB0E RID: 43790 RVA: 0x000F06F0 File Offset: 0x000EE8F0
		public unsafe static string TrimTrailing(string SourceString)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__TrimTrailing_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB0F RID: 43791 RVA: 0x000F071C File Offset: 0x000EE91C
		public unsafe static string Trim(string SourceString)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Trim_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB10 RID: 43792 RVA: 0x000F0748 File Offset: 0x000EE948
		public unsafe static string ToUpper(string SourceString)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__ToUpper_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB11 RID: 43793 RVA: 0x000F0774 File Offset: 0x000EE974
		public unsafe static string ToLower(string SourceString)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__ToLower_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB12 RID: 43794 RVA: 0x000F079D File Offset: 0x000EE99D
		public static string TimeSecondsToString(float InSeconds)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__TimeSecondsToString_Internal(InSeconds));
		}

		// Token: 0x0600AB13 RID: 43795 RVA: 0x000F07AC File Offset: 0x000EE9AC
		public unsafe static bool StartsWith(string SourceString, string InPrefix, ESearchCase SearchCase = ESearchCase.IgnoreCase)
		{
			FString fstring = FString.AllocTemp(SourceString);
			FString fstring2 = FString.AllocTemp(InPrefix);
			bool result = UKismetStringLibrary.__StartsWith_Internal(fstring, fstring2, SearchCase);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600AB14 RID: 43796 RVA: 0x000F07E8 File Offset: 0x000EE9E8
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

		// Token: 0x0600AB15 RID: 43797 RVA: 0x000F0864 File Offset: 0x000EEA64
		public unsafe static string RightPad(string SourceString, int ChCount)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__RightPad_Internal(fstring, ChCount));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB16 RID: 43798 RVA: 0x000F0890 File Offset: 0x000EEA90
		public unsafe static string RightChop(string SourceString, int Count)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__RightChop_Internal(fstring, Count));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB17 RID: 43799 RVA: 0x000F08BC File Offset: 0x000EEABC
		public unsafe static string Right(string SourceString, int Count)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Right_Internal(fstring, Count));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB18 RID: 43800 RVA: 0x000F08E8 File Offset: 0x000EEAE8
		public unsafe static string Reverse(string SourceString)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Reverse_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB19 RID: 43801 RVA: 0x000F0914 File Offset: 0x000EEB14
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

		// Token: 0x0600AB1A RID: 43802 RVA: 0x000F096C File Offset: 0x000EEB6C
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

		// Token: 0x0600AB1B RID: 43803 RVA: 0x000F09C0 File Offset: 0x000EEBC0
		public unsafe static TArray<string> ParseIntoArray(string SourceString, string Delimiter = " ", bool CullEmptyStrings = true)
		{
			FString fstring = FString.AllocTemp(SourceString);
			FString fstring2 = FString.AllocTemp(Delimiter);
			TArray<string> result = new TArray<string>(UKismetStringLibrary.__ParseIntoArray_Internal(fstring, fstring2, CullEmptyStrings), null);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600AB1C RID: 43804 RVA: 0x000F0A00 File Offset: 0x000EEC00
		public unsafe static bool NotEqual_StrStr(string A, string B)
		{
			FString fstring = FString.AllocTemp(A);
			FString fstring2 = FString.AllocTemp(B);
			bool result = UKismetStringLibrary.__NotEqual_StrStr_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600AB1D RID: 43805 RVA: 0x000F0A38 File Offset: 0x000EEC38
		public unsafe static bool NotEqual_StriStri(string A, string B)
		{
			FString fstring = FString.AllocTemp(A);
			FString fstring2 = FString.AllocTemp(B);
			bool result = UKismetStringLibrary.__NotEqual_StriStri_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600AB1E RID: 43806 RVA: 0x000F0A70 File Offset: 0x000EEC70
		public unsafe static string Mid(string SourceString, int Start, int Count)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Mid_Internal(fstring, Start, Count));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB1F RID: 43807 RVA: 0x000F0A9C File Offset: 0x000EEC9C
		public unsafe static bool MatchesWildcard(string SourceString, string Wildcard, ESearchCase SearchCase = ESearchCase.IgnoreCase)
		{
			FString fstring = FString.AllocTemp(SourceString);
			FString fstring2 = FString.AllocTemp(Wildcard);
			bool result = UKismetStringLibrary.__MatchesWildcard_Internal(fstring, fstring2, SearchCase);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600AB20 RID: 43808 RVA: 0x000F0AD8 File Offset: 0x000EECD8
		public unsafe static int LenInUTF8(string S)
		{
			FString fstring = FString.AllocTemp(S);
			int result = UKismetStringLibrary.__LenInUTF8_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB21 RID: 43809 RVA: 0x000F0AFC File Offset: 0x000EECFC
		public unsafe static int Len(string S)
		{
			FString fstring = FString.AllocTemp(S);
			int result = UKismetStringLibrary.__Len_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB22 RID: 43810 RVA: 0x000F0B20 File Offset: 0x000EED20
		public unsafe static string LeftPad(string SourceString, int ChCount)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__LeftPad_Internal(fstring, ChCount));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB23 RID: 43811 RVA: 0x000F0B4C File Offset: 0x000EED4C
		public unsafe static string LeftChop(string SourceString, int Count)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__LeftChop_Internal(fstring, Count));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB24 RID: 43812 RVA: 0x000F0B78 File Offset: 0x000EED78
		public unsafe static string Left(string SourceString, int Count)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Left_Internal(fstring, Count));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB25 RID: 43813 RVA: 0x000F0BA4 File Offset: 0x000EEDA4
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

		// Token: 0x0600AB26 RID: 43814 RVA: 0x000F0BE0 File Offset: 0x000EEDE0
		public unsafe static bool IsNumeric(string SourceString)
		{
			FString fstring = FString.AllocTemp(SourceString);
			bool result = UKismetStringLibrary.__IsNumeric_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB27 RID: 43815 RVA: 0x000F0C04 File Offset: 0x000EEE04
		public unsafe static bool IsEmpty(string InString)
		{
			FString fstring = FString.AllocTemp(InString);
			bool result = UKismetStringLibrary.__IsEmpty_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB28 RID: 43816 RVA: 0x000F0C28 File Offset: 0x000EEE28
		public unsafe static string GetSubstring(string SourceString, int StartIndex = 0, int Length = 1)
		{
			FString fstring = FString.AllocTemp(SourceString);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__GetSubstring_Internal(fstring, StartIndex, Length));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB29 RID: 43817 RVA: 0x000F0C54 File Offset: 0x000EEE54
		public unsafe static int GetCharacterAsNumber(string SourceString, int Index = 0)
		{
			FString fstring = FString.AllocTemp(SourceString);
			int result = UKismetStringLibrary.__GetCharacterAsNumber_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB2A RID: 43818 RVA: 0x000F0C7C File Offset: 0x000EEE7C
		public unsafe static TArray<string> GetCharacterArrayFromString(string SourceString)
		{
			FString fstring = FString.AllocTemp(SourceString);
			TArray<string> result = new TArray<string>(UKismetStringLibrary.__GetCharacterArrayFromString_Internal(fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB2B RID: 43819 RVA: 0x000F0CA8 File Offset: 0x000EEEA8
		public unsafe static int FindSubstring(string SearchIn, string Substring, bool bUseCase = false, bool bSearchFromEnd = false, int StartPosition = -1)
		{
			FString fstring = FString.AllocTemp(SearchIn);
			FString fstring2 = FString.AllocTemp(Substring);
			int result = UKismetStringLibrary.__FindSubstring_Internal(fstring, fstring2, bUseCase, bSearchFromEnd, StartPosition);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600AB2C RID: 43820 RVA: 0x000F0CE4 File Offset: 0x000EEEE4
		public unsafe static bool EqualEqual_StrStr(string A, string B)
		{
			FString fstring = FString.AllocTemp(A);
			FString fstring2 = FString.AllocTemp(B);
			bool result = UKismetStringLibrary.__EqualEqual_StrStr_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600AB2D RID: 43821 RVA: 0x000F0D1C File Offset: 0x000EEF1C
		public unsafe static bool EqualEqual_StriStri(string A, string B)
		{
			FString fstring = FString.AllocTemp(A);
			FString fstring2 = FString.AllocTemp(B);
			bool result = UKismetStringLibrary.__EqualEqual_StriStri_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600AB2E RID: 43822 RVA: 0x000F0D54 File Offset: 0x000EEF54
		public unsafe static bool EndsWith(string SourceString, string InSuffix, ESearchCase SearchCase = ESearchCase.IgnoreCase)
		{
			FString fstring = FString.AllocTemp(SourceString);
			FString fstring2 = FString.AllocTemp(InSuffix);
			bool result = UKismetStringLibrary.__EndsWith_Internal(fstring, fstring2, SearchCase);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600AB2F RID: 43823 RVA: 0x000F0D90 File Offset: 0x000EEF90
		public static string D_Conv_VectorToString(FVectorDouble InVec)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__D_Conv_VectorToString_Internal(InVec));
		}

		// Token: 0x0600AB30 RID: 43824 RVA: 0x000F0DA0 File Offset: 0x000EEFA0
		public unsafe static string D_Conv_TransformToString(in FTransformDouble InTrans)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = InTrans;
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__D_Conv_TransformToString_Internal(uintPtr));
		}

		// Token: 0x0600AB31 RID: 43825 RVA: 0x000F0DD2 File Offset: 0x000EEFD2
		public static string D_Conv_FloatToString(double InDouble)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__D_Conv_FloatToString_Internal(InDouble));
		}

		// Token: 0x0600AB32 RID: 43826 RVA: 0x000F0DE0 File Offset: 0x000EEFE0
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

		// Token: 0x0600AB33 RID: 43827 RVA: 0x000F0E14 File Offset: 0x000EF014
		public static string Conv_VectorToString(FVector InVec)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_VectorToString_Internal(InVec));
		}

		// Token: 0x0600AB34 RID: 43828 RVA: 0x000F0E21 File Offset: 0x000EF021
		public static string Conv_Vector2dToString(FVector2D InVec)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_Vector2dToString_Internal(InVec));
		}

		// Token: 0x0600AB35 RID: 43829 RVA: 0x000F0E2E File Offset: 0x000EF02E
		public static string Conv_Vector2dDoubleToString(FVector2DDouble InVec)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_Vector2dDoubleToString_Internal(InVec));
		}

		// Token: 0x0600AB36 RID: 43830 RVA: 0x000F0E3C File Offset: 0x000EF03C
		public unsafe static string Conv_TransformToString(in FTransform InTrans)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = InTrans;
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_TransformToString_Internal(uintPtr));
		}

		// Token: 0x0600AB37 RID: 43831 RVA: 0x000F0E70 File Offset: 0x000EF070
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

		// Token: 0x0600AB38 RID: 43832 RVA: 0x000F0EAC File Offset: 0x000EF0AC
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

		// Token: 0x0600AB39 RID: 43833 RVA: 0x000F0EE8 File Offset: 0x000EF0E8
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

		// Token: 0x0600AB3A RID: 43834 RVA: 0x000F0F24 File Offset: 0x000EF124
		public unsafe static FName Conv_StringToName(string InString)
		{
			FString fstring = FString.AllocTemp(InString);
			FName result = UKismetStringLibrary.__Conv_StringToName_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB3B RID: 43835 RVA: 0x000F0F48 File Offset: 0x000EF148
		public unsafe static long Conv_StringToInt64(string InString)
		{
			FString fstring = FString.AllocTemp(InString);
			long result = UKismetStringLibrary.__Conv_StringToInt64_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB3C RID: 43836 RVA: 0x000F0F6C File Offset: 0x000EF16C
		public unsafe static int Conv_StringToInt(string InString)
		{
			FString fstring = FString.AllocTemp(InString);
			int result = UKismetStringLibrary.__Conv_StringToInt_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB3D RID: 43837 RVA: 0x000F0F90 File Offset: 0x000EF190
		public unsafe static float Conv_StringToFloat(string InString)
		{
			FString fstring = FString.AllocTemp(InString);
			float result = UKismetStringLibrary.__Conv_StringToFloat_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AB3E RID: 43838 RVA: 0x000F0FB4 File Offset: 0x000EF1B4
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

		// Token: 0x0600AB3F RID: 43839 RVA: 0x000F0FED File Offset: 0x000EF1ED
		public static string Conv_RotatorToString(FRotator InRot)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_RotatorToString_Internal(InRot));
		}

		// Token: 0x0600AB40 RID: 43840 RVA: 0x000F0FFA File Offset: 0x000EF1FA
		public static string Conv_ObjectToString([Nullable(2)] UObject InObj)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_ObjectToString_Internal((InObj != null) ? InObj.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600AB41 RID: 43841 RVA: 0x000F1016 File Offset: 0x000EF216
		public static string Conv_NameToString(FName InName)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_NameToString_Internal(InName));
		}

		// Token: 0x0600AB42 RID: 43842 RVA: 0x000F1024 File Offset: 0x000EF224
		public unsafe static string Conv_MatrixToString(in FMatrix InMatrix)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = InMatrix;
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_MatrixToString_Internal(uintPtr));
		}

		// Token: 0x0600AB43 RID: 43843 RVA: 0x000F1056 File Offset: 0x000EF256
		public static string Conv_IntVectorToString(FIntVector InIntVec)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_IntVectorToString_Internal(InIntVec));
		}

		// Token: 0x0600AB44 RID: 43844 RVA: 0x000F1063 File Offset: 0x000EF263
		public static string Conv_IntToString(int InInt)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_IntToString_Internal(InInt));
		}

		// Token: 0x0600AB45 RID: 43845 RVA: 0x000F1070 File Offset: 0x000EF270
		public static string Conv_IntPointToString(FIntPoint InIntPoint)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_IntPointToString_Internal(InIntPoint));
		}

		// Token: 0x0600AB46 RID: 43846 RVA: 0x000F107D File Offset: 0x000EF27D
		public static string Conv_Int64ToString(long InInt64)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_Int64ToString_Internal(InInt64));
		}

		// Token: 0x0600AB47 RID: 43847 RVA: 0x000F108A File Offset: 0x000EF28A
		public static string Conv_FloatToString(float InFloat)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_FloatToString_Internal(InFloat));
		}

		// Token: 0x0600AB48 RID: 43848 RVA: 0x000F1097 File Offset: 0x000EF297
		public static string Conv_ColorToString(FLinearColor InColor)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_ColorToString_Internal(InColor));
		}

		// Token: 0x0600AB49 RID: 43849 RVA: 0x000F10A4 File Offset: 0x000EF2A4
		public static string Conv_ByteToString(byte InByte)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_ByteToString_Internal(InByte));
		}

		// Token: 0x0600AB4A RID: 43850 RVA: 0x000F10B1 File Offset: 0x000EF2B1
		public static string Conv_BoolToString(bool InBool)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Conv_BoolToString_Internal(InBool));
		}

		// Token: 0x0600AB4B RID: 43851 RVA: 0x000F10C0 File Offset: 0x000EF2C0
		public unsafe static bool Contains(string SearchIn, string Substring, bool bUseCase = false, bool bSearchFromEnd = false)
		{
			FString fstring = FString.AllocTemp(SearchIn);
			FString fstring2 = FString.AllocTemp(Substring);
			bool result = UKismetStringLibrary.__Contains_Internal(fstring, fstring2, bUseCase, bSearchFromEnd);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600AB4C RID: 43852 RVA: 0x000F10F8 File Offset: 0x000EF2F8
		public unsafe static string Concat_StrStr(string A, string B)
		{
			FString fstring = FString.AllocTemp(A);
			FString fstring2 = FString.AllocTemp(B);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringLibrary.__Concat_StrStr_Internal(fstring, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600AB4D RID: 43853 RVA: 0x000F1134 File Offset: 0x000EF334
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

		// Token: 0x0600AB4E RID: 43854 RVA: 0x000F1184 File Offset: 0x000EF384
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

		// Token: 0x0600AB4F RID: 43855 RVA: 0x000F11D4 File Offset: 0x000EF3D4
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

		// Token: 0x0600AB50 RID: 43856 RVA: 0x000F1224 File Offset: 0x000EF424
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

		// Token: 0x0600AB51 RID: 43857 RVA: 0x000F1284 File Offset: 0x000EF484
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

		// Token: 0x0600AB52 RID: 43858 RVA: 0x000F12D4 File Offset: 0x000EF4D4
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

		// Token: 0x0600AB53 RID: 43859 RVA: 0x000F1324 File Offset: 0x000EF524
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

		// Token: 0x0600AB54 RID: 43860 RVA: 0x000F1374 File Offset: 0x000EF574
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

		// Token: 0x0600AB55 RID: 43861 RVA: 0x000F13C4 File Offset: 0x000EF5C4
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

		// Token: 0x0600AB56 RID: 43862 RVA: 0x000F1414 File Offset: 0x000EF614
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

		// Token: 0x0600AB57 RID: 43863
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __TrimTrailing_Internal(in FString SourceString);

		// Token: 0x0600AB58 RID: 43864
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Trim_Internal(in FString SourceString);

		// Token: 0x0600AB59 RID: 43865
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ToUpper_Internal(in FString SourceString);

		// Token: 0x0600AB5A RID: 43866
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ToLower_Internal(in FString SourceString);

		// Token: 0x0600AB5B RID: 43867
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __TimeSecondsToString_Internal(float InSeconds);

		// Token: 0x0600AB5C RID: 43868
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __StartsWith_Internal(in FString SourceString, in FString InPrefix, TEnumAsByte<ESearchCase> SearchCase);

		// Token: 0x0600AB5D RID: 43869
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Split_Internal(in FString SourceString, in FString InStr, ref FString LeftS, ref FString RightS, TEnumAsByte<ESearchCase> SearchCase, TEnumAsByte<ESearchDir> SearchDir);

		// Token: 0x0600AB5E RID: 43870
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __RightPad_Internal(in FString SourceString, int ChCount);

		// Token: 0x0600AB5F RID: 43871
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __RightChop_Internal(in FString SourceString, int Count);

		// Token: 0x0600AB60 RID: 43872
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Right_Internal(in FString SourceString, int Count);

		// Token: 0x0600AB61 RID: 43873
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Reverse_Internal(in FString SourceString);

		// Token: 0x0600AB62 RID: 43874
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __ReplaceInline_Internal(ref FString SourceString, in FString SearchText, in FString ReplacementText, TEnumAsByte<ESearchCase> SearchCase);

		// Token: 0x0600AB63 RID: 43875
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Replace_Internal(in FString SourceString, in FString From, in FString To, TEnumAsByte<ESearchCase> SearchCase);

		// Token: 0x0600AB64 RID: 43876
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ParseIntoArray_Internal(in FString SourceString, in FString Delimiter, bool CullEmptyStrings);

		// Token: 0x0600AB65 RID: 43877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_StrStr_Internal(in FString A, in FString B);

		// Token: 0x0600AB66 RID: 43878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_StriStri_Internal(in FString A, in FString B);

		// Token: 0x0600AB67 RID: 43879
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Mid_Internal(in FString SourceString, int Start, int Count);

		// Token: 0x0600AB68 RID: 43880
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MatchesWildcard_Internal(in FString SourceString, in FString Wildcard, TEnumAsByte<ESearchCase> SearchCase);

		// Token: 0x0600AB69 RID: 43881
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __LenInUTF8_Internal(in FString S);

		// Token: 0x0600AB6A RID: 43882
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __Len_Internal(in FString S);

		// Token: 0x0600AB6B RID: 43883
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __LeftPad_Internal(in FString SourceString, int ChCount);

		// Token: 0x0600AB6C RID: 43884
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __LeftChop_Internal(in FString SourceString, int Count);

		// Token: 0x0600AB6D RID: 43885
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Left_Internal(in FString SourceString, int Count);

		// Token: 0x0600AB6E RID: 43886
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __JoinStringArray_Internal(IntPtr SourceArray, in FString Separator);

		// Token: 0x0600AB6F RID: 43887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsNumeric_Internal(in FString SourceString);

		// Token: 0x0600AB70 RID: 43888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEmpty_Internal(in FString InString);

		// Token: 0x0600AB71 RID: 43889
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSubstring_Internal(in FString SourceString, int StartIndex, int Length);

		// Token: 0x0600AB72 RID: 43890
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCharacterAsNumber_Internal(in FString SourceString, int Index);

		// Token: 0x0600AB73 RID: 43891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCharacterArrayFromString_Internal(in FString SourceString);

		// Token: 0x0600AB74 RID: 43892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __FindSubstring_Internal(in FString SearchIn, in FString Substring, bool bUseCase, bool bSearchFromEnd, int StartPosition);

		// Token: 0x0600AB75 RID: 43893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_StrStr_Internal(in FString A, in FString B);

		// Token: 0x0600AB76 RID: 43894
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_StriStri_Internal(in FString A, in FString B);

		// Token: 0x0600AB77 RID: 43895
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EndsWith_Internal(in FString SourceString, in FString InSuffix, TEnumAsByte<ESearchCase> SearchCase);

		// Token: 0x0600AB78 RID: 43896
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __D_Conv_VectorToString_Internal(FVectorDouble InVec);

		// Token: 0x0600AB79 RID: 43897
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __D_Conv_TransformToString_Internal(in FTransformDouble InTrans);

		// Token: 0x0600AB7A RID: 43898
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __D_Conv_FloatToString_Internal(double InDouble);

		// Token: 0x0600AB7B RID: 43899
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __CullArray_Internal(in FString SourceString, IntPtr InArray);

		// Token: 0x0600AB7C RID: 43900
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_VectorToString_Internal(FVector InVec);

		// Token: 0x0600AB7D RID: 43901
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_Vector2dToString_Internal(FVector2D InVec);

		// Token: 0x0600AB7E RID: 43902
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_Vector2dDoubleToString_Internal(FVector2DDouble InVec);

		// Token: 0x0600AB7F RID: 43903
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_TransformToString_Internal(in FTransform InTrans);

		// Token: 0x0600AB80 RID: 43904
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Conv_StringToVector2D_Internal(in FString InString, ref FVector2D OutConvertedVector2D, ref bool OutIsValid);

		// Token: 0x0600AB81 RID: 43905
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Conv_StringToVector_Internal(in FString InString, ref FVector OutConvertedVector, ref bool OutIsValid);

		// Token: 0x0600AB82 RID: 43906
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Conv_StringToRotator_Internal(in FString InString, ref FRotator OutConvertedRotator, ref bool OutIsValid);

		// Token: 0x0600AB83 RID: 43907
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __Conv_StringToName_Internal(in FString InString);

		// Token: 0x0600AB84 RID: 43908
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long __Conv_StringToInt64_Internal(in FString InString);

		// Token: 0x0600AB85 RID: 43909
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __Conv_StringToInt_Internal(in FString InString);

		// Token: 0x0600AB86 RID: 43910
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Conv_StringToFloat_Internal(in FString InString);

		// Token: 0x0600AB87 RID: 43911
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Conv_StringToColor_Internal(in FString InString, ref FLinearColor OutConvertedColor, ref bool OutIsValid);

		// Token: 0x0600AB88 RID: 43912
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_RotatorToString_Internal(FRotator InRot);

		// Token: 0x0600AB89 RID: 43913
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_ObjectToString_Internal(IntPtr InObj);

		// Token: 0x0600AB8A RID: 43914
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_NameToString_Internal(FName InName);

		// Token: 0x0600AB8B RID: 43915
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_MatrixToString_Internal(in FMatrix InMatrix);

		// Token: 0x0600AB8C RID: 43916
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_IntVectorToString_Internal(FIntVector InIntVec);

		// Token: 0x0600AB8D RID: 43917
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_IntToString_Internal(int InInt);

		// Token: 0x0600AB8E RID: 43918
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_IntPointToString_Internal(FIntPoint InIntPoint);

		// Token: 0x0600AB8F RID: 43919
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_Int64ToString_Internal(long InInt64);

		// Token: 0x0600AB90 RID: 43920
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_FloatToString_Internal(float InFloat);

		// Token: 0x0600AB91 RID: 43921
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_ColorToString_Internal(FLinearColor InColor);

		// Token: 0x0600AB92 RID: 43922
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_ByteToString_Internal(byte InByte);

		// Token: 0x0600AB93 RID: 43923
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_BoolToString_Internal(bool InBool);

		// Token: 0x0600AB94 RID: 43924
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Contains_Internal(in FString SearchIn, in FString Substring, bool bUseCase, bool bSearchFromEnd);

		// Token: 0x0600AB95 RID: 43925
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Concat_StrStr_Internal(in FString A, in FString B);

		// Token: 0x0600AB96 RID: 43926
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BuildString_Vector2d_Internal(in FString AppendTo, in FString Prefix, FVector2D InVector2d, in FString Suffix);

		// Token: 0x0600AB97 RID: 43927
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BuildString_Vector_Internal(in FString AppendTo, in FString Prefix, FVector InVector, in FString Suffix);

		// Token: 0x0600AB98 RID: 43928
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BuildString_Rotator_Internal(in FString AppendTo, in FString Prefix, FRotator InRot, in FString Suffix);

		// Token: 0x0600AB99 RID: 43929
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BuildString_Object_Internal(in FString AppendTo, in FString Prefix, IntPtr InObj, in FString Suffix);

		// Token: 0x0600AB9A RID: 43930
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BuildString_Name_Internal(in FString AppendTo, in FString Prefix, FName InName, in FString Suffix);

		// Token: 0x0600AB9B RID: 43931
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BuildString_IntVector_Internal(in FString AppendTo, in FString Prefix, FIntVector InIntVector, in FString Suffix);

		// Token: 0x0600AB9C RID: 43932
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BuildString_Int_Internal(in FString AppendTo, in FString Prefix, int InInt, in FString Suffix);

		// Token: 0x0600AB9D RID: 43933
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BuildString_Float_Internal(in FString AppendTo, in FString Prefix, float InFloat, in FString Suffix);

		// Token: 0x0600AB9E RID: 43934
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BuildString_Color_Internal(in FString AppendTo, in FString Prefix, FLinearColor InColor, in FString Suffix);

		// Token: 0x0600AB9F RID: 43935
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BuildString_Bool_Internal(in FString AppendTo, in FString Prefix, bool InBool, in FString Suffix);

		// Token: 0x0600ABA0 RID: 43936 RVA: 0x000F1462 File Offset: 0x000EF662
		static UKismetStringLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KismetStringLibrary");
		}

		// Token: 0x0600ABA1 RID: 43937 RVA: 0x000F1470 File Offset: 0x000EF670
		protected UKismetStringLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005B43 RID: 23363
		public new const string __ObjectPath = "/Script/Engine.KismetStringLibrary";

		// Token: 0x04005B44 RID: 23364
		private static IntPtr _ClassPtr;

		// Token: 0x04005B45 RID: 23365
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
