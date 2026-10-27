using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200270E RID: 9998
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.SeqAnimDataSetting")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class USeqAnimDataSetting : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025126 RID: 151846 RVA: 0x0036E457 File Offset: 0x0036C657
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USeqAnimDataSetting._ClassPtr;
		}

		// Token: 0x06025127 RID: 151847 RVA: 0x0036E464 File Offset: 0x0036C664
		public USeqAnimDataSetting() : this(BuiltinUtils.AllocNativeUObject(USeqAnimDataSetting.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025128 RID: 151848 RVA: 0x0036E48C File Offset: 0x0036C68C
		public USeqAnimDataSetting(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USeqAnimDataSetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008F07 RID: 36615
		// (get) Token: 0x06025129 RID: 151849 RVA: 0x0036E4C0 File Offset: 0x0036C6C0
		// (set) Token: 0x0602512A RID: 151850 RVA: 0x0036E4F9 File Offset: 0x0036C6F9
		public TArray<FSeqAnimCurveFloatDesc> SeqAnimCurveFloats
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSeqAnimCurveFloatDesc> result;
				if ((result = this._SeqAnimCurveFloats) == null)
				{
					result = (this._SeqAnimCurveFloats = new TArray<FSeqAnimCurveFloatDesc>(base.NativePtr + (IntPtr)USeqAnimDataSetting.__PropertyOffset_SeqAnimCurveFloats, this));
				}
				return result;
			}
			set
			{
				this.SeqAnimCurveFloats.CopyAssign(value);
			}
		}

		// Token: 0x17008F08 RID: 36616
		// (get) Token: 0x0602512B RID: 151851 RVA: 0x0036E508 File Offset: 0x0036C708
		// (set) Token: 0x0602512C RID: 151852 RVA: 0x0036E541 File Offset: 0x0036C741
		public TArray<FSeqAnimCurveVectorDesc> SeqAnimCurveVectors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSeqAnimCurveVectorDesc> result;
				if ((result = this._SeqAnimCurveVectors) == null)
				{
					result = (this._SeqAnimCurveVectors = new TArray<FSeqAnimCurveVectorDesc>(base.NativePtr + (IntPtr)USeqAnimDataSetting.__PropertyOffset_SeqAnimCurveVectors, this));
				}
				return result;
			}
			set
			{
				this.SeqAnimCurveVectors.CopyAssign(value);
			}
		}

		// Token: 0x17008F09 RID: 36617
		// (get) Token: 0x0602512D RID: 151853 RVA: 0x0036E550 File Offset: 0x0036C750
		// (set) Token: 0x0602512E RID: 151854 RVA: 0x0036E589 File Offset: 0x0036C789
		public TArray<FSeqAnimCurveFloatDesc> FrequentSeqAnimCurveFloats
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSeqAnimCurveFloatDesc> result;
				if ((result = this._FrequentSeqAnimCurveFloats) == null)
				{
					result = (this._FrequentSeqAnimCurveFloats = new TArray<FSeqAnimCurveFloatDesc>(base.NativePtr + (IntPtr)USeqAnimDataSetting.__PropertyOffset_FrequentSeqAnimCurveFloats, this));
				}
				return result;
			}
			set
			{
				this.FrequentSeqAnimCurveFloats.CopyAssign(value);
			}
		}

		// Token: 0x17008F0A RID: 36618
		// (get) Token: 0x0602512F RID: 151855 RVA: 0x0036E598 File Offset: 0x0036C798
		// (set) Token: 0x06025130 RID: 151856 RVA: 0x0036E5D1 File Offset: 0x0036C7D1
		public TArray<FSeqAnimCurveVectorDesc> FrequentSeqAnimCurveVectors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSeqAnimCurveVectorDesc> result;
				if ((result = this._FrequentSeqAnimCurveVectors) == null)
				{
					result = (this._FrequentSeqAnimCurveVectors = new TArray<FSeqAnimCurveVectorDesc>(base.NativePtr + (IntPtr)USeqAnimDataSetting.__PropertyOffset_FrequentSeqAnimCurveVectors, this));
				}
				return result;
			}
			set
			{
				this.FrequentSeqAnimCurveVectors.CopyAssign(value);
			}
		}

		// Token: 0x06025131 RID: 151857 RVA: 0x0036E5DF File Offset: 0x0036C7DF
		static USeqAnimDataSetting()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.SeqAnimDataSetting");
		}

		// Token: 0x06025132 RID: 151858 RVA: 0x0036E5ED File Offset: 0x0036C7ED
		protected USeqAnimDataSetting(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013F7C RID: 81788
		public new const string __ObjectPath = "/Script/SequenceDialogue.SeqAnimDataSetting";

		// Token: 0x04013F7D RID: 81789
		private static IntPtr _ClassPtr;

		// Token: 0x04013F7E RID: 81790
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013F7F RID: 81791
		internal static int __PropertyOffset_SeqAnimCurveFloats;

		// Token: 0x04013F80 RID: 81792
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSeqAnimCurveFloatDesc> _SeqAnimCurveFloats;

		// Token: 0x04013F81 RID: 81793
		internal static int __PropertyOffset_SeqAnimCurveVectors;

		// Token: 0x04013F82 RID: 81794
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSeqAnimCurveVectorDesc> _SeqAnimCurveVectors;

		// Token: 0x04013F83 RID: 81795
		internal static int __PropertyOffset_FrequentSeqAnimCurveFloats;

		// Token: 0x04013F84 RID: 81796
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSeqAnimCurveFloatDesc> _FrequentSeqAnimCurveFloats;

		// Token: 0x04013F85 RID: 81797
		internal static int __PropertyOffset_FrequentSeqAnimCurveVectors;

		// Token: 0x04013F86 RID: 81798
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSeqAnimCurveVectorDesc> _FrequentSeqAnimCurveVectors;
	}
}
