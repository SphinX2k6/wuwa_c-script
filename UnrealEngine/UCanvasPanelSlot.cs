using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002942 RID: 10562
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.CanvasPanelSlot")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UCanvasPanelSlot : UPanelSlot, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602714C RID: 160076 RVA: 0x003B99FC File Offset: 0x003B7BFC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCanvasPanelSlot._ClassPtr;
		}

		// Token: 0x0602714D RID: 160077 RVA: 0x003B9A08 File Offset: 0x003B7C08
		public UCanvasPanelSlot() : this(BuiltinUtils.AllocNativeUObject(UCanvasPanelSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602714E RID: 160078 RVA: 0x003B9A30 File Offset: 0x003B7C30
		public UCanvasPanelSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCanvasPanelSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700965D RID: 38493
		// (get) Token: 0x0602714F RID: 160079 RVA: 0x003B9A64 File Offset: 0x003B7C64
		// (set) Token: 0x06027150 RID: 160080 RVA: 0x003B9A9D File Offset: 0x003B7C9D
		public FAnchorData LayoutData
		{
			get
			{
				base.FastCheckIsValid();
				FAnchorData result;
				if ((result = this._LayoutData) == null)
				{
					result = (this._LayoutData = new FAnchorData(base.NativePtr + (IntPtr)UCanvasPanelSlot.__PropertyOffset_LayoutData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAnchorData.StaticStruct(), base.NativePtr + (IntPtr)UCanvasPanelSlot.__PropertyOffset_LayoutData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700965E RID: 38494
		// (get) Token: 0x06027151 RID: 160081 RVA: 0x003B9ABE File Offset: 0x003B7CBE
		// (set) Token: 0x06027152 RID: 160082 RVA: 0x003B9ACE File Offset: 0x003B7CCE
		public unsafe bool bAutoSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCanvasPanelSlot.__PropertyOffset_bAutoSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCanvasPanelSlot.__PropertyOffset_bAutoSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700965F RID: 38495
		// (get) Token: 0x06027153 RID: 160083 RVA: 0x003B9ADF File Offset: 0x003B7CDF
		// (set) Token: 0x06027154 RID: 160084 RVA: 0x003B9AEF File Offset: 0x003B7CEF
		public unsafe int ZOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCanvasPanelSlot.__PropertyOffset_ZOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCanvasPanelSlot.__PropertyOffset_ZOrder) = value;
			}
		}

		// Token: 0x06027155 RID: 160085 RVA: 0x003B9B00 File Offset: 0x003B7D00
		public void SetZOrder(int InZOrder)
		{
			UCanvasPanelSlot.__SetZOrder_Internal(base.NativePtr, InZOrder);
		}

		// Token: 0x06027156 RID: 160086 RVA: 0x003B9B0E File Offset: 0x003B7D0E
		public void SetSize(FVector2D InSize)
		{
			UCanvasPanelSlot.__SetSize_Internal(base.NativePtr, InSize);
		}

		// Token: 0x06027157 RID: 160087 RVA: 0x003B9B1C File Offset: 0x003B7D1C
		public void SetPosition(FVector2D InPosition)
		{
			UCanvasPanelSlot.__SetPosition_Internal(base.NativePtr, InPosition);
		}

		// Token: 0x06027158 RID: 160088 RVA: 0x003B9B2A File Offset: 0x003B7D2A
		public void SetOffsets(FMargin InOffset)
		{
			UCanvasPanelSlot.__SetOffsets_Internal(base.NativePtr, InOffset);
		}

		// Token: 0x06027159 RID: 160089 RVA: 0x003B9B38 File Offset: 0x003B7D38
		public void SetMinimum(FVector2D InMinimumAnchors)
		{
			UCanvasPanelSlot.__SetMinimum_Internal(base.NativePtr, InMinimumAnchors);
		}

		// Token: 0x0602715A RID: 160090 RVA: 0x003B9B46 File Offset: 0x003B7D46
		public void SetMaximum(FVector2D InMaximumAnchors)
		{
			UCanvasPanelSlot.__SetMaximum_Internal(base.NativePtr, InMaximumAnchors);
		}

		// Token: 0x0602715B RID: 160091 RVA: 0x003B9B54 File Offset: 0x003B7D54
		[NullableContext(2)]
		public void SetLayout(in FAnchorData InLayoutData)
		{
			UCanvasPanelSlot.__SetLayout_Internal(base.NativePtr, (InLayoutData ?? new FAnchorData()).NativePtr);
		}

		// Token: 0x0602715C RID: 160092 RVA: 0x003B9B71 File Offset: 0x003B7D71
		public void SetAutoSize(bool InbAutoSize)
		{
			UCanvasPanelSlot.__SetAutoSize_Internal(base.NativePtr, InbAutoSize);
		}

		// Token: 0x0602715D RID: 160093 RVA: 0x003B9B7F File Offset: 0x003B7D7F
		[NullableContext(2)]
		public void SetAnchors(FAnchors InAnchors)
		{
			UCanvasPanelSlot.__SetAnchors_Internal(base.NativePtr, (InAnchors ?? new FAnchors()).NativePtr);
		}

		// Token: 0x0602715E RID: 160094 RVA: 0x003B9B9B File Offset: 0x003B7D9B
		public void SetAlignment(FVector2D InAlignment)
		{
			UCanvasPanelSlot.__SetAlignment_Internal(base.NativePtr, InAlignment);
		}

		// Token: 0x0602715F RID: 160095 RVA: 0x003B9BA9 File Offset: 0x003B7DA9
		public int GetZOrder()
		{
			return UCanvasPanelSlot.__GetZOrder_Internal(base.NativePtr);
		}

		// Token: 0x06027160 RID: 160096 RVA: 0x003B9BB6 File Offset: 0x003B7DB6
		public FVector2D GetSize()
		{
			return UCanvasPanelSlot.__GetSize_Internal(base.NativePtr);
		}

		// Token: 0x06027161 RID: 160097 RVA: 0x003B9BC3 File Offset: 0x003B7DC3
		public FVector2D GetPosition()
		{
			return UCanvasPanelSlot.__GetPosition_Internal(base.NativePtr);
		}

		// Token: 0x06027162 RID: 160098 RVA: 0x003B9BD0 File Offset: 0x003B7DD0
		public FMargin GetOffsets()
		{
			return UCanvasPanelSlot.__GetOffsets_Internal(base.NativePtr);
		}

		// Token: 0x06027163 RID: 160099 RVA: 0x003B9BDD File Offset: 0x003B7DDD
		public FAnchorData GetLayout()
		{
			return new FAnchorData(UCanvasPanelSlot.__GetLayout_Internal(base.NativePtr), null);
		}

		// Token: 0x06027164 RID: 160100 RVA: 0x003B9BF0 File Offset: 0x003B7DF0
		public bool GetAutoSize()
		{
			return UCanvasPanelSlot.__GetAutoSize_Internal(base.NativePtr);
		}

		// Token: 0x06027165 RID: 160101 RVA: 0x003B9BFD File Offset: 0x003B7DFD
		public FAnchors GetAnchors()
		{
			return new FAnchors(UCanvasPanelSlot.__GetAnchors_Internal(base.NativePtr), null);
		}

		// Token: 0x06027166 RID: 160102 RVA: 0x003B9C10 File Offset: 0x003B7E10
		public FVector2D GetAlignment()
		{
			return UCanvasPanelSlot.__GetAlignment_Internal(base.NativePtr);
		}

		// Token: 0x06027167 RID: 160103
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetZOrder_Internal(IntPtr @this, int InZOrder);

		// Token: 0x06027168 RID: 160104
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSize_Internal(IntPtr @this, FVector2D InSize);

		// Token: 0x06027169 RID: 160105
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPosition_Internal(IntPtr @this, FVector2D InPosition);

		// Token: 0x0602716A RID: 160106
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOffsets_Internal(IntPtr @this, FMargin InOffset);

		// Token: 0x0602716B RID: 160107
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinimum_Internal(IntPtr @this, FVector2D InMinimumAnchors);

		// Token: 0x0602716C RID: 160108
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaximum_Internal(IntPtr @this, FVector2D InMaximumAnchors);

		// Token: 0x0602716D RID: 160109
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLayout_Internal(IntPtr @this, IntPtr InLayoutData);

		// Token: 0x0602716E RID: 160110
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAutoSize_Internal(IntPtr @this, bool InbAutoSize);

		// Token: 0x0602716F RID: 160111
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnchors_Internal(IntPtr @this, IntPtr InAnchors);

		// Token: 0x06027170 RID: 160112
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAlignment_Internal(IntPtr @this, FVector2D InAlignment);

		// Token: 0x06027171 RID: 160113
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetZOrder_Internal(IntPtr @this);

		// Token: 0x06027172 RID: 160114
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetSize_Internal(IntPtr @this);

		// Token: 0x06027173 RID: 160115
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetPosition_Internal(IntPtr @this);

		// Token: 0x06027174 RID: 160116
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMargin __GetOffsets_Internal(IntPtr @this);

		// Token: 0x06027175 RID: 160117
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLayout_Internal(IntPtr @this);

		// Token: 0x06027176 RID: 160118
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAutoSize_Internal(IntPtr @this);

		// Token: 0x06027177 RID: 160119
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAnchors_Internal(IntPtr @this);

		// Token: 0x06027178 RID: 160120
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetAlignment_Internal(IntPtr @this);

		// Token: 0x06027179 RID: 160121 RVA: 0x003B9C1D File Offset: 0x003B7E1D
		static UCanvasPanelSlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.CanvasPanelSlot");
		}

		// Token: 0x0602717A RID: 160122 RVA: 0x003B9C2B File Offset: 0x003B7E2B
		protected UCanvasPanelSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015787 RID: 87943
		public new const string __ObjectPath = "/Script/UMG.CanvasPanelSlot";

		// Token: 0x04015788 RID: 87944
		private static IntPtr _ClassPtr;

		// Token: 0x04015789 RID: 87945
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401578A RID: 87946
		internal static int __PropertyOffset_LayoutData;

		// Token: 0x0401578B RID: 87947
		[Nullable(2)]
		private FAnchorData _LayoutData;

		// Token: 0x0401578C RID: 87948
		internal static int __PropertyOffset_bAutoSize;

		// Token: 0x0401578D RID: 87949
		internal static int __PropertyOffset_ZOrder;
	}
}
