using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000614 RID: 1556
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.ProductData")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FProductData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008893 RID: 34963 RVA: 0x000CE092 File Offset: 0x000CC292
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FProductData._ScriptStructPtr != 0) ? FProductData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.ProductData", ref FProductData._ScriptStructPtr);
		}

		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x06008894 RID: 34964 RVA: 0x000CE0B6 File Offset: 0x000CC2B6
		// (set) Token: 0x06008895 RID: 34965 RVA: 0x000CE0CA File Offset: 0x000CC2CA
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

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x06008896 RID: 34966 RVA: 0x000CE0DF File Offset: 0x000CC2DF
		// (set) Token: 0x06008897 RID: 34967 RVA: 0x000CE0F3 File Offset: 0x000CC2F3
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

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x06008898 RID: 34968 RVA: 0x000CE108 File Offset: 0x000CC308
		// (set) Token: 0x06008899 RID: 34969 RVA: 0x000CE118 File Offset: 0x000CC318
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

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x0600889A RID: 34970 RVA: 0x000CE12C File Offset: 0x000CC32C
		// (set) Token: 0x0600889B RID: 34971 RVA: 0x000CE16F File Offset: 0x000CC36F
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

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x0600889C RID: 34972 RVA: 0x000CE18C File Offset: 0x000CC38C
		// (set) Token: 0x0600889D RID: 34973 RVA: 0x000CE1CF File Offset: 0x000CC3CF
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

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x0600889E RID: 34974 RVA: 0x000CE1EC File Offset: 0x000CC3EC
		// (set) Token: 0x0600889F RID: 34975 RVA: 0x000CE22F File Offset: 0x000CC42F
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

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x060088A0 RID: 34976 RVA: 0x000CE24C File Offset: 0x000CC44C
		// (set) Token: 0x060088A1 RID: 34977 RVA: 0x000CE28F File Offset: 0x000CC48F
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

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x060088A2 RID: 34978 RVA: 0x000CE2AC File Offset: 0x000CC4AC
		// (set) Token: 0x060088A3 RID: 34979 RVA: 0x000CE2EF File Offset: 0x000CC4EF
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

		// Token: 0x060088A4 RID: 34980 RVA: 0x000CE310 File Offset: 0x000CC510
		public FProductData()
		{
		}

		// Token: 0x060088A5 RID: 34981 RVA: 0x000CE318 File Offset: 0x000CC518
		protected override IntPtr GetUStructPtr()
		{
			return FProductData.StaticStruct();
		}

		// Token: 0x060088A6 RID: 34982 RVA: 0x000CE324 File Offset: 0x000CC524
		[NullableContext(2)]
		public FProductData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060088A7 RID: 34983 RVA: 0x000CE32E File Offset: 0x000CC52E
		public FProductData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060088A8 RID: 34984 RVA: 0x000CE339 File Offset: 0x000CC539
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FProductData(Pointer, false, true);
		}

		// Token: 0x060088A9 RID: 34985 RVA: 0x000CE343 File Offset: 0x000CC543
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FProductData(Pointer, MemoryOwner);
		}

		// Token: 0x04003B48 RID: 15176
		public const string __ObjectPath = "/Script/KuroUtility.ProductData";

		// Token: 0x04003B49 RID: 15177
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003B4A RID: 15178
		internal static int __PropertyOffset_id;

		// Token: 0x04003B4B RID: 15179
		internal static int __PropertyOffset_type;

		// Token: 0x04003B4C RID: 15180
		internal static int __PropertyOffset_price;

		// Token: 0x04003B4D RID: 15181
		internal static int __PropertyOffset_displayPrice;

		// Token: 0x04003B4E RID: 15182
		[Nullable(2)]
		private FText _displayPrice;

		// Token: 0x04003B4F RID: 15183
		internal static int __PropertyOffset_description;

		// Token: 0x04003B50 RID: 15184
		[Nullable(2)]
		private FText _description;

		// Token: 0x04003B51 RID: 15185
		internal static int __PropertyOffset_displayName;

		// Token: 0x04003B52 RID: 15186
		[Nullable(2)]
		private FText _displayName;

		// Token: 0x04003B53 RID: 15187
		internal static int __PropertyOffset_label;

		// Token: 0x04003B54 RID: 15188
		[Nullable(2)]
		private FText _label;

		// Token: 0x04003B55 RID: 15189
		internal static int __PropertyOffset_endData;

		// Token: 0x04003B56 RID: 15190
		[Nullable(2)]
		private FDateTime _endData;
	}
}
