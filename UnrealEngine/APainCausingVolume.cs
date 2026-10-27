using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F3B RID: 3899
	[UnrealObjectPath("/Script/Engine.PainCausingVolume")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1160)]
	public class APainCausingVolume : APhysicsVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D24A RID: 53834 RVA: 0x001342A0 File Offset: 0x001324A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APainCausingVolume._ClassPtr;
		}

		// Token: 0x0600D24B RID: 53835 RVA: 0x001342AC File Offset: 0x001324AC
		public APainCausingVolume() : this(BuiltinUtils.AllocNativeUObject(APainCausingVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D24C RID: 53836 RVA: 0x001342D4 File Offset: 0x001324D4
		[NullableContext(1)]
		public APainCausingVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APainCausingVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003121 RID: 12577
		// (get) Token: 0x0600D24D RID: 53837 RVA: 0x00134307 File Offset: 0x00132507
		// (set) Token: 0x0600D24E RID: 53838 RVA: 0x00134320 File Offset: 0x00132520
		public unsafe bool bPainCausing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APainCausingVolume.__PropertyOffset_bPainCausing) & APainCausingVolume.__PropertyMask_bPainCausing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APainCausingVolume.__PropertyOffset_bPainCausing) = ((*(base.NativePtr + (IntPtr)APainCausingVolume.__PropertyOffset_bPainCausing) & ~APainCausingVolume.__PropertyMask_bPainCausing) | (value ? APainCausingVolume.__PropertyMask_bPainCausing : 0));
			}
		}

		// Token: 0x17003122 RID: 12578
		// (get) Token: 0x0600D24F RID: 53839 RVA: 0x00134350 File Offset: 0x00132550
		// (set) Token: 0x0600D250 RID: 53840 RVA: 0x00134360 File Offset: 0x00132560
		public unsafe float DamagePerSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APainCausingVolume.__PropertyOffset_DamagePerSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APainCausingVolume.__PropertyOffset_DamagePerSec) = value;
			}
		}

		// Token: 0x17003123 RID: 12579
		// (get) Token: 0x0600D251 RID: 53841 RVA: 0x00134371 File Offset: 0x00132571
		// (set) Token: 0x0600D252 RID: 53842 RVA: 0x00134385 File Offset: 0x00132585
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UDamageType> DamageType
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)APainCausingVolume.__PropertyOffset_DamageType);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)APainCausingVolume.__PropertyOffset_DamageType) = value;
			}
		}

		// Token: 0x17003124 RID: 12580
		// (get) Token: 0x0600D253 RID: 53843 RVA: 0x0013439A File Offset: 0x0013259A
		// (set) Token: 0x0600D254 RID: 53844 RVA: 0x001343AA File Offset: 0x001325AA
		public unsafe float PainInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APainCausingVolume.__PropertyOffset_PainInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APainCausingVolume.__PropertyOffset_PainInterval) = value;
			}
		}

		// Token: 0x17003125 RID: 12581
		// (get) Token: 0x0600D255 RID: 53845 RVA: 0x001343BB File Offset: 0x001325BB
		// (set) Token: 0x0600D256 RID: 53846 RVA: 0x001343D4 File Offset: 0x001325D4
		public unsafe bool bEntryPain
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APainCausingVolume.__PropertyOffset_bEntryPain) & APainCausingVolume.__PropertyMask_bEntryPain) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APainCausingVolume.__PropertyOffset_bEntryPain) = ((*(base.NativePtr + (IntPtr)APainCausingVolume.__PropertyOffset_bEntryPain) & ~APainCausingVolume.__PropertyMask_bEntryPain) | (value ? APainCausingVolume.__PropertyMask_bEntryPain : 0));
			}
		}

		// Token: 0x17003126 RID: 12582
		// (get) Token: 0x0600D257 RID: 53847 RVA: 0x00134404 File Offset: 0x00132604
		// (set) Token: 0x0600D258 RID: 53848 RVA: 0x0013441D File Offset: 0x0013261D
		public unsafe bool BACKUP_bPainCausing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APainCausingVolume.__PropertyOffset_BACKUP_bPainCausing) & APainCausingVolume.__PropertyMask_BACKUP_bPainCausing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APainCausingVolume.__PropertyOffset_BACKUP_bPainCausing) = ((*(base.NativePtr + (IntPtr)APainCausingVolume.__PropertyOffset_BACKUP_bPainCausing) & ~APainCausingVolume.__PropertyMask_BACKUP_bPainCausing) | (value ? APainCausingVolume.__PropertyMask_BACKUP_bPainCausing : 0));
			}
		}

		// Token: 0x17003127 RID: 12583
		// (get) Token: 0x0600D259 RID: 53849 RVA: 0x0013444D File Offset: 0x0013264D
		// (set) Token: 0x0600D25A RID: 53850 RVA: 0x00134461 File Offset: 0x00132661
		[Nullable(2)]
		public unsafe AController DamageInstigator
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AController>(base.NativePtr / (IntPtr)sizeof(void*) + APainCausingVolume.__PropertyOffset_DamageInstigator);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APainCausingVolume.__PropertyOffset_DamageInstigator, value);
			}
		}

		// Token: 0x0600D25B RID: 53851 RVA: 0x00134476 File Offset: 0x00132676
		static APainCausingVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PainCausingVolume");
		}

		// Token: 0x0600D25C RID: 53852 RVA: 0x00134484 File Offset: 0x00132684
		protected APainCausingVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040070D8 RID: 28888
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PainCausingVolume";

		// Token: 0x040070D9 RID: 28889
		private static IntPtr _ClassPtr;

		// Token: 0x040070DA RID: 28890
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040070DB RID: 28891
		internal static int __PropertyOffset_bPainCausing;

		// Token: 0x040070DC RID: 28892
		internal static byte __PropertyMask_bPainCausing;

		// Token: 0x040070DD RID: 28893
		internal static int __PropertyOffset_DamagePerSec;

		// Token: 0x040070DE RID: 28894
		internal static int __PropertyOffset_DamageType;

		// Token: 0x040070DF RID: 28895
		internal static int __PropertyOffset_PainInterval;

		// Token: 0x040070E0 RID: 28896
		internal static int __PropertyOffset_bEntryPain;

		// Token: 0x040070E1 RID: 28897
		internal static byte __PropertyMask_bEntryPain;

		// Token: 0x040070E2 RID: 28898
		internal static int __PropertyOffset_BACKUP_bPainCausing;

		// Token: 0x040070E3 RID: 28899
		internal static byte __PropertyMask_BACKUP_bPainCausing;

		// Token: 0x040070E4 RID: 28900
		internal static int __PropertyOffset_DamageInstigator;
	}
}
