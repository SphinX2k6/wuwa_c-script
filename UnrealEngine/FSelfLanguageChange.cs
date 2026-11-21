using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020006D8 RID: 1752
	public sealed class FSelfLanguageChange : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060094F9 RID: 38137 RVA: 0x000E0D4E File Offset: 0x000DEF4E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSelfLanguageChange.StaticFunctionPtr();
		}

		// Token: 0x060094FA RID: 38138 RVA: 0x000E0D5A File Offset: 0x000DEF5A
		private static IntPtr StaticFunctionPtr()
		{
			if (FSelfLanguageChange._FunctionPtr == IntPtr.Zero)
			{
				FSelfLanguageChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.SelfLanguageChange__DelegateSignature");
			}
			return FSelfLanguageChange._FunctionPtr;
		}

		// Token: 0x060094FB RID: 38139 RVA: 0x000E0D7D File Offset: 0x000DEF7D
		public FSelfLanguageChange()
		{
		}

		// Token: 0x060094FC RID: 38140 RVA: 0x000E0D85 File Offset: 0x000DEF85
		[NullableContext(2)]
		public FSelfLanguageChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060094FD RID: 38141 RVA: 0x000E0D8F File Offset: 0x000DEF8F
		public FSelfLanguageChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060094FE RID: 38142 RVA: 0x000E0D9A File Offset: 0x000DEF9A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060094FF RID: 38143 RVA: 0x000E0DCC File Offset: 0x000DEFCC
		[NullableContext(1)]
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

		// Token: 0x06009500 RID: 38144 RVA: 0x000E0E06 File Offset: 0x000DF006
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06009501 RID: 38145 RVA: 0x000E0E14 File Offset: 0x000DF014
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x040040C6 RID: 16582
		internal static IntPtr _FunctionPtr;

		// Token: 0x040040C7 RID: 16583
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.SelfLanguageChange__DelegateSignature";

		// Token: 0x040040C8 RID: 16584
		private static int RegisterId;

		// Token: 0x02000F0E RID: 3854
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062DB RID: 25307
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
