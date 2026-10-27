using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000918 RID: 2328
	[UnrealObjectPath("/Script/Engine.CancellableAsyncAction")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UCancellableAsyncAction : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008014 RID: 32788 RVA: 0x000B7767 File Offset: 0x000B5967
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCancellableAsyncAction._ClassPtr;
		}

		// Token: 0x06008015 RID: 32789 RVA: 0x000B7773 File Offset: 0x000B5973
		public bool IsActive()
		{
			return UCancellableAsyncAction.__IsActive_Internal(base.NativePtr);
		}

		// Token: 0x06008016 RID: 32790 RVA: 0x000B7780 File Offset: 0x000B5980
		public void Cancel()
		{
			UCancellableAsyncAction.__Cancel_Internal(base.NativePtr);
		}

		// Token: 0x06008017 RID: 32791
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsActive_Internal(IntPtr @this);

		// Token: 0x06008018 RID: 32792
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Cancel_Internal(IntPtr @this);

		// Token: 0x06008019 RID: 32793 RVA: 0x000B778D File Offset: 0x000B598D
		static UCancellableAsyncAction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CancellableAsyncAction");
		}

		// Token: 0x0600801A RID: 32794 RVA: 0x000B779C File Offset: 0x000B599C
		protected UCancellableAsyncAction() : this(BuiltinUtils.AllocNativeUObject(UCancellableAsyncAction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600801B RID: 32795 RVA: 0x000B77C4 File Offset: 0x000B59C4
		protected UCancellableAsyncAction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003D5F RID: 15711
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CancellableAsyncAction";

		// Token: 0x04003D60 RID: 15712
		private static IntPtr _ClassPtr;

		// Token: 0x04003D61 RID: 15713
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
