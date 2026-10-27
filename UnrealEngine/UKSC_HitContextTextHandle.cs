using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DED RID: 7661
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_HitContextTextHandle")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKSC_HitContextTextHandle : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D480 RID: 119936 RVA: 0x002B3C7C File Offset: 0x002B1E7C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_HitContextTextHandle._ClassPtr;
		}

		// Token: 0x0601D481 RID: 119937 RVA: 0x002B3C88 File Offset: 0x002B1E88
		public UKSC_HitContextTextHandle() : this(BuiltinUtils.AllocNativeUObject(UKSC_HitContextTextHandle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D482 RID: 119938 RVA: 0x002B3CB0 File Offset: 0x002B1EB0
		public UKSC_HitContextTextHandle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_HitContextTextHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007641 RID: 30273
		// (get) Token: 0x0601D483 RID: 119939 RVA: 0x002B3CE3 File Offset: 0x002B1EE3
		// (set) Token: 0x0601D484 RID: 119940 RVA: 0x002B3CF7 File Offset: 0x002B1EF7
		[Nullable(2)]
		public unsafe UKSC_DA_HitContextText DataAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_HitContextText>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HitContextTextHandle.__PropertyOffset_DataAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HitContextTextHandle.__PropertyOffset_DataAsset, value);
			}
		}

		// Token: 0x17007642 RID: 30274
		// (get) Token: 0x0601D485 RID: 119941 RVA: 0x002B3D0C File Offset: 0x002B1F0C
		// (set) Token: 0x0601D486 RID: 119942 RVA: 0x002B3D45 File Offset: 0x002B1F45
		public TMap<EHitContextTextType, float> NextAddTimeMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EHitContextTextType, float> result;
				if ((result = this._NextAddTimeMap) == null)
				{
					result = (this._NextAddTimeMap = new TMap<EHitContextTextType, float>(base.NativePtr + (IntPtr)UKSC_HitContextTextHandle.__PropertyOffset_NextAddTimeMap, this));
				}
				return result;
			}
			set
			{
				this.NextAddTimeMap.CopyAssign(value);
			}
		}

		// Token: 0x0601D487 RID: 119943 RVA: 0x002B3D53 File Offset: 0x002B1F53
		static UKSC_HitContextTextHandle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_HitContextTextHandle");
		}

		// Token: 0x0601D488 RID: 119944 RVA: 0x002B3D61 File Offset: 0x002B1F61
		protected UKSC_HitContextTextHandle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE39 RID: 65081
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_HitContextTextHandle";

		// Token: 0x0400FE3A RID: 65082
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE3B RID: 65083
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE3C RID: 65084
		internal static int __PropertyOffset_DataAsset;

		// Token: 0x0400FE3D RID: 65085
		internal static int __PropertyOffset_NextAddTimeMap;

		// Token: 0x0400FE3E RID: 65086
		[Nullable(2)]
		private TMap<EHitContextTextType, float> _NextAddTimeMap;
	}
}
