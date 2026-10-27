using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200229F RID: 8863
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MediaAssets.MediaTimeStampInfo")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UMediaTimeStampInfo : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021B6E RID: 138094 RVA: 0x0031D7FB File Offset: 0x0031B9FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMediaTimeStampInfo._ClassPtr;
		}

		// Token: 0x06021B6F RID: 138095 RVA: 0x0031D808 File Offset: 0x0031BA08
		public UMediaTimeStampInfo() : this(BuiltinUtils.AllocNativeUObject(UMediaTimeStampInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021B70 RID: 138096 RVA: 0x0031D830 File Offset: 0x0031BA30
		public UMediaTimeStampInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMediaTimeStampInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170082D0 RID: 33488
		// (get) Token: 0x06021B71 RID: 138097 RVA: 0x0031D864 File Offset: 0x0031BA64
		// (set) Token: 0x06021B72 RID: 138098 RVA: 0x0031D89D File Offset: 0x0031BA9D
		public FTimespan Time
		{
			get
			{
				base.FastCheckIsValid();
				FTimespan result;
				if ((result = this._Time) == null)
				{
					result = (this._Time = new FTimespan(base.NativePtr + (IntPtr)UMediaTimeStampInfo.__PropertyOffset_Time, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimespan.StaticStruct(), base.NativePtr + (IntPtr)UMediaTimeStampInfo.__PropertyOffset_Time, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170082D1 RID: 33489
		// (get) Token: 0x06021B73 RID: 138099 RVA: 0x0031D8BE File Offset: 0x0031BABE
		// (set) Token: 0x06021B74 RID: 138100 RVA: 0x0031D8CE File Offset: 0x0031BACE
		public unsafe long SequenceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaTimeStampInfo.__PropertyOffset_SequenceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaTimeStampInfo.__PropertyOffset_SequenceIndex) = value;
			}
		}

		// Token: 0x06021B75 RID: 138101 RVA: 0x0031D8DF File Offset: 0x0031BADF
		static UMediaTimeStampInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MediaAssets.MediaTimeStampInfo");
		}

		// Token: 0x06021B76 RID: 138102 RVA: 0x0031D8ED File Offset: 0x0031BAED
		protected UMediaTimeStampInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011FC8 RID: 73672
		public new const string __ObjectPath = "/Script/MediaAssets.MediaTimeStampInfo";

		// Token: 0x04011FC9 RID: 73673
		private static IntPtr _ClassPtr;

		// Token: 0x04011FCA RID: 73674
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011FCB RID: 73675
		internal static int __PropertyOffset_Time;

		// Token: 0x04011FCC RID: 73676
		[Nullable(2)]
		private FTimespan _Time;

		// Token: 0x04011FCD RID: 73677
		internal static int __PropertyOffset_SequenceIndex;
	}
}
