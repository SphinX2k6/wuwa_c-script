using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D97 RID: 7575
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_HitContextText")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UKSC_DA_HitContextText : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CFBF RID: 118719 RVA: 0x002AD78E File Offset: 0x002AB98E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_HitContextText._ClassPtr;
		}

		// Token: 0x0601CFC0 RID: 118720 RVA: 0x002AD79C File Offset: 0x002AB99C
		public UKSC_DA_HitContextText() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_HitContextText.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CFC1 RID: 118721 RVA: 0x002AD7C4 File Offset: 0x002AB9C4
		public UKSC_DA_HitContextText(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_HitContextText.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170074EB RID: 29931
		// (get) Token: 0x0601CFC2 RID: 118722 RVA: 0x002AD7F8 File Offset: 0x002AB9F8
		// (set) Token: 0x0601CFC3 RID: 118723 RVA: 0x002AD831 File Offset: 0x002ABA31
		public TMap<EHitContextTextType, FKSC_HitContextTextData> HitContextTextMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EHitContextTextType, FKSC_HitContextTextData> result;
				if ((result = this._HitContextTextMap) == null)
				{
					result = (this._HitContextTextMap = new TMap<EHitContextTextType, FKSC_HitContextTextData>(base.NativePtr + (IntPtr)UKSC_DA_HitContextText.__PropertyOffset_HitContextTextMap, this));
				}
				return result;
			}
			set
			{
				this.HitContextTextMap.CopyAssign(value);
			}
		}

		// Token: 0x0601CFC4 RID: 118724 RVA: 0x002AD83F File Offset: 0x002ABA3F
		static UKSC_DA_HitContextText()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_HitContextText");
		}

		// Token: 0x0601CFC5 RID: 118725 RVA: 0x002AD84D File Offset: 0x002ABA4D
		protected UKSC_DA_HitContextText(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBB6 RID: 64438
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_HitContextText";

		// Token: 0x0400FBB7 RID: 64439
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBB8 RID: 64440
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FBB9 RID: 64441
		internal static int __PropertyOffset_HitContextTextMap;

		// Token: 0x0400FBBA RID: 64442
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EHitContextTextType, FKSC_HitContextTextData> _HitContextTextMap;
	}
}
