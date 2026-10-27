using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000DD RID: 221
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FActorPerceptionInfoUpdatedDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060011AA RID: 4522 RVA: 0x0001A55B File Offset: 0x0001875B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorPerceptionInfoUpdatedDelegate.StaticFunctionPtr();
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0001A567 File Offset: 0x00018767
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorPerceptionInfoUpdatedDelegate._FunctionPtr == IntPtr.Zero)
			{
				FActorPerceptionInfoUpdatedDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AIModule.ActorPerceptionInfoUpdatedDelegate__DelegateSignature");
			}
			return FActorPerceptionInfoUpdatedDelegate._FunctionPtr;
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0001A58A File Offset: 0x0001878A
		public FActorPerceptionInfoUpdatedDelegate()
		{
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x0001A592 File Offset: 0x00018792
		[NullableContext(2)]
		public FActorPerceptionInfoUpdatedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x0001A59C File Offset: 0x0001879C
		public FActorPerceptionInfoUpdatedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x0001A5A7 File Offset: 0x000187A7
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FActorPerceptionUpdateInfo>) ?? ((Action<FActorPerceptionUpdateInfo>)Delegate.CreateDelegate(typeof(Action<FActorPerceptionUpdateInfo>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0001A5D9 File Offset: 0x000187D9
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FActorPerceptionUpdateInfo> Callback)
		{
			if (FActorPerceptionInfoUpdatedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorPerceptionInfoUpdatedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorPerceptionInfoUpdatedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorPerceptionInfoUpdatedDelegate.OnScriptCallback));
				}
				FActorPerceptionInfoUpdatedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FActorPerceptionInfoUpdatedDelegate.RegisterId);
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x0001A613 File Offset: 0x00018813
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FActorPerceptionUpdateInfo> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0001A61C File Offset: 0x0001881C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FActorPerceptionUpdateInfo UpdateInfo)
		{
			FActorPerceptionInfoUpdatedDelegate.__FActorPerceptionInfoUpdatedDelegate_DelegateParams* ptr = stackalloc FActorPerceptionInfoUpdatedDelegate.__FActorPerceptionInfoUpdatedDelegate_DelegateParams[(UIntPtr)95] + 15L / (long)sizeof(FActorPerceptionInfoUpdatedDelegate.__FActorPerceptionInfoUpdatedDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorPerceptionInfoUpdatedDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			if (UpdateInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FActorPerceptionUpdateInfo.StaticStruct(), &ptr->UpdateInfo, UpdateInfo.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x0001A678 File Offset: 0x00018878
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FActorPerceptionUpdateInfo> action = target as Action<FActorPerceptionUpdateInfo>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FActorPerceptionUpdateInfo obj = new FActorPerceptionUpdateInfo(&((FActorPerceptionInfoUpdatedDelegate.__FActorPerceptionInfoUpdatedDelegate_DelegateParams*)__Parameters)->UpdateInfo, true, true);
			action(obj);
		}

		// Token: 0x040002E4 RID: 740
		internal static IntPtr _FunctionPtr;

		// Token: 0x040002E5 RID: 741
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.ActorPerceptionInfoUpdatedDelegate__DelegateSignature";

		// Token: 0x040002E6 RID: 742
		private static int RegisterId;

		// Token: 0x02002B3B RID: 11067
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __FActorPerceptionInfoUpdatedDelegate_DelegateParams
		{
			// Token: 0x04016398 RID: 91032
			[FieldOffset(0)]
			public byte UpdateInfo;
		}

		// Token: 0x02002B3C RID: 11068
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016399 RID: 91033
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
