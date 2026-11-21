using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200069E RID: 1694
	public sealed class FLGUIInputActivateDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060091F4 RID: 37364 RVA: 0x000DBA64 File Offset: 0x000D9C64
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIInputActivateDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x060091F5 RID: 37365 RVA: 0x000DBA70 File Offset: 0x000D9C70
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIInputActivateDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIInputActivateDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIInputActivateDynamicDelegate__DelegateSignature");
			}
			return FLGUIInputActivateDynamicDelegate._FunctionPtr;
		}

		// Token: 0x060091F6 RID: 37366 RVA: 0x000DBA93 File Offset: 0x000D9C93
		public FLGUIInputActivateDynamicDelegate()
		{
		}

		// Token: 0x060091F7 RID: 37367 RVA: 0x000DBA9B File Offset: 0x000D9C9B
		[NullableContext(2)]
		public FLGUIInputActivateDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060091F8 RID: 37368 RVA: 0x000DBAA5 File Offset: 0x000D9CA5
		public FLGUIInputActivateDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060091F9 RID: 37369 RVA: 0x000DBAB0 File Offset: 0x000D9CB0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060091FA RID: 37370 RVA: 0x000DBAE2 File Offset: 0x000D9CE2
		[NullableContext(1)]
		public void Bind(Action<bool> Callback)
		{
			if (FLGUIInputActivateDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIInputActivateDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIInputActivateDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIInputActivateDynamicDelegate.OnScriptCallback));
				}
				FLGUIInputActivateDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIInputActivateDynamicDelegate.RegisterId);
		}

		// Token: 0x060091FB RID: 37371 RVA: 0x000DBB1C File Offset: 0x000D9D1C
		[SkipLocalsInit]
		public unsafe void Execute(bool InActivate)
		{
			FLGUIInputActivateDynamicDelegate.__FLGUIInputActivateDynamicDelegate_DelegateParams* ptr = stackalloc FLGUIInputActivateDynamicDelegate.__FLGUIInputActivateDynamicDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FLGUIInputActivateDynamicDelegate.__FLGUIInputActivateDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIInputActivateDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InActivate = InActivate;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060091FC RID: 37372 RVA: 0x000DBB5C File Offset: 0x000D9D5C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIInputActivateDynamicDelegate.__FLGUIInputActivateDynamicDelegate_DelegateParams*)__Parameters)->InActivate);
		}

		// Token: 0x04003F9B RID: 16283
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F9C RID: 16284
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIInputActivateDynamicDelegate__DelegateSignature";

		// Token: 0x04003F9D RID: 16285
		private static int RegisterId;

		// Token: 0x02000EC6 RID: 3782
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FLGUIInputActivateDynamicDelegate_DelegateParams
		{
			// Token: 0x04006280 RID: 25216
			[FieldOffset(0)]
			public bool InActivate;
		}

		// Token: 0x02000EC7 RID: 3783
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006281 RID: 25217
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
