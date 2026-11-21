using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007D3 RID: 2003
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneSeqAnimDataTrack")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMovieSceneSeqAnimDataTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600ACBE RID: 44222 RVA: 0x000FF059 File Offset: 0x000FD259
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSeqAnimDataTrack._ClassPtr;
		}

		// Token: 0x0600ACBF RID: 44223 RVA: 0x000FF068 File Offset: 0x000FD268
		public UMovieSceneSeqAnimDataTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSeqAnimDataTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600ACC0 RID: 44224 RVA: 0x000FF090 File Offset: 0x000FD290
		public UMovieSceneSeqAnimDataTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSeqAnimDataTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700203C RID: 8252
		// (get) Token: 0x0600ACC1 RID: 44225 RVA: 0x000FF0C4 File Offset: 0x000FD2C4
		// (set) Token: 0x0600ACC2 RID: 44226 RVA: 0x000FF0FD File Offset: 0x000FD2FD
		public TArray<UMovieSceneSection> Sections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneSeqAnimDataTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x0600ACC3 RID: 44227 RVA: 0x000FF10B File Offset: 0x000FD30B
		static UMovieSceneSeqAnimDataTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneSeqAnimDataTrack");
		}

		// Token: 0x0600ACC4 RID: 44228 RVA: 0x000FF119 File Offset: 0x000FD319
		protected UMovieSceneSeqAnimDataTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004A7E RID: 19070
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneSeqAnimDataTrack";

		// Token: 0x04004A7F RID: 19071
		private static IntPtr _ClassPtr;

		// Token: 0x04004A80 RID: 19072
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004A81 RID: 19073
		internal static int __PropertyOffset_Sections;

		// Token: 0x04004A82 RID: 19074
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
