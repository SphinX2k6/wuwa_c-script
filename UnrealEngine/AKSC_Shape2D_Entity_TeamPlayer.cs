using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200058F RID: 1423
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2D_Entity_TeamPlayer")]
	[UnrealStructLayout(1320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1320)]
	public class AKSC_Shape2D_Entity_TeamPlayer : AKSC_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060080BF RID: 32959 RVA: 0x000BE210 File Offset: 0x000BC410
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Shape2D_Entity_TeamPlayer._ClassPtr;
		}

		// Token: 0x060080C0 RID: 32960 RVA: 0x000BE21C File Offset: 0x000BC41C
		public AKSC_Shape2D_Entity_TeamPlayer() : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity_TeamPlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060080C1 RID: 32961 RVA: 0x000BE244 File Offset: 0x000BC444
		[NullableContext(1)]
		public AKSC_Shape2D_Entity_TeamPlayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity_TeamPlayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x060080C2 RID: 32962 RVA: 0x000BE277 File Offset: 0x000BC477
		// (set) Token: 0x060080C3 RID: 32963 RVA: 0x000BE28B File Offset: 0x000BC48B
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

		// Token: 0x060080C4 RID: 32964 RVA: 0x000BE2A0 File Offset: 0x000BC4A0
		public void UseSkill(int SkillIndex, bool IsUseMainPlayerSkill)
		{
			AKSC_Shape2D_Entity_TeamPlayer.__UseSkill_Internal(base.NativePtr, SkillIndex, IsUseMainPlayerSkill);
		}

		// Token: 0x060080C5 RID: 32965
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UseSkill_Internal(IntPtr @this, int SkillIndex, bool IsUseMainPlayerSkill);

		// Token: 0x060080C6 RID: 32966 RVA: 0x000BE2AF File Offset: 0x000BC4AF
		static AKSC_Shape2D_Entity_TeamPlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Shape2D_Entity_TeamPlayer");
		}

		// Token: 0x060080C7 RID: 32967 RVA: 0x000BE2BD File Offset: 0x000BC4BD
		protected AKSC_Shape2D_Entity_TeamPlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003836 RID: 14390
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2D_Entity_TeamPlayer";

		// Token: 0x04003837 RID: 14391
		private static IntPtr _ClassPtr;

		// Token: 0x04003838 RID: 14392
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003839 RID: 14393
		internal static int __PropertyOffset_KscShapeWorld;
	}
}
