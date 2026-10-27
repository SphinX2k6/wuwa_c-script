using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CD7 RID: 3287
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KismetTextLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetTextLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600ADE8 RID: 44520 RVA: 0x000F6CA5 File Offset: 0x000F4EA5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetTextLibrary._ClassPtr;
		}

		// Token: 0x0600ADE9 RID: 44521 RVA: 0x000F6CB4 File Offset: 0x000F4EB4
		public UKismetTextLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetTextLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600ADEA RID: 44522 RVA: 0x000F6CDC File Offset: 0x000F4EDC
		public UKismetTextLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetTextLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600ADEB RID: 44523 RVA: 0x000F6D0F File Offset: 0x000F4F0F
		public static FText TextTrimTrailing(in FText InText)
		{
			FText ftext = InText;
			return new FText(UKismetTextLibrary.__TextTrimTrailing_Internal((ftext != null) ? ftext.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x0600ADEC RID: 44524 RVA: 0x000F6D2E File Offset: 0x000F4F2E
		public static FText TextTrimPrecedingAndTrailing(in FText InText)
		{
			FText ftext = InText;
			return new FText(UKismetTextLibrary.__TextTrimPrecedingAndTrailing_Internal((ftext != null) ? ftext.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x0600ADED RID: 44525 RVA: 0x000F6D4D File Offset: 0x000F4F4D
		public static FText TextTrimPreceding(in FText InText)
		{
			FText ftext = InText;
			return new FText(UKismetTextLibrary.__TextTrimPreceding_Internal((ftext != null) ? ftext.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x0600ADEE RID: 44526 RVA: 0x000F6D6C File Offset: 0x000F4F6C
		public static FText TextToUpper(in FText InText)
		{
			FText ftext = InText;
			return new FText(UKismetTextLibrary.__TextToUpper_Internal((ftext != null) ? ftext.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x0600ADEF RID: 44527 RVA: 0x000F6D8B File Offset: 0x000F4F8B
		public static FText TextToLower(in FText InText)
		{
			FText ftext = InText;
			return new FText(UKismetTextLibrary.__TextToLower_Internal((ftext != null) ? ftext.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x0600ADF0 RID: 44528 RVA: 0x000F6DAA File Offset: 0x000F4FAA
		public static bool TextIsTransient(in FText InText)
		{
			FText ftext = InText;
			return UKismetTextLibrary.__TextIsTransient_Internal((ftext != null) ? ftext.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600ADF1 RID: 44529 RVA: 0x000F6DC3 File Offset: 0x000F4FC3
		public static bool TextIsFromStringTable(in FText Text)
		{
			FText ftext = Text;
			return UKismetTextLibrary.__TextIsFromStringTable_Internal((ftext != null) ? ftext.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600ADF2 RID: 44530 RVA: 0x000F6DDC File Offset: 0x000F4FDC
		public static bool TextIsEmpty(in FText InText)
		{
			FText ftext = InText;
			return UKismetTextLibrary.__TextIsEmpty_Internal((ftext != null) ? ftext.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600ADF3 RID: 44531 RVA: 0x000F6DF5 File Offset: 0x000F4FF5
		public static bool TextIsCultureInvariant(in FText InText)
		{
			FText ftext = InText;
			return UKismetTextLibrary.__TextIsCultureInvariant_Internal((ftext != null) ? ftext.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600ADF4 RID: 44532 RVA: 0x000F6E10 File Offset: 0x000F5010
		public unsafe static FText TextFromStringTable(FName TableId, string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			FText result = new FText(UKismetTextLibrary.__TextFromStringTable_Internal(TableId, fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600ADF5 RID: 44533 RVA: 0x000F6E3C File Offset: 0x000F503C
		public unsafe static bool StringTableIdAndKeyFromText(FText Text, ref FName OutTableId, ref string OutKey)
		{
			FString fstring = FString.AllocTemp(OutKey);
			fixed (FName* ptr = &OutTableId)
			{
				void* ptr2 = (void*)ptr;
				bool result = UKismetTextLibrary.__StringTableIdAndKeyFromText_Internal((Text != null) ? Text.NativePtr : IntPtr.Zero, ref OutTableId, ref fstring);
				OutKey = FString.ToString(fstring);
				FString.NativeDestruct(&fstring, 1);
				return result;
			}
		}

		// Token: 0x0600ADF6 RID: 44534 RVA: 0x000F6E80 File Offset: 0x000F5080
		public static FText PolyglotDataToText([Nullable(2)] in FPolyglotTextData PolyglotData)
		{
			return new FText(UKismetTextLibrary.__PolyglotDataToText_Internal((PolyglotData ?? new FPolyglotTextData()).NativePtr), null);
		}

		// Token: 0x0600ADF7 RID: 44535 RVA: 0x000F6E9D File Offset: 0x000F509D
		public static bool NotEqual_TextText(in FText A, in FText B)
		{
			FText ftext = A;
			IntPtr a = (ftext != null) ? ftext.NativePtr : IntPtr.Zero;
			FText ftext2 = B;
			return UKismetTextLibrary.__NotEqual_TextText_Internal(a, (ftext2 != null) ? ftext2.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600ADF8 RID: 44536 RVA: 0x000F6EC8 File Offset: 0x000F50C8
		public static bool NotEqual_IgnoreCase_TextText(in FText A, in FText B)
		{
			FText ftext = A;
			IntPtr a = (ftext != null) ? ftext.NativePtr : IntPtr.Zero;
			FText ftext2 = B;
			return UKismetTextLibrary.__NotEqual_IgnoreCase_TextText_Internal(a, (ftext2 != null) ? ftext2.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600ADF9 RID: 44537 RVA: 0x000F6EF4 File Offset: 0x000F50F4
		public unsafe static void IsPolyglotDataValid([Nullable(2)] in FPolyglotTextData PolyglotData, ref bool IsValid, ref FText ErrorMessage)
		{
			fixed (bool* ptr = &IsValid)
			{
				void* ptr2 = (void*)ptr;
				IntPtr nativePtr = (PolyglotData ?? new FPolyglotTextData()).NativePtr;
				FText ftext = ErrorMessage;
				UKismetTextLibrary.__IsPolyglotDataValid_Internal(nativePtr, ref IsValid, (ftext != null) ? ftext.NativePtr : IntPtr.Zero);
			}
		}

		// Token: 0x0600ADFA RID: 44538 RVA: 0x000F6F31 File Offset: 0x000F5131
		public static FText GetEmptyText()
		{
			return new FText(UKismetTextLibrary.__GetEmptyText_Internal(), null);
		}

		// Token: 0x0600ADFB RID: 44539 RVA: 0x000F6F3E File Offset: 0x000F513E
		public static FText Format(FText InPattern, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<FFormatArgumentData> InArgs)
		{
			return new FText(UKismetTextLibrary.__Format_Internal((InPattern != null) ? InPattern.NativePtr : IntPtr.Zero, (InArgs ?? new TArray<FFormatArgumentData>()).NativePtr), null);
		}

		// Token: 0x0600ADFC RID: 44540 RVA: 0x000F6F6C File Offset: 0x000F516C
		public unsafe static bool FindTextInLocalizationTable(string Namespace, string Key, ref FText OutText)
		{
			FString fstring = FString.AllocTemp(Namespace);
			FString fstring2 = FString.AllocTemp(Key);
			FText ftext = OutText;
			bool result = UKismetTextLibrary.__FindTextInLocalizationTable_Internal(fstring, fstring2, (ftext != null) ? ftext.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600ADFD RID: 44541 RVA: 0x000F6FB4 File Offset: 0x000F51B4
		public static bool EqualEqual_TextText(in FText A, in FText B)
		{
			FText ftext = A;
			IntPtr a = (ftext != null) ? ftext.NativePtr : IntPtr.Zero;
			FText ftext2 = B;
			return UKismetTextLibrary.__EqualEqual_TextText_Internal(a, (ftext2 != null) ? ftext2.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600ADFE RID: 44542 RVA: 0x000F6FDF File Offset: 0x000F51DF
		public static bool EqualEqual_IgnoreCase_TextText(in FText A, in FText B)
		{
			FText ftext = A;
			IntPtr a = (ftext != null) ? ftext.NativePtr : IntPtr.Zero;
			FText ftext2 = B;
			return UKismetTextLibrary.__EqualEqual_IgnoreCase_TextText_Internal(a, (ftext2 != null) ? ftext2.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600ADFF RID: 44543 RVA: 0x000F700A File Offset: 0x000F520A
		public static FText Conv_VectorToText(FVector InVec)
		{
			return new FText(UKismetTextLibrary.__Conv_VectorToText_Internal(InVec), null);
		}

		// Token: 0x0600AE00 RID: 44544 RVA: 0x000F7018 File Offset: 0x000F5218
		public static FText Conv_Vector2dToText(FVector2D InVec)
		{
			return new FText(UKismetTextLibrary.__Conv_Vector2dToText_Internal(InVec), null);
		}

		// Token: 0x0600AE01 RID: 44545 RVA: 0x000F7028 File Offset: 0x000F5228
		public unsafe static FText Conv_TransformToText(in FTransform InTrans)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = InTrans;
			return new FText(UKismetTextLibrary.__Conv_TransformToText_Internal(uintPtr), null);
		}

		// Token: 0x0600AE02 RID: 44546 RVA: 0x000F705B File Offset: 0x000F525B
		public static string Conv_TextToString(in FText InText)
		{
			FText ftext = InText;
			return FString.ToStringAndDeleteNativePtr(UKismetTextLibrary.__Conv_TextToString_Internal((ftext != null) ? ftext.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600AE03 RID: 44547 RVA: 0x000F707C File Offset: 0x000F527C
		public unsafe static FText Conv_StringToText(string InString)
		{
			FString fstring = FString.AllocTemp(InString);
			FText result = new FText(UKismetTextLibrary.__Conv_StringToText_Internal(fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AE04 RID: 44548 RVA: 0x000F70A6 File Offset: 0x000F52A6
		public static FText Conv_RotatorToText(FRotator InRot)
		{
			return new FText(UKismetTextLibrary.__Conv_RotatorToText_Internal(InRot), null);
		}

		// Token: 0x0600AE05 RID: 44549 RVA: 0x000F70B4 File Offset: 0x000F52B4
		public static FText Conv_ObjectToText([Nullable(2)] UObject InObj)
		{
			return new FText(UKismetTextLibrary.__Conv_ObjectToText_Internal((InObj != null) ? InObj.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x0600AE06 RID: 44550 RVA: 0x000F70D1 File Offset: 0x000F52D1
		public static FText Conv_NameToText(FName InName)
		{
			return new FText(UKismetTextLibrary.__Conv_NameToText_Internal(InName), null);
		}

		// Token: 0x0600AE07 RID: 44551 RVA: 0x000F70DF File Offset: 0x000F52DF
		public static FText Conv_IntToText(int Value, bool bAlwaysSign = false, bool bUseGrouping = true, int MinimumIntegralDigits = 1, int MaximumIntegralDigits = 324)
		{
			return new FText(UKismetTextLibrary.__Conv_IntToText_Internal(Value, bAlwaysSign, bUseGrouping, MinimumIntegralDigits, MaximumIntegralDigits), null);
		}

		// Token: 0x0600AE08 RID: 44552 RVA: 0x000F70F2 File Offset: 0x000F52F2
		public static FText Conv_Int64ToText(long Value, bool bAlwaysSign = false, bool bUseGrouping = true, int MinimumIntegralDigits = 1, int MaximumIntegralDigits = 324)
		{
			return new FText(UKismetTextLibrary.__Conv_Int64ToText_Internal(Value, bAlwaysSign, bUseGrouping, MinimumIntegralDigits, MaximumIntegralDigits), null);
		}

		// Token: 0x0600AE09 RID: 44553 RVA: 0x000F7105 File Offset: 0x000F5305
		public static FText Conv_FloatToText(float Value, ERoundingMode RoundingMode, bool bAlwaysSign = false, bool bUseGrouping = true, int MinimumIntegralDigits = 1, int MaximumIntegralDigits = 324, int MinimumFractionalDigits = 0, int MaximumFractionalDigits = 3)
		{
			return new FText(UKismetTextLibrary.__Conv_FloatToText_Internal(Value, RoundingMode, bAlwaysSign, bUseGrouping, MinimumIntegralDigits, MaximumIntegralDigits, MinimumFractionalDigits, MaximumFractionalDigits), null);
		}

		// Token: 0x0600AE0A RID: 44554 RVA: 0x000F7123 File Offset: 0x000F5323
		public static FText Conv_ColorToText(FLinearColor InColor)
		{
			return new FText(UKismetTextLibrary.__Conv_ColorToText_Internal(InColor), null);
		}

		// Token: 0x0600AE0B RID: 44555 RVA: 0x000F7131 File Offset: 0x000F5331
		public static FText Conv_ByteToText(byte Value)
		{
			return new FText(UKismetTextLibrary.__Conv_ByteToText_Internal(Value), null);
		}

		// Token: 0x0600AE0C RID: 44556 RVA: 0x000F713F File Offset: 0x000F533F
		public static FText Conv_BoolToText(bool InBool)
		{
			return new FText(UKismetTextLibrary.__Conv_BoolToText_Internal(InBool), null);
		}

		// Token: 0x0600AE0D RID: 44557 RVA: 0x000F7150 File Offset: 0x000F5350
		public unsafe static FText AsTimeZoneTime_DateTime([Nullable(2)] in FDateTime InDateTime, string InTimeZone = "")
		{
			FString fstring = FString.AllocTemp(InTimeZone);
			FText result = new FText(UKismetTextLibrary.__AsTimeZoneTime_DateTime_Internal((InDateTime ?? new FDateTime()).NativePtr, fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AE0E RID: 44558 RVA: 0x000F718C File Offset: 0x000F538C
		public unsafe static FText AsTimeZoneDateTime_DateTime([Nullable(2)] in FDateTime InDateTime, string InTimeZone = "")
		{
			FString fstring = FString.AllocTemp(InTimeZone);
			FText result = new FText(UKismetTextLibrary.__AsTimeZoneDateTime_DateTime_Internal((InDateTime ?? new FDateTime()).NativePtr, fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AE0F RID: 44559 RVA: 0x000F71C8 File Offset: 0x000F53C8
		public unsafe static FText AsTimeZoneDate_DateTime([Nullable(2)] in FDateTime InDateTime, string InTimeZone = "")
		{
			FString fstring = FString.AllocTemp(InTimeZone);
			FText result = new FText(UKismetTextLibrary.__AsTimeZoneDate_DateTime_Internal((InDateTime ?? new FDateTime()).NativePtr, fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AE10 RID: 44560 RVA: 0x000F7202 File Offset: 0x000F5402
		public static FText AsTimespan_Timespan([Nullable(2)] in FTimespan InTimespan)
		{
			return new FText(UKismetTextLibrary.__AsTimespan_Timespan_Internal((InTimespan ?? new FTimespan()).NativePtr), null);
		}

		// Token: 0x0600AE11 RID: 44561 RVA: 0x000F721F File Offset: 0x000F541F
		public static FText AsTime_DateTime([Nullable(2)] in FDateTime In)
		{
			return new FText(UKismetTextLibrary.__AsTime_DateTime_Internal((In ?? new FDateTime()).NativePtr), null);
		}

		// Token: 0x0600AE12 RID: 44562 RVA: 0x000F723C File Offset: 0x000F543C
		public static FText AsPercent_Float(float Value, ERoundingMode RoundingMode, bool bAlwaysSign = false, bool bUseGrouping = true, int MinimumIntegralDigits = 1, int MaximumIntegralDigits = 324, int MinimumFractionalDigits = 0, int MaximumFractionalDigits = 3)
		{
			return new FText(UKismetTextLibrary.__AsPercent_Float_Internal(Value, RoundingMode, bAlwaysSign, bUseGrouping, MinimumIntegralDigits, MaximumIntegralDigits, MinimumFractionalDigits, MaximumFractionalDigits), null);
		}

		// Token: 0x0600AE13 RID: 44563 RVA: 0x000F725A File Offset: 0x000F545A
		public static FText AsDateTime_DateTime([Nullable(2)] in FDateTime In)
		{
			return new FText(UKismetTextLibrary.__AsDateTime_DateTime_Internal((In ?? new FDateTime()).NativePtr), null);
		}

		// Token: 0x0600AE14 RID: 44564 RVA: 0x000F7277 File Offset: 0x000F5477
		public static FText AsDate_DateTime([Nullable(2)] in FDateTime InDateTime)
		{
			return new FText(UKismetTextLibrary.__AsDate_DateTime_Internal((InDateTime ?? new FDateTime()).NativePtr), null);
		}

		// Token: 0x0600AE15 RID: 44565 RVA: 0x000F7294 File Offset: 0x000F5494
		public unsafe static FText AsCurrencyBase(int BaseValue, string CurrencyCode)
		{
			FString fstring = FString.AllocTemp(CurrencyCode);
			FText result = new FText(UKismetTextLibrary.__AsCurrencyBase_Internal(BaseValue, fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AE16 RID: 44566 RVA: 0x000F72C0 File Offset: 0x000F54C0
		public unsafe static FText AsCurrency_Integer(int Value, ERoundingMode RoundingMode, bool bAlwaysSign = false, bool bUseGrouping = true, int MinimumIntegralDigits = 1, int MaximumIntegralDigits = 324, int MinimumFractionalDigits = 0, int MaximumFractionalDigits = 3, string CurrencyCode = "")
		{
			FString fstring = FString.AllocTemp(CurrencyCode);
			FText result = new FText(UKismetTextLibrary.__AsCurrency_Integer_Internal(Value, RoundingMode, bAlwaysSign, bUseGrouping, MinimumIntegralDigits, MaximumIntegralDigits, MinimumFractionalDigits, MaximumFractionalDigits, fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AE17 RID: 44567 RVA: 0x000F72FC File Offset: 0x000F54FC
		public unsafe static FText AsCurrency_Float(float Value, ERoundingMode RoundingMode, bool bAlwaysSign = false, bool bUseGrouping = true, int MinimumIntegralDigits = 1, int MaximumIntegralDigits = 324, int MinimumFractionalDigits = 0, int MaximumFractionalDigits = 3, string CurrencyCode = "")
		{
			FString fstring = FString.AllocTemp(CurrencyCode);
			FText result = new FText(UKismetTextLibrary.__AsCurrency_Float_Internal(Value, RoundingMode, bAlwaysSign, bUseGrouping, MinimumIntegralDigits, MaximumIntegralDigits, MinimumFractionalDigits, MaximumFractionalDigits, fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AE18 RID: 44568
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __TextTrimTrailing_Internal(IntPtr InText);

		// Token: 0x0600AE19 RID: 44569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __TextTrimPrecedingAndTrailing_Internal(IntPtr InText);

		// Token: 0x0600AE1A RID: 44570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __TextTrimPreceding_Internal(IntPtr InText);

		// Token: 0x0600AE1B RID: 44571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __TextToUpper_Internal(IntPtr InText);

		// Token: 0x0600AE1C RID: 44572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __TextToLower_Internal(IntPtr InText);

		// Token: 0x0600AE1D RID: 44573
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TextIsTransient_Internal(IntPtr InText);

		// Token: 0x0600AE1E RID: 44574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TextIsFromStringTable_Internal(IntPtr Text);

		// Token: 0x0600AE1F RID: 44575
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TextIsEmpty_Internal(IntPtr InText);

		// Token: 0x0600AE20 RID: 44576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TextIsCultureInvariant_Internal(IntPtr InText);

		// Token: 0x0600AE21 RID: 44577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __TextFromStringTable_Internal(FName TableId, in FString Key);

		// Token: 0x0600AE22 RID: 44578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __StringTableIdAndKeyFromText_Internal(IntPtr Text, ref FName OutTableId, ref FString OutKey);

		// Token: 0x0600AE23 RID: 44579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PolyglotDataToText_Internal(IntPtr PolyglotData);

		// Token: 0x0600AE24 RID: 44580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_TextText_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AE25 RID: 44581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_IgnoreCase_TextText_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AE26 RID: 44582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __IsPolyglotDataValid_Internal(IntPtr PolyglotData, ref bool IsValid, IntPtr ErrorMessage);

		// Token: 0x0600AE27 RID: 44583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEmptyText_Internal();

		// Token: 0x0600AE28 RID: 44584
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Format_Internal(IntPtr InPattern, IntPtr InArgs);

		// Token: 0x0600AE29 RID: 44585
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FindTextInLocalizationTable_Internal(in FString Namespace, in FString Key, IntPtr OutText);

		// Token: 0x0600AE2A RID: 44586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_TextText_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AE2B RID: 44587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_IgnoreCase_TextText_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AE2C RID: 44588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_VectorToText_Internal(FVector InVec);

		// Token: 0x0600AE2D RID: 44589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_Vector2dToText_Internal(FVector2D InVec);

		// Token: 0x0600AE2E RID: 44590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_TransformToText_Internal(in FTransform InTrans);

		// Token: 0x0600AE2F RID: 44591
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_TextToString_Internal(IntPtr InText);

		// Token: 0x0600AE30 RID: 44592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_StringToText_Internal(in FString InString);

		// Token: 0x0600AE31 RID: 44593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_RotatorToText_Internal(FRotator InRot);

		// Token: 0x0600AE32 RID: 44594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_ObjectToText_Internal(IntPtr InObj);

		// Token: 0x0600AE33 RID: 44595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_NameToText_Internal(FName InName);

		// Token: 0x0600AE34 RID: 44596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_IntToText_Internal(int Value, bool bAlwaysSign, bool bUseGrouping, int MinimumIntegralDigits, int MaximumIntegralDigits);

		// Token: 0x0600AE35 RID: 44597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_Int64ToText_Internal(long Value, bool bAlwaysSign, bool bUseGrouping, int MinimumIntegralDigits, int MaximumIntegralDigits);

		// Token: 0x0600AE36 RID: 44598
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_FloatToText_Internal(float Value, TEnumAsByte<ERoundingMode> RoundingMode, bool bAlwaysSign, bool bUseGrouping, int MinimumIntegralDigits, int MaximumIntegralDigits, int MinimumFractionalDigits, int MaximumFractionalDigits);

		// Token: 0x0600AE37 RID: 44599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_ColorToText_Internal(FLinearColor InColor);

		// Token: 0x0600AE38 RID: 44600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_ByteToText_Internal(byte Value);

		// Token: 0x0600AE39 RID: 44601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_BoolToText_Internal(bool InBool);

		// Token: 0x0600AE3A RID: 44602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AsTimeZoneTime_DateTime_Internal(IntPtr InDateTime, in FString InTimeZone);

		// Token: 0x0600AE3B RID: 44603
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AsTimeZoneDateTime_DateTime_Internal(IntPtr InDateTime, in FString InTimeZone);

		// Token: 0x0600AE3C RID: 44604
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AsTimeZoneDate_DateTime_Internal(IntPtr InDateTime, in FString InTimeZone);

		// Token: 0x0600AE3D RID: 44605
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AsTimespan_Timespan_Internal(IntPtr InTimespan);

		// Token: 0x0600AE3E RID: 44606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AsTime_DateTime_Internal(IntPtr In);

		// Token: 0x0600AE3F RID: 44607
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AsPercent_Float_Internal(float Value, TEnumAsByte<ERoundingMode> RoundingMode, bool bAlwaysSign, bool bUseGrouping, int MinimumIntegralDigits, int MaximumIntegralDigits, int MinimumFractionalDigits, int MaximumFractionalDigits);

		// Token: 0x0600AE40 RID: 44608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AsDateTime_DateTime_Internal(IntPtr In);

		// Token: 0x0600AE41 RID: 44609
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AsDate_DateTime_Internal(IntPtr InDateTime);

		// Token: 0x0600AE42 RID: 44610
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AsCurrencyBase_Internal(int BaseValue, in FString CurrencyCode);

		// Token: 0x0600AE43 RID: 44611
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AsCurrency_Integer_Internal(int Value, TEnumAsByte<ERoundingMode> RoundingMode, bool bAlwaysSign, bool bUseGrouping, int MinimumIntegralDigits, int MaximumIntegralDigits, int MinimumFractionalDigits, int MaximumFractionalDigits, in FString CurrencyCode);

		// Token: 0x0600AE44 RID: 44612
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AsCurrency_Float_Internal(float Value, TEnumAsByte<ERoundingMode> RoundingMode, bool bAlwaysSign, bool bUseGrouping, int MinimumIntegralDigits, int MaximumIntegralDigits, int MinimumFractionalDigits, int MaximumFractionalDigits, in FString CurrencyCode);

		// Token: 0x0600AE45 RID: 44613 RVA: 0x000F7338 File Offset: 0x000F5538
		static UKismetTextLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KismetTextLibrary");
		}

		// Token: 0x0600AE46 RID: 44614 RVA: 0x000F7346 File Offset: 0x000F5546
		protected UKismetTextLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005B52 RID: 23378
		public new const string __ObjectPath = "/Script/Engine.KismetTextLibrary";

		// Token: 0x04005B53 RID: 23379
		private static IntPtr _ClassPtr;

		// Token: 0x04005B54 RID: 23380
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
