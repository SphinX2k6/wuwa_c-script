using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200145E RID: 5214
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HeadMountedDisplay.AsyncTask_LoadXRDeviceVisComponent")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UAsyncTask_LoadXRDeviceVisComponent : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601307D RID: 77949 RVA: 0x001BFE28 File Offset: 0x001BE028
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncTask_LoadXRDeviceVisComponent._ClassPtr;
		}

		// Token: 0x0601307E RID: 77950 RVA: 0x001BFE34 File Offset: 0x001BE034
		public UAsyncTask_LoadXRDeviceVisComponent() : this(BuiltinUtils.AllocNativeUObject(UAsyncTask_LoadXRDeviceVisComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601307F RID: 77951 RVA: 0x001BFE5C File Offset: 0x001BE05C
		public UAsyncTask_LoadXRDeviceVisComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncTask_LoadXRDeviceVisComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004A06 RID: 18950
		// (get) Token: 0x06013080 RID: 77952 RVA: 0x001BFE90 File Offset: 0x001BE090
		// (set) Token: 0x06013081 RID: 77953 RVA: 0x001BFEC9 File Offset: 0x001BE0C9
		public FDeviceModelLoadedDelegate OnModelLoaded
		{
			get
			{
				base.FastCheckIsValid();
				FDeviceModelLoadedDelegate result;
				if ((result = this._OnModelLoaded) == null)
				{
					result = (this._OnModelLoaded = new FDeviceModelLoadedDelegate(base.NativePtr + (IntPtr)UAsyncTask_LoadXRDeviceVisComponent.__PropertyOffset_OnModelLoaded, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncTask_LoadXRDeviceVisComponent.__PropertyOffset_OnModelLoaded, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004A07 RID: 18951
		// (get) Token: 0x06013082 RID: 77954 RVA: 0x001BFEEC File Offset: 0x001BE0EC
		// (set) Token: 0x06013083 RID: 77955 RVA: 0x001BFF25 File Offset: 0x001BE125
		public FDeviceModelLoadedDelegate OnLoadFailure
		{
			get
			{
				base.FastCheckIsValid();
				FDeviceModelLoadedDelegate result;
				if ((result = this._OnLoadFailure) == null)
				{
					result = (this._OnLoadFailure = new FDeviceModelLoadedDelegate(base.NativePtr + (IntPtr)UAsyncTask_LoadXRDeviceVisComponent.__PropertyOffset_OnLoadFailure, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncTask_LoadXRDeviceVisComponent.__PropertyOffset_OnLoadFailure, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004A08 RID: 18952
		// (get) Token: 0x06013084 RID: 77956 RVA: 0x001BFF46 File Offset: 0x001BE146
		// (set) Token: 0x06013085 RID: 77957 RVA: 0x001BFF5A File Offset: 0x001BE15A
		[Nullable(2)]
		public unsafe UPrimitiveComponent SpawnedComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTask_LoadXRDeviceVisComponent.__PropertyOffset_SpawnedComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTask_LoadXRDeviceVisComponent.__PropertyOffset_SpawnedComponent, value);
			}
		}

		// Token: 0x06013086 RID: 77958 RVA: 0x001BFF70 File Offset: 0x001BE170
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncTask_LoadXRDeviceVisComponent AddNamedDeviceVisualizationComponentAsync(AActor Target, FName SystemName, FName DeviceName, bool bManualAttachment, in FTransform RelativeTransform, ref FXRDeviceId XRDeviceId, ref UPrimitiveComponent NewComponent)
		{
			UAsyncTask_LoadXRDeviceVisComponent.__AddNamedDeviceVisualizationComponentAsync_FunctionParams* ptr = stackalloc UAsyncTask_LoadXRDeviceVisComponent.__AddNamedDeviceVisualizationComponentAsync_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(UAsyncTask_LoadXRDeviceVisComponent.__AddNamedDeviceVisualizationComponentAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTask_LoadXRDeviceVisComponent.__AddNamedDeviceVisualizationComponentAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			ptr->SystemName = SystemName;
			ptr->DeviceName = DeviceName;
			ptr->bManualAttachment = bManualAttachment;
			ptr->RelativeTransform = RelativeTransform;
			if (XRDeviceId != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FXRDeviceId.StaticStruct(), &ptr->XRDeviceId, XRDeviceId.NativePtr, 1, false);
			}
			ref UAsyncTask_LoadXRDeviceVisComponent.__AddNamedDeviceVisualizationComponentAsync_FunctionParams ptr2 = ref *ptr;
			UPrimitiveComponent uprimitiveComponent = NewComponent;
			ptr2.NewComponent = ((uprimitiveComponent != null) ? uprimitiveComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UAsyncTask_LoadXRDeviceVisComponent._ClassDefaultObjectPtr, UAsyncTask_LoadXRDeviceVisComponent.__AddNamedDeviceVisualizationComponentAsync_NativeFunctionPtr, (void*)ptr, 0);
			if (XRDeviceId != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FXRDeviceId.StaticStruct(), XRDeviceId.NativePtr, &ptr->XRDeviceId, 1, false);
			}
			NewComponent = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(ptr->NewComponent);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTask_LoadXRDeviceVisComponent>(ptr->__Result);
		}

		// Token: 0x06013087 RID: 77959 RVA: 0x001C0068 File Offset: 0x001BE268
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncTask_LoadXRDeviceVisComponent AddDeviceVisualizationComponentAsync(AActor Target, in FXRDeviceId XRDeviceId, bool bManualAttachment, in FTransform RelativeTransform, ref UPrimitiveComponent NewComponent)
		{
			UAsyncTask_LoadXRDeviceVisComponent.__AddDeviceVisualizationComponentAsync_FunctionParams* ptr = stackalloc UAsyncTask_LoadXRDeviceVisComponent.__AddDeviceVisualizationComponentAsync_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(UAsyncTask_LoadXRDeviceVisComponent.__AddDeviceVisualizationComponentAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTask_LoadXRDeviceVisComponent.__AddDeviceVisualizationComponentAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			if (XRDeviceId != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FXRDeviceId.StaticStruct(), &ptr->XRDeviceId, XRDeviceId.NativePtr, 1, false);
			}
			ptr->bManualAttachment = bManualAttachment;
			ptr->RelativeTransform = RelativeTransform;
			ref UAsyncTask_LoadXRDeviceVisComponent.__AddDeviceVisualizationComponentAsync_FunctionParams ptr2 = ref *ptr;
			UPrimitiveComponent uprimitiveComponent = NewComponent;
			ptr2.NewComponent = ((uprimitiveComponent != null) ? uprimitiveComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UAsyncTask_LoadXRDeviceVisComponent._ClassDefaultObjectPtr, UAsyncTask_LoadXRDeviceVisComponent.__AddDeviceVisualizationComponentAsync_NativeFunctionPtr, (void*)ptr, 0);
			NewComponent = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(ptr->NewComponent);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTask_LoadXRDeviceVisComponent>(ptr->__Result);
		}

		// Token: 0x06013088 RID: 77960 RVA: 0x001C0126 File Offset: 0x001BE326
		static UAsyncTask_LoadXRDeviceVisComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HeadMountedDisplay.AsyncTask_LoadXRDeviceVisComponent");
		}

		// Token: 0x06013089 RID: 77961 RVA: 0x001C0134 File Offset: 0x001BE334
		protected UAsyncTask_LoadXRDeviceVisComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A339 RID: 41785
		public new const string __ObjectPath = "/Script/HeadMountedDisplay.AsyncTask_LoadXRDeviceVisComponent";

		// Token: 0x0400A33A RID: 41786
		private static IntPtr _ClassPtr;

		// Token: 0x0400A33B RID: 41787
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A33C RID: 41788
		internal static int __PropertyOffset_OnModelLoaded;

		// Token: 0x0400A33D RID: 41789
		[Nullable(2)]
		private FDeviceModelLoadedDelegate _OnModelLoaded;

		// Token: 0x0400A33E RID: 41790
		internal static int __PropertyOffset_OnLoadFailure;

		// Token: 0x0400A33F RID: 41791
		[Nullable(2)]
		private FDeviceModelLoadedDelegate _OnLoadFailure;

		// Token: 0x0400A340 RID: 41792
		internal static int __PropertyOffset_SpawnedComponent;

		// Token: 0x0400A341 RID: 41793
		private static IntPtr __AddNamedDeviceVisualizationComponentAsync_NativeFunctionPtr;

		// Token: 0x0400A342 RID: 41794
		private static IntPtr __AddDeviceVisualizationComponentAsync_NativeFunctionPtr;

		// Token: 0x02002EA7 RID: 11943
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __AddNamedDeviceVisualizationComponentAsync_FunctionParams
		{
			// Token: 0x0401698C RID: 92556
			[FieldOffset(0)]
			public IntPtr Target;

			// Token: 0x0401698D RID: 92557
			[FieldOffset(8)]
			public FName SystemName;

			// Token: 0x0401698E RID: 92558
			[FieldOffset(20)]
			public FName DeviceName;

			// Token: 0x0401698F RID: 92559
			[FieldOffset(32)]
			public bool bManualAttachment;

			// Token: 0x04016990 RID: 92560
			[FieldOffset(48)]
			public FTransform RelativeTransform;

			// Token: 0x04016991 RID: 92561
			[FieldOffset(96)]
			public byte XRDeviceId;

			// Token: 0x04016992 RID: 92562
			[FieldOffset(112)]
			public IntPtr NewComponent;

			// Token: 0x04016993 RID: 92563
			[FieldOffset(120)]
			public IntPtr __Result;
		}

		// Token: 0x02002EA8 RID: 11944
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __AddDeviceVisualizationComponentAsync_FunctionParams
		{
			// Token: 0x04016994 RID: 92564
			[FieldOffset(0)]
			public IntPtr Target;

			// Token: 0x04016995 RID: 92565
			[FieldOffset(8)]
			public byte XRDeviceId;

			// Token: 0x04016996 RID: 92566
			[FieldOffset(24)]
			public bool bManualAttachment;

			// Token: 0x04016997 RID: 92567
			[FieldOffset(32)]
			public FTransform RelativeTransform;

			// Token: 0x04016998 RID: 92568
			[FieldOffset(80)]
			public IntPtr NewComponent;

			// Token: 0x04016999 RID: 92569
			[FieldOffset(88)]
			public IntPtr __Result;
		}
	}
}
