using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001850 RID: 6224
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStopTrackTarget : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06016EE3 RID: 93923 RVA: 0x00217569 File Offset: 0x00215769
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStopTrackTarget.StaticFunctionPtr();
		}

		// Token: 0x06016EE4 RID: 93924 RVA: 0x00217575 File Offset: 0x00215775
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStopTrackTarget._FunctionPtr == IntPtr.Zero)
			{
				FOnStopTrackTarget._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroFauxPhysics.OnStopTrackTarget__DelegateSignature");
			}
			return FOnStopTrackTarget._FunctionPtr;
		}

		// Token: 0x06016EE5 RID: 93925 RVA: 0x00217598 File Offset: 0x00215798
		public FOnStopTrackTarget()
		{
		}

		// Token: 0x06016EE6 RID: 93926 RVA: 0x002175A0 File Offset: 0x002157A0
		[NullableContext(2)]
		public FOnStopTrackTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016EE7 RID: 93927 RVA: 0x002175AA File Offset: 0x002157AA
		public FOnStopTrackTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016EE8 RID: 93928 RVA: 0x002175B5 File Offset: 0x002157B5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FVector>) ?? ((Action<FVector>)Delegate.CreateDelegate(typeof(Action<FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06016EE9 RID: 93929 RVA: 0x002175E7 File Offset: 0x002157E7
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FVector> Callback)
		{
			if (FOnStopTrackTarget.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStopTrackTarget.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStopTrackTarget.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStopTrackTarget.OnScriptCallback));
				}
				FOnStopTrackTarget.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnStopTrackTarget.RegisterId);
		}

		// Token: 0x06016EEA RID: 93930 RVA: 0x00217621 File Offset: 0x00215821
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06016EEB RID: 93931 RVA: 0x0021762C File Offset: 0x0021582C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FVector CurrentLinearVelocity)
		{
			FOnStopTrackTarget.__FOnStopTrackTarget_DelegateParams* ptr = stackalloc FOnStopTrackTarget.__FOnStopTrackTarget_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FOnStopTrackTarget.__FOnStopTrackTarget_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStopTrackTarget.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->CurrentLinearVelocity = CurrentLinearVelocity;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06016EEC RID: 93932 RVA: 0x00217668 File Offset: 0x00215868
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVector> action = target as Action<FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnStopTrackTarget.__FOnStopTrackTarget_DelegateParams*)__Parameters)->CurrentLinearVelocity);
		}

		// Token: 0x0400C754 RID: 51028
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C755 RID: 51029
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroFauxPhysics.OnStopTrackTarget__DelegateSignature";

		// Token: 0x0400C756 RID: 51030
		private static int RegisterId;

		// Token: 0x02002F6E RID: 12142
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FOnStopTrackTarget_DelegateParams
		{
			// Token: 0x04016B29 RID: 92969
			[FieldOffset(0)]
			public FVector CurrentLinearVelocity;
		}

		// Token: 0x02002F6F RID: 12143
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B2A RID: 92970
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
