using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006A2 RID: 1698
	public sealed class FLGUILoopScrollViewGridDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009216 RID: 37398 RVA: 0x000DBEB3 File Offset: 0x000DA0B3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUILoopScrollViewGridDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009217 RID: 37399 RVA: 0x000DBEBF File Offset: 0x000DA0BF
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUILoopScrollViewGridDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUILoopScrollViewGridDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUILoopScrollViewGridDelegate__DelegateSignature");
			}
			return FLGUILoopScrollViewGridDelegate._FunctionPtr;
		}

		// Token: 0x06009218 RID: 37400 RVA: 0x000DBEE2 File Offset: 0x000DA0E2
		public FLGUILoopScrollViewGridDelegate()
		{
		}

		// Token: 0x06009219 RID: 37401 RVA: 0x000DBEEA File Offset: 0x000DA0EA
		[NullableContext(2)]
		public FLGUILoopScrollViewGridDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600921A RID: 37402 RVA: 0x000DBEF4 File Offset: 0x000DA0F4
		public FLGUILoopScrollViewGridDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600921B RID: 37403 RVA: 0x000DBEFF File Offset: 0x000DA0FF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600921C RID: 37404 RVA: 0x000DBF31 File Offset: 0x000DA131
		[NullableContext(1)]
		public void Bind(Action<int, int> Callback)
		{
			if (FLGUILoopScrollViewGridDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUILoopScrollViewGridDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUILoopScrollViewGridDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUILoopScrollViewGridDelegate.OnScriptCallback));
				}
				FLGUILoopScrollViewGridDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUILoopScrollViewGridDelegate.RegisterId);
		}

		// Token: 0x0600921D RID: 37405 RVA: 0x000DBF6C File Offset: 0x000DA16C
		[SkipLocalsInit]
		public unsafe void Execute(int StartIndex, int EndIndex)
		{
			FLGUILoopScrollViewGridDelegate.__FLGUILoopScrollViewGridDelegate_DelegateParams* ptr = stackalloc FLGUILoopScrollViewGridDelegate.__FLGUILoopScrollViewGridDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUILoopScrollViewGridDelegate.__FLGUILoopScrollViewGridDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUILoopScrollViewGridDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->StartIndex = StartIndex;
			ptr->EndIndex = EndIndex;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600921E RID: 37406 RVA: 0x000DBFB0 File Offset: 0x000DA1B0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUILoopScrollViewGridDelegate.__FLGUILoopScrollViewGridDelegate_DelegateParams*)__Parameters)->StartIndex, ((FLGUILoopScrollViewGridDelegate.__FLGUILoopScrollViewGridDelegate_DelegateParams*)__Parameters)->EndIndex);
		}

		// Token: 0x04003FA8 RID: 16296
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003FA9 RID: 16297
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUILoopScrollViewGridDelegate__DelegateSignature";

		// Token: 0x04003FAA RID: 16298
		private static int RegisterId;

		// Token: 0x02000ECB RID: 3787
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FLGUILoopScrollViewGridDelegate_DelegateParams
		{
			// Token: 0x04006286 RID: 25222
			[FieldOffset(0)]
			public int StartIndex;

			// Token: 0x04006287 RID: 25223
			[FieldOffset(4)]
			public int EndIndex;
		}

		// Token: 0x02000ECC RID: 3788
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006288 RID: 25224
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
