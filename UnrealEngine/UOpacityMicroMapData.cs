using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002621 RID: 9761
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/OpacityMicroMap.OpacityMicroMapData")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UOpacityMicroMapData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024497 RID: 148631 RVA: 0x0035B96E File Offset: 0x00359B6E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOpacityMicroMapData._ClassPtr;
		}

		// Token: 0x06024498 RID: 148632 RVA: 0x0035B97C File Offset: 0x00359B7C
		public UOpacityMicroMapData() : this(BuiltinUtils.AllocNativeUObject(UOpacityMicroMapData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024499 RID: 148633 RVA: 0x0035B9A4 File Offset: 0x00359BA4
		public UOpacityMicroMapData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOpacityMicroMapData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008BB5 RID: 35765
		// (get) Token: 0x0602449A RID: 148634 RVA: 0x0035B9D8 File Offset: 0x00359BD8
		// (set) Token: 0x0602449B RID: 148635 RVA: 0x0035BA11 File Offset: 0x00359C11
		public TArray<byte> ArrayData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._ArrayData) == null)
				{
					result = (this._ArrayData = new TArray<byte>(base.NativePtr + (IntPtr)UOpacityMicroMapData.__PropertyOffset_ArrayData, this));
				}
				return result;
			}
			set
			{
				this.ArrayData.CopyAssign(value);
			}
		}

		// Token: 0x17008BB6 RID: 35766
		// (get) Token: 0x0602449C RID: 148636 RVA: 0x0035BA20 File Offset: 0x00359C20
		// (set) Token: 0x0602449D RID: 148637 RVA: 0x0035BA59 File Offset: 0x00359C59
		public TArray<byte> DescArrayData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._DescArrayData) == null)
				{
					result = (this._DescArrayData = new TArray<byte>(base.NativePtr + (IntPtr)UOpacityMicroMapData.__PropertyOffset_DescArrayData, this));
				}
				return result;
			}
			set
			{
				this.DescArrayData.CopyAssign(value);
			}
		}

		// Token: 0x17008BB7 RID: 35767
		// (get) Token: 0x0602449E RID: 148638 RVA: 0x0035BA68 File Offset: 0x00359C68
		// (set) Token: 0x0602449F RID: 148639 RVA: 0x0035BAA1 File Offset: 0x00359CA1
		public TArray<FOpacityMicroMapUsageCount> DescArrayHistogram
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FOpacityMicroMapUsageCount> result;
				if ((result = this._DescArrayHistogram) == null)
				{
					result = (this._DescArrayHistogram = new TArray<FOpacityMicroMapUsageCount>(base.NativePtr + (IntPtr)UOpacityMicroMapData.__PropertyOffset_DescArrayHistogram, this));
				}
				return result;
			}
			set
			{
				this.DescArrayHistogram.CopyAssign(value);
			}
		}

		// Token: 0x17008BB8 RID: 35768
		// (get) Token: 0x060244A0 RID: 148640 RVA: 0x0035BAB0 File Offset: 0x00359CB0
		// (set) Token: 0x060244A1 RID: 148641 RVA: 0x0035BAE9 File Offset: 0x00359CE9
		public TArray<byte> IndexBuffer
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._IndexBuffer) == null)
				{
					result = (this._IndexBuffer = new TArray<byte>(base.NativePtr + (IntPtr)UOpacityMicroMapData.__PropertyOffset_IndexBuffer, this));
				}
				return result;
			}
			set
			{
				this.IndexBuffer.CopyAssign(value);
			}
		}

		// Token: 0x17008BB9 RID: 35769
		// (get) Token: 0x060244A2 RID: 148642 RVA: 0x0035BAF7 File Offset: 0x00359CF7
		// (set) Token: 0x060244A3 RID: 148643 RVA: 0x0035BB07 File Offset: 0x00359D07
		public unsafe bool Is16BitIndexBuffer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpacityMicroMapData.__PropertyOffset_Is16BitIndexBuffer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpacityMicroMapData.__PropertyOffset_Is16BitIndexBuffer) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008BBA RID: 35770
		// (get) Token: 0x060244A4 RID: 148644 RVA: 0x0035BB18 File Offset: 0x00359D18
		// (set) Token: 0x060244A5 RID: 148645 RVA: 0x0035BB51 File Offset: 0x00359D51
		public TArray<FOpacityMicroMapUsageCount> IndexHistogram
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FOpacityMicroMapUsageCount> result;
				if ((result = this._IndexHistogram) == null)
				{
					result = (this._IndexHistogram = new TArray<FOpacityMicroMapUsageCount>(base.NativePtr + (IntPtr)UOpacityMicroMapData.__PropertyOffset_IndexHistogram, this));
				}
				return result;
			}
			set
			{
				this.IndexHistogram.CopyAssign(value);
			}
		}

		// Token: 0x17008BBB RID: 35771
		// (get) Token: 0x060244A6 RID: 148646 RVA: 0x0035BB5F File Offset: 0x00359D5F
		// (set) Token: 0x060244A7 RID: 148647 RVA: 0x0035BB6F File Offset: 0x00359D6F
		public unsafe uint MaxSubdivisionLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpacityMicroMapData.__PropertyOffset_MaxSubdivisionLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpacityMicroMapData.__PropertyOffset_MaxSubdivisionLevel) = (int)value;
			}
		}

		// Token: 0x17008BBC RID: 35772
		// (get) Token: 0x060244A8 RID: 148648 RVA: 0x0035BB80 File Offset: 0x00359D80
		// (set) Token: 0x060244A9 RID: 148649 RVA: 0x0035BB90 File Offset: 0x00359D90
		public unsafe EOpacityMicromapFlags Flags
		{
			get
			{
				return (EOpacityMicromapFlags)(*(base.NativePtr + (IntPtr)UOpacityMicroMapData.__PropertyOffset_Flags));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpacityMicroMapData.__PropertyOffset_Flags) = (byte)value;
			}
		}

		// Token: 0x17008BBD RID: 35773
		// (get) Token: 0x060244AA RID: 148650 RVA: 0x0035BBA1 File Offset: 0x00359DA1
		// (set) Token: 0x060244AB RID: 148651 RVA: 0x0035BBB1 File Offset: 0x00359DB1
		public unsafe bool IsTwoState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpacityMicroMapData.__PropertyOffset_IsTwoState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpacityMicroMapData.__PropertyOffset_IsTwoState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008BBE RID: 35774
		// (get) Token: 0x060244AC RID: 148652 RVA: 0x0035BBC2 File Offset: 0x00359DC2
		// (set) Token: 0x060244AD RID: 148653 RVA: 0x0035BBD2 File Offset: 0x00359DD2
		public unsafe ulong VersionHash
		{
			get
			{
				return (ulong)(*(base.NativePtr + (IntPtr)UOpacityMicroMapData.__PropertyOffset_VersionHash));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpacityMicroMapData.__PropertyOffset_VersionHash) = (long)value;
			}
		}

		// Token: 0x060244AE RID: 148654 RVA: 0x0035BBE3 File Offset: 0x00359DE3
		static UOpacityMicroMapData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/OpacityMicroMap.OpacityMicroMapData");
		}

		// Token: 0x060244AF RID: 148655 RVA: 0x0035BBF1 File Offset: 0x00359DF1
		protected UOpacityMicroMapData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013772 RID: 79730
		public new const string __ObjectPath = "/Script/OpacityMicroMap.OpacityMicroMapData";

		// Token: 0x04013773 RID: 79731
		private static IntPtr _ClassPtr;

		// Token: 0x04013774 RID: 79732
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013775 RID: 79733
		internal static int __PropertyOffset_ArrayData;

		// Token: 0x04013776 RID: 79734
		[Nullable(2)]
		private TArray<byte> _ArrayData;

		// Token: 0x04013777 RID: 79735
		internal static int __PropertyOffset_DescArrayData;

		// Token: 0x04013778 RID: 79736
		[Nullable(2)]
		private TArray<byte> _DescArrayData;

		// Token: 0x04013779 RID: 79737
		internal static int __PropertyOffset_DescArrayHistogram;

		// Token: 0x0401377A RID: 79738
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FOpacityMicroMapUsageCount> _DescArrayHistogram;

		// Token: 0x0401377B RID: 79739
		internal static int __PropertyOffset_IndexBuffer;

		// Token: 0x0401377C RID: 79740
		[Nullable(2)]
		private TArray<byte> _IndexBuffer;

		// Token: 0x0401377D RID: 79741
		internal static int __PropertyOffset_Is16BitIndexBuffer;

		// Token: 0x0401377E RID: 79742
		internal static int __PropertyOffset_IndexHistogram;

		// Token: 0x0401377F RID: 79743
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FOpacityMicroMapUsageCount> _IndexHistogram;

		// Token: 0x04013780 RID: 79744
		internal static int __PropertyOffset_MaxSubdivisionLevel;

		// Token: 0x04013781 RID: 79745
		internal static int __PropertyOffset_Flags;

		// Token: 0x04013782 RID: 79746
		internal static int __PropertyOffset_IsTwoState;

		// Token: 0x04013783 RID: 79747
		internal static int __PropertyOffset_VersionHash;
	}
}
