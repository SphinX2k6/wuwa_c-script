using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200290A RID: 10506
	[UnrealObjectPath("/Script/TemplateSequence.TemplateSequenceSection")]
	[UnrealStructLayout(456, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 456)]
	public class UTemplateSequenceSection : UMovieSceneSubSection, IUnrealUObject, IUnrealObject, IMovieSceneEntityProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06026F7B RID: 159611 RVA: 0x003B6EA6 File Offset: 0x003B50A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTemplateSequenceSection._ClassPtr;
		}

		// Token: 0x06026F7C RID: 159612 RVA: 0x003B6EB2 File Offset: 0x003B50B2
		int IMovieSceneEntityProvider.InterfaceOffset()
		{
			return UTemplateSequenceSection.__InterfaceOffset_IMovieSceneEntityProvider;
		}

		// Token: 0x06026F7D RID: 159613 RVA: 0x003B6EBC File Offset: 0x003B50BC
		public UTemplateSequenceSection() : this(BuiltinUtils.AllocNativeUObject(UTemplateSequenceSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026F7E RID: 159614 RVA: 0x003B6EE4 File Offset: 0x003B50E4
		[NullableContext(1)]
		public UTemplateSequenceSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTemplateSequenceSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026F7F RID: 159615 RVA: 0x003B6F17 File Offset: 0x003B5117
		static UTemplateSequenceSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TemplateSequence.TemplateSequenceSection");
		}

		// Token: 0x06026F80 RID: 159616 RVA: 0x003B6F25 File Offset: 0x003B5125
		protected UTemplateSequenceSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401562A RID: 87594
		internal static int __InterfaceOffset_IMovieSceneEntityProvider;

		// Token: 0x0401562B RID: 87595
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TemplateSequence.TemplateSequenceSection";

		// Token: 0x0401562C RID: 87596
		private static IntPtr _ClassPtr;

		// Token: 0x0401562D RID: 87597
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
