using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000837 RID: 2103
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpineAfterUpdateWorldTransformDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B786 RID: 46982 RVA: 0x00126170 File Offset: 0x00124370
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpineAfterUpdateWorldTransformDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600B787 RID: 46983 RVA: 0x0012617C File Offset: 0x0012437C
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpineAfterUpdateWorldTransformDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSpineAfterUpdateWorldTransformDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SpinePlugin.SpineAfterUpdateWorldTransformDelegate__DelegateSignature");
			}
			return FSpineAfterUpdateWorldTransformDelegate._FunctionPtr;
		}

		// Token: 0x0600B788 RID: 46984 RVA: 0x0012619F File Offset: 0x0012439F
		public FSpineAfterUpdateWorldTransformDelegate()
		{
		}

		// Token: 0x0600B789 RID: 46985 RVA: 0x001261A7 File Offset: 0x001243A7
		[NullableContext(2)]
		public FSpineAfterUpdateWorldTransformDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B78A RID: 46986 RVA: 0x001261B1 File Offset: 0x001243B1
		public FSpineAfterUpdateWorldTransformDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B78B RID: 46987 RVA: 0x001261BC File Offset: 0x001243BC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USpineSkeletonComponent>) ?? ((Action<USpineSkeletonComponent>)Delegate.CreateDelegate(typeof(Action<USpineSkeletonComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B78C RID: 46988 RVA: 0x001261EE File Offset: 0x001243EE
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USpineSkeletonComponent> Callback)
		{
			if (FSpineAfterUpdateWorldTransformDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSpineAfterUpdateWorldTransformDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSpineAfterUpdateWorldTransformDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSpineAfterUpdateWorldTransformDelegate.OnScriptCallback));
				}
				FSpineAfterUpdateWorldTransformDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSpineAfterUpdateWorldTransformDelegate.RegisterId);
		}

		// Token: 0x0600B78D RID: 46989 RVA: 0x00126228 File Offset: 0x00124428
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USpineSkeletonComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600B78E RID: 46990 RVA: 0x00126234 File Offset: 0x00124434
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(USpineSkeletonComponent skeleton)
		{
			FSpineAfterUpdateWorldTransformDelegate.__FSpineAfterUpdateWorldTransformDelegate_DelegateParams* ptr = stackalloc FSpineAfterUpdateWorldTransformDelegate.__FSpineAfterUpdateWorldTransformDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSpineAfterUpdateWorldTransformDelegate.__FSpineAfterUpdateWorldTransformDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSpineAfterUpdateWorldTransformDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->skeleton = ((skeleton != null) ? skeleton.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600B78F RID: 46991 RVA: 0x00126280 File Offset: 0x00124480
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USpineSkeletonComponent> action = target as Action<USpineSkeletonComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USpineSkeletonComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USpineSkeletonComponent>(((FSpineAfterUpdateWorldTransformDelegate.__FSpineAfterUpdateWorldTransformDelegate_DelegateParams*)__Parameters)->skeleton);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400536B RID: 21355
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400536C RID: 21356
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SpinePlugin.SpineAfterUpdateWorldTransformDelegate__DelegateSignature";

		// Token: 0x0400536D RID: 21357
		private static int RegisterId;

		// Token: 0x020013CA RID: 5066
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FSpineAfterUpdateWorldTransformDelegate_DelegateParams
		{
			// Token: 0x04006835 RID: 26677
			[FieldOffset(0)]
			public IntPtr skeleton;
		}

		// Token: 0x020013CB RID: 5067
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006836 RID: 26678
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
