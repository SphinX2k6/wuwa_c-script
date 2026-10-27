using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026E4 RID: 9956
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneDialogueAudioSection")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UMovieSceneDialogueAudioSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024ECE RID: 151246 RVA: 0x00369D16 File Offset: 0x00367F16
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneDialogueAudioSection._ClassPtr;
		}

		// Token: 0x06024ECF RID: 151247 RVA: 0x00369D24 File Offset: 0x00367F24
		public UMovieSceneDialogueAudioSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueAudioSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024ED0 RID: 151248 RVA: 0x00369D4C File Offset: 0x00367F4C
		public UMovieSceneDialogueAudioSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueAudioSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008E8F RID: 36495
		// (get) Token: 0x06024ED1 RID: 151249 RVA: 0x00369D7F File Offset: 0x00367F7F
		// (set) Token: 0x06024ED2 RID: 151250 RVA: 0x00369D93 File Offset: 0x00367F93
		public unsafe string AudioKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneDialogueAudioSection.__PropertyOffset_AudioKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneDialogueAudioSection.__PropertyOffset_AudioKey)), value);
			}
		}

		// Token: 0x17008E90 RID: 36496
		// (get) Token: 0x06024ED3 RID: 151251 RVA: 0x00369DA8 File Offset: 0x00367FA8
		// (set) Token: 0x06024ED4 RID: 151252 RVA: 0x00369DB8 File Offset: 0x00367FB8
		public unsafe int AudioTransitionDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneDialogueAudioSection.__PropertyOffset_AudioTransitionDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneDialogueAudioSection.__PropertyOffset_AudioTransitionDuration) = value;
			}
		}

		// Token: 0x06024ED5 RID: 151253 RVA: 0x00369DC9 File Offset: 0x00367FC9
		static UMovieSceneDialogueAudioSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneDialogueAudioSection");
		}

		// Token: 0x06024ED6 RID: 151254 RVA: 0x00369DD7 File Offset: 0x00367FD7
		protected UMovieSceneDialogueAudioSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013E5A RID: 81498
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneDialogueAudioSection";

		// Token: 0x04013E5B RID: 81499
		private static IntPtr _ClassPtr;

		// Token: 0x04013E5C RID: 81500
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013E5D RID: 81501
		internal static int __PropertyOffset_AudioKey;

		// Token: 0x04013E5E RID: 81502
		internal static int __PropertyOffset_AudioTransitionDuration;
	}
}
