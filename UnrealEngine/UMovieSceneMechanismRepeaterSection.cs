using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000462 RID: 1122
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismRepeaterSection")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class UMovieSceneMechanismRepeaterSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006B72 RID: 27506 RVA: 0x0009C654 File Offset: 0x0009A854
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneMechanismRepeaterSection._ClassPtr;
		}

		// Token: 0x06006B73 RID: 27507 RVA: 0x0009C660 File Offset: 0x0009A860
		public UMovieSceneMechanismRepeaterSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMechanismRepeaterSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006B74 RID: 27508 RVA: 0x0009C688 File Offset: 0x0009A888
		public UMovieSceneMechanismRepeaterSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMechanismRepeaterSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x06006B75 RID: 27509 RVA: 0x0009C6BC File Offset: 0x0009A8BC
		// (set) Token: 0x06006B76 RID: 27510 RVA: 0x0009C6F5 File Offset: 0x0009A8F5
		public FMovieSceneMechanismEvent Event
		{
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
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneMechanismEvent.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneMechanismRepeaterSection.__PropertyOffset_Event, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x06006B77 RID: 27511 RVA: 0x0009C716 File Offset: 0x0009A916
		// (set) Token: 0x06006B78 RID: 27512 RVA: 0x0009C726 File Offset: 0x0009A926
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

		// Token: 0x06006B79 RID: 27513 RVA: 0x0009C737 File Offset: 0x0009A937
		static UMovieSceneMechanismRepeaterSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismRepeaterSection");
		}

		// Token: 0x06006B7A RID: 27514 RVA: 0x0009C745 File Offset: 0x0009A945
		protected UMovieSceneMechanismRepeaterSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002DBB RID: 11707
		public new const string __ObjectPath = "/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismRepeaterSection";

		// Token: 0x04002DBC RID: 11708
		private static IntPtr _ClassPtr;

		// Token: 0x04002DBD RID: 11709
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002DBE RID: 11710
		internal static int __PropertyOffset_Event;

		// Token: 0x04002DBF RID: 11711
		[Nullable(2)]
		private FMovieSceneMechanismEvent _Event;

		// Token: 0x04002DC0 RID: 11712
		internal static int __PropertyOffset_NeedTick;
	}
}
