using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200206B RID: 8299
	public sealed class FLGUIDynScrollViewItemSizeDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F4F0 RID: 128240 RVA: 0x002E7F47 File Offset: 0x002E6147
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDynScrollViewItemSizeDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F4F1 RID: 128241 RVA: 0x002E7F53 File Offset: 0x002E6153
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDynScrollViewItemSizeDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDynScrollViewItemSizeDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDynScrollViewItemSizeDelegate__DelegateSignature");
			}
			return FLGUIDynScrollViewItemSizeDelegate._FunctionPtr;
		}

		// Token: 0x0601F4F2 RID: 128242 RVA: 0x002E7F76 File Offset: 0x002E6176
		public FLGUIDynScrollViewItemSizeDelegate()
		{
		}

		// Token: 0x0601F4F3 RID: 128243 RVA: 0x002E7F7E File Offset: 0x002E617E
		[NullableContext(2)]
		public FLGUIDynScrollViewItemSizeDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F4F4 RID: 128244 RVA: 0x002E7F88 File Offset: 0x002E6188
		public FLGUIDynScrollViewItemSizeDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F4F5 RID: 128245 RVA: 0x002E7F93 File Offset: 0x002E6193
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int, FVector2D>) ?? ((Func<int, FVector2D>)Delegate.CreateDelegate(typeof(Func<int, FVector2D>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F4F6 RID: 128246 RVA: 0x002E7FC5 File Offset: 0x002E61C5
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Func<int, FVector2D> Callback)
		{
			if (FLGUIDynScrollViewItemSizeDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDynScrollViewItemSizeDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDynScrollViewItemSizeDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDynScrollViewItemSizeDelegate.OnScriptCallback));
				}
				FLGUIDynScrollViewItemSizeDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDynScrollViewItemSizeDelegate.RegisterId);
		}

		// Token: 0x0601F4F7 RID: 128247 RVA: 0x002E8000 File Offset: 0x002E6200
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FVector2D Execute(int Index)
		{
			FLGUIDynScrollViewItemSizeDelegate.__FLGUIDynScrollViewItemSizeDelegate_DelegateParams* ptr = stackalloc FLGUIDynScrollViewItemSizeDelegate.__FLGUIDynScrollViewItemSizeDelegate_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FLGUIDynScrollViewItemSizeDelegate.__FLGUIDynScrollViewItemSizeDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDynScrollViewItemSizeDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Index = Index;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F4F8 RID: 128248 RVA: 0x002E8044 File Offset: 0x002E6244
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<int, FVector2D> func = target as Func<int, FVector2D>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FVector2D _Result = func(((FLGUIDynScrollViewItemSizeDelegate.__FLGUIDynScrollViewItemSizeDelegate_DelegateParams*)__Parameters)->Index);
			((FLGUIDynScrollViewItemSizeDelegate.__FLGUIDynScrollViewItemSizeDelegate_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x04010ED1 RID: 69329
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010ED2 RID: 69330
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDynScrollViewItemSizeDelegate__DelegateSignature";

		// Token: 0x04010ED3 RID: 69331
		private static int RegisterId;

		// Token: 0x02003470 RID: 13424
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FLGUIDynScrollViewItemSizeDelegate_DelegateParams
		{
			// Token: 0x04017455 RID: 95317
			[FieldOffset(0)]
			public int Index;

			// Token: 0x04017456 RID: 95318
			[FieldOffset(4)]
			public FVector2D __Result;
		}

		// Token: 0x02003471 RID: 13425
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017457 RID: 95319
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
