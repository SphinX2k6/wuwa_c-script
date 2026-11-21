using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000299 RID: 665
	[UnrealObjectPath("/Script/Engine.Texture2D")]
	[UnrealStructLayout(4240, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4240)]
	public class UTexture2D : UTexture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004964 RID: 18788 RVA: 0x00066E45 File Offset: 0x00065045
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTexture2D._ClassPtr;
		}

		// Token: 0x06004965 RID: 18789 RVA: 0x00066E54 File Offset: 0x00065054
		public UTexture2D() : this(BuiltinUtils.AllocNativeUObject(UTexture2D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004966 RID: 18790 RVA: 0x00066E7C File Offset: 0x0006507C
		[NullableContext(1)]
		public UTexture2D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTexture2D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06004967 RID: 18791 RVA: 0x00066EAF File Offset: 0x000650AF
		// (set) Token: 0x06004968 RID: 18792 RVA: 0x00066EBF File Offset: 0x000650BF
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

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06004969 RID: 18793 RVA: 0x00066ED0 File Offset: 0x000650D0
		// (set) Token: 0x0600496A RID: 18794 RVA: 0x00066EE0 File Offset: 0x000650E0
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

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x0600496B RID: 18795 RVA: 0x00066EF1 File Offset: 0x000650F1
		// (set) Token: 0x0600496C RID: 18796 RVA: 0x00066F0A File Offset: 0x0006510A
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

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x0600496D RID: 18797 RVA: 0x00066F3A File Offset: 0x0006513A
		// (set) Token: 0x0600496E RID: 18798 RVA: 0x00066F4E File Offset: 0x0006514E
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

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x0600496F RID: 18799 RVA: 0x00066F63 File Offset: 0x00065163
		// (set) Token: 0x06004970 RID: 18800 RVA: 0x00066F73 File Offset: 0x00065173
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

		// Token: 0x06004971 RID: 18801 RVA: 0x00066F84 File Offset: 0x00065184
		[SkipLocalsInit]
		public unsafe int Blueprint_GetSizeY()
		{
			UTexture2D.__Blueprint_GetSizeY_FunctionParams* ptr = stackalloc UTexture2D.__Blueprint_GetSizeY_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTexture2D.__Blueprint_GetSizeY_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTexture2D.__Blueprint_GetSizeY_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTexture2D.__Blueprint_GetSizeY_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06004972 RID: 18802 RVA: 0x00066FCC File Offset: 0x000651CC
		[SkipLocalsInit]
		public unsafe int Blueprint_GetSizeX()
		{
			UTexture2D.__Blueprint_GetSizeX_FunctionParams* ptr = stackalloc UTexture2D.__Blueprint_GetSizeX_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTexture2D.__Blueprint_GetSizeX_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTexture2D.__Blueprint_GetSizeX_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTexture2D.__Blueprint_GetSizeX_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06004973 RID: 18803 RVA: 0x00067011 File Offset: 0x00065211
		static UTexture2D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Texture2D");
		}

		// Token: 0x06004974 RID: 18804 RVA: 0x0006701F File Offset: 0x0006521F
		protected UTexture2D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001C8E RID: 7310
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Texture2D";

		// Token: 0x04001C8F RID: 7311
		private static IntPtr _ClassPtr;

		// Token: 0x04001C90 RID: 7312
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001C91 RID: 7313
		internal static int __PropertyOffset_LevelIndex;

		// Token: 0x04001C92 RID: 7314
		internal static int __PropertyOffset_FirstResourceMemMip;

		// Token: 0x04001C93 RID: 7315
		internal static int __PropertyOffset_bTemporarilyDisableStreaming;

		// Token: 0x04001C94 RID: 7316
		internal static byte __PropertyMask_bTemporarilyDisableStreaming;

		// Token: 0x04001C95 RID: 7317
		internal static int __PropertyOffset_ImportedSize;

		// Token: 0x04001C96 RID: 7318
		internal static int __PropertyOffset_LandscapeTextureEditorMipsAndMeshRequiredMips;

		// Token: 0x04001C97 RID: 7319
		private static IntPtr __Blueprint_GetSizeY_NativeFunctionPtr;

		// Token: 0x04001C98 RID: 7320
		private static IntPtr __Blueprint_GetSizeX_NativeFunctionPtr;

		// Token: 0x020009F3 RID: 2547
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Blueprint_GetSizeY_FunctionParams
		{
			// Token: 0x04005998 RID: 22936
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020009F4 RID: 2548
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Blueprint_GetSizeX_FunctionParams
		{
			// Token: 0x04005999 RID: 22937
			[FieldOffset(0)]
			public int __Result;
		}
	}
}
