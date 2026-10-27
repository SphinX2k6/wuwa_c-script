using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000195 RID: 405
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQueryGenerator_Composite")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UEnvQueryGenerator_Composite : UEnvQueryGenerator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001917 RID: 6423 RVA: 0x00025035 File Offset: 0x00023235
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryGenerator_Composite._ClassPtr;
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x00025044 File Offset: 0x00023244
		public UEnvQueryGenerator_Composite() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryGenerator_Composite.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x0002506C File Offset: 0x0002326C
		public UEnvQueryGenerator_Composite(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryGenerator_Composite.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x000250A0 File Offset: 0x000232A0
		// (set) Token: 0x0600191B RID: 6427 RVA: 0x000250D9 File Offset: 0x000232D9
		public TArray<UEnvQueryGenerator> Generators
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UEnvQueryGenerator> result;
				if ((result = this._Generators) == null)
				{
					result = (this._Generators = new TArray<UEnvQueryGenerator>(base.NativePtr + (IntPtr)UEnvQueryGenerator_Composite.__PropertyOffset_Generators, this));
				}
				return result;
			}
			set
			{
				this.Generators.CopyAssign(value);
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x000250E7 File Offset: 0x000232E7
		// (set) Token: 0x0600191D RID: 6429 RVA: 0x00025100 File Offset: 0x00023300
		public unsafe bool bAllowDifferentItemTypes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEnvQueryGenerator_Composite.__PropertyOffset_bAllowDifferentItemTypes) & UEnvQueryGenerator_Composite.__PropertyMask_bAllowDifferentItemTypes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEnvQueryGenerator_Composite.__PropertyOffset_bAllowDifferentItemTypes) = ((*(base.NativePtr + (IntPtr)UEnvQueryGenerator_Composite.__PropertyOffset_bAllowDifferentItemTypes) & ~UEnvQueryGenerator_Composite.__PropertyMask_bAllowDifferentItemTypes) | (value ? UEnvQueryGenerator_Composite.__PropertyMask_bAllowDifferentItemTypes : 0));
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x00025130 File Offset: 0x00023330
		// (set) Token: 0x0600191F RID: 6431 RVA: 0x00025149 File Offset: 0x00023349
		public unsafe bool bHasMatchingItemType
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEnvQueryGenerator_Composite.__PropertyOffset_bHasMatchingItemType) & UEnvQueryGenerator_Composite.__PropertyMask_bHasMatchingItemType) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEnvQueryGenerator_Composite.__PropertyOffset_bHasMatchingItemType) = ((*(base.NativePtr + (IntPtr)UEnvQueryGenerator_Composite.__PropertyOffset_bHasMatchingItemType) & ~UEnvQueryGenerator_Composite.__PropertyMask_bHasMatchingItemType) | (value ? UEnvQueryGenerator_Composite.__PropertyMask_bHasMatchingItemType : 0));
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x00025179 File Offset: 0x00023379
		// (set) Token: 0x06001921 RID: 6433 RVA: 0x0002518D File Offset: 0x0002338D
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UEnvQueryItemType> ForcedItemType
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryGenerator_Composite.__PropertyOffset_ForcedItemType);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryGenerator_Composite.__PropertyOffset_ForcedItemType) = value;
			}
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x000251A2 File Offset: 0x000233A2
		static UEnvQueryGenerator_Composite()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryGenerator_Composite");
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x000251B0 File Offset: 0x000233B0
		protected UEnvQueryGenerator_Composite(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000720 RID: 1824
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryGenerator_Composite";

		// Token: 0x04000721 RID: 1825
		private static IntPtr _ClassPtr;

		// Token: 0x04000722 RID: 1826
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000723 RID: 1827
		internal static int __PropertyOffset_Generators;

		// Token: 0x04000724 RID: 1828
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UEnvQueryGenerator> _Generators;

		// Token: 0x04000725 RID: 1829
		internal static int __PropertyOffset_bAllowDifferentItemTypes;

		// Token: 0x04000726 RID: 1830
		internal static byte __PropertyMask_bAllowDifferentItemTypes;

		// Token: 0x04000727 RID: 1831
		internal static int __PropertyOffset_bHasMatchingItemType;

		// Token: 0x04000728 RID: 1832
		internal static byte __PropertyMask_bHasMatchingItemType;

		// Token: 0x04000729 RID: 1833
		internal static int __PropertyOffset_ForcedItemType;
	}
}
