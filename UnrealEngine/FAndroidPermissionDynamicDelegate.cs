using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002A8 RID: 680
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FAndroidPermissionDynamicDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06002588 RID: 9608 RVA: 0x00038AD5 File Offset: 0x00036CD5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAndroidPermissionDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x00038AE1 File Offset: 0x00036CE1
		private static IntPtr StaticFunctionPtr()
		{
			if (FAndroidPermissionDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FAndroidPermissionDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AndroidPermission.AndroidPermissionDynamicDelegate__DelegateSignature");
			}
			return FAndroidPermissionDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x00038B04 File Offset: 0x00036D04
		public FAndroidPermissionDynamicDelegate()
		{
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x00038B0C File Offset: 0x00036D0C
		[NullableContext(2)]
		public FAndroidPermissionDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x00038B16 File Offset: 0x00036D16
		public FAndroidPermissionDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x00038B21 File Offset: 0x00036D21
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FAndroidPermissionDynamicDelegate.FAndroidPermissionDynamicDelegate_ScriptDelegate) ?? ((FAndroidPermissionDynamicDelegate.FAndroidPermissionDynamicDelegate_ScriptDelegate)Delegate.CreateDelegate(typeof(FAndroidPermissionDynamicDelegate.FAndroidPermissionDynamicDelegate_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x00038B53 File Offset: 0x00036D53
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(FAndroidPermissionDynamicDelegate.FAndroidPermissionDynamicDelegate_ScriptDelegate Callback)
		{
			if (FAndroidPermissionDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAndroidPermissionDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAndroidPermissionDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAndroidPermissionDynamicDelegate.OnScriptCallback));
				}
				FAndroidPermissionDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FAndroidPermissionDynamicDelegate.RegisterId);
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x00038B8D File Offset: 0x00036D8D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FAndroidPermissionDynamicDelegate.FAndroidPermissionDynamicDelegate_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x00038B98 File Offset: 0x00036D98
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> Permissions, in TArray<bool> GrantResults)
		{
			FAndroidPermissionDynamicDelegate.__FAndroidPermissionDynamicDelegate_DelegateParams* ptr = stackalloc FAndroidPermissionDynamicDelegate.__FAndroidPermissionDynamicDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FAndroidPermissionDynamicDelegate.__FAndroidPermissionDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FAndroidPermissionDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<string> tarray = Permissions;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Permissions);
			}
			TArray<bool> tarray2 = GrantResults;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->GrantResults);
			}
			base.BroadcastInternal((void*)ptr);
			TArray<string> tarray3 = Permissions;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->Permissions);
			}
			TArray<bool> tarray4 = GrantResults;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->GrantResults);
			}
			UnrealReflectionUtils.DestroyStruct(FAndroidPermissionDynamicDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x00038C30 File Offset: 0x00036E30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FAndroidPermissionDynamicDelegate.FAndroidPermissionDynamicDelegate_ScriptDelegate fandroidPermissionDynamicDelegate_ScriptDelegate = target as FAndroidPermissionDynamicDelegate.FAndroidPermissionDynamicDelegate_ScriptDelegate;
			if (fandroidPermissionDynamicDelegate_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<string> tarray = new TArray<string>(&((FAndroidPermissionDynamicDelegate.__FAndroidPermissionDynamicDelegate_DelegateParams*)__Parameters)->Permissions, true, true);
			TArray<bool> tarray2 = new TArray<bool>(&((FAndroidPermissionDynamicDelegate.__FAndroidPermissionDynamicDelegate_DelegateParams*)__Parameters)->GrantResults, true, true);
			fandroidPermissionDynamicDelegate_ScriptDelegate(tarray, tarray2);
			if (tarray != null)
			{
				tarray.CopyTo(&((FAndroidPermissionDynamicDelegate.__FAndroidPermissionDynamicDelegate_DelegateParams*)__Parameters)->Permissions, default(UScriptStructStackOnlyPtr));
			}
			if (tarray2 != null)
			{
				tarray2.CopyTo(&((FAndroidPermissionDynamicDelegate.__FAndroidPermissionDynamicDelegate_DelegateParams*)__Parameters)->GrantResults, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04000E72 RID: 3698
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000E73 RID: 3699
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AndroidPermission.AndroidPermissionDynamicDelegate__DelegateSignature";

		// Token: 0x04000E74 RID: 3700
		private static int RegisterId;

		// Token: 0x02002BC6 RID: 11206
		// (Invoke) Token: 0x06028526 RID: 165158
		public delegate void FAndroidPermissionDynamicDelegate_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> Permissions, in TArray<bool> GrantResults);

		// Token: 0x02002BC7 RID: 11207
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FAndroidPermissionDynamicDelegate_DelegateParams
		{
			// Token: 0x04016478 RID: 91256
			[FieldOffset(0)]
			public byte Permissions;

			// Token: 0x04016479 RID: 91257
			[FieldOffset(16)]
			public byte GrantResults;
		}

		// Token: 0x02002BC8 RID: 11208
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401647A RID: 91258
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
