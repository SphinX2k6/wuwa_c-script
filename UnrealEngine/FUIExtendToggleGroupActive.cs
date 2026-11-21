using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000701 RID: 1793
	public sealed class FUIExtendToggleGroupActive : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060098D7 RID: 39127 RVA: 0x000E62CD File Offset: 0x000E44CD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FUIExtendToggleGroupActive.StaticFunctionPtr();
		}

		// Token: 0x060098D8 RID: 39128 RVA: 0x000E62D9 File Offset: 0x000E44D9
		private static IntPtr StaticFunctionPtr()
		{
			if (FUIExtendToggleGroupActive._FunctionPtr == IntPtr.Zero)
			{
				FUIExtendToggleGroupActive._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.UIExtendToggleGroupActive__DelegateSignature");
			}
			return FUIExtendToggleGroupActive._FunctionPtr;
		}

		// Token: 0x060098D9 RID: 39129 RVA: 0x000E62FC File Offset: 0x000E44FC
		public FUIExtendToggleGroupActive()
		{
		}

		// Token: 0x060098DA RID: 39130 RVA: 0x000E6304 File Offset: 0x000E4504
		[NullableContext(2)]
		public FUIExtendToggleGroupActive(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060098DB RID: 39131 RVA: 0x000E630E File Offset: 0x000E450E
		public FUIExtendToggleGroupActive(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060098DC RID: 39132 RVA: 0x000E6319 File Offset: 0x000E4519
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UUIExtendToggleGroup, bool>) ?? ((Action<UUIExtendToggleGroup, bool>)Delegate.CreateDelegate(typeof(Action<UUIExtendToggleGroup, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060098DD RID: 39133 RVA: 0x000E634B File Offset: 0x000E454B
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UUIExtendToggleGroup, bool> Callback)
		{
			if (FUIExtendToggleGroupActive.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FUIExtendToggleGroupActive.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FUIExtendToggleGroupActive.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FUIExtendToggleGroupActive.OnScriptCallback));
				}
				FUIExtendToggleGroupActive.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FUIExtendToggleGroupActive.RegisterId);
		}

		// Token: 0x060098DE RID: 39134 RVA: 0x000E6388 File Offset: 0x000E4588
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(UUIExtendToggleGroup ExtendToggleGroup, bool bCreate)
		{
			FUIExtendToggleGroupActive.__FUIExtendToggleGroupActive_DelegateParams* ptr = stackalloc FUIExtendToggleGroupActive.__FUIExtendToggleGroupActive_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FUIExtendToggleGroupActive.__FUIExtendToggleGroupActive_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FUIExtendToggleGroupActive.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ExtendToggleGroup = ((ExtendToggleGroup != null) ? ExtendToggleGroup.NativePtr : IntPtr.Zero);
			ptr->bCreate = bCreate;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060098DF RID: 39135 RVA: 0x000E63DC File Offset: 0x000E45DC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UUIExtendToggleGroup, bool> action = target as Action<UUIExtendToggleGroup, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UUIExtendToggleGroup orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIExtendToggleGroup>(((FUIExtendToggleGroupActive.__FUIExtendToggleGroupActive_DelegateParams*)__Parameters)->ExtendToggleGroup);
			action(orCreateUObjectByNativePointer, ((FUIExtendToggleGroupActive.__FUIExtendToggleGroupActive_DelegateParams*)__Parameters)->bCreate);
		}

		// Token: 0x04004271 RID: 17009
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004272 RID: 17010
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.UIExtendToggleGroupActive__DelegateSignature";

		// Token: 0x04004273 RID: 17011
		private static int RegisterId;

		// Token: 0x02000F1B RID: 3867
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FUIExtendToggleGroupActive_DelegateParams
		{
			// Token: 0x040062EA RID: 25322
			[FieldOffset(0)]
			public IntPtr ExtendToggleGroup;

			// Token: 0x040062EB RID: 25323
			[FieldOffset(8)]
			public bool bCreate;
		}

		// Token: 0x02000F1C RID: 3868
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062EC RID: 25324
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
