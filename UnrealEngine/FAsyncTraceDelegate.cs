using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000367 RID: 871
	public sealed class FAsyncTraceDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060058B5 RID: 22709 RVA: 0x0007CF40 File Offset: 0x0007B140
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAsyncTraceDelegate.StaticFunctionPtr();
		}

		// Token: 0x060058B6 RID: 22710 RVA: 0x0007CF4C File Offset: 0x0007B14C
		private static IntPtr StaticFunctionPtr()
		{
			if (FAsyncTraceDelegate._FunctionPtr == IntPtr.Zero)
			{
				FAsyncTraceDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroData.AsyncTraceDelegate__DelegateSignature");
			}
			return FAsyncTraceDelegate._FunctionPtr;
		}

		// Token: 0x060058B7 RID: 22711 RVA: 0x0007CF6F File Offset: 0x0007B16F
		public FAsyncTraceDelegate()
		{
		}

		// Token: 0x060058B8 RID: 22712 RVA: 0x0007CF77 File Offset: 0x0007B177
		[NullableContext(2)]
		public FAsyncTraceDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060058B9 RID: 22713 RVA: 0x0007CF81 File Offset: 0x0007B181
		public FAsyncTraceDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060058BA RID: 22714 RVA: 0x0007CF8C File Offset: 0x0007B18C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool, UTraceBaseElement, double, double>) ?? ((Action<bool, UTraceBaseElement, double, double>)Delegate.CreateDelegate(typeof(Action<bool, UTraceBaseElement, double, double>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060058BB RID: 22715 RVA: 0x0007CFBE File Offset: 0x0007B1BE
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<bool, UTraceBaseElement, double, double> Callback)
		{
			if (FAsyncTraceDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAsyncTraceDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAsyncTraceDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAsyncTraceDelegate.OnScriptCallback));
				}
				FAsyncTraceDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FAsyncTraceDelegate.RegisterId);
		}

		// Token: 0x060058BC RID: 22716 RVA: 0x0007CFF8 File Offset: 0x0007B1F8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(bool Result, UTraceBaseElement Element, double Frame, double Index)
		{
			FAsyncTraceDelegate.__FAsyncTraceDelegate_DelegateParams* ptr = stackalloc FAsyncTraceDelegate.__FAsyncTraceDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FAsyncTraceDelegate.__FAsyncTraceDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FAsyncTraceDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Result = Result;
			ptr->Element = ((Element != null) ? Element.NativePtr : IntPtr.Zero);
			ptr->Frame = Frame;
			ptr->Index = Index;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060058BD RID: 22717 RVA: 0x0007D05C File Offset: 0x0007B25C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, UTraceBaseElement, double, double> action = target as Action<bool, UTraceBaseElement, double, double>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UTraceBaseElement orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTraceBaseElement>(((FAsyncTraceDelegate.__FAsyncTraceDelegate_DelegateParams*)__Parameters)->Element);
			action(((FAsyncTraceDelegate.__FAsyncTraceDelegate_DelegateParams*)__Parameters)->Result, orCreateUObjectByNativePointer, ((FAsyncTraceDelegate.__FAsyncTraceDelegate_DelegateParams*)__Parameters)->Frame, ((FAsyncTraceDelegate.__FAsyncTraceDelegate_DelegateParams*)__Parameters)->Index);
		}

		// Token: 0x040024A1 RID: 9377
		internal static IntPtr _FunctionPtr;

		// Token: 0x040024A2 RID: 9378
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroData.AsyncTraceDelegate__DelegateSignature";

		// Token: 0x040024A3 RID: 9379
		private static int RegisterId;

		// Token: 0x02000A7B RID: 2683
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FAsyncTraceDelegate_DelegateParams
		{
			// Token: 0x04005AB8 RID: 23224
			[FieldOffset(0)]
			public bool Result;

			// Token: 0x04005AB9 RID: 23225
			[FieldOffset(8)]
			public IntPtr Element;

			// Token: 0x04005ABA RID: 23226
			[FieldOffset(16)]
			public double Frame;

			// Token: 0x04005ABB RID: 23227
			[FieldOffset(24)]
			public double Index;
		}

		// Token: 0x02000A7C RID: 2684
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005ABC RID: 23228
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
