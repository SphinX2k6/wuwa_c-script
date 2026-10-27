using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029BB RID: 10683
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnUserScrolledEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060277D7 RID: 161751 RVA: 0x003C4488 File Offset: 0x003C2688
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnUserScrolledEvent.StaticFunctionPtr();
		}

		// Token: 0x060277D8 RID: 161752 RVA: 0x003C4494 File Offset: 0x003C2694
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnUserScrolledEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnUserScrolledEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnUserScrolledEvent__DelegateSignature");
			}
			return FOnUserScrolledEvent._FunctionPtr;
		}

		// Token: 0x060277D9 RID: 161753 RVA: 0x003C44B7 File Offset: 0x003C26B7
		public FOnUserScrolledEvent()
		{
		}

		// Token: 0x060277DA RID: 161754 RVA: 0x003C44BF File Offset: 0x003C26BF
		[NullableContext(2)]
		public FOnUserScrolledEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060277DB RID: 161755 RVA: 0x003C44C9 File Offset: 0x003C26C9
		public FOnUserScrolledEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060277DC RID: 161756 RVA: 0x003C44D4 File Offset: 0x003C26D4
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060277DD RID: 161757 RVA: 0x003C4506 File Offset: 0x003C2706
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<float> Callback)
		{
			if (FOnUserScrolledEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnUserScrolledEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnUserScrolledEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnUserScrolledEvent.OnScriptCallback));
				}
				FOnUserScrolledEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnUserScrolledEvent.RegisterId);
		}

		// Token: 0x060277DE RID: 161758 RVA: 0x003C4540 File Offset: 0x003C2740
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060277DF RID: 161759 RVA: 0x003C454C File Offset: 0x003C274C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float CurrentOffset)
		{
			FOnUserScrolledEvent.__FOnUserScrolledEvent_DelegateParams* ptr = stackalloc FOnUserScrolledEvent.__FOnUserScrolledEvent_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnUserScrolledEvent.__FOnUserScrolledEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnUserScrolledEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->CurrentOffset = CurrentOffset;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060277E0 RID: 161760 RVA: 0x003C4588 File Offset: 0x003C2788
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnUserScrolledEvent.__FOnUserScrolledEvent_DelegateParams*)__Parameters)->CurrentOffset);
		}

		// Token: 0x04015A85 RID: 88709
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A86 RID: 88710
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnUserScrolledEvent__DelegateSignature";

		// Token: 0x04015A87 RID: 88711
		private static int RegisterId;

		// Token: 0x02003BC9 RID: 15305
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FOnUserScrolledEvent_DelegateParams
		{
			// Token: 0x04017DB2 RID: 97714
			[FieldOffset(0)]
			public float CurrentOffset;
		}

		// Token: 0x02003BCA RID: 15306
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017DB3 RID: 97715
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
