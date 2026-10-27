using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F3F RID: 7999
	[UnrealObjectPath("/Script/KuroVoxelRuntime.KuroCaveVolumeSubsystem")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKuroCaveVolumeSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E6FF RID: 124671 RVA: 0x002D4021 File Offset: 0x002D2221
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCaveVolumeSubsystem._ClassPtr;
		}

		// Token: 0x0601E700 RID: 124672 RVA: 0x002D4030 File Offset: 0x002D2230
		public UKuroCaveVolumeSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroCaveVolumeSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E701 RID: 124673 RVA: 0x002D4058 File Offset: 0x002D2258
		[NullableContext(1)]
		public UKuroCaveVolumeSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCaveVolumeSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E702 RID: 124674 RVA: 0x002D408C File Offset: 0x002D228C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static byte D_QueryVoxelCaveType(UObject WorldContext, FVectorDouble UELocation, bool bTraceDown)
		{
			UKuroCaveVolumeSubsystem.__D_QueryVoxelCaveType_FunctionParams* ptr = stackalloc UKuroCaveVolumeSubsystem.__D_QueryVoxelCaveType_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroCaveVolumeSubsystem.__D_QueryVoxelCaveType_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCaveVolumeSubsystem.__D_QueryVoxelCaveType_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContext = ((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero);
			ptr->UELocation = UELocation;
			ptr->bTraceDown = bTraceDown;
			UnrealReflectionUtils.CallUFunction(UKuroCaveVolumeSubsystem._ClassDefaultObjectPtr, UKuroCaveVolumeSubsystem.__D_QueryVoxelCaveType_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601E703 RID: 124675 RVA: 0x002D40F5 File Offset: 0x002D22F5
		static UKuroCaveVolumeSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroVoxelRuntime.KuroCaveVolumeSubsystem");
		}

		// Token: 0x0601E704 RID: 124676 RVA: 0x002D4103 File Offset: 0x002D2303
		protected UKuroCaveVolumeSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040106C2 RID: 67266
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroVoxelRuntime.KuroCaveVolumeSubsystem";

		// Token: 0x040106C3 RID: 67267
		private static IntPtr _ClassPtr;

		// Token: 0x040106C4 RID: 67268
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040106C5 RID: 67269
		private static IntPtr __D_QueryVoxelCaveType_NativeFunctionPtr;

		// Token: 0x02003409 RID: 13321
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __D_QueryVoxelCaveType_FunctionParams
		{
			// Token: 0x040173CB RID: 95179
			[FieldOffset(0)]
			public IntPtr WorldContext;

			// Token: 0x040173CC RID: 95180
			[FieldOffset(8)]
			public FVectorDouble UELocation;

			// Token: 0x040173CD RID: 95181
			[FieldOffset(32)]
			public bool bTraceDown;

			// Token: 0x040173CE RID: 95182
			[FieldOffset(33)]
			public byte __Result;
		}
	}
}
