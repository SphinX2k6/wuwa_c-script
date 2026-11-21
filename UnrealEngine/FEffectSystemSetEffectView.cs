using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003D5 RID: 981
	public sealed class FEffectSystemSetEffectView : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060060E5 RID: 24805 RVA: 0x0008A62B File Offset: 0x0008882B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectSystemSetEffectView.StaticFunctionPtr();
		}

		// Token: 0x060060E6 RID: 24806 RVA: 0x0008A637 File Offset: 0x00088837
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectSystemSetEffectView._FunctionPtr == IntPtr.Zero)
			{
				FEffectSystemSetEffectView._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectSystemSetEffectView__DelegateSignature");
			}
			return FEffectSystemSetEffectView._FunctionPtr;
		}

		// Token: 0x060060E7 RID: 24807 RVA: 0x0008A65A File Offset: 0x0008885A
		public FEffectSystemSetEffectView()
		{
		}

		// Token: 0x060060E8 RID: 24808 RVA: 0x0008A662 File Offset: 0x00088862
		[NullableContext(2)]
		public FEffectSystemSetEffectView(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060060E9 RID: 24809 RVA: 0x0008A66C File Offset: 0x0008886C
		public FEffectSystemSetEffectView(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060060EA RID: 24810 RVA: 0x0008A677 File Offset: 0x00088877
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<AActor, int>) ?? ((Action<AActor, int>)Delegate.CreateDelegate(typeof(Action<AActor, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060060EB RID: 24811 RVA: 0x0008A6A9 File Offset: 0x000888A9
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor, int> Callback)
		{
			if (FEffectSystemSetEffectView.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEffectSystemSetEffectView.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEffectSystemSetEffectView.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEffectSystemSetEffectView.OnScriptCallback));
				}
				FEffectSystemSetEffectView.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FEffectSystemSetEffectView.RegisterId);
		}

		// Token: 0x060060EC RID: 24812 RVA: 0x0008A6E4 File Offset: 0x000888E4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(AActor Actor, int EffectId)
		{
			FEffectSystemSetEffectView.__FEffectSystemSetEffectView_DelegateParams* ptr = stackalloc FEffectSystemSetEffectView.__FEffectSystemSetEffectView_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FEffectSystemSetEffectView.__FEffectSystemSetEffectView_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEffectSystemSetEffectView.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			ptr->EffectId = EffectId;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060060ED RID: 24813 RVA: 0x0008A738 File Offset: 0x00088938
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, int> action = target as Action<AActor, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FEffectSystemSetEffectView.__FEffectSystemSetEffectView_DelegateParams*)__Parameters)->Actor);
			action(orCreateUObjectByNativePointer, ((FEffectSystemSetEffectView.__FEffectSystemSetEffectView_DelegateParams*)__Parameters)->EffectId);
		}

		// Token: 0x0400293E RID: 10558
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400293F RID: 10559
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectSystemSetEffectView__DelegateSignature";

		// Token: 0x04002940 RID: 10560
		private static int RegisterId;

		// Token: 0x02000ACE RID: 2766
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FEffectSystemSetEffectView_DelegateParams
		{
			// Token: 0x04005B4A RID: 23370
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x04005B4B RID: 23371
			[FieldOffset(8)]
			public int EffectId;
		}

		// Token: 0x02000ACF RID: 2767
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B4C RID: 23372
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
