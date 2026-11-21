using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000618 RID: 1560
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FTriggerVolumeMapUpdateDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060088C7 RID: 35015 RVA: 0x000CE67A File Offset: 0x000CC87A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTriggerVolumeMapUpdateDelegate.StaticFunctionPtr();
		}

		// Token: 0x060088C8 RID: 35016 RVA: 0x000CE686 File Offset: 0x000CC886
		private static IntPtr StaticFunctionPtr()
		{
			if (FTriggerVolumeMapUpdateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTriggerVolumeMapUpdateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.TriggerVolumeMapUpdateDelegate__DelegateSignature");
			}
			return FTriggerVolumeMapUpdateDelegate._FunctionPtr;
		}

		// Token: 0x060088C9 RID: 35017 RVA: 0x000CE6A9 File Offset: 0x000CC8A9
		public FTriggerVolumeMapUpdateDelegate()
		{
		}

		// Token: 0x060088CA RID: 35018 RVA: 0x000CE6B1 File Offset: 0x000CC8B1
		[NullableContext(2)]
		public FTriggerVolumeMapUpdateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060088CB RID: 35019 RVA: 0x000CE6BB File Offset: 0x000CC8BB
		public FTriggerVolumeMapUpdateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060088CC RID: 35020 RVA: 0x000CE6C6 File Offset: 0x000CC8C6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FName>) ?? ((Action<FName>)Delegate.CreateDelegate(typeof(Action<FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060088CD RID: 35021 RVA: 0x000CE6F8 File Offset: 0x000CC8F8
		[NullableContext(1)]
		public void Add(Action<FName> Callback)
		{
			if (FTriggerVolumeMapUpdateDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTriggerVolumeMapUpdateDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTriggerVolumeMapUpdateDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTriggerVolumeMapUpdateDelegate.OnScriptCallback));
				}
				FTriggerVolumeMapUpdateDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FTriggerVolumeMapUpdateDelegate.RegisterId);
		}

		// Token: 0x060088CE RID: 35022 RVA: 0x000CE732 File Offset: 0x000CC932
		[NullableContext(1)]
		public void Remove(Action<FName> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060088CF RID: 35023 RVA: 0x000CE73C File Offset: 0x000CC93C
		[SkipLocalsInit]
		public unsafe void Broadcast(FName ActorKey)
		{
			FTriggerVolumeMapUpdateDelegate.__FTriggerVolumeMapUpdateDelegate_DelegateParams* ptr = stackalloc FTriggerVolumeMapUpdateDelegate.__FTriggerVolumeMapUpdateDelegate_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FTriggerVolumeMapUpdateDelegate.__FTriggerVolumeMapUpdateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTriggerVolumeMapUpdateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ActorKey = ActorKey;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060088D0 RID: 35024 RVA: 0x000CE778 File Offset: 0x000CC978
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName> action = target as Action<FName>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FTriggerVolumeMapUpdateDelegate.__FTriggerVolumeMapUpdateDelegate_DelegateParams*)__Parameters)->ActorKey);
		}

		// Token: 0x04003B60 RID: 15200
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B61 RID: 15201
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.TriggerVolumeMapUpdateDelegate__DelegateSignature";

		// Token: 0x04003B62 RID: 15202
		private static int RegisterId;

		// Token: 0x02000E4A RID: 3658
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		private ref struct __FTriggerVolumeMapUpdateDelegate_DelegateParams
		{
			// Token: 0x040061E4 RID: 25060
			[FieldOffset(0)]
			public FName ActorKey;
		}

		// Token: 0x02000E4B RID: 3659
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061E5 RID: 25061
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
