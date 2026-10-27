using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C89 RID: 3209
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpTrack")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public abstract class UInterpTrack : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A2E9 RID: 41705 RVA: 0x000E75E2 File Offset: 0x000E57E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrack._ClassPtr;
		}

		// Token: 0x170026C5 RID: 9925
		// (get) Token: 0x0600A2EA RID: 41706 RVA: 0x000E75F0 File Offset: 0x000E57F0
		// (set) Token: 0x0600A2EB RID: 41707 RVA: 0x000E7629 File Offset: 0x000E5829
		public TArray<UInterpTrack> SubTracks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UInterpTrack> result;
				if ((result = this._SubTracks) == null)
				{
					result = (this._SubTracks = new TArray<UInterpTrack>(base.NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_SubTracks, this));
				}
				return result;
			}
			set
			{
				this.SubTracks.CopyAssign(value);
			}
		}

		// Token: 0x170026C6 RID: 9926
		// (get) Token: 0x0600A2EC RID: 41708 RVA: 0x000E7637 File Offset: 0x000E5837
		// (set) Token: 0x0600A2ED RID: 41709 RVA: 0x000E764B File Offset: 0x000E584B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UInterpTrackInst> TrackInstClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_TrackInstClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_TrackInstClass) = value;
			}
		}

		// Token: 0x170026C7 RID: 9927
		// (get) Token: 0x0600A2EE RID: 41710 RVA: 0x000E7660 File Offset: 0x000E5860
		// (set) Token: 0x0600A2EF RID: 41711 RVA: 0x000E7674 File Offset: 0x000E5874
		[Nullable(0)]
		public unsafe TEnumAsByte<ETrackActiveCondition> ActiveCondition
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_ActiveCondition);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_ActiveCondition) = value;
			}
		}

		// Token: 0x170026C8 RID: 9928
		// (get) Token: 0x0600A2F0 RID: 41712 RVA: 0x000E7689 File Offset: 0x000E5889
		// (set) Token: 0x0600A2F1 RID: 41713 RVA: 0x000E769D File Offset: 0x000E589D
		public unsafe string TrackTitle
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UInterpTrack.__PropertyOffset_TrackTitle)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UInterpTrack.__PropertyOffset_TrackTitle)), value);
			}
		}

		// Token: 0x170026C9 RID: 9929
		// (get) Token: 0x0600A2F2 RID: 41714 RVA: 0x000E76B2 File Offset: 0x000E58B2
		// (set) Token: 0x0600A2F3 RID: 41715 RVA: 0x000E76CB File Offset: 0x000E58CB
		public unsafe bool bOnePerGroup
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bOnePerGroup) & UInterpTrack.__PropertyMask_bOnePerGroup) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bOnePerGroup) = ((*(base.NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bOnePerGroup) & ~UInterpTrack.__PropertyMask_bOnePerGroup) | (value ? UInterpTrack.__PropertyMask_bOnePerGroup : 0));
			}
		}

		// Token: 0x170026CA RID: 9930
		// (get) Token: 0x0600A2F4 RID: 41716 RVA: 0x000E76FB File Offset: 0x000E58FB
		// (set) Token: 0x0600A2F5 RID: 41717 RVA: 0x000E7714 File Offset: 0x000E5914
		public unsafe bool bDirGroupOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bDirGroupOnly) & UInterpTrack.__PropertyMask_bDirGroupOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bDirGroupOnly) = ((*(base.NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bDirGroupOnly) & ~UInterpTrack.__PropertyMask_bDirGroupOnly) | (value ? UInterpTrack.__PropertyMask_bDirGroupOnly : 0));
			}
		}

		// Token: 0x170026CB RID: 9931
		// (get) Token: 0x0600A2F6 RID: 41718 RVA: 0x000E7744 File Offset: 0x000E5944
		// (set) Token: 0x0600A2F7 RID: 41719 RVA: 0x000E775D File Offset: 0x000E595D
		public unsafe bool bDisableTrack
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bDisableTrack) & UInterpTrack.__PropertyMask_bDisableTrack) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bDisableTrack) = ((*(base.NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bDisableTrack) & ~UInterpTrack.__PropertyMask_bDisableTrack) | (value ? UInterpTrack.__PropertyMask_bDisableTrack : 0));
			}
		}

		// Token: 0x170026CC RID: 9932
		// (get) Token: 0x0600A2F8 RID: 41720 RVA: 0x000E778D File Offset: 0x000E598D
		// (set) Token: 0x0600A2F9 RID: 41721 RVA: 0x000E77A6 File Offset: 0x000E59A6
		public unsafe bool bIsSelected
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bIsSelected) & UInterpTrack.__PropertyMask_bIsSelected) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bIsSelected) = ((*(base.NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bIsSelected) & ~UInterpTrack.__PropertyMask_bIsSelected) | (value ? UInterpTrack.__PropertyMask_bIsSelected : 0));
			}
		}

		// Token: 0x170026CD RID: 9933
		// (get) Token: 0x0600A2FA RID: 41722 RVA: 0x000E77D6 File Offset: 0x000E59D6
		// (set) Token: 0x0600A2FB RID: 41723 RVA: 0x000E77EF File Offset: 0x000E59EF
		public unsafe bool bIsAnimControlTrack
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bIsAnimControlTrack) & UInterpTrack.__PropertyMask_bIsAnimControlTrack) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bIsAnimControlTrack) = ((*(base.NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bIsAnimControlTrack) & ~UInterpTrack.__PropertyMask_bIsAnimControlTrack) | (value ? UInterpTrack.__PropertyMask_bIsAnimControlTrack : 0));
			}
		}

		// Token: 0x170026CE RID: 9934
		// (get) Token: 0x0600A2FC RID: 41724 RVA: 0x000E781F File Offset: 0x000E5A1F
		// (set) Token: 0x0600A2FD RID: 41725 RVA: 0x000E7838 File Offset: 0x000E5A38
		public unsafe bool bSubTrackOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bSubTrackOnly) & UInterpTrack.__PropertyMask_bSubTrackOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bSubTrackOnly) = ((*(base.NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bSubTrackOnly) & ~UInterpTrack.__PropertyMask_bSubTrackOnly) | (value ? UInterpTrack.__PropertyMask_bSubTrackOnly : 0));
			}
		}

		// Token: 0x170026CF RID: 9935
		// (get) Token: 0x0600A2FE RID: 41726 RVA: 0x000E7868 File Offset: 0x000E5A68
		// (set) Token: 0x0600A2FF RID: 41727 RVA: 0x000E7881 File Offset: 0x000E5A81
		public unsafe bool bVisible
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bVisible) & UInterpTrack.__PropertyMask_bVisible) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bVisible) = ((*(base.NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bVisible) & ~UInterpTrack.__PropertyMask_bVisible) | (value ? UInterpTrack.__PropertyMask_bVisible : 0));
			}
		}

		// Token: 0x170026D0 RID: 9936
		// (get) Token: 0x0600A300 RID: 41728 RVA: 0x000E78B1 File Offset: 0x000E5AB1
		// (set) Token: 0x0600A301 RID: 41729 RVA: 0x000E78CA File Offset: 0x000E5ACA
		public unsafe bool bIsRecording
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bIsRecording) & UInterpTrack.__PropertyMask_bIsRecording) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bIsRecording) = ((*(base.NativePtr + (IntPtr)UInterpTrack.__PropertyOffset_bIsRecording) & ~UInterpTrack.__PropertyMask_bIsRecording) | (value ? UInterpTrack.__PropertyMask_bIsRecording : 0));
			}
		}

		// Token: 0x0600A302 RID: 41730 RVA: 0x000E78FA File Offset: 0x000E5AFA
		static UInterpTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrack");
		}

		// Token: 0x0600A303 RID: 41731 RVA: 0x000E7908 File Offset: 0x000E5B08
		protected UInterpTrack() : this(BuiltinUtils.AllocNativeUObject(UInterpTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A304 RID: 41732 RVA: 0x000E7930 File Offset: 0x000E5B30
		protected UInterpTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400596E RID: 22894
		public new const string __ObjectPath = "/Script/Engine.InterpTrack";

		// Token: 0x0400596F RID: 22895
		private static IntPtr _ClassPtr;

		// Token: 0x04005970 RID: 22896
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005971 RID: 22897
		internal static int __PropertyOffset_SubTracks;

		// Token: 0x04005972 RID: 22898
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UInterpTrack> _SubTracks;

		// Token: 0x04005973 RID: 22899
		internal static int __PropertyOffset_TrackInstClass;

		// Token: 0x04005974 RID: 22900
		internal static int __PropertyOffset_ActiveCondition;

		// Token: 0x04005975 RID: 22901
		internal static int __PropertyOffset_TrackTitle;

		// Token: 0x04005976 RID: 22902
		internal static int __PropertyOffset_bOnePerGroup;

		// Token: 0x04005977 RID: 22903
		internal static byte __PropertyMask_bOnePerGroup;

		// Token: 0x04005978 RID: 22904
		internal static int __PropertyOffset_bDirGroupOnly;

		// Token: 0x04005979 RID: 22905
		internal static byte __PropertyMask_bDirGroupOnly;

		// Token: 0x0400597A RID: 22906
		internal static int __PropertyOffset_bDisableTrack;

		// Token: 0x0400597B RID: 22907
		internal static byte __PropertyMask_bDisableTrack;

		// Token: 0x0400597C RID: 22908
		internal static int __PropertyOffset_bIsSelected;

		// Token: 0x0400597D RID: 22909
		internal static byte __PropertyMask_bIsSelected;

		// Token: 0x0400597E RID: 22910
		internal static int __PropertyOffset_bIsAnimControlTrack;

		// Token: 0x0400597F RID: 22911
		internal static byte __PropertyMask_bIsAnimControlTrack;

		// Token: 0x04005980 RID: 22912
		internal static int __PropertyOffset_bSubTrackOnly;

		// Token: 0x04005981 RID: 22913
		internal static byte __PropertyMask_bSubTrackOnly;

		// Token: 0x04005982 RID: 22914
		internal static int __PropertyOffset_bVisible;

		// Token: 0x04005983 RID: 22915
		internal static byte __PropertyMask_bVisible;

		// Token: 0x04005984 RID: 22916
		internal static int __PropertyOffset_bIsRecording;

		// Token: 0x04005985 RID: 22917
		internal static byte __PropertyMask_bIsRecording;
	}
}
