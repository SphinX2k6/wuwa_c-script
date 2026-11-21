using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000312 RID: 786
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAudio.KuroAudioEnvironmentSubsystem")]
	[UnrealStructLayout(1920, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1920)]
	public class UKuroAudioEnvironmentSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005370 RID: 21360 RVA: 0x00074A98 File Offset: 0x00072C98
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAudioEnvironmentSubsystem._ClassPtr;
		}

		// Token: 0x06005371 RID: 21361 RVA: 0x00074AA4 File Offset: 0x00072CA4
		public UKuroAudioEnvironmentSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroAudioEnvironmentSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005372 RID: 21362 RVA: 0x00074ACC File Offset: 0x00072CCC
		public UKuroAudioEnvironmentSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAudioEnvironmentSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x06005373 RID: 21363 RVA: 0x00074B00 File Offset: 0x00072D00
		// (set) Token: 0x06005374 RID: 21364 RVA: 0x00074B39 File Offset: 0x00072D39
		public FEnvironmentUpdatedDelegate EnvironmentUpdatedDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FEnvironmentUpdatedDelegate result;
				if ((result = this._EnvironmentUpdatedDelegate) == null)
				{
					result = (this._EnvironmentUpdatedDelegate = new FEnvironmentUpdatedDelegate(base.NativePtr + (IntPtr)UKuroAudioEnvironmentSubsystem.__PropertyOffset_EnvironmentUpdatedDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroAudioEnvironmentSubsystem.__PropertyOffset_EnvironmentUpdatedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06005375 RID: 21365 RVA: 0x00074B5A File Offset: 0x00072D5A
		public TMap<string, string> GetEnvironmentStates(in FVector Location)
		{
			return new TMap<string, string>(UKuroAudioEnvironmentSubsystem.__GetEnvironmentStates_Internal(base.NativePtr, Location), null);
		}

		// Token: 0x06005376 RID: 21366 RVA: 0x00074B6E File Offset: 0x00072D6E
		public FKuroAudioEnvironmentInfo GetEnvironmentInfo_MusicCompatible(in FVector Location)
		{
			return new FKuroAudioEnvironmentInfo(UKuroAudioEnvironmentSubsystem.__GetEnvironmentInfo_MusicCompatible_Internal(base.NativePtr, Location), null);
		}

		// Token: 0x06005377 RID: 21367 RVA: 0x00074B82 File Offset: 0x00072D82
		public FKuroAudioEnvironmentInfo GetEnvironmentInfo(in FVector Location)
		{
			return new FKuroAudioEnvironmentInfo(UKuroAudioEnvironmentSubsystem.__GetEnvironmentInfo_Internal(base.NativePtr, Location), null);
		}

		// Token: 0x06005378 RID: 21368 RVA: 0x00074B96 File Offset: 0x00072D96
		public void DynamicReverbTrace(in FVector Location, bool bForceUpdate = false)
		{
			UKuroAudioEnvironmentSubsystem.__DynamicReverbTrace_Internal(base.NativePtr, Location, bForceUpdate);
		}

		// Token: 0x06005379 RID: 21369 RVA: 0x00074BA5 File Offset: 0x00072DA5
		public void DynamicReverbReset()
		{
			UKuroAudioEnvironmentSubsystem.__DynamicReverbReset_Internal(base.NativePtr);
		}

		// Token: 0x0600537A RID: 21370 RVA: 0x00074BB2 File Offset: 0x00072DB2
		public void DynamicReverbApply()
		{
			UKuroAudioEnvironmentSubsystem.__DynamicReverbApply_Internal(base.NativePtr);
		}

		// Token: 0x0600537B RID: 21371 RVA: 0x00074BBF File Offset: 0x00072DBF
		public void D_DynamicReverbTrace(in FVectorDouble Location, bool bForceUpdate = false)
		{
			UKuroAudioEnvironmentSubsystem.__D_DynamicReverbTrace_Internal(base.NativePtr, Location, bForceUpdate);
		}

		// Token: 0x0600537C RID: 21372
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEnvironmentStates_Internal(IntPtr @this, in FVector Location);

		// Token: 0x0600537D RID: 21373
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEnvironmentInfo_MusicCompatible_Internal(IntPtr @this, in FVector Location);

		// Token: 0x0600537E RID: 21374
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEnvironmentInfo_Internal(IntPtr @this, in FVector Location);

		// Token: 0x0600537F RID: 21375
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DynamicReverbTrace_Internal(IntPtr @this, in FVector Location, bool bForceUpdate);

		// Token: 0x06005380 RID: 21376
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DynamicReverbReset_Internal(IntPtr @this);

		// Token: 0x06005381 RID: 21377
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DynamicReverbApply_Internal(IntPtr @this);

		// Token: 0x06005382 RID: 21378
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DynamicReverbTrace_Internal(IntPtr @this, in FVectorDouble Location, bool bForceUpdate);

		// Token: 0x06005383 RID: 21379 RVA: 0x00074BCE File Offset: 0x00072DCE
		static UKuroAudioEnvironmentSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAudio.KuroAudioEnvironmentSubsystem");
		}

		// Token: 0x06005384 RID: 21380 RVA: 0x00074BDC File Offset: 0x00072DDC
		protected UKuroAudioEnvironmentSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002223 RID: 8739
		public new const string __ObjectPath = "/Script/KuroAudio.KuroAudioEnvironmentSubsystem";

		// Token: 0x04002224 RID: 8740
		private static IntPtr _ClassPtr;

		// Token: 0x04002225 RID: 8741
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002226 RID: 8742
		public static IntPtr __EnvironmentUpdatedDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04002227 RID: 8743
		internal static int __PropertyOffset_EnvironmentUpdatedDelegate;

		// Token: 0x04002228 RID: 8744
		[Nullable(2)]
		private FEnvironmentUpdatedDelegate _EnvironmentUpdatedDelegate;
	}
}
