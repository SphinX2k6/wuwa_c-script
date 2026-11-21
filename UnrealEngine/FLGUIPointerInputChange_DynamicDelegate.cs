using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006B3 RID: 1715
	public sealed class FLGUIPointerInputChange_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009353 RID: 37715 RVA: 0x000DDCB5 File Offset: 0x000DBEB5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIPointerInputChange_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009354 RID: 37716 RVA: 0x000DDCC1 File Offset: 0x000DBEC1
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIPointerInputChange_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIPointerInputChange_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIPointerInputChange_DynamicDelegate__DelegateSignature");
			}
			return FLGUIPointerInputChange_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x06009355 RID: 37717 RVA: 0x000DDCE4 File Offset: 0x000DBEE4
		public FLGUIPointerInputChange_DynamicDelegate()
		{
		}

		// Token: 0x06009356 RID: 37718 RVA: 0x000DDCEC File Offset: 0x000DBEEC
		[NullableContext(2)]
		public FLGUIPointerInputChange_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009357 RID: 37719 RVA: 0x000DDCF6 File Offset: 0x000DBEF6
		public FLGUIPointerInputChange_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009358 RID: 37720 RVA: 0x000DDD01 File Offset: 0x000DBF01
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<ELGUIPointerInputType>) ?? ((Action<ELGUIPointerInputType>)Delegate.CreateDelegate(typeof(Action<ELGUIPointerInputType>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009359 RID: 37721 RVA: 0x000DDD33 File Offset: 0x000DBF33
		[NullableContext(1)]
		public void Bind(Action<ELGUIPointerInputType> Callback)
		{
			if (FLGUIPointerInputChange_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIPointerInputChange_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIPointerInputChange_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIPointerInputChange_DynamicDelegate.OnScriptCallback));
				}
				FLGUIPointerInputChange_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIPointerInputChange_DynamicDelegate.RegisterId);
		}

		// Token: 0x0600935A RID: 37722 RVA: 0x000DDD70 File Offset: 0x000DBF70
		[SkipLocalsInit]
		public unsafe void Execute(ELGUIPointerInputType type)
		{
			FLGUIPointerInputChange_DynamicDelegate.__FLGUIPointerInputChange_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIPointerInputChange_DynamicDelegate.__FLGUIPointerInputChange_DynamicDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FLGUIPointerInputChange_DynamicDelegate.__FLGUIPointerInputChange_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIPointerInputChange_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->type = type;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600935B RID: 37723 RVA: 0x000DDDB0 File Offset: 0x000DBFB0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<ELGUIPointerInputType> action = target as Action<ELGUIPointerInputType>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIPointerInputChange_DynamicDelegate.__FLGUIPointerInputChange_DynamicDelegate_DelegateParams*)__Parameters)->type);
		}

		// Token: 0x0400403A RID: 16442
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400403B RID: 16443
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIPointerInputChange_DynamicDelegate__DelegateSignature";

		// Token: 0x0400403C RID: 16444
		private static int RegisterId;

		// Token: 0x02000EDA RID: 3802
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FLGUIPointerInputChange_DynamicDelegate_DelegateParams
		{
			// Token: 0x0400629A RID: 25242
			[FieldOffset(0)]
			public ELGUIPointerInputType type;
		}

		// Token: 0x02000EDB RID: 3803
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400629B RID: 25243
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
