using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002378 RID: 9080
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEventTriggerSection")]
	[UnrealStructLayout(456, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 456)]
	public class UMovieSceneEventTriggerSection : UMovieSceneEventSectionBase, IUnrealUObject, IUnrealObject, IMovieSceneEntityProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022419 RID: 140313 RVA: 0x0032A857 File Offset: 0x00328A57
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneEventTriggerSection._ClassPtr;
		}

		// Token: 0x0602241A RID: 140314 RVA: 0x0032A863 File Offset: 0x00328A63
		int IMovieSceneEntityProvider.InterfaceOffset()
		{
			return UMovieSceneEventTriggerSection.__InterfaceOffset_IMovieSceneEntityProvider;
		}

		// Token: 0x0602241B RID: 140315 RVA: 0x0032A86C File Offset: 0x00328A6C
		public UMovieSceneEventTriggerSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEventTriggerSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602241C RID: 140316 RVA: 0x0032A894 File Offset: 0x00328A94
		[NullableContext(1)]
		public UMovieSceneEventTriggerSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEventTriggerSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700842A RID: 33834
		// (get) Token: 0x0602241D RID: 140317 RVA: 0x0032A8C8 File Offset: 0x00328AC8
		// (set) Token: 0x0602241E RID: 140318 RVA: 0x0032A901 File Offset: 0x00328B01
		[Nullable(1)]
		public FMovieSceneEventChannel EventChannel
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEventChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneEventTriggerSection.__PropertyOffset_EventChannel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602241F RID: 140319 RVA: 0x0032A922 File Offset: 0x00328B22
		static UMovieSceneEventTriggerSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneEventTriggerSection");
		}

		// Token: 0x06022420 RID: 140320 RVA: 0x0032A930 File Offset: 0x00328B30
		protected UMovieSceneEventTriggerSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012493 RID: 74899
		internal static int __InterfaceOffset_IMovieSceneEntityProvider;

		// Token: 0x04012494 RID: 74900
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEventTriggerSection";

		// Token: 0x04012495 RID: 74901
		private static IntPtr _ClassPtr;

		// Token: 0x04012496 RID: 74902
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012497 RID: 74903
		internal static int __PropertyOffset_EventChannel;

		// Token: 0x04012498 RID: 74904
		[Nullable(2)]
		private FMovieSceneEventChannel _EventChannel;
	}
}
