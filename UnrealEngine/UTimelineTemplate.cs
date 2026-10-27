using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011EF RID: 4591
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.TimelineTemplate")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UTimelineTemplate : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010EC3 RID: 69315 RVA: 0x0018D753 File Offset: 0x0018B953
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTimelineTemplate._ClassPtr;
		}

		// Token: 0x06010EC4 RID: 69316 RVA: 0x0018D760 File Offset: 0x0018B960
		public UTimelineTemplate() : this(BuiltinUtils.AllocNativeUObject(UTimelineTemplate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010EC5 RID: 69317 RVA: 0x0018D788 File Offset: 0x0018B988
		public UTimelineTemplate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTimelineTemplate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700421C RID: 16924
		// (get) Token: 0x06010EC6 RID: 69318 RVA: 0x0018D7BB File Offset: 0x0018B9BB
		// (set) Token: 0x06010EC7 RID: 69319 RVA: 0x0018D7CB File Offset: 0x0018B9CB
		public unsafe float TimelineLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_TimelineLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_TimelineLength) = value;
			}
		}

		// Token: 0x1700421D RID: 16925
		// (get) Token: 0x06010EC8 RID: 69320 RVA: 0x0018D7DC File Offset: 0x0018B9DC
		// (set) Token: 0x06010EC9 RID: 69321 RVA: 0x0018D7F0 File Offset: 0x0018B9F0
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineLengthMode> LengthMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_LengthMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_LengthMode) = value;
			}
		}

		// Token: 0x1700421E RID: 16926
		// (get) Token: 0x06010ECA RID: 69322 RVA: 0x0018D805 File Offset: 0x0018BA05
		// (set) Token: 0x06010ECB RID: 69323 RVA: 0x0018D81E File Offset: 0x0018BA1E
		public unsafe bool bAutoPlay
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_bAutoPlay) & UTimelineTemplate.__PropertyMask_bAutoPlay) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_bAutoPlay) = ((*(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_bAutoPlay) & ~UTimelineTemplate.__PropertyMask_bAutoPlay) | (value ? UTimelineTemplate.__PropertyMask_bAutoPlay : 0));
			}
		}

		// Token: 0x1700421F RID: 16927
		// (get) Token: 0x06010ECC RID: 69324 RVA: 0x0018D84E File Offset: 0x0018BA4E
		// (set) Token: 0x06010ECD RID: 69325 RVA: 0x0018D867 File Offset: 0x0018BA67
		public unsafe bool bLoop
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_bLoop) & UTimelineTemplate.__PropertyMask_bLoop) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_bLoop) = ((*(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_bLoop) & ~UTimelineTemplate.__PropertyMask_bLoop) | (value ? UTimelineTemplate.__PropertyMask_bLoop : 0));
			}
		}

		// Token: 0x17004220 RID: 16928
		// (get) Token: 0x06010ECE RID: 69326 RVA: 0x0018D897 File Offset: 0x0018BA97
		// (set) Token: 0x06010ECF RID: 69327 RVA: 0x0018D8B0 File Offset: 0x0018BAB0
		public unsafe bool bReplicated
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_bReplicated) & UTimelineTemplate.__PropertyMask_bReplicated) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_bReplicated) = ((*(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_bReplicated) & ~UTimelineTemplate.__PropertyMask_bReplicated) | (value ? UTimelineTemplate.__PropertyMask_bReplicated : 0));
			}
		}

		// Token: 0x17004221 RID: 16929
		// (get) Token: 0x06010ED0 RID: 69328 RVA: 0x0018D8E0 File Offset: 0x0018BAE0
		// (set) Token: 0x06010ED1 RID: 69329 RVA: 0x0018D8F9 File Offset: 0x0018BAF9
		public unsafe bool bIgnoreTimeDilation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_bIgnoreTimeDilation) & UTimelineTemplate.__PropertyMask_bIgnoreTimeDilation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_bIgnoreTimeDilation) = ((*(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_bIgnoreTimeDilation) & ~UTimelineTemplate.__PropertyMask_bIgnoreTimeDilation) | (value ? UTimelineTemplate.__PropertyMask_bIgnoreTimeDilation : 0));
			}
		}

		// Token: 0x17004222 RID: 16930
		// (get) Token: 0x06010ED2 RID: 69330 RVA: 0x0018D92C File Offset: 0x0018BB2C
		// (set) Token: 0x06010ED3 RID: 69331 RVA: 0x0018D965 File Offset: 0x0018BB65
		public TArray<FTTEventTrack> EventTracks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTTEventTrack> result;
				if ((result = this._EventTracks) == null)
				{
					result = (this._EventTracks = new TArray<FTTEventTrack>(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_EventTracks, this));
				}
				return result;
			}
			set
			{
				this.EventTracks.CopyAssign(value);
			}
		}

		// Token: 0x17004223 RID: 16931
		// (get) Token: 0x06010ED4 RID: 69332 RVA: 0x0018D974 File Offset: 0x0018BB74
		// (set) Token: 0x06010ED5 RID: 69333 RVA: 0x0018D9AD File Offset: 0x0018BBAD
		public TArray<FTTFloatTrack> FloatTracks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTTFloatTrack> result;
				if ((result = this._FloatTracks) == null)
				{
					result = (this._FloatTracks = new TArray<FTTFloatTrack>(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_FloatTracks, this));
				}
				return result;
			}
			set
			{
				this.FloatTracks.CopyAssign(value);
			}
		}

		// Token: 0x17004224 RID: 16932
		// (get) Token: 0x06010ED6 RID: 69334 RVA: 0x0018D9BC File Offset: 0x0018BBBC
		// (set) Token: 0x06010ED7 RID: 69335 RVA: 0x0018D9F5 File Offset: 0x0018BBF5
		public TArray<FTTVectorTrack> VectorTracks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTTVectorTrack> result;
				if ((result = this._VectorTracks) == null)
				{
					result = (this._VectorTracks = new TArray<FTTVectorTrack>(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_VectorTracks, this));
				}
				return result;
			}
			set
			{
				this.VectorTracks.CopyAssign(value);
			}
		}

		// Token: 0x17004225 RID: 16933
		// (get) Token: 0x06010ED8 RID: 69336 RVA: 0x0018DA04 File Offset: 0x0018BC04
		// (set) Token: 0x06010ED9 RID: 69337 RVA: 0x0018DA3D File Offset: 0x0018BC3D
		public TArray<FTTLinearColorTrack> LinearColorTracks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTTLinearColorTrack> result;
				if ((result = this._LinearColorTracks) == null)
				{
					result = (this._LinearColorTracks = new TArray<FTTLinearColorTrack>(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_LinearColorTracks, this));
				}
				return result;
			}
			set
			{
				this.LinearColorTracks.CopyAssign(value);
			}
		}

		// Token: 0x17004226 RID: 16934
		// (get) Token: 0x06010EDA RID: 69338 RVA: 0x0018DA4C File Offset: 0x0018BC4C
		// (set) Token: 0x06010EDB RID: 69339 RVA: 0x0018DA85 File Offset: 0x0018BC85
		public TArray<FBPVariableMetaDataEntry> MetaDataArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBPVariableMetaDataEntry> result;
				if ((result = this._MetaDataArray) == null)
				{
					result = (this._MetaDataArray = new TArray<FBPVariableMetaDataEntry>(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_MetaDataArray, this));
				}
				return result;
			}
			set
			{
				this.MetaDataArray.CopyAssign(value);
			}
		}

		// Token: 0x17004227 RID: 16935
		// (get) Token: 0x06010EDC RID: 69340 RVA: 0x0018DA93 File Offset: 0x0018BC93
		// (set) Token: 0x06010EDD RID: 69341 RVA: 0x0018DAA7 File Offset: 0x0018BCA7
		public unsafe FGuid TimelineGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_TimelineGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_TimelineGuid) = value;
			}
		}

		// Token: 0x17004228 RID: 16936
		// (get) Token: 0x06010EDE RID: 69342 RVA: 0x0018DABC File Offset: 0x0018BCBC
		// (set) Token: 0x06010EDF RID: 69343 RVA: 0x0018DAD0 File Offset: 0x0018BCD0
		public unsafe FName VariableName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_VariableName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_VariableName) = value;
			}
		}

		// Token: 0x17004229 RID: 16937
		// (get) Token: 0x06010EE0 RID: 69344 RVA: 0x0018DAE5 File Offset: 0x0018BCE5
		// (set) Token: 0x06010EE1 RID: 69345 RVA: 0x0018DAF9 File Offset: 0x0018BCF9
		public unsafe FName DirectionPropertyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_DirectionPropertyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_DirectionPropertyName) = value;
			}
		}

		// Token: 0x1700422A RID: 16938
		// (get) Token: 0x06010EE2 RID: 69346 RVA: 0x0018DB0E File Offset: 0x0018BD0E
		// (set) Token: 0x06010EE3 RID: 69347 RVA: 0x0018DB22 File Offset: 0x0018BD22
		public unsafe FName UpdateFunctionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_UpdateFunctionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_UpdateFunctionName) = value;
			}
		}

		// Token: 0x1700422B RID: 16939
		// (get) Token: 0x06010EE4 RID: 69348 RVA: 0x0018DB37 File Offset: 0x0018BD37
		// (set) Token: 0x06010EE5 RID: 69349 RVA: 0x0018DB4B File Offset: 0x0018BD4B
		public unsafe FName FinishedFunctionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_FinishedFunctionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTimelineTemplate.__PropertyOffset_FinishedFunctionName) = value;
			}
		}

		// Token: 0x06010EE6 RID: 69350 RVA: 0x0018DB60 File Offset: 0x0018BD60
		static UTimelineTemplate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TimelineTemplate");
		}

		// Token: 0x06010EE7 RID: 69351 RVA: 0x0018DB6E File Offset: 0x0018BD6E
		protected UTimelineTemplate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009106 RID: 37126
		public new const string __ObjectPath = "/Script/Engine.TimelineTemplate";

		// Token: 0x04009107 RID: 37127
		private static IntPtr _ClassPtr;

		// Token: 0x04009108 RID: 37128
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009109 RID: 37129
		internal static int __PropertyOffset_TimelineLength;

		// Token: 0x0400910A RID: 37130
		internal static int __PropertyOffset_LengthMode;

		// Token: 0x0400910B RID: 37131
		internal static int __PropertyOffset_bAutoPlay;

		// Token: 0x0400910C RID: 37132
		internal static byte __PropertyMask_bAutoPlay;

		// Token: 0x0400910D RID: 37133
		internal static int __PropertyOffset_bLoop;

		// Token: 0x0400910E RID: 37134
		internal static byte __PropertyMask_bLoop;

		// Token: 0x0400910F RID: 37135
		internal static int __PropertyOffset_bReplicated;

		// Token: 0x04009110 RID: 37136
		internal static byte __PropertyMask_bReplicated;

		// Token: 0x04009111 RID: 37137
		internal static int __PropertyOffset_bIgnoreTimeDilation;

		// Token: 0x04009112 RID: 37138
		internal static byte __PropertyMask_bIgnoreTimeDilation;

		// Token: 0x04009113 RID: 37139
		internal static int __PropertyOffset_EventTracks;

		// Token: 0x04009114 RID: 37140
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTTEventTrack> _EventTracks;

		// Token: 0x04009115 RID: 37141
		internal static int __PropertyOffset_FloatTracks;

		// Token: 0x04009116 RID: 37142
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTTFloatTrack> _FloatTracks;

		// Token: 0x04009117 RID: 37143
		internal static int __PropertyOffset_VectorTracks;

		// Token: 0x04009118 RID: 37144
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTTVectorTrack> _VectorTracks;

		// Token: 0x04009119 RID: 37145
		internal static int __PropertyOffset_LinearColorTracks;

		// Token: 0x0400911A RID: 37146
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTTLinearColorTrack> _LinearColorTracks;

		// Token: 0x0400911B RID: 37147
		internal static int __PropertyOffset_MetaDataArray;

		// Token: 0x0400911C RID: 37148
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBPVariableMetaDataEntry> _MetaDataArray;

		// Token: 0x0400911D RID: 37149
		internal static int __PropertyOffset_TimelineGuid;

		// Token: 0x0400911E RID: 37150
		internal static int __PropertyOffset_VariableName;

		// Token: 0x0400911F RID: 37151
		internal static int __PropertyOffset_DirectionPropertyName;

		// Token: 0x04009120 RID: 37152
		internal static int __PropertyOffset_UpdateFunctionName;

		// Token: 0x04009121 RID: 37153
		internal static int __PropertyOffset_FinishedFunctionName;
	}
}
