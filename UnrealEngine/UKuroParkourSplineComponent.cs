using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E7D RID: 7805
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSplines.KuroParkourSplineComponent")]
	[UnrealStructLayout(1920, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1920)]
	public class UKuroParkourSplineComponent : USplineComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DB5E RID: 121694 RVA: 0x002BE374 File Offset: 0x002BC574
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroParkourSplineComponent._ClassPtr;
		}

		// Token: 0x0601DB5F RID: 121695 RVA: 0x002BE380 File Offset: 0x002BC580
		public UKuroParkourSplineComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroParkourSplineComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DB60 RID: 121696 RVA: 0x002BE3A8 File Offset: 0x002BC5A8
		public UKuroParkourSplineComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroParkourSplineComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007775 RID: 30581
		// (get) Token: 0x0601DB61 RID: 121697 RVA: 0x002BE3DC File Offset: 0x002BC5DC
		// (set) Token: 0x0601DB62 RID: 121698 RVA: 0x002BE415 File Offset: 0x002BC615
		public TArray<float> RadiusGroup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._RadiusGroup) == null)
				{
					result = (this._RadiusGroup = new TArray<float>(base.NativePtr + (IntPtr)UKuroParkourSplineComponent.__PropertyOffset_RadiusGroup, this));
				}
				return result;
			}
			set
			{
				this.RadiusGroup.CopyAssign(value);
			}
		}

		// Token: 0x17007776 RID: 30582
		// (get) Token: 0x0601DB63 RID: 121699 RVA: 0x002BE424 File Offset: 0x002BC624
		// (set) Token: 0x0601DB64 RID: 121700 RVA: 0x002BE45D File Offset: 0x002BC65D
		public TArray<float> ModifiedTimes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ModifiedTimes) == null)
				{
					result = (this._ModifiedTimes = new TArray<float>(base.NativePtr + (IntPtr)UKuroParkourSplineComponent.__PropertyOffset_ModifiedTimes, this));
				}
				return result;
			}
			set
			{
				this.ModifiedTimes.CopyAssign(value);
			}
		}

		// Token: 0x17007777 RID: 30583
		// (get) Token: 0x0601DB65 RID: 121701 RVA: 0x002BE46C File Offset: 0x002BC66C
		// (set) Token: 0x0601DB66 RID: 121702 RVA: 0x002BE4A5 File Offset: 0x002BC6A5
		public TArray<int> BuffIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._BuffIds) == null)
				{
					result = (this._BuffIds = new TArray<int>(base.NativePtr + (IntPtr)UKuroParkourSplineComponent.__PropertyOffset_BuffIds, this));
				}
				return result;
			}
			set
			{
				this.BuffIds.CopyAssign(value);
			}
		}

		// Token: 0x0601DB67 RID: 121703 RVA: 0x002BE4B3 File Offset: 0x002BC6B3
		public float GetRadius(int Index)
		{
			return UKuroParkourSplineComponent.__GetRadius_Internal(base.NativePtr, Index);
		}

		// Token: 0x0601DB68 RID: 121704 RVA: 0x002BE4C1 File Offset: 0x002BC6C1
		public float GetModifiedTime(int Index)
		{
			return UKuroParkourSplineComponent.__GetModifiedTime_Internal(base.NativePtr, Index);
		}

		// Token: 0x0601DB69 RID: 121705 RVA: 0x002BE4CF File Offset: 0x002BC6CF
		public int GetBuffId(int Index)
		{
			return UKuroParkourSplineComponent.__GetBuffId_Internal(base.NativePtr, Index);
		}

		// Token: 0x0601DB6A RID: 121706
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRadius_Internal(IntPtr @this, int Index);

		// Token: 0x0601DB6B RID: 121707
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetModifiedTime_Internal(IntPtr @this, int Index);

		// Token: 0x0601DB6C RID: 121708
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetBuffId_Internal(IntPtr @this, int Index);

		// Token: 0x0601DB6D RID: 121709 RVA: 0x002BE4DD File Offset: 0x002BC6DD
		static UKuroParkourSplineComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSplines.KuroParkourSplineComponent");
		}

		// Token: 0x0601DB6E RID: 121710 RVA: 0x002BE4EB File Offset: 0x002BC6EB
		protected UKuroParkourSplineComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010167 RID: 65895
		public new const string __ObjectPath = "/Script/KuroSplines.KuroParkourSplineComponent";

		// Token: 0x04010168 RID: 65896
		private static IntPtr _ClassPtr;

		// Token: 0x04010169 RID: 65897
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401016A RID: 65898
		internal static int __PropertyOffset_RadiusGroup;

		// Token: 0x0401016B RID: 65899
		[Nullable(2)]
		private TArray<float> _RadiusGroup;

		// Token: 0x0401016C RID: 65900
		internal static int __PropertyOffset_ModifiedTimes;

		// Token: 0x0401016D RID: 65901
		[Nullable(2)]
		private TArray<float> _ModifiedTimes;

		// Token: 0x0401016E RID: 65902
		internal static int __PropertyOffset_BuffIds;

		// Token: 0x0401016F RID: 65903
		[Nullable(2)]
		private TArray<int> _BuffIds;
	}
}
