using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024B2 RID: 9394
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NavigationSystem.TileVariantsChunksContainer")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UTileVariantsChunksContainer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060232E4 RID: 144100 RVA: 0x00340A76 File Offset: 0x0033EC76
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTileVariantsChunksContainer._ClassPtr;
		}

		// Token: 0x060232E5 RID: 144101 RVA: 0x00340A84 File Offset: 0x0033EC84
		public UTileVariantsChunksContainer() : this(BuiltinUtils.AllocNativeUObject(UTileVariantsChunksContainer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060232E6 RID: 144102 RVA: 0x00340AAC File Offset: 0x0033ECAC
		public UTileVariantsChunksContainer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTileVariantsChunksContainer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700874D RID: 34637
		// (get) Token: 0x060232E7 RID: 144103 RVA: 0x00340AE0 File Offset: 0x0033ECE0
		// (set) Token: 0x060232E8 RID: 144104 RVA: 0x00340B19 File Offset: 0x0033ED19
		public TArray<URecastTileVariantsDataChunk> DataChunks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<URecastTileVariantsDataChunk> result;
				if ((result = this._DataChunks) == null)
				{
					result = (this._DataChunks = new TArray<URecastTileVariantsDataChunk>(base.NativePtr + (IntPtr)UTileVariantsChunksContainer.__PropertyOffset_DataChunks, this));
				}
				return result;
			}
			set
			{
				this.DataChunks.CopyAssign(value);
			}
		}

		// Token: 0x060232E9 RID: 144105 RVA: 0x00340B27 File Offset: 0x0033ED27
		static UTileVariantsChunksContainer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.TileVariantsChunksContainer");
		}

		// Token: 0x060232EA RID: 144106 RVA: 0x00340B35 File Offset: 0x0033ED35
		protected UTileVariantsChunksContainer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012CA2 RID: 76962
		public new const string __ObjectPath = "/Script/NavigationSystem.TileVariantsChunksContainer";

		// Token: 0x04012CA3 RID: 76963
		private static IntPtr _ClassPtr;

		// Token: 0x04012CA4 RID: 76964
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012CA5 RID: 76965
		internal static int __PropertyOffset_DataChunks;

		// Token: 0x04012CA6 RID: 76966
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<URecastTileVariantsDataChunk> _DataChunks;
	}
}
