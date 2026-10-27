using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000193 RID: 403
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQueryGenerator_ActorsOfClass")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UEnvQueryGenerator_ActorsOfClass : UEnvQueryGenerator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060018F8 RID: 6392 RVA: 0x00024D5D File Offset: 0x00022F5D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryGenerator_ActorsOfClass._ClassPtr;
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00024D6C File Offset: 0x00022F6C
		public UEnvQueryGenerator_ActorsOfClass() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryGenerator_ActorsOfClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x00024D94 File Offset: 0x00022F94
		public UEnvQueryGenerator_ActorsOfClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryGenerator_ActorsOfClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060018FB RID: 6395 RVA: 0x00024DC7 File Offset: 0x00022FC7
		// (set) Token: 0x060018FC RID: 6396 RVA: 0x00024DDB File Offset: 0x00022FDB
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AActor> SearchedActorClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryGenerator_ActorsOfClass.__PropertyOffset_SearchedActorClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryGenerator_ActorsOfClass.__PropertyOffset_SearchedActorClass) = value;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060018FD RID: 6397 RVA: 0x00024DF0 File Offset: 0x00022FF0
		// (set) Token: 0x060018FE RID: 6398 RVA: 0x00024E29 File Offset: 0x00023029
		public FAIDataProviderBoolValue GenerateOnlyActorsInRadius
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderBoolValue result;
				if ((result = this._GenerateOnlyActorsInRadius) == null)
				{
					result = (this._GenerateOnlyActorsInRadius = new FAIDataProviderBoolValue(base.NativePtr + (IntPtr)UEnvQueryGenerator_ActorsOfClass.__PropertyOffset_GenerateOnlyActorsInRadius, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderBoolValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_ActorsOfClass.__PropertyOffset_GenerateOnlyActorsInRadius, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060018FF RID: 6399 RVA: 0x00024E4C File Offset: 0x0002304C
		// (set) Token: 0x06001900 RID: 6400 RVA: 0x00024E85 File Offset: 0x00023085
		public FAIDataProviderFloatValue SearchRadius
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._SearchRadius) == null)
				{
					result = (this._SearchRadius = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryGenerator_ActorsOfClass.__PropertyOffset_SearchRadius, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_ActorsOfClass.__PropertyOffset_SearchRadius, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001901 RID: 6401 RVA: 0x00024EA6 File Offset: 0x000230A6
		// (set) Token: 0x06001902 RID: 6402 RVA: 0x00024EBA File Offset: 0x000230BA
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UEnvQueryContext> SearchCenter
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryGenerator_ActorsOfClass.__PropertyOffset_SearchCenter);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryGenerator_ActorsOfClass.__PropertyOffset_SearchCenter) = value;
			}
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x00024ECF File Offset: 0x000230CF
		static UEnvQueryGenerator_ActorsOfClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryGenerator_ActorsOfClass");
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x00024EDD File Offset: 0x000230DD
		protected UEnvQueryGenerator_ActorsOfClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000710 RID: 1808
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryGenerator_ActorsOfClass";

		// Token: 0x04000711 RID: 1809
		private static IntPtr _ClassPtr;

		// Token: 0x04000712 RID: 1810
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000713 RID: 1811
		internal static int __PropertyOffset_SearchedActorClass;

		// Token: 0x04000714 RID: 1812
		internal static int __PropertyOffset_GenerateOnlyActorsInRadius;

		// Token: 0x04000715 RID: 1813
		[Nullable(2)]
		private FAIDataProviderBoolValue _GenerateOnlyActorsInRadius;

		// Token: 0x04000716 RID: 1814
		internal static int __PropertyOffset_SearchRadius;

		// Token: 0x04000717 RID: 1815
		[Nullable(2)]
		private FAIDataProviderFloatValue _SearchRadius;

		// Token: 0x04000718 RID: 1816
		internal static int __PropertyOffset_SearchCenter;
	}
}
