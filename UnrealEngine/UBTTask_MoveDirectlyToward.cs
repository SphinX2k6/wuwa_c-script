using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000159 RID: 345
	[UnrealObjectPath("/Script/AIModule.BTTask_MoveDirectlyToward")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UBTTask_MoveDirectlyToward : UBTTask_MoveTo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060017AE RID: 6062 RVA: 0x00022CD3 File Offset: 0x00020ED3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_MoveDirectlyToward._ClassPtr;
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x00022CE0 File Offset: 0x00020EE0
		public UBTTask_MoveDirectlyToward() : this(BuiltinUtils.AllocNativeUObject(UBTTask_MoveDirectlyToward.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x00022D08 File Offset: 0x00020F08
		[NullableContext(1)]
		public UBTTask_MoveDirectlyToward(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTTask_MoveDirectlyToward.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x060017B1 RID: 6065 RVA: 0x00022D3B File Offset: 0x00020F3B
		// (set) Token: 0x060017B2 RID: 6066 RVA: 0x00022D54 File Offset: 0x00020F54
		public unsafe bool bDisablePathUpdateOnGoalLocationChange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTTask_MoveDirectlyToward.__PropertyOffset_bDisablePathUpdateOnGoalLocationChange) & UBTTask_MoveDirectlyToward.__PropertyMask_bDisablePathUpdateOnGoalLocationChange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTTask_MoveDirectlyToward.__PropertyOffset_bDisablePathUpdateOnGoalLocationChange) = ((*(base.NativePtr + (IntPtr)UBTTask_MoveDirectlyToward.__PropertyOffset_bDisablePathUpdateOnGoalLocationChange) & ~UBTTask_MoveDirectlyToward.__PropertyMask_bDisablePathUpdateOnGoalLocationChange) | (value ? UBTTask_MoveDirectlyToward.__PropertyMask_bDisablePathUpdateOnGoalLocationChange : 0));
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x00022D84 File Offset: 0x00020F84
		// (set) Token: 0x060017B4 RID: 6068 RVA: 0x00022D9D File Offset: 0x00020F9D
		public unsafe bool bProjectVectorGoalToNavigation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTTask_MoveDirectlyToward.__PropertyOffset_bProjectVectorGoalToNavigation) & UBTTask_MoveDirectlyToward.__PropertyMask_bProjectVectorGoalToNavigation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTTask_MoveDirectlyToward.__PropertyOffset_bProjectVectorGoalToNavigation) = ((*(base.NativePtr + (IntPtr)UBTTask_MoveDirectlyToward.__PropertyOffset_bProjectVectorGoalToNavigation) & ~UBTTask_MoveDirectlyToward.__PropertyMask_bProjectVectorGoalToNavigation) | (value ? UBTTask_MoveDirectlyToward.__PropertyMask_bProjectVectorGoalToNavigation : 0));
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x00022DCD File Offset: 0x00020FCD
		// (set) Token: 0x060017B6 RID: 6070 RVA: 0x00022DE6 File Offset: 0x00020FE6
		public unsafe bool bUpdatedDeprecatedProperties
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTTask_MoveDirectlyToward.__PropertyOffset_bUpdatedDeprecatedProperties) & UBTTask_MoveDirectlyToward.__PropertyMask_bUpdatedDeprecatedProperties) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTTask_MoveDirectlyToward.__PropertyOffset_bUpdatedDeprecatedProperties) = ((*(base.NativePtr + (IntPtr)UBTTask_MoveDirectlyToward.__PropertyOffset_bUpdatedDeprecatedProperties) & ~UBTTask_MoveDirectlyToward.__PropertyMask_bUpdatedDeprecatedProperties) | (value ? UBTTask_MoveDirectlyToward.__PropertyMask_bUpdatedDeprecatedProperties : 0));
			}
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x00022E16 File Offset: 0x00021016
		static UBTTask_MoveDirectlyToward()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTask_MoveDirectlyToward");
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x00022E24 File Offset: 0x00021024
		protected UBTTask_MoveDirectlyToward(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005AC RID: 1452
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTTask_MoveDirectlyToward";

		// Token: 0x040005AD RID: 1453
		private static IntPtr _ClassPtr;

		// Token: 0x040005AE RID: 1454
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040005AF RID: 1455
		internal static int __PropertyOffset_bDisablePathUpdateOnGoalLocationChange;

		// Token: 0x040005B0 RID: 1456
		internal static byte __PropertyMask_bDisablePathUpdateOnGoalLocationChange;

		// Token: 0x040005B1 RID: 1457
		internal static int __PropertyOffset_bProjectVectorGoalToNavigation;

		// Token: 0x040005B2 RID: 1458
		internal static byte __PropertyMask_bProjectVectorGoalToNavigation;

		// Token: 0x040005B3 RID: 1459
		internal static int __PropertyOffset_bUpdatedDeprecatedProperties;

		// Token: 0x040005B4 RID: 1460
		internal static byte __PropertyMask_bUpdatedDeprecatedProperties;
	}
}
