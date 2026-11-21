using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002B3 RID: 691
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionStreamingSourceComponent")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UWorldPartitionStreamingSourceComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004AC5 RID: 19141 RVA: 0x00068A55 File Offset: 0x00066C55
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionStreamingSourceComponent._ClassPtr;
		}

		// Token: 0x06004AC6 RID: 19142 RVA: 0x00068A64 File Offset: 0x00066C64
		public UWorldPartitionStreamingSourceComponent() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionStreamingSourceComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004AC7 RID: 19143 RVA: 0x00068A8C File Offset: 0x00066C8C
		public UWorldPartitionStreamingSourceComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionStreamingSourceComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06004AC8 RID: 19144 RVA: 0x00068ABF File Offset: 0x00066CBF
		// (set) Token: 0x06004AC9 RID: 19145 RVA: 0x00068ACF File Offset: 0x00066CCF
		public unsafe EStreamingSourceTargetBehavior TargetBehavior
		{
			get
			{
				return (EStreamingSourceTargetBehavior)(*(base.NativePtr + (IntPtr)UWorldPartitionStreamingSourceComponent.__PropertyOffset_TargetBehavior));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionStreamingSourceComponent.__PropertyOffset_TargetBehavior) = (byte)value;
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06004ACA RID: 19146 RVA: 0x00068AE0 File Offset: 0x00066CE0
		// (set) Token: 0x06004ACB RID: 19147 RVA: 0x00068AF0 File Offset: 0x00066CF0
		public unsafe EStreamingSourceDisableBehavior DisableBehavior
		{
			get
			{
				return (EStreamingSourceDisableBehavior)(*(base.NativePtr + (IntPtr)UWorldPartitionStreamingSourceComponent.__PropertyOffset_DisableBehavior));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionStreamingSourceComponent.__PropertyOffset_DisableBehavior) = (byte)value;
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06004ACC RID: 19148 RVA: 0x00068B04 File Offset: 0x00066D04
		// (set) Token: 0x06004ACD RID: 19149 RVA: 0x00068B3D File Offset: 0x00066D3D
		public TArray<FName> TargetGrids
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TargetGrids) == null)
				{
					result = (this._TargetGrids = new TArray<FName>(base.NativePtr + (IntPtr)UWorldPartitionStreamingSourceComponent.__PropertyOffset_TargetGrids, this));
				}
				return result;
			}
			set
			{
				this.TargetGrids.CopyAssign(value);
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06004ACE RID: 19150 RVA: 0x00068B4C File Offset: 0x00066D4C
		// (set) Token: 0x06004ACF RID: 19151 RVA: 0x00068B85 File Offset: 0x00066D85
		public TArray<FStreamingSourceShape> Shapes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FStreamingSourceShape> result;
				if ((result = this._Shapes) == null)
				{
					result = (this._Shapes = new TArray<FStreamingSourceShape>(base.NativePtr + (IntPtr)UWorldPartitionStreamingSourceComponent.__PropertyOffset_Shapes, this));
				}
				return result;
			}
			set
			{
				this.Shapes.CopyAssign(value);
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06004AD0 RID: 19152 RVA: 0x00068B93 File Offset: 0x00066D93
		// (set) Token: 0x06004AD1 RID: 19153 RVA: 0x00068BA3 File Offset: 0x00066DA3
		public unsafe EStreamingSourcePriority Priority
		{
			get
			{
				return (EStreamingSourcePriority)(*(base.NativePtr + (IntPtr)UWorldPartitionStreamingSourceComponent.__PropertyOffset_Priority));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionStreamingSourceComponent.__PropertyOffset_Priority) = (byte)value;
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06004AD2 RID: 19154 RVA: 0x00068BB4 File Offset: 0x00066DB4
		// (set) Token: 0x06004AD3 RID: 19155 RVA: 0x00068BC4 File Offset: 0x00066DC4
		public unsafe bool bStreamingSourceShouldBlockOnSlowStreaming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldPartitionStreamingSourceComponent.__PropertyOffset_bStreamingSourceShouldBlockOnSlowStreaming) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionStreamingSourceComponent.__PropertyOffset_bStreamingSourceShouldBlockOnSlowStreaming) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06004AD4 RID: 19156 RVA: 0x00068BD5 File Offset: 0x00066DD5
		// (set) Token: 0x06004AD5 RID: 19157 RVA: 0x00068BE5 File Offset: 0x00066DE5
		public unsafe bool bStreamingSourceEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldPartitionStreamingSourceComponent.__PropertyOffset_bStreamingSourceEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionStreamingSourceComponent.__PropertyOffset_bStreamingSourceEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004AD6 RID: 19158 RVA: 0x00068BF6 File Offset: 0x00066DF6
		[NullableContext(2)]
		public void LogStreamingStuckInfo2(TArray<FName> InDataLayerLabels, bool bUseGridLoadingRange, float Radius, bool bRequirePhysicsReady)
		{
			UWorldPartitionStreamingSourceComponent.__LogStreamingStuckInfo2_Internal(base.NativePtr, (InDataLayerLabels ?? new TArray<FName>()).NativePtr, bUseGridLoadingRange, Radius, bRequirePhysicsReady);
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x00068C18 File Offset: 0x00066E18
		[SkipLocalsInit]
		public unsafe bool IsStreamingSourceEnabled()
		{
			UWorldPartitionStreamingSourceComponent.__IsStreamingSourceEnabled_FunctionParams* ptr = stackalloc UWorldPartitionStreamingSourceComponent.__IsStreamingSourceEnabled_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UWorldPartitionStreamingSourceComponent.__IsStreamingSourceEnabled_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UWorldPartitionStreamingSourceComponent.__IsStreamingSourceEnabled_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UWorldPartitionStreamingSourceComponent.__IsStreamingSourceEnabled_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x00068C60 File Offset: 0x00066E60
		[NullableContext(2)]
		public unsafe bool IsStreamingCompletedForLayers2(TArray<FName> InDataLayerLabels, bool bUseGridLoadingRange, float Radius, bool bNeedProgress, ref float OutProgress, bool bRequirePhysicsReady)
		{
			fixed (float* ptr = &OutProgress)
			{
				void* ptr2 = (void*)ptr;
				return UWorldPartitionStreamingSourceComponent.__IsStreamingCompletedForLayers2_Internal(base.NativePtr, (InDataLayerLabels ?? new TArray<FName>()).NativePtr, bUseGridLoadingRange, Radius, bNeedProgress, ref OutProgress, bRequirePhysicsReady);
			}
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x00068C95 File Offset: 0x00066E95
		[SkipLocalsInit]
		public void EnableStreamingSource()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UWorldPartitionStreamingSourceComponent.__EnableStreamingSource_NativeFunctionPtr, null);
		}

		// Token: 0x06004ADA RID: 19162 RVA: 0x00068CA9 File Offset: 0x00066EA9
		[SkipLocalsInit]
		public void DisableStreamingSource()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UWorldPartitionStreamingSourceComponent.__DisableStreamingSource_NativeFunctionPtr, null);
		}

		// Token: 0x06004ADB RID: 19163
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LogStreamingStuckInfo2_Internal(IntPtr @this, IntPtr InDataLayerLabels, bool bUseGridLoadingRange, float Radius, bool bRequirePhysicsReady);

		// Token: 0x06004ADC RID: 19164
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStreamingCompletedForLayers2_Internal(IntPtr @this, IntPtr InDataLayerLabels, bool bUseGridLoadingRange, float Radius, bool bNeedProgress, ref float OutProgress, bool bRequirePhysicsReady);

		// Token: 0x06004ADD RID: 19165 RVA: 0x00068CBD File Offset: 0x00066EBD
		static UWorldPartitionStreamingSourceComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionStreamingSourceComponent");
		}

		// Token: 0x06004ADE RID: 19166 RVA: 0x00068CCB File Offset: 0x00066ECB
		protected UWorldPartitionStreamingSourceComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D81 RID: 7553
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionStreamingSourceComponent";

		// Token: 0x04001D82 RID: 7554
		private static IntPtr _ClassPtr;

		// Token: 0x04001D83 RID: 7555
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001D84 RID: 7556
		internal static int __PropertyOffset_TargetBehavior;

		// Token: 0x04001D85 RID: 7557
		internal static int __PropertyOffset_DisableBehavior;

		// Token: 0x04001D86 RID: 7558
		internal static int __PropertyOffset_TargetGrids;

		// Token: 0x04001D87 RID: 7559
		[Nullable(2)]
		private TArray<FName> _TargetGrids;

		// Token: 0x04001D88 RID: 7560
		internal static int __PropertyOffset_Shapes;

		// Token: 0x04001D89 RID: 7561
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStreamingSourceShape> _Shapes;

		// Token: 0x04001D8A RID: 7562
		internal static int __PropertyOffset_Priority;

		// Token: 0x04001D8B RID: 7563
		internal static int __PropertyOffset_bStreamingSourceShouldBlockOnSlowStreaming;

		// Token: 0x04001D8C RID: 7564
		internal static int __PropertyOffset_bStreamingSourceEnabled;

		// Token: 0x04001D8D RID: 7565
		private static IntPtr __IsStreamingSourceEnabled_NativeFunctionPtr;

		// Token: 0x04001D8E RID: 7566
		private static IntPtr __EnableStreamingSource_NativeFunctionPtr;

		// Token: 0x04001D8F RID: 7567
		private static IntPtr __DisableStreamingSource_NativeFunctionPtr;

		// Token: 0x020009F9 RID: 2553
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsStreamingSourceEnabled_FunctionParams
		{
			// Token: 0x0400599E RID: 22942
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
