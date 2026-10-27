using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001987 RID: 6535
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroCheckProgress : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601845D RID: 99421 RVA: 0x0023CDE7 File Offset: 0x0023AFE7
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroCheckProgress.StaticFunctionPtr();
		}

		// Token: 0x0601845E RID: 99422 RVA: 0x0023CDF3 File Offset: 0x0023AFF3
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroCheckProgress._FunctionPtr == IntPtr.Zero)
			{
				FKuroCheckProgress._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroHotPatch.KuroCheckProgress__DelegateSignature");
			}
			return FKuroCheckProgress._FunctionPtr;
		}

		// Token: 0x0601845F RID: 99423 RVA: 0x0023CE16 File Offset: 0x0023B016
		public FKuroCheckProgress()
		{
		}

		// Token: 0x06018460 RID: 99424 RVA: 0x0023CE1E File Offset: 0x0023B01E
		[NullableContext(2)]
		public FKuroCheckProgress(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018461 RID: 99425 RVA: 0x0023CE28 File Offset: 0x0023B028
		public FKuroCheckProgress(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018462 RID: 99426 RVA: 0x0023CE33 File Offset: 0x0023B033
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018463 RID: 99427 RVA: 0x0023CE65 File Offset: 0x0023B065
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, int> Callback)
		{
			if (FKuroCheckProgress.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroCheckProgress.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroCheckProgress.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroCheckProgress.OnScriptCallback));
				}
				FKuroCheckProgress.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroCheckProgress.RegisterId);
		}

		// Token: 0x06018464 RID: 99428 RVA: 0x0023CE9F File Offset: 0x0023B09F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06018465 RID: 99429 RVA: 0x0023CEA8 File Offset: 0x0023B0A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int Current, int Total)
		{
			FKuroCheckProgress.__FKuroCheckProgress_DelegateParams* ptr = stackalloc FKuroCheckProgress.__FKuroCheckProgress_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FKuroCheckProgress.__FKuroCheckProgress_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroCheckProgress.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Current = Current;
			ptr->Total = Total;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06018466 RID: 99430 RVA: 0x0023CEEC File Offset: 0x0023B0EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroCheckProgress.__FKuroCheckProgress_DelegateParams*)__Parameters)->Current, ((FKuroCheckProgress.__FKuroCheckProgress_DelegateParams*)__Parameters)->Total);
		}

		// Token: 0x0400D24E RID: 53838
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D24F RID: 53839
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroHotPatch.KuroCheckProgress__DelegateSignature";

		// Token: 0x0400D250 RID: 53840
		private static int RegisterId;

		// Token: 0x0200307E RID: 12414
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FKuroCheckProgress_DelegateParams
		{
			// Token: 0x04016D59 RID: 93529
			[FieldOffset(0)]
			public int Current;

			// Token: 0x04016D5A RID: 93530
			[FieldOffset(4)]
			public int Total;
		}

		// Token: 0x0200307F RID: 12415
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D5B RID: 93531
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
