using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006A1 RID: 1697
	public sealed class FLGUILoopScrollViewGridCreateDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600920D RID: 37389 RVA: 0x000DBD4E File Offset: 0x000D9F4E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUILoopScrollViewGridCreateDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600920E RID: 37390 RVA: 0x000DBD5A File Offset: 0x000D9F5A
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUILoopScrollViewGridCreateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUILoopScrollViewGridCreateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUILoopScrollViewGridCreateDelegate__DelegateSignature");
			}
			return FLGUILoopScrollViewGridCreateDelegate._FunctionPtr;
		}

		// Token: 0x0600920F RID: 37391 RVA: 0x000DBD7D File Offset: 0x000D9F7D
		public FLGUILoopScrollViewGridCreateDelegate()
		{
		}

		// Token: 0x06009210 RID: 37392 RVA: 0x000DBD85 File Offset: 0x000D9F85
		[NullableContext(2)]
		public FLGUILoopScrollViewGridCreateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009211 RID: 37393 RVA: 0x000DBD8F File Offset: 0x000D9F8F
		public FLGUILoopScrollViewGridCreateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009212 RID: 37394 RVA: 0x000DBD9A File Offset: 0x000D9F9A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, AUIBaseActor>) ?? ((Action<int, AUIBaseActor>)Delegate.CreateDelegate(typeof(Action<int, AUIBaseActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009213 RID: 37395 RVA: 0x000DBDCC File Offset: 0x000D9FCC
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<int, AUIBaseActor> Callback)
		{
			if (FLGUILoopScrollViewGridCreateDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUILoopScrollViewGridCreateDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUILoopScrollViewGridCreateDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUILoopScrollViewGridCreateDelegate.OnScriptCallback));
				}
				FLGUILoopScrollViewGridCreateDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUILoopScrollViewGridCreateDelegate.RegisterId);
		}

		// Token: 0x06009214 RID: 37396 RVA: 0x000DBE08 File Offset: 0x000DA008
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(int DisplayIndex, AUIBaseActor Actor)
		{
			FLGUILoopScrollViewGridCreateDelegate.__FLGUILoopScrollViewGridCreateDelegate_DelegateParams* ptr = stackalloc FLGUILoopScrollViewGridCreateDelegate.__FLGUILoopScrollViewGridCreateDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUILoopScrollViewGridCreateDelegate.__FLGUILoopScrollViewGridCreateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUILoopScrollViewGridCreateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DisplayIndex = DisplayIndex;
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06009215 RID: 37397 RVA: 0x000DBE5C File Offset: 0x000DA05C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, AUIBaseActor> action = target as Action<int, AUIBaseActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AUIBaseActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(((FLGUILoopScrollViewGridCreateDelegate.__FLGUILoopScrollViewGridCreateDelegate_DelegateParams*)__Parameters)->Actor);
			action(((FLGUILoopScrollViewGridCreateDelegate.__FLGUILoopScrollViewGridCreateDelegate_DelegateParams*)__Parameters)->DisplayIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x04003FA5 RID: 16293
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003FA6 RID: 16294
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUILoopScrollViewGridCreateDelegate__DelegateSignature";

		// Token: 0x04003FA7 RID: 16295
		private static int RegisterId;

		// Token: 0x02000EC9 RID: 3785
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLGUILoopScrollViewGridCreateDelegate_DelegateParams
		{
			// Token: 0x04006283 RID: 25219
			[FieldOffset(0)]
			public int DisplayIndex;

			// Token: 0x04006284 RID: 25220
			[FieldOffset(8)]
			public IntPtr Actor;
		}

		// Token: 0x02000ECA RID: 3786
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006285 RID: 25221
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
