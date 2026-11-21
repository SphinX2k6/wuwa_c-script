using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000674 RID: 1652
	public sealed class FLGUIDelegateForHelpClick : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009004 RID: 36868 RVA: 0x000D7F77 File Offset: 0x000D6177
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDelegateForHelpClick.StaticFunctionPtr();
		}

		// Token: 0x06009005 RID: 36869 RVA: 0x000D7F83 File Offset: 0x000D6183
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDelegateForHelpClick._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDelegateForHelpClick._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDelegateForHelpClick__DelegateSignature");
			}
			return FLGUIDelegateForHelpClick._FunctionPtr;
		}

		// Token: 0x06009006 RID: 36870 RVA: 0x000D7FA6 File Offset: 0x000D61A6
		public FLGUIDelegateForHelpClick()
		{
		}

		// Token: 0x06009007 RID: 36871 RVA: 0x000D7FAE File Offset: 0x000D61AE
		[NullableContext(2)]
		public FLGUIDelegateForHelpClick(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009008 RID: 36872 RVA: 0x000D7FB8 File Offset: 0x000D61B8
		public FLGUIDelegateForHelpClick(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009009 RID: 36873 RVA: 0x000D7FC3 File Offset: 0x000D61C3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600900A RID: 36874 RVA: 0x000D7FF5 File Offset: 0x000D61F5
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FLGUIDelegateForHelpClick.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDelegateForHelpClick.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDelegateForHelpClick.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDelegateForHelpClick.OnScriptCallback));
				}
				FLGUIDelegateForHelpClick.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDelegateForHelpClick.RegisterId);
		}

		// Token: 0x0600900B RID: 36875 RVA: 0x000D8030 File Offset: 0x000D6230
		[SkipLocalsInit]
		public unsafe void Execute(int helpGroupId)
		{
			FLGUIDelegateForHelpClick.__FLGUIDelegateForHelpClick_DelegateParams* ptr = stackalloc FLGUIDelegateForHelpClick.__FLGUIDelegateForHelpClick_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FLGUIDelegateForHelpClick.__FLGUIDelegateForHelpClick_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDelegateForHelpClick.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->helpGroupId = helpGroupId;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600900C RID: 36876 RVA: 0x000D8070 File Offset: 0x000D6270
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDelegateForHelpClick.__FLGUIDelegateForHelpClick_DelegateParams*)__Parameters)->helpGroupId);
		}

		// Token: 0x04003EF6 RID: 16118
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003EF7 RID: 16119
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDelegateForHelpClick__DelegateSignature";

		// Token: 0x04003EF8 RID: 16120
		private static int RegisterId;

		// Token: 0x02000E7F RID: 3711
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FLGUIDelegateForHelpClick_DelegateParams
		{
			// Token: 0x0400622C RID: 25132
			[FieldOffset(0)]
			public int helpGroupId;
		}

		// Token: 0x02000E80 RID: 3712
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400622D RID: 25133
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
