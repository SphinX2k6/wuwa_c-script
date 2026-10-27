using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002034 RID: 8244
	public sealed class FLGUIDelegateForHelpClick : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F308 RID: 127752 RVA: 0x002E4D85 File Offset: 0x002E2F85
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDelegateForHelpClick.StaticFunctionPtr();
		}

		// Token: 0x0601F309 RID: 127753 RVA: 0x002E4D91 File Offset: 0x002E2F91
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDelegateForHelpClick._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDelegateForHelpClick._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDelegateForHelpClick__DelegateSignature");
			}
			return FLGUIDelegateForHelpClick._FunctionPtr;
		}

		// Token: 0x0601F30A RID: 127754 RVA: 0x002E4DB4 File Offset: 0x002E2FB4
		public FLGUIDelegateForHelpClick()
		{
		}

		// Token: 0x0601F30B RID: 127755 RVA: 0x002E4DBC File Offset: 0x002E2FBC
		[NullableContext(2)]
		public FLGUIDelegateForHelpClick(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F30C RID: 127756 RVA: 0x002E4DC6 File Offset: 0x002E2FC6
		public FLGUIDelegateForHelpClick(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F30D RID: 127757 RVA: 0x002E4DD1 File Offset: 0x002E2FD1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F30E RID: 127758 RVA: 0x002E4E03 File Offset: 0x002E3003
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F30F RID: 127759 RVA: 0x002E4E40 File Offset: 0x002E3040
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int helpGroupId)
		{
			FLGUIDelegateForHelpClick.__FLGUIDelegateForHelpClick_DelegateParams* ptr = stackalloc FLGUIDelegateForHelpClick.__FLGUIDelegateForHelpClick_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FLGUIDelegateForHelpClick.__FLGUIDelegateForHelpClick_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDelegateForHelpClick.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->helpGroupId = helpGroupId;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F310 RID: 127760 RVA: 0x002E4E80 File Offset: 0x002E3080
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDelegateForHelpClick.__FLGUIDelegateForHelpClick_DelegateParams*)__Parameters)->helpGroupId);
		}

		// Token: 0x04010E1E RID: 69150
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010E1F RID: 69151
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDelegateForHelpClick__DelegateSignature";

		// Token: 0x04010E20 RID: 69152
		private static int RegisterId;

		// Token: 0x0200343C RID: 13372
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FLGUIDelegateForHelpClick_DelegateParams
		{
			// Token: 0x0401741D RID: 95261
			[FieldOffset(0)]
			public int helpGroupId;
		}

		// Token: 0x0200343D RID: 13373
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401741E RID: 95262
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
