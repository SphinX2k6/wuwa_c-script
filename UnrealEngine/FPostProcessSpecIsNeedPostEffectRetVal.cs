using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001931 RID: 6449
	public sealed class FPostProcessSpecIsNeedPostEffectRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017E8F RID: 97935 RVA: 0x002309FA File Offset: 0x0022EBFA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPostProcessSpecIsNeedPostEffectRetVal.StaticFunctionPtr();
		}

		// Token: 0x06017E90 RID: 97936 RVA: 0x00230A06 File Offset: 0x0022EC06
		private static IntPtr StaticFunctionPtr()
		{
			if (FPostProcessSpecIsNeedPostEffectRetVal._FunctionPtr == IntPtr.Zero)
			{
				FPostProcessSpecIsNeedPostEffectRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.PostProcessSpecIsNeedPostEffectRetVal__DelegateSignature");
			}
			return FPostProcessSpecIsNeedPostEffectRetVal._FunctionPtr;
		}

		// Token: 0x06017E91 RID: 97937 RVA: 0x00230A29 File Offset: 0x0022EC29
		public FPostProcessSpecIsNeedPostEffectRetVal()
		{
		}

		// Token: 0x06017E92 RID: 97938 RVA: 0x00230A31 File Offset: 0x0022EC31
		[NullableContext(2)]
		public FPostProcessSpecIsNeedPostEffectRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017E93 RID: 97939 RVA: 0x00230A3B File Offset: 0x0022EC3B
		public FPostProcessSpecIsNeedPostEffectRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017E94 RID: 97940 RVA: 0x00230A46 File Offset: 0x0022EC46
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int, bool, bool>) ?? ((Func<int, bool, bool>)Delegate.CreateDelegate(typeof(Func<int, bool, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017E95 RID: 97941 RVA: 0x00230A78 File Offset: 0x0022EC78
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06017E96 RID: 97942 RVA: 0x00230AB4 File Offset: 0x0022ECB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool Execute(int EntityId, bool VisibleForProtoPlayer)
		{
			FPostProcessSpecIsNeedPostEffectRetVal.__FPostProcessSpecIsNeedPostEffectRetVal_DelegateParams* ptr = stackalloc FPostProcessSpecIsNeedPostEffectRetVal.__FPostProcessSpecIsNeedPostEffectRetVal_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FPostProcessSpecIsNeedPostEffectRetVal.__FPostProcessSpecIsNeedPostEffectRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPostProcessSpecIsNeedPostEffectRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->VisibleForProtoPlayer = VisibleForProtoPlayer;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06017E97 RID: 97943 RVA: 0x00230B00 File Offset: 0x0022ED00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400CF24 RID: 53028
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CF25 RID: 53029
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.PostProcessSpecIsNeedPostEffectRetVal__DelegateSignature";

		// Token: 0x0400CF26 RID: 53030
		private static int RegisterId;

		// Token: 0x02002FFB RID: 12283
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FPostProcessSpecIsNeedPostEffectRetVal_DelegateParams
		{
			// Token: 0x04016C06 RID: 93190
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04016C07 RID: 93191
			[FieldOffset(4)]
			public bool VisibleForProtoPlayer;

			// Token: 0x04016C08 RID: 93192
			[FieldOffset(5)]
			public bool __Result;
		}

		// Token: 0x02002FFC RID: 12284
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016C09 RID: 93193
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
