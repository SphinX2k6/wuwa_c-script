using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x0200074F RID: 1871
	public sealed class FTweenerSimpleDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A302 RID: 41730 RVA: 0x000F0F7E File Offset: 0x000EF17E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTweenerSimpleDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600A303 RID: 41731 RVA: 0x000F0F8A File Offset: 0x000EF18A
		private static IntPtr StaticFunctionPtr()
		{
			if (FTweenerSimpleDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTweenerSimpleDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.TweenerSimpleDynamicDelegate__DelegateSignature");
			}
			return FTweenerSimpleDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0600A304 RID: 41732 RVA: 0x000F0FAD File Offset: 0x000EF1AD
		public FTweenerSimpleDynamicDelegate()
		{
		}

		// Token: 0x0600A305 RID: 41733 RVA: 0x000F0FB5 File Offset: 0x000EF1B5
		[NullableContext(2)]
		public FTweenerSimpleDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A306 RID: 41734 RVA: 0x000F0FBF File Offset: 0x000EF1BF
		public FTweenerSimpleDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A307 RID: 41735 RVA: 0x000F0FCA File Offset: 0x000EF1CA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A308 RID: 41736 RVA: 0x000F0FFC File Offset: 0x000EF1FC
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FTweenerSimpleDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTweenerSimpleDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTweenerSimpleDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTweenerSimpleDynamicDelegate.OnScriptCallback));
				}
				FTweenerSimpleDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FTweenerSimpleDynamicDelegate.RegisterId);
		}

		// Token: 0x0600A309 RID: 41737 RVA: 0x000F1036 File Offset: 0x000EF236
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600A30A RID: 41738 RVA: 0x000F1044 File Offset: 0x000EF244
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

		// Token: 0x040045B2 RID: 17842
		internal static IntPtr _FunctionPtr;

		// Token: 0x040045B3 RID: 17843
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.TweenerSimpleDynamicDelegate__DelegateSignature";

		// Token: 0x040045B4 RID: 17844
		private static int RegisterId;

		// Token: 0x02000F3E RID: 3902
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006312 RID: 25362
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
