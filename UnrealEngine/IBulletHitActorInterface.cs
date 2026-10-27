using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001875 RID: 6261
	[UnrealObjectPath("/Script/KuroGameplayInterface.BulletHitActorInterface")]
	public interface IBulletHitActorInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060170E9 RID: 94441
		int InterfaceOffset();

		// Token: 0x060170EA RID: 94442 RVA: 0x0021990C File Offset: 0x00217B0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void OnBulletHit(int BulletEntityId, in FVectorDouble HitPoint)
		{
			IBulletHitActorInterface.__OnBulletHit_FunctionParams* ptr = stackalloc IBulletHitActorInterface.__OnBulletHit_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(IBulletHitActorInterface.__OnBulletHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBulletHitActorInterface_ReflectionImplementationFields.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletEntityId = BulletEntityId;
			ptr->HitPoint = HitPoint;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBulletHitActorInterface_ReflectionImplementationFields.__OnBulletHit_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060170EB RID: 94443 RVA: 0x00219960 File Offset: 0x00217B60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void OnBulletHit_Implementation(int BulletEntityId, in FVectorDouble HitPoint)
		{
			IBulletHitActorInterface.__OnBulletHit_FunctionParams* ptr = stackalloc IBulletHitActorInterface.__OnBulletHit_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(IBulletHitActorInterface.__OnBulletHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBulletHitActorInterface_ReflectionImplementationFields.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletEntityId = BulletEntityId;
			ptr->HitPoint = HitPoint;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IBulletHitActorInterface_ReflectionImplementationFields.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0400C82C RID: 51244
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplayInterface.BulletHitActorInterface";

		// Token: 0x02002F7D RID: 12157
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnBulletHit_FunctionParams
		{
			// Token: 0x04016B3A RID: 92986
			[FieldOffset(0)]
			public int BulletEntityId;

			// Token: 0x04016B3B RID: 92987
			[FieldOffset(8)]
			public FVectorDouble HitPoint;
		}
	}
}
