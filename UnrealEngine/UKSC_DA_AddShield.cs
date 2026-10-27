using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D49 RID: 7497
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_AddShield")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UKSC_DA_AddShield : UKSC_DA_BuffEffectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CB62 RID: 117602 RVA: 0x002A7176 File Offset: 0x002A5376
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_AddShield._ClassPtr;
		}

		// Token: 0x0601CB63 RID: 117603 RVA: 0x002A7184 File Offset: 0x002A5384
		public UKSC_DA_AddShield() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_AddShield.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CB64 RID: 117604 RVA: 0x002A71AC File Offset: 0x002A53AC
		public UKSC_DA_AddShield(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_AddShield.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700737D RID: 29565
		// (get) Token: 0x0601CB65 RID: 117605 RVA: 0x002A71DF File Offset: 0x002A53DF
		// (set) Token: 0x0601CB66 RID: 117606 RVA: 0x002A71EF File Offset: 0x002A53EF
		public unsafe int ShieldHp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_AddShield.__PropertyOffset_ShieldHp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_AddShield.__PropertyOffset_ShieldHp) = value;
			}
		}

		// Token: 0x1700737E RID: 29566
		// (get) Token: 0x0601CB67 RID: 117607 RVA: 0x002A7200 File Offset: 0x002A5400
		// (set) Token: 0x0601CB68 RID: 117608 RVA: 0x002A7239 File Offset: 0x002A5439
		public FKSC_KuroFX ShieldStackBreakFX
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_KuroFX result;
				if ((result = this._ShieldStackBreakFX) == null)
				{
					result = (this._ShieldStackBreakFX = new FKSC_KuroFX(base.NativePtr + (IntPtr)UKSC_DA_AddShield.__PropertyOffset_ShieldStackBreakFX, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_KuroFX.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_AddShield.__PropertyOffset_ShieldStackBreakFX, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601CB69 RID: 117609 RVA: 0x002A725A File Offset: 0x002A545A
		static UKSC_DA_AddShield()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_AddShield");
		}

		// Token: 0x0601CB6A RID: 117610 RVA: 0x002A7268 File Offset: 0x002A5468
		protected UKSC_DA_AddShield(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F911 RID: 63761
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_AddShield";

		// Token: 0x0400F912 RID: 63762
		private static IntPtr _ClassPtr;

		// Token: 0x0400F913 RID: 63763
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F914 RID: 63764
		internal static int __PropertyOffset_ShieldHp;

		// Token: 0x0400F915 RID: 63765
		internal static int __PropertyOffset_ShieldStackBreakFX;

		// Token: 0x0400F916 RID: 63766
		[Nullable(2)]
		private FKSC_KuroFX _ShieldStackBreakFX;
	}
}
