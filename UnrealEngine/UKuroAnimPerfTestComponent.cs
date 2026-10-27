using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001758 RID: 5976
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComponent.KuroAnimPerfTestComponent")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class UKuroAnimPerfTestComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015794 RID: 87956 RVA: 0x001F8DEC File Offset: 0x001F6FEC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimPerfTestComponent._ClassPtr;
		}

		// Token: 0x06015795 RID: 87957 RVA: 0x001F8DF8 File Offset: 0x001F6FF8
		public UKuroAnimPerfTestComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimPerfTestComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015796 RID: 87958 RVA: 0x001F8E20 File Offset: 0x001F7020
		public UKuroAnimPerfTestComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimPerfTestComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170054C6 RID: 21702
		// (get) Token: 0x06015797 RID: 87959 RVA: 0x001F8E53 File Offset: 0x001F7053
		// (set) Token: 0x06015798 RID: 87960 RVA: 0x001F8E63 File Offset: 0x001F7063
		public unsafe int NumSkeletalMeshActorsToGenerate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_NumSkeletalMeshActorsToGenerate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_NumSkeletalMeshActorsToGenerate) = value;
			}
		}

		// Token: 0x170054C7 RID: 21703
		// (get) Token: 0x06015799 RID: 87961 RVA: 0x001F8E74 File Offset: 0x001F7074
		// (set) Token: 0x0601579A RID: 87962 RVA: 0x001F8E84 File Offset: 0x001F7084
		public unsafe EAnimPerfTestBornFrom BornFrom
		{
			get
			{
				return (EAnimPerfTestBornFrom)(*(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_BornFrom));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_BornFrom) = (byte)value;
			}
		}

		// Token: 0x170054C8 RID: 21704
		// (get) Token: 0x0601579B RID: 87963 RVA: 0x001F8E95 File Offset: 0x001F7095
		// (set) Token: 0x0601579C RID: 87964 RVA: 0x001F8EAA File Offset: 0x001F70AA
		public TSoftObjectPtr<APlayerStart> SkelMeshActorBirthplace
		{
			get
			{
				return new TSoftObjectPtr<APlayerStart>(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_SkelMeshActorBirthplace, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_SkelMeshActorBirthplace, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170054C9 RID: 21705
		// (get) Token: 0x0601579D RID: 87965 RVA: 0x001F8ECF File Offset: 0x001F70CF
		// (set) Token: 0x0601579E RID: 87966 RVA: 0x001F8EDF File Offset: 0x001F70DF
		public unsafe EAnimPerfTestActorsGenMethod GenMethod
		{
			get
			{
				return (EAnimPerfTestActorsGenMethod)(*(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_GenMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_GenMethod) = (byte)value;
			}
		}

		// Token: 0x170054CA RID: 21706
		// (get) Token: 0x0601579F RID: 87967 RVA: 0x001F8EF0 File Offset: 0x001F70F0
		// (set) Token: 0x060157A0 RID: 87968 RVA: 0x001F8F00 File Offset: 0x001F7100
		public unsafe EAnimPerfTestSkelMeshLifeCycle LifeCycle
		{
			get
			{
				return (EAnimPerfTestSkelMeshLifeCycle)(*(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_LifeCycle));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_LifeCycle) = (byte)value;
			}
		}

		// Token: 0x170054CB RID: 21707
		// (get) Token: 0x060157A1 RID: 87969 RVA: 0x001F8F11 File Offset: 0x001F7111
		// (set) Token: 0x060157A2 RID: 87970 RVA: 0x001F8F21 File Offset: 0x001F7121
		public unsafe float SkelMeshActorInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_SkelMeshActorInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_SkelMeshActorInterval) = value;
			}
		}

		// Token: 0x170054CC RID: 21708
		// (get) Token: 0x060157A3 RID: 87971 RVA: 0x001F8F32 File Offset: 0x001F7132
		// (set) Token: 0x060157A4 RID: 87972 RVA: 0x001F8F42 File Offset: 0x001F7142
		public unsafe int SkelMeshLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_SkelMeshLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_SkelMeshLOD) = value;
			}
		}

		// Token: 0x170054CD RID: 21709
		// (get) Token: 0x060157A5 RID: 87973 RVA: 0x001F8F53 File Offset: 0x001F7153
		// (set) Token: 0x060157A6 RID: 87974 RVA: 0x001F8F67 File Offset: 0x001F7167
		[Nullable(2)]
		public unsafe USkeletalMesh SkelMeshTemplate
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimPerfTestComponent.__PropertyOffset_SkelMeshTemplate);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimPerfTestComponent.__PropertyOffset_SkelMeshTemplate, value);
			}
		}

		// Token: 0x170054CE RID: 21710
		// (get) Token: 0x060157A7 RID: 87975 RVA: 0x001F8F7C File Offset: 0x001F717C
		// (set) Token: 0x060157A8 RID: 87976 RVA: 0x001F8F90 File Offset: 0x001F7190
		[Nullable(2)]
		public unsafe UAnimationAsset AnimTemplate
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimationAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimPerfTestComponent.__PropertyOffset_AnimTemplate);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimPerfTestComponent.__PropertyOffset_AnimTemplate, value);
			}
		}

		// Token: 0x170054CF RID: 21711
		// (get) Token: 0x060157A9 RID: 87977 RVA: 0x001F8FA5 File Offset: 0x001F71A5
		// (set) Token: 0x060157AA RID: 87978 RVA: 0x001F8FB5 File Offset: 0x001F71B5
		public unsafe EAnimPerfTestRandomGenActorGroup ActorsRandGenGroup
		{
			get
			{
				return (EAnimPerfTestRandomGenActorGroup)(*(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_ActorsRandGenGroup));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_ActorsRandGenGroup) = (byte)value;
			}
		}

		// Token: 0x170054D0 RID: 21712
		// (get) Token: 0x060157AB RID: 87979 RVA: 0x001F8FC6 File Offset: 0x001F71C6
		// (set) Token: 0x060157AC RID: 87980 RVA: 0x001F8FD6 File Offset: 0x001F71D6
		public unsafe EAnimPerfTestAnimSeqFilterMethod AnimSeqFilterMethod
		{
			get
			{
				return (EAnimPerfTestAnimSeqFilterMethod)(*(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_AnimSeqFilterMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_AnimSeqFilterMethod) = (byte)value;
			}
		}

		// Token: 0x170054D1 RID: 21713
		// (get) Token: 0x060157AD RID: 87981 RVA: 0x001F8FE8 File Offset: 0x001F71E8
		// (set) Token: 0x060157AE RID: 87982 RVA: 0x001F9021 File Offset: 0x001F7221
		public TArray<string> AnimSeqFilter
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AnimSeqFilter) == null)
				{
					result = (this._AnimSeqFilter = new TArray<string>(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_AnimSeqFilter, this));
				}
				return result;
			}
			set
			{
				this.AnimSeqFilter.CopyAssign(value);
			}
		}

		// Token: 0x170054D2 RID: 21714
		// (get) Token: 0x060157AF RID: 87983 RVA: 0x001F9030 File Offset: 0x001F7230
		// (set) Token: 0x060157B0 RID: 87984 RVA: 0x001F9069 File Offset: 0x001F7269
		public TArray<USkeletalMesh> RandSkelMeshTemplates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USkeletalMesh> result;
				if ((result = this._RandSkelMeshTemplates) == null)
				{
					result = (this._RandSkelMeshTemplates = new TArray<USkeletalMesh>(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_RandSkelMeshTemplates, this));
				}
				return result;
			}
			set
			{
				this.RandSkelMeshTemplates.CopyAssign(value);
			}
		}

		// Token: 0x170054D3 RID: 21715
		// (get) Token: 0x060157B1 RID: 87985 RVA: 0x001F9078 File Offset: 0x001F7278
		// (set) Token: 0x060157B2 RID: 87986 RVA: 0x001F90B1 File Offset: 0x001F72B1
		public TArray<UAnimSequence> RandSkelMeshAniSeqs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAnimSequence> result;
				if ((result = this._RandSkelMeshAniSeqs) == null)
				{
					result = (this._RandSkelMeshAniSeqs = new TArray<UAnimSequence>(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_RandSkelMeshAniSeqs, this));
				}
				return result;
			}
			set
			{
				this.RandSkelMeshAniSeqs.CopyAssign(value);
			}
		}

		// Token: 0x170054D4 RID: 21716
		// (get) Token: 0x060157B3 RID: 87987 RVA: 0x001F90C0 File Offset: 0x001F72C0
		// (set) Token: 0x060157B4 RID: 87988 RVA: 0x001F90F9 File Offset: 0x001F72F9
		public TArray<AActor> GeneratedSkelMeshActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._GeneratedSkelMeshActors) == null)
				{
					result = (this._GeneratedSkelMeshActors = new TArray<AActor>(base.NativePtr + (IntPtr)UKuroAnimPerfTestComponent.__PropertyOffset_GeneratedSkelMeshActors, this));
				}
				return result;
			}
			set
			{
				this.GeneratedSkelMeshActors.CopyAssign(value);
			}
		}

		// Token: 0x060157B5 RID: 87989 RVA: 0x001F9107 File Offset: 0x001F7307
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void GenerateSkeletalMeshActors()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroAnimPerfTestComponent.__GenerateSkeletalMeshActors_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060157B6 RID: 87990 RVA: 0x001F911C File Offset: 0x001F731C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void DestroySkeletalMeshActors()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroAnimPerfTestComponent.__DestroySkeletalMeshActors_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060157B7 RID: 87991 RVA: 0x001F9131 File Offset: 0x001F7331
		static UKuroAnimPerfTestComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroAnimPerfTestComponent");
		}

		// Token: 0x060157B8 RID: 87992 RVA: 0x001F913F File Offset: 0x001F733F
		protected UKuroAnimPerfTestComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BB70 RID: 47984
		public new const string __ObjectPath = "/Script/KuroComponent.KuroAnimPerfTestComponent";

		// Token: 0x0400BB71 RID: 47985
		private static IntPtr _ClassPtr;

		// Token: 0x0400BB72 RID: 47986
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BB73 RID: 47987
		internal static int __PropertyOffset_NumSkeletalMeshActorsToGenerate;

		// Token: 0x0400BB74 RID: 47988
		internal static int __PropertyOffset_BornFrom;

		// Token: 0x0400BB75 RID: 47989
		internal static int __PropertyOffset_SkelMeshActorBirthplace;

		// Token: 0x0400BB76 RID: 47990
		internal static int __PropertyOffset_GenMethod;

		// Token: 0x0400BB77 RID: 47991
		internal static int __PropertyOffset_LifeCycle;

		// Token: 0x0400BB78 RID: 47992
		internal static int __PropertyOffset_SkelMeshActorInterval;

		// Token: 0x0400BB79 RID: 47993
		internal static int __PropertyOffset_SkelMeshLOD;

		// Token: 0x0400BB7A RID: 47994
		internal static int __PropertyOffset_SkelMeshTemplate;

		// Token: 0x0400BB7B RID: 47995
		internal static int __PropertyOffset_AnimTemplate;

		// Token: 0x0400BB7C RID: 47996
		internal static int __PropertyOffset_ActorsRandGenGroup;

		// Token: 0x0400BB7D RID: 47997
		internal static int __PropertyOffset_AnimSeqFilterMethod;

		// Token: 0x0400BB7E RID: 47998
		internal static int __PropertyOffset_AnimSeqFilter;

		// Token: 0x0400BB7F RID: 47999
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AnimSeqFilter;

		// Token: 0x0400BB80 RID: 48000
		internal static int __PropertyOffset_RandSkelMeshTemplates;

		// Token: 0x0400BB81 RID: 48001
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USkeletalMesh> _RandSkelMeshTemplates;

		// Token: 0x0400BB82 RID: 48002
		internal static int __PropertyOffset_RandSkelMeshAniSeqs;

		// Token: 0x0400BB83 RID: 48003
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimSequence> _RandSkelMeshAniSeqs;

		// Token: 0x0400BB84 RID: 48004
		internal static int __PropertyOffset_GeneratedSkelMeshActors;

		// Token: 0x0400BB85 RID: 48005
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _GeneratedSkelMeshActors;

		// Token: 0x0400BB86 RID: 48006
		private static IntPtr __GenerateSkeletalMeshActors_NativeFunctionPtr;

		// Token: 0x0400BB87 RID: 48007
		private static IntPtr __DestroySkeletalMeshActors_NativeFunctionPtr;
	}
}
