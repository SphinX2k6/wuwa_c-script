using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011CD RID: 4557
	[UnrealObjectPath("/Script/Engine.Texture2D")]
	[UnrealStructLayout(4032, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4032)]
	public class UTexture2D : UTexture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010CDC RID: 68828 RVA: 0x0018AD5D File Offset: 0x00188F5D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTexture2D._ClassPtr;
		}

		// Token: 0x06010CDD RID: 68829 RVA: 0x0018AD6C File Offset: 0x00188F6C
		public UTexture2D() : this(BuiltinUtils.AllocNativeUObject(UTexture2D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010CDE RID: 68830 RVA: 0x0018AD94 File Offset: 0x00188F94
		[NullableContext(1)]
		public UTexture2D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTexture2D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170041A0 RID: 16800
		// (get) Token: 0x06010CDF RID: 68831 RVA: 0x0018ADC7 File Offset: 0x00188FC7
		// (set) Token: 0x06010CE0 RID: 68832 RVA: 0x0018ADD7 File Offset: 0x00188FD7
		public unsafe int LevelIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture2D.__PropertyOffset_LevelIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture2D.__PropertyOffset_LevelIndex) = value;
			}
		}

		// Token: 0x170041A1 RID: 16801
		// (get) Token: 0x06010CE1 RID: 68833 RVA: 0x0018ADE8 File Offset: 0x00188FE8
		// (set) Token: 0x06010CE2 RID: 68834 RVA: 0x0018ADF8 File Offset: 0x00188FF8
		public unsafe int FirstResourceMemMip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture2D.__PropertyOffset_FirstResourceMemMip);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture2D.__PropertyOffset_FirstResourceMemMip) = value;
			}
		}

		// Token: 0x170041A2 RID: 16802
		// (get) Token: 0x06010CE3 RID: 68835 RVA: 0x0018AE09 File Offset: 0x00189009
		// (set) Token: 0x06010CE4 RID: 68836 RVA: 0x0018AE22 File Offset: 0x00189022
		public unsafe bool bTemporarilyDisableStreaming
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTexture2D.__PropertyOffset_bTemporarilyDisableStreaming) & UTexture2D.__PropertyMask_bTemporarilyDisableStreaming) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTexture2D.__PropertyOffset_bTemporarilyDisableStreaming) = ((*(base.NativePtr + (IntPtr)UTexture2D.__PropertyOffset_bTemporarilyDisableStreaming) & ~UTexture2D.__PropertyMask_bTemporarilyDisableStreaming) | (value ? UTexture2D.__PropertyMask_bTemporarilyDisableStreaming : 0));
			}
		}

		// Token: 0x170041A3 RID: 16803
		// (get) Token: 0x06010CE5 RID: 68837 RVA: 0x0018AE52 File Offset: 0x00189052
		// (set) Token: 0x06010CE6 RID: 68838 RVA: 0x0018AE66 File Offset: 0x00189066
		public unsafe TEnumAsByte<TextureAddress> AddressX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture2D.__PropertyOffset_AddressX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture2D.__PropertyOffset_AddressX) = value;
			}
		}

		// Token: 0x170041A4 RID: 16804
		// (get) Token: 0x06010CE7 RID: 68839 RVA: 0x0018AE7B File Offset: 0x0018907B
		// (set) Token: 0x06010CE8 RID: 68840 RVA: 0x0018AE8F File Offset: 0x0018908F
		public unsafe TEnumAsByte<TextureAddress> AddressY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture2D.__PropertyOffset_AddressY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture2D.__PropertyOffset_AddressY) = value;
			}
		}

		// Token: 0x170041A5 RID: 16805
		// (get) Token: 0x06010CE9 RID: 68841 RVA: 0x0018AEA4 File Offset: 0x001890A4
		// (set) Token: 0x06010CEA RID: 68842 RVA: 0x0018AEB8 File Offset: 0x001890B8
		public unsafe FIntPoint ImportedSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture2D.__PropertyOffset_ImportedSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture2D.__PropertyOffset_ImportedSize) = value;
			}
		}

		// Token: 0x170041A6 RID: 16806
		// (get) Token: 0x06010CEB RID: 68843 RVA: 0x0018AECD File Offset: 0x001890CD
		// (set) Token: 0x06010CEC RID: 68844 RVA: 0x0018AEDD File Offset: 0x001890DD
		public unsafe byte LandscapeTextureEditorMipsAndMeshRequiredMips
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture2D.__PropertyOffset_LandscapeTextureEditorMipsAndMeshRequiredMips);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture2D.__PropertyOffset_LandscapeTextureEditorMipsAndMeshRequiredMips) = value;
			}
		}

		// Token: 0x06010CED RID: 68845 RVA: 0x0018AEF0 File Offset: 0x001890F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int Blueprint_GetSizeY()
		{
			UTexture2D.__Blueprint_GetSizeY_FunctionParams* ptr = stackalloc UTexture2D.__Blueprint_GetSizeY_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTexture2D.__Blueprint_GetSizeY_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTexture2D.__Blueprint_GetSizeY_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTexture2D.__Blueprint_GetSizeY_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06010CEE RID: 68846 RVA: 0x0018AF38 File Offset: 0x00189138
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int Blueprint_GetSizeX()
		{
			UTexture2D.__Blueprint_GetSizeX_FunctionParams* ptr = stackalloc UTexture2D.__Blueprint_GetSizeX_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTexture2D.__Blueprint_GetSizeX_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTexture2D.__Blueprint_GetSizeX_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTexture2D.__Blueprint_GetSizeX_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06010CEF RID: 68847 RVA: 0x0018AF7E File Offset: 0x0018917E
		static UTexture2D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Texture2D");
		}

		// Token: 0x06010CF0 RID: 68848 RVA: 0x0018AF8C File Offset: 0x0018918C
		protected UTexture2D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008FAC RID: 36780
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Texture2D";

		// Token: 0x04008FAD RID: 36781
		private static IntPtr _ClassPtr;

		// Token: 0x04008FAE RID: 36782
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008FAF RID: 36783
		internal static int __PropertyOffset_LevelIndex;

		// Token: 0x04008FB0 RID: 36784
		internal static int __PropertyOffset_FirstResourceMemMip;

		// Token: 0x04008FB1 RID: 36785
		internal static int __PropertyOffset_bTemporarilyDisableStreaming;

		// Token: 0x04008FB2 RID: 36786
		internal static byte __PropertyMask_bTemporarilyDisableStreaming;

		// Token: 0x04008FB3 RID: 36787
		internal static int __PropertyOffset_AddressX;

		// Token: 0x04008FB4 RID: 36788
		internal static int __PropertyOffset_AddressY;

		// Token: 0x04008FB5 RID: 36789
		internal static int __PropertyOffset_ImportedSize;

		// Token: 0x04008FB6 RID: 36790
		internal static int __PropertyOffset_LandscapeTextureEditorMipsAndMeshRequiredMips;

		// Token: 0x04008FB7 RID: 36791
		private static IntPtr __Blueprint_GetSizeY_NativeFunctionPtr;

		// Token: 0x04008FB8 RID: 36792
		private static IntPtr __Blueprint_GetSizeX_NativeFunctionPtr;

		// Token: 0x02002DF9 RID: 11769
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Blueprint_GetSizeY_FunctionParams
		{
			// Token: 0x0401685A RID: 92250
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02002DFA RID: 11770
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Blueprint_GetSizeX_FunctionParams
		{
			// Token: 0x0401685B RID: 92251
			[FieldOffset(0)]
			public int __Result;
		}
	}
}
