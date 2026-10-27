using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019D3 RID: 6611
	[UnrealObjectPath("/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismTriggerSection")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UMovieSceneMechanismTriggerSection : UMovieSceneSection, IUnrealUObject, IUnrealObject, IMovieSceneEntityProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060188D3 RID: 100563 RVA: 0x0024279A File Offset: 0x0024099A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneMechanismTriggerSection._ClassPtr;
		}

		// Token: 0x060188D4 RID: 100564 RVA: 0x002427A6 File Offset: 0x002409A6
		int IMovieSceneEntityProvider.InterfaceOffset()
		{
			return UMovieSceneMechanismTriggerSection.__InterfaceOffset_IMovieSceneEntityProvider;
		}

		// Token: 0x060188D5 RID: 100565 RVA: 0x002427B0 File Offset: 0x002409B0
		public UMovieSceneMechanismTriggerSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMechanismTriggerSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060188D6 RID: 100566 RVA: 0x002427D8 File Offset: 0x002409D8
		[NullableContext(1)]
		public UMovieSceneMechanismTriggerSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMechanismTriggerSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170061DC RID: 25052
		// (get) Token: 0x060188D7 RID: 100567 RVA: 0x0024280C File Offset: 0x00240A0C
		// (set) Token: 0x060188D8 RID: 100568 RVA: 0x00242845 File Offset: 0x00240A45
		[Nullable(1)]
		public FMovieSceneMechanismEventChannel EventChannel
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneMechanismEventChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneMechanismTriggerSection.__PropertyOffset_EventChannel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060188D9 RID: 100569 RVA: 0x00242866 File Offset: 0x00240A66
		static UMovieSceneMechanismTriggerSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismTriggerSection");
		}

		// Token: 0x060188DA RID: 100570 RVA: 0x00242874 File Offset: 0x00240A74
		protected UMovieSceneMechanismTriggerSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D43D RID: 54333
		internal static int __InterfaceOffset_IMovieSceneEntityProvider;

		// Token: 0x0400D43E RID: 54334
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismTriggerSection";

		// Token: 0x0400D43F RID: 54335
		private static IntPtr _ClassPtr;

		// Token: 0x0400D440 RID: 54336
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D441 RID: 54337
		internal static int __PropertyOffset_EventChannel;

		// Token: 0x0400D442 RID: 54338
		[Nullable(2)]
		private FMovieSceneMechanismEventChannel _EventChannel;
	}
}
