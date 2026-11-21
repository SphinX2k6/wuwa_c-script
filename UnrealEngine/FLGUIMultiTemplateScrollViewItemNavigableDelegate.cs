using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006A6 RID: 1702
	public sealed class FLGUIMultiTemplateScrollViewItemNavigableDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600926B RID: 37483 RVA: 0x000DC923 File Offset: 0x000DAB23
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIMultiTemplateScrollViewItemNavigableDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600926C RID: 37484 RVA: 0x000DC92F File Offset: 0x000DAB2F
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIMultiTemplateScrollViewItemNavigableDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIMultiTemplateScrollViewItemNavigableDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIMultiTemplateScrollViewItemNavigableDelegate__DelegateSignature");
			}
			return FLGUIMultiTemplateScrollViewItemNavigableDelegate._FunctionPtr;
		}

		// Token: 0x0600926D RID: 37485 RVA: 0x000DC952 File Offset: 0x000DAB52
		public FLGUIMultiTemplateScrollViewItemNavigableDelegate()
		{
		}

		// Token: 0x0600926E RID: 37486 RVA: 0x000DC95A File Offset: 0x000DAB5A
		[NullableContext(2)]
		public FLGUIMultiTemplateScrollViewItemNavigableDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600926F RID: 37487 RVA: 0x000DC964 File Offset: 0x000DAB64
		public FLGUIMultiTemplateScrollViewItemNavigableDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009270 RID: 37488 RVA: 0x000DC96F File Offset: 0x000DAB6F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int, bool>) ?? ((Func<int, bool>)Delegate.CreateDelegate(typeof(Func<int, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009271 RID: 37489 RVA: 0x000DC9A1 File Offset: 0x000DABA1
		[NullableContext(1)]
		public void Bind(Func<int, bool> Callback)
		{
			if (FLGUIMultiTemplateScrollViewItemNavigableDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIMultiTemplateScrollViewItemNavigableDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIMultiTemplateScrollViewItemNavigableDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIMultiTemplateScrollViewItemNavigableDelegate.OnScriptCallback));
				}
				FLGUIMultiTemplateScrollViewItemNavigableDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIMultiTemplateScrollViewItemNavigableDelegate.RegisterId);
		}

		// Token: 0x06009272 RID: 37490 RVA: 0x000DC9DC File Offset: 0x000DABDC
		[SkipLocalsInit]
		public unsafe bool Execute(int GridIndex)
		{
			FLGUIMultiTemplateScrollViewItemNavigableDelegate.__FLGUIMultiTemplateScrollViewItemNavigableDelegate_DelegateParams* ptr = stackalloc FLGUIMultiTemplateScrollViewItemNavigableDelegate.__FLGUIMultiTemplateScrollViewItemNavigableDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIMultiTemplateScrollViewItemNavigableDelegate.__FLGUIMultiTemplateScrollViewItemNavigableDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIMultiTemplateScrollViewItemNavigableDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->GridIndex = GridIndex;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06009273 RID: 37491 RVA: 0x000DCA20 File Offset: 0x000DAC20
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<int, bool> func = target as Func<int, bool>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			bool _Result = func(((FLGUIMultiTemplateScrollViewItemNavigableDelegate.__FLGUIMultiTemplateScrollViewItemNavigableDelegate_DelegateParams*)__Parameters)->GridIndex);
			((FLGUIMultiTemplateScrollViewItemNavigableDelegate.__FLGUIMultiTemplateScrollViewItemNavigableDelegate_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x04003FD9 RID: 16345
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003FDA RID: 16346
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIMultiTemplateScrollViewItemNavigableDelegate__DelegateSignature";

		// Token: 0x04003FDB RID: 16347
		private static int RegisterId;

		// Token: 0x02000ED1 RID: 3793
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FLGUIMultiTemplateScrollViewItemNavigableDelegate_DelegateParams
		{
			// Token: 0x0400628F RID: 25231
			[FieldOffset(0)]
			public int GridIndex;

			// Token: 0x04006290 RID: 25232
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02000ED2 RID: 3794
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006291 RID: 25233
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
