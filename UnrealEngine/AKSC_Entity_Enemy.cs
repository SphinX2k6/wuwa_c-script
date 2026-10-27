using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DDF RID: 7647
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Entity_Enemy")]
	[UnrealStructLayout(1392, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1392)]
	public class AKSC_Entity_Enemy : AKSC_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D395 RID: 119701 RVA: 0x002B289E File Offset: 0x002B0A9E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Entity_Enemy._ClassPtr;
		}

		// Token: 0x0601D396 RID: 119702 RVA: 0x002B28AC File Offset: 0x002B0AAC
		public AKSC_Entity_Enemy() : this(BuiltinUtils.AllocNativeUObject(AKSC_Entity_Enemy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D397 RID: 119703 RVA: 0x002B28D4 File Offset: 0x002B0AD4
		public AKSC_Entity_Enemy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Entity_Enemy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007600 RID: 30208
		// (get) Token: 0x0601D398 RID: 119704 RVA: 0x002B2908 File Offset: 0x002B0B08
		// (set) Token: 0x0601D399 RID: 119705 RVA: 0x002B2941 File Offset: 0x002B0B41
		public TMap<FGameplayTag, FKSC_Enemy_Delay_KuroMatFX> DelayDeadTagMaterialMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, FKSC_Enemy_Delay_KuroMatFX> result;
				if ((result = this._DelayDeadTagMaterialMap) == null)
				{
					result = (this._DelayDeadTagMaterialMap = new TMap<FGameplayTag, FKSC_Enemy_Delay_KuroMatFX>(base.NativePtr + (IntPtr)AKSC_Entity_Enemy.__PropertyOffset_DelayDeadTagMaterialMap, this));
				}
				return result;
			}
			set
			{
				this.DelayDeadTagMaterialMap.CopyAssign(value);
			}
		}

		// Token: 0x17007601 RID: 30209
		// (get) Token: 0x0601D39A RID: 119706 RVA: 0x002B2950 File Offset: 0x002B0B50
		// (set) Token: 0x0601D39B RID: 119707 RVA: 0x002B2989 File Offset: 0x002B0B89
		public FKSC_Enemy_Delay_KuroMatFX DelayDeadMaterial
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_Enemy_Delay_KuroMatFX result;
				if ((result = this._DelayDeadMaterial) == null)
				{
					result = (this._DelayDeadMaterial = new FKSC_Enemy_Delay_KuroMatFX(base.NativePtr + (IntPtr)AKSC_Entity_Enemy.__PropertyOffset_DelayDeadMaterial, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_Enemy_Delay_KuroMatFX.StaticStruct(), base.NativePtr + (IntPtr)AKSC_Entity_Enemy.__PropertyOffset_DelayDeadMaterial, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007602 RID: 30210
		// (get) Token: 0x0601D39C RID: 119708 RVA: 0x002B29AC File Offset: 0x002B0BAC
		// (set) Token: 0x0601D39D RID: 119709 RVA: 0x002B29E5 File Offset: 0x002B0BE5
		public FKSC_Enemy_Delay_KuroMatFX DelayArrivalMaterial
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_Enemy_Delay_KuroMatFX result;
				if ((result = this._DelayArrivalMaterial) == null)
				{
					result = (this._DelayArrivalMaterial = new FKSC_Enemy_Delay_KuroMatFX(base.NativePtr + (IntPtr)AKSC_Entity_Enemy.__PropertyOffset_DelayArrivalMaterial, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_Enemy_Delay_KuroMatFX.StaticStruct(), base.NativePtr + (IntPtr)AKSC_Entity_Enemy.__PropertyOffset_DelayArrivalMaterial, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601D39E RID: 119710 RVA: 0x002B2A06 File Offset: 0x002B0C06
		static AKSC_Entity_Enemy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Entity_Enemy");
		}

		// Token: 0x0601D39F RID: 119711 RVA: 0x002B2A14 File Offset: 0x002B0C14
		protected AKSC_Entity_Enemy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FDBD RID: 64957
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Entity_Enemy";

		// Token: 0x0400FDBE RID: 64958
		private static IntPtr _ClassPtr;

		// Token: 0x0400FDBF RID: 64959
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FDC0 RID: 64960
		internal static int __PropertyOffset_DelayDeadTagMaterialMap;

		// Token: 0x0400FDC1 RID: 64961
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, FKSC_Enemy_Delay_KuroMatFX> _DelayDeadTagMaterialMap;

		// Token: 0x0400FDC2 RID: 64962
		internal static int __PropertyOffset_DelayDeadMaterial;

		// Token: 0x0400FDC3 RID: 64963
		[Nullable(2)]
		private FKSC_Enemy_Delay_KuroMatFX _DelayDeadMaterial;

		// Token: 0x0400FDC4 RID: 64964
		internal static int __PropertyOffset_DelayArrivalMaterial;

		// Token: 0x0400FDC5 RID: 64965
		[Nullable(2)]
		private FKSC_Enemy_Delay_KuroMatFX _DelayArrivalMaterial;
	}
}
