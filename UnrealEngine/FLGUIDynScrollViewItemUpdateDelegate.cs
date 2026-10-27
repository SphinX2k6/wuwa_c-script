using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200206C RID: 8300
	public sealed class FLGUIDynScrollViewItemUpdateDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F4F9 RID: 128249 RVA: 0x002E8096 File Offset: 0x002E6296
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDynScrollViewItemUpdateDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F4FA RID: 128250 RVA: 0x002E80A2 File Offset: 0x002E62A2
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDynScrollViewItemUpdateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDynScrollViewItemUpdateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDynScrollViewItemUpdateDelegate__DelegateSignature");
			}
			return FLGUIDynScrollViewItemUpdateDelegate._FunctionPtr;
		}

		// Token: 0x0601F4FB RID: 128251 RVA: 0x002E80C5 File Offset: 0x002E62C5
		public FLGUIDynScrollViewItemUpdateDelegate()
		{
		}

		// Token: 0x0601F4FC RID: 128252 RVA: 0x002E80CD File Offset: 0x002E62CD
		[NullableContext(2)]
		public FLGUIDynScrollViewItemUpdateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F4FD RID: 128253 RVA: 0x002E80D7 File Offset: 0x002E62D7
		public FLGUIDynScrollViewItemUpdateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F4FE RID: 128254 RVA: 0x002E80E2 File Offset: 0x002E62E2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int, AUIBaseActor, AUIBaseActor>) ?? ((Func<int, AUIBaseActor, AUIBaseActor>)Delegate.CreateDelegate(typeof(Func<int, AUIBaseActor, AUIBaseActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F4FF RID: 128255 RVA: 0x002E8114 File Offset: 0x002E6314
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Func<int, AUIBaseActor, AUIBaseActor> Callback)
		{
			if (FLGUIDynScrollViewItemUpdateDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDynScrollViewItemUpdateDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDynScrollViewItemUpdateDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDynScrollViewItemUpdateDelegate.OnScriptCallback));
				}
				FLGUIDynScrollViewItemUpdateDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDynScrollViewItemUpdateDelegate.RegisterId);
		}

		// Token: 0x0601F500 RID: 128256 RVA: 0x002E8150 File Offset: 0x002E6350
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe AUIBaseActor Execute(int Index, AUIBaseActor Actor)
		{
			FLGUIDynScrollViewItemUpdateDelegate.__FLGUIDynScrollViewItemUpdateDelegate_DelegateParams* ptr = stackalloc FLGUIDynScrollViewItemUpdateDelegate.__FLGUIDynScrollViewItemUpdateDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FLGUIDynScrollViewItemUpdateDelegate.__FLGUIDynScrollViewItemUpdateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDynScrollViewItemUpdateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Index = Index;
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(ptr->__Result);
		}

		// Token: 0x0601F501 RID: 128257 RVA: 0x002E81B0 File Offset: 0x002E63B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<int, AUIBaseActor, AUIBaseActor> func = target as Func<int, AUIBaseActor, AUIBaseActor>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AUIBaseActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(((FLGUIDynScrollViewItemUpdateDelegate.__FLGUIDynScrollViewItemUpdateDelegate_DelegateParams*)__Parameters)->Actor);
			AUIBaseActor auibaseActor = func(((FLGUIDynScrollViewItemUpdateDelegate.__FLGUIDynScrollViewItemUpdateDelegate_DelegateParams*)__Parameters)->Index, orCreateUObjectByNativePointer);
			((FLGUIDynScrollViewItemUpdateDelegate.__FLGUIDynScrollViewItemUpdateDelegate_DelegateParams*)__Parameters)->__Result = ((auibaseActor != null) ? auibaseActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x04010ED4 RID: 69332
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010ED5 RID: 69333
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDynScrollViewItemUpdateDelegate__DelegateSignature";

		// Token: 0x04010ED6 RID: 69334
		private static int RegisterId;

		// Token: 0x02003472 RID: 13426
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FLGUIDynScrollViewItemUpdateDelegate_DelegateParams
		{
			// Token: 0x04017458 RID: 95320
			[FieldOffset(0)]
			public int Index;

			// Token: 0x04017459 RID: 95321
			[FieldOffset(8)]
			public IntPtr Actor;

			// Token: 0x0401745A RID: 95322
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02003473 RID: 13427
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401745B RID: 95323
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
