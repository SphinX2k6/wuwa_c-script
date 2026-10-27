using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001AB RID: 427
	[UnrealObjectPath("/Script/AIModule.EnvQueryTest_Distance")]
	[UnrealStructLayout(624, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 624)]
	public class UEnvQueryTest_Distance : UEnvQueryTest, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001A35 RID: 6709 RVA: 0x00026E35 File Offset: 0x00025035
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryTest_Distance._ClassPtr;
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x00026E44 File Offset: 0x00025044
		public UEnvQueryTest_Distance() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTest_Distance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x00026E6C File Offset: 0x0002506C
		[NullableContext(1)]
		public UEnvQueryTest_Distance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTest_Distance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001A38 RID: 6712 RVA: 0x00026E9F File Offset: 0x0002509F
		// (set) Token: 0x06001A39 RID: 6713 RVA: 0x00026EB3 File Offset: 0x000250B3
		public unsafe TEnumAsByte<EEnvTestDistance> TestMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryTest_Distance.__PropertyOffset_TestMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest_Distance.__PropertyOffset_TestMode) = value;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06001A3A RID: 6714 RVA: 0x00026EC8 File Offset: 0x000250C8
		// (set) Token: 0x06001A3B RID: 6715 RVA: 0x00026EDC File Offset: 0x000250DC
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UEnvQueryContext> DistanceTo
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryTest_Distance.__PropertyOffset_DistanceTo);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest_Distance.__PropertyOffset_DistanceTo) = value;
			}
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x00026EF1 File Offset: 0x000250F1
		static UEnvQueryTest_Distance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryTest_Distance");
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x00026EFF File Offset: 0x000250FF
		protected UEnvQueryTest_Distance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040007D9 RID: 2009
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryTest_Distance";

		// Token: 0x040007DA RID: 2010
		private static IntPtr _ClassPtr;

		// Token: 0x040007DB RID: 2011
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040007DC RID: 2012
		internal static int __PropertyOffset_TestMode;

		// Token: 0x040007DD RID: 2013
		internal static int __PropertyOffset_DistanceTo;
	}
}
