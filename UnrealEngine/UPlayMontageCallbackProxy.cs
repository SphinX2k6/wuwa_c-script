using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000336 RID: 822
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.PlayMontageCallbackProxy")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UPlayMontageCallbackProxy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002DB7 RID: 11703 RVA: 0x000460D2 File Offset: 0x000442D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPlayMontageCallbackProxy._ClassPtr;
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x000460E0 File Offset: 0x000442E0
		public UPlayMontageCallbackProxy() : this(BuiltinUtils.AllocNativeUObject(UPlayMontageCallbackProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x00046108 File Offset: 0x00044308
		public UPlayMontageCallbackProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPlayMontageCallbackProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06002DBA RID: 11706 RVA: 0x0004613C File Offset: 0x0004433C
		// (set) Token: 0x06002DBB RID: 11707 RVA: 0x00046175 File Offset: 0x00044375
		public FOnMontagePlayDelegate OnCompleted
		{
			get
			{
				base.FastCheckIsValid();
				FOnMontagePlayDelegate result;
				if ((result = this._OnCompleted) == null)
				{
					result = (this._OnCompleted = new FOnMontagePlayDelegate(base.NativePtr + (IntPtr)UPlayMontageCallbackProxy.__PropertyOffset_OnCompleted, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPlayMontageCallbackProxy.__PropertyOffset_OnCompleted, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06002DBC RID: 11708 RVA: 0x00046198 File Offset: 0x00044398
		// (set) Token: 0x06002DBD RID: 11709 RVA: 0x000461D1 File Offset: 0x000443D1
		public FOnMontagePlayDelegate OnBlendOut
		{
			get
			{
				base.FastCheckIsValid();
				FOnMontagePlayDelegate result;
				if ((result = this._OnBlendOut) == null)
				{
					result = (this._OnBlendOut = new FOnMontagePlayDelegate(base.NativePtr + (IntPtr)UPlayMontageCallbackProxy.__PropertyOffset_OnBlendOut, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPlayMontageCallbackProxy.__PropertyOffset_OnBlendOut, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06002DBE RID: 11710 RVA: 0x000461F4 File Offset: 0x000443F4
		// (set) Token: 0x06002DBF RID: 11711 RVA: 0x0004622D File Offset: 0x0004442D
		public FOnMontagePlayDelegate OnInterrupted
		{
			get
			{
				base.FastCheckIsValid();
				FOnMontagePlayDelegate result;
				if ((result = this._OnInterrupted) == null)
				{
					result = (this._OnInterrupted = new FOnMontagePlayDelegate(base.NativePtr + (IntPtr)UPlayMontageCallbackProxy.__PropertyOffset_OnInterrupted, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPlayMontageCallbackProxy.__PropertyOffset_OnInterrupted, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06002DC0 RID: 11712 RVA: 0x00046250 File Offset: 0x00044450
		// (set) Token: 0x06002DC1 RID: 11713 RVA: 0x00046289 File Offset: 0x00044489
		public FOnMontagePlayDelegate OnNotifyBegin
		{
			get
			{
				base.FastCheckIsValid();
				FOnMontagePlayDelegate result;
				if ((result = this._OnNotifyBegin) == null)
				{
					result = (this._OnNotifyBegin = new FOnMontagePlayDelegate(base.NativePtr + (IntPtr)UPlayMontageCallbackProxy.__PropertyOffset_OnNotifyBegin, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPlayMontageCallbackProxy.__PropertyOffset_OnNotifyBegin, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06002DC2 RID: 11714 RVA: 0x000462AC File Offset: 0x000444AC
		// (set) Token: 0x06002DC3 RID: 11715 RVA: 0x000462E5 File Offset: 0x000444E5
		public FOnMontagePlayDelegate OnNotifyEnd
		{
			get
			{
				base.FastCheckIsValid();
				FOnMontagePlayDelegate result;
				if ((result = this._OnNotifyEnd) == null)
				{
					result = (this._OnNotifyEnd = new FOnMontagePlayDelegate(base.NativePtr + (IntPtr)UPlayMontageCallbackProxy.__PropertyOffset_OnNotifyEnd, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPlayMontageCallbackProxy.__PropertyOffset_OnNotifyEnd, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x00046308 File Offset: 0x00044508
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnNotifyEndReceived(FName NotifyName, in FBranchingPointNotifyPayload BranchingPointNotifyPayload)
		{
			UPlayMontageCallbackProxy.__OnNotifyEndReceived_FunctionParams* ptr = stackalloc UPlayMontageCallbackProxy.__OnNotifyEndReceived_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UPlayMontageCallbackProxy.__OnNotifyEndReceived_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPlayMontageCallbackProxy.__OnNotifyEndReceived_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			if (BranchingPointNotifyPayload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FBranchingPointNotifyPayload.StaticStruct(), &ptr->BranchingPointNotifyPayload, BranchingPointNotifyPayload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UPlayMontageCallbackProxy.__OnNotifyEndReceived_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x00046374 File Offset: 0x00044574
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnNotifyBeginReceived(FName NotifyName, in FBranchingPointNotifyPayload BranchingPointNotifyPayload)
		{
			UPlayMontageCallbackProxy.__OnNotifyBeginReceived_FunctionParams* ptr = stackalloc UPlayMontageCallbackProxy.__OnNotifyBeginReceived_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UPlayMontageCallbackProxy.__OnNotifyBeginReceived_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPlayMontageCallbackProxy.__OnNotifyBeginReceived_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			if (BranchingPointNotifyPayload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FBranchingPointNotifyPayload.StaticStruct(), &ptr->BranchingPointNotifyPayload, BranchingPointNotifyPayload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UPlayMontageCallbackProxy.__OnNotifyBeginReceived_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x000463E0 File Offset: 0x000445E0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnMontageEnded(UAnimMontage Montage, bool bInterrupted)
		{
			UPlayMontageCallbackProxy.__OnMontageEnded_FunctionParams* ptr = stackalloc UPlayMontageCallbackProxy.__OnMontageEnded_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UPlayMontageCallbackProxy.__OnMontageEnded_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPlayMontageCallbackProxy.__OnMontageEnded_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Montage = ((Montage != null) ? Montage.NativePtr : IntPtr.Zero);
			ptr->bInterrupted = bInterrupted;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UPlayMontageCallbackProxy.__OnMontageEnded_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x00046440 File Offset: 0x00044640
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnMontageBlendingOut(UAnimMontage Montage, bool bInterrupted)
		{
			UPlayMontageCallbackProxy.__OnMontageBlendingOut_FunctionParams* ptr = stackalloc UPlayMontageCallbackProxy.__OnMontageBlendingOut_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UPlayMontageCallbackProxy.__OnMontageBlendingOut_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPlayMontageCallbackProxy.__OnMontageBlendingOut_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Montage = ((Montage != null) ? Montage.NativePtr : IntPtr.Zero);
			ptr->bInterrupted = bInterrupted;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UPlayMontageCallbackProxy.__OnMontageBlendingOut_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x000464A0 File Offset: 0x000446A0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UPlayMontageCallbackProxy CreateProxyObjectForPlayMontage(USkeletalMeshComponent InSkeletalMeshComponent, UAnimMontage MontageToPlay, float PlayRate = 1f, float StartingPosition = 0f, FName StartingSection = default(FName))
		{
			UPlayMontageCallbackProxy.__CreateProxyObjectForPlayMontage_FunctionParams* ptr = stackalloc UPlayMontageCallbackProxy.__CreateProxyObjectForPlayMontage_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UPlayMontageCallbackProxy.__CreateProxyObjectForPlayMontage_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPlayMontageCallbackProxy.__CreateProxyObjectForPlayMontage_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSkeletalMeshComponent = ((InSkeletalMeshComponent != null) ? InSkeletalMeshComponent.NativePtr : IntPtr.Zero);
			ptr->MontageToPlay = ((MontageToPlay != null) ? MontageToPlay.NativePtr : IntPtr.Zero);
			ptr->PlayRate = PlayRate;
			ptr->StartingPosition = StartingPosition;
			ptr->StartingSection = StartingSection;
			UnrealReflectionUtils.CallUFunction(UPlayMontageCallbackProxy._ClassDefaultObjectPtr, UPlayMontageCallbackProxy.__CreateProxyObjectForPlayMontage_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPlayMontageCallbackProxy>(ptr->__Result);
		}

		// Token: 0x06002DC9 RID: 11721 RVA: 0x0004652C File Offset: 0x0004472C
		static UPlayMontageCallbackProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AnimGraphRuntime.PlayMontageCallbackProxy");
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x0004653A File Offset: 0x0004473A
		protected UPlayMontageCallbackProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400138C RID: 5004
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.PlayMontageCallbackProxy";

		// Token: 0x0400138D RID: 5005
		private static IntPtr _ClassPtr;

		// Token: 0x0400138E RID: 5006
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400138F RID: 5007
		internal static int __PropertyOffset_OnCompleted;

		// Token: 0x04001390 RID: 5008
		[Nullable(2)]
		private FOnMontagePlayDelegate _OnCompleted;

		// Token: 0x04001391 RID: 5009
		internal static int __PropertyOffset_OnBlendOut;

		// Token: 0x04001392 RID: 5010
		[Nullable(2)]
		private FOnMontagePlayDelegate _OnBlendOut;

		// Token: 0x04001393 RID: 5011
		internal static int __PropertyOffset_OnInterrupted;

		// Token: 0x04001394 RID: 5012
		[Nullable(2)]
		private FOnMontagePlayDelegate _OnInterrupted;

		// Token: 0x04001395 RID: 5013
		internal static int __PropertyOffset_OnNotifyBegin;

		// Token: 0x04001396 RID: 5014
		[Nullable(2)]
		private FOnMontagePlayDelegate _OnNotifyBegin;

		// Token: 0x04001397 RID: 5015
		internal static int __PropertyOffset_OnNotifyEnd;

		// Token: 0x04001398 RID: 5016
		[Nullable(2)]
		private FOnMontagePlayDelegate _OnNotifyEnd;

		// Token: 0x04001399 RID: 5017
		private static IntPtr __OnNotifyEndReceived_NativeFunctionPtr;

		// Token: 0x0400139A RID: 5018
		private static IntPtr __OnNotifyBeginReceived_NativeFunctionPtr;

		// Token: 0x0400139B RID: 5019
		private static IntPtr __OnMontageEnded_NativeFunctionPtr;

		// Token: 0x0400139C RID: 5020
		private static IntPtr __OnMontageBlendingOut_NativeFunctionPtr;

		// Token: 0x0400139D RID: 5021
		private static IntPtr __CreateProxyObjectForPlayMontage_NativeFunctionPtr;

		// Token: 0x02002BCB RID: 11211
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __OnNotifyEndReceived_FunctionParams
		{
			// Token: 0x0401647D RID: 91261
			[FieldOffset(0)]
			public FName NotifyName;

			// Token: 0x0401647E RID: 91262
			[FieldOffset(16)]
			public byte BranchingPointNotifyPayload;
		}

		// Token: 0x02002BCC RID: 11212
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __OnNotifyBeginReceived_FunctionParams
		{
			// Token: 0x0401647F RID: 91263
			[FieldOffset(0)]
			public FName NotifyName;

			// Token: 0x04016480 RID: 91264
			[FieldOffset(16)]
			public byte BranchingPointNotifyPayload;
		}

		// Token: 0x02002BCD RID: 11213
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnMontageEnded_FunctionParams
		{
			// Token: 0x04016481 RID: 91265
			[FieldOffset(0)]
			public IntPtr Montage;

			// Token: 0x04016482 RID: 91266
			[FieldOffset(8)]
			public bool bInterrupted;
		}

		// Token: 0x02002BCE RID: 11214
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnMontageBlendingOut_FunctionParams
		{
			// Token: 0x04016483 RID: 91267
			[FieldOffset(0)]
			public IntPtr Montage;

			// Token: 0x04016484 RID: 91268
			[FieldOffset(8)]
			public bool bInterrupted;
		}

		// Token: 0x02002BCF RID: 11215
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __CreateProxyObjectForPlayMontage_FunctionParams
		{
			// Token: 0x04016485 RID: 91269
			[FieldOffset(0)]
			public IntPtr InSkeletalMeshComponent;

			// Token: 0x04016486 RID: 91270
			[FieldOffset(8)]
			public IntPtr MontageToPlay;

			// Token: 0x04016487 RID: 91271
			[FieldOffset(16)]
			public float PlayRate;

			// Token: 0x04016488 RID: 91272
			[FieldOffset(20)]
			public float StartingPosition;

			// Token: 0x04016489 RID: 91273
			[FieldOffset(24)]
			public FName StartingSection;

			// Token: 0x0401648A RID: 91274
			[FieldOffset(40)]
			public IntPtr __Result;
		}
	}
}
