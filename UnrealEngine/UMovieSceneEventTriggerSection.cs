using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000769 RID: 1897
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEventTriggerSection")]
	[UnrealStructLayout(472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class UMovieSceneEventTriggerSection : UMovieSceneEventSectionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A4AF RID: 42159 RVA: 0x000F33C6 File Offset: 0x000F15C6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneEventTriggerSection._ClassPtr;
		}

		// Token: 0x0600A4B0 RID: 42160 RVA: 0x000F33D4 File Offset: 0x000F15D4
		public UMovieSceneEventTriggerSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEventTriggerSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A4B1 RID: 42161 RVA: 0x000F33FC File Offset: 0x000F15FC
		public UMovieSceneEventTriggerSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEventTriggerSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E70 RID: 7792
		// (get) Token: 0x0600A4B2 RID: 42162 RVA: 0x000F3430 File Offset: 0x000F1630
		// (set) Token: 0x0600A4B3 RID: 42163 RVA: 0x000F3469 File Offset: 0x000F1669
		public FMovieSceneEventChannel EventChannel
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEventChannel result;
				if ((result = this._EventChannel) == null)
				{
					result = (this._EventChannel = new FMovieSceneEventChannel(base.NativePtr + (IntPtr)UMovieSceneEventTriggerSection.__PropertyOffset_EventChannel, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEventChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneEventTriggerSection.__PropertyOffset_EventChannel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600A4B4 RID: 42164 RVA: 0x000F348A File Offset: 0x000F168A
		static UMovieSceneEventTriggerSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneEventTriggerSection");
		}

		// Token: 0x0600A4B5 RID: 42165 RVA: 0x000F3498 File Offset: 0x000F1698
		protected UMovieSceneEventTriggerSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004642 RID: 17986
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEventTriggerSection";

		// Token: 0x04004643 RID: 17987
		private static IntPtr _ClassPtr;

		// Token: 0x04004644 RID: 17988
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004645 RID: 17989
		internal static int __PropertyOffset_EventChannel;

		// Token: 0x04004646 RID: 17990
		[Nullable(2)]
		private FMovieSceneEventChannel _EventChannel;
	}
}
