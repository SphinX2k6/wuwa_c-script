using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006D5 RID: 1749
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnToggleStateChange : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060094DC RID: 38108 RVA: 0x000E09B1 File Offset: 0x000DEBB1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnToggleStateChange.StaticFunctionPtr();
		}

		// Token: 0x060094DD RID: 38109 RVA: 0x000E09BD File Offset: 0x000DEBBD
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnToggleStateChange._FunctionPtr == IntPtr.Zero)
			{
				FOnToggleStateChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.OnToggleStateChange__DelegateSignature");
			}
			return FOnToggleStateChange._FunctionPtr;
		}

		// Token: 0x060094DE RID: 38110 RVA: 0x000E09E0 File Offset: 0x000DEBE0
		public FOnToggleStateChange()
		{
		}

		// Token: 0x060094DF RID: 38111 RVA: 0x000E09E8 File Offset: 0x000DEBE8
		[NullableContext(2)]
		public FOnToggleStateChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060094E0 RID: 38112 RVA: 0x000E09F2 File Offset: 0x000DEBF2
		public FOnToggleStateChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060094E1 RID: 38113 RVA: 0x000E09FD File Offset: 0x000DEBFD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<EToggleState>) ?? ((Action<EToggleState>)Delegate.CreateDelegate(typeof(Action<EToggleState>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060094E2 RID: 38114 RVA: 0x000E0A2F File Offset: 0x000DEC2F
		[NullableContext(1)]
		public void Add(Action<EToggleState> Callback)
		{
			if (FOnToggleStateChange.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnToggleStateChange.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnToggleStateChange.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnToggleStateChange.OnScriptCallback));
				}
				FOnToggleStateChange.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnToggleStateChange.RegisterId);
		}

		// Token: 0x060094E3 RID: 38115 RVA: 0x000E0A69 File Offset: 0x000DEC69
		[NullableContext(1)]
		public void Remove(Action<EToggleState> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060094E4 RID: 38116 RVA: 0x000E0A74 File Offset: 0x000DEC74
		[SkipLocalsInit]
		public unsafe void Broadcast(EToggleState State)
		{
			FOnToggleStateChange.__FOnToggleStateChange_DelegateParams* ptr = stackalloc FOnToggleStateChange.__FOnToggleStateChange_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnToggleStateChange.__FOnToggleStateChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnToggleStateChange.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->State = State;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060094E5 RID: 38117 RVA: 0x000E0AB0 File Offset: 0x000DECB0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EToggleState> action = target as Action<EToggleState>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnToggleStateChange.__FOnToggleStateChange_DelegateParams*)__Parameters)->State);
		}

		// Token: 0x040040BD RID: 16573
		internal static IntPtr _FunctionPtr;

		// Token: 0x040040BE RID: 16574
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.OnToggleStateChange__DelegateSignature";

		// Token: 0x040040BF RID: 16575
		private static int RegisterId;

		// Token: 0x02000F09 RID: 3849
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FOnToggleStateChange_DelegateParams
		{
			// Token: 0x040062D6 RID: 25302
			[FieldOffset(0)]
			public EToggleState State;
		}

		// Token: 0x02000F0A RID: 3850
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062D7 RID: 25303
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
