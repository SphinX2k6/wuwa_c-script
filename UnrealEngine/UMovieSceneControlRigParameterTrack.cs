using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000514 RID: 1300
	[UnrealObjectPath("/Script/ControlRig.MovieSceneControlRigParameterTrack")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UMovieSceneControlRigParameterTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface, INodeAndChannelMappings
	{
		// Token: 0x060043E6 RID: 17382 RVA: 0x000652A0 File Offset: 0x000634A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneControlRigParameterTrack._ClassPtr;
		}

		// Token: 0x060043E7 RID: 17383 RVA: 0x000652AC File Offset: 0x000634AC
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneControlRigParameterTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x060043E8 RID: 17384 RVA: 0x000652B3 File Offset: 0x000634B3
		int INodeAndChannelMappings.InterfaceOffset()
		{
			return UMovieSceneControlRigParameterTrack.__InterfaceOffset_INodeAndChannelMappings;
		}

		// Token: 0x060043E9 RID: 17385 RVA: 0x000652BC File Offset: 0x000634BC
		public UMovieSceneControlRigParameterTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneControlRigParameterTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060043EA RID: 17386 RVA: 0x000652E4 File Offset: 0x000634E4
		[NullableContext(1)]
		public UMovieSceneControlRigParameterTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneControlRigParameterTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x060043EB RID: 17387 RVA: 0x00065317 File Offset: 0x00063517
		// (set) Token: 0x060043EC RID: 17388 RVA: 0x0006532B File Offset: 0x0006352B
		[Nullable(2)]
		public unsafe UControlRig ControlRig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UControlRig>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneControlRigParameterTrack.__PropertyOffset_ControlRig);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneControlRigParameterTrack.__PropertyOffset_ControlRig, value);
			}
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x060043ED RID: 17389 RVA: 0x00065340 File Offset: 0x00063540
		// (set) Token: 0x060043EE RID: 17390 RVA: 0x00065354 File Offset: 0x00063554
		[Nullable(2)]
		public unsafe UMovieSceneSection SectionToKey
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneSection>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneControlRigParameterTrack.__PropertyOffset_SectionToKey);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneControlRigParameterTrack.__PropertyOffset_SectionToKey, value);
			}
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x060043EF RID: 17391 RVA: 0x0006536C File Offset: 0x0006356C
		// (set) Token: 0x060043F0 RID: 17392 RVA: 0x000653A5 File Offset: 0x000635A5
		[Nullable(1)]
		public TArray<UMovieSceneSection> Sections
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneControlRigParameterTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x060043F1 RID: 17393 RVA: 0x000653B3 File Offset: 0x000635B3
		// (set) Token: 0x060043F2 RID: 17394 RVA: 0x000653C7 File Offset: 0x000635C7
		public unsafe FName TrackName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneControlRigParameterTrack.__PropertyOffset_TrackName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneControlRigParameterTrack.__PropertyOffset_TrackName) = value;
			}
		}

		// Token: 0x060043F3 RID: 17395 RVA: 0x000653DC File Offset: 0x000635DC
		static UMovieSceneControlRigParameterTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ControlRig.MovieSceneControlRigParameterTrack");
		}

		// Token: 0x060043F4 RID: 17396 RVA: 0x000653EA File Offset: 0x000635EA
		protected UMovieSceneControlRigParameterTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002113 RID: 8467
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04002114 RID: 8468
		internal static int __InterfaceOffset_INodeAndChannelMappings;

		// Token: 0x04002115 RID: 8469
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.MovieSceneControlRigParameterTrack";

		// Token: 0x04002116 RID: 8470
		private static IntPtr _ClassPtr;

		// Token: 0x04002117 RID: 8471
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002118 RID: 8472
		internal static int __PropertyOffset_ControlRig;

		// Token: 0x04002119 RID: 8473
		internal static int __PropertyOffset_SectionToKey;

		// Token: 0x0400211A RID: 8474
		internal static int __PropertyOffset_Sections;

		// Token: 0x0400211B RID: 8475
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;

		// Token: 0x0400211C RID: 8476
		internal static int __PropertyOffset_TrackName;
	}
}
