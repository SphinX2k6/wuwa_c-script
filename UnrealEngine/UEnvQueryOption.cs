using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001A7 RID: 423
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQueryOption")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UEnvQueryOption : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060019E6 RID: 6630 RVA: 0x000266A1 File Offset: 0x000248A1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryOption._ClassPtr;
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x000266B0 File Offset: 0x000248B0
		public UEnvQueryOption() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryOption.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x000266D8 File Offset: 0x000248D8
		public UEnvQueryOption(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryOption.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x0002670B File Offset: 0x0002490B
		// (set) Token: 0x060019EA RID: 6634 RVA: 0x0002671F File Offset: 0x0002491F
		[Nullable(2)]
		public unsafe UEnvQueryGenerator Generator
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEnvQueryGenerator>(base.NativePtr / (IntPtr)sizeof(void*) + UEnvQueryOption.__PropertyOffset_Generator);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEnvQueryOption.__PropertyOffset_Generator, value);
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x00026734 File Offset: 0x00024934
		// (set) Token: 0x060019EC RID: 6636 RVA: 0x0002676D File Offset: 0x0002496D
		public TArray<UEnvQueryTest> Tests
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UEnvQueryTest> result;
				if ((result = this._Tests) == null)
				{
					result = (this._Tests = new TArray<UEnvQueryTest>(base.NativePtr + (IntPtr)UEnvQueryOption.__PropertyOffset_Tests, this));
				}
				return result;
			}
			set
			{
				this.Tests.CopyAssign(value);
			}
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x0002677B File Offset: 0x0002497B
		static UEnvQueryOption()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryOption");
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x00026789 File Offset: 0x00024989
		protected UEnvQueryOption(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040007AB RID: 1963
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryOption";

		// Token: 0x040007AC RID: 1964
		private static IntPtr _ClassPtr;

		// Token: 0x040007AD RID: 1965
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040007AE RID: 1966
		internal static int __PropertyOffset_Generator;

		// Token: 0x040007AF RID: 1967
		internal static int __PropertyOffset_Tests;

		// Token: 0x040007B0 RID: 1968
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UEnvQueryTest> _Tests;
	}
}
