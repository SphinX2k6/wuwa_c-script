using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001AF RID: 431
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQueryTest_Pathfinding")]
	[UnrealStructLayout(760, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 760)]
	public class UEnvQueryTest_Pathfinding : UEnvQueryTest, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001A5F RID: 6751 RVA: 0x000272D1 File Offset: 0x000254D1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryTest_Pathfinding._ClassPtr;
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x000272E0 File Offset: 0x000254E0
		public UEnvQueryTest_Pathfinding() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTest_Pathfinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x00027308 File Offset: 0x00025508
		public UEnvQueryTest_Pathfinding(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTest_Pathfinding.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x0002733B File Offset: 0x0002553B
		// (set) Token: 0x06001A63 RID: 6755 RVA: 0x0002734F File Offset: 0x0002554F
		[Nullable(0)]
		public unsafe TEnumAsByte<EEnvTestPathfinding> TestMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryTest_Pathfinding.__PropertyOffset_TestMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest_Pathfinding.__PropertyOffset_TestMode) = value;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x00027364 File Offset: 0x00025564
		// (set) Token: 0x06001A65 RID: 6757 RVA: 0x00027378 File Offset: 0x00025578
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UEnvQueryContext> Context
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryTest_Pathfinding.__PropertyOffset_Context);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest_Pathfinding.__PropertyOffset_Context) = value;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x00027390 File Offset: 0x00025590
		// (set) Token: 0x06001A67 RID: 6759 RVA: 0x000273C9 File Offset: 0x000255C9
		public FAIDataProviderBoolValue PathFromContext
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderBoolValue result;
				if ((result = this._PathFromContext) == null)
				{
					result = (this._PathFromContext = new FAIDataProviderBoolValue(base.NativePtr + (IntPtr)UEnvQueryTest_Pathfinding.__PropertyOffset_PathFromContext, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderBoolValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryTest_Pathfinding.__PropertyOffset_PathFromContext, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x000273EC File Offset: 0x000255EC
		// (set) Token: 0x06001A69 RID: 6761 RVA: 0x00027425 File Offset: 0x00025625
		public FAIDataProviderBoolValue SkipUnreachable
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderBoolValue result;
				if ((result = this._SkipUnreachable) == null)
				{
					result = (this._SkipUnreachable = new FAIDataProviderBoolValue(base.NativePtr + (IntPtr)UEnvQueryTest_Pathfinding.__PropertyOffset_SkipUnreachable, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderBoolValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryTest_Pathfinding.__PropertyOffset_SkipUnreachable, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x00027446 File Offset: 0x00025646
		// (set) Token: 0x06001A6B RID: 6763 RVA: 0x0002745A File Offset: 0x0002565A
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavigationQueryFilter> FilterClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryTest_Pathfinding.__PropertyOffset_FilterClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest_Pathfinding.__PropertyOffset_FilterClass) = value;
			}
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x0002746F File Offset: 0x0002566F
		static UEnvQueryTest_Pathfinding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryTest_Pathfinding");
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x0002747D File Offset: 0x0002567D
		protected UEnvQueryTest_Pathfinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040007F5 RID: 2037
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryTest_Pathfinding";

		// Token: 0x040007F6 RID: 2038
		private static IntPtr _ClassPtr;

		// Token: 0x040007F7 RID: 2039
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040007F8 RID: 2040
		internal static int __PropertyOffset_TestMode;

		// Token: 0x040007F9 RID: 2041
		internal static int __PropertyOffset_Context;

		// Token: 0x040007FA RID: 2042
		internal static int __PropertyOffset_PathFromContext;

		// Token: 0x040007FB RID: 2043
		[Nullable(2)]
		private FAIDataProviderBoolValue _PathFromContext;

		// Token: 0x040007FC RID: 2044
		internal static int __PropertyOffset_SkipUnreachable;

		// Token: 0x040007FD RID: 2045
		[Nullable(2)]
		private FAIDataProviderBoolValue _SkipUnreachable;

		// Token: 0x040007FE RID: 2046
		internal static int __PropertyOffset_FilterClass;
	}
}
