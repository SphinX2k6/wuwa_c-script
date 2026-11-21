using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000221 RID: 545
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KismetInputLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetInputLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600252B RID: 9515 RVA: 0x0003587D File Offset: 0x00033A7D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetInputLibrary._ClassPtr;
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x0003588C File Offset: 0x00033A8C
		public UKismetInputLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetInputLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x000358B4 File Offset: 0x00033AB4
		[NullableContext(1)]
		public UKismetInputLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetInputLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x000358E7 File Offset: 0x00033AE7
		public static bool Key_IsVectorAxis(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsVectorAxis_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x000358FE File Offset: 0x00033AFE
		public static bool Key_IsValid(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsValid_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x00035915 File Offset: 0x00033B15
		public static bool Key_IsMouseButton(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsMouseButton_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x0003592C File Offset: 0x00033B2C
		public static bool Key_IsModifierKey(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsModifierKey_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x00035943 File Offset: 0x00033B43
		public static bool Key_IsKeyboardKey(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsKeyboardKey_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x0003595A File Offset: 0x00033B5A
		public static bool Key_IsGamepadKey(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsGamepadKey_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x00035971 File Offset: 0x00033B71
		public static bool Key_IsDigital(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsDigital_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x00035988 File Offset: 0x00033B88
		public static bool Key_IsButtonAxis(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsButtonAxis_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x0003599F File Offset: 0x00033B9F
		public static bool Key_IsAxis3D(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsAxis3D_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x000359B6 File Offset: 0x00033BB6
		public static bool Key_IsAxis2D(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsAxis2D_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x000359CD File Offset: 0x00033BCD
		public static bool Key_IsAxis1D(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsAxis1D_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x000359E4 File Offset: 0x00033BE4
		public static bool Key_IsAnalog(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsAnalog_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x000359FB File Offset: 0x00033BFB
		[NullableContext(1)]
		public static FText Key_GetDisplayName([Nullable(2)] in FKey Key)
		{
			return new FText(UKismetInputLibrary.__Key_GetDisplayName_Internal((Key ?? new FKey()).NativePtr), null);
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x00035A18 File Offset: 0x00033C18
		[NullableContext(1)]
		public static FText InputChord_GetDisplayName([Nullable(2)] in FInputChord Key)
		{
			return new FText(UKismetInputLibrary.__InputChord_GetDisplayName_Internal((Key ?? new FInputChord()).NativePtr), null);
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x00035A35 File Offset: 0x00033C35
		public static bool EqualEqual_KeyKey(FKey A, FKey B)
		{
			return UKismetInputLibrary.__EqualEqual_KeyKey_Internal((A ?? new FKey()).NativePtr, (B ?? new FKey()).NativePtr);
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x00035A5A File Offset: 0x00033C5A
		public static bool EqualEqual_InputChordInputChord(FInputChord A, FInputChord B)
		{
			return UKismetInputLibrary.__EqualEqual_InputChordInputChord_Internal((A ?? new FInputChord()).NativePtr, (B ?? new FInputChord()).NativePtr);
		}

		// Token: 0x0600253E RID: 9534
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CalibrateTilt();

		// Token: 0x0600253F RID: 9535
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsVectorAxis_Internal(IntPtr Key);

		// Token: 0x06002540 RID: 9536
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsValid_Internal(IntPtr Key);

		// Token: 0x06002541 RID: 9537
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsMouseButton_Internal(IntPtr Key);

		// Token: 0x06002542 RID: 9538
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsModifierKey_Internal(IntPtr Key);

		// Token: 0x06002543 RID: 9539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsKeyboardKey_Internal(IntPtr Key);

		// Token: 0x06002544 RID: 9540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsGamepadKey_Internal(IntPtr Key);

		// Token: 0x06002545 RID: 9541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsDigital_Internal(IntPtr Key);

		// Token: 0x06002546 RID: 9542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsButtonAxis_Internal(IntPtr Key);

		// Token: 0x06002547 RID: 9543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsAxis3D_Internal(IntPtr Key);

		// Token: 0x06002548 RID: 9544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsAxis2D_Internal(IntPtr Key);

		// Token: 0x06002549 RID: 9545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsAxis1D_Internal(IntPtr Key);

		// Token: 0x0600254A RID: 9546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsAnalog_Internal(IntPtr Key);

		// Token: 0x0600254B RID: 9547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Key_GetDisplayName_Internal(IntPtr Key);

		// Token: 0x0600254C RID: 9548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __InputChord_GetDisplayName_Internal(IntPtr Key);

		// Token: 0x0600254D RID: 9549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_KeyKey_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600254E RID: 9550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_InputChordInputChord_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600254F RID: 9551 RVA: 0x00035A7F File Offset: 0x00033C7F
		static UKismetInputLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KismetInputLibrary");
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x00035A8D File Offset: 0x00033C8D
		protected UKismetInputLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E07 RID: 3591
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KismetInputLibrary";

		// Token: 0x04000E08 RID: 3592
		private static IntPtr _ClassPtr;

		// Token: 0x04000E09 RID: 3593
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
