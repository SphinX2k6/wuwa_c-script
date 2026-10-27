using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000892 RID: 2194
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneSplitMeshDA")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UBakedBoneSplitMeshDA : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060077FC RID: 30716 RVA: 0x000ABCE2 File Offset: 0x000A9EE2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBakedBoneSplitMeshDA._ClassPtr;
		}

		// Token: 0x060077FD RID: 30717 RVA: 0x000ABCF0 File Offset: 0x000A9EF0
		public UBakedBoneSplitMeshDA() : this(BuiltinUtils.AllocNativeUObject(UBakedBoneSplitMeshDA.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060077FE RID: 30718 RVA: 0x000ABD18 File Offset: 0x000A9F18
		public UBakedBoneSplitMeshDA(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBakedBoneSplitMeshDA.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C54 RID: 7252
		// (get) Token: 0x060077FF RID: 30719 RVA: 0x000ABD4C File Offset: 0x000A9F4C
		// (set) Token: 0x06007800 RID: 30720 RVA: 0x000ABD85 File Offset: 0x000A9F85
		public TArray<FBakedBoneSplitSingleMeshConfig> Meshes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedBoneSplitSingleMeshConfig> result;
				if ((result = this._Meshes) == null)
				{
					result = (this._Meshes = new TArray<FBakedBoneSplitSingleMeshConfig>(base.NativePtr + (IntPtr)UBakedBoneSplitMeshDA.__PropertyOffset_Meshes, this));
				}
				return result;
			}
			set
			{
				this.Meshes.CopyAssign(value);
			}
		}

		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x06007801 RID: 30721 RVA: 0x000ABD93 File Offset: 0x000A9F93
		// (set) Token: 0x06007802 RID: 30722 RVA: 0x000ABDA7 File Offset: 0x000A9FA7
		public unsafe FBoxSphereBounds InstanceBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneSplitMeshDA.__PropertyOffset_InstanceBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneSplitMeshDA.__PropertyOffset_InstanceBounds) = value;
			}
		}

		// Token: 0x06007803 RID: 30723 RVA: 0x000ABDBC File Offset: 0x000A9FBC
		static UBakedBoneSplitMeshDA()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BakedBoneSplitMeshDA");
		}

		// Token: 0x06007804 RID: 30724 RVA: 0x000ABDCA File Offset: 0x000A9FCA
		protected UBakedBoneSplitMeshDA(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400399D RID: 14749
		public new const string __ObjectPath = "/Script/Engine.BakedBoneSplitMeshDA";

		// Token: 0x0400399E RID: 14750
		private static IntPtr _ClassPtr;

		// Token: 0x0400399F RID: 14751
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040039A0 RID: 14752
		internal static int __PropertyOffset_Meshes;

		// Token: 0x040039A1 RID: 14753
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedBoneSplitSingleMeshConfig> _Meshes;

		// Token: 0x040039A2 RID: 14754
		internal static int __PropertyOffset_InstanceBounds;
	}
}
