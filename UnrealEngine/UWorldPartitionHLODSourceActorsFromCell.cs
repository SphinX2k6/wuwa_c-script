using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001260 RID: 4704
	[UnrealObjectPath("/Script/Engine.WorldPartitionHLODSourceActorsFromCell")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UWorldPartitionHLODSourceActorsFromCell : UWorldPartitionHLODSourceActors, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601144C RID: 70732 RVA: 0x001959B1 File Offset: 0x00193BB1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionHLODSourceActorsFromCell._ClassPtr;
		}

		// Token: 0x0601144D RID: 70733 RVA: 0x001959C0 File Offset: 0x00193BC0
		public UWorldPartitionHLODSourceActorsFromCell() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionHLODSourceActorsFromCell.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601144E RID: 70734 RVA: 0x001959E8 File Offset: 0x00193BE8
		[NullableContext(1)]
		public UWorldPartitionHLODSourceActorsFromCell(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionHLODSourceActorsFromCell.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601144F RID: 70735 RVA: 0x00195A1B File Offset: 0x00193C1B
		static UWorldPartitionHLODSourceActorsFromCell()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionHLODSourceActorsFromCell");
		}

		// Token: 0x06011450 RID: 70736 RVA: 0x00195A29 File Offset: 0x00193C29
		protected UWorldPartitionHLODSourceActorsFromCell(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040093D6 RID: 37846
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionHLODSourceActorsFromCell";

		// Token: 0x040093D7 RID: 37847
		private static IntPtr _ClassPtr;

		// Token: 0x040093D8 RID: 37848
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
