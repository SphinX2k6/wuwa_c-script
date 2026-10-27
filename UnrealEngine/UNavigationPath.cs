using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002493 RID: 9363
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NavigationSystem.NavigationPath")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UNavigationPath : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023030 RID: 143408 RVA: 0x0033C489 File Offset: 0x0033A689
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavigationPath._ClassPtr;
		}

		// Token: 0x06023031 RID: 143409 RVA: 0x0033C498 File Offset: 0x0033A698
		public UNavigationPath() : this(BuiltinUtils.AllocNativeUObject(UNavigationPath.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023032 RID: 143410 RVA: 0x0033C4C0 File Offset: 0x0033A6C0
		public UNavigationPath(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavigationPath.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008682 RID: 34434
		// (get) Token: 0x06023033 RID: 143411 RVA: 0x0033C4F4 File Offset: 0x0033A6F4
		// (set) Token: 0x06023034 RID: 143412 RVA: 0x0033C52D File Offset: 0x0033A72D
		public FOnNavigationPathUpdated PathUpdatedNotifier
		{
			get
			{
				base.FastCheckIsValid();
				FOnNavigationPathUpdated result;
				if ((result = this._PathUpdatedNotifier) == null)
				{
					result = (this._PathUpdatedNotifier = new FOnNavigationPathUpdated(base.NativePtr + (IntPtr)UNavigationPath.__PropertyOffset_PathUpdatedNotifier, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UNavigationPath.__PropertyOffset_PathUpdatedNotifier, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008683 RID: 34435
		// (get) Token: 0x06023035 RID: 143413 RVA: 0x0033C550 File Offset: 0x0033A750
		// (set) Token: 0x06023036 RID: 143414 RVA: 0x0033C589 File Offset: 0x0033A789
		public TArray<FVector> PathPoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PathPoints) == null)
				{
					result = (this._PathPoints = new TArray<FVector>(base.NativePtr + (IntPtr)UNavigationPath.__PropertyOffset_PathPoints, this));
				}
				return result;
			}
			set
			{
				this.PathPoints.CopyAssign(value);
			}
		}

		// Token: 0x17008684 RID: 34436
		// (get) Token: 0x06023037 RID: 143415 RVA: 0x0033C597 File Offset: 0x0033A797
		// (set) Token: 0x06023038 RID: 143416 RVA: 0x0033C5AB File Offset: 0x0033A7AB
		[Nullable(0)]
		public unsafe TEnumAsByte<ENavigationOptionFlag> RecalculateOnInvalidation
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavigationPath.__PropertyOffset_RecalculateOnInvalidation);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UNavigationPath.__PropertyOffset_RecalculateOnInvalidation) = value;
			}
		}

		// Token: 0x17008685 RID: 34437
		// (get) Token: 0x06023039 RID: 143417 RVA: 0x0033C5C0 File Offset: 0x0033A7C0
		// (set) Token: 0x0602303A RID: 143418 RVA: 0x0033C5D4 File Offset: 0x0033A7D4
		[Nullable(2)]
		public unsafe UNavigationPartitionPathBase NavPartitionPath
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNavigationPartitionPathBase>(base.NativePtr / (IntPtr)sizeof(void*) + UNavigationPath.__PropertyOffset_NavPartitionPath);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNavigationPath.__PropertyOffset_NavPartitionPath, value);
			}
		}

		// Token: 0x0602303B RID: 143419 RVA: 0x0033C5E9 File Offset: 0x0033A7E9
		public new bool IsValid()
		{
			return UNavigationPath.__IsValid_Internal(base.NativePtr);
		}

		// Token: 0x0602303C RID: 143420 RVA: 0x0033C5F6 File Offset: 0x0033A7F6
		public bool IsStringPulled()
		{
			return UNavigationPath.__IsStringPulled_Internal(base.NativePtr);
		}

		// Token: 0x0602303D RID: 143421 RVA: 0x0033C603 File Offset: 0x0033A803
		public bool IsPartial()
		{
			return UNavigationPath.__IsPartial_Internal(base.NativePtr);
		}

		// Token: 0x0602303E RID: 143422 RVA: 0x0033C610 File Offset: 0x0033A810
		public float GetPathLength()
		{
			return UNavigationPath.__GetPathLength_Internal(base.NativePtr);
		}

		// Token: 0x0602303F RID: 143423 RVA: 0x0033C61D File Offset: 0x0033A81D
		public float GetPathCost()
		{
			return UNavigationPath.__GetPathCost_Internal(base.NativePtr);
		}

		// Token: 0x06023040 RID: 143424 RVA: 0x0033C62A File Offset: 0x0033A82A
		public string GetDebugString()
		{
			return FString.ToStringAndDeleteNativePtr(UNavigationPath.__GetDebugString_Internal(base.NativePtr));
		}

		// Token: 0x06023041 RID: 143425 RVA: 0x0033C63C File Offset: 0x0033A83C
		public void EnableRecalculationOnInvalidation(ENavigationOptionFlag DoRecalculation)
		{
			UNavigationPath.__EnableRecalculationOnInvalidation_Internal(base.NativePtr, DoRecalculation);
		}

		// Token: 0x06023042 RID: 143426 RVA: 0x0033C650 File Offset: 0x0033A850
		public void EnableDebugDrawing(bool bShouldDrawDebugData, FLinearColor? PathColor = null)
		{
			UNavigationPath.__EnableDebugDrawing_Internal(base.NativePtr, bShouldDrawDebugData, PathColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			});
		}

		// Token: 0x06023043 RID: 143427
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsValid_Internal(IntPtr @this);

		// Token: 0x06023044 RID: 143428
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStringPulled_Internal(IntPtr @this);

		// Token: 0x06023045 RID: 143429
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPartial_Internal(IntPtr @this);

		// Token: 0x06023046 RID: 143430
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPathLength_Internal(IntPtr @this);

		// Token: 0x06023047 RID: 143431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPathCost_Internal(IntPtr @this);

		// Token: 0x06023048 RID: 143432
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDebugString_Internal(IntPtr @this);

		// Token: 0x06023049 RID: 143433
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableRecalculationOnInvalidation_Internal(IntPtr @this, TEnumAsByte<ENavigationOptionFlag> DoRecalculation);

		// Token: 0x0602304A RID: 143434
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableDebugDrawing_Internal(IntPtr @this, bool bShouldDrawDebugData, FLinearColor PathColor);

		// Token: 0x0602304B RID: 143435 RVA: 0x0033C6B5 File Offset: 0x0033A8B5
		static UNavigationPath()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavigationPath");
		}

		// Token: 0x0602304C RID: 143436 RVA: 0x0033C6C3 File Offset: 0x0033A8C3
		protected UNavigationPath(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012B1C RID: 76572
		public new const string __ObjectPath = "/Script/NavigationSystem.NavigationPath";

		// Token: 0x04012B1D RID: 76573
		private static IntPtr _ClassPtr;

		// Token: 0x04012B1E RID: 76574
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012B1F RID: 76575
		internal static int __PropertyOffset_PathUpdatedNotifier;

		// Token: 0x04012B20 RID: 76576
		[Nullable(2)]
		private FOnNavigationPathUpdated _PathUpdatedNotifier;

		// Token: 0x04012B21 RID: 76577
		internal static int __PropertyOffset_PathPoints;

		// Token: 0x04012B22 RID: 76578
		[Nullable(2)]
		private TArray<FVector> _PathPoints;

		// Token: 0x04012B23 RID: 76579
		internal static int __PropertyOffset_RecalculateOnInvalidation;

		// Token: 0x04012B24 RID: 76580
		internal static int __PropertyOffset_NavPartitionPath;
	}
}
