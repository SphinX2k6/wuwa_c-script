using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024B0 RID: 9392
	[UnrealObjectPath("/Script/NavigationSystem.RecastTileVariantsDataChunk")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class URecastTileVariantsDataChunk : URecastNavMeshDataChunk, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060232D1 RID: 144081 RVA: 0x00340908 File Offset: 0x0033EB08
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URecastTileVariantsDataChunk._ClassPtr;
		}

		// Token: 0x060232D2 RID: 144082 RVA: 0x00340914 File Offset: 0x0033EB14
		public URecastTileVariantsDataChunk() : this(BuiltinUtils.AllocNativeUObject(URecastTileVariantsDataChunk.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060232D3 RID: 144083 RVA: 0x0034093C File Offset: 0x0033EB3C
		[NullableContext(1)]
		public URecastTileVariantsDataChunk(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URecastTileVariantsDataChunk.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060232D4 RID: 144084 RVA: 0x0034096F File Offset: 0x0033EB6F
		static URecastTileVariantsDataChunk()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.RecastTileVariantsDataChunk");
		}

		// Token: 0x060232D5 RID: 144085 RVA: 0x0034097D File Offset: 0x0033EB7D
		protected URecastTileVariantsDataChunk(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012C9A RID: 76954
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.RecastTileVariantsDataChunk";

		// Token: 0x04012C9B RID: 76955
		private static IntPtr _ClassPtr;

		// Token: 0x04012C9C RID: 76956
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
