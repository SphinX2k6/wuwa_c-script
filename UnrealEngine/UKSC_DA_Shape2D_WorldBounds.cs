using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DB7 RID: 7607
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Shape2D_WorldBounds")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKSC_DA_Shape2D_WorldBounds : UKSC_DA_WorldBounds, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D148 RID: 119112 RVA: 0x002AF8D7 File Offset: 0x002ADAD7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Shape2D_WorldBounds._ClassPtr;
		}

		// Token: 0x0601D149 RID: 119113 RVA: 0x002AF8E4 File Offset: 0x002ADAE4
		public UKSC_DA_Shape2D_WorldBounds() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_WorldBounds.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D14A RID: 119114 RVA: 0x002AF90C File Offset: 0x002ADB0C
		public UKSC_DA_Shape2D_WorldBounds(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_WorldBounds.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007560 RID: 30048
		// (get) Token: 0x0601D14B RID: 119115 RVA: 0x002AF940 File Offset: 0x002ADB40
		// (set) Token: 0x0601D14C RID: 119116 RVA: 0x002AF979 File Offset: 0x002ADB79
		public TArray<FKSC_DA_Shape2D_WorldBounds_Item> BoundItems
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKSC_DA_Shape2D_WorldBounds_Item> result;
				if ((result = this._BoundItems) == null)
				{
					result = (this._BoundItems = new TArray<FKSC_DA_Shape2D_WorldBounds_Item>(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_WorldBounds.__PropertyOffset_BoundItems, this));
				}
				return result;
			}
			set
			{
				this.BoundItems.CopyAssign(value);
			}
		}

		// Token: 0x17007561 RID: 30049
		// (get) Token: 0x0601D14D RID: 119117 RVA: 0x002AF987 File Offset: 0x002ADB87
		// (set) Token: 0x0601D14E RID: 119118 RVA: 0x002AF99B File Offset: 0x002ADB9B
		public unsafe FVectorDouble WorldCenterOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_WorldBounds.__PropertyOffset_WorldCenterOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_WorldBounds.__PropertyOffset_WorldCenterOffset) = value;
			}
		}

		// Token: 0x0601D14F RID: 119119 RVA: 0x002AF9B0 File Offset: 0x002ADBB0
		static UKSC_DA_Shape2D_WorldBounds()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Shape2D_WorldBounds");
		}

		// Token: 0x0601D150 RID: 119120 RVA: 0x002AF9BE File Offset: 0x002ADBBE
		protected UKSC_DA_Shape2D_WorldBounds(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC95 RID: 64661
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Shape2D_WorldBounds";

		// Token: 0x0400FC96 RID: 64662
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC97 RID: 64663
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC98 RID: 64664
		internal static int __PropertyOffset_BoundItems;

		// Token: 0x0400FC99 RID: 64665
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSC_DA_Shape2D_WorldBounds_Item> _BoundItems;

		// Token: 0x0400FC9A RID: 64666
		internal static int __PropertyOffset_WorldCenterOffset;
	}
}
