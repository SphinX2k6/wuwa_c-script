using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200034C RID: 844
	[UnrealObjectPath("/Script/KuroComponent.KuroSceneItemModelBufferComponent")]
	[UnrealStructLayout(544, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 544)]
	public class UKuroSceneItemModelBufferComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005660 RID: 22112 RVA: 0x00079193 File Offset: 0x00077393
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSceneItemModelBufferComponent._ClassPtr;
		}

		// Token: 0x06005661 RID: 22113 RVA: 0x000791A0 File Offset: 0x000773A0
		public UKuroSceneItemModelBufferComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroSceneItemModelBufferComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005662 RID: 22114 RVA: 0x000791C8 File Offset: 0x000773C8
		[NullableContext(1)]
		public UKuroSceneItemModelBufferComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSceneItemModelBufferComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x06005663 RID: 22115 RVA: 0x000791FB File Offset: 0x000773FB
		// (set) Token: 0x06005664 RID: 22116 RVA: 0x0007920B File Offset: 0x0007740B
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

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x06005665 RID: 22117 RVA: 0x0007921C File Offset: 0x0007741C
		// (set) Token: 0x06005666 RID: 22118 RVA: 0x0007922C File Offset: 0x0007742C
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

		// Token: 0x06005667 RID: 22119 RVA: 0x0007923D File Offset: 0x0007743D
		public void StopModelBuffer()
		{
			UKuroSceneItemModelBufferComponent.__StopModelBuffer_Internal(base.NativePtr);
		}

		// Token: 0x06005668 RID: 22120 RVA: 0x0007924A File Offset: 0x0007744A
		[NullableContext(2)]
		public void SetUpMeshComponent(USkeletalMeshComponent InMeshComponent)
		{
			UKuroSceneItemModelBufferComponent.__SetUpMeshComponent_Internal(base.NativePtr, (InMeshComponent != null) ? InMeshComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005669 RID: 22121 RVA: 0x00079267 File Offset: 0x00077467
		[NullableContext(2)]
		public bool SetActorTransformExceptSkeletalMesh(in FVectorDouble NewLocation, in FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport, bool bIgnoreOverlap)
		{
			return UKuroSceneItemModelBufferComponent.__SetActorTransformExceptSkeletalMesh_Internal(base.NativePtr, NewLocation, NewRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport, bIgnoreOverlap);
		}

		// Token: 0x0600566A RID: 22122 RVA: 0x0007928C File Offset: 0x0007748C
		public void ResetModelQuat()
		{
			UKuroSceneItemModelBufferComponent.__ResetModelQuat_Internal(base.NativePtr);
		}

		// Token: 0x0600566B RID: 22123 RVA: 0x00079299 File Offset: 0x00077499
		public void ResetModelLocation()
		{
			UKuroSceneItemModelBufferComponent.__ResetModelLocation_Internal(base.NativePtr);
		}

		// Token: 0x0600566C RID: 22124 RVA: 0x000792A8 File Offset: 0x000774A8
		public unsafe void GetTransformOffsetInWorld(FTransform Child, FTransform Parent)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Child;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = Parent;
			UKuroSceneItemModelBufferComponent.__GetTransformOffsetInWorld_Internal(base.NativePtr, ptr, ptr2);
		}

		// Token: 0x0600566D RID: 22125 RVA: 0x000792F0 File Offset: 0x000774F0
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

		// Token: 0x0600566E RID: 22126 RVA: 0x00079364 File Offset: 0x00077564
		public unsafe void AddModelQuat(FQuat Quat, bool LockCenter)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = Quat;
			UKuroSceneItemModelBufferComponent.__AddModelQuat_Internal(base.NativePtr, ptr, LockCenter);
		}

		// Token: 0x0600566F RID: 22127 RVA: 0x00079395 File Offset: 0x00077595
		public void AddModelLocation(FVector Offset)
		{
			UKuroSceneItemModelBufferComponent.__AddModelLocation_Internal(base.NativePtr, Offset);
		}

		// Token: 0x06005670 RID: 22128
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopModelBuffer_Internal(IntPtr @this);

		// Token: 0x06005671 RID: 22129
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUpMeshComponent_Internal(IntPtr @this, IntPtr InMeshComponent);

		// Token: 0x06005672 RID: 22130
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetActorTransformExceptSkeletalMesh_Internal(IntPtr @this, in FVectorDouble NewLocation, in FRotator NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport, bool bIgnoreOverlap);

		// Token: 0x06005673 RID: 22131
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetModelQuat_Internal(IntPtr @this);

		// Token: 0x06005674 RID: 22132
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetModelLocation_Internal(IntPtr @this);

		// Token: 0x06005675 RID: 22133
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetTransformOffsetInWorld_Internal(IntPtr @this, in FTransform Child, in FTransform Parent);

		// Token: 0x06005676 RID: 22134
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_GetTransformOffsetInWorld_Internal(IntPtr @this, in FTransformDouble Child, in FTransformDouble Parent, ref FTransformDouble Out);

		// Token: 0x06005677 RID: 22135
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddModelQuat_Internal(IntPtr @this, in FQuat Quat, bool LockCenter);

		// Token: 0x06005678 RID: 22136
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddModelLocation_Internal(IntPtr @this, FVector Offset);

		// Token: 0x06005679 RID: 22137 RVA: 0x000793A3 File Offset: 0x000775A3
		static UKuroSceneItemModelBufferComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroSceneItemModelBufferComponent");
		}

		// Token: 0x0600567A RID: 22138 RVA: 0x000793B1 File Offset: 0x000775B1
		protected UKuroSceneItemModelBufferComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002372 RID: 9074
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComponent.KuroSceneItemModelBufferComponent";

		// Token: 0x04002373 RID: 9075
		private static IntPtr _ClassPtr;

		// Token: 0x04002374 RID: 9076
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002375 RID: 9077
		internal static int __PropertyOffset_BufferTimeLength;

		// Token: 0x04002376 RID: 9078
		internal static int __PropertyOffset_BufferNowTime;
	}
}
