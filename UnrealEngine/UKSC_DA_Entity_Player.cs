using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D92 RID: 7570
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Entity_Player")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UKSC_DA_Entity_Player : UKSC_DA_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CF94 RID: 118676 RVA: 0x002AD34E File Offset: 0x002AB54E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Entity_Player._ClassPtr;
		}

		// Token: 0x0601CF95 RID: 118677 RVA: 0x002AD35C File Offset: 0x002AB55C
		public UKSC_DA_Entity_Player() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity_Player.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CF96 RID: 118678 RVA: 0x002AD384 File Offset: 0x002AB584
		[NullableContext(1)]
		public UKSC_DA_Entity_Player(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity_Player.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170074E2 RID: 29922
		// (get) Token: 0x0601CF97 RID: 118679 RVA: 0x002AD3B7 File Offset: 0x002AB5B7
		// (set) Token: 0x0601CF98 RID: 118680 RVA: 0x002AD3C7 File Offset: 0x002AB5C7
		public unsafe float TurnRateScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Entity_Player.__PropertyOffset_TurnRateScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Entity_Player.__PropertyOffset_TurnRateScale) = value;
			}
		}

		// Token: 0x0601CF99 RID: 118681 RVA: 0x002AD3D8 File Offset: 0x002AB5D8
		static UKSC_DA_Entity_Player()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Entity_Player");
		}

		// Token: 0x0601CF9A RID: 118682 RVA: 0x002AD3E6 File Offset: 0x002AB5E6
		protected UKSC_DA_Entity_Player(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB9B RID: 64411
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Entity_Player";

		// Token: 0x0400FB9C RID: 64412
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB9D RID: 64413
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB9E RID: 64414
		internal static int __PropertyOffset_TurnRateScale;
	}
}
