using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02002102 RID: 8450
	public sealed class FSelfLanguageChange : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FCB3 RID: 130227 RVA: 0x002F478C File Offset: 0x002F298C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSelfLanguageChange.StaticFunctionPtr();
		}

		// Token: 0x0601FCB4 RID: 130228 RVA: 0x002F4798 File Offset: 0x002F2998
		private static IntPtr StaticFunctionPtr()
		{
			if (FSelfLanguageChange._FunctionPtr == IntPtr.Zero)
			{
				FSelfLanguageChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.SelfLanguageChange__DelegateSignature");
			}
			return FSelfLanguageChange._FunctionPtr;
		}

		// Token: 0x0601FCB5 RID: 130229 RVA: 0x002F47BB File Offset: 0x002F29BB
		public FSelfLanguageChange()
		{
		}

		// Token: 0x0601FCB6 RID: 130230 RVA: 0x002F47C3 File Offset: 0x002F29C3
		[NullableContext(2)]
		public FSelfLanguageChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FCB7 RID: 130231 RVA: 0x002F47CD File Offset: 0x002F29CD
		public FSelfLanguageChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FCB8 RID: 130232 RVA: 0x002F47D8 File Offset: 0x002F29D8
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FCB9 RID: 130233 RVA: 0x002F480A File Offset: 0x002F2A0A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FSelfLanguageChange.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSelfLanguageChange.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSelfLanguageChange.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSelfLanguageChange.OnScriptCallback));
				}
				FSelfLanguageChange.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSelfLanguageChange.RegisterId);
		}

		// Token: 0x0601FCBA RID: 130234 RVA: 0x002F4844 File Offset: 0x002F2A44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601FCBB RID: 130235 RVA: 0x002F4850 File Offset: 0x002F2A50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x04011228 RID: 70184
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011229 RID: 70185
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.SelfLanguageChange__DelegateSignature";

		// Token: 0x0401122A RID: 70186
		private static int RegisterId;

		// Token: 0x020034E2 RID: 13538
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174F6 RID: 95478
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
