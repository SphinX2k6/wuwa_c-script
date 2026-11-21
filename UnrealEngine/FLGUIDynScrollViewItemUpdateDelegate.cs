using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000691 RID: 1681
	public sealed class FLGUIDynScrollViewItemUpdateDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009107 RID: 37127 RVA: 0x000DA39A File Offset: 0x000D859A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDynScrollViewItemUpdateDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009108 RID: 37128 RVA: 0x000DA3A6 File Offset: 0x000D85A6
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDynScrollViewItemUpdateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDynScrollViewItemUpdateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDynScrollViewItemUpdateDelegate__DelegateSignature");
			}
			return FLGUIDynScrollViewItemUpdateDelegate._FunctionPtr;
		}

		// Token: 0x06009109 RID: 37129 RVA: 0x000DA3C9 File Offset: 0x000D85C9
		public FLGUIDynScrollViewItemUpdateDelegate()
		{
		}

		// Token: 0x0600910A RID: 37130 RVA: 0x000DA3D1 File Offset: 0x000D85D1
		[NullableContext(2)]
		public FLGUIDynScrollViewItemUpdateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600910B RID: 37131 RVA: 0x000DA3DB File Offset: 0x000D85DB
		public FLGUIDynScrollViewItemUpdateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600910C RID: 37132 RVA: 0x000DA3E6 File Offset: 0x000D85E6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int, AUIBaseActor, AUIBaseActor>) ?? ((Func<int, AUIBaseActor, AUIBaseActor>)Delegate.CreateDelegate(typeof(Func<int, AUIBaseActor, AUIBaseActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600910D RID: 37133 RVA: 0x000DA418 File Offset: 0x000D8618
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

		// Token: 0x0600910E RID: 37134 RVA: 0x000DA454 File Offset: 0x000D8654
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe AUIBaseActor Execute(int Index, AUIBaseActor Actor)
		{
			FLGUIDynScrollViewItemUpdateDelegate.__FLGUIDynScrollViewItemUpdateDelegate_DelegateParams* ptr = stackalloc FLGUIDynScrollViewItemUpdateDelegate.__FLGUIDynScrollViewItemUpdateDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FLGUIDynScrollViewItemUpdateDelegate.__FLGUIDynScrollViewItemUpdateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDynScrollViewItemUpdateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Index = Index;
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(ptr->__Result);
		}

		// Token: 0x0600910F RID: 37135 RVA: 0x000DA4B4 File Offset: 0x000D86B4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003F4C RID: 16204
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F4D RID: 16205
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDynScrollViewItemUpdateDelegate__DelegateSignature";

		// Token: 0x04003F4E RID: 16206
		private static int RegisterId;

		// Token: 0x02000EB5 RID: 3765
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FLGUIDynScrollViewItemUpdateDelegate_DelegateParams
		{
			// Token: 0x04006267 RID: 25191
			[FieldOffset(0)]
			public int Index;

			// Token: 0x04006268 RID: 25192
			[FieldOffset(8)]
			public IntPtr Actor;

			// Token: 0x04006269 RID: 25193
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02000EB6 RID: 3766
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400626A RID: 25194
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
