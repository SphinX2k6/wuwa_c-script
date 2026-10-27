using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E64 RID: 7780
	public sealed class FOnKSCAttrChange : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DA6A RID: 121450 RVA: 0x002BC6A2 File Offset: 0x002BA8A2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKSCAttrChange.StaticFunctionPtr();
		}

		// Token: 0x0601DA6B RID: 121451 RVA: 0x002BC6AE File Offset: 0x002BA8AE
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKSCAttrChange._FunctionPtr == IntPtr.Zero)
			{
				FOnKSCAttrChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnKSCAttrChange__DelegateSignature");
			}
			return FOnKSCAttrChange._FunctionPtr;
		}

		// Token: 0x0601DA6C RID: 121452 RVA: 0x002BC6D1 File Offset: 0x002BA8D1
		public FOnKSCAttrChange()
		{
		}

		// Token: 0x0601DA6D RID: 121453 RVA: 0x002BC6D9 File Offset: 0x002BA8D9
		[NullableContext(2)]
		public FOnKSCAttrChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DA6E RID: 121454 RVA: 0x002BC6E3 File Offset: 0x002BA8E3
		public FOnKSCAttrChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DA6F RID: 121455 RVA: 0x002BC6EE File Offset: 0x002BA8EE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<EKSC_AttrType, int>) ?? ((Action<EKSC_AttrType, int>)Delegate.CreateDelegate(typeof(Action<EKSC_AttrType, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DA70 RID: 121456 RVA: 0x002BC720 File Offset: 0x002BA920
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601DA71 RID: 121457 RVA: 0x002BC75C File Offset: 0x002BA95C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(EKSC_AttrType AttrType, int Value)
		{
			FOnKSCAttrChange.__FOnKSCAttrChange_DelegateParams* ptr = stackalloc FOnKSCAttrChange.__FOnKSCAttrChange_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnKSCAttrChange.__FOnKSCAttrChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnKSCAttrChange.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->AttrType = AttrType;
			ptr->Value = Value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601DA72 RID: 121458 RVA: 0x002BC7A0 File Offset: 0x002BA9A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EKSC_AttrType, int> action = target as Action<EKSC_AttrType, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnKSCAttrChange.__FOnKSCAttrChange_DelegateParams*)__Parameters)->AttrType, ((FOnKSCAttrChange.__FOnKSCAttrChange_DelegateParams*)__Parameters)->Value);
		}

		// Token: 0x0401010F RID: 65807
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010110 RID: 65808
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnKSCAttrChange__DelegateSignature";

		// Token: 0x04010111 RID: 65809
		private static int RegisterId;

		// Token: 0x020032AE RID: 12974
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnKSCAttrChange_DelegateParams
		{
			// Token: 0x04017151 RID: 94545
			[FieldOffset(0)]
			public EKSC_AttrType AttrType;

			// Token: 0x04017152 RID: 94546
			[FieldOffset(4)]
			public int Value;
		}

		// Token: 0x020032AF RID: 12975
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017153 RID: 94547
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
