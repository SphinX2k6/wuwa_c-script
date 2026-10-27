using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200112C RID: 4396
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundCue")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class USoundCue : USoundBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010175 RID: 65909 RVA: 0x0017B4BC File Offset: 0x001796BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundCue._ClassPtr;
		}

		// Token: 0x06010176 RID: 65910 RVA: 0x0017B4C8 File Offset: 0x001796C8
		public USoundCue() : this(BuiltinUtils.AllocNativeUObject(USoundCue.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010177 RID: 65911 RVA: 0x0017B4F0 File Offset: 0x001796F0
		public USoundCue(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundCue.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003EFC RID: 16124
		// (get) Token: 0x06010178 RID: 65912 RVA: 0x0017B523 File Offset: 0x00179723
		// (set) Token: 0x06010179 RID: 65913 RVA: 0x0017B53C File Offset: 0x0017973C
		public unsafe bool bPrimeOnLoad
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundCue.__PropertyOffset_bPrimeOnLoad) & USoundCue.__PropertyMask_bPrimeOnLoad) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundCue.__PropertyOffset_bPrimeOnLoad) = ((*(base.NativePtr + (IntPtr)USoundCue.__PropertyOffset_bPrimeOnLoad) & ~USoundCue.__PropertyMask_bPrimeOnLoad) | (value ? USoundCue.__PropertyMask_bPrimeOnLoad : 0));
			}
		}

		// Token: 0x17003EFD RID: 16125
		// (get) Token: 0x0601017A RID: 65914 RVA: 0x0017B56C File Offset: 0x0017976C
		// (set) Token: 0x0601017B RID: 65915 RVA: 0x0017B580 File Offset: 0x00179780
		[Nullable(2)]
		public unsafe USoundNode FirstNode
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundNode>(base.NativePtr / (IntPtr)sizeof(void*) + USoundCue.__PropertyOffset_FirstNode);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USoundCue.__PropertyOffset_FirstNode, value);
			}
		}

		// Token: 0x17003EFE RID: 16126
		// (get) Token: 0x0601017C RID: 65916 RVA: 0x0017B595 File Offset: 0x00179795
		// (set) Token: 0x0601017D RID: 65917 RVA: 0x0017B5A5 File Offset: 0x001797A5
		public unsafe float VolumeMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundCue.__PropertyOffset_VolumeMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundCue.__PropertyOffset_VolumeMultiplier) = value;
			}
		}

		// Token: 0x17003EFF RID: 16127
		// (get) Token: 0x0601017E RID: 65918 RVA: 0x0017B5B6 File Offset: 0x001797B6
		// (set) Token: 0x0601017F RID: 65919 RVA: 0x0017B5C6 File Offset: 0x001797C6
		public unsafe float PitchMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundCue.__PropertyOffset_PitchMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundCue.__PropertyOffset_PitchMultiplier) = value;
			}
		}

		// Token: 0x17003F00 RID: 16128
		// (get) Token: 0x06010180 RID: 65920 RVA: 0x0017B5D8 File Offset: 0x001797D8
		// (set) Token: 0x06010181 RID: 65921 RVA: 0x0017B611 File Offset: 0x00179811
		public FSoundAttenuationSettings AttenuationOverrides
		{
			get
			{
				base.FastCheckIsValid();
				FSoundAttenuationSettings result;
				if ((result = this._AttenuationOverrides) == null)
				{
					result = (this._AttenuationOverrides = new FSoundAttenuationSettings(base.NativePtr + (IntPtr)USoundCue.__PropertyOffset_AttenuationOverrides, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoundAttenuationSettings.StaticStruct(), base.NativePtr + (IntPtr)USoundCue.__PropertyOffset_AttenuationOverrides, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003F01 RID: 16129
		// (get) Token: 0x06010182 RID: 65922 RVA: 0x0017B632 File Offset: 0x00179832
		// (set) Token: 0x06010183 RID: 65923 RVA: 0x0017B642 File Offset: 0x00179842
		public unsafe float SubtitlePriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundCue.__PropertyOffset_SubtitlePriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundCue.__PropertyOffset_SubtitlePriority) = value;
			}
		}

		// Token: 0x17003F02 RID: 16130
		// (get) Token: 0x06010184 RID: 65924 RVA: 0x0017B653 File Offset: 0x00179853
		// (set) Token: 0x06010185 RID: 65925 RVA: 0x0017B66C File Offset: 0x0017986C
		public unsafe bool bOverrideAttenuation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundCue.__PropertyOffset_bOverrideAttenuation) & USoundCue.__PropertyMask_bOverrideAttenuation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundCue.__PropertyOffset_bOverrideAttenuation) = ((*(base.NativePtr + (IntPtr)USoundCue.__PropertyOffset_bOverrideAttenuation) & ~USoundCue.__PropertyMask_bOverrideAttenuation) | (value ? USoundCue.__PropertyMask_bOverrideAttenuation : 0));
			}
		}

		// Token: 0x17003F03 RID: 16131
		// (get) Token: 0x06010186 RID: 65926 RVA: 0x0017B69C File Offset: 0x0017989C
		// (set) Token: 0x06010187 RID: 65927 RVA: 0x0017B6B5 File Offset: 0x001798B5
		public unsafe bool bExcludeFromRandomNodeBranchCulling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundCue.__PropertyOffset_bExcludeFromRandomNodeBranchCulling) & USoundCue.__PropertyMask_bExcludeFromRandomNodeBranchCulling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundCue.__PropertyOffset_bExcludeFromRandomNodeBranchCulling) = ((*(base.NativePtr + (IntPtr)USoundCue.__PropertyOffset_bExcludeFromRandomNodeBranchCulling) & ~USoundCue.__PropertyMask_bExcludeFromRandomNodeBranchCulling) | (value ? USoundCue.__PropertyMask_bExcludeFromRandomNodeBranchCulling : 0));
			}
		}

		// Token: 0x17003F04 RID: 16132
		// (get) Token: 0x06010188 RID: 65928 RVA: 0x0017B6E5 File Offset: 0x001798E5
		// (set) Token: 0x06010189 RID: 65929 RVA: 0x0017B6F5 File Offset: 0x001798F5
		public unsafe int CookedQualityIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundCue.__PropertyOffset_CookedQualityIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundCue.__PropertyOffset_CookedQualityIndex) = value;
			}
		}

		// Token: 0x17003F05 RID: 16133
		// (get) Token: 0x0601018A RID: 65930 RVA: 0x0017B706 File Offset: 0x00179906
		// (set) Token: 0x0601018B RID: 65931 RVA: 0x0017B71F File Offset: 0x0017991F
		public unsafe bool bHasPlayWhenSilent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundCue.__PropertyOffset_bHasPlayWhenSilent) & USoundCue.__PropertyMask_bHasPlayWhenSilent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundCue.__PropertyOffset_bHasPlayWhenSilent) = ((*(base.NativePtr + (IntPtr)USoundCue.__PropertyOffset_bHasPlayWhenSilent) & ~USoundCue.__PropertyMask_bHasPlayWhenSilent) | (value ? USoundCue.__PropertyMask_bHasPlayWhenSilent : 0));
			}
		}

		// Token: 0x0601018C RID: 65932 RVA: 0x0017B74F File Offset: 0x0017994F
		static USoundCue()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundCue");
		}

		// Token: 0x0601018D RID: 65933 RVA: 0x0017B75D File Offset: 0x0017995D
		protected USoundCue(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008A6A RID: 35434
		public new const string __ObjectPath = "/Script/Engine.SoundCue";

		// Token: 0x04008A6B RID: 35435
		private static IntPtr _ClassPtr;

		// Token: 0x04008A6C RID: 35436
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008A6D RID: 35437
		internal static int __PropertyOffset_bPrimeOnLoad;

		// Token: 0x04008A6E RID: 35438
		internal static byte __PropertyMask_bPrimeOnLoad;

		// Token: 0x04008A6F RID: 35439
		internal static int __PropertyOffset_FirstNode;

		// Token: 0x04008A70 RID: 35440
		internal static int __PropertyOffset_VolumeMultiplier;

		// Token: 0x04008A71 RID: 35441
		internal static int __PropertyOffset_PitchMultiplier;

		// Token: 0x04008A72 RID: 35442
		internal static int __PropertyOffset_AttenuationOverrides;

		// Token: 0x04008A73 RID: 35443
		[Nullable(2)]
		private FSoundAttenuationSettings _AttenuationOverrides;

		// Token: 0x04008A74 RID: 35444
		internal static int __PropertyOffset_SubtitlePriority;

		// Token: 0x04008A75 RID: 35445
		internal static int __PropertyOffset_bOverrideAttenuation;

		// Token: 0x04008A76 RID: 35446
		internal static byte __PropertyMask_bOverrideAttenuation;

		// Token: 0x04008A77 RID: 35447
		internal static int __PropertyOffset_bExcludeFromRandomNodeBranchCulling;

		// Token: 0x04008A78 RID: 35448
		internal static byte __PropertyMask_bExcludeFromRandomNodeBranchCulling;

		// Token: 0x04008A79 RID: 35449
		internal static int __PropertyOffset_CookedQualityIndex;

		// Token: 0x04008A7A RID: 35450
		internal static int __PropertyOffset_bHasPlayWhenSilent;

		// Token: 0x04008A7B RID: 35451
		internal static byte __PropertyMask_bHasPlayWhenSilent;
	}
}
