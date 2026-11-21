using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000572 RID: 1394
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Shape2D_Entity")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UKSC_DA_Shape2D_Entity : UKSC_DA_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007E8C RID: 32396 RVA: 0x000BB875 File Offset: 0x000B9A75
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Shape2D_Entity._ClassPtr;
		}

		// Token: 0x06007E8D RID: 32397 RVA: 0x000BB884 File Offset: 0x000B9A84
		public UKSC_DA_Shape2D_Entity() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_Entity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007E8E RID: 32398 RVA: 0x000BB8AC File Offset: 0x000B9AAC
		[NullableContext(1)]
		public UKSC_DA_Shape2D_Entity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_Entity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007E8F RID: 32399 RVA: 0x000BB8DF File Offset: 0x000B9ADF
		static UKSC_DA_Shape2D_Entity()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Shape2D_Entity");
		}

		// Token: 0x06007E90 RID: 32400 RVA: 0x000BB8ED File Offset: 0x000B9AED
		protected UKSC_DA_Shape2D_Entity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400373F RID: 14143
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Shape2D_Entity";

		// Token: 0x04003740 RID: 14144
		private static IntPtr _ClassPtr;

		// Token: 0x04003741 RID: 14145
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
