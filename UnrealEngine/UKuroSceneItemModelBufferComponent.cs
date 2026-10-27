using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001763 RID: 5987
	[UnrealObjectPath("/Script/KuroComponent.KuroSceneItemModelBufferComponent")]
	[UnrealStructLayout(544, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 544)]
	public class UKuroSceneItemModelBufferComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601584A RID: 88138 RVA: 0x001F9F04 File Offset: 0x001F8104
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSceneItemModelBufferComponent._ClassPtr;
		}

		// Token: 0x0601584B RID: 88139 RVA: 0x001F9F10 File Offset: 0x001F8110
		public UKuroSceneItemModelBufferComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroSceneItemModelBufferComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601584C RID: 88140 RVA: 0x001F9F38 File Offset: 0x001F8138
		[NullableContext(1)]
		public UKuroSceneItemModelBufferComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSceneItemModelBufferComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170054F8 RID: 21752
		// (get) Token: 0x0601584D RID: 88141 RVA: 0x001F9F6B File Offset: 0x001F816B
		// (set) Token: 0x0601584E RID: 88142 RVA: 0x001F9F7B File Offset: 0x001F817B
		public unsafe float BufferTimeLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneItemModelBufferComponent.__PropertyOffset_BufferTimeLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneItemModelBufferComponent.__PropertyOffset_BufferTimeLength) = value;
			}
		}

		// Token: 0x170054F9 RID: 21753
		// (get) Token: 0x0601584F RID: 88143 RVA: 0x001F9F8C File Offset: 0x001F818C
		// (set) Token: 0x06015850 RID: 88144 RVA: 0x001F9F9C File Offset: 0x001F819C
		public unsafe float BufferNowTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneItemModelBufferComponent.__PropertyOffset_BufferNowTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneItemModelBufferComponent.__PropertyOffset_BufferNowTime) = value;
			}
		}

		// Token: 0x06015851 RID: 88145 RVA: 0x001F9FAD File Offset: 0x001F81AD
		public void StopModelBuffer()
		{
			UKuroSceneItemModelBufferComponent.__StopModelBuffer_Internal(base.NativePtr);
		}

		// Token: 0x06015852 RID: 88146 RVA: 0x001F9FBA File Offset: 0x001F81BA
		[NullableContext(2)]
		public void SetUpMeshComponent(USkeletalMeshComponent InMeshComponent)
		{
			UKuroSceneItemModelBufferComponent.__SetUpMeshComponent_Internal(base.NativePtr, (InMeshComponent != null) ? InMeshComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06015853 RID: 88147 RVA: 0x001F9FD7 File Offset: 0x001F81D7
		[NullableContext(2)]
		public bool SetActorTransformExceptSkeletalMesh(in FVectorDouble NewLocation, in FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport, bool bIgnoreOverlap)
		{
			return UKuroSceneItemModelBufferComponent.__SetActorTransformExceptSkeletalMesh_Internal(base.NativePtr, NewLocation, NewRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport, bIgnoreOverlap);
		}

		// Token: 0x06015854 RID: 88148 RVA: 0x001F9FFC File Offset: 0x001F81FC
		public void ResetModelQuat()
		{
			UKuroSceneItemModelBufferComponent.__ResetModelQuat_Internal(base.NativePtr);
		}

		// Token: 0x06015855 RID: 88149 RVA: 0x001FA009 File Offset: 0x001F8209
		public void ResetModelLocation()
		{
			UKuroSceneItemModelBufferComponent.__ResetModelLocation_Internal(base.NativePtr);
		}

		// Token: 0x06015856 RID: 88150 RVA: 0x001FA018 File Offset: 0x001F8218
		public unsafe void GetTransformOffsetInWorld(FTransform Child, FTransform Parent)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Child;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = Parent;
			UKuroSceneItemModelBufferComponent.__GetTransformOffsetInWorld_Internal(base.NativePtr, ptr, ptr2);
		}

		// Token: 0x06015857 RID: 88151 RVA: 0x001FA060 File Offset: 0x001F8260
		public unsafe void D_GetTransformOffsetInWorld(FTransformDouble Child, FTransformDouble Parent, ref FTransformDouble Out)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = Child;
			ref FTransformDouble ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr2 = Parent;
			ref FTransformDouble ptr3 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr3 = Out;
			UKuroSceneItemModelBufferComponent.__D_GetTransformOffsetInWorld_Internal(base.NativePtr, ptr, ptr2, ref ptr3);
			Out = ptr3;
		}

		// Token: 0x06015858 RID: 88152 RVA: 0x001FA0D4 File Offset: 0x001F82D4
		public unsafe void AddModelQuat(FQuat Quat, bool LockCenter)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = Quat;
			UKuroSceneItemModelBufferComponent.__AddModelQuat_Internal(base.NativePtr, ptr, LockCenter);
		}

		// Token: 0x06015859 RID: 88153 RVA: 0x001FA105 File Offset: 0x001F8305
		public void AddModelLocation(FVector Offset)
		{
			UKuroSceneItemModelBufferComponent.__AddModelLocation_Internal(base.NativePtr, Offset);
		}

		// Token: 0x0601585A RID: 88154
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopModelBuffer_Internal(IntPtr @this);

		// Token: 0x0601585B RID: 88155
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUpMeshComponent_Internal(IntPtr @this, IntPtr InMeshComponent);

		// Token: 0x0601585C RID: 88156
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetActorTransformExceptSkeletalMesh_Internal(IntPtr @this, in FVectorDouble NewLocation, in FRotator NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport, bool bIgnoreOverlap);

		// Token: 0x0601585D RID: 88157
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetModelQuat_Internal(IntPtr @this);

		// Token: 0x0601585E RID: 88158
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetModelLocation_Internal(IntPtr @this);

		// Token: 0x0601585F RID: 88159
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetTransformOffsetInWorld_Internal(IntPtr @this, in FTransform Child, in FTransform Parent);

		// Token: 0x06015860 RID: 88160
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_GetTransformOffsetInWorld_Internal(IntPtr @this, in FTransformDouble Child, in FTransformDouble Parent, ref FTransformDouble Out);

		// Token: 0x06015861 RID: 88161
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddModelQuat_Internal(IntPtr @this, in FQuat Quat, bool LockCenter);

		// Token: 0x06015862 RID: 88162
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddModelLocation_Internal(IntPtr @this, FVector Offset);

		// Token: 0x06015863 RID: 88163 RVA: 0x001FA113 File Offset: 0x001F8313
		static UKuroSceneItemModelBufferComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroSceneItemModelBufferComponent");
		}

		// Token: 0x06015864 RID: 88164 RVA: 0x001FA121 File Offset: 0x001F8321
		protected UKuroSceneItemModelBufferComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BBD8 RID: 48088
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComponent.KuroSceneItemModelBufferComponent";

		// Token: 0x0400BBD9 RID: 48089
		private static IntPtr _ClassPtr;

		// Token: 0x0400BBDA RID: 48090
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BBDB RID: 48091
		internal static int __PropertyOffset_BufferTimeLength;

		// Token: 0x0400BBDC RID: 48092
		internal static int __PropertyOffset_BufferNowTime;
	}
}
