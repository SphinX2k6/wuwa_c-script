using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200290C RID: 10508
	[UnrealObjectPath("/Script/TemplateSequence.TemplateSequenceTrack")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UTemplateSequenceTrack : UMovieSceneSubTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026F86 RID: 159622 RVA: 0x003B6FAE File Offset: 0x003B51AE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTemplateSequenceTrack._ClassPtr;
		}

		// Token: 0x06026F87 RID: 159623 RVA: 0x003B6FBC File Offset: 0x003B51BC
		public UTemplateSequenceTrack() : this(BuiltinUtils.AllocNativeUObject(UTemplateSequenceTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026F88 RID: 159624 RVA: 0x003B6FE4 File Offset: 0x003B51E4
		[NullableContext(1)]
		public UTemplateSequenceTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTemplateSequenceTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026F89 RID: 159625 RVA: 0x003B7017 File Offset: 0x003B5217
		static UTemplateSequenceTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TemplateSequence.TemplateSequenceTrack");
		}

		// Token: 0x06026F8A RID: 159626 RVA: 0x003B7025 File Offset: 0x003B5225
		protected UTemplateSequenceTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015631 RID: 87601
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TemplateSequence.TemplateSequenceTrack";

		// Token: 0x04015632 RID: 87602
		private static IntPtr _ClassPtr;

		// Token: 0x04015633 RID: 87603
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
