using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D4B RID: 7499
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_AttrSet")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKSC_DA_AttrSet : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CB71 RID: 117617 RVA: 0x002A72E5 File Offset: 0x002A54E5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_AttrSet._ClassPtr;
		}

		// Token: 0x0601CB72 RID: 117618 RVA: 0x002A72F4 File Offset: 0x002A54F4
		public UKSC_DA_AttrSet() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_AttrSet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CB73 RID: 117619 RVA: 0x002A731C File Offset: 0x002A551C
		public UKSC_DA_AttrSet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_AttrSet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007380 RID: 29568
		// (get) Token: 0x0601CB74 RID: 117620 RVA: 0x002A734F File Offset: 0x002A554F
		// (set) Token: 0x0601CB75 RID: 117621 RVA: 0x002A7363 File Offset: 0x002A5563
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UKSC_AttrSet> RuntimeClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_AttrSet.__PropertyOffset_RuntimeClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_AttrSet.__PropertyOffset_RuntimeClass) = value;
			}
		}

		// Token: 0x17007381 RID: 29569
		// (get) Token: 0x0601CB76 RID: 117622 RVA: 0x002A7378 File Offset: 0x002A5578
		// (set) Token: 0x0601CB77 RID: 117623 RVA: 0x002A73B1 File Offset: 0x002A55B1
		public TMap<EKSC_AttrType, int> Attrs
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, int> result;
				if ((result = this._Attrs) == null)
				{
					result = (this._Attrs = new TMap<EKSC_AttrType, int>(base.NativePtr + (IntPtr)UKSC_DA_AttrSet.__PropertyOffset_Attrs, this));
				}
				return result;
			}
			set
			{
				this.Attrs.CopyAssign(value);
			}
		}

		// Token: 0x0601CB78 RID: 117624 RVA: 0x002A73BF File Offset: 0x002A55BF
		static UKSC_DA_AttrSet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_AttrSet");
		}

		// Token: 0x0601CB79 RID: 117625 RVA: 0x002A73CD File Offset: 0x002A55CD
		protected UKSC_DA_AttrSet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F91B RID: 63771
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_AttrSet";

		// Token: 0x0400F91C RID: 63772
		private static IntPtr _ClassPtr;

		// Token: 0x0400F91D RID: 63773
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F91E RID: 63774
		internal static int __PropertyOffset_RuntimeClass;

		// Token: 0x0400F91F RID: 63775
		internal static int __PropertyOffset_Attrs;

		// Token: 0x0400F920 RID: 63776
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _Attrs;
	}
}
