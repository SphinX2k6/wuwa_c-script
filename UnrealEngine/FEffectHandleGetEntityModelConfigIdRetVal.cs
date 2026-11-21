using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003BB RID: 955
	public sealed class FEffectHandleGetEntityModelConfigIdRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005D8D RID: 23949 RVA: 0x00084320 File Offset: 0x00082520
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectHandleGetEntityModelConfigIdRetVal.StaticFunctionPtr();
		}

		// Token: 0x06005D8E RID: 23950 RVA: 0x0008432C File Offset: 0x0008252C
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectHandleGetEntityModelConfigIdRetVal._FunctionPtr == IntPtr.Zero)
			{
				FEffectHandleGetEntityModelConfigIdRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectHandleGetEntityModelConfigIdRetVal__DelegateSignature");
			}
			return FEffectHandleGetEntityModelConfigIdRetVal._FunctionPtr;
		}

		// Token: 0x06005D8F RID: 23951 RVA: 0x0008434F File Offset: 0x0008254F
		public FEffectHandleGetEntityModelConfigIdRetVal()
		{
		}

		// Token: 0x06005D90 RID: 23952 RVA: 0x00084357 File Offset: 0x00082557
		[NullableContext(2)]
		public FEffectHandleGetEntityModelConfigIdRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D91 RID: 23953 RVA: 0x00084361 File Offset: 0x00082561
		public FEffectHandleGetEntityModelConfigIdRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D92 RID: 23954 RVA: 0x0008436C File Offset: 0x0008256C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int, int>) ?? ((Func<int, int>)Delegate.CreateDelegate(typeof(Func<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005D93 RID: 23955 RVA: 0x0008439E File Offset: 0x0008259E
		[NullableContext(1)]
		public void Bind(Func<int, int> Callback)
		{
			if (FEffectHandleGetEntityModelConfigIdRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEffectHandleGetEntityModelConfigIdRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEffectHandleGetEntityModelConfigIdRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEffectHandleGetEntityModelConfigIdRetVal.OnScriptCallback));
				}
				FEffectHandleGetEntityModelConfigIdRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FEffectHandleGetEntityModelConfigIdRetVal.RegisterId);
		}

		// Token: 0x06005D94 RID: 23956 RVA: 0x000843D8 File Offset: 0x000825D8
		[SkipLocalsInit]
		public unsafe int Execute(int EntityId)
		{
			FEffectHandleGetEntityModelConfigIdRetVal.__FEffectHandleGetEntityModelConfigIdRetVal_DelegateParams* ptr = stackalloc FEffectHandleGetEntityModelConfigIdRetVal.__FEffectHandleGetEntityModelConfigIdRetVal_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FEffectHandleGetEntityModelConfigIdRetVal.__FEffectHandleGetEntityModelConfigIdRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEffectHandleGetEntityModelConfigIdRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06005D95 RID: 23957 RVA: 0x0008441C File Offset: 0x0008261C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<int, int> func = target as Func<int, int>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			int _Result = func(((FEffectHandleGetEntityModelConfigIdRetVal.__FEffectHandleGetEntityModelConfigIdRetVal_DelegateParams*)__Parameters)->EntityId);
			((FEffectHandleGetEntityModelConfigIdRetVal.__FEffectHandleGetEntityModelConfigIdRetVal_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x040026FD RID: 9981
		internal static IntPtr _FunctionPtr;

		// Token: 0x040026FE RID: 9982
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectHandleGetEntityModelConfigIdRetVal__DelegateSignature";

		// Token: 0x040026FF RID: 9983
		private static int RegisterId;

		// Token: 0x02000AC0 RID: 2752
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FEffectHandleGetEntityModelConfigIdRetVal_DelegateParams
		{
			// Token: 0x04005B2F RID: 23343
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04005B30 RID: 23344
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x02000AC1 RID: 2753
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B31 RID: 23345
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
