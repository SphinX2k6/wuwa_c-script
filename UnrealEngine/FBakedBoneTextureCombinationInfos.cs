using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000898 RID: 2200
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneTextureCombinationInfos")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FBakedBoneTextureCombinationInfos : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600785A RID: 30810 RVA: 0x000AC512 File Offset: 0x000AA712
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedBoneTextureCombinationInfos._ScriptStructPtr != 0) ? FBakedBoneTextureCombinationInfos._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedBoneTextureCombinationInfos", ref FBakedBoneTextureCombinationInfos._ScriptStructPtr);
		}

		// Token: 0x17001C6C RID: 7276
		// (get) Token: 0x0600785B RID: 30811 RVA: 0x000AC536 File Offset: 0x000AA736
		// (set) Token: 0x0600785C RID: 30812 RVA: 0x000AC546 File Offset: 0x000AA746
		public unsafe int NumAnimTextures
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneTextureCombinationInfos.__PropertyOffset_NumAnimTextures);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneTextureCombinationInfos.__PropertyOffset_NumAnimTextures) = value;
			}
		}

		// Token: 0x17001C6D RID: 7277
		// (get) Token: 0x0600785D RID: 30813 RVA: 0x000AC557 File Offset: 0x000AA757
		// (set) Token: 0x0600785E RID: 30814 RVA: 0x000AC567 File Offset: 0x000AA767
		public unsafe int NumNoiseTextures
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneTextureCombinationInfos.__PropertyOffset_NumNoiseTextures);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneTextureCombinationInfos.__PropertyOffset_NumNoiseTextures) = value;
			}
		}

		// Token: 0x17001C6E RID: 7278
		// (get) Token: 0x0600785F RID: 30815 RVA: 0x000AC578 File Offset: 0x000AA778
		// (set) Token: 0x06007860 RID: 30816 RVA: 0x000AC5BB File Offset: 0x000AA7BB
		public TArray<int> NumTracks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._NumTracks) == null)
				{
					result = (this._NumTracks = new TArray<int>(base.NativePtr + (IntPtr)FBakedBoneTextureCombinationInfos.__PropertyOffset_NumTracks, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NumTracks.CopyAssign(value);
			}
		}

		// Token: 0x17001C6F RID: 7279
		// (get) Token: 0x06007861 RID: 30817 RVA: 0x000AC5CC File Offset: 0x000AA7CC
		// (set) Token: 0x06007862 RID: 30818 RVA: 0x000AC60F File Offset: 0x000AA80F
		public TArray<int> NumFrames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._NumFrames) == null)
				{
					result = (this._NumFrames = new TArray<int>(base.NativePtr + (IntPtr)FBakedBoneTextureCombinationInfos.__PropertyOffset_NumFrames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NumFrames.CopyAssign(value);
			}
		}

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x06007863 RID: 30819 RVA: 0x000AC620 File Offset: 0x000AA820
		// (set) Token: 0x06007864 RID: 30820 RVA: 0x000AC663 File Offset: 0x000AA863
		public TArray<float> AnimTimes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._AnimTimes) == null)
				{
					result = (this._AnimTimes = new TArray<float>(base.NativePtr + (IntPtr)FBakedBoneTextureCombinationInfos.__PropertyOffset_AnimTimes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AnimTimes.CopyAssign(value);
			}
		}

		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x06007865 RID: 30821 RVA: 0x000AC674 File Offset: 0x000AA874
		// (set) Token: 0x06007866 RID: 30822 RVA: 0x000AC6B7 File Offset: 0x000AA8B7
		public TArray<FBakedBoneMorphInfo> MorphInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedBoneMorphInfo> result;
				if ((result = this._MorphInfos) == null)
				{
					result = (this._MorphInfos = new TArray<FBakedBoneMorphInfo>(base.NativePtr + (IntPtr)FBakedBoneTextureCombinationInfos.__PropertyOffset_MorphInfos, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MorphInfos.CopyAssign(value);
			}
		}

		// Token: 0x06007867 RID: 30823 RVA: 0x000AC6C5 File Offset: 0x000AA8C5
		public FBakedBoneTextureCombinationInfos()
		{
		}

		// Token: 0x06007868 RID: 30824 RVA: 0x000AC6CD File Offset: 0x000AA8CD
		public FBakedBoneTextureCombinationInfos(int NumAnimTextures, int NumNoiseTextures, TArray<UAnimSequenceBase> AnimSeqsBakedFrom, TArray<int> NumTracks, TArray<int> NumFrames, TArray<float> AnimTimes, TArray<FBakedBoneMorphInfo> MorphInfos)
		{
			this.NumAnimTextures = NumAnimTextures;
			this.NumNoiseTextures = NumNoiseTextures;
			this.NumTracks = NumTracks;
			this.NumFrames = NumFrames;
			this.AnimTimes = AnimTimes;
			this.MorphInfos = MorphInfos;
		}

		// Token: 0x06007869 RID: 30825 RVA: 0x000AC703 File Offset: 0x000AA903
		protected override IntPtr GetUStructPtr()
		{
			return FBakedBoneTextureCombinationInfos.StaticStruct();
		}

		// Token: 0x0600786A RID: 30826 RVA: 0x000AC70F File Offset: 0x000AA90F
		[NullableContext(2)]
		public FBakedBoneTextureCombinationInfos(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600786B RID: 30827 RVA: 0x000AC719 File Offset: 0x000AA919
		public FBakedBoneTextureCombinationInfos(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600786C RID: 30828 RVA: 0x000AC724 File Offset: 0x000AA924
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedBoneTextureCombinationInfos(Pointer, false, true);
		}

		// Token: 0x0600786D RID: 30829 RVA: 0x000AC72E File Offset: 0x000AA92E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedBoneTextureCombinationInfos(Pointer, MemoryOwner);
		}

		// Token: 0x040039CD RID: 14797
		public const string __ObjectPath = "/Script/Engine.BakedBoneTextureCombinationInfos";

		// Token: 0x040039CE RID: 14798
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040039CF RID: 14799
		internal static int __PropertyOffset_NumAnimTextures;

		// Token: 0x040039D0 RID: 14800
		internal static int __PropertyOffset_NumNoiseTextures;

		// Token: 0x040039D1 RID: 14801
		internal static int __PropertyOffset_NumTracks;

		// Token: 0x040039D2 RID: 14802
		[Nullable(2)]
		private TArray<int> _NumTracks;

		// Token: 0x040039D3 RID: 14803
		internal static int __PropertyOffset_NumFrames;

		// Token: 0x040039D4 RID: 14804
		[Nullable(2)]
		private TArray<int> _NumFrames;

		// Token: 0x040039D5 RID: 14805
		internal static int __PropertyOffset_AnimTimes;

		// Token: 0x040039D6 RID: 14806
		[Nullable(2)]
		private TArray<float> _AnimTimes;

		// Token: 0x040039D7 RID: 14807
		internal static int __PropertyOffset_MorphInfos;

		// Token: 0x040039D8 RID: 14808
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedBoneMorphInfo> _MorphInfos;
	}
}
