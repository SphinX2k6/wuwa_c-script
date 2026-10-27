using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E82 RID: 7810
	public sealed class FQueriedCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DBC0 RID: 121792 RVA: 0x002BEC67 File Offset: 0x002BCE67
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FQueriedCallback.StaticFunctionPtr();
		}

		// Token: 0x0601DBC1 RID: 121793 RVA: 0x002BEC73 File Offset: 0x002BCE73
		private static IntPtr StaticFunctionPtr()
		{
			if (FQueriedCallback._FunctionPtr == IntPtr.Zero)
			{
				FQueriedCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSqliteBpLib.QueriedCallback__DelegateSignature");
			}
			return FQueriedCallback._FunctionPtr;
		}

		// Token: 0x0601DBC2 RID: 121794 RVA: 0x002BEC96 File Offset: 0x002BCE96
		public FQueriedCallback()
		{
		}

		// Token: 0x0601DBC3 RID: 121795 RVA: 0x002BEC9E File Offset: 0x002BCE9E
		[NullableContext(2)]
		public FQueriedCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DBC4 RID: 121796 RVA: 0x002BECA8 File Offset: 0x002BCEA8
		public FQueriedCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DBC5 RID: 121797 RVA: 0x002BECB3 File Offset: 0x002BCEB3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DBC6 RID: 121798 RVA: 0x002BECE5 File Offset: 0x002BCEE5
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<bool> Callback)
		{
			if (FQueriedCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FQueriedCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FQueriedCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FQueriedCallback.OnScriptCallback));
				}
				FQueriedCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FQueriedCallback.RegisterId);
		}

		// Token: 0x0601DBC7 RID: 121799 RVA: 0x002BED20 File Offset: 0x002BCF20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool Success)
		{
			FQueriedCallback.__FQueriedCallback_DelegateParams* ptr = stackalloc FQueriedCallback.__FQueriedCallback_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FQueriedCallback.__FQueriedCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FQueriedCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Success = Success;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601DBC8 RID: 121800 RVA: 0x002BED60 File Offset: 0x002BCF60
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
			action(((FQueriedCallback.__FQueriedCallback_DelegateParams*)__Parameters)->Success);
		}

		// Token: 0x04010185 RID: 65925
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010186 RID: 65926
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSqliteBpLib.QueriedCallback__DelegateSignature";

		// Token: 0x04010187 RID: 65927
		private static int RegisterId;

		// Token: 0x020032D2 RID: 13010
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FQueriedCallback_DelegateParams
		{
			// Token: 0x04017179 RID: 94585
			[FieldOffset(0)]
			public bool Success;
		}

		// Token: 0x020032D3 RID: 13011
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401717A RID: 94586
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
