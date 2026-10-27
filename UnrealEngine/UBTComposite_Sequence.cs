using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000136 RID: 310
	[UnrealObjectPath("/Script/AIModule.BTComposite_Sequence")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UBTComposite_Sequence : UBTCompositeNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060015E4 RID: 5604 RVA: 0x000202BA File Offset: 0x0001E4BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTComposite_Sequence._ClassPtr;
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x000202C8 File Offset: 0x0001E4C8
		public UBTComposite_Sequence() : this(BuiltinUtils.AllocNativeUObject(UBTComposite_Sequence.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x000202F0 File Offset: 0x0001E4F0
		[NullableContext(1)]
		public UBTComposite_Sequence(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTComposite_Sequence.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00020323 File Offset: 0x0001E523
		static UBTComposite_Sequence()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTComposite_Sequence");
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00020331 File Offset: 0x0001E531
		protected UBTComposite_Sequence(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040004CC RID: 1228
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTComposite_Sequence";

		// Token: 0x040004CD RID: 1229
		private static IntPtr _ClassPtr;

		// Token: 0x040004CE RID: 1230
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
