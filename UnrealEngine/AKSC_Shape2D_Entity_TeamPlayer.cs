using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E39 RID: 7737
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2D_Entity_TeamPlayer")]
	[UnrealStructLayout(1320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1320)]
	public class AKSC_Shape2D_Entity_TeamPlayer : AKSC_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D7A2 RID: 120738 RVA: 0x002B871C File Offset: 0x002B691C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Shape2D_Entity_TeamPlayer._ClassPtr;
		}

		// Token: 0x0601D7A3 RID: 120739 RVA: 0x002B8728 File Offset: 0x002B6928
		public AKSC_Shape2D_Entity_TeamPlayer() : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity_TeamPlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D7A4 RID: 120740 RVA: 0x002B8750 File Offset: 0x002B6950
		[NullableContext(1)]
		public AKSC_Shape2D_Entity_TeamPlayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity_TeamPlayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076C9 RID: 30409
		// (get) Token: 0x0601D7A5 RID: 120741 RVA: 0x002B8783 File Offset: 0x002B6983
		// (set) Token: 0x0601D7A6 RID: 120742 RVA: 0x002B8797 File Offset: 0x002B6997
		[Nullable(2)]
		public unsafe UKSC_Shape2D_World KscShapeWorld
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Shape2D_World>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Shape2D_Entity_TeamPlayer.__PropertyOffset_KscShapeWorld);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Shape2D_Entity_TeamPlayer.__PropertyOffset_KscShapeWorld, value);
			}
		}

		// Token: 0x0601D7A7 RID: 120743 RVA: 0x002B87AC File Offset: 0x002B69AC
		public void UseSkill(int SkillIndex, bool IsUseMainPlayerSkill)
		{
			AKSC_Shape2D_Entity_TeamPlayer.__UseSkill_Internal(base.NativePtr, SkillIndex, IsUseMainPlayerSkill);
		}

		// Token: 0x0601D7A8 RID: 120744
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UseSkill_Internal(IntPtr @this, int SkillIndex, bool IsUseMainPlayerSkill);

		// Token: 0x0601D7A9 RID: 120745 RVA: 0x002B87BB File Offset: 0x002B69BB
		static AKSC_Shape2D_Entity_TeamPlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Shape2D_Entity_TeamPlayer");
		}

		// Token: 0x0601D7AA RID: 120746 RVA: 0x002B87C9 File Offset: 0x002B69C9
		protected AKSC_Shape2D_Entity_TeamPlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FFAE RID: 65454
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2D_Entity_TeamPlayer";

		// Token: 0x0400FFAF RID: 65455
		private static IntPtr _ClassPtr;

		// Token: 0x0400FFB0 RID: 65456
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FFB1 RID: 65457
		internal static int __PropertyOffset_KscShapeWorld;
	}
}
