using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026E1 RID: 9953
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneAutoTransformSection")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMovieSceneAutoTransformSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024EB7 RID: 151223 RVA: 0x00369B31 File Offset: 0x00367D31
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneAutoTransformSection._ClassPtr;
		}

		// Token: 0x06024EB8 RID: 151224 RVA: 0x00369B40 File Offset: 0x00367D40
		public UMovieSceneAutoTransformSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAutoTransformSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024EB9 RID: 151225 RVA: 0x00369B68 File Offset: 0x00367D68
		[NullableContext(1)]
		public UMovieSceneAutoTransformSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAutoTransformSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008E8D RID: 36493
		// (get) Token: 0x06024EBA RID: 151226 RVA: 0x00369B9B File Offset: 0x00367D9B
		// (set) Token: 0x06024EBB RID: 151227 RVA: 0x00369BAB File Offset: 0x00367DAB
		public unsafe bool bApplyCameraProperties
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneAutoTransformSection.__PropertyOffset_bApplyCameraProperties) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneAutoTransformSection.__PropertyOffset_bApplyCameraProperties) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024EBC RID: 151228 RVA: 0x00369BBC File Offset: 0x00367DBC
		static UMovieSceneAutoTransformSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneAutoTransformSection");
		}

		// Token: 0x06024EBD RID: 151229 RVA: 0x00369BCA File Offset: 0x00367DCA
		protected UMovieSceneAutoTransformSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013E4E RID: 81486
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneAutoTransformSection";

		// Token: 0x04013E4F RID: 81487
		private static IntPtr _ClassPtr;

		// Token: 0x04013E50 RID: 81488
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013E51 RID: 81489
		internal static int __PropertyOffset_bApplyCameraProperties;
	}
}
