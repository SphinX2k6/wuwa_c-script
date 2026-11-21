using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02000267 RID: 615
	public sealed class FPostEvaluateAnimEvent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060036B4 RID: 14004 RVA: 0x0004D11A File Offset: 0x0004B31A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPostEvaluateAnimEvent.StaticFunctionPtr();
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x0004D126 File Offset: 0x0004B326
		private static IntPtr StaticFunctionPtr()
		{
			if (FPostEvaluateAnimEvent._FunctionPtr == IntPtr.Zero)
			{
				FPostEvaluateAnimEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.PostEvaluateAnimEvent__DelegateSignature");
			}
			return FPostEvaluateAnimEvent._FunctionPtr;
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x0004D149 File Offset: 0x0004B349
		public FPostEvaluateAnimEvent()
		{
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x0004D151 File Offset: 0x0004B351
		[NullableContext(2)]
		public FPostEvaluateAnimEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x0004D15B File Offset: 0x0004B35B
		public FPostEvaluateAnimEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x0004D166 File Offset: 0x0004B366
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x0004D198 File Offset: 0x0004B398
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FPostEvaluateAnimEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPostEvaluateAnimEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPostEvaluateAnimEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPostEvaluateAnimEvent.OnScriptCallback));
				}
				FPostEvaluateAnimEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPostEvaluateAnimEvent.RegisterId);
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x0004D1D2 File Offset: 0x0004B3D2
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x0004D1E0 File Offset: 0x0004B3E0
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

		// Token: 0x040012D9 RID: 4825
		internal static IntPtr _FunctionPtr;

		// Token: 0x040012DA RID: 4826
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PostEvaluateAnimEvent__DelegateSignature";

		// Token: 0x040012DB RID: 4827
		private static int RegisterId;

		// Token: 0x020009E4 RID: 2532
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400597D RID: 22909
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
