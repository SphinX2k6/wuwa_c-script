using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200083E RID: 2110
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpineBeforeUpdateWorldTransformDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B7CD RID: 47053 RVA: 0x00126ACC File Offset: 0x00124CCC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpineBeforeUpdateWorldTransformDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600B7CE RID: 47054 RVA: 0x00126AD8 File Offset: 0x00124CD8
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpineBeforeUpdateWorldTransformDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSpineBeforeUpdateWorldTransformDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SpinePlugin.SpineBeforeUpdateWorldTransformDelegate__DelegateSignature");
			}
			return FSpineBeforeUpdateWorldTransformDelegate._FunctionPtr;
		}

		// Token: 0x0600B7CF RID: 47055 RVA: 0x00126AFB File Offset: 0x00124CFB
		public FSpineBeforeUpdateWorldTransformDelegate()
		{
		}

		// Token: 0x0600B7D0 RID: 47056 RVA: 0x00126B03 File Offset: 0x00124D03
		[NullableContext(2)]
		public FSpineBeforeUpdateWorldTransformDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B7D1 RID: 47057 RVA: 0x00126B0D File Offset: 0x00124D0D
		public FSpineBeforeUpdateWorldTransformDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B7D2 RID: 47058 RVA: 0x00126B18 File Offset: 0x00124D18
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USpineSkeletonComponent>) ?? ((Action<USpineSkeletonComponent>)Delegate.CreateDelegate(typeof(Action<USpineSkeletonComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B7D3 RID: 47059 RVA: 0x00126B4A File Offset: 0x00124D4A
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USpineSkeletonComponent> Callback)
		{
			if (FSpineBeforeUpdateWorldTransformDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSpineBeforeUpdateWorldTransformDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSpineBeforeUpdateWorldTransformDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSpineBeforeUpdateWorldTransformDelegate.OnScriptCallback));
				}
				FSpineBeforeUpdateWorldTransformDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSpineBeforeUpdateWorldTransformDelegate.RegisterId);
		}

		// Token: 0x0600B7D4 RID: 47060 RVA: 0x00126B84 File Offset: 0x00124D84
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USpineSkeletonComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600B7D5 RID: 47061 RVA: 0x00126B90 File Offset: 0x00124D90
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(USpineSkeletonComponent skeleton)
		{
			FSpineBeforeUpdateWorldTransformDelegate.__FSpineBeforeUpdateWorldTransformDelegate_DelegateParams* ptr = stackalloc FSpineBeforeUpdateWorldTransformDelegate.__FSpineBeforeUpdateWorldTransformDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSpineBeforeUpdateWorldTransformDelegate.__FSpineBeforeUpdateWorldTransformDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSpineBeforeUpdateWorldTransformDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->skeleton = ((skeleton != null) ? skeleton.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600B7D6 RID: 47062 RVA: 0x00126BDC File Offset: 0x00124DDC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USpineSkeletonComponent> action = target as Action<USpineSkeletonComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USpineSkeletonComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USpineSkeletonComponent>(((FSpineBeforeUpdateWorldTransformDelegate.__FSpineBeforeUpdateWorldTransformDelegate_DelegateParams*)__Parameters)->skeleton);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04005384 RID: 21380
		internal static IntPtr _FunctionPtr;

		// Token: 0x04005385 RID: 21381
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SpinePlugin.SpineBeforeUpdateWorldTransformDelegate__DelegateSignature";

		// Token: 0x04005386 RID: 21382
		private static int RegisterId;

		// Token: 0x020013D6 RID: 5078
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FSpineBeforeUpdateWorldTransformDelegate_DelegateParams
		{
			// Token: 0x04006841 RID: 26689
			[FieldOffset(0)]
			public IntPtr skeleton;
		}

		// Token: 0x020013D7 RID: 5079
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006842 RID: 26690
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
