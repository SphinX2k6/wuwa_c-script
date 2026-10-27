using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D44 RID: 7492
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DamageHandler_WF")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UKSC_DamageHandler_WF : UKSC_DamageHandler, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CB12 RID: 117522 RVA: 0x002A6A32 File Offset: 0x002A4C32
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DamageHandler_WF._ClassPtr;
		}

		// Token: 0x0601CB13 RID: 117523 RVA: 0x002A6A40 File Offset: 0x002A4C40
		public UKSC_DamageHandler_WF() : this(BuiltinUtils.AllocNativeUObject(UKSC_DamageHandler_WF.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CB14 RID: 117524 RVA: 0x002A6A68 File Offset: 0x002A4C68
		public UKSC_DamageHandler_WF(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DamageHandler_WF.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007366 RID: 29542
		// (get) Token: 0x0601CB15 RID: 117525 RVA: 0x002A6A9B File Offset: 0x002A4C9B
		// (set) Token: 0x0601CB16 RID: 117526 RVA: 0x002A6AAF File Offset: 0x002A4CAF
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

		// Token: 0x17007367 RID: 29543
		// (get) Token: 0x0601CB17 RID: 117527 RVA: 0x002A6AC4 File Offset: 0x002A4CC4
		// (set) Token: 0x0601CB18 RID: 117528 RVA: 0x002A6AFD File Offset: 0x002A4CFD
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

		// Token: 0x0601CB19 RID: 117529 RVA: 0x002A6B0B File Offset: 0x002A4D0B
		static UKSC_DamageHandler_WF()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DamageHandler_WF");
		}

		// Token: 0x0601CB1A RID: 117530 RVA: 0x002A6B19 File Offset: 0x002A4D19
		protected UKSC_DamageHandler_WF(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F8E5 RID: 63717
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DamageHandler_WF";

		// Token: 0x0400F8E6 RID: 63718
		private static IntPtr _ClassPtr;

		// Token: 0x0400F8E7 RID: 63719
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F8E8 RID: 63720
		internal static int __PropertyOffset_Shape2DWorld;

		// Token: 0x0400F8E9 RID: 63721
		internal static int __PropertyOffset_TempSkillComps;

		// Token: 0x0400F8EA RID: 63722
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_SkillComp> _TempSkillComps;
	}
}
