using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CD2 RID: 3282
	[UnrealObjectPath("/Script/Engine.KismetNodeHelperLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetNodeHelperLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AAC0 RID: 43712 RVA: 0x000EFF11 File Offset: 0x000EE111
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetNodeHelperLibrary._ClassPtr;
		}

		// Token: 0x0600AAC1 RID: 43713 RVA: 0x000EFF20 File Offset: 0x000EE120
		public UKismetNodeHelperLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetNodeHelperLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AAC2 RID: 43714 RVA: 0x000EFF48 File Offset: 0x000EE148
		[NullableContext(1)]
		public UKismetNodeHelperLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetNodeHelperLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600AAC3 RID: 43715
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MarkBit(ref int Data, int Index);

		// Token: 0x0600AAC4 RID: 43716
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasUnmarkedBit(int Data, int NumBits);

		// Token: 0x0600AAC5 RID: 43717
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasMarkedBit(int Data, int NumBits);

		// Token: 0x0600AAC6 RID: 43718 RVA: 0x000EFF7B File Offset: 0x000EE17B
		[NullableContext(2)]
		public static byte GetValidValue(UEnum Enum, byte EnumeratorValue)
		{
			return UKismetNodeHelperLibrary.__GetValidValue_Internal((Enum != null) ? Enum.NativePtr : IntPtr.Zero, EnumeratorValue);
		}

		// Token: 0x0600AAC7 RID: 43719
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetUnmarkedBit(int Data, int StartIdx, int NumBits, bool bRandom);

		// Token: 0x0600AAC8 RID: 43720
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetRandomUnmarkedBit(int Data, int StartIdx, int NumBits);

		// Token: 0x0600AAC9 RID: 43721
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetFirstUnmarkedBit(int Data, int StartIdx, int NumBits);

		// Token: 0x0600AACA RID: 43722 RVA: 0x000EFF93 File Offset: 0x000EE193
		[NullableContext(2)]
		public static byte GetEnumeratorValueFromIndex(UEnum Enum, byte EnumeratorIndex)
		{
			return UKismetNodeHelperLibrary.__GetEnumeratorValueFromIndex_Internal((Enum != null) ? Enum.NativePtr : IntPtr.Zero, EnumeratorIndex);
		}

		// Token: 0x0600AACB RID: 43723 RVA: 0x000EFFAB File Offset: 0x000EE1AB
		[NullableContext(1)]
		public static string GetEnumeratorUserFriendlyName([Nullable(2)] UEnum Enum, byte EnumeratorValue)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetNodeHelperLibrary.__GetEnumeratorUserFriendlyName_Internal((Enum != null) ? Enum.NativePtr : IntPtr.Zero, EnumeratorValue));
		}

		// Token: 0x0600AACC RID: 43724 RVA: 0x000EFFC8 File Offset: 0x000EE1C8
		[NullableContext(2)]
		public static FName GetEnumeratorName(UEnum Enum, byte EnumeratorValue)
		{
			return UKismetNodeHelperLibrary.__GetEnumeratorName_Internal((Enum != null) ? Enum.NativePtr : IntPtr.Zero, EnumeratorValue);
		}

		// Token: 0x0600AACD RID: 43725
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearBit(ref int Data, int Index);

		// Token: 0x0600AACE RID: 43726
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearAllBits(ref int Data);

		// Token: 0x0600AACF RID: 43727
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool BitIsMarked(int Data, int Index);

		// Token: 0x0600AAD0 RID: 43728
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte __GetValidValue_Internal(IntPtr Enum, byte EnumeratorValue);

		// Token: 0x0600AAD1 RID: 43729
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte __GetEnumeratorValueFromIndex_Internal(IntPtr Enum, byte EnumeratorIndex);

		// Token: 0x0600AAD2 RID: 43730
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetEnumeratorUserFriendlyName_Internal(IntPtr Enum, byte EnumeratorValue);

		// Token: 0x0600AAD3 RID: 43731
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetEnumeratorName_Internal(IntPtr Enum, byte EnumeratorValue);

		// Token: 0x0600AAD4 RID: 43732 RVA: 0x000EFFE0 File Offset: 0x000EE1E0
		static UKismetNodeHelperLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KismetNodeHelperLibrary");
		}

		// Token: 0x0600AAD5 RID: 43733 RVA: 0x000EFFEE File Offset: 0x000EE1EE
		protected UKismetNodeHelperLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005B3D RID: 23357
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KismetNodeHelperLibrary";

		// Token: 0x04005B3E RID: 23358
		private static IntPtr _ClassPtr;

		// Token: 0x04005B3F RID: 23359
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
