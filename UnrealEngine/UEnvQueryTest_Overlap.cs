using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001AE RID: 430
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQueryTest_Overlap")]
	[UnrealStructLayout(640, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 640)]
	public class UEnvQueryTest_Overlap : UEnvQueryTest, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001A58 RID: 6744 RVA: 0x000271F5 File Offset: 0x000253F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryTest_Overlap._ClassPtr;
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x00027204 File Offset: 0x00025404
		public UEnvQueryTest_Overlap() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTest_Overlap.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x0002722C File Offset: 0x0002542C
		public UEnvQueryTest_Overlap(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTest_Overlap.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001A5B RID: 6747 RVA: 0x00027260 File Offset: 0x00025460
		// (set) Token: 0x06001A5C RID: 6748 RVA: 0x00027299 File Offset: 0x00025499
		public FEnvOverlapData OverlapData
		{
			get
			{
				base.FastCheckIsValid();
				FEnvOverlapData result;
				if ((result = this._OverlapData) == null)
				{
					result = (this._OverlapData = new FEnvOverlapData(base.NativePtr + (IntPtr)UEnvQueryTest_Overlap.__PropertyOffset_OverlapData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEnvOverlapData.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryTest_Overlap.__PropertyOffset_OverlapData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x000272BA File Offset: 0x000254BA
		static UEnvQueryTest_Overlap()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryTest_Overlap");
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x000272C8 File Offset: 0x000254C8
		protected UEnvQueryTest_Overlap(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040007F0 RID: 2032
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryTest_Overlap";

		// Token: 0x040007F1 RID: 2033
		private static IntPtr _ClassPtr;

		// Token: 0x040007F2 RID: 2034
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040007F3 RID: 2035
		internal static int __PropertyOffset_OverlapData;

		// Token: 0x040007F4 RID: 2036
		[Nullable(2)]
		private FEnvOverlapData _OverlapData;
	}
}
