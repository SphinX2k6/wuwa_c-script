using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C1E RID: 3102
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HierarchicalLODSetup")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UHierarchicalLODSetup : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009D11 RID: 40209 RVA: 0x000DF4E7 File Offset: 0x000DD6E7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHierarchicalLODSetup._ClassPtr;
		}

		// Token: 0x06009D12 RID: 40210 RVA: 0x000DF4F4 File Offset: 0x000DD6F4
		public UHierarchicalLODSetup() : this(BuiltinUtils.AllocNativeUObject(UHierarchicalLODSetup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009D13 RID: 40211 RVA: 0x000DF51C File Offset: 0x000DD71C
		public UHierarchicalLODSetup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHierarchicalLODSetup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002580 RID: 9600
		// (get) Token: 0x06009D14 RID: 40212 RVA: 0x000DF550 File Offset: 0x000DD750
		// (set) Token: 0x06009D15 RID: 40213 RVA: 0x000DF589 File Offset: 0x000DD789
		public TArray<FHierarchicalSimplification> HierarchicalLODSetup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FHierarchicalSimplification> result;
				if ((result = this._HierarchicalLODSetup) == null)
				{
					result = (this._HierarchicalLODSetup = new TArray<FHierarchicalSimplification>(base.NativePtr + (IntPtr)UHierarchicalLODSetup.__PropertyOffset_HierarchicalLODSetup, this));
				}
				return result;
			}
			set
			{
				this.HierarchicalLODSetup.CopyAssign(value);
			}
		}

		// Token: 0x17002581 RID: 9601
		// (get) Token: 0x06009D16 RID: 40214 RVA: 0x000DF597 File Offset: 0x000DD797
		// (set) Token: 0x06009D17 RID: 40215 RVA: 0x000DF5AC File Offset: 0x000DD7AC
		public TSoftObjectPtr<UMaterialInterface> OverrideBaseMaterial
		{
			get
			{
				return new TSoftObjectPtr<UMaterialInterface>(base.NativePtr + (IntPtr)UHierarchicalLODSetup.__PropertyOffset_OverrideBaseMaterial, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UHierarchicalLODSetup.__PropertyOffset_OverrideBaseMaterial, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06009D18 RID: 40216 RVA: 0x000DF5D1 File Offset: 0x000DD7D1
		static UHierarchicalLODSetup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HierarchicalLODSetup");
		}

		// Token: 0x06009D19 RID: 40217 RVA: 0x000DF5DF File Offset: 0x000DD7DF
		protected UHierarchicalLODSetup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040056AA RID: 22186
		public new const string __ObjectPath = "/Script/Engine.HierarchicalLODSetup";

		// Token: 0x040056AB RID: 22187
		private static IntPtr _ClassPtr;

		// Token: 0x040056AC RID: 22188
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040056AD RID: 22189
		internal static int __PropertyOffset_HierarchicalLODSetup;

		// Token: 0x040056AE RID: 22190
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FHierarchicalSimplification> _HierarchicalLODSetup;

		// Token: 0x040056AF RID: 22191
		internal static int __PropertyOffset_OverrideBaseMaterial;
	}
}
