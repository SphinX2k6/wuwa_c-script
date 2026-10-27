using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EE2 RID: 7906
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnBooleanEventTrigger : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E0F8 RID: 123128 RVA: 0x002C9D9E File Offset: 0x002C7F9E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnBooleanEventTrigger.StaticFunctionPtr();
		}

		// Token: 0x0601E0F9 RID: 123129 RVA: 0x002C9DAA File Offset: 0x002C7FAA
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnBooleanEventTrigger._FunctionPtr == IntPtr.Zero)
			{
				FOnBooleanEventTrigger._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnBooleanEventTrigger__DelegateSignature");
			}
			return FOnBooleanEventTrigger._FunctionPtr;
		}

		// Token: 0x0601E0FA RID: 123130 RVA: 0x002C9DCD File Offset: 0x002C7FCD
		public FOnBooleanEventTrigger()
		{
		}

		// Token: 0x0601E0FB RID: 123131 RVA: 0x002C9DD5 File Offset: 0x002C7FD5
		[NullableContext(2)]
		public FOnBooleanEventTrigger(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E0FC RID: 123132 RVA: 0x002C9DDF File Offset: 0x002C7FDF
		public FOnBooleanEventTrigger(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E0FD RID: 123133 RVA: 0x002C9DEA File Offset: 0x002C7FEA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E0FE RID: 123134 RVA: 0x002C9E1C File Offset: 0x002C801C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool> Callback)
		{
			if (FOnBooleanEventTrigger.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnBooleanEventTrigger.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnBooleanEventTrigger.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnBooleanEventTrigger.OnScriptCallback));
				}
				FOnBooleanEventTrigger.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnBooleanEventTrigger.RegisterId);
		}

		// Token: 0x0601E0FF RID: 123135 RVA: 0x002C9E56 File Offset: 0x002C8056
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601E100 RID: 123136 RVA: 0x002C9E60 File Offset: 0x002C8060
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool bContent)
		{
			FOnBooleanEventTrigger.__FOnBooleanEventTrigger_DelegateParams* ptr = stackalloc FOnBooleanEventTrigger.__FOnBooleanEventTrigger_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnBooleanEventTrigger.__FOnBooleanEventTrigger_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnBooleanEventTrigger.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bContent = bContent;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601E101 RID: 123137 RVA: 0x002C9E9C File Offset: 0x002C809C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnBooleanEventTrigger.__FOnBooleanEventTrigger_DelegateParams*)__Parameters)->bContent);
		}

		// Token: 0x04010400 RID: 66560
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010401 RID: 66561
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnBooleanEventTrigger__DelegateSignature";

		// Token: 0x04010402 RID: 66562
		private static int RegisterId;

		// Token: 0x020033AC RID: 13228
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnBooleanEventTrigger_DelegateParams
		{
			// Token: 0x04017361 RID: 95073
			[FieldOffset(0)]
			public bool bContent;
		}

		// Token: 0x020033AD RID: 13229
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017362 RID: 95074
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
