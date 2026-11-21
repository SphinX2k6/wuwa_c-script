using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000BC RID: 188
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkAudioType")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public abstract class UAkAudioType : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000E01 RID: 3585 RVA: 0x00015F84 File Offset: 0x00014184
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkAudioType._ClassPtr;
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x00015F90 File Offset: 0x00014190
		// (set) Token: 0x06000E03 RID: 3587 RVA: 0x00015FA0 File Offset: 0x000141A0
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

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x00015FB4 File Offset: 0x000141B4
		// (set) Token: 0x06000E05 RID: 3589 RVA: 0x00015FED File Offset: 0x000141ED
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

		// Token: 0x06000E06 RID: 3590 RVA: 0x00015FFB File Offset: 0x000141FB
		public void UnloadData(bool bAsync = false)
		{
			UAkAudioType.__UnloadData_Internal(base.NativePtr, bAsync);
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00016009 File Offset: 0x00014209
		public void LoadData()
		{
			UAkAudioType.__LoadData_Internal(base.NativePtr);
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00016016 File Offset: 0x00014216
		public int GetWwiseShortID()
		{
			return UAkAudioType.__GetWwiseShortID_Internal(base.NativePtr);
		}

		// Token: 0x06000E09 RID: 3593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnloadData_Internal(IntPtr @this, bool bAsync);

		// Token: 0x06000E0A RID: 3594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LoadData_Internal(IntPtr @this);

		// Token: 0x06000E0B RID: 3595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetWwiseShortID_Internal(IntPtr @this);

		// Token: 0x06000E0C RID: 3596 RVA: 0x00016023 File Offset: 0x00014223
		static UAkAudioType()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkAudioType");
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00016034 File Offset: 0x00014234
		protected UAkAudioType() : this(BuiltinUtils.AllocNativeUObject(UAkAudioType.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x0001605C File Offset: 0x0001425C
		protected UAkAudioType(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002AD RID: 685
		public new const string __ObjectPath = "/Script/AkAudio.AkAudioType";

		// Token: 0x040002AE RID: 686
		private static IntPtr _ClassPtr;

		// Token: 0x040002AF RID: 687
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040002B0 RID: 688
		internal static int __PropertyOffset_bAutoLoad;

		// Token: 0x040002B1 RID: 689
		internal static int __PropertyOffset_UserData;

		// Token: 0x040002B2 RID: 690
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _UserData;
	}
}
