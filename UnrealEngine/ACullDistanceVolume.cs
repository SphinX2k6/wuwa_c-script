using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000977 RID: 2423
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CullDistanceVolume")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class ACullDistanceVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600891E RID: 35102 RVA: 0x000C4571 File Offset: 0x000C2771
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACullDistanceVolume._ClassPtr;
		}

		// Token: 0x0600891F RID: 35103 RVA: 0x000C4580 File Offset: 0x000C2780
		public ACullDistanceVolume() : this(BuiltinUtils.AllocNativeUObject(ACullDistanceVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008920 RID: 35104 RVA: 0x000C45A8 File Offset: 0x000C27A8
		public ACullDistanceVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACullDistanceVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002059 RID: 8281
		// (get) Token: 0x06008921 RID: 35105 RVA: 0x000C45DC File Offset: 0x000C27DC
		// (set) Token: 0x06008922 RID: 35106 RVA: 0x000C4615 File Offset: 0x000C2815
		public TArray<FCullDistanceSizePair> CullDistances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCullDistanceSizePair> result;
				if ((result = this._CullDistances) == null)
				{
					result = (this._CullDistances = new TArray<FCullDistanceSizePair>(base.NativePtr + (IntPtr)ACullDistanceVolume.__PropertyOffset_CullDistances, this));
				}
				return result;
			}
			set
			{
				this.CullDistances.CopyAssign(value);
			}
		}

		// Token: 0x1700205A RID: 8282
		// (get) Token: 0x06008923 RID: 35107 RVA: 0x000C4623 File Offset: 0x000C2823
		// (set) Token: 0x06008924 RID: 35108 RVA: 0x000C463C File Offset: 0x000C283C
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ACullDistanceVolume.__PropertyOffset_bEnabled) & ACullDistanceVolume.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ACullDistanceVolume.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)ACullDistanceVolume.__PropertyOffset_bEnabled) & ~ACullDistanceVolume.__PropertyMask_bEnabled) | (value ? ACullDistanceVolume.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x06008925 RID: 35109 RVA: 0x000C466C File Offset: 0x000C286C
		static ACullDistanceVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CullDistanceVolume");
		}

		// Token: 0x06008926 RID: 35110 RVA: 0x000C467A File Offset: 0x000C287A
		protected ACullDistanceVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400411F RID: 16671
		public new const string __ObjectPath = "/Script/Engine.CullDistanceVolume";

		// Token: 0x04004120 RID: 16672
		private static IntPtr _ClassPtr;

		// Token: 0x04004121 RID: 16673
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004122 RID: 16674
		internal static int __PropertyOffset_CullDistances;

		// Token: 0x04004123 RID: 16675
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCullDistanceSizePair> _CullDistances;

		// Token: 0x04004124 RID: 16676
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04004125 RID: 16677
		internal static byte __PropertyMask_bEnabled;
	}
}
