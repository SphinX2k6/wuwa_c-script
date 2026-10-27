using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200208D RID: 8333
	public sealed class FLGUIMultiTemplateScrollViewItemNavigableDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F6F1 RID: 128753 RVA: 0x002EB16F File Offset: 0x002E936F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIMultiTemplateScrollViewItemNavigableDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F6F2 RID: 128754 RVA: 0x002EB17B File Offset: 0x002E937B
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIMultiTemplateScrollViewItemNavigableDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIMultiTemplateScrollViewItemNavigableDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIMultiTemplateScrollViewItemNavigableDelegate__DelegateSignature");
			}
			return FLGUIMultiTemplateScrollViewItemNavigableDelegate._FunctionPtr;
		}

		// Token: 0x0601F6F3 RID: 128755 RVA: 0x002EB19E File Offset: 0x002E939E
		public FLGUIMultiTemplateScrollViewItemNavigableDelegate()
		{
		}

		// Token: 0x0601F6F4 RID: 128756 RVA: 0x002EB1A6 File Offset: 0x002E93A6
		[NullableContext(2)]
		public FLGUIMultiTemplateScrollViewItemNavigableDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F6F5 RID: 128757 RVA: 0x002EB1B0 File Offset: 0x002E93B0
		public FLGUIMultiTemplateScrollViewItemNavigableDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F6F6 RID: 128758 RVA: 0x002EB1BB File Offset: 0x002E93BB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int, bool>) ?? ((Func<int, bool>)Delegate.CreateDelegate(typeof(Func<int, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F6F7 RID: 128759 RVA: 0x002EB1ED File Offset: 0x002E93ED
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F6F8 RID: 128760 RVA: 0x002EB228 File Offset: 0x002E9428
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool Execute(int GridIndex)
		{
			FLGUIMultiTemplateScrollViewItemNavigableDelegate.__FLGUIMultiTemplateScrollViewItemNavigableDelegate_DelegateParams* ptr = stackalloc FLGUIMultiTemplateScrollViewItemNavigableDelegate.__FLGUIMultiTemplateScrollViewItemNavigableDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIMultiTemplateScrollViewItemNavigableDelegate.__FLGUIMultiTemplateScrollViewItemNavigableDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIMultiTemplateScrollViewItemNavigableDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->GridIndex = GridIndex;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F6F9 RID: 128761 RVA: 0x002EB26C File Offset: 0x002E946C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04010FA3 RID: 69539
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010FA4 RID: 69540
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIMultiTemplateScrollViewItemNavigableDelegate__DelegateSignature";

		// Token: 0x04010FA5 RID: 69541
		private static int RegisterId;

		// Token: 0x0200348E RID: 13454
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FLGUIMultiTemplateScrollViewItemNavigableDelegate_DelegateParams
		{
			// Token: 0x04017480 RID: 95360
			[FieldOffset(0)]
			public int GridIndex;

			// Token: 0x04017481 RID: 95361
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x0200348F RID: 13455
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017482 RID: 95362
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
