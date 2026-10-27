using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B96 RID: 7062
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroRainActorV2")]
	[UnrealStructLayout(1448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1448)]
	public class AKuroRainActorV2 : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601ADF1 RID: 110065 RVA: 0x00279F5C File Offset: 0x0027815C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroRainActorV2._ClassPtr;
		}

		// Token: 0x0601ADF2 RID: 110066 RVA: 0x00279F68 File Offset: 0x00278168
		public AKuroRainActorV2() : this(BuiltinUtils.AllocNativeUObject(AKuroRainActorV2.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601ADF3 RID: 110067 RVA: 0x00279F90 File Offset: 0x00278190
		[NullableContext(1)]
		public AKuroRainActorV2(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroRainActorV2.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601ADF4 RID: 110068 RVA: 0x00279FC4 File Offset: 0x002781C4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdatePlayingRainComponent(UKuroRainComponent RainComponent)
		{
			AKuroRainActorV2.__UpdatePlayingRainComponent_FunctionParams* ptr = stackalloc AKuroRainActorV2.__UpdatePlayingRainComponent_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(AKuroRainActorV2.__UpdatePlayingRainComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AKuroRainActorV2.__UpdatePlayingRainComponent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RainComponent = ((RainComponent != null) ? RainComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AKuroRainActorV2.__UpdatePlayingRainComponent_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601ADF5 RID: 110069 RVA: 0x0027A01C File Offset: 0x0027821C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetCameraFrustum(UKuroRainComponent Comp)
		{
			AKuroRainActorV2.__SetCameraFrustum_FunctionParams* ptr = stackalloc AKuroRainActorV2.__SetCameraFrustum_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(AKuroRainActorV2.__SetCameraFrustum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AKuroRainActorV2.__SetCameraFrustum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Comp = ((Comp != null) ? Comp.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroRainActorV2.__SetCameraFrustum_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601ADF6 RID: 110070 RVA: 0x0027A074 File Offset: 0x00278274
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void RemoveRainComponent(UKuroRainComponent Comp)
		{
			AKuroRainActorV2.__RemoveRainComponent_FunctionParams* ptr = stackalloc AKuroRainActorV2.__RemoveRainComponent_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(AKuroRainActorV2.__RemoveRainComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AKuroRainActorV2.__RemoveRainComponent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Comp = ((Comp != null) ? Comp.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroRainActorV2.__RemoveRainComponent_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601ADF7 RID: 110071 RVA: 0x0027A0CA File Offset: 0x002782CA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ProcessPlayingRainComponents()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroRainActorV2.__ProcessPlayingRainComponents_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601ADF8 RID: 110072 RVA: 0x0027A0E0 File Offset: 0x002782E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void GetPlayerOrEditorCameraLocation(ref FVector OutLocation)
		{
			AKuroRainActorV2.__GetPlayerOrEditorCameraLocation_FunctionParams* ptr = stackalloc AKuroRainActorV2.__GetPlayerOrEditorCameraLocation_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(AKuroRainActorV2.__GetPlayerOrEditorCameraLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AKuroRainActorV2.__GetPlayerOrEditorCameraLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutLocation = OutLocation;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroRainActorV2.__GetPlayerOrEditorCameraLocation_NativeFunctionPtr, (void*)ptr, 0);
			OutLocation = ptr->OutLocation;
		}

		// Token: 0x0601ADF9 RID: 110073 RVA: 0x0027A138 File Offset: 0x00278338
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EnableRain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AKuroRainActorV2.__EnableRain_NativeFunctionPtr, null);
		}

		// Token: 0x0601ADFA RID: 110074 RVA: 0x0027A14C File Offset: 0x0027834C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DisableRain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AKuroRainActorV2.__DisableRain_NativeFunctionPtr, null);
		}

		// Token: 0x0601ADFB RID: 110075 RVA: 0x0027A160 File Offset: 0x00278360
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void D_GetPlayerOrEditorCameraLocation(ref FVectorDouble OutLocation)
		{
			AKuroRainActorV2.__D_GetPlayerOrEditorCameraLocation_FunctionParams* ptr = stackalloc AKuroRainActorV2.__D_GetPlayerOrEditorCameraLocation_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(AKuroRainActorV2.__D_GetPlayerOrEditorCameraLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AKuroRainActorV2.__D_GetPlayerOrEditorCameraLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutLocation = OutLocation;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroRainActorV2.__D_GetPlayerOrEditorCameraLocation_NativeFunctionPtr, (void*)ptr, 0);
			OutLocation = ptr->OutLocation;
		}

		// Token: 0x0601ADFC RID: 110076 RVA: 0x0027A1B8 File Offset: 0x002783B8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UKuroRainComponent AddRainComponent([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UKuroRainComponent> ClassType)
		{
			AKuroRainActorV2.__AddRainComponent_FunctionParams* ptr = stackalloc AKuroRainActorV2.__AddRainComponent_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(AKuroRainActorV2.__AddRainComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AKuroRainActorV2.__AddRainComponent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ClassType = ClassType;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroRainActorV2.__AddRainComponent_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroRainComponent>(ptr->__Result);
		}

		// Token: 0x0601ADFD RID: 110077 RVA: 0x0027A20A File Offset: 0x0027840A
		static AKuroRainActorV2()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroRainActorV2");
		}

		// Token: 0x0601ADFE RID: 110078 RVA: 0x0027A218 File Offset: 0x00278418
		protected AKuroRainActorV2(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E8BA RID: 59578
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroRainActorV2";

		// Token: 0x0400E8BB RID: 59579
		private static IntPtr _ClassPtr;

		// Token: 0x0400E8BC RID: 59580
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E8BD RID: 59581
		private static IntPtr __UpdatePlayingRainComponent_NativeFunctionPtr;

		// Token: 0x0400E8BE RID: 59582
		private static IntPtr __SetCameraFrustum_NativeFunctionPtr;

		// Token: 0x0400E8BF RID: 59583
		private static IntPtr __RemoveRainComponent_NativeFunctionPtr;

		// Token: 0x0400E8C0 RID: 59584
		private static IntPtr __ProcessPlayingRainComponents_NativeFunctionPtr;

		// Token: 0x0400E8C1 RID: 59585
		private static IntPtr __GetPlayerOrEditorCameraLocation_NativeFunctionPtr;

		// Token: 0x0400E8C2 RID: 59586
		private static IntPtr __EnableRain_NativeFunctionPtr;

		// Token: 0x0400E8C3 RID: 59587
		private static IntPtr __DisableRain_NativeFunctionPtr;

		// Token: 0x0400E8C4 RID: 59588
		private static IntPtr __D_GetPlayerOrEditorCameraLocation_NativeFunctionPtr;

		// Token: 0x0400E8C5 RID: 59589
		private static IntPtr __AddRainComponent_NativeFunctionPtr;

		// Token: 0x02003163 RID: 12643
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __UpdatePlayingRainComponent_FunctionParams
		{
			// Token: 0x04016F8B RID: 94091
			[FieldOffset(0)]
			public IntPtr RainComponent;
		}

		// Token: 0x02003164 RID: 12644
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetCameraFrustum_FunctionParams
		{
			// Token: 0x04016F8C RID: 94092
			[FieldOffset(0)]
			public IntPtr Comp;
		}

		// Token: 0x02003165 RID: 12645
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __RemoveRainComponent_FunctionParams
		{
			// Token: 0x04016F8D RID: 94093
			[FieldOffset(0)]
			public IntPtr Comp;
		}

		// Token: 0x02003166 RID: 12646
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetPlayerOrEditorCameraLocation_FunctionParams
		{
			// Token: 0x04016F8E RID: 94094
			[FieldOffset(0)]
			public FVector OutLocation;
		}

		// Token: 0x02003167 RID: 12647
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __D_GetPlayerOrEditorCameraLocation_FunctionParams
		{
			// Token: 0x04016F8F RID: 94095
			[FieldOffset(0)]
			public FVectorDouble OutLocation;
		}

		// Token: 0x02003168 RID: 12648
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __AddRainComponent_FunctionParams
		{
			// Token: 0x04016F90 RID: 94096
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<UKuroRainComponent> ClassType;

			// Token: 0x04016F91 RID: 94097
			[FieldOffset(8)]
			public IntPtr __Result;
		}
	}
}
