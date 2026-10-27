using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200088D RID: 2189
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneSplitComponent")]
	[UnrealStructLayout(1920, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1920)]
	public class UBakedBoneSplitComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060077B2 RID: 30642 RVA: 0x000AB6B2 File Offset: 0x000A98B2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBakedBoneSplitComponent._ClassPtr;
		}

		// Token: 0x060077B3 RID: 30643 RVA: 0x000AB6C0 File Offset: 0x000A98C0
		public UBakedBoneSplitComponent() : this(BuiltinUtils.AllocNativeUObject(UBakedBoneSplitComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060077B4 RID: 30644 RVA: 0x000AB6E8 File Offset: 0x000A98E8
		public UBakedBoneSplitComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBakedBoneSplitComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C40 RID: 7232
		// (get) Token: 0x060077B5 RID: 30645 RVA: 0x000AB71B File Offset: 0x000A991B
		// (set) Token: 0x060077B6 RID: 30646 RVA: 0x000AB72F File Offset: 0x000A992F
		public unsafe FGuid SlotGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneSplitComponent.__PropertyOffset_SlotGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneSplitComponent.__PropertyOffset_SlotGuid) = value;
			}
		}

		// Token: 0x17001C41 RID: 7233
		// (get) Token: 0x060077B7 RID: 30647 RVA: 0x000AB744 File Offset: 0x000A9944
		// (set) Token: 0x060077B8 RID: 30648 RVA: 0x000AB758 File Offset: 0x000A9958
		public unsafe FBoxSphereBounds CustomBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneSplitComponent.__PropertyOffset_CustomBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneSplitComponent.__PropertyOffset_CustomBounds) = value;
			}
		}

		// Token: 0x17001C42 RID: 7234
		// (get) Token: 0x060077B9 RID: 30649 RVA: 0x000AB770 File Offset: 0x000A9970
		// (set) Token: 0x060077BA RID: 30650 RVA: 0x000AB7A9 File Offset: 0x000A99A9
		public TArray<FBakedBoneSplitAnimInfo> AnimInfoArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedBoneSplitAnimInfo> result;
				if ((result = this._AnimInfoArray) == null)
				{
					result = (this._AnimInfoArray = new TArray<FBakedBoneSplitAnimInfo>(base.NativePtr + (IntPtr)UBakedBoneSplitComponent.__PropertyOffset_AnimInfoArray, this));
				}
				return result;
			}
			set
			{
				this.AnimInfoArray.CopyAssign(value);
			}
		}

		// Token: 0x17001C43 RID: 7235
		// (get) Token: 0x060077BB RID: 30651 RVA: 0x000AB7B8 File Offset: 0x000A99B8
		// (set) Token: 0x060077BC RID: 30652 RVA: 0x000AB7F1 File Offset: 0x000A99F1
		public TArray<FBakedBoneSplitLogicGroup> LogicGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedBoneSplitLogicGroup> result;
				if ((result = this._LogicGroups) == null)
				{
					result = (this._LogicGroups = new TArray<FBakedBoneSplitLogicGroup>(base.NativePtr + (IntPtr)UBakedBoneSplitComponent.__PropertyOffset_LogicGroups, this));
				}
				return result;
			}
			set
			{
				this.LogicGroups.CopyAssign(value);
			}
		}

		// Token: 0x060077BD RID: 30653 RVA: 0x000AB7FF File Offset: 0x000A99FF
		static UBakedBoneSplitComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BakedBoneSplitComponent");
		}

		// Token: 0x060077BE RID: 30654 RVA: 0x000AB80D File Offset: 0x000A9A0D
		protected UBakedBoneSplitComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003979 RID: 14713
		public new const string __ObjectPath = "/Script/Engine.BakedBoneSplitComponent";

		// Token: 0x0400397A RID: 14714
		private static IntPtr _ClassPtr;

		// Token: 0x0400397B RID: 14715
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400397C RID: 14716
		internal static int __PropertyOffset_SlotGuid;

		// Token: 0x0400397D RID: 14717
		internal static int __PropertyOffset_CustomBounds;

		// Token: 0x0400397E RID: 14718
		internal static int __PropertyOffset_AnimInfoArray;

		// Token: 0x0400397F RID: 14719
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedBoneSplitAnimInfo> _AnimInfoArray;

		// Token: 0x04003980 RID: 14720
		internal static int __PropertyOffset_LogicGroups;

		// Token: 0x04003981 RID: 14721
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedBoneSplitLogicGroup> _LogicGroups;
	}
}
