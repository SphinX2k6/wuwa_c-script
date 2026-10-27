using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F07 RID: 7943
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.ProductData")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FProductData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E254 RID: 123476 RVA: 0x002CD116 File Offset: 0x002CB316
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FProductData._ScriptStructPtr != 0) ? FProductData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.ProductData", ref FProductData._ScriptStructPtr);
		}

		// Token: 0x170077C6 RID: 30662
		// (get) Token: 0x0601E255 RID: 123477 RVA: 0x002CD13A File Offset: 0x002CB33A
		// (set) Token: 0x0601E256 RID: 123478 RVA: 0x002CD14E File Offset: 0x002CB34E
		public unsafe string id
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FProductData.__PropertyOffset_id)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FProductData.__PropertyOffset_id)), value);
			}
		}

		// Token: 0x170077C7 RID: 30663
		// (get) Token: 0x0601E257 RID: 123479 RVA: 0x002CD163 File Offset: 0x002CB363
		// (set) Token: 0x0601E258 RID: 123480 RVA: 0x002CD177 File Offset: 0x002CB377
		public unsafe string type
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FProductData.__PropertyOffset_type)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FProductData.__PropertyOffset_type)), value);
			}
		}

		// Token: 0x170077C8 RID: 30664
		// (get) Token: 0x0601E259 RID: 123481 RVA: 0x002CD18C File Offset: 0x002CB38C
		// (set) Token: 0x0601E25A RID: 123482 RVA: 0x002CD19C File Offset: 0x002CB39C
		public unsafe int price
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProductData.__PropertyOffset_price);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProductData.__PropertyOffset_price) = value;
			}
		}

		// Token: 0x170077C9 RID: 30665
		// (get) Token: 0x0601E25B RID: 123483 RVA: 0x002CD1B0 File Offset: 0x002CB3B0
		// (set) Token: 0x0601E25C RID: 123484 RVA: 0x002CD1F3 File Offset: 0x002CB3F3
		public unsafe FText displayPrice
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._displayPrice) == null)
				{
					result = (this._displayPrice = new FText(base.NativePtr + (IntPtr)FProductData.__PropertyOffset_displayPrice, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FProductData.__PropertyOffset_displayPrice)), value.NativePtr, 1);
			}
		}

		// Token: 0x170077CA RID: 30666
		// (get) Token: 0x0601E25D RID: 123485 RVA: 0x002CD210 File Offset: 0x002CB410
		// (set) Token: 0x0601E25E RID: 123486 RVA: 0x002CD253 File Offset: 0x002CB453
		public unsafe FText description
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._description) == null)
				{
					result = (this._description = new FText(base.NativePtr + (IntPtr)FProductData.__PropertyOffset_description, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FProductData.__PropertyOffset_description)), value.NativePtr, 1);
			}
		}

		// Token: 0x170077CB RID: 30667
		// (get) Token: 0x0601E25F RID: 123487 RVA: 0x002CD270 File Offset: 0x002CB470
		// (set) Token: 0x0601E260 RID: 123488 RVA: 0x002CD2B3 File Offset: 0x002CB4B3
		public unsafe FText displayName
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._displayName) == null)
				{
					result = (this._displayName = new FText(base.NativePtr + (IntPtr)FProductData.__PropertyOffset_displayName, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FProductData.__PropertyOffset_displayName)), value.NativePtr, 1);
			}
		}

		// Token: 0x170077CC RID: 30668
		// (get) Token: 0x0601E261 RID: 123489 RVA: 0x002CD2D0 File Offset: 0x002CB4D0
		// (set) Token: 0x0601E262 RID: 123490 RVA: 0x002CD313 File Offset: 0x002CB513
		public unsafe FText label
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._label) == null)
				{
					result = (this._label = new FText(base.NativePtr + (IntPtr)FProductData.__PropertyOffset_label, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FProductData.__PropertyOffset_label)), value.NativePtr, 1);
			}
		}

		// Token: 0x170077CD RID: 30669
		// (get) Token: 0x0601E263 RID: 123491 RVA: 0x002CD330 File Offset: 0x002CB530
		// (set) Token: 0x0601E264 RID: 123492 RVA: 0x002CD373 File Offset: 0x002CB573
		public FDateTime endData
		{
			get
			{
				base.FastCheckIsValid();
				FDateTime result;
				if ((result = this._endData) == null)
				{
					result = (this._endData = new FDateTime(base.NativePtr + (IntPtr)FProductData.__PropertyOffset_endData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDateTime.StaticStruct(), base.NativePtr + (IntPtr)FProductData.__PropertyOffset_endData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601E265 RID: 123493 RVA: 0x002CD394 File Offset: 0x002CB594
		public FProductData()
		{
		}

		// Token: 0x0601E266 RID: 123494 RVA: 0x002CD39C File Offset: 0x002CB59C
		public FProductData(string id, string type, int price, FText displayPrice, FText description, FText displayName, FText label, FDateTime endData)
		{
			this.id = id;
			this.type = type;
			this.price = price;
			this.displayPrice = displayPrice;
			this.description = description;
			this.displayName = displayName;
			this.label = label;
			this.endData = endData;
		}

		// Token: 0x0601E267 RID: 123495 RVA: 0x002CD3EC File Offset: 0x002CB5EC
		protected override IntPtr GetUStructPtr()
		{
			return FProductData.StaticStruct();
		}

		// Token: 0x0601E268 RID: 123496 RVA: 0x002CD3F8 File Offset: 0x002CB5F8
		[NullableContext(2)]
		public FProductData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E269 RID: 123497 RVA: 0x002CD402 File Offset: 0x002CB602
		public FProductData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E26A RID: 123498 RVA: 0x002CD40D File Offset: 0x002CB60D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FProductData(Pointer, false, true);
		}

		// Token: 0x0601E26B RID: 123499 RVA: 0x002CD417 File Offset: 0x002CB617
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FProductData(Pointer, MemoryOwner);
		}

		// Token: 0x04010476 RID: 66678
		public const string __ObjectPath = "/Script/KuroUtility.ProductData";

		// Token: 0x04010477 RID: 66679
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010478 RID: 66680
		internal static int __PropertyOffset_id;

		// Token: 0x04010479 RID: 66681
		internal static int __PropertyOffset_type;

		// Token: 0x0401047A RID: 66682
		internal static int __PropertyOffset_price;

		// Token: 0x0401047B RID: 66683
		internal static int __PropertyOffset_displayPrice;

		// Token: 0x0401047C RID: 66684
		[Nullable(2)]
		private FText _displayPrice;

		// Token: 0x0401047D RID: 66685
		internal static int __PropertyOffset_description;

		// Token: 0x0401047E RID: 66686
		[Nullable(2)]
		private FText _description;

		// Token: 0x0401047F RID: 66687
		internal static int __PropertyOffset_displayName;

		// Token: 0x04010480 RID: 66688
		[Nullable(2)]
		private FText _displayName;

		// Token: 0x04010481 RID: 66689
		internal static int __PropertyOffset_label;

		// Token: 0x04010482 RID: 66690
		[Nullable(2)]
		private FText _label;

		// Token: 0x04010483 RID: 66691
		internal static int __PropertyOffset_endData;

		// Token: 0x04010484 RID: 66692
		[Nullable(2)]
		private FDateTime _endData;
	}
}
