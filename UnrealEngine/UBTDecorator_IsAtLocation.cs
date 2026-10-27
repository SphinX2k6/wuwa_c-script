using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000144 RID: 324
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTDecorator_IsAtLocation")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UBTDecorator_IsAtLocation : UBTDecorator_BlackboardBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600168C RID: 5772 RVA: 0x0002130E File Offset: 0x0001F50E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator_IsAtLocation._ClassPtr;
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x0002131C File Offset: 0x0001F51C
		public UBTDecorator_IsAtLocation() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_IsAtLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00021344 File Offset: 0x0001F544
		public UBTDecorator_IsAtLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_IsAtLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x0600168F RID: 5775 RVA: 0x00021377 File Offset: 0x0001F577
		// (set) Token: 0x06001690 RID: 5776 RVA: 0x00021387 File Offset: 0x0001F587
		public unsafe float AcceptableRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_IsAtLocation.__PropertyOffset_AcceptableRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_IsAtLocation.__PropertyOffset_AcceptableRadius) = value;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001691 RID: 5777 RVA: 0x00021398 File Offset: 0x0001F598
		// (set) Token: 0x06001692 RID: 5778 RVA: 0x000213D1 File Offset: 0x0001F5D1
		public FAIDataProviderFloatValue ParametrizedAcceptableRadius
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._ParametrizedAcceptableRadius) == null)
				{
					result = (this._ParametrizedAcceptableRadius = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UBTDecorator_IsAtLocation.__PropertyOffset_ParametrizedAcceptableRadius, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UBTDecorator_IsAtLocation.__PropertyOffset_ParametrizedAcceptableRadius, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001693 RID: 5779 RVA: 0x000213F2 File Offset: 0x0001F5F2
		// (set) Token: 0x06001694 RID: 5780 RVA: 0x00021402 File Offset: 0x0001F602
		public unsafe FAIDistanceType GeometricDistanceType
		{
			get
			{
				return (FAIDistanceType)(*(base.NativePtr + (IntPtr)UBTDecorator_IsAtLocation.__PropertyOffset_GeometricDistanceType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_IsAtLocation.__PropertyOffset_GeometricDistanceType) = (byte)value;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001695 RID: 5781 RVA: 0x00021413 File Offset: 0x0001F613
		// (set) Token: 0x06001696 RID: 5782 RVA: 0x0002142C File Offset: 0x0001F62C
		public unsafe bool bUseParametrizedRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTDecorator_IsAtLocation.__PropertyOffset_bUseParametrizedRadius) & UBTDecorator_IsAtLocation.__PropertyMask_bUseParametrizedRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTDecorator_IsAtLocation.__PropertyOffset_bUseParametrizedRadius) = ((*(base.NativePtr + (IntPtr)UBTDecorator_IsAtLocation.__PropertyOffset_bUseParametrizedRadius) & ~UBTDecorator_IsAtLocation.__PropertyMask_bUseParametrizedRadius) | (value ? UBTDecorator_IsAtLocation.__PropertyMask_bUseParametrizedRadius : 0));
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001697 RID: 5783 RVA: 0x0002145C File Offset: 0x0001F65C
		// (set) Token: 0x06001698 RID: 5784 RVA: 0x00021475 File Offset: 0x0001F675
		public unsafe bool bUseNavAgentGoalLocation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTDecorator_IsAtLocation.__PropertyOffset_bUseNavAgentGoalLocation) & UBTDecorator_IsAtLocation.__PropertyMask_bUseNavAgentGoalLocation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTDecorator_IsAtLocation.__PropertyOffset_bUseNavAgentGoalLocation) = ((*(base.NativePtr + (IntPtr)UBTDecorator_IsAtLocation.__PropertyOffset_bUseNavAgentGoalLocation) & ~UBTDecorator_IsAtLocation.__PropertyMask_bUseNavAgentGoalLocation) | (value ? UBTDecorator_IsAtLocation.__PropertyMask_bUseNavAgentGoalLocation : 0));
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001699 RID: 5785 RVA: 0x000214A5 File Offset: 0x0001F6A5
		// (set) Token: 0x0600169A RID: 5786 RVA: 0x000214BE File Offset: 0x0001F6BE
		public unsafe bool bPathFindingBasedTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTDecorator_IsAtLocation.__PropertyOffset_bPathFindingBasedTest) & UBTDecorator_IsAtLocation.__PropertyMask_bPathFindingBasedTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTDecorator_IsAtLocation.__PropertyOffset_bPathFindingBasedTest) = ((*(base.NativePtr + (IntPtr)UBTDecorator_IsAtLocation.__PropertyOffset_bPathFindingBasedTest) & ~UBTDecorator_IsAtLocation.__PropertyMask_bPathFindingBasedTest) | (value ? UBTDecorator_IsAtLocation.__PropertyMask_bPathFindingBasedTest : 0));
			}
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x000214EE File Offset: 0x0001F6EE
		static UBTDecorator_IsAtLocation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTDecorator_IsAtLocation");
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x000214FC File Offset: 0x0001F6FC
		protected UBTDecorator_IsAtLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000528 RID: 1320
		public new const string __ObjectPath = "/Script/AIModule.BTDecorator_IsAtLocation";

		// Token: 0x04000529 RID: 1321
		private static IntPtr _ClassPtr;

		// Token: 0x0400052A RID: 1322
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400052B RID: 1323
		internal static int __PropertyOffset_AcceptableRadius;

		// Token: 0x0400052C RID: 1324
		internal static int __PropertyOffset_ParametrizedAcceptableRadius;

		// Token: 0x0400052D RID: 1325
		[Nullable(2)]
		private FAIDataProviderFloatValue _ParametrizedAcceptableRadius;

		// Token: 0x0400052E RID: 1326
		internal static int __PropertyOffset_GeometricDistanceType;

		// Token: 0x0400052F RID: 1327
		internal static int __PropertyOffset_bUseParametrizedRadius;

		// Token: 0x04000530 RID: 1328
		internal static byte __PropertyMask_bUseParametrizedRadius;

		// Token: 0x04000531 RID: 1329
		internal static int __PropertyOffset_bUseNavAgentGoalLocation;

		// Token: 0x04000532 RID: 1330
		internal static byte __PropertyMask_bUseNavAgentGoalLocation;

		// Token: 0x04000533 RID: 1331
		internal static int __PropertyOffset_bPathFindingBasedTest;

		// Token: 0x04000534 RID: 1332
		internal static byte __PropertyMask_bPathFindingBasedTest;
	}
}
