using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001F3 RID: 499
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkAudioType")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public abstract class UAkAudioType : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001D5F RID: 7519 RVA: 0x0002BB89 File Offset: 0x00029D89
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkAudioType._ClassPtr;
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x0002BB95 File Offset: 0x00029D95
		// (set) Token: 0x06001D61 RID: 7521 RVA: 0x0002BBA5 File Offset: 0x00029DA5
		public unsafe bool bAutoLoad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkAudioType.__PropertyOffset_bAutoLoad) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkAudioType.__PropertyOffset_bAutoLoad) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x0002BBB8 File Offset: 0x00029DB8
		// (set) Token: 0x06001D63 RID: 7523 RVA: 0x0002BBF1 File Offset: 0x00029DF1
		public TArray<UObject> UserData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._UserData) == null)
				{
					result = (this._UserData = new TArray<UObject>(base.NativePtr + (IntPtr)UAkAudioType.__PropertyOffset_UserData, this));
				}
				return result;
			}
			set
			{
				this.UserData.CopyAssign(value);
			}
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x0002BBFF File Offset: 0x00029DFF
		public void UnloadData(bool bAsync = false)
		{
			UAkAudioType.__UnloadData_Internal(base.NativePtr, bAsync);
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x0002BC0D File Offset: 0x00029E0D
		public void LoadData()
		{
			UAkAudioType.__LoadData_Internal(base.NativePtr);
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x0002BC1A File Offset: 0x00029E1A
		public int GetWwiseShortID()
		{
			return UAkAudioType.__GetWwiseShortID_Internal(base.NativePtr);
		}

		// Token: 0x06001D67 RID: 7527
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnloadData_Internal(IntPtr @this, bool bAsync);

		// Token: 0x06001D68 RID: 7528
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LoadData_Internal(IntPtr @this);

		// Token: 0x06001D69 RID: 7529
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetWwiseShortID_Internal(IntPtr @this);

		// Token: 0x06001D6A RID: 7530 RVA: 0x0002BC27 File Offset: 0x00029E27
		static UAkAudioType()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkAudioType");
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x0002BC38 File Offset: 0x00029E38
		protected UAkAudioType() : this(BuiltinUtils.AllocNativeUObject(UAkAudioType.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x0002BC60 File Offset: 0x00029E60
		protected UAkAudioType(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040009AC RID: 2476
		public new const string __ObjectPath = "/Script/AkAudio.AkAudioType";

		// Token: 0x040009AD RID: 2477
		private static IntPtr _ClassPtr;

		// Token: 0x040009AE RID: 2478
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040009AF RID: 2479
		internal static int __PropertyOffset_bAutoLoad;

		// Token: 0x040009B0 RID: 2480
		internal static int __PropertyOffset_UserData;

		// Token: 0x040009B1 RID: 2481
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _UserData;
	}
}
