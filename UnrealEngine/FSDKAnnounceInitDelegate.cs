using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200052E RID: 1326
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKAnnounceInitDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007BF3 RID: 31731 RVA: 0x000B724E File Offset: 0x000B544E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKAnnounceInitDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007BF4 RID: 31732 RVA: 0x000B725A File Offset: 0x000B545A
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKAnnounceInitDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKAnnounceInitDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKAnnounceInitDelegate__DelegateSignature");
			}
			return FSDKAnnounceInitDelegate._FunctionPtr;
		}

		// Token: 0x06007BF5 RID: 31733 RVA: 0x000B727D File Offset: 0x000B547D
		public FSDKAnnounceInitDelegate()
		{
		}

		// Token: 0x06007BF6 RID: 31734 RVA: 0x000B7285 File Offset: 0x000B5485
		[NullableContext(2)]
		public FSDKAnnounceInitDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007BF7 RID: 31735 RVA: 0x000B728F File Offset: 0x000B548F
		public FSDKAnnounceInitDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007BF8 RID: 31736 RVA: 0x000B729A File Offset: 0x000B549A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007BF9 RID: 31737 RVA: 0x000B72CC File Offset: 0x000B54CC
		[NullableContext(1)]
		public void Add(Action<string> Callback)
		{
			if (FSDKAnnounceInitDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKAnnounceInitDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKAnnounceInitDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKAnnounceInitDelegate.OnScriptCallback));
				}
				FSDKAnnounceInitDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKAnnounceInitDelegate.RegisterId);
		}

		// Token: 0x06007BFA RID: 31738 RVA: 0x000B7306 File Offset: 0x000B5506
		[NullableContext(1)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007BFB RID: 31739 RVA: 0x000B7310 File Offset: 0x000B5510
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string result)
		{
			FSDKAnnounceInitDelegate.__FSDKAnnounceInitDelegate_DelegateParams* ptr = stackalloc FSDKAnnounceInitDelegate.__FSDKAnnounceInitDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSDKAnnounceInitDelegate.__FSDKAnnounceInitDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKAnnounceInitDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->result), result);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKAnnounceInitDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007BFC RID: 31740 RVA: 0x000B7364 File Offset: 0x000B5564
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FSDKAnnounceInitDelegate.__FSDKAnnounceInitDelegate_DelegateParams*)__Parameters)->result));
			action(obj);
		}

		// Token: 0x0400350A RID: 13578
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400350B RID: 13579
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKAnnounceInitDelegate__DelegateSignature";

		// Token: 0x0400350C RID: 13580
		private static int RegisterId;

		// Token: 0x02000CD3 RID: 3283
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FSDKAnnounceInitDelegate_DelegateParams
		{
			// Token: 0x04005F53 RID: 24403
			[FieldOffset(0)]
			public FString result;
		}

		// Token: 0x02000CD4 RID: 3284
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F54 RID: 24404
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
