using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E0A RID: 7690
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move_StageApproach3D")]
	[UnrealStructLayout(536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 536)]
	public class UKSC_Move_StageApproach3D : UKSC_Move_Stage, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D5CA RID: 120266 RVA: 0x002B5822 File Offset: 0x002B3A22
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move_StageApproach3D._ClassPtr;
		}

		// Token: 0x0601D5CB RID: 120267 RVA: 0x002B5830 File Offset: 0x002B3A30
		public UKSC_Move_StageApproach3D() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_StageApproach3D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D5CC RID: 120268 RVA: 0x002B5858 File Offset: 0x002B3A58
		[NullableContext(1)]
		public UKSC_Move_StageApproach3D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_StageApproach3D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D5CD RID: 120269 RVA: 0x002B588B File Offset: 0x002B3A8B
		static UKSC_Move_StageApproach3D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move_StageApproach3D");
		}

		// Token: 0x0601D5CE RID: 120270 RVA: 0x002B5899 File Offset: 0x002B3A99
		protected UKSC_Move_StageApproach3D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FECF RID: 65231
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move_StageApproach3D";

		// Token: 0x0400FED0 RID: 65232
		private static IntPtr _ClassPtr;

		// Token: 0x0400FED1 RID: 65233
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
