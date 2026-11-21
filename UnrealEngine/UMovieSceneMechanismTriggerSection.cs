using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000464 RID: 1124
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismTriggerSection")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UMovieSceneMechanismTriggerSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006B82 RID: 27522 RVA: 0x0009C816 File Offset: 0x0009AA16
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneMechanismTriggerSection._ClassPtr;
		}

		// Token: 0x06006B83 RID: 27523 RVA: 0x0009C824 File Offset: 0x0009AA24
		public UMovieSceneMechanismTriggerSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMechanismTriggerSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006B84 RID: 27524 RVA: 0x0009C84C File Offset: 0x0009AA4C
		public UMovieSceneMechanismTriggerSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMechanismTriggerSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x06006B85 RID: 27525 RVA: 0x0009C880 File Offset: 0x0009AA80
		// (set) Token: 0x06006B86 RID: 27526 RVA: 0x0009C8B9 File Offset: 0x0009AAB9
		public FMovieSceneMechanismEventChannel EventChannel
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneMechanismEventChannel result;
				if ((result = this._EventChannel) == null)
				{
					result = (this._EventChannel = new FMovieSceneMechanismEventChannel(base.NativePtr + (IntPtr)UMovieSceneMechanismTriggerSection.__PropertyOffset_EventChannel, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneMechanismEventChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneMechanismTriggerSection.__PropertyOffset_EventChannel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06006B87 RID: 27527 RVA: 0x0009C8DA File Offset: 0x0009AADA
		static UMovieSceneMechanismTriggerSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismTriggerSection");
		}

		// Token: 0x06006B88 RID: 27528 RVA: 0x0009C8E8 File Offset: 0x0009AAE8
		protected UMovieSceneMechanismTriggerSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002DC6 RID: 11718
		public new const string __ObjectPath = "/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismTriggerSection";

		// Token: 0x04002DC7 RID: 11719
		private static IntPtr _ClassPtr;

		// Token: 0x04002DC8 RID: 11720
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002DC9 RID: 11721
		internal static int __PropertyOffset_EventChannel;

		// Token: 0x04002DCA RID: 11722
		[Nullable(2)]
		private FMovieSceneMechanismEventChannel _EventChannel;
	}
}
