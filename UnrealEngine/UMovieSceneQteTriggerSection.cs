using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007D2 RID: 2002
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneQteTriggerSection")]
	[UnrealStructLayout(456, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 456)]
	public class UMovieSceneQteTriggerSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600ACB7 RID: 44215 RVA: 0x000FEF7D File Offset: 0x000FD17D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneQteTriggerSection._ClassPtr;
		}

		// Token: 0x0600ACB8 RID: 44216 RVA: 0x000FEF8C File Offset: 0x000FD18C
		public UMovieSceneQteTriggerSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneQteTriggerSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600ACB9 RID: 44217 RVA: 0x000FEFB4 File Offset: 0x000FD1B4
		public UMovieSceneQteTriggerSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneQteTriggerSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700203B RID: 8251
		// (get) Token: 0x0600ACBA RID: 44218 RVA: 0x000FEFE8 File Offset: 0x000FD1E8
		// (set) Token: 0x0600ACBB RID: 44219 RVA: 0x000FF021 File Offset: 0x000FD221
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

		// Token: 0x0600ACBC RID: 44220 RVA: 0x000FF042 File Offset: 0x000FD242
		static UMovieSceneQteTriggerSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneQteTriggerSection");
		}

		// Token: 0x0600ACBD RID: 44221 RVA: 0x000FF050 File Offset: 0x000FD250
		protected UMovieSceneQteTriggerSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004A79 RID: 19065
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneQteTriggerSection";

		// Token: 0x04004A7A RID: 19066
		private static IntPtr _ClassPtr;

		// Token: 0x04004A7B RID: 19067
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004A7C RID: 19068
		internal static int __PropertyOffset_DataChannel;

		// Token: 0x04004A7D RID: 19069
		[Nullable(2)]
		private FMovieSceneQteTriggerChannel _DataChannel;
	}
}
