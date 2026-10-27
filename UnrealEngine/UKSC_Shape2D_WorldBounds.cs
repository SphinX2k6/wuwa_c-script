using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E3B RID: 7739
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2D_WorldBounds")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UKSC_Shape2D_WorldBounds : UKSC_WorldBounds, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D7E6 RID: 120806 RVA: 0x002B8C02 File Offset: 0x002B6E02
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Shape2D_WorldBounds._ClassPtr;
		}

		// Token: 0x0601D7E7 RID: 120807 RVA: 0x002B8C10 File Offset: 0x002B6E10
		public UKSC_Shape2D_WorldBounds() : this(BuiltinUtils.AllocNativeUObject(UKSC_Shape2D_WorldBounds.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D7E8 RID: 120808 RVA: 0x002B8C38 File Offset: 0x002B6E38
		[NullableContext(1)]
		public UKSC_Shape2D_WorldBounds(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Shape2D_WorldBounds.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076D5 RID: 30421
		// (get) Token: 0x0601D7E9 RID: 120809 RVA: 0x002B8C6C File Offset: 0x002B6E6C
		// (set) Token: 0x0601D7EA RID: 120810 RVA: 0x002B8CA5 File Offset: 0x002B6EA5
		[Nullable(1)]
		public TArray<UKSC_Shape2D_WorldBounds_Item> BoundItemObjs
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_Shape2D_WorldBounds_Item> result;
				if ((result = this._BoundItemObjs) == null)
				{
					result = (this._BoundItemObjs = new TArray<UKSC_Shape2D_WorldBounds_Item>(base.NativePtr + (IntPtr)UKSC_Shape2D_WorldBounds.__PropertyOffset_BoundItemObjs, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BoundItemObjs.CopyAssign(value);
			}
		}

		// Token: 0x170076D6 RID: 30422
		// (get) Token: 0x0601D7EB RID: 120811 RVA: 0x002B8CB3 File Offset: 0x002B6EB3
		// (set) Token: 0x0601D7EC RID: 120812 RVA: 0x002B8CC7 File Offset: 0x002B6EC7
		public unsafe UKSC_Shape2D_World KscShapeWorld
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Shape2D_World>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2D_WorldBounds.__PropertyOffset_KscShapeWorld);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2D_WorldBounds.__PropertyOffset_KscShapeWorld, value);
			}
		}

		// Token: 0x170076D7 RID: 30423
		// (get) Token: 0x0601D7ED RID: 120813 RVA: 0x002B8CDC File Offset: 0x002B6EDC
		// (set) Token: 0x0601D7EE RID: 120814 RVA: 0x002B8CF0 File Offset: 0x002B6EF0
		public unsafe UKSC_DA_Shape2D_WorldBounds DA_WorldBounds
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Shape2D_WorldBounds>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2D_WorldBounds.__PropertyOffset_DA_WorldBounds);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2D_WorldBounds.__PropertyOffset_DA_WorldBounds, value);
			}
		}

		// Token: 0x0601D7EF RID: 120815 RVA: 0x002B8D05 File Offset: 0x002B6F05
		static UKSC_Shape2D_WorldBounds()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Shape2D_WorldBounds");
		}

		// Token: 0x0601D7F0 RID: 120816 RVA: 0x002B8D13 File Offset: 0x002B6F13
		protected UKSC_Shape2D_WorldBounds(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FFC4 RID: 65476
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2D_WorldBounds";

		// Token: 0x0400FFC5 RID: 65477
		private static IntPtr _ClassPtr;

		// Token: 0x0400FFC6 RID: 65478
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FFC7 RID: 65479
		internal static int __PropertyOffset_BoundItemObjs;

		// Token: 0x0400FFC8 RID: 65480
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_Shape2D_WorldBounds_Item> _BoundItemObjs;

		// Token: 0x0400FFC9 RID: 65481
		internal static int __PropertyOffset_KscShapeWorld;

		// Token: 0x0400FFCA RID: 65482
		internal static int __PropertyOffset_DA_WorldBounds;
	}
}
