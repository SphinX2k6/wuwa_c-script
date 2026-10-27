using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026FA RID: 9978
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneQteTriggerSection")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 440)]
	public class UMovieSceneQteTriggerSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602501F RID: 151583 RVA: 0x0036BFCF File Offset: 0x0036A1CF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneQteTriggerSection._ClassPtr;
		}

		// Token: 0x06025020 RID: 151584 RVA: 0x0036BFDC File Offset: 0x0036A1DC
		public UMovieSceneQteTriggerSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneQteTriggerSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025021 RID: 151585 RVA: 0x0036C004 File Offset: 0x0036A204
		public UMovieSceneQteTriggerSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneQteTriggerSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008EE6 RID: 36582
		// (get) Token: 0x06025022 RID: 151586 RVA: 0x0036C038 File Offset: 0x0036A238
		// (set) Token: 0x06025023 RID: 151587 RVA: 0x0036C071 File Offset: 0x0036A271
		public FMovieSceneQteTriggerChannel DataChannel
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneQteTriggerChannel result;
				if ((result = this._DataChannel) == null)
				{
					result = (this._DataChannel = new FMovieSceneQteTriggerChannel(base.NativePtr + (IntPtr)UMovieSceneQteTriggerSection.__PropertyOffset_DataChannel, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneQteTriggerChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneQteTriggerSection.__PropertyOffset_DataChannel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06025024 RID: 151588 RVA: 0x0036C092 File Offset: 0x0036A292
		static UMovieSceneQteTriggerSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneQteTriggerSection");
		}

		// Token: 0x06025025 RID: 151589 RVA: 0x0036C0A0 File Offset: 0x0036A2A0
		protected UMovieSceneQteTriggerSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013F17 RID: 81687
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneQteTriggerSection";

		// Token: 0x04013F18 RID: 81688
		private static IntPtr _ClassPtr;

		// Token: 0x04013F19 RID: 81689
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013F1A RID: 81690
		internal static int __PropertyOffset_DataChannel;

		// Token: 0x04013F1B RID: 81691
		[Nullable(2)]
		private FMovieSceneQteTriggerChannel _DataChannel;
	}
}
