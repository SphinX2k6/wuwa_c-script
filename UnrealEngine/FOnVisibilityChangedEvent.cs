using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029BC RID: 10684
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnVisibilityChangedEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060277E1 RID: 161761 RVA: 0x003C45D2 File Offset: 0x003C27D2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnVisibilityChangedEvent.StaticFunctionPtr();
		}

		// Token: 0x060277E2 RID: 161762 RVA: 0x003C45DE File Offset: 0x003C27DE
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnVisibilityChangedEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnVisibilityChangedEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnVisibilityChangedEvent__DelegateSignature");
			}
			return FOnVisibilityChangedEvent._FunctionPtr;
		}

		// Token: 0x060277E3 RID: 161763 RVA: 0x003C4601 File Offset: 0x003C2801
		public FOnVisibilityChangedEvent()
		{
		}

		// Token: 0x060277E4 RID: 161764 RVA: 0x003C4609 File Offset: 0x003C2809
		[NullableContext(2)]
		public FOnVisibilityChangedEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060277E5 RID: 161765 RVA: 0x003C4613 File Offset: 0x003C2813
		public FOnVisibilityChangedEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060277E6 RID: 161766 RVA: 0x003C461E File Offset: 0x003C281E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<ESlateVisibility>) ?? ((Action<ESlateVisibility>)Delegate.CreateDelegate(typeof(Action<ESlateVisibility>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060277E7 RID: 161767 RVA: 0x003C4650 File Offset: 0x003C2850
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<ESlateVisibility> Callback)
		{
			if (FOnVisibilityChangedEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnVisibilityChangedEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnVisibilityChangedEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnVisibilityChangedEvent.OnScriptCallback));
				}
				FOnVisibilityChangedEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnVisibilityChangedEvent.RegisterId);
		}

		// Token: 0x060277E8 RID: 161768 RVA: 0x003C468A File Offset: 0x003C288A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<ESlateVisibility> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060277E9 RID: 161769 RVA: 0x003C4694 File Offset: 0x003C2894
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(ESlateVisibility InVisibility)
		{
			FOnVisibilityChangedEvent.__FOnVisibilityChangedEvent_DelegateParams* ptr = stackalloc FOnVisibilityChangedEvent.__FOnVisibilityChangedEvent_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnVisibilityChangedEvent.__FOnVisibilityChangedEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnVisibilityChangedEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InVisibility = InVisibility;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060277EA RID: 161770 RVA: 0x003C46D0 File Offset: 0x003C28D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<ESlateVisibility> action = target as Action<ESlateVisibility>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnVisibilityChangedEvent.__FOnVisibilityChangedEvent_DelegateParams*)__Parameters)->InVisibility);
		}

		// Token: 0x04015A88 RID: 88712
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A89 RID: 88713
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnVisibilityChangedEvent__DelegateSignature";

		// Token: 0x04015A8A RID: 88714
		private static int RegisterId;

		// Token: 0x02003BCB RID: 15307
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnVisibilityChangedEvent_DelegateParams
		{
			// Token: 0x04017DB4 RID: 97716
			[FieldOffset(0)]
			public ESlateVisibility InVisibility;
		}

		// Token: 0x02003BCC RID: 15308
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017DB5 RID: 97717
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
