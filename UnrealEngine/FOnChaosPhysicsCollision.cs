using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000456 RID: 1110
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnChaosPhysicsCollision : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06003BDC RID: 15324 RVA: 0x0005A365 File Offset: 0x00058565
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnChaosPhysicsCollision.StaticFunctionPtr();
		}

		// Token: 0x06003BDD RID: 15325 RVA: 0x0005A371 File Offset: 0x00058571
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnChaosPhysicsCollision._FunctionPtr == IntPtr.Zero)
			{
				FOnChaosPhysicsCollision._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/ChaosSolverEngine.OnChaosPhysicsCollision__DelegateSignature");
			}
			return FOnChaosPhysicsCollision._FunctionPtr;
		}

		// Token: 0x06003BDE RID: 15326 RVA: 0x0005A394 File Offset: 0x00058594
		public FOnChaosPhysicsCollision()
		{
		}

		// Token: 0x06003BDF RID: 15327 RVA: 0x0005A39C File Offset: 0x0005859C
		[NullableContext(2)]
		public FOnChaosPhysicsCollision(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003BE0 RID: 15328 RVA: 0x0005A3A6 File Offset: 0x000585A6
		public FOnChaosPhysicsCollision(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003BE1 RID: 15329 RVA: 0x0005A3B1 File Offset: 0x000585B1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FChaosPhysicsCollisionInfo>) ?? ((Action<FChaosPhysicsCollisionInfo>)Delegate.CreateDelegate(typeof(Action<FChaosPhysicsCollisionInfo>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x0005A3E3 File Offset: 0x000585E3
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FChaosPhysicsCollisionInfo> Callback)
		{
			if (FOnChaosPhysicsCollision.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnChaosPhysicsCollision.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnChaosPhysicsCollision.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnChaosPhysicsCollision.OnScriptCallback));
				}
				FOnChaosPhysicsCollision.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnChaosPhysicsCollision.RegisterId);
		}

		// Token: 0x06003BE3 RID: 15331 RVA: 0x0005A41D File Offset: 0x0005861D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FChaosPhysicsCollisionInfo> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06003BE4 RID: 15332 RVA: 0x0005A428 File Offset: 0x00058628
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FChaosPhysicsCollisionInfo CollisionInfo)
		{
			FOnChaosPhysicsCollision.__FOnChaosPhysicsCollision_DelegateParams* ptr = stackalloc FOnChaosPhysicsCollision.__FOnChaosPhysicsCollision_DelegateParams[(UIntPtr)127] + 15L / (long)sizeof(FOnChaosPhysicsCollision.__FOnChaosPhysicsCollision_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnChaosPhysicsCollision.StaticFunctionPtr(), (void*)ptr, 1);
			if (CollisionInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FChaosPhysicsCollisionInfo.StaticStruct(), &ptr->CollisionInfo, CollisionInfo.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06003BE5 RID: 15333 RVA: 0x0005A484 File Offset: 0x00058684
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FChaosPhysicsCollisionInfo> action = target as Action<FChaosPhysicsCollisionInfo>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FChaosPhysicsCollisionInfo obj = new FChaosPhysicsCollisionInfo(&((FOnChaosPhysicsCollision.__FOnChaosPhysicsCollision_DelegateParams*)__Parameters)->CollisionInfo, true, true);
			action(obj);
		}

		// Token: 0x04001B9D RID: 7069
		internal static IntPtr _FunctionPtr;

		// Token: 0x04001B9E RID: 7070
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ChaosSolverEngine.OnChaosPhysicsCollision__DelegateSignature";

		// Token: 0x04001B9F RID: 7071
		private static int RegisterId;

		// Token: 0x02002C39 RID: 11321
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __FOnChaosPhysicsCollision_DelegateParams
		{
			// Token: 0x04016542 RID: 91458
			[FieldOffset(0)]
			public byte CollisionInfo;
		}

		// Token: 0x02002C3A RID: 11322
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016543 RID: 91459
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
