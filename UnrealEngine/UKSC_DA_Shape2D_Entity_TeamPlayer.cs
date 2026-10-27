using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DB5 RID: 7605
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Shape2D_Entity_TeamPlayer")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UKSC_DA_Shape2D_Entity_TeamPlayer : UKSC_DA_Shape2D_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D0E4 RID: 119012 RVA: 0x002AF15B File Offset: 0x002AD35B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Shape2D_Entity_TeamPlayer._ClassPtr;
		}

		// Token: 0x0601D0E5 RID: 119013 RVA: 0x002AF168 File Offset: 0x002AD368
		public UKSC_DA_Shape2D_Entity_TeamPlayer() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_Entity_TeamPlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D0E6 RID: 119014 RVA: 0x002AF190 File Offset: 0x002AD390
		[NullableContext(1)]
		public UKSC_DA_Shape2D_Entity_TeamPlayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_Entity_TeamPlayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D0E7 RID: 119015 RVA: 0x002AF1C3 File Offset: 0x002AD3C3
		static UKSC_DA_Shape2D_Entity_TeamPlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Shape2D_Entity_TeamPlayer");
		}

		// Token: 0x0601D0E8 RID: 119016 RVA: 0x002AF1D1 File Offset: 0x002AD3D1
		protected UKSC_DA_Shape2D_Entity_TeamPlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC62 RID: 64610
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Shape2D_Entity_TeamPlayer";

		// Token: 0x0400FC63 RID: 64611
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC64 RID: 64612
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
