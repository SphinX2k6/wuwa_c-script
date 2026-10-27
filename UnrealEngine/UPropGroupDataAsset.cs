using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001813 RID: 6163
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroDynamicMeshBatch.PropGroupDataAsset")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UPropGroupDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016CCE RID: 93390 RVA: 0x002144B2 File Offset: 0x002126B2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPropGroupDataAsset._ClassPtr;
		}

		// Token: 0x06016CCF RID: 93391 RVA: 0x002144C0 File Offset: 0x002126C0
		public UPropGroupDataAsset() : this(BuiltinUtils.AllocNativeUObject(UPropGroupDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016CD0 RID: 93392 RVA: 0x002144E8 File Offset: 0x002126E8
		public UPropGroupDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPropGroupDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C13 RID: 23571
		// (get) Token: 0x06016CD1 RID: 93393 RVA: 0x0021451C File Offset: 0x0021271C
		// (set) Token: 0x06016CD2 RID: 93394 RVA: 0x00214555 File Offset: 0x00212755
		public TArray<FPropGroup> PropGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPropGroup> result;
				if ((result = this._PropGroups) == null)
				{
					result = (this._PropGroups = new TArray<FPropGroup>(base.NativePtr + (IntPtr)UPropGroupDataAsset.__PropertyOffset_PropGroups, this));
				}
				return result;
			}
			set
			{
				this.PropGroups.CopyAssign(value);
			}
		}

		// Token: 0x06016CD3 RID: 93395 RVA: 0x00214563 File Offset: 0x00212763
		static UPropGroupDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroDynamicMeshBatch.PropGroupDataAsset");
		}

		// Token: 0x06016CD4 RID: 93396 RVA: 0x00214571 File Offset: 0x00212771
		protected UPropGroupDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C5E5 RID: 50661
		public new const string __ObjectPath = "/Script/KuroDynamicMeshBatch.PropGroupDataAsset";

		// Token: 0x0400C5E6 RID: 50662
		private static IntPtr _ClassPtr;

		// Token: 0x0400C5E7 RID: 50663
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C5E8 RID: 50664
		internal static int __PropertyOffset_PropGroups;

		// Token: 0x0400C5E9 RID: 50665
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPropGroup> _PropGroups;
	}
}
