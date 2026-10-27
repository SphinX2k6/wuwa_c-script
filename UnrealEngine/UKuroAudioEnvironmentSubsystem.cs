using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001698 RID: 5784
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAudio.KuroAudioEnvironmentSubsystem")]
	[UnrealStructLayout(1920, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1920)]
	public class UKuroAudioEnvironmentSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014F8F RID: 85903 RVA: 0x001ED386 File Offset: 0x001EB586
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAudioEnvironmentSubsystem._ClassPtr;
		}

		// Token: 0x06014F90 RID: 85904 RVA: 0x001ED394 File Offset: 0x001EB594
		public UKuroAudioEnvironmentSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroAudioEnvironmentSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014F91 RID: 85905 RVA: 0x001ED3BC File Offset: 0x001EB5BC
		public UKuroAudioEnvironmentSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAudioEnvironmentSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700530F RID: 21263
		// (get) Token: 0x06014F92 RID: 85906 RVA: 0x001ED3F0 File Offset: 0x001EB5F0
		// (set) Token: 0x06014F93 RID: 85907 RVA: 0x001ED429 File Offset: 0x001EB629
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

		// Token: 0x06014F94 RID: 85908 RVA: 0x001ED44A File Offset: 0x001EB64A
		public TMap<string, string> GetEnvironmentStates(in FVector Location)
		{
			return new TMap<string, string>(UKuroAudioEnvironmentSubsystem.__GetEnvironmentStates_Internal(base.NativePtr, Location), null);
		}

		// Token: 0x06014F95 RID: 85909 RVA: 0x001ED45E File Offset: 0x001EB65E
		public FKuroAudioEnvironmentInfo GetEnvironmentInfo_MusicCompatible(in FVector Location)
		{
			return new FKuroAudioEnvironmentInfo(UKuroAudioEnvironmentSubsystem.__GetEnvironmentInfo_MusicCompatible_Internal(base.NativePtr, Location), null);
		}

		// Token: 0x06014F96 RID: 85910 RVA: 0x001ED472 File Offset: 0x001EB672
		public FKuroAudioEnvironmentInfo GetEnvironmentInfo(in FVector Location)
		{
			return new FKuroAudioEnvironmentInfo(UKuroAudioEnvironmentSubsystem.__GetEnvironmentInfo_Internal(base.NativePtr, Location), null);
		}

		// Token: 0x06014F97 RID: 85911 RVA: 0x001ED486 File Offset: 0x001EB686
		public void DynamicReverbTrace(in FVector Location, bool bForceUpdate = false)
		{
			UKuroAudioEnvironmentSubsystem.__DynamicReverbTrace_Internal(base.NativePtr, Location, bForceUpdate);
		}

		// Token: 0x06014F98 RID: 85912 RVA: 0x001ED495 File Offset: 0x001EB695
		public void DynamicReverbReset()
		{
			UKuroAudioEnvironmentSubsystem.__DynamicReverbReset_Internal(base.NativePtr);
		}

		// Token: 0x06014F99 RID: 85913 RVA: 0x001ED4A2 File Offset: 0x001EB6A2
		public void DynamicReverbApply()
		{
			UKuroAudioEnvironmentSubsystem.__DynamicReverbApply_Internal(base.NativePtr);
		}

		// Token: 0x06014F9A RID: 85914 RVA: 0x001ED4AF File Offset: 0x001EB6AF
		public void D_DynamicReverbTrace(in FVectorDouble Location, bool bForceUpdate = false)
		{
			UKuroAudioEnvironmentSubsystem.__D_DynamicReverbTrace_Internal(base.NativePtr, Location, bForceUpdate);
		}

		// Token: 0x06014F9B RID: 85915
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEnvironmentStates_Internal(IntPtr @this, in FVector Location);

		// Token: 0x06014F9C RID: 85916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEnvironmentInfo_MusicCompatible_Internal(IntPtr @this, in FVector Location);

		// Token: 0x06014F9D RID: 85917
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEnvironmentInfo_Internal(IntPtr @this, in FVector Location);

		// Token: 0x06014F9E RID: 85918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DynamicReverbTrace_Internal(IntPtr @this, in FVector Location, bool bForceUpdate);

		// Token: 0x06014F9F RID: 85919
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DynamicReverbReset_Internal(IntPtr @this);

		// Token: 0x06014FA0 RID: 85920
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DynamicReverbApply_Internal(IntPtr @this);

		// Token: 0x06014FA1 RID: 85921
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DynamicReverbTrace_Internal(IntPtr @this, in FVectorDouble Location, bool bForceUpdate);

		// Token: 0x06014FA2 RID: 85922 RVA: 0x001ED4BE File Offset: 0x001EB6BE
		static UKuroAudioEnvironmentSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAudio.KuroAudioEnvironmentSubsystem");
		}

		// Token: 0x06014FA3 RID: 85923 RVA: 0x001ED4CC File Offset: 0x001EB6CC
		protected UKuroAudioEnvironmentSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B6D1 RID: 46801
		public new const string __ObjectPath = "/Script/KuroAudio.KuroAudioEnvironmentSubsystem";

		// Token: 0x0400B6D2 RID: 46802
		private static IntPtr _ClassPtr;

		// Token: 0x0400B6D3 RID: 46803
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B6D4 RID: 46804
		public static IntPtr __EnvironmentUpdatedDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400B6D5 RID: 46805
		internal static int __PropertyOffset_EnvironmentUpdatedDelegate;

		// Token: 0x0400B6D6 RID: 46806
		[Nullable(2)]
		private FEnvironmentUpdatedDelegate _EnvironmentUpdatedDelegate;
	}
}
