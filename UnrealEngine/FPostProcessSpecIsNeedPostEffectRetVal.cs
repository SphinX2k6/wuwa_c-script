using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000418 RID: 1048
	public sealed class FPostProcessSpecIsNeedPostEffectRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600659B RID: 26011 RVA: 0x0009181E File Offset: 0x0008FA1E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPostProcessSpecIsNeedPostEffectRetVal.StaticFunctionPtr();
		}

		// Token: 0x0600659C RID: 26012 RVA: 0x0009182A File Offset: 0x0008FA2A
		private static IntPtr StaticFunctionPtr()
		{
			if (FPostProcessSpecIsNeedPostEffectRetVal._FunctionPtr == IntPtr.Zero)
			{
				FPostProcessSpecIsNeedPostEffectRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.PostProcessSpecIsNeedPostEffectRetVal__DelegateSignature");
			}
			return FPostProcessSpecIsNeedPostEffectRetVal._FunctionPtr;
		}

		// Token: 0x0600659D RID: 26013 RVA: 0x0009184D File Offset: 0x0008FA4D
		public FPostProcessSpecIsNeedPostEffectRetVal()
		{
		}

		// Token: 0x0600659E RID: 26014 RVA: 0x00091855 File Offset: 0x0008FA55
		[NullableContext(2)]
		public FPostProcessSpecIsNeedPostEffectRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600659F RID: 26015 RVA: 0x0009185F File Offset: 0x0008FA5F
		public FPostProcessSpecIsNeedPostEffectRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060065A0 RID: 26016 RVA: 0x0009186A File Offset: 0x0008FA6A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int, bool, bool>) ?? ((Func<int, bool, bool>)Delegate.CreateDelegate(typeof(Func<int, bool, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060065A1 RID: 26017 RVA: 0x0009189C File Offset: 0x0008FA9C
		[NullableContext(1)]
		public void Bind(Func<int, bool, bool> Callback)
		{
			if (FPostProcessSpecIsNeedPostEffectRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPostProcessSpecIsNeedPostEffectRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPostProcessSpecIsNeedPostEffectRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPostProcessSpecIsNeedPostEffectRetVal.OnScriptCallback));
				}
				FPostProcessSpecIsNeedPostEffectRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPostProcessSpecIsNeedPostEffectRetVal.RegisterId);
		}

		// Token: 0x060065A2 RID: 26018 RVA: 0x000918D8 File Offset: 0x0008FAD8
		[SkipLocalsInit]
		public unsafe bool Execute(int EntityId, bool VisibleForProtoPlayer)
		{
			FPostProcessSpecIsNeedPostEffectRetVal.__FPostProcessSpecIsNeedPostEffectRetVal_DelegateParams* ptr = stackalloc FPostProcessSpecIsNeedPostEffectRetVal.__FPostProcessSpecIsNeedPostEffectRetVal_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FPostProcessSpecIsNeedPostEffectRetVal.__FPostProcessSpecIsNeedPostEffectRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPostProcessSpecIsNeedPostEffectRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->VisibleForProtoPlayer = VisibleForProtoPlayer;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060065A3 RID: 26019 RVA: 0x00091924 File Offset: 0x0008FB24
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<int, bool, bool> func = target as Func<int, bool, bool>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			bool _Result = func(((FPostProcessSpecIsNeedPostEffectRetVal.__FPostProcessSpecIsNeedPostEffectRetVal_DelegateParams*)__Parameters)->EntityId, ((FPostProcessSpecIsNeedPostEffectRetVal.__FPostProcessSpecIsNeedPostEffectRetVal_DelegateParams*)__Parameters)->VisibleForProtoPlayer);
			((FPostProcessSpecIsNeedPostEffectRetVal.__FPostProcessSpecIsNeedPostEffectRetVal_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x04002ABE RID: 10942
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002ABF RID: 10943
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.PostProcessSpecIsNeedPostEffectRetVal__DelegateSignature";

		// Token: 0x04002AC0 RID: 10944
		private static int RegisterId;

		// Token: 0x02000B0F RID: 2831
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FPostProcessSpecIsNeedPostEffectRetVal_DelegateParams
		{
			// Token: 0x04005BAF RID: 23471
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04005BB0 RID: 23472
			[FieldOffset(4)]
			public bool VisibleForProtoPlayer;

			// Token: 0x04005BB1 RID: 23473
			[FieldOffset(5)]
			public bool __Result;
		}

		// Token: 0x02000B10 RID: 2832
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005BB2 RID: 23474
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
