using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019D0 RID: 6608
	[UnrealObjectPath("/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismRepeaterSection")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public class UMovieSceneMechanismRepeaterSection : UMovieSceneSection, IUnrealUObject, IUnrealObject, IMovieSceneEntityProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060188B9 RID: 100537 RVA: 0x00242552 File Offset: 0x00240752
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneMechanismRepeaterSection._ClassPtr;
		}

		// Token: 0x060188BA RID: 100538 RVA: 0x0024255E File Offset: 0x0024075E
		int IMovieSceneEntityProvider.InterfaceOffset()
		{
			return UMovieSceneMechanismRepeaterSection.__InterfaceOffset_IMovieSceneEntityProvider;
		}

		// Token: 0x060188BB RID: 100539 RVA: 0x00242568 File Offset: 0x00240768
		public UMovieSceneMechanismRepeaterSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMechanismRepeaterSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060188BC RID: 100540 RVA: 0x00242590 File Offset: 0x00240790
		[NullableContext(1)]
		public UMovieSceneMechanismRepeaterSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMechanismRepeaterSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170061D9 RID: 25049
		// (get) Token: 0x060188BD RID: 100541 RVA: 0x002425C4 File Offset: 0x002407C4
		// (set) Token: 0x060188BE RID: 100542 RVA: 0x002425FD File Offset: 0x002407FD
		[Nullable(1)]
		public FMovieSceneMechanismEvent Event
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMovieSceneMechanismEvent result;
				if ((result = this._Event) == null)
				{
					result = (this._Event = new FMovieSceneMechanismEvent(base.NativePtr + (IntPtr)UMovieSceneMechanismRepeaterSection.__PropertyOffset_Event, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneMechanismEvent.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneMechanismRepeaterSection.__PropertyOffset_Event, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170061DA RID: 25050
		// (get) Token: 0x060188BF RID: 100543 RVA: 0x0024261E File Offset: 0x0024081E
		// (set) Token: 0x060188C0 RID: 100544 RVA: 0x0024262E File Offset: 0x0024082E
		public unsafe bool NeedTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneMechanismRepeaterSection.__PropertyOffset_NeedTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneMechanismRepeaterSection.__PropertyOffset_NeedTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x060188C1 RID: 100545 RVA: 0x0024263F File Offset: 0x0024083F
		static UMovieSceneMechanismRepeaterSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismRepeaterSection");
		}

		// Token: 0x060188C2 RID: 100546 RVA: 0x0024264D File Offset: 0x0024084D
		protected UMovieSceneMechanismRepeaterSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D42E RID: 54318
		internal static int __InterfaceOffset_IMovieSceneEntityProvider;

		// Token: 0x0400D42F RID: 54319
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismRepeaterSection";

		// Token: 0x0400D430 RID: 54320
		private static IntPtr _ClassPtr;

		// Token: 0x0400D431 RID: 54321
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D432 RID: 54322
		internal static int __PropertyOffset_Event;

		// Token: 0x0400D433 RID: 54323
		[Nullable(2)]
		private FMovieSceneMechanismEvent _Event;

		// Token: 0x0400D434 RID: 54324
		internal static int __PropertyOffset_NeedTick;
	}
}
