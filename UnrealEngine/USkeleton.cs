using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000281 RID: 641
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Skeleton")]
	[UnrealStructLayout(1296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1296)]
	public class USkeleton : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600449C RID: 17564 RVA: 0x0006151A File Offset: 0x0005F71A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USkeleton._ClassPtr;
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x00061528 File Offset: 0x0005F728
		public USkeleton() : this(BuiltinUtils.AllocNativeUObject(USkeleton.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x00061550 File Offset: 0x0005F750
		public USkeleton(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USkeleton.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x0600449F RID: 17567 RVA: 0x00061584 File Offset: 0x0005F784
		// (set) Token: 0x060044A0 RID: 17568 RVA: 0x000615BD File Offset: 0x0005F7BD
		public TArray<FTransform> RefLocalPoses_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._RefLocalPoses_DEPRECATED) == null)
				{
					result = (this._RefLocalPoses_DEPRECATED = new TArray<FTransform>(base.NativePtr + (IntPtr)USkeleton.__PropertyOffset_RefLocalPoses_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				this.RefLocalPoses_DEPRECATED.CopyAssign(value);
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x060044A1 RID: 17569 RVA: 0x000615CB File Offset: 0x0005F7CB
		// (set) Token: 0x060044A2 RID: 17570 RVA: 0x000615DF File Offset: 0x0005F7DF
		public unsafe FGuid VirtualBoneGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeleton.__PropertyOffset_VirtualBoneGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeleton.__PropertyOffset_VirtualBoneGuid) = value;
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x060044A3 RID: 17571 RVA: 0x000615F4 File Offset: 0x0005F7F4
		// (set) Token: 0x060044A4 RID: 17572 RVA: 0x0006162D File Offset: 0x0005F82D
		public TArray<FAnimSlotGroup> SlotGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimSlotGroup> result;
				if ((result = this._SlotGroups) == null)
				{
					result = (this._SlotGroups = new TArray<FAnimSlotGroup>(base.NativePtr + (IntPtr)USkeleton.__PropertyOffset_SlotGroups, this));
				}
				return result;
			}
			set
			{
				this.SlotGroups.CopyAssign(value);
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x060044A5 RID: 17573 RVA: 0x0006163B File Offset: 0x0005F83B
		// (set) Token: 0x060044A6 RID: 17574 RVA: 0x0006164B File Offset: 0x0005F84B
		public unsafe bool bAllBoneInheritScaleXYZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeleton.__PropertyOffset_bAllBoneInheritScaleXYZ) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeleton.__PropertyOffset_bAllBoneInheritScaleXYZ) = (value ? 1 : 0);
			}
		}

		// Token: 0x060044A7 RID: 17575 RVA: 0x0006165C File Offset: 0x0005F85C
		static USkeleton()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Skeleton");
		}

		// Token: 0x060044A8 RID: 17576 RVA: 0x0006166A File Offset: 0x0005F86A
		protected USkeleton(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001AD4 RID: 6868
		public new const string __ObjectPath = "/Script/Engine.Skeleton";

		// Token: 0x04001AD5 RID: 6869
		private static IntPtr _ClassPtr;

		// Token: 0x04001AD6 RID: 6870
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001AD7 RID: 6871
		internal static int __PropertyOffset_RefLocalPoses_DEPRECATED;

		// Token: 0x04001AD8 RID: 6872
		[Nullable(2)]
		private TArray<FTransform> _RefLocalPoses_DEPRECATED;

		// Token: 0x04001AD9 RID: 6873
		internal static int __PropertyOffset_VirtualBoneGuid;

		// Token: 0x04001ADA RID: 6874
		internal static int __PropertyOffset_SlotGroups;

		// Token: 0x04001ADB RID: 6875
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimSlotGroup> _SlotGroups;

		// Token: 0x04001ADC RID: 6876
		internal static int __PropertyOffset_bAllBoneInheritScaleXYZ;
	}
}
