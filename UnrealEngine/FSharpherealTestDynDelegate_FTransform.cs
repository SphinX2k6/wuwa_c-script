using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002733 RID: 10035
	public sealed class FSharpherealTestDynDelegate_FTransform : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06025296 RID: 152214 RVA: 0x00370B50 File Offset: 0x0036ED50
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealTestDynDelegate_FTransform.StaticFunctionPtr();
		}

		// Token: 0x06025297 RID: 152215 RVA: 0x00370B5C File Offset: 0x0036ED5C
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealTestDynDelegate_FTransform._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealTestDynDelegate_FTransform._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SharpherealTest.SharpherealTestDynDelegate_FTransform__DelegateSignature");
			}
			return FSharpherealTestDynDelegate_FTransform._FunctionPtr;
		}

		// Token: 0x06025298 RID: 152216 RVA: 0x00370B7F File Offset: 0x0036ED7F
		public FSharpherealTestDynDelegate_FTransform()
		{
		}

		// Token: 0x06025299 RID: 152217 RVA: 0x00370B87 File Offset: 0x0036ED87
		[NullableContext(2)]
		public FSharpherealTestDynDelegate_FTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602529A RID: 152218 RVA: 0x00370B91 File Offset: 0x0036ED91
		public FSharpherealTestDynDelegate_FTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602529B RID: 152219 RVA: 0x00370B9C File Offset: 0x0036ED9C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<FTransform, FTransform, FTransform>) ?? ((Func<FTransform, FTransform, FTransform>)Delegate.CreateDelegate(typeof(Func<FTransform, FTransform, FTransform>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602529C RID: 152220 RVA: 0x00370BCE File Offset: 0x0036EDCE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Func<FTransform, FTransform, FTransform> Callback)
		{
			if (FSharpherealTestDynDelegate_FTransform.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSharpherealTestDynDelegate_FTransform.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSharpherealTestDynDelegate_FTransform.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSharpherealTestDynDelegate_FTransform.OnScriptCallback));
				}
				FSharpherealTestDynDelegate_FTransform.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSharpherealTestDynDelegate_FTransform.RegisterId);
		}

		// Token: 0x0602529D RID: 152221 RVA: 0x00370C08 File Offset: 0x0036EE08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FTransform Execute(in FTransform A, in FTransform B)
		{
			FSharpherealTestDynDelegate_FTransform.__FSharpherealTestDynDelegate_FTransform_DelegateParams* ptr = stackalloc FSharpherealTestDynDelegate_FTransform.__FSharpherealTestDynDelegate_FTransform_DelegateParams[(UIntPtr)159] + 15L / (long)sizeof(FSharpherealTestDynDelegate_FTransform.__FSharpherealTestDynDelegate_FTransform_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSharpherealTestDynDelegate_FTransform.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->A = A;
			ptr->B = B;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602529E RID: 152222 RVA: 0x00370C60 File Offset: 0x0036EE60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<FTransform, FTransform, FTransform> func = target as Func<FTransform, FTransform, FTransform>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FTransform _Result = func(((FSharpherealTestDynDelegate_FTransform.__FSharpherealTestDynDelegate_FTransform_DelegateParams*)__Parameters)->A, ((FSharpherealTestDynDelegate_FTransform.__FSharpherealTestDynDelegate_FTransform_DelegateParams*)__Parameters)->B);
			((FSharpherealTestDynDelegate_FTransform.__FSharpherealTestDynDelegate_FTransform_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x0401407D RID: 82045
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401407E RID: 82046
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestDynDelegate_FTransform__DelegateSignature";

		// Token: 0x0401407F RID: 82047
		private static int RegisterId;

		// Token: 0x020036BF RID: 14015
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __FSharpherealTestDynDelegate_FTransform_DelegateParams
		{
			// Token: 0x040177DC RID: 96220
			[FieldOffset(0)]
			public FTransform A;

			// Token: 0x040177DD RID: 96221
			[FieldOffset(48)]
			public FTransform B;

			// Token: 0x040177DE RID: 96222
			[FieldOffset(96)]
			public FTransform __Result;
		}

		// Token: 0x020036C0 RID: 14016
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040177DF RID: 96223
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
