using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002B1 RID: 689
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionStreamingPortal")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1136)]
	public class AWorldPartitionStreamingPortal : ATriggerSphere, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004A95 RID: 19093 RVA: 0x0006865D File Offset: 0x0006685D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AWorldPartitionStreamingPortal._ClassPtr;
		}

		// Token: 0x06004A96 RID: 19094 RVA: 0x0006866C File Offset: 0x0006686C
		public AWorldPartitionStreamingPortal() : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionStreamingPortal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004A97 RID: 19095 RVA: 0x00068694 File Offset: 0x00066894
		public AWorldPartitionStreamingPortal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionStreamingPortal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06004A98 RID: 19096 RVA: 0x000686C7 File Offset: 0x000668C7
		// (set) Token: 0x06004A99 RID: 19097 RVA: 0x000686DB File Offset: 0x000668DB
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

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06004A9A RID: 19098 RVA: 0x000686F0 File Offset: 0x000668F0
		// (set) Token: 0x06004A9B RID: 19099 RVA: 0x00068705 File Offset: 0x00066905
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

		// Token: 0x06004A9C RID: 19100 RVA: 0x0006872A File Offset: 0x0006692A
		[NullableContext(2)]
		public void SetTargetStreamingSourceComponent(UWorldPartitionStreamingSourceComponent InComponent)
		{
			AWorldPartitionStreamingPortal.__SetTargetStreamingSourceComponent_Internal(base.NativePtr, (InComponent != null) ? InComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06004A9D RID: 19101 RVA: 0x00068748 File Offset: 0x00066948
		[SkipLocalsInit]
		public unsafe void SetTarget(TSoftObjectPtr<AActor> InTarget)
		{
			AWorldPartitionStreamingPortal.__SetTarget_FunctionParams* ptr = stackalloc AWorldPartitionStreamingPortal.__SetTarget_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(AWorldPartitionStreamingPortal.__SetTarget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AWorldPartitionStreamingPortal.__SetTarget_NativeFunctionPtr, (void*)ptr, 1);
			if (InTarget != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->InTarget, InTarget.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AWorldPartitionStreamingPortal.__SetTarget_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(AWorldPartitionStreamingPortal.__SetTarget_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06004A9E RID: 19102 RVA: 0x000687B4 File Offset: 0x000669B4
		public virtual void OnStateChanged()
		{
			AWorldPartitionStreamingPortal.__OnStateChanged_Internal(base.NativePtr);
		}

		// Token: 0x06004A9F RID: 19103 RVA: 0x000687C1 File Offset: 0x000669C1
		protected virtual void OnStateChanged_Implementation()
		{
			AWorldPartitionStreamingPortal.__OnStateChanged_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x06004AA0 RID: 19104 RVA: 0x000687CE File Offset: 0x000669CE
		public virtual bool IsStreamingAllowed()
		{
			return AWorldPartitionStreamingPortal.__IsStreamingAllowed_Internal(base.NativePtr);
		}

		// Token: 0x06004AA1 RID: 19105 RVA: 0x000687DB File Offset: 0x000669DB
		protected virtual bool IsStreamingAllowed_Implementation()
		{
			return AWorldPartitionStreamingPortal.__IsStreamingAllowed_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x06004AA2 RID: 19106 RVA: 0x000687E8 File Offset: 0x000669E8
		[NullableContext(2)]
		public UWorldPartitionStreamingSourceComponent GetTargetStreamingSourceComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWorldPartitionStreamingSourceComponent>(AWorldPartitionStreamingPortal.__GetTargetStreamingSourceComponent_Internal(base.NativePtr));
		}

		// Token: 0x06004AA3 RID: 19107 RVA: 0x000687FC File Offset: 0x000669FC
		[SkipLocalsInit]
		public unsafe TSoftObjectPtr<AActor> GetTarget()
		{
			AWorldPartitionStreamingPortal.__GetTarget_FunctionParams* ptr = stackalloc AWorldPartitionStreamingPortal.__GetTarget_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(AWorldPartitionStreamingPortal.__GetTarget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AWorldPartitionStreamingPortal.__GetTarget_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AWorldPartitionStreamingPortal.__GetTarget_NativeFunctionPtr, (void*)ptr);
			TSoftObjectPtr<AActor> result = new TSoftObjectPtr<AActor>(&ptr->__Result, false, true);
			UnrealReflectionUtils.DestroyStruct(AWorldPartitionStreamingPortal.__GetTarget_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06004AA4 RID: 19108 RVA: 0x0006885A File Offset: 0x00066A5A
		[NullableContext(2)]
		public UWorldPartitionStreamingSourceComponent GetStreamingSourceComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWorldPartitionStreamingSourceComponent>(AWorldPartitionStreamingPortal.__GetStreamingSourceComponent_Internal(base.NativePtr));
		}

		// Token: 0x06004AA5 RID: 19109
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetStreamingSourceComponent_Internal(IntPtr @this, IntPtr InComponent);

		// Token: 0x06004AA6 RID: 19110
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnStateChanged_Internal(IntPtr @this);

		// Token: 0x06004AA7 RID: 19111
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnStateChanged_Implementation_Internal(IntPtr @this);

		// Token: 0x06004AA8 RID: 19112
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStreamingAllowed_Internal(IntPtr @this);

		// Token: 0x06004AA9 RID: 19113
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStreamingAllowed_Implementation_Internal(IntPtr @this);

		// Token: 0x06004AAA RID: 19114
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTargetStreamingSourceComponent_Internal(IntPtr @this);

		// Token: 0x06004AAB RID: 19115
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetStreamingSourceComponent_Internal(IntPtr @this);

		// Token: 0x06004AAC RID: 19116 RVA: 0x0006886C File Offset: 0x00066A6C
		static AWorldPartitionStreamingPortal()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionStreamingPortal");
		}

		// Token: 0x06004AAD RID: 19117 RVA: 0x0006887A File Offset: 0x00066A7A
		protected AWorldPartitionStreamingPortal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D6E RID: 7534
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionStreamingPortal";

		// Token: 0x04001D6F RID: 7535
		private static IntPtr _ClassPtr;

		// Token: 0x04001D70 RID: 7536
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001D71 RID: 7537
		internal static int __PropertyOffset_StreamingSourceComponent;

		// Token: 0x04001D72 RID: 7538
		internal static int __PropertyOffset_Target;

		// Token: 0x04001D73 RID: 7539
		private static IntPtr __SetTarget_NativeFunctionPtr;

		// Token: 0x04001D74 RID: 7540
		private static IntPtr __GetTarget_NativeFunctionPtr;

		// Token: 0x020009F6 RID: 2550
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetTarget_FunctionParams
		{
			// Token: 0x0400599B RID: 22939
			[FieldOffset(0)]
			public byte InTarget;
		}

		// Token: 0x020009F7 RID: 2551
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsStreamingAllowed_FunctionParams
		{
			// Token: 0x0400599C RID: 22940
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020009F8 RID: 2552
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetTarget_FunctionParams
		{
			// Token: 0x0400599D RID: 22941
			[FieldOffset(0)]
			public byte __Result;
		}
	}
}
