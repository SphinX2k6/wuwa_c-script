using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003A1 RID: 929
	[UnrealObjectPath("/Script/KuroGameplayInterface.BulletHitActorInterface")]
	public interface IBulletHitActorInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06005BFE RID: 23550
		int InterfaceOffset();

		// Token: 0x06005BFF RID: 23551 RVA: 0x00081934 File Offset: 0x0007FB34
		[SkipLocalsInit]
		unsafe void OnBulletHit(int BulletEntityId, in FVectorDouble HitPoint)
		{
			IBulletHitActorInterface.__OnBulletHit_FunctionParams* ptr = stackalloc IBulletHitActorInterface.__OnBulletHit_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(IBulletHitActorInterface.__OnBulletHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBulletHitActorInterface_ReflectionImplementationFields.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletEntityId = BulletEntityId;
			ptr->HitPoint = HitPoint;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBulletHitActorInterface_ReflectionImplementationFields.__OnBulletHit_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06005C00 RID: 23552 RVA: 0x00081988 File Offset: 0x0007FB88
		[SkipLocalsInit]
		unsafe void OnBulletHit_Implementation(int BulletEntityId, in FVectorDouble HitPoint)
		{
			IBulletHitActorInterface.__OnBulletHit_FunctionParams* ptr = stackalloc IBulletHitActorInterface.__OnBulletHit_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(IBulletHitActorInterface.__OnBulletHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBulletHitActorInterface_ReflectionImplementationFields.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletEntityId = BulletEntityId;
			ptr->HitPoint = HitPoint;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IBulletHitActorInterface_ReflectionImplementationFields.__OnBulletHit_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x04002649 RID: 9801
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplayInterface.BulletHitActorInterface";

		// Token: 0x02000AA3 RID: 2723
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnBulletHit_FunctionParams
		{
			// Token: 0x04005AFA RID: 23290
			[FieldOffset(0)]
			public int BulletEntityId;

			// Token: 0x04005AFB RID: 23291
			[FieldOffset(8)]
			public FVectorDouble HitPoint;
		}
	}
}
