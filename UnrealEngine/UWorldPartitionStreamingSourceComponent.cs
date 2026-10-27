using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001289 RID: 4745
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionStreamingSourceComponent")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UWorldPartitionStreamingSourceComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601161C RID: 71196 RVA: 0x001983F0 File Offset: 0x001965F0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionStreamingSourceComponent._ClassPtr;
		}

		// Token: 0x0601161D RID: 71197 RVA: 0x001983FC File Offset: 0x001965FC
		public UWorldPartitionStreamingSourceComponent() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionStreamingSourceComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601161E RID: 71198 RVA: 0x00198424 File Offset: 0x00196624
		public UWorldPartitionStreamingSourceComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionStreamingSourceComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043B8 RID: 17336
		// (get) Token: 0x0601161F RID: 71199 RVA: 0x00198457 File Offset: 0x00196657
		// (set) Token: 0x06011620 RID: 71200 RVA: 0x00198467 File Offset: 0x00196667
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

		// Token: 0x170043B9 RID: 17337
		// (get) Token: 0x06011621 RID: 71201 RVA: 0x00198478 File Offset: 0x00196678
		// (set) Token: 0x06011622 RID: 71202 RVA: 0x00198488 File Offset: 0x00196688
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

		// Token: 0x170043BA RID: 17338
		// (get) Token: 0x06011623 RID: 71203 RVA: 0x0019849C File Offset: 0x0019669C
		// (set) Token: 0x06011624 RID: 71204 RVA: 0x001984D5 File Offset: 0x001966D5
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

		// Token: 0x170043BB RID: 17339
		// (get) Token: 0x06011625 RID: 71205 RVA: 0x001984E4 File Offset: 0x001966E4
		// (set) Token: 0x06011626 RID: 71206 RVA: 0x0019851D File Offset: 0x0019671D
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

		// Token: 0x170043BC RID: 17340
		// (get) Token: 0x06011627 RID: 71207 RVA: 0x0019852B File Offset: 0x0019672B
		// (set) Token: 0x06011628 RID: 71208 RVA: 0x0019853B File Offset: 0x0019673B
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

		// Token: 0x170043BD RID: 17341
		// (get) Token: 0x06011629 RID: 71209 RVA: 0x0019854C File Offset: 0x0019674C
		// (set) Token: 0x0601162A RID: 71210 RVA: 0x0019855C File Offset: 0x0019675C
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

		// Token: 0x170043BE RID: 17342
		// (get) Token: 0x0601162B RID: 71211 RVA: 0x0019856D File Offset: 0x0019676D
		// (set) Token: 0x0601162C RID: 71212 RVA: 0x0019857D File Offset: 0x0019677D
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

		// Token: 0x170043BF RID: 17343
		// (get) Token: 0x0601162D RID: 71213 RVA: 0x0019858E File Offset: 0x0019678E
		// (set) Token: 0x0601162E RID: 71214 RVA: 0x0019859E File Offset: 0x0019679E
		public unsafe EStreamingSourceTargetState TargetState
		{
			get
			{
				return (EStreamingSourceTargetState)(*(base.NativePtr + (IntPtr)UWorldPartitionStreamingSourceComponent.__PropertyOffset_TargetState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionStreamingSourceComponent.__PropertyOffset_TargetState) = (byte)value;
			}
		}

		// Token: 0x0601162F RID: 71215 RVA: 0x001985AF File Offset: 0x001967AF
		[NullableContext(2)]
		public void LogStreamingStuckInfo2(TArray<FName> InDataLayerLabels, bool bUseGridLoadingRange, float Radius, bool bRequirePhysicsReady)
		{
			UWorldPartitionStreamingSourceComponent.__LogStreamingStuckInfo2_Internal(base.NativePtr, (InDataLayerLabels ?? new TArray<FName>()).NativePtr, bUseGridLoadingRange, Radius, bRequirePhysicsReady);
		}

		// Token: 0x06011630 RID: 71216 RVA: 0x001985CF File Offset: 0x001967CF
		[NullableContext(2)]
		public bool KURO_IsStreamingCompleted(ref FStreamingCompleteContext InParams)
		{
			return UWorldPartitionStreamingSourceComponent.__KURO_IsStreamingCompleted_Internal(base.NativePtr, (InParams ?? new FStreamingCompleteContext()).NativePtr);
		}

		// Token: 0x06011631 RID: 71217 RVA: 0x001985EC File Offset: 0x001967EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsStreamingSourceEnabled()
		{
			UWorldPartitionStreamingSourceComponent.__IsStreamingSourceEnabled_FunctionParams* ptr = stackalloc UWorldPartitionStreamingSourceComponent.__IsStreamingSourceEnabled_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UWorldPartitionStreamingSourceComponent.__IsStreamingSourceEnabled_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UWorldPartitionStreamingSourceComponent.__IsStreamingSourceEnabled_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UWorldPartitionStreamingSourceComponent.__IsStreamingSourceEnabled_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06011632 RID: 71218 RVA: 0x00198634 File Offset: 0x00196834
		[NullableContext(2)]
		public unsafe bool IsStreamingCompletedForLayers2(TArray<FName> InDataLayerLabels, bool bUseGridLoadingRange, float Radius, bool bNeedProgress, ref float OutProgress, bool bRequirePhysicsReady)
		{
			fixed (float* ptr = &OutProgress)
			{
				void* ptr2 = (void*)ptr;
				return UWorldPartitionStreamingSourceComponent.__IsStreamingCompletedForLayers2_Internal(base.NativePtr, (InDataLayerLabels ?? new TArray<FName>()).NativePtr, bUseGridLoadingRange, Radius, bNeedProgress, ref OutProgress, bRequirePhysicsReady);
			}
		}

		// Token: 0x06011633 RID: 71219 RVA: 0x00198669 File Offset: 0x00196869
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void EnableStreamingSource()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UWorldPartitionStreamingSourceComponent.__EnableStreamingSource_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06011634 RID: 71220 RVA: 0x0019867E File Offset: 0x0019687E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void DisableStreamingSource()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UWorldPartitionStreamingSourceComponent.__DisableStreamingSource_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06011635 RID: 71221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LogStreamingStuckInfo2_Internal(IntPtr @this, IntPtr InDataLayerLabels, bool bUseGridLoadingRange, float Radius, bool bRequirePhysicsReady);

		// Token: 0x06011636 RID: 71222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __KURO_IsStreamingCompleted_Internal(IntPtr @this, IntPtr InParams);

		// Token: 0x06011637 RID: 71223
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStreamingCompletedForLayers2_Internal(IntPtr @this, IntPtr InDataLayerLabels, bool bUseGridLoadingRange, float Radius, bool bNeedProgress, ref float OutProgress, bool bRequirePhysicsReady);

		// Token: 0x06011638 RID: 71224 RVA: 0x00198693 File Offset: 0x00196893
		static UWorldPartitionStreamingSourceComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionStreamingSourceComponent");
		}

		// Token: 0x06011639 RID: 71225 RVA: 0x001986A1 File Offset: 0x001968A1
		protected UWorldPartitionStreamingSourceComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040094D4 RID: 38100
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionStreamingSourceComponent";

		// Token: 0x040094D5 RID: 38101
		private static IntPtr _ClassPtr;

		// Token: 0x040094D6 RID: 38102
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040094D7 RID: 38103
		internal static int __PropertyOffset_TargetBehavior;

		// Token: 0x040094D8 RID: 38104
		internal static int __PropertyOffset_DisableBehavior;

		// Token: 0x040094D9 RID: 38105
		internal static int __PropertyOffset_TargetGrids;

		// Token: 0x040094DA RID: 38106
		[Nullable(2)]
		private TArray<FName> _TargetGrids;

		// Token: 0x040094DB RID: 38107
		internal static int __PropertyOffset_Shapes;

		// Token: 0x040094DC RID: 38108
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStreamingSourceShape> _Shapes;

		// Token: 0x040094DD RID: 38109
		internal static int __PropertyOffset_Priority;

		// Token: 0x040094DE RID: 38110
		internal static int __PropertyOffset_bStreamingSourceShouldBlockOnSlowStreaming;

		// Token: 0x040094DF RID: 38111
		internal static int __PropertyOffset_bStreamingSourceEnabled;

		// Token: 0x040094E0 RID: 38112
		internal static int __PropertyOffset_TargetState;

		// Token: 0x040094E1 RID: 38113
		private static IntPtr __IsStreamingSourceEnabled_NativeFunctionPtr;

		// Token: 0x040094E2 RID: 38114
		private static IntPtr __EnableStreamingSource_NativeFunctionPtr;

		// Token: 0x040094E3 RID: 38115
		private static IntPtr __DisableStreamingSource_NativeFunctionPtr;

		// Token: 0x02002E19 RID: 11801
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsStreamingSourceEnabled_FunctionParams
		{
			// Token: 0x0401689E RID: 92318
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
