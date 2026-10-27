using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000897 RID: 2199
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneTexture2D")]
	[UnrealStructLayout(4192, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4192)]
	public class UBakedBoneTexture2D : UTexture2D, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007839 RID: 30777 RVA: 0x000AC2B2 File Offset: 0x000AA4B2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBakedBoneTexture2D._ClassPtr;
		}

		// Token: 0x0600783A RID: 30778 RVA: 0x000AC2C0 File Offset: 0x000AA4C0
		public UBakedBoneTexture2D() : this(BuiltinUtils.AllocNativeUObject(UBakedBoneTexture2D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600783B RID: 30779 RVA: 0x000AC2E8 File Offset: 0x000AA4E8
		public UBakedBoneTexture2D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBakedBoneTexture2D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C63 RID: 7267
		// (get) Token: 0x0600783C RID: 30780 RVA: 0x000AC31B File Offset: 0x000AA51B
		// (set) Token: 0x0600783D RID: 30781 RVA: 0x000AC32B File Offset: 0x000AA52B
		public unsafe int TextureWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneTexture2D.__PropertyOffset_TextureWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneTexture2D.__PropertyOffset_TextureWidth) = value;
			}
		}

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x0600783E RID: 30782 RVA: 0x000AC33C File Offset: 0x000AA53C
		// (set) Token: 0x0600783F RID: 30783 RVA: 0x000AC34C File Offset: 0x000AA54C
		public unsafe int TextureHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneTexture2D.__PropertyOffset_TextureHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneTexture2D.__PropertyOffset_TextureHeight) = value;
			}
		}

		// Token: 0x17001C65 RID: 7269
		// (get) Token: 0x06007840 RID: 30784 RVA: 0x000AC35D File Offset: 0x000AA55D
		// (set) Token: 0x06007841 RID: 30785 RVA: 0x000AC36D File Offset: 0x000AA56D
		public unsafe int NumFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneTexture2D.__PropertyOffset_NumFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneTexture2D.__PropertyOffset_NumFrames) = value;
			}
		}

		// Token: 0x17001C66 RID: 7270
		// (get) Token: 0x06007842 RID: 30786 RVA: 0x000AC37E File Offset: 0x000AA57E
		// (set) Token: 0x06007843 RID: 30787 RVA: 0x000AC38E File Offset: 0x000AA58E
		public unsafe int NumTracks
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneTexture2D.__PropertyOffset_NumTracks);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneTexture2D.__PropertyOffset_NumTracks) = value;
			}
		}

		// Token: 0x17001C67 RID: 7271
		// (get) Token: 0x06007844 RID: 30788 RVA: 0x000AC39F File Offset: 0x000AA59F
		// (set) Token: 0x06007845 RID: 30789 RVA: 0x000AC3AF File Offset: 0x000AA5AF
		public unsafe float AnimTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneTexture2D.__PropertyOffset_AnimTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneTexture2D.__PropertyOffset_AnimTime) = value;
			}
		}

		// Token: 0x17001C68 RID: 7272
		// (get) Token: 0x06007846 RID: 30790 RVA: 0x000AC3C0 File Offset: 0x000AA5C0
		// (set) Token: 0x06007847 RID: 30791 RVA: 0x000AC3D0 File Offset: 0x000AA5D0
		public unsafe float FrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneTexture2D.__PropertyOffset_FrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneTexture2D.__PropertyOffset_FrameRate) = value;
			}
		}

		// Token: 0x17001C69 RID: 7273
		// (get) Token: 0x06007848 RID: 30792 RVA: 0x000AC3E1 File Offset: 0x000AA5E1
		// (set) Token: 0x06007849 RID: 30793 RVA: 0x000AC3F1 File Offset: 0x000AA5F1
		public unsafe bool bIsCombined
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneTexture2D.__PropertyOffset_bIsCombined) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneTexture2D.__PropertyOffset_bIsCombined) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C6A RID: 7274
		// (get) Token: 0x0600784A RID: 30794 RVA: 0x000AC404 File Offset: 0x000AA604
		// (set) Token: 0x0600784B RID: 30795 RVA: 0x000AC43D File Offset: 0x000AA63D
		public FBakedBoneTextureCombinationInfos CombinationInfos
		{
			get
			{
				base.FastCheckIsValid();
				FBakedBoneTextureCombinationInfos result;
				if ((result = this._CombinationInfos) == null)
				{
					result = (this._CombinationInfos = new FBakedBoneTextureCombinationInfos(base.NativePtr + (IntPtr)UBakedBoneTexture2D.__PropertyOffset_CombinationInfos, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBakedBoneTextureCombinationInfos.StaticStruct(), base.NativePtr + (IntPtr)UBakedBoneTexture2D.__PropertyOffset_CombinationInfos, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001C6B RID: 7275
		// (get) Token: 0x0600784C RID: 30796 RVA: 0x000AC460 File Offset: 0x000AA660
		// (set) Token: 0x0600784D RID: 30797 RVA: 0x000AC499 File Offset: 0x000AA699
		public FBakedBoneMorphInfo MorphInfo
		{
			get
			{
				base.FastCheckIsValid();
				FBakedBoneMorphInfo result;
				if ((result = this._MorphInfo) == null)
				{
					result = (this._MorphInfo = new FBakedBoneMorphInfo(base.NativePtr + (IntPtr)UBakedBoneTexture2D.__PropertyOffset_MorphInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBakedBoneMorphInfo.StaticStruct(), base.NativePtr + (IntPtr)UBakedBoneTexture2D.__PropertyOffset_MorphInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600784E RID: 30798 RVA: 0x000AC4BA File Offset: 0x000AA6BA
		public bool IsCombined()
		{
			return UBakedBoneTexture2D.__IsCombined_Internal(base.NativePtr);
		}

		// Token: 0x0600784F RID: 30799 RVA: 0x000AC4C7 File Offset: 0x000AA6C7
		public int GetNumTotalFrames()
		{
			return UBakedBoneTexture2D.__GetNumTotalFrames_Internal(base.NativePtr);
		}

		// Token: 0x06007850 RID: 30800 RVA: 0x000AC4D4 File Offset: 0x000AA6D4
		public int GetNumNoiseTextures()
		{
			return UBakedBoneTexture2D.__GetNumNoiseTextures_Internal(base.NativePtr);
		}

		// Token: 0x06007851 RID: 30801 RVA: 0x000AC4E1 File Offset: 0x000AA6E1
		public int GetNumMaxTracks()
		{
			return UBakedBoneTexture2D.__GetNumMaxTracks_Internal(base.NativePtr);
		}

		// Token: 0x06007852 RID: 30802 RVA: 0x000AC4EE File Offset: 0x000AA6EE
		public int GetNumAnimTextures()
		{
			return UBakedBoneTexture2D.__GetNumAnimTextures_Internal(base.NativePtr);
		}

		// Token: 0x06007853 RID: 30803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsCombined_Internal(IntPtr @this);

		// Token: 0x06007854 RID: 30804
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumTotalFrames_Internal(IntPtr @this);

		// Token: 0x06007855 RID: 30805
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumNoiseTextures_Internal(IntPtr @this);

		// Token: 0x06007856 RID: 30806
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumMaxTracks_Internal(IntPtr @this);

		// Token: 0x06007857 RID: 30807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumAnimTextures_Internal(IntPtr @this);

		// Token: 0x06007858 RID: 30808 RVA: 0x000AC4FB File Offset: 0x000AA6FB
		static UBakedBoneTexture2D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BakedBoneTexture2D");
		}

		// Token: 0x06007859 RID: 30809 RVA: 0x000AC509 File Offset: 0x000AA709
		protected UBakedBoneTexture2D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040039BF RID: 14783
		public new const string __ObjectPath = "/Script/Engine.BakedBoneTexture2D";

		// Token: 0x040039C0 RID: 14784
		private static IntPtr _ClassPtr;

		// Token: 0x040039C1 RID: 14785
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040039C2 RID: 14786
		internal static int __PropertyOffset_TextureWidth;

		// Token: 0x040039C3 RID: 14787
		internal static int __PropertyOffset_TextureHeight;

		// Token: 0x040039C4 RID: 14788
		internal static int __PropertyOffset_NumFrames;

		// Token: 0x040039C5 RID: 14789
		internal static int __PropertyOffset_NumTracks;

		// Token: 0x040039C6 RID: 14790
		internal static int __PropertyOffset_AnimTime;

		// Token: 0x040039C7 RID: 14791
		internal static int __PropertyOffset_FrameRate;

		// Token: 0x040039C8 RID: 14792
		internal static int __PropertyOffset_bIsCombined;

		// Token: 0x040039C9 RID: 14793
		internal static int __PropertyOffset_CombinationInfos;

		// Token: 0x040039CA RID: 14794
		[Nullable(2)]
		private FBakedBoneTextureCombinationInfos _CombinationInfos;

		// Token: 0x040039CB RID: 14795
		internal static int __PropertyOffset_MorphInfo;

		// Token: 0x040039CC RID: 14796
		[Nullable(2)]
		private FBakedBoneMorphInfo _MorphInfo;
	}
}
