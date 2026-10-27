using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DB2 RID: 7602
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Shape2D_Entity_Enemy")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UKSC_DA_Shape2D_Entity_Enemy : UKSC_DA_Shape2D_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D0CF RID: 118991 RVA: 0x002AEF73 File Offset: 0x002AD173
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Shape2D_Entity_Enemy._ClassPtr;
		}

		// Token: 0x0601D0D0 RID: 118992 RVA: 0x002AEF80 File Offset: 0x002AD180
		public UKSC_DA_Shape2D_Entity_Enemy() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_Entity_Enemy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D0D1 RID: 118993 RVA: 0x002AEFA8 File Offset: 0x002AD1A8
		[NullableContext(1)]
		public UKSC_DA_Shape2D_Entity_Enemy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_Entity_Enemy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007530 RID: 30000
		// (get) Token: 0x0601D0D2 RID: 118994 RVA: 0x002AEFDB File Offset: 0x002AD1DB
		// (set) Token: 0x0601D0D3 RID: 118995 RVA: 0x002AEFEB File Offset: 0x002AD1EB
		public unsafe bool IsEnableBeHitColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_Entity_Enemy.__PropertyOffset_IsEnableBeHitColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_Entity_Enemy.__PropertyOffset_IsEnableBeHitColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601D0D4 RID: 118996 RVA: 0x002AEFFC File Offset: 0x002AD1FC
		static UKSC_DA_Shape2D_Entity_Enemy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Shape2D_Entity_Enemy");
		}

		// Token: 0x0601D0D5 RID: 118997 RVA: 0x002AF00A File Offset: 0x002AD20A
		protected UKSC_DA_Shape2D_Entity_Enemy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC56 RID: 64598
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Shape2D_Entity_Enemy";

		// Token: 0x0400FC57 RID: 64599
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC58 RID: 64600
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC59 RID: 64601
		internal static int __PropertyOffset_IsEnableBeHitColor;
	}
}
