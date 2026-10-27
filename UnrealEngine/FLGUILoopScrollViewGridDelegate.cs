using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002085 RID: 8325
	public sealed class FLGUILoopScrollViewGridDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F678 RID: 128632 RVA: 0x002EA3CF File Offset: 0x002E85CF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUILoopScrollViewGridDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F679 RID: 128633 RVA: 0x002EA3DB File Offset: 0x002E85DB
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUILoopScrollViewGridDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUILoopScrollViewGridDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUILoopScrollViewGridDelegate__DelegateSignature");
			}
			return FLGUILoopScrollViewGridDelegate._FunctionPtr;
		}

		// Token: 0x0601F67A RID: 128634 RVA: 0x002EA3FE File Offset: 0x002E85FE
		public FLGUILoopScrollViewGridDelegate()
		{
		}

		// Token: 0x0601F67B RID: 128635 RVA: 0x002EA406 File Offset: 0x002E8606
		[NullableContext(2)]
		public FLGUILoopScrollViewGridDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F67C RID: 128636 RVA: 0x002EA410 File Offset: 0x002E8610
		public FLGUILoopScrollViewGridDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F67D RID: 128637 RVA: 0x002EA41B File Offset: 0x002E861B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F67E RID: 128638 RVA: 0x002EA44D File Offset: 0x002E864D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int, int> Callback)
		{
			if (FLGUILoopScrollViewGridDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUILoopScrollViewGridDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUILoopScrollViewGridDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUILoopScrollViewGridDelegate.OnScriptCallback));
				}
				FLGUILoopScrollViewGridDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUILoopScrollViewGridDelegate.RegisterId);
		}

		// Token: 0x0601F67F RID: 128639 RVA: 0x002EA488 File Offset: 0x002E8688
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int StartIndex, int EndIndex)
		{
			FLGUILoopScrollViewGridDelegate.__FLGUILoopScrollViewGridDelegate_DelegateParams* ptr = stackalloc FLGUILoopScrollViewGridDelegate.__FLGUILoopScrollViewGridDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUILoopScrollViewGridDelegate.__FLGUILoopScrollViewGridDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUILoopScrollViewGridDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->StartIndex = StartIndex;
			ptr->EndIndex = EndIndex;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F680 RID: 128640 RVA: 0x002EA4CC File Offset: 0x002E86CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUILoopScrollViewGridDelegate.__FLGUILoopScrollViewGridDelegate_DelegateParams*)__Parameters)->StartIndex, ((FLGUILoopScrollViewGridDelegate.__FLGUILoopScrollViewGridDelegate_DelegateParams*)__Parameters)->EndIndex);
		}

		// Token: 0x04010F5E RID: 69470
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010F5F RID: 69471
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUILoopScrollViewGridDelegate__DelegateSignature";

		// Token: 0x04010F60 RID: 69472
		private static int RegisterId;

		// Token: 0x02003488 RID: 13448
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FLGUILoopScrollViewGridDelegate_DelegateParams
		{
			// Token: 0x04017477 RID: 95351
			[FieldOffset(0)]
			public int StartIndex;

			// Token: 0x04017478 RID: 95352
			[FieldOffset(4)]
			public int EndIndex;
		}

		// Token: 0x02003489 RID: 13449
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017479 RID: 95353
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
