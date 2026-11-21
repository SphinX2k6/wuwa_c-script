using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000596 RID: 1430
	public sealed class FOnKSCAllAttrChange : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060081CB RID: 33227 RVA: 0x000BF824 File Offset: 0x000BDA24
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKSCAllAttrChange.StaticFunctionPtr();
		}

		// Token: 0x060081CC RID: 33228 RVA: 0x000BF830 File Offset: 0x000BDA30
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKSCAllAttrChange._FunctionPtr == IntPtr.Zero)
			{
				FOnKSCAllAttrChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnKSCAllAttrChange__DelegateSignature");
			}
			return FOnKSCAllAttrChange._FunctionPtr;
		}

		// Token: 0x060081CD RID: 33229 RVA: 0x000BF853 File Offset: 0x000BDA53
		public FOnKSCAllAttrChange()
		{
		}

		// Token: 0x060081CE RID: 33230 RVA: 0x000BF85B File Offset: 0x000BDA5B
		[NullableContext(2)]
		public FOnKSCAllAttrChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060081CF RID: 33231 RVA: 0x000BF865 File Offset: 0x000BDA65
		public FOnKSCAllAttrChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060081D0 RID: 33232 RVA: 0x000BF870 File Offset: 0x000BDA70
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<EKSC_AttrType, int, int>) ?? ((Action<EKSC_AttrType, int, int>)Delegate.CreateDelegate(typeof(Action<EKSC_AttrType, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060081D1 RID: 33233 RVA: 0x000BF8A2 File Offset: 0x000BDAA2
		[NullableContext(1)]
		public void Bind(Action<EKSC_AttrType, int, int> Callback)
		{
			if (FOnKSCAllAttrChange.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnKSCAllAttrChange.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnKSCAllAttrChange.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnKSCAllAttrChange.OnScriptCallback));
				}
				FOnKSCAllAttrChange.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnKSCAllAttrChange.RegisterId);
		}

		// Token: 0x060081D2 RID: 33234 RVA: 0x000BF8DC File Offset: 0x000BDADC
		[SkipLocalsInit]
		public unsafe void Execute(EKSC_AttrType AttrType, int OldValue, int NewValue)
		{
			FOnKSCAllAttrChange.__FOnKSCAllAttrChange_DelegateParams* ptr = stackalloc FOnKSCAllAttrChange.__FOnKSCAllAttrChange_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FOnKSCAllAttrChange.__FOnKSCAllAttrChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnKSCAllAttrChange.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->AttrType = AttrType;
			ptr->OldValue = OldValue;
			ptr->NewValue = NewValue;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060081D3 RID: 33235 RVA: 0x000BF928 File Offset: 0x000BDB28
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EKSC_AttrType, int, int> action = target as Action<EKSC_AttrType, int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnKSCAllAttrChange.__FOnKSCAllAttrChange_DelegateParams*)__Parameters)->AttrType, ((FOnKSCAllAttrChange.__FOnKSCAllAttrChange_DelegateParams*)__Parameters)->OldValue, ((FOnKSCAllAttrChange.__FOnKSCAllAttrChange_DelegateParams*)__Parameters)->NewValue);
		}

		// Token: 0x040038A1 RID: 14497
		internal static IntPtr _FunctionPtr;

		// Token: 0x040038A2 RID: 14498
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnKSCAllAttrChange__DelegateSignature";

		// Token: 0x040038A3 RID: 14499
		private static int RegisterId;

		// Token: 0x02000D0B RID: 3339
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		private ref struct __FOnKSCAllAttrChange_DelegateParams
		{
			// Token: 0x04005F99 RID: 24473
			[FieldOffset(0)]
			public EKSC_AttrType AttrType;

			// Token: 0x04005F9A RID: 24474
			[FieldOffset(4)]
			public int OldValue;

			// Token: 0x04005F9B RID: 24475
			[FieldOffset(8)]
			public int NewValue;
		}

		// Token: 0x02000D0C RID: 3340
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F9C RID: 24476
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
