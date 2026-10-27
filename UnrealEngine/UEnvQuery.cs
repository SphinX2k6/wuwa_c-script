using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200018C RID: 396
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQuery")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UEnvQuery : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060018CB RID: 6347 RVA: 0x00024744 File Offset: 0x00022944
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQuery._ClassPtr;
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x00024750 File Offset: 0x00022950
		public UEnvQuery() : this(BuiltinUtils.AllocNativeUObject(UEnvQuery.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x00024778 File Offset: 0x00022978
		public UEnvQuery(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQuery.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060018CE RID: 6350 RVA: 0x000247AB File Offset: 0x000229AB
		// (set) Token: 0x060018CF RID: 6351 RVA: 0x000247BF File Offset: 0x000229BF
		public unsafe FName QueryName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQuery.__PropertyOffset_QueryName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQuery.__PropertyOffset_QueryName) = value;
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x000247D4 File Offset: 0x000229D4
		// (set) Token: 0x060018D1 RID: 6353 RVA: 0x0002480D File Offset: 0x00022A0D
		public TArray<UEnvQueryOption> Options
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UEnvQueryOption> result;
				if ((result = this._Options) == null)
				{
					result = (this._Options = new TArray<UEnvQueryOption>(base.NativePtr + (IntPtr)UEnvQuery.__PropertyOffset_Options, this));
				}
				return result;
			}
			set
			{
				this.Options.CopyAssign(value);
			}
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x0002481B File Offset: 0x00022A1B
		static UEnvQuery()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQuery");
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x00024829 File Offset: 0x00022A29
		protected UEnvQuery(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040006F0 RID: 1776
		public new const string __ObjectPath = "/Script/AIModule.EnvQuery";

		// Token: 0x040006F1 RID: 1777
		private static IntPtr _ClassPtr;

		// Token: 0x040006F2 RID: 1778
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040006F3 RID: 1779
		internal static int __PropertyOffset_QueryName;

		// Token: 0x040006F4 RID: 1780
		internal static int __PropertyOffset_Options;

		// Token: 0x040006F5 RID: 1781
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UEnvQueryOption> _Options;
	}
}
