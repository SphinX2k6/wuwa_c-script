using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028DE RID: 10462
	[UnrealObjectPath("/Script/TapCommon.TapButtonSlot")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UTapButtonSlot : UPanelSlot, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026CF7 RID: 158967 RVA: 0x003B2FF9 File Offset: 0x003B11F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTapButtonSlot._ClassPtr;
		}

		// Token: 0x06026CF8 RID: 158968 RVA: 0x003B3008 File Offset: 0x003B1208
		public UTapButtonSlot() : this(BuiltinUtils.AllocNativeUObject(UTapButtonSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026CF9 RID: 158969 RVA: 0x003B3030 File Offset: 0x003B1230
		[NullableContext(1)]
		public UTapButtonSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTapButtonSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009584 RID: 38276
		// (get) Token: 0x06026CFA RID: 158970 RVA: 0x003B3063 File Offset: 0x003B1263
		// (set) Token: 0x06026CFB RID: 158971 RVA: 0x003B3077 File Offset: 0x003B1277
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTapButtonSlot.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTapButtonSlot.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x17009585 RID: 38277
		// (get) Token: 0x06026CFC RID: 158972 RVA: 0x003B308C File Offset: 0x003B128C
		// (set) Token: 0x06026CFD RID: 158973 RVA: 0x003B30A0 File Offset: 0x003B12A0
		public unsafe TEnumAsByte<EHorizontalAlignment> HorizontalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTapButtonSlot.__PropertyOffset_HorizontalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTapButtonSlot.__PropertyOffset_HorizontalAlignment) = value;
			}
		}

		// Token: 0x17009586 RID: 38278
		// (get) Token: 0x06026CFE RID: 158974 RVA: 0x003B30B5 File Offset: 0x003B12B5
		// (set) Token: 0x06026CFF RID: 158975 RVA: 0x003B30C9 File Offset: 0x003B12C9
		public unsafe TEnumAsByte<EVerticalAlignment> VerticalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTapButtonSlot.__PropertyOffset_VerticalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTapButtonSlot.__PropertyOffset_VerticalAlignment) = value;
			}
		}

		// Token: 0x06026D00 RID: 158976 RVA: 0x003B30E0 File Offset: 0x003B12E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
		{
			UTapButtonSlot.__SetVerticalAlignment_FunctionParams* ptr = stackalloc UTapButtonSlot.__SetVerticalAlignment_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTapButtonSlot.__SetVerticalAlignment_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTapButtonSlot.__SetVerticalAlignment_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InVerticalAlignment = InVerticalAlignment;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTapButtonSlot.__SetVerticalAlignment_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026D01 RID: 158977 RVA: 0x003B312C File Offset: 0x003B132C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetPadding(FMargin InPadding)
		{
			UTapButtonSlot.__SetPadding_FunctionParams* ptr = stackalloc UTapButtonSlot.__SetPadding_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTapButtonSlot.__SetPadding_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTapButtonSlot.__SetPadding_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InPadding = InPadding;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTapButtonSlot.__SetPadding_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026D02 RID: 158978 RVA: 0x003B3174 File Offset: 0x003B1374
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
		{
			UTapButtonSlot.__SetHorizontalAlignment_FunctionParams* ptr = stackalloc UTapButtonSlot.__SetHorizontalAlignment_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTapButtonSlot.__SetHorizontalAlignment_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTapButtonSlot.__SetHorizontalAlignment_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InHorizontalAlignment = InHorizontalAlignment;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTapButtonSlot.__SetHorizontalAlignment_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026D03 RID: 158979 RVA: 0x003B31C0 File Offset: 0x003B13C0
		static UTapButtonSlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TapCommon.TapButtonSlot");
		}

		// Token: 0x06026D04 RID: 158980 RVA: 0x003B31CE File Offset: 0x003B13CE
		protected UTapButtonSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040154ED RID: 87277
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TapCommon.TapButtonSlot";

		// Token: 0x040154EE RID: 87278
		private static IntPtr _ClassPtr;

		// Token: 0x040154EF RID: 87279
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040154F0 RID: 87280
		internal static int __PropertyOffset_Padding;

		// Token: 0x040154F1 RID: 87281
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x040154F2 RID: 87282
		internal static int __PropertyOffset_VerticalAlignment;

		// Token: 0x040154F3 RID: 87283
		private static IntPtr __SetVerticalAlignment_NativeFunctionPtr;

		// Token: 0x040154F4 RID: 87284
		private static IntPtr __SetPadding_NativeFunctionPtr;

		// Token: 0x040154F5 RID: 87285
		private static IntPtr __SetHorizontalAlignment_NativeFunctionPtr;

		// Token: 0x02003B4C RID: 15180
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetVerticalAlignment_FunctionParams
		{
			// Token: 0x04017CF1 RID: 97521
			[FieldOffset(0)]
			public TEnumAsByte<EVerticalAlignment> InVerticalAlignment;
		}

		// Token: 0x02003B4D RID: 15181
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetPadding_FunctionParams
		{
			// Token: 0x04017CF2 RID: 97522
			[FieldOffset(0)]
			public FMargin InPadding;
		}

		// Token: 0x02003B4E RID: 15182
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetHorizontalAlignment_FunctionParams
		{
			// Token: 0x04017CF3 RID: 97523
			[FieldOffset(0)]
			public TEnumAsByte<EHorizontalAlignment> InHorizontalAlignment;
		}
	}
}
