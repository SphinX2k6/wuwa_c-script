using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000597 RID: 1431
	public sealed class FOnKSCAttrChange : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060081D4 RID: 33236 RVA: 0x000BF97E File Offset: 0x000BDB7E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKSCAttrChange.StaticFunctionPtr();
		}

		// Token: 0x060081D5 RID: 33237 RVA: 0x000BF98A File Offset: 0x000BDB8A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKSCAttrChange._FunctionPtr == IntPtr.Zero)
			{
				FOnKSCAttrChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnKSCAttrChange__DelegateSignature");
			}
			return FOnKSCAttrChange._FunctionPtr;
		}

		// Token: 0x060081D6 RID: 33238 RVA: 0x000BF9AD File Offset: 0x000BDBAD
		public FOnKSCAttrChange()
		{
		}

		// Token: 0x060081D7 RID: 33239 RVA: 0x000BF9B5 File Offset: 0x000BDBB5
		[NullableContext(2)]
		public FOnKSCAttrChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060081D8 RID: 33240 RVA: 0x000BF9BF File Offset: 0x000BDBBF
		public FOnKSCAttrChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060081D9 RID: 33241 RVA: 0x000BF9CA File Offset: 0x000BDBCA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<EKSC_AttrType, int>) ?? ((Action<EKSC_AttrType, int>)Delegate.CreateDelegate(typeof(Action<EKSC_AttrType, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060081DA RID: 33242 RVA: 0x000BF9FC File Offset: 0x000BDBFC
		[NullableContext(1)]
		public void Bind(Action<EKSC_AttrType, int> Callback)
		{
			if (FOnKSCAttrChange.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnKSCAttrChange.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnKSCAttrChange.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnKSCAttrChange.OnScriptCallback));
				}
				FOnKSCAttrChange.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnKSCAttrChange.RegisterId);
		}

		// Token: 0x060081DB RID: 33243 RVA: 0x000BFA38 File Offset: 0x000BDC38
		[SkipLocalsInit]
		public unsafe void Execute(EKSC_AttrType AttrType, int Value)
		{
			FOnKSCAttrChange.__FOnKSCAttrChange_DelegateParams* ptr = stackalloc FOnKSCAttrChange.__FOnKSCAttrChange_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnKSCAttrChange.__FOnKSCAttrChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnKSCAttrChange.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->AttrType = AttrType;
			ptr->Value = Value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060081DC RID: 33244 RVA: 0x000BFA7C File Offset: 0x000BDC7C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EKSC_AttrType, int> action = target as Action<EKSC_AttrType, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnKSCAttrChange.__FOnKSCAttrChange_DelegateParams*)__Parameters)->AttrType, ((FOnKSCAttrChange.__FOnKSCAttrChange_DelegateParams*)__Parameters)->Value);
		}

		// Token: 0x040038A4 RID: 14500
		internal static IntPtr _FunctionPtr;

		// Token: 0x040038A5 RID: 14501
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnKSCAttrChange__DelegateSignature";

		// Token: 0x040038A6 RID: 14502
		private static int RegisterId;

		// Token: 0x02000D0D RID: 3341
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnKSCAttrChange_DelegateParams
		{
			// Token: 0x04005F9D RID: 24477
			[FieldOffset(0)]
			public EKSC_AttrType AttrType;

			// Token: 0x04005F9E RID: 24478
			[FieldOffset(4)]
			public int Value;
		}

		// Token: 0x02000D0E RID: 3342
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F9F RID: 24479
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
