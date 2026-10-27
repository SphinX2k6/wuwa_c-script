using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001287 RID: 4743
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionStreamingPortal")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1136)]
	public class AWorldPartitionStreamingPortal : ATriggerSphere, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060115EB RID: 71147 RVA: 0x00197FA5 File Offset: 0x001961A5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AWorldPartitionStreamingPortal._ClassPtr;
		}

		// Token: 0x060115EC RID: 71148 RVA: 0x00197FB4 File Offset: 0x001961B4
		public AWorldPartitionStreamingPortal() : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionStreamingPortal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060115ED RID: 71149 RVA: 0x00197FDC File Offset: 0x001961DC
		public AWorldPartitionStreamingPortal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionStreamingPortal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043AE RID: 17326
		// (get) Token: 0x060115EE RID: 71150 RVA: 0x0019800F File Offset: 0x0019620F
		// (set) Token: 0x060115EF RID: 71151 RVA: 0x00198023 File Offset: 0x00196223
		[Nullable(2)]
		public unsafe UWorldPartitionStreamingSourceComponent StreamingSourceComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorldPartitionStreamingSourceComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AWorldPartitionStreamingPortal.__PropertyOffset_StreamingSourceComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AWorldPartitionStreamingPortal.__PropertyOffset_StreamingSourceComponent, value);
			}
		}

		// Token: 0x170043AF RID: 17327
		// (get) Token: 0x060115F0 RID: 71152 RVA: 0x00198038 File Offset: 0x00196238
		// (set) Token: 0x060115F1 RID: 71153 RVA: 0x0019804D File Offset: 0x0019624D
		public TSoftObjectPtr<AActor> Target
		{
			get
			{
				return new TSoftObjectPtr<AActor>(base.NativePtr + (IntPtr)AWorldPartitionStreamingPortal.__PropertyOffset_Target, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)AWorldPartitionStreamingPortal.__PropertyOffset_Target, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x060115F2 RID: 71154 RVA: 0x00198072 File Offset: 0x00196272
		[NullableContext(2)]
		public void SetTargetStreamingSourceComponent(UWorldPartitionStreamingSourceComponent InComponent)
		{
			AWorldPartitionStreamingPortal.__SetTargetStreamingSourceComponent_Internal(base.NativePtr, (InComponent != null) ? InComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060115F3 RID: 71155 RVA: 0x00198090 File Offset: 0x00196290
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetTarget(TSoftObjectPtr<AActor> InTarget)
		{
			AWorldPartitionStreamingPortal.__SetTarget_FunctionParams* ptr = stackalloc AWorldPartitionStreamingPortal.__SetTarget_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(AWorldPartitionStreamingPortal.__SetTarget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AWorldPartitionStreamingPortal.__SetTarget_NativeFunctionPtr, (void*)ptr, 1);
			if (InTarget != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->InTarget, InTarget.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AWorldPartitionStreamingPortal.__SetTarget_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(AWorldPartitionStreamingPortal.__SetTarget_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060115F4 RID: 71156 RVA: 0x001980FD File Offset: 0x001962FD
		public virtual void OnStateChanged()
		{
			AWorldPartitionStreamingPortal.__OnStateChanged_Internal(base.NativePtr);
		}

		// Token: 0x060115F5 RID: 71157 RVA: 0x0019810A File Offset: 0x0019630A
		protected virtual void OnStateChanged_Implementation()
		{
			AWorldPartitionStreamingPortal.__OnStateChanged_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x060115F6 RID: 71158 RVA: 0x00198117 File Offset: 0x00196317
		public virtual bool IsStreamingAllowed()
		{
			return AWorldPartitionStreamingPortal.__IsStreamingAllowed_Internal(base.NativePtr);
		}

		// Token: 0x060115F7 RID: 71159 RVA: 0x00198124 File Offset: 0x00196324
		protected virtual bool IsStreamingAllowed_Implementation()
		{
			return AWorldPartitionStreamingPortal.__IsStreamingAllowed_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x060115F8 RID: 71160 RVA: 0x00198131 File Offset: 0x00196331
		[NullableContext(2)]
		public UWorldPartitionStreamingSourceComponent GetTargetStreamingSourceComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWorldPartitionStreamingSourceComponent>(AWorldPartitionStreamingPortal.__GetTargetStreamingSourceComponent_Internal(base.NativePtr));
		}

		// Token: 0x060115F9 RID: 71161 RVA: 0x00198144 File Offset: 0x00196344
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSoftObjectPtr<AActor> GetTarget()
		{
			AWorldPartitionStreamingPortal.__GetTarget_FunctionParams* ptr = stackalloc AWorldPartitionStreamingPortal.__GetTarget_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(AWorldPartitionStreamingPortal.__GetTarget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AWorldPartitionStreamingPortal.__GetTarget_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AWorldPartitionStreamingPortal.__GetTarget_NativeFunctionPtr, (void*)ptr, 0);
			TSoftObjectPtr<AActor> result = new TSoftObjectPtr<AActor>(&ptr->__Result, false, true);
			UnrealReflectionUtils.DestroyStruct(AWorldPartitionStreamingPortal.__GetTarget_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060115FA RID: 71162 RVA: 0x001981A3 File Offset: 0x001963A3
		[NullableContext(2)]
		public UWorldPartitionStreamingSourceComponent GetStreamingSourceComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWorldPartitionStreamingSourceComponent>(AWorldPartitionStreamingPortal.__GetStreamingSourceComponent_Internal(base.NativePtr));
		}

		// Token: 0x060115FB RID: 71163
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetStreamingSourceComponent_Internal(IntPtr @this, IntPtr InComponent);

		// Token: 0x060115FC RID: 71164
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnStateChanged_Internal(IntPtr @this);

		// Token: 0x060115FD RID: 71165
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnStateChanged_Implementation_Internal(IntPtr @this);

		// Token: 0x060115FE RID: 71166
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStreamingAllowed_Internal(IntPtr @this);

		// Token: 0x060115FF RID: 71167
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStreamingAllowed_Implementation_Internal(IntPtr @this);

		// Token: 0x06011600 RID: 71168
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTargetStreamingSourceComponent_Internal(IntPtr @this);

		// Token: 0x06011601 RID: 71169
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetStreamingSourceComponent_Internal(IntPtr @this);

		// Token: 0x06011602 RID: 71170 RVA: 0x001981B5 File Offset: 0x001963B5
		static AWorldPartitionStreamingPortal()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionStreamingPortal");
		}

		// Token: 0x06011603 RID: 71171 RVA: 0x001981C3 File Offset: 0x001963C3
		protected AWorldPartitionStreamingPortal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040094C1 RID: 38081
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionStreamingPortal";

		// Token: 0x040094C2 RID: 38082
		private static IntPtr _ClassPtr;

		// Token: 0x040094C3 RID: 38083
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040094C4 RID: 38084
		internal static int __PropertyOffset_StreamingSourceComponent;

		// Token: 0x040094C5 RID: 38085
		internal static int __PropertyOffset_Target;

		// Token: 0x040094C6 RID: 38086
		private static IntPtr __SetTarget_NativeFunctionPtr;

		// Token: 0x040094C7 RID: 38087
		private static IntPtr __GetTarget_NativeFunctionPtr;

		// Token: 0x02002E16 RID: 11798
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetTarget_FunctionParams
		{
			// Token: 0x0401689B RID: 92315
			[FieldOffset(0)]
			public byte InTarget;
		}

		// Token: 0x02002E17 RID: 11799
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsStreamingAllowed_FunctionParams
		{
			// Token: 0x0401689C RID: 92316
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02002E18 RID: 11800
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetTarget_FunctionParams
		{
			// Token: 0x0401689D RID: 92317
			[FieldOffset(0)]
			public byte __Result;
		}
	}
}
