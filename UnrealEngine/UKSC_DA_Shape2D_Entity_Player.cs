using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DB4 RID: 7604
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Shape2D_Entity_Player")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UKSC_DA_Shape2D_Entity_Player : UKSC_DA_Shape2D_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D0DD RID: 119005 RVA: 0x002AF0BB File Offset: 0x002AD2BB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Shape2D_Entity_Player._ClassPtr;
		}

		// Token: 0x0601D0DE RID: 119006 RVA: 0x002AF0C8 File Offset: 0x002AD2C8
		public UKSC_DA_Shape2D_Entity_Player() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_Entity_Player.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D0DF RID: 119007 RVA: 0x002AF0F0 File Offset: 0x002AD2F0
		[NullableContext(1)]
		public UKSC_DA_Shape2D_Entity_Player(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_Entity_Player.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007532 RID: 30002
		// (get) Token: 0x0601D0E0 RID: 119008 RVA: 0x002AF123 File Offset: 0x002AD323
		// (set) Token: 0x0601D0E1 RID: 119009 RVA: 0x002AF133 File Offset: 0x002AD333
		public unsafe bool IsEnableBeHitColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_Entity_Player.__PropertyOffset_IsEnableBeHitColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_Entity_Player.__PropertyOffset_IsEnableBeHitColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601D0E2 RID: 119010 RVA: 0x002AF144 File Offset: 0x002AD344
		static UKSC_DA_Shape2D_Entity_Player()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Shape2D_Entity_Player");
		}

		// Token: 0x0601D0E3 RID: 119011 RVA: 0x002AF152 File Offset: 0x002AD352
		protected UKSC_DA_Shape2D_Entity_Player(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC5E RID: 64606
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Shape2D_Entity_Player";

		// Token: 0x0400FC5F RID: 64607
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC60 RID: 64608
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC61 RID: 64609
		internal static int __PropertyOffset_IsEnableBeHitColor;
	}
}
