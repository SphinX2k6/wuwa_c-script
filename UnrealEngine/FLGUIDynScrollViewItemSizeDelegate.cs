using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000690 RID: 1680
	public sealed class FLGUIDynScrollViewItemSizeDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060090FE RID: 37118 RVA: 0x000DA24B File Offset: 0x000D844B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDynScrollViewItemSizeDelegate.StaticFunctionPtr();
		}

		// Token: 0x060090FF RID: 37119 RVA: 0x000DA257 File Offset: 0x000D8457
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDynScrollViewItemSizeDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDynScrollViewItemSizeDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDynScrollViewItemSizeDelegate__DelegateSignature");
			}
			return FLGUIDynScrollViewItemSizeDelegate._FunctionPtr;
		}

		// Token: 0x06009100 RID: 37120 RVA: 0x000DA27A File Offset: 0x000D847A
		public FLGUIDynScrollViewItemSizeDelegate()
		{
		}

		// Token: 0x06009101 RID: 37121 RVA: 0x000DA282 File Offset: 0x000D8482
		[NullableContext(2)]
		public FLGUIDynScrollViewItemSizeDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009102 RID: 37122 RVA: 0x000DA28C File Offset: 0x000D848C
		public FLGUIDynScrollViewItemSizeDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009103 RID: 37123 RVA: 0x000DA297 File Offset: 0x000D8497
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int, FVector2D>) ?? ((Func<int, FVector2D>)Delegate.CreateDelegate(typeof(Func<int, FVector2D>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009104 RID: 37124 RVA: 0x000DA2C9 File Offset: 0x000D84C9
		[NullableContext(1)]
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

		// Token: 0x06009105 RID: 37125 RVA: 0x000DA304 File Offset: 0x000D8504
		[SkipLocalsInit]
		public unsafe FVector2D Execute(int Index)
		{
			FLGUIDynScrollViewItemSizeDelegate.__FLGUIDynScrollViewItemSizeDelegate_DelegateParams* ptr = stackalloc FLGUIDynScrollViewItemSizeDelegate.__FLGUIDynScrollViewItemSizeDelegate_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FLGUIDynScrollViewItemSizeDelegate.__FLGUIDynScrollViewItemSizeDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDynScrollViewItemSizeDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Index = Index;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06009106 RID: 37126 RVA: 0x000DA348 File Offset: 0x000D8548
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003F49 RID: 16201
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F4A RID: 16202
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDynScrollViewItemSizeDelegate__DelegateSignature";

		// Token: 0x04003F4B RID: 16203
		private static int RegisterId;

		// Token: 0x02000EB3 RID: 3763
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		private ref struct __FLGUIDynScrollViewItemSizeDelegate_DelegateParams
		{
			// Token: 0x04006264 RID: 25188
			[FieldOffset(0)]
			public int Index;

			// Token: 0x04006265 RID: 25189
			[FieldOffset(4)]
			public FVector2D __Result;
		}

		// Token: 0x02000EB4 RID: 3764
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006266 RID: 25190
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
