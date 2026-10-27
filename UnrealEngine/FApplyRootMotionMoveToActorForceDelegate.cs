using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001325 RID: 4901
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FApplyRootMotionMoveToActorForceDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060120CE RID: 73934 RVA: 0x001A816E File Offset: 0x001A636E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FApplyRootMotionMoveToActorForceDelegate.StaticFunctionPtr();
		}

		// Token: 0x060120CF RID: 73935 RVA: 0x001A817A File Offset: 0x001A637A
		private static IntPtr StaticFunctionPtr()
		{
			if (FApplyRootMotionMoveToActorForceDelegate._FunctionPtr == IntPtr.Zero)
			{
				FApplyRootMotionMoveToActorForceDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.ApplyRootMotionMoveToActorForceDelegate__DelegateSignature");
			}
			return FApplyRootMotionMoveToActorForceDelegate._FunctionPtr;
		}

		// Token: 0x060120D0 RID: 73936 RVA: 0x001A819D File Offset: 0x001A639D
		public FApplyRootMotionMoveToActorForceDelegate()
		{
		}

		// Token: 0x060120D1 RID: 73937 RVA: 0x001A81A5 File Offset: 0x001A63A5
		[NullableContext(2)]
		public FApplyRootMotionMoveToActorForceDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060120D2 RID: 73938 RVA: 0x001A81AF File Offset: 0x001A63AF
		public FApplyRootMotionMoveToActorForceDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060120D3 RID: 73939 RVA: 0x001A81BA File Offset: 0x001A63BA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, bool, FVector>) ?? ((Action<bool, bool, FVector>)Delegate.CreateDelegate(typeof(Action<bool, bool, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060120D4 RID: 73940 RVA: 0x001A81EC File Offset: 0x001A63EC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool, bool, FVector> Callback)
		{
			if (FApplyRootMotionMoveToActorForceDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FApplyRootMotionMoveToActorForceDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FApplyRootMotionMoveToActorForceDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FApplyRootMotionMoveToActorForceDelegate.OnScriptCallback));
				}
				FApplyRootMotionMoveToActorForceDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FApplyRootMotionMoveToActorForceDelegate.RegisterId);
		}

		// Token: 0x060120D5 RID: 73941 RVA: 0x001A8226 File Offset: 0x001A6426
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool, bool, FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060120D6 RID: 73942 RVA: 0x001A8230 File Offset: 0x001A6430
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool DestinationReached, bool TimedOut, FVector FinalTargetLocation)
		{
			FApplyRootMotionMoveToActorForceDelegate.__FApplyRootMotionMoveToActorForceDelegate_DelegateParams* ptr = stackalloc FApplyRootMotionMoveToActorForceDelegate.__FApplyRootMotionMoveToActorForceDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FApplyRootMotionMoveToActorForceDelegate.__FApplyRootMotionMoveToActorForceDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FApplyRootMotionMoveToActorForceDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DestinationReached = DestinationReached;
			ptr->TimedOut = TimedOut;
			ptr->FinalTargetLocation = FinalTargetLocation;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060120D7 RID: 73943 RVA: 0x001A827C File Offset: 0x001A647C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, bool, FVector> action = target as Action<bool, bool, FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FApplyRootMotionMoveToActorForceDelegate.__FApplyRootMotionMoveToActorForceDelegate_DelegateParams*)__Parameters)->DestinationReached, ((FApplyRootMotionMoveToActorForceDelegate.__FApplyRootMotionMoveToActorForceDelegate_DelegateParams*)__Parameters)->TimedOut, ((FApplyRootMotionMoveToActorForceDelegate.__FApplyRootMotionMoveToActorForceDelegate_DelegateParams*)__Parameters)->FinalTargetLocation);
		}

		// Token: 0x04009A3B RID: 39483
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009A3C RID: 39484
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.ApplyRootMotionMoveToActorForceDelegate__DelegateSignature";

		// Token: 0x04009A3D RID: 39485
		private static int RegisterId;

		// Token: 0x02002E26 RID: 11814
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FApplyRootMotionMoveToActorForceDelegate_DelegateParams
		{
			// Token: 0x040168BB RID: 92347
			[FieldOffset(0)]
			public bool DestinationReached;

			// Token: 0x040168BC RID: 92348
			[FieldOffset(1)]
			public bool TimedOut;

			// Token: 0x040168BD RID: 92349
			[FieldOffset(4)]
			public FVector FinalTargetLocation;
		}

		// Token: 0x02002E27 RID: 11815
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040168BE RID: 92350
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
