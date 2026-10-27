using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C08 RID: 7176
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMediaAlignSection")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public class UMovieSceneKuroMediaAlignSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601BB0B RID: 113419 RVA: 0x0028C120 File Offset: 0x0028A320
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneKuroMediaAlignSection._ClassPtr;
		}

		// Token: 0x0601BB0C RID: 113420 RVA: 0x0028C12C File Offset: 0x0028A32C
		public UMovieSceneKuroMediaAlignSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneKuroMediaAlignSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601BB0D RID: 113421 RVA: 0x0028C154 File Offset: 0x0028A354
		public UMovieSceneKuroMediaAlignSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneKuroMediaAlignSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006FAF RID: 28591
		// (get) Token: 0x0601BB0E RID: 113422 RVA: 0x0028C187 File Offset: 0x0028A387
		// (set) Token: 0x0601BB0F RID: 113423 RVA: 0x0028C19B File Offset: 0x0028A39B
		public unsafe FName AlignKey
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneKuroMediaAlignSection.__PropertyOffset_AlignKey);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneKuroMediaAlignSection.__PropertyOffset_AlignKey) = value;
			}
		}

		// Token: 0x17006FB0 RID: 28592
		// (get) Token: 0x0601BB10 RID: 113424 RVA: 0x0028C1B0 File Offset: 0x0028A3B0
		// (set) Token: 0x0601BB11 RID: 113425 RVA: 0x0028C1E9 File Offset: 0x0028A3E9
		public FFrameNumber StartFrameOffset
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._StartFrameOffset) == null)
				{
					result = (this._StartFrameOffset = new FFrameNumber(base.NativePtr + (IntPtr)UMovieSceneKuroMediaAlignSection.__PropertyOffset_StartFrameOffset, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneKuroMediaAlignSection.__PropertyOffset_StartFrameOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601BB12 RID: 113426 RVA: 0x0028C20A File Offset: 0x0028A40A
		static UMovieSceneKuroMediaAlignSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMediaAlignSection");
		}

		// Token: 0x0601BB13 RID: 113427 RVA: 0x0028C218 File Offset: 0x0028A418
		protected UMovieSceneKuroMediaAlignSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EE46 RID: 60998
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMediaAlignSection";

		// Token: 0x0400EE47 RID: 60999
		private static IntPtr _ClassPtr;

		// Token: 0x0400EE48 RID: 61000
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EE49 RID: 61001
		internal static int __PropertyOffset_AlignKey;

		// Token: 0x0400EE4A RID: 61002
		internal static int __PropertyOffset_StartFrameOffset;

		// Token: 0x0400EE4B RID: 61003
		[Nullable(2)]
		private FFrameNumber _StartFrameOffset;
	}
}
