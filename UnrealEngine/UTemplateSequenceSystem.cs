using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200290B RID: 10507
	[UnrealObjectPath("/Script/TemplateSequence.TemplateSequenceSystem")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UTemplateSequenceSystem : UMovieSceneEntitySystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026F81 RID: 159617 RVA: 0x003B6F2E File Offset: 0x003B512E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTemplateSequenceSystem._ClassPtr;
		}

		// Token: 0x06026F82 RID: 159618 RVA: 0x003B6F3C File Offset: 0x003B513C
		public UTemplateSequenceSystem() : this(BuiltinUtils.AllocNativeUObject(UTemplateSequenceSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026F83 RID: 159619 RVA: 0x003B6F64 File Offset: 0x003B5164
		[NullableContext(1)]
		public UTemplateSequenceSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTemplateSequenceSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026F84 RID: 159620 RVA: 0x003B6F97 File Offset: 0x003B5197
		static UTemplateSequenceSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TemplateSequence.TemplateSequenceSystem");
		}

		// Token: 0x06026F85 RID: 159621 RVA: 0x003B6FA5 File Offset: 0x003B51A5
		protected UTemplateSequenceSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401562E RID: 87598
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TemplateSequence.TemplateSequenceSystem";

		// Token: 0x0401562F RID: 87599
		private static IntPtr _ClassPtr;

		// Token: 0x04015630 RID: 87600
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
