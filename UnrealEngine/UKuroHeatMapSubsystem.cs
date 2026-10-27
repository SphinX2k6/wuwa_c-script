using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B1F RID: 6943
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroHeatMapSubsystem")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UKuroHeatMapSubsystem : UEngineSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A1EE RID: 106990 RVA: 0x00268D54 File Offset: 0x00266F54
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroHeatMapSubsystem._ClassPtr;
		}

		// Token: 0x0601A1EF RID: 106991 RVA: 0x00268D60 File Offset: 0x00266F60
		public UKuroHeatMapSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroHeatMapSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A1F0 RID: 106992 RVA: 0x00268D88 File Offset: 0x00266F88
		[NullableContext(1)]
		public UKuroHeatMapSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroHeatMapSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601A1F1 RID: 106993 RVA: 0x00268DBC File Offset: 0x00266FBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool ShouldRedraw()
		{
			UKuroHeatMapSubsystem.__ShouldRedraw_FunctionParams* ptr = stackalloc UKuroHeatMapSubsystem.__ShouldRedraw_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroHeatMapSubsystem.__ShouldRedraw_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHeatMapSubsystem.__ShouldRedraw_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroHeatMapSubsystem.__ShouldRedraw_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601A1F2 RID: 106994 RVA: 0x00268E04 File Offset: 0x00267004
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetShouldRedraw(bool bRedraw)
		{
			UKuroHeatMapSubsystem.__SetShouldRedraw_FunctionParams* ptr = stackalloc UKuroHeatMapSubsystem.__SetShouldRedraw_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroHeatMapSubsystem.__SetShouldRedraw_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHeatMapSubsystem.__SetShouldRedraw_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bRedraw = bRedraw;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroHeatMapSubsystem.__SetShouldRedraw_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601A1F3 RID: 106995 RVA: 0x00268E4C File Offset: 0x0026704C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRange(float Range)
		{
			UKuroHeatMapSubsystem.__SetRange_FunctionParams* ptr = stackalloc UKuroHeatMapSubsystem.__SetRange_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroHeatMapSubsystem.__SetRange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHeatMapSubsystem.__SetRange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Range = Range;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroHeatMapSubsystem.__SetRange_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601A1F4 RID: 106996 RVA: 0x00268E94 File Offset: 0x00267094
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void RegisterDrawRequest(in FHeatMapDrawRequest DrawRequest)
		{
			UKuroHeatMapSubsystem.__RegisterDrawRequest_FunctionParams* ptr = stackalloc UKuroHeatMapSubsystem.__RegisterDrawRequest_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(UKuroHeatMapSubsystem.__RegisterDrawRequest_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHeatMapSubsystem.__RegisterDrawRequest_NativeFunctionPtr, (void*)ptr, 1);
			if (DrawRequest != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHeatMapDrawRequest.StaticStruct(), &ptr->DrawRequest, DrawRequest.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroHeatMapSubsystem.__RegisterDrawRequest_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroHeatMapSubsystem.__RegisterDrawRequest_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601A1F5 RID: 106997 RVA: 0x00268F0C File Offset: 0x0026710C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsPersistenceDraw()
		{
			UKuroHeatMapSubsystem.__IsPersistenceDraw_FunctionParams* ptr = stackalloc UKuroHeatMapSubsystem.__IsPersistenceDraw_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroHeatMapSubsystem.__IsPersistenceDraw_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHeatMapSubsystem.__IsPersistenceDraw_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroHeatMapSubsystem.__IsPersistenceDraw_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601A1F6 RID: 106998 RVA: 0x00268F54 File Offset: 0x00267154
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetRange()
		{
			UKuroHeatMapSubsystem.__GetRange_FunctionParams* ptr = stackalloc UKuroHeatMapSubsystem.__GetRange_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroHeatMapSubsystem.__GetRange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHeatMapSubsystem.__GetRange_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroHeatMapSubsystem.__GetRange_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601A1F7 RID: 106999 RVA: 0x00268F9C File Offset: 0x0026719C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FVector GetCenterLocation()
		{
			UKuroHeatMapSubsystem.__GetCenterLocation_FunctionParams* ptr = stackalloc UKuroHeatMapSubsystem.__GetCenterLocation_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroHeatMapSubsystem.__GetCenterLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHeatMapSubsystem.__GetCenterLocation_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroHeatMapSubsystem.__GetCenterLocation_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601A1F8 RID: 107000 RVA: 0x00268FE4 File Offset: 0x002671E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetActorCount()
		{
			UKuroHeatMapSubsystem.__GetActorCount_FunctionParams* ptr = stackalloc UKuroHeatMapSubsystem.__GetActorCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroHeatMapSubsystem.__GetActorCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHeatMapSubsystem.__GetActorCount_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroHeatMapSubsystem.__GetActorCount_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601A1F9 RID: 107001 RVA: 0x0026902C File Offset: 0x0026722C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UTextureRenderTarget2D CreateHeatMapRenderTarget(int Width = 256, int Height = 256)
		{
			UKuroHeatMapSubsystem.__CreateHeatMapRenderTarget_FunctionParams* ptr = stackalloc UKuroHeatMapSubsystem.__CreateHeatMapRenderTarget_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroHeatMapSubsystem.__CreateHeatMapRenderTarget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHeatMapSubsystem.__CreateHeatMapRenderTarget_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Width = Width;
			ptr->Height = Height;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroHeatMapSubsystem.__CreateHeatMapRenderTarget_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTextureRenderTarget2D>(ptr->__Result);
		}

		// Token: 0x0601A1FA RID: 107002 RVA: 0x00269085 File Offset: 0x00267285
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ClearDrawRequest()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroHeatMapSubsystem.__ClearDrawRequest_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601A1FB RID: 107003 RVA: 0x0026909A File Offset: 0x0026729A
		static UKuroHeatMapSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroHeatMapSubsystem");
		}

		// Token: 0x0601A1FC RID: 107004 RVA: 0x002690A8 File Offset: 0x002672A8
		protected UKuroHeatMapSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E2F0 RID: 58096
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroHeatMapSubsystem";

		// Token: 0x0400E2F1 RID: 58097
		private static IntPtr _ClassPtr;

		// Token: 0x0400E2F2 RID: 58098
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E2F3 RID: 58099
		private static IntPtr __ShouldRedraw_NativeFunctionPtr;

		// Token: 0x0400E2F4 RID: 58100
		private static IntPtr __SetShouldRedraw_NativeFunctionPtr;

		// Token: 0x0400E2F5 RID: 58101
		private static IntPtr __SetRange_NativeFunctionPtr;

		// Token: 0x0400E2F6 RID: 58102
		private static IntPtr __RegisterDrawRequest_NativeFunctionPtr;

		// Token: 0x0400E2F7 RID: 58103
		private static IntPtr __IsPersistenceDraw_NativeFunctionPtr;

		// Token: 0x0400E2F8 RID: 58104
		private static IntPtr __GetRange_NativeFunctionPtr;

		// Token: 0x0400E2F9 RID: 58105
		private static IntPtr __GetCenterLocation_NativeFunctionPtr;

		// Token: 0x0400E2FA RID: 58106
		private static IntPtr __GetActorCount_NativeFunctionPtr;

		// Token: 0x0400E2FB RID: 58107
		private static IntPtr __CreateHeatMapRenderTarget_NativeFunctionPtr;

		// Token: 0x0400E2FC RID: 58108
		private static IntPtr __ClearDrawRequest_NativeFunctionPtr;

		// Token: 0x02003148 RID: 12616
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ShouldRedraw_FunctionParams
		{
			// Token: 0x04016F5D RID: 94045
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003149 RID: 12617
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetShouldRedraw_FunctionParams
		{
			// Token: 0x04016F5E RID: 94046
			[FieldOffset(0)]
			public bool bRedraw;
		}

		// Token: 0x0200314A RID: 12618
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetRange_FunctionParams
		{
			// Token: 0x04016F5F RID: 94047
			[FieldOffset(0)]
			public float Range;
		}

		// Token: 0x0200314B RID: 12619
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __RegisterDrawRequest_FunctionParams
		{
			// Token: 0x04016F60 RID: 94048
			[FieldOffset(0)]
			public byte DrawRequest;
		}

		// Token: 0x0200314C RID: 12620
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsPersistenceDraw_FunctionParams
		{
			// Token: 0x04016F61 RID: 94049
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200314D RID: 12621
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetRange_FunctionParams
		{
			// Token: 0x04016F62 RID: 94050
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x0200314E RID: 12622
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetCenterLocation_FunctionParams
		{
			// Token: 0x04016F63 RID: 94051
			[FieldOffset(0)]
			public FVector __Result;
		}

		// Token: 0x0200314F RID: 12623
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetActorCount_FunctionParams
		{
			// Token: 0x04016F64 RID: 94052
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02003150 RID: 12624
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __CreateHeatMapRenderTarget_FunctionParams
		{
			// Token: 0x04016F65 RID: 94053
			[FieldOffset(0)]
			public int Width;

			// Token: 0x04016F66 RID: 94054
			[FieldOffset(4)]
			public int Height;

			// Token: 0x04016F67 RID: 94055
			[FieldOffset(8)]
			public IntPtr __Result;
		}
	}
}
