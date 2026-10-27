using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200019C RID: 412
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQueryGenerator_SimpleGrid")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UEnvQueryGenerator_SimpleGrid : UEnvQueryGenerator_ProjectedPoints, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001981 RID: 6529 RVA: 0x00025DD9 File Offset: 0x00023FD9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryGenerator_SimpleGrid._ClassPtr;
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00025DE8 File Offset: 0x00023FE8
		public UEnvQueryGenerator_SimpleGrid() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryGenerator_SimpleGrid.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00025E10 File Offset: 0x00024010
		public UEnvQueryGenerator_SimpleGrid(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryGenerator_SimpleGrid.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001984 RID: 6532 RVA: 0x00025E44 File Offset: 0x00024044
		// (set) Token: 0x06001985 RID: 6533 RVA: 0x00025E7D File Offset: 0x0002407D
		public FAIDataProviderFloatValue GridSize
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._GridSize) == null)
				{
					result = (this._GridSize = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryGenerator_SimpleGrid.__PropertyOffset_GridSize, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_SimpleGrid.__PropertyOffset_GridSize, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001986 RID: 6534 RVA: 0x00025EA0 File Offset: 0x000240A0
		// (set) Token: 0x06001987 RID: 6535 RVA: 0x00025ED9 File Offset: 0x000240D9
		public FAIDataProviderFloatValue SpaceBetween
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._SpaceBetween) == null)
				{
					result = (this._SpaceBetween = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryGenerator_SimpleGrid.__PropertyOffset_SpaceBetween, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_SimpleGrid.__PropertyOffset_SpaceBetween, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001988 RID: 6536 RVA: 0x00025EFA File Offset: 0x000240FA
		// (set) Token: 0x06001989 RID: 6537 RVA: 0x00025F0E File Offset: 0x0002410E
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UEnvQueryContext> GenerateAround
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryGenerator_SimpleGrid.__PropertyOffset_GenerateAround);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryGenerator_SimpleGrid.__PropertyOffset_GenerateAround) = value;
			}
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x00025F23 File Offset: 0x00024123
		static UEnvQueryGenerator_SimpleGrid()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryGenerator_SimpleGrid");
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x00025F31 File Offset: 0x00024131
		protected UEnvQueryGenerator_SimpleGrid(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000773 RID: 1907
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryGenerator_SimpleGrid";

		// Token: 0x04000774 RID: 1908
		private static IntPtr _ClassPtr;

		// Token: 0x04000775 RID: 1909
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000776 RID: 1910
		internal static int __PropertyOffset_GridSize;

		// Token: 0x04000777 RID: 1911
		[Nullable(2)]
		private FAIDataProviderFloatValue _GridSize;

		// Token: 0x04000778 RID: 1912
		internal static int __PropertyOffset_SpaceBetween;

		// Token: 0x04000779 RID: 1913
		[Nullable(2)]
		private FAIDataProviderFloatValue _SpaceBetween;

		// Token: 0x0400077A RID: 1914
		internal static int __PropertyOffset_GenerateAround;
	}
}
