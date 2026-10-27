using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001B0 RID: 432
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQueryTest_PathfindingBatch")]
	[UnrealStructLayout(824, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 824)]
	public class UEnvQueryTest_PathfindingBatch : UEnvQueryTest_Pathfinding, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001A6E RID: 6766 RVA: 0x00027486 File Offset: 0x00025686
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryTest_PathfindingBatch._ClassPtr;
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x00027494 File Offset: 0x00025694
		public UEnvQueryTest_PathfindingBatch() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTest_PathfindingBatch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x000274BC File Offset: 0x000256BC
		public UEnvQueryTest_PathfindingBatch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTest_PathfindingBatch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001A71 RID: 6769 RVA: 0x000274F0 File Offset: 0x000256F0
		// (set) Token: 0x06001A72 RID: 6770 RVA: 0x00027529 File Offset: 0x00025729
		public FAIDataProviderFloatValue ScanRangeMultiplier
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._ScanRangeMultiplier) == null)
				{
					result = (this._ScanRangeMultiplier = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryTest_PathfindingBatch.__PropertyOffset_ScanRangeMultiplier, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryTest_PathfindingBatch.__PropertyOffset_ScanRangeMultiplier, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x0002754A File Offset: 0x0002574A
		static UEnvQueryTest_PathfindingBatch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryTest_PathfindingBatch");
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x00027558 File Offset: 0x00025758
		protected UEnvQueryTest_PathfindingBatch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040007FF RID: 2047
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryTest_PathfindingBatch";

		// Token: 0x04000800 RID: 2048
		private static IntPtr _ClassPtr;

		// Token: 0x04000801 RID: 2049
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000802 RID: 2050
		internal static int __PropertyOffset_ScanRangeMultiplier;

		// Token: 0x04000803 RID: 2051
		[Nullable(2)]
		private FAIDataProviderFloatValue _ScanRangeMultiplier;
	}
}
