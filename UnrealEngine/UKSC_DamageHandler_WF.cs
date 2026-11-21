using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000566 RID: 1382
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DamageHandler_WF")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UKSC_DamageHandler_WF : UKSC_DamageHandler, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007DD3 RID: 32211 RVA: 0x000BA8FE File Offset: 0x000B8AFE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DamageHandler_WF._ClassPtr;
		}

		// Token: 0x06007DD4 RID: 32212 RVA: 0x000BA90C File Offset: 0x000B8B0C
		public UKSC_DamageHandler_WF() : this(BuiltinUtils.AllocNativeUObject(UKSC_DamageHandler_WF.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007DD5 RID: 32213 RVA: 0x000BA934 File Offset: 0x000B8B34
		public UKSC_DamageHandler_WF(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DamageHandler_WF.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x06007DD6 RID: 32214 RVA: 0x000BA967 File Offset: 0x000B8B67
		// (set) Token: 0x06007DD7 RID: 32215 RVA: 0x000BA97B File Offset: 0x000B8B7B
		[Nullable(2)]
		public unsafe UKSC_Shape2D_World Shape2DWorld
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Shape2D_World>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DamageHandler_WF.__PropertyOffset_Shape2DWorld);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DamageHandler_WF.__PropertyOffset_Shape2DWorld, value);
			}
		}

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x06007DD8 RID: 32216 RVA: 0x000BA990 File Offset: 0x000B8B90
		// (set) Token: 0x06007DD9 RID: 32217 RVA: 0x000BA9C9 File Offset: 0x000B8BC9
		public TArray<UKSC_SkillComp> TempSkillComps
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_SkillComp> result;
				if ((result = this._TempSkillComps) == null)
				{
					result = (this._TempSkillComps = new TArray<UKSC_SkillComp>(base.NativePtr + (IntPtr)UKSC_DamageHandler_WF.__PropertyOffset_TempSkillComps, this));
				}
				return result;
			}
			set
			{
				this.TempSkillComps.CopyAssign(value);
			}
		}

		// Token: 0x06007DDA RID: 32218 RVA: 0x000BA9D7 File Offset: 0x000B8BD7
		static UKSC_DamageHandler_WF()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DamageHandler_WF");
		}

		// Token: 0x06007DDB RID: 32219 RVA: 0x000BA9E5 File Offset: 0x000B8BE5
		protected UKSC_DamageHandler_WF(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040036D9 RID: 14041
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DamageHandler_WF";

		// Token: 0x040036DA RID: 14042
		private static IntPtr _ClassPtr;

		// Token: 0x040036DB RID: 14043
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040036DC RID: 14044
		internal static int __PropertyOffset_Shape2DWorld;

		// Token: 0x040036DD RID: 14045
		internal static int __PropertyOffset_TempSkillComps;

		// Token: 0x040036DE RID: 14046
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_SkillComp> _TempSkillComps;
	}
}
