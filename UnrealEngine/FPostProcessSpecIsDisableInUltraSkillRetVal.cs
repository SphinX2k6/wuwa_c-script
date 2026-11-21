using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000417 RID: 1047
	public sealed class FPostProcessSpecIsDisableInUltraSkillRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006592 RID: 26002 RVA: 0x000916CE File Offset: 0x0008F8CE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPostProcessSpecIsDisableInUltraSkillRetVal.StaticFunctionPtr();
		}

		// Token: 0x06006593 RID: 26003 RVA: 0x000916DA File Offset: 0x0008F8DA
		private static IntPtr StaticFunctionPtr()
		{
			if (FPostProcessSpecIsDisableInUltraSkillRetVal._FunctionPtr == IntPtr.Zero)
			{
				FPostProcessSpecIsDisableInUltraSkillRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.PostProcessSpecIsDisableInUltraSkillRetVal__DelegateSignature");
			}
			return FPostProcessSpecIsDisableInUltraSkillRetVal._FunctionPtr;
		}

		// Token: 0x06006594 RID: 26004 RVA: 0x000916FD File Offset: 0x0008F8FD
		public FPostProcessSpecIsDisableInUltraSkillRetVal()
		{
		}

		// Token: 0x06006595 RID: 26005 RVA: 0x00091705 File Offset: 0x0008F905
		[NullableContext(2)]
		public FPostProcessSpecIsDisableInUltraSkillRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006596 RID: 26006 RVA: 0x0009170F File Offset: 0x0008F90F
		public FPostProcessSpecIsDisableInUltraSkillRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006597 RID: 26007 RVA: 0x0009171A File Offset: 0x0008F91A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int, bool>) ?? ((Func<int, bool>)Delegate.CreateDelegate(typeof(Func<int, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006598 RID: 26008 RVA: 0x0009174C File Offset: 0x0008F94C
		[NullableContext(1)]
		public void Bind(Func<int, bool> Callback)
		{
			if (FPostProcessSpecIsDisableInUltraSkillRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPostProcessSpecIsDisableInUltraSkillRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPostProcessSpecIsDisableInUltraSkillRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPostProcessSpecIsDisableInUltraSkillRetVal.OnScriptCallback));
				}
				FPostProcessSpecIsDisableInUltraSkillRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPostProcessSpecIsDisableInUltraSkillRetVal.RegisterId);
		}

		// Token: 0x06006599 RID: 26009 RVA: 0x00091788 File Offset: 0x0008F988
		[SkipLocalsInit]
		public unsafe bool Execute(int EntityId)
		{
			FPostProcessSpecIsDisableInUltraSkillRetVal.__FPostProcessSpecIsDisableInUltraSkillRetVal_DelegateParams* ptr = stackalloc FPostProcessSpecIsDisableInUltraSkillRetVal.__FPostProcessSpecIsDisableInUltraSkillRetVal_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FPostProcessSpecIsDisableInUltraSkillRetVal.__FPostProcessSpecIsDisableInUltraSkillRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPostProcessSpecIsDisableInUltraSkillRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600659A RID: 26010 RVA: 0x000917CC File Offset: 0x0008F9CC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<int, bool> func = target as Func<int, bool>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			bool _Result = func(((FPostProcessSpecIsDisableInUltraSkillRetVal.__FPostProcessSpecIsDisableInUltraSkillRetVal_DelegateParams*)__Parameters)->EntityId);
			((FPostProcessSpecIsDisableInUltraSkillRetVal.__FPostProcessSpecIsDisableInUltraSkillRetVal_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x04002ABB RID: 10939
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002ABC RID: 10940
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.PostProcessSpecIsDisableInUltraSkillRetVal__DelegateSignature";

		// Token: 0x04002ABD RID: 10941
		private static int RegisterId;

		// Token: 0x02000B0D RID: 2829
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FPostProcessSpecIsDisableInUltraSkillRetVal_DelegateParams
		{
			// Token: 0x04005BAC RID: 23468
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04005BAD RID: 23469
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02000B0E RID: 2830
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005BAE RID: 23470
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
